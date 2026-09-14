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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Defines how telemetry should be configured for specific Amazon Web Services resources.
    /// </summary>
    public partial class TelemetryRule
    {
        /// <summary>
        /// Gets and sets the property AllRegions. 
        /// <para>
        ///  If set to <c>true</c>, the telemetry rule is replicated to all Amazon Web Services
        /// Regions where Amazon CloudWatch Observability Admin is available in the current partition.
        /// When new regions become available, the rule automatically replicates to them. Mutually
        /// exclusive with <c>Regions</c>. 
        /// </para>
        /// </summary>
        public bool? AllRegions { get; set; }

        /// <summary>
        /// Checks to see if the AllRegions property is set.
        /// </summary>
        internal bool IsSetAllRegions() => this.AllRegions.HasValue;

        /// <summary>
        /// Gets and sets the property AllowFieldUpdates. 
        /// <para>
        ///  If set to <c>true</c>, Amazon CloudWatch Observability Admin detects and remediates
        /// configuration drift in telemetry resources that it manages. For example, if a VPC
        /// flow log's format, traffic type, or aggregation interval no longer matches the rule's
        /// destination configuration, the flow log is replaced with one that matches. Only Observability
        /// Admin-managed resources are updated; customer-created resources are never modified.
        /// Currently supported for <c>AWS::EC2::VPC</c> resources (VPC flow logs). 
        /// </para>
        /// </summary>
        public bool? AllowFieldUpdates { get; set; }

        /// <summary>
        /// Checks to see if the AllowFieldUpdates property is set.
        /// </summary>
        internal bool IsSetAllowFieldUpdates() => this.AllowFieldUpdates.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        ///  Configuration specifying where and how the telemetry data should be delivered. 
        /// </para>
        /// </summary>
        public TelemetryDestinationConfiguration DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationConfiguration() => this.DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        ///  An optional list of Amazon Web Services Regions where this telemetry rule should
        /// be replicated. When specified, the rule is created in the home region and automatically
        /// replicated to all listed regions. Mutually exclusive with <c>AllRegions</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  The type of Amazon Web Services resource to configure telemetry for (for example,
        /// <c>AWS::EC2::VPC</c>, <c>AWS::EKS::Cluster</c>, <c>AWS::ElasticLoadBalancingV2::LoadBalancer</c>,
        /// or <c>AWS::Bedrock::KnowledgeBase</c>). 
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        ///  The organizational scope to which the rule applies, specified using accounts or organizational
        /// units. 
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SelectionCriteria. 
        /// <para>
        ///  Criteria for selecting which resources the rule applies to, such as resource tags.
        /// 
        /// </para>
        /// </summary>
        public string SelectionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SelectionCriteria property is set.
        /// </summary>
        internal bool IsSetSelectionCriteria() => this.SelectionCriteria != null;

        /// <summary>
        /// Gets and sets the property TelemetrySourceTypes. 
        /// <para>
        ///  The specific telemetry source types to configure for the resource, such as VPC_FLOW_LOGS
        /// or EKS_AUDIT_LOGS. TelemetrySourceTypes must be correlated with the specific resource
        /// type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TelemetrySourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TelemetrySourceTypes property is set.
        /// </summary>
        internal bool IsSetTelemetrySourceTypes() => this.TelemetrySourceTypes != null && (this.TelemetrySourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetryType. 
        /// <para>
        ///  The type of telemetry to collect (Logs, Metrics, or Traces). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TelemetryType TelemetryType { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryType property is set.
        /// </summary>
        internal bool IsSetTelemetryType() => this.TelemetryType != null;
    }
}
