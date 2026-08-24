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
    /// A benefit on a different pillar from acting on the recommendation.
    /// </summary>
    public partial class CrossPillarBenefit
    {
        private string _description;
        private ImpactCategory _impact;
        private Pillar _pillar;
        private string _title;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what changes and why it matters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=30, Max=300)]
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
        /// Gets and sets the property Impact. 
        /// <para>
        /// The severity of the benefit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImpactCategory Impact
        {
            get { return this._impact; }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact != null;
        }

        /// <summary>
        /// Gets and sets the property Pillar. 
        /// <para>
        /// The pillar that would be positively impacted.
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
        /// Gets and sets the property Title. 
        /// <para>
        /// A short phrase describing the outcome.
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