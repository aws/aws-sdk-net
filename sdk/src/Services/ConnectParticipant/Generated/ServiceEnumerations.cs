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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ConnectParticipant
{

    /// <summary>
    /// Constants used for properties of type ArtifactStatus.
    /// </summary>
    public class ArtifactStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for ArtifactStatus
        /// </summary>
        public static readonly ArtifactStatus APPROVED = new ArtifactStatus("APPROVED");
        /// <summary>
        /// Constant IN_PROGRESS for ArtifactStatus
        /// </summary>
        public static readonly ArtifactStatus IN_PROGRESS = new ArtifactStatus("IN_PROGRESS");
        /// <summary>
        /// Constant REJECTED for ArtifactStatus
        /// </summary>
        public static readonly ArtifactStatus REJECTED = new ArtifactStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactStatus FindValue(string value)
        {
            return FindValue<ArtifactStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChatItemType.
    /// </summary>
    public class ChatItemType : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHMENT for ChatItemType
        /// </summary>
        public static readonly ChatItemType ATTACHMENT = new ChatItemType("ATTACHMENT");
        /// <summary>
        /// Constant CHAT_ENDED for ChatItemType
        /// </summary>
        public static readonly ChatItemType CHAT_ENDED = new ChatItemType("CHAT_ENDED");
        /// <summary>
        /// Constant CONNECTION_ACK for ChatItemType
        /// </summary>
        public static readonly ChatItemType CONNECTION_ACK = new ChatItemType("CONNECTION_ACK");
        /// <summary>
        /// Constant EVENT for ChatItemType
        /// </summary>
        public static readonly ChatItemType EVENT = new ChatItemType("EVENT");
        /// <summary>
        /// Constant MESSAGE for ChatItemType
        /// </summary>
        public static readonly ChatItemType MESSAGE = new ChatItemType("MESSAGE");
        /// <summary>
        /// Constant MESSAGE_DELIVERED for ChatItemType
        /// </summary>
        public static readonly ChatItemType MESSAGE_DELIVERED = new ChatItemType("MESSAGE_DELIVERED");
        /// <summary>
        /// Constant MESSAGE_READ for ChatItemType
        /// </summary>
        public static readonly ChatItemType MESSAGE_READ = new ChatItemType("MESSAGE_READ");
        /// <summary>
        /// Constant PARTICIPANT_JOINED for ChatItemType
        /// </summary>
        public static readonly ChatItemType PARTICIPANT_JOINED = new ChatItemType("PARTICIPANT_JOINED");
        /// <summary>
        /// Constant PARTICIPANT_LEFT for ChatItemType
        /// </summary>
        public static readonly ChatItemType PARTICIPANT_LEFT = new ChatItemType("PARTICIPANT_LEFT");
        /// <summary>
        /// Constant TRANSFER_FAILED for ChatItemType
        /// </summary>
        public static readonly ChatItemType TRANSFER_FAILED = new ChatItemType("TRANSFER_FAILED");
        /// <summary>
        /// Constant TRANSFER_SUCCEEDED for ChatItemType
        /// </summary>
        public static readonly ChatItemType TRANSFER_SUCCEEDED = new ChatItemType("TRANSFER_SUCCEEDED");
        /// <summary>
        /// Constant TYPING for ChatItemType
        /// </summary>
        public static readonly ChatItemType TYPING = new ChatItemType("TYPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChatItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChatItemType FindValue(string value)
        {
            return FindValue<ChatItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChatItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionType.
    /// </summary>
    public class ConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTION_CREDENTIALS for ConnectionType
        /// </summary>
        public static readonly ConnectionType CONNECTION_CREDENTIALS = new ConnectionType("CONNECTION_CREDENTIALS");
        /// <summary>
        /// Constant WEBSOCKET for ConnectionType
        /// </summary>
        public static readonly ConnectionType WEBSOCKET = new ConnectionType("WEBSOCKET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionType FindValue(string value)
        {
            return FindValue<ConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantRole.
    /// </summary>
    public class ParticipantRole : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole AGENT = new ParticipantRole("AGENT");
        /// <summary>
        /// Constant CUSTOMER for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole CUSTOMER = new ParticipantRole("CUSTOMER");
        /// <summary>
        /// Constant SYSTEM for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole SYSTEM = new ParticipantRole("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantRole FindValue(string value)
        {
            return FindValue<ParticipantRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanDirection.
    /// </summary>
    public class ScanDirection : ConstantClass
    {

        /// <summary>
        /// Constant BACKWARD for ScanDirection
        /// </summary>
        public static readonly ScanDirection BACKWARD = new ScanDirection("BACKWARD");
        /// <summary>
        /// Constant FORWARD for ScanDirection
        /// </summary>
        public static readonly ScanDirection FORWARD = new ScanDirection("FORWARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanDirection FindValue(string value)
        {
            return FindValue<ScanDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortKey.
    /// </summary>
    public class SortKey : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortKey
        /// </summary>
        public static readonly SortKey ASCENDING = new SortKey("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortKey
        /// </summary>
        public static readonly SortKey DESCENDING = new SortKey("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortKey FindValue(string value)
        {
            return FindValue<SortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortKey(string value)
        {
            return FindValue(value);
        }
    }

}