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
    /// Container for the parameters to the GetFunction operation.
    /// Returns the configuration information of the Lambda function and a presigned URL link
    /// to the .zip file you uploaded with <a>CreateFunction</a> so you can download the .zip
    /// file. Note that the URL is valid for up to 10 minutes. The configuration information
    /// is the same information you provided as parameters when uploading the function.
    /// 
    ///  
    /// <para>
    /// Using the optional <code>Qualifier</code> parameter, you can specify a specific function
    /// version for which you want this information. If you don't specify this parameter,
    /// the API uses unqualified function ARN which return information about the <code>$LATEST</code>
    /// version of the Lambda function. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
    /// Lambda Function Versioning and Aliases</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:GetFunction</code> action.
    /// </para>
    /// </summary>
    public partial class GetFunctionRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private string _qualifier;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The Lambda function name.
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
        /// Use this optional parameter to specify a function version or an alias name. If you
        /// specify function version, the API uses qualified function ARN for the request and
        /// returns information about the specific Lambda function version. If you specify an
        /// alias name, the API uses the alias ARN and returns information about the function
        /// version to which the alias points. If you don't provide this parameter, the API uses
        /// unqualified function ARN and returns information about the <code>$LATEST</code> version
        /// of the Lambda function. 
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

    }
}