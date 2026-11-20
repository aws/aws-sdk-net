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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the PutOrganizationDataRetentionStorage operation.
    /// Creates or replaces the organization's retention storage record for a model provider.
    /// The organization is resolved from the authenticated caller's management context; the
    /// caller must be the organization's management account or a delegated administrator.
    /// Requires resolved organization-scope trusted access eligibility for a storage-capable
    /// program of the provider; otherwise returns ConflictException. Writes replace the whole
    /// record; the last write wins. <para> For <c>customer_managed</c> destinations, Amazon
    /// Bedrock validates the caller's and service's access to the bucket and key before saving
    /// the configuration. The bucket and key must be in the AWS Region where you register
    /// the configuration. Validation failures reject the write. </para>
    /// </summary>
    public partial class PutOrganizationDataRetentionStorageRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ModelProvider. 
        /// <para>
        /// The model provider whose retention storage configuration is addressed by this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataRetentionStorageModelProvider ModelProvider { get; set; }

        /// <summary>
        /// Checks to see if the ModelProvider property is set.
        /// </summary>
        internal bool IsSetModelProvider() => this.ModelProvider != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Destination bucket and key. Required when storageDestination is customer_managed;
        /// rejected with ValidationException when amazon_managed.
        /// </para>
        /// </summary>
        public DataRetentionStorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageDestination. 
        /// <para>
        /// Where retained data is delivered for this scope. customer_managed requires storageConfiguration;
        /// amazon_managed forbids it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataRetentionStorageDestination StorageDestination { get; set; }

        /// <summary>
        /// Checks to see if the StorageDestination property is set.
        /// </summary>
        internal bool IsSetStorageDestination() => this.StorageDestination != null;
    }
}
