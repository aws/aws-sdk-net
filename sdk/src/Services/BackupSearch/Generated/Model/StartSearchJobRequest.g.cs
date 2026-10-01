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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the StartSearchJob operation. This operation creates
    /// a search job which returns recovery points filtered by SearchScope and items filtered
    /// by ItemFilters. <para> You can optionally include ClientToken, EncryptionKeyArn, Name,
    /// and/or Tags. </para>
    /// </summary>
    public partial class StartSearchJobRequest : AmazonBackupSearchRequest
    {
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
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The encryption key for the specified search job.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

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
        public ItemFilters ItemFilters { get; set; }

        /// <summary>
        /// Checks to see if the ItemFilters property is set.
        /// </summary>
        internal bool IsSetItemFilters() => this.ItemFilters != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Include alphanumeric characters to create a name for this search job.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SearchScope. 
        /// <para>
        /// This object can contain BackupResourceTypes, BackupResourceArns, BackupResourceCreationTime,
        /// BackupResourceTags, and SourceResourceArns to filter the recovery points returned
        /// by the search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchScope SearchScope { get; set; }

        /// <summary>
        /// Checks to see if the SearchScope property is set.
        /// </summary>
        internal bool IsSetSearchScope() => this.SearchScope != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags returned by the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
