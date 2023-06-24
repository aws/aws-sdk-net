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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResponsePlan operation.
    /// Updates the specified response plan.
    /// </summary>
    public partial class UpdateResponsePlanRequest : AmazonSSMIncidentsRequest
    {
        private List<Action> _actions = new List<Action>();
        private string _arn;
        private ChatChannel _chatChannel;
        private string _clientToken;
        private string _displayName;
        private List<string> _engagements = new List<string>();
        private string _incidentTemplateDedupeString;
        private int? _incidentTemplateImpact;
        private List<NotificationTargetItem> _incidentTemplateNotificationTargets = new List<NotificationTargetItem>();
        private string _incidentTemplateSummary;
        private Dictionary<string, string> _incidentTemplateTags = new Dictionary<string, string>();
        private string _incidentTemplateTitle;
        private List<Integration> _integrations = new List<Integration>();

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions that this response plan takes at the beginning of an incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Action> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the response plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

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
        public ChatChannel ChatChannel
        {
            get { return this._chatChannel; }
            set { this._chatChannel = value; }
        }

        // Check to see if ChatChannel property is set
        internal bool IsSetChatChannel()
        {
            return this._chatChannel != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The long format name of the response plan. The display name can't contain spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Engagements. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contacts and escalation plans that the response
        /// plan engages during an incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> Engagements
        {
            get { return this._engagements; }
            set { this._engagements = value; }
        }

        // Check to see if Engagements property is set
        internal bool IsSetEngagements()
        {
            return this._engagements != null && this._engagements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplateDedupeString. 
        /// <para>
        /// The string Incident Manager uses to prevent duplicate incidents from being created
        /// by the same incident in the same account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string IncidentTemplateDedupeString
        {
            get { return this._incidentTemplateDedupeString; }
            set { this._incidentTemplateDedupeString = value; }
        }

        // Check to see if IncidentTemplateDedupeString property is set
        internal bool IsSetIncidentTemplateDedupeString()
        {
            return this._incidentTemplateDedupeString != null;
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplateImpact. 
        /// <para>
        /// Defines the impact to the customers. Providing an impact overwrites the impact provided
        /// by a response plan.
        /// </para>
        ///  <p class="title"> <b>Possible impacts:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>5</code> - Severe impact
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>4</code> - High impact
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>3</code> - Medium impact
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>2</code> - Low impact
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>1</code> - No impact
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int IncidentTemplateImpact
        {
            get { return this._incidentTemplateImpact.GetValueOrDefault(); }
            set { this._incidentTemplateImpact = value; }
        }

        // Check to see if IncidentTemplateImpact property is set
        internal bool IsSetIncidentTemplateImpact()
        {
            return this._incidentTemplateImpact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplateNotificationTargets. 
        /// <para>
        /// The Amazon SNS targets that are notified when updates are made to an incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<NotificationTargetItem> IncidentTemplateNotificationTargets
        {
            get { return this._incidentTemplateNotificationTargets; }
            set { this._incidentTemplateNotificationTargets = value; }
        }

        // Check to see if IncidentTemplateNotificationTargets property is set
        internal bool IsSetIncidentTemplateNotificationTargets()
        {
            return this._incidentTemplateNotificationTargets != null && this._incidentTemplateNotificationTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplateSummary. 
        /// <para>
        /// A brief summary of the incident. This typically contains what has happened, what's
        /// currently happening, and next steps.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8000)]
        public string IncidentTemplateSummary
        {
            get { return this._incidentTemplateSummary; }
            set { this._incidentTemplateSummary = value; }
        }

        // Check to see if IncidentTemplateSummary property is set
        internal bool IsSetIncidentTemplateSummary()
        {
            return this._incidentTemplateSummary != null;
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplateTags. 
        /// <para>
        /// Tags to assign to the template. When the <code>StartIncident</code> API action is
        /// called, Incident Manager assigns the tags specified in the template to the incident.
        /// To call this action, you must also have permission to call the <code>TagResource</code>
        /// API action for the incident record resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> IncidentTemplateTags
        {
            get { return this._incidentTemplateTags; }
            set { this._incidentTemplateTags = value; }
        }

        // Check to see if IncidentTemplateTags property is set
        internal bool IsSetIncidentTemplateTags()
        {
            return this._incidentTemplateTags != null && this._incidentTemplateTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplateTitle. 
        /// <para>
        /// The short format name of the incident. The title can't contain spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string IncidentTemplateTitle
        {
            get { return this._incidentTemplateTitle; }
            set { this._incidentTemplateTitle = value; }
        }

        // Check to see if IncidentTemplateTitle property is set
        internal bool IsSetIncidentTemplateTitle()
        {
            return this._incidentTemplateTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Integrations. 
        /// <para>
        /// Information about third-party services integrated into the response plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Integration> Integrations
        {
            get { return this._integrations; }
            set { this._integrations = value; }
        }

        // Check to see if Integrations property is set
        internal bool IsSetIntegrations()
        {
            return this._integrations != null && this._integrations.Count > 0; 
        }

    }
}