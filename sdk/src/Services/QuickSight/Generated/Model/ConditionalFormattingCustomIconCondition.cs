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
    /// Determines the custom condition for an icon set.
    /// </summary>
    public partial class ConditionalFormattingCustomIconCondition
    {
        private string _color;
        private ConditionalFormattingIconDisplayConfiguration _displayConfiguration;
        private string _expression;
        private ConditionalFormattingCustomIconOptions _iconOptions;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// Determines the color of the icon.
        /// </para>
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayConfiguration. 
        /// <para>
        /// Determines the icon display configuration.
        /// </para>
        /// </summary>
        public ConditionalFormattingIconDisplayConfiguration DisplayConfiguration
        {
            get { return this._displayConfiguration; }
            set { this._displayConfiguration = value; }
        }

        // Check to see if DisplayConfiguration property is set
        internal bool IsSetDisplayConfiguration()
        {
            return this._displayConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression that determines the condition of the icon set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property IconOptions. 
        /// <para>
        /// Custom icon options for an icon set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConditionalFormattingCustomIconOptions IconOptions
        {
            get { return this._iconOptions; }
            set { this._iconOptions = value; }
        }

        // Check to see if IconOptions property is set
        internal bool IsSetIconOptions()
        {
            return this._iconOptions != null;
        }

    }
}