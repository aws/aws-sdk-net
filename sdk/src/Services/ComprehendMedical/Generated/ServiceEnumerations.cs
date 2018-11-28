/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        /// Constant NEGATION for AttributeName
        /// </summary>
        public static readonly AttributeName NEGATION = new AttributeName("NEGATION");
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
        /// Constant GENERIC_NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType GENERIC_NAME = new EntitySubType("GENERIC_NAME");
        /// <summary>
        /// Constant IDENTIFIER for EntitySubType
        /// </summary>
        public static readonly EntitySubType IDENTIFIER = new EntitySubType("IDENTIFIER");
        /// <summary>
        /// Constant NAME for EntitySubType
        /// </summary>
        public static readonly EntitySubType NAME = new EntitySubType("NAME");
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
        /// Constant RATE for EntitySubType
        /// </summary>
        public static readonly EntitySubType RATE = new EntitySubType("RATE");
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
        /// Constant TEST_UNITS for EntitySubType
        /// </summary>
        public static readonly EntitySubType TEST_UNITS = new EntitySubType("TEST_UNITS");
        /// <summary>
        /// Constant TEST_VALUE for EntitySubType
        /// </summary>
        public static readonly EntitySubType TEST_VALUE = new EntitySubType("TEST_VALUE");
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

}