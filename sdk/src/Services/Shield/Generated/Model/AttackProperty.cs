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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Details of a Shield event. This is provided as part of an <a>AttackDetail</a>.
    /// </summary>
    public partial class AttackProperty
    {
        private AttackLayer _attackLayer;
        private AttackPropertyIdentifier _attackPropertyIdentifier;
        private List<Contributor> _topContributors = AWSConfigs.InitializeCollections ? new List<Contributor>() : null;
        private long? _total;
        private Unit _unit;

        /// <summary>
        /// Gets and sets the property AttackLayer. 
        /// <para>
        /// The type of Shield event that was observed. <c>NETWORK</c> indicates layer 3 and layer
        /// 4 events and <c>APPLICATION</c> indicates layer 7 events.
        /// </para>
        ///  
        /// <para>
        /// For infrastructure layer events (L3 and L4 events), you can view metrics for top contributors
        /// in Amazon CloudWatch metrics. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/monitoring-cloudwatch.html#set-ddos-alarms">Shield
        /// metrics and alarms</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        public AttackLayer AttackLayer
        {
            get { return this._attackLayer; }
            set { this._attackLayer = value; }
        }

        // Check to see if AttackLayer property is set
        internal bool IsSetAttackLayer()
        {
            return this._attackLayer != null;
        }

        /// <summary>
        /// Gets and sets the property AttackPropertyIdentifier. 
        /// <para>
        /// Defines the Shield event property information that is provided. The <c>WORDPRESS_PINGBACK_REFLECTOR</c>
        /// and <c>WORDPRESS_PINGBACK_SOURCE</c> values are valid only for WordPress reflective
        /// pingback events.
        /// </para>
        /// </summary>
        public AttackPropertyIdentifier AttackPropertyIdentifier
        {
            get { return this._attackPropertyIdentifier; }
            set { this._attackPropertyIdentifier = value; }
        }

        // Check to see if AttackPropertyIdentifier property is set
        internal bool IsSetAttackPropertyIdentifier()
        {
            return this._attackPropertyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TopContributors. 
        /// <para>
        /// Contributor objects for the top five contributors to a Shield event. A contributor
        /// is a source of traffic that Shield Advanced identifies as responsible for some or
        /// all of an event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Contributor> TopContributors
        {
            get { return this._topContributors; }
            set { this._topContributors = value; }
        }

        // Check to see if TopContributors property is set
        internal bool IsSetTopContributors()
        {
            return this._topContributors != null && (this._topContributors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total contributions made to this Shield event by all contributors.
        /// </para>
        /// </summary>
        public long? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit used for the <c>Contributor</c> <c>Value</c> property. 
        /// </para>
        /// </summary>
        public Unit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}