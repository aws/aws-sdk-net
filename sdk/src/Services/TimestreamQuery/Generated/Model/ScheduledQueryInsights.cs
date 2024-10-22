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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Encapsulates settings for enabling <c>QueryInsights</c> on an <c>ExecuteScheduledQueryRequest</c>.
    /// </summary>
    public partial class ScheduledQueryInsights
    {
        private ScheduledQueryInsightsMode _mode;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Provides the following modes to enable <c>ScheduledQueryInsights</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED_WITH_RATE_CONTROL</c> – Enables <c>ScheduledQueryInsights</c> for the
        /// queries being processed. This mode also includes a rate control mechanism, which limits
        /// the <c>QueryInsights</c> feature to 1 query per second (QPS).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Disables <c>ScheduledQueryInsights</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledQueryInsightsMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}