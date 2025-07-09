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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the ListPoliciesForTarget operation.
    /// Lists the policies that are directly attached to the specified target root, organizational
    /// unit (OU), or account. You must specify the policy type that you want included in
    /// the returned list.
    /// 
    ///  <note> 
    /// <para>
    /// Always check the <c>NextToken</c> response parameter for a <c>null</c> value when
    /// calling a <c>List*</c> operation. These operations can occasionally return an empty
    /// set of results even when there are more results available. The <c>NextToken</c> response
    /// parameter value is <c>null</c> <i>only</i> when there are no more results to display.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    /// </summary>
    public partial class ListPoliciesForTargetRequest : AmazonOrganizationsRequest
    {
        private PolicyType _filter;
        private int? _maxResults;
        private string _nextToken;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The type of policy that you want to include in the returned list. You must specify
        /// one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scp.html">SERVICE_CONTROL_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_rcps.html">RESOURCE_CONTROL_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_declarative.html">DECLARATIVE_POLICY_EC2</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_backup.html">BACKUP_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">TAG_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_chatbot.html">CHATBOT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_ai-opt-out.html">AISERVICES_OPT_OUT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_security_hub.html">SECURITYHUB_POLICY</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of results that you want included on each page of the response. If
        /// you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the maximum you specify, the <c>NextToken</c>
        /// response element is present and has a value (is not null). Include that value as the
        /// <c>NextToken</c> request parameter in the next call to the operation to get the next
        /// part of the results. Note that Organizations might return fewer results than the maximum
        /// even when there are more results available. You should check <c>NextToken</c> after
        /// every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The parameter for receiving additional results if you receive a <c>NextToken</c> response
        /// in a previous request. A <c>NextToken</c> response indicates that more output is available.
        /// Set this parameter to the value of the previous call's <c>NextToken</c> response to
        /// indicate where the output should continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier (ID) of the root, organizational unit, or account whose policies
        /// you want to list.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a target ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> - A string that begins with "r-" followed by from 4 to 32 lowercase letters
        /// or digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> - A string that consists of exactly 12 digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Organizational unit (OU)</b> - A string that begins with "ou-" followed by from
        /// 4 to 32 lowercase letters or digits (the ID of the root that the OU is in). This string
        /// is followed by a second "-" dash and from 8 to 32 additional lowercase letters or
        /// digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}