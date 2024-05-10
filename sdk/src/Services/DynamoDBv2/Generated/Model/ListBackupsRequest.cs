/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the ListBackups operation.
    /// List DynamoDB backups that are associated with an Amazon Web Services account and
    /// weren't made with Amazon Web Services Backup. To list these backups for a given table,
    /// specify <c>TableName</c>. <c>ListBackups</c> returns a paginated list of results with
    /// at most 1 MB worth of items in a page. You can also specify a maximum number of entries
    /// to be returned in a page.
    /// 
    ///  
    /// <para>
    /// In the request, start time is inclusive, but end time is exclusive. Note that these
    /// boundaries are for the time at which the original backup was requested.
    /// </para>
    ///  
    /// <para>
    /// You can call <c>ListBackups</c> a maximum of five times per second.
    /// </para>
    ///  
    /// <para>
    /// If you want to retrieve the complete list of backups made with Amazon Web Services
    /// Backup, use the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_ListBackupJobs.html">Amazon
    /// Web Services Backup list API.</a> 
    /// </para>
    /// </summary>
    public partial class ListBackupsRequest : AmazonDynamoDBRequest
    {
        private BackupTypeFilter _backupType;
        private string _exclusiveStartBackupArn;
        private int? _limit;
        private string _tableName;
        private DateTime? _timeRangeLowerBound;
        private DateTime? _timeRangeUpperBound;

        /// <summary>
        /// Gets and sets the property BackupType. 
        /// <para>
        /// The backups from the table specified by <c>BackupType</c> are listed.
        /// </para>
        ///  
        /// <para>
        /// Where <c>BackupType</c> can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>USER</c> - On-demand backup created by you. (The default setting if no other backup
        /// types are specified.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SYSTEM</c> - On-demand backup automatically created by DynamoDB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - All types of on-demand backups (USER and SYSTEM).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BackupTypeFilter BackupType
        {
            get { return this._backupType; }
            set { this._backupType = value; }
        }

        // Check to see if BackupType property is set
        internal bool IsSetBackupType()
        {
            return this._backupType != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusiveStartBackupArn. 
        /// <para>
        ///  <c>LastEvaluatedBackupArn</c> is the Amazon Resource Name (ARN) of the backup last
        /// evaluated when the current page of results was returned, inclusive of the current
        /// page of results. This value may be specified as the <c>ExclusiveStartBackupArn</c>
        /// of a new <c>ListBackups</c> operation in order to fetch the next page of results.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=37, Max=1024)]
        public string ExclusiveStartBackupArn
        {
            get { return this._exclusiveStartBackupArn; }
            set { this._exclusiveStartBackupArn = value; }
        }

        // Check to see if ExclusiveStartBackupArn property is set
        internal bool IsSetExclusiveStartBackupArn()
        {
            return this._exclusiveStartBackupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of backups to return at once.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Lists the backups from the table specified in <c>TableName</c>. You can also provide
        /// the Amazon Resource Name (ARN) of the table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRangeLowerBound. 
        /// <para>
        /// Only backups created after this time are listed. <c>TimeRangeLowerBound</c> is inclusive.
        /// </para>
        /// </summary>
        public DateTime? TimeRangeLowerBound
        {
            get { return this._timeRangeLowerBound; }
            set { this._timeRangeLowerBound = value; }
        }

        // Check to see if TimeRangeLowerBound property is set
        internal bool IsSetTimeRangeLowerBound()
        {
            return this._timeRangeLowerBound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeRangeUpperBound. 
        /// <para>
        /// Only backups created before this time are listed. <c>TimeRangeUpperBound</c> is exclusive.
        /// 
        /// </para>
        /// </summary>
        public DateTime? TimeRangeUpperBound
        {
            get { return this._timeRangeUpperBound; }
            set { this._timeRangeUpperBound = value; }
        }

        // Check to see if TimeRangeUpperBound property is set
        internal bool IsSetTimeRangeUpperBound()
        {
            return this._timeRangeUpperBound.HasValue; 
        }

    }
}