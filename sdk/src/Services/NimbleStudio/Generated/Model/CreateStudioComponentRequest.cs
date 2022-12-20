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
    /// Container for the parameters to the CreateStudioComponent operation.
    /// Creates a studio component resource.
    /// </summary>
    public partial class CreateStudioComponentRequest : AmazonNimbleStudioRequest
    {
        private string _clientToken;
        private StudioComponentConfiguration _configuration;
        private string _description;
        private List<string> _ec2SecurityGroupIds = new List<string>();
        private List<StudioComponentInitializationScript> _initializationScripts = new List<StudioComponentInitializationScript>();
        private string _name;
        private string _runtimeRoleArn;
        private List<ScriptParameterKeyValue> _scriptParameters = new List<ScriptParameterKeyValue>();
        private string _secureInitializationRoleArn;
        private string _studioId;
        private StudioComponentSubtype _subtype;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private StudioComponentType _type;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If you don’t specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The name for the studio component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
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
        [AWSProperty(Min=0, Max=30)]
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
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The studio ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
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
        [AWSProperty(Required=true)]
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

    }
}