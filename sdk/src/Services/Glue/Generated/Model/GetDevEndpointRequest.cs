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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetDevEndpoint operation.
    /// Retrieves information about a specified development endpoint.
    /// 
    ///  <note> 
    /// <para>
    /// When you create a development endpoint in a virtual private cloud (VPC), AWS Glue
    /// returns only a private IP address, and the public IP address field is not populated.
    /// When you create a non-VPC development endpoint, AWS Glue returns only a public IP
    /// address.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDevEndpointRequest : AmazonGlueRequest
    {
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// Name of the <code>DevEndpoint</code> to retrieve information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

    }
}