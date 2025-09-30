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
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant ADDED_PROFILE_KEY for ActionType
        /// </summary>
        public static readonly ActionType ADDED_PROFILE_KEY = new ActionType("ADDED_PROFILE_KEY");
        /// <summary>
        /// Constant CREATED for ActionType
        /// </summary>
        public static readonly ActionType CREATED = new ActionType("CREATED");
        /// <summary>
        /// Constant DELETED_BY_CUSTOMER for ActionType
        /// </summary>
        public static readonly ActionType DELETED_BY_CUSTOMER = new ActionType("DELETED_BY_CUSTOMER");
        /// <summary>
        /// Constant DELETED_BY_MERGE for ActionType
        /// </summary>
        public static readonly ActionType DELETED_BY_MERGE = new ActionType("DELETED_BY_MERGE");
        /// <summary>
        /// Constant DELETED_PROFILE_KEY for ActionType
        /// </summary>
        public static readonly ActionType DELETED_PROFILE_KEY = new ActionType("DELETED_PROFILE_KEY");
        /// <summary>
        /// Constant EXPIRED for ActionType
        /// </summary>
        public static readonly ActionType EXPIRED = new ActionType("EXPIRED");
        /// <summary>
        /// Constant INGESTED for ActionType
        /// </summary>
        public static readonly ActionType INGESTED = new ActionType("INGESTED");
        /// <summary>
        /// Constant MERGED for ActionType
        /// </summary>
        public static readonly ActionType MERGED = new ActionType("MERGED");
        /// <summary>
        /// Constant UPDATED for ActionType
        /// </summary>
        public static readonly ActionType UPDATED = new ActionType("UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttributeDimensionType.
    /// </summary>
    public class AttributeDimensionType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType AFTER = new AttributeDimensionType("AFTER");
        /// <summary>
        /// Constant BEFORE for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType BEFORE = new AttributeDimensionType("BEFORE");
        /// <summary>
        /// Constant BEGINS_WITH for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType BEGINS_WITH = new AttributeDimensionType("BEGINS_WITH");
        /// <summary>
        /// Constant BETWEEN for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType BETWEEN = new AttributeDimensionType("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType CONTAINS = new AttributeDimensionType("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType ENDS_WITH = new AttributeDimensionType("ENDS_WITH");
        /// <summary>
        /// Constant EQUAL for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType EQUAL = new AttributeDimensionType("EQUAL");
        /// <summary>
        /// Constant EXCLUSIVE for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType EXCLUSIVE = new AttributeDimensionType("EXCLUSIVE");
        /// <summary>
        /// Constant GREATER_THAN for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType GREATER_THAN = new AttributeDimensionType("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType GREATER_THAN_OR_EQUAL = new AttributeDimensionType("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant INCLUSIVE for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType INCLUSIVE = new AttributeDimensionType("INCLUSIVE");
        /// <summary>
        /// Constant LESS_THAN for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType LESS_THAN = new AttributeDimensionType("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType LESS_THAN_OR_EQUAL = new AttributeDimensionType("LESS_THAN_OR_EQUAL");
        /// <summary>
        /// Constant NOT_BETWEEN for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType NOT_BETWEEN = new AttributeDimensionType("NOT_BETWEEN");
        /// <summary>
        /// Constant ON for AttributeDimensionType
        /// </summary>
        public static readonly AttributeDimensionType ON = new AttributeDimensionType("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeDimensionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeDimensionType FindValue(string value)
        {
            return FindValue<AttributeDimensionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeDimensionType(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant AFTER for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator AFTER = new ComparisonOperator("AFTER");
        /// <summary>
        /// Constant BEFORE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator BEFORE = new ComparisonOperator("BEFORE");
        /// <summary>
        /// Constant BEGINS_WITH for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator BEGINS_WITH = new ComparisonOperator("BEGINS_WITH");
        /// <summary>
        /// Constant BETWEEN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator BETWEEN = new ComparisonOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator CONTAINS = new ComparisonOperator("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator ENDS_WITH = new ComparisonOperator("ENDS_WITH");
        /// <summary>
        /// Constant EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQUAL = new ComparisonOperator("EQUAL");
        /// <summary>
        /// Constant EXCLUSIVE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EXCLUSIVE = new ComparisonOperator("EXCLUSIVE");
        /// <summary>
        /// Constant GREATER_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_THAN = new ComparisonOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_THAN_OR_EQUAL = new ComparisonOperator("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant INCLUSIVE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator INCLUSIVE = new ComparisonOperator("INCLUSIVE");
        /// <summary>
        /// Constant LESS_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_THAN = new ComparisonOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_THAN_OR_EQUAL = new ComparisonOperator("LESS_THAN_OR_EQUAL");
        /// <summary>
        /// Constant NOT_BETWEEN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NOT_BETWEEN = new ComparisonOperator("NOT_BETWEEN");
        /// <summary>
        /// Constant ON for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator ON = new ComparisonOperator("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type ContactType.
    /// </summary>
    public class ContactType : ConstantClass
    {

        /// <summary>
        /// Constant BusinessEmailAddress for ContactType
        /// </summary>
        public static readonly ContactType BusinessEmailAddress = new ContactType("BusinessEmailAddress");
        /// <summary>
        /// Constant BusinessPhoneNumber for ContactType
        /// </summary>
        public static readonly ContactType BusinessPhoneNumber = new ContactType("BusinessPhoneNumber");
        /// <summary>
        /// Constant EmailAddress for ContactType
        /// </summary>
        public static readonly ContactType EmailAddress = new ContactType("EmailAddress");
        /// <summary>
        /// Constant HomePhoneNumber for ContactType
        /// </summary>
        public static readonly ContactType HomePhoneNumber = new ContactType("HomePhoneNumber");
        /// <summary>
        /// Constant MobilePhoneNumber for ContactType
        /// </summary>
        public static readonly ContactType MobilePhoneNumber = new ContactType("MobilePhoneNumber");
        /// <summary>
        /// Constant PersonalEmailAddress for ContactType
        /// </summary>
        public static readonly ContactType PersonalEmailAddress = new ContactType("PersonalEmailAddress");
        /// <summary>
        /// Constant PhoneNumber for ContactType
        /// </summary>
        public static readonly ContactType PhoneNumber = new ContactType("PhoneNumber");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactType FindValue(string value)
        {
            return FindValue<ContactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataFormat.
    /// </summary>
    public class DataFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for DataFormat
        /// </summary>
        public static readonly DataFormat CSV = new DataFormat("CSV");
        /// <summary>
        /// Constant JSONL for DataFormat
        /// </summary>
        public static readonly DataFormat JSONL = new DataFormat("JSONL");
        /// <summary>
        /// Constant ORC for DataFormat
        /// </summary>
        public static readonly DataFormat ORC = new DataFormat("ORC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataFormat FindValue(string value)
        {
            return FindValue<DataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataFormat(string value)
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
    /// Constants used for properties of type DateDimensionType.
    /// </summary>
    public class DateDimensionType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER for DateDimensionType
        /// </summary>
        public static readonly DateDimensionType AFTER = new DateDimensionType("AFTER");
        /// <summary>
        /// Constant BEFORE for DateDimensionType
        /// </summary>
        public static readonly DateDimensionType BEFORE = new DateDimensionType("BEFORE");
        /// <summary>
        /// Constant BETWEEN for DateDimensionType
        /// </summary>
        public static readonly DateDimensionType BETWEEN = new DateDimensionType("BETWEEN");
        /// <summary>
        /// Constant NOT_BETWEEN for DateDimensionType
        /// </summary>
        public static readonly DateDimensionType NOT_BETWEEN = new DateDimensionType("NOT_BETWEEN");
        /// <summary>
        /// Constant ON for DateDimensionType
        /// </summary>
        public static readonly DateDimensionType ON = new DateDimensionType("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DateDimensionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DateDimensionType FindValue(string value)
        {
            return FindValue<DateDimensionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DateDimensionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EstimateStatus.
    /// </summary>
    public class EstimateStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for EstimateStatus
        /// </summary>
        public static readonly EstimateStatus FAILED = new EstimateStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for EstimateStatus
        /// </summary>
        public static readonly EstimateStatus RUNNING = new EstimateStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for EstimateStatus
        /// </summary>
        public static readonly EstimateStatus SUCCEEDED = new EstimateStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EstimateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EstimateStatus FindValue(string value)
        {
            return FindValue<EstimateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EstimateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventStreamDestinationStatus.
    /// </summary>
    public class EventStreamDestinationStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for EventStreamDestinationStatus
        /// </summary>
        public static readonly EventStreamDestinationStatus HEALTHY = new EventStreamDestinationStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for EventStreamDestinationStatus
        /// </summary>
        public static readonly EventStreamDestinationStatus UNHEALTHY = new EventStreamDestinationStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventStreamDestinationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventStreamDestinationStatus FindValue(string value)
        {
            return FindValue<EventStreamDestinationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventStreamDestinationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventStreamState.
    /// </summary>
    public class EventStreamState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for EventStreamState
        /// </summary>
        public static readonly EventStreamState RUNNING = new EventStreamState("RUNNING");
        /// <summary>
        /// Constant STOPPED for EventStreamState
        /// </summary>
        public static readonly EventStreamState STOPPED = new EventStreamState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventStreamState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventStreamState FindValue(string value)
        {
            return FindValue<EventStreamState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventStreamState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventTriggerLogicalOperator.
    /// </summary>
    public class EventTriggerLogicalOperator : ConstantClass
    {

        /// <summary>
        /// Constant ALL for EventTriggerLogicalOperator
        /// </summary>
        public static readonly EventTriggerLogicalOperator ALL = new EventTriggerLogicalOperator("ALL");
        /// <summary>
        /// Constant ANY for EventTriggerLogicalOperator
        /// </summary>
        public static readonly EventTriggerLogicalOperator ANY = new EventTriggerLogicalOperator("ANY");
        /// <summary>
        /// Constant NONE for EventTriggerLogicalOperator
        /// </summary>
        public static readonly EventTriggerLogicalOperator NONE = new EventTriggerLogicalOperator("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventTriggerLogicalOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventTriggerLogicalOperator FindValue(string value)
        {
            return FindValue<EventTriggerLogicalOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventTriggerLogicalOperator(string value)
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
    /// Constants used for properties of type FilterDimensionType.
    /// </summary>
    public class FilterDimensionType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType AFTER = new FilterDimensionType("AFTER");
        /// <summary>
        /// Constant BEFORE for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType BEFORE = new FilterDimensionType("BEFORE");
        /// <summary>
        /// Constant BEGINS_WITH for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType BEGINS_WITH = new FilterDimensionType("BEGINS_WITH");
        /// <summary>
        /// Constant BETWEEN for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType BETWEEN = new FilterDimensionType("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType CONTAINS = new FilterDimensionType("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType ENDS_WITH = new FilterDimensionType("ENDS_WITH");
        /// <summary>
        /// Constant EQUAL for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType EQUAL = new FilterDimensionType("EQUAL");
        /// <summary>
        /// Constant EXCLUSIVE for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType EXCLUSIVE = new FilterDimensionType("EXCLUSIVE");
        /// <summary>
        /// Constant GREATER_THAN for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType GREATER_THAN = new FilterDimensionType("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType GREATER_THAN_OR_EQUAL = new FilterDimensionType("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant INCLUSIVE for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType INCLUSIVE = new FilterDimensionType("INCLUSIVE");
        /// <summary>
        /// Constant LESS_THAN for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType LESS_THAN = new FilterDimensionType("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType LESS_THAN_OR_EQUAL = new FilterDimensionType("LESS_THAN_OR_EQUAL");
        /// <summary>
        /// Constant NOT_BETWEEN for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType NOT_BETWEEN = new FilterDimensionType("NOT_BETWEEN");
        /// <summary>
        /// Constant ON for FilterDimensionType
        /// </summary>
        public static readonly FilterDimensionType ON = new FilterDimensionType("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterDimensionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterDimensionType FindValue(string value)
        {
            return FindValue<FilterDimensionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterDimensionType(string value)
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
    /// Constants used for properties of type Include.
    /// </summary>
    public class Include : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Include
        /// </summary>
        public static readonly Include ALL = new Include("ALL");
        /// <summary>
        /// Constant ANY for Include
        /// </summary>
        public static readonly Include ANY = new Include("ANY");
        /// <summary>
        /// Constant NONE for Include
        /// </summary>
        public static readonly Include NONE = new Include("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Include(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Include FindValue(string value)
        {
            return FindValue<Include>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Include(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IncludeOptions.
    /// </summary>
    public class IncludeOptions : ConstantClass
    {

        /// <summary>
        /// Constant ALL for IncludeOptions
        /// </summary>
        public static readonly IncludeOptions ALL = new IncludeOptions("ALL");
        /// <summary>
        /// Constant ANY for IncludeOptions
        /// </summary>
        public static readonly IncludeOptions ANY = new IncludeOptions("ANY");
        /// <summary>
        /// Constant NONE for IncludeOptions
        /// </summary>
        public static readonly IncludeOptions NONE = new IncludeOptions("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncludeOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncludeOptions FindValue(string value)
        {
            return FindValue<IncludeOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncludeOptions(string value)
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
    /// Constants used for properties of type LayoutType.
    /// </summary>
    public class LayoutType : ConstantClass
    {

        /// <summary>
        /// Constant PROFILE_EXPLORER for LayoutType
        /// </summary>
        public static readonly LayoutType PROFILE_EXPLORER = new LayoutType("PROFILE_EXPLORER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayoutType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayoutType FindValue(string value)
        {
            return FindValue<LayoutType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayoutType(string value)
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
    /// Constants used for properties of type MatchType.
    /// </summary>
    public class MatchType : ConstantClass
    {

        /// <summary>
        /// Constant ML_BASED_MATCHING for MatchType
        /// </summary>
        public static readonly MatchType ML_BASED_MATCHING = new MatchType("ML_BASED_MATCHING");
        /// <summary>
        /// Constant RULE_BASED_MATCHING for MatchType
        /// </summary>
        public static readonly MatchType RULE_BASED_MATCHING = new MatchType("RULE_BASED_MATCHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchType FindValue(string value)
        {
            return FindValue<MatchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant EQUAL_TO for Operator
        /// </summary>
        public static readonly Operator EQUAL_TO = new Operator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for Operator
        /// </summary>
        public static readonly Operator GREATER_THAN = new Operator("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for Operator
        /// </summary>
        public static readonly Operator LESS_THAN = new Operator("LESS_THAN");
        /// <summary>
        /// Constant NOT_EQUAL_TO for Operator
        /// </summary>
        public static readonly Operator NOT_EQUAL_TO = new Operator("NOT_EQUAL_TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
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
    /// Constants used for properties of type PeriodUnit.
    /// </summary>
    public class PeriodUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit DAYS = new PeriodUnit("DAYS");
        /// <summary>
        /// Constant HOURS for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit HOURS = new PeriodUnit("HOURS");
        /// <summary>
        /// Constant MONTHS for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit MONTHS = new PeriodUnit("MONTHS");
        /// <summary>
        /// Constant WEEKS for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit WEEKS = new PeriodUnit("WEEKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PeriodUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeriodUnit FindValue(string value)
        {
            return FindValue<PeriodUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeriodUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileType.
    /// </summary>
    public class ProfileType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_PROFILE for ProfileType
        /// </summary>
        public static readonly ProfileType ACCOUNT_PROFILE = new ProfileType("ACCOUNT_PROFILE");
        /// <summary>
        /// Constant PROFILE for ProfileType
        /// </summary>
        public static readonly ProfileType PROFILE = new ProfileType("PROFILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileType FindValue(string value)
        {
            return FindValue<ProfileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileTypeDimensionType.
    /// </summary>
    public class ProfileTypeDimensionType : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUSIVE for ProfileTypeDimensionType
        /// </summary>
        public static readonly ProfileTypeDimensionType EXCLUSIVE = new ProfileTypeDimensionType("EXCLUSIVE");
        /// <summary>
        /// Constant INCLUSIVE for ProfileTypeDimensionType
        /// </summary>
        public static readonly ProfileTypeDimensionType INCLUSIVE = new ProfileTypeDimensionType("INCLUSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileTypeDimensionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileTypeDimensionType FindValue(string value)
        {
            return FindValue<ProfileTypeDimensionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileTypeDimensionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryResult.
    /// </summary>
    public class QueryResult : ConstantClass
    {

        /// <summary>
        /// Constant ABSENT for QueryResult
        /// </summary>
        public static readonly QueryResult ABSENT = new QueryResult("ABSENT");
        /// <summary>
        /// Constant PRESENT for QueryResult
        /// </summary>
        public static readonly QueryResult PRESENT = new QueryResult("PRESENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryResult FindValue(string value)
        {
            return FindValue<QueryResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RangeUnit.
    /// </summary>
    public class RangeUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for RangeUnit
        /// </summary>
        public static readonly RangeUnit DAYS = new RangeUnit("DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RangeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RangeUnit FindValue(string value)
        {
            return FindValue<RangeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RangeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadinessStatus.
    /// </summary>
    public class ReadinessStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ReadinessStatus
        /// </summary>
        public static readonly ReadinessStatus COMPLETED = new ReadinessStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ReadinessStatus
        /// </summary>
        public static readonly ReadinessStatus FAILED = new ReadinessStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReadinessStatus
        /// </summary>
        public static readonly ReadinessStatus IN_PROGRESS = new ReadinessStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PREPARING for ReadinessStatus
        /// </summary>
        public static readonly ReadinessStatus PREPARING = new ReadinessStatus("PREPARING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadinessStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadinessStatus FindValue(string value)
        {
            return FindValue<ReadinessStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadinessStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleBasedMatchingStatus.
    /// </summary>
    public class RuleBasedMatchingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RuleBasedMatchingStatus
        /// </summary>
        public static readonly RuleBasedMatchingStatus ACTIVE = new RuleBasedMatchingStatus("ACTIVE");
        /// <summary>
        /// Constant IN_PROGRESS for RuleBasedMatchingStatus
        /// </summary>
        public static readonly RuleBasedMatchingStatus IN_PROGRESS = new RuleBasedMatchingStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for RuleBasedMatchingStatus
        /// </summary>
        public static readonly RuleBasedMatchingStatus PENDING = new RuleBasedMatchingStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleBasedMatchingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleBasedMatchingStatus FindValue(string value)
        {
            return FindValue<RuleBasedMatchingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleBasedMatchingStatus(string value)
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
    /// Constants used for properties of type SegmentSnapshotStatus.
    /// </summary>
    public class SegmentSnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SegmentSnapshotStatus
        /// </summary>
        public static readonly SegmentSnapshotStatus COMPLETED = new SegmentSnapshotStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for SegmentSnapshotStatus
        /// </summary>
        public static readonly SegmentSnapshotStatus FAILED = new SegmentSnapshotStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for SegmentSnapshotStatus
        /// </summary>
        public static readonly SegmentSnapshotStatus IN_PROGRESS = new SegmentSnapshotStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SegmentSnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SegmentSnapshotStatus FindValue(string value)
        {
            return FindValue<SegmentSnapshotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SegmentSnapshotStatus(string value)
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
        /// Constant AIR_BOOKING for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier AIR_BOOKING = new StandardIdentifier("AIR_BOOKING");
        /// <summary>
        /// Constant AIR_PREFERENCE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier AIR_PREFERENCE = new StandardIdentifier("AIR_PREFERENCE");
        /// <summary>
        /// Constant AIR_SEGMENT for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier AIR_SEGMENT = new StandardIdentifier("AIR_SEGMENT");
        /// <summary>
        /// Constant ASSET for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier ASSET = new StandardIdentifier("ASSET");
        /// <summary>
        /// Constant CASE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier CASE = new StandardIdentifier("CASE");
        /// <summary>
        /// Constant COMMUNICATION_RECORD for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier COMMUNICATION_RECORD = new StandardIdentifier("COMMUNICATION_RECORD");
        /// <summary>
        /// Constant HOTEL_PREFERENCE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier HOTEL_PREFERENCE = new StandardIdentifier("HOTEL_PREFERENCE");
        /// <summary>
        /// Constant HOTEL_RESERVATION for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier HOTEL_RESERVATION = new StandardIdentifier("HOTEL_RESERVATION");
        /// <summary>
        /// Constant HOTEL_STAY_REVENUE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier HOTEL_STAY_REVENUE = new StandardIdentifier("HOTEL_STAY_REVENUE");
        /// <summary>
        /// Constant LOOKUP_ONLY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier LOOKUP_ONLY = new StandardIdentifier("LOOKUP_ONLY");
        /// <summary>
        /// Constant LOYALTY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier LOYALTY = new StandardIdentifier("LOYALTY");
        /// <summary>
        /// Constant LOYALTY_PROMOTION for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier LOYALTY_PROMOTION = new StandardIdentifier("LOYALTY_PROMOTION");
        /// <summary>
        /// Constant LOYALTY_TRANSACTION for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier LOYALTY_TRANSACTION = new StandardIdentifier("LOYALTY_TRANSACTION");
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
    /// Constants used for properties of type Statistic.
    /// </summary>
    public class Statistic : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for Statistic
        /// </summary>
        public static readonly Statistic AVERAGE = new Statistic("AVERAGE");
        /// <summary>
        /// Constant COUNT for Statistic
        /// </summary>
        public static readonly Statistic COUNT = new Statistic("COUNT");
        /// <summary>
        /// Constant FIRST_OCCURRENCE for Statistic
        /// </summary>
        public static readonly Statistic FIRST_OCCURRENCE = new Statistic("FIRST_OCCURRENCE");
        /// <summary>
        /// Constant LAST_OCCURRENCE for Statistic
        /// </summary>
        public static readonly Statistic LAST_OCCURRENCE = new Statistic("LAST_OCCURRENCE");
        /// <summary>
        /// Constant MAX_OCCURRENCE for Statistic
        /// </summary>
        public static readonly Statistic MAX_OCCURRENCE = new Statistic("MAX_OCCURRENCE");
        /// <summary>
        /// Constant MAXIMUM for Statistic
        /// </summary>
        public static readonly Statistic MAXIMUM = new Statistic("MAXIMUM");
        /// <summary>
        /// Constant MINIMUM for Statistic
        /// </summary>
        public static readonly Statistic MINIMUM = new Statistic("MINIMUM");
        /// <summary>
        /// Constant SUM for Statistic
        /// </summary>
        public static readonly Statistic SUM = new Statistic("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Statistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Statistic FindValue(string value)
        {
            return FindValue<Statistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Statistic(string value)
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
    /// Constants used for properties of type StatusReason.
    /// </summary>
    public class StatusReason : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for StatusReason
        /// </summary>
        public static readonly StatusReason INTERNAL_FAILURE = new StatusReason("INTERNAL_FAILURE");
        /// <summary>
        /// Constant VALIDATION_FAILURE for StatusReason
        /// </summary>
        public static readonly StatusReason VALIDATION_FAILURE = new StatusReason("VALIDATION_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusReason FindValue(string value)
        {
            return FindValue<StatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StringDimensionType.
    /// </summary>
    public class StringDimensionType : ConstantClass
    {

        /// <summary>
        /// Constant BEGINS_WITH for StringDimensionType
        /// </summary>
        public static readonly StringDimensionType BEGINS_WITH = new StringDimensionType("BEGINS_WITH");
        /// <summary>
        /// Constant CONTAINS for StringDimensionType
        /// </summary>
        public static readonly StringDimensionType CONTAINS = new StringDimensionType("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for StringDimensionType
        /// </summary>
        public static readonly StringDimensionType ENDS_WITH = new StringDimensionType("ENDS_WITH");
        /// <summary>
        /// Constant EXCLUSIVE for StringDimensionType
        /// </summary>
        public static readonly StringDimensionType EXCLUSIVE = new StringDimensionType("EXCLUSIVE");
        /// <summary>
        /// Constant INCLUSIVE for StringDimensionType
        /// </summary>
        public static readonly StringDimensionType INCLUSIVE = new StringDimensionType("INCLUSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringDimensionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringDimensionType FindValue(string value)
        {
            return FindValue<StringDimensionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringDimensionType(string value)
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
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Type
        /// </summary>
        public static readonly Type ALL = new Type("ALL");
        /// <summary>
        /// Constant ANY for Type
        /// </summary>
        public static readonly Type ANY = new Type("ANY");
        /// <summary>
        /// Constant NONE for Type
        /// </summary>
        public static readonly Type NONE = new Type("NONE");

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
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for Unit
        /// </summary>
        public static readonly Unit DAYS = new Unit("DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UploadJobStatus.
    /// </summary>
    public class UploadJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for UploadJobStatus
        /// </summary>
        public static readonly UploadJobStatus CREATED = new UploadJobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for UploadJobStatus
        /// </summary>
        public static readonly UploadJobStatus FAILED = new UploadJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for UploadJobStatus
        /// </summary>
        public static readonly UploadJobStatus IN_PROGRESS = new UploadJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PARTIALLY_SUCCEEDED for UploadJobStatus
        /// </summary>
        public static readonly UploadJobStatus PARTIALLY_SUCCEEDED = new UploadJobStatus("PARTIALLY_SUCCEEDED");
        /// <summary>
        /// Constant STOPPED for UploadJobStatus
        /// </summary>
        public static readonly UploadJobStatus STOPPED = new UploadJobStatus("STOPPED");
        /// <summary>
        /// Constant SUCCEEDED for UploadJobStatus
        /// </summary>
        public static readonly UploadJobStatus SUCCEEDED = new UploadJobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UploadJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UploadJobStatus FindValue(string value)
        {
            return FindValue<UploadJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UploadJobStatus(string value)
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