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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CostAndUsageReport
{

    /// <summary>
    /// Constants used for properties of type AdditionalArtifact.
    /// </summary>
    public class AdditionalArtifact : ConstantClass
    {

        /// <summary>
        /// Constant ATHENA for AdditionalArtifact
        /// </summary>
        public static readonly AdditionalArtifact ATHENA = new AdditionalArtifact("ATHENA");
        /// <summary>
        /// Constant QUICKSIGHT for AdditionalArtifact
        /// </summary>
        public static readonly AdditionalArtifact QUICKSIGHT = new AdditionalArtifact("QUICKSIGHT");
        /// <summary>
        /// Constant REDSHIFT for AdditionalArtifact
        /// </summary>
        public static readonly AdditionalArtifact REDSHIFT = new AdditionalArtifact("REDSHIFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdditionalArtifact(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdditionalArtifact FindValue(string value)
        {
            return FindValue<AdditionalArtifact>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdditionalArtifact(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AWSRegion.
    /// </summary>
    public class AWSRegion : ConstantClass
    {

        /// <summary>
        /// Constant AfSouth1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion AfSouth1 = new AWSRegion("af-south-1");
        /// <summary>
        /// Constant ApEast1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApEast1 = new AWSRegion("ap-east-1");
        /// <summary>
        /// Constant ApNortheast1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApNortheast1 = new AWSRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApNortheast2 = new AWSRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApNortheast3 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApNortheast3 = new AWSRegion("ap-northeast-3");
        /// <summary>
        /// Constant ApSouth1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApSouth1 = new AWSRegion("ap-south-1");
        /// <summary>
        /// Constant ApSouth2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApSouth2 = new AWSRegion("ap-south-2");
        /// <summary>
        /// Constant ApSoutheast1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApSoutheast1 = new AWSRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApSoutheast2 = new AWSRegion("ap-southeast-2");
        /// <summary>
        /// Constant ApSoutheast3 for AWSRegion
        /// </summary>
        public static readonly AWSRegion ApSoutheast3 = new AWSRegion("ap-southeast-3");
        /// <summary>
        /// Constant CaCentral1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion CaCentral1 = new AWSRegion("ca-central-1");
        /// <summary>
        /// Constant CnNorth1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion CnNorth1 = new AWSRegion("cn-north-1");
        /// <summary>
        /// Constant CnNorthwest1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion CnNorthwest1 = new AWSRegion("cn-northwest-1");
        /// <summary>
        /// Constant EuCentral1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuCentral1 = new AWSRegion("eu-central-1");
        /// <summary>
        /// Constant EuCentral2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuCentral2 = new AWSRegion("eu-central-2");
        /// <summary>
        /// Constant EuNorth1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuNorth1 = new AWSRegion("eu-north-1");
        /// <summary>
        /// Constant EuSouth1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuSouth1 = new AWSRegion("eu-south-1");
        /// <summary>
        /// Constant EuSouth2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuSouth2 = new AWSRegion("eu-south-2");
        /// <summary>
        /// Constant EuWest1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuWest1 = new AWSRegion("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuWest2 = new AWSRegion("eu-west-2");
        /// <summary>
        /// Constant EuWest3 for AWSRegion
        /// </summary>
        public static readonly AWSRegion EuWest3 = new AWSRegion("eu-west-3");
        /// <summary>
        /// Constant MeCentral1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion MeCentral1 = new AWSRegion("me-central-1");
        /// <summary>
        /// Constant MeSouth1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion MeSouth1 = new AWSRegion("me-south-1");
        /// <summary>
        /// Constant SaEast1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion SaEast1 = new AWSRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion UsEast1 = new AWSRegion("us-east-1");
        /// <summary>
        /// Constant UsEast2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion UsEast2 = new AWSRegion("us-east-2");
        /// <summary>
        /// Constant UsWest1 for AWSRegion
        /// </summary>
        public static readonly AWSRegion UsWest1 = new AWSRegion("us-west-1");
        /// <summary>
        /// Constant UsWest2 for AWSRegion
        /// </summary>
        public static readonly AWSRegion UsWest2 = new AWSRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AWSRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AWSRegion FindValue(string value)
        {
            return FindValue<AWSRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AWSRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionFormat.
    /// </summary>
    public class CompressionFormat : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat GZIP = new CompressionFormat("GZIP");
        /// <summary>
        /// Constant Parquet for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat Parquet = new CompressionFormat("Parquet");
        /// <summary>
        /// Constant ZIP for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat ZIP = new CompressionFormat("ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionFormat FindValue(string value)
        {
            return FindValue<CompressionFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastStatus.
    /// </summary>
    public class LastStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR_NO_BUCKET for LastStatus
        /// </summary>
        public static readonly LastStatus ERROR_NO_BUCKET = new LastStatus("ERROR_NO_BUCKET");
        /// <summary>
        /// Constant ERROR_PERMISSIONS for LastStatus
        /// </summary>
        public static readonly LastStatus ERROR_PERMISSIONS = new LastStatus("ERROR_PERMISSIONS");
        /// <summary>
        /// Constant SUCCESS for LastStatus
        /// </summary>
        public static readonly LastStatus SUCCESS = new LastStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastStatus FindValue(string value)
        {
            return FindValue<LastStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFormat.
    /// </summary>
    public class ReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant Parquet for ReportFormat
        /// </summary>
        public static readonly ReportFormat Parquet = new ReportFormat("Parquet");
        /// <summary>
        /// Constant TextORcsv for ReportFormat
        /// </summary>
        public static readonly ReportFormat TextORcsv = new ReportFormat("textORcsv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFormat FindValue(string value)
        {
            return FindValue<ReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportVersioning.
    /// </summary>
    public class ReportVersioning : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_NEW_REPORT for ReportVersioning
        /// </summary>
        public static readonly ReportVersioning CREATE_NEW_REPORT = new ReportVersioning("CREATE_NEW_REPORT");
        /// <summary>
        /// Constant OVERWRITE_REPORT for ReportVersioning
        /// </summary>
        public static readonly ReportVersioning OVERWRITE_REPORT = new ReportVersioning("OVERWRITE_REPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportVersioning(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportVersioning FindValue(string value)
        {
            return FindValue<ReportVersioning>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportVersioning(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaElement.
    /// </summary>
    public class SchemaElement : ConstantClass
    {

        /// <summary>
        /// Constant MANUAL_DISCOUNT_COMPATIBILITY for SchemaElement
        /// </summary>
        public static readonly SchemaElement MANUAL_DISCOUNT_COMPATIBILITY = new SchemaElement("MANUAL_DISCOUNT_COMPATIBILITY");
        /// <summary>
        /// Constant RESOURCES for SchemaElement
        /// </summary>
        public static readonly SchemaElement RESOURCES = new SchemaElement("RESOURCES");
        /// <summary>
        /// Constant SPLIT_COST_ALLOCATION_DATA for SchemaElement
        /// </summary>
        public static readonly SchemaElement SPLIT_COST_ALLOCATION_DATA = new SchemaElement("SPLIT_COST_ALLOCATION_DATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaElement FindValue(string value)
        {
            return FindValue<SchemaElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeUnit.
    /// </summary>
    public class TimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for TimeUnit
        /// </summary>
        public static readonly TimeUnit DAILY = new TimeUnit("DAILY");
        /// <summary>
        /// Constant HOURLY for TimeUnit
        /// </summary>
        public static readonly TimeUnit HOURLY = new TimeUnit("HOURLY");
        /// <summary>
        /// Constant MONTHLY for TimeUnit
        /// </summary>
        public static readonly TimeUnit MONTHLY = new TimeUnit("MONTHLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeUnit FindValue(string value)
        {
            return FindValue<TimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeUnit(string value)
        {
            return FindValue(value);
        }
    }

}