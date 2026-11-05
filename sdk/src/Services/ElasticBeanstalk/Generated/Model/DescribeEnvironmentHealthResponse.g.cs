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
    /// This is the response object from the DescribeEnvironmentHealth operation.
    /// </summary>
    public partial class DescribeEnvironmentHealthResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationMetrics. 
        /// <para>
        /// Application request metrics for the environment.
        /// </para>
        /// </summary>
        public ApplicationMetrics ApplicationMetrics { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMetrics property is set.
        /// </summary>
        internal bool IsSetApplicationMetrics() => this.ApplicationMetrics != null;

        /// <summary>
        /// Gets and sets the property Causes. 
        /// <para>
        /// Descriptions of the data that contributed to the environment's current health status.
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
        /// The <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">health
        /// color</a> of the environment.
        /// </para>
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The environment's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">health
        /// status</a> of the environment. For example, <c>Ok</c>.
        /// </para>
        /// </summary>
        public string HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property InstancesHealth. 
        /// <para>
        /// Summary health information for the instances in the environment.
        /// </para>
        /// </summary>
        public InstanceHealthSummary InstancesHealth { get; set; }

        /// <summary>
        /// Checks to see if the InstancesHealth property is set.
        /// </summary>
        internal bool IsSetInstancesHealth() => this.InstancesHealth != null;

        /// <summary>
        /// Gets and sets the property RefreshedAt. 
        /// <para>
        /// The date and time that the health information was retrieved.
        /// </para>
        /// </summary>
        public DateTime? RefreshedAt { get; set; }

        /// <summary>
        /// Checks to see if the RefreshedAt property is set.
        /// </summary>
        internal bool IsSetRefreshedAt() => this.RefreshedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The environment's operational status. <c>Ready</c>, <c>Launching</c>, <c>Updating</c>,
        /// <c>Terminating</c>, or <c>Terminated</c>.
        /// </para>
        /// </summary>
        public EnvironmentHealth Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
