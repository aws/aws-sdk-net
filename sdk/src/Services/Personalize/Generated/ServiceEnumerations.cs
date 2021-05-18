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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Personalize
{

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionMode(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectiveSensitivity(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type RecipeProvider.
    /// </summary>
    public class RecipeProvider : ConstantClass
    {

        /// <summary>
        /// Constant SERVICE for RecipeProvider
        /// </summary>
        public static readonly RecipeProvider SERVICE = new RecipeProvider("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecipeProvider(string value)
            : base(value)
        {
        }

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
        /// Constant FULL for TrainingMode
        /// </summary>
        public static readonly TrainingMode FULL = new TrainingMode("FULL");
        /// <summary>
        /// Constant UPDATE for TrainingMode
        /// </summary>
        public static readonly TrainingMode UPDATE = new TrainingMode("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingMode(string value)
            : base(value)
        {
        }

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

}