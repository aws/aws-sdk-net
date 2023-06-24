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
    /// Container for the parameters to the UpdateProfile operation.
    /// Updates a <i>profile</i>, a list of the roles that IAM Roles Anywhere service is trusted
    /// to assume. You use profiles to intersect permissions with IAM managed policies.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateProfile</code>. 
    /// </para>
    /// </summary>
    public partial class UpdateProfileRequest : AmazonIAMRolesAnywhereRequest
    {
        private int? _durationSeconds;
        private List<string> _managedPolicyArns = new List<string>();
        private string _name;
        private string _profileId;
        private List<string> _roleArns = new List<string>();
        private string _sessionPolicy;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        ///  The number of seconds the vended session credentials are valid for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=3600)]
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
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        [AWSProperty(Min=1, Max=100000)]
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

    }
}