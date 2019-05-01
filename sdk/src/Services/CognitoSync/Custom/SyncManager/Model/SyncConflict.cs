//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//

using System;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// A model which stores conflicting record from the remote storage and the local storage.
    /// </summary>
    public class SyncConflict
    {
        private readonly string _key;
        private readonly Record _remoteRecord;
        private readonly Record _localRecord;

        /// <summary>
        /// The record Key
        /// </summary>
        public string Key
        {
            get { return this._key; }
        }

        /// <summary>
        /// Return the record which is present on the server
        /// </summary>
        public Record RemoteRecord
        {
            get { return this._remoteRecord; }
        }

        /// <summary>
        /// Return the record which is present locally on the device
        /// </summary>
        public Record LocalRecord
        {
            get { return this._localRecord; }
        }

        /// <summary>
        /// Constructs a SyncConflict object.
        /// </summary>
        /// <param name="remoteRecord">record from remote storage</param>
        /// <param name="localRecord">record from local storage</param>
        public SyncConflict(Record remoteRecord, Record localRecord)
        {
            if (remoteRecord == null || localRecord == null)
            {
                throw new ArgumentException("Record can't be null");
            }
            if (!remoteRecord.Key.Equals(localRecord.Key))
            {
                throw new ArgumentException("The keys of remote record and local record don't match");
            }
            this._key = remoteRecord.Key;
            this._remoteRecord = remoteRecord;
            this._localRecord = localRecord;
        }

        /// <summary>
        /// Resolves conflict with remote record
        /// </summary>
        /// <returns>Resolved record</returns>
        public Record ResolveWithRemoteRecord()
        {
            return new Record(
                this.Key,
                this.RemoteRecord.Value,
                this.RemoteRecord.SyncCount,
                this.RemoteRecord.LastModifiedDate,
                this.RemoteRecord.LastModifiedBy,
                this.RemoteRecord.DeviceLastModifiedDate,
                false
                );
        }

        /// <summary>
        /// Resolves conflict with local record
        /// </summary>
        /// <returns>Resolved record</returns>
        public Record ResolveWithLocalRecord()
        {
            return new Record(
                this.Key,
                this.LocalRecord.Value,
                this.RemoteRecord.SyncCount,
                this.LocalRecord.LastModifiedDate,
                this.LocalRecord.LastModifiedBy,
                this.LocalRecord.DeviceLastModifiedDate,
                true
                );
        }

        /// <summary>
        /// Resolves conflict with a new value.
        /// </summary>
        /// <returns>Resolved record.</returns>
        /// <param name="newValue">new value of the record</param>
        public Record ResolveWithValue(string newValue)
        {
            return new Record(
                this.Key,
                newValue,
                this.RemoteRecord.SyncCount,
                this.LocalRecord.LastModifiedDate,
                this.LocalRecord.LastModifiedBy,
                this.LocalRecord.DeviceLastModifiedDate,
                true
                );
        }
    }
}

