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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the AddPermission operation. Grants a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#Principal_specifying">principal</a>
    /// permission to use a function. You can apply the policy at the function level, or specify
    /// a qualifier to restrict access to a single version or alias. If you use a qualifier,
    /// the invoker must use the full Amazon Resource Name (ARN) of that version or alias
    /// to invoke the function. Note: Lambda does not support adding policies to version $LATEST.
    /// <para> To grant permission to another account, specify the account ID as the <c>Principal</c>.
    /// To grant permission to an organization defined in Organizations, specify the organization
    /// ID as the <c>PrincipalOrgID</c>. For Amazon Web Services services, the principal is
    /// a domain-style identifier that the service defines, such as <c>s3.amazonaws.com</c>
    /// or <c>sns.amazonaws.com</c>. For Amazon Web Services services, you can also specify
    /// the ARN of the associated resource as the <c>SourceArn</c>. If you grant permission
    /// to a service principal without specifying the source, other accounts could potentially
    /// configure resources in their account to invoke your Lambda function. </para> <para>
    /// This operation adds a statement to a resource-based permissions policy for the function.
    /// For more information about function policies, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">Using
    /// resource-based policies for Lambda</a>. </para>
    /// </summary>
    public partial class AddPermissionRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that the principal can use on the function. For example, <c>lambda:InvokeFunction</c>
        /// or <c>lambda:GetFunction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property EventSourceToken. 
        /// <para>
        /// For Alexa Smart Home functions, a token that the invoker must supply.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EventSourceToken { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceToken property is set.
        /// </summary>
        internal bool IsSetEventSourceToken() => this.EventSourceToken != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function, version, or alias.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <c>my-function</c> (name-only), <c>my-function:v1</c> (with
        /// alias).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <c>arn:aws:lambda:us-west-2:123456789012:function:my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <c>123456789012:function:my-function</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can append a version number or alias to any of the formats. The length constraint
        /// applies only to the full ARN. If you specify only the function name, it is limited
        /// to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property FunctionUrlAuthType. 
        /// <para>
        /// The type of authentication that your function URL uses. Set to <c>AWS_IAM</c> if you
        /// want to restrict access to authenticated users only. Set to <c>NONE</c> if you want
        /// to bypass IAM authentication to create a public endpoint. For more information, see
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/urls-auth.html">Control access
        /// to Lambda function URLs</a>.
        /// </para>
        /// </summary>
        public FunctionUrlAuthType FunctionUrlAuthType { get; set; }

        /// <summary>
        /// Checks to see if the FunctionUrlAuthType property is set.
        /// </summary>
        internal bool IsSetFunctionUrlAuthType() => this.FunctionUrlAuthType != null;

        /// <summary>
        /// Gets and sets the property InvokedViaFunctionUrl. 
        /// <para>
        /// Indicates whether the permission applies when the function is invoked through a function
        /// URL. 
        /// </para>
        /// </summary>
        public bool? InvokedViaFunctionUrl { get; set; }

        /// <summary>
        /// Checks to see if the InvokedViaFunctionUrl property is set.
        /// </summary>
        internal bool IsSetInvokedViaFunctionUrl() => this.InvokedViaFunctionUrl.HasValue;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Web Services service, Amazon Web Services account, IAM user, or IAM role
        /// that invokes the function. If you specify a service, use <c>SourceArn</c> or <c>SourceAccount</c>
        /// to limit who can invoke the function through that service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property PrincipalOrgID. 
        /// <para>
        /// The identifier for your organization in Organizations. Use this to grant permissions
        /// to all the Amazon Web Services accounts under this organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 34)]
        public string PrincipalOrgID { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalOrgID property is set.
        /// </summary>
        internal bool IsSetPrincipalOrgID() => this.PrincipalOrgID != null;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Specify a version or alias to add permissions to a published version of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Update the policy only if the revision ID matches the ID that's specified. Use this
        /// option to avoid modifying a policy that has changed since you last read it.
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;

        /// <summary>
        /// Gets and sets the property SourceAccount. 
        /// <para>
        /// For Amazon Web Services service, the ID of the Amazon Web Services account that owns
        /// the resource. Use this together with <c>SourceArn</c> to ensure that the specified
        /// account owns the resource. It is possible for an Amazon S3 bucket to be deleted by
        /// its owner and recreated by another account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccount property is set.
        /// </summary>
        internal bool IsSetSourceAccount() => this.SourceAccount != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// For Amazon Web Services services, the ARN of the Amazon Web Services resource that
        /// invokes the function. For example, an Amazon S3 bucket or Amazon SNS topic.
        /// </para>
        ///  
        /// <para>
        /// Note that Lambda configures the comparison using the <c>StringLike</c> operator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// A statement identifier that differentiates the statement from others in the same policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string StatementId { get; set; }

        /// <summary>
        /// Checks to see if the StatementId property is set.
        /// </summary>
        internal bool IsSetStatementId() => this.StatementId != null;
    }
}
