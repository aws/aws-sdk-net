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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
    /// Container for the parameters to the CreateFHIRDatastore operation.
    /// Creates a data store that can ingest and export FHIR formatted data.
    /// </summary>
    public partial class CreateFHIRDatastoreRequest : AmazonHealthLakeRequest
    {
        private string _clientToken;
        private string _datastoreName;
        private FHIRVersion _datastoreTypeVersion;
        private IdentityProviderConfiguration _identityProviderConfiguration;
        private PreloadDataConfig _preloadDataConfig;
        private SseConfiguration _sseConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Optional user provided token used for ensuring idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The user generated name for the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DatastoreName
        {
            get { return this._datastoreName; }
            set { this._datastoreName = value; }
        }

        // Check to see if DatastoreName property is set
        internal bool IsSetDatastoreName()
        {
            return this._datastoreName != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreTypeVersion. 
        /// <para>
        /// The FHIR version of the data store. The only supported version is R4.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FHIRVersion DatastoreTypeVersion
        {
            get { return this._datastoreTypeVersion; }
            set { this._datastoreTypeVersion = value; }
        }

        // Check to see if DatastoreTypeVersion property is set
        internal bool IsSetDatastoreTypeVersion()
        {
            return this._datastoreTypeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderConfiguration. 
        /// <para>
        /// The configuration of the identity provider that you want to use for your data store.
        /// </para>
        /// </summary>
        public IdentityProviderConfiguration IdentityProviderConfiguration
        {
            get { return this._identityProviderConfiguration; }
            set { this._identityProviderConfiguration = value; }
        }

        // Check to see if IdentityProviderConfiguration property is set
        internal bool IsSetIdentityProviderConfiguration()
        {
            return this._identityProviderConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PreloadDataConfig. 
        /// <para>
        /// Optional parameter to preload data upon creation of the data store. Currently, the
        /// only supported preloaded data is synthetic data generated from Synthea.
        /// </para>
        /// </summary>
        public PreloadDataConfig PreloadDataConfig
        {
            get { return this._preloadDataConfig; }
            set { this._preloadDataConfig = value; }
        }

        // Check to see if PreloadDataConfig property is set
        internal bool IsSetPreloadDataConfig()
        {
            return this._preloadDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SseConfiguration. 
        /// <para>
        ///  The server-side encryption key configuration for a customer provided encryption key
        /// specified for creating a data store. 
        /// </para>
        /// </summary>
        public SseConfiguration SseConfiguration
        {
            get { return this._sseConfiguration; }
            set { this._sseConfiguration = value; }
        }

        // Check to see if SseConfiguration property is set
        internal bool IsSetSseConfiguration()
        {
            return this._sseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Resource tags that are applied to a data store when it is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
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