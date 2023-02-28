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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Omics
{

    /// <summary>
    /// Constants used for properties of type AnnotationType.
    /// </summary>
    public class AnnotationType : ConstantClass
    {

        /// <summary>
        /// Constant CHR_POS for AnnotationType
        /// </summary>
        public static readonly AnnotationType CHR_POS = new AnnotationType("CHR_POS");
        /// <summary>
        /// Constant CHR_POS_REF_ALT for AnnotationType
        /// </summary>
        public static readonly AnnotationType CHR_POS_REF_ALT = new AnnotationType("CHR_POS_REF_ALT");
        /// <summary>
        /// Constant CHR_START_END_ONE_BASE for AnnotationType
        /// </summary>
        public static readonly AnnotationType CHR_START_END_ONE_BASE = new AnnotationType("CHR_START_END_ONE_BASE");
        /// <summary>
        /// Constant CHR_START_END_REF_ALT_ONE_BASE for AnnotationType
        /// </summary>
        public static readonly AnnotationType CHR_START_END_REF_ALT_ONE_BASE = new AnnotationType("CHR_START_END_REF_ALT_ONE_BASE");
        /// <summary>
        /// Constant CHR_START_END_REF_ALT_ZERO_BASE for AnnotationType
        /// </summary>
        public static readonly AnnotationType CHR_START_END_REF_ALT_ZERO_BASE = new AnnotationType("CHR_START_END_REF_ALT_ZERO_BASE");
        /// <summary>
        /// Constant CHR_START_END_ZERO_BASE for AnnotationType
        /// </summary>
        public static readonly AnnotationType CHR_START_END_ZERO_BASE = new AnnotationType("CHR_START_END_ZERO_BASE");
        /// <summary>
        /// Constant GENERIC for AnnotationType
        /// </summary>
        public static readonly AnnotationType GENERIC = new AnnotationType("GENERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnnotationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnnotationType FindValue(string value)
        {
            return FindValue<AnnotationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnnotationType(string value)
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
    /// Constants used for properties of type FileType.
    /// </summary>
    public class FileType : ConstantClass
    {

        /// <summary>
        /// Constant BAM for FileType
        /// </summary>
        public static readonly FileType BAM = new FileType("BAM");
        /// <summary>
        /// Constant CRAM for FileType
        /// </summary>
        public static readonly FileType CRAM = new FileType("CRAM");
        /// <summary>
        /// Constant FASTQ for FileType
        /// </summary>
        public static readonly FileType FASTQ = new FileType("FASTQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileType FindValue(string value)
        {
            return FindValue<FileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormatToHeaderKey.
    /// </summary>
    public class FormatToHeaderKey : ConstantClass
    {

        /// <summary>
        /// Constant ALT for FormatToHeaderKey
        /// </summary>
        public static readonly FormatToHeaderKey ALT = new FormatToHeaderKey("ALT");
        /// <summary>
        /// Constant CHR for FormatToHeaderKey
        /// </summary>
        public static readonly FormatToHeaderKey CHR = new FormatToHeaderKey("CHR");
        /// <summary>
        /// Constant END for FormatToHeaderKey
        /// </summary>
        public static readonly FormatToHeaderKey END = new FormatToHeaderKey("END");
        /// <summary>
        /// Constant POS for FormatToHeaderKey
        /// </summary>
        public static readonly FormatToHeaderKey POS = new FormatToHeaderKey("POS");
        /// <summary>
        /// Constant REF for FormatToHeaderKey
        /// </summary>
        public static readonly FormatToHeaderKey REF = new FormatToHeaderKey("REF");
        /// <summary>
        /// Constant START for FormatToHeaderKey
        /// </summary>
        public static readonly FormatToHeaderKey START = new FormatToHeaderKey("START");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormatToHeaderKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormatToHeaderKey FindValue(string value)
        {
            return FindValue<FormatToHeaderKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormatToHeaderKey(string value)
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
        /// Constant CANCELLED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELLED = new JobStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED_WITH_FAILURES = new JobStatus("COMPLETED_WITH_FAILURES");
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
    /// Constants used for properties of type ReadSetActivationJobItemStatus.
    /// </summary>
    public class ReadSetActivationJobItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ReadSetActivationJobItemStatus
        /// </summary>
        public static readonly ReadSetActivationJobItemStatus FAILED = new ReadSetActivationJobItemStatus("FAILED");
        /// <summary>
        /// Constant FINISHED for ReadSetActivationJobItemStatus
        /// </summary>
        public static readonly ReadSetActivationJobItemStatus FINISHED = new ReadSetActivationJobItemStatus("FINISHED");
        /// <summary>
        /// Constant IN_PROGRESS for ReadSetActivationJobItemStatus
        /// </summary>
        public static readonly ReadSetActivationJobItemStatus IN_PROGRESS = new ReadSetActivationJobItemStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ReadSetActivationJobItemStatus
        /// </summary>
        public static readonly ReadSetActivationJobItemStatus NOT_STARTED = new ReadSetActivationJobItemStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetActivationJobItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetActivationJobItemStatus FindValue(string value)
        {
            return FindValue<ReadSetActivationJobItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetActivationJobItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadSetActivationJobStatus.
    /// </summary>
    public class ReadSetActivationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ReadSetActivationJobStatus
        /// </summary>
        public static readonly ReadSetActivationJobStatus CANCELLED = new ReadSetActivationJobStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ReadSetActivationJobStatus
        /// </summary>
        public static readonly ReadSetActivationJobStatus CANCELLING = new ReadSetActivationJobStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for ReadSetActivationJobStatus
        /// </summary>
        public static readonly ReadSetActivationJobStatus COMPLETED = new ReadSetActivationJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for ReadSetActivationJobStatus
        /// </summary>
        public static readonly ReadSetActivationJobStatus COMPLETED_WITH_FAILURES = new ReadSetActivationJobStatus("COMPLETED_WITH_FAILURES");
        /// <summary>
        /// Constant FAILED for ReadSetActivationJobStatus
        /// </summary>
        public static readonly ReadSetActivationJobStatus FAILED = new ReadSetActivationJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReadSetActivationJobStatus
        /// </summary>
        public static readonly ReadSetActivationJobStatus IN_PROGRESS = new ReadSetActivationJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for ReadSetActivationJobStatus
        /// </summary>
        public static readonly ReadSetActivationJobStatus SUBMITTED = new ReadSetActivationJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetActivationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetActivationJobStatus FindValue(string value)
        {
            return FindValue<ReadSetActivationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetActivationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadSetExportJobItemStatus.
    /// </summary>
    public class ReadSetExportJobItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ReadSetExportJobItemStatus
        /// </summary>
        public static readonly ReadSetExportJobItemStatus FAILED = new ReadSetExportJobItemStatus("FAILED");
        /// <summary>
        /// Constant FINISHED for ReadSetExportJobItemStatus
        /// </summary>
        public static readonly ReadSetExportJobItemStatus FINISHED = new ReadSetExportJobItemStatus("FINISHED");
        /// <summary>
        /// Constant IN_PROGRESS for ReadSetExportJobItemStatus
        /// </summary>
        public static readonly ReadSetExportJobItemStatus IN_PROGRESS = new ReadSetExportJobItemStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ReadSetExportJobItemStatus
        /// </summary>
        public static readonly ReadSetExportJobItemStatus NOT_STARTED = new ReadSetExportJobItemStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetExportJobItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetExportJobItemStatus FindValue(string value)
        {
            return FindValue<ReadSetExportJobItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetExportJobItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadSetExportJobStatus.
    /// </summary>
    public class ReadSetExportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ReadSetExportJobStatus
        /// </summary>
        public static readonly ReadSetExportJobStatus CANCELLED = new ReadSetExportJobStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ReadSetExportJobStatus
        /// </summary>
        public static readonly ReadSetExportJobStatus CANCELLING = new ReadSetExportJobStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for ReadSetExportJobStatus
        /// </summary>
        public static readonly ReadSetExportJobStatus COMPLETED = new ReadSetExportJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for ReadSetExportJobStatus
        /// </summary>
        public static readonly ReadSetExportJobStatus COMPLETED_WITH_FAILURES = new ReadSetExportJobStatus("COMPLETED_WITH_FAILURES");
        /// <summary>
        /// Constant FAILED for ReadSetExportJobStatus
        /// </summary>
        public static readonly ReadSetExportJobStatus FAILED = new ReadSetExportJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReadSetExportJobStatus
        /// </summary>
        public static readonly ReadSetExportJobStatus IN_PROGRESS = new ReadSetExportJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for ReadSetExportJobStatus
        /// </summary>
        public static readonly ReadSetExportJobStatus SUBMITTED = new ReadSetExportJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetExportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetExportJobStatus FindValue(string value)
        {
            return FindValue<ReadSetExportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetExportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadSetFile.
    /// </summary>
    public class ReadSetFile : ConstantClass
    {

        /// <summary>
        /// Constant INDEX for ReadSetFile
        /// </summary>
        public static readonly ReadSetFile INDEX = new ReadSetFile("INDEX");
        /// <summary>
        /// Constant SOURCE1 for ReadSetFile
        /// </summary>
        public static readonly ReadSetFile SOURCE1 = new ReadSetFile("SOURCE1");
        /// <summary>
        /// Constant SOURCE2 for ReadSetFile
        /// </summary>
        public static readonly ReadSetFile SOURCE2 = new ReadSetFile("SOURCE2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetFile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetFile FindValue(string value)
        {
            return FindValue<ReadSetFile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetFile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadSetImportJobItemStatus.
    /// </summary>
    public class ReadSetImportJobItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ReadSetImportJobItemStatus
        /// </summary>
        public static readonly ReadSetImportJobItemStatus FAILED = new ReadSetImportJobItemStatus("FAILED");
        /// <summary>
        /// Constant FINISHED for ReadSetImportJobItemStatus
        /// </summary>
        public static readonly ReadSetImportJobItemStatus FINISHED = new ReadSetImportJobItemStatus("FINISHED");
        /// <summary>
        /// Constant IN_PROGRESS for ReadSetImportJobItemStatus
        /// </summary>
        public static readonly ReadSetImportJobItemStatus IN_PROGRESS = new ReadSetImportJobItemStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ReadSetImportJobItemStatus
        /// </summary>
        public static readonly ReadSetImportJobItemStatus NOT_STARTED = new ReadSetImportJobItemStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetImportJobItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetImportJobItemStatus FindValue(string value)
        {
            return FindValue<ReadSetImportJobItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetImportJobItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadSetImportJobStatus.
    /// </summary>
    public class ReadSetImportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ReadSetImportJobStatus
        /// </summary>
        public static readonly ReadSetImportJobStatus CANCELLED = new ReadSetImportJobStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ReadSetImportJobStatus
        /// </summary>
        public static readonly ReadSetImportJobStatus CANCELLING = new ReadSetImportJobStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for ReadSetImportJobStatus
        /// </summary>
        public static readonly ReadSetImportJobStatus COMPLETED = new ReadSetImportJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for ReadSetImportJobStatus
        /// </summary>
        public static readonly ReadSetImportJobStatus COMPLETED_WITH_FAILURES = new ReadSetImportJobStatus("COMPLETED_WITH_FAILURES");
        /// <summary>
        /// Constant FAILED for ReadSetImportJobStatus
        /// </summary>
        public static readonly ReadSetImportJobStatus FAILED = new ReadSetImportJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReadSetImportJobStatus
        /// </summary>
        public static readonly ReadSetImportJobStatus IN_PROGRESS = new ReadSetImportJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for ReadSetImportJobStatus
        /// </summary>
        public static readonly ReadSetImportJobStatus SUBMITTED = new ReadSetImportJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetImportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetImportJobStatus FindValue(string value)
        {
            return FindValue<ReadSetImportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetImportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadSetStatus.
    /// </summary>
    public class ReadSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for ReadSetStatus
        /// </summary>
        public static readonly ReadSetStatus ACTIVATING = new ReadSetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for ReadSetStatus
        /// </summary>
        public static readonly ReadSetStatus ACTIVE = new ReadSetStatus("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for ReadSetStatus
        /// </summary>
        public static readonly ReadSetStatus ARCHIVED = new ReadSetStatus("ARCHIVED");
        /// <summary>
        /// Constant DELETED for ReadSetStatus
        /// </summary>
        public static readonly ReadSetStatus DELETED = new ReadSetStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ReadSetStatus
        /// </summary>
        public static readonly ReadSetStatus DELETING = new ReadSetStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadSetStatus FindValue(string value)
        {
            return FindValue<ReadSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceFile.
    /// </summary>
    public class ReferenceFile : ConstantClass
    {

        /// <summary>
        /// Constant INDEX for ReferenceFile
        /// </summary>
        public static readonly ReferenceFile INDEX = new ReferenceFile("INDEX");
        /// <summary>
        /// Constant SOURCE for ReferenceFile
        /// </summary>
        public static readonly ReferenceFile SOURCE = new ReferenceFile("SOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceFile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceFile FindValue(string value)
        {
            return FindValue<ReferenceFile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceFile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceImportJobItemStatus.
    /// </summary>
    public class ReferenceImportJobItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ReferenceImportJobItemStatus
        /// </summary>
        public static readonly ReferenceImportJobItemStatus FAILED = new ReferenceImportJobItemStatus("FAILED");
        /// <summary>
        /// Constant FINISHED for ReferenceImportJobItemStatus
        /// </summary>
        public static readonly ReferenceImportJobItemStatus FINISHED = new ReferenceImportJobItemStatus("FINISHED");
        /// <summary>
        /// Constant IN_PROGRESS for ReferenceImportJobItemStatus
        /// </summary>
        public static readonly ReferenceImportJobItemStatus IN_PROGRESS = new ReferenceImportJobItemStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ReferenceImportJobItemStatus
        /// </summary>
        public static readonly ReferenceImportJobItemStatus NOT_STARTED = new ReferenceImportJobItemStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceImportJobItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceImportJobItemStatus FindValue(string value)
        {
            return FindValue<ReferenceImportJobItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceImportJobItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceImportJobStatus.
    /// </summary>
    public class ReferenceImportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ReferenceImportJobStatus
        /// </summary>
        public static readonly ReferenceImportJobStatus CANCELLED = new ReferenceImportJobStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ReferenceImportJobStatus
        /// </summary>
        public static readonly ReferenceImportJobStatus CANCELLING = new ReferenceImportJobStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for ReferenceImportJobStatus
        /// </summary>
        public static readonly ReferenceImportJobStatus COMPLETED = new ReferenceImportJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for ReferenceImportJobStatus
        /// </summary>
        public static readonly ReferenceImportJobStatus COMPLETED_WITH_FAILURES = new ReferenceImportJobStatus("COMPLETED_WITH_FAILURES");
        /// <summary>
        /// Constant FAILED for ReferenceImportJobStatus
        /// </summary>
        public static readonly ReferenceImportJobStatus FAILED = new ReferenceImportJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReferenceImportJobStatus
        /// </summary>
        public static readonly ReferenceImportJobStatus IN_PROGRESS = new ReferenceImportJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for ReferenceImportJobStatus
        /// </summary>
        public static readonly ReferenceImportJobStatus SUBMITTED = new ReferenceImportJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceImportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceImportJobStatus FindValue(string value)
        {
            return FindValue<ReferenceImportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceImportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceStatus.
    /// </summary>
    public class ReferenceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus ACTIVE = new ReferenceStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus DELETED = new ReferenceStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus DELETING = new ReferenceStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceStatus FindValue(string value)
        {
            return FindValue<ReferenceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunExport.
    /// </summary>
    public class RunExport : ConstantClass
    {

        /// <summary>
        /// Constant DEFINITION for RunExport
        /// </summary>
        public static readonly RunExport DEFINITION = new RunExport("DEFINITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunExport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunExport FindValue(string value)
        {
            return FindValue<RunExport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunExport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunLogLevel.
    /// </summary>
    public class RunLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RunLogLevel
        /// </summary>
        public static readonly RunLogLevel ALL = new RunLogLevel("ALL");
        /// <summary>
        /// Constant ERROR for RunLogLevel
        /// </summary>
        public static readonly RunLogLevel ERROR = new RunLogLevel("ERROR");
        /// <summary>
        /// Constant FATAL for RunLogLevel
        /// </summary>
        public static readonly RunLogLevel FATAL = new RunLogLevel("FATAL");
        /// <summary>
        /// Constant OFF for RunLogLevel
        /// </summary>
        public static readonly RunLogLevel OFF = new RunLogLevel("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunLogLevel FindValue(string value)
        {
            return FindValue<RunLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunLogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunStatus.
    /// </summary>
    public class RunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for RunStatus
        /// </summary>
        public static readonly RunStatus CANCELLED = new RunStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for RunStatus
        /// </summary>
        public static readonly RunStatus COMPLETED = new RunStatus("COMPLETED");
        /// <summary>
        /// Constant DELETED for RunStatus
        /// </summary>
        public static readonly RunStatus DELETED = new RunStatus("DELETED");
        /// <summary>
        /// Constant FAILED for RunStatus
        /// </summary>
        public static readonly RunStatus FAILED = new RunStatus("FAILED");
        /// <summary>
        /// Constant PENDING for RunStatus
        /// </summary>
        public static readonly RunStatus PENDING = new RunStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for RunStatus
        /// </summary>
        public static readonly RunStatus RUNNING = new RunStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for RunStatus
        /// </summary>
        public static readonly RunStatus STARTING = new RunStatus("STARTING");
        /// <summary>
        /// Constant STOPPING for RunStatus
        /// </summary>
        public static readonly RunStatus STOPPING = new RunStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunStatus FindValue(string value)
        {
            return FindValue<RunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaValueType.
    /// </summary>
    public class SchemaValueType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for SchemaValueType
        /// </summary>
        public static readonly SchemaValueType BOOLEAN = new SchemaValueType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for SchemaValueType
        /// </summary>
        public static readonly SchemaValueType DOUBLE = new SchemaValueType("DOUBLE");
        /// <summary>
        /// Constant FLOAT for SchemaValueType
        /// </summary>
        public static readonly SchemaValueType FLOAT = new SchemaValueType("FLOAT");
        /// <summary>
        /// Constant INT for SchemaValueType
        /// </summary>
        public static readonly SchemaValueType INT = new SchemaValueType("INT");
        /// <summary>
        /// Constant LONG for SchemaValueType
        /// </summary>
        public static readonly SchemaValueType LONG = new SchemaValueType("LONG");
        /// <summary>
        /// Constant STRING for SchemaValueType
        /// </summary>
        public static readonly SchemaValueType STRING = new SchemaValueType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaValueType FindValue(string value)
        {
            return FindValue<SchemaValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StoreFormat.
    /// </summary>
    public class StoreFormat : ConstantClass
    {

        /// <summary>
        /// Constant GFF for StoreFormat
        /// </summary>
        public static readonly StoreFormat GFF = new StoreFormat("GFF");
        /// <summary>
        /// Constant TSV for StoreFormat
        /// </summary>
        public static readonly StoreFormat TSV = new StoreFormat("TSV");
        /// <summary>
        /// Constant VCF for StoreFormat
        /// </summary>
        public static readonly StoreFormat VCF = new StoreFormat("VCF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StoreFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StoreFormat FindValue(string value)
        {
            return FindValue<StoreFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StoreFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StoreStatus.
    /// </summary>
    public class StoreStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StoreStatus
        /// </summary>
        public static readonly StoreStatus ACTIVE = new StoreStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for StoreStatus
        /// </summary>
        public static readonly StoreStatus CREATING = new StoreStatus("CREATING");
        /// <summary>
        /// Constant DELETING for StoreStatus
        /// </summary>
        public static readonly StoreStatus DELETING = new StoreStatus("DELETING");
        /// <summary>
        /// Constant FAILED for StoreStatus
        /// </summary>
        public static readonly StoreStatus FAILED = new StoreStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for StoreStatus
        /// </summary>
        public static readonly StoreStatus UPDATING = new StoreStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StoreStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StoreStatus FindValue(string value)
        {
            return FindValue<StoreStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StoreStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for TaskStatus
        /// </summary>
        public static readonly TaskStatus CANCELLED = new TaskStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for TaskStatus
        /// </summary>
        public static readonly TaskStatus COMPLETED = new TaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for TaskStatus
        /// </summary>
        public static readonly TaskStatus FAILED = new TaskStatus("FAILED");
        /// <summary>
        /// Constant PENDING for TaskStatus
        /// </summary>
        public static readonly TaskStatus PENDING = new TaskStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for TaskStatus
        /// </summary>
        public static readonly TaskStatus RUNNING = new TaskStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for TaskStatus
        /// </summary>
        public static readonly TaskStatus STARTING = new TaskStatus("STARTING");
        /// <summary>
        /// Constant STOPPING for TaskStatus
        /// </summary>
        public static readonly TaskStatus STOPPING = new TaskStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowEngine.
    /// </summary>
    public class WorkflowEngine : ConstantClass
    {

        /// <summary>
        /// Constant NEXTFLOW for WorkflowEngine
        /// </summary>
        public static readonly WorkflowEngine NEXTFLOW = new WorkflowEngine("NEXTFLOW");
        /// <summary>
        /// Constant WDL for WorkflowEngine
        /// </summary>
        public static readonly WorkflowEngine WDL = new WorkflowEngine("WDL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowEngine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowEngine FindValue(string value)
        {
            return FindValue<WorkflowEngine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowEngine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowExport.
    /// </summary>
    public class WorkflowExport : ConstantClass
    {

        /// <summary>
        /// Constant DEFINITION for WorkflowExport
        /// </summary>
        public static readonly WorkflowExport DEFINITION = new WorkflowExport("DEFINITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowExport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowExport FindValue(string value)
        {
            return FindValue<WorkflowExport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowExport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStatus.
    /// </summary>
    public class WorkflowStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus ACTIVE = new WorkflowStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus CREATING = new WorkflowStatus("CREATING");
        /// <summary>
        /// Constant DELETED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus DELETED = new WorkflowStatus("DELETED");
        /// <summary>
        /// Constant FAILED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus FAILED = new WorkflowStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus INACTIVE = new WorkflowStatus("INACTIVE");
        /// <summary>
        /// Constant UPDATING for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus UPDATING = new WorkflowStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStatus FindValue(string value)
        {
            return FindValue<WorkflowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowType.
    /// </summary>
    public class WorkflowType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for WorkflowType
        /// </summary>
        public static readonly WorkflowType PRIVATE = new WorkflowType("PRIVATE");
        /// <summary>
        /// Constant SERVICE for WorkflowType
        /// </summary>
        public static readonly WorkflowType SERVICE = new WorkflowType("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowType FindValue(string value)
        {
            return FindValue<WorkflowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowType(string value)
        {
            return FindValue(value);
        }
    }

}