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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Represents health information from the specified instance that belongs to the AWS
    /// Elastic Beanstalk environment. Use the <code>InstanceId</code> property to specify
    /// the application instance for which you'd like to return data.
    /// </summary>
    public partial class SingleInstanceHealth
    {
        private ApplicationMetrics _applicationMetrics;
        private List<string> _causes = new List<string>();
        private string _color;
        private string _healthStatus;
        private string _instanceId;
        private DateTime? _launchedAt;
        private SystemStatus _system;

        /// <summary>
        /// Gets and sets the property ApplicationMetrics.
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
        /// Represents the causes, which provide more information about the current health status.
        /// </para>
        /// </summary>
        public List<string> Causes
        {
            get { return this._causes; }
            set { this._causes = value; }
        }

        // Check to see if Causes property is set
        internal bool IsSetCauses()
        {
            return this._causes != null && this._causes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// Represents the color indicator that gives you information about the health of the
        /// EC2 instance. For more information, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">Health
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
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Returns the health status of the specified instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html"></a>.
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
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// The time at which the EC2 instance was launched.
        /// </para>
        /// </summary>
        public DateTime LaunchedAt
        {
            get { return this._launchedAt.GetValueOrDefault(); }
            set { this._launchedAt = value; }
        }

        // Check to see if LaunchedAt property is set
        internal bool IsSetLaunchedAt()
        {
            return this._launchedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property System.
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