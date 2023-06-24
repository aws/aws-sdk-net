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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ComprehendMedical
{

    /// <summary>
    /// Constants used for properties of type AttributeName.
    /// </summary>
    public class AttributeName : ConstantClass
    {

        /// <summary>
        /// Constant DIAGNOSIS for AttributeName
        /// </summary>
        public static readonly AttributeName DIAGNOSIS = new AttributeName("DIAGNOSIS");
        /// <summary>
        /// Constant FUTURE for AttributeName
        /// </summary>
        public static readonly AttributeName FUTURE = new AttributeName("FUTURE");
        /// <summary>
        /// Constant HYPOTHETICAL for AttributeName
        /// </summary>
        public static readonly AttributeName HYPOTHETICAL = new AttributeName("HYPOTHETICAL");
        /// <summary>
        /// Constant LOW_CONFIDENCE for AttributeName
        /// </summary>
        public static readonly AttributeName LOW_CONFIDENCE = new AttributeName("LOW_CONFIDENCE");
        /// <summary>
        /// Constant NEGATION for AttributeName
        /// </summary>
        public static readonly AttributeName NEGATION = new AttributeName("NEGATION");
        /// <summary>
        /// Constant PAST_HISTORY for AttributeName
        /// </summary>
        public static readonly AttributeName PAST_HISTORY = new AttributeName("PAST_HISTORY");
        /// <summary>
        /// Constant PERTAINS_TO_FAMILY for AttributeName
        /// </summary>
        public static readonly AttributeName PERTAINS_TO_FAMILY = new AttributeName("PERTAINS_TO_FAMILY");
        /// <summary>
        /// Constant SIGN for AttributeName
        /// </summary>
        public static readonly AttributeName SIGN = new AttributeName("SIGN");
        /// <summary>
        /// Constant SYMPTOM for AttributeName
        /// </summary>
        public static readonly AttributeName SYMPTOM = new AttributeName("SYMPTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeName FindValue(string value)
        {
            return FindValue<AttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntitySubType.
    /// </summary>
    public class EntitySubType : ConstantClass
    {

        /// <summary>
        /// Constant ACUITY for EntitySubType
        /// </summary>
        public static readonly EntitySubType ACUITY = new EntitySubType("ACUITY");
        /// <summary>
        /// Constant ADDRESS for EntitySubType
        /// </summary>
        public static readonly EntitySubType ADDRESS = new EntitySubType("ADDRESS");
        /// <summary>
        /// Constant AGE for EntitySubType
        /// </summary>
        public static readonly EntitySubType AGE = new EntitySubType("AGE");
        /// <summary>
        /// Constant ALCOHOL_CONSUMPTION for EntitySubType
        /// </summary>
        public static readonly EntitySubType ALCOHOL_CONSUMPTION = new EntitySubType("ALCOHOL_CONSUMPTION");
        /// <summary>
        /// Constant ALLERGIES for EntitySubType
        /// </summary>
        public static readonly EntitySubType ALLERGIES = new EntitySubType("ALLERGIES");
        /// <summary>
        /// Constant AMOUNT for EntitySubType
        /// </summary>
        public static readonly EntitySubType AMOUNT = new EntitySubType("AMOUNT");
        /// <summary>
        /// Constant BRAND_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType BRAND_NAME = new EntitySubType("BRAND_NAME");
        /// <summary>
        /// Constant CONTACT_POINT for EntitySubType
        /// </summary>
        public static readonly EntitySubType CONTACT_POINT = new EntitySubType("CONTACT_POINT");
        /// <summary>
        /// Constant DATE for EntitySubType
        /// </summary>
        public static readonly EntitySubType DATE = new EntitySubType("DATE");
        /// <summary>
        /// Constant DIRECTION for EntitySubType
        /// </summary>
        public static readonly EntitySubType DIRECTION = new EntitySubType("DIRECTION");
        /// <summary>
        /// Constant DOSAGE for EntitySubType
        /// </summary>
        public static readonly EntitySubType DOSAGE = new EntitySubType("DOSAGE");
        /// <summary>
        /// Constant DURATION for EntitySubType
        /// </summary>
        public static readonly EntitySubType DURATION = new EntitySubType("DURATION");
        /// <summary>
        /// Constant DX_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType DX_NAME = new EntitySubType("DX_NAME");
        /// <summary>
        /// Constant EMAIL for EntitySubType
        /// </summary>
        public static readonly EntitySubType EMAIL = new EntitySubType("EMAIL");
        /// <summary>
        /// Constant FORM for EntitySubType
        /// </summary>
        public static readonly EntitySubType FORM = new EntitySubType("FORM");
        /// <summary>
        /// Constant FREQUENCY for EntitySubType
        /// </summary>
        public static readonly EntitySubType FREQUENCY = new EntitySubType("FREQUENCY");
        /// <summary>
        /// Constant GENDER for EntitySubType
        /// </summary>
        public static readonly EntitySubType GENDER = new EntitySubType("GENDER");
        /// <summary>
        /// Constant GENERIC_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType GENERIC_NAME = new EntitySubType("GENERIC_NAME");
        /// <summary>
        /// Constant ID for EntitySubType
        /// </summary>
        public static readonly EntitySubType ID = new EntitySubType("ID");
        /// <summary>
        /// Constant IDENTIFIER for EntitySubType
        /// </summary>
        public static readonly EntitySubType IDENTIFIER = new EntitySubType("IDENTIFIER");
        /// <summary>
        /// Constant NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType NAME = new EntitySubType("NAME");
        /// <summary>
        /// Constant PHONE_OR_FAX for EntitySubType
        /// </summary>
        public static readonly EntitySubType PHONE_OR_FAX = new EntitySubType("PHONE_OR_FAX");
        /// <summary>
        /// Constant PROCEDURE_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType PROCEDURE_NAME = new EntitySubType("PROCEDURE_NAME");
        /// <summary>
        /// Constant PROFESSION for EntitySubType
        /// </summary>
        public static readonly EntitySubType PROFESSION = new EntitySubType("PROFESSION");
        /// <summary>
        /// Constant QUALITY for EntitySubType
        /// </summary>
        public static readonly EntitySubType QUALITY = new EntitySubType("QUALITY");
        /// <summary>
        /// Constant QUANTITY for EntitySubType
        /// </summary>
        public static readonly EntitySubType QUANTITY = new EntitySubType("QUANTITY");
        /// <summary>
        /// Constant RACE_ETHNICITY for EntitySubType
        /// </summary>
        public static readonly EntitySubType RACE_ETHNICITY = new EntitySubType("RACE_ETHNICITY");
        /// <summary>
        /// Constant RATE for EntitySubType
        /// </summary>
        public static readonly EntitySubType RATE = new EntitySubType("RATE");
        /// <summary>
        /// Constant REC_DRUG_USE for EntitySubType
        /// </summary>
        public static readonly EntitySubType REC_DRUG_USE = new EntitySubType("REC_DRUG_USE");
        /// <summary>
        /// Constant ROUTE_OR_MODE for EntitySubType
        /// </summary>
        public static readonly EntitySubType ROUTE_OR_MODE = new EntitySubType("ROUTE_OR_MODE");
        /// <summary>
        /// Constant STRENGTH for EntitySubType
        /// </summary>
        public static readonly EntitySubType STRENGTH = new EntitySubType("STRENGTH");
        /// <summary>
        /// Constant SYSTEM_ORGAN_SITE for EntitySubType
        /// </summary>
        public static readonly EntitySubType SYSTEM_ORGAN_SITE = new EntitySubType("SYSTEM_ORGAN_SITE");
        /// <summary>
        /// Constant TEST_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType TEST_NAME = new EntitySubType("TEST_NAME");
        /// <summary>
        /// Constant TEST_UNIT for EntitySubType
        /// </summary>
        public static readonly EntitySubType TEST_UNIT = new EntitySubType("TEST_UNIT");
        /// <summary>
        /// Constant TEST_UNITS for EntitySubType
        /// </summary>
        public static readonly EntitySubType TEST_UNITS = new EntitySubType("TEST_UNITS");
        /// <summary>
        /// Constant TEST_VALUE for EntitySubType
        /// </summary>
        public static readonly EntitySubType TEST_VALUE = new EntitySubType("TEST_VALUE");
        /// <summary>
        /// Constant TIME_EXPRESSION for EntitySubType
        /// </summary>
        public static readonly EntitySubType TIME_EXPRESSION = new EntitySubType("TIME_EXPRESSION");
        /// <summary>
        /// Constant TIME_TO_DX_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType TIME_TO_DX_NAME = new EntitySubType("TIME_TO_DX_NAME");
        /// <summary>
        /// Constant TIME_TO_MEDICATION_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType TIME_TO_MEDICATION_NAME = new EntitySubType("TIME_TO_MEDICATION_NAME");
        /// <summary>
        /// Constant TIME_TO_PROCEDURE_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType TIME_TO_PROCEDURE_NAME = new EntitySubType("TIME_TO_PROCEDURE_NAME");
        /// <summary>
        /// Constant TIME_TO_TEST_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType TIME_TO_TEST_NAME = new EntitySubType("TIME_TO_TEST_NAME");
        /// <summary>
        /// Constant TIME_TO_TREATMENT_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType TIME_TO_TREATMENT_NAME = new EntitySubType("TIME_TO_TREATMENT_NAME");
        /// <summary>
        /// Constant TOBACCO_USE for EntitySubType
        /// </summary>
        public static readonly EntitySubType TOBACCO_USE = new EntitySubType("TOBACCO_USE");
        /// <summary>
        /// Constant TREATMENT_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType TREATMENT_NAME = new EntitySubType("TREATMENT_NAME");
        /// <summary>
        /// Constant URL for EntitySubType
        /// </summary>
        public static readonly EntitySubType URL = new EntitySubType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntitySubType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntitySubType FindValue(string value)
        {
            return FindValue<EntitySubType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntitySubType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant ANATOMY for EntityType
        /// </summary>
        public static readonly EntityType ANATOMY = new EntityType("ANATOMY");
        /// <summary>
        /// Constant BEHAVIORAL_ENVIRONMENTAL_SOCIAL for EntityType
        /// </summary>
        public static readonly EntityType BEHAVIORAL_ENVIRONMENTAL_SOCIAL = new EntityType("BEHAVIORAL_ENVIRONMENTAL_SOCIAL");
        /// <summary>
        /// Constant MEDICAL_CONDITION for EntityType
        /// </summary>
        public static readonly EntityType MEDICAL_CONDITION = new EntityType("MEDICAL_CONDITION");
        /// <summary>
        /// Constant MEDICATION for EntityType
        /// </summary>
        public static readonly EntityType MEDICATION = new EntityType("MEDICATION");
        /// <summary>
        /// Constant PROTECTED_HEALTH_INFORMATION for EntityType
        /// </summary>
        public static readonly EntityType PROTECTED_HEALTH_INFORMATION = new EntityType("PROTECTED_HEALTH_INFORMATION");
        /// <summary>
        /// Constant TEST_TREATMENT_PROCEDURE for EntityType
        /// </summary>
        public static readonly EntityType TEST_TREATMENT_PROCEDURE = new EntityType("TEST_TREATMENT_PROCEDURE");
        /// <summary>
        /// Constant TIME_EXPRESSION for EntityType
        /// </summary>
        public static readonly EntityType TIME_EXPRESSION = new EntityType("TIME_EXPRESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ICD10CMAttributeType.
    /// </summary>
    public class ICD10CMAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant ACUITY for ICD10CMAttributeType
        /// </summary>
        public static readonly ICD10CMAttributeType ACUITY = new ICD10CMAttributeType("ACUITY");
        /// <summary>
        /// Constant DIRECTION for ICD10CMAttributeType
        /// </summary>
        public static readonly ICD10CMAttributeType DIRECTION = new ICD10CMAttributeType("DIRECTION");
        /// <summary>
        /// Constant QUALITY for ICD10CMAttributeType
        /// </summary>
        public static readonly ICD10CMAttributeType QUALITY = new ICD10CMAttributeType("QUALITY");
        /// <summary>
        /// Constant QUANTITY for ICD10CMAttributeType
        /// </summary>
        public static readonly ICD10CMAttributeType QUANTITY = new ICD10CMAttributeType("QUANTITY");
        /// <summary>
        /// Constant SYSTEM_ORGAN_SITE for ICD10CMAttributeType
        /// </summary>
        public static readonly ICD10CMAttributeType SYSTEM_ORGAN_SITE = new ICD10CMAttributeType("SYSTEM_ORGAN_SITE");
        /// <summary>
        /// Constant TIME_EXPRESSION for ICD10CMAttributeType
        /// </summary>
        public static readonly ICD10CMAttributeType TIME_EXPRESSION = new ICD10CMAttributeType("TIME_EXPRESSION");
        /// <summary>
        /// Constant TIME_TO_DX_NAME for ICD10CMAttributeType
        /// </summary>
        public static readonly ICD10CMAttributeType TIME_TO_DX_NAME = new ICD10CMAttributeType("TIME_TO_DX_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ICD10CMAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ICD10CMAttributeType FindValue(string value)
        {
            return FindValue<ICD10CMAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ICD10CMAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ICD10CMEntityCategory.
    /// </summary>
    public class ICD10CMEntityCategory : ConstantClass
    {

        /// <summary>
        /// Constant MEDICAL_CONDITION for ICD10CMEntityCategory
        /// </summary>
        public static readonly ICD10CMEntityCategory MEDICAL_CONDITION = new ICD10CMEntityCategory("MEDICAL_CONDITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ICD10CMEntityCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ICD10CMEntityCategory FindValue(string value)
        {
            return FindValue<ICD10CMEntityCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ICD10CMEntityCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ICD10CMEntityType.
    /// </summary>
    public class ICD10CMEntityType : ConstantClass
    {

        /// <summary>
        /// Constant DX_NAME for ICD10CMEntityType
        /// </summary>
        public static readonly ICD10CMEntityType DX_NAME = new ICD10CMEntityType("DX_NAME");
        /// <summary>
        /// Constant TIME_EXPRESSION for ICD10CMEntityType
        /// </summary>
        public static readonly ICD10CMEntityType TIME_EXPRESSION = new ICD10CMEntityType("TIME_EXPRESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ICD10CMEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ICD10CMEntityType FindValue(string value)
        {
            return FindValue<ICD10CMEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ICD10CMEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ICD10CMRelationshipType.
    /// </summary>
    public class ICD10CMRelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant OVERLAP for ICD10CMRelationshipType
        /// </summary>
        public static readonly ICD10CMRelationshipType OVERLAP = new ICD10CMRelationshipType("OVERLAP");
        /// <summary>
        /// Constant QUALITY for ICD10CMRelationshipType
        /// </summary>
        public static readonly ICD10CMRelationshipType QUALITY = new ICD10CMRelationshipType("QUALITY");
        /// <summary>
        /// Constant SYSTEM_ORGAN_SITE for ICD10CMRelationshipType
        /// </summary>
        public static readonly ICD10CMRelationshipType SYSTEM_ORGAN_SITE = new ICD10CMRelationshipType("SYSTEM_ORGAN_SITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ICD10CMRelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ICD10CMRelationshipType FindValue(string value)
        {
            return FindValue<ICD10CMRelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ICD10CMRelationshipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ICD10CMTraitName.
    /// </summary>
    public class ICD10CMTraitName : ConstantClass
    {

        /// <summary>
        /// Constant DIAGNOSIS for ICD10CMTraitName
        /// </summary>
        public static readonly ICD10CMTraitName DIAGNOSIS = new ICD10CMTraitName("DIAGNOSIS");
        /// <summary>
        /// Constant HYPOTHETICAL for ICD10CMTraitName
        /// </summary>
        public static readonly ICD10CMTraitName HYPOTHETICAL = new ICD10CMTraitName("HYPOTHETICAL");
        /// <summary>
        /// Constant LOW_CONFIDENCE for ICD10CMTraitName
        /// </summary>
        public static readonly ICD10CMTraitName LOW_CONFIDENCE = new ICD10CMTraitName("LOW_CONFIDENCE");
        /// <summary>
        /// Constant NEGATION for ICD10CMTraitName
        /// </summary>
        public static readonly ICD10CMTraitName NEGATION = new ICD10CMTraitName("NEGATION");
        /// <summary>
        /// Constant PERTAINS_TO_FAMILY for ICD10CMTraitName
        /// </summary>
        public static readonly ICD10CMTraitName PERTAINS_TO_FAMILY = new ICD10CMTraitName("PERTAINS_TO_FAMILY");
        /// <summary>
        /// Constant SIGN for ICD10CMTraitName
        /// </summary>
        public static readonly ICD10CMTraitName SIGN = new ICD10CMTraitName("SIGN");
        /// <summary>
        /// Constant SYMPTOM for ICD10CMTraitName
        /// </summary>
        public static readonly ICD10CMTraitName SYMPTOM = new ICD10CMTraitName("SYMPTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ICD10CMTraitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ICD10CMTraitName FindValue(string value)
        {
            return FindValue<ICD10CMTraitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ICD10CMTraitName(string value)
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
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PARTIAL_SUCCESS for JobStatus
        /// </summary>
        public static readonly JobStatus PARTIAL_SUCCESS = new JobStatus("PARTIAL_SUCCESS");
        /// <summary>
        /// Constant STOP_REQUESTED for JobStatus
        /// </summary>
        public static readonly JobStatus STOP_REQUESTED = new JobStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant STOPPED for JobStatus
        /// </summary>
        public static readonly JobStatus STOPPED = new JobStatus("STOPPED");
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
    /// Constants used for properties of type LanguageCode.
    /// </summary>
    public class LanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant En for LanguageCode
        /// </summary>
        public static readonly LanguageCode En = new LanguageCode("en");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCode FindValue(string value)
        {
            return FindValue<LanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelationshipType.
    /// </summary>
    public class RelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant ACUITY for RelationshipType
        /// </summary>
        public static readonly RelationshipType ACUITY = new RelationshipType("ACUITY");
        /// <summary>
        /// Constant ADMINISTERED_VIA for RelationshipType
        /// </summary>
        public static readonly RelationshipType ADMINISTERED_VIA = new RelationshipType("ADMINISTERED_VIA");
        /// <summary>
        /// Constant AMOUNT for RelationshipType
        /// </summary>
        public static readonly RelationshipType AMOUNT = new RelationshipType("AMOUNT");
        /// <summary>
        /// Constant DIRECTION for RelationshipType
        /// </summary>
        public static readonly RelationshipType DIRECTION = new RelationshipType("DIRECTION");
        /// <summary>
        /// Constant DOSAGE for RelationshipType
        /// </summary>
        public static readonly RelationshipType DOSAGE = new RelationshipType("DOSAGE");
        /// <summary>
        /// Constant DURATION for RelationshipType
        /// </summary>
        public static readonly RelationshipType DURATION = new RelationshipType("DURATION");
        /// <summary>
        /// Constant EVERY for RelationshipType
        /// </summary>
        public static readonly RelationshipType EVERY = new RelationshipType("EVERY");
        /// <summary>
        /// Constant FOR for RelationshipType
        /// </summary>
        public static readonly RelationshipType FOR = new RelationshipType("FOR");
        /// <summary>
        /// Constant FORM for RelationshipType
        /// </summary>
        public static readonly RelationshipType FORM = new RelationshipType("FORM");
        /// <summary>
        /// Constant FREQUENCY for RelationshipType
        /// </summary>
        public static readonly RelationshipType FREQUENCY = new RelationshipType("FREQUENCY");
        /// <summary>
        /// Constant NEGATIVE for RelationshipType
        /// </summary>
        public static readonly RelationshipType NEGATIVE = new RelationshipType("NEGATIVE");
        /// <summary>
        /// Constant OVERLAP for RelationshipType
        /// </summary>
        public static readonly RelationshipType OVERLAP = new RelationshipType("OVERLAP");
        /// <summary>
        /// Constant QUALITY for RelationshipType
        /// </summary>
        public static readonly RelationshipType QUALITY = new RelationshipType("QUALITY");
        /// <summary>
        /// Constant RATE for RelationshipType
        /// </summary>
        public static readonly RelationshipType RATE = new RelationshipType("RATE");
        /// <summary>
        /// Constant ROUTE_OR_MODE for RelationshipType
        /// </summary>
        public static readonly RelationshipType ROUTE_OR_MODE = new RelationshipType("ROUTE_OR_MODE");
        /// <summary>
        /// Constant STRENGTH for RelationshipType
        /// </summary>
        public static readonly RelationshipType STRENGTH = new RelationshipType("STRENGTH");
        /// <summary>
        /// Constant SYSTEM_ORGAN_SITE for RelationshipType
        /// </summary>
        public static readonly RelationshipType SYSTEM_ORGAN_SITE = new RelationshipType("SYSTEM_ORGAN_SITE");
        /// <summary>
        /// Constant TEST_UNIT for RelationshipType
        /// </summary>
        public static readonly RelationshipType TEST_UNIT = new RelationshipType("TEST_UNIT");
        /// <summary>
        /// Constant TEST_UNITS for RelationshipType
        /// </summary>
        public static readonly RelationshipType TEST_UNITS = new RelationshipType("TEST_UNITS");
        /// <summary>
        /// Constant TEST_VALUE for RelationshipType
        /// </summary>
        public static readonly RelationshipType TEST_VALUE = new RelationshipType("TEST_VALUE");
        /// <summary>
        /// Constant USAGE for RelationshipType
        /// </summary>
        public static readonly RelationshipType USAGE = new RelationshipType("USAGE");
        /// <summary>
        /// Constant WITH_DOSAGE for RelationshipType
        /// </summary>
        public static readonly RelationshipType WITH_DOSAGE = new RelationshipType("WITH_DOSAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationshipType FindValue(string value)
        {
            return FindValue<RelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationshipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RxNormAttributeType.
    /// </summary>
    public class RxNormAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant DOSAGE for RxNormAttributeType
        /// </summary>
        public static readonly RxNormAttributeType DOSAGE = new RxNormAttributeType("DOSAGE");
        /// <summary>
        /// Constant DURATION for RxNormAttributeType
        /// </summary>
        public static readonly RxNormAttributeType DURATION = new RxNormAttributeType("DURATION");
        /// <summary>
        /// Constant FORM for RxNormAttributeType
        /// </summary>
        public static readonly RxNormAttributeType FORM = new RxNormAttributeType("FORM");
        /// <summary>
        /// Constant FREQUENCY for RxNormAttributeType
        /// </summary>
        public static readonly RxNormAttributeType FREQUENCY = new RxNormAttributeType("FREQUENCY");
        /// <summary>
        /// Constant RATE for RxNormAttributeType
        /// </summary>
        public static readonly RxNormAttributeType RATE = new RxNormAttributeType("RATE");
        /// <summary>
        /// Constant ROUTE_OR_MODE for RxNormAttributeType
        /// </summary>
        public static readonly RxNormAttributeType ROUTE_OR_MODE = new RxNormAttributeType("ROUTE_OR_MODE");
        /// <summary>
        /// Constant STRENGTH for RxNormAttributeType
        /// </summary>
        public static readonly RxNormAttributeType STRENGTH = new RxNormAttributeType("STRENGTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RxNormAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RxNormAttributeType FindValue(string value)
        {
            return FindValue<RxNormAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RxNormAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RxNormEntityCategory.
    /// </summary>
    public class RxNormEntityCategory : ConstantClass
    {

        /// <summary>
        /// Constant MEDICATION for RxNormEntityCategory
        /// </summary>
        public static readonly RxNormEntityCategory MEDICATION = new RxNormEntityCategory("MEDICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RxNormEntityCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RxNormEntityCategory FindValue(string value)
        {
            return FindValue<RxNormEntityCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RxNormEntityCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RxNormEntityType.
    /// </summary>
    public class RxNormEntityType : ConstantClass
    {

        /// <summary>
        /// Constant BRAND_NAME for RxNormEntityType
        /// </summary>
        public static readonly RxNormEntityType BRAND_NAME = new RxNormEntityType("BRAND_NAME");
        /// <summary>
        /// Constant GENERIC_NAME for RxNormEntityType
        /// </summary>
        public static readonly RxNormEntityType GENERIC_NAME = new RxNormEntityType("GENERIC_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RxNormEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RxNormEntityType FindValue(string value)
        {
            return FindValue<RxNormEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RxNormEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RxNormTraitName.
    /// </summary>
    public class RxNormTraitName : ConstantClass
    {

        /// <summary>
        /// Constant NEGATION for RxNormTraitName
        /// </summary>
        public static readonly RxNormTraitName NEGATION = new RxNormTraitName("NEGATION");
        /// <summary>
        /// Constant PAST_HISTORY for RxNormTraitName
        /// </summary>
        public static readonly RxNormTraitName PAST_HISTORY = new RxNormTraitName("PAST_HISTORY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RxNormTraitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RxNormTraitName FindValue(string value)
        {
            return FindValue<RxNormTraitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RxNormTraitName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SNOMEDCTAttributeType.
    /// </summary>
    public class SNOMEDCTAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant ACUITY for SNOMEDCTAttributeType
        /// </summary>
        public static readonly SNOMEDCTAttributeType ACUITY = new SNOMEDCTAttributeType("ACUITY");
        /// <summary>
        /// Constant DIRECTION for SNOMEDCTAttributeType
        /// </summary>
        public static readonly SNOMEDCTAttributeType DIRECTION = new SNOMEDCTAttributeType("DIRECTION");
        /// <summary>
        /// Constant QUALITY for SNOMEDCTAttributeType
        /// </summary>
        public static readonly SNOMEDCTAttributeType QUALITY = new SNOMEDCTAttributeType("QUALITY");
        /// <summary>
        /// Constant SYSTEM_ORGAN_SITE for SNOMEDCTAttributeType
        /// </summary>
        public static readonly SNOMEDCTAttributeType SYSTEM_ORGAN_SITE = new SNOMEDCTAttributeType("SYSTEM_ORGAN_SITE");
        /// <summary>
        /// Constant TEST_UNIT for SNOMEDCTAttributeType
        /// </summary>
        public static readonly SNOMEDCTAttributeType TEST_UNIT = new SNOMEDCTAttributeType("TEST_UNIT");
        /// <summary>
        /// Constant TEST_VALUE for SNOMEDCTAttributeType
        /// </summary>
        public static readonly SNOMEDCTAttributeType TEST_VALUE = new SNOMEDCTAttributeType("TEST_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SNOMEDCTAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SNOMEDCTAttributeType FindValue(string value)
        {
            return FindValue<SNOMEDCTAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SNOMEDCTAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SNOMEDCTEntityCategory.
    /// </summary>
    public class SNOMEDCTEntityCategory : ConstantClass
    {

        /// <summary>
        /// Constant ANATOMY for SNOMEDCTEntityCategory
        /// </summary>
        public static readonly SNOMEDCTEntityCategory ANATOMY = new SNOMEDCTEntityCategory("ANATOMY");
        /// <summary>
        /// Constant MEDICAL_CONDITION for SNOMEDCTEntityCategory
        /// </summary>
        public static readonly SNOMEDCTEntityCategory MEDICAL_CONDITION = new SNOMEDCTEntityCategory("MEDICAL_CONDITION");
        /// <summary>
        /// Constant TEST_TREATMENT_PROCEDURE for SNOMEDCTEntityCategory
        /// </summary>
        public static readonly SNOMEDCTEntityCategory TEST_TREATMENT_PROCEDURE = new SNOMEDCTEntityCategory("TEST_TREATMENT_PROCEDURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SNOMEDCTEntityCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SNOMEDCTEntityCategory FindValue(string value)
        {
            return FindValue<SNOMEDCTEntityCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SNOMEDCTEntityCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SNOMEDCTEntityType.
    /// </summary>
    public class SNOMEDCTEntityType : ConstantClass
    {

        /// <summary>
        /// Constant DX_NAME for SNOMEDCTEntityType
        /// </summary>
        public static readonly SNOMEDCTEntityType DX_NAME = new SNOMEDCTEntityType("DX_NAME");
        /// <summary>
        /// Constant PROCEDURE_NAME for SNOMEDCTEntityType
        /// </summary>
        public static readonly SNOMEDCTEntityType PROCEDURE_NAME = new SNOMEDCTEntityType("PROCEDURE_NAME");
        /// <summary>
        /// Constant TEST_NAME for SNOMEDCTEntityType
        /// </summary>
        public static readonly SNOMEDCTEntityType TEST_NAME = new SNOMEDCTEntityType("TEST_NAME");
        /// <summary>
        /// Constant TREATMENT_NAME for SNOMEDCTEntityType
        /// </summary>
        public static readonly SNOMEDCTEntityType TREATMENT_NAME = new SNOMEDCTEntityType("TREATMENT_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SNOMEDCTEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SNOMEDCTEntityType FindValue(string value)
        {
            return FindValue<SNOMEDCTEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SNOMEDCTEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SNOMEDCTRelationshipType.
    /// </summary>
    public class SNOMEDCTRelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant ACUITY for SNOMEDCTRelationshipType
        /// </summary>
        public static readonly SNOMEDCTRelationshipType ACUITY = new SNOMEDCTRelationshipType("ACUITY");
        /// <summary>
        /// Constant DIRECTION for SNOMEDCTRelationshipType
        /// </summary>
        public static readonly SNOMEDCTRelationshipType DIRECTION = new SNOMEDCTRelationshipType("DIRECTION");
        /// <summary>
        /// Constant QUALITY for SNOMEDCTRelationshipType
        /// </summary>
        public static readonly SNOMEDCTRelationshipType QUALITY = new SNOMEDCTRelationshipType("QUALITY");
        /// <summary>
        /// Constant SYSTEM_ORGAN_SITE for SNOMEDCTRelationshipType
        /// </summary>
        public static readonly SNOMEDCTRelationshipType SYSTEM_ORGAN_SITE = new SNOMEDCTRelationshipType("SYSTEM_ORGAN_SITE");
        /// <summary>
        /// Constant TEST_UNIT for SNOMEDCTRelationshipType
        /// </summary>
        public static readonly SNOMEDCTRelationshipType TEST_UNIT = new SNOMEDCTRelationshipType("TEST_UNIT");
        /// <summary>
        /// Constant TEST_UNITS for SNOMEDCTRelationshipType
        /// </summary>
        public static readonly SNOMEDCTRelationshipType TEST_UNITS = new SNOMEDCTRelationshipType("TEST_UNITS");
        /// <summary>
        /// Constant TEST_VALUE for SNOMEDCTRelationshipType
        /// </summary>
        public static readonly SNOMEDCTRelationshipType TEST_VALUE = new SNOMEDCTRelationshipType("TEST_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SNOMEDCTRelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SNOMEDCTRelationshipType FindValue(string value)
        {
            return FindValue<SNOMEDCTRelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SNOMEDCTRelationshipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SNOMEDCTTraitName.
    /// </summary>
    public class SNOMEDCTTraitName : ConstantClass
    {

        /// <summary>
        /// Constant DIAGNOSIS for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName DIAGNOSIS = new SNOMEDCTTraitName("DIAGNOSIS");
        /// <summary>
        /// Constant FUTURE for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName FUTURE = new SNOMEDCTTraitName("FUTURE");
        /// <summary>
        /// Constant HYPOTHETICAL for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName HYPOTHETICAL = new SNOMEDCTTraitName("HYPOTHETICAL");
        /// <summary>
        /// Constant LOW_CONFIDENCE for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName LOW_CONFIDENCE = new SNOMEDCTTraitName("LOW_CONFIDENCE");
        /// <summary>
        /// Constant NEGATION for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName NEGATION = new SNOMEDCTTraitName("NEGATION");
        /// <summary>
        /// Constant PAST_HISTORY for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName PAST_HISTORY = new SNOMEDCTTraitName("PAST_HISTORY");
        /// <summary>
        /// Constant PERTAINS_TO_FAMILY for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName PERTAINS_TO_FAMILY = new SNOMEDCTTraitName("PERTAINS_TO_FAMILY");
        /// <summary>
        /// Constant SIGN for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName SIGN = new SNOMEDCTTraitName("SIGN");
        /// <summary>
        /// Constant SYMPTOM for SNOMEDCTTraitName
        /// </summary>
        public static readonly SNOMEDCTTraitName SYMPTOM = new SNOMEDCTTraitName("SYMPTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SNOMEDCTTraitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SNOMEDCTTraitName FindValue(string value)
        {
            return FindValue<SNOMEDCTTraitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SNOMEDCTTraitName(string value)
        {
            return FindValue(value);
        }
    }

}