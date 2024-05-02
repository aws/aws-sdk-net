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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeBackups operation.
    /// Gets information about backups of AWS CloudHSM clusters.
    /// 
    ///  
    /// <para>
    /// This is a paginated operation, which means that each response might contain only a
    /// subset of all the backups. When the response contains only a subset of backups, it
    /// includes a <c>NextToken</c> value. Use this value in a subsequent <c>DescribeBackups</c>
    /// request to get more backups. When you receive a response with no <c>NextToken</c>
    /// (or an empty or null value), that means there are no more backups to get.
    /// </para>
    /// </summary>
    public partial class DescribeBackupsRequest : AmazonCloudHSMV2Request
    {
        private Dictionary<string, List<string>> _filters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private int? _maxResults;
        private string _nextToken;
        private bool? _sortAscending;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters to limit the items returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>backupIds</c> filter to return only the specified backups. Specify backups
        /// by their backup identifier (ID).
        /// </para>
        ///  
        /// <para>
        /// Use the <c>sourceBackupIds</c> filter to return only the backups created from a source
        /// backup. The <c>sourceBackupID</c> of a source backup is returned by the <a>CopyBackupToRegion</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>clusterIds</c> filter to return only the backups for the specified clusters.
        /// Specify clusters by their cluster identifier (ID).
        /// </para>
        ///  
        /// <para>
        /// Use the <c>states</c> filter to return only backups that match the specified state.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>neverExpires</c> filter to return backups filtered by the value in the
        /// <c>neverExpires</c> parameter. <c>True</c> returns all backups exempt from the backup
        /// retention policy. <c>False</c> returns all backups with a backup retention policy
        /// defined at the cluster.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Filters
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
        /// The maximum number of backups to return in the response. When there are more backups
        /// than the number you specify, the response contains a <c>NextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The <c>NextToken</c> value that you received in the previous response. Use this value
        /// to get more backups.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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

        /// <summary>
        /// Gets and sets the property SortAscending. 
        /// <para>
        /// Designates whether or not to sort the return backups by ascending chronological order
        /// of generation.
        /// </para>
        /// </summary>
        public bool? SortAscending
        {
            get { return this._sortAscending; }
            set { this._sortAscending = value; }
        }

        // Check to see if SortAscending property is set
        internal bool IsSetSortAscending()
        {
            return this._sortAscending.HasValue; 
        }

    }
}