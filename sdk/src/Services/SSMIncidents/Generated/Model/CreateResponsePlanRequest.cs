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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResponsePlan operation.
    /// Creates a response plan that automates the initial response to incidents. A response
    /// plan engages contacts, starts chat channel collaboration, and initiates runbooks at
    /// the beginning of an incident.
    /// </summary>
    public partial class CreateResponsePlanRequest : AmazonSSMIncidentsRequest
    {
        private List<Action> _actions = AWSConfigs.InitializeCollections ? new List<Action>() : null;
        private ChatChannel _chatChannel;
        private string _clientToken;
        private string _displayName;
        private List<string> _engagements = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IncidentTemplate _incidentTemplate;
        private List<Integration> _integrations = AWSConfigs.InitializeCollections ? new List<Integration>() : null;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions that the response plan starts at the beginning of an incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChatChannel. 
        /// <para>
        /// The Chatbot chat channel used for collaboration during an incident.
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
        /// The long format of the response plan name. This field can contain spaces.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._engagements != null && (this._engagements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplate. 
        /// <para>
        /// Details used to create an incident when using this response plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncidentTemplate IncidentTemplate
        {
            get { return this._incidentTemplate; }
            set { this._incidentTemplate = value; }
        }

        // Check to see if IncidentTemplate property is set
        internal bool IsSetIncidentTemplate()
        {
            return this._incidentTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Integrations. 
        /// <para>
        /// Information about third-party services integrated into the response plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._integrations != null && (this._integrations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The short format name of the response plan. Can't include spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you are adding to the response plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}