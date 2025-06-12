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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the last deployment of the environment.
    /// </summary>
    public partial class Deployment
    {
        private string _deploymentId;
        private DeploymentStatus _deploymentStatus;
        private DeploymentType _deploymentType;
        private EnvironmentError _failureReason;
        private bool? _isDeploymentComplete;
        private List<string> _messages = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the last deployment of the environment.
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The status of the last deployment of the environment.
        /// </para>
        /// </summary>
        public DeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The type of the last deployment of the environment.
        /// </para>
        /// </summary>
        public DeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason of the last deployment of the environment.
        /// </para>
        /// </summary>
        public EnvironmentError FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property IsDeploymentComplete. 
        /// <para>
        /// Specifies whether the last deployment of the environment is complete.
        /// </para>
        /// </summary>
        public bool? IsDeploymentComplete
        {
            get { return this._isDeploymentComplete; }
            set { this._isDeploymentComplete = value; }
        }

        // Check to see if IsDeploymentComplete property is set
        internal bool IsSetIsDeploymentComplete()
        {
            return this._isDeploymentComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The messages of the last deployment of the environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}