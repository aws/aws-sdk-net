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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.S3Control
{

    /// <summary>
    /// Constants used for properties of type BucketCannedACL.
    /// </summary>
    public class BucketCannedACL : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL AuthenticatedRead = new BucketCannedACL("authenticated-read");
        /// <summary>
        /// Constant Private for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL Private = new BucketCannedACL("private");
        /// <summary>
        /// Constant PublicRead for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL PublicRead = new BucketCannedACL("public-read");
        /// <summary>
        /// Constant PublicReadWrite for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL PublicReadWrite = new BucketCannedACL("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketCannedACL(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketCannedACL FindValue(string value)
        {
            return FindValue<BucketCannedACL>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketCannedACL(string value)
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
        /// Constant ApNortheast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApNortheast1 = new BucketLocationConstraint("ap-northeast-1");
        /// <summary>
        /// Constant ApSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSouth1 = new BucketLocationConstraint("ap-south-1");
        /// <summary>
        /// Constant ApSoutheast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast1 = new BucketLocationConstraint("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast2 = new BucketLocationConstraint("ap-southeast-2");
        /// <summary>
        /// Constant CnNorth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CnNorth1 = new BucketLocationConstraint("cn-north-1");
        /// <summary>
        /// Constant EU for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EU = new BucketLocationConstraint("EU");
        /// <summary>
        /// Constant EuCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuCentral1 = new BucketLocationConstraint("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuWest1 = new BucketLocationConstraint("eu-west-1");
        /// <summary>
        /// Constant SaEast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint SaEast1 = new BucketLocationConstraint("sa-east-1");
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
    /// Constants used for properties of type ExpirationStatus.
    /// </summary>
    public class ExpirationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ExpirationStatus
        /// </summary>
        public static readonly ExpirationStatus Disabled = new ExpirationStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ExpirationStatus
        /// </summary>
        public static readonly ExpirationStatus Enabled = new ExpirationStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpirationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpirationStatus FindValue(string value)
        {
            return FindValue<ExpirationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpirationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant CSV for Format
        /// </summary>
        public static readonly Format CSV = new Format("CSV");
        /// <summary>
        /// Constant Parquet for Format
        /// </summary>
        public static readonly Format Parquet = new Format("Parquet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobManifestFieldName.
    /// </summary>
    public class JobManifestFieldName : ConstantClass
    {

        /// <summary>
        /// Constant Bucket for JobManifestFieldName
        /// </summary>
        public static readonly JobManifestFieldName Bucket = new JobManifestFieldName("Bucket");
        /// <summary>
        /// Constant Ignore for JobManifestFieldName
        /// </summary>
        public static readonly JobManifestFieldName Ignore = new JobManifestFieldName("Ignore");
        /// <summary>
        /// Constant Key for JobManifestFieldName
        /// </summary>
        public static readonly JobManifestFieldName Key = new JobManifestFieldName("Key");
        /// <summary>
        /// Constant VersionId for JobManifestFieldName
        /// </summary>
        public static readonly JobManifestFieldName VersionId = new JobManifestFieldName("VersionId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobManifestFieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobManifestFieldName FindValue(string value)
        {
            return FindValue<JobManifestFieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobManifestFieldName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobManifestFormat.
    /// </summary>
    public class JobManifestFormat : ConstantClass
    {

        /// <summary>
        /// Constant S3BatchOperations_CSV_20180820 for JobManifestFormat
        /// </summary>
        public static readonly JobManifestFormat S3BatchOperations_CSV_20180820 = new JobManifestFormat("S3BatchOperations_CSV_20180820");
        /// <summary>
        /// Constant S3InventoryReport_CSV_20161130 for JobManifestFormat
        /// </summary>
        public static readonly JobManifestFormat S3InventoryReport_CSV_20161130 = new JobManifestFormat("S3InventoryReport_CSV_20161130");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobManifestFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobManifestFormat FindValue(string value)
        {
            return FindValue<JobManifestFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobManifestFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobReportFormat.
    /// </summary>
    public class JobReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant Report_CSV_20180820 for JobReportFormat
        /// </summary>
        public static readonly JobReportFormat Report_CSV_20180820 = new JobReportFormat("Report_CSV_20180820");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobReportFormat FindValue(string value)
        {
            return FindValue<JobReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobReportScope.
    /// </summary>
    public class JobReportScope : ConstantClass
    {

        /// <summary>
        /// Constant AllTasks for JobReportScope
        /// </summary>
        public static readonly JobReportScope AllTasks = new JobReportScope("AllTasks");
        /// <summary>
        /// Constant FailedTasksOnly for JobReportScope
        /// </summary>
        public static readonly JobReportScope FailedTasksOnly = new JobReportScope("FailedTasksOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobReportScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobReportScope FindValue(string value)
        {
            return FindValue<JobReportScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobReportScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for JobStatus
        /// </summary>
        public static readonly JobStatus Active = new JobStatus("Active");
        /// <summary>
        /// Constant Cancelled for JobStatus
        /// </summary>
        public static readonly JobStatus Cancelled = new JobStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for JobStatus
        /// </summary>
        public static readonly JobStatus Cancelling = new JobStatus("Cancelling");
        /// <summary>
        /// Constant Complete for JobStatus
        /// </summary>
        public static readonly JobStatus Complete = new JobStatus("Complete");
        /// <summary>
        /// Constant Completing for JobStatus
        /// </summary>
        public static readonly JobStatus Completing = new JobStatus("Completing");
        /// <summary>
        /// Constant Failed for JobStatus
        /// </summary>
        public static readonly JobStatus Failed = new JobStatus("Failed");
        /// <summary>
        /// Constant Failing for JobStatus
        /// </summary>
        public static readonly JobStatus Failing = new JobStatus("Failing");
        /// <summary>
        /// Constant New for JobStatus
        /// </summary>
        public static readonly JobStatus New = new JobStatus("New");
        /// <summary>
        /// Constant Paused for JobStatus
        /// </summary>
        public static readonly JobStatus Paused = new JobStatus("Paused");
        /// <summary>
        /// Constant Pausing for JobStatus
        /// </summary>
        public static readonly JobStatus Pausing = new JobStatus("Pausing");
        /// <summary>
        /// Constant Preparing for JobStatus
        /// </summary>
        public static readonly JobStatus Preparing = new JobStatus("Preparing");
        /// <summary>
        /// Constant Ready for JobStatus
        /// </summary>
        public static readonly JobStatus Ready = new JobStatus("Ready");
        /// <summary>
        /// Constant Suspended for JobStatus
        /// </summary>
        public static readonly JobStatus Suspended = new JobStatus("Suspended");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkOrigin.
    /// </summary>
    public class NetworkOrigin : ConstantClass
    {

        /// <summary>
        /// Constant Internet for NetworkOrigin
        /// </summary>
        public static readonly NetworkOrigin Internet = new NetworkOrigin("Internet");
        /// <summary>
        /// Constant VPC for NetworkOrigin
        /// </summary>
        public static readonly NetworkOrigin VPC = new NetworkOrigin("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkOrigin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkOrigin FindValue(string value)
        {
            return FindValue<NetworkOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkOrigin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationName.
    /// </summary>
    public class OperationName : ConstantClass
    {

        /// <summary>
        /// Constant LambdaInvoke for OperationName
        /// </summary>
        public static readonly OperationName LambdaInvoke = new OperationName("LambdaInvoke");
        /// <summary>
        /// Constant S3InitiateRestoreObject for OperationName
        /// </summary>
        public static readonly OperationName S3InitiateRestoreObject = new OperationName("S3InitiateRestoreObject");
        /// <summary>
        /// Constant S3PutObjectAcl for OperationName
        /// </summary>
        public static readonly OperationName S3PutObjectAcl = new OperationName("S3PutObjectAcl");
        /// <summary>
        /// Constant S3PutObjectCopy for OperationName
        /// </summary>
        public static readonly OperationName S3PutObjectCopy = new OperationName("S3PutObjectCopy");
        /// <summary>
        /// Constant S3PutObjectLegalHold for OperationName
        /// </summary>
        public static readonly OperationName S3PutObjectLegalHold = new OperationName("S3PutObjectLegalHold");
        /// <summary>
        /// Constant S3PutObjectRetention for OperationName
        /// </summary>
        public static readonly OperationName S3PutObjectRetention = new OperationName("S3PutObjectRetention");
        /// <summary>
        /// Constant S3PutObjectTagging for OperationName
        /// </summary>
        public static readonly OperationName S3PutObjectTagging = new OperationName("S3PutObjectTagging");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationName FindValue(string value)
        {
            return FindValue<OperationName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputSchemaVersion.
    /// </summary>
    public class OutputSchemaVersion : ConstantClass
    {

        /// <summary>
        /// Constant V_1 for OutputSchemaVersion
        /// </summary>
        public static readonly OutputSchemaVersion V_1 = new OutputSchemaVersion("V_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputSchemaVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputSchemaVersion FindValue(string value)
        {
            return FindValue<OutputSchemaVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputSchemaVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestedJobStatus.
    /// </summary>
    public class RequestedJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for RequestedJobStatus
        /// </summary>
        public static readonly RequestedJobStatus Cancelled = new RequestedJobStatus("Cancelled");
        /// <summary>
        /// Constant Ready for RequestedJobStatus
        /// </summary>
        public static readonly RequestedJobStatus Ready = new RequestedJobStatus("Ready");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestedJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestedJobStatus FindValue(string value)
        {
            return FindValue<RequestedJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestedJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3CannedAccessControlList.
    /// </summary>
    public class S3CannedAccessControlList : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for S3CannedAccessControlList
        /// </summary>
        public static readonly S3CannedAccessControlList AuthenticatedRead = new S3CannedAccessControlList("authenticated-read");
        /// <summary>
        /// Constant AwsExecRead for S3CannedAccessControlList
        /// </summary>
        public static readonly S3CannedAccessControlList AwsExecRead = new S3CannedAccessControlList("aws-exec-read");
        /// <summary>
        /// Constant BucketOwnerFullControl for S3CannedAccessControlList
        /// </summary>
        public static readonly S3CannedAccessControlList BucketOwnerFullControl = new S3CannedAccessControlList("bucket-owner-full-control");
        /// <summary>
        /// Constant BucketOwnerRead for S3CannedAccessControlList
        /// </summary>
        public static readonly S3CannedAccessControlList BucketOwnerRead = new S3CannedAccessControlList("bucket-owner-read");
        /// <summary>
        /// Constant Private for S3CannedAccessControlList
        /// </summary>
        public static readonly S3CannedAccessControlList Private = new S3CannedAccessControlList("private");
        /// <summary>
        /// Constant PublicRead for S3CannedAccessControlList
        /// </summary>
        public static readonly S3CannedAccessControlList PublicRead = new S3CannedAccessControlList("public-read");
        /// <summary>
        /// Constant PublicReadWrite for S3CannedAccessControlList
        /// </summary>
        public static readonly S3CannedAccessControlList PublicReadWrite = new S3CannedAccessControlList("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3CannedAccessControlList(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3CannedAccessControlList FindValue(string value)
        {
            return FindValue<S3CannedAccessControlList>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3CannedAccessControlList(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3GlacierJobTier.
    /// </summary>
    public class S3GlacierJobTier : ConstantClass
    {

        /// <summary>
        /// Constant BULK for S3GlacierJobTier
        /// </summary>
        public static readonly S3GlacierJobTier BULK = new S3GlacierJobTier("BULK");
        /// <summary>
        /// Constant STANDARD for S3GlacierJobTier
        /// </summary>
        public static readonly S3GlacierJobTier STANDARD = new S3GlacierJobTier("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3GlacierJobTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3GlacierJobTier FindValue(string value)
        {
            return FindValue<S3GlacierJobTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3GlacierJobTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3GranteeTypeIdentifier.
    /// </summary>
    public class S3GranteeTypeIdentifier : ConstantClass
    {

        /// <summary>
        /// Constant EmailAddress for S3GranteeTypeIdentifier
        /// </summary>
        public static readonly S3GranteeTypeIdentifier EmailAddress = new S3GranteeTypeIdentifier("emailAddress");
        /// <summary>
        /// Constant Id for S3GranteeTypeIdentifier
        /// </summary>
        public static readonly S3GranteeTypeIdentifier Id = new S3GranteeTypeIdentifier("id");
        /// <summary>
        /// Constant Uri for S3GranteeTypeIdentifier
        /// </summary>
        public static readonly S3GranteeTypeIdentifier Uri = new S3GranteeTypeIdentifier("uri");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3GranteeTypeIdentifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3GranteeTypeIdentifier FindValue(string value)
        {
            return FindValue<S3GranteeTypeIdentifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3GranteeTypeIdentifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3MetadataDirective.
    /// </summary>
    public class S3MetadataDirective : ConstantClass
    {

        /// <summary>
        /// Constant COPY for S3MetadataDirective
        /// </summary>
        public static readonly S3MetadataDirective COPY = new S3MetadataDirective("COPY");
        /// <summary>
        /// Constant REPLACE for S3MetadataDirective
        /// </summary>
        public static readonly S3MetadataDirective REPLACE = new S3MetadataDirective("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3MetadataDirective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3MetadataDirective FindValue(string value)
        {
            return FindValue<S3MetadataDirective>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3MetadataDirective(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ObjectLockLegalHoldStatus.
    /// </summary>
    public class S3ObjectLockLegalHoldStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFF for S3ObjectLockLegalHoldStatus
        /// </summary>
        public static readonly S3ObjectLockLegalHoldStatus OFF = new S3ObjectLockLegalHoldStatus("OFF");
        /// <summary>
        /// Constant ON for S3ObjectLockLegalHoldStatus
        /// </summary>
        public static readonly S3ObjectLockLegalHoldStatus ON = new S3ObjectLockLegalHoldStatus("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ObjectLockLegalHoldStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ObjectLockLegalHoldStatus FindValue(string value)
        {
            return FindValue<S3ObjectLockLegalHoldStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ObjectLockLegalHoldStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ObjectLockMode.
    /// </summary>
    public class S3ObjectLockMode : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANCE for S3ObjectLockMode
        /// </summary>
        public static readonly S3ObjectLockMode COMPLIANCE = new S3ObjectLockMode("COMPLIANCE");
        /// <summary>
        /// Constant GOVERNANCE for S3ObjectLockMode
        /// </summary>
        public static readonly S3ObjectLockMode GOVERNANCE = new S3ObjectLockMode("GOVERNANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ObjectLockMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ObjectLockMode FindValue(string value)
        {
            return FindValue<S3ObjectLockMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ObjectLockMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ObjectLockRetentionMode.
    /// </summary>
    public class S3ObjectLockRetentionMode : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANCE for S3ObjectLockRetentionMode
        /// </summary>
        public static readonly S3ObjectLockRetentionMode COMPLIANCE = new S3ObjectLockRetentionMode("COMPLIANCE");
        /// <summary>
        /// Constant GOVERNANCE for S3ObjectLockRetentionMode
        /// </summary>
        public static readonly S3ObjectLockRetentionMode GOVERNANCE = new S3ObjectLockRetentionMode("GOVERNANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ObjectLockRetentionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ObjectLockRetentionMode FindValue(string value)
        {
            return FindValue<S3ObjectLockRetentionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ObjectLockRetentionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3Permission.
    /// </summary>
    public class S3Permission : ConstantClass
    {

        /// <summary>
        /// Constant FULL_CONTROL for S3Permission
        /// </summary>
        public static readonly S3Permission FULL_CONTROL = new S3Permission("FULL_CONTROL");
        /// <summary>
        /// Constant READ for S3Permission
        /// </summary>
        public static readonly S3Permission READ = new S3Permission("READ");
        /// <summary>
        /// Constant READ_ACP for S3Permission
        /// </summary>
        public static readonly S3Permission READ_ACP = new S3Permission("READ_ACP");
        /// <summary>
        /// Constant WRITE for S3Permission
        /// </summary>
        public static readonly S3Permission WRITE = new S3Permission("WRITE");
        /// <summary>
        /// Constant WRITE_ACP for S3Permission
        /// </summary>
        public static readonly S3Permission WRITE_ACP = new S3Permission("WRITE_ACP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3Permission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3Permission FindValue(string value)
        {
            return FindValue<S3Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3Permission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3SSEAlgorithm.
    /// </summary>
    public class S3SSEAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for S3SSEAlgorithm
        /// </summary>
        public static readonly S3SSEAlgorithm AES256 = new S3SSEAlgorithm("AES256");
        /// <summary>
        /// Constant KMS for S3SSEAlgorithm
        /// </summary>
        public static readonly S3SSEAlgorithm KMS = new S3SSEAlgorithm("KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3SSEAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3SSEAlgorithm FindValue(string value)
        {
            return FindValue<S3SSEAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3SSEAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3StorageClass.
    /// </summary>
    public class S3StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass DEEP_ARCHIVE = new S3StorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant GLACIER for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass GLACIER = new S3StorageClass("GLACIER");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass INTELLIGENT_TIERING = new S3StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant ONEZONE_IA for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass ONEZONE_IA = new S3StorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant STANDARD for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass STANDARD = new S3StorageClass("STANDARD");
        /// <summary>
        /// Constant STANDARD_IA for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass STANDARD_IA = new S3StorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3StorageClass FindValue(string value)
        {
            return FindValue<S3StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitionStorageClass.
    /// </summary>
    public class TransitionStorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass DEEP_ARCHIVE = new TransitionStorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant GLACIER for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass GLACIER = new TransitionStorageClass("GLACIER");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass INTELLIGENT_TIERING = new TransitionStorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant ONEZONE_IA for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass ONEZONE_IA = new TransitionStorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant STANDARD_IA for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass STANDARD_IA = new TransitionStorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitionStorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitionStorageClass FindValue(string value)
        {
            return FindValue<TransitionStorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitionStorageClass(string value)
        {
            return FindValue(value);
        }
    }

}