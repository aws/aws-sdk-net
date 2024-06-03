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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBackendEnvironment operation.
    /// Creates a new backend environment for an Amplify app. 
    /// 
    ///  
    /// <para>
    /// This API is available only to Amplify Gen 1 applications where the backend is created
    /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
    /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
    /// you provision the app's backend infrastructure using Typescript code.
    /// </para>
    /// </summary>
    public partial class CreateBackendEnvironmentRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private string _deploymentArtifacts;
        private string _environmentName;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentArtifacts. 
        /// <para>
        /// The name of deployment artifacts. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DeploymentArtifacts
        {
            get { return this._deploymentArtifacts; }
            set { this._deploymentArtifacts = value; }
        }

        // Check to see if DeploymentArtifacts property is set
        internal bool IsSetDeploymentArtifacts()
        {
            return this._deploymentArtifacts != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name for the backend environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The AWS CloudFormation stack name of a backend environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}