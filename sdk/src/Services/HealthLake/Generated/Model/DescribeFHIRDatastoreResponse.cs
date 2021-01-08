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
    /// This is the response object from the DescribeFHIRDatastore operation.
    /// </summary>
    public partial class DescribeFHIRDatastoreResponse : AmazonWebServiceResponse
    {
        private DatastoreProperties _datastoreProperties;

        /// <summary>
        /// Gets and sets the property DatastoreProperties. 
        /// <para>
        /// All properties associated with a Data Store, including the Data Store ID, Data Store
        /// ARN, Data Store name, Data Store status, created at, Data Store type version, and
        /// Data Store endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatastoreProperties DatastoreProperties
        {
            get { return this._datastoreProperties; }
            set { this._datastoreProperties = value; }
        }

        // Check to see if DatastoreProperties property is set
        internal bool IsSetDatastoreProperties()
        {
            return this._datastoreProperties != null;
        }

    }
}