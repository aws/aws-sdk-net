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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
        private FunctionScalingConfig _appliedFunctionScalingConfig;
        private string _functionArn;
        private FunctionScalingConfig _requestedFunctionScalingConfig;

        /// <summary>
        /// Gets and sets the property AppliedFunctionScalingConfig. 
        /// <para>
        /// The scaling configuration that is currently applied to the function. This represents
        /// the actual scaling settings in effect.
        /// </para>
        /// </summary>
        public FunctionScalingConfig AppliedFunctionScalingConfig
        {
            get { return this._appliedFunctionScalingConfig; }
            set { this._appliedFunctionScalingConfig = value; }
        }

        // Check to see if AppliedFunctionScalingConfig property is set
        internal bool IsSetAppliedFunctionScalingConfig()
        {
            return this._appliedFunctionScalingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedFunctionScalingConfig. 
        /// <para>
        /// The scaling configuration that was requested for the function.
        /// </para>
        /// </summary>
        public FunctionScalingConfig RequestedFunctionScalingConfig
        {
            get { return this._requestedFunctionScalingConfig; }
            set { this._requestedFunctionScalingConfig = value; }
        }

        // Check to see if RequestedFunctionScalingConfig property is set
        internal bool IsSetRequestedFunctionScalingConfig()
        {
            return this._requestedFunctionScalingConfig != null;
        }

    }
}