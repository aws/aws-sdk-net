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
    /// Deterministic values the producer computed from its assessment, as distinct from the
    /// assessment itself.
    /// </summary>
    public partial class SignalComputation
    {
        /// <summary>
        /// Gets and sets the property Barriers. How many of the four exploit preconditions act
        /// as barriers (0-4).
        /// </summary>
        public int? Barriers { get; set; }

        /// <summary>
        /// Checks to see if the Barriers property is set.
        /// </summary>
        internal bool IsSetBarriers() => this.Barriers.HasValue;

        /// <summary>
        /// Gets and sets the property ImpactBand. Computed impact band, on an impact signal.
        /// </summary>
        public SignalBand ImpactBand { get; set; }

        /// <summary>
        /// Checks to see if the ImpactBand property is set.
        /// </summary>
        internal bool IsSetImpactBand() => this.ImpactBand != null;

        /// <summary>
        /// Gets and sets the property LikelihoodBand. Computed likelihood band, on a likelihood
        /// signal.
        /// </summary>
        public SignalBand LikelihoodBand { get; set; }

        /// <summary>
        /// Checks to see if the LikelihoodBand property is set.
        /// </summary>
        internal bool IsSetLikelihoodBand() => this.LikelihoodBand != null;
    }
}
