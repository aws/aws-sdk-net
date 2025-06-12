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
    /// Health details for an AWS Elastic Beanstalk environment.
    /// </summary>
    public partial class DescribeEnvironmentHealthResponse : AmazonWebServiceResponse
    {
        private ApplicationMetrics _applicationMetrics;
        private List<string> _causes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _color;
        private string _environmentName;
        private string _healthStatus;
        private InstanceHealthSummary _instancesHealth;
        private DateTime? _refreshedAt;
        private EnvironmentHealth _status;

        /// <summary>
        /// Gets and sets the property ApplicationMetrics. 
        /// <para>
        /// Application request metrics for the environment.
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
        /// Gets and sets the property Causes. 
        /// <para>
        /// Descriptions of the data that contributed to the environment's current health status.
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
        /// The <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">health
        /// color</a> of the environment.
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The environment's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
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
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">health
        /// status</a> of the environment. For example, <c>Ok</c>.
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
        /// Gets and sets the property InstancesHealth. 
        /// <para>
        /// Summary health information for the instances in the environment.
        /// </para>
        /// </summary>
        public InstanceHealthSummary InstancesHealth
        {
            get { return this._instancesHealth; }
            set { this._instancesHealth = value; }
        }

        // Check to see if InstancesHealth property is set
        internal bool IsSetInstancesHealth()
        {
            return this._instancesHealth != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshedAt. 
        /// <para>
        /// The date and time that the health information was retrieved.
        /// </para>
        /// </summary>
        public DateTime? RefreshedAt
        {
            get { return this._refreshedAt; }
            set { this._refreshedAt = value; }
        }

        // Check to see if RefreshedAt property is set
        internal bool IsSetRefreshedAt()
        {
            return this._refreshedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The environment's operational status. <c>Ready</c>, <c>Launching</c>, <c>Updating</c>,
        /// <c>Terminating</c>, or <c>Terminated</c>.
        /// </para>
        /// </summary>
        public EnvironmentHealth Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}