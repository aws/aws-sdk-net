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
    /// <note> 
    /// <para>
    /// The option to create and modify full JSON resource-based policies, and to use the
    /// PutResourcePolicy, GetResourcePolicy, and DeleteResourcePolicy APIs, won't be available
    /// in all Amazon Web Services Regions until September 30, 2024.
    /// </para>
    ///  </note> 
    /// <para>
    /// Adds a <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">resource-based
    /// policy</a> to a function. You can use resource-based policies to grant access to other
    /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/permissions-function-cross-account.html">Amazon
    /// Web Services accounts</a>, <a href="https://docs.aws.amazon.com/lambda/latest/dg/permissions-function-organization.html">organizations</a>,
    /// or <a href="https://docs.aws.amazon.com/lambda/latest/dg/permissions-function-services.html">services</a>.
    /// Resource-based policies apply to a single function, version, or alias.
    /// </para>
    ///  <important> 
    /// <para>
    /// Adding a resource-based policy using this API action replaces any existing policy
    /// you've previously created. This means that if you've previously added resource-based
    /// permissions to a function using the <a>AddPermission</a> action, those permissions
    /// will be overwritten by your new policy.
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
        /// The JSON resource-based policy you want to add to your function.
        /// </para>
        ///  
        /// <para>
        /// To learn more about creating resource-based policies for controlling access to Lambda,
        /// see <a href="https://docs.aws.amazon.com/">Working with resource-based IAM policies
        /// in Lambda</a> in the <i>Lambda Developer Guide</i>.
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
        /// The Amazon Resource Name (ARN) of the function you want to add the policy to. You
        /// can use either a qualified or an unqualified ARN, but the value you specify must be
        /// a complete ARN and wildcard characters are not accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Replace the existing policy only if its revision ID matches the string you specify.
        /// To find the revision ID of the policy currently attached to your function, use the
        /// <a>GetResourcePolicy</a> action.
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