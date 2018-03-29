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
    /// Container for the parameters to the GetContextKeysForPrincipalPolicy operation.
    /// Gets a list of all of the context keys referenced in all the IAM policies that are
    /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
    /// If you specify a user, then the request also includes all of the policies attached
    /// to groups that the user is a member of.
    /// 
    ///  
    /// <para>
    /// You can optionally include a list of one or more additional policies, specified as
    /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
    /// instead.
    /// </para>
    ///  
    /// <para>
    ///  <b>Note:</b> This API discloses information about the permissions granted to other
    /// users. If you do not want users to see other user's permissions, then consider allowing
    /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
    /// </para>
    ///  
    /// <para>
    /// Context keys are variables maintained by AWS and its services that provide details
    /// about the context of an API query request. Context keys can be evaluated by testing
    /// against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a> to understand
    /// what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
    /// </para>
    /// </summary>
    public partial class GetContextKeysForPrincipalPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private List<string> _policyInputList = new List<string>();
        private string _policySourceArn;

        /// <summary>
        /// Gets and sets the property PolicyInputList. 
        /// <para>
        /// An optional list of additional policies for which you want the list of context keys
        /// that are referenced.
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
        public List<string> PolicyInputList
        {
            get { return this._policyInputList; }
            set { this._policyInputList = value; }
        }

        // Check to see if PolicyInputList property is set
        internal bool IsSetPolicyInputList()
        {
            return this._policyInputList != null && this._policyInputList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicySourceArn. 
        /// <para>
        /// The ARN of a user, group, or role whose policies contain the context keys that you
        /// want listed. If you specify a user, the list includes context keys that are found
        /// in all policies that are attached to the user. The list also includes all groups that
        /// the user is a member of. If you pick a group or a role, then it includes only those
        /// context keys that are found in policies attached to that entity. Note that all parameters
        /// are shown in unencoded form here for clarity, but must be URL encoded to be included
        /// as a part of a real HTML request.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string PolicySourceArn
        {
            get { return this._policySourceArn; }
            set { this._policySourceArn = value; }
        }

        // Check to see if PolicySourceArn property is set
        internal bool IsSetPolicySourceArn()
        {
            return this._policySourceArn != null;
        }

    }
}