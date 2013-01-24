/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

namespace Amazon.S3.Model
{
    /// <summary>
    /// An Enumeration of all possible CannedACLs that can be used
    /// for S3 Buckets or S3 Objects. For more information about CannedACLs, refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/RESTAccessPolicy.html#RESTCannedAccessPolicies"/>
    /// </summary>
    public enum S3CannedACL
    {
        /// <summary>
        /// No Canned ACL is used.
        /// </summary>
        NoACL,

        /// <summary>
        /// Owner gets FULL_CONTROL.
        /// No one else has access rights (default).
        /// </summary>
        Private,

        /// <summary>
        /// Owner gets FULL_CONTROL and the anonymous principal is granted READ access.
        /// If this policy is used on an object, it can be read from a browser with no authentication.
        /// </summary>
        PublicRead,

        /// <summary>
        /// Owner gets FULL_CONTROL, the anonymous principal is granted READ and WRITE access.
        /// This can be a useful policy to apply to a bucket, but is generally not recommended.
        /// </summary>
        PublicReadWrite,

        /// <summary>
        /// Owner gets FULL_CONTROL, and any principal authenticated as a registered Amazon
        /// S3 user is granted READ access.
        /// </summary>
        AuthenticatedRead,

        /// <summary>
        /// Object Owner gets FULL_CONTROL, Bucket Owner gets READ
        /// This ACL applies only to objects and is equivalent to private when used with PUT Bucket. 
        /// You use this ACL to let someone other than the bucket owner write content (get full control) 
        /// in the bucket but still grant the bucket owner read access to the objects.
        /// </summary>
        BucketOwnerRead,

        /// <summary>
        /// Object Owner gets FULL_CONTROL, Bucket Owner gets FULL_CONTROL.
        /// This ACL applies only to objects and is equivalent to private when used with PUT Bucket. 
        /// You use this ACL to let someone other than the bucket owner write content (get full control) 
        /// in the bucket but still grant the bucket owner full rights over the objects.
        /// </summary>
        BucketOwnerFullControl,

        /// <summary>
        /// The LogDelivery group gets WRITE and READ_ACP permissions on the bucket.
        /// </summary>
        LogDeliveryWrite
    }

    internal enum S3QueryParameter
    {
        Action,
        Authorization,
        BucketVersion,
        CanonicalizedResource,
        ContentBody,
        ContentLength,
        ContentType,
        DestinationBucket,
        Expires,
        Key,
        Query,
        QueryToSign,
        Range,
        RequestAddress,
        RequestTimeout,
        RequestReadWriteTimeout,
        Url,
        Verb,
        VerifyChecksum,
        MaxUploads,
        KeyMarker,
        UploadIdMarker
    }

    /// <summary>
    /// An enumeration of all possible S3 Bucket region possibilities. For
    /// more information, refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/BucketConfiguration.html#LocationSelection"/>
    /// </summary>
    public enum S3Region
    {
        /// <summary>
        /// Specifies that the S3 Bucket should use US locality.
        /// This is the default value.
        /// </summary>
        US,
        /// <summary>
        /// Specifies that the S3 Bucket should use EU locality.
        /// </summary>
        EU,
        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-1 locality.
        /// </summary>
        SFO,
        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-2 locality.
        /// </summary>
        USW2,
        /// <summary>
        /// Specifies that the S3 Bucket should use the AP-SOUTHEAST-1 locality.
        /// </summary>
        APS1,
        /// <summary>
        /// Specifies that the S3 Bucket should use the AP-SOUTHEAST-2 locality.
        /// </summary>
        APS2,
        /// <summary>
        /// Specifies that the S3 Bucket should use the AP-NORTHEAST-1 locality.
        /// </summary>
        APN1,
        /// <summary>
        /// Specifies that the S3 Bucket should use the SA-EAST-1 locality.
        /// </summary>
        SAE1
    }

    /// <summary>
    /// An enumeration of all ACL permissions. For more information, refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/S3_ACLs.html#S3_ACLs_Permissions"/>
    /// </summary>
    public enum S3Permission
    {
        /// <summary>
        /// An invalid permission that will not make the request invalid.
        /// </summary>
        INVALID,

        /// <summary>
        /// When applied to a bucket, grants permission to list the bucket.
        /// When applied to an object, this grants permission to read the
        /// object data and/or metadata.
        /// </summary>
        READ,

