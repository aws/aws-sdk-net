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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters that are required to connect to an S3 knowledge base data source.
    /// 
    ///  
    /// <para>
    ///  <b>Prerequisites: Amazon S3 bucket access</b> 
    /// </para>
    ///  
    /// <para>
    /// Before you call <c>CreateKnowledgeBase</c> for an Amazon S3 knowledge base, an administrator
    /// must grant Amazon QuickSight access to the source S3 bucket. If access has not been
    /// granted for the bucket, knowledge base creation fails.
    /// </para>
    ///  
    /// <para>
    /// To grant access, an administrator adds the bucket in the Amazon QuickSight admin console,
    /// under Permissions, Amazon Web Services resources, Amazon S3, Select S3 buckets. This
    /// authorizes the Amazon QuickSight service role to read the bucket. The bucket can be
    /// in the same Amazon Web Services account or, when the bucket owner has authorized your
    /// account, in a different account.
    /// </para>
    ///  
    /// <para>
    /// The service role requires at least the following permissions on the bucket:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>s3:GetObject</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3:ListBucket</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3:GetBucketLocation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3:GetObjectVersion</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3:ListBucketVersions</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the full procedure, including cross-account buckets and KMS-encrypted buckets,
    /// see the Amazon S3 knowledge base administrator setup guide.
    /// </para>
    ///  <note> 
    /// <para>
    /// To grant access for a specific S3 knowledge base data source without granting account-wide
    /// S3 access, provide a custom IAM role on the data source by using <c>RoleArn</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class S3KnowledgeBaseParameters
    {
        /// <summary>
        /// Gets and sets the property BucketUrl. 
        /// <para>
        /// The URL of the S3 bucket that contains the knowledge base data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string BucketUrl { get; set; }

        /// <summary>
        /// Checks to see if the BucketUrl property is set.
        /// </summary>
        internal bool IsSetBucketUrl() => this.BucketUrl != null;

        /// <summary>
        /// Gets and sets the property MetadataFilesLocation. 
        /// <para>
        /// The Amazon S3 location (prefix) of per-document metadata files. Each metadata file
        /// describes a single source document and its indexable attributes, such as title, category,
        /// and version. This is not the global ACL configuration file. To apply a single global
        /// ACL file to the entire knowledge base, use the access control configuration instead.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string MetadataFilesLocation { get; set; }

        /// <summary>
        /// Checks to see if the MetadataFilesLocation property is set.
        /// </summary>
        internal bool IsSetMetadataFilesLocation() => this.MetadataFilesLocation != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Use the <c>RoleArn</c> structure to override an account-wide role for a specific S3
        /// Knowledge Base data source. For example, say an account administrator has turned off
        /// all S3 access with an account-wide role. The administrator can then use <c>RoleArn</c>
        /// to bypass the account-wide role and allow S3 access for the single S3 Knowledge Base
        /// data source that is specified in the structure, even if the account-wide role forbidding
        /// S3 access is still active.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
