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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Information about an Auto-Tune action. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html">Auto-Tune
    /// for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class AutoTune
    {
        /// <summary>
        /// Gets and sets the property AutoTuneDetails. 
        /// <para>
        /// Details about an Auto-Tune action.
        /// </para>
        /// </summary>
        public AutoTuneDetails AutoTuneDetails { get; set; }

        /// <summary>
        /// Checks to see if the AutoTuneDetails property is set.
        /// </summary>
        internal bool IsSetAutoTuneDetails() => this.AutoTuneDetails != null;

        /// <summary>
        /// Gets and sets the property AutoTuneType. 
        /// <para>
        /// The type of Auto-Tune action.
        /// </para>
        /// </summary>
        public AutoTuneType AutoTuneType { get; set; }

        /// <summary>
        /// Checks to see if the AutoTuneType property is set.
        /// </summary>
        internal bool IsSetAutoTuneType() => this.AutoTuneType != null;
    }
}
