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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
    /// Information about the target to be updated by an CloudFormation blue/green deployment.
    /// This target type is used for all deployments initiated by a CloudFormation stack update.
    /// </summary>
    public partial class CloudFormationTarget
    {
        private string _deploymentId;
        private DateTime? _lastUpdatedAt;
        private List<LifecycleEvent> _lifecycleEvents = AWSConfigs.InitializeCollections ? new List<LifecycleEvent>() : null;
        private string _resourceType;
        private TargetStatus _status;
        private string _targetId;
        private double? _targetVersionWeight;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The unique ID of an CloudFormation blue/green deployment.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  The date and time when the target application was updated by an CloudFormation blue/green
        /// deployment. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleEvents. 
        /// <para>
        ///  The lifecycle events of the CloudFormation blue/green deployment to this target application.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleEvent> LifecycleEvents
        {
            get { return this._lifecycleEvents; }
            set { this._lifecycleEvents = value; }
        }

        // Check to see if LifecycleEvents property is set
        internal bool IsSetLifecycleEvents()
        {
            return this._lifecycleEvents != null && (this._lifecycleEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type for the CloudFormation blue/green deployment.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of an CloudFormation blue/green deployment's target application. 
        /// </para>
        /// </summary>
        public TargetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        ///  The unique ID of a deployment target that has a type of <c>CloudFormationTarget</c>.
        /// 
        /// </para>
        /// </summary>
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersionWeight. 
        /// <para>
        /// The percentage of production traffic that the target version of an CloudFormation
        /// blue/green deployment receives.
        /// </para>
        /// </summary>
        public double? TargetVersionWeight
        {
            get { return this._targetVersionWeight; }
            set { this._targetVersionWeight = value; }
        }

        // Check to see if TargetVersionWeight property is set
        internal bool IsSetTargetVersionWeight()
        {
            return this._targetVersionWeight.HasValue; 
        }

    }
}