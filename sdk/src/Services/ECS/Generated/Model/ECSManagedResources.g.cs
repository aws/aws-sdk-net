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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Represents the Amazon Web Services resources managed by Amazon ECS for an Express
    /// service, including ingress paths, auto-scaling policies, metric alarms, and security
    /// groups.
    /// </summary>
    public partial class ECSManagedResources
    {
        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// The auto-scaling configuration and policies for the Express service.
        /// </para>
        /// </summary>
        public ManagedAutoScaling AutoScaling { get; set; }

        /// <summary>
        /// Checks to see if the AutoScaling property is set.
        /// </summary>
        internal bool IsSetAutoScaling() => this.AutoScaling != null;

        /// <summary>
        /// Gets and sets the property IngressPaths. 
        /// <para>
        /// The ingress paths and endpoints for the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedIngressPath> IngressPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedIngressPath>() : null;

        /// <summary>
        /// Checks to see if the IngressPaths property is set.
        /// </summary>
        internal bool IsSetIngressPaths() => this.IngressPaths != null && (this.IngressPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogGroups. 
        /// <para>
        /// The log groups managed by the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedLogGroup> LogGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedLogGroup>() : null;

        /// <summary>
        /// Checks to see if the LogGroups property is set.
        /// </summary>
        internal bool IsSetLogGroups() => this.LogGroups != null && (this.LogGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricAlarms. 
        /// <para>
        /// The CloudWatch metric alarms associated with the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedMetricAlarm> MetricAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedMetricAlarm>() : null;

        /// <summary>
        /// Checks to see if the MetricAlarms property is set.
        /// </summary>
        internal bool IsSetMetricAlarms() => this.MetricAlarms != null && (this.MetricAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceSecurityGroups. 
        /// <para>
        /// The security groups managed by the Express service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedSecurityGroup> ServiceSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedSecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the ServiceSecurityGroups property is set.
        /// </summary>
        internal bool IsSetServiceSecurityGroups() => this.ServiceSecurityGroups != null && (this.ServiceSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
