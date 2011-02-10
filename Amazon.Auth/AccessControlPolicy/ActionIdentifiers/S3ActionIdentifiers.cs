/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        /// <summary>
        /// Represents any action being taken on Amazon S3.
        /// </summary>
        public static readonly ActionIdentifier AllS3Actions = new ActionIdentifier("s3:*");

        /// <summary>
        /// Action for retrieving an object (GET), object metadata (HEAD) or an object torrent.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetObjectRequest"/>
        /// <see cref="Amazon.S3.Model.GetObjectMetadataRequest"/>
        public static readonly ActionIdentifier GetObject = new ActionIdentifier("s3:GetObject");

        /// <summary>
        /// Action for retrieving a object version (GET), object metadata for an
        /// object version (HEAD) or a torrent for an object version.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetObjectRequest"/>
        /// <see cref="Amazon.S3.Model.GetObjectMetadataRequest"/>
        public static readonly ActionIdentifier GetObjectVersion = new ActionIdentifier("s3:GetObjectVersion");

        /// <summary>
        /// Action for uploading an object (PUT or POST).
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.PutObjectRequest"/>
        public static readonly ActionIdentifier PutObject = new ActionIdentifier("s3:PutObject");

        /// <summary>
        /// Action for retrieving an object's ACL.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetACLRequest"/>
        public static readonly ActionIdentifier GetObjectAcl = new ActionIdentifier("s3:GetObjectAcl");

        /// <summary>
        /// Action for retrieving an object version's ACL.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetACLRequest"/>
        public static readonly ActionIdentifier GetObjectVersionAcl = new ActionIdentifier("s3:GetObjectVersionAcl");

        /// <summary>
        /// Action for setting an object's ACL.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.S3AccessControlList"/>
        /// <see cref="Amazon.S3.Model.S3CannedACL"/>
        public static readonly ActionIdentifier SetObjectAcl = new ActionIdentifier("s3:PutObjectAcl");

        /// <summary>
        /// Action for setting an object version's ACL.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.S3AccessControlList"/>
        /// <see cref="Amazon.S3.Model.S3CannedACL"/>
        public static readonly ActionIdentifier SetObjectVersionAcl = new ActionIdentifier("s3:PutObjectAclVersion");

        /// <summary>
        /// Action for deleting an object.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.DeleteObjectRequest"/>
        public static readonly ActionIdentifier DeleteObject = new ActionIdentifier("s3:DeleteObject");

        /// <summary>
        /// Action for deleting an object version.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.DeleteObjectRequest"/>
        public static readonly ActionIdentifier DeleteObjectVersion = new ActionIdentifier("s3:DeleteObjectVersion");

        /// <summary>
        /// Action for creating a new Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.PutBucketRequest"/>
        public static readonly ActionIdentifier CreateBucket = new ActionIdentifier("s3:CreateBucket");

        /// <summary>
        /// Action for deleting an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3ObjectResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.DeleteBucketRequest"/>
        public static readonly ActionIdentifier DeleteBucket = new ActionIdentifier("s3:DeleteBucket");

        /// <summary>
        /// Action for listing the objects in an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.ListObjectsRequest"/>
        public static readonly ActionIdentifier ListObjects = new ActionIdentifier("s3:ListBucket");

        /// <summary>
        /// Action for listing the object versions in an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.ListVersionsRequest"/>
        public static readonly ActionIdentifier ListObjectVersions = new ActionIdentifier("s3:ListBucketVersions");

        /// <summary>
        /// Action for listing the Amazon S3 buckets in an account.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.ListBucketsRequest"/>
        public static readonly ActionIdentifier ListBuckets = new ActionIdentifier("s3:ListAllMyBuckets");

        /// <summary>
        /// Action for retrieving the ACL of an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetACLRequest"/>
        public static readonly ActionIdentifier GetBucketAcl = new ActionIdentifier("s3:GetBucketAcl");

        /// <summary>
        /// Action for setting the ACL of an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.S3AccessControlList"/>
        /// <see cref="Amazon.S3.Model.S3CannedACL"/>
        public static readonly ActionIdentifier SetBucketAcl = new ActionIdentifier("s3:PutBucketAcl");

        /// <summary>
        /// Action for retrieving the versioning configuration of an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.S3BucketVersioningConfig"/>
        /// <see cref="Amazon.S3.Model.GetBucketVersioningRequest"/>
        public static readonly ActionIdentifier GetBucketVersioningConfiguration = new ActionIdentifier("s3:GetBucketVersioning");

        /// <summary>
        /// Action for setting the versioning configuration of an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.S3BucketVersioningConfig"/>
        /// <see cref="Amazon.S3.Model.SetBucketVersioningRequest"/>
        public static readonly ActionIdentifier SetBucketVersioningConfiguration = new ActionIdentifier("s3:PutBucketVersioning");

        /// <summary>
        /// Action for retrieving the requester pays status of an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        public static readonly ActionIdentifier GetBucketRequesterPays = new ActionIdentifier("s3:GetBucketRequesterPays");

        /// <summary>
        /// Action for setting the requester pays status of an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        public static readonly ActionIdentifier SetBucketRequesterPays = new ActionIdentifier("s3:PutBucketRequesterPays");

        /// <summary>
        /// Action for retrieving the bucket location of an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetBucketLocationRequest"/>
        public static readonly ActionIdentifier GetBucketLocation = new ActionIdentifier("s3:GetBucketLocation");

        /// <summary>
        /// Action for retrieving the access control policy for an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetBucketPolicyRequest"/>
        public static readonly ActionIdentifier GetBucketPolicy = new ActionIdentifier("s3:GetBucketPolicy");

        /// <summary>
        /// Action for setting the access control policy for an Amazon S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.PutBucketPolicyRequest"/>
        public static readonly ActionIdentifier PutBucketPolicy = new ActionIdentifier("s3:PutBucketPolicy");

        /// <summary>
        /// Action for retrieving the bucket notification configuration for an Amazon
        /// S3 bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.GetNotificationConfigurationRequest"/>
        public static readonly ActionIdentifier GetBucketNotificationConfiguration = new ActionIdentifier("s3:GetBucketNotification");

        /// <summary>
        /// Action for setting the bucket notification configuration for an Amazon S3
        /// bucket.
        /// <para>
        /// Valid for use with <see cref="M:Amazon.Auth.AccessControlPolicy.NewS3BucketResource"/> resources.
        /// </para>
        /// </summary>
        /// <see cref="Amazon.S3.Model.SetNotificationConfigurationRequest"/>
        public static readonly ActionIdentifier SetBucketNotificationConfiguration = new ActionIdentifier("s3:PutBucketNotification");

        private S3ActionIdentifiers() 
        {
        }
    }
}
