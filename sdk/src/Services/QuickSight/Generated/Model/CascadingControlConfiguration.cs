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
    /// The values that are displayed in a control can be configured to only show values that
    /// are valid based on what's selected in other controls.
    /// </summary>
    public partial class CascadingControlConfiguration
    {
        private List<CascadingControlSource> _sourceControls = new List<CascadingControlSource>();

        /// <summary>
        /// Gets and sets the property SourceControls. 
        /// <para>
        /// A list of source controls that determine the values that are used in the current control.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<CascadingControlSource> SourceControls
        {
            get { return this._sourceControls; }
            set { this._sourceControls = value; }
        }

        // Check to see if SourceControls property is set
        internal bool IsSetSourceControls()
        {
            return this._sourceControls != null && this._sourceControls.Count > 0; 
        }

    }
}