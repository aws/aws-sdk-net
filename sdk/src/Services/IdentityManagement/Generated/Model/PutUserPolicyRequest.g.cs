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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the PutUserPolicy operation. Adds or updates an inline
    /// policy document that is embedded in the specified IAM user. <para> An IAM user can
    /// also have a managed policy attached to it. To attach a managed policy to a user, use
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AttachUserPolicy.html">
    /// <c>AttachUserPolicy</c> </a>. To create a new managed policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">
    /// <c>CreatePolicy</c> </a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// policies and inline policies</a> in the <i>IAM User Guide</i>. </para> <para> For
    /// information about the maximum number of inline policies that you can embed in a user,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
    /// and STS quotas</a> in the <i>IAM User Guide</i>. </para> <note> <para> Because policy
    /// documents can be large, you should use POST rather than GET when calling <c>PutUserPolicy</c>.
    /// For general information about using the Query API with IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// query requests</a> in the <i>IAM User Guide</i>. </para> </note>
    /// </summary>
    public partial class PutUserPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public PutUserPolicyRequest() { }

        /// <summary>
        /// Instantiates PutUserPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user to associate the policy with.   This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric  characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="policyName">The name of the policy document.   This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric  characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="policyDocument">The policy document.   You must provide policies in JSON format in IAM. However, for CloudFormation   templates formatted in YAML, you can provide the policy in JSON or YAML format. CloudFormation always converts a YAML policy to JSON format before submitting it to   IAM.   The <a href="http://wikipedia.org/wiki/regex">regex pattern</a>  used to validate this parameter is a string of characters consisting of the following:   <ul>   <li>      Any printable ASCII  character ranging from the space character (<c>\u0020</c>) through the end of the ASCII character range   </li>   <li>      The printable characters in the Basic Latin and  Latin-1 Supplement character set  (through <c>\u00FF</c>)   </li>   <li>      The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and  carriage return (<c>\u000D</c>)   </li>   </ul></param>
        public PutUserPolicyRequest(string userName, string policyName, string policyDocument)
        {
            this.UserName = userName;
            this.PolicyName = policyName;
            this.PolicyDocument = policyDocument;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy document.
        /// </para>
        ///  
        /// <para>
        /// You must provide policies in JSON format in IAM. However, for CloudFormation templates
        /// formatted in YAML, you can provide the policy in JSON or YAML format. CloudFormation
        /// always converts a YAML policy to JSON format before submitting it to IAM.
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
        [AWSProperty(Required = true, Min = 1, Max = 131072)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy document.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user to associate the policy with.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
