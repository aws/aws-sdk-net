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
    /// Container for the parameters to the PutUserPolicy operation.
    /// Adds or updates an inline policy document that is embedded in the specified IAM user.
    /// 
    ///  
    /// <para>
    /// An IAM user can also have a managed policy attached to it. To attach a managed policy
    /// to a user, use <a>AttachUserPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
    /// For information about policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about limits on the number of inline policies that you can embed in
    /// a user, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
    /// on IAM Entities</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Because policy documents can be large, you should use POST rather than GET when calling
    /// <code>PutUserPolicy</code>. For general information about using the Query API with
    /// IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutUserPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyDocument;
        private string _policyName;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutUserPolicyRequest() { }

        /// <summary>
        /// Instantiates PutUserPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user to associate the policy with. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="policyName">The name of the policy document. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="policyDocument">The policy document. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (\u0020) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through \u00FF) </li> <li> The special characters tab (\u0009), line feed (\u000A), and carriage return (\u000D) </li> </ul></param>
        public PutUserPolicyRequest(string userName, string policyName, string policyDocument)
        {
            _userName = userName;
            _policyName = policyName;
            _policyDocument = policyDocument;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy document.
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
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy document.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user to associate the policy with.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}