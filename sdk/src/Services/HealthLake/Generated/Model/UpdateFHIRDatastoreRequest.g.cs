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
    /// Container for the parameters to the UpdateFHIRDatastore operation. Update the properties
    /// of a FHIR-enabled data store.
    /// </summary>
    public partial class UpdateFHIRDatastoreRequest : AmazonHealthLakeRequest
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
        /// Gets and sets the property IdentityProviderConfiguration. 
        /// <para>
        /// The identity provider configuration for the data store.
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
    }
}
