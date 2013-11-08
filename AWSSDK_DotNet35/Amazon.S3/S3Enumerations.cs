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
using System;
using System.Collections.Generic;
using System.Reflection;

using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.S3
{
    /// <summary>
    /// A list of all possible CannedACLs that can be used
    /// for S3 Buckets or S3 Objects. For more information about CannedACLs, refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/RESTAccessPolicy.html#RESTCannedAccessPolicies"/>
    /// </summary>
    public sealed class S3CannedACL : ConstantClass
    {
        /// <summary>
        /// Owner gets FULL_CONTROL.
        /// No one else has access rights (default).
        /// </summary>
        public static readonly S3CannedACL NoACL = new S3CannedACL("NoACL");

        /// <summary>
        /// Owner gets FULL_CONTROL.
        /// No one else has access rights (default).
        /// </summary>
        public static readonly S3CannedACL Private = new S3CannedACL("private");

        /// <summary>
        /// Owner gets FULL_CONTROL and the anonymous principal is granted READ access.
        /// If this policy is used on an object, it can be read from a browser with no authentication.
        /// </summary>
        public static readonly S3CannedACL PublicRead = new S3CannedACL("public-read");

        /// <summary>
        /// Owner gets FULL_CONTROL, the anonymous principal is granted READ and WRITE access.
        /// This can be a useful policy to apply to a bucket, but is generally not recommended.
        /// </summary>
        public static readonly S3CannedACL PublicReadWrite = new S3CannedACL("public-read-write");

        /// <summary>
        /// Owner gets FULL_CONTROL, and any principal authenticated as a registered Amazon
        /// S3 user is granted READ access.
        /// </summary>
        public static readonly S3CannedACL AuthenticatedRead = new S3CannedACL("authenticated-read");

        /// <summary>
        /// Object Owner gets FULL_CONTROL, Bucket Owner gets READ
        /// This ACL applies only to objects and is equivalent to private when used with PUT Bucket. 
        /// You use this ACL to let someone other than the bucket owner write content (get full control) 
        /// in the bucket but still grant the bucket owner read access to the objects.
        /// </summary>
        public static readonly S3CannedACL BucketOwnerRead = new S3CannedACL("bucket-owner-read");

        /// <summary>
        /// Object Owner gets FULL_CONTROL, Bucket Owner gets FULL_CONTROL.
        /// This ACL applies only to objects and is equivalent to private when used with PUT Bucket. 
        /// You use this ACL to let someone other than the bucket owner write content (get full control) 
        /// in the bucket but still grant the bucket owner full rights over the objects.
        /// </summary>
        public static readonly S3CannedACL BucketOwnerFullControl = new S3CannedACL("bucket-owner-full-control");

        /// <summary>
        /// The LogDelivery group gets WRITE and READ_ACP permissions on the bucket.
        /// </summary>
        public static readonly S3CannedACL LogDeliveryWrite = new S3CannedACL("log-delivery-write");

        public S3CannedACL(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static S3CannedACL FindValue(string value)
        {
            return FindValue<S3CannedACL>(value);
        }

        public static implicit operator S3CannedACL(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all possible S3 Bucket region possibilities. For
    /// more information, refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/BucketConfiguration.html#LocationSelection"/>
    /// </summary>
    public sealed class S3Region : ConstantClass
    {
        /// <summary>
        /// Specifies that the S3 Bucket should use US locality.
        /// This is the default value.
        /// </summary>
        public static readonly S3Region US = new S3Region("");
        /// <summary>
        /// Specifies that the S3 Bucket should use EU locality.
        /// </summary>
        public static readonly S3Region EU = new S3Region("EU");
        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-1 locality.
        /// </summary>
        public static readonly S3Region USW1 = new S3Region("us-west-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-2 locality.
        /// </summary>
        public static readonly S3Region USW2 = new S3Region("us-west-2");
        /// <summary>
        /// Specifies that the S3 Bucket should use the AP-SOUTHEAST-1 locality.
        /// </summary>
        public static readonly S3Region APS1 = new S3Region("ap-southeast-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use the AP-SOUTHEAST-2 locality.
        /// </summary>
        public static readonly S3Region APS2 = new S3Region("ap-southeast-2");
        /// <summary>
        /// Specifies that the S3 Bucket should use the AP-NORTHEAST-1 locality.
        /// </summary>
        public static readonly S3Region APN1 = new S3Region("ap-northeast-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use the SA-EAST-1 locality.
        /// </summary>
        public static readonly S3Region SAE1 = new S3Region("sa-east-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-1 locality.
        /// </summary>
        [Obsolete("This constant is obsolete. Usags of this property should be migrated to the USW1 constant")]
        public static readonly S3Region SFO = new S3Region("us-west-1");

        public S3Region(string value)
            : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static S3Region FindValue(string value)
        {
            if (value == null)
                return S3Region.US;

            return FindValue<S3Region>(value);
        }

        public static implicit operator S3Region(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all ACL permissions. For more information, refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/S3_ACLs.html#S3_ACLs_Permissions"/>
    /// </summary>
    public sealed class S3Permission : ConstantClass
    {
        /// <summary>
        /// When applied to a bucket, grants permission to list the bucket.
        /// When applied to an object, this grants permission to read the
        /// object data and/or metadata.
        /// </summary>
        public static readonly S3Permission READ = new S3Permission("READ", "x-amz-grant-read");

        /// <summary>
        /// When applied to a bucket, grants permission to create, overwrite,
        /// and delete any object in the bucket. This permission is not
        /// supported for objects.
        /// </summary>
        public static readonly S3Permission WRITE = new S3Permission("WRITE", "x-amz-grant-write");

        /// <summary>
        /// Grants permission to read the ACL for the applicable bucket or object.
        /// The owner of a bucket or object always has this permission implicitly.
        /// </summary>
        public static readonly S3Permission READ_ACP = new S3Permission("READ_ACP", "x-amz-grant-read-acp");

        /// <summary>
        /// Gives permission to overwrite the ACP for the applicable bucket or object.
        /// The owner of a bucket or object always has this permission implicitly.
        /// Granting this permission is equivalent to granting FULL_CONTROL because
        /// the grant recipient can make any changes to the ACP.
        /// </summary>
        public static readonly S3Permission WRITE_ACP = new S3Permission("WRITE_ACP", "x-amz-grant-write-acp");

        /// <summary>
        /// Provides READ, WRITE, READ_ACP, and WRITE_ACP permissions.
        /// It does not convey additional rights and is provided only for convenience.
        /// </summary>
        public static readonly S3Permission FULL_CONTROL = new S3Permission("FULL_CONTROL", "x-amz-grant-full-control");

        /// <summary>
        /// Gives permission to restore an object that is currently stored in Amazon Glacier
        /// for archival storage.
        /// </summary>
        public static readonly S3Permission RESTORE_OBJECT = new S3Permission("RESTORE", "x-amz-grant-restore-object");

        public S3Permission(string value)
            : this(value, null) { }


        public S3Permission(string value, string headerName)
            : base(value)
        {
            this.HeaderName = headerName;
        }

        public string HeaderName
        {
            get;
            private set;
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static S3Permission FindValue(string value)
        {
            return FindValue<S3Permission>(value);
        }

        public static implicit operator S3Permission(string value)
        {
            return FindValue(value);
        }
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
    public sealed class S3StorageClass : ConstantClass
    {
        /// <summary>
        /// The STANDARD storage class, which is the default
        /// storage class for S3 objects. Provides a 99.999999999%
        /// durability guarantee.
        /// </summary>
        public static readonly S3StorageClass Standard = new S3StorageClass("STANDARD");
        /// <summary>
        /// The REDUCED_REDUNDANCY storage class for S3 objects. This
        /// provides a reduced (99.99%) durability guarantee at a lower
        /// cost as compared to the STANDARD storage class. Use this
        /// storage class for non-mission critical data or for data 
        /// that doesn’t require the higher level of durability that S3
        /// provides with the STANDARD storage class.
        /// </summary>
        public static readonly S3StorageClass ReducedRedundancy = new S3StorageClass("REDUCED_REDUNDANCY");
        /// <summary>
        /// The GLACIER storage is for object that are stored in Amazon Glacier.
        /// This storage class is for objects that are for archival purpose and 
        /// get operations are rare.
        /// </summary>
        public static readonly S3StorageClass Glacier = new S3StorageClass("GLACIER");

        public S3StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static S3StorageClass FindValue(string value)
        {
            return FindValue<S3StorageClass>(value);
        }

        public static implicit operator S3StorageClass(string value)
        {
            return FindValue(value);
        }
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
    /// A list of all server-side encryption methods.
    /// </summary>
    public sealed class ServerSideEncryptionMethod : ConstantClass
    {
        /// <summary>
        /// No server side encryption to be used.
        /// </summary>
        public static readonly ServerSideEncryptionMethod None = new ServerSideEncryptionMethod("");

        /// <summary>
        /// Use AES 256 server side encryption.
        /// </summary>
        public static readonly ServerSideEncryptionMethod AES256 = new ServerSideEncryptionMethod("AES256");

        public ServerSideEncryptionMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ServerSideEncryptionMethod FindValue(string value)
        {
            return FindValue<ServerSideEncryptionMethod>(value);
        }

        public static implicit operator ServerSideEncryptionMethod(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all grantee types.
    /// </summary>
    public sealed class GranteeType : ConstantClass
    {
        /// <summary>
        /// The predefined group.
        /// </summary>
        public static readonly GranteeType Group = new GranteeType("Group");

        /// <summary>
        /// The email address of an AWS account
        /// </summary>
        public static readonly GranteeType Email = new GranteeType("AmazonCustomerByEmail");

        /// <summary>
        /// The canonical user ID of an AWS account
        /// </summary>
        public static readonly GranteeType CanonicalUser = new GranteeType("CanonicalUser");


        public GranteeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GranteeType FindValue(string value)
        {
            return FindValue<GranteeType>(value);
        }

        public static implicit operator GranteeType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all lifecycle statuses.
    /// </summary>
    public sealed class LifecycleRuleStatus : ConstantClass
    {

        /// <summary>
        /// The rule is enabled.
        /// </summary>
        public static readonly LifecycleRuleStatus Enabled = new LifecycleRuleStatus("Enabled");

        /// <summary>
        /// The rule is disabled.
        /// </summary>
        public static readonly LifecycleRuleStatus Disabled = new LifecycleRuleStatus("Disabled");

        public LifecycleRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static LifecycleRuleStatus FindValue(string value)
        {
            return FindValue<LifecycleRuleStatus>(value);
        }

        public static implicit operator LifecycleRuleStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all version statuses.
    /// </summary>
    public sealed class VersionStatus : ConstantClass
    {
        /// <summary>
        /// The rule is off.
        /// </summary>
        public static readonly VersionStatus Off = new VersionStatus("Off");

        /// <summary>
        /// The rule is suspended.
        /// </summary>
        public static readonly VersionStatus Suspended = new VersionStatus("Suspended");

        /// <summary>
        /// The rule is enabled.
        /// </summary>
        public static readonly VersionStatus Enabled = new VersionStatus("Enabled");

        public VersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VersionStatus FindValue(string value)
        {
            return FindValue<VersionStatus>(value);
        }

        public static implicit operator VersionStatus(string value)
        {
            return FindValue(value);
        }
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
}