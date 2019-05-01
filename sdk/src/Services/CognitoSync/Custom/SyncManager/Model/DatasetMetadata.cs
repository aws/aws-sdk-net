//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//

using System;
using System.Globalization;
namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// Metadata information representing a dataset
    /// </summary>
    public sealed class DatasetMetadata
    {
        private string _datasetName;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedBy;
        private long _storageSizeBytes;
        private long _recordCount;

        /// <summary>
        /// Non empty String name of the dataset
        /// </summary>
        /// <value>The name of the dataset.</value>
        public string DatasetName
        {
            get { return this._datasetName; }
        }

        /// <summary>
        /// Date when the dataset is created
        /// </summary>
        /// <value>The creation date.</value>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
        }

        /// <summary>
        /// Date when the dataset is last modified
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
        }

        /// <summary>
        /// The device that made the last modification
        /// </summary>
        /// <value>The last modified by.</value>
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
        }

        /// <summary>
        /// The storage size in bytes of the dataset
        /// </summary>
        /// <value>The storage size bytes.</value>
        public long StorageSizeBytes
        {
            get { return this._storageSizeBytes; }
        }

        /// <summary>
        /// Number of records in the dataset
        /// </summary>
        /// <value>The record count.</value>
        public long RecordCount
        {
            get { return this._recordCount; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="creationDate"></param>
        /// <param name="lastModifiedDate"></param>
        /// <param name="lastModifiedBy"></param>
        /// <param name="storageSizeBytes"></param>
        /// <param name="recordCount"></param>
        public DatasetMetadata(string datasetName, DateTime? creationDate, DateTime? lastModifiedDate, string lastModifiedBy, long storageSizeBytes, long recordCount)
        {
            this._datasetName = datasetName;
            this._creationDate = creationDate;
            this._lastModifiedDate = lastModifiedDate;
            this._lastModifiedBy = lastModifiedBy;
            this._storageSizeBytes = storageSizeBytes;
            this._recordCount = recordCount;
        }


        /// <summary>
        /// A string representation of DatasetMetadata
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "DatasetName:[{0}], CreationDate:[{1}], LastModifiedDate:[{2}], LastModifiedBy:[{3}], StorageSizeBytes:[{4}], RecordCount:[{5}]",
                DatasetName, CreationDate, LastModifiedDate, LastModifiedBy, StorageSizeBytes, RecordCount);
        }
    }
}

