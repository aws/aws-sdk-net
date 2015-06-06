using System;
using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager
{

    public class DatasetUpdates
    {
        private string _datasetName;
        private List<Record> _records;
        private long _syncCount;
        private string _syncSessionToken;
        private bool _exists;
        private bool _deleted;
        private List<string> _mergedDatasetNameList;

        public string DatasetName
        {
            get
            {
                return this._datasetName;
            }
        }

        public bool Deleted
        {
            get
            {
                return this._deleted;
            }
        }

        public bool Exists
        {
            get
            {
                return this._exists;
            }
        }

        public List<string> MergedDatasetNameList
        {
            get
            {
                return _mergedDatasetNameList;
            }
        }


        public List<Record> Records
        {
            get
            {
                return this._records;
            }
        }

        public long SyncCount
        {
            get
            {
                return this._syncCount;
            }
        }

        public string SyncSessionToken
        {
            get
            {
                return this._syncSessionToken;
            }
        }

        public DatasetUpdates(string datasetName, List<Record> records, long syncCount, string syncSessionToken,
                                  bool exists, bool deleted, List<string> mergedDatasetNameList)
        {
            this._datasetName = datasetName;
            this._records = records;
            this._syncCount = syncCount;
            this._syncSessionToken = syncSessionToken;
            this._exists = exists;
            this._deleted = deleted;
            this._mergedDatasetNameList = mergedDatasetNameList;
        }
    }
}
