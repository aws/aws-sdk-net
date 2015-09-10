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
    /// Container for the parameters to the SimulatePrincipalPolicy operation.
    /// Simulate the set of IAM policies attached to an IAM entity against a list of API actions
    /// and AWS resources to determine the policies' effective permissions. The entity can
    /// be an IAM user, group, or role. If you specify a user, then the simulation also includes
    /// all of the policies attached to groups that the user is a member of.
    /// 
    ///  
    /// <para>
    /// You can optionally include a list of one or more additional policies specified as
    /// strings to include in the simulation. If you want to simulate only policies specified
    /// as strings, use <a>SimulateCustomPolicy</a> instead.
    /// </para>
    ///  
    /// <para>
    /// The simulation does not perform the API actions, it only checks the authorization
    /// to determine if the simulated policies allow or deny the actions.
    /// </para>
    ///  
    /// <para>
    /// <b>Note:</b> This API discloses information about the permissions granted to other
    /// users. If you do not want users to see other user's permissions, then consider allowing
    /// them to use <a>SimulateCustomPolicy</a> instead.
    /// </para>
    ///  
    /// <para>
    /// Context keys are variables maintained by AWS and its services that provide details
    /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
    /// element of an IAM policy. To get the list of context keys required by the policies
    /// to simulate them correctly, use <a>GetContextKeysForPrincipalPolicy</a>.
    /// </para>
    ///  
    /// <para>
    /// If the output is long, you can paginate the results using the <code>MaxItems</code>
    /// and <code>Marker</code> parameters.
    /// </para>
    /// </summary>
    public partial class SimulatePrincipalPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private List<string> _actionNames = new List<string>();
        private List<ContextEntry> _contextEntries = new List<ContextEntry>();
        private string _marker;
        private int? _maxItems;
        private List<string> _policyInputList = new List<string>();
        private string _policySourceArn;
        private List<string> _resourceArns = new List<string>();

        /// <summary>
        /// Gets and sets the property ActionNames. 
        /// <para>
        /// A list of names of API actions to evaluate in the simulation. Each action is evaluated
        /// for each resource. Each action must include the service identifier, such as <code>iam:CreateUser</code>.
        /// </para>
        /// </summary>
        public List<string> ActionNames
        {
            get { return this._actionNames; }
            set { this._actionNames = value; }
        }

        // Check to see if ActionNames property is set
        internal bool IsSetActionNames()
        {
            return this._actionNames != null && this._actionNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContextEntries. 
        /// <para>
        /// A list of context keys and corresponding values that are used by the simulation. Whenever
        /// a context key is evaluated by a <code>Condition</code> element in one of the simulated
        /// IAM permission policies, the corresponding value is supplied.
        /// </para>
        /// </summary>
        public List<ContextEntry> ContextEntries
        {
            get { return this._contextEntries; }
            set { this._contextEntries = value; }
        }

        // Check to see if ContextEntries property is set
        internal bool IsSetContextEntries()
        {
            return this._contextEntries != null && this._contextEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response you received to inform the next call about where to start.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If there are additional items beyond the maximum you specify,
        /// the <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you do not include it, it defaults to 100.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyInputList. 
        /// <para>
        /// An optional list of additional policy documents to include in the simulation. Each
        /// document is specified as a string containing the complete, valid JSON text of an IAM
        /// policy.
        /// </para>
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
        /// The Amazon Resource Name (ARN) of a user, group, or role whose policies you want to
        /// include in the simulation. If you specify a user, group, or role, the simulation includes
        /// all policies associated with that entity. If you specify a user, the simulation also
        /// includes all policies attached to any groups the user is a member of.
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

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// A list of ARNs of AWS resources to include in the simulation. If this parameter is
        /// not provided then the value defaults to <code>*</code> (all resources). Each API in
        /// the <code>ActionNames</code> parameter is evaluated for each resource in this list.
        /// The simulation determines the access result (allowed or denied) of each combination
        /// and reports it in the response.
        /// </para>
        /// </summary>
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

    }
}