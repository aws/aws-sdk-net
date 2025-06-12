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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfile operation.
    /// Updates a <i>profile</i>, a list of the roles that IAM Roles Anywhere service is trusted
    /// to assume. You use profiles to intersect permissions with IAM managed policies.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateProfile</c>. 
    /// </para>
    /// </summary>
    public partial class UpdateProfileRequest : AmazonIAMRolesAnywhereRequest
    {
        private bool? _acceptRoleSessionName;
        private int? _durationSeconds;
        private List<string> _managedPolicyArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _profileId;
        private List<string> _roleArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sessionPolicy;

        /// <summary>
        /// Gets and sets the property AcceptRoleSessionName. 
        /// <para>
        /// Used to determine if a custom role session name will be accepted in a temporary credential
        /// request.
        /// </para>
        /// </summary>
        public bool? AcceptRoleSessionName
        {
            get { return this._acceptRoleSessionName; }
            set { this._acceptRoleSessionName = value; }
        }

        // Check to see if AcceptRoleSessionName property is set
        internal bool IsSetAcceptRoleSessionName()
        {
            return this._acceptRoleSessionName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        ///  Used to determine how long sessions vended using this profile are valid for. See
        /// the <c>Expiration</c> section of the <a href="https://docs.aws.amazon.com/rolesanywhere/latest/userguide/authentication-create-session.html#credentials-object">CreateSession
        /// API documentation</a> page for more details. In requests, if this value is not provided,
        /// the default value will be 3600. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=43200)]
        public int? DurationSeconds
        {
            get { return this._durationSeconds; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._managedPolicyArns != null && (this._managedPolicyArns.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> RoleArns
        {
            get { return this._roleArns; }
            set { this._roleArns = value; }
        }

        // Check to see if RoleArns property is set
        internal bool IsSetRoleArns()
        {
            return this._roleArns != null && (this._roleArns.Count > 0 || !AWSConfigs.InitializeCollections); 
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