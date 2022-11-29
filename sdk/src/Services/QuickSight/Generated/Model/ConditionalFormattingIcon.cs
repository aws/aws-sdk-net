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
    /// The formatting configuration for the icon.
    /// </summary>
    public partial class ConditionalFormattingIcon
    {
        private ConditionalFormattingCustomIconCondition _customCondition;
        private ConditionalFormattingIconSet _iconSet;

        /// <summary>
        /// Gets and sets the property CustomCondition. 
        /// <para>
        /// Determines the custom condition for an icon set.
        /// </para>
        /// </summary>
        public ConditionalFormattingCustomIconCondition CustomCondition
        {
            get { return this._customCondition; }
            set { this._customCondition = value; }
        }

        // Check to see if CustomCondition property is set
        internal bool IsSetCustomCondition()
        {
            return this._customCondition != null;
        }

        /// <summary>
        /// Gets and sets the property IconSet. 
        /// <para>
        /// Formatting configuration for icon set.
        /// </para>
        /// </summary>
        public ConditionalFormattingIconSet IconSet
        {
            get { return this._iconSet; }
            set { this._iconSet = value; }
        }

        // Check to see if IconSet property is set
        internal bool IsSetIconSet()
        {
            return this._iconSet != null;
        }

    }
}