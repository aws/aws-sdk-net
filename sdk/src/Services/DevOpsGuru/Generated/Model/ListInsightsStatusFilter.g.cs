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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// A filter used by <c>ListInsights</c> to specify which insights to return.
    /// </summary>
    public partial class ListInsightsStatusFilter
    {
        /// <summary>
        /// Gets and sets the property Any. 
        /// <para>
        ///  A <c>ListInsightsAnyStatusFilter</c> that specifies insights of any status that are
        /// either <c>REACTIVE</c> or <c>PROACTIVE</c>. 
        /// </para>
        /// </summary>
        public ListInsightsAnyStatusFilter Any { get; set; }

        /// <summary>
        /// Checks to see if the Any property is set.
        /// </summary>
        internal bool IsSetAny() => this.Any != null;

        /// <summary>
        /// Gets and sets the property Closed. 
        /// <para>
        ///  A <c>ListInsightsClosedStatusFilter</c> that specifies closed insights that are either
        /// <c>REACTIVE</c> or <c>PROACTIVE</c>. 
        /// </para>
        /// </summary>
        public ListInsightsClosedStatusFilter Closed { get; set; }

        /// <summary>
        /// Checks to see if the Closed property is set.
        /// </summary>
        internal bool IsSetClosed() => this.Closed != null;

        /// <summary>
        /// Gets and sets the property Ongoing. 
        /// <para>
        ///  A <c>ListInsightsAnyStatusFilter</c> that specifies ongoing insights that are either
        /// <c>REACTIVE</c> or <c>PROACTIVE</c>. 
        /// </para>
        /// </summary>
        public ListInsightsOngoingStatusFilter Ongoing { get; set; }

        /// <summary>
        /// Checks to see if the Ongoing property is set.
        /// </summary>
        internal bool IsSetOngoing() => this.Ongoing != null;
    }
}
