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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Displays the properties of the Data Store, including the ID, Arn, name, and the status
    /// of the Data Store.
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
        private PreloadDataConfig _preloadDataConfig;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that a Data Store was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// The Amazon Resource Name used in the creation of the Data Store.
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
        /// The AWS endpoint for the Data Store. Each Data Store will have it's own endpoint with
        /// Data Store ID in the endpoint URL.
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
        /// The AWS-generated ID number for the Data Store.
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
        /// The user-generated name for the Data Store.
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
        /// The status of the Data Store. Possible statuses are 'CREATING', 'ACTIVE', 'DELETING',
        /// or 'DELETED'.
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
        /// The FHIR version. Only R4 version data is supported.
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
        /// Gets and sets the property PreloadDataConfig. 
        /// <para>
        /// The preloaded data configuration for the Data Store. Only data preloaded from Synthea
        /// is supported.
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

    }
}