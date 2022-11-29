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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the AddPermission operation.
    /// Grants an Amazon Web Service, Amazon Web Services account, or Amazon Web Services
    /// organization permission to use a function. You can apply the policy at the function
    /// level, or specify a qualifier to restrict access to a single version or alias. If
    /// you use a qualifier, the invoker must use the full Amazon Resource Name (ARN) of that
    /// version or alias to invoke the function. Note: Lambda does not support adding policies
    /// to version $LATEST.
    /// 
    ///  
    /// <para>
    /// To grant permission to another account, specify the account ID as the <code>Principal</code>.
    /// To grant permission to an organization defined in Organizations, specify the organization
    /// ID as the <code>PrincipalOrgID</code>. For Amazon Web Services, the principal is a
    /// domain-style identifier that the service defines, such as <code>s3.amazonaws.com</code>
    /// or <code>sns.amazonaws.com</code>. For Amazon Web Services, you can also specify the
    /// ARN of the associated resource as the <code>SourceArn</code>. If you grant permission
    /// to a service principal without specifying the source, other accounts could potentially
    /// configure resources in their account to invoke your Lambda function.
    /// </para>
    ///  
    /// <para>
    /// This operation adds a statement to a resource-based permissions policy for the function.
    /// For more information about function policies, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">Using
    /// resource-based policies for Lambda</a>.
    /// </para>
    /// </summary>
    public partial class AddPermissionRequest : AmazonLambdaRequest
    {
        private string _action;
        private string _eventSourceToken;
        private string _functionName;
        private FunctionUrlAuthType _functionUrlAuthType;
        private string _principal;
        private string _principalOrgID;
        private string _qualifier;
        private string _revisionId;
        private string _sourceAccount;
        private string _sourceArn;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that the principal can use on the function. For example, <code>lambda:InvokeFunction</code>
        /// or <code>lambda:GetFunction</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property EventSourceToken. 
        /// <para>
        /// For Alexa Smart Home functions, a token that the invoker must supply.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string EventSourceToken
        {
            get { return this._eventSourceToken; }
            set { this._eventSourceToken = value; }
        }

        // Check to see if EventSourceToken property is set
        internal bool IsSetEventSourceToken()
        {
            return this._eventSourceToken != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the Lambda function, version, or alias.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code>
        /// (with alias).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can append a version number or alias to any of the formats. The length constraint
        /// applies only to the full ARN. If you specify only the function name, it is limited
        /// to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionUrlAuthType. 
        /// <para>
        /// The type of authentication that your function URL uses. Set to <code>AWS_IAM</code>
        /// if you want to restrict access to authenticated IAM users only. Set to <code>NONE</code>
        /// if you want to bypass IAM authentication to create a public endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/urls-auth.html">Security
        /// and auth model for Lambda function URLs</a>.
        /// </para>
        /// </summary>
        public FunctionUrlAuthType FunctionUrlAuthType
        {
            get { return this._functionUrlAuthType; }
            set { this._functionUrlAuthType = value; }
        }

        // Check to see if FunctionUrlAuthType property is set
        internal bool IsSetFunctionUrlAuthType()
        {
            return this._functionUrlAuthType != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Web Service or Amazon Web Services account that invokes the function. If
        /// you specify a service, use <code>SourceArn</code> or <code>SourceAccount</code> to
        /// limit who can invoke the function through that service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalOrgID. 
        /// <para>
        /// The identifier for your organization in Organizations. Use this to grant permissions
        /// to all the Amazon Web Services accounts under this organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=34)]
        public string PrincipalOrgID
        {
            get { return this._principalOrgID; }
            set { this._principalOrgID = value; }
        }

        // Check to see if PrincipalOrgID property is set
        internal bool IsSetPrincipalOrgID()
        {
            return this._principalOrgID != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Specify a version or alias to add permissions to a published version of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Update the policy only if the revision ID matches the ID that's specified. Use this
        /// option to avoid modifying a policy that has changed since you last read it.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SourceAccount. 
        /// <para>
        /// For Amazon Web Service, the ID of the Amazon Web Services account that owns the resource.
        /// Use this together with <code>SourceArn</code> to ensure that the specified account
        /// owns the resource. It is possible for an Amazon S3 bucket to be deleted by its owner
        /// and recreated by another account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
        public string SourceAccount
        {
            get { return this._sourceAccount; }
            set { this._sourceAccount = value; }
        }

        // Check to see if SourceAccount property is set
        internal bool IsSetSourceAccount()
        {
            return this._sourceAccount != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// For Amazon Web Services, the ARN of the Amazon Web Services resource that invokes
        /// the function. For example, an Amazon S3 bucket or Amazon SNS topic.
        /// </para>
        ///  
        /// <para>
        /// Note that Lambda configures the comparison using the <code>StringLike</code> operator.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// A statement identifier that differentiates the statement from others in the same policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string StatementId
        {
            get { return this._statementId; }
            set { this._statementId = value; }
        }

        // Check to see if StatementId property is set
        internal bool IsSetStatementId()
        {
            return this._statementId != null;
        }

    }
}