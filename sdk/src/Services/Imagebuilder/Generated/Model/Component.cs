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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A detailed view of a component.
    /// </summary>
    public partial class Component
    {
        private string _arn;
        private string _changeDescription;
        private string _data;
        private string _dateCreated;
        private string _description;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _name;
        private bool? _obfuscate;
        private string _owner;
        private List<ComponentParameterDetail> _parameters = new List<ComponentParameterDetail>();
        private Platform _platform;
        private string _publisher;
        private ComponentState _state;
        private List<string> _supportedOsVersions = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private ComponentType _type;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the component.
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
        /// Gets and sets the property ChangeDescription. 
        /// <para>
        /// The change description of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ChangeDescription
        {
            get { return this._changeDescription; }
            set { this._changeDescription = value; }
        }

        // Check to see if ChangeDescription property is set
        internal bool IsSetChangeDescription()
        {
            return this._changeDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Component data contains the YAML document content for the component.
        /// </para>
        /// </summary>
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date that Image Builder created the component.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// The encryption status of the component.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier used to encrypt the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Obfuscate. 
        /// <para>
        /// Indicates whether component source is hidden from view in the console, and from component
        /// detail results for API, CLI, or SDK operations.
        /// </para>
        /// </summary>
        public bool Obfuscate
        {
            get { return this._obfuscate.GetValueOrDefault(); }
            set { this._obfuscate = value; }
        }

        // Check to see if Obfuscate property is set
        internal bool IsSetObfuscate()
        {
            return this._obfuscate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Contains parameter details for each of the parameters that the component document
        /// defined for the component.
        /// </para>
        /// </summary>
        public List<ComponentParameterDetail> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the component.
        /// </para>
        /// </summary>
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Publisher. 
        /// <para>
        /// Contains the name of the publisher if this is a third-party component. Otherwise,
        /// this property is empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }

        // Check to see if Publisher property is set
        internal bool IsSetPublisher()
        {
            return this._publisher != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Describes the current status of the component. This is used for components that are
        /// no longer active.
        /// </para>
        /// </summary>
        public ComponentState State
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
        /// Gets and sets the property SupportedOsVersions. 
        /// <para>
        /// The operating system (OS) version supported by the component. If the OS information
        /// is available, Image Builder performs a prefix match against the base image OS version
        /// during image recipe creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> SupportedOsVersions
        {
            get { return this._supportedOsVersions; }
            set { this._supportedOsVersions = value; }
        }

        // Check to see if SupportedOsVersions property is set
        internal bool IsSetSupportedOsVersions()
        {
            return this._supportedOsVersions != null && this._supportedOsVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply to the component.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The component type specifies whether Image Builder uses the component to build the
        /// image or only to test it.
        /// </para>
        /// </summary>
        public ComponentType Type
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}