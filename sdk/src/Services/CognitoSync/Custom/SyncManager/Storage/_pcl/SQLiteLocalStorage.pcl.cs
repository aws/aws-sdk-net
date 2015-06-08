//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    public class SQLiteLocalStorage : ILocalStorage
    {
        internal void CreateDatasetHelper(string query, params object[] parameters)
        {

        }

        internal DatasetMetadata GetMetadataHelper(string identityId, string datasetName)
        {
            return null;
        }

        internal List<DatasetMetadata> GetDatasetMetadataHelper(string query, params string[] parameters)
        {
            return null;
        }

        internal Record GetRecordHelper(string query, params string[] parameters)
        {
            return null;
        }

        internal List<Record> GetRecordsHelper(string query, params string[] parameters)
        {
            return null;
        }

        internal long GetLastSyncCountHelper(string query, params string[] parameters)
        {
            return 0;
        }

        internal List<Record> GetModifiedRecordsHelper(string query, params object[] parameters)
        {
            return null;
        }

        internal void ExecuteMultipleHelper(List<Statement> staement)
        {
            //use sql transactions
        }

        internal void UpdateLastSyncCountHelper(string query , params object[] parameters)
        {

        }

        internal void UpdateLastModifiedTimestampHelper(string query, params object[] parameters)
        {

        }

        internal void UpdateAndClearRecord(string identityId, string datasetName, Record record)
        {
            lock (sqlite_lock)
            {
                try
                {
                    string updateAndClearQuery = RecordColumns.BuildQuery(
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                        RecordColumns.KEY + " = @whereKey "
                    );



                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);
                    stmt.BindText(3, record.Key);
                    bool recordsFound = false;

                    while (stmt.Read())
                    {
                        recordsFound = true;
                    }
                    stmt.FinalizeStm();

                    if (recordsFound)
                    {
                        stmt = db.Prepare(
                        RecordColumns.BuildUpdate(
                            new string[] {
                            RecordColumns.VALUE,
                            RecordColumns.SYNC_COUNT,
                            RecordColumns.MODIFIED
                        },
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                            RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                            RecordColumns.KEY + " = @whereKey "
                        ));
                        stmt.BindText(1, record.Value);
                        stmt.BindInt(2, record.SyncCount);
                        stmt.BindInt(3, record.IsModified ? 1 : 0);
                        stmt.BindText(4, identityId);
                        stmt.BindText(5, datasetName);
                        stmt.BindText(6, record.Key);
                        stmt.Step();
                    }
                    else
                    {
                        stmt = db.Prepare(RecordColumns.BuildInsert());
                        stmt.BindText(1, identityId);
                        stmt.BindText(2, datasetName);
                        stmt.BindText(3, record.Key);
                        stmt.BindText(4, record.Value);
                        stmt.BindInt(5, record.SyncCount);
                        stmt.BindDateTime(6, record.LastModifiedDate);
                        stmt.BindText(7, record.LastModifiedBy);
                        stmt.BindDateTime(8, record.DeviceLastModifiedDate);
                        stmt.BindInt(9, record.IsModified ? 1 : 0);
                        stmt.Step();
                    }
                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }
        }

        private Record SqliteStmtToRecord(SQLiteStatement stmt)
        {
            return new Record(stmt.Fields[RecordColumns.KEY].TEXT, stmt.Fields[RecordColumns.VALUE].TEXT,
                               stmt.Fields[RecordColumns.SYNC_COUNT].INTEGER, stmt.Fields[RecordColumns.LAST_MODIFIED_TIMESTAMP].DATETIME,
                               stmt.Fields[RecordColumns.LAST_MODIFIED_BY].TEXT, stmt.Fields[RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP].DATETIME,
                               (stmt.Fields[RecordColumns.MODIFIED].INTEGER == 1));
        }


    }
}

