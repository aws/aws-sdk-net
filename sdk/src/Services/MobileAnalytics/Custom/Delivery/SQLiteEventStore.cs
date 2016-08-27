/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using Logger = Amazon.Runtime.Internal.Util.Logger;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Implementation of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
    /// The object stores Mobile Analytic events in SQLite database.
    /// </summary>
    [System.Security.SecuritySafeCritical]
    public partial class SQLiteEventStore : IEventStore
    {
        private Logger _logger = Logger.GetLogger(typeof(SQLiteEventStore));
        private const String TABLE_NAME = "ma_events";
        private const String EVENT_COLUMN_NAME = "ma_event";
        private const String EVENT_ID_COLUMN_NAME = "ma_event_id";
        private const String EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME = "ma_delivery_attempt_count";
        private const String MA_APP_ID_COLUMN_NAME = "ma_app_id";
        private const String TABLE_ROWID = "ROWID";
        private const String DB_SIZE_KEY = "MAX_DB_SIZE";
        private const String DB_WARNING_THRESHOLD_KEY = "DB_WARNING_THRESHOLD";
        private const String dbFileName = "mobile_analytic_event.db";

        // platform specific db file path
        private static object _lock = new object();
        private MobileAnalyticsManagerConfig _maConfig;

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore"/>
        /// </summary>
        /// <param name="maConfig">Mobile Analytics Manager Configuration.</param>
        public SQLiteEventStore(MobileAnalyticsManagerConfig maConfig)
        {
            _maConfig = maConfig;
            SetupSQLiteEventStore();
        }

        /// <summary>
        /// Get the SQLite Event Store's database file full path.
        /// </summary>
        /// <returns> The database file full path. </returns>
        public string DBfileFullPath
        {
            get;
            internal set;
        }


        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

