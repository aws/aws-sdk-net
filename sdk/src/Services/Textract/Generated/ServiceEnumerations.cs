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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Textract
{

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentClassifier(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type FeatureType.
    /// </summary>
    public class FeatureType : ConstantClass
    {

        /// <summary>
        /// Constant FORMS for FeatureType
        /// </summary>
        public static readonly FeatureType FORMS = new FeatureType("FORMS");
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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelectionStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValueType(string value)
            : base(value)
        {
        }

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