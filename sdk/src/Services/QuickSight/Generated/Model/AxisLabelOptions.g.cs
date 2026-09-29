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
    /// The label options for a chart axis. You must specify the field that the label is targeted
    /// to.
    /// </summary>
    public partial class AxisLabelOptions
    {
        /// <summary>
        /// Gets and sets the property ApplyTo. 
        /// <para>
        /// The options that indicate which field the label belongs to.
        /// </para>
        /// </summary>
        public AxisLabelReferenceOptions ApplyTo { get; set; }

        /// <summary>
        /// Checks to see if the ApplyTo property is set.
        /// </summary>
        internal bool IsSetApplyTo() => this.ApplyTo != null;

        /// <summary>
        /// Gets and sets the property CustomLabel. 
        /// <para>
        /// The text for the axis label.
        /// </para>
        /// </summary>
        public string CustomLabel { get; set; }

        /// <summary>
        /// Checks to see if the CustomLabel property is set.
        /// </summary>
        internal bool IsSetCustomLabel() => this.CustomLabel != null;

        /// <summary>
        /// Gets and sets the property FontConfiguration. 
        /// <para>
        /// The font configuration of the axis label.
        /// </para>
        /// </summary>
        public FontConfiguration FontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FontConfiguration property is set.
        /// </summary>
        internal bool IsSetFontConfiguration() => this.FontConfiguration != null;
    }
}
