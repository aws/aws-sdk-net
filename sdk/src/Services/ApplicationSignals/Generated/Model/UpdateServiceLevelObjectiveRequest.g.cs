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
    /// Container for the parameters to the UpdateServiceLevelObjective operation. Updates
    /// an existing service level objective (SLO). If you omit parameters, the previous values
    /// of those parameters are retained. <para> You cannot change from a period-based SLO
    /// to a request-based SLO, or change from a request-based SLO to a period-based SLO.
    /// </para>
    /// </summary>
    public partial class UpdateServiceLevelObjectiveRequest : AmazonApplicationSignalsRequest
    {
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
        /// Use this array to create <i>burn rates</i> for this SLO. Each burn rate is a metric
        /// that indicates how fast the service is consuming the error budget, relative to the
        /// attainment goal of the SLO.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Goal. 
        /// <para>
        /// A structure that contains the attributes that determine the goal of the SLO. This
        /// includes the time period for evaluation and the attainment threshold.
        /// </para>
        /// </summary>
        public Goal Goal { get; set; }

        /// <summary>
        /// Checks to see if the Goal property is set.
        /// </summary>
        internal bool IsSetGoal() => this.Goal != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The Amazon Resource Name (ARN) or name of the service level objective that you want
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RequestBasedSliConfig. 
        /// <para>
        /// If this SLO is a request-based SLO, this structure defines the information about what
        /// performance metric this SLO will monitor.
        /// </para>
        ///  
        /// <para>
        /// You can't specify both <c>SliConfig</c> and <c>RequestBasedSliConfig</c> in the same
        /// operation.
        /// </para>
        /// </summary>
        public RequestBasedServiceLevelIndicatorConfig RequestBasedSliConfig { get; set; }

        /// <summary>
        /// Checks to see if the RequestBasedSliConfig property is set.
        /// </summary>
        internal bool IsSetRequestBasedSliConfig() => this.RequestBasedSliConfig != null;

        /// <summary>
        /// Gets and sets the property SliConfig. 
        /// <para>
        /// If this SLO is a period-based SLO, this structure defines the information about what
        /// performance metric this SLO will monitor.
        /// </para>
        /// </summary>
        public ServiceLevelIndicatorConfig SliConfig { get; set; }

        /// <summary>
        /// Checks to see if the SliConfig property is set.
        /// </summary>
        internal bool IsSetSliConfig() => this.SliConfig != null;
    }
}
