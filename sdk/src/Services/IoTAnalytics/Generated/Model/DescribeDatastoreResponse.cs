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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// This is the response object from the DescribeDatastore operation.
    /// </summary>
    public partial class DescribeDatastoreResponse : AmazonWebServiceResponse
    {
        private Datastore _datastore;
        private DatastoreStatistics _statistics;

        /// <summary>
        /// Gets and sets the property Datastore. 
        /// <para>
        /// Information about the data store.
        /// </para>
        /// </summary>
        public Datastore Datastore
        {
            get { return this._datastore; }
            set { this._datastore = value; }
        }

        // Check to see if Datastore property is set
        internal bool IsSetDatastore()
        {
            return this._datastore != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Additional statistical information about the data store. Included if the <c>includeStatistics</c>
        /// parameter is set to <c>true</c> in the request.
        /// </para>
        /// </summary>
        public DatastoreStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

    }
}