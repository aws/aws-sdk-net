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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Formatting configuration for icon set.
    /// </summary>
    public partial class ConditionalFormattingIconSet
    {
        private string _expression;
        private ConditionalFormattingIconSetType _iconSetType;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression that determines the formatting configuration for the icon set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
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
        /// Gets and sets the property IconSetType. 
        /// <para>
        /// Determines the icon set type.
        /// </para>
        /// </summary>
        public ConditionalFormattingIconSetType IconSetType
        {
            get { return this._iconSetType; }
            set { this._iconSetType = value; }
        }

        // Check to see if IconSetType property is set
        internal bool IsSetIconSetType()
        {
            return this._iconSetType != null;
        }

    }
}