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
    /// The value label configuration of the label in a reference line.
    /// </summary>
    public partial class ReferenceLineValueLabelConfiguration
    {
        private NumericFormatConfiguration _formatConfiguration;
        private ReferenceLineValueLabelRelativePosition _relativePosition;

        /// <summary>
        /// Gets and sets the property FormatConfiguration. 
        /// <para>
        /// The format configuration of the value label.
        /// </para>
        /// </summary>
        public NumericFormatConfiguration FormatConfiguration
        {
            get { return this._formatConfiguration; }
            set { this._formatConfiguration = value; }
        }

        // Check to see if FormatConfiguration property is set
        internal bool IsSetFormatConfiguration()
        {
            return this._formatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RelativePosition. 
        /// <para>
        /// The relative position of the value label. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BEFORE_CUSTOM_LABEL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AFTER_CUSTOM_LABEL</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReferenceLineValueLabelRelativePosition RelativePosition
        {
            get { return this._relativePosition; }
            set { this._relativePosition = value; }
        }

        // Check to see if RelativePosition property is set
        internal bool IsSetRelativePosition()
        {
            return this._relativePosition != null;
        }

    }
}