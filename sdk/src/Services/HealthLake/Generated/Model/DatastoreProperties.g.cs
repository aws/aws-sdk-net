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
    /// The data store properties.
    /// </summary>
    public partial class DatastoreProperties
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
        /// Gets and sets the property BackupStatusInfo. The backup status information for the
        /// data store.
        /// </summary>
        public DatastoreBackupStatus BackupStatusInfo { get; set; }

        /// <summary>
        /// Checks to see if the BackupStatusInfo property is set.
        /// </summary>
        internal bool IsSetBackupStatusInfo() => this.BackupStatusInfo != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the data store was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DatastoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used in the creation of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatastoreArn { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreArn property is set.
        /// </summary>
        internal bool IsSetDatastoreArn() => this.DatastoreArn != null;

        /// <summary>
        /// Gets and sets the property DatastoreEndpoint. 
        /// <para>
        /// The Amazon Web Services endpoint for the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string DatastoreEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreEndpoint property is set.
        /// </summary>
        internal bool IsSetDatastoreEndpoint() => this.DatastoreEndpoint != null;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string DatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreId property is set.
        /// </summary>
        internal bool IsSetDatastoreId() => this.DatastoreId != null;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The data store name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreName property is set.
        /// </summary>
        internal bool IsSetDatastoreName() => this.DatastoreName != null;

        /// <summary>
        /// Gets and sets the property DatastoreStatus. 
        /// <para>
        /// The data store status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatastoreStatus DatastoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreStatus property is set.
        /// </summary>
        internal bool IsSetDatastoreStatus() => this.DatastoreStatus != null;

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
        /// Gets and sets the property ErrorCause. 
        /// <para>
        /// The error cause for the current data store operation.
        /// </para>
        /// </summary>
        public ErrorCause ErrorCause { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCause property is set.
        /// </summary>
        internal bool IsSetErrorCause() => this.ErrorCause != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfiguration. 
        /// <para>
        /// The identity provider selected during data store creation.
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
        /// The preloaded Synthea data configuration for the data store.
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
        ///  The server-side encryption key configuration for a customer provided encryption key.
        /// </para>
        /// </summary>
        public SseConfiguration SseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SseConfiguration property is set.
        /// </summary>
        internal bool IsSetSseConfiguration() => this.SseConfiguration != null;
    }
}
