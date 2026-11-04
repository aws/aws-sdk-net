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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Detailed health information about an Amazon EC2 instance in your Elastic Beanstalk
    /// environment.
    /// </summary>
    public partial class SingleInstanceHealth
    {
        /// <summary>
        /// Gets and sets the property ApplicationMetrics. 
        /// <para>
        /// Request metrics from your application.
        /// </para>
        /// </summary>
        public ApplicationMetrics ApplicationMetrics { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMetrics property is set.
        /// </summary>
        internal bool IsSetApplicationMetrics() => this.ApplicationMetrics != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone in which the instance runs.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Causes. 
        /// <para>
        /// Represents the causes, which provide more information about the current health status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Causes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Causes property is set.
        /// </summary>
        internal bool IsSetCauses() => this.Causes != null && (this.Causes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// Represents the color indicator that gives you information about the health of the
        /// EC2 instance. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">Health
        /// Colors and Statuses</a>.
        /// </para>
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property Deployment. 
        /// <para>
        /// Information about the most recent deployment to an instance.
        /// </para>
        /// </summary>
        public Deployment Deployment { get; set; }

        /// <summary>
        /// Checks to see if the Deployment property is set.
        /// </summary>
        internal bool IsSetDeployment() => this.Deployment != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Returns the health status of the specified instance. For more information, see <a
        /// href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">Health
        /// Colors and Statuses</a>.
        /// </para>
        /// </summary>
        public string HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance's type.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// The time at which the EC2 instance was launched.
        /// </para>
        /// </summary>
        public DateTime? LaunchedAt { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedAt property is set.
        /// </summary>
        internal bool IsSetLaunchedAt() => this.LaunchedAt.HasValue;

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// Operating system metrics from the instance.
        /// </para>
        /// </summary>
        public SystemStatus System { get; set; }

        /// <summary>
        /// Checks to see if the System property is set.
        /// </summary>
        internal bool IsSetSystem() => this.System != null;
    }
}
