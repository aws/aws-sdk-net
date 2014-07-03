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
    /// Container for the parameters to the PutGroupPolicy operation.
    /// Adds (or updates) a policy document associated with the specified group. For information            about
    /// policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html"
    /// target="_blank">Overview of Policies</a> in <i>Using AWS Identity and Access Management</i>.
    /// 
    ///         
    /// <para>
    /// For information about limits on the number of policies you can associate with a group,
    /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
    /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
    /// </para>
    ///         <note>Because policy documents can be large, you should use POST rather than GET
    /// when calling                <code>PutGroupPolicy</code>. For information about setting up signatures
    /// and authorization            through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
    /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
    /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
    /// target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
    /// </summary>
    public partial class PutGroupPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _groupName;
        private string _policyDocument;
        private string _policyName;


        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Name of the group to associate the policy with.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }


        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy document.
        /// </para>
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
        /// Name of the policy document.
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

    }
}