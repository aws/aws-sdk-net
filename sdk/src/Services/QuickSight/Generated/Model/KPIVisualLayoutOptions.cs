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
    /// The options that determine the layout a KPI visual.
    /// </summary>
    public partial class KPIVisualLayoutOptions
    {
        private KPIVisualStandardLayout _standardLayout;

        /// <summary>
        /// Gets and sets the property StandardLayout. 
        /// <para>
        /// The standard layout of the KPI visual.
        /// </para>
        /// </summary>
        public KPIVisualStandardLayout StandardLayout
        {
            get { return this._standardLayout; }
            set { this._standardLayout = value; }
        }

        // Check to see if StandardLayout property is set
        internal bool IsSetStandardLayout()
        {
            return this._standardLayout != null;
        }

    }
}