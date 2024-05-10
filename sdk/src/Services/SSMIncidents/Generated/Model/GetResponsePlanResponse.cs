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
    /// This is the response object from the GetResponsePlan operation.
    /// </summary>
    public partial class GetResponsePlanResponse : AmazonWebServiceResponse
    {
        private List<Action> _actions = AWSConfigs.InitializeCollections ? new List<Action>() : null;
        private string _arn;
        private ChatChannel _chatChannel;
        private string _displayName;
        private List<string> _engagements = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IncidentTemplate _incidentTemplate;
        private List<Integration> _integrations = AWSConfigs.InitializeCollections ? new List<Integration>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions that this response plan takes at the beginning of the incident.
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
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the response plan.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The long format name of the response plan. Can contain spaces.
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
            return this._engagements != null && (this._engagements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncidentTemplate. 
        /// <para>
        /// Details used to create the incident when using this response plan.
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
        /// Information about third-party services integrated into the Incident Manager response
        /// plan.
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
            return this._integrations != null && (this._integrations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The short format name of the response plan. The name can't contain spaces.
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

    }
}