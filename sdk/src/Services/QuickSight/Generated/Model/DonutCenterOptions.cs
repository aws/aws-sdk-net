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
    /// The label options of the label that is displayed in the center of a donut chart. This
    /// option isn't available for pie charts.
    /// </summary>
    public partial class DonutCenterOptions
    {
        private Visibility _labelVisibility;

        /// <summary>
        /// Gets and sets the property LabelVisibility. 
        /// <para>
        /// Determines the visibility of the label in a donut chart. In the Amazon QuickSight
        /// console, this option is called <code>'Show total'</code>.
        /// </para>
        /// </summary>
        public Visibility LabelVisibility
        {
            get { return this._labelVisibility; }
            set { this._labelVisibility = value; }
        }

        // Check to see if LabelVisibility property is set
        internal bool IsSetLabelVisibility()
        {
            return this._labelVisibility != null;
        }

    }
}