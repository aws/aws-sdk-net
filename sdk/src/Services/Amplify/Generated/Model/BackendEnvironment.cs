/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Backend environment for an Amplify App.
    /// </summary>
    public partial class BackendEnvironment
    {
        private string _backendEnvironmentArn;
        private DateTime? _createTime;
        private string _deploymentArtifacts;
        private string _environmentName;
        private string _stackName;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property BackendEnvironmentArn. 
        /// <para>
        ///  Arn for a backend environment, part of an Amplify App. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string BackendEnvironmentArn
        {
            get { return this._backendEnvironmentArn; }
            set { this._backendEnvironmentArn = value; }
        }

        // Check to see if BackendEnvironmentArn property is set
        internal bool IsSetBackendEnvironmentArn()
        {
            return this._backendEnvironmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        ///  Creation date and time for a backend environment, part of an Amplify App. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentArtifacts. 
        /// <para>
        ///  Name of deployment artifacts. 
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
        ///  Name for a backend environment, part of an Amplify App. 
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
        ///  CloudFormation stack name of backend environment. 
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

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  Last updated date and time for a backend environment, part of an Amplify App. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}