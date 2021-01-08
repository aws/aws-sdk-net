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
    /// Constants used for properties of type JobErrorLimitName.
    /// </summary>
    public class JobErrorLimitName : ConstantClass
    {

        /// <summary>
        /// Constant AssetSizeInGB for JobErrorLimitName
        /// </summary>
        public static readonly JobErrorLimitName AssetSizeInGB = new JobErrorLimitName("Asset size in GB");
        /// <summary>
        /// Constant AssetsPerRevision for JobErrorLimitName
        /// </summary>
        public static readonly JobErrorLimitName AssetsPerRevision = new JobErrorLimitName("Assets per revision");

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
    /// Constants used for properties of type LimitName.
    /// </summary>
    public class LimitName : ConstantClass
    {

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
        /// Constant ConcurrentInProgressJobsToExportAssetsToAmazonS3 for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToExportAssetsToAmazonS3 = new LimitName("Concurrent in progress jobs to export assets to Amazon S3");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToExportAssetsToASignedURL for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToExportAssetsToASignedURL = new LimitName("Concurrent in progress jobs to export assets to a signed URL");
        /// <summary>
        /// Constant ConcurrentInProgressJobsToImportAssetsFromAmazonS3 for LimitName
        /// </summary>
        public static readonly LimitName ConcurrentInProgressJobsToImportAssetsFromAmazonS3 = new LimitName("Concurrent in progress jobs to import assets from Amazon S3");
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
        /// Constant ProductsPerAccount for LimitName
        /// </summary>
        public static readonly LimitName ProductsPerAccount = new LimitName("Products per account");
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
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant EXPORT_ASSET_TO_SIGNED_URL for Type
        /// </summary>
        public static readonly Type EXPORT_ASSET_TO_SIGNED_URL = new Type("EXPORT_ASSET_TO_SIGNED_URL");
        /// <summary>
        /// Constant EXPORT_ASSETS_TO_S3 for Type
        /// </summary>
        public static readonly Type EXPORT_ASSETS_TO_S3 = new Type("EXPORT_ASSETS_TO_S3");
        /// <summary>
        /// Constant IMPORT_ASSET_FROM_SIGNED_URL for Type
        /// </summary>
        public static readonly Type IMPORT_ASSET_FROM_SIGNED_URL = new Type("IMPORT_ASSET_FROM_SIGNED_URL");
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