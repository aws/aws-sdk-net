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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SSMContacts
{

    /// <summary>
    /// Constants used for properties of type AcceptCodeValidation.
    /// </summary>
    public class AcceptCodeValidation : ConstantClass
    {

        /// <summary>
        /// Constant ENFORCE for AcceptCodeValidation
        /// </summary>
        public static readonly AcceptCodeValidation ENFORCE = new AcceptCodeValidation("ENFORCE");
        /// <summary>
        /// Constant IGNORE for AcceptCodeValidation
        /// </summary>
        public static readonly AcceptCodeValidation IGNORE = new AcceptCodeValidation("IGNORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptCodeValidation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptCodeValidation FindValue(string value)
        {
            return FindValue<AcceptCodeValidation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptCodeValidation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcceptType.
    /// </summary>
    public class AcceptType : ConstantClass
    {

        /// <summary>
        /// Constant DELIVERED for AcceptType
        /// </summary>
        public static readonly AcceptType DELIVERED = new AcceptType("DELIVERED");
        /// <summary>
        /// Constant READ for AcceptType
        /// </summary>
        public static readonly AcceptType READ = new AcceptType("READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptType FindValue(string value)
        {
            return FindValue<AcceptType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActivationStatus.
    /// </summary>
    public class ActivationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for ActivationStatus
        /// </summary>
        public static readonly ActivationStatus ACTIVATED = new ActivationStatus("ACTIVATED");
        /// <summary>
        /// Constant NOT_ACTIVATED for ActivationStatus
        /// </summary>
        public static readonly ActivationStatus NOT_ACTIVATED = new ActivationStatus("NOT_ACTIVATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivationStatus FindValue(string value)
        {
            return FindValue<ActivationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelType.
    /// </summary>
    public class ChannelType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for ChannelType
        /// </summary>
        public static readonly ChannelType EMAIL = new ChannelType("EMAIL");
        /// <summary>
        /// Constant SMS for ChannelType
        /// </summary>
        public static readonly ChannelType SMS = new ChannelType("SMS");
        /// <summary>
        /// Constant VOICE for ChannelType
        /// </summary>
        public static readonly ChannelType VOICE = new ChannelType("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelType FindValue(string value)
        {
            return FindValue<ChannelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelType(string value)
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
        /// Constant ESCALATION for ContactType
        /// </summary>
        public static readonly ContactType ESCALATION = new ContactType("ESCALATION");
        /// <summary>
        /// Constant ONCALL_SCHEDULE for ContactType
        /// </summary>
        public static readonly ContactType ONCALL_SCHEDULE = new ContactType("ONCALL_SCHEDULE");
        /// <summary>
        /// Constant PERSONAL for ContactType
        /// </summary>
        public static readonly ContactType PERSONAL = new ContactType("PERSONAL");

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
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRI for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRI = new DayOfWeek("FRI");
        /// <summary>
        /// Constant MON for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MON = new DayOfWeek("MON");
        /// <summary>
        /// Constant SAT for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SAT = new DayOfWeek("SAT");
        /// <summary>
        /// Constant SUN for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUN = new DayOfWeek("SUN");
        /// <summary>
        /// Constant THU for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THU = new DayOfWeek("THU");
        /// <summary>
        /// Constant TUE for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUE = new DayOfWeek("TUE");
        /// <summary>
        /// Constant WED for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WED = new DayOfWeek("WED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReceiptType.
    /// </summary>
    public class ReceiptType : ConstantClass
    {

        /// <summary>
        /// Constant DELIVERED for ReceiptType
        /// </summary>
        public static readonly ReceiptType DELIVERED = new ReceiptType("DELIVERED");
        /// <summary>
        /// Constant ERROR for ReceiptType
        /// </summary>
        public static readonly ReceiptType ERROR = new ReceiptType("ERROR");
        /// <summary>
        /// Constant READ for ReceiptType
        /// </summary>
        public static readonly ReceiptType READ = new ReceiptType("READ");
        /// <summary>
        /// Constant SENT for ReceiptType
        /// </summary>
        public static readonly ReceiptType SENT = new ReceiptType("SENT");
        /// <summary>
        /// Constant STOP for ReceiptType
        /// </summary>
        public static readonly ReceiptType STOP = new ReceiptType("STOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReceiptType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReceiptType FindValue(string value)
        {
            return FindValue<ReceiptType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReceiptType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShiftType.
    /// </summary>
    public class ShiftType : ConstantClass
    {

        /// <summary>
        /// Constant OVERRIDDEN for ShiftType
        /// </summary>
        public static readonly ShiftType OVERRIDDEN = new ShiftType("OVERRIDDEN");
        /// <summary>
        /// Constant REGULAR for ShiftType
        /// </summary>
        public static readonly ShiftType REGULAR = new ShiftType("REGULAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShiftType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShiftType FindValue(string value)
        {
            return FindValue<ShiftType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShiftType(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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