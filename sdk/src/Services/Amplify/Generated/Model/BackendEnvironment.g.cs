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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the backend environment associated with a <c>Branch</c> of a Gen 1 Amplify
    /// app. Amplify Gen 1 applications are created using Amplify Studio or the Amplify command
    /// line interface (CLI).
    /// </summary>
    public partial class BackendEnvironment
    {
        /// <summary>
        /// Gets and sets the property BackendEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a backend environment that is part of an Amplify
        /// app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string BackendEnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the BackendEnvironmentArn property is set.
        /// </summary>
        internal bool IsSetBackendEnvironmentArn() => this.BackendEnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The creation date and time for a backend environment that is part of an Amplify app.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentArtifacts. 
        /// <para>
        /// The name of deployment artifacts. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DeploymentArtifacts { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentArtifacts property is set.
        /// </summary>
        internal bool IsSetDeploymentArtifacts() => this.DeploymentArtifacts != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name for a backend environment that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The AWS CloudFormation stack name of a backend environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The last updated date and time for a backend environment that is part of an Amplify
        /// app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
