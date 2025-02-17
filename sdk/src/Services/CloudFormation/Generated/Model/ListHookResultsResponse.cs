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
    /// This is the response object from the ListHookResults operation.
    /// </summary>
    public partial class ListHookResultsResponse : AmazonWebServiceResponse
    {
        private List<HookResultSummary> _hookResults = AWSConfigs.InitializeCollections ? new List<HookResultSummary>() : null;
        private string _nextToken;
        private string _targetId;
        private ListHookResultsTargetType _targetType;

        /// <summary>
        /// Gets and sets the property HookResults. 
        /// <para>
        /// A list of <c>HookResultSummary</c> structures that provides the status and Hook status
        /// reason for each Hook invocation for the specified target.
        /// </para>
        /// </summary>
        public List<HookResultSummary> HookResults
        {
            get { return this._hookResults; }
            set { this._hookResults = value; }
        }

        // Check to see if HookResults property is set
        internal bool IsSetHookResults()
        {
            return this._hookResults != null && (this._hookResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token, <c>null</c> or empty if no more results.
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
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The logical ID of the target the operation is acting on by the Hook. If the target
        /// is a change set, it's the ARN of the change set.
        /// </para>
        ///  
        /// <para>
        /// If the target is a Cloud Control API operation, this will be the <c>HooksRequestToken</c>
        /// returned by the Cloud Control API operation request. For more information on the <c>HooksRequestToken</c>,
        /// see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_ProgressEvent.html">ProgressEvent</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of operation being targeted by the Hook.
        /// </para>
        /// </summary>
        public ListHookResultsTargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}