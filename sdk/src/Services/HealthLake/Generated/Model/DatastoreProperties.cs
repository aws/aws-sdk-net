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
    /// The data store properties.
    /// </summary>
    public partial class DatastoreProperties
    {
        private DateTime? _createdAt;
        private string _datastoreArn;
        private string _datastoreEndpoint;
        private string _datastoreId;
        private string _datastoreName;
        private DatastoreStatus _datastoreStatus;
        private FHIRVersion _datastoreTypeVersion;
        private ErrorCause _errorCause;
        private IdentityProviderConfiguration _identityProviderConfiguration;
        private PreloadDataConfig _preloadDataConfig;
        private SseConfiguration _sseConfiguration;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the data store was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatastoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used in the creation of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreArn
        {
            get { return this._datastoreArn; }
            set { this._datastoreArn = value; }
        }

        // Check to see if DatastoreArn property is set
        internal bool IsSetDatastoreArn()
        {
            return this._datastoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreEndpoint. 
        /// <para>
        /// The AWS endpoint for the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
        public string DatastoreEndpoint
        {
            get { return this._datastoreEndpoint; }
            set { this._datastoreEndpoint = value; }
        }

        // Check to see if DatastoreEndpoint property is set
        internal bool IsSetDatastoreEndpoint()
        {
            return this._datastoreEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The data store name.
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
        /// Gets and sets the property DatastoreStatus. 
        /// <para>
        /// The data store status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatastoreStatus DatastoreStatus
        {
            get { return this._datastoreStatus; }
            set { this._datastoreStatus = value; }
        }

        // Check to see if DatastoreStatus property is set
        internal bool IsSetDatastoreStatus()
        {
            return this._datastoreStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreTypeVersion. 
        /// <para>
        /// The FHIR release version supported by the data store. Current support is for version
        /// <c>R4</c>.
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
        /// Gets and sets the property ErrorCause. 
        /// <para>
        /// The error cause for the current data store operation.
        /// </para>
        /// </summary>
        public ErrorCause ErrorCause
        {
            get { return this._errorCause; }
            set { this._errorCause = value; }
        }

        // Check to see if ErrorCause property is set
        internal bool IsSetErrorCause()
        {
            return this._errorCause != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderConfiguration. 
        /// <para>
        /// The identity provider selected during data store creation.
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
        /// The preloaded Synthea data configuration for the data store.
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
        ///  The server-side encryption key configuration for a customer provided encryption key.
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

    }
}