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
    /// Container for the parameters to the PublishVersion operation.
    /// Publishes a version of your function from the current snapshot of HEAD. That is, AWS
    /// Lambda takes a snapshot of the function code and configuration information from HEAD
    /// and publishes a new version. The code and <code>handler</code> of this specific Lambda
    /// function version cannot be modified after publication, but you can modify the configuration
    /// information.
    /// </summary>
    public partial class PublishVersionRequest : AmazonLambdaRequest
    {
        private string _codeSha256;
        private string _description;
        private string _functionName;

        /// <summary>
        /// Gets and sets the property CodeSha256. 
        /// <para>
        /// The SHA256 hash of the deployment package you want to publish. This provides validation
        /// on the code you are publishing. If you provide this parameter value must match the
        /// SHA256 of the HEAD version for the publication to succeed. 
        /// </para>
        /// </summary>
        public string CodeSha256
        {
            get { return this._codeSha256; }
            set { this._codeSha256 = value; }
        }

        // Check to see if CodeSha256 property is set
        internal bool IsSetCodeSha256()
        {
            return this._codeSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the version you are publishing. If not provided, AWS Lambda copies
        /// the description from the HEAD version. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The Lambda function name. You can specify an unqualified function name (for example,
        /// "Thumbnail") or you can specify Amazon Resource Name (ARN) of the function (for example,
        /// "arn:aws:lambda:us-west-2:account-id:function:ThumbNail"). AWS Lambda also allows
        /// you to specify only the account ID qualifier (for example, "account-id:Thumbnail").
        /// Note that the length constraint applies only to the ARN. If you specify only the function
        /// name, it is limited to 64 character in length. 
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

    }
}