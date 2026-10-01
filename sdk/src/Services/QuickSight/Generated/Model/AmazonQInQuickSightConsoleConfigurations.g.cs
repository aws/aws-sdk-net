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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A collection of Amazon Q feature configurations in an embedded Quick Sight console.
    /// </summary>
    public partial class AmazonQInQuickSightConsoleConfigurations
    {
        /// <summary>
        /// Gets and sets the property DataQnA. 
        /// <para>
        /// Adds generative Q&amp;A capabilitiees to an embedded Quick Sight console.
        /// </para>
        /// </summary>
        public DataQnAConfigurations DataQnA { get; set; }

        /// <summary>
        /// Checks to see if the DataQnA property is set.
        /// </summary>
        internal bool IsSetDataQnA() => this.DataQnA != null;

        /// <summary>
        /// Gets and sets the property DataStories. 
        /// <para>
        /// Adds the data stories feature to an embedded Quick Sight console.
        /// </para>
        /// </summary>
        public DataStoriesConfigurations DataStories { get; set; }

        /// <summary>
        /// Checks to see if the DataStories property is set.
        /// </summary>
        internal bool IsSetDataStories() => this.DataStories != null;

        /// <summary>
        /// Gets and sets the property ExecutiveSummary. 
        /// <para>
        /// Adds the executive summaries feature to an embedded Quick Sight console.
        /// </para>
        /// </summary>
        public ExecutiveSummaryConfigurations ExecutiveSummary { get; set; }

        /// <summary>
        /// Checks to see if the ExecutiveSummary property is set.
        /// </summary>
        internal bool IsSetExecutiveSummary() => this.ExecutiveSummary != null;

        /// <summary>
        /// Gets and sets the property GenerativeAuthoring. 
        /// <para>
        /// Adds the generative BI authoring experience to an embedded Quick Sight console.
        /// </para>
        /// </summary>
        public GenerativeAuthoringConfigurations GenerativeAuthoring { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeAuthoring property is set.
        /// </summary>
        internal bool IsSetGenerativeAuthoring() => this.GenerativeAuthoring != null;
    }
}
