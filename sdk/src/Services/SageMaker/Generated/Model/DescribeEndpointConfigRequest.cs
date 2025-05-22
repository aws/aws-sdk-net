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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEndpointConfig operation.
    /// Returns the description of an endpoint configuration created using the <c>CreateEndpointConfig</c>
    /// API.
    /// </summary>
    public partial class DescribeEndpointConfigRequest : AmazonSageMakerRequest
    {
        private string _endpointConfigName;

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string EndpointConfigName
        {
            get { return this._endpointConfigName; }
            set { this._endpointConfigName = value; }
        }

        // Check to see if EndpointConfigName property is set
        internal bool IsSetEndpointConfigName()
        {
            return this._endpointConfigName != null;
        }

    }
}