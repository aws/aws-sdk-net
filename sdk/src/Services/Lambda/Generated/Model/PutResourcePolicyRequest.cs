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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Adds a <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">resource-based
    /// policy</a> to a Lambda resource. Resource-based policies grant access to other <a
    /// href="https://docs.aws.amazon.com/lambda/latest/dg/permissions-function-cross-account.html">Amazon
    /// Web Services accounts</a>, <a href="https://docs.aws.amazon.com/lambda/latest/dg/permissions-function-organization.html">organizations</a>,
    /// or <a href="https://docs.aws.amazon.com/lambda/latest/dg/permissions-function-services.html">services</a>.
    /// Resource-based policies apply to a single Lambda resource (for example, a function,
    /// function version, or function alias).
    /// 
    ///  <important> 
    /// <para>
    /// This operation replaces any existing policy on the Lambda resource. If you previously
    /// added permissions using the <a>AddPermission</a> operation, the new policy overwrites
    /// those permissions.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonLambdaRequest
    {
        private string _policy;
        private string _resourceArn;
        private string _revisionId;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy document you want to add to your Lambda resource. This is formatted as
        /// a JSON string.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">Working
        /// with resource-based policies in Lambda</a> in the <i>Lambda Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20480)]
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
        /// The Amazon Resource Name (ARN) of the Lambda resource you want to add the policy to.
        /// You can use a qualified or an unqualified ARN. The value must be a complete ARN, and
        /// the operation does not accept wildcard characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision ID that the existing policy must match for the replacement to proceed.
        /// If the revision ID doesn't match, the operation fails with a <c>PreconditionFailedException</c>
        /// error. To retrieve the current revision ID, use the <a>GetResourcePolicy</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

    }
}