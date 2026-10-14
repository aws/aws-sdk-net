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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreFHIRDatastore operation. Restore a backup-enabled
    /// data store to a point in time. Creates a new data store from the backup.
    /// </summary>
    public partial class RestoreFHIRDatastoreRequest : AmazonHealthLakeRequest
    {
        /// <summary>
        /// Gets and sets the property AnalyticsConfiguration. The analytics configuration for
        /// the restored data store.
        /// </summary>
        public AnalyticsConfiguration AnalyticsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnalyticsConfiguration property is set.
        /// </summary>
        internal bool IsSetAnalyticsConfiguration() => this.AnalyticsConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. An optional user-provided token to ensure
        /// API idempotency of the restore.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DatastoreName. The name for the restored data store.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreName property is set.
        /// </summary>
        internal bool IsSetDatastoreName() => this.DatastoreName != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfiguration. The identity provider configuration
        /// for the restored data store.
        /// </summary>
        public IdentityProviderConfiguration IdentityProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetIdentityProviderConfiguration() => this.IdentityProviderConfiguration != null;

        /// <summary>
        /// Gets and sets the property NlpConfiguration. The NLP configuration for the restored
        /// data store.
        /// </summary>
        public NlpConfiguration NlpConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NlpConfiguration property is set.
        /// </summary>
        internal bool IsSetNlpConfiguration() => this.NlpConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProfileConfiguration. The profile configuration for the
        /// restored data store.
        /// </summary>
        public ProfileConfiguration ProfileConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProfileConfiguration property is set.
        /// </summary>
        internal bool IsSetProfileConfiguration() => this.ProfileConfiguration != null;

        /// <summary>
        /// Gets and sets the property RestoreConfiguration. The restore configuration specifying
        /// the type and parameters for the restore.
        /// </summary>
        [AWSProperty(Required = true)]
        public RestoreConfiguration RestoreConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RestoreConfiguration property is set.
        /// </summary>
        internal bool IsSetRestoreConfiguration() => this.RestoreConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceDatastoreId. The identifier of the source data store
        /// to restore from.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string SourceDatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the SourceDatastoreId property is set.
        /// </summary>
        internal bool IsSetSourceDatastoreId() => this.SourceDatastoreId != null;

        /// <summary>
        /// Gets and sets the property SseConfiguration. The server-side encryption key configuration
        /// for the restored data store.
        /// </summary>
        public SseConfiguration SseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SseConfiguration property is set.
        /// </summary>
        internal bool IsSetSseConfiguration() => this.SseConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. The resource tags applied to the restored data store.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
