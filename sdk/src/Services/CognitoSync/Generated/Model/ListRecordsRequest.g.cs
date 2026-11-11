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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecords operation. Gets paginated records,
    /// optionally changed after a particular sync count for a dataset and identity. With
    /// Amazon Cognito Sync, each identity has access only to its own data. Thus, the credentials
    /// used to make this API call need to have access to the identity data. <para> ListRecords
    /// can be called with temporary user credentials provided by Cognito Identity or with
    /// developer credentials. You should use Cognito Identity credentials to make this API
    /// call. </para>
    /// </summary>
    public partial class ListRecordsRequest : AmazonCognitoSyncRequest
    {
        /// <summary>
        /// Gets and sets the property DatasetName. A string of up to 128 characters. Allowed
        /// characters are a-z, A-Z, 0-9, '_' (underscore), '-' (dash), and '.' (dot).
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property IdentityId. A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE)
        /// created by Amazon Cognito. GUID generation is unique within a region.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityId property is set.
        /// </summary>
        internal bool IsSetIdentityId() => this.IdentityId != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE)
        /// created by Amazon Cognito. GUID generation is unique within a region.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property LastSyncCount. The last server sync count for this record.
        /// </summary>
        public long? LastSyncCount { get; set; }

        /// <summary>
        /// Checks to see if the LastSyncCount property is set.
        /// </summary>
        internal bool IsSetLastSyncCount() => this.LastSyncCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of results to be returned.
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. A pagination token for obtaining the next page
        /// of results.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SyncSessionToken. A token containing a session ID, identity
        /// ID, and expiration.
        /// </summary>
        public string SyncSessionToken { get; set; }

        /// <summary>
        /// Checks to see if the SyncSessionToken property is set.
        /// </summary>
        internal bool IsSetSyncSessionToken() => this.SyncSessionToken != null;
    }
}
