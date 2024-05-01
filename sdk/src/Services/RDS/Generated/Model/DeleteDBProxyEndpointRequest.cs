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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBProxyEndpoint operation.
    /// Deletes a <c>DBProxyEndpoint</c>. Doing so removes the ability to access the DB proxy
    /// using the endpoint that you defined. The endpoint that you delete might have provided
    /// capabilities such as read/write or read-only operations, or using a different VPC
    /// than the DB proxy's default VPC.
    /// </summary>
    public partial class DeleteDBProxyEndpointRequest : AmazonRDSRequest
    {
        private string _dbProxyEndpointName;

        /// <summary>
        /// Gets and sets the property DBProxyEndpointName. 
        /// <para>
        /// The name of the DB proxy endpoint to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DBProxyEndpointName
        {
            get { return this._dbProxyEndpointName; }
            set { this._dbProxyEndpointName = value; }
        }

        // Check to see if DBProxyEndpointName property is set
        internal bool IsSetDBProxyEndpointName()
        {
            return this._dbProxyEndpointName != null;
        }

    }
}