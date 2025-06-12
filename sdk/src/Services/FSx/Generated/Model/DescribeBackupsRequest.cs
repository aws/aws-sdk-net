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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeBackups operation.
    /// Returns the description of a specific Amazon FSx backup, if a <c>BackupIds</c> value
    /// is provided for that backup. Otherwise, it returns all backups owned by your Amazon
    /// Web Services account in the Amazon Web Services Region of the endpoint that you're
    /// calling.
    /// 
    ///  
    /// <para>
    /// When retrieving all backups, you can optionally specify the <c>MaxResults</c> parameter
    /// to limit the number of backups in a response. If more backups remain, Amazon FSx returns
    /// a <c>NextToken</c> value in the response. In this case, send a later request with
    /// the <c>NextToken</c> request parameter set to the value of the <c>NextToken</c> value
    /// from the last response.
    /// </para>
    ///  
    /// <para>
    /// This operation is used in an iterative process to retrieve a list of your backups.
    /// <c>DescribeBackups</c> is called first without a <c>NextToken</c> value. Then the
    /// operation continues to be called with the <c>NextToken</c> parameter set to the value
    /// of the last <c>NextToken</c> value until a response has no <c>NextToken</c> value.
    /// </para>
    ///  
    /// <para>
    /// When using this operation, keep the following in mind:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The operation might return fewer than the <c>MaxResults</c> value of backup descriptions
    /// while still including a <c>NextToken</c> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The order of the backups returned in the response of one <c>DescribeBackups</c> call
    /// and the order of the backups returned across the responses of a multi-call iteration
    /// is unspecified.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeBackupsRequest : AmazonFSxRequest
    {
        private List<string> _backupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BackupIds. 
        /// <para>
        /// The IDs of the backups that you want to retrieve. This parameter value overrides any
        /// filters. If any IDs aren't found, a <c>BackupNotFound</c> error occurs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> BackupIds
        {
            get { return this._backupIds; }
            set { this._backupIds = value; }
        }

        // Check to see if BackupIds property is set
        internal bool IsSetBackupIds()
        {
            return this._backupIds != null && (this._backupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters structure. The supported names are <c>file-system-id</c>, <c>backup-type</c>,
        /// <c>file-system-type</c>, and <c>volume-id</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of backups to return in the response. This parameter value must be
        /// greater than 0. The number of items that Amazon FSx returns is the minimum of the
        /// <c>MaxResults</c> parameter specified in the request and the service's internal maximum
        /// number of items per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token returned from a previous <c>DescribeBackups</c> operation.
        /// If a token is present, the operation continues the list from where the returning call
        /// left off.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}