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

namespace Amazon.Textract
{
    /// <summary>
    /// Constants used for properties of type AdapterVersionStatus.
    /// </summary>
    public class AdapterVersionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for AdapterVersionStatus
        /// </summary>
        public static readonly AdapterVersionStatus ACTIVE = new AdapterVersionStatus("ACTIVE");

        /// <summary>
        /// Constant AT_RISK for AdapterVersionStatus
        /// </summary>
        public static readonly AdapterVersionStatus AT_RISK = new AdapterVersionStatus("AT_RISK");

        /// <summary>
        /// Constant CREATION_ERROR for AdapterVersionStatus
        /// </summary>
        public static readonly AdapterVersionStatus CREATION_ERROR = new AdapterVersionStatus("CREATION_ERROR");

        /// <summary>
        /// Constant CREATION_IN_PROGRESS for AdapterVersionStatus
        /// </summary>
        public static readonly AdapterVersionStatus CREATION_IN_PROGRESS = new AdapterVersionStatus("CREATION_IN_PROGRESS");

        /// <summary>
        /// Constant DEPRECATED for AdapterVersionStatus
        /// </summary>
        public static readonly AdapterVersionStatus DEPRECATED = new AdapterVersionStatus("DEPRECATED");

        /// <summary>
        /// Constructs a custom AdapterVersionStatus for a value not among the defined constants.
        /// </summary>
        public AdapterVersionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdapterVersionStatus FindValue(string value)
        {
            return FindValue<AdapterVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdapterVersionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AutoUpdate.
    /// </summary>
    public class AutoUpdate : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for AutoUpdate
        /// </summary>
        public static readonly AutoUpdate DISABLED = new AutoUpdate("DISABLED");

        /// <summary>
        /// Constant ENABLED for AutoUpdate
        /// </summary>
        public static readonly AutoUpdate ENABLED = new AutoUpdate("ENABLED");

        /// <summary>
        /// Constructs a custom AutoUpdate for a value not among the defined constants.
        /// </summary>
        public AutoUpdate(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoUpdate FindValue(string value)
        {
            return FindValue<AutoUpdate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoUpdate(string value)
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
        /// Constant CELL for BlockType
        /// </summary>
        public static readonly BlockType CELL = new BlockType("CELL");

        /// <summary>
        /// Constant KEY_VALUE_SET for BlockType
        /// </summary>
        public static readonly BlockType KEY_VALUE_SET = new BlockType("KEY_VALUE_SET");

        /// <summary>
        /// Constant LAYOUT_FIGURE for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_FIGURE = new BlockType("LAYOUT_FIGURE");

        /// <summary>
        /// Constant LAYOUT_FOOTER for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_FOOTER = new BlockType("LAYOUT_FOOTER");

        /// <summary>
        /// Constant LAYOUT_HEADER for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_HEADER = new BlockType("LAYOUT_HEADER");

        /// <summary>
        /// Constant LAYOUT_KEY_VALUE for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_KEY_VALUE = new BlockType("LAYOUT_KEY_VALUE");

        /// <summary>
        /// Constant LAYOUT_LIST for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_LIST = new BlockType("LAYOUT_LIST");

        /// <summary>
        /// Constant LAYOUT_PAGE_NUMBER for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_PAGE_NUMBER = new BlockType("LAYOUT_PAGE_NUMBER");

        /// <summary>
        /// Constant LAYOUT_SECTION_HEADER for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_SECTION_HEADER = new BlockType("LAYOUT_SECTION_HEADER");

        /// <summary>
        /// Constant LAYOUT_TABLE for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_TABLE = new BlockType("LAYOUT_TABLE");

        /// <summary>
        /// Constant LAYOUT_TEXT for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_TEXT = new BlockType("LAYOUT_TEXT");

        /// <summary>
        /// Constant LAYOUT_TITLE for BlockType
        /// </summary>
        public static readonly BlockType LAYOUT_TITLE = new BlockType("LAYOUT_TITLE");

        /// <summary>
        /// Constant LINE for BlockType
        /// </summary>
        public static readonly BlockType LINE = new BlockType("LINE");

        /// <summary>
        /// Constant MERGED_CELL for BlockType
        /// </summary>
        public static readonly BlockType MERGED_CELL = new BlockType("MERGED_CELL");

        /// <summary>
        /// Constant PAGE for BlockType
        /// </summary>
        public static readonly BlockType PAGE = new BlockType("PAGE");

        /// <summary>
        /// Constant QUERY for BlockType
        /// </summary>
        public static readonly BlockType QUERY = new BlockType("QUERY");

        /// <summary>
        /// Constant QUERY_RESULT for BlockType
        /// </summary>
        public static readonly BlockType QUERY_RESULT = new BlockType("QUERY_RESULT");

        /// <summary>
        /// Constant SELECTION_ELEMENT for BlockType
        /// </summary>
        public static readonly BlockType SELECTION_ELEMENT = new BlockType("SELECTION_ELEMENT");

        /// <summary>
        /// Constant SIGNATURE for BlockType
        /// </summary>
        public static readonly BlockType SIGNATURE = new BlockType("SIGNATURE");

        /// <summary>
        /// Constant TABLE for BlockType
        /// </summary>
        public static readonly BlockType TABLE = new BlockType("TABLE");

        /// <summary>
        /// Constant TABLE_FOOTER for BlockType
        /// </summary>
        public static readonly BlockType TABLE_FOOTER = new BlockType("TABLE_FOOTER");

        /// <summary>
        /// Constant TABLE_TITLE for BlockType
        /// </summary>
        public static readonly BlockType TABLE_TITLE = new BlockType("TABLE_TITLE");

        /// <summary>
        /// Constant TITLE for BlockType
        /// </summary>
        public static readonly BlockType TITLE = new BlockType("TITLE");

        /// <summary>
        /// Constant WORD for BlockType
        /// </summary>
        public static readonly BlockType WORD = new BlockType("WORD");

        /// <summary>
        /// Constructs a custom BlockType for a value not among the defined constants.
        /// </summary>
        public BlockType(string value) : base(value) { }

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
    /// Constants used for properties of type ContentClassifier.
    /// </summary>
    public class ContentClassifier : ConstantClass
    {
        /// <summary>
        /// Constant FreeOfAdultContent for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfAdultContent = new ContentClassifier("FreeOfAdultContent");

        /// <summary>
        /// Constant FreeOfPersonallyIdentifiableInformation for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfPersonallyIdentifiableInformation = new ContentClassifier("FreeOfPersonallyIdentifiableInformation");

        /// <summary>
        /// Constructs a custom ContentClassifier for a value not among the defined constants.
        /// </summary>
        public ContentClassifier(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentClassifier FindValue(string value)
        {
            return FindValue<ContentClassifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentClassifier(string value)
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
        /// Constant COLUMN_HEADER for EntityType
        /// </summary>
        public static readonly EntityType COLUMN_HEADER = new EntityType("COLUMN_HEADER");

        /// <summary>
        /// Constant KEY for EntityType
        /// </summary>
        public static readonly EntityType KEY = new EntityType("KEY");

        /// <summary>
        /// Constant SEMI_STRUCTURED_TABLE for EntityType
        /// </summary>
        public static readonly EntityType SEMI_STRUCTURED_TABLE = new EntityType("SEMI_STRUCTURED_TABLE");

        /// <summary>
        /// Constant STRUCTURED_TABLE for EntityType
        /// </summary>
        public static readonly EntityType STRUCTURED_TABLE = new EntityType("STRUCTURED_TABLE");

        /// <summary>
        /// Constant TABLE_FOOTER for EntityType
        /// </summary>
        public static readonly EntityType TABLE_FOOTER = new EntityType("TABLE_FOOTER");

        /// <summary>
        /// Constant TABLE_SECTION_TITLE for EntityType
        /// </summary>
        public static readonly EntityType TABLE_SECTION_TITLE = new EntityType("TABLE_SECTION_TITLE");

        /// <summary>
        /// Constant TABLE_SUMMARY for EntityType
        /// </summary>
        public static readonly EntityType TABLE_SUMMARY = new EntityType("TABLE_SUMMARY");

        /// <summary>
        /// Constant TABLE_TITLE for EntityType
        /// </summary>
        public static readonly EntityType TABLE_TITLE = new EntityType("TABLE_TITLE");

        /// <summary>
        /// Constant VALUE for EntityType
        /// </summary>
        public static readonly EntityType VALUE = new EntityType("VALUE");

        /// <summary>
        /// Constructs a custom EntityType for a value not among the defined constants.
        /// </summary>
        public EntityType(string value) : base(value) { }

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
    /// Constants used for properties of type ExtractionGranularityType.
    /// </summary>
    public class ExtractionGranularityType : ConstantClass
    {
        /// <summary>
        /// Constant DOCUMENT for ExtractionGranularityType
        /// </summary>
        public static readonly ExtractionGranularityType DOCUMENT = new ExtractionGranularityType("DOCUMENT");

        /// <summary>
        /// Constant ELEMENT for ExtractionGranularityType
        /// </summary>
        public static readonly ExtractionGranularityType ELEMENT = new ExtractionGranularityType("ELEMENT");

        /// <summary>
        /// Constant LINE for ExtractionGranularityType
        /// </summary>
        public static readonly ExtractionGranularityType LINE = new ExtractionGranularityType("LINE");

        /// <summary>
        /// Constant PAGE for ExtractionGranularityType
        /// </summary>
        public static readonly ExtractionGranularityType PAGE = new ExtractionGranularityType("PAGE");

        /// <summary>
        /// Constant WORD for ExtractionGranularityType
        /// </summary>
        public static readonly ExtractionGranularityType WORD = new ExtractionGranularityType("WORD");

        /// <summary>
        /// Constructs a custom ExtractionGranularityType for a value not among the defined constants.
        /// </summary>
        public ExtractionGranularityType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtractionGranularityType FindValue(string value)
        {
            return FindValue<ExtractionGranularityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtractionGranularityType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FeatureType.
    /// </summary>
    public class FeatureType : ConstantClass
    {
        /// <summary>
        /// Constant FORMS for FeatureType
        /// </summary>
        public static readonly FeatureType FORMS = new FeatureType("FORMS");

        /// <summary>
        /// Constant LAYOUT for FeatureType
        /// </summary>
        public static readonly FeatureType LAYOUT = new FeatureType("LAYOUT");

        /// <summary>
        /// Constant QUERIES for FeatureType
        /// </summary>
        public static readonly FeatureType QUERIES = new FeatureType("QUERIES");

        /// <summary>
        /// Constant SIGNATURES for FeatureType
        /// </summary>
        public static readonly FeatureType SIGNATURES = new FeatureType("SIGNATURES");

        /// <summary>
        /// Constant TABLES for FeatureType
        /// </summary>
        public static readonly FeatureType TABLES = new FeatureType("TABLES");

        /// <summary>
        /// Constructs a custom FeatureType for a value not among the defined constants.
        /// </summary>
        public FeatureType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureType FindValue(string value)
        {
            return FindValue<FeatureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureType(string value)
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
        /// Constant PARTIAL_SUCCESS for JobStatus
        /// </summary>
        public static readonly JobStatus PARTIAL_SUCCESS = new JobStatus("PARTIAL_SUCCESS");

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
    /// Constants used for properties of type OutputTextFormatType.
    /// </summary>
    public class OutputTextFormatType : ConstantClass
    {
        /// <summary>
        /// Constant CSV for OutputTextFormatType
        /// </summary>
        public static readonly OutputTextFormatType CSV = new OutputTextFormatType("CSV");

        /// <summary>
        /// Constant HTML for OutputTextFormatType
        /// </summary>
        public static readonly OutputTextFormatType HTML = new OutputTextFormatType("HTML");

        /// <summary>
        /// Constant MARKDOWN for OutputTextFormatType
        /// </summary>
        public static readonly OutputTextFormatType MARKDOWN = new OutputTextFormatType("MARKDOWN");

        /// <summary>
        /// Constant PLAIN_TEXT for OutputTextFormatType
        /// </summary>
        public static readonly OutputTextFormatType PLAIN_TEXT = new OutputTextFormatType("PLAIN_TEXT");

        /// <summary>
        /// Constructs a custom OutputTextFormatType for a value not among the defined constants.
        /// </summary>
        public OutputTextFormatType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputTextFormatType FindValue(string value)
        {
            return FindValue<OutputTextFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputTextFormatType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PIIEntityType.
    /// </summary>
    public class PIIEntityType : ConstantClass
    {
        /// <summary>
        /// Constant ADDRESS for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType ADDRESS = new PIIEntityType("ADDRESS");

        /// <summary>
        /// Constant AGE for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType AGE = new PIIEntityType("AGE");

        /// <summary>
        /// Constant ALL for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType ALL = new PIIEntityType("ALL");

        /// <summary>
        /// Constant AWS_ACCESS_KEY for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType AWS_ACCESS_KEY = new PIIEntityType("AWS_ACCESS_KEY");

        /// <summary>
        /// Constant AWS_SECRET_KEY for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType AWS_SECRET_KEY = new PIIEntityType("AWS_SECRET_KEY");

        /// <summary>
        /// Constant CA_HEALTH_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType CA_HEALTH_NUMBER = new PIIEntityType("CA_HEALTH_NUMBER");

        /// <summary>
        /// Constant CA_SOCIAL_INSURANCE_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType CA_SOCIAL_INSURANCE_NUMBER = new PIIEntityType("CA_SOCIAL_INSURANCE_NUMBER");

        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_CVV for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType CREDIT_DEBIT_CARD_CVV = new PIIEntityType("CREDIT_DEBIT_CARD_CVV");

        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_EXPIRY for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType CREDIT_DEBIT_CARD_EXPIRY = new PIIEntityType("CREDIT_DEBIT_CARD_EXPIRY");

        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType CREDIT_DEBIT_CARD_NUMBER = new PIIEntityType("CREDIT_DEBIT_CARD_NUMBER");

        /// <summary>
        /// Constant DRIVER_ID for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType DRIVER_ID = new PIIEntityType("DRIVER_ID");

        /// <summary>
        /// Constant EMAIL for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType EMAIL = new PIIEntityType("EMAIL");

        /// <summary>
        /// Constant INTERNATIONAL_BANK_ACCOUNT_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType INTERNATIONAL_BANK_ACCOUNT_NUMBER = new PIIEntityType("INTERNATIONAL_BANK_ACCOUNT_NUMBER");

        /// <summary>
        /// Constant IP_ADDRESS for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType IP_ADDRESS = new PIIEntityType("IP_ADDRESS");

        /// <summary>
        /// Constant LICENSE_PLATE for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType LICENSE_PLATE = new PIIEntityType("LICENSE_PLATE");

        /// <summary>
        /// Constant MAC_ADDRESS for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType MAC_ADDRESS = new PIIEntityType("MAC_ADDRESS");

        /// <summary>
        /// Constant NAME for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType NAME = new PIIEntityType("NAME");

        /// <summary>
        /// Constant PASSWORD for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType PASSWORD = new PIIEntityType("PASSWORD");

        /// <summary>
        /// Constant PHONE for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType PHONE = new PIIEntityType("PHONE");

        /// <summary>
        /// Constant PIN for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType PIN = new PIIEntityType("PIN");

        /// <summary>
        /// Constant SWIFT_CODE for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType SWIFT_CODE = new PIIEntityType("SWIFT_CODE");

        /// <summary>
        /// Constant UK_NATIONAL_HEALTH_SERVICE_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType UK_NATIONAL_HEALTH_SERVICE_NUMBER = new PIIEntityType("UK_NATIONAL_HEALTH_SERVICE_NUMBER");

        /// <summary>
        /// Constant UK_NATIONAL_INSURANCE_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType UK_NATIONAL_INSURANCE_NUMBER = new PIIEntityType("UK_NATIONAL_INSURANCE_NUMBER");

        /// <summary>
        /// Constant UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER = new PIIEntityType("UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER");

        /// <summary>
        /// Constant URL for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType URL = new PIIEntityType("URL");

        /// <summary>
        /// Constant USERNAME for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType USERNAME = new PIIEntityType("USERNAME");

        /// <summary>
        /// Constant US_BANK_ACCOUNT_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType US_BANK_ACCOUNT_NUMBER = new PIIEntityType("US_BANK_ACCOUNT_NUMBER");

        /// <summary>
        /// Constant US_BANK_ROUTING_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType US_BANK_ROUTING_NUMBER = new PIIEntityType("US_BANK_ROUTING_NUMBER");

        /// <summary>
        /// Constant US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER = new PIIEntityType("US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER");

        /// <summary>
        /// Constant US_PASSPORT_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType US_PASSPORT_NUMBER = new PIIEntityType("US_PASSPORT_NUMBER");

        /// <summary>
        /// Constant US_SOCIAL_SECURITY_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType US_SOCIAL_SECURITY_NUMBER = new PIIEntityType("US_SOCIAL_SECURITY_NUMBER");

        /// <summary>
        /// Constant VEHICLE_IDENTIFICATION_NUMBER for PIIEntityType
        /// </summary>
        public static readonly PIIEntityType VEHICLE_IDENTIFICATION_NUMBER = new PIIEntityType("VEHICLE_IDENTIFICATION_NUMBER");

        /// <summary>
        /// Constructs a custom PIIEntityType for a value not among the defined constants.
        /// </summary>
        public PIIEntityType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PIIEntityType FindValue(string value)
        {
            return FindValue<PIIEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PIIEntityType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PIIRedactionMaskMode.
    /// </summary>
    public class PIIRedactionMaskMode : ConstantClass
    {
        /// <summary>
        /// Constant ENTITY_TYPE for PIIRedactionMaskMode
        /// </summary>
        public static readonly PIIRedactionMaskMode ENTITY_TYPE = new PIIRedactionMaskMode("ENTITY_TYPE");

        /// <summary>
        /// Constant PII for PIIRedactionMaskMode
        /// </summary>
        public static readonly PIIRedactionMaskMode PII = new PIIRedactionMaskMode("PII");

        /// <summary>
        /// Constructs a custom PIIRedactionMaskMode for a value not among the defined constants.
        /// </summary>
        public PIIRedactionMaskMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PIIRedactionMaskMode FindValue(string value)
        {
            return FindValue<PIIRedactionMaskMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PIIRedactionMaskMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProjectStatus.
    /// </summary>
    public class ProjectStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus COMPLETED = new ProjectStatus("COMPLETED");

        /// <summary>
        /// Constant FAILED for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus FAILED = new ProjectStatus("FAILED");

        /// <summary>
        /// Constructs a custom ProjectStatus for a value not among the defined constants.
        /// </summary>
        public ProjectStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectStatus FindValue(string value)
        {
            return FindValue<ProjectStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectStatus(string value)
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
        /// Constant ANSWER for RelationshipType
        /// </summary>
        public static readonly RelationshipType ANSWER = new RelationshipType("ANSWER");

        /// <summary>
        /// Constant CHILD for RelationshipType
        /// </summary>
        public static readonly RelationshipType CHILD = new RelationshipType("CHILD");

        /// <summary>
        /// Constant COMPLEX_FEATURES for RelationshipType
        /// </summary>
        public static readonly RelationshipType COMPLEX_FEATURES = new RelationshipType("COMPLEX_FEATURES");

        /// <summary>
        /// Constant MERGED_CELL for RelationshipType
        /// </summary>
        public static readonly RelationshipType MERGED_CELL = new RelationshipType("MERGED_CELL");

        /// <summary>
        /// Constant TABLE for RelationshipType
        /// </summary>
        public static readonly RelationshipType TABLE = new RelationshipType("TABLE");

        /// <summary>
        /// Constant TABLE_FOOTER for RelationshipType
        /// </summary>
        public static readonly RelationshipType TABLE_FOOTER = new RelationshipType("TABLE_FOOTER");

        /// <summary>
        /// Constant TABLE_TITLE for RelationshipType
        /// </summary>
        public static readonly RelationshipType TABLE_TITLE = new RelationshipType("TABLE_TITLE");

        /// <summary>
        /// Constant TITLE for RelationshipType
        /// </summary>
        public static readonly RelationshipType TITLE = new RelationshipType("TITLE");

        /// <summary>
        /// Constant VALUE for RelationshipType
        /// </summary>
        public static readonly RelationshipType VALUE = new RelationshipType("VALUE");

        /// <summary>
        /// Constructs a custom RelationshipType for a value not among the defined constants.
        /// </summary>
        public RelationshipType(string value) : base(value) { }

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
    /// Constants used for properties of type ResourceOwner.
    /// </summary>
    public class ResourceOwner : ConstantClass
    {
        /// <summary>
        /// Constant ACCOUNT for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner ACCOUNT = new ResourceOwner("ACCOUNT");

        /// <summary>
        /// Constant SERVICE for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner SERVICE = new ResourceOwner("SERVICE");

        /// <summary>
        /// Constructs a custom ResourceOwner for a value not among the defined constants.
        /// </summary>
        public ResourceOwner(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceOwner FindValue(string value)
        {
            return FindValue<ResourceOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceOwner(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SelectionStatus.
    /// </summary>
    public class SelectionStatus : ConstantClass
    {
        /// <summary>
        /// Constant NOT_SELECTED for SelectionStatus
        /// </summary>
        public static readonly SelectionStatus NOT_SELECTED = new SelectionStatus("NOT_SELECTED");

        /// <summary>
        /// Constant SELECTED for SelectionStatus
        /// </summary>
        public static readonly SelectionStatus SELECTED = new SelectionStatus("SELECTED");

        /// <summary>
        /// Constructs a custom SelectionStatus for a value not among the defined constants.
        /// </summary>
        public SelectionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelectionStatus FindValue(string value)
        {
            return FindValue<SelectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelectionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SensitiveDataDetectionMode.
    /// </summary>
    public class SensitiveDataDetectionMode : ConstantClass
    {
        /// <summary>
        /// Constant DETECTION for SensitiveDataDetectionMode
        /// </summary>
        public static readonly SensitiveDataDetectionMode DETECTION = new SensitiveDataDetectionMode("DETECTION");

        /// <summary>
        /// Constant DETECTION_AND_REDACTION for SensitiveDataDetectionMode
        /// </summary>
        public static readonly SensitiveDataDetectionMode DETECTION_AND_REDACTION = new SensitiveDataDetectionMode("DETECTION_AND_REDACTION");

        /// <summary>
        /// Constant DISABLED for SensitiveDataDetectionMode
        /// </summary>
        public static readonly SensitiveDataDetectionMode DISABLED = new SensitiveDataDetectionMode("DISABLED");

        /// <summary>
        /// Constructs a custom SensitiveDataDetectionMode for a value not among the defined constants.
        /// </summary>
        public SensitiveDataDetectionMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SensitiveDataDetectionMode FindValue(string value)
        {
            return FindValue<SensitiveDataDetectionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SensitiveDataDetectionMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for State
        /// </summary>
        public static readonly State DISABLED = new State("DISABLED");

        /// <summary>
        /// Constant ENABLED for State
        /// </summary>
        public static readonly State ENABLED = new State("ENABLED");

        /// <summary>
        /// Constructs a custom State for a value not among the defined constants.
        /// </summary>
        public State(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TextType.
    /// </summary>
    public class TextType : ConstantClass
    {
        /// <summary>
        /// Constant HANDWRITING for TextType
        /// </summary>
        public static readonly TextType HANDWRITING = new TextType("HANDWRITING");

        /// <summary>
        /// Constant PRINTED for TextType
        /// </summary>
        public static readonly TextType PRINTED = new TextType("PRINTED");

        /// <summary>
        /// Constructs a custom TextType for a value not among the defined constants.
        /// </summary>
        public TextType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextType FindValue(string value)
        {
            return FindValue<TextType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ValueType.
    /// </summary>
    public class ValueType : ConstantClass
    {
        /// <summary>
        /// Constant DATE for ValueType
        /// </summary>
        public static readonly ValueType DATE = new ValueType("DATE");

        /// <summary>
        /// Constructs a custom ValueType for a value not among the defined constants.
        /// </summary>
        public ValueType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValueType FindValue(string value)
        {
            return FindValue<ValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValueType(string value)
        {
            return FindValue(value);
        }
    }
}
