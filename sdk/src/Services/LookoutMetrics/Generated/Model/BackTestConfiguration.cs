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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Settings for backtest mode.
    /// </summary>
    public partial class BackTestConfiguration
    {
        private bool? _runBackTestMode;

        /// <summary>
        /// Gets and sets the property RunBackTestMode. 
        /// <para>
        /// Run a backtest instead of monitoring new data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? RunBackTestMode
        {
            get { return this._runBackTestMode; }
            set { this._runBackTestMode = value; }
        }

        // Check to see if RunBackTestMode property is set
        internal bool IsSetRunBackTestMode()
        {
            return this._runBackTestMode.HasValue; 
        }

    }
}