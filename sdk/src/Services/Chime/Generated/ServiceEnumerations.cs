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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Chime
{

    /// <summary>
    /// Constants used for properties of type AccountType.
    /// </summary>
    public class AccountType : ConstantClass
    {

        /// <summary>
        /// Constant EnterpriseDirectory for AccountType
        /// </summary>
        public static readonly AccountType EnterpriseDirectory = new AccountType("EnterpriseDirectory");
        /// <summary>
        /// Constant EnterpriseLWA for AccountType
        /// </summary>
        public static readonly AccountType EnterpriseLWA = new AccountType("EnterpriseLWA");
        /// <summary>
        /// Constant EnterpriseOIDC for AccountType
        /// </summary>
        public static readonly AccountType EnterpriseOIDC = new AccountType("EnterpriseOIDC");
        /// <summary>
        /// Constant Team for AccountType
        /// </summary>
        public static readonly AccountType Team = new AccountType("Team");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountType FindValue(string value)
        {
            return FindValue<AccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmailStatus.
    /// </summary>
    public class EmailStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for EmailStatus
        /// </summary>
        public static readonly EmailStatus Failed = new EmailStatus("Failed");
        /// <summary>
        /// Constant NotSent for EmailStatus
        /// </summary>
        public static readonly EmailStatus NotSent = new EmailStatus("NotSent");
        /// <summary>
        /// Constant Sent for EmailStatus
        /// </summary>
        public static readonly EmailStatus Sent = new EmailStatus("Sent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmailStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmailStatus FindValue(string value)
        {
            return FindValue<EmailStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmailStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BadRequest for ErrorCode
        /// </summary>
        public static readonly ErrorCode BadRequest = new ErrorCode("BadRequest");
        /// <summary>
        /// Constant Conflict for ErrorCode
        /// </summary>
        public static readonly ErrorCode Conflict = new ErrorCode("Conflict");
        /// <summary>
        /// Constant Forbidden for ErrorCode
        /// </summary>
        public static readonly ErrorCode Forbidden = new ErrorCode("Forbidden");
        /// <summary>
        /// Constant NotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode NotFound = new ErrorCode("NotFound");
        /// <summary>
        /// Constant PreconditionFailed for ErrorCode
        /// </summary>
        public static readonly ErrorCode PreconditionFailed = new ErrorCode("PreconditionFailed");
        /// <summary>
        /// Constant ServiceFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceFailure = new ErrorCode("ServiceFailure");
        /// <summary>
        /// Constant ServiceUnavailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceUnavailable = new ErrorCode("ServiceUnavailable");
        /// <summary>
        /// Constant Throttled for ErrorCode
        /// </summary>
        public static readonly ErrorCode Throttled = new ErrorCode("Throttled");
        /// <summary>
        /// Constant Unauthorized for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unauthorized = new ErrorCode("Unauthorized");
        /// <summary>
        /// Constant Unprocessable for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unprocessable = new ErrorCode("Unprocessable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InviteStatus.
    /// </summary>
    public class InviteStatus : ConstantClass
    {

        /// <summary>
        /// Constant Accepted for InviteStatus
        /// </summary>
        public static readonly InviteStatus Accepted = new InviteStatus("Accepted");
        /// <summary>
        /// Constant Failed for InviteStatus
        /// </summary>
        public static readonly InviteStatus Failed = new InviteStatus("Failed");
        /// <summary>
        /// Constant Pending for InviteStatus
        /// </summary>
        public static readonly InviteStatus Pending = new InviteStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InviteStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InviteStatus FindValue(string value)
        {
            return FindValue<InviteStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InviteStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type License.
    /// </summary>
    public class License : ConstantClass
    {

        /// <summary>
        /// Constant Basic for License
        /// </summary>
        public static readonly License Basic = new License("Basic");
        /// <summary>
        /// Constant Plus for License
        /// </summary>
        public static readonly License Plus = new License("Plus");
        /// <summary>
        /// Constant Pro for License
        /// </summary>
        public static readonly License Pro = new License("Pro");
        /// <summary>
        /// Constant ProTrial for License
        /// </summary>
        public static readonly License ProTrial = new License("ProTrial");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public License(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static License FindValue(string value)
        {
            return FindValue<License>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator License(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationStatus.
    /// </summary>
    public class RegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Registered for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Registered = new RegistrationStatus("Registered");
        /// <summary>
        /// Constant Suspended for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Suspended = new RegistrationStatus("Suspended");
        /// <summary>
        /// Constant Unregistered for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Unregistered = new RegistrationStatus("Unregistered");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationStatus FindValue(string value)
        {
            return FindValue<RegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }

}