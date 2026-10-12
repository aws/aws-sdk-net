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
    /// This is the response object from the RestoreFHIRDatastore operation.
    /// </summary>
    public partial class RestoreFHIRDatastoreResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DatastoreArn. The Amazon Resource Name (ARN) for the restored
        /// data store.
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatastoreArn { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreArn property is set.
        /// </summary>
        internal bool IsSetDatastoreArn() => this.DatastoreArn != null;

        /// <summary>
        /// Gets and sets the property DatastoreEndpoint. The AWS endpoint for the restored data
        /// store.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5000)]
        public string DatastoreEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreEndpoint property is set.
        /// </summary>
        internal bool IsSetDatastoreEndpoint() => this.DatastoreEndpoint != null;

        /// <summary>
        /// Gets and sets the property DatastoreId. The restored data store identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string DatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreId property is set.
        /// </summary>
        internal bool IsSetDatastoreId() => this.DatastoreId != null;

        /// <summary>
        /// Gets and sets the property DatastoreStatus. The restored data store status.
        /// </summary>
        [AWSProperty(Required = true)]
        public DatastoreStatus DatastoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreStatus property is set.
        /// </summary>
        internal bool IsSetDatastoreStatus() => this.DatastoreStatus != null;
    }
}
