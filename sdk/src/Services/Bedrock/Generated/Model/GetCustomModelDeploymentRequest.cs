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
    /// Container for the parameters to the GetCustomModelDeployment operation.
    /// Retrieves information about a custom model deployment, including its status, configuration,
    /// and metadata. Use this operation to monitor the deployment status and retrieve details
    /// needed for inference requests.
    /// 
    ///  
    /// <para>
    /// The following actions are related to the <c>GetCustomModelDeployment</c> operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetCustomModelDeploymentRequest : AmazonBedrockRequest
    {
        private string _customModelDeploymentIdentifier;

        /// <summary>
        /// Gets and sets the property CustomModelDeploymentIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or name of the custom model deployment to retrieve
        /// information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=93)]
        public string CustomModelDeploymentIdentifier
        {
            get { return this._customModelDeploymentIdentifier; }
            set { this._customModelDeploymentIdentifier = value; }
        }

        // Check to see if CustomModelDeploymentIdentifier property is set
        internal bool IsSetCustomModelDeploymentIdentifier()
        {
            return this._customModelDeploymentIdentifier != null;
        }

    }
}