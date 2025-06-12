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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CopyProjectVersion operation.
    /// <note> 
    /// <para>
    /// This operation applies only to Amazon Rekognition Custom Labels.
    /// </para>
    ///  </note> 
    /// <para>
    /// Copies a version of an Amazon Rekognition Custom Labels model from a source project
    /// to a destination project. The source and destination projects can be in different
    /// AWS accounts but must be in the same AWS Region. You can't copy a model to another
    /// AWS service. 
    /// </para>
    ///  
    /// <para>
    /// To copy a model version to a different AWS account, you need to create a resource-based
    /// policy known as a <i>project policy</i>. You attach the project policy to the source
    /// project by calling <a>PutProjectPolicy</a>. The project policy gives permission to
    /// copy the model version from a trusting AWS account to a trusted account.
    /// </para>
    ///  
    /// <para>
    /// For more information creating and attaching a project policy, see Attaching a project
    /// policy (SDK) in the <i>Amazon Rekognition Custom Labels Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// If you are copying a model version to a project in the same AWS account, you don't
    /// need to create a project policy.
    /// </para>
    ///  <note> 
    /// <para>
    /// Copying project versions is supported only for Custom Labels models. 
    /// </para>
    ///  
    /// <para>
    /// To copy a model, the destination project, source project, and source model version
    /// must already exist.
    /// </para>
    ///  </note> 
    /// <para>
    /// Copying a model version takes a while to complete. To get the current status, call
    /// <a>DescribeProjectVersions</a> and check the value of <c>Status</c> in the <a>ProjectVersionDescription</a>
    /// object. The copy operation has finished when the value of <c>Status</c> is <c>COPYING_COMPLETED</c>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:CopyProjectVersion</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class CopyProjectVersionRequest : AmazonRekognitionRequest
    {
        private string _destinationProjectArn;
        private string _kmsKeyId;
        private OutputConfig _outputConfig;
        private string _sourceProjectArn;
        private string _sourceProjectVersionArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property DestinationProjectArn. 
        /// <para>
        /// The ARN of the project in the trusted AWS account that you want to copy the model
        /// version to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DestinationProjectArn
        {
            get { return this._destinationProjectArn; }
            set { this._destinationProjectArn = value; }
        }

        // Check to see if DestinationProjectArn property is set
        internal bool IsSetDestinationProjectArn()
        {
            return this._destinationProjectArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier for your AWS Key Management Service key (AWS KMS key). You can supply
        /// the Amazon Resource Name (ARN) of your KMS key, the ID of your KMS key, an alias for
        /// your KMS key, or an alias ARN. The key is used to encrypt training results and manifest
        /// files written to the output Amazon S3 bucket (<c>OutputConfig</c>).
        /// </para>
        ///  
        /// <para>
        /// If you choose to use your own KMS key, you need the following permissions on the KMS
        /// key.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// kms:CreateGrant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:DescribeKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:GenerateDataKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:Decrypt
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value for <c>KmsKeyId</c>, images copied into the service are
        /// encrypted using a key that AWS owns and manages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The S3 bucket and folder location where the training output for the source model version
        /// is placed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProjectArn. 
        /// <para>
        /// The ARN of the source project in the trusting AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SourceProjectArn
        {
            get { return this._sourceProjectArn; }
            set { this._sourceProjectArn = value; }
        }

        // Check to see if SourceProjectArn property is set
        internal bool IsSetSourceProjectArn()
        {
            return this._sourceProjectArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProjectVersionArn. 
        /// <para>
        /// The ARN of the model version in the source project that you want to copy to a destination
        /// project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SourceProjectVersionArn
        {
            get { return this._sourceProjectVersionArn; }
            set { this._sourceProjectVersionArn = value; }
        }

        // Check to see if SourceProjectVersionArn property is set
        internal bool IsSetSourceProjectVersionArn()
        {
            return this._sourceProjectVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value tags to assign to the model version. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// A name for the version of the model that's copied to the destination project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}