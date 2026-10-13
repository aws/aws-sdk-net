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

namespace Amazon.Personalize
{
    /// <summary>
    /// Constants used for properties of type BatchInferenceJobMode.
    /// </summary>
    public class BatchInferenceJobMode : ConstantClass
    {
        /// <summary>
        /// Constant BATCH_INFERENCE for BatchInferenceJobMode
        /// </summary>
        public static readonly BatchInferenceJobMode BATCH_INFERENCE = new BatchInferenceJobMode("BATCH_INFERENCE");

        /// <summary>
        /// Constant THEME_GENERATION for BatchInferenceJobMode
        /// </summary>
        public static readonly BatchInferenceJobMode THEME_GENERATION = new BatchInferenceJobMode("THEME_GENERATION");

        /// <summary>
        /// Constructs a custom BatchInferenceJobMode for a value not among the defined constants.
        /// </summary>
        public BatchInferenceJobMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchInferenceJobMode FindValue(string value)
        {
            return FindValue<BatchInferenceJobMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchInferenceJobMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Domain.
    /// </summary>
    public class Domain : ConstantClass
    {
        /// <summary>
        /// Constant ECOMMERCE for Domain
        /// </summary>
        public static readonly Domain ECOMMERCE = new Domain("ECOMMERCE");

        /// <summary>
        /// Constant VIDEO_ON_DEMAND for Domain
        /// </summary>
        public static readonly Domain VIDEO_ON_DEMAND = new Domain("VIDEO_ON_DEMAND");

        /// <summary>
        /// Constructs a custom Domain for a value not among the defined constants.
        /// </summary>
        public Domain(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Domain FindValue(string value)
        {
            return FindValue<Domain>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Domain(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ImportMode.
    /// </summary>
    public class ImportMode : ConstantClass
    {
        /// <summary>
        /// Constant FULL for ImportMode
        /// </summary>
        public static readonly ImportMode FULL = new ImportMode("FULL");

        /// <summary>
        /// Constant INCREMENTAL for ImportMode
        /// </summary>
        public static readonly ImportMode INCREMENTAL = new ImportMode("INCREMENTAL");

        /// <summary>
        /// Constructs a custom ImportMode for a value not among the defined constants.
        /// </summary>
        public ImportMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportMode FindValue(string value)
        {
            return FindValue<ImportMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IngestionMode.
    /// </summary>
    public class IngestionMode : ConstantClass
    {
        /// <summary>
        /// Constant ALL for IngestionMode
        /// </summary>
        public static readonly IngestionMode ALL = new IngestionMode("ALL");

        /// <summary>
        /// Constant BULK for IngestionMode
        /// </summary>
        public static readonly IngestionMode BULK = new IngestionMode("BULK");

        /// <summary>
        /// Constant PUT for IngestionMode
        /// </summary>
        public static readonly IngestionMode PUT = new IngestionMode("PUT");

        /// <summary>
        /// Constructs a custom IngestionMode for a value not among the defined constants.
        /// </summary>
        public IngestionMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionMode FindValue(string value)
        {
            return FindValue<IngestionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ObjectiveSensitivity.
    /// </summary>
    public class ObjectiveSensitivity : ConstantClass
    {
        /// <summary>
        /// Constant HIGH for ObjectiveSensitivity
        /// </summary>
        public static readonly ObjectiveSensitivity HIGH = new ObjectiveSensitivity("HIGH");

        /// <summary>
        /// Constant LOW for ObjectiveSensitivity
        /// </summary>
        public static readonly ObjectiveSensitivity LOW = new ObjectiveSensitivity("LOW");

        /// <summary>
        /// Constant MEDIUM for ObjectiveSensitivity
        /// </summary>
        public static readonly ObjectiveSensitivity MEDIUM = new ObjectiveSensitivity("MEDIUM");

        /// <summary>
        /// Constant OFF for ObjectiveSensitivity
        /// </summary>
        public static readonly ObjectiveSensitivity OFF = new ObjectiveSensitivity("OFF");

        /// <summary>
        /// Constructs a custom ObjectiveSensitivity for a value not among the defined constants.
        /// </summary>
        public ObjectiveSensitivity(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectiveSensitivity FindValue(string value)
        {
            return FindValue<ObjectiveSensitivity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectiveSensitivity(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RankingInfluenceType.
    /// </summary>
    public class RankingInfluenceType : ConstantClass
    {
        /// <summary>
        /// Constant FRESHNESS for RankingInfluenceType
        /// </summary>
        public static readonly RankingInfluenceType FRESHNESS = new RankingInfluenceType("FRESHNESS");

        /// <summary>
        /// Constant POPULARITY for RankingInfluenceType
        /// </summary>
        public static readonly RankingInfluenceType POPULARITY = new RankingInfluenceType("POPULARITY");

        /// <summary>
        /// Constructs a custom RankingInfluenceType for a value not among the defined constants.
        /// </summary>
        public RankingInfluenceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RankingInfluenceType FindValue(string value)
        {
            return FindValue<RankingInfluenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RankingInfluenceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RecipeProvider.
    /// </summary>
    public class RecipeProvider : ConstantClass
    {
        /// <summary>
        /// Constant SERVICE for RecipeProvider
        /// </summary>
        public static readonly RecipeProvider SERVICE = new RecipeProvider("SERVICE");

        /// <summary>
        /// Constructs a custom RecipeProvider for a value not among the defined constants.
        /// </summary>
        public RecipeProvider(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecipeProvider FindValue(string value)
        {
            return FindValue<RecipeProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecipeProvider(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TrainingMode.
    /// </summary>
    public class TrainingMode : ConstantClass
    {
        /// <summary>
        /// Constant AUTOTRAIN for TrainingMode
        /// </summary>
        public static readonly TrainingMode AUTOTRAIN = new TrainingMode("AUTOTRAIN");

        /// <summary>
        /// Constant FULL for TrainingMode
        /// </summary>
        public static readonly TrainingMode FULL = new TrainingMode("FULL");

        /// <summary>
        /// Constant UPDATE for TrainingMode
        /// </summary>
        public static readonly TrainingMode UPDATE = new TrainingMode("UPDATE");

        /// <summary>
        /// Constructs a custom TrainingMode for a value not among the defined constants.
        /// </summary>
        public TrainingMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingMode FindValue(string value)
        {
            return FindValue<TrainingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TrainingType.
    /// </summary>
    public class TrainingType : ConstantClass
    {
        /// <summary>
        /// Constant AUTOMATIC for TrainingType
        /// </summary>
        public static readonly TrainingType AUTOMATIC = new TrainingType("AUTOMATIC");

        /// <summary>
        /// Constant MANUAL for TrainingType
        /// </summary>
        public static readonly TrainingType MANUAL = new TrainingType("MANUAL");

        /// <summary>
        /// Constructs a custom TrainingType for a value not among the defined constants.
        /// </summary>
        public TrainingType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingType FindValue(string value)
        {
            return FindValue<TrainingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingType(string value)
        {
            return FindValue(value);
        }
    }
}
