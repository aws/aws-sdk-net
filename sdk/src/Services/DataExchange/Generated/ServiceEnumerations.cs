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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DataExchange
{

    /// <summary>
    /// Constants used for properties of type AssetType.
    /// </summary>
    public class AssetType : ConstantClass
    {

        /// <summary>
        /// Constant API_GATEWAY_API for AssetType
        /// </summary>
        public static readonly AssetType API_GATEWAY_API = new AssetType("API_GATEWAY_API");
        /// <summary>
        /// Constant LAKE_FORMATION_DATA_PERMISSION for AssetType
        /// </summary>
        public static readonly AssetType LAKE_FORMATION_DATA_PERMISSION = new AssetType("LAKE_FORMATION_DATA_PERMISSION");
        /// <summary>
        /// Constant REDSHIFT_DATA_SHARE for AssetType
        /// </summary>
        public static readonly AssetType REDSHIFT_DATA_SHARE = new AssetType("REDSHIFT_DATA_SHARE");
        /// <summary>
        /// Constant S3_DATA_ACCESS for AssetType
        /// </summary>
        public static readonly AssetType S3_DATA_ACCESS = new AssetType("S3_DATA_ACCESS");
        /// <summary>
        /// Constant S3_SNAPSHOT for AssetType
        /// </summary>
        public static readonly AssetType S3_SNAPSHOT = new AssetType("S3_SNAPSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetType FindValue(string value)
        {
            return FindValue<AssetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Code.
    /// </summary>
    public class Code : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED_EXCEPTION for Code
        /// </summary>
        public static readonly Code ACCESS_DENIED_EXCEPTION = new Code("ACCESS_DENIED_EXCEPTION");
        /// <summary>
        /// Constant INTERNAL_SERVER_EXCEPTION for Code
        /// </summary>
        public static readonly Code INTERNAL_SERVER_EXCEPTION = new Code("INTERNAL_SERVER_EXCEPTION");
        /// <summary>
        /// Constant MALWARE_DETECTED for Code
        /// </summary>
        public static readonly Code MALWARE_DETECTED = new Code("MALWARE_DETECTED");
        /// <summary>
        /// Constant MALWARE_SCAN_ENCRYPTED_FILE for Code
        /// </summary>
        public static readonly Code MALWARE_SCAN_ENCRYPTED_FILE = new Code("MALWARE_SCAN_ENCRYPTED_FILE");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND_EXCEPTION for Code
        /// </summary>
        public static readonly Code RESOURCE_NOT_FOUND_EXCEPTION = new Code("RESOURCE_NOT_FOUND_EXCEPTION");
        /// <summary>
        /// Constant SERVICE_QUOTA_EXCEEDED_EXCEPTION for Code
        /// </summary>
        public static readonly Code SERVICE_QUOTA_EXCEEDED_EXCEPTION = new Code("SERVICE_QUOTA_EXCEEDED_EXCEPTION");
        /// <summary>
        /// Constant VALIDATION_EXCEPTION for Code
        /// </summary>
        public static readonly Code VALIDATION_EXCEPTION = new Code("VALIDATION_EXCEPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Code(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Code FindValue(string value)
        {
            return FindValue<Code>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Code(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseLFTagPolicyPermission.
    /// </summary>
    public class DatabaseLFTagPolicyPermission : ConstantClass
    {

        /// <summary>
        /// Constant DESCRIBE for DatabaseLFTagPolicyPermission
        /// </summary>
        public static readonly DatabaseLFTagPolicyPermission DESCRIBE = new DatabaseLFTagPolicyPermission("DESCRIBE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseLFTagPolicyPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseLFTagPolicyPermission FindValue(string value)
        {
            return FindValue<DatabaseLFTagPolicyPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseLFTagPolicyPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExceptionCause.
    /// </summary>
    public class ExceptionCause : ConstantClass
    {

        /// <summary>
        /// Constant InsufficientS3BucketPolicy for ExceptionCause
        /// </summary>
        public static readonly ExceptionCause InsufficientS3BucketPolicy = new ExceptionCause("InsufficientS3BucketPolicy");
        /// <summary>
        /// Constant S3AccessDenied for ExceptionCause
        /// </summary>
        public static readonly ExceptionCause S3AccessDenied = new ExceptionCause("S3AccessDenied");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExceptionCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExceptionCause FindValue(string value)
        {
            return FindValue<ExceptionCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExceptionCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobErrorLimitName.
    /// </summary>
    public class JobErrorLimitName : ConstantClass
    {

        /// <summary>
        /// Constant AmazonRedshiftDatashareAssetsPerRevision for JobErrorLimitName
        /// </summary>
        public static readonly JobErrorLimitName AmazonRedshiftDatashareAssetsPerRevision = new JobErrorLimitName("Amazon Redshift datashare assets per revision");
        /// <summary>
        /// Constant AmazonS3DataAccessAssetsPerRevision for JobErrorLimitName
        /// </summary>
        public static readonly JobErrorLimitName AmazonS3DataAccessAssetsPerRevision = new JobErrorLimitName("Amazon S3 data access assets per revision");
        /// <summary>
        /// Constant AssetSizeInGB for JobErrorLimitName
        /// </summary>
        public static readonly JobErrorLimitName AssetSizeInGB = new JobErrorLimitName("Asset size in GB");
        /// <summary>
        /// Constant AssetsPerRevision for JobErrorLimitName
        /// </summary>
        public static readonly JobErrorLimitName AssetsPerRevision = new JobErrorLimitName("Assets per revision");
        /// <summary>
        /// Constant AWSLakeFormationDataPermissionAssetsPerRevision for JobErrorLimitName
        /// </summary>
        public static readonly JobErrorLimitName AWSLakeFormationDataPermissionAssetsPerRevision = new JobErrorLimitName("AWS Lake Formation data permission assets per revision");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobErrorLimitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobErrorLimitName FindValue(string value)
        {
            return FindValue<JobErrorLimitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobErrorLimitName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobErrorResourceTypes.
    /// </summary>
    public class JobErrorResourceTypes : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for JobErrorResourceTypes
        /// </summary>
        public static readonly JobErrorResourceTypes ASSET = new JobErrorResourceTypes("ASSET");
        /// <summary>
        /// Constant DATA_SET for JobErrorResourceTypes
        /// </summary>
        public static readonly JobErrorResourceTypes DATA_SET = new JobErrorResourceTypes("DATA_SET");
        /// <summary>
        /// Constant REVISION for JobErrorResourceTypes
        /// </summary>
        public static readonly JobErrorResourceTypes REVISION = new JobErrorResourceTypes("REVISION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobErrorResourceTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobErrorResourceTypes FindValue(string value)
        {
            return FindValue<JobErrorResourceTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobErrorResourceTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LakeFormationDataPermissionType.
    /// </summary>
    public class LakeFormationDataPermissionType : ConstantClass
    {

        /// <summary>
        /// Constant LFTagPolicy for LakeFormationDataPermissionType
        /// </summary>
        public static readonly LakeFormationDataPermissionType LFTagPolicy = new LakeFormationDataPermissionType("LFTagPolicy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LakeFormationDataPermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LakeFormationDataPermissionType FindValue(string value)
        {
            return FindValue<LakeFormationDataPermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LakeFormationDataPermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LFPermission.
    /// </summary>
    public class LFPermission : ConstantClass
    {

        /// <summary>
        /// Constant DESCRIBE for LFPermission
        /// </summary>
        public static readonly LFPermission DESCRIBE = new LFPermission("DESCRIBE");
        /// <summary>
        /// Constant SELECT for LFPermission
        /// </summary>
        public static readonly LFPermission SELECT = new LFPermission("SELECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LFPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LFPermission FindValue(string value)
        {
            return FindValue<LFPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LFPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LFResourceType.
    /// </summary>
    public class LFResourceType : ConstantClass
    {

        /// <summary>
        /// Constant DATABASE for LFResourceType
        /// </summary>
        public static readonly LFResourceType DATABASE = new LFResourceType("DATABASE");
        /// <summary>
        /// Constant TABLE for LFResourceType
        /// </summary>
        public static readonly LFResourceType TABLE = new LFResourceType("TABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LFResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LFResourceType FindValue(string value)
        {
            return FindValue<LFResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LFResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LimitName.
    /// </summary>
    public class LimitName : ConstantClass
    {

        /// <summary>
        /// Constant AmazonAPIGatewayAPIAssetsPerRevision for LimitName
        /// </summary>
        public static readonly LimitName AmazonAPIGatewayAPIAssetsPerRevision = new LimitName("Amazon API Gateway API assets per revision");
        /// <summary>
        /// Constant AmazonRedshiftDatashareAssetsPerImportJobFromRedshift for LimitName
        /// </summary>
        public static readonly LimitName AmazonRedshiftDatashareAssetsPerImportJobFromRedshift = new LimitName("Amazon Redshift datashare assets per import job from Redshift");
        /// <summary>
        /// Constant AmazonRedshiftDatashareAssetsPerRevision for LimitName
        /// </summary>
        public static readonly LimitName AmazonRedshiftDatashareAssetsPerRevision = new LimitName("Amazon Redshift datashare assets per revision");
        /// <summary>
        /// Constant AmazonS3DataAccessAssetsPerRevision for LimitName
        /// </summary>
        public static readonly LimitName AmazonS3DataAccessAssetsPerRevision = new LimitName("Amazon S3 data access assets per revision");
        /// <summary>
        /// Constant AssetPerExportJobFromAmazonS3 for LimitName
        /// </summary>
        public static readonly LimitName AssetPerExportJobFromAmazonS3 = new LimitName("Asset per export job from Amazon S3");
        /// <summary>
        /// Constant AssetSizeInGB for LimitName
        /// </summary>
        public static readonly LimitName AssetSizeInGB = new LimitName("Asset size in GB");
        /// <summary>
        /// Constant AssetsPerImportJobFromAmazonS3 for LimitName
        /// </summary>
        public static readonly LimitName AssetsPerImportJobFromAmazonS3 = new LimitName("Assets per import job from Amazon S3");
        /// <summary>
        /// Constant AssetsPerRevision for LimitName
        /// </summary>
        public static readonly LimitName AssetsPerRevision = new LimitName("Assets per revision");
        /// <summary>
        /// Constant AutoExportEventActionsPerDataSet for LimitName
        /// </summary>
        public static readonly LimitName AutoExportEventActionsPerDataSet = new LimitName("Auto export event actions per data set");
        /// <summary>
        /// Constant AWSLakeFormationDataPermissionAssetsPerRevision for LimitName
        /// </summary>
        public static readonly LimitName AWSLakeFormationDataPermissionAssetsPerRevision = new LimitName("AWS Lake Formation data permission assets per revision");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToCreateAmazonS3DataAccessAssetsFromS3Buckets for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToCreateAmazonS3DataAccessAssetsFromS3Buckets = new LimitName("Concurrent in progress jobs to create Amazon S3 data access assets from S3 buckets");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToExportAssetsToAmazonS3 for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToExportAssetsToAmazonS3 = new LimitName("Concurrent in progress jobs to export assets to Amazon S3");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToExportAssetsToASignedURL for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToExportAssetsToASignedURL = new LimitName("Concurrent in progress jobs to export assets to a signed URL");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToExportRevisionsToAmazonS3 for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToExportRevisionsToAmazonS3 = new LimitName("Concurrent in progress jobs to export revisions to Amazon S3");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToImportAssetsFromAmazonRedshiftDatashares for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToImportAssetsFromAmazonRedshiftDatashares = new LimitName("Concurrent in progress jobs to import assets from Amazon Redshift datashares");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToImportAssetsFromAmazonS3 for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToImportAssetsFromAmazonS3 = new LimitName("Concurrent in progress jobs to import assets from Amazon S3");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToImportAssetsFromAnAPIGatewayAPI for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToImportAssetsFromAnAPIGatewayAPI = new LimitName("Concurrent in progress jobs to import assets from an API Gateway API");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToImportAssetsFromAnAWSLakeFormationTagPolicy for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToImportAssetsFromAnAWSLakeFormationTagPolicy = new LimitName("Concurrent in progress jobs to import assets from an AWS Lake Formation tag policy");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToImportAssetsFromASignedURL for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToImportAssetsFromASignedURL = new LimitName("Concurrent in progress jobs to import assets from a signed URL");
        /// <summary>
        /// Constant DataSetsPerAccount for LimitName
        /// </summary>
        public static readonly LimitName DataSetsPerAccount = new LimitName("Data sets per account");
        /// <summary>
        /// Constant DataSetsPerProduct for LimitName
        /// </summary>
        public static readonly LimitName DataSetsPerProduct = new LimitName("Data sets per product");
        /// <summary>
        /// Constant EventActionsPerAccount for LimitName
        /// </summary>
        public static readonly LimitName EventActionsPerAccount = new LimitName("Event actions per account");
        /// <summary>
        /// Constant ProductsPerAccount for LimitName
        /// </summary>
        public static readonly LimitName ProductsPerAccount = new LimitName("Products per account");
        /// <summary>
        /// Constant RevisionsPerAmazonAPIGatewayAPIDataSet for LimitName
        /// </summary>
        public static readonly LimitName RevisionsPerAmazonAPIGatewayAPIDataSet = new LimitName("Revisions per Amazon API Gateway API data set");
        /// <summary>
        /// Constant RevisionsPerAmazonRedshiftDatashareDataSet for LimitName
        /// </summary>
        public static readonly LimitName RevisionsPerAmazonRedshiftDatashareDataSet = new LimitName("Revisions per Amazon Redshift datashare data set");
        /// <summary>
        /// Constant RevisionsPerAmazonS3DataAccessDataSet for LimitName
        /// </summary>
        public static readonly LimitName RevisionsPerAmazonS3DataAccessDataSet = new LimitName("Revisions per Amazon S3 data access data set");
        /// <summary>
        /// Constant RevisionsPerAWSLakeFormationDataPermissionDataSet for LimitName
        /// </summary>
        public static readonly LimitName RevisionsPerAWSLakeFormationDataPermissionDataSet = new LimitName("Revisions per AWS Lake Formation data permission data set");
        /// <summary>
        /// Constant RevisionsPerDataSet for LimitName
        /// </summary>
        public static readonly LimitName RevisionsPerDataSet = new LimitName("Revisions per data set");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LimitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LimitName FindValue(string value)
        {
            return FindValue<LimitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LimitName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Origin.
    /// </summary>
    public class Origin : ConstantClass
    {

        /// <summary>
        /// Constant ENTITLED for Origin
        /// </summary>
        public static readonly Origin ENTITLED = new Origin("ENTITLED");
        /// <summary>
        /// Constant OWNED for Origin
        /// </summary>
        public static readonly Origin OWNED = new Origin("OWNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Origin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Origin FindValue(string value)
        {
            return FindValue<Origin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Origin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtocolType.
    /// </summary>
    public class ProtocolType : ConstantClass
    {

        /// <summary>
        /// Constant REST for ProtocolType
        /// </summary>
        public static readonly ProtocolType REST = new ProtocolType("REST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtocolType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtocolType FindValue(string value)
        {
            return FindValue<ProtocolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtocolType(string value)
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
        /// Constant ASSET for ResourceType
        /// </summary>
        public static readonly ResourceType ASSET = new ResourceType("ASSET");
        /// <summary>
        /// Constant DATA_SET for ResourceType
        /// </summary>
        public static readonly ResourceType DATA_SET = new ResourceType("DATA_SET");
        /// <summary>
        /// Constant EVENT_ACTION for ResourceType
        /// </summary>
        public static readonly ResourceType EVENT_ACTION = new ResourceType("EVENT_ACTION");
        /// <summary>
        /// Constant JOB for ResourceType
        /// </summary>
        public static readonly ResourceType JOB = new ResourceType("JOB");
        /// <summary>
        /// Constant REVISION for ResourceType
        /// </summary>
        public static readonly ResourceType REVISION = new ResourceType("REVISION");

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
    /// Constants used for properties of type ServerSideEncryptionTypes.
    /// </summary>
    public class ServerSideEncryptionTypes : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for ServerSideEncryptionTypes
        /// </summary>
        public static readonly ServerSideEncryptionTypes AES256 = new ServerSideEncryptionTypes("AES256");
        /// <summary>
        /// Constant AwsKms for ServerSideEncryptionTypes
        /// </summary>
        public static readonly ServerSideEncryptionTypes AwsKms = new ServerSideEncryptionTypes("aws:kms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerSideEncryptionTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerSideEncryptionTypes FindValue(string value)
        {
            return FindValue<ServerSideEncryptionTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerSideEncryptionTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for State
        /// </summary>
        public static readonly State CANCELLED = new State("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for State
        /// </summary>
        public static readonly State COMPLETED = new State("COMPLETED");
        /// <summary>
        /// Constant ERROR for State
        /// </summary>
        public static readonly State ERROR = new State("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for State
        /// </summary>
        public static readonly State IN_PROGRESS = new State("IN_PROGRESS");
        /// <summary>
        /// Constant TIMED_OUT for State
        /// </summary>
        public static readonly State TIMED_OUT = new State("TIMED_OUT");
        /// <summary>
        /// Constant WAITING for State
        /// </summary>
        public static readonly State WAITING = new State("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableTagPolicyLFPermission.
    /// </summary>
    public class TableTagPolicyLFPermission : ConstantClass
    {

        /// <summary>
        /// Constant DESCRIBE for TableTagPolicyLFPermission
        /// </summary>
        public static readonly TableTagPolicyLFPermission DESCRIBE = new TableTagPolicyLFPermission("DESCRIBE");
        /// <summary>
        /// Constant SELECT for TableTagPolicyLFPermission
        /// </summary>
        public static readonly TableTagPolicyLFPermission SELECT = new TableTagPolicyLFPermission("SELECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableTagPolicyLFPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableTagPolicyLFPermission FindValue(string value)
        {
            return FindValue<TableTagPolicyLFPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableTagPolicyLFPermission(string value)
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
        /// Constant CREATE_S3_DATA_ACCESS_FROM_S3_BUCKET for Type
        /// </summary>
        public static readonly Type CREATE_S3_DATA_ACCESS_FROM_S3_BUCKET = new Type("CREATE_S3_DATA_ACCESS_FROM_S3_BUCKET");
        /// <summary>
        /// Constant EXPORT_ASSET_TO_SIGNED_URL for Type
        /// </summary>
        public static readonly Type EXPORT_ASSET_TO_SIGNED_URL = new Type("EXPORT_ASSET_TO_SIGNED_URL");
        /// <summary>
        /// Constant EXPORT_ASSETS_TO_S3 for Type
        /// </summary>
        public static readonly Type EXPORT_ASSETS_TO_S3 = new Type("EXPORT_ASSETS_TO_S3");
        /// <summary>
        /// Constant EXPORT_REVISIONS_TO_S3 for Type
        /// </summary>
        public static readonly Type EXPORT_REVISIONS_TO_S3 = new Type("EXPORT_REVISIONS_TO_S3");
        /// <summary>
        /// Constant IMPORT_ASSET_FROM_API_GATEWAY_API for Type
        /// </summary>
        public static readonly Type IMPORT_ASSET_FROM_API_GATEWAY_API = new Type("IMPORT_ASSET_FROM_API_GATEWAY_API");
        /// <summary>
        /// Constant IMPORT_ASSET_FROM_SIGNED_URL for Type
        /// </summary>
        public static readonly Type IMPORT_ASSET_FROM_SIGNED_URL = new Type("IMPORT_ASSET_FROM_SIGNED_URL");
        /// <summary>
        /// Constant IMPORT_ASSETS_FROM_LAKE_FORMATION_TAG_POLICY for Type
        /// </summary>
        public static readonly Type IMPORT_ASSETS_FROM_LAKE_FORMATION_TAG_POLICY = new Type("IMPORT_ASSETS_FROM_LAKE_FORMATION_TAG_POLICY");
        /// <summary>
        /// Constant IMPORT_ASSETS_FROM_REDSHIFT_DATA_SHARES for Type
        /// </summary>
        public static readonly Type IMPORT_ASSETS_FROM_REDSHIFT_DATA_SHARES = new Type("IMPORT_ASSETS_FROM_REDSHIFT_DATA_SHARES");
        /// <summary>
        /// Constant IMPORT_ASSETS_FROM_S3 for Type
        /// </summary>
        public static readonly Type IMPORT_ASSETS_FROM_S3 = new Type("IMPORT_ASSETS_FROM_S3");

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

}