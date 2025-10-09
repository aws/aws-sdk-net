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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Contains detailed information about an action connector, including its configuration,
    /// status, and enabled actions.
    /// </summary>
    public partial class ActionConnector
    {
        private string _actionConnectorId;
        private string _arn;
        private ReadAuthConfig _authenticationConfig;
        private DateTime? _createdTime;
        private string _description;
        private List<string> _enabledActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ActionConnectorError _error;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private ResourceStatus _status;
        private ActionConnectorType _type;
        private string _vpcConnectionArn;

        /// <summary>
        /// Gets and sets the property ActionConnectorId. 
        /// <para>
        /// The unique identifier of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ActionConnectorId
        {
            get { return this._actionConnectorId; }
            set { this._actionConnectorId = value; }
        }

        // Check to see if ActionConnectorId property is set
        internal bool IsSetActionConnectorId()
        {
            return this._actionConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AuthenticationConfig. 
        /// <para>
        /// The authentication configuration used to connect to the external service.
        /// </para>
        /// </summary>
        public ReadAuthConfig AuthenticationConfig
        {
            get { return this._authenticationConfig; }
            set { this._authenticationConfig = value; }
        }

        // Check to see if AuthenticationConfig property is set
        internal bool IsSetAuthenticationConfig()
        {
            return this._authenticationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the action connector was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledActions. 
        /// <para>
        /// The list of actions that are enabled for this connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> EnabledActions
        {
            get { return this._enabledActions; }
            set { this._enabledActions = value; }
        }

        // Check to see if EnabledActions property is set
        internal bool IsSetEnabledActions()
        {
            return this._enabledActions != null && (this._enabledActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error information if the action connector is in an error state.
        /// </para>
        /// </summary>
        public ActionConnectorError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the action connector was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the action connector.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionConnectorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionArn. 
        /// <para>
        /// The ARN of the VPC connection used for secure connectivity to the external service.
        /// </para>
        /// </summary>
        public string VpcConnectionArn
        {
            get { return this._vpcConnectionArn; }
            set { this._vpcConnectionArn = value; }
        }

        // Check to see if VpcConnectionArn property is set
        internal bool IsSetVpcConnectionArn()
        {
            return this._vpcConnectionArn != null;
        }

    }
}