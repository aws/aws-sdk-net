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
    /// Projected content for an EVIDENCE artifact carrying prioritization's prevalidation
    /// signals.
    /// </summary>
    public partial class PrevalidationSignalsBody
    {
        /// <summary>
        /// Gets and sets the property ProducedBy. The agent that produced this signal set.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProducedBy { get; set; }

        /// <summary>
        /// Checks to see if the ProducedBy property is set.
        /// </summary>
        internal bool IsSetProducedBy() => this.ProducedBy != null;

        /// <summary>
        /// Gets and sets the property Signals. The signals backing the Issue's proposed severity.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<PrevalidationSignal> Signals { get; set; } = AWSConfigs.InitializeCollections ? new List<PrevalidationSignal>() : null;

        /// <summary>
        /// Checks to see if the Signals property is set.
        /// </summary>
        internal bool IsSetSignals() => this.Signals != null && (this.Signals.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
