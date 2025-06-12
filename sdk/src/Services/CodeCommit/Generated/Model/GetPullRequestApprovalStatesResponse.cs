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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetPullRequestApprovalStates operation.
    /// </summary>
    public partial class GetPullRequestApprovalStatesResponse : AmazonWebServiceResponse
    {
        private List<Approval> _approvals = AWSConfigs.InitializeCollections ? new List<Approval>() : null;

        /// <summary>
        /// Gets and sets the property Approvals. 
        /// <para>
        /// Information about users who have approved the pull request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Approval> Approvals
        {
            get { return this._approvals; }
            set { this._approvals = value; }
        }

        // Check to see if Approvals property is set
        internal bool IsSetApprovals()
        {
            return this._approvals != null && (this._approvals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}