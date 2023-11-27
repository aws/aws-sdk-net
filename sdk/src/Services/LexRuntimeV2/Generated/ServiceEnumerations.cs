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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LexRuntimeV2
{

    /// <summary>
    /// Constants used for properties of type ConfirmationState.
    /// </summary>
    public class ConfirmationState : ConstantClass
    {

        /// <summary>
        /// Constant Confirmed for ConfirmationState
        /// </summary>
        public static readonly ConfirmationState Confirmed = new ConfirmationState("Confirmed");
        /// <summary>
        /// Constant Denied for ConfirmationState
        /// </summary>
        public static readonly ConfirmationState Denied = new ConfirmationState("Denied");
        /// <summary>
        /// Constant None for ConfirmationState
        /// </summary>
        public static readonly ConfirmationState None = new ConfirmationState("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfirmationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfirmationState FindValue(string value)
        {
            return FindValue<ConfirmationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfirmationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversationMode.
    /// </summary>
    public class ConversationMode : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO for ConversationMode
        /// </summary>
        public static readonly ConversationMode AUDIO = new ConversationMode("AUDIO");
        /// <summary>
        /// Constant TEXT for ConversationMode
        /// </summary>
        public static readonly ConversationMode TEXT = new ConversationMode("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationMode FindValue(string value)
        {
            return FindValue<ConversationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationMode(string value)
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
        /// Constant None for DialogActionType
        /// </summary>
        public static readonly DialogActionType None = new DialogActionType("None");

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
    /// Constants used for properties of type InputMode.
    /// </summary>
    public class InputMode : ConstantClass
    {

        /// <summary>
        /// Constant DTMF for InputMode
        /// </summary>
        public static readonly InputMode DTMF = new InputMode("DTMF");
        /// <summary>
        /// Constant Speech for InputMode
        /// </summary>
        public static readonly InputMode Speech = new InputMode("Speech");
        /// <summary>
        /// Constant Text for InputMode
        /// </summary>
        public static readonly InputMode Text = new InputMode("Text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputMode FindValue(string value)
        {
            return FindValue<InputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntentState.
    /// </summary>
    public class IntentState : ConstantClass
    {

        /// <summary>
        /// Constant Failed for IntentState
        /// </summary>
        public static readonly IntentState Failed = new IntentState("Failed");
        /// <summary>
        /// Constant Fulfilled for IntentState
        /// </summary>
        public static readonly IntentState Fulfilled = new IntentState("Fulfilled");
        /// <summary>
        /// Constant FulfillmentInProgress for IntentState
        /// </summary>
        public static readonly IntentState FulfillmentInProgress = new IntentState("FulfillmentInProgress");
        /// <summary>
        /// Constant InProgress for IntentState
        /// </summary>
        public static readonly IntentState InProgress = new IntentState("InProgress");
        /// <summary>
        /// Constant ReadyForFulfillment for IntentState
        /// </summary>
        public static readonly IntentState ReadyForFulfillment = new IntentState("ReadyForFulfillment");
        /// <summary>
        /// Constant Waiting for IntentState
        /// </summary>
        public static readonly IntentState Waiting = new IntentState("Waiting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntentState FindValue(string value)
        {
            return FindValue<IntentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InterpretationSource.
    /// </summary>
    public class InterpretationSource : ConstantClass
    {

        /// <summary>
        /// Constant Bedrock for InterpretationSource
        /// </summary>
        public static readonly InterpretationSource Bedrock = new InterpretationSource("Bedrock");
        /// <summary>
        /// Constant Lex for InterpretationSource
        /// </summary>
        public static readonly InterpretationSource Lex = new InterpretationSource("Lex");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InterpretationSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InterpretationSource FindValue(string value)
        {
            return FindValue<InterpretationSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InterpretationSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageContentType.
    /// </summary>
    public class MessageContentType : ConstantClass
    {

        /// <summary>
        /// Constant CustomPayload for MessageContentType
        /// </summary>
        public static readonly MessageContentType CustomPayload = new MessageContentType("CustomPayload");
        /// <summary>
        /// Constant ImageResponseCard for MessageContentType
        /// </summary>
        public static readonly MessageContentType ImageResponseCard = new MessageContentType("ImageResponseCard");
        /// <summary>
        /// Constant PlainText for MessageContentType
        /// </summary>
        public static readonly MessageContentType PlainText = new MessageContentType("PlainText");
        /// <summary>
        /// Constant SSML for MessageContentType
        /// </summary>
        public static readonly MessageContentType SSML = new MessageContentType("SSML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageContentType FindValue(string value)
        {
            return FindValue<MessageContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlaybackInterruptionReason.
    /// </summary>
    public class PlaybackInterruptionReason : ConstantClass
    {

        /// <summary>
        /// Constant DTMF_START_DETECTED for PlaybackInterruptionReason
        /// </summary>
        public static readonly PlaybackInterruptionReason DTMF_START_DETECTED = new PlaybackInterruptionReason("DTMF_START_DETECTED");
        /// <summary>
        /// Constant TEXT_DETECTED for PlaybackInterruptionReason
        /// </summary>
        public static readonly PlaybackInterruptionReason TEXT_DETECTED = new PlaybackInterruptionReason("TEXT_DETECTED");
        /// <summary>
        /// Constant VOICE_START_DETECTED for PlaybackInterruptionReason
        /// </summary>
        public static readonly PlaybackInterruptionReason VOICE_START_DETECTED = new PlaybackInterruptionReason("VOICE_START_DETECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlaybackInterruptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlaybackInterruptionReason FindValue(string value)
        {
            return FindValue<PlaybackInterruptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlaybackInterruptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SentimentType.
    /// </summary>
    public class SentimentType : ConstantClass
    {

        /// <summary>
        /// Constant MIXED for SentimentType
        /// </summary>
        public static readonly SentimentType MIXED = new SentimentType("MIXED");
        /// <summary>
        /// Constant NEGATIVE for SentimentType
        /// </summary>
        public static readonly SentimentType NEGATIVE = new SentimentType("NEGATIVE");
        /// <summary>
        /// Constant NEUTRAL for SentimentType
        /// </summary>
        public static readonly SentimentType NEUTRAL = new SentimentType("NEUTRAL");
        /// <summary>
        /// Constant POSITIVE for SentimentType
        /// </summary>
        public static readonly SentimentType POSITIVE = new SentimentType("POSITIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SentimentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SentimentType FindValue(string value)
        {
            return FindValue<SentimentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SentimentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Shape.
    /// </summary>
    public class Shape : ConstantClass
    {

        /// <summary>
        /// Constant Composite for Shape
        /// </summary>
        public static readonly Shape Composite = new Shape("Composite");
        /// <summary>
        /// Constant List for Shape
        /// </summary>
        public static readonly Shape List = new Shape("List");
        /// <summary>
        /// Constant Scalar for Shape
        /// </summary>
        public static readonly Shape Scalar = new Shape("Scalar");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Shape(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Shape FindValue(string value)
        {
            return FindValue<Shape>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Shape(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StyleType.
    /// </summary>
    public class StyleType : ConstantClass
    {

        /// <summary>
        /// Constant Default for StyleType
        /// </summary>
        public static readonly StyleType Default = new StyleType("Default");
        /// <summary>
        /// Constant SpellByLetter for StyleType
        /// </summary>
        public static readonly StyleType SpellByLetter = new StyleType("SpellByLetter");
        /// <summary>
        /// Constant SpellByWord for StyleType
        /// </summary>
        public static readonly StyleType SpellByWord = new StyleType("SpellByWord");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StyleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StyleType FindValue(string value)
        {
            return FindValue<StyleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StyleType(string value)
        {
            return FindValue(value);
        }
    }

}