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
    /// Container for the parameters to the CreateFHIRDatastore operation. Create a FHIR-enabled
    /// data store.
    /// </summary>
    public partial class CreateFHIRDatastoreRequest : AmazonHealthLakeRequest
    {
        /// <summary>
        /// Gets and sets the property AnalyticsConfiguration. 
        /// <para>
        /// The analytics configuration for the data store.
        /// </para>
        /// </summary>
        public AnalyticsConfiguration AnalyticsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnalyticsConfiguration property is set.
        /// </summary>
        internal bool IsSetAnalyticsConfiguration() => this.AnalyticsConfiguration != null;

        /// <summary>
        /// Gets and sets the property BackupConfiguration. The backup configuration for the data
        /// store.
        /// </summary>
        public BackupConfiguration BackupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BackupConfiguration property is set.
        /// </summary>
        internal bool IsSetBackupConfiguration() => this.BackupConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An optional user-provided token to ensure API idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The data store name (user-generated).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreName property is set.
        /// </summary>
        internal bool IsSetDatastoreName() => this.DatastoreName != null;

        /// <summary>
        /// Gets and sets the property DatastoreTypeVersion. 
        /// <para>
        /// The FHIR release version supported by the data store. Current support is for version
        /// <c>R4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FHIRVersion DatastoreTypeVersion { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreTypeVersion property is set.
        /// </summary>
        internal bool IsSetDatastoreTypeVersion() => this.DatastoreTypeVersion != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfiguration. 
        /// <para>
        /// The identity provider configuration to use for the data store.
        /// </para>
        /// </summary>
        public IdentityProviderConfiguration IdentityProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetIdentityProviderConfiguration() => this.IdentityProviderConfiguration != null;

        /// <summary>
        /// Gets and sets the property NlpConfiguration. 
        /// <para>
        /// The natural language processing (NLP) configuration for the data store.
        /// </para>
        /// </summary>
        public NlpConfiguration NlpConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NlpConfiguration property is set.
        /// </summary>
        internal bool IsSetNlpConfiguration() => this.NlpConfiguration != null;

        /// <summary>
        /// Gets and sets the property PreloadDataConfig. 
        /// <para>
        /// An optional parameter to preload (import) open source Synthea FHIR data upon creation
        /// of the data store.
        /// </para>
        /// </summary>
        public PreloadDataConfig PreloadDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the PreloadDataConfig property is set.
        /// </summary>
        internal bool IsSetPreloadDataConfig() => this.PreloadDataConfig != null;

        /// <summary>
        /// Gets and sets the property ProfileConfiguration. 
        /// <para>
        /// The profile configuration for the data store.
        /// </para>
        /// </summary>
        public ProfileConfiguration ProfileConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProfileConfiguration property is set.
        /// </summary>
        internal bool IsSetProfileConfiguration() => this.ProfileConfiguration != null;

        /// <summary>
        /// Gets and sets the property SseConfiguration. 
        /// <para>
        /// The server-side encryption key configuration for a customer-provided encryption key
        /// specified for creating a data store. 
        /// </para>
        /// </summary>
        public SseConfiguration SseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SseConfiguration property is set.
        /// </summary>
        internal bool IsSetSseConfiguration() => this.SseConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The resource tags applied to a data store when it is created.
        /// </para>
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
