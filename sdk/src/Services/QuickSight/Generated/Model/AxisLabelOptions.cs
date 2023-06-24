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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The label options for a chart axis. You must specify the field that the label is targeted
    /// to.
    /// </summary>
    public partial class AxisLabelOptions
    {
        private AxisLabelReferenceOptions _applyTo;
        private string _customLabel;
        private FontConfiguration _fontConfiguration;

        /// <summary>
        /// Gets and sets the property ApplyTo. 
        /// <para>
        /// The options that indicate which field the label belongs to.
        /// </para>
        /// </summary>
        public AxisLabelReferenceOptions ApplyTo
        {
            get { return this._applyTo; }
            set { this._applyTo = value; }
        }

        // Check to see if ApplyTo property is set
        internal bool IsSetApplyTo()
        {
            return this._applyTo != null;
        }

        /// <summary>
        /// Gets and sets the property CustomLabel. 
        /// <para>
        /// The text for the axis label.
        /// </para>
        /// </summary>
        public string CustomLabel
        {
            get { return this._customLabel; }
            set { this._customLabel = value; }
        }

        // Check to see if CustomLabel property is set
        internal bool IsSetCustomLabel()
        {
            return this._customLabel != null;
        }

        /// <summary>
        /// Gets and sets the property FontConfiguration. 
        /// <para>
        /// The font configuration of the axis label.
        /// </para>
        /// </summary>
        public FontConfiguration FontConfiguration
        {
            get { return this._fontConfiguration; }
            set { this._fontConfiguration = value; }
        }

        // Check to see if FontConfiguration property is set
        internal bool IsSetFontConfiguration()
        {
            return this._fontConfiguration != null;
        }

    }
}