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
    /// Container for the parameters to the UpdateBucketMetadataAnnotationTableConfiguration operation.
    /// Updates the annotation table configuration for an Amazon S3 bucket's metadata configuration.
    /// Use this operation to enable or disable the annotation table, or to update its associated
    /// IAM role.
    /// 
    ///  
    /// <para>
    /// An annotation table is a queryable Iceberg table that contains records of all annotations
    /// attached to objects in the bucket. To use this operation, the bucket must have an
    /// existing Amazon S3 Metadata configuration.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have the <c>s3:UpdateBucketMetadataAnnotationTableConfiguration</c>
    /// permission. If you are specifying or changing the IAM role, you must also have <c>iam:PassRole</c>
    /// permission for the role.
    /// </para>
    ///  
    /// <para>
    /// The IAM role must have a trust policy that allows the Amazon S3 metadata service to
    /// assume it, and a permissions policy that grants the actions needed to read annotations
    /// from your bucket. The following examples show a trust policy and a permissions policy
    /// that you can adapt for your bucket and account.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>UpdateBucketMetadataAnnotationTableConfiguration</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucketMetadataConfiguration.html">CreateBucketMetadataConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketMetadataConfiguration.html">GetBucketMetadataConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateBucketMetadataAnnotationTableConfigurationRequest : AmazonWebServiceRequest
    {
        private AnnotationTableConfigurationUpdates _annotationTableConfiguration;
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property AnnotationTableConfiguration. 
        /// <para>
        /// The annotation table configuration updates to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnnotationTableConfigurationUpdates AnnotationTableConfiguration
        {
            get { return this._annotationTableConfiguration; }
            set { this._annotationTableConfiguration = value; }
        }

        // Check to see if AnnotationTableConfiguration property is set
        internal bool IsSetAnnotationTableConfiguration()
        {
            return this._annotationTableConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket whose annotation table configuration to update.
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
        /// Checksum algorithm for the request payload.
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
        /// Base64-encoded MD5 digest of the message body.
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
        /// The account ID of the expected bucket owner.
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

    }
}