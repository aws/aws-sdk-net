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
    /// A structure containing information about one service level objective (SLO) that has
    /// been created in Application Signals. Creating SLOs can help you ensure your services
    /// are performing to the level that you expect. SLOs help you set and track a specific
    /// target level for the reliability and availability of your applications and services.
    /// Each SLO uses a service level indicator (SLI), which is a key performance metric,
    /// to calculate how much underperformance can be tolerated before the goal that you set
    /// for the SLO is not achieved.
    /// </summary>
    public partial class ServiceLevelObjective
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutoInvestigationEnabled. Indicates whether DevOps Agent
        /// will automatically investigate this SLO when it is breached
        /// </summary>
        public bool? AutoInvestigationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoInvestigationEnabled property is set.
        /// </summary>
        internal bool IsSetAutoInvestigationEnabled() => this.AutoInvestigationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property BurnRateConfigurations. 
        /// <para>
        /// Each object in this array defines the length of the look-back window used to calculate
        /// one burn rate metric for this SLO. The burn rate measures how fast the service is
        /// consuming the error budget, relative to the attainment goal of the SLO.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<BurnRateConfiguration> BurnRateConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<BurnRateConfiguration>() : null;

        /// <summary>
        /// Checks to see if the BurnRateConfigurations property is set.
        /// </summary>
        internal bool IsSetBurnRateConfigurations() => this.BurnRateConfigurations != null && (this.BurnRateConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that this SLO was created. When used in a raw HTTP Query API, it
        /// is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you created for this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property Goal.
        /// </summary>
        [AWSProperty(Required = true)]
        public Goal Goal { get; set; }

        /// <summary>
        /// Checks to see if the Goal property is set.
        /// </summary>
        internal bool IsSetGoal() => this.Goal != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that this SLO was most recently updated. When used in a raw HTTP Query API,
        /// it is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

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
        /// The name of this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestBasedSli. 
        /// <para>
        /// A structure containing information about the performance metric that this SLO monitors,
        /// if this is a request-based SLO.
        /// </para>
        /// </summary>
        public RequestBasedServiceLevelIndicator RequestBasedSli { get; set; }

        /// <summary>
        /// Checks to see if the RequestBasedSli property is set.
        /// </summary>
        internal bool IsSetRequestBasedSli() => this.RequestBasedSli != null;

        /// <summary>
        /// Gets and sets the property Sli. 
        /// <para>
        /// A structure containing information about the performance metric that this SLO monitors,
        /// if this is a period-based SLO.
        /// </para>
        /// </summary>
        public ServiceLevelIndicator Sli { get; set; }

        /// <summary>
        /// Checks to see if the Sli property is set.
        /// </summary>
        internal bool IsSetSli() => this.Sli != null;
    }
}
