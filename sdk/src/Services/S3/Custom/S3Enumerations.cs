/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Constants used for properties of type BucketType.
    /// </summary>
    public class BucketType : ConstantClass
    {

        /// <summary>
        /// Constant Directory for BucketType
        /// </summary>
        public static readonly BucketType Directory = new BucketType("Directory");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketType FindValue(string value)
        {
            return FindValue<BucketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketType(string value)
        {
            return FindValue(value);
        }
    }
    /// <summary>
    /// Constants used for properties of type DataRedundancy.
    /// </summary>
    public class DataRedundancy : ConstantClass
    {

        /// <summary>
        /// Constant SingleAvailabilityZone for DataRedundancy
        /// </summary>
        public static readonly DataRedundancy SingleAvailabilityZone = new DataRedundancy("SingleAvailabilityZone");

        /// <summary>
        /// Constant SingleLocalZone for DataRedundancy
        /// </summary>
        public static readonly DataRedundancy SingleLocalZone = new DataRedundancy("SingleLocalZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataRedundancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataRedundancy FindValue(string value)
        {
            return FindValue<DataRedundancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataRedundancy(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The status of the delete marker replication.
    /// </summary>
    public sealed class DeleteMarkerReplicationStatus : ConstantClass
    {
        /// <summary>
        /// Delete marker replication is enabled.
        /// </summary>
        public static readonly DeleteMarkerReplicationStatus Enabled = new DeleteMarkerReplicationStatus("Enabled");

        /// <summary>
        /// Delete marker replication is disabled.
        /// </summary>
        public static readonly DeleteMarkerReplicationStatus Disabled = new DeleteMarkerReplicationStatus("Disabled");

        /// <summary>
        /// Construct instance of DeleteMarkerReplicationStatus. It is not intended for this constructor to be called. Instead users should call the FindValue.
        /// </summary>
        /// <param name="value"></param>
        public DeleteMarkerReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DeleteMarkerReplicationStatus FindValue(string value)
        {
            return FindValue<DeleteMarkerReplicationStatus>(value);
        }

        /// <summary>
        /// Converts the string to a DeleteMarkerReplicationStatus
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator DeleteMarkerReplicationStatus(string value)
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
                return S3Region.USEast1;

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
    /// Constants used for properties of type LocationType.
    /// </summary>
    public class LocationType : ConstantClass
    {

        /// <summary>
        /// Constant AvailabilityZone for LocationType
        /// </summary>
        public static readonly LocationType AvailabilityZone = new LocationType("AvailabilityZone");

        /// <summary>
        /// Constant LocalZone for LocationType
        /// </summary>
        public static readonly LocationType LocalZone = new LocationType("LocalZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationType FindValue(string value)
        {
            return FindValue<LocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationType(string value)
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
    /// Constants used for properties of type BucketLocationConstraint.
    /// </summary>
    public class BucketLocationConstraint : ConstantClass
    {

        /// <summary>
        /// Constant AfSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint AfSouth1 = new BucketLocationConstraint("af-south-1");
        /// <summary>
        /// Constant ApEast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApEast1 = new BucketLocationConstraint("ap-east-1");
        /// <summary>
        /// Constant ApNortheast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApNortheast1 = new BucketLocationConstraint("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApNortheast2 = new BucketLocationConstraint("ap-northeast-2");
        /// <summary>
        /// Constant ApNortheast3 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApNortheast3 = new BucketLocationConstraint("ap-northeast-3");
        /// <summary>
        /// Constant ApSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSouth1 = new BucketLocationConstraint("ap-south-1");
        /// <summary>
        /// Constant ApSouth2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSouth2 = new BucketLocationConstraint("ap-south-2");
        /// <summary>
        /// Constant ApSoutheast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast1 = new BucketLocationConstraint("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast2 = new BucketLocationConstraint("ap-southeast-2");
        /// <summary>
        /// Constant ApSoutheast3 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast3 = new BucketLocationConstraint("ap-southeast-3");
        /// <summary>
        /// Constant ApSoutheast4 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast4 = new BucketLocationConstraint("ap-southeast-4");
        /// <summary>
        /// Constant ApSoutheast5 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast5 = new BucketLocationConstraint("ap-southeast-5");
        /// <summary>
        /// Constant CaCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CaCentral1 = new BucketLocationConstraint("ca-central-1");
        /// <summary>
        /// Constant CaWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CaWest1 = new BucketLocationConstraint("ca-west-1");
        /// <summary>
        /// Constant CnNorth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CnNorth1 = new BucketLocationConstraint("cn-north-1");
        /// <summary>
        /// Constant CnNorthwest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CnNorthwest1 = new BucketLocationConstraint("cn-northwest-1");
        /// <summary>
        /// Constant EU for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EU = new BucketLocationConstraint("EU");
        /// <summary>
        /// Constant EuCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuCentral1 = new BucketLocationConstraint("eu-central-1");
        /// <summary>
        /// Constant EuCentral2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuCentral2 = new BucketLocationConstraint("eu-central-2");
        /// <summary>
        /// Constant EuNorth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuNorth1 = new BucketLocationConstraint("eu-north-1");
        /// <summary>
        /// Constant EuSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuSouth1 = new BucketLocationConstraint("eu-south-1");
        /// <summary>
        /// Constant EuSouth2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuSouth2 = new BucketLocationConstraint("eu-south-2");
        /// <summary>
        /// Constant EuWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuWest1 = new BucketLocationConstraint("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuWest2 = new BucketLocationConstraint("eu-west-2");
        /// <summary>
        /// Constant EuWest3 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuWest3 = new BucketLocationConstraint("eu-west-3");
        /// <summary>
        /// Constant IlCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint IlCentral1 = new BucketLocationConstraint("il-central-1");
        /// <summary>
        /// Constant MeCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint MeCentral1 = new BucketLocationConstraint("me-central-1");
        /// <summary>
        /// Constant MeSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint MeSouth1 = new BucketLocationConstraint("me-south-1");
        /// <summary>
        /// Constant SaEast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint SaEast1 = new BucketLocationConstraint("sa-east-1");
        /// <summary>
        /// Constant UsEast2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsEast2 = new BucketLocationConstraint("us-east-2");
        /// <summary>
        /// Constant UsGovEast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsGovEast1 = new BucketLocationConstraint("us-gov-east-1");
        /// <summary>
        /// Constant UsGovWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsGovWest1 = new BucketLocationConstraint("us-gov-west-1");
        /// <summary>
        /// Constant UsWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsWest1 = new BucketLocationConstraint("us-west-1");
        /// <summary>
        /// Constant UsWest2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsWest2 = new BucketLocationConstraint("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketLocationConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketLocationConstraint FindValue(string value)
        {
            return FindValue<BucketLocationConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketLocationConstraint(string value)
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
        /// S3 Glacier Deep Archive provides secure, durable object storage class for long term data archival.
        /// It is the ideal storage class to make an archival, durable copy of data that rarely, if ever, needs to be accessed.
        /// It can be used as an offline backup for their most important data assets and to meet long-term retention needs.
        /// </summary>
        public static readonly S3StorageClass DeepArchive = new S3StorageClass("DEEP_ARCHIVE");

        /// <summary>
        /// The GLACIER storage is for object that are stored in Amazon Glacier.
        /// This storage class is for objects that are for archival purpose and 
        /// get operations are rare.
        /// <para></para>
        /// Durability 99.999999999%
        /// </summary>
        public static readonly S3StorageClass Glacier = new S3StorageClass("GLACIER");

        /// <summary>
        /// Constant GLACIER_IR for ObjectStorageClass
        /// </summary>
        public static readonly S3StorageClass GlacierInstantRetrieval= new S3StorageClass("GLACIER_IR");

        /// <summary>
        /// IntelligentTiering makes it easy to lower your overall cost of storage by automatically placing data in the storage
        /// class that best matches the access patterns for the storage. With IntelligentTiering, you don’t need to define
        /// and manage individual policies for lifecycle data management or write code to transition objects
        /// between storage classes. Instead, you can use IntelligentTiering to manage transitions between Standard and
        /// S-IA without writing any application code. IntelligentTiering also manages transitions automatically to
        /// Glacier for long term archive in addition to S3 storage classes.
        /// </summary>
        public static readonly S3StorageClass IntelligentTiering = new S3StorageClass("INTELLIGENT_TIERING");

        /// <summary>
        /// The ONEZONE_IA storage is for infrequently accessed objects. It is similiar to STANDARD_IA, but
        /// only stores object data within one Availablity Zone in a given region.
        /// <para></para>
        /// Durability 99.999999999%; Availability 99% over a given year.
        /// </summary>
        public static readonly S3StorageClass OneZoneInfrequentAccess = new S3StorageClass("ONEZONE_IA");

        /// <summary>
        /// The OUTPOSTS storage class for objects stored in a S3 Outpost
        /// </summary>
        public static readonly S3StorageClass Outposts = new S3StorageClass("OUTPOSTS");

        /// <summary>
        /// REDUCED_REDUNDANCY provides the same availability as standard, but at a lower durability.
        /// <para></para>
        /// Durability 99.99%; Availability 99.99% over a given year.
        /// </summary>
        public static readonly S3StorageClass ReducedRedundancy = new S3StorageClass("REDUCED_REDUNDANCY");


        /// <summary>
        /// The STANDARD storage class, which is the default
        /// storage class for S3.
        /// <para></para>
        /// Durability 99.999999999%; Availability 99.99% over a given year.
        /// </summary>
        public static readonly S3StorageClass Standard = new S3StorageClass("STANDARD");

        /// <summary>
        /// The STANDARD_IA storage is for infrequently accessed objects.
        /// This storage class is for objects that are long-lived and less frequently accessed,
        /// like backups and older data.
        /// <para></para>
        /// Durability 99.999999999%; Availability 99.9% over a given year.
        /// </summary>
        public static readonly S3StorageClass StandardInfrequentAccess = new S3StorageClass("STANDARD_IA");

        /// <summary>
        /// The SNOW storage is for objects stored in Amazon S3 compatible object storage
        /// for Snow family devices.
        /// </summary>
        public static readonly S3StorageClass Snow = new S3StorageClass("SNOW");
        /// <summary>
        /// The EXPRESS_ONEZONE storage class for faster access to S3
        /// </summary>
        public static readonly S3StorageClass ExpressOnezone = new S3StorageClass("EXPRESS_ONEZONE");
        /// <summary>
        /// The Amazon FSx for OpenZFS is a fully managed file storage service built on the OpenZFS file system.
        /// </summary>
        public static readonly S3StorageClass FSX_OPENZFS = new S3StorageClass("FSX_OPENZFS");
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
        /// Use AWS FSx for server side encryption.
        /// </summary>
        public static readonly ServerSideEncryptionMethod AWSFSX = new ServerSideEncryptionMethod("aws:fsx");

        /// <summary>
        /// Use AWS Key Management Service for server side encryption.
        /// </summary>
        public static readonly ServerSideEncryptionMethod AWSKMS = new ServerSideEncryptionMethod("aws:kms");

        /// <summary>
        /// Use AWS Key Management Service for server side double encryption 
        /// </summary>
        public static readonly ServerSideEncryptionMethod AWSKMSDSSE = new ServerSideEncryptionMethod("aws:kms:dsse");

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
    /// The bucket event for which to send notifications.
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
        /// Event for all object restore
        /// </summary>
        public static readonly EventType ObjectRestoreAll = new EventType("s3:ObjectRestore:*");

        /// <summary>
        /// Event for restore post operations.
        /// </summary>
        public static readonly EventType ObjectRestorePost = new EventType("s3:ObjectRestore:Post");

        /// <summary>
        /// Event for when object restore is completed.
        /// </summary>
        public static readonly EventType ObjectRestoreCompleted = new EventType("s3:ObjectRestore:Completed");

        /// <summary>
        /// Event for replication of all
        /// </summary>
        public static readonly EventType ReplicationAll = new EventType("s3:Replication:*");

        /// <summary>
        /// Event for operation failed replication
        /// </summary>
        public static readonly EventType ReplicationOperationFailedReplication = new EventType("s3:Replication:OperationFailedReplication");

        /// <summary>
        /// Evemt for replication operation not tracked
        /// </summary>
        public static readonly EventType ReplicationOperationNotTracked = new EventType("s3:Replication:OperationNotTracked");

        /// <summary>
        /// Event for replication operation missed threshold
        /// </summary>
        public static readonly EventType ReplicationOperationMissedThreshold = new EventType("s3:Replication:OperationMissedThreshold");

        /// <summary>
        /// Event for operation replicated after threshold
        /// </summary>
        public static readonly EventType ReplicationOperationReplicatedAfterThreshold = new EventType("s3:Replication:OperationReplicatedAfterThreshold");

        /// <summary>
        /// Event for Intelligent Tiering
        /// </summary>
        public static readonly EventType S3IntelligentTiering = new EventType("s3:IntelligentTiering");

        /// <summary>
        /// Event for all Lifecycle Expiration events
        /// </summary>
        public static readonly EventType S3LifecycleExpirationAll = new EventType("s3:LifecycleExpiration:*");

        /// <summary>
        /// Event for Lifecycle Expiration deletion
        /// </summary>
        public static readonly EventType S3LifecycleExpirationDelete = new EventType("s3:LifecycleExpiration:Delete");

        /// <summary>
        /// Event for Lifecycle Expiration Delete Marker creation
        /// </summary>
        public static readonly EventType S3LifecycleExpirationDeleteMarkerCreated = new EventType("s3:LifecycleExpiration:DeleteMarkerCreated");

        /// <summary>
        /// Event for Lifecycle Transition
        /// </summary>
        public static readonly EventType S3LifecycleTransition = new EventType("s3:LifecycleTransition");

        /// <summary>
        /// Event for Object Acl puts
        /// </summary>
        public static readonly EventType S3ObjectAclPut = new EventType("s3:ObjectAcl:Put");

        /// <summary>
        /// Event for Object Restore deletes 
        /// </summary>
        public static readonly EventType S3ObjectRestoreDelete = new EventType("s3:ObjectRestore:Delete");

        /// <summary>
        /// Event for all Object Tagging events
        /// </summary>
        public static readonly EventType S3ObjectTaggingAll = new EventType("s3:ObjectTagging:*");

        /// <summary>
        /// Event for Object Tagging deletes
        /// </summary>
        public static readonly EventType S3ObjectTaggingDelete = new EventType("s3:ObjectTagging:Delete");

        /// <summary>
        /// Event for Object Tagging puts
        /// </summary>
        public static readonly EventType S3ObjectTaggingPut = new EventType("s3:ObjectTagging:Put");

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
        ///  ORC inventory format
        /// </summary>
        public static readonly InventoryFormat ORC = new InventoryFormat("ORC");

        /// <summary>
        ///  Parquet inventory format
        /// </summary>
        public static readonly InventoryFormat Parquet = new InventoryFormat("Parquet");

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
        ///  InventoryOptionalField for ObjectLockRetainUntilDate
        /// </summary>
        public static readonly InventoryOptionalField ObjectLockRetainUntilDate = new InventoryOptionalField("ObjectLockRetainUntilDate");

        /// <summary>
        ///  InventoryOptionalField for ObjectLockMode
        /// </summary>
        public static readonly InventoryOptionalField ObjectLockMode = new InventoryOptionalField("ObjectLockMode");

        /// <summary>
        ///  InventoryOptionalField for ObjectLockLegalHoldStatus
        /// </summary>
        public static readonly InventoryOptionalField ObjectLockLegalHoldStatus = new InventoryOptionalField("ObjectLockLegalHoldStatus");

        /// <summary>
        /// InventoryOptionalField for IntelligentTieringAccessTier
        /// </summary>
        public static readonly InventoryOptionalField IntelligentTieringAccessTier = new InventoryOptionalField("IntelligentTieringAccessTier");

        /// <summary>
        /// Constant BucketKeyStatus for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField BucketKeyStatus = new InventoryOptionalField("BucketKeyStatus");

        /// <summary>
        /// Constant ChecksumAlgorithm for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ChecksumAlgorithm = new InventoryOptionalField("ChecksumAlgorithm");

        /// <summary>
        /// Constant ObjectAccessControlList for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ObjectAccessControlList = new InventoryOptionalField("ObjectAccessControlList");

        /// <summary>
        /// Constant ObjectOwner for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ObjectOwner = new InventoryOptionalField("ObjectOwner");

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
    public sealed class TaggingDirective : ConstantClass
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
        public GlacierJobTier(string value)
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

        /// <summary>
        /// Construct an instance of RequestPayer
        /// </summary>
        /// <param name="value"></param>
        public RequestPayer(string value)
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

        /// <summary>
        /// Construct an instance of RequestCharged
        /// </summary>
        /// <param name="value"></param>
        public RequestCharged(string value)
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

        /// <summary>
        /// Construct an instance of OwnerOverride
        /// </summary>
        /// <param name="value"></param>
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
    /// Constants used for properties of type SessionMode.
    /// </summary>
    public sealed class SessionMode : ConstantClass
    {

        /// <summary>
        /// Constant ReadOnly for SessionMode
        /// </summary>
        public static readonly SessionMode ReadOnly = new SessionMode("ReadOnly");
        /// <summary>
        /// Constant ReadWrite for SessionMode
        /// </summary>
        public static readonly SessionMode ReadWrite = new SessionMode("ReadWrite");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionMode FindValue(string value)
        {
            return FindValue<SessionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PartitionDateSource.
    /// </summary>
    public sealed class PartitionDateSource : ConstantClass
    {

        /// <summary>
        /// Constant DeliveryTime for PartitionDateSource
        /// </summary>
        public static readonly PartitionDateSource DeliveryTime = new PartitionDateSource("DeliveryTime");
        /// <summary>
        /// Constant EventTime for PartitionDateSource
        /// </summary>
        public static readonly PartitionDateSource EventTime = new PartitionDateSource("EventTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartitionDateSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartitionDateSource FindValue(string value)
        {
            return FindValue<PartitionDateSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartitionDateSource(string value)
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

        /// <summary>
        /// Construct instance of FileHeaderInfo
        /// </summary>
        /// <param name="value"></param>
        public FileHeaderInfo(string value)
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
    /// Specifies whether existing object replication is enabled.
    /// </summary>
    public sealed class ExistingObjectReplicationStatus : ConstantClass
    {
        /// <summary>
        /// Enable the replication of existing objects
        /// </summary>
        public static readonly ExistingObjectReplicationStatus Enabled = new ExistingObjectReplicationStatus("Enabled");

        /// <summary>
        /// Disable the replication of existing objects
        /// </summary>
        public static readonly ExistingObjectReplicationStatus Disabled = new ExistingObjectReplicationStatus("Disabled");

        /// <summary>
        /// Construct instance of ExistingObjectReplicationStatus
        /// </summary>
        /// <param name="value"></param>
        public ExistingObjectReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the ExistingObjectReplicationStatus instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ExistingObjectReplicationStatus FindValue(string value)
        {
            return FindValue<ExistingObjectReplicationStatus>(value);
        }

        /// <summary>
        /// Converts the string to ExistingObjectReplicationStatus instance
        /// </summary>
        public static implicit operator ExistingObjectReplicationStatus(string value)
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

        /// <summary>
        /// Constuct an instance of QuoteFields
        /// </summary>
        /// <param name="value"></param>
        public QuoteFields(string value)
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

        /// <summary>
        /// Construct instance of ExpressionType
        /// </summary>
        /// <param name="value"></param>
        public ExpressionType(string value)
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
        /// <summary>
        /// Constant for the value SELECT
        /// </summary>
        public static readonly RestoreRequestType SELECT = new RestoreRequestType("SELECT");

        /// <summary>
        /// Construct an instance of RestoreRequestType
        /// </summary>
        /// <param name="value"></param>
        public RestoreRequestType(string value)
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

    /// <summary>
    /// The type of JSON.
    /// </summary>
    public sealed class JsonType : ConstantClass
    {
        /// <summary>
        /// Constant for DOCUMENT
        /// </summary>
        public static readonly JsonType Document = new JsonType("DOCUMENT");
        /// <summary>
        /// Constant for LINES
        /// </summary>
        public static readonly JsonType Lines = new JsonType("LINES");

        /// <summary>
        /// Construct instance of JsonType
        /// </summary>
        /// <param name="value"></param>
        public JsonType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the JsonType instance for the string value
        /// </summary>
        public static JsonType FindValue(string value)
        {
            return FindValue<JsonType>(value);
        }

        /// <summary>
        /// Converts the string to JsonType instance
        /// </summary>
        public static implicit operator JsonType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Specifies object's compression format.
    /// </summary>
    public sealed class CompressionType : ConstantClass
    {
        /// <summary>
        /// Constant for NONE
        /// </summary>
        public static readonly CompressionType None = new CompressionType("NONE");
        /// <summary>
        /// Constant for GZIP
        /// </summary>
        public static readonly CompressionType Gzip = new CompressionType("GZIP");
        /// <summary>
        /// Constante for BZIP2
        /// </summary>
        public static readonly CompressionType Bzip2 = new CompressionType("BZIP2");

        /// <summary>
        /// Constructs an instance of CompressionType
        /// </summary>
        /// <param name="value"></param>
        public CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the CompressionType instance for the string value
        /// </summary>
        public static CompressionType FindValue(string value)
        {
            return FindValue<CompressionType>(value);
        }

        /// <summary>
        /// Converts the string to CompressionType instance
        /// </summary>
        public static implicit operator CompressionType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The type of ObjectLockEnabled
    /// </summary>
    public sealed class ObjectLockEnabled : ConstantClass
    {        
        /// <summary>
        /// Constant for Enabled
        /// </summary>
        public static readonly ObjectLockEnabled Enabled = new ObjectLockEnabled("Enabled");

        /// <summary>
        /// Construct an instance of ObjectLockEnabled
        /// </summary>
        /// <param name="value"></param>
        public ObjectLockEnabled(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the ObjectLockEnabled instance for the string value
        /// </summary>
        public static ObjectLockEnabled FindValue(string value)
        {
            return FindValue<ObjectLockEnabled>(value);
        }

        /// <summary>
        /// Converts the string to ObjectLockEnabled instance
        /// </summary>
        public static implicit operator ObjectLockEnabled(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The type of ObjectLockLegalHoldStatus
    /// </summary>
    public sealed class ObjectLockLegalHoldStatus : ConstantClass
    {
        /// <summary>
        /// Constant for ON
        /// </summary>
        public static readonly ObjectLockLegalHoldStatus On = new ObjectLockLegalHoldStatus("ON");

        /// <summary>
        /// Constant for OFF
        /// </summary>
        public static readonly ObjectLockLegalHoldStatus Off = new ObjectLockLegalHoldStatus("OFF");

        /// <summary>
        /// Construct an instance of ObjectLockLegalHoldStatus
        /// </summary>
        /// <param name="value"></param>
        public ObjectLockLegalHoldStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the ObjectLockLegalHoldStatus instance for the string value
        /// </summary>
        public static ObjectLockLegalHoldStatus FindValue(string value)
        {
            return FindValue<ObjectLockLegalHoldStatus>(value);
        }

        /// <summary>
        /// Converts the string to ObjectLockLegalHoldStatus instance
        /// </summary>
        public static implicit operator ObjectLockLegalHoldStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The type of ObjectLockRetentionMode
    /// </summary>
    public sealed class ObjectLockRetentionMode : ConstantClass
    {
        /// <summary>
        /// Constant for GOVERNANCE
        /// </summary>
        public static readonly ObjectLockRetentionMode Governance = new ObjectLockRetentionMode("GOVERNANCE");

        /// <summary>
        /// Constant for COMPLIANCE
        /// </summary>
        public static readonly ObjectLockRetentionMode Compliance = new ObjectLockRetentionMode("COMPLIANCE");

        /// <summary>
        /// Construct an instance of ObjectLockRetentionMode
        /// </summary>
        /// <param name="value"></param>
        public ObjectLockRetentionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the ObjectLockRetentionMode instance for the string value
        /// </summary>
        public static ObjectLockRetentionMode FindValue(string value)
        {
            return FindValue<ObjectLockRetentionMode>(value);
        }

        /// <summary>
        /// Converts the string to ObjectLockRetentionMode instance
        /// </summary>
        public static implicit operator ObjectLockRetentionMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The type of ObjectLockMode
    /// </summary>
    public sealed class ObjectLockMode : ConstantClass
    {
        /// <summary>
        /// Constant for GOVERNANCE
        /// </summary>
        public static readonly ObjectLockMode Governance = new ObjectLockMode("GOVERNANCE");

        /// <summary>
        /// Constant for COMPLIANCE
        /// </summary>
        public static readonly ObjectLockMode Compliance = new ObjectLockMode("COMPLIANCE");

        /// <summary>
        /// Construct an instance of ObjectLockMode
        /// </summary>
        /// <param name="value"></param>
        public ObjectLockMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the ObjectLockMode instance for the string value
        /// </summary>
        public static ObjectLockMode FindValue(string value)
        {
            return FindValue<ObjectLockMode>(value);
        }

        /// <summary>
        /// Converts the string to ObjectLockMode instance
        /// </summary>
        public static implicit operator ObjectLockMode(string value)
        {
            return FindValue(value);
        }
    }
    /// <summary>
    /// Constants used for properties of type OptionalObjectAttributes.
    /// </summary>
    public sealed class OptionalObjectAttributes : ConstantClass
    {

        /// <summary>
        /// Constant RestoreStatus for OptionalObjectAttributes
        /// </summary>
        public static readonly OptionalObjectAttributes RestoreStatus = new OptionalObjectAttributes("RestoreStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptionalObjectAttributes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptionalObjectAttributes FindValue(string value)
        {
            return FindValue<OptionalObjectAttributes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptionalObjectAttributes(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Specifies whether the replication time is enabled.
    /// </summary>
    public sealed class ReplicationTimeStatus : ConstantClass
    {
        /// <summary>
        /// Construct an instance of ReplicationTimeStatus
        /// </summary>
        /// <param name="value"></param>
        public ReplicationTimeStatus(string value)
            : base(value)
        {

        }

        /// <summary>
        /// Replication time is enabled.
        /// </summary>
        public static readonly ReplicationTimeStatus Enabled = new ReplicationTimeStatus("Enabled");

        /// <summary>
        /// Replication time is disabled.
        /// </summary>
        public static readonly ReplicationTimeStatus Disabled = new ReplicationTimeStatus("Disabled");

        /// <summary>
        /// Finds the ReplicationTimeStatus instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ReplicationTimeStatus FindValue(string value)
        {
            return FindValue<ReplicationTimeStatus>(value);
        }

        /// <summary>
        /// Converts the string to ReplicationTimeStatus instance
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ReplicationTimeStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Specifies whether the replication metrics are enabled.
    /// </summary>
    public sealed class MetricsStatus : ConstantClass
    {
        /// <summary>
        /// Construct an instance of MetricsStatus
        /// </summary>
        /// <param name="value"></param>
        public MetricsStatus(string value)
            : base(value)
        {

        }

        /// <summary>
        /// Replication metrics are enabled.
        /// </summary>
        public static readonly MetricsStatus Enabled = new MetricsStatus("Enabled");

        /// <summary>
        /// Replication metrics are disabled.
        /// </summary>
        public static readonly MetricsStatus Disabled = new MetricsStatus("Disabled");

        /// <summary>
        /// Finds the MetricsStatus instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MetricsStatus FindValue(string value)
        {
            return FindValue<MetricsStatus>(value);
        }

        /// <summary>
        /// Converts the string to MetricsStatus instance
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator MetricsStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Specifies who is assigned ownership of objects uploaded to a bucket
    /// </summary>
    public sealed class ObjectOwnership : ConstantClass
    {
        /// <summary>
        /// Constuct an instance of ObjectOwnership
        /// </summary>
        /// <param name="value"></param>
        public ObjectOwnership(string value)
            : base(value)
        {

        }

        /// <summary>
        /// Constant BucketOwnerEnforced for ObjectOwnership
        /// </summary>
        public static readonly ObjectOwnership BucketOwnerEnforced = new ObjectOwnership("BucketOwnerEnforced");
        
        /// <summary>
        /// Objects uploaded to the bucket change ownership to the bucket owner if the objects are uploaded with the bucket-owner-full-control canned ACL
        /// </summary>
        public static readonly ObjectOwnership BucketOwnerPreferred = new ObjectOwnership("BucketOwnerPreferred");

        /// <summary>
        /// The uploading account will own the object if the object is uploaded with the bucket-owner-full-control canned ACL
        /// </summary>
        public static readonly ObjectOwnership ObjectWriter = new ObjectOwnership("ObjectWriter");

        /// <summary>
        /// Finds the ObjectOwnership instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ObjectOwnership FindValue(string value)
        {
            return FindValue<ObjectOwnership>(value);
        }

        /// <summary>
        /// Converts the string to ObjectOwnership instance
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ObjectOwnership(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants for the IntelligentTieringStatus field.
    /// </summary>
    public sealed class IntelligentTieringStatus : ConstantClass
    {
        /// <summary>
        /// Construct an instance of IntelligentTieringStatus
        /// </summary>
        /// <param name="value"></param>
        public IntelligentTieringStatus(string value)
            : base(value)
        {

        }

        /// <summary>
        /// intelligent tiering is enabled.
        /// </summary>
        public static readonly IntelligentTieringStatus Enabled = new IntelligentTieringStatus("Enabled");

        /// <summary>
        /// intelligent tiering is disabled.
        /// </summary>
        public static readonly IntelligentTieringStatus Disabled = new IntelligentTieringStatus("Disabled");

        /// <summary>
        /// Finds the IntelligentTieringStatus instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IntelligentTieringStatus FindValue(string value)
        {
            return FindValue<IntelligentTieringStatus>(value);
        }

        /// <summary>
        /// Converts the string to IntelligentTieringStatus instance
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator IntelligentTieringStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constance for intelligent tiering access tier.
    /// </summary>
    public sealed class IntelligentTieringAccessTier : ConstantClass
    {
        /// <summary>
        /// Construct instance of IntelligentTieringAccessTier
        /// </summary>
        /// <param name="value"></param>
        public IntelligentTieringAccessTier(string value)
            : base(value)
        {

        }

        /// <summary>
        /// Access Tier is set to Archive Access.
        /// </summary>
        public static readonly IntelligentTieringAccessTier ARCHIVE_ACCESS = new IntelligentTieringAccessTier("ARCHIVE_ACCESS");

        /// <summary>
        /// Access Tier is set to Deep Archive Access.
        /// </summary>
        public static readonly IntelligentTieringAccessTier DEEP_ARCHIVE_ACCESS = new IntelligentTieringAccessTier("DEEP_ARCHIVE_ACCESS");

        /// <summary>
        /// Finds the IntelligentTieringAccessTier instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IntelligentTieringAccessTier FindValue(string value)
        {
            return FindValue<IntelligentTieringAccessTier>(value);
        }

        /// <summary>
        /// Converts the string to IntelligentTieringAccessTier instance
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator IntelligentTieringAccessTier(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The Archive status  associated with this source object.
    /// </summary>
    public sealed class ArchiveStatus : ConstantClass
    {
        /// <summary>
        ///  The Status is ARCHIVE_ACCESS.
        /// </summary>
        public static readonly ArchiveStatus ARCHIVE_ACCESS = new ArchiveStatus("ARCHIVE_ACCESS");

        /// <summary>
        /// The Status is DEEP_ARCHIVE_ACCESS.
        /// </summary>
        public static readonly ArchiveStatus DEEP_ARCHIVE_ACCESS = new ArchiveStatus("DEEP_ARCHIVE_ACCESS");

        /// <summary>
        /// Construct instance of ArchiveStatus.
        /// </summary>
        /// <param name="value"></param>
        public ArchiveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The string representation of the ArchiveStatus.</param>
        /// <returns>The ArchiveStatus object for that string.</returns>
        public static ArchiveStatus FindValue(string value)
        {
            return FindValue<ArchiveStatus>(value);
        }

        /// <summary>
        /// Convert string to ArchiveStatus.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator ArchiveStatus(string value)
        {
            return FindValue<ArchiveStatus>(value);
        }

    }

    /// <summary>
    /// Constants for the ReplicaModificationsStatus field.
    /// </summary>
    public sealed class ReplicaModificationsStatus : ConstantClass
    {
        /// <summary>
        /// Construct an instance of ReplicaModificationsStatus
        /// </summary>
        /// <param name="value"></param>
        public ReplicaModificationsStatus(string value)
            : base(value)
        {

        }

        /// <summary>
        /// Replica Modification is enabled.
        /// </summary>
        public static readonly ReplicaModificationsStatus Enabled = new ReplicaModificationsStatus("Enabled");

        /// <summary>
        /// Replica Modification is disabled.
        /// </summary>
        public static readonly ReplicaModificationsStatus Disabled = new ReplicaModificationsStatus("Disabled");

        /// <summary>
        /// Finds the ReplicaModificationsStatus instance for the string value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ReplicaModificationsStatus FindValue(string value)
        {
            return FindValue<ReplicaModificationsStatus>(value);
        }

        /// <summary>
        /// Converts the string to ReplicaModificationsStatus instance
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ReplicaModificationsStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ChecksumAlgorithm.
    /// </summary>
    public class ChecksumAlgorithm : ConstantClass
    {
        /// <summary>
        /// Constant CRC32 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm CRC32 = new ChecksumAlgorithm("CRC32");
        /// <summary>
        /// Constant CRC32C for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm CRC32C = new ChecksumAlgorithm("CRC32C");
        /// <summary>
        /// Constant CRC64NVME for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm CRC64NVME = new ChecksumAlgorithm("CRC64NVME");
        /// <summary>
        /// Constant SHA1 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm SHA1 = new ChecksumAlgorithm("SHA1");
        /// <summary>
        /// Constant SHA256 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm SHA256 = new ChecksumAlgorithm("SHA256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumAlgorithm FindValue(string value)
        {
            return FindValue<ChecksumAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumAlgorithm(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ChecksumMode.
    /// </summary>
    public class ChecksumMode : ConstantClass
    {
        /// <summary>
        /// Constant ENABLED for ChecksumMode
        /// </summary>
        public static readonly ChecksumMode ENABLED = new ChecksumMode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumMode FindValue(string value)
        {
            return FindValue<ChecksumMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChecksumType.
    /// </summary>
    public class ChecksumType : ConstantClass
    {
        /// <summary>
        /// Constant COMPOSITE for ChecksumType
        /// </summary>
        public static readonly ChecksumType COMPOSITE = new ChecksumType("COMPOSITE");

        /// <summary>
        /// Constant FULL_OBJECT for ChecksumType
        /// </summary>
        public static readonly ChecksumType FULL_OBJECT = new ChecksumType("FULL_OBJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumType FindValue(string value)
        {
            return FindValue<ChecksumType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ObjectAttributes.
    /// </summary>
    public class ObjectAttributes : ConstantClass
    {
        /// <summary>
        /// Constant Checksum for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes Checksum = new ObjectAttributes("Checksum");
        /// <summary>
        /// Constant ETag for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes ETag = new ObjectAttributes("ETag");
        /// <summary>
        /// Constant ObjectParts for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes ObjectParts = new ObjectAttributes("ObjectParts");
        /// <summary>
        /// Constant ObjectSize for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes ObjectSize = new ObjectAttributes("ObjectSize");
        /// <summary>
        /// Constant StorageClass for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes StorageClass = new ObjectAttributes("StorageClass");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectAttributes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectAttributes FindValue(string value)
        {
            return FindValue<ObjectAttributes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectAttributes(string value)
        {
            return FindValue(value);
        }
    }
    /// <summary>
    /// Constants used for properties of type TransitionDefaultMinimumObjectSize.
    /// </summary>
    public class TransitionDefaultMinimumObjectSize : ConstantClass
    {

        /// <summary>
        /// Constant All_storage_classes_128K for TransitionDefaultMinimumObjectSize
        /// </summary>
        public static readonly TransitionDefaultMinimumObjectSize AllStorageClasses128K = new TransitionDefaultMinimumObjectSize("all_storage_classes_128K");
        /// <summary>
        /// Constant Varies_by_storage_class for TransitionDefaultMinimumObjectSize
        /// </summary>
        public static readonly TransitionDefaultMinimumObjectSize VariesByStorageClass = new TransitionDefaultMinimumObjectSize("varies_by_storage_class");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitionDefaultMinimumObjectSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitionDefaultMinimumObjectSize FindValue(string value)
        {
            return FindValue<TransitionDefaultMinimumObjectSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitionDefaultMinimumObjectSize(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The configuration state for inventory tables.
    /// </summary>
    public sealed class InventoryConfigurationState : ConstantClass
    {
        /// <summary>
        /// Inventory configuration is enabled.
        /// </summary>
        public static readonly InventoryConfigurationState Enabled = new InventoryConfigurationState("ENABLED");

        /// <summary>
        /// Inventory configuration is disabled.
        /// </summary>
        public static readonly InventoryConfigurationState Disabled = new InventoryConfigurationState("DISABLED");

        /// <summary>
        /// Construct instance of InventoryConfigurationState.
        /// </summary>
        /// <param name="value"></param>
        public InventoryConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryConfigurationState FindValue(string value)
        {
            return FindValue<InventoryConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryConfigurationState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The configuration state for journal tables.
    /// </summary>
    public sealed class JournalConfigurationState : ConstantClass
    {
        /// <summary>
        /// Journal configuration is enabled.
        /// </summary>
        public static readonly JournalConfigurationState Enabled = new JournalConfigurationState("ENABLED");

        /// <summary>
        /// Journal configuration is disabled.
        /// </summary>
        public static readonly JournalConfigurationState Disabled = new JournalConfigurationState("DISABLED");

        /// <summary>
        /// Construct instance of JournalConfigurationState.
        /// </summary>
        /// <param name="value"></param>
        public JournalConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JournalConfigurationState FindValue(string value)
        {
            return FindValue<JournalConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JournalConfigurationState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The type of S3 Tables bucket.
    /// </summary>
    public sealed class S3TablesBucketType : ConstantClass
    {
        /// <summary>
        /// AWS-managed S3 Tables bucket.
        /// </summary>
        public static readonly S3TablesBucketType Aws = new S3TablesBucketType("aws");

        /// <summary>
        /// Customer-managed S3 Tables bucket.
        /// </summary>
        public static readonly S3TablesBucketType Customer = new S3TablesBucketType("customer");

        /// <summary>
        /// Construct instance of S3TablesBucketType.
        /// </summary>
        /// <param name="value"></param>
        public S3TablesBucketType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3TablesBucketType FindValue(string value)
        {
            return FindValue<S3TablesBucketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3TablesBucketType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The SSE algorithm for table encryption.
    /// </summary>
    public sealed class TableSseAlgorithm : ConstantClass
    {
        /// <summary>
        /// SSE-KMS encryption.
        /// </summary>
        public static readonly TableSseAlgorithm AwsKms = new TableSseAlgorithm("aws:kms");

        /// <summary>
        /// AES256 encryption.
        /// </summary>
        public static readonly TableSseAlgorithm AES256 = new TableSseAlgorithm("AES256");

        /// <summary>
        /// Construct instance of TableSseAlgorithm.
        /// </summary>
        /// <param name="value"></param>
        public TableSseAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableSseAlgorithm FindValue(string value)
        {
            return FindValue<TableSseAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableSseAlgorithm(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The expiration state for journal records.
    /// </summary>
    public sealed class ExpirationState : ConstantClass
    {
        /// <summary>
        /// Record expiration is enabled.
        /// </summary>
        public static readonly ExpirationState Enabled = new ExpirationState("ENABLED");

        /// <summary>
        /// Record expiration is disabled.
        /// </summary>
        public static readonly ExpirationState Disabled = new ExpirationState("DISABLED");

        /// <summary>
        /// Construct instance of ExpirationState.
        /// </summary>
        /// <param name="value"></param>
        public ExpirationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpirationState FindValue(string value)
        {
            return FindValue<ExpirationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpirationState(string value)
        {
            return FindValue(value);
        }
    }
}
