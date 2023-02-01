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
    /// A launch profile controls your artist workforce’s access to studio components, like
    /// compute farms, shared file systems, managed file systems, and license server configurations,
    /// as well as instance types and Amazon Machine Images (AMIs). 
    /// 
    ///  
    /// <para>
    /// Studio administrators create launch profiles in the Nimble Studio console. Artists
    /// can use their launch profiles to launch an instance from the Nimble Studio portal.
    /// Each user’s launch profile defines how they can launch a streaming session. By default,
    /// studio admins can use all launch profiles.
    /// </para>
    /// </summary>
    public partial class LaunchProfile
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private List<string> _ec2SubnetIds = new List<string>();
        private string _launchProfileId;
        private List<string> _launchProfileProtocolVersions = new List<string>();
        private string _name;
        private LaunchProfileState _state;
        private LaunchProfileStatusCode _statusCode;
        private string _statusMessage;
        private StreamConfiguration _streamConfiguration;
        private List<string> _studioComponentIds = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updatedAt;
        private string _updatedBy;
        private List<ValidationResult> _validationResults = new List<ValidationResult>();

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
        /// The user ID of the user that created the launch profile.
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
        /// A human-readable description of the launch profile.
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
        /// Gets and sets the property Ec2SubnetIds. 
        /// <para>
        /// Unique identifiers for a collection of EC2 subnets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public List<string> Ec2SubnetIds
        {
            get { return this._ec2SubnetIds; }
            set { this._ec2SubnetIds = value; }
        }

        // Check to see if Ec2SubnetIds property is set
        internal bool IsSetEc2SubnetIds()
        {
            return this._ec2SubnetIds != null && this._ec2SubnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileId. 
        /// <para>
        /// The ID of the launch profile used to control access from the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string LaunchProfileId
        {
            get { return this._launchProfileId; }
            set { this._launchProfileId = value; }
        }

        // Check to see if LaunchProfileId property is set
        internal bool IsSetLaunchProfileId()
        {
            return this._launchProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileProtocolVersions. 
        /// <para>
        /// The version number of the protocol that is used by the launch profile. The only valid
        /// version is "2021-03-31".
        /// </para>
        /// </summary>
        public List<string> LaunchProfileProtocolVersions
        {
            get { return this._launchProfileProtocolVersions; }
            set { this._launchProfileProtocolVersions = value; }
        }

        // Check to see if LaunchProfileProtocolVersions property is set
        internal bool IsSetLaunchProfileProtocolVersions()
        {
            return this._launchProfileProtocolVersions != null && this._launchProfileProtocolVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for the launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state.
        /// </para>
        /// </summary>
        public LaunchProfileState State
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
        public LaunchProfileStatusCode StatusCode
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
        /// The status message for the launch profile.
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
        /// Gets and sets the property StreamConfiguration. 
        /// <para>
        /// A configuration for a streaming session.
        /// </para>
        /// </summary>
        public StreamConfiguration StreamConfiguration
        {
            get { return this._streamConfiguration; }
            set { this._streamConfiguration = value; }
        }

        // Check to see if StreamConfiguration property is set
        internal bool IsSetStreamConfiguration()
        {
            return this._streamConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StudioComponentIds. 
        /// <para>
        /// Unique identifiers for a collection of studio components that can be used with this
        /// launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> StudioComponentIds
        {
            get { return this._studioComponentIds; }
            set { this._studioComponentIds = value; }
        }

        // Check to see if StudioComponentIds property is set
        internal bool IsSetStudioComponentIds()
        {
            return this._studioComponentIds != null && this._studioComponentIds.Count > 0; 
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

        /// <summary>
        /// Gets and sets the property ValidationResults. 
        /// <para>
        /// The list of the latest validation results.
        /// </para>
        /// </summary>
        public List<ValidationResult> ValidationResults
        {
            get { return this._validationResults; }
            set { this._validationResults = value; }
        }

        // Check to see if ValidationResults property is set
        internal bool IsSetValidationResults()
        {
            return this._validationResults != null && this._validationResults.Count > 0; 
        }

    }
}