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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBucketMetadataTableConfiguration operation.
    /// <important> 
    /// <para>
    ///  We recommend that you create your S3 Metadata configurations by using the V2 <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucketMetadataConfiguration.html">CreateBucketMetadataConfiguration</a>
    /// API operation. We no longer recommend using the V1 <c>CreateBucketMetadataTableConfiguration</c>
    /// API operation. 
    /// </para>
    ///  
    /// <para>
    /// If you created your S3 Metadata configuration before July 15, 2025, we recommend that
    /// you delete and re-create your configuration by using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucketMetadataConfiguration.html">CreateBucketMetadataConfiguration</a>
    /// so that you can expire journal table records and create a live inventory table.
    /// </para>
    ///  </important> 
    /// <para>
    /// Creates a V1 S3 Metadata configuration for a general purpose bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-overview.html">Accelerating
    /// data discovery with S3 Metadata</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// To use this operation, you must have the following permissions. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-permissions.html">Setting
    /// up permissions for configuring metadata tables</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you want to encrypt your metadata tables with server-side encryption with Key Management
    /// Service (KMS) keys (SSE-KMS), you need additional permissions. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-permissions.html">
    /// Setting up permissions for configuring metadata tables</a> in the <i>Amazon S3 User
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you also want to integrate your table bucket with Amazon Web Services analytics
    /// services so that you can query your metadata table, you need additional permissions.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-integrating-aws.html">
    /// Integrating Amazon S3 Tables with Amazon Web Services analytics services</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>s3:CreateBucketMetadataTableConfiguration</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:CreateNamespace</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:GetTable</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:CreateTable</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:PutTablePolicy</c> 
    /// </para>
    ///  </li> </ul> </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>CreateBucketMetadataTableConfiguration</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketMetadataTableConfiguration.html">DeleteBucketMetadataTableConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketMetadataTableConfiguration.html">GetBucketMetadataTableConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateBucketMetadataTableConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private MetadataTableConfiguration _metadataTableConfiguration;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The general purpose bucket that you want to create the metadata table configuration
        /// for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        ///  The checksum algorithm to use with your metadata table configuration. 
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        ///  The <c>Content-MD5</c> header for the metadata table configuration. 
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        ///  The expected owner of the general purpose bucket that corresponds to your metadata
        /// table configuration. 
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataTableConfiguration. 
        /// <para>
        ///  The contents of your metadata table configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataTableConfiguration MetadataTableConfiguration
        {
            get { return this._metadataTableConfiguration; }
            set { this._metadataTableConfiguration = value; }
        }

        // Check to see if MetadataTableConfiguration property is set
        internal bool IsSetMetadataTableConfiguration()
        {
            return this._metadataTableConfiguration != null;
        }

    }
}