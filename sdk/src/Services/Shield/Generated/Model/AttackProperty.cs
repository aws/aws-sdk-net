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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Details of the described attack.
    /// </summary>
    public partial class AttackProperty
    {
        private AttackLayer _attackLayer;
        private AttackPropertyIdentifier _attackPropertyIdentifier;
        private List<Contributor> _topContributors = new List<Contributor>();
        private long? _total;
        private Unit _unit;

        /// <summary>
        /// Gets and sets the property AttackLayer. 
        /// <para>
        /// The type of DDoS event that was observed. <code>NETWORK</code> indicates layer 3 and
        /// layer 4 events and <code>APPLICATION</code> indicates layer 7 events.
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
        /// Defines the DDoS attack property information that is provided.
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
        /// The array of <a>Contributor</a> objects that includes the top five contributors to
        /// an attack. 
        /// </para>
        /// </summary>
        public List<Contributor> TopContributors
        {
            get { return this._topContributors; }
            set { this._topContributors = value; }
        }

        // Check to see if TopContributors property is set
        internal bool IsSetTopContributors()
        {
            return this._topContributors != null && this._topContributors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total contributions made to this attack by all contributors, not just the five
        /// listed in the <code>TopContributors</code> list.
        /// </para>
        /// </summary>
        public long Total
        {
            get { return this._total.GetValueOrDefault(); }
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
        /// The unit of the <code>Value</code> of the contributions.
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