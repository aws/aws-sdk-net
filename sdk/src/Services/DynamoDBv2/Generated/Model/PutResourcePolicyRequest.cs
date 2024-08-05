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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Attaches a resource-based policy document to the resource, which can be a table or
    /// stream. When you attach a resource-based policy using this API, the policy application
    /// is <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
    /// <i>eventually consistent</i> </a>.
    /// 
    ///  
    /// <para>
    ///  <c>PutResourcePolicy</c> is an idempotent operation; running it multiple times on
    /// the same resource using the same policy document will return the same revision ID.
    /// If you specify an <c>ExpectedRevisionId</c> that doesn't match the current policy's
    /// <c>RevisionId</c>, the <c>PolicyNotFoundException</c> will be returned.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>PutResourcePolicy</c> is an asynchronous operation. If you issue a <c>GetResourcePolicy</c>
    /// request immediately after a <c>PutResourcePolicy</c> request, DynamoDB might return
    /// your previous policy, if there was one, or return the <c>PolicyNotFoundException</c>.
    /// This is because <c>GetResourcePolicy</c> uses an eventually consistent query, and
    /// the metadata for your policy or table might not be available at that moment. Wait
    /// for a few seconds, and then try the <c>GetResourcePolicy</c> request again.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonDynamoDBRequest
    {
        private bool? _confirmRemoveSelfResourceAccess;
        private string _expectedRevisionId;
        private string _policy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ConfirmRemoveSelfResourceAccess. 
        /// <para>
        /// Set this parameter to <c>true</c> to confirm that you want to remove your permissions
        /// to change the policy of this resource in the future.
        /// </para>
        /// </summary>
        public bool? ConfirmRemoveSelfResourceAccess
        {
            get { return this._confirmRemoveSelfResourceAccess; }
            set { this._confirmRemoveSelfResourceAccess = value; }
        }

        // Check to see if ConfirmRemoveSelfResourceAccess property is set
        internal bool IsSetConfirmRemoveSelfResourceAccess()
        {
            return this._confirmRemoveSelfResourceAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// A string value that you can use to conditionally update your policy. You can provide
        /// the revision ID of your existing policy to make mutating requests against that policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you provide an expected revision ID, if the revision ID of the existing policy
        /// on the resource doesn't match or if there's no policy attached to the resource, your
        /// request will be rejected with a <c>PolicyNotFoundException</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To conditionally attach a policy when no policy exists for the resource, specify <c>NO_POLICY</c>
        /// for the revision ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ExpectedRevisionId
        {
            get { return this._expectedRevisionId; }
            set { this._expectedRevisionId = value; }
        }

        // Check to see if ExpectedRevisionId property is set
        internal bool IsSetExpectedRevisionId()
        {
            return this._expectedRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// An Amazon Web Services resource-based policy document in JSON format.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The maximum size supported for a resource-based policy document is 20 KB. DynamoDB
        /// counts whitespaces when calculating the size of a policy against this limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Within a resource-based policy, if the action for a DynamoDB service-linked role (SLR)
        /// to replicate data for a global table is denied, adding or deleting a replica will
        /// fail with an error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a full list of all considerations that apply while attaching a resource-based
        /// policy, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/rbac-considerations.html">Resource-based
        /// policy considerations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DynamoDB resource to which the policy will be
        /// attached. The resources you can specify include tables and streams.
        /// </para>
        ///  
        /// <para>
        /// You can control index permissions using the base table's policy. To specify the same
        /// permission level for your table and its indexes, you can provide both the table and
        /// index Amazon Resource Name (ARN)s in the <c>Resource</c> field of a given <c>Statement</c>
        /// in your policy document. Alternatively, to specify different permissions for your
        /// table, indexes, or both, you can define multiple <c>Statement</c> fields in your policy
        /// document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1283)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}