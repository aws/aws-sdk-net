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
    /// Container for the parameters to the DeleteBucketMetadataTableConfiguration operation.
    /// <important> 
    /// <para>
    ///  We recommend that you delete your S3 Metadata configurations by using the V2 <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketMetadataTableConfiguration.html">DeleteBucketMetadataTableConfiguration</a>
    /// API operation. We no longer recommend using the V1 <c>DeleteBucketMetadataTableConfiguration</c>
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
    ///  Deletes a V1 S3 Metadata configuration from a general purpose bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-overview.html">Accelerating
    /// data discovery with S3 Metadata</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can use the V2 <c>DeleteBucketMetadataConfiguration</c> API operation with V1
    /// or V2 metadata table configurations. However, if you try to use the V1 <c>DeleteBucketMetadataTableConfiguration</c>
    /// API operation with V2 configurations, you will receive an HTTP <c>405 Method Not Allowed</c>
    /// error.
    /// </para>
    ///  
    /// <para>
    /// Make sure that you update your processes to use the new V2 API operations (<c>CreateBucketMetadataConfiguration</c>,
    /// <c>GetBucketMetadataConfiguration</c>, and <c>DeleteBucketMetadataConfiguration</c>)
    /// instead of the V1 API operations. 
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// To use this operation, you must have the <c>s3:DeleteBucketMetadataTableConfiguration</c>
    /// permission. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-permissions.html">Setting
    /// up permissions for configuring metadata tables</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>DeleteBucketMetadataTableConfiguration</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucketMetadataTableConfiguration.html">CreateBucketMetadataTableConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketMetadataTableConfiguration.html">GetBucketMetadataTableConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteBucketMetadataTableConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The general purpose bucket that you want to remove the metadata table configuration
        /// from. 
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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        ///  The expected bucket owner of the general purpose bucket that you want to remove the
        /// metadata table configuration from. 
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