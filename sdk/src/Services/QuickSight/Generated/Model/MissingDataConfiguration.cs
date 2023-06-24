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
    /// The configuration options that determine how missing data is treated during the rendering
    /// of a line chart.
    /// </summary>
    public partial class MissingDataConfiguration
    {
        private MissingDataTreatmentOption _treatmentOption;

        /// <summary>
        /// Gets and sets the property TreatmentOption. 
        /// <para>
        /// The treatment option that determines how missing data should be rendered. Choose from
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INTERPOLATE</code>: Interpolate missing values between the prior and the next
        /// known value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SHOW_AS_ZERO</code>: Show missing values as the value <code>0</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SHOW_AS_BLANK</code>: Display a blank space when rendering missing data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MissingDataTreatmentOption TreatmentOption
        {
            get { return this._treatmentOption; }
            set { this._treatmentOption = value; }
        }

        // Check to see if TreatmentOption property is set
        internal bool IsSetTreatmentOption()
        {
            return this._treatmentOption != null;
        }

    }
}