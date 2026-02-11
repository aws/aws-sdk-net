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
    /// Container for the parameters to the UpdateBucketMetadataInventoryTableConfiguration operation.
    /// Enables or disables a live inventory table for an S3 Metadata configuration on a general
    /// purpose bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-overview.html">Accelerating
    /// data discovery with S3 Metadata</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// To use this operation, you must have the following permissions. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-permissions.html">Setting
    /// up permissions for configuring metadata tables</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you want to encrypt your inventory table with server-side encryption with Key Management
    /// Service (KMS) keys (SSE-KMS), you need additional permissions in your KMS key policy.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-permissions.html">
    /// Setting up permissions for configuring metadata tables</a> in the <i>Amazon S3 User
    /// Guide</i>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>s3:UpdateBucketMetadataInventoryTableConfiguration</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:CreateTableBucket</c> 
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
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:PutTableEncryption</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>kms:DescribeKey</c> 
    /// </para>
    ///  </li> </ul> </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>UpdateBucketMetadataInventoryTableConfiguration</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucketMetadataConfiguration.html">CreateBucketMetadataConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketMetadataConfiguration.html">DeleteBucketMetadataConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketMetadataConfiguration.html">GetBucketMetadataConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UpdateBucketMetadataJournalTableConfiguration.html">UpdateBucketMetadataJournalTableConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateBucketMetadataInventoryTableConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private InventoryTableConfigurationUpdates _inventoryTableConfiguration;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The general purpose bucket that corresponds to the metadata configuration that you
        /// want to enable or disable an inventory table for. 
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
        ///  The checksum algorithm to use with your inventory table configuration. 
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
        ///  The <c>Content-MD5</c> header for the inventory table configuration. 
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
            return !String.IsNullOrEmpty(this._contentMD5);
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        ///  The expected owner of the general purpose bucket that corresponds to the metadata
        /// table configuration that you want to enable or disable an inventory table for. 
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
            return !String.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property InventoryTableConfiguration. 
        /// <para>
        ///  The contents of your inventory table configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryTableConfigurationUpdates InventoryTableConfiguration
        {
            get { return this._inventoryTableConfiguration; }
            set { this._inventoryTableConfiguration = value; }
        }

        // Check to see if InventoryTableConfiguration property is set
        internal bool IsSetInventoryTableConfiguration()
        {
            return this._inventoryTableConfiguration != null;
        }

    }
}