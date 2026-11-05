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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Schedule of the campaign.
    /// </summary>
    public partial class InAppCampaignSchedule
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The scheduled time after which the in-app message should not be shown. Timestamp is
        /// in ISO 8601 format.
        /// </para>
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate != null;

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// The event filter the SDK has to use to show the in-app message in the application.
        /// </para>
        /// </summary>
        public CampaignEventFilter EventFilter { get; set; }

        /// <summary>
        /// Checks to see if the EventFilter property is set.
        /// </summary>
        internal bool IsSetEventFilter() => this.EventFilter != null;

        /// <summary>
        /// Gets and sets the property QuietTime. 
        /// <para>
        /// Time during which the in-app message should not be shown to the user.
        /// </para>
        /// </summary>
        public QuietTime QuietTime { get; set; }

        /// <summary>
        /// Checks to see if the QuietTime property is set.
        /// </summary>
        internal bool IsSetQuietTime() => this.QuietTime != null;
    }
}
