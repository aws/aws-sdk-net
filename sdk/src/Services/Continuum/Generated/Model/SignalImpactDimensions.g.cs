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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// The three impact dimensions an impact signal assessed. The computed impact band is
    /// derived from attackerGains and blastRadius, then shifted by targetValue.
    /// </summary>
    public partial class SignalImpactDimensions
    {
        /// <summary>
        /// Gets and sets the property AttackerGains. What the attacker gains from exploitation.
        /// </summary>
        public SignalAttackerGainsDimension AttackerGains { get; set; }

        /// <summary>
        /// Checks to see if the AttackerGains property is set.
        /// </summary>
        internal bool IsSetAttackerGains() => this.AttackerGains != null;

        /// <summary>
        /// Gets and sets the property BlastRadius. How far the consequences reach.
        /// </summary>
        public SignalBlastRadiusDimension BlastRadius { get; set; }

        /// <summary>
        /// Checks to see if the BlastRadius property is set.
        /// </summary>
        internal bool IsSetBlastRadius() => this.BlastRadius != null;

        /// <summary>
        /// Gets and sets the property TargetValue. How valuable the target is, which can shift
        /// the band off its base value.
        /// </summary>
        public SignalTargetValueDimension TargetValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetValue property is set.
        /// </summary>
        internal bool IsSetTargetValue() => this.TargetValue != null;
    }
}
