/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Amazon S3.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class S3ActionIdentifiers
    {
        public static readonly ActionIdentifier AllS3Actions = new ActionIdentifier("s3:*");

        public static readonly ActionIdentifier AbortMultipartUpload = new ActionIdentifier("s3:AbortMultipartUpload");
        public static readonly ActionIdentifier CopyObject = new ActionIdentifier("s3:CopyObject");
        public static readonly ActionIdentifier CreateBucket = new ActionIdentifier("s3:CreateBucket");
        public static readonly ActionIdentifier DeleteBucket = new ActionIdentifier("s3:DeleteBucket");
        public static readonly ActionIdentifier DeleteObject = new ActionIdentifier("s3:DeleteObject");
        public static readonly ActionIdentifier DeleteObjectVersion = new ActionIdentifier("s3:DeleteObjectVersion");
        public static readonly ActionIdentifier GetBucketAccessControlPolicy = new ActionIdentifier("s3:GetBucketAccessControlPolicy");
        public static readonly ActionIdentifier GetBucketAcl = new ActionIdentifier("s3:GetBucketAcl");
        public static readonly ActionIdentifier GetBucketLocation = new ActionIdentifier("s3:GetBucketLocation");
        public static readonly ActionIdentifier GetBucketLogging = new ActionIdentifier("s3:GetBucketLogging");
        public static readonly ActionIdentifier GetBucketNotification = new ActionIdentifier("s3:GetBucketNotification");
        public static readonly ActionIdentifier GetBucketPolicy = new ActionIdentifier("s3:GetBucketPolicy");
        public static readonly ActionIdentifier GetBucketRequestPayment = new ActionIdentifier("s3:GetBucketRequestPayment");
        public static readonly ActionIdentifier GetBucketVersioning = new ActionIdentifier("s3:GetBucketVersioning");
        public static readonly ActionIdentifier GetLifecycleConfiguration = new ActionIdentifier("s3:GetLifecycleConfiguration");
        public static readonly ActionIdentifier GetObject = new ActionIdentifier("s3:GetObject");
        public static readonly ActionIdentifier GetObjectAccessControlPolicy = new ActionIdentifier("s3:GetObjectAccessControlPolicy");
        public static readonly ActionIdentifier GetObjectAcl = new ActionIdentifier("s3:GetObjectAcl");
        public static readonly ActionIdentifier GetObjectExtended = new ActionIdentifier("s3:GetObjectExtended");
        public static readonly ActionIdentifier GetObjectVersion = new ActionIdentifier("s3:GetObjectVersion");
        public static readonly ActionIdentifier GetObjectVersionAcl = new ActionIdentifier("s3:GetObjectVersionAcl");
        public static readonly ActionIdentifier ListAllMyBuckets = new ActionIdentifier("s3:ListAllMyBuckets");
        public static readonly ActionIdentifier ListBucket = new ActionIdentifier("s3:ListBucket");
        public static readonly ActionIdentifier ListBucketMultipartUploads = new ActionIdentifier("s3:ListBucketMultipartUploads");
        public static readonly ActionIdentifier ListBucketVersions = new ActionIdentifier("s3:ListBucketVersions");
        public static readonly ActionIdentifier ListMultipartUploadParts = new ActionIdentifier("s3:ListMultipartUploadParts");
        public static readonly ActionIdentifier PutBucketAcl = new ActionIdentifier("s3:PutBucketAcl");
        public static readonly ActionIdentifier PutBucketNotification = new ActionIdentifier("s3:PutBucketNotification");
        public static readonly ActionIdentifier PutBucketLogging = new ActionIdentifier("s3:PutBucketLogging");
        public static readonly ActionIdentifier PutBucketPolicy = new ActionIdentifier("s3:PutBucketPolicy");
        public static readonly ActionIdentifier PutBucketRequestPayment = new ActionIdentifier("s3:PutBucketRequestPayment");
        public static readonly ActionIdentifier PutBucketVersioning = new ActionIdentifier("s3:PutBucketVersioning");
        public static readonly ActionIdentifier PutLifecycleConfiguration = new ActionIdentifier("s3:PutLifecycleConfiguration");
        public static readonly ActionIdentifier PutObject = new ActionIdentifier("s3:PutObject");
        public static readonly ActionIdentifier PutObjectAcl = new ActionIdentifier("s3:PutObjectAcl");
        public static readonly ActionIdentifier PutObjectInline = new ActionIdentifier("s3:PutObjectInline");
        public static readonly ActionIdentifier PutObjectVersionAcl = new ActionIdentifier("s3:PutObjectVersionAcl");
        public static readonly ActionIdentifier SetBucketAccessControlPolicy = new ActionIdentifier("s3:SetBucketAccessControlPolicy");
        public static readonly ActionIdentifier SetObjectAccessControlPolicy = new ActionIdentifier("s3:SetObjectAccessControlPolicy");
    }
}
