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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AccessAnalyzer
{

    /// <summary>
    /// Constants used for properties of type AccessCheckPolicyType.
    /// </summary>
    public class AccessCheckPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant IDENTITY_POLICY for AccessCheckPolicyType
        /// </summary>
        public static readonly AccessCheckPolicyType IDENTITY_POLICY = new AccessCheckPolicyType("IDENTITY_POLICY");
        /// <summary>
        /// Constant RESOURCE_POLICY for AccessCheckPolicyType
        /// </summary>
        public static readonly AccessCheckPolicyType RESOURCE_POLICY = new AccessCheckPolicyType("RESOURCE_POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessCheckPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessCheckPolicyType FindValue(string value)
        {
            return FindValue<AccessCheckPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessCheckPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessCheckResourceType.
    /// </summary>
    public class AccessCheckResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWSApiGatewayRestApi for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSApiGatewayRestApi = new AccessCheckResourceType("AWS::ApiGateway::RestApi");
        /// <summary>
        /// Constant AWSBackupBackupVault for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSBackupBackupVault = new AccessCheckResourceType("AWS::Backup::BackupVault");
        /// <summary>
        /// Constant AWSCloudTrailDashboard for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSCloudTrailDashboard = new AccessCheckResourceType("AWS::CloudTrail::Dashboard");
        /// <summary>
        /// Constant AWSCloudTrailEventDataStore for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSCloudTrailEventDataStore = new AccessCheckResourceType("AWS::CloudTrail::EventDataStore");
        /// <summary>
        /// Constant AWSCodeArtifactDomain for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSCodeArtifactDomain = new AccessCheckResourceType("AWS::CodeArtifact::Domain");
        /// <summary>
        /// Constant AWSDynamoDBStream for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSDynamoDBStream = new AccessCheckResourceType("AWS::DynamoDB::Stream");
        /// <summary>
        /// Constant AWSDynamoDBTable for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSDynamoDBTable = new AccessCheckResourceType("AWS::DynamoDB::Table");
        /// <summary>
        /// Constant AWSEFSFileSystem for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSEFSFileSystem = new AccessCheckResourceType("AWS::EFS::FileSystem");
        /// <summary>
        /// Constant AWSIAMAssumeRolePolicyDocument for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSIAMAssumeRolePolicyDocument = new AccessCheckResourceType("AWS::IAM::AssumeRolePolicyDocument");
        /// <summary>
        /// Constant AWSKinesisStream for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSKinesisStream = new AccessCheckResourceType("AWS::Kinesis::Stream");
        /// <summary>
        /// Constant AWSKinesisStreamConsumer for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSKinesisStreamConsumer = new AccessCheckResourceType("AWS::Kinesis::StreamConsumer");
        /// <summary>
        /// Constant AWSKMSKey for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSKMSKey = new AccessCheckResourceType("AWS::KMS::Key");
        /// <summary>
        /// Constant AWSLambdaFunction for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSLambdaFunction = new AccessCheckResourceType("AWS::Lambda::Function");
        /// <summary>
        /// Constant AWSOpenSearchServiceDomain for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSOpenSearchServiceDomain = new AccessCheckResourceType("AWS::OpenSearchService::Domain");
        /// <summary>
        /// Constant AWSS3AccessPoint for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3AccessPoint = new AccessCheckResourceType("AWS::S3::AccessPoint");
        /// <summary>
        /// Constant AWSS3Bucket for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3Bucket = new AccessCheckResourceType("AWS::S3::Bucket");
        /// <summary>
        /// Constant AWSS3ExpressAccessPoint for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3ExpressAccessPoint = new AccessCheckResourceType("AWS::S3Express::AccessPoint");
        /// <summary>
        /// Constant AWSS3ExpressDirectoryBucket for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3ExpressDirectoryBucket = new AccessCheckResourceType("AWS::S3Express::DirectoryBucket");
        /// <summary>
        /// Constant AWSS3Glacier for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3Glacier = new AccessCheckResourceType("AWS::S3::Glacier");
        /// <summary>
        /// Constant AWSS3OutpostsAccessPoint for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3OutpostsAccessPoint = new AccessCheckResourceType("AWS::S3Outposts::AccessPoint");
        /// <summary>
        /// Constant AWSS3OutpostsBucket for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3OutpostsBucket = new AccessCheckResourceType("AWS::S3Outposts::Bucket");
        /// <summary>
        /// Constant AWSS3TablesTable for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3TablesTable = new AccessCheckResourceType("AWS::S3Tables::Table");
        /// <summary>
        /// Constant AWSS3TablesTableBucket for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSS3TablesTableBucket = new AccessCheckResourceType("AWS::S3Tables::TableBucket");
        /// <summary>
        /// Constant AWSSecretsManagerSecret for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSSecretsManagerSecret = new AccessCheckResourceType("AWS::SecretsManager::Secret");
        /// <summary>
        /// Constant AWSSNSTopic for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSSNSTopic = new AccessCheckResourceType("AWS::SNS::Topic");
        /// <summary>
        /// Constant AWSSQSQueue for AccessCheckResourceType
        /// </summary>
        public static readonly AccessCheckResourceType AWSSQSQueue = new AccessCheckResourceType("AWS::SQS::Queue");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessCheckResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessCheckResourceType FindValue(string value)
        {
            return FindValue<AccessCheckResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessCheckResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessPreviewStatus.
    /// </summary>
    public class AccessPreviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for AccessPreviewStatus
        /// </summary>
        public static readonly AccessPreviewStatus COMPLETED = new AccessPreviewStatus("COMPLETED");
        /// <summary>
        /// Constant CREATING for AccessPreviewStatus
        /// </summary>
        public static readonly AccessPreviewStatus CREATING = new AccessPreviewStatus("CREATING");
        /// <summary>
        /// Constant FAILED for AccessPreviewStatus
        /// </summary>
        public static readonly AccessPreviewStatus FAILED = new AccessPreviewStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessPreviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessPreviewStatus FindValue(string value)
        {
            return FindValue<AccessPreviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessPreviewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessPreviewStatusReasonCode.
    /// </summary>
    public class AccessPreviewStatusReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_ERROR for AccessPreviewStatusReasonCode
        /// </summary>
        public static readonly AccessPreviewStatusReasonCode INTERNAL_ERROR = new AccessPreviewStatusReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_CONFIGURATION for AccessPreviewStatusReasonCode
        /// </summary>
        public static readonly AccessPreviewStatusReasonCode INVALID_CONFIGURATION = new AccessPreviewStatusReasonCode("INVALID_CONFIGURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessPreviewStatusReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessPreviewStatusReasonCode FindValue(string value)
        {
            return FindValue<AccessPreviewStatusReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessPreviewStatusReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AclPermission.
    /// </summary>
    public class AclPermission : ConstantClass
    {

        /// <summary>
        /// Constant FULL_CONTROL for AclPermission
        /// </summary>
        public static readonly AclPermission FULL_CONTROL = new AclPermission("FULL_CONTROL");
        /// <summary>
        /// Constant READ for AclPermission
        /// </summary>
        public static readonly AclPermission READ = new AclPermission("READ");
        /// <summary>
        /// Constant READ_ACP for AclPermission
        /// </summary>
        public static readonly AclPermission READ_ACP = new AclPermission("READ_ACP");
        /// <summary>
        /// Constant WRITE for AclPermission
        /// </summary>
        public static readonly AclPermission WRITE = new AclPermission("WRITE");
        /// <summary>
        /// Constant WRITE_ACP for AclPermission
        /// </summary>
        public static readonly AclPermission WRITE_ACP = new AclPermission("WRITE_ACP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AclPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AclPermission FindValue(string value)
        {
            return FindValue<AclPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AclPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyzerStatus.
    /// </summary>
    public class AnalyzerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AnalyzerStatus
        /// </summary>
        public static readonly AnalyzerStatus ACTIVE = new AnalyzerStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for AnalyzerStatus
        /// </summary>
        public static readonly AnalyzerStatus CREATING = new AnalyzerStatus("CREATING");
        /// <summary>
        /// Constant DISABLED for AnalyzerStatus
        /// </summary>
        public static readonly AnalyzerStatus DISABLED = new AnalyzerStatus("DISABLED");
        /// <summary>
        /// Constant FAILED for AnalyzerStatus
        /// </summary>
        public static readonly AnalyzerStatus FAILED = new AnalyzerStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyzerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyzerStatus FindValue(string value)
        {
            return FindValue<AnalyzerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyzerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckAccessNotGrantedResult.
    /// </summary>
    public class CheckAccessNotGrantedResult : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for CheckAccessNotGrantedResult
        /// </summary>
        public static readonly CheckAccessNotGrantedResult FAIL = new CheckAccessNotGrantedResult("FAIL");
        /// <summary>
        /// Constant PASS for CheckAccessNotGrantedResult
        /// </summary>
        public static readonly CheckAccessNotGrantedResult PASS = new CheckAccessNotGrantedResult("PASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckAccessNotGrantedResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckAccessNotGrantedResult FindValue(string value)
        {
            return FindValue<CheckAccessNotGrantedResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckAccessNotGrantedResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckNoNewAccessResult.
    /// </summary>
    public class CheckNoNewAccessResult : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for CheckNoNewAccessResult
        /// </summary>
        public static readonly CheckNoNewAccessResult FAIL = new CheckNoNewAccessResult("FAIL");
        /// <summary>
        /// Constant PASS for CheckNoNewAccessResult
        /// </summary>
        public static readonly CheckNoNewAccessResult PASS = new CheckNoNewAccessResult("PASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckNoNewAccessResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckNoNewAccessResult FindValue(string value)
        {
            return FindValue<CheckNoNewAccessResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckNoNewAccessResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CheckNoPublicAccessResult.
    /// </summary>
    public class CheckNoPublicAccessResult : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for CheckNoPublicAccessResult
        /// </summary>
        public static readonly CheckNoPublicAccessResult FAIL = new CheckNoPublicAccessResult("FAIL");
        /// <summary>
        /// Constant PASS for CheckNoPublicAccessResult
        /// </summary>
        public static readonly CheckNoPublicAccessResult PASS = new CheckNoPublicAccessResult("PASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CheckNoPublicAccessResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CheckNoPublicAccessResult FindValue(string value)
        {
            return FindValue<CheckNoPublicAccessResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CheckNoPublicAccessResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingChangeType.
    /// </summary>
    public class FindingChangeType : ConstantClass
    {

        /// <summary>
        /// Constant CHANGED for FindingChangeType
        /// </summary>
        public static readonly FindingChangeType CHANGED = new FindingChangeType("CHANGED");
        /// <summary>
        /// Constant NEW for FindingChangeType
        /// </summary>
        public static readonly FindingChangeType NEW = new FindingChangeType("NEW");
        /// <summary>
        /// Constant UNCHANGED for FindingChangeType
        /// </summary>
        public static readonly FindingChangeType UNCHANGED = new FindingChangeType("UNCHANGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingChangeType FindValue(string value)
        {
            return FindValue<FindingChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingSourceType.
    /// </summary>
    public class FindingSourceType : ConstantClass
    {

        /// <summary>
        /// Constant BUCKET_ACL for FindingSourceType
        /// </summary>
        public static readonly FindingSourceType BUCKET_ACL = new FindingSourceType("BUCKET_ACL");
        /// <summary>
        /// Constant POLICY for FindingSourceType
        /// </summary>
        public static readonly FindingSourceType POLICY = new FindingSourceType("POLICY");
        /// <summary>
        /// Constant S3_ACCESS_POINT for FindingSourceType
        /// </summary>
        public static readonly FindingSourceType S3_ACCESS_POINT = new FindingSourceType("S3_ACCESS_POINT");
        /// <summary>
        /// Constant S3_ACCESS_POINT_ACCOUNT for FindingSourceType
        /// </summary>
        public static readonly FindingSourceType S3_ACCESS_POINT_ACCOUNT = new FindingSourceType("S3_ACCESS_POINT_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingSourceType FindValue(string value)
        {
            return FindValue<FindingSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingStatus.
    /// </summary>
    public class FindingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FindingStatus
        /// </summary>
        public static readonly FindingStatus ACTIVE = new FindingStatus("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for FindingStatus
        /// </summary>
        public static readonly FindingStatus ARCHIVED = new FindingStatus("ARCHIVED");
        /// <summary>
        /// Constant RESOLVED for FindingStatus
        /// </summary>
        public static readonly FindingStatus RESOLVED = new FindingStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatus FindValue(string value)
        {
            return FindValue<FindingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingStatusUpdate.
    /// </summary>
    public class FindingStatusUpdate : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FindingStatusUpdate
        /// </summary>
        public static readonly FindingStatusUpdate ACTIVE = new FindingStatusUpdate("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for FindingStatusUpdate
        /// </summary>
        public static readonly FindingStatusUpdate ARCHIVED = new FindingStatusUpdate("ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatusUpdate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatusUpdate FindValue(string value)
        {
            return FindValue<FindingStatusUpdate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatusUpdate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingType.
    /// </summary>
    public class FindingType : ConstantClass
    {

        /// <summary>
        /// Constant ExternalAccess for FindingType
        /// </summary>
        public static readonly FindingType ExternalAccess = new FindingType("ExternalAccess");
        /// <summary>
        /// Constant InternalAccess for FindingType
        /// </summary>
        public static readonly FindingType InternalAccess = new FindingType("InternalAccess");
        /// <summary>
        /// Constant UnusedIAMRole for FindingType
        /// </summary>
        public static readonly FindingType UnusedIAMRole = new FindingType("UnusedIAMRole");
        /// <summary>
        /// Constant UnusedIAMUserAccessKey for FindingType
        /// </summary>
        public static readonly FindingType UnusedIAMUserAccessKey = new FindingType("UnusedIAMUserAccessKey");
        /// <summary>
        /// Constant UnusedIAMUserPassword for FindingType
        /// </summary>
        public static readonly FindingType UnusedIAMUserPassword = new FindingType("UnusedIAMUserPassword");
        /// <summary>
        /// Constant UnusedPermission for FindingType
        /// </summary>
        public static readonly FindingType UnusedPermission = new FindingType("UnusedPermission");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingType FindValue(string value)
        {
            return FindValue<FindingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InternalAccessType.
    /// </summary>
    public class InternalAccessType : ConstantClass
    {

        /// <summary>
        /// Constant INTRA_ACCOUNT for InternalAccessType
        /// </summary>
        public static readonly InternalAccessType INTRA_ACCOUNT = new InternalAccessType("INTRA_ACCOUNT");
        /// <summary>
        /// Constant INTRA_ORG for InternalAccessType
        /// </summary>
        public static readonly InternalAccessType INTRA_ORG = new InternalAccessType("INTRA_ORG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InternalAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InternalAccessType FindValue(string value)
        {
            return FindValue<InternalAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InternalAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobErrorCode.
    /// </summary>
    public class JobErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AUTHORIZATION_ERROR for JobErrorCode
        /// </summary>
        public static readonly JobErrorCode AUTHORIZATION_ERROR = new JobErrorCode("AUTHORIZATION_ERROR");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND_ERROR for JobErrorCode
        /// </summary>
        public static readonly JobErrorCode RESOURCE_NOT_FOUND_ERROR = new JobErrorCode("RESOURCE_NOT_FOUND_ERROR");
        /// <summary>
        /// Constant SERVICE_ERROR for JobErrorCode
        /// </summary>
        public static readonly JobErrorCode SERVICE_ERROR = new JobErrorCode("SERVICE_ERROR");
        /// <summary>
        /// Constant SERVICE_QUOTA_EXCEEDED_ERROR for JobErrorCode
        /// </summary>
        public static readonly JobErrorCode SERVICE_QUOTA_EXCEEDED_ERROR = new JobErrorCode("SERVICE_QUOTA_EXCEEDED_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobErrorCode FindValue(string value)
        {
            return FindValue<JobErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobErrorCode(string value)
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
        /// Constant CANCELED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELED = new JobStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for JobStatus
        /// </summary>
        public static readonly JobStatus SUCCEEDED = new JobStatus("SUCCEEDED");

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
    /// Constants used for properties of type KmsGrantOperation.
    /// </summary>
    public class KmsGrantOperation : ConstantClass
    {

        /// <summary>
        /// Constant CreateGrant for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation CreateGrant = new KmsGrantOperation("CreateGrant");
        /// <summary>
        /// Constant Decrypt for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation Decrypt = new KmsGrantOperation("Decrypt");
        /// <summary>
        /// Constant DescribeKey for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation DescribeKey = new KmsGrantOperation("DescribeKey");
        /// <summary>
        /// Constant Encrypt for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation Encrypt = new KmsGrantOperation("Encrypt");
        /// <summary>
        /// Constant GenerateDataKey for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation GenerateDataKey = new KmsGrantOperation("GenerateDataKey");
        /// <summary>
        /// Constant GenerateDataKeyPair for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation GenerateDataKeyPair = new KmsGrantOperation("GenerateDataKeyPair");
        /// <summary>
        /// Constant GenerateDataKeyPairWithoutPlaintext for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation GenerateDataKeyPairWithoutPlaintext = new KmsGrantOperation("GenerateDataKeyPairWithoutPlaintext");
        /// <summary>
        /// Constant GenerateDataKeyWithoutPlaintext for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation GenerateDataKeyWithoutPlaintext = new KmsGrantOperation("GenerateDataKeyWithoutPlaintext");
        /// <summary>
        /// Constant GetPublicKey for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation GetPublicKey = new KmsGrantOperation("GetPublicKey");
        /// <summary>
        /// Constant ReEncryptFrom for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation ReEncryptFrom = new KmsGrantOperation("ReEncryptFrom");
        /// <summary>
        /// Constant ReEncryptTo for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation ReEncryptTo = new KmsGrantOperation("ReEncryptTo");
        /// <summary>
        /// Constant RetireGrant for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation RetireGrant = new KmsGrantOperation("RetireGrant");
        /// <summary>
        /// Constant Sign for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation Sign = new KmsGrantOperation("Sign");
        /// <summary>
        /// Constant Verify for KmsGrantOperation
        /// </summary>
        public static readonly KmsGrantOperation Verify = new KmsGrantOperation("Verify");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KmsGrantOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KmsGrantOperation FindValue(string value)
        {
            return FindValue<KmsGrantOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KmsGrantOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Locale.
    /// </summary>
    public class Locale : ConstantClass
    {

        /// <summary>
        /// Constant DE for Locale
        /// </summary>
        public static readonly Locale DE = new Locale("DE");
        /// <summary>
        /// Constant EN for Locale
        /// </summary>
        public static readonly Locale EN = new Locale("EN");
        /// <summary>
        /// Constant ES for Locale
        /// </summary>
        public static readonly Locale ES = new Locale("ES");
        /// <summary>
        /// Constant FR for Locale
        /// </summary>
        public static readonly Locale FR = new Locale("FR");
        /// <summary>
        /// Constant IT for Locale
        /// </summary>
        public static readonly Locale IT = new Locale("IT");
        /// <summary>
        /// Constant JA for Locale
        /// </summary>
        public static readonly Locale JA = new Locale("JA");
        /// <summary>
        /// Constant KO for Locale
        /// </summary>
        public static readonly Locale KO = new Locale("KO");
        /// <summary>
        /// Constant PT_BR for Locale
        /// </summary>
        public static readonly Locale PT_BR = new Locale("PT_BR");
        /// <summary>
        /// Constant ZH_CN for Locale
        /// </summary>
        public static readonly Locale ZH_CN = new Locale("ZH_CN");
        /// <summary>
        /// Constant ZH_TW for Locale
        /// </summary>
        public static readonly Locale ZH_TW = new Locale("ZH_TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Locale(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Locale FindValue(string value)
        {
            return FindValue<Locale>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Locale(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderBy.
    /// </summary>
    public class OrderBy : ConstantClass
    {

        /// <summary>
        /// Constant ASC for OrderBy
        /// </summary>
        public static readonly OrderBy ASC = new OrderBy("ASC");
        /// <summary>
        /// Constant DESC for OrderBy
        /// </summary>
        public static readonly OrderBy DESC = new OrderBy("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderBy FindValue(string value)
        {
            return FindValue<OrderBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant IDENTITY_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType IDENTITY_POLICY = new PolicyType("IDENTITY_POLICY");
        /// <summary>
        /// Constant RESOURCE_CONTROL_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType RESOURCE_CONTROL_POLICY = new PolicyType("RESOURCE_CONTROL_POLICY");
        /// <summary>
        /// Constant RESOURCE_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType RESOURCE_POLICY = new PolicyType("RESOURCE_POLICY");
        /// <summary>
        /// Constant SERVICE_CONTROL_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType SERVICE_CONTROL_POLICY = new PolicyType("SERVICE_CONTROL_POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant IAM_ROLE for PrincipalType
        /// </summary>
        public static readonly PrincipalType IAM_ROLE = new PrincipalType("IAM_ROLE");
        /// <summary>
        /// Constant IAM_USER for PrincipalType
        /// </summary>
        public static readonly PrincipalType IAM_USER = new PrincipalType("IAM_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReasonCode.
    /// </summary>
    public class ReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SERVICE_ACCESS_DISABLED for ReasonCode
        /// </summary>
        public static readonly ReasonCode AWS_SERVICE_ACCESS_DISABLED = new ReasonCode("AWS_SERVICE_ACCESS_DISABLED");
        /// <summary>
        /// Constant DELEGATED_ADMINISTRATOR_DEREGISTERED for ReasonCode
        /// </summary>
        public static readonly ReasonCode DELEGATED_ADMINISTRATOR_DEREGISTERED = new ReasonCode("DELEGATED_ADMINISTRATOR_DEREGISTERED");
        /// <summary>
        /// Constant ORGANIZATION_DELETED for ReasonCode
        /// </summary>
        public static readonly ReasonCode ORGANIZATION_DELETED = new ReasonCode("ORGANIZATION_DELETED");
        /// <summary>
        /// Constant SERVICE_LINKED_ROLE_CREATION_FAILED for ReasonCode
        /// </summary>
        public static readonly ReasonCode SERVICE_LINKED_ROLE_CREATION_FAILED = new ReasonCode("SERVICE_LINKED_ROLE_CREATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReasonCode FindValue(string value)
        {
            return FindValue<ReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationType.
    /// </summary>
    public class RecommendationType : ConstantClass
    {

        /// <summary>
        /// Constant UnusedPermissionRecommendation for RecommendationType
        /// </summary>
        public static readonly RecommendationType UnusedPermissionRecommendation = new RecommendationType("UnusedPermissionRecommendation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationType FindValue(string value)
        {
            return FindValue<RecommendationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendedRemediationAction.
    /// </summary>
    public class RecommendedRemediationAction : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_POLICY for RecommendedRemediationAction
        /// </summary>
        public static readonly RecommendedRemediationAction CREATE_POLICY = new RecommendedRemediationAction("CREATE_POLICY");
        /// <summary>
        /// Constant DETACH_POLICY for RecommendedRemediationAction
        /// </summary>
        public static readonly RecommendedRemediationAction DETACH_POLICY = new RecommendedRemediationAction("DETACH_POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendedRemediationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendedRemediationAction FindValue(string value)
        {
            return FindValue<RecommendedRemediationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendedRemediationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceControlPolicyRestriction.
    /// </summary>
    public class ResourceControlPolicyRestriction : ConstantClass
    {

        /// <summary>
        /// Constant APPLICABLE for ResourceControlPolicyRestriction
        /// </summary>
        public static readonly ResourceControlPolicyRestriction APPLICABLE = new ResourceControlPolicyRestriction("APPLICABLE");
        /// <summary>
        /// Constant APPLIED for ResourceControlPolicyRestriction
        /// </summary>
        public static readonly ResourceControlPolicyRestriction APPLIED = new ResourceControlPolicyRestriction("APPLIED");
        /// <summary>
        /// Constant FAILED_TO_EVALUATE_RCP for ResourceControlPolicyRestriction
        /// </summary>
        public static readonly ResourceControlPolicyRestriction FAILED_TO_EVALUATE_RCP = new ResourceControlPolicyRestriction("FAILED_TO_EVALUATE_RCP");
        /// <summary>
        /// Constant NOT_APPLICABLE for ResourceControlPolicyRestriction
        /// </summary>
        public static readonly ResourceControlPolicyRestriction NOT_APPLICABLE = new ResourceControlPolicyRestriction("NOT_APPLICABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceControlPolicyRestriction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceControlPolicyRestriction FindValue(string value)
        {
            return FindValue<ResourceControlPolicyRestriction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceControlPolicyRestriction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWSDynamoDBStream for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDynamoDBStream = new ResourceType("AWS::DynamoDB::Stream");
        /// <summary>
        /// Constant AWSDynamoDBTable for ResourceType
        /// </summary>
        public static readonly ResourceType AWSDynamoDBTable = new ResourceType("AWS::DynamoDB::Table");
        /// <summary>
        /// Constant AWSEC2Snapshot for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Snapshot = new ResourceType("AWS::EC2::Snapshot");
        /// <summary>
        /// Constant AWSECRRepository for ResourceType
        /// </summary>
        public static readonly ResourceType AWSECRRepository = new ResourceType("AWS::ECR::Repository");
        /// <summary>
        /// Constant AWSEFSFileSystem for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEFSFileSystem = new ResourceType("AWS::EFS::FileSystem");
        /// <summary>
        /// Constant AWSIAMRole for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIAMRole = new ResourceType("AWS::IAM::Role");
        /// <summary>
        /// Constant AWSIAMUser for ResourceType
        /// </summary>
        public static readonly ResourceType AWSIAMUser = new ResourceType("AWS::IAM::User");
        /// <summary>
        /// Constant AWSKMSKey for ResourceType
        /// </summary>
        public static readonly ResourceType AWSKMSKey = new ResourceType("AWS::KMS::Key");
        /// <summary>
        /// Constant AWSLambdaFunction for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLambdaFunction = new ResourceType("AWS::Lambda::Function");
        /// <summary>
        /// Constant AWSLambdaLayerVersion for ResourceType
        /// </summary>
        public static readonly ResourceType AWSLambdaLayerVersion = new ResourceType("AWS::Lambda::LayerVersion");
        /// <summary>
        /// Constant AWSRDSDBClusterSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBClusterSnapshot = new ResourceType("AWS::RDS::DBClusterSnapshot");
        /// <summary>
        /// Constant AWSRDSDBSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType AWSRDSDBSnapshot = new ResourceType("AWS::RDS::DBSnapshot");
        /// <summary>
        /// Constant AWSS3Bucket for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3Bucket = new ResourceType("AWS::S3::Bucket");
        /// <summary>
        /// Constant AWSS3ExpressDirectoryBucket for ResourceType
        /// </summary>
        public static readonly ResourceType AWSS3ExpressDirectoryBucket = new ResourceType("AWS::S3Express::DirectoryBucket");
        /// <summary>
        /// Constant AWSSecretsManagerSecret for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSecretsManagerSecret = new ResourceType("AWS::SecretsManager::Secret");
        /// <summary>
        /// Constant AWSSNSTopic for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSNSTopic = new ResourceType("AWS::SNS::Topic");
        /// <summary>
        /// Constant AWSSQSQueue for ResourceType
        /// </summary>
        public static readonly ResourceType AWSSQSQueue = new ResourceType("AWS::SQS::Queue");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceControlPolicyRestriction.
    /// </summary>
    public class ServiceControlPolicyRestriction : ConstantClass
    {

        /// <summary>
        /// Constant APPLICABLE for ServiceControlPolicyRestriction
        /// </summary>
        public static readonly ServiceControlPolicyRestriction APPLICABLE = new ServiceControlPolicyRestriction("APPLICABLE");
        /// <summary>
        /// Constant APPLIED for ServiceControlPolicyRestriction
        /// </summary>
        public static readonly ServiceControlPolicyRestriction APPLIED = new ServiceControlPolicyRestriction("APPLIED");
        /// <summary>
        /// Constant FAILED_TO_EVALUATE_SCP for ServiceControlPolicyRestriction
        /// </summary>
        public static readonly ServiceControlPolicyRestriction FAILED_TO_EVALUATE_SCP = new ServiceControlPolicyRestriction("FAILED_TO_EVALUATE_SCP");
        /// <summary>
        /// Constant NOT_APPLICABLE for ServiceControlPolicyRestriction
        /// </summary>
        public static readonly ServiceControlPolicyRestriction NOT_APPLICABLE = new ServiceControlPolicyRestriction("NOT_APPLICABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceControlPolicyRestriction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceControlPolicyRestriction FindValue(string value)
        {
            return FindValue<ServiceControlPolicyRestriction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceControlPolicyRestriction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for Status
        /// </summary>
        public static readonly Status IN_PROGRESS = new Status("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for Status
        /// </summary>
        public static readonly Status SUCCEEDED = new Status("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for Type
        /// </summary>
        public static readonly Type ACCOUNT = new Type("ACCOUNT");
        /// <summary>
        /// Constant ACCOUNT_INTERNAL_ACCESS for Type
        /// </summary>
        public static readonly Type ACCOUNT_INTERNAL_ACCESS = new Type("ACCOUNT_INTERNAL_ACCESS");
        /// <summary>
        /// Constant ACCOUNT_UNUSED_ACCESS for Type
        /// </summary>
        public static readonly Type ACCOUNT_UNUSED_ACCESS = new Type("ACCOUNT_UNUSED_ACCESS");
        /// <summary>
        /// Constant ORGANIZATION for Type
        /// </summary>
        public static readonly Type ORGANIZATION = new Type("ORGANIZATION");
        /// <summary>
        /// Constant ORGANIZATION_INTERNAL_ACCESS for Type
        /// </summary>
        public static readonly Type ORGANIZATION_INTERNAL_ACCESS = new Type("ORGANIZATION_INTERNAL_ACCESS");
        /// <summary>
        /// Constant ORGANIZATION_UNUSED_ACCESS for Type
        /// </summary>
        public static readonly Type ORGANIZATION_UNUSED_ACCESS = new Type("ORGANIZATION_UNUSED_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidatePolicyFindingType.
    /// </summary>
    public class ValidatePolicyFindingType : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for ValidatePolicyFindingType
        /// </summary>
        public static readonly ValidatePolicyFindingType ERROR = new ValidatePolicyFindingType("ERROR");
        /// <summary>
        /// Constant SECURITY_WARNING for ValidatePolicyFindingType
        /// </summary>
        public static readonly ValidatePolicyFindingType SECURITY_WARNING = new ValidatePolicyFindingType("SECURITY_WARNING");
        /// <summary>
        /// Constant SUGGESTION for ValidatePolicyFindingType
        /// </summary>
        public static readonly ValidatePolicyFindingType SUGGESTION = new ValidatePolicyFindingType("SUGGESTION");
        /// <summary>
        /// Constant WARNING for ValidatePolicyFindingType
        /// </summary>
        public static readonly ValidatePolicyFindingType WARNING = new ValidatePolicyFindingType("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidatePolicyFindingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidatePolicyFindingType FindValue(string value)
        {
            return FindValue<ValidatePolicyFindingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidatePolicyFindingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidatePolicyResourceType.
    /// </summary>
    public class ValidatePolicyResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWSDynamoDBTable for ValidatePolicyResourceType
        /// </summary>
        public static readonly ValidatePolicyResourceType AWSDynamoDBTable = new ValidatePolicyResourceType("AWS::DynamoDB::Table");
        /// <summary>
        /// Constant AWSIAMAssumeRolePolicyDocument for ValidatePolicyResourceType
        /// </summary>
        public static readonly ValidatePolicyResourceType AWSIAMAssumeRolePolicyDocument = new ValidatePolicyResourceType("AWS::IAM::AssumeRolePolicyDocument");
        /// <summary>
        /// Constant AWSS3AccessPoint for ValidatePolicyResourceType
        /// </summary>
        public static readonly ValidatePolicyResourceType AWSS3AccessPoint = new ValidatePolicyResourceType("AWS::S3::AccessPoint");
        /// <summary>
        /// Constant AWSS3Bucket for ValidatePolicyResourceType
        /// </summary>
        public static readonly ValidatePolicyResourceType AWSS3Bucket = new ValidatePolicyResourceType("AWS::S3::Bucket");
        /// <summary>
        /// Constant AWSS3MultiRegionAccessPoint for ValidatePolicyResourceType
        /// </summary>
        public static readonly ValidatePolicyResourceType AWSS3MultiRegionAccessPoint = new ValidatePolicyResourceType("AWS::S3::MultiRegionAccessPoint");
        /// <summary>
        /// Constant AWSS3ObjectLambdaAccessPoint for ValidatePolicyResourceType
        /// </summary>
        public static readonly ValidatePolicyResourceType AWSS3ObjectLambdaAccessPoint = new ValidatePolicyResourceType("AWS::S3ObjectLambda::AccessPoint");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidatePolicyResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidatePolicyResourceType FindValue(string value)
        {
            return FindValue<ValidatePolicyResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidatePolicyResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant NotSupported for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason NotSupported = new ValidationExceptionReason("notSupported");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}