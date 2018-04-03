/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the AddPermission operation.
    /// Adds a permission to the resource policy associated with the specified AWS Lambda
    /// function. You use resource policies to grant permissions to event sources that use
    /// <i>push</i> model. In a <i>push</i> model, event sources (such as Amazon S3 and custom
    /// applications) invoke your Lambda function. Each permission you add to the resource
    /// policy allows an event source, permission to invoke the Lambda function. 
    /// 
    ///  
    /// <para>
    /// For information about the push model, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">Lambda
    /// Functions</a>. 
    /// </para>
    ///  
    /// <para>
    /// If you are using versioning, the permissions you add are specific to the Lambda function
    /// version or alias you specify in the <code>AddPermission</code> request via the <code>Qualifier</code>
    /// parameter. For more information about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
    /// Lambda Function Versioning and Aliases</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:AddPermission</code> action.
    /// </para>
    /// </summary>
    public partial class AddPermissionRequest : AmazonLambdaRequest
    {
        private string _action;
        private string _eventSourceToken;
        private string _functionName;
        private string _principal;
        private string _qualifier;
        private string _revisionId;
        private string _sourceAccount;
        private string _sourceArn;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The AWS Lambda action you want to allow in this statement. Each Lambda action is a
        /// string starting with <code>lambda:</code> followed by the API name . For example,
        /// <code>lambda:CreateFunction</code>. You can use wildcard (<code>lambda:*</code>) to
        /// grant permission for all AWS Lambda actions. 
        /// </para>
        /// </summary>
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
        /// A unique token that must be supplied by the principal invoking the function. This
        /// is currently only used for Alexa Smart Home functions.
        /// </para>
        /// </summary>
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
        /// Name of the Lambda function whose resource policy you are updating by adding a new
        /// permission.
        /// </para>
        ///  
        /// <para>
        ///  You can specify a function name (for example, <code>Thumbnail</code>) or you can
        /// specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>).
        /// AWS Lambda also allows you to specify partial ARN (for example, <code>account-id:Thumbnail</code>).
        /// Note that the length constraint applies only to the ARN. If you specify only the function
        /// name, it is limited to 64 characters in length. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal who is getting this permission. It can be Amazon S3 service Principal
        /// (<code>s3.amazonaws.com</code>) if you want Amazon S3 to invoke the function, an AWS
        /// account ID if you are granting cross-account permission, or any valid AWS service
        /// principal such as <code>sns.amazonaws.com</code>. For example, you might want to allow
        /// a custom application in another AWS account to push events to AWS Lambda by invoking
        /// your function. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// You can use this optional query parameter to describe a qualified ARN using a function
        /// version or an alias name. The permission will then apply to the specific qualified
        /// ARN. For example, if you specify function version 2 as the qualifier, then permission
        /// applies only when request is made using qualified function ARN:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:aws-region:acct-id:function:function-name:2</code> 
        /// </para>
        ///  
        /// <para>
        /// If you specify an alias name, for example <code>PROD</code>, then the permission is
        /// valid only for requests made using the alias ARN:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:aws-region:acct-id:function:function-name:PROD</code> 
        /// </para>
        ///  
        /// <para>
        /// If the qualifier is not specified, the permission is valid only when requests is made
        /// using unqualified function ARN.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:aws-region:acct-id:function:function-name</code> 
        /// </para>
        /// </summary>
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
        /// An optional value you can use to ensure you are updating the latest update of the
        /// function version or alias. If the <code>RevisionID</code> you pass doesn't match the
        /// latest <code>RevisionId</code> of the function or alias, it will fail with an error
        /// message, advising you to retrieve the latest function version or alias <code>RevisionID</code>
        /// using either or .
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
        /// This parameter is used for S3 and SES. The AWS account ID (without a hyphen) of the
        /// source owner. For example, if the <code>SourceArn</code> identifies a bucket, then
        /// this is the bucket owner's account ID. You can use this additional condition to ensure
        /// the bucket you specify is owned by a specific account (it is possible the bucket owner
        /// deleted the bucket and some other AWS account created the bucket). You can also use
        /// this condition to specify all sources (that is, you don't specify the <code>SourceArn</code>)
        /// owned by a specific account. 
        /// </para>
        /// </summary>
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
        /// This is optional; however, when granting permission to invoke your function, you should
        /// specify this field with the Amazon Resource Name (ARN) as its value. This ensures
        /// that only events generated from the specified source can invoke the function.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you add a permission without providing the source ARN, any AWS account that creates
        /// a mapping to your function ARN can send events to invoke your Lambda function.
        /// </para>
        ///  </important>
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
        /// A unique statement identifier.
        /// </para>
        /// </summary>
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