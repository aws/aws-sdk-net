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
    /// Container for the parameters to the GetPolicy operation.
    /// Returns the resource policy associated with the specified Lambda function.
    /// 
    ///  
    /// <para>
    ///  If you are using the versioning feature, you can get the resource policy associated
    /// with the specific Lambda function version or alias by specifying the version or alias
    /// name using the <code>Qualifier</code> parameter. For more information about versioning,
    /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
    /// Lambda Function Versioning and Aliases</a>. 
    /// </para>
    ///  
    /// <para>
    /// For information about adding permissions, see <a>AddPermission</a>.
    /// </para>
    ///  
    /// <para>
    /// You need permission for the <code>lambda:GetPolicy action.</code> 
    /// </para>
    /// </summary>
    public partial class GetPolicyRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private string _qualifier;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// Function name whose resource policy you want to retrieve.
        /// </para>
        ///  
        /// <para>
        ///  You can specify the function name (for example, <code>Thumbnail</code>) or you can
        /// specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>).
        /// If you are using versioning, you can also provide a qualified function ARN (ARN that
        /// is qualified with function version or alias name as suffix). AWS Lambda also allows
        /// you to specify only the function name with the account ID qualifier (for example,
        /// <code>account-id:Thumbnail</code>). Note that the length constraint applies only to
        /// the ARN. If you specify only the function name, it is limited to 64 character in length.
        /// 
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
        /// You can specify this optional query parameter to specify a function version or an
        /// alias name in which case this API will return all permissions associated with the
        /// specific qualified ARN. If you don't provide this parameter, the API will return permissions
        /// that apply to the unqualified function ARN.
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