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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ConnectHealth
{

    /// <summary>
    /// Constants used for properties of type CustomTemplateBase.
    /// </summary>
    public class CustomTemplateBase : ConstantClass
    {

        /// <summary>
        /// Constant BEHAVIORAL_SOAP for CustomTemplateBase
        /// </summary>
        public static readonly CustomTemplateBase BEHAVIORAL_SOAP = new CustomTemplateBase("BEHAVIORAL_SOAP");
        /// <summary>
        /// Constant BIRP for CustomTemplateBase
        /// </summary>
        public static readonly CustomTemplateBase BIRP = new CustomTemplateBase("BIRP");
        /// <summary>
        /// Constant DAP for CustomTemplateBase
        /// </summary>
        public static readonly CustomTemplateBase DAP = new CustomTemplateBase("DAP");
        /// <summary>
        /// Constant GIRPP for CustomTemplateBase
        /// </summary>
        public static readonly CustomTemplateBase GIRPP = new CustomTemplateBase("GIRPP");
        /// <summary>
        /// Constant HISTORY_AND_PHYSICAL for CustomTemplateBase
        /// </summary>
        public static readonly CustomTemplateBase HISTORY_AND_PHYSICAL = new CustomTemplateBase("HISTORY_AND_PHYSICAL");
        /// <summary>
        /// Constant SIRP for CustomTemplateBase
        /// </summary>
        public static readonly CustomTemplateBase SIRP = new CustomTemplateBase("SIRP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomTemplateBase(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomTemplateBase FindValue(string value)
        {
            return FindValue<CustomTemplateBase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomTemplateBase(string value)
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
        /// Constant DELETED for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETED = new DomainStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETING = new DomainStatus("DELETING");

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
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType AWS_OWNED_KEY = new EncryptionType("AWS_OWNED_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType CUSTOMER_MANAGED_KEY = new EncryptionType("CUSTOMER_MANAGED_KEY");

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
    /// Constants used for properties of type InsightsType.
    /// </summary>
    public class InsightsType : ConstantClass
    {

        /// <summary>
        /// Constant PRE_VISIT for InsightsType
        /// </summary>
        public static readonly InsightsType PRE_VISIT = new InsightsType("PRE_VISIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightsType FindValue(string value)
        {
            return FindValue<InsightsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus SUBMITTED = new JobStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCEEDED for JobStatus
        /// </summary>
        public static readonly JobStatus SUCCEEDED = new JobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedNoteTemplate.
    /// </summary>
    public class ManagedNoteTemplate : ConstantClass
    {

        /// <summary>
        /// Constant BEHAVIORAL_SOAP for ManagedNoteTemplate
        /// </summary>
        public static readonly ManagedNoteTemplate BEHAVIORAL_SOAP = new ManagedNoteTemplate("BEHAVIORAL_SOAP");
        /// <summary>
        /// Constant BIRP for ManagedNoteTemplate
        /// </summary>
        public static readonly ManagedNoteTemplate BIRP = new ManagedNoteTemplate("BIRP");
        /// <summary>
        /// Constant DAP for ManagedNoteTemplate
        /// </summary>
        public static readonly ManagedNoteTemplate DAP = new ManagedNoteTemplate("DAP");
        /// <summary>
        /// Constant GIRPP for ManagedNoteTemplate
        /// </summary>
        public static readonly ManagedNoteTemplate GIRPP = new ManagedNoteTemplate("GIRPP");
        /// <summary>
        /// Constant HISTORY_AND_PHYSICAL for ManagedNoteTemplate
        /// </summary>
        public static readonly ManagedNoteTemplate HISTORY_AND_PHYSICAL = new ManagedNoteTemplate("HISTORY_AND_PHYSICAL");
        /// <summary>
        /// Constant PHYSICAL_SOAP for ManagedNoteTemplate
        /// </summary>
        public static readonly ManagedNoteTemplate PHYSICAL_SOAP = new ManagedNoteTemplate("PHYSICAL_SOAP");
        /// <summary>
        /// Constant SIRP for ManagedNoteTemplate
        /// </summary>
        public static readonly ManagedNoteTemplate SIRP = new ManagedNoteTemplate("SIRP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedNoteTemplate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedNoteTemplate FindValue(string value)
        {
            return FindValue<ManagedNoteTemplate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedNoteTemplate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeLanguageCode.
    /// </summary>
    public class MedicalScribeLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant EnUS for MedicalScribeLanguageCode
        /// </summary>
        public static readonly MedicalScribeLanguageCode EnUS = new MedicalScribeLanguageCode("en-US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeLanguageCode FindValue(string value)
        {
            return FindValue<MedicalScribeLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeMediaEncoding.
    /// </summary>
    public class MedicalScribeMediaEncoding : ConstantClass
    {

        /// <summary>
        /// Constant Flac for MedicalScribeMediaEncoding
        /// </summary>
        public static readonly MedicalScribeMediaEncoding Flac = new MedicalScribeMediaEncoding("flac");
        /// <summary>
        /// Constant Pcm for MedicalScribeMediaEncoding
        /// </summary>
        public static readonly MedicalScribeMediaEncoding Pcm = new MedicalScribeMediaEncoding("pcm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeMediaEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeMediaEncoding FindValue(string value)
        {
            return FindValue<MedicalScribeMediaEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeMediaEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeParticipantRole.
    /// </summary>
    public class MedicalScribeParticipantRole : ConstantClass
    {

        /// <summary>
        /// Constant CLINICIAN for MedicalScribeParticipantRole
        /// </summary>
        public static readonly MedicalScribeParticipantRole CLINICIAN = new MedicalScribeParticipantRole("CLINICIAN");
        /// <summary>
        /// Constant PATIENT for MedicalScribeParticipantRole
        /// </summary>
        public static readonly MedicalScribeParticipantRole PATIENT = new MedicalScribeParticipantRole("PATIENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeParticipantRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeParticipantRole FindValue(string value)
        {
            return FindValue<MedicalScribeParticipantRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeParticipantRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeSessionControlEventType.
    /// </summary>
    public class MedicalScribeSessionControlEventType : ConstantClass
    {

        /// <summary>
        /// Constant END_OF_SESSION for MedicalScribeSessionControlEventType
        /// </summary>
        public static readonly MedicalScribeSessionControlEventType END_OF_SESSION = new MedicalScribeSessionControlEventType("END_OF_SESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeSessionControlEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeSessionControlEventType FindValue(string value)
        {
            return FindValue<MedicalScribeSessionControlEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeSessionControlEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MedicalScribeStreamStatus.
    /// </summary>
    public class MedicalScribeStreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus COMPLETED = new MedicalScribeStreamStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus FAILED = new MedicalScribeStreamStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus IN_PROGRESS = new MedicalScribeStreamStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PAUSED for MedicalScribeStreamStatus
        /// </summary>
        public static readonly MedicalScribeStreamStatus PAUSED = new MedicalScribeStreamStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MedicalScribeStreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MedicalScribeStreamStatus FindValue(string value)
        {
            return FindValue<MedicalScribeStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MedicalScribeStreamStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PostStreamArtifactGenerationStatus.
    /// </summary>
    public class PostStreamArtifactGenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for PostStreamArtifactGenerationStatus
        /// </summary>
        public static readonly PostStreamArtifactGenerationStatus COMPLETED = new PostStreamArtifactGenerationStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for PostStreamArtifactGenerationStatus
        /// </summary>
        public static readonly PostStreamArtifactGenerationStatus FAILED = new PostStreamArtifactGenerationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for PostStreamArtifactGenerationStatus
        /// </summary>
        public static readonly PostStreamArtifactGenerationStatus IN_PROGRESS = new PostStreamArtifactGenerationStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PostStreamArtifactGenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostStreamArtifactGenerationStatus FindValue(string value)
        {
            return FindValue<PostStreamArtifactGenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostStreamArtifactGenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Pronouns.
    /// </summary>
    public class Pronouns : ConstantClass
    {

        /// <summary>
        /// Constant HE_HIM for Pronouns
        /// </summary>
        public static readonly Pronouns HE_HIM = new Pronouns("HE_HIM");
        /// <summary>
        /// Constant SHE_HER for Pronouns
        /// </summary>
        public static readonly Pronouns SHE_HER = new Pronouns("SHE_HER");
        /// <summary>
        /// Constant THEY_THEM for Pronouns
        /// </summary>
        public static readonly Pronouns THEY_THEM = new Pronouns("THEY_THEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Pronouns(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Pronouns FindValue(string value)
        {
            return FindValue<Pronouns>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Pronouns(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProviderRole.
    /// </summary>
    public class ProviderRole : ConstantClass
    {

        /// <summary>
        /// Constant CLINICIAN for ProviderRole
        /// </summary>
        public static readonly ProviderRole CLINICIAN = new ProviderRole("CLINICIAN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProviderRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProviderRole FindValue(string value)
        {
            return FindValue<ProviderRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProviderRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Specialty.
    /// </summary>
    public class Specialty : ConstantClass
    {

        /// <summary>
        /// Constant PRIMARY_CARE for Specialty
        /// </summary>
        public static readonly Specialty PRIMARY_CARE = new Specialty("PRIMARY_CARE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Specialty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Specialty FindValue(string value)
        {
            return FindValue<Specialty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Specialty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionStatus.
    /// </summary>
    public class SubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus ACTIVE = new SubscriptionStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus DELETED = new SubscriptionStatus("DELETED");
        /// <summary>
        /// Constant INACTIVE for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus INACTIVE = new SubscriptionStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionStatus FindValue(string value)
        {
            return FindValue<SubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }

}