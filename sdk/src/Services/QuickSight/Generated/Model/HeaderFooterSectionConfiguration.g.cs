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
    /// The configuration of a header or footer section.
    /// </summary>
    public partial class HeaderFooterSectionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// The layout configuration of the header or footer section.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SectionLayoutConfiguration Layout { get; set; }

        /// <summary>
        /// Checks to see if the Layout property is set.
        /// </summary>
        internal bool IsSetLayout() => this.Layout != null;

        /// <summary>
        /// Gets and sets the property SectionId. 
        /// <para>
        /// The unique identifier of the header or footer section.
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
        /// The style options of a header or footer section.
        /// </para>
        /// </summary>
        public SectionStyle Style { get; set; }

        /// <summary>
        /// Checks to see if the Style property is set.
        /// </summary>
        internal bool IsSetStyle() => this.Style != null;
    }
}
