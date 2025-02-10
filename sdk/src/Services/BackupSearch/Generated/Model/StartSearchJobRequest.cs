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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// Container for the parameters to the StartSearchJob operation.
    /// This operation creates a search job which returns recovery points filtered by SearchScope
    /// and items filtered by ItemFilters.
    /// 
    ///  
    /// <para>
    /// You can optionally include ClientToken, EncryptionKeyArn, Name, and/or Tags.
    /// </para>
    /// </summary>
    public partial class StartSearchJobRequest : AmazonBackupSearchRequest
    {
        private string _clientToken;
        private string _encryptionKeyArn;
        private ItemFilters _itemFilters;
        private string _name;
        private SearchScope _searchScope;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Include this parameter to allow multiple identical calls for idempotency.
        /// </para>
        ///  
        /// <para>
        /// A client token is valid for 8 hours after the first request that uses it is completed.
        /// After this time, any request with the same token is treated as a new request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The encryption key for the specified search job.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ItemFilters. 
        /// <para>
        /// Item Filters represent all input item properties specified when the search was created.
        /// </para>
        ///  
        /// <para>
        /// Contains either EBSItemFilters or S3ItemFilters
        /// </para>
        /// </summary>
        public ItemFilters ItemFilters
        {
            get { return this._itemFilters; }
            set { this._itemFilters = value; }
        }

        // Check to see if ItemFilters property is set
        internal bool IsSetItemFilters()
        {
            return this._itemFilters != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Include alphanumeric characters to create a name for this search job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SearchScope. 
        /// <para>
        /// This object can contain BackupResourceTypes, BackupResourceArns, BackupResourceCreationTime,
        /// BackupResourceTags, and SourceResourceArns to filter the recovery points returned
        /// by the search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchScope SearchScope
        {
            get { return this._searchScope; }
            set { this._searchScope = value; }
        }

        // Check to see if SearchScope property is set
        internal bool IsSetSearchScope()
        {
            return this._searchScope != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags returned by the operation.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}