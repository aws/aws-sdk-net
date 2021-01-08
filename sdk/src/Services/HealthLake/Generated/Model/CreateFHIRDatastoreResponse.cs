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
    /// This is the response object from the CreateFHIRDatastore operation.
    /// </summary>
    public partial class CreateFHIRDatastoreResponse : AmazonWebServiceResponse
    {
        private string _datastoreArn;
        private string _datastoreEndpoint;
        private string _datastoreId;
        private DatastoreStatus _datastoreStatus;

        /// <summary>
        /// Gets and sets the property DatastoreArn. 
        /// <para>
        /// The datastore ARN is generated during the creation of the Data Store and can be found
        /// in the output from the initial Data Store creation call.
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
        /// The AWS endpoint for the created Data Store. For preview, only US-east-1 endpoints
        /// are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5000)]
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
        /// The AWS-generated Data Store id. This id is in the output from the initial Data Store
        /// creation call.
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
        /// Gets and sets the property DatastoreStatus. 
        /// <para>
        /// The status of the FHIR Data Store. Possible statuses are ‘CREATING’, ‘ACTIVE’, ‘DELETING’,
        /// ‘DELETED’.
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

    }
}