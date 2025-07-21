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
    /// If an S3 Metadata V1 <c>CreateBucketMetadataTableConfiguration</c> or V2 <c>CreateBucketMetadataConfiguration</c>
    /// request succeeds, but S3 Metadata was unable to create the table, this structure contains
    /// the error code and error message. 
    /// 
    ///  <note> 
    /// <para>
    /// If you created your S3 Metadata configuration before July 15, 2025, we recommend that
    /// you delete and re-create your configuration by using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucketMetadataConfiguration.html">CreateBucketMetadataConfiguration</a>
    /// so that you can expire journal table records and create a live inventory table.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ErrorDetails
    {
        private string _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  If the V1 <c>CreateBucketMetadataTableConfiguration</c> request succeeds, but S3
        /// Metadata was unable to create the table, this structure contains the error code. The
        /// possible error codes and error messages are as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AccessDeniedCreatingResources</c> - You don't have sufficient permissions to create
        /// the required resources. Make sure that you have <c>s3tables:CreateNamespace</c>, <c>s3tables:CreateTable</c>,
        /// <c>s3tables:GetTable</c> and <c>s3tables:PutTablePolicy</c> permissions, and then
        /// try again. To create a new metadata table, you must delete the metadata configuration
        /// for this bucket, and then create a new metadata configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessDeniedWritingToTable</c> - Unable to write to the metadata table because
        /// of missing resource permissions. To fix the resource policy, Amazon S3 needs to create
        /// a new metadata table. To create a new metadata table, you must delete the metadata
        /// configuration for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DestinationTableNotFound</c> - The destination table doesn't exist. To create
        /// a new metadata table, you must delete the metadata configuration for this bucket,
        /// and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServerInternalError</c> - An internal error has occurred. To create a new metadata
        /// table, you must delete the metadata configuration for this bucket, and then create
        /// a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TableAlreadyExists</c> - The table that you specified already exists in the table
        /// bucket's namespace. Specify a different table name. To create a new metadata table,
        /// you must delete the metadata configuration for this bucket, and then create a new
        /// metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TableBucketNotFound</c> - The table bucket that you specified doesn't exist in
        /// this Amazon Web Services Region and account. Create or choose a different table bucket.
        /// To create a new metadata table, you must delete the metadata configuration for this
        /// bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If the V2 <c>CreateBucketMetadataConfiguration</c> request succeeds, but S3 Metadata
        /// was unable to create the table, this structure contains the error code. The possible
        /// error codes and error messages are as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AccessDeniedCreatingResources</c> - You don't have sufficient permissions to create
        /// the required resources. Make sure that you have <c>s3tables:CreateTableBucket</c>,
        /// <c>s3tables:CreateNamespace</c>, <c>s3tables:CreateTable</c>, <c>s3tables:GetTable</c>,
        /// <c>s3tables:PutTablePolicy</c>, <c>kms:DescribeKey</c>, and <c>s3tables:PutTableEncryption</c>
        /// permissions. Additionally, ensure that the KMS key used to encrypt the table still
        /// exists, is active and has a resource policy granting access to the S3 service principals
        /// '<c>maintenance.s3tables.amazonaws.com</c>' and '<c>metadata.s3.amazonaws.com</c>'.
        /// To create a new metadata table, you must delete the metadata configuration for this
        /// bucket, and then create a new metadata configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessDeniedWritingToTable</c> - Unable to write to the metadata table because
        /// of missing resource permissions. To fix the resource policy, Amazon S3 needs to create
        /// a new metadata table. To create a new metadata table, you must delete the metadata
        /// configuration for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DestinationTableNotFound</c> - The destination table doesn't exist. To create
        /// a new metadata table, you must delete the metadata configuration for this bucket,
        /// and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServerInternalError</c> - An internal error has occurred. To create a new metadata
        /// table, you must delete the metadata configuration for this bucket, and then create
        /// a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JournalTableAlreadyExists</c> - A journal table already exists in the Amazon Web
        /// Services managed table bucket's namespace. Delete the journal table, and then try
        /// again. To create a new metadata table, you must delete the metadata configuration
        /// for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InventoryTableAlreadyExists</c> - An inventory table already exists in the Amazon
        /// Web Services managed table bucket's namespace. Delete the inventory table, and then
        /// try again. To create a new metadata table, you must delete the metadata configuration
        /// for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JournalTableNotAvailable</c> - The journal table that the inventory table relies
        /// on has a <c>FAILED</c> status. An inventory table requires a journal table with an
        /// <c>ACTIVE</c> status. To create a new journal or inventory table, you must delete
        /// the metadata configuration for this bucket, along with any journal or inventory tables,
        /// and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NoSuchBucket</c> - The specified general purpose bucket does not exist.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  If the V1 <c>CreateBucketMetadataTableConfiguration</c> request succeeds, but S3
        /// Metadata was unable to create the table, this structure contains the error message.
        /// The possible error codes and error messages are as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AccessDeniedCreatingResources</c> - You don't have sufficient permissions to create
        /// the required resources. Make sure that you have <c>s3tables:CreateNamespace</c>, <c>s3tables:CreateTable</c>,
        /// <c>s3tables:GetTable</c> and <c>s3tables:PutTablePolicy</c> permissions, and then
        /// try again. To create a new metadata table, you must delete the metadata configuration
        /// for this bucket, and then create a new metadata configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessDeniedWritingToTable</c> - Unable to write to the metadata table because
        /// of missing resource permissions. To fix the resource policy, Amazon S3 needs to create
        /// a new metadata table. To create a new metadata table, you must delete the metadata
        /// configuration for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DestinationTableNotFound</c> - The destination table doesn't exist. To create
        /// a new metadata table, you must delete the metadata configuration for this bucket,
        /// and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServerInternalError</c> - An internal error has occurred. To create a new metadata
        /// table, you must delete the metadata configuration for this bucket, and then create
        /// a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TableAlreadyExists</c> - The table that you specified already exists in the table
        /// bucket's namespace. Specify a different table name. To create a new metadata table,
        /// you must delete the metadata configuration for this bucket, and then create a new
        /// metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TableBucketNotFound</c> - The table bucket that you specified doesn't exist in
        /// this Amazon Web Services Region and account. Create or choose a different table bucket.
        /// To create a new metadata table, you must delete the metadata configuration for this
        /// bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If the V2 <c>CreateBucketMetadataConfiguration</c> request succeeds, but S3 Metadata
        /// was unable to create the table, this structure contains the error code. The possible
        /// error codes and error messages are as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AccessDeniedCreatingResources</c> - You don't have sufficient permissions to create
        /// the required resources. Make sure that you have <c>s3tables:CreateTableBucket</c>,
        /// <c>s3tables:CreateNamespace</c>, <c>s3tables:CreateTable</c>, <c>s3tables:GetTable</c>,
        /// <c>s3tables:PutTablePolicy</c>, <c>kms:DescribeKey</c>, and <c>s3tables:PutTableEncryption</c>
        /// permissions. Additionally, ensure that the KMS key used to encrypt the table still
        /// exists, is active and has a resource policy granting access to the S3 service principals
        /// '<c>maintenance.s3tables.amazonaws.com</c>' and '<c>metadata.s3.amazonaws.com</c>'.
        /// To create a new metadata table, you must delete the metadata configuration for this
        /// bucket, and then create a new metadata configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessDeniedWritingToTable</c> - Unable to write to the metadata table because
        /// of missing resource permissions. To fix the resource policy, Amazon S3 needs to create
        /// a new metadata table. To create a new metadata table, you must delete the metadata
        /// configuration for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DestinationTableNotFound</c> - The destination table doesn't exist. To create
        /// a new metadata table, you must delete the metadata configuration for this bucket,
        /// and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServerInternalError</c> - An internal error has occurred. To create a new metadata
        /// table, you must delete the metadata configuration for this bucket, and then create
        /// a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JournalTableAlreadyExists</c> - A journal table already exists in the Amazon Web
        /// Services managed table bucket's namespace. Delete the journal table, and then try
        /// again. To create a new metadata table, you must delete the metadata configuration
        /// for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InventoryTableAlreadyExists</c> - An inventory table already exists in the Amazon
        /// Web Services managed table bucket's namespace. Delete the inventory table, and then
        /// try again. To create a new metadata table, you must delete the metadata configuration
        /// for this bucket, and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JournalTableNotAvailable</c> - The journal table that the inventory table relies
        /// on has a <c>FAILED</c> status. An inventory table requires a journal table with an
        /// <c>ACTIVE</c> status. To create a new journal or inventory table, you must delete
        /// the metadata configuration for this bucket, along with any journal or inventory tables,
        /// and then create a new metadata configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NoSuchBucket</c> - The specified general purpose bucket does not exist.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

    }
}