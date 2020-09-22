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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Comprehend
{

    /// <summary>
    /// Constants used for properties of type DocumentClassifierDataFormat.
    /// </summary>
    public class DocumentClassifierDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant AUGMENTED_MANIFEST for DocumentClassifierDataFormat
        /// </summary>
        public static readonly DocumentClassifierDataFormat AUGMENTED_MANIFEST = new DocumentClassifierDataFormat("AUGMENTED_MANIFEST");
        /// <summary>
        /// Constant COMPREHEND_CSV for DocumentClassifierDataFormat
        /// </summary>
        public static readonly DocumentClassifierDataFormat COMPREHEND_CSV = new DocumentClassifierDataFormat("COMPREHEND_CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentClassifierDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentClassifierDataFormat FindValue(string value)
        {
            return FindValue<DocumentClassifierDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentClassifierDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentClassifierMode.
    /// </summary>
    public class DocumentClassifierMode : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_CLASS for DocumentClassifierMode
        /// </summary>
        public static readonly DocumentClassifierMode MULTI_CLASS = new DocumentClassifierMode("MULTI_CLASS");
        /// <summary>
        /// Constant MULTI_LABEL for DocumentClassifierMode
        /// </summary>
        public static readonly DocumentClassifierMode MULTI_LABEL = new DocumentClassifierMode("MULTI_LABEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentClassifierMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentClassifierMode FindValue(string value)
        {
            return FindValue<DocumentClassifierMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentClassifierMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointStatus.
    /// </summary>
    public class EndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus CREATING = new EndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETING for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus DELETING = new EndpointStatus("DELETING");
        /// <summary>
        /// Constant FAILED for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus FAILED = new EndpointStatus("FAILED");
        /// <summary>
        /// Constant IN_SERVICE for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus IN_SERVICE = new EndpointStatus("IN_SERVICE");
        /// <summary>
        /// Constant UPDATING for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus UPDATING = new EndpointStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointStatus FindValue(string value)
        {
            return FindValue<EndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityRecognizerDataFormat.
    /// </summary>
    public class EntityRecognizerDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant AUGMENTED_MANIFEST for EntityRecognizerDataFormat
        /// </summary>
        public static readonly EntityRecognizerDataFormat AUGMENTED_MANIFEST = new EntityRecognizerDataFormat("AUGMENTED_MANIFEST");
        /// <summary>
        /// Constant COMPREHEND_CSV for EntityRecognizerDataFormat
        /// </summary>
        public static readonly EntityRecognizerDataFormat COMPREHEND_CSV = new EntityRecognizerDataFormat("COMPREHEND_CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityRecognizerDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityRecognizerDataFormat FindValue(string value)
        {
            return FindValue<EntityRecognizerDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityRecognizerDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant COMMERCIAL_ITEM for EntityType
        /// </summary>
        public static readonly EntityType COMMERCIAL_ITEM = new EntityType("COMMERCIAL_ITEM");
        /// <summary>
        /// Constant DATE for EntityType
        /// </summary>
        public static readonly EntityType DATE = new EntityType("DATE");
        /// <summary>
        /// Constant EVENT for EntityType
        /// </summary>
        public static readonly EntityType EVENT = new EntityType("EVENT");
        /// <summary>
        /// Constant LOCATION for EntityType
        /// </summary>
        public static readonly EntityType LOCATION = new EntityType("LOCATION");
        /// <summary>
        /// Constant ORGANIZATION for EntityType
        /// </summary>
        public static readonly EntityType ORGANIZATION = new EntityType("ORGANIZATION");
        /// <summary>
        /// Constant OTHER for EntityType
        /// </summary>
        public static readonly EntityType OTHER = new EntityType("OTHER");
        /// <summary>
        /// Constant PERSON for EntityType
        /// </summary>
        public static readonly EntityType PERSON = new EntityType("PERSON");
        /// <summary>
        /// Constant QUANTITY for EntityType
        /// </summary>
        public static readonly EntityType QUANTITY = new EntityType("QUANTITY");
        /// <summary>
        /// Constant TITLE for EntityType
        /// </summary>
        public static readonly EntityType TITLE = new EntityType("TITLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputFormat.
    /// </summary>
    public class InputFormat : ConstantClass
    {

        /// <summary>
        /// Constant ONE_DOC_PER_FILE for InputFormat
        /// </summary>
        public static readonly InputFormat ONE_DOC_PER_FILE = new InputFormat("ONE_DOC_PER_FILE");
        /// <summary>
        /// Constant ONE_DOC_PER_LINE for InputFormat
        /// </summary>
        public static readonly InputFormat ONE_DOC_PER_LINE = new InputFormat("ONE_DOC_PER_LINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputFormat FindValue(string value)
        {
            return FindValue<InputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputFormat(string value)
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
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant STOP_REQUESTED for JobStatus
        /// </summary>
        public static readonly JobStatus STOP_REQUESTED = new JobStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant STOPPED for JobStatus
        /// </summary>
        public static readonly JobStatus STOPPED = new JobStatus("STOPPED");
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
    /// Constants used for properties of type LanguageCode.
    /// </summary>
    public class LanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant Ar for LanguageCode
        /// </summary>
        public static readonly LanguageCode Ar = new LanguageCode("ar");
        /// <summary>
        /// Constant De for LanguageCode
        /// </summary>
        public static readonly LanguageCode De = new LanguageCode("de");
        /// <summary>
        /// Constant En for LanguageCode
        /// </summary>
        public static readonly LanguageCode En = new LanguageCode("en");
        /// <summary>
        /// Constant Es for LanguageCode
        /// </summary>
        public static readonly LanguageCode Es = new LanguageCode("es");
        /// <summary>
        /// Constant Fr for LanguageCode
        /// </summary>
        public static readonly LanguageCode Fr = new LanguageCode("fr");
        /// <summary>
        /// Constant Hi for LanguageCode
        /// </summary>
        public static readonly LanguageCode Hi = new LanguageCode("hi");
        /// <summary>
        /// Constant It for LanguageCode
        /// </summary>
        public static readonly LanguageCode It = new LanguageCode("it");
        /// <summary>
        /// Constant Ja for LanguageCode
        /// </summary>
        public static readonly LanguageCode Ja = new LanguageCode("ja");
        /// <summary>
        /// Constant Ko for LanguageCode
        /// </summary>
        public static readonly LanguageCode Ko = new LanguageCode("ko");
        /// <summary>
        /// Constant Pt for LanguageCode
        /// </summary>
        public static readonly LanguageCode Pt = new LanguageCode("pt");
        /// <summary>
        /// Constant Zh for LanguageCode
        /// </summary>
        public static readonly LanguageCode Zh = new LanguageCode("zh");
        /// <summary>
        /// Constant ZhTW for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZhTW = new LanguageCode("zh-TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCode FindValue(string value)
        {
            return FindValue<LanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelStatus.
    /// </summary>
    public class ModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ModelStatus
        /// </summary>
        public static readonly ModelStatus DELETING = new ModelStatus("DELETING");
        /// <summary>
        /// Constant IN_ERROR for ModelStatus
        /// </summary>
        public static readonly ModelStatus IN_ERROR = new ModelStatus("IN_ERROR");
        /// <summary>
        /// Constant STOP_REQUESTED for ModelStatus
        /// </summary>
        public static readonly ModelStatus STOP_REQUESTED = new ModelStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant STOPPED for ModelStatus
        /// </summary>
        public static readonly ModelStatus STOPPED = new ModelStatus("STOPPED");
        /// <summary>
        /// Constant SUBMITTED for ModelStatus
        /// </summary>
        public static readonly ModelStatus SUBMITTED = new ModelStatus("SUBMITTED");
        /// <summary>
        /// Constant TRAINED for ModelStatus
        /// </summary>
        public static readonly ModelStatus TRAINED = new ModelStatus("TRAINED");
        /// <summary>
        /// Constant TRAINING for ModelStatus
        /// </summary>
        public static readonly ModelStatus TRAINING = new ModelStatus("TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelStatus FindValue(string value)
        {
            return FindValue<ModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartOfSpeechTagType.
    /// </summary>
    public class PartOfSpeechTagType : ConstantClass
    {

        /// <summary>
        /// Constant ADJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType ADJ = new PartOfSpeechTagType("ADJ");
        /// <summary>
        /// Constant ADP for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType ADP = new PartOfSpeechTagType("ADP");
        /// <summary>
        /// Constant ADV for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType ADV = new PartOfSpeechTagType("ADV");
        /// <summary>
        /// Constant AUX for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType AUX = new PartOfSpeechTagType("AUX");
        /// <summary>
        /// Constant CCONJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType CCONJ = new PartOfSpeechTagType("CCONJ");
        /// <summary>
        /// Constant CONJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType CONJ = new PartOfSpeechTagType("CONJ");
        /// <summary>
        /// Constant DET for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType DET = new PartOfSpeechTagType("DET");
        /// <summary>
        /// Constant INTJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType INTJ = new PartOfSpeechTagType("INTJ");
        /// <summary>
        /// Constant NOUN for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType NOUN = new PartOfSpeechTagType("NOUN");
        /// <summary>
        /// Constant NUM for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType NUM = new PartOfSpeechTagType("NUM");
        /// <summary>
        /// Constant O for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType O = new PartOfSpeechTagType("O");
        /// <summary>
        /// Constant PART for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PART = new PartOfSpeechTagType("PART");
        /// <summary>
        /// Constant PRON for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PRON = new PartOfSpeechTagType("PRON");
        /// <summary>
        /// Constant PROPN for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PROPN = new PartOfSpeechTagType("PROPN");
        /// <summary>
        /// Constant PUNCT for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType PUNCT = new PartOfSpeechTagType("PUNCT");
        /// <summary>
        /// Constant SCONJ for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType SCONJ = new PartOfSpeechTagType("SCONJ");
        /// <summary>
        /// Constant SYM for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType SYM = new PartOfSpeechTagType("SYM");
        /// <summary>
        /// Constant VERB for PartOfSpeechTagType
        /// </summary>
        public static readonly PartOfSpeechTagType VERB = new PartOfSpeechTagType("VERB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartOfSpeechTagType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartOfSpeechTagType FindValue(string value)
        {
            return FindValue<PartOfSpeechTagType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartOfSpeechTagType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PiiEntitiesDetectionMaskMode.
    /// </summary>
    public class PiiEntitiesDetectionMaskMode : ConstantClass
    {

        /// <summary>
        /// Constant MASK for PiiEntitiesDetectionMaskMode
        /// </summary>
        public static readonly PiiEntitiesDetectionMaskMode MASK = new PiiEntitiesDetectionMaskMode("MASK");
        /// <summary>
        /// Constant REPLACE_WITH_PII_ENTITY_TYPE for PiiEntitiesDetectionMaskMode
        /// </summary>
        public static readonly PiiEntitiesDetectionMaskMode REPLACE_WITH_PII_ENTITY_TYPE = new PiiEntitiesDetectionMaskMode("REPLACE_WITH_PII_ENTITY_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PiiEntitiesDetectionMaskMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PiiEntitiesDetectionMaskMode FindValue(string value)
        {
            return FindValue<PiiEntitiesDetectionMaskMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PiiEntitiesDetectionMaskMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PiiEntitiesDetectionMode.
    /// </summary>
    public class PiiEntitiesDetectionMode : ConstantClass
    {

        /// <summary>
        /// Constant ONLY_OFFSETS for PiiEntitiesDetectionMode
        /// </summary>
        public static readonly PiiEntitiesDetectionMode ONLY_OFFSETS = new PiiEntitiesDetectionMode("ONLY_OFFSETS");
        /// <summary>
        /// Constant ONLY_REDACTION for PiiEntitiesDetectionMode
        /// </summary>
        public static readonly PiiEntitiesDetectionMode ONLY_REDACTION = new PiiEntitiesDetectionMode("ONLY_REDACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PiiEntitiesDetectionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PiiEntitiesDetectionMode FindValue(string value)
        {
            return FindValue<PiiEntitiesDetectionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PiiEntitiesDetectionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PiiEntityType.
    /// </summary>
    public class PiiEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ADDRESS for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType ADDRESS = new PiiEntityType("ADDRESS");
        /// <summary>
        /// Constant AGE for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType AGE = new PiiEntityType("AGE");
        /// <summary>
        /// Constant ALL for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType ALL = new PiiEntityType("ALL");
        /// <summary>
        /// Constant AWS_ACCESS_KEY for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType AWS_ACCESS_KEY = new PiiEntityType("AWS_ACCESS_KEY");
        /// <summary>
        /// Constant AWS_SECRET_KEY for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType AWS_SECRET_KEY = new PiiEntityType("AWS_SECRET_KEY");
        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType BANK_ACCOUNT_NUMBER = new PiiEntityType("BANK_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant BANK_ROUTING for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType BANK_ROUTING = new PiiEntityType("BANK_ROUTING");
        /// <summary>
        /// Constant CREDIT_DEBIT_CVV for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CREDIT_DEBIT_CVV = new PiiEntityType("CREDIT_DEBIT_CVV");
        /// <summary>
        /// Constant CREDIT_DEBIT_EXPIRY for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CREDIT_DEBIT_EXPIRY = new PiiEntityType("CREDIT_DEBIT_EXPIRY");
        /// <summary>
        /// Constant CREDIT_DEBIT_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CREDIT_DEBIT_NUMBER = new PiiEntityType("CREDIT_DEBIT_NUMBER");
        /// <summary>
        /// Constant DATE_TIME for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType DATE_TIME = new PiiEntityType("DATE_TIME");
        /// <summary>
        /// Constant DRIVER_ID for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType DRIVER_ID = new PiiEntityType("DRIVER_ID");
        /// <summary>
        /// Constant EMAIL for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType EMAIL = new PiiEntityType("EMAIL");
        /// <summary>
        /// Constant IP_ADDRESS for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType IP_ADDRESS = new PiiEntityType("IP_ADDRESS");
        /// <summary>
        /// Constant MAC_ADDRESS for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType MAC_ADDRESS = new PiiEntityType("MAC_ADDRESS");
        /// <summary>
        /// Constant NAME for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType NAME = new PiiEntityType("NAME");
        /// <summary>
        /// Constant PASSPORT_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType PASSPORT_NUMBER = new PiiEntityType("PASSPORT_NUMBER");
        /// <summary>
        /// Constant PASSWORD for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType PASSWORD = new PiiEntityType("PASSWORD");
        /// <summary>
        /// Constant PHONE for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType PHONE = new PiiEntityType("PHONE");
        /// <summary>
        /// Constant PIN for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType PIN = new PiiEntityType("PIN");
        /// <summary>
        /// Constant SSN for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType SSN = new PiiEntityType("SSN");
        /// <summary>
        /// Constant URL for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType URL = new PiiEntityType("URL");
        /// <summary>
        /// Constant USERNAME for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType USERNAME = new PiiEntityType("USERNAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PiiEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PiiEntityType FindValue(string value)
        {
            return FindValue<PiiEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PiiEntityType(string value)
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
    /// Constants used for properties of type SyntaxLanguageCode.
    /// </summary>
    public class SyntaxLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant De for SyntaxLanguageCode
        /// </summary>
        public static readonly SyntaxLanguageCode De = new SyntaxLanguageCode("de");
        /// <summary>
        /// Constant En for SyntaxLanguageCode
        /// </summary>
        public static readonly SyntaxLanguageCode En = new SyntaxLanguageCode("en");
        /// <summary>
        /// Constant Es for SyntaxLanguageCode
        /// </summary>
        public static readonly SyntaxLanguageCode Es = new SyntaxLanguageCode("es");
        /// <summary>
        /// Constant Fr for SyntaxLanguageCode
        /// </summary>
        public static readonly SyntaxLanguageCode Fr = new SyntaxLanguageCode("fr");
        /// <summary>
        /// Constant It for SyntaxLanguageCode
        /// </summary>
        public static readonly SyntaxLanguageCode It = new SyntaxLanguageCode("it");
        /// <summary>
        /// Constant Pt for SyntaxLanguageCode
        /// </summary>
        public static readonly SyntaxLanguageCode Pt = new SyntaxLanguageCode("pt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyntaxLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyntaxLanguageCode FindValue(string value)
        {
            return FindValue<SyntaxLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyntaxLanguageCode(string value)
        {
            return FindValue(value);
        }
    }

}