        /// <summary>
        /// When applied to a bucket, grants permission to create, overwrite,
        /// and delete any object in the bucket. This permission is not
        /// supported for objects.
        /// </summary>
        WRITE,

        /// <summary>
        /// Grants permission to read the ACL for the applicable bucket or object.
        /// The owner of a bucket or object always has this permission implicitly.
        /// </summary>
        READ_ACP,

        /// <summary>
        /// Gives permission to overwrite the ACP for the applicable bucket or object.
        /// The owner of a bucket or object always has this permission implicitly.
        /// Granting this permission is equivalent to granting FULL_CONTROL because
        /// the grant recipient can make any changes to the ACP.
        /// </summary>
        WRITE_ACP,

        /// <summary>
        /// Provides READ, WRITE, READ_ACP, and WRITE_ACP permissions.
        /// It does not convey additional rights and is provided only for convenience.
        /// </summary>
        FULL_CONTROL,

        /// <summary>
        /// Gives permission to restore an object that is currently stored in Amazon Glacier
        /// for archival storage.
        /// </summary>
        RESTORE_OBJECT
    }

    /// <summary>
    /// An enumeration of all Metadata directives that
    /// can be used for the CopyObject operation.
    /// </summary>
    public enum S3MetadataDirective
    {
        /// <summary>
        /// Specifies that the metadata is copied from the source object.
        /// </summary>
        COPY,

        /// <summary>
        /// Specifies that the metadata is replaced with metadata provided in the request.
        /// All original metadata is replaced by the metadata you specify.
        /// </summary>
        REPLACE
    }

    /// <summary>
    /// An enumeration of all protocols that the pre-signed
    /// URL can be created against.
    /// </summary>
    public enum Protocol
    {
        /// <summary>
        /// https protocol will be used in the pre-signed URL.
        /// </summary>
        HTTPS,
        /// <summary>
        /// http protocol will be used in the pre-signed URL.
        /// </summary>
        HTTP
    }

    /// <summary>
    /// An enumeration of supported HTTP verbs
    /// </summary>
    public enum HttpVerb
    {
        /// <summary>
        /// The GET HTTP verb.
        /// </summary>
        GET,
        /// <summary>
        /// The HEAD HTTP verb.
        /// </summary>
        HEAD,
        /// <summary>
        /// The PUT HTTP verb.
        /// </summary>
        PUT,
        /// <summary>
        /// The DELETE HTTP verb.
        /// </summary>
        DELETE
    }

    /// <summary>
    /// Specifies the Storage Class of of an S3 object. Possible values
    /// are: <list type="bullet">
    /// <item>ReducedRedundancy: provides a 99.99% durability guarantee</item>
    /// <item>Standard: provides a 99.999999999% durability guarantee</item>
    /// </list>
    /// </summary>
    public enum S3StorageClass
    {
        /// <summary>
        /// The STANDARD storage class, which is the default
        /// storage class for S3 objects. Provides a 99.999999999%
        /// durability guarantee.
        /// </summary>
        Standard,
        /// <summary>
        /// The REDUCED_REDUNDANCY storage class for S3 objects. This
        /// provides a reduced (99.99%) durability guarantee at a lower
        /// cost as compared to the STANDARD storage class. Use this
        /// storage class for non-mission critical data or for data 
        /// that doesn’t require the higher level of durability that S3
        /// provides with the STANDARD storage class.
        /// </summary>
        ReducedRedundancy,
        /// <summary>
        /// The GLACIER storage is for object that are stored in Amazon Glacier.
        /// This storage class is for objects that are for archival purpose and 
        /// get operations are rare.
        /// </summary>
        Glacier
    }

    /// <summary>
    /// The constants for the known event names used by S3 notification. S3 might add new
    /// events before the SDK is updated. In which case the names listed in the S3 documentation
    /// will work as well as these constants.
    /// </summary>
    public sealed class NotificationEvents
    {
        /// <summary>
        /// An event that says an object has been lost in the reduced redundancy storage.
        /// </summary>
        public static readonly string ReducedRedundancyLostObject = "s3:ReducedRedundancyLostObject";

        private NotificationEvents()
        {
        }
    }

    /// <summary>
    /// The enumeration of all server-side encryption methods.
    /// </summary>
    public enum ServerSideEncryptionMethod
    {
        None,
        AES256
    }
}