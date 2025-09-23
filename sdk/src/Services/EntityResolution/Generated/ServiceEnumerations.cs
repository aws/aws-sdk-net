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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EntityResolution
{

    /// <summary>
    /// Constants used for properties of type AttributeMatchingModel.
    /// </summary>
    public class AttributeMatchingModel : ConstantClass
    {

        /// <summary>
        /// Constant MANY_TO_MANY for AttributeMatchingModel
        /// </summary>
        public static readonly AttributeMatchingModel MANY_TO_MANY = new AttributeMatchingModel("MANY_TO_MANY");
        /// <summary>
        /// Constant ONE_TO_ONE for AttributeMatchingModel
        /// </summary>
        public static readonly AttributeMatchingModel ONE_TO_ONE = new AttributeMatchingModel("ONE_TO_ONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeMatchingModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeMatchingModel FindValue(string value)
        {
            return FindValue<AttributeMatchingModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeMatchingModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteUniqueIdErrorType.
    /// </summary>
    public class DeleteUniqueIdErrorType : ConstantClass
    {

        /// <summary>
        /// Constant SERVICE_ERROR for DeleteUniqueIdErrorType
        /// </summary>
        public static readonly DeleteUniqueIdErrorType SERVICE_ERROR = new DeleteUniqueIdErrorType("SERVICE_ERROR");
        /// <summary>
        /// Constant VALIDATION_ERROR for DeleteUniqueIdErrorType
        /// </summary>
        public static readonly DeleteUniqueIdErrorType VALIDATION_ERROR = new DeleteUniqueIdErrorType("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteUniqueIdErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteUniqueIdErrorType FindValue(string value)
        {
            return FindValue<DeleteUniqueIdErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteUniqueIdErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteUniqueIdStatus.
    /// </summary>
    public class DeleteUniqueIdStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for DeleteUniqueIdStatus
        /// </summary>
        public static readonly DeleteUniqueIdStatus ACCEPTED = new DeleteUniqueIdStatus("ACCEPTED");
        /// <summary>
        /// Constant COMPLETED for DeleteUniqueIdStatus
        /// </summary>
        public static readonly DeleteUniqueIdStatus COMPLETED = new DeleteUniqueIdStatus("COMPLETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteUniqueIdStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteUniqueIdStatus FindValue(string value)
        {
            return FindValue<DeleteUniqueIdStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteUniqueIdStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdMappingIncrementalRunType.
    /// </summary>
    public class IdMappingIncrementalRunType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for IdMappingIncrementalRunType
        /// </summary>
        public static readonly IdMappingIncrementalRunType ON_DEMAND = new IdMappingIncrementalRunType("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdMappingIncrementalRunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdMappingIncrementalRunType FindValue(string value)
        {
            return FindValue<IdMappingIncrementalRunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdMappingIncrementalRunType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdMappingType.
    /// </summary>
    public class IdMappingType : ConstantClass
    {

        /// <summary>
        /// Constant PROVIDER for IdMappingType
        /// </summary>
        public static readonly IdMappingType PROVIDER = new IdMappingType("PROVIDER");
        /// <summary>
        /// Constant RULE_BASED for IdMappingType
        /// </summary>
        public static readonly IdMappingType RULE_BASED = new IdMappingType("RULE_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdMappingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdMappingType FindValue(string value)
        {
            return FindValue<IdMappingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdMappingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdMappingWorkflowRuleDefinitionType.
    /// </summary>
    public class IdMappingWorkflowRuleDefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant SOURCE for IdMappingWorkflowRuleDefinitionType
        /// </summary>
        public static readonly IdMappingWorkflowRuleDefinitionType SOURCE = new IdMappingWorkflowRuleDefinitionType("SOURCE");
        /// <summary>
        /// Constant TARGET for IdMappingWorkflowRuleDefinitionType
        /// </summary>
        public static readonly IdMappingWorkflowRuleDefinitionType TARGET = new IdMappingWorkflowRuleDefinitionType("TARGET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdMappingWorkflowRuleDefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdMappingWorkflowRuleDefinitionType FindValue(string value)
        {
            return FindValue<IdMappingWorkflowRuleDefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdMappingWorkflowRuleDefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdNamespaceType.
    /// </summary>
    public class IdNamespaceType : ConstantClass
    {

        /// <summary>
        /// Constant SOURCE for IdNamespaceType
        /// </summary>
        public static readonly IdNamespaceType SOURCE = new IdNamespaceType("SOURCE");
        /// <summary>
        /// Constant TARGET for IdNamespaceType
        /// </summary>
        public static readonly IdNamespaceType TARGET = new IdNamespaceType("TARGET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdNamespaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdNamespaceType FindValue(string value)
        {
            return FindValue<IdNamespaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdNamespaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IncrementalRunType.
    /// </summary>
    public class IncrementalRunType : ConstantClass
    {

        /// <summary>
        /// Constant IMMEDIATE for IncrementalRunType
        /// </summary>
        public static readonly IncrementalRunType IMMEDIATE = new IncrementalRunType("IMMEDIATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncrementalRunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncrementalRunType FindValue(string value)
        {
            return FindValue<IncrementalRunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncrementalRunType(string value)
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
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for JobStatus
        /// </summary>
        public static readonly JobStatus QUEUED = new JobStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNING = new JobStatus("RUNNING");
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
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant BATCH for JobType
        /// </summary>
        public static readonly JobType BATCH = new JobType("BATCH");
        /// <summary>
        /// Constant DELETE_ONLY for JobType
        /// </summary>
        public static readonly JobType DELETE_ONLY = new JobType("DELETE_ONLY");
        /// <summary>
        /// Constant INCREMENTAL for JobType
        /// </summary>
        public static readonly JobType INCREMENTAL = new JobType("INCREMENTAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchPurpose.
    /// </summary>
    public class MatchPurpose : ConstantClass
    {

        /// <summary>
        /// Constant IDENTIFIER_GENERATION for MatchPurpose
        /// </summary>
        public static readonly MatchPurpose IDENTIFIER_GENERATION = new MatchPurpose("IDENTIFIER_GENERATION");
        /// <summary>
        /// Constant INDEXING for MatchPurpose
        /// </summary>
        public static readonly MatchPurpose INDEXING = new MatchPurpose("INDEXING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchPurpose(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchPurpose FindValue(string value)
        {
            return FindValue<MatchPurpose>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchPurpose(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingType.
    /// </summary>
    public class ProcessingType : ConstantClass
    {

        /// <summary>
        /// Constant CONSISTENT for ProcessingType
        /// </summary>
        public static readonly ProcessingType CONSISTENT = new ProcessingType("CONSISTENT");
        /// <summary>
        /// Constant EVENTUAL for ProcessingType
        /// </summary>
        public static readonly ProcessingType EVENTUAL = new ProcessingType("EVENTUAL");
        /// <summary>
        /// Constant EVENTUAL_NO_LOOKUP for ProcessingType
        /// </summary>
        public static readonly ProcessingType EVENTUAL_NO_LOOKUP = new ProcessingType("EVENTUAL_NO_LOOKUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingType FindValue(string value)
        {
            return FindValue<ProcessingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordMatchingModel.
    /// </summary>
    public class RecordMatchingModel : ConstantClass
    {

        /// <summary>
        /// Constant MANY_SOURCE_TO_ONE_TARGET for RecordMatchingModel
        /// </summary>
        public static readonly RecordMatchingModel MANY_SOURCE_TO_ONE_TARGET = new RecordMatchingModel("MANY_SOURCE_TO_ONE_TARGET");
        /// <summary>
        /// Constant ONE_SOURCE_TO_ONE_TARGET for RecordMatchingModel
        /// </summary>
        public static readonly RecordMatchingModel ONE_SOURCE_TO_ONE_TARGET = new RecordMatchingModel("ONE_SOURCE_TO_ONE_TARGET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordMatchingModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordMatchingModel FindValue(string value)
        {
            return FindValue<RecordMatchingModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordMatchingModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolutionType.
    /// </summary>
    public class ResolutionType : ConstantClass
    {

        /// <summary>
        /// Constant ML_MATCHING for ResolutionType
        /// </summary>
        public static readonly ResolutionType ML_MATCHING = new ResolutionType("ML_MATCHING");
        /// <summary>
        /// Constant PROVIDER for ResolutionType
        /// </summary>
        public static readonly ResolutionType PROVIDER = new ResolutionType("PROVIDER");
        /// <summary>
        /// Constant RULE_MATCHING for ResolutionType
        /// </summary>
        public static readonly ResolutionType RULE_MATCHING = new ResolutionType("RULE_MATCHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolutionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolutionType FindValue(string value)
        {
            return FindValue<ResolutionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolutionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaAttributeType.
    /// </summary>
    public class SchemaAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant ADDRESS for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS = new SchemaAttributeType("ADDRESS");
        /// <summary>
        /// Constant ADDRESS_CITY for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS_CITY = new SchemaAttributeType("ADDRESS_CITY");
        /// <summary>
        /// Constant ADDRESS_COUNTRY for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS_COUNTRY = new SchemaAttributeType("ADDRESS_COUNTRY");
        /// <summary>
        /// Constant ADDRESS_POSTALCODE for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS_POSTALCODE = new SchemaAttributeType("ADDRESS_POSTALCODE");
        /// <summary>
        /// Constant ADDRESS_STATE for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS_STATE = new SchemaAttributeType("ADDRESS_STATE");
        /// <summary>
        /// Constant ADDRESS_STREET1 for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS_STREET1 = new SchemaAttributeType("ADDRESS_STREET1");
        /// <summary>
        /// Constant ADDRESS_STREET2 for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS_STREET2 = new SchemaAttributeType("ADDRESS_STREET2");
        /// <summary>
        /// Constant ADDRESS_STREET3 for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType ADDRESS_STREET3 = new SchemaAttributeType("ADDRESS_STREET3");
        /// <summary>
        /// Constant DATE for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType DATE = new SchemaAttributeType("DATE");
        /// <summary>
        /// Constant EMAIL_ADDRESS for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType EMAIL_ADDRESS = new SchemaAttributeType("EMAIL_ADDRESS");
        /// <summary>
        /// Constant IPV4 for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType IPV4 = new SchemaAttributeType("IPV4");
        /// <summary>
        /// Constant IPV6 for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType IPV6 = new SchemaAttributeType("IPV6");
        /// <summary>
        /// Constant MAID for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType MAID = new SchemaAttributeType("MAID");
        /// <summary>
        /// Constant NAME for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType NAME = new SchemaAttributeType("NAME");
        /// <summary>
        /// Constant NAME_FIRST for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType NAME_FIRST = new SchemaAttributeType("NAME_FIRST");
        /// <summary>
        /// Constant NAME_LAST for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType NAME_LAST = new SchemaAttributeType("NAME_LAST");
        /// <summary>
        /// Constant NAME_MIDDLE for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType NAME_MIDDLE = new SchemaAttributeType("NAME_MIDDLE");
        /// <summary>
        /// Constant PHONE for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType PHONE = new SchemaAttributeType("PHONE");
        /// <summary>
        /// Constant PHONE_COUNTRYCODE for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType PHONE_COUNTRYCODE = new SchemaAttributeType("PHONE_COUNTRYCODE");
        /// <summary>
        /// Constant PHONE_NUMBER for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType PHONE_NUMBER = new SchemaAttributeType("PHONE_NUMBER");
        /// <summary>
        /// Constant PROVIDER_ID for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType PROVIDER_ID = new SchemaAttributeType("PROVIDER_ID");
        /// <summary>
        /// Constant STRING for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType STRING = new SchemaAttributeType("STRING");
        /// <summary>
        /// Constant UNIQUE_ID for SchemaAttributeType
        /// </summary>
        public static readonly SchemaAttributeType UNIQUE_ID = new SchemaAttributeType("UNIQUE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaAttributeType FindValue(string value)
        {
            return FindValue<SchemaAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceType.
    /// </summary>
    public class ServiceType : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGNMENT for ServiceType
        /// </summary>
        public static readonly ServiceType ASSIGNMENT = new ServiceType("ASSIGNMENT");
        /// <summary>
        /// Constant ID_MAPPING for ServiceType
        /// </summary>
        public static readonly ServiceType ID_MAPPING = new ServiceType("ID_MAPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceType FindValue(string value)
        {
            return FindValue<ServiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatementEffect.
    /// </summary>
    public class StatementEffect : ConstantClass
    {

        /// <summary>
        /// Constant Allow for StatementEffect
        /// </summary>
        public static readonly StatementEffect Allow = new StatementEffect("Allow");
        /// <summary>
        /// Constant Deny for StatementEffect
        /// </summary>
        public static readonly StatementEffect Deny = new StatementEffect("Deny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatementEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatementEffect FindValue(string value)
        {
            return FindValue<StatementEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatementEffect(string value)
        {
            return FindValue(value);
        }
    }

}