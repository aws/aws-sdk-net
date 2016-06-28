/*******************************************************************************
 *  Copyright 2008-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Represents the accelerate status for a bucket.
    /// </summary>
    public sealed class BucketAccelerateStatus : ConstantClass
    {
        /// <summary>
        /// Bucket acceleration is enabled.
        /// </summary>
        public static readonly BucketAccelerateStatus Enabled = new BucketAccelerateStatus("Enabled");

        /// <summary>
        /// Bucket acceleration is suspended.
        /// </summary>
        public static readonly BucketAccelerateStatus Suspended = new BucketAccelerateStatus("Suspended");

        /// <summary>
        /// Construct instance of BucketAccelerateStatus. It is not intended for this constructor to be called. Instead users should call the FindValue.
        /// </summary>
        /// <param name="value"></param>
        public BucketAccelerateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BucketAccelerateStatus FindValue(string value)
        {
            return FindValue<BucketAccelerateStatus>(value);
        }

        /// <summary>
        /// Converts the string to an BucketAccelerateStatus
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator BucketAccelerateStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all possible CannedACLs that can be used
    /// for S3 Buckets or S3 Objects. For more information about CannedACLs, refer to
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/RESTAccessPolicy.html#RESTCannedAccessPolicies"/>.
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
        /// Owner gets FULL_CONTROL. Amazon EC2 gets READ access to GET an
        /// Amazon Machine Image (AMI) bundle from Amazon S3.
        /// </summary>
        public static readonly S3CannedACL AWSExecRead = new S3CannedACL("aws-exec-read");

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

        /// <summary>
        /// Construct instance of S3CannedACL. It is not intended for this constructor to be called. Instead users should call the FindValue.
        /// </summary>
        /// <param name="value"></param>
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


        /// <summary>
        /// Converts the string to an S3CannedACL
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator S3CannedACL(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all possible S3 Bucket region possibilities. For
    /// more information, refer to 
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/BucketConfiguration.html#LocationSelection"/>.
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
        /// Specifies that the S3 Bucket should use the EU-CENTRAL-1 locality.
        /// </summary>
        public static readonly S3Region EUC1 = new S3Region("eu-central-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-1 locality.
        /// </summary>
        public static readonly S3Region USW1 = new S3Region("us-west-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-2 locality.
        /// </summary>
        public static readonly S3Region USW2 = new S3Region("us-west-2");
        /// <summary>
        /// Specifies that the S3 Bucket should use US-GOV-WEST-1 locality.
        /// </summary>
        public static readonly S3Region GOVW1 = new S3Region("us-gov-west-1");
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
        /// Specifies that the S3 Bucket should use the AP-NORTHEAST-2 locality.
        /// </summary>
        public static readonly S3Region APN2 = new S3Region("ap-northeast-2");
        /// <summary>
        /// Specifies that the S3 Bucket should use the AP-SOUTH-1 locality.
        /// </summary>
        public static readonly S3Region APS3 = new S3Region("ap-south-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use the SA-EAST-1 locality.
        /// </summary>
        public static readonly S3Region SAE1 = new S3Region("sa-east-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use CN-NORTH-1 locality.
        /// </summary>
        public static readonly S3Region CN1 = new S3Region("cn-north-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use US-WEST-1 locality.
        /// </summary>
        [Obsolete("This constant is obsolete. Usags of this property should be migrated to the USW1 constant")]
        public static readonly S3Region SFO = new S3Region("us-west-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use CN-NORTH-1 locality.
        /// </summary>
        [Obsolete("This constant is obsolete. Usags of this property should be migrated to the CN1 constant")]
        public static readonly S3Region CN = new S3Region("cn-north-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use US-GOV-WEST-1 locality.
        /// </summary>
        [Obsolete("This constant is obsolete. Usags of this property should be migrated to the GOVW1 constant")]
        public static readonly S3Region GOV = new S3Region("us-gov-west-1");

        /// <summary>
        /// Construct instance of S3Region. It is not intended for this constructor to be called. Instead users should call the FindValue.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Converts the string to the S3Region class
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator S3Region(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all ACL permissions. For more information, refer to
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/S3_ACLs.html#S3_ACLs_Permissions"/>.
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

        /// <summary>
        /// Construct S3Permission.
        /// </summary>
        /// <param name="value"></param>
        public S3Permission(string value)
            : this(value, null) { }

        /// <summary>
        /// Construct instance of S3Permission. It is not intended for this constructor to be called. Instead users should call the FindValue.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="headerName"></param>
        public S3Permission(string value, string headerName)
            : base(value)
        {
            this.HeaderName = headerName;
        }

        /// <summary>
        /// Gets and sets the HeaderName property.
        /// </summary>
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

        /// <summary>
        /// Converts the string to an S3Permission
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// The STANDARD_IA storage is for infrequently accessed objects.
        /// This storage class is for objects that are long-lived and less frequently accessed,
        /// like backups and older data.
        /// </summary>
        public static readonly S3StorageClass StandardInfrequentAccess = new S3StorageClass("STANDARD_IA");

        /// <summary>
        /// Construct an instance of S3StorageClass.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Convert string to S3StorageClass.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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
    /// A list of all server-side encryption methods for customer provided encryption keys.
    /// </summary>
    public sealed class ServerSideEncryptionCustomerMethod : ConstantClass
    {
        /// <summary>
        /// No server side encryption to be used.
        /// </summary>
        public static readonly ServerSideEncryptionCustomerMethod None = new ServerSideEncryptionCustomerMethod("");

        /// <summary>
        /// Use AES 256 server side encryption.
        /// </summary>
        public static readonly ServerSideEncryptionCustomerMethod AES256 = new ServerSideEncryptionCustomerMethod("AES256");

        /// <summary>
        /// Constructs an instance of ServerSideEncryptionCustomerMethod.
        /// </summary>
        /// <param name="value"></param>
        public ServerSideEncryptionCustomerMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ServerSideEncryptionCustomerMethod FindValue(string value)
        {
            return FindValue<ServerSideEncryptionCustomerMethod>(value);
        }

        /// <summary>
        /// Converts string to ServerSideEncryptionCustomerMethod.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator ServerSideEncryptionCustomerMethod(string value)
        {
            return FindValue(value);
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

        /// <summary>
        /// Use AWS Key Management Service for server side encryption.
        /// </summary>
        public static readonly ServerSideEncryptionMethod AWSKMS = new ServerSideEncryptionMethod("aws:kms");

        /// <summary>
        /// Construct instance of ServerSideEncryptionMethod.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Convert string to ServerSideEncryptionCustomerMethod.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Construct an instance of GranteeType.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Convert a string to GranteeType.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Constructs an instance LifecycleRuleStatus.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Convert string to LifecycleRuleStatus.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Construct an instance of VersionStatus.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Convert string to VersionStatus.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator VersionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all encoding types.
    /// </summary>
    public sealed class EncodingType : ConstantClass
    {
        /// <summary>
        /// Url encoding.
        /// </summary>
        public static readonly EncodingType Url = new EncodingType("Url");

        /// <summary>
        /// Constructs intance of EncodingType
        /// </summary>
        /// <param name="value"></param>
        public EncodingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EncodingType FindValue(string value)
        {
            return FindValue<EncodingType>(value);
        }

        /// <summary>
        /// Converts string to EncodingType
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator EncodingType(string value)
        {
            return FindValue(value);
        }

    }

    /// <summary>
    /// A list of all event types that can configured with the bucket notification configuration.
    /// </summary>
    public sealed class EventType : ConstantClass
    {
        /// <summary>
        /// The event encapsulates all the object create events
        /// </summary>
        public static readonly EventType ObjectCreatedAll = new EventType("s3:ObjectCreated:*");

        /// <summary>
        /// Event for put operations
        /// </summary>
        public static readonly EventType ObjectCreatedPut = new EventType("s3:ObjectCreated:Put");

        /// <summary>
        /// Event for post operations
        /// </summary>
        public static readonly EventType ObjectCreatedPost = new EventType("s3:ObjectCreated:Post");

        /// <summary>
        /// Event for copy operations
        /// </summary>
        public static readonly EventType ObjectCreatedCopy = new EventType("s3:ObjectCreated:Copy");

        /// <summary>
        /// Event for completing a multi part upload
        /// </summary>
        public static readonly EventType ObjectCreatedCompleteMultipartUpload = new EventType("s3:ObjectCreated:CompleteMultipartUpload");

        /// <summary>
        /// This event encapsulates all the object removed events
        /// </summary>
        public static readonly EventType ObjectRemovedAll = new EventType("s3:ObjectRemoved:*");

        /// <summary>
        /// Event for object removed, delete operation.
        /// </summary>
        public static readonly EventType ObjectRemovedDelete = new EventType("s3:ObjectRemoved:Delete");

        /// <summary>
        /// Event for object removed, delete marker created operation.
        /// </summary>
        public static readonly EventType ObjectRemovedDeleteMarkerCreated = new EventType("s3:ObjectRemoved:DeleteMarkerCreated");
		
        /// <summary>
        /// Event for objects stored in reduced redundancy and S3 detects the object is lost
        /// </summary>
        public static readonly EventType ReducedRedundancyLostObject = new EventType("s3:ReducedRedundancyLostObject");

        /// <summary>
        /// Constructs instance of EventType.
        /// </summary>
        /// <param name="value"></param>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Convert string to EventType.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }

    }

    /// <summary>
    /// The status of the replication job associated with this source object.
    /// </summary>
    public sealed class ReplicationStatus : ConstantClass
    {
        /// <summary>
        ///  The object is pending replication.
        /// </summary>
        public static readonly ReplicationStatus Pending = new ReplicationStatus("PENDING");

        /// <summary>
        /// The object has been replicated.
        /// </summary>
        public static readonly ReplicationStatus Completed = new ReplicationStatus("COMPLETED");

        /// <summary>
        /// The object was created as a result of replication.
        /// </summary>
        public static readonly ReplicationStatus Replica = new ReplicationStatus("REPLICA");

        /// <summary>
        ///  The object replication has failed due to a customer-attributable reason, and the replication will not be attempted again.
        /// </summary>
        public static readonly ReplicationStatus Failed = new ReplicationStatus("FAILED");

        /// <summary>
        /// Construct instance of ReplicationStatus.
        /// </summary>
        /// <param name="value"></param>
        public ReplicationStatus(string value) 
            : base(value) 
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the ReplicationStatus.</param>
        /// <returns>The ReplicationStatus object for that string.</returns>
        public static ReplicationStatus FindValue(string value)
        {
            return FindValue<ReplicationStatus>(value);
        }

        /// <summary>
        /// Convert string to ReplicationStatus.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator ReplicationStatus(string value)
        {
            return FindValue<ReplicationStatus>(value);
        }

    }

    /// <summary>
    /// Whether a replication rule is applied or ignored.
    /// </summary>
    public sealed class ReplicationRuleStatus : ConstantClass
    {
        /// <summary>
        /// The rule will be applied.
        /// </summary>
        public static readonly ReplicationRuleStatus Enabled = new ReplicationRuleStatus("Enabled");

        /// <summary>
        /// The rule will be ignored.
        /// </summary>
        public static readonly ReplicationRuleStatus Disabled = new ReplicationRuleStatus("Disabled");
        
        /// <summary>
        /// Construct instance of ReplicationRuleStatus
        /// </summary>
        /// <param name="value"></param>
        public ReplicationRuleStatus(string value) 
            : base(value) 
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the ReplicationRuleStatus.</param>
        /// <returns>The ReplicationRuleStatus object for that string.</returns>
        public static ReplicationRuleStatus FindValue(string value)
        {
            return FindValue<ReplicationRuleStatus>(value);
        }

        /// <summary>
        /// Convert string to ReplicationRuleStatus.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator ReplicationRuleStatus(string value)
        {
            return FindValue<ReplicationRuleStatus>(value);
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