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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.VoiceID
{

    /// <summary>
    /// Constants used for properties of type AuthenticationDecision.
    /// </summary>
    public class AuthenticationDecision : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT for AuthenticationDecision
        /// </summary>
        public static readonly AuthenticationDecision ACCEPT = new AuthenticationDecision("ACCEPT");
        /// <summary>
        /// Constant NOT_ENOUGH_SPEECH for AuthenticationDecision
        /// </summary>
        public static readonly AuthenticationDecision NOT_ENOUGH_SPEECH = new AuthenticationDecision("NOT_ENOUGH_SPEECH");
        /// <summary>
        /// Constant REJECT for AuthenticationDecision
        /// </summary>
        public static readonly AuthenticationDecision REJECT = new AuthenticationDecision("REJECT");
        /// <summary>
        /// Constant SPEAKER_EXPIRED for AuthenticationDecision
        /// </summary>
        public static readonly AuthenticationDecision SPEAKER_EXPIRED = new AuthenticationDecision("SPEAKER_EXPIRED");
        /// <summary>
        /// Constant SPEAKER_ID_NOT_PROVIDED for AuthenticationDecision
        /// </summary>
        public static readonly AuthenticationDecision SPEAKER_ID_NOT_PROVIDED = new AuthenticationDecision("SPEAKER_ID_NOT_PROVIDED");
        /// <summary>
        /// Constant SPEAKER_NOT_ENROLLED for AuthenticationDecision
        /// </summary>
        public static readonly AuthenticationDecision SPEAKER_NOT_ENROLLED = new AuthenticationDecision("SPEAKER_NOT_ENROLLED");
        /// <summary>
        /// Constant SPEAKER_OPTED_OUT for AuthenticationDecision
        /// </summary>
        public static readonly AuthenticationDecision SPEAKER_OPTED_OUT = new AuthenticationDecision("SPEAKER_OPTED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationDecision(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationDecision FindValue(string value)
        {
            return FindValue<AuthenticationDecision>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationDecision(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictType.
    /// </summary>
    public class ConflictType : ConstantClass
    {

        /// <summary>
        /// Constant ANOTHER_ACTIVE_STREAM for ConflictType
        /// </summary>
        public static readonly ConflictType ANOTHER_ACTIVE_STREAM = new ConflictType("ANOTHER_ACTIVE_STREAM");
        /// <summary>
        /// Constant CANNOT_CHANGE_SPEAKER_AFTER_ENROLLMENT for ConflictType
        /// </summary>
        public static readonly ConflictType CANNOT_CHANGE_SPEAKER_AFTER_ENROLLMENT = new ConflictType("CANNOT_CHANGE_SPEAKER_AFTER_ENROLLMENT");
        /// <summary>
        /// Constant CANNOT_DELETE_NON_EMPTY_WATCHLIST for ConflictType
        /// </summary>
        public static readonly ConflictType CANNOT_DELETE_NON_EMPTY_WATCHLIST = new ConflictType("CANNOT_DELETE_NON_EMPTY_WATCHLIST");
        /// <summary>
        /// Constant CONCURRENT_CHANGES for ConflictType
        /// </summary>
        public static readonly ConflictType CONCURRENT_CHANGES = new ConflictType("CONCURRENT_CHANGES");
        /// <summary>
        /// Constant DOMAIN_LOCKED_FROM_ENCRYPTION_UPDATES for ConflictType
        /// </summary>
        public static readonly ConflictType DOMAIN_LOCKED_FROM_ENCRYPTION_UPDATES = new ConflictType("DOMAIN_LOCKED_FROM_ENCRYPTION_UPDATES");
        /// <summary>
        /// Constant DOMAIN_NOT_ACTIVE for ConflictType
        /// </summary>
        public static readonly ConflictType DOMAIN_NOT_ACTIVE = new ConflictType("DOMAIN_NOT_ACTIVE");
        /// <summary>
        /// Constant ENROLLMENT_ALREADY_EXISTS for ConflictType
        /// </summary>
        public static readonly ConflictType ENROLLMENT_ALREADY_EXISTS = new ConflictType("ENROLLMENT_ALREADY_EXISTS");
        /// <summary>
        /// Constant FRAUDSTER_MUST_BELONG_TO_AT_LEAST_ONE_WATCHLIST for ConflictType
        /// </summary>
        public static readonly ConflictType FRAUDSTER_MUST_BELONG_TO_AT_LEAST_ONE_WATCHLIST = new ConflictType("FRAUDSTER_MUST_BELONG_TO_AT_LEAST_ONE_WATCHLIST");
        /// <summary>
        /// Constant SPEAKER_NOT_SET for ConflictType
        /// </summary>
        public static readonly ConflictType SPEAKER_NOT_SET = new ConflictType("SPEAKER_NOT_SET");
        /// <summary>
        /// Constant SPEAKER_OPTED_OUT for ConflictType
        /// </summary>
        public static readonly ConflictType SPEAKER_OPTED_OUT = new ConflictType("SPEAKER_OPTED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictType FindValue(string value)
        {
            return FindValue<ConflictType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatus.
    /// </summary>
    public class DomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DomainStatus
        /// </summary>
        public static readonly DomainStatus ACTIVE = new DomainStatus("ACTIVE");
        /// <summary>
        /// Constant PENDING for DomainStatus
        /// </summary>
        public static readonly DomainStatus PENDING = new DomainStatus("PENDING");
        /// <summary>
        /// Constant SUSPENDED for DomainStatus
        /// </summary>
        public static readonly DomainStatus SUSPENDED = new DomainStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatus FindValue(string value)
        {
            return FindValue<DomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DuplicateRegistrationAction.
    /// </summary>
    public class DuplicateRegistrationAction : ConstantClass
    {

        /// <summary>
        /// Constant REGISTER_AS_NEW for DuplicateRegistrationAction
        /// </summary>
        public static readonly DuplicateRegistrationAction REGISTER_AS_NEW = new DuplicateRegistrationAction("REGISTER_AS_NEW");
        /// <summary>
        /// Constant SKIP for DuplicateRegistrationAction
        /// </summary>
        public static readonly DuplicateRegistrationAction SKIP = new DuplicateRegistrationAction("SKIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DuplicateRegistrationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DuplicateRegistrationAction FindValue(string value)
        {
            return FindValue<DuplicateRegistrationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DuplicateRegistrationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExistingEnrollmentAction.
    /// </summary>
    public class ExistingEnrollmentAction : ConstantClass
    {

        /// <summary>
        /// Constant OVERWRITE for ExistingEnrollmentAction
        /// </summary>
        public static readonly ExistingEnrollmentAction OVERWRITE = new ExistingEnrollmentAction("OVERWRITE");
        /// <summary>
        /// Constant SKIP for ExistingEnrollmentAction
        /// </summary>
        public static readonly ExistingEnrollmentAction SKIP = new ExistingEnrollmentAction("SKIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExistingEnrollmentAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExistingEnrollmentAction FindValue(string value)
        {
            return FindValue<ExistingEnrollmentAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExistingEnrollmentAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FraudDetectionAction.
    /// </summary>
    public class FraudDetectionAction : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for FraudDetectionAction
        /// </summary>
        public static readonly FraudDetectionAction FAIL = new FraudDetectionAction("FAIL");
        /// <summary>
        /// Constant IGNORE for FraudDetectionAction
        /// </summary>
        public static readonly FraudDetectionAction IGNORE = new FraudDetectionAction("IGNORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FraudDetectionAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FraudDetectionAction FindValue(string value)
        {
            return FindValue<FraudDetectionAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FraudDetectionAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FraudDetectionDecision.
    /// </summary>
    public class FraudDetectionDecision : ConstantClass
    {

        /// <summary>
        /// Constant HIGH_RISK for FraudDetectionDecision
        /// </summary>
        public static readonly FraudDetectionDecision HIGH_RISK = new FraudDetectionDecision("HIGH_RISK");
        /// <summary>
        /// Constant LOW_RISK for FraudDetectionDecision
        /// </summary>
        public static readonly FraudDetectionDecision LOW_RISK = new FraudDetectionDecision("LOW_RISK");
        /// <summary>
        /// Constant NOT_ENOUGH_SPEECH for FraudDetectionDecision
        /// </summary>
        public static readonly FraudDetectionDecision NOT_ENOUGH_SPEECH = new FraudDetectionDecision("NOT_ENOUGH_SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FraudDetectionDecision(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FraudDetectionDecision FindValue(string value)
        {
            return FindValue<FraudDetectionDecision>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FraudDetectionDecision(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FraudDetectionReason.
    /// </summary>
    public class FraudDetectionReason : ConstantClass
    {

        /// <summary>
        /// Constant KNOWN_FRAUDSTER for FraudDetectionReason
        /// </summary>
        public static readonly FraudDetectionReason KNOWN_FRAUDSTER = new FraudDetectionReason("KNOWN_FRAUDSTER");
        /// <summary>
        /// Constant VOICE_SPOOFING for FraudDetectionReason
        /// </summary>
        public static readonly FraudDetectionReason VOICE_SPOOFING = new FraudDetectionReason("VOICE_SPOOFING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FraudDetectionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FraudDetectionReason FindValue(string value)
        {
            return FindValue<FraudDetectionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FraudDetectionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FraudsterRegistrationJobStatus.
    /// </summary>
    public class FraudsterRegistrationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for FraudsterRegistrationJobStatus
        /// </summary>
        public static readonly FraudsterRegistrationJobStatus COMPLETED = new FraudsterRegistrationJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for FraudsterRegistrationJobStatus
        /// </summary>
        public static readonly FraudsterRegistrationJobStatus COMPLETED_WITH_ERRORS = new FraudsterRegistrationJobStatus("COMPLETED_WITH_ERRORS");
        /// <summary>
        /// Constant FAILED for FraudsterRegistrationJobStatus
        /// </summary>
        public static readonly FraudsterRegistrationJobStatus FAILED = new FraudsterRegistrationJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for FraudsterRegistrationJobStatus
        /// </summary>
        public static readonly FraudsterRegistrationJobStatus IN_PROGRESS = new FraudsterRegistrationJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for FraudsterRegistrationJobStatus
        /// </summary>
        public static readonly FraudsterRegistrationJobStatus SUBMITTED = new FraudsterRegistrationJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FraudsterRegistrationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FraudsterRegistrationJobStatus FindValue(string value)
        {
            return FindValue<FraudsterRegistrationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FraudsterRegistrationJobStatus(string value)
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
        /// Constant BATCH_JOB for ResourceType
        /// </summary>
        public static readonly ResourceType BATCH_JOB = new ResourceType("BATCH_JOB");
        /// <summary>
        /// Constant COMPLIANCE_CONSENT for ResourceType
        /// </summary>
        public static readonly ResourceType COMPLIANCE_CONSENT = new ResourceType("COMPLIANCE_CONSENT");
        /// <summary>
        /// Constant DOMAIN for ResourceType
        /// </summary>
        public static readonly ResourceType DOMAIN = new ResourceType("DOMAIN");
        /// <summary>
        /// Constant FRAUDSTER for ResourceType
        /// </summary>
        public static readonly ResourceType FRAUDSTER = new ResourceType("FRAUDSTER");
        /// <summary>
        /// Constant SESSION for ResourceType
        /// </summary>
        public static readonly ResourceType SESSION = new ResourceType("SESSION");
        /// <summary>
        /// Constant SPEAKER for ResourceType
        /// </summary>
        public static readonly ResourceType SPEAKER = new ResourceType("SPEAKER");
        /// <summary>
        /// Constant WATCHLIST for ResourceType
        /// </summary>
        public static readonly ResourceType WATCHLIST = new ResourceType("WATCHLIST");

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
    /// Constants used for properties of type ServerSideEncryptionUpdateStatus.
    /// </summary>
    public class ServerSideEncryptionUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ServerSideEncryptionUpdateStatus
        /// </summary>
        public static readonly ServerSideEncryptionUpdateStatus COMPLETED = new ServerSideEncryptionUpdateStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ServerSideEncryptionUpdateStatus
        /// </summary>
        public static readonly ServerSideEncryptionUpdateStatus FAILED = new ServerSideEncryptionUpdateStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ServerSideEncryptionUpdateStatus
        /// </summary>
        public static readonly ServerSideEncryptionUpdateStatus IN_PROGRESS = new ServerSideEncryptionUpdateStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerSideEncryptionUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerSideEncryptionUpdateStatus FindValue(string value)
        {
            return FindValue<ServerSideEncryptionUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerSideEncryptionUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpeakerEnrollmentJobStatus.
    /// </summary>
    public class SpeakerEnrollmentJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SpeakerEnrollmentJobStatus
        /// </summary>
        public static readonly SpeakerEnrollmentJobStatus COMPLETED = new SpeakerEnrollmentJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for SpeakerEnrollmentJobStatus
        /// </summary>
        public static readonly SpeakerEnrollmentJobStatus COMPLETED_WITH_ERRORS = new SpeakerEnrollmentJobStatus("COMPLETED_WITH_ERRORS");
        /// <summary>
        /// Constant FAILED for SpeakerEnrollmentJobStatus
        /// </summary>
        public static readonly SpeakerEnrollmentJobStatus FAILED = new SpeakerEnrollmentJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for SpeakerEnrollmentJobStatus
        /// </summary>
        public static readonly SpeakerEnrollmentJobStatus IN_PROGRESS = new SpeakerEnrollmentJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for SpeakerEnrollmentJobStatus
        /// </summary>
        public static readonly SpeakerEnrollmentJobStatus SUBMITTED = new SpeakerEnrollmentJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpeakerEnrollmentJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpeakerEnrollmentJobStatus FindValue(string value)
        {
            return FindValue<SpeakerEnrollmentJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpeakerEnrollmentJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpeakerStatus.
    /// </summary>
    public class SpeakerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENROLLED for SpeakerStatus
        /// </summary>
        public static readonly SpeakerStatus ENROLLED = new SpeakerStatus("ENROLLED");
        /// <summary>
        /// Constant EXPIRED for SpeakerStatus
        /// </summary>
        public static readonly SpeakerStatus EXPIRED = new SpeakerStatus("EXPIRED");
        /// <summary>
        /// Constant OPTED_OUT for SpeakerStatus
        /// </summary>
        public static readonly SpeakerStatus OPTED_OUT = new SpeakerStatus("OPTED_OUT");
        /// <summary>
        /// Constant PENDING for SpeakerStatus
        /// </summary>
        public static readonly SpeakerStatus PENDING = new SpeakerStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpeakerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpeakerStatus FindValue(string value)
        {
            return FindValue<SpeakerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpeakerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingStatus.
    /// </summary>
    public class StreamingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENDED for StreamingStatus
        /// </summary>
        public static readonly StreamingStatus ENDED = new StreamingStatus("ENDED");
        /// <summary>
        /// Constant ONGOING for StreamingStatus
        /// </summary>
        public static readonly StreamingStatus ONGOING = new StreamingStatus("ONGOING");
        /// <summary>
        /// Constant PENDING_CONFIGURATION for StreamingStatus
        /// </summary>
        public static readonly StreamingStatus PENDING_CONFIGURATION = new StreamingStatus("PENDING_CONFIGURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingStatus FindValue(string value)
        {
            return FindValue<StreamingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingStatus(string value)
        {
            return FindValue(value);
        }
    }

}