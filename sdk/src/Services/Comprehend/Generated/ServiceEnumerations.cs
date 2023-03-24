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
    /// Constants used for properties of type AugmentedManifestsDocumentTypeFormat.
    /// </summary>
    public class AugmentedManifestsDocumentTypeFormat : ConstantClass
    {

        /// <summary>
        /// Constant PLAIN_TEXT_DOCUMENT for AugmentedManifestsDocumentTypeFormat
        /// </summary>
        public static readonly AugmentedManifestsDocumentTypeFormat PLAIN_TEXT_DOCUMENT = new AugmentedManifestsDocumentTypeFormat("PLAIN_TEXT_DOCUMENT");
        /// <summary>
        /// Constant SEMI_STRUCTURED_DOCUMENT for AugmentedManifestsDocumentTypeFormat
        /// </summary>
        public static readonly AugmentedManifestsDocumentTypeFormat SEMI_STRUCTURED_DOCUMENT = new AugmentedManifestsDocumentTypeFormat("SEMI_STRUCTURED_DOCUMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AugmentedManifestsDocumentTypeFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AugmentedManifestsDocumentTypeFormat FindValue(string value)
        {
            return FindValue<AugmentedManifestsDocumentTypeFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AugmentedManifestsDocumentTypeFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlockType.
    /// </summary>
    public class BlockType : ConstantClass
    {

        /// <summary>
        /// Constant LINE for BlockType
        /// </summary>
        public static readonly BlockType LINE = new BlockType("LINE");
        /// <summary>
        /// Constant WORD for BlockType
        /// </summary>
        public static readonly BlockType WORD = new BlockType("WORD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlockType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlockType FindValue(string value)
        {
            return FindValue<BlockType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlockType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetDataFormat.
    /// </summary>
    public class DatasetDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant AUGMENTED_MANIFEST for DatasetDataFormat
        /// </summary>
        public static readonly DatasetDataFormat AUGMENTED_MANIFEST = new DatasetDataFormat("AUGMENTED_MANIFEST");
        /// <summary>
        /// Constant COMPREHEND_CSV for DatasetDataFormat
        /// </summary>
        public static readonly DatasetDataFormat COMPREHEND_CSV = new DatasetDataFormat("COMPREHEND_CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetDataFormat FindValue(string value)
        {
            return FindValue<DatasetDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetDataFormat(string value)
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
        /// Constant COMPLETED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus COMPLETED = new DatasetStatus("COMPLETED");
        /// <summary>
        /// Constant CREATING for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATING = new DatasetStatus("CREATING");
        /// <summary>
        /// Constant FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus FAILED = new DatasetStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetStatus(string value)
            : base(value)
        {
        }

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
        /// Constant TEST for DatasetType
        /// </summary>
        public static readonly DatasetType TEST = new DatasetType("TEST");
        /// <summary>
        /// Constant TRAIN for DatasetType
        /// </summary>
        public static readonly DatasetType TRAIN = new DatasetType("TRAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type DocumentReadAction.
    /// </summary>
    public class DocumentReadAction : ConstantClass
    {

        /// <summary>
        /// Constant TEXTRACT_ANALYZE_DOCUMENT for DocumentReadAction
        /// </summary>
        public static readonly DocumentReadAction TEXTRACT_ANALYZE_DOCUMENT = new DocumentReadAction("TEXTRACT_ANALYZE_DOCUMENT");
        /// <summary>
        /// Constant TEXTRACT_DETECT_DOCUMENT_TEXT for DocumentReadAction
        /// </summary>
        public static readonly DocumentReadAction TEXTRACT_DETECT_DOCUMENT_TEXT = new DocumentReadAction("TEXTRACT_DETECT_DOCUMENT_TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentReadAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentReadAction FindValue(string value)
        {
            return FindValue<DocumentReadAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentReadAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentReadFeatureTypes.
    /// </summary>
    public class DocumentReadFeatureTypes : ConstantClass
    {

        /// <summary>
        /// Constant FORMS for DocumentReadFeatureTypes
        /// </summary>
        public static readonly DocumentReadFeatureTypes FORMS = new DocumentReadFeatureTypes("FORMS");
        /// <summary>
        /// Constant TABLES for DocumentReadFeatureTypes
        /// </summary>
        public static readonly DocumentReadFeatureTypes TABLES = new DocumentReadFeatureTypes("TABLES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentReadFeatureTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentReadFeatureTypes FindValue(string value)
        {
            return FindValue<DocumentReadFeatureTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentReadFeatureTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentReadMode.
    /// </summary>
    public class DocumentReadMode : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_DOCUMENT_READ_ACTION for DocumentReadMode
        /// </summary>
        public static readonly DocumentReadMode FORCE_DOCUMENT_READ_ACTION = new DocumentReadMode("FORCE_DOCUMENT_READ_ACTION");
        /// <summary>
        /// Constant SERVICE_DEFAULT for DocumentReadMode
        /// </summary>
        public static readonly DocumentReadMode SERVICE_DEFAULT = new DocumentReadMode("SERVICE_DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentReadMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentReadMode FindValue(string value)
        {
            return FindValue<DocumentReadMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentReadMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentType.
    /// </summary>
    public class DocumentType : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE for DocumentType
        /// </summary>
        public static readonly DocumentType IMAGE = new DocumentType("IMAGE");
        /// <summary>
        /// Constant MS_WORD for DocumentType
        /// </summary>
        public static readonly DocumentType MS_WORD = new DocumentType("MS_WORD");
        /// <summary>
        /// Constant NATIVE_PDF for DocumentType
        /// </summary>
        public static readonly DocumentType NATIVE_PDF = new DocumentType("NATIVE_PDF");
        /// <summary>
        /// Constant PLAIN_TEXT for DocumentType
        /// </summary>
        public static readonly DocumentType PLAIN_TEXT = new DocumentType("PLAIN_TEXT");
        /// <summary>
        /// Constant SCANNED_PDF for DocumentType
        /// </summary>
        public static readonly DocumentType SCANNED_PDF = new DocumentType("SCANNED_PDF");
        /// <summary>
        /// Constant TEXTRACT_ANALYZE_DOCUMENT_JSON for DocumentType
        /// </summary>
        public static readonly DocumentType TEXTRACT_ANALYZE_DOCUMENT_JSON = new DocumentType("TEXTRACT_ANALYZE_DOCUMENT_JSON");
        /// <summary>
        /// Constant TEXTRACT_DETECT_DOCUMENT_TEXT_JSON for DocumentType
        /// </summary>
        public static readonly DocumentType TEXTRACT_DETECT_DOCUMENT_TEXT_JSON = new DocumentType("TEXTRACT_DETECT_DOCUMENT_TEXT_JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentType FindValue(string value)
        {
            return FindValue<DocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentType(string value)
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
    /// Constants used for properties of type FlywheelIterationStatus.
    /// </summary>
    public class FlywheelIterationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for FlywheelIterationStatus
        /// </summary>
        public static readonly FlywheelIterationStatus COMPLETED = new FlywheelIterationStatus("COMPLETED");
        /// <summary>
        /// Constant EVALUATING for FlywheelIterationStatus
        /// </summary>
        public static readonly FlywheelIterationStatus EVALUATING = new FlywheelIterationStatus("EVALUATING");
        /// <summary>
        /// Constant FAILED for FlywheelIterationStatus
        /// </summary>
        public static readonly FlywheelIterationStatus FAILED = new FlywheelIterationStatus("FAILED");
        /// <summary>
        /// Constant STOP_REQUESTED for FlywheelIterationStatus
        /// </summary>
        public static readonly FlywheelIterationStatus STOP_REQUESTED = new FlywheelIterationStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant STOPPED for FlywheelIterationStatus
        /// </summary>
        public static readonly FlywheelIterationStatus STOPPED = new FlywheelIterationStatus("STOPPED");
        /// <summary>
        /// Constant TRAINING for FlywheelIterationStatus
        /// </summary>
        public static readonly FlywheelIterationStatus TRAINING = new FlywheelIterationStatus("TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlywheelIterationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlywheelIterationStatus FindValue(string value)
        {
            return FindValue<FlywheelIterationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlywheelIterationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlywheelStatus.
    /// </summary>
    public class FlywheelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FlywheelStatus
        /// </summary>
        public static readonly FlywheelStatus ACTIVE = new FlywheelStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for FlywheelStatus
        /// </summary>
        public static readonly FlywheelStatus CREATING = new FlywheelStatus("CREATING");
        /// <summary>
        /// Constant DELETING for FlywheelStatus
        /// </summary>
        public static readonly FlywheelStatus DELETING = new FlywheelStatus("DELETING");
        /// <summary>
        /// Constant FAILED for FlywheelStatus
        /// </summary>
        public static readonly FlywheelStatus FAILED = new FlywheelStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for FlywheelStatus
        /// </summary>
        public static readonly FlywheelStatus UPDATING = new FlywheelStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlywheelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlywheelStatus FindValue(string value)
        {
            return FindValue<FlywheelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlywheelStatus(string value)
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
    /// Constants used for properties of type InvalidRequestDetailReason.
    /// </summary>
    public class InvalidRequestDetailReason : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENT_SIZE_EXCEEDED for InvalidRequestDetailReason
        /// </summary>
        public static readonly InvalidRequestDetailReason DOCUMENT_SIZE_EXCEEDED = new InvalidRequestDetailReason("DOCUMENT_SIZE_EXCEEDED");
        /// <summary>
        /// Constant PAGE_LIMIT_EXCEEDED for InvalidRequestDetailReason
        /// </summary>
        public static readonly InvalidRequestDetailReason PAGE_LIMIT_EXCEEDED = new InvalidRequestDetailReason("PAGE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant TEXTRACT_ACCESS_DENIED for InvalidRequestDetailReason
        /// </summary>
        public static readonly InvalidRequestDetailReason TEXTRACT_ACCESS_DENIED = new InvalidRequestDetailReason("TEXTRACT_ACCESS_DENIED");
        /// <summary>
        /// Constant UNSUPPORTED_DOC_TYPE for InvalidRequestDetailReason
        /// </summary>
        public static readonly InvalidRequestDetailReason UNSUPPORTED_DOC_TYPE = new InvalidRequestDetailReason("UNSUPPORTED_DOC_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvalidRequestDetailReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvalidRequestDetailReason FindValue(string value)
        {
            return FindValue<InvalidRequestDetailReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvalidRequestDetailReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvalidRequestReason.
    /// </summary>
    public class InvalidRequestReason : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_DOCUMENT for InvalidRequestReason
        /// </summary>
        public static readonly InvalidRequestReason INVALID_DOCUMENT = new InvalidRequestReason("INVALID_DOCUMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvalidRequestReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvalidRequestReason FindValue(string value)
        {
            return FindValue<InvalidRequestReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvalidRequestReason(string value)
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
        /// Constant TRAINED_WITH_WARNING for ModelStatus
        /// </summary>
        public static readonly ModelStatus TRAINED_WITH_WARNING = new ModelStatus("TRAINED_WITH_WARNING");
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
    /// Constants used for properties of type ModelType.
    /// </summary>
    public class ModelType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENT_CLASSIFIER for ModelType
        /// </summary>
        public static readonly ModelType DOCUMENT_CLASSIFIER = new ModelType("DOCUMENT_CLASSIFIER");
        /// <summary>
        /// Constant ENTITY_RECOGNIZER for ModelType
        /// </summary>
        public static readonly ModelType ENTITY_RECOGNIZER = new ModelType("ENTITY_RECOGNIZER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelType FindValue(string value)
        {
            return FindValue<ModelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PageBasedErrorCode.
    /// </summary>
    public class PageBasedErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for PageBasedErrorCode
        /// </summary>
        public static readonly PageBasedErrorCode INTERNAL_SERVER_ERROR = new PageBasedErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant PAGE_CHARACTERS_EXCEEDED for PageBasedErrorCode
        /// </summary>
        public static readonly PageBasedErrorCode PAGE_CHARACTERS_EXCEEDED = new PageBasedErrorCode("PAGE_CHARACTERS_EXCEEDED");
        /// <summary>
        /// Constant PAGE_SIZE_EXCEEDED for PageBasedErrorCode
        /// </summary>
        public static readonly PageBasedErrorCode PAGE_SIZE_EXCEEDED = new PageBasedErrorCode("PAGE_SIZE_EXCEEDED");
        /// <summary>
        /// Constant TEXTRACT_BAD_PAGE for PageBasedErrorCode
        /// </summary>
        public static readonly PageBasedErrorCode TEXTRACT_BAD_PAGE = new PageBasedErrorCode("TEXTRACT_BAD_PAGE");
        /// <summary>
        /// Constant TEXTRACT_PROVISIONED_THROUGHPUT_EXCEEDED for PageBasedErrorCode
        /// </summary>
        public static readonly PageBasedErrorCode TEXTRACT_PROVISIONED_THROUGHPUT_EXCEEDED = new PageBasedErrorCode("TEXTRACT_PROVISIONED_THROUGHPUT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PageBasedErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PageBasedErrorCode FindValue(string value)
        {
            return FindValue<PageBasedErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PageBasedErrorCode(string value)
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
        /// Constant CA_HEALTH_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CA_HEALTH_NUMBER = new PiiEntityType("CA_HEALTH_NUMBER");
        /// <summary>
        /// Constant CA_SOCIAL_INSURANCE_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType CA_SOCIAL_INSURANCE_NUMBER = new PiiEntityType("CA_SOCIAL_INSURANCE_NUMBER");
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
        /// Constant IN_AADHAAR for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType IN_AADHAAR = new PiiEntityType("IN_AADHAAR");
        /// <summary>
        /// Constant IN_NREGA for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType IN_NREGA = new PiiEntityType("IN_NREGA");
        /// <summary>
        /// Constant IN_PERMANENT_ACCOUNT_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType IN_PERMANENT_ACCOUNT_NUMBER = new PiiEntityType("IN_PERMANENT_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant IN_VOTER_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType IN_VOTER_NUMBER = new PiiEntityType("IN_VOTER_NUMBER");
        /// <summary>
        /// Constant INTERNATIONAL_BANK_ACCOUNT_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType INTERNATIONAL_BANK_ACCOUNT_NUMBER = new PiiEntityType("INTERNATIONAL_BANK_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant IP_ADDRESS for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType IP_ADDRESS = new PiiEntityType("IP_ADDRESS");
        /// <summary>
        /// Constant LICENSE_PLATE for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType LICENSE_PLATE = new PiiEntityType("LICENSE_PLATE");
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
        /// Constant SWIFT_CODE for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType SWIFT_CODE = new PiiEntityType("SWIFT_CODE");
        /// <summary>
        /// Constant UK_NATIONAL_HEALTH_SERVICE_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType UK_NATIONAL_HEALTH_SERVICE_NUMBER = new PiiEntityType("UK_NATIONAL_HEALTH_SERVICE_NUMBER");
        /// <summary>
        /// Constant UK_NATIONAL_INSURANCE_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType UK_NATIONAL_INSURANCE_NUMBER = new PiiEntityType("UK_NATIONAL_INSURANCE_NUMBER");
        /// <summary>
        /// Constant UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER = new PiiEntityType("UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER");
        /// <summary>
        /// Constant URL for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType URL = new PiiEntityType("URL");
        /// <summary>
        /// Constant US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER = new PiiEntityType("US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER");
        /// <summary>
        /// Constant USERNAME for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType USERNAME = new PiiEntityType("USERNAME");
        /// <summary>
        /// Constant VEHICLE_IDENTIFICATION_NUMBER for PiiEntityType
        /// </summary>
        public static readonly PiiEntityType VEHICLE_IDENTIFICATION_NUMBER = new PiiEntityType("VEHICLE_IDENTIFICATION_NUMBER");

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
    /// Constants used for properties of type RelationshipType.
    /// </summary>
    public class RelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant CHILD for RelationshipType
        /// </summary>
        public static readonly RelationshipType CHILD = new RelationshipType("CHILD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationshipType FindValue(string value)
        {
            return FindValue<RelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationshipType(string value)
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
    /// Constants used for properties of type Split.
    /// </summary>
    public class Split : ConstantClass
    {

        /// <summary>
        /// Constant TEST for Split
        /// </summary>
        public static readonly Split TEST = new Split("TEST");
        /// <summary>
        /// Constant TRAIN for Split
        /// </summary>
        public static readonly Split TRAIN = new Split("TRAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Split(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Split FindValue(string value)
        {
            return FindValue<Split>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Split(string value)
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


    /// <summary>
    /// Constants used for properties of type TargetedSentimentEntityType.
    /// </summary>
    public class TargetedSentimentEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ATTRIBUTE for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType ATTRIBUTE = new TargetedSentimentEntityType("ATTRIBUTE");
        /// <summary>
        /// Constant BOOK for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType BOOK = new TargetedSentimentEntityType("BOOK");
        /// <summary>
        /// Constant BRAND for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType BRAND = new TargetedSentimentEntityType("BRAND");
        /// <summary>
        /// Constant COMMERCIAL_ITEM for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType COMMERCIAL_ITEM = new TargetedSentimentEntityType("COMMERCIAL_ITEM");
        /// <summary>
        /// Constant DATE for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType DATE = new TargetedSentimentEntityType("DATE");
        /// <summary>
        /// Constant EVENT for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType EVENT = new TargetedSentimentEntityType("EVENT");
        /// <summary>
        /// Constant FACILITY for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType FACILITY = new TargetedSentimentEntityType("FACILITY");
        /// <summary>
        /// Constant GAME for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType GAME = new TargetedSentimentEntityType("GAME");
        /// <summary>
        /// Constant LOCATION for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType LOCATION = new TargetedSentimentEntityType("LOCATION");
        /// <summary>
        /// Constant MOVIE for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType MOVIE = new TargetedSentimentEntityType("MOVIE");
        /// <summary>
        /// Constant MUSIC for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType MUSIC = new TargetedSentimentEntityType("MUSIC");
        /// <summary>
        /// Constant ORGANIZATION for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType ORGANIZATION = new TargetedSentimentEntityType("ORGANIZATION");
        /// <summary>
        /// Constant OTHER for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType OTHER = new TargetedSentimentEntityType("OTHER");
        /// <summary>
        /// Constant PERSON for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType PERSON = new TargetedSentimentEntityType("PERSON");
        /// <summary>
        /// Constant PERSONAL_TITLE for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType PERSONAL_TITLE = new TargetedSentimentEntityType("PERSONAL_TITLE");
        /// <summary>
        /// Constant QUANTITY for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType QUANTITY = new TargetedSentimentEntityType("QUANTITY");
        /// <summary>
        /// Constant SOFTWARE for TargetedSentimentEntityType
        /// </summary>
        public static readonly TargetedSentimentEntityType SOFTWARE = new TargetedSentimentEntityType("SOFTWARE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetedSentimentEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetedSentimentEntityType FindValue(string value)
        {
            return FindValue<TargetedSentimentEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetedSentimentEntityType(string value)
        {
            return FindValue(value);
        }
    }

}