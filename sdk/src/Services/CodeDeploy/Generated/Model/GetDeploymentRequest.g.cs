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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the GetDeployment operation. Gets information about
    /// a deployment. <note> <para> The <c>content</c> property of the <c>appSpecContent</c>
    /// object in the returned revision is always null. Use <c>GetApplicationRevision</c>
    /// and the <c>sha256</c> property of the returned <c>appSpecContent</c> object to get
    /// the content of the deployment’s AppSpec file. </para> </note>
    /// </summary>
    public partial class GetDeploymentRequest : AmazonCodeDeployRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment associated with the user or Amazon Web Services account.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;
    }
}
