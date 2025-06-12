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
    /// Container for the parameters to the UpdateFunctionCode operation.
    /// Updates a Lambda function's code. If code signing is enabled for the function, the
    /// code package must be signed by a trusted publisher. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">Configuring
    /// code signing for Lambda</a>.
    /// 
    ///  
    /// <para>
    /// If the function's package type is <c>Image</c>, then you must specify the code package
    /// in <c>ImageUri</c> as the URI of a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-images.html">container
    /// image</a> in the Amazon ECR registry.
    /// </para>
    ///  
    /// <para>
    /// If the function's package type is <c>Zip</c>, then you must specify the deployment
    /// package as a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html#gettingstarted-package-zip">.zip
    /// file archive</a>. Enter the Amazon S3 bucket and key of the code .zip file location.
    /// You can also provide the function code inline using the <c>ZipFile</c> field.
    /// </para>
    ///  
    /// <para>
    /// The code in the deployment package must be compatible with the target instruction
    /// set architecture of the function (<c>x86-64</c> or <c>arm64</c>).
    /// </para>
    ///  
    /// <para>
    /// The function's code is locked when you publish a version. You can't modify the code
    /// of a published version, only the unpublished version.
    /// </para>
    ///  <note> 
    /// <para>
    /// For a function defined as a container image, Lambda resolves the image tag to an image
    /// digest. In Amazon ECR, if you update the image tag to a new image, Lambda does not
    /// automatically update the function.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateFunctionCodeRequest : AmazonLambdaRequest
    {
        private List<string> _architectures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private string _functionName;
        private string _imageUri;
        private bool? _publish;
        private string _revisionId;
        private string _s3Bucket;
        private string _s3Key;
        private string _s3ObjectVersion;
        private string _sourceKMSKeyArn;
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The instruction set architecture that the function supports. Enter a string array
        /// with one of the valid values (arm64 or x86_64). The default value is <c>x86_64</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Architectures
        {
            get { return this._architectures; }
            set { this._architectures = value; }
        }

        // Check to see if Architectures property is set
        internal bool IsSetArchitectures()
        {
            return this._architectures != null && (this._architectures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Set to true to validate the request parameters and access permissions without modifying
        /// the function code.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        ///  <b>Function name</b> – <c>my-function</c>.
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
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// URI of a container image in the Amazon ECR registry. Do not use for a function defined
        /// with a .zip file archive.
        /// </para>
        /// </summary>
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }

        // Check to see if ImageUri property is set
        internal bool IsSetImageUri()
        {
            return this._imageUri != null;
        }

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// Set to true to publish a new version of the function after updating the code. This
        /// has the same effect as calling <a>PublishVersion</a> separately.
        /// </para>
        /// </summary>
        public bool? Publish
        {
            get { return this._publish; }
            set { this._publish = value; }
        }

        // Check to see if Publish property is set
        internal bool IsSetPublish()
        {
            return this._publish.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Update the function only if the revision ID matches the ID that's specified. Use this
        /// option to avoid modifying a function that has changed since you last read it.
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
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// An Amazon S3 bucket in the same Amazon Web Services Region as your function. The bucket
        /// can be in a different Amazon Web Services account. Use only with a function defined
        /// with a .zip file archive deployment package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// The Amazon S3 key of the deployment package. Use only with a function defined with
        /// a .zip file archive deployment package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// For versioned objects, the version of the deployment package object to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property SourceKMSKeyArn. 
        /// <para>
        /// The ARN of the Key Management Service (KMS) customer managed key that's used to encrypt
        /// your function's .zip deployment package. If you don't provide a customer managed key,
        /// Lambda uses an Amazon Web Services managed key.
        /// </para>
        /// </summary>
        public string SourceKMSKeyArn
        {
            get { return this._sourceKMSKeyArn; }
            set { this._sourceKMSKeyArn = value; }
        }

        // Check to see if SourceKMSKeyArn property is set
        internal bool IsSetSourceKMSKeyArn()
        {
            return this._sourceKMSKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// The base64-encoded contents of the deployment package. Amazon Web Services SDK and
        /// CLI clients handle the encoding for you. Use only with a function defined with a .zip
        /// file archive deployment package.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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