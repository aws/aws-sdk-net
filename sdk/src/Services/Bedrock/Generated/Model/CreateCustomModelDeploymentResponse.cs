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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the CreateCustomModelDeployment operation.
    /// </summary>
    public partial class CreateCustomModelDeploymentResponse : AmazonWebServiceResponse
    {
        private string _customModelDeploymentArn;

        /// <summary>
        /// Gets and sets the property CustomModelDeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model deployment. Use this ARN as the
        /// <c>modelId</c> parameter when invoking the model with the <c>InvokeModel</c> or <c>Converse</c>
        /// operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string CustomModelDeploymentArn
        {
            get { return this._customModelDeploymentArn; }
            set { this._customModelDeploymentArn = value; }
        }

        // Check to see if CustomModelDeploymentArn property is set
        internal bool IsSetCustomModelDeploymentArn()
        {
            return this._customModelDeploymentArn != null;
        }

    }
}