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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for an interceptor on a gateway. This structure defines settings
    /// for an interceptor that will be invoked during the invocation of the gateway.
    /// </summary>
    public partial class GatewayInterceptorConfiguration
    {
        private InterceptorInputConfiguration _inputConfiguration;
        private List<string> _interceptionPoints = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InterceptorConfiguration _interceptor;

        /// <summary>
        /// Gets and sets the property InputConfiguration. 
        /// <para>
        /// The configuration for the input of the interceptor. This field specifies how the input
        /// to the interceptor is constructed
        /// </para>
        /// </summary>
        public InterceptorInputConfiguration InputConfiguration
        {
            get { return this._inputConfiguration; }
            set { this._inputConfiguration = value; }
        }

        // Check to see if InputConfiguration property is set
        internal bool IsSetInputConfiguration()
        {
            return this._inputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InterceptionPoints. 
        /// <para>
        /// The supported points of interception. This field specifies which points during the
        /// gateway invocation to invoke the interceptor
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> InterceptionPoints
        {
            get { return this._interceptionPoints; }
            set { this._interceptionPoints = value; }
        }

        // Check to see if InterceptionPoints property is set
        internal bool IsSetInterceptionPoints()
        {
            return this._interceptionPoints != null && (this._interceptionPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Interceptor. 
        /// <para>
        /// The infrastructure settings of an interceptor configuration. This structure defines
        /// how the interceptor can be invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InterceptorConfiguration Interceptor
        {
            get { return this._interceptor; }
            set { this._interceptor = value; }
        }

        // Check to see if Interceptor property is set
        internal bool IsSetInterceptor()
        {
            return this._interceptor != null;
        }

    }
}