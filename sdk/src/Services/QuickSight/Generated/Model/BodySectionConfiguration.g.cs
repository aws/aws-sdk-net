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
    /// The configuration of a body section.
    /// </summary>
    public partial class BodySectionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The configuration of content in a body section.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BodySectionContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property PageBreakConfiguration. 
        /// <para>
        /// The configuration of a page break for a section.
        /// </para>
        /// </summary>
        public SectionPageBreakConfiguration PageBreakConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PageBreakConfiguration property is set.
        /// </summary>
        internal bool IsSetPageBreakConfiguration() => this.PageBreakConfiguration != null;

        /// <summary>
        /// Gets and sets the property RepeatConfiguration. 
        /// <para>
        /// Describes the configurations that are required to declare a section as repeating.
        /// </para>
        /// </summary>
        public BodySectionRepeatConfiguration RepeatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RepeatConfiguration property is set.
        /// </summary>
        internal bool IsSetRepeatConfiguration() => this.RepeatConfiguration != null;

        /// <summary>
        /// Gets and sets the property SectionId. 
        /// <para>
        /// The unique identifier of a body section.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SectionId { get; set; }

        /// <summary>
        /// Checks to see if the SectionId property is set.
        /// </summary>
        internal bool IsSetSectionId() => this.SectionId != null;

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// The style options of a body section.
        /// </para>
        /// </summary>
        public SectionStyle Style { get; set; }

        /// <summary>
        /// Checks to see if the Style property is set.
        /// </summary>
        internal bool IsSetStyle() => this.Style != null;
    }
}
