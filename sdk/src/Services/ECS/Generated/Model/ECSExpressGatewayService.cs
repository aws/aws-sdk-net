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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Represents an Express service, which provides a simplified way to deploy containerized
    /// web applications on Amazon ECS with managed Amazon Web Services infrastructure. An
    /// Express service automatically provisions and manages Application Load Balancers, target
    /// groups, security groups, and auto-scaling policies.
    /// 
    ///  
    /// <para>
    /// Express services use a service revision architecture where each service can have multiple
    /// active configurations, enabling blue-green deployments and gradual rollouts. The service
    /// maintains a list of active configurations and manages the lifecycle of the underlying
    /// Amazon Web Services resources.
    /// </para>
    /// </summary>
    public partial class ECSExpressGatewayService
    {
        private List<ExpressGatewayServiceConfiguration> _activeConfigurations = AWSConfigs.InitializeCollections ? new List<ExpressGatewayServiceConfiguration>() : null;
        private string _cluster;
        private DateTime? _createdAt;
        private string _currentDeployment;
        private string _infrastructureRoleArn;
        private string _serviceArn;
        private string _serviceName;
        private ExpressGatewayServiceStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ActiveConfigurations. 
        /// <para>
        /// The list of active service configurations for the Express service.
        /// </para>
        /// </summary>
        public List<ExpressGatewayServiceConfiguration> ActiveConfigurations
        {
            get { return this._activeConfigurations; }
            set { this._activeConfigurations = value; }
        }

        // Check to see if ActiveConfigurations property is set
        internal bool IsSetActiveConfigurations()
        {
            return this._activeConfigurations != null && (this._activeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full ARN of the cluster that hosts the Express service.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for when the Express service was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentDeployment. 
        /// <para>
        /// The current deployment configuration for the Express service.
        /// </para>
        /// </summary>
        public string CurrentDeployment
        {
            get { return this._currentDeployment; }
            set { this._currentDeployment = value; }
        }

        // Check to see if CurrentDeployment property is set
        internal bool IsSetCurrentDeployment()
        {
            return this._currentDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The ARN of the infrastructure role that manages Amazon Web Services resources for
        /// the Express service.
        /// </para>
        /// </summary>
        public string InfrastructureRoleArn
        {
            get { return this._infrastructureRoleArn; }
            set { this._infrastructureRoleArn = value; }
        }

        // Check to see if InfrastructureRoleArn property is set
        internal bool IsSetInfrastructureRoleArn()
        {
            return this._infrastructureRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN that identifies the Express service.
        /// </para>
        /// </summary>
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Express service.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Express service.
        /// </para>
        /// </summary>
        public ExpressGatewayServiceStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata applied to the Express service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for when the Express service was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}