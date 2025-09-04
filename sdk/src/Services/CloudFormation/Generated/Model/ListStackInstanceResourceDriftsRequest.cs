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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListStackInstanceResourceDrifts operation.
    /// Returns drift information for resources in a stack instance.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>ListStackInstanceResourceDrifts</c> returns drift information for the most recent
    /// drift detection operation. If an operation is in progress, it may only return partial
    /// results.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListStackInstanceResourceDriftsRequest : AmazonCloudFormationRequest
    {
        private CallAs _callAs;
        private int? _maxResults;
        private string _nextToken;
        private string _operationId;
        private string _stackInstanceAccount;
        private string _stackInstanceRegion;
        private List<string> _stackInstanceResourceDriftStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <c>NextToken</c> value
        /// that you can assign to the <c>NextToken</c> request parameter to get the next set
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If the previous paginated request didn't return all of the remaining results, the
        /// response object's <c>NextToken</c> parameter value is set to a token. To retrieve
        /// the next set of results, call this action again and assign that token to the request
        /// object's <c>NextToken</c> parameter. If there are no remaining results, the previous
        /// response object's <c>NextToken</c> parameter is set to <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique ID of the drift operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property StackInstanceAccount. 
        /// <para>
        /// The name of the Amazon Web Services account that you want to list resource drifts
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackInstanceAccount
        {
            get { return this._stackInstanceAccount; }
            set { this._stackInstanceAccount = value; }
        }

        // Check to see if StackInstanceAccount property is set
        internal bool IsSetStackInstanceAccount()
        {
            return this._stackInstanceAccount != null;
        }

        /// <summary>
        /// Gets and sets the property StackInstanceRegion. 
        /// <para>
        /// The name of the Region where you want to list resource drifts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackInstanceRegion
        {
            get { return this._stackInstanceRegion; }
            set { this._stackInstanceRegion = value; }
        }

        // Check to see if StackInstanceRegion property is set
        internal bool IsSetStackInstanceRegion()
        {
            return this._stackInstanceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property StackInstanceResourceDriftStatuses. 
        /// <para>
        /// The resource drift status of the stack instance. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETED</c>: The resource differs from its expected template configuration in
        /// that the resource has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFIED</c>: One or more resource properties differ from their expected template
        /// values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The resource's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation doesn't currently return this value.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> StackInstanceResourceDriftStatuses
        {
            get { return this._stackInstanceResourceDriftStatuses; }
            set { this._stackInstanceResourceDriftStatuses = value; }
        }

        // Check to see if StackInstanceResourceDriftStatuses property is set
        internal bool IsSetStackInstanceResourceDriftStatuses()
        {
            return this._stackInstanceResourceDriftStatuses != null && (this._stackInstanceResourceDriftStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the StackSet that you want to list drifted resources for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

    }
}