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
    /// Used to filter for insights that have any status.
    /// </summary>
    public partial class ListInsightsAnyStatusFilter
    {
        private StartTimeRange _startTimeRange;
        private InsightType _type;

        /// <summary>
        /// Gets and sets the property StartTimeRange. 
        /// <para>
        ///  A time range used to specify when the behavior of the filtered insights started.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StartTimeRange StartTimeRange
        {
            get { return this._startTimeRange; }
            set { this._startTimeRange = value; }
        }

        // Check to see if StartTimeRange property is set
        internal bool IsSetStartTimeRange()
        {
            return this._startTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Use to filter for either <code>REACTIVE</code> or <code>PROACTIVE</code> insights.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InsightType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}