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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Neptunedata
{

    /// <summary>
    /// Constants used for properties of type Action.
    /// </summary>
    public class Action : ConstantClass
    {

        /// <summary>
        /// Constant InitiateDatabaseReset for Action
        /// </summary>
        public static readonly Action InitiateDatabaseReset = new Action("initiateDatabaseReset");
        /// <summary>
        /// Constant PerformDatabaseReset for Action
        /// </summary>
        public static readonly Action PerformDatabaseReset = new Action("performDatabaseReset");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Action(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Action FindValue(string value)
        {
            return FindValue<Action>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Action(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Encoding.
    /// </summary>
    public class Encoding : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for Encoding
        /// </summary>
        public static readonly Encoding Gzip = new Encoding("gzip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Encoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Encoding FindValue(string value)
        {
            return FindValue<Encoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Encoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant Csv for Format
        /// </summary>
        public static readonly Format Csv = new Format("csv");
        /// <summary>
        /// Constant Nquads for Format
        /// </summary>
        public static readonly Format Nquads = new Format("nquads");
        /// <summary>
        /// Constant Ntriples for Format
        /// </summary>
        public static readonly Format Ntriples = new Format("ntriples");
        /// <summary>
        /// Constant Opencypher for Format
        /// </summary>
        public static readonly Format Opencypher = new Format("opencypher");
        /// <summary>
        /// Constant Rdfxml for Format
        /// </summary>
        public static readonly Format Rdfxml = new Format("rdfxml");
        /// <summary>
        /// Constant Turtle for Format
        /// </summary>
        public static readonly Format Turtle = new Format("turtle");

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
    /// Constants used for properties of type GraphSummaryType.
    /// </summary>
    public class GraphSummaryType : ConstantClass
    {

        /// <summary>
        /// Constant Basic for GraphSummaryType
        /// </summary>
        public static readonly GraphSummaryType Basic = new GraphSummaryType("basic");
        /// <summary>
        /// Constant Detailed for GraphSummaryType
        /// </summary>
        public static readonly GraphSummaryType Detailed = new GraphSummaryType("detailed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GraphSummaryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GraphSummaryType FindValue(string value)
        {
            return FindValue<GraphSummaryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GraphSummaryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IteratorType.
    /// </summary>
    public class IteratorType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_SEQUENCE_NUMBER for IteratorType
        /// </summary>
        public static readonly IteratorType AFTER_SEQUENCE_NUMBER = new IteratorType("AFTER_SEQUENCE_NUMBER");
        /// <summary>
        /// Constant AT_SEQUENCE_NUMBER for IteratorType
        /// </summary>
        public static readonly IteratorType AT_SEQUENCE_NUMBER = new IteratorType("AT_SEQUENCE_NUMBER");
        /// <summary>
        /// Constant LATEST for IteratorType
        /// </summary>
        public static readonly IteratorType LATEST = new IteratorType("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for IteratorType
        /// </summary>
        public static readonly IteratorType TRIM_HORIZON = new IteratorType("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IteratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IteratorType FindValue(string value)
        {
            return FindValue<IteratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IteratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mode.
    /// </summary>
    public class Mode : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for Mode
        /// </summary>
        public static readonly Mode AUTO = new Mode("AUTO");
        /// <summary>
        /// Constant NEW for Mode
        /// </summary>
        public static readonly Mode NEW = new Mode("NEW");
        /// <summary>
        /// Constant RESUME for Mode
        /// </summary>
        public static readonly Mode RESUME = new Mode("RESUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mode FindValue(string value)
        {
            return FindValue<Mode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenCypherExplainMode.
    /// </summary>
    public class OpenCypherExplainMode : ConstantClass
    {

        /// <summary>
        /// Constant Details for OpenCypherExplainMode
        /// </summary>
        public static readonly OpenCypherExplainMode Details = new OpenCypherExplainMode("details");
        /// <summary>
        /// Constant Dynamic for OpenCypherExplainMode
        /// </summary>
        public static readonly OpenCypherExplainMode Dynamic = new OpenCypherExplainMode("dynamic");
        /// <summary>
        /// Constant Static for OpenCypherExplainMode
        /// </summary>
        public static readonly OpenCypherExplainMode Static = new OpenCypherExplainMode("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenCypherExplainMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenCypherExplainMode FindValue(string value)
        {
            return FindValue<OpenCypherExplainMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenCypherExplainMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Parallelism.
    /// </summary>
    public class Parallelism : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Parallelism
        /// </summary>
        public static readonly Parallelism HIGH = new Parallelism("HIGH");
        /// <summary>
        /// Constant LOW for Parallelism
        /// </summary>
        public static readonly Parallelism LOW = new Parallelism("LOW");
        /// <summary>
        /// Constant MEDIUM for Parallelism
        /// </summary>
        public static readonly Parallelism MEDIUM = new Parallelism("MEDIUM");
        /// <summary>
        /// Constant OVERSUBSCRIBE for Parallelism
        /// </summary>
        public static readonly Parallelism OVERSUBSCRIBE = new Parallelism("OVERSUBSCRIBE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Parallelism(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Parallelism FindValue(string value)
        {
            return FindValue<Parallelism>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Parallelism(string value)
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
        /// Constant ApEast2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApEast2 = new S3BucketRegion("ap-east-2");
        /// <summary>
        /// Constant ApNortheast1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApNortheast1 = new S3BucketRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApNortheast2 = new S3BucketRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApNortheast3 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApNortheast3 = new S3BucketRegion("ap-northeast-3");
        /// <summary>
        /// Constant ApSouth1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSouth1 = new S3BucketRegion("ap-south-1");
        /// <summary>
        /// Constant ApSouth2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSouth2 = new S3BucketRegion("ap-south-2");
        /// <summary>
        /// Constant ApSoutheast1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSoutheast1 = new S3BucketRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSoutheast2 = new S3BucketRegion("ap-southeast-2");
        /// <summary>
        /// Constant ApSoutheast3 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSoutheast3 = new S3BucketRegion("ap-southeast-3");
        /// <summary>
        /// Constant ApSoutheast4 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSoutheast4 = new S3BucketRegion("ap-southeast-4");
        /// <summary>
        /// Constant ApSoutheast5 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSoutheast5 = new S3BucketRegion("ap-southeast-5");
        /// <summary>
        /// Constant ApSoutheast7 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion ApSoutheast7 = new S3BucketRegion("ap-southeast-7");
        /// <summary>
        /// Constant CaCentral1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion CaCentral1 = new S3BucketRegion("ca-central-1");
        /// <summary>
        /// Constant CaWest1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion CaWest1 = new S3BucketRegion("ca-west-1");
        /// <summary>
        /// Constant CnNorth1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion CnNorth1 = new S3BucketRegion("cn-north-1");
        /// <summary>
        /// Constant CnNorthwest1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion CnNorthwest1 = new S3BucketRegion("cn-northwest-1");
        /// <summary>
        /// Constant EuCentral1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuCentral1 = new S3BucketRegion("eu-central-1");
        /// <summary>
        /// Constant EuCentral2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuCentral2 = new S3BucketRegion("eu-central-2");
        /// <summary>
        /// Constant EuNorth1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuNorth1 = new S3BucketRegion("eu-north-1");
        /// <summary>
        /// Constant EuSouth2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuSouth2 = new S3BucketRegion("eu-south-2");
        /// <summary>
        /// Constant EuWest1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuWest1 = new S3BucketRegion("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuWest2 = new S3BucketRegion("eu-west-2");
        /// <summary>
        /// Constant EuWest3 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion EuWest3 = new S3BucketRegion("eu-west-3");
        /// <summary>
        /// Constant IlCentral1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion IlCentral1 = new S3BucketRegion("il-central-1");
        /// <summary>
        /// Constant MeCentral1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion MeCentral1 = new S3BucketRegion("me-central-1");
        /// <summary>
        /// Constant MeSouth1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion MeSouth1 = new S3BucketRegion("me-south-1");
        /// <summary>
        /// Constant MxCentral1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion MxCentral1 = new S3BucketRegion("mx-central-1");
        /// <summary>
        /// Constant SaEast1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion SaEast1 = new S3BucketRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion UsEast1 = new S3BucketRegion("us-east-1");
        /// <summary>
        /// Constant UsEast2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion UsEast2 = new S3BucketRegion("us-east-2");
        /// <summary>
        /// Constant UsGovEast1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion UsGovEast1 = new S3BucketRegion("us-gov-east-1");
        /// <summary>
        /// Constant UsGovWest1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion UsGovWest1 = new S3BucketRegion("us-gov-west-1");
        /// <summary>
        /// Constant UsWest1 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion UsWest1 = new S3BucketRegion("us-west-1");
        /// <summary>
        /// Constant UsWest2 for S3BucketRegion
        /// </summary>
        public static readonly S3BucketRegion UsWest2 = new S3BucketRegion("us-west-2");

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


    /// <summary>
    /// Constants used for properties of type StatisticsAutoGenerationMode.
    /// </summary>
    public class StatisticsAutoGenerationMode : ConstantClass
    {

        /// <summary>
        /// Constant DisableAutoCompute for StatisticsAutoGenerationMode
        /// </summary>
        public static readonly StatisticsAutoGenerationMode DisableAutoCompute = new StatisticsAutoGenerationMode("disableAutoCompute");
        /// <summary>
        /// Constant EnableAutoCompute for StatisticsAutoGenerationMode
        /// </summary>
        public static readonly StatisticsAutoGenerationMode EnableAutoCompute = new StatisticsAutoGenerationMode("enableAutoCompute");
        /// <summary>
        /// Constant Refresh for StatisticsAutoGenerationMode
        /// </summary>
        public static readonly StatisticsAutoGenerationMode Refresh = new StatisticsAutoGenerationMode("refresh");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatisticsAutoGenerationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatisticsAutoGenerationMode FindValue(string value)
        {
            return FindValue<StatisticsAutoGenerationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatisticsAutoGenerationMode(string value)
        {
            return FindValue(value);
        }
    }

}