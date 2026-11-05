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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for an interceptor on a gateway. This structure defines settings
    /// for an interceptor that will be invoked during the invocation of the gateway.
    /// </summary>
    public partial class GatewayInterceptorConfiguration
    {
        /// <summary>
        /// Gets and sets the property InputConfiguration. 
        /// <para>
        /// The configuration for the input of the interceptor. This field specifies how the input
        /// to the interceptor is constructed
        /// </para>
        /// </summary>
        public InterceptorInputConfiguration InputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputConfiguration property is set.
        /// </summary>
        internal bool IsSetInputConfiguration() => this.InputConfiguration != null;

        /// <summary>
        /// Gets and sets the property InterceptionPoints. 
        /// <para>
        /// The supported points of interception. This field specifies which points during the
        /// gateway invocation to invoke the interceptor
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<string> InterceptionPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InterceptionPoints property is set.
        /// </summary>
        internal bool IsSetInterceptionPoints() => this.InterceptionPoints != null && (this.InterceptionPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Interceptor. 
        /// <para>
        /// The infrastructure settings of an interceptor configuration. This structure defines
        /// how the interceptor can be invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InterceptorConfiguration Interceptor { get; set; }

        /// <summary>
        /// Checks to see if the Interceptor property is set.
        /// </summary>
        internal bool IsSetInterceptor() => this.Interceptor != null;
    }
}
