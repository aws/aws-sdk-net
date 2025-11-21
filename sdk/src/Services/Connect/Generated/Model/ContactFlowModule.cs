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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about a flow module.
    /// </summary>
    public partial class ContactFlowModule
    {
        private string _arn;
        private string _content;
        private string _description;
        private ExternalInvocationConfiguration _externalInvocationConfiguration;
        private string _flowModuleContentSha256;
        private string _id;
        private string _name;
        private string _settings;
        private ContactFlowModuleState _state;
        private ContactFlowModuleStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _version;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN).
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
        /// Gets and sets the property Content. 
        /// <para>
        /// The JSON string that represents the content of the flow. For an example, see <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language-example.html">Example
        /// flow in Amazon Connect Flow language</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property ExternalInvocationConfiguration. 
        /// <para>
        /// The external invocation configuration for the flow module
        /// </para>
        /// </summary>
        public ExternalInvocationConfiguration ExternalInvocationConfiguration
        {
            get { return this._externalInvocationConfiguration; }
            set { this._externalInvocationConfiguration = value; }
        }

        // Check to see if ExternalInvocationConfiguration property is set
        internal bool IsSetExternalInvocationConfiguration()
        {
            return this._externalInvocationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FlowModuleContentSha256. 
        /// <para>
        /// Hash of the module content for integrity verification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FlowModuleContentSha256
        {
            get { return this._flowModuleContentSha256; }
            set { this._flowModuleContentSha256 = value; }
        }

        // Check to see if FlowModuleContentSha256 property is set
        internal bool IsSetFlowModuleContentSha256()
        {
            return this._flowModuleContentSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// The configuration settings for the flow module.
        /// </para>
        /// </summary>
        public string Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The type of flow module.
        /// </para>
        /// </summary>
        public ContactFlowModuleState State
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the flow module.
        /// </para>
        /// </summary>
        public ContactFlowModuleStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// Description of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}