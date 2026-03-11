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
    /// Container for the parameters to the PutFunctionScalingConfig operation.
    /// Sets the scaling configuration for a Lambda Managed Instances function. The scaling
    /// configuration defines the minimum and maximum number of execution environments that
    /// can be provisioned for the function, allowing you to control scaling behavior and
    /// resource allocation.
    /// </summary>
    public partial class PutFunctionScalingConfigRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private FunctionScalingConfig _functionScalingConfig;
        private string _qualifier;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionScalingConfig. 
        /// <para>
        /// The scaling configuration to apply to the function, including minimum and maximum
        /// execution environment limits.
        /// </para>
        /// </summary>
        public FunctionScalingConfig FunctionScalingConfig
        {
            get { return this._functionScalingConfig; }
            set { this._functionScalingConfig = value; }
        }

        // Check to see if FunctionScalingConfig property is set
        internal bool IsSetFunctionScalingConfig()
        {
            return this._functionScalingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Specify a version or alias to set the scaling configuration for a published version
        /// of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

    }
}