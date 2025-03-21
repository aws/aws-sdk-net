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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the AddRoleToInstanceProfile operation.
    /// Adds the specified IAM role to the specified instance profile. An instance profile
    /// can contain only one role, and this quota cannot be increased. You can remove the
    /// existing role and then add a different role to an instance profile. You must then
    /// wait for the change to appear across all of Amazon Web Services because of <a href="https://en.wikipedia.org/wiki/Eventual_consistency">eventual
    /// consistency</a>. To force the change, you must <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DisassociateIamInstanceProfile.html">disassociate
    /// the instance profile</a> and then <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_AssociateIamInstanceProfile.html">associate
    /// the instance profile</a>, or you can stop your instance and then restart it.
    /// 
    ///  <note> 
    /// <para>
    /// The caller of this operation must be granted the <c>PassRole</c> permission on the
    /// IAM role by a permissions policy.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// When using the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#available-keys-for-iam">iam:AssociatedResourceArn</a>
    /// condition in a policy to restrict the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">PassRole</a>
    /// IAM action, special considerations apply if the policy is intended to define access
    /// for the <c>AddRoleToInstanceProfile</c> action. In this case, you cannot specify a
    /// Region or instance ID in the EC2 instance ARN. The ARN value must be <c>arn:aws:ec2:*:CallerAccountId:instance/*</c>.
    /// Using any other ARN value may lead to unexpected evaluation results.
    /// </para>
    ///  </important> 
    /// <para>
    ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
    /// roles</a> in the <i>IAM User Guide</i>. For more information about instance profiles,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
    /// instance profiles</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AddRoleToInstanceProfileRequest : AmazonIdentityManagementServiceRequest
    {
        private string _instanceProfileName;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// The name of the instance profile to update.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string InstanceProfileName
        {
            get { return this._instanceProfileName; }
            set { this._instanceProfileName = value; }
        }

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this._instanceProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to add.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
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

    }
}