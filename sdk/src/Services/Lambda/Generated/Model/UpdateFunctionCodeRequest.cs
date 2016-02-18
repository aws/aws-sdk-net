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
    /// Container for the parameters to the UpdateFunctionCode operation.
    /// Updates the code for the specified Lambda function. This operation must only be used
    /// on an existing Lambda function and cannot be used to update the function configuration.
    /// 
    /// 
    ///  
    /// <para>
    /// If you are using the versioning feature, note this API will always update the $LATEST
    /// version of your Lambda function. For information about the versioning feature, see
    /// <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
    /// Lambda Function Versioning and Aliases</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:UpdateFunctionCode</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateFunctionCodeRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private bool? _publish;
        private string _s3Bucket;
        private string _s3Key;
        private string _s3ObjectVersion;
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The existing Lambda function name whose code you want to replace.
        /// </para>
        ///  
        /// <para>
        ///  You can specify a function name (for example, <code>Thumbnail</code>) or you can
        /// specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>).
        /// AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>).
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

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// This boolean parameter can be used to request AWS Lambda to update the Lambda function
        /// and publish a version as an atomic operation. 
        /// </para>
        /// </summary>
        public bool Publish
        {
            get { return this._publish.GetValueOrDefault(); }
            set { this._publish = value; }
        }

        // Check to see if Publish property is set
        internal bool IsSetPublish()
        {
            return this._publish.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// Amazon S3 bucket name where the .zip file containing your deployment package is stored.
        /// This bucket must reside in the same AWS region where you are creating the Lambda function.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The Amazon S3 object (the deployment package) key name you want to upload. 
        /// </para>
        /// </summary>
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

        /// <summary>
        /// Gets and sets the property S3ObjectVersion. 
        /// <para>
        /// The Amazon S3 object (the deployment package) version you want to upload.
        /// </para>
        /// </summary>
        public string S3ObjectVersion
        {
            get { return this._s3ObjectVersion; }
            set { this._s3ObjectVersion = value; }
        }

        // Check to see if S3ObjectVersion property is set
        internal bool IsSetS3ObjectVersion()
        {
            return this._s3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// Based64-encoded .zip file containing your packaged source code.
        /// </para>
        /// </summary>
        public MemoryStream ZipFile
        {
            get { return this._zipFile; }
            set { this._zipFile = value; }
        }

        // Check to see if ZipFile property is set
        internal bool IsSetZipFile()
        {
            return this._zipFile != null;
        }

    }
}