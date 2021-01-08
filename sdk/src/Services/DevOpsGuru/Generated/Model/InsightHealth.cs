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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the number of open reactive and proactive insights that can be
    /// used to gauge the health of your system.
    /// </summary>
    public partial class InsightHealth
    {
        private long? _meanTimeToRecoverInMilliseconds;
        private int? _openProactiveInsights;
        private int? _openReactiveInsights;

        /// <summary>
        /// Gets and sets the property MeanTimeToRecoverInMilliseconds. 
        /// <para>
        ///  The Meant Time to Recover (MTTR) for the insight. 
        /// </para>
        /// </summary>
        public long MeanTimeToRecoverInMilliseconds
        {
            get { return this._meanTimeToRecoverInMilliseconds.GetValueOrDefault(); }
            set { this._meanTimeToRecoverInMilliseconds = value; }
        }

        // Check to see if MeanTimeToRecoverInMilliseconds property is set
        internal bool IsSetMeanTimeToRecoverInMilliseconds()
        {
            return this._meanTimeToRecoverInMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenProactiveInsights. 
        /// <para>
        ///  The number of open proactive insights. 
        /// </para>
        /// </summary>
        public int OpenProactiveInsights
        {
            get { return this._openProactiveInsights.GetValueOrDefault(); }
            set { this._openProactiveInsights = value; }
        }

        // Check to see if OpenProactiveInsights property is set
        internal bool IsSetOpenProactiveInsights()
        {
            return this._openProactiveInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenReactiveInsights. 
        /// <para>
        ///  The number of open reactive insights. 
        /// </para>
        /// </summary>
        public int OpenReactiveInsights
        {
            get { return this._openReactiveInsights.GetValueOrDefault(); }
            set { this._openReactiveInsights = value; }
        }

        // Check to see if OpenReactiveInsights property is set
        internal bool IsSetOpenReactiveInsights()
        {
            return this._openReactiveInsights.HasValue; 
        }

    }
}