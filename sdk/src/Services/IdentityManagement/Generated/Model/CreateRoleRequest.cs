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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRole operation.
    /// Creates a new role for your Amazon Web Services account. For more information about
    /// roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">IAM
    /// roles</a>. For information about quotas for role names and the number of roles you
    /// can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
    /// and STS quotas</a> in the <i>IAM User Guide</i>.
    /// </summary>
    public partial class CreateRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _assumeRolePolicyDocument;
        private string _description;
        private int? _maxSessionDuration;
        private string _path;
        private string _permissionsBoundary;
        private string _roleName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocument. 
        /// <para>
        /// The trust relationship policy document that grants an entity permission to assume
        /// the role.
        /// </para>
        ///  
        /// <para>
        /// In IAM, you must provide a JSON policy that has been converted to a string. However,
        /// for CloudFormation templates formatted in YAML, you can provide the policy in JSON
        /// or YAML format. CloudFormation always converts a YAML policy to JSON format before
        /// submitting it to IAM.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Upon success, the response includes the same trust policy in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=131072)]
        public string AssumeRolePolicyDocument
        {
            get { return this._assumeRolePolicyDocument; }
            set { this._assumeRolePolicyDocument = value; }
        }

        // Check to see if AssumeRolePolicyDocument property is set
        internal bool IsSetAssumeRolePolicyDocument()
        {
            return this._assumeRolePolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the role.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum session duration (in seconds) that you want to set for the specified role.
        /// If you do not specify a value for this setting, the default value of one hour is applied.
        /// This setting can have a value from 1 hour to 12 hours.
        /// </para>
        ///  
        /// <para>
        /// Anyone who assumes the role from the CLI or API can use the <code>DurationSeconds</code>
        /// API parameter or the <code>duration-seconds</code> CLI parameter to request a longer
        /// session. The <code>MaxSessionDuration</code> setting determines the maximum duration
        /// that can be requested using the <code>DurationSeconds</code> parameter. If users don't
        /// specify a value for the <code>DurationSeconds</code> parameter, their security credentials
        /// are valid for one hour by default. This applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI operations but does not apply
        /// when you use those operations to create a console URL. For more information, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3600, Max=43200)]
        public int MaxSessionDuration
        {
            get { return this._maxSessionDuration.GetValueOrDefault(); }
            set { this._maxSessionDuration = value; }
        }

        // Check to see if MaxSessionDuration property is set
        internal bool IsSetMaxSessionDuration()
        {
            return this._maxSessionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the role. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of either a forward slash (/) by itself
        /// or a string that must begin and end with forward slashes. In addition, it can contain
        /// any ASCII character from the ! (<code>\u0021</code>) through the DEL character (<code>\u007F</code>),
        /// including most punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsBoundary. 
        /// <para>
        /// The ARN of the managed policy that is used to set the permissions boundary for the
        /// role.
        /// </para>
        ///  
        /// <para>
        /// A permissions boundary policy defines the maximum permissions that identity-based
        /// policies can grant to an entity, but does not grant permissions. Permissions boundaries
        /// do not define the maximum permissions that a resource-based policy can grant to an
        /// entity. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
        /// boundaries for IAM entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#access_policy-types">Policy
        /// types </a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PermissionsBoundary
        {
            get { return this._permissionsBoundary; }
            set { this._permissionsBoundary = value; }
        }

        // Check to see if PermissionsBoundary property is set
        internal bool IsSetPermissionsBoundary()
        {
            return this._permissionsBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to create.
        /// </para>
        ///  
        /// <para>
        /// IAM user, group, role, and policy names must be unique within the account. Names are
        /// not distinguished by case. For example, you cannot create resources named both "MyResource"
        /// and "myresource".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the new role. Each tag consists of a key
        /// name and an associated value. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}