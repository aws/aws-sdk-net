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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// A custom 10-hour, low-traffic window during which OpenSearch Service can perform mandatory
    /// configuration changes on the domain. These actions can include scheduled service software
    /// updates and blue/green Auto-Tune enhancements. OpenSearch Service will schedule these
    /// actions during the window that you specify.
    /// 
    ///  
    /// <para>
    /// If you don't specify a window start time, it defaults to 10:00 P.M. local time.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html">Defining
    /// off-peak maintenance windows for Amazon OpenSearch Service</a>.
    /// </para>
    /// </summary>
    public partial class OffPeakWindow
    {
        private WindowStartTime _windowStartTime;

        /// <summary>
        /// Gets and sets the property WindowStartTime. 
        /// <para>
        /// A custom start time for the off-peak window, in Coordinated Universal Time (UTC).
        /// The window length will always be 10 hours, so you can't specify an end time. For example,
        /// if you specify 11:00 P.M. UTC as a start time, the end time will automatically be
        /// set to 9:00 A.M.
        /// </para>
        /// </summary>
        public WindowStartTime WindowStartTime
        {
            get { return this._windowStartTime; }
            set { this._windowStartTime = value; }
        }

        // Check to see if WindowStartTime property is set
        internal bool IsSetWindowStartTime()
        {
            return this._windowStartTime != null;
        }

    }
}