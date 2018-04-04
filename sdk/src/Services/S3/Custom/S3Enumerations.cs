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
    /// The file format used when exporting data to Amazon S3.
    /// </summary>
    public sealed class AnalyticsS3ExportFileFormat : ConstantClass
    {
        /// <summary>
        /// CSV file format.
        /// </summary>
        public static readonly AnalyticsS3ExportFileFormat CSV = new AnalyticsS3ExportFileFormat("CSV");

        /// <summary>
        /// Construct instance of AnalyticsS3ExportFileFormat. 
        /// </summary>
        /// <param name="value"></param>
        public AnalyticsS3ExportFileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AnalyticsS3ExportFileFormat FindValue(string value)
        {
            return FindValue<AnalyticsS3ExportFileFormat>(value);
        }

        /// <summary>
        /// Converts the string to an AnalyticsS3ExportFileFormat.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator AnalyticsS3ExportFileFormat(string value)
        {
            return FindValue<AnalyticsS3ExportFileFormat>(value);
        }

    }

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
    public sealed partial class S3Region : ConstantClass
    {
        /// <summary>
        /// Specifies that the S3 Bucket should use US locality.
        /// This is the default value.
        /// </summary>
        public static readonly S3Region US = new S3Region("");
        /// <summary>
        /// Specifies that the S3 Bucket should use US-EAST-2 locality.
        /// </summary>
        public static readonly S3Region USE2 = new S3Region("us-east-2");
        /// <summary>
        /// Specifies that the S3 Bucket should use EU locality which defaults to EU-WEST-1
        /// </summary>
        public static readonly S3Region EU = new S3Region("EU");
        /// <summary>
        /// Specifies that the S3 Bucket should use the EU-WEST-1 locality.
        /// </summary>
        public static readonly S3Region EUW1 = new S3Region("eu-west-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use the EU-WEST-2 locality.
        /// </summary>
        public static readonly S3Region EUW2 = new S3Region("eu-west-2");
        /// <summary>
        /// Specifies that the S3 Bucket should use the EU-WEST-3 locality.
        /// </summary>
        public static readonly S3Region EUW3 = new S3Region("eu-west-3");
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
        /// Specifies that the S3 Bucket should use CN-NORTHWEST-1 locality.
        /// </summary>
        public static readonly S3Region CNW1 = new S3Region("cn-northwest-1");
        /// <summary>
        /// Specifies that the S3 Bucket should use CA-CENTRAL-1 locality.
        /// </summary>
        public static readonly S3Region CAN1 = new S3Region("ca-central-1");

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
    /// S3 Storage Class Definitions
    /// </summary>
    public sealed class S3StorageClass : ConstantClass
    {
        /// <summary>
        /// The STANDARD storage class, which is the default
        /// storage class for S3.
        /// <para></para>
        /// Durability 99.999999999%; Availability 99.99% over a given year.
        /// </summary>
        public static readonly S3StorageClass Standard = new S3StorageClass("STANDARD");

        /// <summary>
        /// REDUCED_REDUNDANCY provides the same availability as standard, but at a lower durability.
        /// <para></para>
        /// Durability 99.99%; Availability 99.99% over a given year.
        /// </summary>
        public static readonly S3StorageClass ReducedRedundancy = new S3StorageClass("REDUCED_REDUNDANCY");

        /// <summary>
        /// The GLACIER storage is for object that are stored in Amazon Glacier.
        /// This storage class is for objects that are for archival purpose and 
        /// get operations are rare.
        /// <para></para>
        /// Durability 99.999999999%
        /// </summary>
        public static readonly S3StorageClass Glacier = new S3StorageClass("GLACIER");

        /// <summary>
        /// The STANDARD_IA storage is for infrequently accessed objects.
        /// This storage class is for objects that are long-lived and less frequently accessed,
        /// like backups and older data.
        /// <para></para>
        /// Durability 99.999999999%; Availability 99.9% over a given year.
        /// </summary>
        public static readonly S3StorageClass StandardInfrequentAccess = new S3StorageClass("STANDARD_IA");

        /// <summary>
        /// The ONEZONE_IA storage is for infrequently accessed objects. It is similiar to STANDARD_IA, but
        /// only stores object data within one Availablity Zone in a given region.
        /// <para></para>
        /// Durability 99.999999999%; Availability 99% over a given year.
        /// </summary>
        public static readonly S3StorageClass OneZoneInfrequentAccess = new S3StorageClass("ONEZONE_IA");

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

        /// <summary>
        /// Compares if the ConstantClass instances are equals.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(ConstantClass obj)
        {
            if(obj == null)
            {
                return false;
            }

            return this.Equals(obj.Value);
        }

        /// <summary>
        /// Compares if the ConstantClass instances are equals. This is ovewritten to handle the 
        /// discrepancy with S3 events coming from Lambda that don't have the prefix "s3:".
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected override bool Equals(string value)
        {
            if (value == null)
            {
                return false;
            }

            var thisValue = this.Value;
            if (!thisValue.StartsWith("s3:", StringComparison.OrdinalIgnoreCase))
                thisValue = "s3:" + thisValue;

            if (!value.StartsWith("s3:", StringComparison.OrdinalIgnoreCase))
                value = "s3:" + value;


            return StringComparer.OrdinalIgnoreCase.Equals(thisValue, value);
        }
    }

    /// <summary>
    /// A list of all Inventory Formats.
    /// </summary>
    public sealed class InventoryFormat : ConstantClass
    {
        /// <summary>
        ///  CSV inventory format
        /// </summary>
        public static readonly InventoryFormat CSV = new InventoryFormat("CSV");
        
        /// <summary>
        ///  CSV inventory format
        /// </summary>
        public static readonly InventoryFormat ORC = new InventoryFormat("ORC");

        /// <summary>
        /// Construct instance of InventoryFormat.
        /// </summary>
        /// <param name="value"></param>
        public InventoryFormat(string value) 
            : base(value) 
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the InventoryFormat.</param>
        /// <returns>The InventoryFormat object for that string.</returns>
        public static InventoryFormat FindValue(string value)
        {
            return FindValue<InventoryFormat>(value);
        }

        /// <summary>
        /// Convert string to InventoryFormat.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator InventoryFormat(string value)
        {
            return FindValue<InventoryFormat>(value);
        }

    }

    /// <summary>
    /// A list of inventory included object versions.
    /// </summary>
    public sealed class InventoryIncludedObjectVersions : ConstantClass
    {
        /// <summary>
        ///  All Inventory Included Object Versions
        /// </summary>
        public static readonly InventoryIncludedObjectVersions All = new InventoryIncludedObjectVersions("All");

        /// <summary>
        ///  Current Inventory Included Object Versions
        /// </summary>
        public static readonly InventoryIncludedObjectVersions Current = new InventoryIncludedObjectVersions("Current");

        /// <summary>
        /// Construct instance of InventoryIncludedObjectVersions.
        /// </summary>
        /// <param name="value"></param>
        public InventoryIncludedObjectVersions(string value) 
            : base(value) 
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the InventoryIncludedObjectVersions.</param>
        /// <returns>The InventoryIncludedObjectVersions object for that string.</returns>
        public static InventoryIncludedObjectVersions FindValue(string value)
        {
            return FindValue<InventoryIncludedObjectVersions>(value);
        }

        /// <summary>
        /// Convert string to InventoryIncludedObjectVersions.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator InventoryIncludedObjectVersions(string value)
        {
            return FindValue<InventoryIncludedObjectVersions>(value);
        }
    }

    /// <summary>
    /// A list of inventory frequencies.
    /// </summary>
    public sealed class InventoryFrequency : ConstantClass
    {
        /// <summary>
        ///  Daily Inventory Frequency
        /// </summary>
        public static readonly InventoryFrequency Daily = new InventoryFrequency("Daily");

        /// <summary>
        ///  Weekly Inventory Frequency
        /// </summary>
        public static readonly InventoryFrequency Weekly = new InventoryFrequency("Weekly");

        /// <summary>
        /// Construct instance of InventoryFrequency.
        /// </summary>
        /// <param name="value"></param>
        public InventoryFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the InventoryFrequency.</param>
        /// <returns>The InventoryFrequency object for that string.</returns>
        public static InventoryFrequency FindValue(string value)
        {
            return FindValue<InventoryFrequency>(value);
        }

        /// <summary>
        /// Convert string to InventoryFrequency.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator InventoryFrequency(string value)
        {
            return FindValue<InventoryFrequency>(value);
        }
    }

    /// <summary>
    /// A list of inventory optional fields.
    /// </summary>
    public sealed class InventoryOptionalField : ConstantClass
    {
        /// <summary>
        ///  InventoryOptionalField for Size
        /// </summary>
        public static readonly InventoryOptionalField Size = new InventoryOptionalField("Size");

        /// <summary>
        ///  InventoryOptionalField for LastModifiedDate
        /// </summary>
        public static readonly InventoryOptionalField LastModifiedDate = new InventoryOptionalField("LastModifiedDate");

        /// <summary>
        ///  InventoryOptionalField for StorageClass
        /// </summary>
        public static readonly InventoryOptionalField StorageClass = new InventoryOptionalField("StorageClass");

        /// <summary>
        ///  InventoryOptionalField for ETag
        /// </summary>
        public static readonly InventoryOptionalField ETag = new InventoryOptionalField("ETag");

        /// <summary>
        ///  InventoryOptionalField for IsMultipartUploaded
        /// </summary>
        public static readonly InventoryOptionalField IsMultipartUploaded = new InventoryOptionalField("IsMultipartUploaded");

        /// <summary>
        ///  InventoryOptionalField for ReplicationStatus
        /// </summary>
        public static readonly InventoryOptionalField ReplicationStatus = new InventoryOptionalField("ReplicationStatus");

        /// <summary>
        ///  InventoryOptionalField for EncryptionStatus
        /// </summary>
        public static readonly InventoryOptionalField EncryptionStatus = new InventoryOptionalField("EncryptionStatus");
        /// <summary>
        /// Construct instance of InventoryOptionalField.
        /// </summary>
        /// <param name="value"></param>
        public InventoryOptionalField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the InventoryOptionalField.</param>
        /// <returns>The InventoryIncludedObjectVersions object for that string.</returns>
        public static InventoryOptionalField FindValue(string value)
        {
            return FindValue<InventoryOptionalField>(value);
        }

        /// <summary>
        /// Convert string to InventoryOptionalField.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator InventoryOptionalField(string value)
        {
            return FindValue<InventoryOptionalField>(value);
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

    /// <summary>
    /// Specifies whether the object tag-set are copied from the source object or replaced with tag-set provided in the request.
    /// </summary>
    internal sealed class TaggingDirective : ConstantClass
    {
        /// <summary>
        /// The object tag-set is copied from the source object.
        /// </summary>
        public static readonly TaggingDirective COPY = new TaggingDirective("COPY");

        /// <summary>
        /// The object tag-set is replaced with tag-set provided in the request.
        /// </summary>
        public static readonly TaggingDirective REPLACE = new TaggingDirective("REPLACE");

        /// <summary>
        /// Construct instance of TaggingDirective
        /// </summary>
        public TaggingDirective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the TaggingDirective.</param>
        /// <returns>The TaggingDirective object for that string.</returns>
        public static TaggingDirective FindValue(string value)
        {
            return FindValue<TaggingDirective>(value);
        }

        /// <summary>
        /// Convert string to TaggingDirective.
        /// </summary>
        public static implicit operator TaggingDirective(string value)
        {
            return FindValue<TaggingDirective>(value);
        }
    }

    /// <summary>
    /// All enumerations type for retrieval tier for Glacier restore.
    /// </summary>
    public sealed class GlacierJobTier : ConstantClass
    {
        /// <summary>
        /// Standard Tier for Glacier restore.
        /// </summary>
        public static readonly GlacierJobTier Standard = new GlacierJobTier("Standard");

        /// <summary>
        /// Bulk Tier for Glacier restore.
        /// </summary>
        public static readonly GlacierJobTier Bulk = new GlacierJobTier("Bulk");

        /// <summary>
        /// Expedited Tier for Glacier restore.
        /// </summary>
        public static readonly GlacierJobTier Expedited = new GlacierJobTier("Expedited");

        /// <summary>
        /// Construct instance of RestoreObjectRequestGlacierJobTier
        /// </summary>
        /// <param name="value"></param>
        private GlacierJobTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the RestoreObjectRequestGlacierJobTier.</param>
        /// <returns>The RestoreObjectRequestGlacierJobTier object for that string.</returns>
        public static GlacierJobTier FindValue(string value)
        {
            return FindValue<GlacierJobTier>(value);
        }

        /// <summary>
        /// Convert string to RestoreObjectRequestGlacierJobTier.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator GlacierJobTier(string value)
        {
            return FindValue<GlacierJobTier>(value);
        }

    }

    /// <summary>
    /// The version of the output schema to use when exporting data.
    /// </summary>
    public sealed class StorageClassAnalysisSchemaVersion : ConstantClass
    {
        /// <summary>
        /// The schema output version V_1.
        /// </summary>
        public static readonly StorageClassAnalysisSchemaVersion V_1 = new StorageClassAnalysisSchemaVersion("V_1");

        /// <summary>
        /// Construct instance of StorageClassAnalysisSchemaVersion
        /// </summary>
        /// <param name="value"></param>
        public StorageClassAnalysisSchemaVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the StorageClassAnalysisSchemaVersion.</param>
        /// <returns>The StorageClassAnalysisSchemaVersion object for that string.</returns>
        public static StorageClassAnalysisSchemaVersion FindValue(string value)
        {
            return FindValue<StorageClassAnalysisSchemaVersion>(value);
        }

        /// <summary>
        /// Convert string to StorageClassAnalysisSchemaVersion.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator StorageClassAnalysisSchemaVersion(string value)
        {
            return FindValue<StorageClassAnalysisSchemaVersion>(value);
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

    /// <summary>
    /// Acknowledges that requester pays for the operation.
    /// </summary>
    public sealed class RequestPayer : ConstantClass
    {
        /// <summary>
        /// Requester pays for the operation.
        /// </summary>
        public static readonly RequestPayer Requester = new RequestPayer("requester");

        private RequestPayer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the RequestPayer instance for the string value.
        /// </summary>
        public static RequestPayer FindValue(string value)
        {
            return FindValue<RequestPayer>(value);
        }

        /// <summary>
        /// Converts string to RequestPayer instance
        /// </summary>
        public static implicit operator RequestPayer(string value)
        {
            return FindValue<RequestPayer>(value);
        }
    }

    /// <summary>
    /// The response from S3 that it confirms that requester pays.
    /// </summary>
    public sealed class RequestCharged : ConstantClass
    {
        /// <summary>
        /// S3 acknowledges that the requester pays.
        /// </summary>
        public static readonly RequestCharged Requester = new RequestCharged("requester");

        private RequestCharged(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the RequestCharged instance for the string value
        /// </summary>
        public static RequestCharged FindValue(string value)
        {
            return FindValue<RequestCharged>(value);
        }

        /// <summary>
        ///  converts the string to RequestCharged instance
        /// </summary>
        public static implicit operator RequestCharged(string value)
        {
            return FindValue<RequestCharged>(value);
        }
    }

    /// <summary>
    /// The override value for the owner of the replica object.
    /// </summary>
    public sealed class OwnerOverride : ConstantClass
    {
        /// <summary>
        /// Overrides destination bucket's owner.
        /// </summary>
        public static readonly OwnerOverride Destination = new OwnerOverride("Destination");
        
        public OwnerOverride(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the OwnerOverride instance for the string value
        /// </summary>
        public static OwnerOverride FindValue(string value)
        {
            return FindValue<OwnerOverride>(value);
        }

        /// <summary>
        ///  converts the string to OwnerOverride instance
        /// </summary>
        public static implicit operator OwnerOverride(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The replication for KMS encrypted S3 objects is disabled if status is not Enabled.
    /// </summary>
    public sealed class SseKmsEncryptedObjectsStatus : ConstantClass
    {
        /// <summary>
        /// The replication for KMS encrypted S3 objects is enabled.
        /// </summary>
        public static readonly SseKmsEncryptedObjectsStatus Enabled = new SseKmsEncryptedObjectsStatus("Enabled");
        /// <summary>
        /// The replication for KMS encrypted S3 objects is disabled.
        /// </summary>
        public static readonly SseKmsEncryptedObjectsStatus Disabled = new SseKmsEncryptedObjectsStatus("Disabled");
        
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        public SseKmsEncryptedObjectsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the SseKmsEncryptedObjectsStatus instance for the string value
        /// </summary>
        public static SseKmsEncryptedObjectsStatus FindValue(string value)
        {
            return FindValue<SseKmsEncryptedObjectsStatus>(value);
        }

        /// <summary>
        /// Converts the string to SseKmsEncryptedObjectsStatus instance
        /// </summary>
        public static implicit operator SseKmsEncryptedObjectsStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Specify how headers will be handled.
    /// </summary>
    public sealed class FileHeaderInfo : ConstantClass
    {
        /// <summary>
        /// Headers will be usable in SELECT clause. 
        /// </summary>
        public static readonly FileHeaderInfo Use = new FileHeaderInfo("USE");

        /// <summary>
        /// Headers will be skipped
        /// </summary>
        public static readonly FileHeaderInfo Ignore = new FileHeaderInfo("IGNORE");

        /// <summary>
        /// No header is present.
        /// </summary>
        public static readonly FileHeaderInfo None = new FileHeaderInfo("NONE");

        private FileHeaderInfo(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the FileHeaderInfo instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FileHeaderInfo FindValue(string value)
        {
            return FindValue<FileHeaderInfo>(value);
        }

        /// <summary>
        /// Converts the string to FileHeaderInfo instance
        /// </summary>
        public static implicit operator FileHeaderInfo(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Describes when fields in output should be surrounded with quotes.
    /// </summary>
    public sealed class QuoteFields : ConstantClass
    {
        /// <summary>
        /// Specifies that fields in output should always be surrounded in quotes.
        /// </summary>
        public static readonly QuoteFields Always = new QuoteFields("ALWAYS");

        /// <summary>
        /// Specifies that fields in output should be surrounded in quotes as necessary.
        /// </summary>
        public static readonly QuoteFields AsNeeded = new QuoteFields("ASNEEDED");

        private QuoteFields(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the QuoteFields instance for the string value
        /// </summary>
        /// <param name="value">string value that maps to QuoteFields enum</param>
        /// <returns>QuoteFields enum</returns>
        public static QuoteFields FindValue(string value)
        {
            return FindValue<QuoteFields>(value);
        }

        /// <summary>
        /// Converts the string to QuoteFields instance
        /// </summary>
        public static implicit operator QuoteFields(string value)
        {
            return FindValue(value);
        }
    }
    
    /// <summary>
    /// Type of the expression provided in the Expression member.
    /// </summary>
    public sealed class ExpressionType : ConstantClass
    {
        /// <summary>
        /// SQL expression
        /// </summary>
        public static readonly ExpressionType SQL = new ExpressionType("SQL");

        private ExpressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the ExpressionType instance for the string value
        /// </summary>
        /// <param name="value">string value that maps to ExpressionType enum</param>
        /// <returns>ExpressionType enum</returns>
        public static ExpressionType FindValue(string value)
        {
            return FindValue<ExpressionType>(value);
        }

        /// <summary>
        /// Converts the string to ExpressionType instance
        /// </summary>
        public static implicit operator ExpressionType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Indicates what type of job is being initiated.
    /// </summary>
    public sealed class RestoreRequestType : ConstantClass
    {
        public static readonly RestoreRequestType SELECT = new RestoreRequestType("SELECT");

        private RestoreRequestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the RestoreRequestType instance for the string value
        /// </summary>
        public static RestoreRequestType FindValue(string value)
        {
            return FindValue<RestoreRequestType>(value);
        }

        /// <summary>
        /// Converts the string to RestoreRequestType instance
        /// </summary>
        public static implicit operator RestoreRequestType(string value)
        {
            return FindValue(value);
        }
    }
}