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
    /// Container for the parameters to the UpdateResponsePlan operation. Updates the specified
    /// response plan.
    /// </summary>
    public partial class UpdateResponsePlanRequest : AmazonSSMIncidentsRequest
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions that this response plan takes at the beginning of an incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<Action> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<Action>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the response plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChatChannel. 
        /// <para>
        /// The Chatbot chat channel used for collaboration during an incident.
        /// </para>
        ///  
        /// <para>
        /// Use the empty structure to remove the chat channel from the response plan.
        /// </para>
        /// </summary>
        public ChatChannel ChatChannel { get; set; }

        /// <summary>
        /// Checks to see if the ChatChannel property is set.
        /// </summary>
        internal bool IsSetChatChannel() => this.ChatChannel != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The long format name of the response plan. The display name can't contain spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Engagements. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contacts and escalation plans that the response
        /// plan engages during an incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<string> Engagements { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Engagements property is set.
        /// </summary>
        internal bool IsSetEngagements() => this.Engagements != null && (this.Engagements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncidentTemplateDedupeString. 
        /// <para>
        /// The string Incident Manager uses to prevent duplicate incidents from being created
        /// by the same incident in the same account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string IncidentTemplateDedupeString { get; set; }

        /// <summary>
        /// Checks to see if the IncidentTemplateDedupeString property is set.
        /// </summary>
        internal bool IsSetIncidentTemplateDedupeString() => this.IncidentTemplateDedupeString != null;

        /// <summary>
        /// Gets and sets the property IncidentTemplateImpact. 
        /// <para>
        /// Defines the impact to the customers. Providing an impact overwrites the impact provided
        /// by a response plan.
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
        [AWSProperty(Min = 1, Max = 5)]
        public int? IncidentTemplateImpact { get; set; }

        /// <summary>
        /// Checks to see if the IncidentTemplateImpact property is set.
        /// </summary>
        internal bool IsSetIncidentTemplateImpact() => this.IncidentTemplateImpact.HasValue;

        /// <summary>
        /// Gets and sets the property IncidentTemplateNotificationTargets. 
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
        public List<NotificationTargetItem> IncidentTemplateNotificationTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<NotificationTargetItem>() : null;

        /// <summary>
        /// Checks to see if the IncidentTemplateNotificationTargets property is set.
        /// </summary>
        internal bool IsSetIncidentTemplateNotificationTargets() => this.IncidentTemplateNotificationTargets != null && (this.IncidentTemplateNotificationTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncidentTemplateSummary. 
        /// <para>
        /// A brief summary of the incident. This typically contains what has happened, what's
        /// currently happening, and next steps.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8000)]
        public string IncidentTemplateSummary { get; set; }

        /// <summary>
        /// Checks to see if the IncidentTemplateSummary property is set.
        /// </summary>
        internal bool IsSetIncidentTemplateSummary() => this.IncidentTemplateSummary != null;

        /// <summary>
        /// Gets and sets the property IncidentTemplateTags. 
        /// <para>
        /// Tags to assign to the template. When the <c>StartIncident</c> API action is called,
        /// Incident Manager assigns the tags specified in the template to the incident. To call
        /// this action, you must also have permission to call the <c>TagResource</c> API action
        /// for the incident record resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> IncidentTemplateTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the IncidentTemplateTags property is set.
        /// </summary>
        internal bool IsSetIncidentTemplateTags() => this.IncidentTemplateTags != null && (this.IncidentTemplateTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncidentTemplateTitle. 
        /// <para>
        /// The short format name of the incident. The title can't contain spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string IncidentTemplateTitle { get; set; }

        /// <summary>
        /// Checks to see if the IncidentTemplateTitle property is set.
        /// </summary>
        internal bool IsSetIncidentTemplateTitle() => this.IncidentTemplateTitle != null;

        /// <summary>
        /// Gets and sets the property Integrations. 
        /// <para>
        /// Information about third-party services integrated into the response plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<Integration> Integrations { get; set; } = AWSConfigs.InitializeCollections ? new List<Integration>() : null;

        /// <summary>
        /// Checks to see if the Integrations property is set.
        /// </summary>
        internal bool IsSetIntegrations() => this.Integrations != null && (this.Integrations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
