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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.ConnectHealth
{
    /// <summary>
    /// Constants used for properties of type ChecklistItemStatus.
    /// </summary>
    public class ChecklistItemStatus : ConstantClass
    {
        /// <summary>
        /// Constant DISCUSSED for ChecklistItemStatus
        /// </summary>
        public static readonly ChecklistItemStatus DISCUSSED = new ChecklistItemStatus("DISCUSSED");

        /// <summary>
        /// Constant NOT_DISCUSSED for ChecklistItemStatus
        /// </summary>
        public static readonly ChecklistItemStatus NOT_DISCUSSED = new ChecklistItemStatus("NOT_DISCUSSED");

        /// <summary>
        /// Constant PARTIALLY_DISCUSSED for ChecklistItemStatus
        /// </summary>
        public static readonly ChecklistItemStatus PARTIALLY_DISCUSSED = new ChecklistItemStatus("PARTIALLY_DISCUSSED");

        /// <summary>
        /// Constructs a custom ChecklistItemStatus for a value not among the defined constants.
        /// </summary>
        public ChecklistItemStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecklistItemStatus FindValue(string value)
        {
            return FindValue<ChecklistItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecklistItemStatus(string value)
        {
            return FindValue(value);
        }
    }

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
        /// Constructs a custom CustomTemplateBase for a value not among the defined constants.
        /// </summary>
        public CustomTemplateBase(string value) : base(value) { }

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
    /// Constants used for properties of type DatasetStatus.
    /// </summary>
    public class DatasetStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus ACTIVE = new DatasetStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATE_FAILED = new DatasetStatus("CREATE_FAILED");

        /// <summary>
        /// Constant CREATING for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATING = new DatasetStatus("CREATING");

        /// <summary>
        /// Constant DELETED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETED = new DatasetStatus("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETE_FAILED = new DatasetStatus("DELETE_FAILED");

        /// <summary>
        /// Constant DELETING for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETING = new DatasetStatus("DELETING");

        /// <summary>
        /// Constructs a custom DatasetStatus for a value not among the defined constants.
        /// </summary>
        public DatasetStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetStatus FindValue(string value)
        {
            return FindValue<DatasetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DatasetType.
    /// </summary>
    public class DatasetType : ConstantClass
    {
        /// <summary>
        /// Constant MEDICAL_CODING for DatasetType
        /// </summary>
        public static readonly DatasetType MEDICAL_CODING = new DatasetType("MEDICAL_CODING");

        /// <summary>
        /// Constructs a custom DatasetType for a value not among the defined constants.
        /// </summary>
        public DatasetType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetType FindValue(string value)
        {
            return FindValue<DatasetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetType(string value)
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
        /// Constructs a custom DomainStatus for a value not among the defined constants.
        /// </summary>
        public DomainStatus(string value) : base(value) { }

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
    /// Constants used for properties of type EncounterType.
    /// </summary>
    public class EncounterType : ConstantClass
    {
        /// <summary>
        /// Constant IN_PERSON for EncounterType
        /// </summary>
        public static readonly EncounterType IN_PERSON = new EncounterType("IN_PERSON");

        /// <summary>
        /// Constant TELEHEALTH for EncounterType
        /// </summary>
        public static readonly EncounterType TELEHEALTH = new EncounterType("TELEHEALTH");

        /// <summary>
        /// Constructs a custom EncounterType for a value not among the defined constants.
        /// </summary>
        public EncounterType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncounterType FindValue(string value)
        {
            return FindValue<EncounterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncounterType(string value)
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
        /// Constructs a custom EncryptionType for a value not among the defined constants.
        /// </summary>
        public EncryptionType(string value) : base(value) { }

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
    /// Constants used for properties of type FeedbackArtifactType.
    /// </summary>
    public class FeedbackArtifactType : ConstantClass
    {
        /// <summary>
        /// Constant CLINICAL_DOC for FeedbackArtifactType
        /// </summary>
        public static readonly FeedbackArtifactType CLINICAL_DOC = new FeedbackArtifactType("CLINICAL_DOC");

        /// <summary>
        /// Constant MEDICAL_CODES for FeedbackArtifactType
        /// </summary>
        public static readonly FeedbackArtifactType MEDICAL_CODES = new FeedbackArtifactType("MEDICAL_CODES");

        /// <summary>
        /// Constructs a custom FeedbackArtifactType for a value not among the defined constants.
        /// </summary>
        public FeedbackArtifactType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedbackArtifactType FindValue(string value)
        {
            return FindValue<FeedbackArtifactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedbackArtifactType(string value)
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
        /// Constructs a custom InsightsType for a value not among the defined constants.
        /// </summary>
        public InsightsType(string value) : base(value) { }

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
        /// Constructs a custom JobStatus for a value not among the defined constants.
        /// </summary>
        public JobStatus(string value) : base(value) { }

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
        /// Constructs a custom ManagedNoteTemplate for a value not among the defined constants.
        /// </summary>
        public ManagedNoteTemplate(string value) : base(value) { }

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
        /// Constant Multi for MedicalScribeLanguageCode
        /// </summary>
        public static readonly MedicalScribeLanguageCode Multi = new MedicalScribeLanguageCode("multi");

        /// <summary>
        /// Constructs a custom MedicalScribeLanguageCode for a value not among the defined constants.
        /// </summary>
        public MedicalScribeLanguageCode(string value) : base(value) { }

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
        /// Constructs a custom MedicalScribeMediaEncoding for a value not among the defined constants.
        /// </summary>
        public MedicalScribeMediaEncoding(string value) : base(value) { }

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
        /// Constructs a custom MedicalScribeParticipantRole for a value not among the defined constants.
        /// </summary>
        public MedicalScribeParticipantRole(string value) : base(value) { }

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
        /// Constructs a custom MedicalScribeSessionControlEventType for a value not among the defined constants.
        /// </summary>
        public MedicalScribeSessionControlEventType(string value) : base(value) { }

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
        /// Constructs a custom MedicalScribeStreamStatus for a value not among the defined constants.
        /// </summary>
        public MedicalScribeStreamStatus(string value) : base(value) { }

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
    /// Constants used for properties of type PatientStatus.
    /// </summary>
    public class PatientStatus : ConstantClass
    {
        /// <summary>
        /// Constant ESTABLISHED for PatientStatus
        /// </summary>
        public static readonly PatientStatus ESTABLISHED = new PatientStatus("ESTABLISHED");

        /// <summary>
        /// Constant NEW for PatientStatus
        /// </summary>
        public static readonly PatientStatus NEW = new PatientStatus("NEW");

        /// <summary>
        /// Constructs a custom PatientStatus for a value not among the defined constants.
        /// </summary>
        public PatientStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatientStatus FindValue(string value)
        {
            return FindValue<PatientStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatientStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PeriodontalReviewReason.
    /// </summary>
    public class PeriodontalReviewReason : ConstantClass
    {
        /// <summary>
        /// Constant LINE_UNCLEAR for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason LINE_UNCLEAR = new PeriodontalReviewReason("LINE_UNCLEAR");

        /// <summary>
        /// Constant MEASUREMENT_NOT_CHARTED for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason MEASUREMENT_NOT_CHARTED = new PeriodontalReviewReason("MEASUREMENT_NOT_CHARTED");

        /// <summary>
        /// Constant MISSING_TOOTH_CONFLICT for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason MISSING_TOOTH_CONFLICT = new PeriodontalReviewReason("MISSING_TOOTH_CONFLICT");

        /// <summary>
        /// Constant READING_COUNT_MISMATCH for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason READING_COUNT_MISMATCH = new PeriodontalReviewReason("READING_COUNT_MISMATCH");

        /// <summary>
        /// Constant SESSION_ISSUE for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason SESSION_ISSUE = new PeriodontalReviewReason("SESSION_ISSUE");

        /// <summary>
        /// Constant SITE_NOT_CHARTED for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason SITE_NOT_CHARTED = new PeriodontalReviewReason("SITE_NOT_CHARTED");

        /// <summary>
        /// Constant TOOTH_UNCLEAR for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason TOOTH_UNCLEAR = new PeriodontalReviewReason("TOOTH_UNCLEAR");

        /// <summary>
        /// Constant VALUE_NOT_CHARTED for PeriodontalReviewReason
        /// </summary>
        public static readonly PeriodontalReviewReason VALUE_NOT_CHARTED = new PeriodontalReviewReason("VALUE_NOT_CHARTED");

        /// <summary>
        /// Constructs a custom PeriodontalReviewReason for a value not among the defined constants.
        /// </summary>
        public PeriodontalReviewReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeriodontalReviewReason FindValue(string value)
        {
            return FindValue<PeriodontalReviewReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeriodontalReviewReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PeriodontalSiteName.
    /// </summary>
    public class PeriodontalSiteName : ConstantClass
    {
        /// <summary>
        /// Constant B for PeriodontalSiteName
        /// </summary>
        public static readonly PeriodontalSiteName B = new PeriodontalSiteName("B");

        /// <summary>
        /// Constant DB for PeriodontalSiteName
        /// </summary>
        public static readonly PeriodontalSiteName DB = new PeriodontalSiteName("DB");

        /// <summary>
        /// Constant DL for PeriodontalSiteName
        /// </summary>
        public static readonly PeriodontalSiteName DL = new PeriodontalSiteName("DL");

        /// <summary>
        /// Constant L for PeriodontalSiteName
        /// </summary>
        public static readonly PeriodontalSiteName L = new PeriodontalSiteName("L");

        /// <summary>
        /// Constant MB for PeriodontalSiteName
        /// </summary>
        public static readonly PeriodontalSiteName MB = new PeriodontalSiteName("MB");

        /// <summary>
        /// Constant ML for PeriodontalSiteName
        /// </summary>
        public static readonly PeriodontalSiteName ML = new PeriodontalSiteName("ML");

        /// <summary>
        /// Constructs a custom PeriodontalSiteName for a value not among the defined constants.
        /// </summary>
        public PeriodontalSiteName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeriodontalSiteName FindValue(string value)
        {
            return FindValue<PeriodontalSiteName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeriodontalSiteName(string value)
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
        /// Constant PENDING for PostStreamArtifactGenerationStatus
        /// </summary>
        public static readonly PostStreamArtifactGenerationStatus PENDING = new PostStreamArtifactGenerationStatus("PENDING");

        /// <summary>
        /// Constant SKIPPED for PostStreamArtifactGenerationStatus
        /// </summary>
        public static readonly PostStreamArtifactGenerationStatus SKIPPED = new PostStreamArtifactGenerationStatus("SKIPPED");

        /// <summary>
        /// Constructs a custom PostStreamArtifactGenerationStatus for a value not among the defined constants.
        /// </summary>
        public PostStreamArtifactGenerationStatus(string value) : base(value) { }

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
        /// Constructs a custom Pronouns for a value not among the defined constants.
        /// </summary>
        public Pronouns(string value) : base(value) { }

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
        /// Constructs a custom ProviderRole for a value not among the defined constants.
        /// </summary>
        public ProviderRole(string value) : base(value) { }

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
    /// Constants used for properties of type Sex.
    /// </summary>
    public class Sex : ConstantClass
    {
        /// <summary>
        /// Constant FEMALE for Sex
        /// </summary>
        public static readonly Sex FEMALE = new Sex("FEMALE");

        /// <summary>
        /// Constant MALE for Sex
        /// </summary>
        public static readonly Sex MALE = new Sex("MALE");

        /// <summary>
        /// Constant NON_BINARY for Sex
        /// </summary>
        public static readonly Sex NON_BINARY = new Sex("NON_BINARY");

        /// <summary>
        /// Constant UNKNOWN for Sex
        /// </summary>
        public static readonly Sex UNKNOWN = new Sex("UNKNOWN");

        /// <summary>
        /// Constructs a custom Sex for a value not among the defined constants.
        /// </summary>
        public Sex(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Sex FindValue(string value)
        {
            return FindValue<Sex>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Sex(string value)
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
        /// Constructs a custom Specialty for a value not among the defined constants.
        /// </summary>
        public Specialty(string value) : base(value) { }

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
        /// Constructs a custom SubscriptionStatus for a value not among the defined constants.
        /// </summary>
        public SubscriptionStatus(string value) : base(value) { }

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
