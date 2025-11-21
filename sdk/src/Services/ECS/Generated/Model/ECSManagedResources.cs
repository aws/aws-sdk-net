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
    /// Represents the Amazon Web Services resources managed by Amazon ECS for an Express
    /// service, including ingress paths, auto-scaling policies, metric alarms, and security
    /// groups.
    /// </summary>
    public partial class ECSManagedResources
    {
        private ManagedAutoScaling _autoScaling;
        private List<ManagedIngressPath> _ingressPaths = AWSConfigs.InitializeCollections ? new List<ManagedIngressPath>() : null;
        private List<ManagedLogGroup> _logGroups = AWSConfigs.InitializeCollections ? new List<ManagedLogGroup>() : null;
        private List<ManagedMetricAlarm> _metricAlarms = AWSConfigs.InitializeCollections ? new List<ManagedMetricAlarm>() : null;
        private List<ManagedSecurityGroup> _serviceSecurityGroups = AWSConfigs.InitializeCollections ? new List<ManagedSecurityGroup>() : null;

        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// The auto-scaling configuration and policies for the Express service.
        /// </para>
        /// </summary>
        public ManagedAutoScaling AutoScaling
        {
            get { return this._autoScaling; }
            set { this._autoScaling = value; }
        }

        // Check to see if AutoScaling property is set
        internal bool IsSetAutoScaling()
        {
            return this._autoScaling != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPaths. 
        /// <para>
        /// The ingress paths and endpoints for the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedIngressPath> IngressPaths
        {
            get { return this._ingressPaths; }
            set { this._ingressPaths = value; }
        }

        // Check to see if IngressPaths property is set
        internal bool IsSetIngressPaths()
        {
            return this._ingressPaths != null && (this._ingressPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogGroups. 
        /// <para>
        /// The log groups managed by the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedLogGroup> LogGroups
        {
            get { return this._logGroups; }
            set { this._logGroups = value; }
        }

        // Check to see if LogGroups property is set
        internal bool IsSetLogGroups()
        {
            return this._logGroups != null && (this._logGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricAlarms. 
        /// <para>
        /// The CloudWatch metric alarms associated with the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedMetricAlarm> MetricAlarms
        {
            get { return this._metricAlarms; }
            set { this._metricAlarms = value; }
        }

        // Check to see if MetricAlarms property is set
        internal bool IsSetMetricAlarms()
        {
            return this._metricAlarms != null && (this._metricAlarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceSecurityGroups. 
        /// <para>
        /// The security groups managed by the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedSecurityGroup> ServiceSecurityGroups
        {
            get { return this._serviceSecurityGroups; }
            set { this._serviceSecurityGroups = value; }
        }

        // Check to see if ServiceSecurityGroups property is set
        internal bool IsSetServiceSecurityGroups()
        {
            return this._serviceSecurityGroups != null && (this._serviceSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}