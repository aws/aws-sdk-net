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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationCostProfiler
{

    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant CSV for Format
        /// </summary>
        public static readonly Format CSV = new Format("CSV");
        /// <summary>
        /// Constant PARQUET for Format
        /// </summary>
        public static readonly Format PARQUET = new Format("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFrequency.
    /// </summary>
    public class ReportFrequency : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ReportFrequency
        /// </summary>
        public static readonly ReportFrequency ALL = new ReportFrequency("ALL");
        /// <summary>
        /// Constant DAILY for ReportFrequency
        /// </summary>
        public static readonly ReportFrequency DAILY = new ReportFrequency("DAILY");
        /// <summary>
        /// Constant MONTHLY for ReportFrequency
        /// </summary>
        public static readonly ReportFrequency MONTHLY = new ReportFrequency("MONTHLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFrequency FindValue(string value)
        {
            return FindValue<ReportFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3BucketRegion.
    /// </summary>
    public class S3BucketRegion : ConstantClass
    {

        /// <summary>
        /// Constant AfSouth1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion AfSouth1 = new S3BucketRegion("af-south-1");
        /// <summary>
        /// Constant ApEast1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApEast1 = new S3BucketRegion("ap-east-1");
        /// <summary>
        /// Constant EuSouth1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuSouth1 = new S3BucketRegion("eu-south-1");
        /// <summary>
        /// Constant MeSouth1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion MeSouth1 = new S3BucketRegion("me-south-1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3BucketRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3BucketRegion FindValue(string value)
        {
            return FindValue<S3BucketRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3BucketRegion(string value)
        {
            return FindValue(value);
        }
    }

}