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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SageMakerGeospatial
{

    /// <summary>
    /// Constants used for properties of type AlgorithmNameCloudRemoval.
    /// </summary>
    public class AlgorithmNameCloudRemoval : ConstantClass
    {

        /// <summary>
        /// Constant INTERPOLATION for AlgorithmNameCloudRemoval
        /// </summary>
        public static readonly AlgorithmNameCloudRemoval INTERPOLATION = new AlgorithmNameCloudRemoval("INTERPOLATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmNameCloudRemoval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmNameCloudRemoval FindValue(string value)
        {
            return FindValue<AlgorithmNameCloudRemoval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmNameCloudRemoval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlgorithmNameGeoMosaic.
    /// </summary>
    public class AlgorithmNameGeoMosaic : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic AVERAGE = new AlgorithmNameGeoMosaic("AVERAGE");
        /// <summary>
        /// Constant BILINEAR for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic BILINEAR = new AlgorithmNameGeoMosaic("BILINEAR");
        /// <summary>
        /// Constant CUBIC for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic CUBIC = new AlgorithmNameGeoMosaic("CUBIC");
        /// <summary>
        /// Constant CUBICSPLINE for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic CUBICSPLINE = new AlgorithmNameGeoMosaic("CUBICSPLINE");
        /// <summary>
        /// Constant LANCZOS for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic LANCZOS = new AlgorithmNameGeoMosaic("LANCZOS");
        /// <summary>
        /// Constant MAX for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic MAX = new AlgorithmNameGeoMosaic("MAX");
        /// <summary>
        /// Constant MED for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic MED = new AlgorithmNameGeoMosaic("MED");
        /// <summary>
        /// Constant MIN for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic MIN = new AlgorithmNameGeoMosaic("MIN");
        /// <summary>
        /// Constant MODE for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic MODE = new AlgorithmNameGeoMosaic("MODE");
        /// <summary>
        /// Constant NEAR for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic NEAR = new AlgorithmNameGeoMosaic("NEAR");
        /// <summary>
        /// Constant Q1 for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic Q1 = new AlgorithmNameGeoMosaic("Q1");
        /// <summary>
        /// Constant Q3 for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic Q3 = new AlgorithmNameGeoMosaic("Q3");
        /// <summary>
        /// Constant RMS for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic RMS = new AlgorithmNameGeoMosaic("RMS");
        /// <summary>
        /// Constant SUM for AlgorithmNameGeoMosaic
        /// </summary>
        public static readonly AlgorithmNameGeoMosaic SUM = new AlgorithmNameGeoMosaic("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmNameGeoMosaic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmNameGeoMosaic FindValue(string value)
        {
            return FindValue<AlgorithmNameGeoMosaic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmNameGeoMosaic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlgorithmNameResampling.
    /// </summary>
    public class AlgorithmNameResampling : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling AVERAGE = new AlgorithmNameResampling("AVERAGE");
        /// <summary>
        /// Constant BILINEAR for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling BILINEAR = new AlgorithmNameResampling("BILINEAR");
        /// <summary>
        /// Constant CUBIC for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling CUBIC = new AlgorithmNameResampling("CUBIC");
        /// <summary>
        /// Constant CUBICSPLINE for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling CUBICSPLINE = new AlgorithmNameResampling("CUBICSPLINE");
        /// <summary>
        /// Constant LANCZOS for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling LANCZOS = new AlgorithmNameResampling("LANCZOS");
        /// <summary>
        /// Constant MAX for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling MAX = new AlgorithmNameResampling("MAX");
        /// <summary>
        /// Constant MED for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling MED = new AlgorithmNameResampling("MED");
        /// <summary>
        /// Constant MIN for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling MIN = new AlgorithmNameResampling("MIN");
        /// <summary>
        /// Constant MODE for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling MODE = new AlgorithmNameResampling("MODE");
        /// <summary>
        /// Constant NEAR for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling NEAR = new AlgorithmNameResampling("NEAR");
        /// <summary>
        /// Constant Q1 for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling Q1 = new AlgorithmNameResampling("Q1");
        /// <summary>
        /// Constant Q3 for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling Q3 = new AlgorithmNameResampling("Q3");
        /// <summary>
        /// Constant RMS for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling RMS = new AlgorithmNameResampling("RMS");
        /// <summary>
        /// Constant SUM for AlgorithmNameResampling
        /// </summary>
        public static readonly AlgorithmNameResampling SUM = new AlgorithmNameResampling("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmNameResampling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmNameResampling FindValue(string value)
        {
            return FindValue<AlgorithmNameResampling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmNameResampling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQUALS = new ComparisonOperator("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NOT_EQUALS = new ComparisonOperator("NOT_EQUALS");
        /// <summary>
        /// Constant STARTS_WITH for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator STARTS_WITH = new ComparisonOperator("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataCollectionType.
    /// </summary>
    public class DataCollectionType : ConstantClass
    {

        /// <summary>
        /// Constant PREMIUM for DataCollectionType
        /// </summary>
        public static readonly DataCollectionType PREMIUM = new DataCollectionType("PREMIUM");
        /// <summary>
        /// Constant PUBLIC for DataCollectionType
        /// </summary>
        public static readonly DataCollectionType PUBLIC = new DataCollectionType("PUBLIC");
        /// <summary>
        /// Constant USER for DataCollectionType
        /// </summary>
        public static readonly DataCollectionType USER = new DataCollectionType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataCollectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataCollectionType FindValue(string value)
        {
            return FindValue<DataCollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataCollectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EarthObservationJobErrorType.
    /// </summary>
    public class EarthObservationJobErrorType : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for EarthObservationJobErrorType
        /// </summary>
        public static readonly EarthObservationJobErrorType CLIENT_ERROR = new EarthObservationJobErrorType("CLIENT_ERROR");
        /// <summary>
        /// Constant SERVER_ERROR for EarthObservationJobErrorType
        /// </summary>
        public static readonly EarthObservationJobErrorType SERVER_ERROR = new EarthObservationJobErrorType("SERVER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EarthObservationJobErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EarthObservationJobErrorType FindValue(string value)
        {
            return FindValue<EarthObservationJobErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EarthObservationJobErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EarthObservationJobExportStatus.
    /// </summary>
    public class EarthObservationJobExportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for EarthObservationJobExportStatus
        /// </summary>
        public static readonly EarthObservationJobExportStatus FAILED = new EarthObservationJobExportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for EarthObservationJobExportStatus
        /// </summary>
        public static readonly EarthObservationJobExportStatus IN_PROGRESS = new EarthObservationJobExportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for EarthObservationJobExportStatus
        /// </summary>
        public static readonly EarthObservationJobExportStatus SUCCEEDED = new EarthObservationJobExportStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EarthObservationJobExportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EarthObservationJobExportStatus FindValue(string value)
        {
            return FindValue<EarthObservationJobExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EarthObservationJobExportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EarthObservationJobStatus.
    /// </summary>
    public class EarthObservationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus COMPLETED = new EarthObservationJobStatus("COMPLETED");
        /// <summary>
        /// Constant DELETED for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus DELETED = new EarthObservationJobStatus("DELETED");
        /// <summary>
        /// Constant DELETING for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus DELETING = new EarthObservationJobStatus("DELETING");
        /// <summary>
        /// Constant FAILED for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus FAILED = new EarthObservationJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus IN_PROGRESS = new EarthObservationJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INITIALIZING for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus INITIALIZING = new EarthObservationJobStatus("INITIALIZING");
        /// <summary>
        /// Constant STOPPED for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus STOPPED = new EarthObservationJobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for EarthObservationJobStatus
        /// </summary>
        public static readonly EarthObservationJobStatus STOPPING = new EarthObservationJobStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EarthObservationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EarthObservationJobStatus FindValue(string value)
        {
            return FindValue<EarthObservationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EarthObservationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportErrorType.
    /// </summary>
    public class ExportErrorType : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for ExportErrorType
        /// </summary>
        public static readonly ExportErrorType CLIENT_ERROR = new ExportErrorType("CLIENT_ERROR");
        /// <summary>
        /// Constant SERVER_ERROR for ExportErrorType
        /// </summary>
        public static readonly ExportErrorType SERVER_ERROR = new ExportErrorType("SERVER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportErrorType FindValue(string value)
        {
            return FindValue<ExportErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupBy.
    /// </summary>
    public class GroupBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for GroupBy
        /// </summary>
        public static readonly GroupBy ALL = new GroupBy("ALL");
        /// <summary>
        /// Constant YEARLY for GroupBy
        /// </summary>
        public static readonly GroupBy YEARLY = new GroupBy("YEARLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupBy FindValue(string value)
        {
            return FindValue<GroupBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogicalOperator.
    /// </summary>
    public class LogicalOperator : ConstantClass
    {

        /// <summary>
        /// Constant AND for LogicalOperator
        /// </summary>
        public static readonly LogicalOperator AND = new LogicalOperator("AND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogicalOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogicalOperator FindValue(string value)
        {
            return FindValue<LogicalOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogicalOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetadataProvider.
    /// </summary>
    public class MetadataProvider : ConstantClass
    {

        /// <summary>
        /// Constant PLANET_ORDER for MetadataProvider
        /// </summary>
        public static readonly MetadataProvider PLANET_ORDER = new MetadataProvider("PLANET_ORDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataProvider FindValue(string value)
        {
            return FindValue<MetadataProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputType.
    /// </summary>
    public class OutputType : ConstantClass
    {

        /// <summary>
        /// Constant FLOAT32 for OutputType
        /// </summary>
        public static readonly OutputType FLOAT32 = new OutputType("FLOAT32");
        /// <summary>
        /// Constant FLOAT64 for OutputType
        /// </summary>
        public static readonly OutputType FLOAT64 = new OutputType("FLOAT64");
        /// <summary>
        /// Constant INT16 for OutputType
        /// </summary>
        public static readonly OutputType INT16 = new OutputType("INT16");
        /// <summary>
        /// Constant INT32 for OutputType
        /// </summary>
        public static readonly OutputType INT32 = new OutputType("INT32");
        /// <summary>
        /// Constant UINT16 for OutputType
        /// </summary>
        public static readonly OutputType UINT16 = new OutputType("UINT16");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputType FindValue(string value)
        {
            return FindValue<OutputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PredefinedResolution.
    /// </summary>
    public class PredefinedResolution : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for PredefinedResolution
        /// </summary>
        public static readonly PredefinedResolution AVERAGE = new PredefinedResolution("AVERAGE");
        /// <summary>
        /// Constant HIGHEST for PredefinedResolution
        /// </summary>
        public static readonly PredefinedResolution HIGHEST = new PredefinedResolution("HIGHEST");
        /// <summary>
        /// Constant LOWEST for PredefinedResolution
        /// </summary>
        public static readonly PredefinedResolution LOWEST = new PredefinedResolution("LOWEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PredefinedResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PredefinedResolution FindValue(string value)
        {
            return FindValue<PredefinedResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PredefinedResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetOptions.
    /// </summary>
    public class TargetOptions : ConstantClass
    {

        /// <summary>
        /// Constant INPUT for TargetOptions
        /// </summary>
        public static readonly TargetOptions INPUT = new TargetOptions("INPUT");
        /// <summary>
        /// Constant OUTPUT for TargetOptions
        /// </summary>
        public static readonly TargetOptions OUTPUT = new TargetOptions("OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetOptions FindValue(string value)
        {
            return FindValue<TargetOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemporalStatistics.
    /// </summary>
    public class TemporalStatistics : ConstantClass
    {

        /// <summary>
        /// Constant MEAN for TemporalStatistics
        /// </summary>
        public static readonly TemporalStatistics MEAN = new TemporalStatistics("MEAN");
        /// <summary>
        /// Constant MEDIAN for TemporalStatistics
        /// </summary>
        public static readonly TemporalStatistics MEDIAN = new TemporalStatistics("MEDIAN");
        /// <summary>
        /// Constant STANDARD_DEVIATION for TemporalStatistics
        /// </summary>
        public static readonly TemporalStatistics STANDARD_DEVIATION = new TemporalStatistics("STANDARD_DEVIATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemporalStatistics(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemporalStatistics FindValue(string value)
        {
            return FindValue<TemporalStatistics>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemporalStatistics(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant METERS for Unit
        /// </summary>
        public static readonly Unit METERS = new Unit("METERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VectorEnrichmentJobDocumentType.
    /// </summary>
    public class VectorEnrichmentJobDocumentType : ConstantClass
    {

        /// <summary>
        /// Constant CSV for VectorEnrichmentJobDocumentType
        /// </summary>
        public static readonly VectorEnrichmentJobDocumentType CSV = new VectorEnrichmentJobDocumentType("CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VectorEnrichmentJobDocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VectorEnrichmentJobDocumentType FindValue(string value)
        {
            return FindValue<VectorEnrichmentJobDocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VectorEnrichmentJobDocumentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VectorEnrichmentJobErrorType.
    /// </summary>
    public class VectorEnrichmentJobErrorType : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for VectorEnrichmentJobErrorType
        /// </summary>
        public static readonly VectorEnrichmentJobErrorType CLIENT_ERROR = new VectorEnrichmentJobErrorType("CLIENT_ERROR");
        /// <summary>
        /// Constant SERVER_ERROR for VectorEnrichmentJobErrorType
        /// </summary>
        public static readonly VectorEnrichmentJobErrorType SERVER_ERROR = new VectorEnrichmentJobErrorType("SERVER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VectorEnrichmentJobErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VectorEnrichmentJobErrorType FindValue(string value)
        {
            return FindValue<VectorEnrichmentJobErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VectorEnrichmentJobErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VectorEnrichmentJobExportErrorType.
    /// </summary>
    public class VectorEnrichmentJobExportErrorType : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for VectorEnrichmentJobExportErrorType
        /// </summary>
        public static readonly VectorEnrichmentJobExportErrorType CLIENT_ERROR = new VectorEnrichmentJobExportErrorType("CLIENT_ERROR");
        /// <summary>
        /// Constant SERVER_ERROR for VectorEnrichmentJobExportErrorType
        /// </summary>
        public static readonly VectorEnrichmentJobExportErrorType SERVER_ERROR = new VectorEnrichmentJobExportErrorType("SERVER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VectorEnrichmentJobExportErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VectorEnrichmentJobExportErrorType FindValue(string value)
        {
            return FindValue<VectorEnrichmentJobExportErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VectorEnrichmentJobExportErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VectorEnrichmentJobExportStatus.
    /// </summary>
    public class VectorEnrichmentJobExportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for VectorEnrichmentJobExportStatus
        /// </summary>
        public static readonly VectorEnrichmentJobExportStatus FAILED = new VectorEnrichmentJobExportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for VectorEnrichmentJobExportStatus
        /// </summary>
        public static readonly VectorEnrichmentJobExportStatus IN_PROGRESS = new VectorEnrichmentJobExportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for VectorEnrichmentJobExportStatus
        /// </summary>
        public static readonly VectorEnrichmentJobExportStatus SUCCEEDED = new VectorEnrichmentJobExportStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VectorEnrichmentJobExportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VectorEnrichmentJobExportStatus FindValue(string value)
        {
            return FindValue<VectorEnrichmentJobExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VectorEnrichmentJobExportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VectorEnrichmentJobStatus.
    /// </summary>
    public class VectorEnrichmentJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus COMPLETED = new VectorEnrichmentJobStatus("COMPLETED");
        /// <summary>
        /// Constant DELETED for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus DELETED = new VectorEnrichmentJobStatus("DELETED");
        /// <summary>
        /// Constant DELETING for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus DELETING = new VectorEnrichmentJobStatus("DELETING");
        /// <summary>
        /// Constant FAILED for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus FAILED = new VectorEnrichmentJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus IN_PROGRESS = new VectorEnrichmentJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INITIALIZING for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus INITIALIZING = new VectorEnrichmentJobStatus("INITIALIZING");
        /// <summary>
        /// Constant STOPPED for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus STOPPED = new VectorEnrichmentJobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for VectorEnrichmentJobStatus
        /// </summary>
        public static readonly VectorEnrichmentJobStatus STOPPING = new VectorEnrichmentJobStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VectorEnrichmentJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VectorEnrichmentJobStatus FindValue(string value)
        {
            return FindValue<VectorEnrichmentJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VectorEnrichmentJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VectorEnrichmentJobType.
    /// </summary>
    public class VectorEnrichmentJobType : ConstantClass
    {

        /// <summary>
        /// Constant MAP_MATCHING for VectorEnrichmentJobType
        /// </summary>
        public static readonly VectorEnrichmentJobType MAP_MATCHING = new VectorEnrichmentJobType("MAP_MATCHING");
        /// <summary>
        /// Constant REVERSE_GEOCODING for VectorEnrichmentJobType
        /// </summary>
        public static readonly VectorEnrichmentJobType REVERSE_GEOCODING = new VectorEnrichmentJobType("REVERSE_GEOCODING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VectorEnrichmentJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VectorEnrichmentJobType FindValue(string value)
        {
            return FindValue<VectorEnrichmentJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VectorEnrichmentJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ZonalStatistics.
    /// </summary>
    public class ZonalStatistics : ConstantClass
    {

        /// <summary>
        /// Constant MAX for ZonalStatistics
        /// </summary>
        public static readonly ZonalStatistics MAX = new ZonalStatistics("MAX");
        /// <summary>
        /// Constant MEAN for ZonalStatistics
        /// </summary>
        public static readonly ZonalStatistics MEAN = new ZonalStatistics("MEAN");
        /// <summary>
        /// Constant MEDIAN for ZonalStatistics
        /// </summary>
        public static readonly ZonalStatistics MEDIAN = new ZonalStatistics("MEDIAN");
        /// <summary>
        /// Constant MIN for ZonalStatistics
        /// </summary>
        public static readonly ZonalStatistics MIN = new ZonalStatistics("MIN");
        /// <summary>
        /// Constant STANDARD_DEVIATION for ZonalStatistics
        /// </summary>
        public static readonly ZonalStatistics STANDARD_DEVIATION = new ZonalStatistics("STANDARD_DEVIATION");
        /// <summary>
        /// Constant SUM for ZonalStatistics
        /// </summary>
        public static readonly ZonalStatistics SUM = new ZonalStatistics("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZonalStatistics(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZonalStatistics FindValue(string value)
        {
            return FindValue<ZonalStatistics>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZonalStatistics(string value)
        {
            return FindValue(value);
        }
    }

}