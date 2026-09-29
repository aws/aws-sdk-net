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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// The output configuration settings for the contextual metadata feature. Use this structure
    /// when the feed output generates metadata that describes the media content.
    /// </summary>
    public partial class ContextualMetadataConfig
    {
        /// <summary>
        /// Gets and sets the property ExtendedAnalysis. 
        /// <para>
        /// Specifies whether Elemental Inference generates extended analysis of the media content
        /// for this output. Extended analysis identifies the people, environments, brands, and
        /// on-screen text in the media content. This setting is independent of <c>summaryGeneration</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ENABLED (default) – Elemental Inference populates the people, environments, brands,
        /// and on-screen text fields. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISABLED – Elemental Inference doesn't populate the people, environments, brands,
        /// and on-screen text fields. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExtendedAnalysisMode ExtendedAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedAnalysis property is set.
        /// </summary>
        internal bool IsSetExtendedAnalysis() => this.ExtendedAnalysis != null;

        /// <summary>
        /// Gets and sets the property SummaryGeneration. 
        /// <para>
        /// Specifies whether Elemental Inference generates a descriptive summary of the media
        /// content for this output, along with the objects and actions that it detects. This
        /// setting is independent of <c>extendedAnalysis</c>. 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ENABLED (default) – Elemental Inference populates the summary, objects, and actions
        /// fields, along with the IAB taxonomy and GARM suitability classifications. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISABLED – Elemental Inference doesn't populate the summary, objects, and actions
        /// fields. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SummaryGenerationMode SummaryGeneration { get; set; }

        /// <summary>
        /// Checks to see if the SummaryGeneration property is set.
        /// </summary>
        internal bool IsSetSummaryGeneration() => this.SummaryGeneration != null;
    }
}
