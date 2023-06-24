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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// A studio component represents a network resource to be used by a studio's users and
    /// workflows. A typical studio contains studio components for each of the following:
    /// render farm, Active Directory, licensing, and file system.
    /// 
    ///  
    /// <para>
    /// Access to a studio component is managed by specifying security groups for the resource,
    /// as well as its endpoint.
    /// </para>
    ///  
    /// <para>
    /// A studio component also has a set of initialization scripts that are returned by <code>GetLaunchProfileInitialization</code>.
    /// These initialization scripts run on streaming sessions when they start. They provide
    /// users with flexibility in controlling how the studio resources are configured on a
    /// streaming session.
    /// </para>
    /// </summary>
    public partial class StudioComponent
    {
        private string _arn;
        private StudioComponentConfiguration _configuration;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private List<string> _ec2SecurityGroupIds = new List<string>();
        private List<StudioComponentInitializationScript> _initializationScripts = new List<StudioComponentInitializationScript>();
        private string _name;
        private string _runtimeRoleArn;
        private List<ScriptParameterKeyValue> _scriptParameters = new List<ScriptParameterKeyValue>();
        private string _secureInitializationRoleArn;
        private StudioComponentState _state;
        private StudioComponentStatusCode _statusCode;
        private string _statusMessage;
        private string _studioComponentId;
        private StudioComponentSubtype _subtype;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private StudioComponentType _type;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is assigned to a studio resource and uniquely
        /// identifies it. ARNs are unique across all Regions.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the studio component, based on component type.
        /// </para>
        /// </summary>
        public StudioComponentConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO timestamp in seconds for when the resource was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user ID of the user that created the studio component.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description for the studio component resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
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
        /// Gets and sets the property Ec2SecurityGroupIds. 
        /// <para>
        /// The EC2 security groups that control access to the studio component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<string> Ec2SecurityGroupIds
        {
            get { return this._ec2SecurityGroupIds; }
            set { this._ec2SecurityGroupIds = value; }
        }

        // Check to see if Ec2SecurityGroupIds property is set
        internal bool IsSetEc2SecurityGroupIds()
        {
            return this._ec2SecurityGroupIds != null && this._ec2SecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InitializationScripts. 
        /// <para>
        /// Initialization scripts for studio components.
        /// </para>
        /// </summary>
        public List<StudioComponentInitializationScript> InitializationScripts
        {
            get { return this._initializationScripts; }
            set { this._initializationScripts = value; }
        }

        // Check to see if InitializationScripts property is set
        internal bool IsSetInitializationScripts()
        {
            return this._initializationScripts != null && this._initializationScripts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for the studio component resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=64)]
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
        /// Gets and sets the property RuntimeRoleArn. 
        /// <para>
        /// An IAM role attached to a Studio Component that gives the studio component access
        /// to Amazon Web Services resources at anytime while the instance is running. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RuntimeRoleArn
        {
            get { return this._runtimeRoleArn; }
            set { this._runtimeRoleArn = value; }
        }

        // Check to see if RuntimeRoleArn property is set
        internal bool IsSetRuntimeRoleArn()
        {
            return this._runtimeRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptParameters. 
        /// <para>
        /// Parameters for the studio component scripts.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=30)]
        public List<ScriptParameterKeyValue> ScriptParameters
        {
            get { return this._scriptParameters; }
            set { this._scriptParameters = value; }
        }

        // Check to see if ScriptParameters property is set
        internal bool IsSetScriptParameters()
        {
            return this._scriptParameters != null && this._scriptParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecureInitializationRoleArn. 
        /// <para>
        /// An IAM role attached to Studio Component when the system initialization script runs
        /// which give the studio component access to Amazon Web Services resources when the system
        /// initialization script runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SecureInitializationRoleArn
        {
            get { return this._secureInitializationRoleArn; }
            set { this._secureInitializationRoleArn = value; }
        }

        // Check to see if SecureInitializationRoleArn property is set
        internal bool IsSetSecureInitializationRoleArn()
        {
            return this._secureInitializationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state.
        /// </para>
        /// </summary>
        public StudioComponentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code.
        /// </para>
        /// </summary>
        public StudioComponentStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the studio component.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StudioComponentId. 
        /// <para>
        /// The unique identifier for a studio component resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string StudioComponentId
        {
            get { return this._studioComponentId; }
            set { this._studioComponentId = value; }
        }

        // Check to see if StudioComponentId property is set
        internal bool IsSetStudioComponentId()
        {
            return this._studioComponentId != null;
        }

        /// <summary>
        /// Gets and sets the property Subtype. 
        /// <para>
        /// The specific subtype of a studio component.
        /// </para>
        /// </summary>
        public StudioComponentSubtype Subtype
        {
            get { return this._subtype; }
            set { this._subtype = value; }
        }

        // Check to see if Subtype property is set
        internal bool IsSetSubtype()
        {
            return this._subtype != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of labels, in the form of key-value pairs, that apply to this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the studio component.
        /// </para>
        /// </summary>
        public StudioComponentType Type
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO timestamp in seconds for when the resource was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user ID of the user that most recently updated the resource.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}