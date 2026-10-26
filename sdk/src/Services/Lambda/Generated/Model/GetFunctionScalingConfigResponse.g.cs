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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the GetFunctionScalingConfig operation.
    /// </summary>
    public partial class GetFunctionScalingConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AppliedFunctionScalingConfig. 
        /// <para>
        /// The scaling configuration that is currently applied to the function. This represents
        /// the actual scaling settings in effect.
        /// </para>
        /// </summary>
        public FunctionScalingConfig AppliedFunctionScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the AppliedFunctionScalingConfig property is set.
        /// </summary>
        internal bool IsSetAppliedFunctionScalingConfig() => this.AppliedFunctionScalingConfig != null;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property RequestedFunctionScalingConfig. 
        /// <para>
        /// The scaling configuration that was requested for the function.
        /// </para>
        /// </summary>
        public FunctionScalingConfig RequestedFunctionScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the RequestedFunctionScalingConfig property is set.
        /// </summary>
        internal bool IsSetRequestedFunctionScalingConfig() => this.RequestedFunctionScalingConfig != null;
    }
}
