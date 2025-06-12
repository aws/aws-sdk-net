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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Detailed health information about an Amazon EC2 instance in your Elastic Beanstalk
    /// environment.
    /// </summary>
    public partial class SingleInstanceHealth
    {
        private ApplicationMetrics _applicationMetrics;
        private string _availabilityZone;
        private List<string> _causes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _color;
        private Deployment _deployment;
        private string _healthStatus;
        private string _instanceId;
        private string _instanceType;
        private DateTime? _launchedAt;
        private SystemStatus _system;

        /// <summary>
        /// Gets and sets the property ApplicationMetrics. 
        /// <para>
        /// Request metrics from your application.
        /// </para>
        /// </summary>
        public ApplicationMetrics ApplicationMetrics
        {
            get { return this._applicationMetrics; }
            set { this._applicationMetrics = value; }
        }

        // Check to see if ApplicationMetrics property is set
        internal bool IsSetApplicationMetrics()
        {
            return this._applicationMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone in which the instance runs.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Causes. 
        /// <para>
        /// Represents the causes, which provide more information about the current health status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Causes
        {
            get { return this._causes; }
            set { this._causes = value; }
        }

        // Check to see if Causes property is set
        internal bool IsSetCauses()
        {
            return this._causes != null && (this._causes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// Represents the color indicator that gives you information about the health of the
        /// EC2 instance. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">Health
        /// Colors and Statuses</a>.
        /// </para>
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null;
        }

        /// <summary>
        /// Gets and sets the property Deployment. 
        /// <para>
        /// Information about the most recent deployment to an instance.
        /// </para>
        /// </summary>
        public Deployment Deployment
        {
            get { return this._deployment; }
            set { this._deployment = value; }
        }

        // Check to see if Deployment property is set
        internal bool IsSetDeployment()
        {
            return this._deployment != null;
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Returns the health status of the specified instance. For more information, see <a
        /// href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">Health
        /// Colors and Statuses</a>.
        /// </para>
        /// </summary>
        public string HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance's type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// The time at which the EC2 instance was launched.
        /// </para>
        /// </summary>
        public DateTime? LaunchedAt
        {
            get { return this._launchedAt; }
            set { this._launchedAt = value; }
        }

        // Check to see if LaunchedAt property is set
        internal bool IsSetLaunchedAt()
        {
            return this._launchedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// Operating system metrics from the instance.
        /// </para>
        /// </summary>
        public SystemStatus System
        {
            get { return this._system; }
            set { this._system = value; }
        }

        // Check to see if System property is set
        internal bool IsSetSystem()
        {
            return this._system != null;
        }

    }
}