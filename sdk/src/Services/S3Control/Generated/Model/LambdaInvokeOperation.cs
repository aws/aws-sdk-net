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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for a <c>Lambda Invoke</c> operation.
    /// </summary>
    public partial class LambdaInvokeOperation
    {
        private string _functionArn;
        private string _invocationSchemaVersion;
        private Dictionary<string, string> _userArguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Lambda function that the specified job will
        /// invoke on every object in the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationSchemaVersion. 
        /// <para>
        /// Specifies the schema version for the payload that Batch Operations sends when invoking
        /// an Lambda function. Version <c>1.0</c> is the default. Version <c>2.0</c> is required
        /// when you use Batch Operations to invoke Lambda functions that act on directory buckets,
        /// or if you need to specify <c>UserArguments</c>. For more information, see <a href="https://aws.amazon.com/blogs/storage/automate-object-processing-in-amazon-s3-directory-buckets-with-s3-batch-operations-and-aws-lambda/">Automate
        /// object processing in Amazon S3 directory buckets with S3 Batch Operations and Lambda</a>
        /// in the <i>Amazon Web Services Storage Blog</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Ensure that your Lambda function code expects <c>InvocationSchemaVersion</c> <b>2.0</b>
        /// and uses bucket name rather than bucket ARN. If the <c>InvocationSchemaVersion</c>
        /// does not match what your Lambda function expects, your function might not work as
        /// expected.
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  <b>Directory buckets</b> - To initiate Amazon Web Services Lambda function to perform
        /// custom actions on objects in directory buckets, you must specify <c>2.0</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string InvocationSchemaVersion
        {
            get { return this._invocationSchemaVersion; }
            set { this._invocationSchemaVersion = value; }
        }

        // Check to see if InvocationSchemaVersion property is set
        internal bool IsSetInvocationSchemaVersion()
        {
            return this._invocationSchemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UserArguments. 
        /// <para>
        /// Key-value pairs that are passed in the payload that Batch Operations sends when invoking
        /// an Lambda function. You must specify <c>InvocationSchemaVersion</c> <b>2.0</b> for
        /// <c>LambdaInvoke</c> operations that include <c>UserArguments</c>. For more information,
        /// see <a href="https://aws.amazon.com/blogs/storage/automate-object-processing-in-amazon-s3-directory-buckets-with-s3-batch-operations-and-aws-lambda/">Automate
        /// object processing in Amazon S3 directory buckets with S3 Batch Operations and Lambda</a>
        /// in the <i>Amazon Web Services Storage Blog</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public Dictionary<string, string> UserArguments
        {
            get { return this._userArguments; }
            set { this._userArguments = value; }
        }

        // Check to see if UserArguments property is set
        internal bool IsSetUserArguments()
        {
            return this._userArguments != null && (this._userArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}