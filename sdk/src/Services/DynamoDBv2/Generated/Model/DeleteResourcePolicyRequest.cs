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
    /// Container for the parameters to the DeleteResourcePolicy operation.
    /// Deletes the resource-based policy attached to the resource, which can be a table or
    /// stream.
    /// 
    ///  
    /// <para>
    ///  <c>DeleteResourcePolicy</c> is an idempotent operation; running it multiple times
    /// on the same resource <i>doesn't</i> result in an error response, unless you specify
    /// an <c>ExpectedRevisionId</c>, which will then return a <c>PolicyNotFoundException</c>.
    /// </para>
    ///  <important> 
    /// <para>
    /// To make sure that you don't inadvertently lock yourself out of your own resources,
    /// the root principal in your Amazon Web Services account can perform <c>DeleteResourcePolicy</c>
    /// requests, even if your resource-based policy explicitly denies the root principal's
    /// access. 
    /// </para>
    ///  </important> <note> 
    /// <para>
    ///  <c>DeleteResourcePolicy</c> is an asynchronous operation. If you issue a <c>GetResourcePolicy</c>
    /// request immediately after running the <c>DeleteResourcePolicy</c> request, DynamoDB
    /// might still return the deleted policy. This is because the policy for your resource
    /// might not have been deleted yet. Wait for a few seconds, and then try the <c>GetResourcePolicy</c>
    /// request again.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonDynamoDBRequest
    {
        private string _expectedRevisionId;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// A string value that you can use to conditionally delete your policy. When you provide
        /// an expected revision ID, if the revision ID of the existing policy on the resource
        /// doesn't match or if there's no policy attached to the resource, the request will fail
        /// and return a <c>PolicyNotFoundException</c>.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DynamoDB resource from which the policy will
        /// be removed. The resources you can specify include tables and streams. If you remove
        /// the policy of a table, it will also remove the permissions for the table's indexes
        /// defined in that policy document. This is because index permissions are defined in
        /// the table's policy.
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