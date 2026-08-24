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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
        private string _description;
        private string _mitigation;
        private Pillar _pillar;
        private RiskRating _risk;
        private string _riskExplanation;
        private string _title;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the specific risk and the condition that triggers it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=30, Max=450)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Mitigation. 
        /// <para>
        /// A specific action to mitigate the trade-off and when to take it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=30, Max=450)]
        public string Mitigation
        {
            get { return this._mitigation; }
            set { this._mitigation = value; }
        }

        // Check to see if Mitigation property is set
        internal bool IsSetMitigation()
        {
            return this._mitigation != null;
        }

        /// <summary>
        /// Gets and sets the property Pillar. 
        /// <para>
        /// The pillar that could be negatively impacted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Pillar Pillar
        {
            get { return this._pillar; }
            set { this._pillar = value; }
        }

        // Check to see if Pillar property is set
        internal bool IsSetPillar()
        {
            return this._pillar != null;
        }

        /// <summary>
        /// Gets and sets the property Risk. 
        /// <para>
        /// The risk rating for the trade-off.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RiskRating Risk
        {
            get { return this._risk; }
            set { this._risk = value; }
        }

        // Check to see if Risk property is set
        internal bool IsSetRisk()
        {
            return this._risk != null;
        }

        /// <summary>
        /// Gets and sets the property RiskExplanation. 
        /// <para>
        /// An optional explanation providing additional context for the risk rating.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=160)]
        public string RiskExplanation
        {
            get { return this._riskExplanation; }
            set { this._riskExplanation = value; }
        }

        // Check to see if RiskExplanation property is set
        internal bool IsSetRiskExplanation()
        {
            return this._riskExplanation != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short phrase describing what is lost or degraded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=80)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}