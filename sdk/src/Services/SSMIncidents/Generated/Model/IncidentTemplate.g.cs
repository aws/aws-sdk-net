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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Basic details used in creating a response plan. The response plan is then used to
    /// create an incident record.
    /// </summary>
    public partial class IncidentTemplate
    {
        /// <summary>
        /// Gets and sets the property DedupeString. 
        /// <para>
        /// The string Incident Manager uses to prevent the same root cause from creating multiple
        /// incidents in the same account.
        /// </para>
        ///  
        /// <para>
        /// A deduplication string is a term or phrase the system uses to check for duplicate
        /// incidents. If you specify a deduplication string, Incident Manager searches for open
        /// incidents that contain the same string in the <c>dedupeString</c> field when it creates
        /// the incident. If a duplicate is detected, Incident Manager deduplicates the newer
        /// incident into the existing incident.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, Incident Manager automatically deduplicates multiple incidents created
        /// by the same Amazon CloudWatch alarm or Amazon EventBridge event. You don't have to
        /// enter your own deduplication string to prevent duplication for these resource types.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string DedupeString { get; set; }

        /// <summary>
        /// Checks to see if the DedupeString property is set.
        /// </summary>
        internal bool IsSetDedupeString() => this.DedupeString != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The impact of the incident on your customers and applications.
        /// </para>
        ///  
        /// <para>
        ///  <b>Supported impact codes</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>1</c> - Critical
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2</c> - High
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>3</c> - Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>4</c> - Low
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>5</c> - No Impact
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public int? Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact.HasValue;

        /// <summary>
        /// Gets and sets the property IncidentTags. 
        /// <para>
        /// Tags to assign to the template. When the <c>StartIncident</c> API action is called,
        /// Incident Manager assigns the tags specified in the template to the incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> IncidentTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the IncidentTags property is set.
        /// </summary>
        internal bool IsSetIncidentTags() => this.IncidentTags != null && (this.IncidentTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationTargets. 
        /// <para>
        /// The Amazon SNS targets that are notified when updates are made to an incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<NotificationTargetItem> NotificationTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<NotificationTargetItem>() : null;

        /// <summary>
        /// Checks to see if the NotificationTargets property is set.
        /// </summary>
        internal bool IsSetNotificationTargets() => this.NotificationTargets != null && (this.NotificationTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// The summary of the incident. The summary is a brief synopsis of what occurred, what's
        /// currently happening, and context.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8000)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the incident. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
