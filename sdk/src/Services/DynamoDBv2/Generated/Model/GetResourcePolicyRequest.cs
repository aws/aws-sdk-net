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
    /// Container for the parameters to the GetResourcePolicy operation.
    /// Returns the resource-based policy document attached to the resource, which can be
    /// a table or stream, in JSON format.
    /// 
    ///  
    /// <para>
    ///  <c>GetResourcePolicy</c> follows an <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
    /// <i>eventually consistent</i> </a> model. The following list describes the outcomes
    /// when you issue the <c>GetResourcePolicy</c> request immediately after issuing another
    /// request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you issue a <c>GetResourcePolicy</c> request immediately after a <c>PutResourcePolicy</c>
    /// request, DynamoDB might return a <c>PolicyNotFoundException</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you issue a <c>GetResourcePolicy</c>request immediately after a <c>DeleteResourcePolicy</c>
    /// request, DynamoDB might return the policy that was present before the deletion request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you issue a <c>GetResourcePolicy</c> request immediately after a <c>CreateTable</c>
    /// request, which includes a resource-based policy, DynamoDB might return a <c>ResourceNotFoundException</c>
    /// or a <c>PolicyNotFoundException</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Because <c>GetResourcePolicy</c> uses an <i>eventually consistent</i> query, the metadata
    /// for your policy or table might not be available at that moment. Wait for a few seconds,
    /// and then retry the <c>GetResourcePolicy</c> request.
    /// </para>
    ///  
    /// <para>
    /// After a <c>GetResourcePolicy</c> request returns a policy created using the <c>PutResourcePolicy</c>
    /// request, the policy will be applied in the authorization of requests to the resource.
    /// Because this process is eventually consistent, it will take some time to apply the
    /// policy to all requests to a resource. Policies that you attach while creating a table
    /// using the <c>CreateTable</c> request will always be applied to all requests for that
    /// table.
    /// </para>
    /// </summary>
    public partial class GetResourcePolicyRequest : AmazonDynamoDBRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DynamoDB resource to which the policy is attached.
        /// The resources you can specify include tables and streams.
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