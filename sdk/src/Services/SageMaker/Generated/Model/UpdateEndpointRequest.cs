/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEndpoint operation.
    /// Deploys the new <code>EndpointConfig</code> specified in the request, switches to
    /// using newly created endpoint, and then deletes resources provisioned for the endpoint
    /// using the previous <code>EndpointConfig</code> (there is no availability loss). 
    /// 
    ///  
    /// <para>
    /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Updating</code>.
    /// After updating the endpoint, it sets the status to <code>InService</code>. To check
    /// the status of an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
    /// API. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You cannot update an endpoint with the current <code>EndpointConfig</code>. To update
    /// an endpoint, you must create a new <code>EndpointConfig</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateEndpointRequest : AmazonSageMakerRequest
    {
        private string _endpointConfigName;
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the new endpoint configuration.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint whose configuration you want to update.
        /// </para>
        /// </summary>
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