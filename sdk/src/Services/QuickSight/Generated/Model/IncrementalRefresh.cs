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
    /// The incremental refresh configuration for a dataset.
    /// </summary>
    public partial class IncrementalRefresh
    {
        private LookbackWindow _lookbackWindow;

        /// <summary>
        /// Gets and sets the property LookbackWindow. 
        /// <para>
        /// The lookback window setup for an incremental refresh configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LookbackWindow LookbackWindow
        {
            get { return this._lookbackWindow; }
            set { this._lookbackWindow = value; }
        }

        // Check to see if LookbackWindow property is set
        internal bool IsSetLookbackWindow()
        {
            return this._lookbackWindow != null;
        }

    }
}