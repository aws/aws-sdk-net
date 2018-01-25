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
    /// Container for the parameters to the RemovePermission operation.
    /// You can remove individual permissions from an resource policy associated with a Lambda
    /// function by providing a statement ID that you provided when you added the permission.
    /// 
    ///  
    /// <para>
    /// If you are using versioning, the permissions you remove are specific to the Lambda
    /// function version or alias you specify in the <code>AddPermission</code> request via
    /// the <code>Qualifier</code> parameter. For more information about versioning, see <a
    /// href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS Lambda
    /// Function Versioning and Aliases</a>. 
    /// </para>
    ///  
    /// <para>
    /// Note that removal of a permission will cause an active event source to lose permission
    /// to the function.
    /// </para>
    ///  
    /// <para>
    /// You need permission for the <code>lambda:RemovePermission</code> action.
    /// </para>
    /// </summary>
    public partial class RemovePermissionRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private string _qualifier;
        private string _revisionId;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// Lambda function whose resource policy you want to remove a permission from.
        /// </para>
        ///  
        /// <para>
        ///  You can specify a function name (for example, <code>Thumbnail</code>) or you can
        /// specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>).
        /// AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>).
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
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// You can specify this optional parameter to remove permission associated with a specific
        /// function version or function alias. If you don't specify this parameter, the API removes
        /// permission associated with the unqualified function ARN.
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
        /// Gets and sets the property StatementId. 
        /// <para>
        /// Statement ID of the permission to remove.
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