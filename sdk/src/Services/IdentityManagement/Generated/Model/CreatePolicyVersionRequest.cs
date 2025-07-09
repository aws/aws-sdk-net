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
    /// Container for the parameters to the CreatePolicyVersion operation.
    /// Creates a new version of the specified managed policy. To update a managed policy,
    /// you create a new policy version. A managed policy can have up to five versions. If
    /// the policy has five versions, you must delete an existing version using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicyVersion.html">DeletePolicyVersion</a>
    /// before you create a new version.
    /// 
    ///  
    /// <para>
    /// Optionally, you can set the new version as the policy's default version. The default
    /// version is the version that is in effect for the IAM users, groups, and roles to which
    /// the policy is attached.
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
    /// for managed policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreatePolicyVersionRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyArn;
        private string _policyDocument;
        private bool? _setAsDefault;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM policy to which you want to add a new version.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON policy document that you want to use as the content for this new version
        /// of the policy.
        /// </para>
        ///  
        /// <para>
        /// You must provide policies in JSON format in IAM. However, for CloudFormation templates
        /// formatted in YAML, you can provide the policy in JSON or YAML format. CloudFormation
        /// always converts a YAML policy to JSON format before submitting it to IAM.
        /// </para>
        ///  
        /// <para>
        /// The maximum length of the policy document that you can pass in this operation, including
        /// whitespace, is listed below. To view the maximum character counts of a managed policy
        /// with no whitespaces, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-quotas-entity-length">IAM
        /// and STS character quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<c>\u0020</c>) through
        /// the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <c>\u00FF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage
        /// return (<c>\u000D</c>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=131072)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property SetAsDefault. 
        /// <para>
        /// Specifies whether to set this version as the policy's default version.
        /// </para>
        ///  
        /// <para>
        /// When this parameter is <c>true</c>, the new policy version becomes the operative version.
        /// That is, it becomes the version that is in effect for the IAM users, groups, and roles
        /// that the policy is attached to.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for managed policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public bool? SetAsDefault
        {
            get { return this._setAsDefault; }
            set { this._setAsDefault = value; }
        }

        // Check to see if SetAsDefault property is set
        internal bool IsSetSetAsDefault()
        {
            return this._setAsDefault.HasValue; 
        }

    }
}