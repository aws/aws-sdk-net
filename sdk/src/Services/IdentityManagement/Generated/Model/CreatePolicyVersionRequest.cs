/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePolicyVersion operation.
    /// Creates a new version of the specified managed policy. To update a managed policy,
    /// you create a new policy version. A managed policy can have up to five versions. If
    /// the policy has five versions, you must delete an existing version using <a>DeletePolicyVersion</a>
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
    /// For more information about managed policy versions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
    /// for Managed Policies</a> in the <i>IAM User Guide</i>.
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
        /// For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
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
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (\u0020) through the
        /// end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// \u00FF)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (\u0009), line feed (\u000A), and carriage return (\u000D)
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// When this parameter is <code>true</code>, the new policy version becomes the operative
        /// version. That is, it becomes the version that is in effect for the IAM users, groups,
        /// and roles that the policy is attached to.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public bool SetAsDefault
        {
            get { return this._setAsDefault.GetValueOrDefault(); }
            set { this._setAsDefault = value; }
        }

        // Check to see if SetAsDefault property is set
        internal bool IsSetSetAsDefault()
        {
            return this._setAsDefault.HasValue; 
        }

    }
}