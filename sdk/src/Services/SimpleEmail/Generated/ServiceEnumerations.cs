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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SimpleEmail
{

    /// <summary>
    /// Constants used for properties of type BounceType.
    /// </summary>
    public class BounceType : ConstantClass
    {

        /// <summary>
        /// Constant ContentRejected for BounceType
        /// </summary>
        public static readonly BounceType ContentRejected = new BounceType("ContentRejected");
        /// <summary>
        /// Constant DoesNotExist for BounceType
        /// </summary>
        public static readonly BounceType DoesNotExist = new BounceType("DoesNotExist");
        /// <summary>
        /// Constant ExceededQuota for BounceType
        /// </summary>
        public static readonly BounceType ExceededQuota = new BounceType("ExceededQuota");
        /// <summary>
        /// Constant MessageTooLarge for BounceType
        /// </summary>
        public static readonly BounceType MessageTooLarge = new BounceType("MessageTooLarge");
        /// <summary>
        /// Constant TemporaryFailure for BounceType
        /// </summary>
        public static readonly BounceType TemporaryFailure = new BounceType("TemporaryFailure");
        /// <summary>
        /// Constant Undefined for BounceType
        /// </summary>
        public static readonly BounceType Undefined = new BounceType("Undefined");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BounceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BounceType FindValue(string value)
        {
            return FindValue<BounceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BounceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DsnAction.
    /// </summary>
    public class DsnAction : ConstantClass
    {

        /// <summary>
        /// Constant Delayed for DsnAction
        /// </summary>
        public static readonly DsnAction Delayed = new DsnAction("delayed");
        /// <summary>
        /// Constant Delivered for DsnAction
        /// </summary>
        public static readonly DsnAction Delivered = new DsnAction("delivered");
        /// <summary>
        /// Constant Expanded for DsnAction
        /// </summary>
        public static readonly DsnAction Expanded = new DsnAction("expanded");
        /// <summary>
        /// Constant Failed for DsnAction
        /// </summary>
        public static readonly DsnAction Failed = new DsnAction("failed");
        /// <summary>
        /// Constant Relayed for DsnAction
        /// </summary>
        public static readonly DsnAction Relayed = new DsnAction("relayed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DsnAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DsnAction FindValue(string value)
        {
            return FindValue<DsnAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DsnAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityType.
    /// </summary>
    public class IdentityType : ConstantClass
    {

        /// <summary>
        /// Constant Domain for IdentityType
        /// </summary>
        public static readonly IdentityType Domain = new IdentityType("Domain");
        /// <summary>
        /// Constant EmailAddress for IdentityType
        /// </summary>
        public static readonly IdentityType EmailAddress = new IdentityType("EmailAddress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvocationType.
    /// </summary>
    public class InvocationType : ConstantClass
    {

        /// <summary>
        /// Constant Event for InvocationType
        /// </summary>
        public static readonly InvocationType Event = new InvocationType("Event");
        /// <summary>
        /// Constant RequestResponse for InvocationType
        /// </summary>
        public static readonly InvocationType RequestResponse = new InvocationType("RequestResponse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvocationType FindValue(string value)
        {
            return FindValue<InvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationType.
    /// </summary>
    public class NotificationType : ConstantClass
    {

        /// <summary>
        /// Constant Bounce for NotificationType
        /// </summary>
        public static readonly NotificationType Bounce = new NotificationType("Bounce");
        /// <summary>
        /// Constant Complaint for NotificationType
        /// </summary>
        public static readonly NotificationType Complaint = new NotificationType("Complaint");
        /// <summary>
        /// Constant Delivery for NotificationType
        /// </summary>
        public static readonly NotificationType Delivery = new NotificationType("Delivery");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReceiptFilterPolicy.
    /// </summary>
    public class ReceiptFilterPolicy : ConstantClass
    {

        /// <summary>
        /// Constant Allow for ReceiptFilterPolicy
        /// </summary>
        public static readonly ReceiptFilterPolicy Allow = new ReceiptFilterPolicy("Allow");
        /// <summary>
        /// Constant Block for ReceiptFilterPolicy
        /// </summary>
        public static readonly ReceiptFilterPolicy Block = new ReceiptFilterPolicy("Block");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReceiptFilterPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReceiptFilterPolicy FindValue(string value)
        {
            return FindValue<ReceiptFilterPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReceiptFilterPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StopScope.
    /// </summary>
    public class StopScope : ConstantClass
    {

        /// <summary>
        /// Constant RuleSet for StopScope
        /// </summary>
        public static readonly StopScope RuleSet = new StopScope("RuleSet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopScope FindValue(string value)
        {
            return FindValue<StopScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TlsPolicy.
    /// </summary>
    public class TlsPolicy : ConstantClass
    {

        /// <summary>
        /// Constant Optional for TlsPolicy
        /// </summary>
        public static readonly TlsPolicy Optional = new TlsPolicy("Optional");
        /// <summary>
        /// Constant Require for TlsPolicy
        /// </summary>
        public static readonly TlsPolicy Require = new TlsPolicy("Require");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TlsPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TlsPolicy FindValue(string value)
        {
            return FindValue<TlsPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TlsPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerificationStatus.
    /// </summary>
    public class VerificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus Failed = new VerificationStatus("Failed");
        /// <summary>
        /// Constant NotStarted for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus NotStarted = new VerificationStatus("NotStarted");
        /// <summary>
        /// Constant Pending for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus Pending = new VerificationStatus("Pending");
        /// <summary>
        /// Constant Success for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus Success = new VerificationStatus("Success");
        /// <summary>
        /// Constant TemporaryFailure for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus TemporaryFailure = new VerificationStatus("TemporaryFailure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationStatus FindValue(string value)
        {
            return FindValue<VerificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationStatus(string value)
        {
            return FindValue(value);
        }
    }

}