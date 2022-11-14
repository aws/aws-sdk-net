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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CustomerProfiles
{

    /// <summary>
    /// Constants used for properties of type ConflictResolvingModel.
    /// </summary>
    public class ConflictResolvingModel : ConstantClass
    {

        /// <summary>
        /// Constant RECENCY for ConflictResolvingModel
        /// </summary>
        public static readonly ConflictResolvingModel RECENCY = new ConflictResolvingModel("RECENCY");
        /// <summary>
        /// Constant SOURCE for ConflictResolvingModel
        /// </summary>
        public static readonly ConflictResolvingModel SOURCE = new ConflictResolvingModel("SOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictResolvingModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictResolvingModel FindValue(string value)
        {
            return FindValue<ConflictResolvingModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictResolvingModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataPullMode.
    /// </summary>
    public class DataPullMode : ConstantClass
    {

        /// <summary>
        /// Constant Complete for DataPullMode
        /// </summary>
        public static readonly DataPullMode Complete = new DataPullMode("Complete");
        /// <summary>
        /// Constant Incremental for DataPullMode
        /// </summary>
        public static readonly DataPullMode Incremental = new DataPullMode("Incremental");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataPullMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataPullMode FindValue(string value)
        {
            return FindValue<DataPullMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataPullMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldContentType.
    /// </summary>
    public class FieldContentType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL_ADDRESS for FieldContentType
        /// </summary>
        public static readonly FieldContentType EMAIL_ADDRESS = new FieldContentType("EMAIL_ADDRESS");
        /// <summary>
        /// Constant NAME for FieldContentType
        /// </summary>
        public static readonly FieldContentType NAME = new FieldContentType("NAME");
        /// <summary>
        /// Constant NUMBER for FieldContentType
        /// </summary>
        public static readonly FieldContentType NUMBER = new FieldContentType("NUMBER");
        /// <summary>
        /// Constant PHONE_NUMBER for FieldContentType
        /// </summary>
        public static readonly FieldContentType PHONE_NUMBER = new FieldContentType("PHONE_NUMBER");
        /// <summary>
        /// Constant STRING for FieldContentType
        /// </summary>
        public static readonly FieldContentType STRING = new FieldContentType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldContentType FindValue(string value)
        {
            return FindValue<FieldContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Gender.
    /// </summary>
    public class Gender : ConstantClass
    {

        /// <summary>
        /// Constant FEMALE for Gender
        /// </summary>
        public static readonly Gender FEMALE = new Gender("FEMALE");
        /// <summary>
        /// Constant MALE for Gender
        /// </summary>
        public static readonly Gender MALE = new Gender("MALE");
        /// <summary>
        /// Constant UNSPECIFIED for Gender
        /// </summary>
        public static readonly Gender UNSPECIFIED = new Gender("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Gender(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Gender FindValue(string value)
        {
            return FindValue<Gender>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Gender(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityResolutionJobStatus.
    /// </summary>
    public class IdentityResolutionJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for IdentityResolutionJobStatus
        /// </summary>
        public static readonly IdentityResolutionJobStatus COMPLETED = new IdentityResolutionJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for IdentityResolutionJobStatus
        /// </summary>
        public static readonly IdentityResolutionJobStatus FAILED = new IdentityResolutionJobStatus("FAILED");
        /// <summary>
        /// Constant FIND_MATCHING for IdentityResolutionJobStatus
        /// </summary>
        public static readonly IdentityResolutionJobStatus FIND_MATCHING = new IdentityResolutionJobStatus("FIND_MATCHING");
        /// <summary>
        /// Constant MERGING for IdentityResolutionJobStatus
        /// </summary>
        public static readonly IdentityResolutionJobStatus MERGING = new IdentityResolutionJobStatus("MERGING");
        /// <summary>
        /// Constant PARTIAL_SUCCESS for IdentityResolutionJobStatus
        /// </summary>
        public static readonly IdentityResolutionJobStatus PARTIAL_SUCCESS = new IdentityResolutionJobStatus("PARTIAL_SUCCESS");
        /// <summary>
        /// Constant PENDING for IdentityResolutionJobStatus
        /// </summary>
        public static readonly IdentityResolutionJobStatus PENDING = new IdentityResolutionJobStatus("PENDING");
        /// <summary>
        /// Constant PREPROCESSING for IdentityResolutionJobStatus
        /// </summary>
        public static readonly IdentityResolutionJobStatus PREPROCESSING = new IdentityResolutionJobStatus("PREPROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityResolutionJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityResolutionJobStatus FindValue(string value)
        {
            return FindValue<IdentityResolutionJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityResolutionJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobScheduleDayOfTheWeek.
    /// </summary>
    public class JobScheduleDayOfTheWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for JobScheduleDayOfTheWeek
        /// </summary>
        public static readonly JobScheduleDayOfTheWeek FRIDAY = new JobScheduleDayOfTheWeek("FRIDAY");
        /// <summary>
        /// Constant MONDAY for JobScheduleDayOfTheWeek
        /// </summary>
        public static readonly JobScheduleDayOfTheWeek MONDAY = new JobScheduleDayOfTheWeek("MONDAY");
        /// <summary>
        /// Constant SATURDAY for JobScheduleDayOfTheWeek
        /// </summary>
        public static readonly JobScheduleDayOfTheWeek SATURDAY = new JobScheduleDayOfTheWeek("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for JobScheduleDayOfTheWeek
        /// </summary>
        public static readonly JobScheduleDayOfTheWeek SUNDAY = new JobScheduleDayOfTheWeek("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for JobScheduleDayOfTheWeek
        /// </summary>
        public static readonly JobScheduleDayOfTheWeek THURSDAY = new JobScheduleDayOfTheWeek("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for JobScheduleDayOfTheWeek
        /// </summary>
        public static readonly JobScheduleDayOfTheWeek TUESDAY = new JobScheduleDayOfTheWeek("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for JobScheduleDayOfTheWeek
        /// </summary>
        public static readonly JobScheduleDayOfTheWeek WEDNESDAY = new JobScheduleDayOfTheWeek("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobScheduleDayOfTheWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobScheduleDayOfTheWeek FindValue(string value)
        {
            return FindValue<JobScheduleDayOfTheWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobScheduleDayOfTheWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogicalOperator.
    /// </summary>
    public class LogicalOperator : ConstantClass
    {

        /// <summary>
        /// Constant AND for LogicalOperator
        /// </summary>
        public static readonly LogicalOperator AND = new LogicalOperator("AND");
        /// <summary>
        /// Constant OR for LogicalOperator
        /// </summary>
        public static readonly LogicalOperator OR = new LogicalOperator("OR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogicalOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogicalOperator FindValue(string value)
        {
            return FindValue<LogicalOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogicalOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketoConnectorOperator.
    /// </summary>
    public class MarketoConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator ADDITION = new MarketoConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator BETWEEN = new MarketoConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator DIVISION = new MarketoConnectorOperator("DIVISION");
        /// <summary>
        /// Constant GREATER_THAN for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator GREATER_THAN = new MarketoConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator LESS_THAN = new MarketoConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant MASK_ALL for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MASK_ALL = new MarketoConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MASK_FIRST_N = new MarketoConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MASK_LAST_N = new MarketoConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MULTIPLICATION = new MarketoConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator NO_OP = new MarketoConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator PROJECTION = new MarketoConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator SUBTRACTION = new MarketoConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NON_NEGATIVE = new MarketoConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NON_NULL = new MarketoConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NON_ZERO = new MarketoConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NUMERIC = new MarketoConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketoConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketoConnectorOperator FindValue(string value)
        {
            return FindValue<MarketoConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketoConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatorPropertiesKeys.
    /// </summary>
    public class OperatorPropertiesKeys : ConstantClass
    {

        /// <summary>
        /// Constant CONCAT_FORMAT for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys CONCAT_FORMAT = new OperatorPropertiesKeys("CONCAT_FORMAT");
        /// <summary>
        /// Constant DATA_TYPE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys DATA_TYPE = new OperatorPropertiesKeys("DATA_TYPE");
        /// <summary>
        /// Constant DESTINATION_DATA_TYPE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys DESTINATION_DATA_TYPE = new OperatorPropertiesKeys("DESTINATION_DATA_TYPE");
        /// <summary>
        /// Constant LOWER_BOUND for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys LOWER_BOUND = new OperatorPropertiesKeys("LOWER_BOUND");
        /// <summary>
        /// Constant MASK_LENGTH for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys MASK_LENGTH = new OperatorPropertiesKeys("MASK_LENGTH");
        /// <summary>
        /// Constant MASK_VALUE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys MASK_VALUE = new OperatorPropertiesKeys("MASK_VALUE");
        /// <summary>
        /// Constant MATH_OPERATION_FIELDS_ORDER for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys MATH_OPERATION_FIELDS_ORDER = new OperatorPropertiesKeys("MATH_OPERATION_FIELDS_ORDER");
        /// <summary>
        /// Constant SOURCE_DATA_TYPE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys SOURCE_DATA_TYPE = new OperatorPropertiesKeys("SOURCE_DATA_TYPE");
        /// <summary>
        /// Constant SUBFIELD_CATEGORY_MAP for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys SUBFIELD_CATEGORY_MAP = new OperatorPropertiesKeys("SUBFIELD_CATEGORY_MAP");
        /// <summary>
        /// Constant TRUNCATE_LENGTH for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys TRUNCATE_LENGTH = new OperatorPropertiesKeys("TRUNCATE_LENGTH");
        /// <summary>
        /// Constant UPPER_BOUND for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys UPPER_BOUND = new OperatorPropertiesKeys("UPPER_BOUND");
        /// <summary>
        /// Constant VALIDATION_ACTION for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys VALIDATION_ACTION = new OperatorPropertiesKeys("VALIDATION_ACTION");
        /// <summary>
        /// Constant VALUE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys VALUE = new OperatorPropertiesKeys("VALUE");
        /// <summary>
        /// Constant VALUES for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys VALUES = new OperatorPropertiesKeys("VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatorPropertiesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatorPropertiesKeys FindValue(string value)
        {
            return FindValue<OperatorPropertiesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatorPropertiesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartyType.
    /// </summary>
    public class PartyType : ConstantClass
    {

        /// <summary>
        /// Constant BUSINESS for PartyType
        /// </summary>
        public static readonly PartyType BUSINESS = new PartyType("BUSINESS");
        /// <summary>
        /// Constant INDIVIDUAL for PartyType
        /// </summary>
        public static readonly PartyType INDIVIDUAL = new PartyType("INDIVIDUAL");
        /// <summary>
        /// Constant OTHER for PartyType
        /// </summary>
        public static readonly PartyType OTHER = new PartyType("OTHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartyType FindValue(string value)
        {
            return FindValue<PartyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ConnectorOperator.
    /// </summary>
    public class S3ConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator ADDITION = new S3ConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator BETWEEN = new S3ConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator DIVISION = new S3ConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator EQUAL_TO = new S3ConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator GREATER_THAN = new S3ConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator GREATER_THAN_OR_EQUAL_TO = new S3ConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator LESS_THAN = new S3ConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator LESS_THAN_OR_EQUAL_TO = new S3ConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MASK_ALL = new S3ConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MASK_FIRST_N = new S3ConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MASK_LAST_N = new S3ConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MULTIPLICATION = new S3ConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator NO_OP = new S3ConnectorOperator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator NOT_EQUAL_TO = new S3ConnectorOperator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator PROJECTION = new S3ConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator SUBTRACTION = new S3ConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NON_NEGATIVE = new S3ConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NON_NULL = new S3ConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NON_ZERO = new S3ConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NUMERIC = new S3ConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ConnectorOperator FindValue(string value)
        {
            return FindValue<S3ConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SalesforceConnectorOperator.
    /// </summary>
    public class SalesforceConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator ADDITION = new SalesforceConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator BETWEEN = new SalesforceConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator CONTAINS = new SalesforceConnectorOperator("CONTAINS");
        /// <summary>
        /// Constant DIVISION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator DIVISION = new SalesforceConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator EQUAL_TO = new SalesforceConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator GREATER_THAN = new SalesforceConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator GREATER_THAN_OR_EQUAL_TO = new SalesforceConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator LESS_THAN = new SalesforceConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator LESS_THAN_OR_EQUAL_TO = new SalesforceConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MASK_ALL = new SalesforceConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MASK_FIRST_N = new SalesforceConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MASK_LAST_N = new SalesforceConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MULTIPLICATION = new SalesforceConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator NO_OP = new SalesforceConnectorOperator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator NOT_EQUAL_TO = new SalesforceConnectorOperator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator PROJECTION = new SalesforceConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator SUBTRACTION = new SalesforceConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NON_NEGATIVE = new SalesforceConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NON_NULL = new SalesforceConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NON_ZERO = new SalesforceConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NUMERIC = new SalesforceConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesforceConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesforceConnectorOperator FindValue(string value)
        {
            return FindValue<SalesforceConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesforceConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNowConnectorOperator.
    /// </summary>
    public class ServiceNowConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator ADDITION = new ServiceNowConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator BETWEEN = new ServiceNowConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator CONTAINS = new ServiceNowConnectorOperator("CONTAINS");
        /// <summary>
        /// Constant DIVISION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator DIVISION = new ServiceNowConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator EQUAL_TO = new ServiceNowConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator GREATER_THAN = new ServiceNowConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator GREATER_THAN_OR_EQUAL_TO = new ServiceNowConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator LESS_THAN = new ServiceNowConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator LESS_THAN_OR_EQUAL_TO = new ServiceNowConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MASK_ALL = new ServiceNowConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MASK_FIRST_N = new ServiceNowConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MASK_LAST_N = new ServiceNowConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MULTIPLICATION = new ServiceNowConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator NO_OP = new ServiceNowConnectorOperator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator NOT_EQUAL_TO = new ServiceNowConnectorOperator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator PROJECTION = new ServiceNowConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator SUBTRACTION = new ServiceNowConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NON_NEGATIVE = new ServiceNowConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NON_NULL = new ServiceNowConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NON_ZERO = new ServiceNowConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NUMERIC = new ServiceNowConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNowConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNowConnectorOperator FindValue(string value)
        {
            return FindValue<ServiceNowConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNowConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceConnectorType.
    /// </summary>
    public class SourceConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant Marketo for SourceConnectorType
        /// </summary>
        public static readonly SourceConnectorType Marketo = new SourceConnectorType("Marketo");
        /// <summary>
        /// Constant S3 for SourceConnectorType
        /// </summary>
        public static readonly SourceConnectorType S3 = new SourceConnectorType("S3");
        /// <summary>
        /// Constant Salesforce for SourceConnectorType
        /// </summary>
        public static readonly SourceConnectorType Salesforce = new SourceConnectorType("Salesforce");
        /// <summary>
        /// Constant Servicenow for SourceConnectorType
        /// </summary>
        public static readonly SourceConnectorType Servicenow = new SourceConnectorType("Servicenow");
        /// <summary>
        /// Constant Zendesk for SourceConnectorType
        /// </summary>
        public static readonly SourceConnectorType Zendesk = new SourceConnectorType("Zendesk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceConnectorType FindValue(string value)
        {
            return FindValue<SourceConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandardIdentifier.
    /// </summary>
    public class StandardIdentifier : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier ASSET = new StandardIdentifier("ASSET");
        /// <summary>
        /// Constant CASE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier CASE = new StandardIdentifier("CASE");
        /// <summary>
        /// Constant LOOKUP_ONLY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier LOOKUP_ONLY = new StandardIdentifier("LOOKUP_ONLY");
        /// <summary>
        /// Constant NEW_ONLY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier NEW_ONLY = new StandardIdentifier("NEW_ONLY");
        /// <summary>
        /// Constant ORDER for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier ORDER = new StandardIdentifier("ORDER");
        /// <summary>
        /// Constant PROFILE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier PROFILE = new StandardIdentifier("PROFILE");
        /// <summary>
        /// Constant SECONDARY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier SECONDARY = new StandardIdentifier("SECONDARY");
        /// <summary>
        /// Constant UNIQUE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier UNIQUE = new StandardIdentifier("UNIQUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardIdentifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardIdentifier FindValue(string value)
        {
            return FindValue<StandardIdentifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardIdentifier(string value)
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
        /// Constant CANCELLED for Status
        /// </summary>
        public static readonly Status CANCELLED = new Status("CANCELLED");
        /// <summary>
        /// Constant COMPLETE for Status
        /// </summary>
        public static readonly Status COMPLETE = new Status("COMPLETE");
        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for Status
        /// </summary>
        public static readonly Status IN_PROGRESS = new Status("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for Status
        /// </summary>
        public static readonly Status NOT_STARTED = new Status("NOT_STARTED");
        /// <summary>
        /// Constant RETRY for Status
        /// </summary>
        public static readonly Status RETRY = new Status("RETRY");
        /// <summary>
        /// Constant SPLIT for Status
        /// </summary>
        public static readonly Status SPLIT = new Status("SPLIT");

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
    /// Constants used for properties of type TaskType.
    /// </summary>
    public class TaskType : ConstantClass
    {

        /// <summary>
        /// Constant Arithmetic for TaskType
        /// </summary>
        public static readonly TaskType Arithmetic = new TaskType("Arithmetic");
        /// <summary>
        /// Constant Filter for TaskType
        /// </summary>
        public static readonly TaskType Filter = new TaskType("Filter");
        /// <summary>
        /// Constant Map for TaskType
        /// </summary>
        public static readonly TaskType Map = new TaskType("Map");
        /// <summary>
        /// Constant Mask for TaskType
        /// </summary>
        public static readonly TaskType Mask = new TaskType("Mask");
        /// <summary>
        /// Constant Merge for TaskType
        /// </summary>
        public static readonly TaskType Merge = new TaskType("Merge");
        /// <summary>
        /// Constant Truncate for TaskType
        /// </summary>
        public static readonly TaskType Truncate = new TaskType("Truncate");
        /// <summary>
        /// Constant Validate for TaskType
        /// </summary>
        public static readonly TaskType Validate = new TaskType("Validate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskType FindValue(string value)
        {
            return FindValue<TaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerType.
    /// </summary>
    public class TriggerType : ConstantClass
    {

        /// <summary>
        /// Constant Event for TriggerType
        /// </summary>
        public static readonly TriggerType Event = new TriggerType("Event");
        /// <summary>
        /// Constant OnDemand for TriggerType
        /// </summary>
        public static readonly TriggerType OnDemand = new TriggerType("OnDemand");
        /// <summary>
        /// Constant Scheduled for TriggerType
        /// </summary>
        public static readonly TriggerType Scheduled = new TriggerType("Scheduled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerType FindValue(string value)
        {
            return FindValue<TriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowType.
    /// </summary>
    public class WorkflowType : ConstantClass
    {

        /// <summary>
        /// Constant APPFLOW_INTEGRATION for WorkflowType
        /// </summary>
        public static readonly WorkflowType APPFLOW_INTEGRATION = new WorkflowType("APPFLOW_INTEGRATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowType FindValue(string value)
        {
            return FindValue<WorkflowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ZendeskConnectorOperator.
    /// </summary>
    public class ZendeskConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator ADDITION = new ZendeskConnectorOperator("ADDITION");
        /// <summary>
        /// Constant DIVISION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator DIVISION = new ZendeskConnectorOperator("DIVISION");
        /// <summary>
        /// Constant GREATER_THAN for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator GREATER_THAN = new ZendeskConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant MASK_ALL for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MASK_ALL = new ZendeskConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MASK_FIRST_N = new ZendeskConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MASK_LAST_N = new ZendeskConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MULTIPLICATION = new ZendeskConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator NO_OP = new ZendeskConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator PROJECTION = new ZendeskConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator SUBTRACTION = new ZendeskConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NON_NEGATIVE = new ZendeskConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NON_NULL = new ZendeskConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NON_ZERO = new ZendeskConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NUMERIC = new ZendeskConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZendeskConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZendeskConnectorOperator FindValue(string value)
        {
            return FindValue<ZendeskConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZendeskConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }

}