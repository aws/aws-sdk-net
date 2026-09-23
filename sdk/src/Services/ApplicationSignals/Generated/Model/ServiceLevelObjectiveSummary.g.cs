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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains information about one service level objective (SLO) created
    /// in Application Signals.
    /// </summary>
    public partial class ServiceLevelObjectiveSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of this service level objective.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CompositeSliConfig. 
        /// <para>
        /// The composite SLI configuration for service-level SLOs that monitor multiple operations
        /// of a service.
        /// </para>
        /// </summary>
        public CompositeSliConfig CompositeSliConfig { get; set; }

        /// <summary>
        /// Checks to see if the CompositeSliConfig property is set.
        /// </summary>
        internal bool IsSetCompositeSliConfig() => this.CompositeSliConfig != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that this service level objective was created. It is expressed as
        /// the number of milliseconds since Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DependencyConfig. 
        /// <para>
        /// Identifies the dependency using the <c>DependencyKeyAttributes</c> and <c>DependencyOperationName</c>.
        /// 
        /// </para>
        /// </summary>
        public DependencyConfig DependencyConfig { get; set; }

        /// <summary>
        /// Checks to see if the DependencyConfig property is set.
        /// </summary>
        internal bool IsSetDependencyConfig() => this.DependencyConfig != null;

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// Displays whether this is a period-based SLO or a request-based SLO.
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationType property is set.
        /// </summary>
        internal bool IsSetEvaluationType() => this.EvaluationType != null;

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this service level objective is for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public Dictionary<string, string> KeyAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KeyAttributes property is set.
        /// </summary>
        internal bool IsSetKeyAttributes() => this.KeyAttributes != null && (this.KeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricSource. 
        /// <para>
        /// Identifies the metric source for SLOs on resources other than Application Signals
        /// services.
        /// </para>
        /// </summary>
        public MetricSource MetricSource { get; set; }

        /// <summary>
        /// Checks to see if the MetricSource property is set.
        /// </summary>
        internal bool IsSetMetricSource() => this.MetricSource != null;

        /// <summary>
        /// Gets and sets the property MetricSourceType. 
        /// <para>
        /// Displays the SLI metric source type for this SLO. Supported types are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Service operation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service dependency
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch metric
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AppMonitor
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Canary
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MetricSourceType MetricSourceType { get; set; }

        /// <summary>
        /// Checks to see if the MetricSourceType property is set.
        /// </summary>
        internal bool IsSetMetricSourceType() => this.MetricSourceType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service level objective.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// If this service level objective is specific to a single operation, this field displays
        /// the name of that operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;
    }
}
