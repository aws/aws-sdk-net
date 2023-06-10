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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// The state of the profile after a read or write operation.
    /// </summary>
    public partial class ProfileDetail
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private int? _durationSeconds;
        private bool? _enabled;
        private List<string> _managedPolicyArns = new List<string>();
        private string _name;
        private string _profileArn;
        private string _profileId;
        private bool? _requireInstanceProperties;
        private List<string> _roleArns = new List<string>();
        private string _sessionPolicy;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the profile was created. 
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
        /// The Amazon Web Services account that created the profile.
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
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        ///  The number of seconds the vended session credentials are valid for. 
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the profile is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedPolicyArns. 
        /// <para>
        /// A list of managed policy ARNs that apply to the vended session credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> ManagedPolicyArns
        {
            get { return this._managedPolicyArns; }
            set { this._managedPolicyArns = value; }
        }

        // Check to see if ManagedPolicyArns property is set
        internal bool IsSetManagedPolicyArns()
        {
            return this._managedPolicyArns != null && this._managedPolicyArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The ARN of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property RequireInstanceProperties. 
        /// <para>
        /// Specifies whether instance properties are required in temporary credential requests
        /// with this profile. 
        /// </para>
        /// </summary>
        public bool RequireInstanceProperties
        {
            get { return this._requireInstanceProperties.GetValueOrDefault(); }
            set { this._requireInstanceProperties = value; }
        }

        // Check to see if RequireInstanceProperties property is set
        internal bool IsSetRequireInstanceProperties()
        {
            return this._requireInstanceProperties.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArns. 
        /// <para>
        /// A list of IAM roles that this profile can assume in a temporary credential request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> RoleArns
        {
            get { return this._roleArns; }
            set { this._roleArns = value; }
        }

        // Check to see if RoleArns property is set
        internal bool IsSetRoleArns()
        {
            return this._roleArns != null && this._roleArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionPolicy. 
        /// <para>
        /// A session policy that applies to the trust boundary of the vended session credentials.
        /// 
        /// </para>
        /// </summary>
        public string SessionPolicy
        {
            get { return this._sessionPolicy; }
            set { this._sessionPolicy = value; }
        }

        // Check to see if SessionPolicy property is set
        internal bool IsSetSessionPolicy()
        {
            return this._sessionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the profile was last updated. 
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

    }
}