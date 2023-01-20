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
    /// The options for data bars.
    /// </summary>
    public partial class DataBarsOptions
    {
        private string _fieldId;
        private string _negativeColor;
        private string _positiveColor;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID for the data bars options.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property NegativeColor. 
        /// <para>
        /// The color of the negative data bar.
        /// </para>
        /// </summary>
        public string NegativeColor
        {
            get { return this._negativeColor; }
            set { this._negativeColor = value; }
        }

        // Check to see if NegativeColor property is set
        internal bool IsSetNegativeColor()
        {
            return this._negativeColor != null;
        }

        /// <summary>
        /// Gets and sets the property PositiveColor. 
        /// <para>
        /// The color of the positive data bar.
        /// </para>
        /// </summary>
        public string PositiveColor
        {
            get { return this._positiveColor; }
            set { this._positiveColor = value; }
        }

        // Check to see if PositiveColor property is set
        internal bool IsSetPositiveColor()
        {
            return this._positiveColor != null;
        }

    }
}