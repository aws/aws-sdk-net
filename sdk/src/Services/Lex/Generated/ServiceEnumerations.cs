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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Lex
{

    /// <summary>
    /// Constants used for properties of type ConfirmationStatus.
    /// </summary>
    public class ConfirmationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Confirmed for ConfirmationStatus
        /// </summary>
        public static readonly ConfirmationStatus Confirmed = new ConfirmationStatus("Confirmed");
        /// <summary>
        /// Constant Denied for ConfirmationStatus
        /// </summary>
        public static readonly ConfirmationStatus Denied = new ConfirmationStatus("Denied");
        /// <summary>
        /// Constant None for ConfirmationStatus
        /// </summary>
        public static readonly ConfirmationStatus None = new ConfirmationStatus("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfirmationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfirmationStatus FindValue(string value)
        {
            return FindValue<ConfirmationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfirmationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentType.
    /// </summary>
    public class ContentType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationVndAmazonawsCardGeneric for ContentType
        /// </summary>
        public static readonly ContentType ApplicationVndAmazonawsCardGeneric = new ContentType("application/vnd.amazonaws.card.generic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentType FindValue(string value)
        {
            return FindValue<ContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DialogActionType.
    /// </summary>
    public class DialogActionType : ConstantClass
    {

        /// <summary>
        /// Constant Close for DialogActionType
        /// </summary>
        public static readonly DialogActionType Close = new DialogActionType("Close");
        /// <summary>
        /// Constant ConfirmIntent for DialogActionType
        /// </summary>
        public static readonly DialogActionType ConfirmIntent = new DialogActionType("ConfirmIntent");
        /// <summary>
        /// Constant Delegate for DialogActionType
        /// </summary>
        public static readonly DialogActionType Delegate = new DialogActionType("Delegate");
        /// <summary>
        /// Constant ElicitIntent for DialogActionType
        /// </summary>
        public static readonly DialogActionType ElicitIntent = new DialogActionType("ElicitIntent");
        /// <summary>
        /// Constant ElicitSlot for DialogActionType
        /// </summary>
        public static readonly DialogActionType ElicitSlot = new DialogActionType("ElicitSlot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DialogActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DialogActionType FindValue(string value)
        {
            return FindValue<DialogActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DialogActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DialogState.
    /// </summary>
    public class DialogState : ConstantClass
    {

        /// <summary>
        /// Constant ConfirmIntent for DialogState
        /// </summary>
        public static readonly DialogState ConfirmIntent = new DialogState("ConfirmIntent");
        /// <summary>
        /// Constant ElicitIntent for DialogState
        /// </summary>
        public static readonly DialogState ElicitIntent = new DialogState("ElicitIntent");
        /// <summary>
        /// Constant ElicitSlot for DialogState
        /// </summary>
        public static readonly DialogState ElicitSlot = new DialogState("ElicitSlot");
        /// <summary>
        /// Constant Failed for DialogState
        /// </summary>
        public static readonly DialogState Failed = new DialogState("Failed");
        /// <summary>
        /// Constant Fulfilled for DialogState
        /// </summary>
        public static readonly DialogState Fulfilled = new DialogState("Fulfilled");
        /// <summary>
        /// Constant ReadyForFulfillment for DialogState
        /// </summary>
        public static readonly DialogState ReadyForFulfillment = new DialogState("ReadyForFulfillment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DialogState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DialogState FindValue(string value)
        {
            return FindValue<DialogState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DialogState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FulfillmentState.
    /// </summary>
    public class FulfillmentState : ConstantClass
    {

        /// <summary>
        /// Constant Failed for FulfillmentState
        /// </summary>
        public static readonly FulfillmentState Failed = new FulfillmentState("Failed");
        /// <summary>
        /// Constant Fulfilled for FulfillmentState
        /// </summary>
        public static readonly FulfillmentState Fulfilled = new FulfillmentState("Fulfilled");
        /// <summary>
        /// Constant ReadyForFulfillment for FulfillmentState
        /// </summary>
        public static readonly FulfillmentState ReadyForFulfillment = new FulfillmentState("ReadyForFulfillment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FulfillmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FulfillmentState FindValue(string value)
        {
            return FindValue<FulfillmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FulfillmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageFormatType.
    /// </summary>
    public class MessageFormatType : ConstantClass
    {

        /// <summary>
        /// Constant Composite for MessageFormatType
        /// </summary>
        public static readonly MessageFormatType Composite = new MessageFormatType("Composite");
        /// <summary>
        /// Constant CustomPayload for MessageFormatType
        /// </summary>
        public static readonly MessageFormatType CustomPayload = new MessageFormatType("CustomPayload");
        /// <summary>
        /// Constant PlainText for MessageFormatType
        /// </summary>
        public static readonly MessageFormatType PlainText = new MessageFormatType("PlainText");
        /// <summary>
        /// Constant SSML for MessageFormatType
        /// </summary>
        public static readonly MessageFormatType SSML = new MessageFormatType("SSML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageFormatType FindValue(string value)
        {
            return FindValue<MessageFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageFormatType(string value)
        {
            return FindValue(value);
        }
    }

}