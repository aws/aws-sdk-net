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

namespace Amazon.S3Vectors
{
    /// <summary>
    /// Constants used for properties of type DataType.
    /// </summary>
    public class DataType : ConstantClass
    {
        /// <summary>
        /// Constant Float32 for DataType
        /// </summary>
        public static readonly DataType Float32 = new DataType("float32");

        /// <summary>
        /// Constructs a custom DataType for a value not among the defined constants.
        /// </summary>
        public DataType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataType FindValue(string value)
        {
            return FindValue<DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DistanceMetric.
    /// </summary>
    public class DistanceMetric : ConstantClass
    {
        /// <summary>
        /// Constant Cosine for DistanceMetric
        /// </summary>
        public static readonly DistanceMetric Cosine = new DistanceMetric("cosine");

        /// <summary>
        /// Constant Euclidean for DistanceMetric
        /// </summary>
        public static readonly DistanceMetric Euclidean = new DistanceMetric("euclidean");

        /// <summary>
        /// Constructs a custom DistanceMetric for a value not among the defined constants.
        /// </summary>
        public DistanceMetric(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DistanceMetric FindValue(string value)
        {
            return FindValue<DistanceMetric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DistanceMetric(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IndexMode.
    /// </summary>
    public class IndexMode : ConstantClass
    {
        /// <summary>
        /// Constant CLASSIC for IndexMode
        /// </summary>
        public static readonly IndexMode CLASSIC = new IndexMode("CLASSIC");

        /// <summary>
        /// Constant ENHANCED for IndexMode
        /// </summary>
        public static readonly IndexMode ENHANCED = new IndexMode("ENHANCED");

        /// <summary>
        /// Constructs a custom IndexMode for a value not among the defined constants.
        /// </summary>
        public IndexMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexMode FindValue(string value)
        {
            return FindValue<IndexMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SseType.
    /// </summary>
    public class SseType : ConstantClass
    {
        /// <summary>
        /// Constant AES256 for SseType
        /// </summary>
        public static readonly SseType AES256 = new SseType("AES256");

        /// <summary>
        /// Constant AwsKms for SseType
        /// </summary>
        public static readonly SseType AwsKms = new SseType("aws:kms");

        /// <summary>
        /// Constructs a custom SseType for a value not among the defined constants.
        /// </summary>
        public SseType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SseType FindValue(string value)
        {
            return FindValue<SseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SseType(string value)
        {
            return FindValue(value);
        }
    }
}
