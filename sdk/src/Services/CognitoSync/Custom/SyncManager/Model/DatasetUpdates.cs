using System;
using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// A model class which stores a list of updated dataset. 
    /// </summary>
    public class DatasetUpdates
    {
        private string _datasetName;
        private List<Record> _records;
        private long _syncCount;
        private string _syncSessionToken;
        private bool _exists;
        private bool _deleted;
        private List<string> _mergedDatasetNameList;

        /// <summary>
        /// THe name representing the dataset.
        /// </summary>
        public string DatasetName
        {
            get
            {
                return this._datasetName;
            }
        }

        /// <summary>
        /// A flag which indicates if the dataset is deleted or not.
        /// </summary>
        public bool Deleted
        {
            get
            {
                return this._deleted;
            }
        }

        /// <summary>
        /// A flag indicating if the dataset exists.
        /// </summary>
        public bool Exists
        {
            get
            {
                return this._exists;
            }
        }

        /// <summary>
        /// A list of dataset names which are merged.
        /// </summary>
        public List<string> MergedDatasetNameList
        {
            get
            {
                return _mergedDatasetNameList;
            }
        }

        /// <summary>
        /// A list of records.
        /// </summary>
        public List<Record> Records
        {
            get
            {
                return this._records;
            }
        }

        /// <summary>
        /// The count of number of times the dataset is synchronized.
        /// </summary>
        public long SyncCount
        {
            get
            {
                return this._syncCount;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SyncSessionToken
        {
            get
            {
                return this._syncSessionToken;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="records"></param>
        /// <param name="syncCount"></param>
        /// <param name="syncSessionToken"></param>
        /// <param name="exists"></param>
        /// <param name="deleted"></param>
        /// <param name="mergedDatasetNameList"></param>
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
