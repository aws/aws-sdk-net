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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A negative trade-off from acting on the recommendation.
    /// </summary>
    public partial class TradeOff
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the specific risk and the condition that triggers it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 30, Max = 450)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Mitigation. 
        /// <para>
        /// A specific action to mitigate the trade-off and when to take it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 30, Max = 450)]
        public string Mitigation { get; set; }

        /// <summary>
        /// Checks to see if the Mitigation property is set.
        /// </summary>
        internal bool IsSetMitigation() => this.Mitigation != null;

        /// <summary>
        /// Gets and sets the property Pillar. 
        /// <para>
        /// The pillar that could be negatively impacted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Pillar Pillar { get; set; }

        /// <summary>
        /// Checks to see if the Pillar property is set.
        /// </summary>
        internal bool IsSetPillar() => this.Pillar != null;

        /// <summary>
        /// Gets and sets the property Risk. 
        /// <para>
        /// The risk rating for the trade-off.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RiskRating Risk { get; set; }

        /// <summary>
        /// Checks to see if the Risk property is set.
        /// </summary>
        internal bool IsSetRisk() => this.Risk != null;

        /// <summary>
        /// Gets and sets the property RiskExplanation. 
        /// <para>
        /// An optional explanation providing additional context for the risk rating.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 160)]
        public string RiskExplanation { get; set; }

        /// <summary>
        /// Checks to see if the RiskExplanation property is set.
        /// </summary>
        internal bool IsSetRiskExplanation() => this.RiskExplanation != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short phrase describing what is lost or degraded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 80)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
