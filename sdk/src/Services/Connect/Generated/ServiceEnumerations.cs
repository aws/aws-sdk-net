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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Connect
{

    /// <summary>
    /// Constants used for properties of type Channel.
    /// </summary>
    public class Channel : ConstantClass
    {

        /// <summary>
        /// Constant CHAT for Channel
        /// </summary>
        public static readonly Channel CHAT = new Channel("CHAT");
        /// <summary>
        /// Constant TASK for Channel
        /// </summary>
        public static readonly Channel TASK = new Channel("TASK");
        /// <summary>
        /// Constant VOICE for Channel
        /// </summary>
        public static readonly Channel VOICE = new Channel("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Channel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Channel FindValue(string value)
        {
            return FindValue<Channel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Channel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Comparison.
    /// </summary>
    public class Comparison : ConstantClass
    {

        /// <summary>
        /// Constant LT for Comparison
        /// </summary>
        public static readonly Comparison LT = new Comparison("LT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Comparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Comparison FindValue(string value)
        {
            return FindValue<Comparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Comparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactFlowType.
    /// </summary>
    public class ContactFlowType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_HOLD for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType AGENT_HOLD = new ContactFlowType("AGENT_HOLD");
        /// <summary>
        /// Constant AGENT_TRANSFER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType AGENT_TRANSFER = new ContactFlowType("AGENT_TRANSFER");
        /// <summary>
        /// Constant AGENT_WHISPER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType AGENT_WHISPER = new ContactFlowType("AGENT_WHISPER");
        /// <summary>
        /// Constant CONTACT_FLOW for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CONTACT_FLOW = new ContactFlowType("CONTACT_FLOW");
        /// <summary>
        /// Constant CUSTOMER_HOLD for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CUSTOMER_HOLD = new ContactFlowType("CUSTOMER_HOLD");
        /// <summary>
        /// Constant CUSTOMER_QUEUE for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CUSTOMER_QUEUE = new ContactFlowType("CUSTOMER_QUEUE");
        /// <summary>
        /// Constant CUSTOMER_WHISPER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CUSTOMER_WHISPER = new ContactFlowType("CUSTOMER_WHISPER");
        /// <summary>
        /// Constant OUTBOUND_WHISPER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType OUTBOUND_WHISPER = new ContactFlowType("OUTBOUND_WHISPER");
        /// <summary>
        /// Constant QUEUE_TRANSFER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType QUEUE_TRANSFER = new ContactFlowType("QUEUE_TRANSFER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactFlowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactFlowType FindValue(string value)
        {
            return FindValue<ContactFlowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactFlowType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrentMetricName.
    /// </summary>
    public class CurrentMetricName : ConstantClass
    {

        /// <summary>
        /// Constant AGENTS_AFTER_CONTACT_WORK for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_AFTER_CONTACT_WORK = new CurrentMetricName("AGENTS_AFTER_CONTACT_WORK");
        /// <summary>
        /// Constant AGENTS_AVAILABLE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_AVAILABLE = new CurrentMetricName("AGENTS_AVAILABLE");
        /// <summary>
        /// Constant AGENTS_ERROR for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ERROR = new CurrentMetricName("AGENTS_ERROR");
        /// <summary>
        /// Constant AGENTS_NON_PRODUCTIVE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_NON_PRODUCTIVE = new CurrentMetricName("AGENTS_NON_PRODUCTIVE");
        /// <summary>
        /// Constant AGENTS_ON_CALL for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ON_CALL = new CurrentMetricName("AGENTS_ON_CALL");
        /// <summary>
        /// Constant AGENTS_ON_CONTACT for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ON_CONTACT = new CurrentMetricName("AGENTS_ON_CONTACT");
        /// <summary>
        /// Constant AGENTS_ONLINE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ONLINE = new CurrentMetricName("AGENTS_ONLINE");
        /// <summary>
        /// Constant AGENTS_STAFFED for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_STAFFED = new CurrentMetricName("AGENTS_STAFFED");
        /// <summary>
        /// Constant CONTACTS_IN_QUEUE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName CONTACTS_IN_QUEUE = new CurrentMetricName("CONTACTS_IN_QUEUE");
        /// <summary>
        /// Constant CONTACTS_SCHEDULED for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName CONTACTS_SCHEDULED = new CurrentMetricName("CONTACTS_SCHEDULED");
        /// <summary>
        /// Constant OLDEST_CONTACT_AGE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName OLDEST_CONTACT_AGE = new CurrentMetricName("OLDEST_CONTACT_AGE");
        /// <summary>
        /// Constant SLOTS_ACTIVE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName SLOTS_ACTIVE = new CurrentMetricName("SLOTS_ACTIVE");
        /// <summary>
        /// Constant SLOTS_AVAILABLE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName SLOTS_AVAILABLE = new CurrentMetricName("SLOTS_AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrentMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrentMetricName FindValue(string value)
        {
            return FindValue<CurrentMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrentMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryType.
    /// </summary>
    public class DirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECT_MANAGED for DirectoryType
        /// </summary>
        public static readonly DirectoryType CONNECT_MANAGED = new DirectoryType("CONNECT_MANAGED");
        /// <summary>
        /// Constant EXISTING_DIRECTORY for DirectoryType
        /// </summary>
        public static readonly DirectoryType EXISTING_DIRECTORY = new DirectoryType("EXISTING_DIRECTORY");
        /// <summary>
        /// Constant SAML for DirectoryType
        /// </summary>
        public static readonly DirectoryType SAML = new DirectoryType("SAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryType FindValue(string value)
        {
            return FindValue<DirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS = new EncryptionType("KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Grouping.
    /// </summary>
    public class Grouping : ConstantClass
    {

        /// <summary>
        /// Constant CHANNEL for Grouping
        /// </summary>
        public static readonly Grouping CHANNEL = new Grouping("CHANNEL");
        /// <summary>
        /// Constant QUEUE for Grouping
        /// </summary>
        public static readonly Grouping QUEUE = new Grouping("QUEUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Grouping(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Grouping FindValue(string value)
        {
            return FindValue<Grouping>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Grouping(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HistoricalMetricName.
    /// </summary>
    public class HistoricalMetricName : ConstantClass
    {

        /// <summary>
        /// Constant ABANDON_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName ABANDON_TIME = new HistoricalMetricName("ABANDON_TIME");
        /// <summary>
        /// Constant AFTER_CONTACT_WORK_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName AFTER_CONTACT_WORK_TIME = new HistoricalMetricName("AFTER_CONTACT_WORK_TIME");
        /// <summary>
        /// Constant API_CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName API_CONTACTS_HANDLED = new HistoricalMetricName("API_CONTACTS_HANDLED");
        /// <summary>
        /// Constant CALLBACK_CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CALLBACK_CONTACTS_HANDLED = new HistoricalMetricName("CALLBACK_CONTACTS_HANDLED");
        /// <summary>
        /// Constant CONTACTS_ABANDONED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_ABANDONED = new HistoricalMetricName("CONTACTS_ABANDONED");
        /// <summary>
        /// Constant CONTACTS_AGENT_HUNG_UP_FIRST for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_AGENT_HUNG_UP_FIRST = new HistoricalMetricName("CONTACTS_AGENT_HUNG_UP_FIRST");
        /// <summary>
        /// Constant CONTACTS_CONSULTED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_CONSULTED = new HistoricalMetricName("CONTACTS_CONSULTED");
        /// <summary>
        /// Constant CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED = new HistoricalMetricName("CONTACTS_HANDLED");
        /// <summary>
        /// Constant CONTACTS_HANDLED_INCOMING for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED_INCOMING = new HistoricalMetricName("CONTACTS_HANDLED_INCOMING");
        /// <summary>
        /// Constant CONTACTS_HANDLED_OUTBOUND for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED_OUTBOUND = new HistoricalMetricName("CONTACTS_HANDLED_OUTBOUND");
        /// <summary>
        /// Constant CONTACTS_HOLD_ABANDONS for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HOLD_ABANDONS = new HistoricalMetricName("CONTACTS_HOLD_ABANDONS");
        /// <summary>
        /// Constant CONTACTS_MISSED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_MISSED = new HistoricalMetricName("CONTACTS_MISSED");
        /// <summary>
        /// Constant CONTACTS_QUEUED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_QUEUED = new HistoricalMetricName("CONTACTS_QUEUED");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_IN for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_IN = new HistoricalMetricName("CONTACTS_TRANSFERRED_IN");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_IN_FROM_QUEUE for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_IN_FROM_QUEUE = new HistoricalMetricName("CONTACTS_TRANSFERRED_IN_FROM_QUEUE");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_OUT for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_OUT = new HistoricalMetricName("CONTACTS_TRANSFERRED_OUT");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_OUT_FROM_QUEUE for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_OUT_FROM_QUEUE = new HistoricalMetricName("CONTACTS_TRANSFERRED_OUT_FROM_QUEUE");
        /// <summary>
        /// Constant HANDLE_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName HANDLE_TIME = new HistoricalMetricName("HANDLE_TIME");
        /// <summary>
        /// Constant HOLD_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName HOLD_TIME = new HistoricalMetricName("HOLD_TIME");
        /// <summary>
        /// Constant INTERACTION_AND_HOLD_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName INTERACTION_AND_HOLD_TIME = new HistoricalMetricName("INTERACTION_AND_HOLD_TIME");
        /// <summary>
        /// Constant INTERACTION_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName INTERACTION_TIME = new HistoricalMetricName("INTERACTION_TIME");
        /// <summary>
        /// Constant OCCUPANCY for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName OCCUPANCY = new HistoricalMetricName("OCCUPANCY");
        /// <summary>
        /// Constant QUEUE_ANSWER_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName QUEUE_ANSWER_TIME = new HistoricalMetricName("QUEUE_ANSWER_TIME");
        /// <summary>
        /// Constant QUEUED_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName QUEUED_TIME = new HistoricalMetricName("QUEUED_TIME");
        /// <summary>
        /// Constant SERVICE_LEVEL for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName SERVICE_LEVEL = new HistoricalMetricName("SERVICE_LEVEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HistoricalMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HistoricalMetricName FindValue(string value)
        {
            return FindValue<HistoricalMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HistoricalMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceAttributeType.
    /// </summary>
    public class InstanceAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_RESOLVE_BEST_VOICES for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType AUTO_RESOLVE_BEST_VOICES = new InstanceAttributeType("AUTO_RESOLVE_BEST_VOICES");
        /// <summary>
        /// Constant CONTACT_LENS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType CONTACT_LENS = new InstanceAttributeType("CONTACT_LENS");
        /// <summary>
        /// Constant CONTACTFLOW_LOGS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType CONTACTFLOW_LOGS = new InstanceAttributeType("CONTACTFLOW_LOGS");
        /// <summary>
        /// Constant EARLY_MEDIA for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType EARLY_MEDIA = new InstanceAttributeType("EARLY_MEDIA");
        /// <summary>
        /// Constant INBOUND_CALLS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType INBOUND_CALLS = new InstanceAttributeType("INBOUND_CALLS");
        /// <summary>
        /// Constant OUTBOUND_CALLS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType OUTBOUND_CALLS = new InstanceAttributeType("OUTBOUND_CALLS");
        /// <summary>
        /// Constant USE_CUSTOM_TTS_VOICES for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType USE_CUSTOM_TTS_VOICES = new InstanceAttributeType("USE_CUSTOM_TTS_VOICES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAttributeType FindValue(string value)
        {
            return FindValue<InstanceAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStatus.
    /// </summary>
    public class InstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus ACTIVE = new InstanceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATION_FAILED for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus CREATION_FAILED = new InstanceStatus("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus CREATION_IN_PROGRESS = new InstanceStatus("CREATION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStatus FindValue(string value)
        {
            return FindValue<InstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStorageResourceType.
    /// </summary>
    public class InstanceStorageResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_EVENTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType AGENT_EVENTS = new InstanceStorageResourceType("AGENT_EVENTS");
        /// <summary>
        /// Constant CALL_RECORDINGS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType CALL_RECORDINGS = new InstanceStorageResourceType("CALL_RECORDINGS");
        /// <summary>
        /// Constant CHAT_TRANSCRIPTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType CHAT_TRANSCRIPTS = new InstanceStorageResourceType("CHAT_TRANSCRIPTS");
        /// <summary>
        /// Constant CONTACT_TRACE_RECORDS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType CONTACT_TRACE_RECORDS = new InstanceStorageResourceType("CONTACT_TRACE_RECORDS");
        /// <summary>
        /// Constant MEDIA_STREAMS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType MEDIA_STREAMS = new InstanceStorageResourceType("MEDIA_STREAMS");
        /// <summary>
        /// Constant SCHEDULED_REPORTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType SCHEDULED_REPORTS = new InstanceStorageResourceType("SCHEDULED_REPORTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStorageResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStorageResourceType FindValue(string value)
        {
            return FindValue<InstanceStorageResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStorageResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant EVENT for IntegrationType
        /// </summary>
        public static readonly IntegrationType EVENT = new IntegrationType("EVENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberCountryCode.
    /// </summary>
    public class PhoneNumberCountryCode : ConstantClass
    {

        /// <summary>
        /// Constant AD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AD = new PhoneNumberCountryCode("AD");
        /// <summary>
        /// Constant AE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AE = new PhoneNumberCountryCode("AE");
        /// <summary>
        /// Constant AF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AF = new PhoneNumberCountryCode("AF");
        /// <summary>
        /// Constant AG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AG = new PhoneNumberCountryCode("AG");
        /// <summary>
        /// Constant AI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AI = new PhoneNumberCountryCode("AI");
        /// <summary>
        /// Constant AL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AL = new PhoneNumberCountryCode("AL");
        /// <summary>
        /// Constant AM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AM = new PhoneNumberCountryCode("AM");
        /// <summary>
        /// Constant AN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AN = new PhoneNumberCountryCode("AN");
        /// <summary>
        /// Constant AO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AO = new PhoneNumberCountryCode("AO");
        /// <summary>
        /// Constant AQ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AQ = new PhoneNumberCountryCode("AQ");
        /// <summary>
        /// Constant AR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AR = new PhoneNumberCountryCode("AR");
        /// <summary>
        /// Constant AS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AS = new PhoneNumberCountryCode("AS");
        /// <summary>
        /// Constant AT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AT = new PhoneNumberCountryCode("AT");
        /// <summary>
        /// Constant AU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AU = new PhoneNumberCountryCode("AU");
        /// <summary>
        /// Constant AW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AW = new PhoneNumberCountryCode("AW");
        /// <summary>
        /// Constant AZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AZ = new PhoneNumberCountryCode("AZ");
        /// <summary>
        /// Constant BA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BA = new PhoneNumberCountryCode("BA");
        /// <summary>
        /// Constant BB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BB = new PhoneNumberCountryCode("BB");
        /// <summary>
        /// Constant BD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BD = new PhoneNumberCountryCode("BD");
        /// <summary>
        /// Constant BE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BE = new PhoneNumberCountryCode("BE");
        /// <summary>
        /// Constant BF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BF = new PhoneNumberCountryCode("BF");
        /// <summary>
        /// Constant BG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BG = new PhoneNumberCountryCode("BG");
        /// <summary>
        /// Constant BH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BH = new PhoneNumberCountryCode("BH");
        /// <summary>
        /// Constant BI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BI = new PhoneNumberCountryCode("BI");
        /// <summary>
        /// Constant BJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BJ = new PhoneNumberCountryCode("BJ");
        /// <summary>
        /// Constant BL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BL = new PhoneNumberCountryCode("BL");
        /// <summary>
        /// Constant BM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BM = new PhoneNumberCountryCode("BM");
        /// <summary>
        /// Constant BN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BN = new PhoneNumberCountryCode("BN");
        /// <summary>
        /// Constant BO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BO = new PhoneNumberCountryCode("BO");
        /// <summary>
        /// Constant BR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BR = new PhoneNumberCountryCode("BR");
        /// <summary>
        /// Constant BS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BS = new PhoneNumberCountryCode("BS");
        /// <summary>
        /// Constant BT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BT = new PhoneNumberCountryCode("BT");
        /// <summary>
        /// Constant BW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BW = new PhoneNumberCountryCode("BW");
        /// <summary>
        /// Constant BY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BY = new PhoneNumberCountryCode("BY");
        /// <summary>
        /// Constant BZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BZ = new PhoneNumberCountryCode("BZ");
        /// <summary>
        /// Constant CA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CA = new PhoneNumberCountryCode("CA");
        /// <summary>
        /// Constant CC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CC = new PhoneNumberCountryCode("CC");
        /// <summary>
        /// Constant CD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CD = new PhoneNumberCountryCode("CD");
        /// <summary>
        /// Constant CF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CF = new PhoneNumberCountryCode("CF");
        /// <summary>
        /// Constant CG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CG = new PhoneNumberCountryCode("CG");
        /// <summary>
        /// Constant CH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CH = new PhoneNumberCountryCode("CH");
        /// <summary>
        /// Constant CI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CI = new PhoneNumberCountryCode("CI");
        /// <summary>
        /// Constant CK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CK = new PhoneNumberCountryCode("CK");
        /// <summary>
        /// Constant CL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CL = new PhoneNumberCountryCode("CL");
        /// <summary>
        /// Constant CM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CM = new PhoneNumberCountryCode("CM");
        /// <summary>
        /// Constant CN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CN = new PhoneNumberCountryCode("CN");
        /// <summary>
        /// Constant CO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CO = new PhoneNumberCountryCode("CO");
        /// <summary>
        /// Constant CR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CR = new PhoneNumberCountryCode("CR");
        /// <summary>
        /// Constant CU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CU = new PhoneNumberCountryCode("CU");
        /// <summary>
        /// Constant CV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CV = new PhoneNumberCountryCode("CV");
        /// <summary>
        /// Constant CW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CW = new PhoneNumberCountryCode("CW");
        /// <summary>
        /// Constant CX for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CX = new PhoneNumberCountryCode("CX");
        /// <summary>
        /// Constant CY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CY = new PhoneNumberCountryCode("CY");
        /// <summary>
        /// Constant CZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CZ = new PhoneNumberCountryCode("CZ");
        /// <summary>
        /// Constant DE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DE = new PhoneNumberCountryCode("DE");
        /// <summary>
        /// Constant DJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DJ = new PhoneNumberCountryCode("DJ");
        /// <summary>
        /// Constant DK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DK = new PhoneNumberCountryCode("DK");
        /// <summary>
        /// Constant DM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DM = new PhoneNumberCountryCode("DM");
        /// <summary>
        /// Constant DO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DO = new PhoneNumberCountryCode("DO");
        /// <summary>
        /// Constant DZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DZ = new PhoneNumberCountryCode("DZ");
        /// <summary>
        /// Constant EC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EC = new PhoneNumberCountryCode("EC");
        /// <summary>
        /// Constant EE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EE = new PhoneNumberCountryCode("EE");
        /// <summary>
        /// Constant EG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EG = new PhoneNumberCountryCode("EG");
        /// <summary>
        /// Constant EH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EH = new PhoneNumberCountryCode("EH");
        /// <summary>
        /// Constant ER for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ER = new PhoneNumberCountryCode("ER");
        /// <summary>
        /// Constant ES for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ES = new PhoneNumberCountryCode("ES");
        /// <summary>
        /// Constant ET for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ET = new PhoneNumberCountryCode("ET");
        /// <summary>
        /// Constant FI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FI = new PhoneNumberCountryCode("FI");
        /// <summary>
        /// Constant FJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FJ = new PhoneNumberCountryCode("FJ");
        /// <summary>
        /// Constant FK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FK = new PhoneNumberCountryCode("FK");
        /// <summary>
        /// Constant FM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FM = new PhoneNumberCountryCode("FM");
        /// <summary>
        /// Constant FO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FO = new PhoneNumberCountryCode("FO");
        /// <summary>
        /// Constant FR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FR = new PhoneNumberCountryCode("FR");
        /// <summary>
        /// Constant GA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GA = new PhoneNumberCountryCode("GA");
        /// <summary>
        /// Constant GB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GB = new PhoneNumberCountryCode("GB");
        /// <summary>
        /// Constant GD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GD = new PhoneNumberCountryCode("GD");
        /// <summary>
        /// Constant GE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GE = new PhoneNumberCountryCode("GE");
        /// <summary>
        /// Constant GG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GG = new PhoneNumberCountryCode("GG");
        /// <summary>
        /// Constant GH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GH = new PhoneNumberCountryCode("GH");
        /// <summary>
        /// Constant GI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GI = new PhoneNumberCountryCode("GI");
        /// <summary>
        /// Constant GL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GL = new PhoneNumberCountryCode("GL");
        /// <summary>
        /// Constant GM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GM = new PhoneNumberCountryCode("GM");
        /// <summary>
        /// Constant GN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GN = new PhoneNumberCountryCode("GN");
        /// <summary>
        /// Constant GQ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GQ = new PhoneNumberCountryCode("GQ");
        /// <summary>
        /// Constant GR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GR = new PhoneNumberCountryCode("GR");
        /// <summary>
        /// Constant GT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GT = new PhoneNumberCountryCode("GT");
        /// <summary>
        /// Constant GU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GU = new PhoneNumberCountryCode("GU");
        /// <summary>
        /// Constant GW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GW = new PhoneNumberCountryCode("GW");
        /// <summary>
        /// Constant GY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GY = new PhoneNumberCountryCode("GY");
        /// <summary>
        /// Constant HK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HK = new PhoneNumberCountryCode("HK");
        /// <summary>
        /// Constant HN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HN = new PhoneNumberCountryCode("HN");
        /// <summary>
        /// Constant HR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HR = new PhoneNumberCountryCode("HR");
        /// <summary>
        /// Constant HT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HT = new PhoneNumberCountryCode("HT");
        /// <summary>
        /// Constant HU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HU = new PhoneNumberCountryCode("HU");
        /// <summary>
        /// Constant ID for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ID = new PhoneNumberCountryCode("ID");
        /// <summary>
        /// Constant IE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IE = new PhoneNumberCountryCode("IE");
        /// <summary>
        /// Constant IL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IL = new PhoneNumberCountryCode("IL");
        /// <summary>
        /// Constant IM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IM = new PhoneNumberCountryCode("IM");
        /// <summary>
        /// Constant IN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IN = new PhoneNumberCountryCode("IN");
        /// <summary>
        /// Constant IO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IO = new PhoneNumberCountryCode("IO");
        /// <summary>
        /// Constant IQ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IQ = new PhoneNumberCountryCode("IQ");
        /// <summary>
        /// Constant IR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IR = new PhoneNumberCountryCode("IR");
        /// <summary>
        /// Constant IS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IS = new PhoneNumberCountryCode("IS");
        /// <summary>
        /// Constant IT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IT = new PhoneNumberCountryCode("IT");
        /// <summary>
        /// Constant JE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JE = new PhoneNumberCountryCode("JE");
        /// <summary>
        /// Constant JM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JM = new PhoneNumberCountryCode("JM");
        /// <summary>
        /// Constant JO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JO = new PhoneNumberCountryCode("JO");
        /// <summary>
        /// Constant JP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JP = new PhoneNumberCountryCode("JP");
        /// <summary>
        /// Constant KE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KE = new PhoneNumberCountryCode("KE");
        /// <summary>
        /// Constant KG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KG = new PhoneNumberCountryCode("KG");
        /// <summary>
        /// Constant KH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KH = new PhoneNumberCountryCode("KH");
        /// <summary>
        /// Constant KI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KI = new PhoneNumberCountryCode("KI");
        /// <summary>
        /// Constant KM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KM = new PhoneNumberCountryCode("KM");
        /// <summary>
        /// Constant KN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KN = new PhoneNumberCountryCode("KN");
        /// <summary>
        /// Constant KP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KP = new PhoneNumberCountryCode("KP");
        /// <summary>
        /// Constant KR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KR = new PhoneNumberCountryCode("KR");
        /// <summary>
        /// Constant KW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KW = new PhoneNumberCountryCode("KW");
        /// <summary>
        /// Constant KY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KY = new PhoneNumberCountryCode("KY");
        /// <summary>
        /// Constant KZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KZ = new PhoneNumberCountryCode("KZ");
        /// <summary>
        /// Constant LA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LA = new PhoneNumberCountryCode("LA");
        /// <summary>
        /// Constant LB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LB = new PhoneNumberCountryCode("LB");
        /// <summary>
        /// Constant LC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LC = new PhoneNumberCountryCode("LC");
        /// <summary>
        /// Constant LI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LI = new PhoneNumberCountryCode("LI");
        /// <summary>
        /// Constant LK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LK = new PhoneNumberCountryCode("LK");
        /// <summary>
        /// Constant LR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LR = new PhoneNumberCountryCode("LR");
        /// <summary>
        /// Constant LS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LS = new PhoneNumberCountryCode("LS");
        /// <summary>
        /// Constant LT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LT = new PhoneNumberCountryCode("LT");
        /// <summary>
        /// Constant LU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LU = new PhoneNumberCountryCode("LU");
        /// <summary>
        /// Constant LV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LV = new PhoneNumberCountryCode("LV");
        /// <summary>
        /// Constant LY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LY = new PhoneNumberCountryCode("LY");
        /// <summary>
        /// Constant MA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MA = new PhoneNumberCountryCode("MA");
        /// <summary>
        /// Constant MC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MC = new PhoneNumberCountryCode("MC");
        /// <summary>
        /// Constant MD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MD = new PhoneNumberCountryCode("MD");
        /// <summary>
        /// Constant ME for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ME = new PhoneNumberCountryCode("ME");
        /// <summary>
        /// Constant MF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MF = new PhoneNumberCountryCode("MF");
        /// <summary>
        /// Constant MG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MG = new PhoneNumberCountryCode("MG");
        /// <summary>
        /// Constant MH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MH = new PhoneNumberCountryCode("MH");
        /// <summary>
        /// Constant MK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MK = new PhoneNumberCountryCode("MK");
        /// <summary>
        /// Constant ML for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ML = new PhoneNumberCountryCode("ML");
        /// <summary>
        /// Constant MM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MM = new PhoneNumberCountryCode("MM");
        /// <summary>
        /// Constant MN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MN = new PhoneNumberCountryCode("MN");
        /// <summary>
        /// Constant MO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MO = new PhoneNumberCountryCode("MO");
        /// <summary>
        /// Constant MP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MP = new PhoneNumberCountryCode("MP");
        /// <summary>
        /// Constant MR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MR = new PhoneNumberCountryCode("MR");
        /// <summary>
        /// Constant MS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MS = new PhoneNumberCountryCode("MS");
        /// <summary>
        /// Constant MT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MT = new PhoneNumberCountryCode("MT");
        /// <summary>
        /// Constant MU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MU = new PhoneNumberCountryCode("MU");
        /// <summary>
        /// Constant MV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MV = new PhoneNumberCountryCode("MV");
        /// <summary>
        /// Constant MW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MW = new PhoneNumberCountryCode("MW");
        /// <summary>
        /// Constant MX for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MX = new PhoneNumberCountryCode("MX");
        /// <summary>
        /// Constant MY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MY = new PhoneNumberCountryCode("MY");
        /// <summary>
        /// Constant MZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MZ = new PhoneNumberCountryCode("MZ");
        /// <summary>
        /// Constant NA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NA = new PhoneNumberCountryCode("NA");
        /// <summary>
        /// Constant NC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NC = new PhoneNumberCountryCode("NC");
        /// <summary>
        /// Constant NE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NE = new PhoneNumberCountryCode("NE");
        /// <summary>
        /// Constant NG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NG = new PhoneNumberCountryCode("NG");
        /// <summary>
        /// Constant NI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NI = new PhoneNumberCountryCode("NI");
        /// <summary>
        /// Constant NL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NL = new PhoneNumberCountryCode("NL");
        /// <summary>
        /// Constant NO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NO = new PhoneNumberCountryCode("NO");
        /// <summary>
        /// Constant NP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NP = new PhoneNumberCountryCode("NP");
        /// <summary>
        /// Constant NR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NR = new PhoneNumberCountryCode("NR");
        /// <summary>
        /// Constant NU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NU = new PhoneNumberCountryCode("NU");
        /// <summary>
        /// Constant NZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NZ = new PhoneNumberCountryCode("NZ");
        /// <summary>
        /// Constant OM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode OM = new PhoneNumberCountryCode("OM");
        /// <summary>
        /// Constant PA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PA = new PhoneNumberCountryCode("PA");
        /// <summary>
        /// Constant PE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PE = new PhoneNumberCountryCode("PE");
        /// <summary>
        /// Constant PF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PF = new PhoneNumberCountryCode("PF");
        /// <summary>
        /// Constant PG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PG = new PhoneNumberCountryCode("PG");
        /// <summary>
        /// Constant PH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PH = new PhoneNumberCountryCode("PH");
        /// <summary>
        /// Constant PK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PK = new PhoneNumberCountryCode("PK");
        /// <summary>
        /// Constant PL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PL = new PhoneNumberCountryCode("PL");
        /// <summary>
        /// Constant PM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PM = new PhoneNumberCountryCode("PM");
        /// <summary>
        /// Constant PN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PN = new PhoneNumberCountryCode("PN");
        /// <summary>
        /// Constant PR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PR = new PhoneNumberCountryCode("PR");
        /// <summary>
        /// Constant PT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PT = new PhoneNumberCountryCode("PT");
        /// <summary>
        /// Constant PW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PW = new PhoneNumberCountryCode("PW");
        /// <summary>
        /// Constant PY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PY = new PhoneNumberCountryCode("PY");
        /// <summary>
        /// Constant QA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode QA = new PhoneNumberCountryCode("QA");
        /// <summary>
        /// Constant RE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RE = new PhoneNumberCountryCode("RE");
        /// <summary>
        /// Constant RO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RO = new PhoneNumberCountryCode("RO");
        /// <summary>
        /// Constant RS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RS = new PhoneNumberCountryCode("RS");
        /// <summary>
        /// Constant RU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RU = new PhoneNumberCountryCode("RU");
        /// <summary>
        /// Constant RW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RW = new PhoneNumberCountryCode("RW");
        /// <summary>
        /// Constant SA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SA = new PhoneNumberCountryCode("SA");
        /// <summary>
        /// Constant SB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SB = new PhoneNumberCountryCode("SB");
        /// <summary>
        /// Constant SC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SC = new PhoneNumberCountryCode("SC");
        /// <summary>
        /// Constant SD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SD = new PhoneNumberCountryCode("SD");
        /// <summary>
        /// Constant SE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SE = new PhoneNumberCountryCode("SE");
        /// <summary>
        /// Constant SG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SG = new PhoneNumberCountryCode("SG");
        /// <summary>
        /// Constant SH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SH = new PhoneNumberCountryCode("SH");
        /// <summary>
        /// Constant SI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SI = new PhoneNumberCountryCode("SI");
        /// <summary>
        /// Constant SJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SJ = new PhoneNumberCountryCode("SJ");
        /// <summary>
        /// Constant SK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SK = new PhoneNumberCountryCode("SK");
        /// <summary>
        /// Constant SL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SL = new PhoneNumberCountryCode("SL");
        /// <summary>
        /// Constant SM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SM = new PhoneNumberCountryCode("SM");
        /// <summary>
        /// Constant SN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SN = new PhoneNumberCountryCode("SN");
        /// <summary>
        /// Constant SO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SO = new PhoneNumberCountryCode("SO");
        /// <summary>
        /// Constant SR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SR = new PhoneNumberCountryCode("SR");
        /// <summary>
        /// Constant ST for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ST = new PhoneNumberCountryCode("ST");
        /// <summary>
        /// Constant SV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SV = new PhoneNumberCountryCode("SV");
        /// <summary>
        /// Constant SX for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SX = new PhoneNumberCountryCode("SX");
        /// <summary>
        /// Constant SY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SY = new PhoneNumberCountryCode("SY");
        /// <summary>
        /// Constant SZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SZ = new PhoneNumberCountryCode("SZ");
        /// <summary>
        /// Constant TC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TC = new PhoneNumberCountryCode("TC");
        /// <summary>
        /// Constant TD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TD = new PhoneNumberCountryCode("TD");
        /// <summary>
        /// Constant TG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TG = new PhoneNumberCountryCode("TG");
        /// <summary>
        /// Constant TH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TH = new PhoneNumberCountryCode("TH");
        /// <summary>
        /// Constant TJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TJ = new PhoneNumberCountryCode("TJ");
        /// <summary>
        /// Constant TK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TK = new PhoneNumberCountryCode("TK");
        /// <summary>
        /// Constant TL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TL = new PhoneNumberCountryCode("TL");
        /// <summary>
        /// Constant TM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TM = new PhoneNumberCountryCode("TM");
        /// <summary>
        /// Constant TN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TN = new PhoneNumberCountryCode("TN");
        /// <summary>
        /// Constant TO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TO = new PhoneNumberCountryCode("TO");
        /// <summary>
        /// Constant TR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TR = new PhoneNumberCountryCode("TR");
        /// <summary>
        /// Constant TT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TT = new PhoneNumberCountryCode("TT");
        /// <summary>
        /// Constant TV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TV = new PhoneNumberCountryCode("TV");
        /// <summary>
        /// Constant TW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TW = new PhoneNumberCountryCode("TW");
        /// <summary>
        /// Constant TZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TZ = new PhoneNumberCountryCode("TZ");
        /// <summary>
        /// Constant UA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UA = new PhoneNumberCountryCode("UA");
        /// <summary>
        /// Constant UG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UG = new PhoneNumberCountryCode("UG");
        /// <summary>
        /// Constant US for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode US = new PhoneNumberCountryCode("US");
        /// <summary>
        /// Constant UY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UY = new PhoneNumberCountryCode("UY");
        /// <summary>
        /// Constant UZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UZ = new PhoneNumberCountryCode("UZ");
        /// <summary>
        /// Constant VA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VA = new PhoneNumberCountryCode("VA");
        /// <summary>
        /// Constant VC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VC = new PhoneNumberCountryCode("VC");
        /// <summary>
        /// Constant VE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VE = new PhoneNumberCountryCode("VE");
        /// <summary>
        /// Constant VG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VG = new PhoneNumberCountryCode("VG");
        /// <summary>
        /// Constant VI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VI = new PhoneNumberCountryCode("VI");
        /// <summary>
        /// Constant VN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VN = new PhoneNumberCountryCode("VN");
        /// <summary>
        /// Constant VU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VU = new PhoneNumberCountryCode("VU");
        /// <summary>
        /// Constant WF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode WF = new PhoneNumberCountryCode("WF");
        /// <summary>
        /// Constant WS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode WS = new PhoneNumberCountryCode("WS");
        /// <summary>
        /// Constant YE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode YE = new PhoneNumberCountryCode("YE");
        /// <summary>
        /// Constant YT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode YT = new PhoneNumberCountryCode("YT");
        /// <summary>
        /// Constant ZA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ZA = new PhoneNumberCountryCode("ZA");
        /// <summary>
        /// Constant ZM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ZM = new PhoneNumberCountryCode("ZM");
        /// <summary>
        /// Constant ZW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ZW = new PhoneNumberCountryCode("ZW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberCountryCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberCountryCode FindValue(string value)
        {
            return FindValue<PhoneNumberCountryCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberCountryCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberType.
    /// </summary>
    public class PhoneNumberType : ConstantClass
    {

        /// <summary>
        /// Constant DID for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType DID = new PhoneNumberType("DID");
        /// <summary>
        /// Constant TOLL_FREE for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType TOLL_FREE = new PhoneNumberType("TOLL_FREE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberType FindValue(string value)
        {
            return FindValue<PhoneNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneType.
    /// </summary>
    public class PhoneType : ConstantClass
    {

        /// <summary>
        /// Constant DESK_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType DESK_PHONE = new PhoneType("DESK_PHONE");
        /// <summary>
        /// Constant SOFT_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType SOFT_PHONE = new PhoneType("SOFT_PHONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneType FindValue(string value)
        {
            return FindValue<PhoneType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueType.
    /// </summary>
    public class QueueType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for QueueType
        /// </summary>
        public static readonly QueueType AGENT = new QueueType("AGENT");
        /// <summary>
        /// Constant STANDARD for QueueType
        /// </summary>
        public static readonly QueueType STANDARD = new QueueType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueType FindValue(string value)
        {
            return FindValue<QueueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuickConnectType.
    /// </summary>
    public class QuickConnectType : ConstantClass
    {

        /// <summary>
        /// Constant PHONE_NUMBER for QuickConnectType
        /// </summary>
        public static readonly QuickConnectType PHONE_NUMBER = new QuickConnectType("PHONE_NUMBER");
        /// <summary>
        /// Constant QUEUE for QuickConnectType
        /// </summary>
        public static readonly QuickConnectType QUEUE = new QuickConnectType("QUEUE");
        /// <summary>
        /// Constant USER for QuickConnectType
        /// </summary>
        public static readonly QuickConnectType USER = new QuickConnectType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuickConnectType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuickConnectType FindValue(string value)
        {
            return FindValue<QuickConnectType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuickConnectType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceType.
    /// </summary>
    public class ReferenceType : ConstantClass
    {

        /// <summary>
        /// Constant URL for ReferenceType
        /// </summary>
        public static readonly ReferenceType URL = new ReferenceType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceType FindValue(string value)
        {
            return FindValue<ReferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant CONTACT for ResourceType
        /// </summary>
        public static readonly ResourceType CONTACT = new ResourceType("CONTACT");
        /// <summary>
        /// Constant CONTACT_FLOW for ResourceType
        /// </summary>
        public static readonly ResourceType CONTACT_FLOW = new ResourceType("CONTACT_FLOW");
        /// <summary>
        /// Constant HIERARCHY_GROUP for ResourceType
        /// </summary>
        public static readonly ResourceType HIERARCHY_GROUP = new ResourceType("HIERARCHY_GROUP");
        /// <summary>
        /// Constant HIERARCHY_LEVEL for ResourceType
        /// </summary>
        public static readonly ResourceType HIERARCHY_LEVEL = new ResourceType("HIERARCHY_LEVEL");
        /// <summary>
        /// Constant INSTANCE for ResourceType
        /// </summary>
        public static readonly ResourceType INSTANCE = new ResourceType("INSTANCE");
        /// <summary>
        /// Constant PARTICIPANT for ResourceType
        /// </summary>
        public static readonly ResourceType PARTICIPANT = new ResourceType("PARTICIPANT");
        /// <summary>
        /// Constant USER for ResourceType
        /// </summary>
        public static readonly ResourceType USER = new ResourceType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant SALESFORCE for SourceType
        /// </summary>
        public static readonly SourceType SALESFORCE = new SourceType("SALESFORCE");
        /// <summary>
        /// Constant ZENDESK for SourceType
        /// </summary>
        public static readonly SourceType ZENDESK = new SourceType("ZENDESK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
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
        /// Constant AVG for Statistic
        /// </summary>
        public static readonly Statistic AVG = new Statistic("AVG");
        /// <summary>
        /// Constant MAX for Statistic
        /// </summary>
        public static readonly Statistic MAX = new Statistic("MAX");
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
    /// Constants used for properties of type StorageType.
    /// </summary>
    public class StorageType : ConstantClass
    {

        /// <summary>
        /// Constant KINESIS_FIREHOSE for StorageType
        /// </summary>
        public static readonly StorageType KINESIS_FIREHOSE = new StorageType("KINESIS_FIREHOSE");
        /// <summary>
        /// Constant KINESIS_STREAM for StorageType
        /// </summary>
        public static readonly StorageType KINESIS_STREAM = new StorageType("KINESIS_STREAM");
        /// <summary>
        /// Constant KINESIS_VIDEO_STREAM for StorageType
        /// </summary>
        public static readonly StorageType KINESIS_VIDEO_STREAM = new StorageType("KINESIS_VIDEO_STREAM");
        /// <summary>
        /// Constant S3 for StorageType
        /// </summary>
        public static readonly StorageType S3 = new StorageType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageType FindValue(string value)
        {
            return FindValue<StorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageType(string value)
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
        /// Constant COUNT for Unit
        /// </summary>
        public static readonly Unit COUNT = new Unit("COUNT");
        /// <summary>
        /// Constant PERCENT for Unit
        /// </summary>
        public static readonly Unit PERCENT = new Unit("PERCENT");
        /// <summary>
        /// Constant SECONDS for Unit
        /// </summary>
        public static readonly Unit SECONDS = new Unit("SECONDS");

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
    /// Constants used for properties of type UseCaseType.
    /// </summary>
    public class UseCaseType : ConstantClass
    {

        /// <summary>
        /// Constant RULES_EVALUATION for UseCaseType
        /// </summary>
        public static readonly UseCaseType RULES_EVALUATION = new UseCaseType("RULES_EVALUATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UseCaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UseCaseType FindValue(string value)
        {
            return FindValue<UseCaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UseCaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceRecordingTrack.
    /// </summary>
    public class VoiceRecordingTrack : ConstantClass
    {

        /// <summary>
        /// Constant ALL for VoiceRecordingTrack
        /// </summary>
        public static readonly VoiceRecordingTrack ALL = new VoiceRecordingTrack("ALL");
        /// <summary>
        /// Constant FROM_AGENT for VoiceRecordingTrack
        /// </summary>
        public static readonly VoiceRecordingTrack FROM_AGENT = new VoiceRecordingTrack("FROM_AGENT");
        /// <summary>
        /// Constant TO_AGENT for VoiceRecordingTrack
        /// </summary>
        public static readonly VoiceRecordingTrack TO_AGENT = new VoiceRecordingTrack("TO_AGENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceRecordingTrack(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceRecordingTrack FindValue(string value)
        {
            return FindValue<VoiceRecordingTrack>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceRecordingTrack(string value)
        {
            return FindValue(value);
        }
    }

}