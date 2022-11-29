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
    /// Determines the row alternate color options.
    /// </summary>
    public partial class RowAlternateColorOptions
    {
        private List<string> _rowAlternateColors = new List<string>();
        private WidgetStatus _status;

        /// <summary>
        /// Gets and sets the property RowAlternateColors. 
        /// <para>
        /// Determines the list of row alternate colors.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> RowAlternateColors
        {
            get { return this._rowAlternateColors; }
            set { this._rowAlternateColors = value; }
        }

        // Check to see if RowAlternateColors property is set
        internal bool IsSetRowAlternateColors()
        {
            return this._rowAlternateColors != null && this._rowAlternateColors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Determines the widget status.
        /// </para>
        /// </summary>
        public WidgetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}