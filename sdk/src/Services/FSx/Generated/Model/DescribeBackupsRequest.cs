/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeBackups operation.
    /// Returns the description of specific Amazon FSx for Windows File Server backups, if
    /// a <code>BackupIds</code> value is provided for that backup. Otherwise, it returns
    /// all backups owned by your AWS account in the AWS Region of the endpoint that you're
    /// calling.
    /// 
    ///  
    /// <para>
    /// When retrieving all backups, you can optionally specify the <code>MaxResults</code>
    /// parameter to limit the number of backups in a response. If more backups remain, Amazon
    /// FSx returns a <code>NextToken</code> value in the response. In this case, send a later
    /// request with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
    /// from the last response.
    /// </para>
    ///  
    /// <para>
    /// This action is used in an iterative process to retrieve a list of your backups. <code>DescribeBackups</code>
    /// is called first without a <code>NextToken</code>value. Then the action continues to
    /// be called with the <code>NextToken</code> parameter set to the value of the last <code>NextToken</code>
    /// value until a response has no <code>NextToken</code>.
    /// </para>
    ///  
    /// <para>
    /// When using this action, keep the following in mind:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
    /// while still including a <code>NextToken</code> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The order of backups returned in the response of one <code>DescribeBackups</code>
    /// call and the order of backups returned across the responses of a multi-call iteration
    /// is unspecified.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeBackupsRequest : AmazonFSxRequest
    {
        private List<string> _backupIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BackupIds. 
        /// <para>
        /// (Optional) IDs of the backups you want to retrieve (String). This overrides any filters.
        /// If any IDs are not found, BackupNotFound will be thrown.
        /// </para>
        /// </summary>
        public List<string> BackupIds
        {
            get { return this._backupIds; }
            set { this._backupIds = value; }
        }

        // Check to see if BackupIds property is set
        internal bool IsSetBackupIds()
        {
            return this._backupIds != null && this._backupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// (Optional) Filters structure. Supported names are file-system-id and backup-type.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) Maximum number of backups to return in the response (integer). This parameter
        /// value must be greater than 0. The number of items that Amazon FSx returns is the minimum
        /// of the <code>MaxResults</code> parameter specified in the request and the service's
        /// internal maximum number of items per page.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// (Optional) Opaque pagination token returned from a previous <code>DescribeBackups</code>
        /// operation (String). If a token present, the action continues the list from where the
        /// returning call left off.
        /// </para>
        /// </summary>
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