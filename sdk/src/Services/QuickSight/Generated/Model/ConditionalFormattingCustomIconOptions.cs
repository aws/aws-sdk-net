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
    /// Custom icon options for an icon set.
    /// </summary>
    public partial class ConditionalFormattingCustomIconOptions
    {
        private Icon _icon;
        private string _unicodeIcon;

        /// <summary>
        /// Gets and sets the property Icon. 
        /// <para>
        /// Determines the type of icon.
        /// </para>
        /// </summary>
        public Icon Icon
        {
            get { return this._icon; }
            set { this._icon = value; }
        }

        // Check to see if Icon property is set
        internal bool IsSetIcon()
        {
            return this._icon != null;
        }

        /// <summary>
        /// Gets and sets the property UnicodeIcon. 
        /// <para>
        /// Determines the Unicode icon type.
        /// </para>
        /// </summary>
        public string UnicodeIcon
        {
            get { return this._unicodeIcon; }
            set { this._unicodeIcon = value; }
        }

        // Check to see if UnicodeIcon property is set
        internal bool IsSetUnicodeIcon()
        {
            return this._unicodeIcon != null;
        }

    }
}