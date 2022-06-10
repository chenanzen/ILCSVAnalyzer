using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILCSVAnalyzer
{
    internal class CSVFIleAnalyzer
    {

        public bool OpenCSV(string csvfullfilepath)
        {
            var csvFileReader = new CSVFileReader(csvfullfilepath);
            try
            {
                var headers = csvFileReader.GetHeaders();

                while (!csvFileReader.EndOfData())
                {
                    var rowdata = csvFileReader.ReadLine();
                    

                    if (cache.Count == _config.BulkCopyBatchSize() || csvReader.EndOfData())
                    {
                        _log.Debug($"creating datatable for batch no '{batchNo}' for dataset '{dataset}'");
                        var tempDataTable = _customSQLCommandProvider.ConstructDTForBulkCopy(cache);
                        var conversionErrors = _customSQLCommandProvider.GetErrors();
                        if (conversionErrors.Any())
                        {
                            warnings.Add(new RWarning()
                            {
                                Message = $"WARNING: Conversion issue at batch no: {batchNo}.",
                                Childs = conversionErrors
                            });
                        }

                        // bulk send bulk copy
                        _log.Debug($"Uploading batch no '{batchNo}' for dataset '{dataset}'");
                        string err = _dataContext.BulkCopy(tempDataTable);
                        if (!string.IsNullOrWhiteSpace(err))
                        {
                            warnings.Add(new RWarning()
                            {
                                Message = $"EXCEPTION on BULKCOPY at batch no: '{batchNo}'.",
                                IsCritical = true,
                                Childs = new List<RWarning>()
                                    {
                                        new RWarning(err)
                                    }
                            });
                            break;
                        }
                        _log.Debug($"Completed Uploading batch no '{batchNo}' for dataset '{dataset}'");
                        cache.Clear();

                        batchNo++;
                    }
                }
            }
            catch (Exception ex)
            {


                return false;
            }
        }
    }
}
