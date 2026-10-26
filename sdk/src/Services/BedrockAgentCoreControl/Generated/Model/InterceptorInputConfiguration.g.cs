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
    /// The input configuration of the interceptor.
    /// </summary>
    public partial class InterceptorInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property PassRequestHeaders. 
        /// <para>
        /// Indicates whether to pass request headers as input into the interceptor. When set
        /// to true, request headers will be passed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? PassRequestHeaders { get; set; }

        /// <summary>
        /// Checks to see if the PassRequestHeaders property is set.
        /// </summary>
        internal bool IsSetPassRequestHeaders() => this.PassRequestHeaders.HasValue;

        /// <summary>
        /// Gets and sets the property PayloadFilter. 
        /// <para>
        /// The filter that determines which parts of the request or response payload are passed
        /// as input to the interceptor.
        /// </para>
        /// </summary>
        public InterceptorPayloadFilter PayloadFilter { get; set; }

        /// <summary>
        /// Checks to see if the PayloadFilter property is set.
        /// </summary>
        internal bool IsSetPayloadFilter() => this.PayloadFilter != null;
    }
}
