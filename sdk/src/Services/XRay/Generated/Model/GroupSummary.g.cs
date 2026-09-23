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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Details for a group without metadata.
    /// </summary>
    public partial class GroupSummary
    {
        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// The filter expression defining the parameters to include traces.
        /// </para>
        /// </summary>
        public string FilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the FilterExpression property is set.
        /// </summary>
        internal bool IsSetFilterExpression() => this.FilterExpression != null;

        /// <summary>
        /// Gets and sets the property GroupARN. 
        /// <para>
        /// The ARN of the group generated based on the GroupName.
        /// </para>
        /// </summary>
        public string GroupARN { get; set; }

        /// <summary>
        /// Checks to see if the GroupARN property is set.
        /// </summary>
        internal bool IsSetGroupARN() => this.GroupARN != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The unique case-sensitive name of the group.
        /// </para>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property InsightsConfiguration. 
        /// <para>
        /// The structure containing configurations related to insights.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The InsightsEnabled boolean can be set to true to enable insights for the group or
        /// false to disable insights for the group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The NotificationsEnabled boolean can be set to true to enable insights notifications.
        /// Notifications can only be enabled on a group with InsightsEnabled set to true.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InsightsConfiguration InsightsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InsightsConfiguration property is set.
        /// </summary>
        internal bool IsSetInsightsConfiguration() => this.InsightsConfiguration != null;
    }
}
