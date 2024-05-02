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
    /// Container for the parameters to the PublishVersion operation.
    /// Creates a <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">version</a>
    /// from the current code and configuration of a function. Use versions to create a snapshot
    /// of your function code and configuration that doesn't change.
    /// 
    ///  
    /// <para>
    /// Lambda doesn't publish a version if the function's configuration and code haven't
    /// changed since the last version. Use <a>UpdateFunctionCode</a> or <a>UpdateFunctionConfiguration</a>
    /// to update the function before publishing a version.
    /// </para>
    ///  
    /// <para>
    /// Clients can invoke versions directly or with an alias. To create an alias, use <a>CreateAlias</a>.
    /// </para>
    /// </summary>
    public partial class PublishVersionRequest : AmazonLambdaRequest
    {
        private string _codeSha256;
        private string _description;
        private string _functionName;
        private string _revisionId;

        /// <summary>
        /// Gets and sets the property CodeSha256. 
        /// <para>
        /// Only publish a version if the hash value matches the value that's specified. Use this
        /// option to avoid publishing a version if the function code has changed since you last
        /// updated it. You can get the hash for the version that you uploaded from the output
        /// of <a>UpdateFunctionCode</a>.
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
        /// A description for the version to override the description in the function configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The name or ARN of the Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> - <c>MyFunction</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> - <c>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> - <c>123456789012:function:MyFunction</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Only update the function if the revision ID matches the ID that's specified. Use this
        /// option to avoid publishing a version if the function configuration has changed since
        /// you last updated it.
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

    }
}