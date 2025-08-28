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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.HealthLake
{

    /// <summary>
    /// Constants used for properties of type AuthorizationStrategy.
    /// </summary>
    public class AuthorizationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AWS_AUTH for AuthorizationStrategy
        /// </summary>
        public static readonly AuthorizationStrategy AWS_AUTH = new AuthorizationStrategy("AWS_AUTH");
        /// <summary>
        /// Constant SMART_ON_FHIR for AuthorizationStrategy
        /// </summary>
        public static readonly AuthorizationStrategy SMART_ON_FHIR = new AuthorizationStrategy("SMART_ON_FHIR");
        /// <summary>
        /// Constant SMART_ON_FHIR_V1 for AuthorizationStrategy
        /// </summary>
        public static readonly AuthorizationStrategy SMART_ON_FHIR_V1 = new AuthorizationStrategy("SMART_ON_FHIR_V1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizationStrategy FindValue(string value)
        {
            return FindValue<AuthorizationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmkType.
    /// </summary>
    public class CmkType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KMS_KEY for CmkType
        /// </summary>
        public static readonly CmkType AWS_OWNED_KMS_KEY = new CmkType("AWS_OWNED_KMS_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KMS_KEY for CmkType
        /// </summary>
        public static readonly CmkType CUSTOMER_MANAGED_KMS_KEY = new CmkType("CUSTOMER_MANAGED_KMS_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmkType FindValue(string value)
        {
            return FindValue<CmkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatastoreStatus.
    /// </summary>
    public class DatastoreStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus ACTIVE = new DatastoreStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus CREATE_FAILED = new DatastoreStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus CREATING = new DatastoreStatus("CREATING");
        /// <summary>
        /// Constant DELETED for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus DELETED = new DatastoreStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus DELETING = new DatastoreStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatastoreStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatastoreStatus FindValue(string value)
        {
            return FindValue<DatastoreStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatastoreStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCategory.
    /// </summary>
    public class ErrorCategory : ConstantClass
    {

        /// <summary>
        /// Constant NON_RETRYABLE_ERROR for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory NON_RETRYABLE_ERROR = new ErrorCategory("NON_RETRYABLE_ERROR");
        /// <summary>
        /// Constant RETRYABLE_ERROR for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory RETRYABLE_ERROR = new ErrorCategory("RETRYABLE_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCategory FindValue(string value)
        {
            return FindValue<ErrorCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FHIRVersion.
    /// </summary>
    public class FHIRVersion : ConstantClass
    {

        /// <summary>
        /// Constant R4 for FHIRVersion
        /// </summary>
        public static readonly FHIRVersion R4 = new FHIRVersion("R4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FHIRVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FHIRVersion FindValue(string value)
        {
            return FindValue<FHIRVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FHIRVersion(string value)
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
        /// Constant CANCEL_COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCEL_COMPLETED = new JobStatus("CANCEL_COMPLETED");
        /// <summary>
        /// Constant CANCEL_FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCEL_FAILED = new JobStatus("CANCEL_FAILED");
        /// <summary>
        /// Constant CANCEL_IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus CANCEL_IN_PROGRESS = new JobStatus("CANCEL_IN_PROGRESS");
        /// <summary>
        /// Constant CANCEL_SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCEL_SUBMITTED = new JobStatus("CANCEL_SUBMITTED");
        /// <summary>
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED_WITH_ERRORS = new JobStatus("COMPLETED_WITH_ERRORS");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for JobStatus
        /// </summary>
        public static readonly JobStatus QUEUED = new JobStatus("QUEUED");
        /// <summary>
        /// Constant SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus SUBMITTED = new JobStatus("SUBMITTED");

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
    /// Constants used for properties of type PreloadDataType.
    /// </summary>
    public class PreloadDataType : ConstantClass
    {

        /// <summary>
        /// Constant SYNTHEA for PreloadDataType
        /// </summary>
        public static readonly PreloadDataType SYNTHEA = new PreloadDataType("SYNTHEA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreloadDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreloadDataType FindValue(string value)
        {
            return FindValue<PreloadDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreloadDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationLevel.
    /// </summary>
    public class ValidationLevel : ConstantClass
    {

        /// <summary>
        /// Constant Minimal for ValidationLevel
        /// </summary>
        public static readonly ValidationLevel Minimal = new ValidationLevel("minimal");
        /// <summary>
        /// Constant Strict for ValidationLevel
        /// </summary>
        public static readonly ValidationLevel Strict = new ValidationLevel("strict");
        /// <summary>
        /// Constant StructureOnly for ValidationLevel
        /// </summary>
        public static readonly ValidationLevel StructureOnly = new ValidationLevel("structure-only");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationLevel FindValue(string value)
        {
            return FindValue<ValidationLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationLevel(string value)
        {
            return FindValue(value);
        }
    }

}