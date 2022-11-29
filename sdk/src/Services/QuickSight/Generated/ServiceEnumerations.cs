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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.QuickSight
{

    /// <summary>
    /// Constants used for properties of type AnalysisErrorType.
    /// </summary>
    public class AnalysisErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType ACCESS_DENIED = new AnalysisErrorType("ACCESS_DENIED");
        /// <summary>
        /// Constant COLUMN_GEOGRAPHIC_ROLE_MISMATCH for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType COLUMN_GEOGRAPHIC_ROLE_MISMATCH = new AnalysisErrorType("COLUMN_GEOGRAPHIC_ROLE_MISMATCH");
        /// <summary>
        /// Constant COLUMN_REPLACEMENT_MISSING for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType COLUMN_REPLACEMENT_MISSING = new AnalysisErrorType("COLUMN_REPLACEMENT_MISSING");
        /// <summary>
        /// Constant COLUMN_TYPE_MISMATCH for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType COLUMN_TYPE_MISMATCH = new AnalysisErrorType("COLUMN_TYPE_MISMATCH");
        /// <summary>
        /// Constant DATA_SET_NOT_FOUND for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType DATA_SET_NOT_FOUND = new AnalysisErrorType("DATA_SET_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType INTERNAL_FAILURE = new AnalysisErrorType("INTERNAL_FAILURE");
        /// <summary>
        /// Constant PARAMETER_NOT_FOUND for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType PARAMETER_NOT_FOUND = new AnalysisErrorType("PARAMETER_NOT_FOUND");
        /// <summary>
        /// Constant PARAMETER_TYPE_INVALID for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType PARAMETER_TYPE_INVALID = new AnalysisErrorType("PARAMETER_TYPE_INVALID");
        /// <summary>
        /// Constant PARAMETER_VALUE_INCOMPATIBLE for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType PARAMETER_VALUE_INCOMPATIBLE = new AnalysisErrorType("PARAMETER_VALUE_INCOMPATIBLE");
        /// <summary>
        /// Constant SOURCE_NOT_FOUND for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType SOURCE_NOT_FOUND = new AnalysisErrorType("SOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisErrorType FindValue(string value)
        {
            return FindValue<AnalysisErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisFilterAttribute.
    /// </summary>
    public class AnalysisFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant ANALYSIS_NAME for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute ANALYSIS_NAME = new AnalysisFilterAttribute("ANALYSIS_NAME");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_OWNER for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute DIRECT_QUICKSIGHT_OWNER = new AnalysisFilterAttribute("DIRECT_QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_SOLE_OWNER for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute DIRECT_QUICKSIGHT_SOLE_OWNER = new AnalysisFilterAttribute("DIRECT_QUICKSIGHT_SOLE_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_VIEWER_OR_OWNER for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute DIRECT_QUICKSIGHT_VIEWER_OR_OWNER = new AnalysisFilterAttribute("DIRECT_QUICKSIGHT_VIEWER_OR_OWNER");
        /// <summary>
        /// Constant QUICKSIGHT_OWNER for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute QUICKSIGHT_OWNER = new AnalysisFilterAttribute("QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant QUICKSIGHT_USER for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute QUICKSIGHT_USER = new AnalysisFilterAttribute("QUICKSIGHT_USER");
        /// <summary>
        /// Constant QUICKSIGHT_VIEWER_OR_OWNER for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute QUICKSIGHT_VIEWER_OR_OWNER = new AnalysisFilterAttribute("QUICKSIGHT_VIEWER_OR_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisFilterAttribute FindValue(string value)
        {
            return FindValue<AnalysisFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnchorOption.
    /// </summary>
    public class AnchorOption : ConstantClass
    {

        /// <summary>
        /// Constant NOW for AnchorOption
        /// </summary>
        public static readonly AnchorOption NOW = new AnchorOption("NOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnchorOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnchorOption FindValue(string value)
        {
            return FindValue<AnchorOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnchorOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArcThickness.
    /// </summary>
    public class ArcThickness : ConstantClass
    {

        /// <summary>
        /// Constant LARGE for ArcThickness
        /// </summary>
        public static readonly ArcThickness LARGE = new ArcThickness("LARGE");
        /// <summary>
        /// Constant MEDIUM for ArcThickness
        /// </summary>
        public static readonly ArcThickness MEDIUM = new ArcThickness("MEDIUM");
        /// <summary>
        /// Constant SMALL for ArcThickness
        /// </summary>
        public static readonly ArcThickness SMALL = new ArcThickness("SMALL");
        /// <summary>
        /// Constant WHOLE for ArcThickness
        /// </summary>
        public static readonly ArcThickness WHOLE = new ArcThickness("WHOLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArcThickness(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArcThickness FindValue(string value)
        {
            return FindValue<ArcThickness>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArcThickness(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArcThicknessOptions.
    /// </summary>
    public class ArcThicknessOptions : ConstantClass
    {

        /// <summary>
        /// Constant LARGE for ArcThicknessOptions
        /// </summary>
        public static readonly ArcThicknessOptions LARGE = new ArcThicknessOptions("LARGE");
        /// <summary>
        /// Constant MEDIUM for ArcThicknessOptions
        /// </summary>
        public static readonly ArcThicknessOptions MEDIUM = new ArcThicknessOptions("MEDIUM");
        /// <summary>
        /// Constant SMALL for ArcThicknessOptions
        /// </summary>
        public static readonly ArcThicknessOptions SMALL = new ArcThicknessOptions("SMALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArcThicknessOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArcThicknessOptions FindValue(string value)
        {
            return FindValue<ArcThicknessOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArcThicknessOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssignmentStatus.
    /// </summary>
    public class AssignmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus DISABLED = new AssignmentStatus("DISABLED");
        /// <summary>
        /// Constant DRAFT for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus DRAFT = new AssignmentStatus("DRAFT");
        /// <summary>
        /// Constant ENABLED for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus ENABLED = new AssignmentStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssignmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignmentStatus FindValue(string value)
        {
            return FindValue<AssignmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssignmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticationMethodOption.
    /// </summary>
    public class AuthenticationMethodOption : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_DIRECTORY for AuthenticationMethodOption
        /// </summary>
        public static readonly AuthenticationMethodOption ACTIVE_DIRECTORY = new AuthenticationMethodOption("ACTIVE_DIRECTORY");
        /// <summary>
        /// Constant IAM_AND_QUICKSIGHT for AuthenticationMethodOption
        /// </summary>
        public static readonly AuthenticationMethodOption IAM_AND_QUICKSIGHT = new AuthenticationMethodOption("IAM_AND_QUICKSIGHT");
        /// <summary>
        /// Constant IAM_ONLY for AuthenticationMethodOption
        /// </summary>
        public static readonly AuthenticationMethodOption IAM_ONLY = new AuthenticationMethodOption("IAM_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationMethodOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationMethodOption FindValue(string value)
        {
            return FindValue<AuthenticationMethodOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationMethodOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AxisBinding.
    /// </summary>
    public class AxisBinding : ConstantClass
    {

        /// <summary>
        /// Constant PRIMARY_YAXIS for AxisBinding
        /// </summary>
        public static readonly AxisBinding PRIMARY_YAXIS = new AxisBinding("PRIMARY_YAXIS");
        /// <summary>
        /// Constant SECONDARY_YAXIS for AxisBinding
        /// </summary>
        public static readonly AxisBinding SECONDARY_YAXIS = new AxisBinding("SECONDARY_YAXIS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AxisBinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AxisBinding FindValue(string value)
        {
            return FindValue<AxisBinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AxisBinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BarChartOrientation.
    /// </summary>
    public class BarChartOrientation : ConstantClass
    {

        /// <summary>
        /// Constant HORIZONTAL for BarChartOrientation
        /// </summary>
        public static readonly BarChartOrientation HORIZONTAL = new BarChartOrientation("HORIZONTAL");
        /// <summary>
        /// Constant VERTICAL for BarChartOrientation
        /// </summary>
        public static readonly BarChartOrientation VERTICAL = new BarChartOrientation("VERTICAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BarChartOrientation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BarChartOrientation FindValue(string value)
        {
            return FindValue<BarChartOrientation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BarChartOrientation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BarsArrangement.
    /// </summary>
    public class BarsArrangement : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTERED for BarsArrangement
        /// </summary>
        public static readonly BarsArrangement CLUSTERED = new BarsArrangement("CLUSTERED");
        /// <summary>
        /// Constant STACKED for BarsArrangement
        /// </summary>
        public static readonly BarsArrangement STACKED = new BarsArrangement("STACKED");
        /// <summary>
        /// Constant STACKED_PERCENT for BarsArrangement
        /// </summary>
        public static readonly BarsArrangement STACKED_PERCENT = new BarsArrangement("STACKED_PERCENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BarsArrangement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BarsArrangement FindValue(string value)
        {
            return FindValue<BarsArrangement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BarsArrangement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BaseMapStyleType.
    /// </summary>
    public class BaseMapStyleType : ConstantClass
    {

        /// <summary>
        /// Constant DARK_GRAY for BaseMapStyleType
        /// </summary>
        public static readonly BaseMapStyleType DARK_GRAY = new BaseMapStyleType("DARK_GRAY");
        /// <summary>
        /// Constant IMAGERY for BaseMapStyleType
        /// </summary>
        public static readonly BaseMapStyleType IMAGERY = new BaseMapStyleType("IMAGERY");
        /// <summary>
        /// Constant LIGHT_GRAY for BaseMapStyleType
        /// </summary>
        public static readonly BaseMapStyleType LIGHT_GRAY = new BaseMapStyleType("LIGHT_GRAY");
        /// <summary>
        /// Constant STREET for BaseMapStyleType
        /// </summary>
        public static readonly BaseMapStyleType STREET = new BaseMapStyleType("STREET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BaseMapStyleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BaseMapStyleType FindValue(string value)
        {
            return FindValue<BaseMapStyleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BaseMapStyleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BoxPlotFillStyle.
    /// </summary>
    public class BoxPlotFillStyle : ConstantClass
    {

        /// <summary>
        /// Constant SOLID for BoxPlotFillStyle
        /// </summary>
        public static readonly BoxPlotFillStyle SOLID = new BoxPlotFillStyle("SOLID");
        /// <summary>
        /// Constant TRANSPARENT for BoxPlotFillStyle
        /// </summary>
        public static readonly BoxPlotFillStyle TRANSPARENT = new BoxPlotFillStyle("TRANSPARENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BoxPlotFillStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BoxPlotFillStyle FindValue(string value)
        {
            return FindValue<BoxPlotFillStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BoxPlotFillStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CategoricalAggregationFunction.
    /// </summary>
    public class CategoricalAggregationFunction : ConstantClass
    {

        /// <summary>
        /// Constant COUNT for CategoricalAggregationFunction
        /// </summary>
        public static readonly CategoricalAggregationFunction COUNT = new CategoricalAggregationFunction("COUNT");
        /// <summary>
        /// Constant DISTINCT_COUNT for CategoricalAggregationFunction
        /// </summary>
        public static readonly CategoricalAggregationFunction DISTINCT_COUNT = new CategoricalAggregationFunction("DISTINCT_COUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CategoricalAggregationFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CategoricalAggregationFunction FindValue(string value)
        {
            return FindValue<CategoricalAggregationFunction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CategoricalAggregationFunction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CategoryFilterMatchOperator.
    /// </summary>
    public class CategoryFilterMatchOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for CategoryFilterMatchOperator
        /// </summary>
        public static readonly CategoryFilterMatchOperator CONTAINS = new CategoryFilterMatchOperator("CONTAINS");
        /// <summary>
        /// Constant DOES_NOT_CONTAIN for CategoryFilterMatchOperator
        /// </summary>
        public static readonly CategoryFilterMatchOperator DOES_NOT_CONTAIN = new CategoryFilterMatchOperator("DOES_NOT_CONTAIN");
        /// <summary>
        /// Constant DOES_NOT_EQUAL for CategoryFilterMatchOperator
        /// </summary>
        public static readonly CategoryFilterMatchOperator DOES_NOT_EQUAL = new CategoryFilterMatchOperator("DOES_NOT_EQUAL");
        /// <summary>
        /// Constant ENDS_WITH for CategoryFilterMatchOperator
        /// </summary>
        public static readonly CategoryFilterMatchOperator ENDS_WITH = new CategoryFilterMatchOperator("ENDS_WITH");
        /// <summary>
        /// Constant EQUALS for CategoryFilterMatchOperator
        /// </summary>
        public static readonly CategoryFilterMatchOperator EQUALS = new CategoryFilterMatchOperator("EQUALS");
        /// <summary>
        /// Constant STARTS_WITH for CategoryFilterMatchOperator
        /// </summary>
        public static readonly CategoryFilterMatchOperator STARTS_WITH = new CategoryFilterMatchOperator("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CategoryFilterMatchOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CategoryFilterMatchOperator FindValue(string value)
        {
            return FindValue<CategoryFilterMatchOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CategoryFilterMatchOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CategoryFilterSelectAllOptions.
    /// </summary>
    public class CategoryFilterSelectAllOptions : ConstantClass
    {

        /// <summary>
        /// Constant FILTER_ALL_VALUES for CategoryFilterSelectAllOptions
        /// </summary>
        public static readonly CategoryFilterSelectAllOptions FILTER_ALL_VALUES = new CategoryFilterSelectAllOptions("FILTER_ALL_VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CategoryFilterSelectAllOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CategoryFilterSelectAllOptions FindValue(string value)
        {
            return FindValue<CategoryFilterSelectAllOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CategoryFilterSelectAllOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColorFillType.
    /// </summary>
    public class ColorFillType : ConstantClass
    {

        /// <summary>
        /// Constant DISCRETE for ColorFillType
        /// </summary>
        public static readonly ColorFillType DISCRETE = new ColorFillType("DISCRETE");
        /// <summary>
        /// Constant GRADIENT for ColorFillType
        /// </summary>
        public static readonly ColorFillType GRADIENT = new ColorFillType("GRADIENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColorFillType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorFillType FindValue(string value)
        {
            return FindValue<ColorFillType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorFillType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColumnDataType.
    /// </summary>
    public class ColumnDataType : ConstantClass
    {

        /// <summary>
        /// Constant DATETIME for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType DATETIME = new ColumnDataType("DATETIME");
        /// <summary>
        /// Constant DECIMAL for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType DECIMAL = new ColumnDataType("DECIMAL");
        /// <summary>
        /// Constant INTEGER for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType INTEGER = new ColumnDataType("INTEGER");
        /// <summary>
        /// Constant STRING for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType STRING = new ColumnDataType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnDataType FindValue(string value)
        {
            return FindValue<ColumnDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColumnRole.
    /// </summary>
    public class ColumnRole : ConstantClass
    {

        /// <summary>
        /// Constant DIMENSION for ColumnRole
        /// </summary>
        public static readonly ColumnRole DIMENSION = new ColumnRole("DIMENSION");
        /// <summary>
        /// Constant MEASURE for ColumnRole
        /// </summary>
        public static readonly ColumnRole MEASURE = new ColumnRole("MEASURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnRole FindValue(string value)
        {
            return FindValue<ColumnRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColumnTagName.
    /// </summary>
    public class ColumnTagName : ConstantClass
    {

        /// <summary>
        /// Constant COLUMN_DESCRIPTION for ColumnTagName
        /// </summary>
        public static readonly ColumnTagName COLUMN_DESCRIPTION = new ColumnTagName("COLUMN_DESCRIPTION");
        /// <summary>
        /// Constant COLUMN_GEOGRAPHIC_ROLE for ColumnTagName
        /// </summary>
        public static readonly ColumnTagName COLUMN_GEOGRAPHIC_ROLE = new ColumnTagName("COLUMN_GEOGRAPHIC_ROLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnTagName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnTagName FindValue(string value)
        {
            return FindValue<ColumnTagName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnTagName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonMethod.
    /// </summary>
    public class ComparisonMethod : ConstantClass
    {

        /// <summary>
        /// Constant DIFFERENCE for ComparisonMethod
        /// </summary>
        public static readonly ComparisonMethod DIFFERENCE = new ComparisonMethod("DIFFERENCE");
        /// <summary>
        /// Constant PERCENT for ComparisonMethod
        /// </summary>
        public static readonly ComparisonMethod PERCENT = new ComparisonMethod("PERCENT");
        /// <summary>
        /// Constant PERCENT_DIFFERENCE for ComparisonMethod
        /// </summary>
        public static readonly ComparisonMethod PERCENT_DIFFERENCE = new ComparisonMethod("PERCENT_DIFFERENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonMethod FindValue(string value)
        {
            return FindValue<ComparisonMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConditionalFormattingIconDisplayOption.
    /// </summary>
    public class ConditionalFormattingIconDisplayOption : ConstantClass
    {

        /// <summary>
        /// Constant ICON_ONLY for ConditionalFormattingIconDisplayOption
        /// </summary>
        public static readonly ConditionalFormattingIconDisplayOption ICON_ONLY = new ConditionalFormattingIconDisplayOption("ICON_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConditionalFormattingIconDisplayOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConditionalFormattingIconDisplayOption FindValue(string value)
        {
            return FindValue<ConditionalFormattingIconDisplayOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConditionalFormattingIconDisplayOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConditionalFormattingIconSetType.
    /// </summary>
    public class ConditionalFormattingIconSetType : ConstantClass
    {

        /// <summary>
        /// Constant BARS for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType BARS = new ConditionalFormattingIconSetType("BARS");
        /// <summary>
        /// Constant CARET_UP_MINUS_DOWN for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType CARET_UP_MINUS_DOWN = new ConditionalFormattingIconSetType("CARET_UP_MINUS_DOWN");
        /// <summary>
        /// Constant CHECK_X for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType CHECK_X = new ConditionalFormattingIconSetType("CHECK_X");
        /// <summary>
        /// Constant FLAGS for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType FLAGS = new ConditionalFormattingIconSetType("FLAGS");
        /// <summary>
        /// Constant FOUR_COLOR_ARROW for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType FOUR_COLOR_ARROW = new ConditionalFormattingIconSetType("FOUR_COLOR_ARROW");
        /// <summary>
        /// Constant FOUR_GRAY_ARROW for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType FOUR_GRAY_ARROW = new ConditionalFormattingIconSetType("FOUR_GRAY_ARROW");
        /// <summary>
        /// Constant PLUS_MINUS for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType PLUS_MINUS = new ConditionalFormattingIconSetType("PLUS_MINUS");
        /// <summary>
        /// Constant THREE_CIRCLE for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType THREE_CIRCLE = new ConditionalFormattingIconSetType("THREE_CIRCLE");
        /// <summary>
        /// Constant THREE_COLOR_ARROW for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType THREE_COLOR_ARROW = new ConditionalFormattingIconSetType("THREE_COLOR_ARROW");
        /// <summary>
        /// Constant THREE_GRAY_ARROW for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType THREE_GRAY_ARROW = new ConditionalFormattingIconSetType("THREE_GRAY_ARROW");
        /// <summary>
        /// Constant THREE_SHAPE for ConditionalFormattingIconSetType
        /// </summary>
        public static readonly ConditionalFormattingIconSetType THREE_SHAPE = new ConditionalFormattingIconSetType("THREE_SHAPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConditionalFormattingIconSetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConditionalFormattingIconSetType FindValue(string value)
        {
            return FindValue<ConditionalFormattingIconSetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConditionalFormattingIconSetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CrossDatasetTypes.
    /// </summary>
    public class CrossDatasetTypes : ConstantClass
    {

        /// <summary>
        /// Constant ALL_DATASETS for CrossDatasetTypes
        /// </summary>
        public static readonly CrossDatasetTypes ALL_DATASETS = new CrossDatasetTypes("ALL_DATASETS");
        /// <summary>
        /// Constant SINGLE_DATASET for CrossDatasetTypes
        /// </summary>
        public static readonly CrossDatasetTypes SINGLE_DATASET = new CrossDatasetTypes("SINGLE_DATASET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrossDatasetTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrossDatasetTypes FindValue(string value)
        {
            return FindValue<CrossDatasetTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrossDatasetTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomContentImageScalingConfiguration.
    /// </summary>
    public class CustomContentImageScalingConfiguration : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOT_SCALE for CustomContentImageScalingConfiguration
        /// </summary>
        public static readonly CustomContentImageScalingConfiguration DO_NOT_SCALE = new CustomContentImageScalingConfiguration("DO_NOT_SCALE");
        /// <summary>
        /// Constant FIT_TO_HEIGHT for CustomContentImageScalingConfiguration
        /// </summary>
        public static readonly CustomContentImageScalingConfiguration FIT_TO_HEIGHT = new CustomContentImageScalingConfiguration("FIT_TO_HEIGHT");
        /// <summary>
        /// Constant FIT_TO_WIDTH for CustomContentImageScalingConfiguration
        /// </summary>
        public static readonly CustomContentImageScalingConfiguration FIT_TO_WIDTH = new CustomContentImageScalingConfiguration("FIT_TO_WIDTH");
        /// <summary>
        /// Constant SCALE_TO_VISUAL for CustomContentImageScalingConfiguration
        /// </summary>
        public static readonly CustomContentImageScalingConfiguration SCALE_TO_VISUAL = new CustomContentImageScalingConfiguration("SCALE_TO_VISUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomContentImageScalingConfiguration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomContentImageScalingConfiguration FindValue(string value)
        {
            return FindValue<CustomContentImageScalingConfiguration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomContentImageScalingConfiguration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomContentType.
    /// </summary>
    public class CustomContentType : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE for CustomContentType
        /// </summary>
        public static readonly CustomContentType IMAGE = new CustomContentType("IMAGE");
        /// <summary>
        /// Constant OTHER_EMBEDDED_CONTENT for CustomContentType
        /// </summary>
        public static readonly CustomContentType OTHER_EMBEDDED_CONTENT = new CustomContentType("OTHER_EMBEDDED_CONTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomContentType FindValue(string value)
        {
            return FindValue<CustomContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardBehavior.
    /// </summary>
    public class DashboardBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DashboardBehavior
        /// </summary>
        public static readonly DashboardBehavior DISABLED = new DashboardBehavior("DISABLED");
        /// <summary>
        /// Constant ENABLED for DashboardBehavior
        /// </summary>
        public static readonly DashboardBehavior ENABLED = new DashboardBehavior("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardBehavior FindValue(string value)
        {
            return FindValue<DashboardBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardErrorType.
    /// </summary>
    public class DashboardErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType ACCESS_DENIED = new DashboardErrorType("ACCESS_DENIED");
        /// <summary>
        /// Constant COLUMN_GEOGRAPHIC_ROLE_MISMATCH for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType COLUMN_GEOGRAPHIC_ROLE_MISMATCH = new DashboardErrorType("COLUMN_GEOGRAPHIC_ROLE_MISMATCH");
        /// <summary>
        /// Constant COLUMN_REPLACEMENT_MISSING for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType COLUMN_REPLACEMENT_MISSING = new DashboardErrorType("COLUMN_REPLACEMENT_MISSING");
        /// <summary>
        /// Constant COLUMN_TYPE_MISMATCH for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType COLUMN_TYPE_MISMATCH = new DashboardErrorType("COLUMN_TYPE_MISMATCH");
        /// <summary>
        /// Constant DATA_SET_NOT_FOUND for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType DATA_SET_NOT_FOUND = new DashboardErrorType("DATA_SET_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType INTERNAL_FAILURE = new DashboardErrorType("INTERNAL_FAILURE");
        /// <summary>
        /// Constant PARAMETER_NOT_FOUND for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType PARAMETER_NOT_FOUND = new DashboardErrorType("PARAMETER_NOT_FOUND");
        /// <summary>
        /// Constant PARAMETER_TYPE_INVALID for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType PARAMETER_TYPE_INVALID = new DashboardErrorType("PARAMETER_TYPE_INVALID");
        /// <summary>
        /// Constant PARAMETER_VALUE_INCOMPATIBLE for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType PARAMETER_VALUE_INCOMPATIBLE = new DashboardErrorType("PARAMETER_VALUE_INCOMPATIBLE");
        /// <summary>
        /// Constant SOURCE_NOT_FOUND for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType SOURCE_NOT_FOUND = new DashboardErrorType("SOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardErrorType FindValue(string value)
        {
            return FindValue<DashboardErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardFilterAttribute.
    /// </summary>
    public class DashboardFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant DASHBOARD_NAME for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute DASHBOARD_NAME = new DashboardFilterAttribute("DASHBOARD_NAME");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_OWNER for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute DIRECT_QUICKSIGHT_OWNER = new DashboardFilterAttribute("DIRECT_QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_SOLE_OWNER for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute DIRECT_QUICKSIGHT_SOLE_OWNER = new DashboardFilterAttribute("DIRECT_QUICKSIGHT_SOLE_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_VIEWER_OR_OWNER for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute DIRECT_QUICKSIGHT_VIEWER_OR_OWNER = new DashboardFilterAttribute("DIRECT_QUICKSIGHT_VIEWER_OR_OWNER");
        /// <summary>
        /// Constant QUICKSIGHT_OWNER for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute QUICKSIGHT_OWNER = new DashboardFilterAttribute("QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant QUICKSIGHT_USER for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute QUICKSIGHT_USER = new DashboardFilterAttribute("QUICKSIGHT_USER");
        /// <summary>
        /// Constant QUICKSIGHT_VIEWER_OR_OWNER for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute QUICKSIGHT_VIEWER_OR_OWNER = new DashboardFilterAttribute("QUICKSIGHT_VIEWER_OR_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardFilterAttribute FindValue(string value)
        {
            return FindValue<DashboardFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardUIState.
    /// </summary>
    public class DashboardUIState : ConstantClass
    {

        /// <summary>
        /// Constant COLLAPSED for DashboardUIState
        /// </summary>
        public static readonly DashboardUIState COLLAPSED = new DashboardUIState("COLLAPSED");
        /// <summary>
        /// Constant EXPANDED for DashboardUIState
        /// </summary>
        public static readonly DashboardUIState EXPANDED = new DashboardUIState("EXPANDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardUIState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardUIState FindValue(string value)
        {
            return FindValue<DashboardUIState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardUIState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataLabelContent.
    /// </summary>
    public class DataLabelContent : ConstantClass
    {

        /// <summary>
        /// Constant PERCENT for DataLabelContent
        /// </summary>
        public static readonly DataLabelContent PERCENT = new DataLabelContent("PERCENT");
        /// <summary>
        /// Constant VALUE for DataLabelContent
        /// </summary>
        public static readonly DataLabelContent VALUE = new DataLabelContent("VALUE");
        /// <summary>
        /// Constant VALUE_AND_PERCENT for DataLabelContent
        /// </summary>
        public static readonly DataLabelContent VALUE_AND_PERCENT = new DataLabelContent("VALUE_AND_PERCENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataLabelContent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLabelContent FindValue(string value)
        {
            return FindValue<DataLabelContent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLabelContent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataLabelOverlap.
    /// </summary>
    public class DataLabelOverlap : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_OVERLAP for DataLabelOverlap
        /// </summary>
        public static readonly DataLabelOverlap DISABLE_OVERLAP = new DataLabelOverlap("DISABLE_OVERLAP");
        /// <summary>
        /// Constant ENABLE_OVERLAP for DataLabelOverlap
        /// </summary>
        public static readonly DataLabelOverlap ENABLE_OVERLAP = new DataLabelOverlap("ENABLE_OVERLAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataLabelOverlap(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLabelOverlap FindValue(string value)
        {
            return FindValue<DataLabelOverlap>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLabelOverlap(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataLabelPosition.
    /// </summary>
    public class DataLabelPosition : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM for DataLabelPosition
        /// </summary>
        public static readonly DataLabelPosition BOTTOM = new DataLabelPosition("BOTTOM");
        /// <summary>
        /// Constant INSIDE for DataLabelPosition
        /// </summary>
        public static readonly DataLabelPosition INSIDE = new DataLabelPosition("INSIDE");
        /// <summary>
        /// Constant LEFT for DataLabelPosition
        /// </summary>
        public static readonly DataLabelPosition LEFT = new DataLabelPosition("LEFT");
        /// <summary>
        /// Constant OUTSIDE for DataLabelPosition
        /// </summary>
        public static readonly DataLabelPosition OUTSIDE = new DataLabelPosition("OUTSIDE");
        /// <summary>
        /// Constant RIGHT for DataLabelPosition
        /// </summary>
        public static readonly DataLabelPosition RIGHT = new DataLabelPosition("RIGHT");
        /// <summary>
        /// Constant TOP for DataLabelPosition
        /// </summary>
        public static readonly DataLabelPosition TOP = new DataLabelPosition("TOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataLabelPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLabelPosition FindValue(string value)
        {
            return FindValue<DataLabelPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLabelPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSetFilterAttribute.
    /// </summary>
    public class DataSetFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant DATASET_NAME for DataSetFilterAttribute
        /// </summary>
        public static readonly DataSetFilterAttribute DATASET_NAME = new DataSetFilterAttribute("DATASET_NAME");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_OWNER for DataSetFilterAttribute
        /// </summary>
        public static readonly DataSetFilterAttribute DIRECT_QUICKSIGHT_OWNER = new DataSetFilterAttribute("DIRECT_QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_SOLE_OWNER for DataSetFilterAttribute
        /// </summary>
        public static readonly DataSetFilterAttribute DIRECT_QUICKSIGHT_SOLE_OWNER = new DataSetFilterAttribute("DIRECT_QUICKSIGHT_SOLE_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_VIEWER_OR_OWNER for DataSetFilterAttribute
        /// </summary>
        public static readonly DataSetFilterAttribute DIRECT_QUICKSIGHT_VIEWER_OR_OWNER = new DataSetFilterAttribute("DIRECT_QUICKSIGHT_VIEWER_OR_OWNER");
        /// <summary>
        /// Constant QUICKSIGHT_OWNER for DataSetFilterAttribute
        /// </summary>
        public static readonly DataSetFilterAttribute QUICKSIGHT_OWNER = new DataSetFilterAttribute("QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant QUICKSIGHT_VIEWER_OR_OWNER for DataSetFilterAttribute
        /// </summary>
        public static readonly DataSetFilterAttribute QUICKSIGHT_VIEWER_OR_OWNER = new DataSetFilterAttribute("QUICKSIGHT_VIEWER_OR_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSetFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSetFilterAttribute FindValue(string value)
        {
            return FindValue<DataSetFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSetFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSetImportMode.
    /// </summary>
    public class DataSetImportMode : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_QUERY for DataSetImportMode
        /// </summary>
        public static readonly DataSetImportMode DIRECT_QUERY = new DataSetImportMode("DIRECT_QUERY");
        /// <summary>
        /// Constant SPICE for DataSetImportMode
        /// </summary>
        public static readonly DataSetImportMode SPICE = new DataSetImportMode("SPICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSetImportMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSetImportMode FindValue(string value)
        {
            return FindValue<DataSetImportMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSetImportMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceErrorInfoType.
    /// </summary>
    public class DataSourceErrorInfoType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType ACCESS_DENIED = new DataSourceErrorInfoType("ACCESS_DENIED");
        /// <summary>
        /// Constant CONFLICT for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType CONFLICT = new DataSourceErrorInfoType("CONFLICT");
        /// <summary>
        /// Constant COPY_SOURCE_NOT_FOUND for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType COPY_SOURCE_NOT_FOUND = new DataSourceErrorInfoType("COPY_SOURCE_NOT_FOUND");
        /// <summary>
        /// Constant ENGINE_VERSION_NOT_SUPPORTED for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType ENGINE_VERSION_NOT_SUPPORTED = new DataSourceErrorInfoType("ENGINE_VERSION_NOT_SUPPORTED");
        /// <summary>
        /// Constant GENERIC_SQL_FAILURE for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType GENERIC_SQL_FAILURE = new DataSourceErrorInfoType("GENERIC_SQL_FAILURE");
        /// <summary>
        /// Constant TIMEOUT for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType TIMEOUT = new DataSourceErrorInfoType("TIMEOUT");
        /// <summary>
        /// Constant UNKNOWN for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType UNKNOWN = new DataSourceErrorInfoType("UNKNOWN");
        /// <summary>
        /// Constant UNKNOWN_HOST for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType UNKNOWN_HOST = new DataSourceErrorInfoType("UNKNOWN_HOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceErrorInfoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceErrorInfoType FindValue(string value)
        {
            return FindValue<DataSourceErrorInfoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceErrorInfoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceFilterAttribute.
    /// </summary>
    public class DataSourceFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant DATASOURCE_NAME for DataSourceFilterAttribute
        /// </summary>
        public static readonly DataSourceFilterAttribute DATASOURCE_NAME = new DataSourceFilterAttribute("DATASOURCE_NAME");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_OWNER for DataSourceFilterAttribute
        /// </summary>
        public static readonly DataSourceFilterAttribute DIRECT_QUICKSIGHT_OWNER = new DataSourceFilterAttribute("DIRECT_QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_SOLE_OWNER for DataSourceFilterAttribute
        /// </summary>
        public static readonly DataSourceFilterAttribute DIRECT_QUICKSIGHT_SOLE_OWNER = new DataSourceFilterAttribute("DIRECT_QUICKSIGHT_SOLE_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_VIEWER_OR_OWNER for DataSourceFilterAttribute
        /// </summary>
        public static readonly DataSourceFilterAttribute DIRECT_QUICKSIGHT_VIEWER_OR_OWNER = new DataSourceFilterAttribute("DIRECT_QUICKSIGHT_VIEWER_OR_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceFilterAttribute FindValue(string value)
        {
            return FindValue<DataSourceFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ADOBE_ANALYTICS for DataSourceType
        /// </summary>
        public static readonly DataSourceType ADOBE_ANALYTICS = new DataSourceType("ADOBE_ANALYTICS");
        /// <summary>
        /// Constant AMAZON_ELASTICSEARCH for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_ELASTICSEARCH = new DataSourceType("AMAZON_ELASTICSEARCH");
        /// <summary>
        /// Constant AMAZON_OPENSEARCH for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_OPENSEARCH = new DataSourceType("AMAZON_OPENSEARCH");
        /// <summary>
        /// Constant ATHENA for DataSourceType
        /// </summary>
        public static readonly DataSourceType ATHENA = new DataSourceType("ATHENA");
        /// <summary>
        /// Constant AURORA for DataSourceType
        /// </summary>
        public static readonly DataSourceType AURORA = new DataSourceType("AURORA");
        /// <summary>
        /// Constant AURORA_POSTGRESQL for DataSourceType
        /// </summary>
        public static readonly DataSourceType AURORA_POSTGRESQL = new DataSourceType("AURORA_POSTGRESQL");
        /// <summary>
        /// Constant AWS_IOT_ANALYTICS for DataSourceType
        /// </summary>
        public static readonly DataSourceType AWS_IOT_ANALYTICS = new DataSourceType("AWS_IOT_ANALYTICS");
        /// <summary>
        /// Constant DATABRICKS for DataSourceType
        /// </summary>
        public static readonly DataSourceType DATABRICKS = new DataSourceType("DATABRICKS");
        /// <summary>
        /// Constant EXASOL for DataSourceType
        /// </summary>
        public static readonly DataSourceType EXASOL = new DataSourceType("EXASOL");
        /// <summary>
        /// Constant GITHUB for DataSourceType
        /// </summary>
        public static readonly DataSourceType GITHUB = new DataSourceType("GITHUB");
        /// <summary>
        /// Constant JIRA for DataSourceType
        /// </summary>
        public static readonly DataSourceType JIRA = new DataSourceType("JIRA");
        /// <summary>
        /// Constant MARIADB for DataSourceType
        /// </summary>
        public static readonly DataSourceType MARIADB = new DataSourceType("MARIADB");
        /// <summary>
        /// Constant MYSQL for DataSourceType
        /// </summary>
        public static readonly DataSourceType MYSQL = new DataSourceType("MYSQL");
        /// <summary>
        /// Constant ORACLE for DataSourceType
        /// </summary>
        public static readonly DataSourceType ORACLE = new DataSourceType("ORACLE");
        /// <summary>
        /// Constant POSTGRESQL for DataSourceType
        /// </summary>
        public static readonly DataSourceType POSTGRESQL = new DataSourceType("POSTGRESQL");
        /// <summary>
        /// Constant PRESTO for DataSourceType
        /// </summary>
        public static readonly DataSourceType PRESTO = new DataSourceType("PRESTO");
        /// <summary>
        /// Constant REDSHIFT for DataSourceType
        /// </summary>
        public static readonly DataSourceType REDSHIFT = new DataSourceType("REDSHIFT");
        /// <summary>
        /// Constant S3 for DataSourceType
        /// </summary>
        public static readonly DataSourceType S3 = new DataSourceType("S3");
        /// <summary>
        /// Constant SALESFORCE for DataSourceType
        /// </summary>
        public static readonly DataSourceType SALESFORCE = new DataSourceType("SALESFORCE");
        /// <summary>
        /// Constant SERVICENOW for DataSourceType
        /// </summary>
        public static readonly DataSourceType SERVICENOW = new DataSourceType("SERVICENOW");
        /// <summary>
        /// Constant SNOWFLAKE for DataSourceType
        /// </summary>
        public static readonly DataSourceType SNOWFLAKE = new DataSourceType("SNOWFLAKE");
        /// <summary>
        /// Constant SPARK for DataSourceType
        /// </summary>
        public static readonly DataSourceType SPARK = new DataSourceType("SPARK");
        /// <summary>
        /// Constant SQLSERVER for DataSourceType
        /// </summary>
        public static readonly DataSourceType SQLSERVER = new DataSourceType("SQLSERVER");
        /// <summary>
        /// Constant TERADATA for DataSourceType
        /// </summary>
        public static readonly DataSourceType TERADATA = new DataSourceType("TERADATA");
        /// <summary>
        /// Constant TIMESTREAM for DataSourceType
        /// </summary>
        public static readonly DataSourceType TIMESTREAM = new DataSourceType("TIMESTREAM");
        /// <summary>
        /// Constant TWITTER for DataSourceType
        /// </summary>
        public static readonly DataSourceType TWITTER = new DataSourceType("TWITTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DateAggregationFunction.
    /// </summary>
    public class DateAggregationFunction : ConstantClass
    {

        /// <summary>
        /// Constant COUNT for DateAggregationFunction
        /// </summary>
        public static readonly DateAggregationFunction COUNT = new DateAggregationFunction("COUNT");
        /// <summary>
        /// Constant DISTINCT_COUNT for DateAggregationFunction
        /// </summary>
        public static readonly DateAggregationFunction DISTINCT_COUNT = new DateAggregationFunction("DISTINCT_COUNT");
        /// <summary>
        /// Constant MAX for DateAggregationFunction
        /// </summary>
        public static readonly DateAggregationFunction MAX = new DateAggregationFunction("MAX");
        /// <summary>
        /// Constant MIN for DateAggregationFunction
        /// </summary>
        public static readonly DateAggregationFunction MIN = new DateAggregationFunction("MIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DateAggregationFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DateAggregationFunction FindValue(string value)
        {
            return FindValue<DateAggregationFunction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DateAggregationFunction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Edition.
    /// </summary>
    public class Edition : ConstantClass
    {

        /// <summary>
        /// Constant ENTERPRISE for Edition
        /// </summary>
        public static readonly Edition ENTERPRISE = new Edition("ENTERPRISE");
        /// <summary>
        /// Constant ENTERPRISE_AND_Q for Edition
        /// </summary>
        public static readonly Edition ENTERPRISE_AND_Q = new Edition("ENTERPRISE_AND_Q");
        /// <summary>
        /// Constant STANDARD for Edition
        /// </summary>
        public static readonly Edition STANDARD = new Edition("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Edition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Edition FindValue(string value)
        {
            return FindValue<Edition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Edition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmbeddingIdentityType.
    /// </summary>
    public class EmbeddingIdentityType : ConstantClass
    {

        /// <summary>
        /// Constant ANONYMOUS for EmbeddingIdentityType
        /// </summary>
        public static readonly EmbeddingIdentityType ANONYMOUS = new EmbeddingIdentityType("ANONYMOUS");
        /// <summary>
        /// Constant IAM for EmbeddingIdentityType
        /// </summary>
        public static readonly EmbeddingIdentityType IAM = new EmbeddingIdentityType("IAM");
        /// <summary>
        /// Constant QUICKSIGHT for EmbeddingIdentityType
        /// </summary>
        public static readonly EmbeddingIdentityType QUICKSIGHT = new EmbeddingIdentityType("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmbeddingIdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmbeddingIdentityType FindValue(string value)
        {
            return FindValue<EmbeddingIdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmbeddingIdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExceptionResourceType.
    /// </summary>
    public class ExceptionResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_SETTINGS for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType ACCOUNT_SETTINGS = new ExceptionResourceType("ACCOUNT_SETTINGS");
        /// <summary>
        /// Constant DATA_SET for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType DATA_SET = new ExceptionResourceType("DATA_SET");
        /// <summary>
        /// Constant DATA_SOURCE for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType DATA_SOURCE = new ExceptionResourceType("DATA_SOURCE");
        /// <summary>
        /// Constant GROUP for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType GROUP = new ExceptionResourceType("GROUP");
        /// <summary>
        /// Constant IAMPOLICY_ASSIGNMENT for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType IAMPOLICY_ASSIGNMENT = new ExceptionResourceType("IAMPOLICY_ASSIGNMENT");
        /// <summary>
        /// Constant INGESTION for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType INGESTION = new ExceptionResourceType("INGESTION");
        /// <summary>
        /// Constant NAMESPACE for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType NAMESPACE = new ExceptionResourceType("NAMESPACE");
        /// <summary>
        /// Constant USER for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType USER = new ExceptionResourceType("USER");
        /// <summary>
        /// Constant VPC_CONNECTION for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType VPC_CONNECTION = new ExceptionResourceType("VPC_CONNECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExceptionResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExceptionResourceType FindValue(string value)
        {
            return FindValue<ExceptionResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExceptionResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileFormat.
    /// </summary>
    public class FileFormat : ConstantClass
    {

        /// <summary>
        /// Constant CLF for FileFormat
        /// </summary>
        public static readonly FileFormat CLF = new FileFormat("CLF");
        /// <summary>
        /// Constant CSV for FileFormat
        /// </summary>
        public static readonly FileFormat CSV = new FileFormat("CSV");
        /// <summary>
        /// Constant ELF for FileFormat
        /// </summary>
        public static readonly FileFormat ELF = new FileFormat("ELF");
        /// <summary>
        /// Constant JSON for FileFormat
        /// </summary>
        public static readonly FileFormat JSON = new FileFormat("JSON");
        /// <summary>
        /// Constant TSV for FileFormat
        /// </summary>
        public static readonly FileFormat TSV = new FileFormat("TSV");
        /// <summary>
        /// Constant XLSX for FileFormat
        /// </summary>
        public static readonly FileFormat XLSX = new FileFormat("XLSX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileFormat FindValue(string value)
        {
            return FindValue<FileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterNullOption.
    /// </summary>
    public class FilterNullOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL_VALUES for FilterNullOption
        /// </summary>
        public static readonly FilterNullOption ALL_VALUES = new FilterNullOption("ALL_VALUES");
        /// <summary>
        /// Constant NON_NULLS_ONLY for FilterNullOption
        /// </summary>
        public static readonly FilterNullOption NON_NULLS_ONLY = new FilterNullOption("NON_NULLS_ONLY");
        /// <summary>
        /// Constant NULLS_ONLY for FilterNullOption
        /// </summary>
        public static readonly FilterNullOption NULLS_ONLY = new FilterNullOption("NULLS_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterNullOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterNullOption FindValue(string value)
        {
            return FindValue<FilterNullOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterNullOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterOperator.
    /// </summary>
    public class FilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant StringEquals for FilterOperator
        /// </summary>
        public static readonly FilterOperator StringEquals = new FilterOperator("StringEquals");
        /// <summary>
        /// Constant StringLike for FilterOperator
        /// </summary>
        public static readonly FilterOperator StringLike = new FilterOperator("StringLike");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterOperator FindValue(string value)
        {
            return FindValue<FilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterVisualScope.
    /// </summary>
    public class FilterVisualScope : ConstantClass
    {

        /// <summary>
        /// Constant ALL_VISUALS for FilterVisualScope
        /// </summary>
        public static readonly FilterVisualScope ALL_VISUALS = new FilterVisualScope("ALL_VISUALS");
        /// <summary>
        /// Constant SELECTED_VISUALS for FilterVisualScope
        /// </summary>
        public static readonly FilterVisualScope SELECTED_VISUALS = new FilterVisualScope("SELECTED_VISUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterVisualScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterVisualScope FindValue(string value)
        {
            return FindValue<FilterVisualScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterVisualScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FolderFilterAttribute.
    /// </summary>
    public class FolderFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_OWNER for FolderFilterAttribute
        /// </summary>
        public static readonly FolderFilterAttribute DIRECT_QUICKSIGHT_OWNER = new FolderFilterAttribute("DIRECT_QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_SOLE_OWNER for FolderFilterAttribute
        /// </summary>
        public static readonly FolderFilterAttribute DIRECT_QUICKSIGHT_SOLE_OWNER = new FolderFilterAttribute("DIRECT_QUICKSIGHT_SOLE_OWNER");
        /// <summary>
        /// Constant DIRECT_QUICKSIGHT_VIEWER_OR_OWNER for FolderFilterAttribute
        /// </summary>
        public static readonly FolderFilterAttribute DIRECT_QUICKSIGHT_VIEWER_OR_OWNER = new FolderFilterAttribute("DIRECT_QUICKSIGHT_VIEWER_OR_OWNER");
        /// <summary>
        /// Constant FOLDER_NAME for FolderFilterAttribute
        /// </summary>
        public static readonly FolderFilterAttribute FOLDER_NAME = new FolderFilterAttribute("FOLDER_NAME");
        /// <summary>
        /// Constant PARENT_FOLDER_ARN for FolderFilterAttribute
        /// </summary>
        public static readonly FolderFilterAttribute PARENT_FOLDER_ARN = new FolderFilterAttribute("PARENT_FOLDER_ARN");
        /// <summary>
        /// Constant QUICKSIGHT_OWNER for FolderFilterAttribute
        /// </summary>
        public static readonly FolderFilterAttribute QUICKSIGHT_OWNER = new FolderFilterAttribute("QUICKSIGHT_OWNER");
        /// <summary>
        /// Constant QUICKSIGHT_VIEWER_OR_OWNER for FolderFilterAttribute
        /// </summary>
        public static readonly FolderFilterAttribute QUICKSIGHT_VIEWER_OR_OWNER = new FolderFilterAttribute("QUICKSIGHT_VIEWER_OR_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FolderFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FolderFilterAttribute FindValue(string value)
        {
            return FindValue<FolderFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FolderFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FolderType.
    /// </summary>
    public class FolderType : ConstantClass
    {

        /// <summary>
        /// Constant SHARED for FolderType
        /// </summary>
        public static readonly FolderType SHARED = new FolderType("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FolderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FolderType FindValue(string value)
        {
            return FindValue<FolderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FolderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FontDecoration.
    /// </summary>
    public class FontDecoration : ConstantClass
    {

        /// <summary>
        /// Constant NONE for FontDecoration
        /// </summary>
        public static readonly FontDecoration NONE = new FontDecoration("NONE");
        /// <summary>
        /// Constant UNDERLINE for FontDecoration
        /// </summary>
        public static readonly FontDecoration UNDERLINE = new FontDecoration("UNDERLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FontDecoration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FontDecoration FindValue(string value)
        {
            return FindValue<FontDecoration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FontDecoration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FontStyle.
    /// </summary>
    public class FontStyle : ConstantClass
    {

        /// <summary>
        /// Constant ITALIC for FontStyle
        /// </summary>
        public static readonly FontStyle ITALIC = new FontStyle("ITALIC");
        /// <summary>
        /// Constant NORMAL for FontStyle
        /// </summary>
        public static readonly FontStyle NORMAL = new FontStyle("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FontStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FontStyle FindValue(string value)
        {
            return FindValue<FontStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FontStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FontWeightName.
    /// </summary>
    public class FontWeightName : ConstantClass
    {

        /// <summary>
        /// Constant BOLD for FontWeightName
        /// </summary>
        public static readonly FontWeightName BOLD = new FontWeightName("BOLD");
        /// <summary>
        /// Constant NORMAL for FontWeightName
        /// </summary>
        public static readonly FontWeightName NORMAL = new FontWeightName("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FontWeightName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FontWeightName FindValue(string value)
        {
            return FindValue<FontWeightName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FontWeightName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ForecastComputationSeasonality.
    /// </summary>
    public class ForecastComputationSeasonality : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for ForecastComputationSeasonality
        /// </summary>
        public static readonly ForecastComputationSeasonality AUTOMATIC = new ForecastComputationSeasonality("AUTOMATIC");
        /// <summary>
        /// Constant CUSTOM for ForecastComputationSeasonality
        /// </summary>
        public static readonly ForecastComputationSeasonality CUSTOM = new ForecastComputationSeasonality("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ForecastComputationSeasonality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ForecastComputationSeasonality FindValue(string value)
        {
            return FindValue<ForecastComputationSeasonality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ForecastComputationSeasonality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunnelChartMeasureDataLabelStyle.
    /// </summary>
    public class FunnelChartMeasureDataLabelStyle : ConstantClass
    {

        /// <summary>
        /// Constant PERCENTAGE_BY_FIRST_STAGE for FunnelChartMeasureDataLabelStyle
        /// </summary>
        public static readonly FunnelChartMeasureDataLabelStyle PERCENTAGE_BY_FIRST_STAGE = new FunnelChartMeasureDataLabelStyle("PERCENTAGE_BY_FIRST_STAGE");
        /// <summary>
        /// Constant PERCENTAGE_BY_PREVIOUS_STAGE for FunnelChartMeasureDataLabelStyle
        /// </summary>
        public static readonly FunnelChartMeasureDataLabelStyle PERCENTAGE_BY_PREVIOUS_STAGE = new FunnelChartMeasureDataLabelStyle("PERCENTAGE_BY_PREVIOUS_STAGE");
        /// <summary>
        /// Constant VALUE_AND_PERCENTAGE_BY_FIRST_STAGE for FunnelChartMeasureDataLabelStyle
        /// </summary>
        public static readonly FunnelChartMeasureDataLabelStyle VALUE_AND_PERCENTAGE_BY_FIRST_STAGE = new FunnelChartMeasureDataLabelStyle("VALUE_AND_PERCENTAGE_BY_FIRST_STAGE");
        /// <summary>
        /// Constant VALUE_AND_PERCENTAGE_BY_PREVIOUS_STAGE for FunnelChartMeasureDataLabelStyle
        /// </summary>
        public static readonly FunnelChartMeasureDataLabelStyle VALUE_AND_PERCENTAGE_BY_PREVIOUS_STAGE = new FunnelChartMeasureDataLabelStyle("VALUE_AND_PERCENTAGE_BY_PREVIOUS_STAGE");
        /// <summary>
        /// Constant VALUE_ONLY for FunnelChartMeasureDataLabelStyle
        /// </summary>
        public static readonly FunnelChartMeasureDataLabelStyle VALUE_ONLY = new FunnelChartMeasureDataLabelStyle("VALUE_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunnelChartMeasureDataLabelStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunnelChartMeasureDataLabelStyle FindValue(string value)
        {
            return FindValue<FunnelChartMeasureDataLabelStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunnelChartMeasureDataLabelStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeoSpatialCountryCode.
    /// </summary>
    public class GeoSpatialCountryCode : ConstantClass
    {

        /// <summary>
        /// Constant US for GeoSpatialCountryCode
        /// </summary>
        public static readonly GeoSpatialCountryCode US = new GeoSpatialCountryCode("US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoSpatialCountryCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoSpatialCountryCode FindValue(string value)
        {
            return FindValue<GeoSpatialCountryCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoSpatialCountryCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeoSpatialDataRole.
    /// </summary>
    public class GeoSpatialDataRole : ConstantClass
    {

        /// <summary>
        /// Constant CITY for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole CITY = new GeoSpatialDataRole("CITY");
        /// <summary>
        /// Constant COUNTRY for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole COUNTRY = new GeoSpatialDataRole("COUNTRY");
        /// <summary>
        /// Constant COUNTY for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole COUNTY = new GeoSpatialDataRole("COUNTY");
        /// <summary>
        /// Constant LATITUDE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole LATITUDE = new GeoSpatialDataRole("LATITUDE");
        /// <summary>
        /// Constant LONGITUDE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole LONGITUDE = new GeoSpatialDataRole("LONGITUDE");
        /// <summary>
        /// Constant POSTCODE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole POSTCODE = new GeoSpatialDataRole("POSTCODE");
        /// <summary>
        /// Constant STATE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole STATE = new GeoSpatialDataRole("STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoSpatialDataRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoSpatialDataRole FindValue(string value)
        {
            return FindValue<GeoSpatialDataRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoSpatialDataRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeospatialSelectedPointStyle.
    /// </summary>
    public class GeospatialSelectedPointStyle : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER for GeospatialSelectedPointStyle
        /// </summary>
        public static readonly GeospatialSelectedPointStyle CLUSTER = new GeospatialSelectedPointStyle("CLUSTER");
        /// <summary>
        /// Constant POINT for GeospatialSelectedPointStyle
        /// </summary>
        public static readonly GeospatialSelectedPointStyle POINT = new GeospatialSelectedPointStyle("POINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeospatialSelectedPointStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeospatialSelectedPointStyle FindValue(string value)
        {
            return FindValue<GeospatialSelectedPointStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeospatialSelectedPointStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupFilterAttribute.
    /// </summary>
    public class GroupFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant GROUP_NAME for GroupFilterAttribute
        /// </summary>
        public static readonly GroupFilterAttribute GROUP_NAME = new GroupFilterAttribute("GROUP_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupFilterAttribute FindValue(string value)
        {
            return FindValue<GroupFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupFilterOperator.
    /// </summary>
    public class GroupFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant StartsWith for GroupFilterOperator
        /// </summary>
        public static readonly GroupFilterOperator StartsWith = new GroupFilterOperator("StartsWith");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupFilterOperator FindValue(string value)
        {
            return FindValue<GroupFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HistogramBinType.
    /// </summary>
    public class HistogramBinType : ConstantClass
    {

        /// <summary>
        /// Constant BIN_COUNT for HistogramBinType
        /// </summary>
        public static readonly HistogramBinType BIN_COUNT = new HistogramBinType("BIN_COUNT");
        /// <summary>
        /// Constant BIN_WIDTH for HistogramBinType
        /// </summary>
        public static readonly HistogramBinType BIN_WIDTH = new HistogramBinType("BIN_WIDTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HistogramBinType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HistogramBinType FindValue(string value)
        {
            return FindValue<HistogramBinType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HistogramBinType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HorizontalTextAlignment.
    /// </summary>
    public class HorizontalTextAlignment : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for HorizontalTextAlignment
        /// </summary>
        public static readonly HorizontalTextAlignment AUTO = new HorizontalTextAlignment("AUTO");
        /// <summary>
        /// Constant CENTER for HorizontalTextAlignment
        /// </summary>
        public static readonly HorizontalTextAlignment CENTER = new HorizontalTextAlignment("CENTER");
        /// <summary>
        /// Constant LEFT for HorizontalTextAlignment
        /// </summary>
        public static readonly HorizontalTextAlignment LEFT = new HorizontalTextAlignment("LEFT");
        /// <summary>
        /// Constant RIGHT for HorizontalTextAlignment
        /// </summary>
        public static readonly HorizontalTextAlignment RIGHT = new HorizontalTextAlignment("RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HorizontalTextAlignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HorizontalTextAlignment FindValue(string value)
        {
            return FindValue<HorizontalTextAlignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HorizontalTextAlignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Icon.
    /// </summary>
    public class Icon : ConstantClass
    {

        /// <summary>
        /// Constant ARROW_DOWN for Icon
        /// </summary>
        public static readonly Icon ARROW_DOWN = new Icon("ARROW_DOWN");
        /// <summary>
        /// Constant ARROW_DOWN_LEFT for Icon
        /// </summary>
        public static readonly Icon ARROW_DOWN_LEFT = new Icon("ARROW_DOWN_LEFT");
        /// <summary>
        /// Constant ARROW_DOWN_RIGHT for Icon
        /// </summary>
        public static readonly Icon ARROW_DOWN_RIGHT = new Icon("ARROW_DOWN_RIGHT");
        /// <summary>
        /// Constant ARROW_LEFT for Icon
        /// </summary>
        public static readonly Icon ARROW_LEFT = new Icon("ARROW_LEFT");
        /// <summary>
        /// Constant ARROW_RIGHT for Icon
        /// </summary>
        public static readonly Icon ARROW_RIGHT = new Icon("ARROW_RIGHT");
        /// <summary>
        /// Constant ARROW_UP for Icon
        /// </summary>
        public static readonly Icon ARROW_UP = new Icon("ARROW_UP");
        /// <summary>
        /// Constant ARROW_UP_LEFT for Icon
        /// </summary>
        public static readonly Icon ARROW_UP_LEFT = new Icon("ARROW_UP_LEFT");
        /// <summary>
        /// Constant ARROW_UP_RIGHT for Icon
        /// </summary>
        public static readonly Icon ARROW_UP_RIGHT = new Icon("ARROW_UP_RIGHT");
        /// <summary>
        /// Constant CARET_DOWN for Icon
        /// </summary>
        public static readonly Icon CARET_DOWN = new Icon("CARET_DOWN");
        /// <summary>
        /// Constant CARET_UP for Icon
        /// </summary>
        public static readonly Icon CARET_UP = new Icon("CARET_UP");
        /// <summary>
        /// Constant CHECKMARK for Icon
        /// </summary>
        public static readonly Icon CHECKMARK = new Icon("CHECKMARK");
        /// <summary>
        /// Constant CIRCLE for Icon
        /// </summary>
        public static readonly Icon CIRCLE = new Icon("CIRCLE");
        /// <summary>
        /// Constant FACE_DOWN for Icon
        /// </summary>
        public static readonly Icon FACE_DOWN = new Icon("FACE_DOWN");
        /// <summary>
        /// Constant FACE_FLAT for Icon
        /// </summary>
        public static readonly Icon FACE_FLAT = new Icon("FACE_FLAT");
        /// <summary>
        /// Constant FACE_UP for Icon
        /// </summary>
        public static readonly Icon FACE_UP = new Icon("FACE_UP");
        /// <summary>
        /// Constant FLAG for Icon
        /// </summary>
        public static readonly Icon FLAG = new Icon("FLAG");
        /// <summary>
        /// Constant MINUS for Icon
        /// </summary>
        public static readonly Icon MINUS = new Icon("MINUS");
        /// <summary>
        /// Constant ONE_BAR for Icon
        /// </summary>
        public static readonly Icon ONE_BAR = new Icon("ONE_BAR");
        /// <summary>
        /// Constant PLUS for Icon
        /// </summary>
        public static readonly Icon PLUS = new Icon("PLUS");
        /// <summary>
        /// Constant SQUARE for Icon
        /// </summary>
        public static readonly Icon SQUARE = new Icon("SQUARE");
        /// <summary>
        /// Constant THREE_BAR for Icon
        /// </summary>
        public static readonly Icon THREE_BAR = new Icon("THREE_BAR");
        /// <summary>
        /// Constant THUMBS_DOWN for Icon
        /// </summary>
        public static readonly Icon THUMBS_DOWN = new Icon("THUMBS_DOWN");
        /// <summary>
        /// Constant THUMBS_UP for Icon
        /// </summary>
        public static readonly Icon THUMBS_UP = new Icon("THUMBS_UP");
        /// <summary>
        /// Constant TRIANGLE for Icon
        /// </summary>
        public static readonly Icon TRIANGLE = new Icon("TRIANGLE");
        /// <summary>
        /// Constant TWO_BAR for Icon
        /// </summary>
        public static readonly Icon TWO_BAR = new Icon("TWO_BAR");
        /// <summary>
        /// Constant X for Icon
        /// </summary>
        public static readonly Icon X = new Icon("X");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Icon(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Icon FindValue(string value)
        {
            return FindValue<Icon>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Icon(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityStore.
    /// </summary>
    public class IdentityStore : ConstantClass
    {

        /// <summary>
        /// Constant QUICKSIGHT for IdentityStore
        /// </summary>
        public static readonly IdentityStore QUICKSIGHT = new IdentityStore("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityStore(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityStore FindValue(string value)
        {
            return FindValue<IdentityStore>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityStore(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityType.
    /// </summary>
    public class IdentityType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for IdentityType
        /// </summary>
        public static readonly IdentityType IAM = new IdentityType("IAM");
        /// <summary>
        /// Constant QUICKSIGHT for IdentityType
        /// </summary>
        public static readonly IdentityType QUICKSIGHT = new IdentityType("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionErrorType.
    /// </summary>
    public class IngestionErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_CAPACITY_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType ACCOUNT_CAPACITY_LIMIT_EXCEEDED = new IngestionErrorType("ACCOUNT_CAPACITY_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant CONNECTION_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType CONNECTION_FAILURE = new IngestionErrorType("CONNECTION_FAILURE");
        /// <summary>
        /// Constant CURSOR_NOT_ENABLED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType CURSOR_NOT_ENABLED = new IngestionErrorType("CURSOR_NOT_ENABLED");
        /// <summary>
        /// Constant CUSTOMER_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType CUSTOMER_ERROR = new IngestionErrorType("CUSTOMER_ERROR");
        /// <summary>
        /// Constant DATA_SET_DELETED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SET_DELETED = new IngestionErrorType("DATA_SET_DELETED");
        /// <summary>
        /// Constant DATA_SET_NOT_SPICE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SET_NOT_SPICE = new IngestionErrorType("DATA_SET_NOT_SPICE");
        /// <summary>
        /// Constant DATA_SET_SIZE_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SET_SIZE_LIMIT_EXCEEDED = new IngestionErrorType("DATA_SET_SIZE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant DATA_SOURCE_AUTH_FAILED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SOURCE_AUTH_FAILED = new IngestionErrorType("DATA_SOURCE_AUTH_FAILED");
        /// <summary>
        /// Constant DATA_SOURCE_CONNECTION_FAILED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SOURCE_CONNECTION_FAILED = new IngestionErrorType("DATA_SOURCE_CONNECTION_FAILED");
        /// <summary>
        /// Constant DATA_SOURCE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SOURCE_NOT_FOUND = new IngestionErrorType("DATA_SOURCE_NOT_FOUND");
        /// <summary>
        /// Constant DATA_TOLERANCE_EXCEPTION for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_TOLERANCE_EXCEPTION = new IngestionErrorType("DATA_TOLERANCE_EXCEPTION");
        /// <summary>
        /// Constant ELASTICSEARCH_CURSOR_NOT_ENABLED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType ELASTICSEARCH_CURSOR_NOT_ENABLED = new IngestionErrorType("ELASTICSEARCH_CURSOR_NOT_ENABLED");
        /// <summary>
        /// Constant FAILURE_TO_ASSUME_ROLE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType FAILURE_TO_ASSUME_ROLE = new IngestionErrorType("FAILURE_TO_ASSUME_ROLE");
        /// <summary>
        /// Constant FAILURE_TO_PROCESS_JSON_FILE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType FAILURE_TO_PROCESS_JSON_FILE = new IngestionErrorType("FAILURE_TO_PROCESS_JSON_FILE");
        /// <summary>
        /// Constant IAM_ROLE_NOT_AVAILABLE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType IAM_ROLE_NOT_AVAILABLE = new IngestionErrorType("IAM_ROLE_NOT_AVAILABLE");
        /// <summary>
        /// Constant INGESTION_CANCELED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INGESTION_CANCELED = new IngestionErrorType("INGESTION_CANCELED");
        /// <summary>
        /// Constant INGESTION_SUPERSEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INGESTION_SUPERSEDED = new IngestionErrorType("INGESTION_SUPERSEDED");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INTERNAL_SERVICE_ERROR = new IngestionErrorType("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant INVALID_DATA_SOURCE_CONFIG for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INVALID_DATA_SOURCE_CONFIG = new IngestionErrorType("INVALID_DATA_SOURCE_CONFIG");
        /// <summary>
        /// Constant INVALID_DATAPREP_SYNTAX for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INVALID_DATAPREP_SYNTAX = new IngestionErrorType("INVALID_DATAPREP_SYNTAX");
        /// <summary>
        /// Constant INVALID_DATE_FORMAT for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INVALID_DATE_FORMAT = new IngestionErrorType("INVALID_DATE_FORMAT");
        /// <summary>
        /// Constant IOT_DATA_SET_FILE_EMPTY for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType IOT_DATA_SET_FILE_EMPTY = new IngestionErrorType("IOT_DATA_SET_FILE_EMPTY");
        /// <summary>
        /// Constant IOT_FILE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType IOT_FILE_NOT_FOUND = new IngestionErrorType("IOT_FILE_NOT_FOUND");
        /// <summary>
        /// Constant OAUTH_TOKEN_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType OAUTH_TOKEN_FAILURE = new IngestionErrorType("OAUTH_TOKEN_FAILURE");
        /// <summary>
        /// Constant PASSWORD_AUTHENTICATION_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType PASSWORD_AUTHENTICATION_FAILURE = new IngestionErrorType("PASSWORD_AUTHENTICATION_FAILURE");
        /// <summary>
        /// Constant PERMISSION_DENIED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType PERMISSION_DENIED = new IngestionErrorType("PERMISSION_DENIED");
        /// <summary>
        /// Constant PERMISSION_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType PERMISSION_NOT_FOUND = new IngestionErrorType("PERMISSION_NOT_FOUND");
        /// <summary>
        /// Constant QUERY_TIMEOUT for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType QUERY_TIMEOUT = new IngestionErrorType("QUERY_TIMEOUT");
        /// <summary>
        /// Constant REFRESH_SUPPRESSED_BY_EDIT for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType REFRESH_SUPPRESSED_BY_EDIT = new IngestionErrorType("REFRESH_SUPPRESSED_BY_EDIT");
        /// <summary>
        /// Constant ROW_SIZE_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType ROW_SIZE_LIMIT_EXCEEDED = new IngestionErrorType("ROW_SIZE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant S3_FILE_INACCESSIBLE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType S3_FILE_INACCESSIBLE = new IngestionErrorType("S3_FILE_INACCESSIBLE");
        /// <summary>
        /// Constant S3_MANIFEST_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType S3_MANIFEST_ERROR = new IngestionErrorType("S3_MANIFEST_ERROR");
        /// <summary>
        /// Constant S3_UPLOADED_FILE_DELETED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType S3_UPLOADED_FILE_DELETED = new IngestionErrorType("S3_UPLOADED_FILE_DELETED");
        /// <summary>
        /// Constant SOURCE_API_LIMIT_EXCEEDED_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SOURCE_API_LIMIT_EXCEEDED_FAILURE = new IngestionErrorType("SOURCE_API_LIMIT_EXCEEDED_FAILURE");
        /// <summary>
        /// Constant SOURCE_RESOURCE_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SOURCE_RESOURCE_LIMIT_EXCEEDED = new IngestionErrorType("SOURCE_RESOURCE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant SPICE_TABLE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SPICE_TABLE_NOT_FOUND = new IngestionErrorType("SPICE_TABLE_NOT_FOUND");
        /// <summary>
        /// Constant SQL_EXCEPTION for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_EXCEPTION = new IngestionErrorType("SQL_EXCEPTION");
        /// <summary>
        /// Constant SQL_INVALID_PARAMETER_VALUE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_INVALID_PARAMETER_VALUE = new IngestionErrorType("SQL_INVALID_PARAMETER_VALUE");
        /// <summary>
        /// Constant SQL_NUMERIC_OVERFLOW for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_NUMERIC_OVERFLOW = new IngestionErrorType("SQL_NUMERIC_OVERFLOW");
        /// <summary>
        /// Constant SQL_SCHEMA_MISMATCH_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_SCHEMA_MISMATCH_ERROR = new IngestionErrorType("SQL_SCHEMA_MISMATCH_ERROR");
        /// <summary>
        /// Constant SQL_TABLE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_TABLE_NOT_FOUND = new IngestionErrorType("SQL_TABLE_NOT_FOUND");
        /// <summary>
        /// Constant SSL_CERTIFICATE_VALIDATION_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SSL_CERTIFICATE_VALIDATION_FAILURE = new IngestionErrorType("SSL_CERTIFICATE_VALIDATION_FAILURE");
        /// <summary>
        /// Constant UNRESOLVABLE_HOST for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType UNRESOLVABLE_HOST = new IngestionErrorType("UNRESOLVABLE_HOST");
        /// <summary>
        /// Constant UNROUTABLE_HOST for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType UNROUTABLE_HOST = new IngestionErrorType("UNROUTABLE_HOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionErrorType FindValue(string value)
        {
            return FindValue<IngestionErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionRequestSource.
    /// </summary>
    public class IngestionRequestSource : ConstantClass
    {

        /// <summary>
        /// Constant MANUAL for IngestionRequestSource
        /// </summary>
        public static readonly IngestionRequestSource MANUAL = new IngestionRequestSource("MANUAL");
        /// <summary>
        /// Constant SCHEDULED for IngestionRequestSource
        /// </summary>
        public static readonly IngestionRequestSource SCHEDULED = new IngestionRequestSource("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionRequestSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionRequestSource FindValue(string value)
        {
            return FindValue<IngestionRequestSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionRequestSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionRequestType.
    /// </summary>
    public class IngestionRequestType : ConstantClass
    {

        /// <summary>
        /// Constant EDIT for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType EDIT = new IngestionRequestType("EDIT");
        /// <summary>
        /// Constant FULL_REFRESH for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType FULL_REFRESH = new IngestionRequestType("FULL_REFRESH");
        /// <summary>
        /// Constant INCREMENTAL_REFRESH for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType INCREMENTAL_REFRESH = new IngestionRequestType("INCREMENTAL_REFRESH");
        /// <summary>
        /// Constant INITIAL_INGESTION for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType INITIAL_INGESTION = new IngestionRequestType("INITIAL_INGESTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionRequestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionRequestType FindValue(string value)
        {
            return FindValue<IngestionRequestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionRequestType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionStatus.
    /// </summary>
    public class IngestionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus CANCELLED = new IngestionStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus COMPLETED = new IngestionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus FAILED = new IngestionStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus INITIALIZED = new IngestionStatus("INITIALIZED");
        /// <summary>
        /// Constant QUEUED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus QUEUED = new IngestionStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus RUNNING = new IngestionStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionStatus FindValue(string value)
        {
            return FindValue<IngestionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionType.
    /// </summary>
    public class IngestionType : ConstantClass
    {

        /// <summary>
        /// Constant FULL_REFRESH for IngestionType
        /// </summary>
        public static readonly IngestionType FULL_REFRESH = new IngestionType("FULL_REFRESH");
        /// <summary>
        /// Constant INCREMENTAL_REFRESH for IngestionType
        /// </summary>
        public static readonly IngestionType INCREMENTAL_REFRESH = new IngestionType("INCREMENTAL_REFRESH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionType FindValue(string value)
        {
            return FindValue<IngestionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputColumnDataType.
    /// </summary>
    public class InputColumnDataType : ConstantClass
    {

        /// <summary>
        /// Constant BIT for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType BIT = new InputColumnDataType("BIT");
        /// <summary>
        /// Constant BOOLEAN for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType BOOLEAN = new InputColumnDataType("BOOLEAN");
        /// <summary>
        /// Constant DATETIME for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType DATETIME = new InputColumnDataType("DATETIME");
        /// <summary>
        /// Constant DECIMAL for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType DECIMAL = new InputColumnDataType("DECIMAL");
        /// <summary>
        /// Constant INTEGER for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType INTEGER = new InputColumnDataType("INTEGER");
        /// <summary>
        /// Constant JSON for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType JSON = new InputColumnDataType("JSON");
        /// <summary>
        /// Constant STRING for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType STRING = new InputColumnDataType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputColumnDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputColumnDataType FindValue(string value)
        {
            return FindValue<InputColumnDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputColumnDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JoinType.
    /// </summary>
    public class JoinType : ConstantClass
    {

        /// <summary>
        /// Constant INNER for JoinType
        /// </summary>
        public static readonly JoinType INNER = new JoinType("INNER");
        /// <summary>
        /// Constant LEFT for JoinType
        /// </summary>
        public static readonly JoinType LEFT = new JoinType("LEFT");
        /// <summary>
        /// Constant OUTER for JoinType
        /// </summary>
        public static readonly JoinType OUTER = new JoinType("OUTER");
        /// <summary>
        /// Constant RIGHT for JoinType
        /// </summary>
        public static readonly JoinType RIGHT = new JoinType("RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JoinType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JoinType FindValue(string value)
        {
            return FindValue<JoinType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JoinType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayoutElementType.
    /// </summary>
    public class LayoutElementType : ConstantClass
    {

        /// <summary>
        /// Constant FILTER_CONTROL for LayoutElementType
        /// </summary>
        public static readonly LayoutElementType FILTER_CONTROL = new LayoutElementType("FILTER_CONTROL");
        /// <summary>
        /// Constant PARAMETER_CONTROL for LayoutElementType
        /// </summary>
        public static readonly LayoutElementType PARAMETER_CONTROL = new LayoutElementType("PARAMETER_CONTROL");
        /// <summary>
        /// Constant TEXT_BOX for LayoutElementType
        /// </summary>
        public static readonly LayoutElementType TEXT_BOX = new LayoutElementType("TEXT_BOX");
        /// <summary>
        /// Constant VISUAL for LayoutElementType
        /// </summary>
        public static readonly LayoutElementType VISUAL = new LayoutElementType("VISUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayoutElementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayoutElementType FindValue(string value)
        {
            return FindValue<LayoutElementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayoutElementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LegendPosition.
    /// </summary>
    public class LegendPosition : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for LegendPosition
        /// </summary>
        public static readonly LegendPosition AUTO = new LegendPosition("AUTO");
        /// <summary>
        /// Constant BOTTOM for LegendPosition
        /// </summary>
        public static readonly LegendPosition BOTTOM = new LegendPosition("BOTTOM");
        /// <summary>
        /// Constant RIGHT for LegendPosition
        /// </summary>
        public static readonly LegendPosition RIGHT = new LegendPosition("RIGHT");
        /// <summary>
        /// Constant TOP for LegendPosition
        /// </summary>
        public static readonly LegendPosition TOP = new LegendPosition("TOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LegendPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LegendPosition FindValue(string value)
        {
            return FindValue<LegendPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LegendPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineChartLineStyle.
    /// </summary>
    public class LineChartLineStyle : ConstantClass
    {

        /// <summary>
        /// Constant DASHED for LineChartLineStyle
        /// </summary>
        public static readonly LineChartLineStyle DASHED = new LineChartLineStyle("DASHED");
        /// <summary>
        /// Constant DOTTED for LineChartLineStyle
        /// </summary>
        public static readonly LineChartLineStyle DOTTED = new LineChartLineStyle("DOTTED");
        /// <summary>
        /// Constant SOLID for LineChartLineStyle
        /// </summary>
        public static readonly LineChartLineStyle SOLID = new LineChartLineStyle("SOLID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineChartLineStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineChartLineStyle FindValue(string value)
        {
            return FindValue<LineChartLineStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineChartLineStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineChartMarkerShape.
    /// </summary>
    public class LineChartMarkerShape : ConstantClass
    {

        /// <summary>
        /// Constant CIRCLE for LineChartMarkerShape
        /// </summary>
        public static readonly LineChartMarkerShape CIRCLE = new LineChartMarkerShape("CIRCLE");
        /// <summary>
        /// Constant DIAMOND for LineChartMarkerShape
        /// </summary>
        public static readonly LineChartMarkerShape DIAMOND = new LineChartMarkerShape("DIAMOND");
        /// <summary>
        /// Constant ROUNDED_SQUARE for LineChartMarkerShape
        /// </summary>
        public static readonly LineChartMarkerShape ROUNDED_SQUARE = new LineChartMarkerShape("ROUNDED_SQUARE");
        /// <summary>
        /// Constant SQUARE for LineChartMarkerShape
        /// </summary>
        public static readonly LineChartMarkerShape SQUARE = new LineChartMarkerShape("SQUARE");
        /// <summary>
        /// Constant TRIANGLE for LineChartMarkerShape
        /// </summary>
        public static readonly LineChartMarkerShape TRIANGLE = new LineChartMarkerShape("TRIANGLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineChartMarkerShape(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineChartMarkerShape FindValue(string value)
        {
            return FindValue<LineChartMarkerShape>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineChartMarkerShape(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineChartType.
    /// </summary>
    public class LineChartType : ConstantClass
    {

        /// <summary>
        /// Constant AREA for LineChartType
        /// </summary>
        public static readonly LineChartType AREA = new LineChartType("AREA");
        /// <summary>
        /// Constant LINE for LineChartType
        /// </summary>
        public static readonly LineChartType LINE = new LineChartType("LINE");
        /// <summary>
        /// Constant STACKED_AREA for LineChartType
        /// </summary>
        public static readonly LineChartType STACKED_AREA = new LineChartType("STACKED_AREA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineChartType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineChartType FindValue(string value)
        {
            return FindValue<LineChartType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineChartType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineInterpolation.
    /// </summary>
    public class LineInterpolation : ConstantClass
    {

        /// <summary>
        /// Constant LINEAR for LineInterpolation
        /// </summary>
        public static readonly LineInterpolation LINEAR = new LineInterpolation("LINEAR");
        /// <summary>
        /// Constant SMOOTH for LineInterpolation
        /// </summary>
        public static readonly LineInterpolation SMOOTH = new LineInterpolation("SMOOTH");
        /// <summary>
        /// Constant STEPPED for LineInterpolation
        /// </summary>
        public static readonly LineInterpolation STEPPED = new LineInterpolation("STEPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineInterpolation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineInterpolation FindValue(string value)
        {
            return FindValue<LineInterpolation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineInterpolation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MapZoomMode.
    /// </summary>
    public class MapZoomMode : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for MapZoomMode
        /// </summary>
        public static readonly MapZoomMode AUTO = new MapZoomMode("AUTO");
        /// <summary>
        /// Constant MANUAL for MapZoomMode
        /// </summary>
        public static readonly MapZoomMode MANUAL = new MapZoomMode("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MapZoomMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MapZoomMode FindValue(string value)
        {
            return FindValue<MapZoomMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MapZoomMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaximumMinimumComputationType.
    /// </summary>
    public class MaximumMinimumComputationType : ConstantClass
    {

        /// <summary>
        /// Constant MAXIMUM for MaximumMinimumComputationType
        /// </summary>
        public static readonly MaximumMinimumComputationType MAXIMUM = new MaximumMinimumComputationType("MAXIMUM");
        /// <summary>
        /// Constant MINIMUM for MaximumMinimumComputationType
        /// </summary>
        public static readonly MaximumMinimumComputationType MINIMUM = new MaximumMinimumComputationType("MINIMUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaximumMinimumComputationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaximumMinimumComputationType FindValue(string value)
        {
            return FindValue<MaximumMinimumComputationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaximumMinimumComputationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberType.
    /// </summary>
    public class MemberType : ConstantClass
    {

        /// <summary>
        /// Constant ANALYSIS for MemberType
        /// </summary>
        public static readonly MemberType ANALYSIS = new MemberType("ANALYSIS");
        /// <summary>
        /// Constant DASHBOARD for MemberType
        /// </summary>
        public static readonly MemberType DASHBOARD = new MemberType("DASHBOARD");
        /// <summary>
        /// Constant DATASET for MemberType
        /// </summary>
        public static readonly MemberType DATASET = new MemberType("DATASET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberType FindValue(string value)
        {
            return FindValue<MemberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MissingDataTreatmentOption.
    /// </summary>
    public class MissingDataTreatmentOption : ConstantClass
    {

        /// <summary>
        /// Constant INTERPOLATE for MissingDataTreatmentOption
        /// </summary>
        public static readonly MissingDataTreatmentOption INTERPOLATE = new MissingDataTreatmentOption("INTERPOLATE");
        /// <summary>
        /// Constant SHOW_AS_BLANK for MissingDataTreatmentOption
        /// </summary>
        public static readonly MissingDataTreatmentOption SHOW_AS_BLANK = new MissingDataTreatmentOption("SHOW_AS_BLANK");
        /// <summary>
        /// Constant SHOW_AS_ZERO for MissingDataTreatmentOption
        /// </summary>
        public static readonly MissingDataTreatmentOption SHOW_AS_ZERO = new MissingDataTreatmentOption("SHOW_AS_ZERO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MissingDataTreatmentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MissingDataTreatmentOption FindValue(string value)
        {
            return FindValue<MissingDataTreatmentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MissingDataTreatmentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceErrorType.
    /// </summary>
    public class NamespaceErrorType : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for NamespaceErrorType
        /// </summary>
        public static readonly NamespaceErrorType INTERNAL_SERVICE_ERROR = new NamespaceErrorType("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant PERMISSION_DENIED for NamespaceErrorType
        /// </summary>
        public static readonly NamespaceErrorType PERMISSION_DENIED = new NamespaceErrorType("PERMISSION_DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceErrorType FindValue(string value)
        {
            return FindValue<NamespaceErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceStatus.
    /// </summary>
    public class NamespaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus CREATED = new NamespaceStatus("CREATED");
        /// <summary>
        /// Constant CREATING for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus CREATING = new NamespaceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus DELETING = new NamespaceStatus("DELETING");
        /// <summary>
        /// Constant NON_RETRYABLE_FAILURE for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus NON_RETRYABLE_FAILURE = new NamespaceStatus("NON_RETRYABLE_FAILURE");
        /// <summary>
        /// Constant RETRYABLE_FAILURE for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus RETRYABLE_FAILURE = new NamespaceStatus("RETRYABLE_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceStatus FindValue(string value)
        {
            return FindValue<NamespaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NegativeValueDisplayMode.
    /// </summary>
    public class NegativeValueDisplayMode : ConstantClass
    {

        /// <summary>
        /// Constant NEGATIVE for NegativeValueDisplayMode
        /// </summary>
        public static readonly NegativeValueDisplayMode NEGATIVE = new NegativeValueDisplayMode("NEGATIVE");
        /// <summary>
        /// Constant POSITIVE for NegativeValueDisplayMode
        /// </summary>
        public static readonly NegativeValueDisplayMode POSITIVE = new NegativeValueDisplayMode("POSITIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NegativeValueDisplayMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NegativeValueDisplayMode FindValue(string value)
        {
            return FindValue<NegativeValueDisplayMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NegativeValueDisplayMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberScale.
    /// </summary>
    public class NumberScale : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for NumberScale
        /// </summary>
        public static readonly NumberScale AUTO = new NumberScale("AUTO");
        /// <summary>
        /// Constant BILLIONS for NumberScale
        /// </summary>
        public static readonly NumberScale BILLIONS = new NumberScale("BILLIONS");
        /// <summary>
        /// Constant MILLIONS for NumberScale
        /// </summary>
        public static readonly NumberScale MILLIONS = new NumberScale("MILLIONS");
        /// <summary>
        /// Constant NONE for NumberScale
        /// </summary>
        public static readonly NumberScale NONE = new NumberScale("NONE");
        /// <summary>
        /// Constant THOUSANDS for NumberScale
        /// </summary>
        public static readonly NumberScale THOUSANDS = new NumberScale("THOUSANDS");
        /// <summary>
        /// Constant TRILLIONS for NumberScale
        /// </summary>
        public static readonly NumberScale TRILLIONS = new NumberScale("TRILLIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberScale(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberScale FindValue(string value)
        {
            return FindValue<NumberScale>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberScale(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumericEqualityMatchOperator.
    /// </summary>
    public class NumericEqualityMatchOperator : ConstantClass
    {

        /// <summary>
        /// Constant DOES_NOT_EQUAL for NumericEqualityMatchOperator
        /// </summary>
        public static readonly NumericEqualityMatchOperator DOES_NOT_EQUAL = new NumericEqualityMatchOperator("DOES_NOT_EQUAL");
        /// <summary>
        /// Constant EQUALS for NumericEqualityMatchOperator
        /// </summary>
        public static readonly NumericEqualityMatchOperator EQUALS = new NumericEqualityMatchOperator("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumericEqualityMatchOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumericEqualityMatchOperator FindValue(string value)
        {
            return FindValue<NumericEqualityMatchOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumericEqualityMatchOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumericFilterSelectAllOptions.
    /// </summary>
    public class NumericFilterSelectAllOptions : ConstantClass
    {

        /// <summary>
        /// Constant FILTER_ALL_VALUES for NumericFilterSelectAllOptions
        /// </summary>
        public static readonly NumericFilterSelectAllOptions FILTER_ALL_VALUES = new NumericFilterSelectAllOptions("FILTER_ALL_VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumericFilterSelectAllOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumericFilterSelectAllOptions FindValue(string value)
        {
            return FindValue<NumericFilterSelectAllOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumericFilterSelectAllOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumericSeparatorSymbol.
    /// </summary>
    public class NumericSeparatorSymbol : ConstantClass
    {

        /// <summary>
        /// Constant COMMA for NumericSeparatorSymbol
        /// </summary>
        public static readonly NumericSeparatorSymbol COMMA = new NumericSeparatorSymbol("COMMA");
        /// <summary>
        /// Constant DOT for NumericSeparatorSymbol
        /// </summary>
        public static readonly NumericSeparatorSymbol DOT = new NumericSeparatorSymbol("DOT");
        /// <summary>
        /// Constant SPACE for NumericSeparatorSymbol
        /// </summary>
        public static readonly NumericSeparatorSymbol SPACE = new NumericSeparatorSymbol("SPACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumericSeparatorSymbol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumericSeparatorSymbol FindValue(string value)
        {
            return FindValue<NumericSeparatorSymbol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumericSeparatorSymbol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OtherCategories.
    /// </summary>
    public class OtherCategories : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for OtherCategories
        /// </summary>
        public static readonly OtherCategories EXCLUDE = new OtherCategories("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for OtherCategories
        /// </summary>
        public static readonly OtherCategories INCLUDE = new OtherCategories("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OtherCategories(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OtherCategories FindValue(string value)
        {
            return FindValue<OtherCategories>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OtherCategories(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PanelBorderStyle.
    /// </summary>
    public class PanelBorderStyle : ConstantClass
    {

        /// <summary>
        /// Constant DASHED for PanelBorderStyle
        /// </summary>
        public static readonly PanelBorderStyle DASHED = new PanelBorderStyle("DASHED");
        /// <summary>
        /// Constant DOTTED for PanelBorderStyle
        /// </summary>
        public static readonly PanelBorderStyle DOTTED = new PanelBorderStyle("DOTTED");
        /// <summary>
        /// Constant SOLID for PanelBorderStyle
        /// </summary>
        public static readonly PanelBorderStyle SOLID = new PanelBorderStyle("SOLID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PanelBorderStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PanelBorderStyle FindValue(string value)
        {
            return FindValue<PanelBorderStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PanelBorderStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaperOrientation.
    /// </summary>
    public class PaperOrientation : ConstantClass
    {

        /// <summary>
        /// Constant LANDSCAPE for PaperOrientation
        /// </summary>
        public static readonly PaperOrientation LANDSCAPE = new PaperOrientation("LANDSCAPE");
        /// <summary>
        /// Constant PORTRAIT for PaperOrientation
        /// </summary>
        public static readonly PaperOrientation PORTRAIT = new PaperOrientation("PORTRAIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaperOrientation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaperOrientation FindValue(string value)
        {
            return FindValue<PaperOrientation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaperOrientation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaperSize.
    /// </summary>
    public class PaperSize : ConstantClass
    {

        /// <summary>
        /// Constant A0 for PaperSize
        /// </summary>
        public static readonly PaperSize A0 = new PaperSize("A0");
        /// <summary>
        /// Constant A1 for PaperSize
        /// </summary>
        public static readonly PaperSize A1 = new PaperSize("A1");
        /// <summary>
        /// Constant A2 for PaperSize
        /// </summary>
        public static readonly PaperSize A2 = new PaperSize("A2");
        /// <summary>
        /// Constant A3 for PaperSize
        /// </summary>
        public static readonly PaperSize A3 = new PaperSize("A3");
        /// <summary>
        /// Constant A4 for PaperSize
        /// </summary>
        public static readonly PaperSize A4 = new PaperSize("A4");
        /// <summary>
        /// Constant A5 for PaperSize
        /// </summary>
        public static readonly PaperSize A5 = new PaperSize("A5");
        /// <summary>
        /// Constant JIS_B4 for PaperSize
        /// </summary>
        public static readonly PaperSize JIS_B4 = new PaperSize("JIS_B4");
        /// <summary>
        /// Constant JIS_B5 for PaperSize
        /// </summary>
        public static readonly PaperSize JIS_B5 = new PaperSize("JIS_B5");
        /// <summary>
        /// Constant US_LEGAL for PaperSize
        /// </summary>
        public static readonly PaperSize US_LEGAL = new PaperSize("US_LEGAL");
        /// <summary>
        /// Constant US_LETTER for PaperSize
        /// </summary>
        public static readonly PaperSize US_LETTER = new PaperSize("US_LETTER");
        /// <summary>
        /// Constant US_TABLOID_LEDGER for PaperSize
        /// </summary>
        public static readonly PaperSize US_TABLOID_LEDGER = new PaperSize("US_TABLOID_LEDGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaperSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaperSize FindValue(string value)
        {
            return FindValue<PaperSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaperSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterValueType.
    /// </summary>
    public class ParameterValueType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_VALUED for ParameterValueType
        /// </summary>
        public static readonly ParameterValueType MULTI_VALUED = new ParameterValueType("MULTI_VALUED");
        /// <summary>
        /// Constant SINGLE_VALUED for ParameterValueType
        /// </summary>
        public static readonly ParameterValueType SINGLE_VALUED = new ParameterValueType("SINGLE_VALUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterValueType FindValue(string value)
        {
            return FindValue<ParameterValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PivotTableConditionalFormattingScopeRole.
    /// </summary>
    public class PivotTableConditionalFormattingScopeRole : ConstantClass
    {

        /// <summary>
        /// Constant FIELD for PivotTableConditionalFormattingScopeRole
        /// </summary>
        public static readonly PivotTableConditionalFormattingScopeRole FIELD = new PivotTableConditionalFormattingScopeRole("FIELD");
        /// <summary>
        /// Constant FIELD_TOTAL for PivotTableConditionalFormattingScopeRole
        /// </summary>
        public static readonly PivotTableConditionalFormattingScopeRole FIELD_TOTAL = new PivotTableConditionalFormattingScopeRole("FIELD_TOTAL");
        /// <summary>
        /// Constant GRAND_TOTAL for PivotTableConditionalFormattingScopeRole
        /// </summary>
        public static readonly PivotTableConditionalFormattingScopeRole GRAND_TOTAL = new PivotTableConditionalFormattingScopeRole("GRAND_TOTAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PivotTableConditionalFormattingScopeRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PivotTableConditionalFormattingScopeRole FindValue(string value)
        {
            return FindValue<PivotTableConditionalFormattingScopeRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PivotTableConditionalFormattingScopeRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PivotTableMetricPlacement.
    /// </summary>
    public class PivotTableMetricPlacement : ConstantClass
    {

        /// <summary>
        /// Constant COLUMN for PivotTableMetricPlacement
        /// </summary>
        public static readonly PivotTableMetricPlacement COLUMN = new PivotTableMetricPlacement("COLUMN");
        /// <summary>
        /// Constant ROW for PivotTableMetricPlacement
        /// </summary>
        public static readonly PivotTableMetricPlacement ROW = new PivotTableMetricPlacement("ROW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PivotTableMetricPlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PivotTableMetricPlacement FindValue(string value)
        {
            return FindValue<PivotTableMetricPlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PivotTableMetricPlacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PivotTableSubtotalLevel.
    /// </summary>
    public class PivotTableSubtotalLevel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for PivotTableSubtotalLevel
        /// </summary>
        public static readonly PivotTableSubtotalLevel ALL = new PivotTableSubtotalLevel("ALL");
        /// <summary>
        /// Constant CUSTOM for PivotTableSubtotalLevel
        /// </summary>
        public static readonly PivotTableSubtotalLevel CUSTOM = new PivotTableSubtotalLevel("CUSTOM");
        /// <summary>
        /// Constant LAST for PivotTableSubtotalLevel
        /// </summary>
        public static readonly PivotTableSubtotalLevel LAST = new PivotTableSubtotalLevel("LAST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PivotTableSubtotalLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PivotTableSubtotalLevel FindValue(string value)
        {
            return FindValue<PivotTableSubtotalLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PivotTableSubtotalLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrimaryValueDisplayType.
    /// </summary>
    public class PrimaryValueDisplayType : ConstantClass
    {

        /// <summary>
        /// Constant ACTUAL for PrimaryValueDisplayType
        /// </summary>
        public static readonly PrimaryValueDisplayType ACTUAL = new PrimaryValueDisplayType("ACTUAL");
        /// <summary>
        /// Constant COMPARISON for PrimaryValueDisplayType
        /// </summary>
        public static readonly PrimaryValueDisplayType COMPARISON = new PrimaryValueDisplayType("COMPARISON");
        /// <summary>
        /// Constant HIDDEN for PrimaryValueDisplayType
        /// </summary>
        public static readonly PrimaryValueDisplayType HIDDEN = new PrimaryValueDisplayType("HIDDEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrimaryValueDisplayType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrimaryValueDisplayType FindValue(string value)
        {
            return FindValue<PrimaryValueDisplayType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrimaryValueDisplayType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceLineLabelHorizontalPosition.
    /// </summary>
    public class ReferenceLineLabelHorizontalPosition : ConstantClass
    {

        /// <summary>
        /// Constant CENTER for ReferenceLineLabelHorizontalPosition
        /// </summary>
        public static readonly ReferenceLineLabelHorizontalPosition CENTER = new ReferenceLineLabelHorizontalPosition("CENTER");
        /// <summary>
        /// Constant LEFT for ReferenceLineLabelHorizontalPosition
        /// </summary>
        public static readonly ReferenceLineLabelHorizontalPosition LEFT = new ReferenceLineLabelHorizontalPosition("LEFT");
        /// <summary>
        /// Constant RIGHT for ReferenceLineLabelHorizontalPosition
        /// </summary>
        public static readonly ReferenceLineLabelHorizontalPosition RIGHT = new ReferenceLineLabelHorizontalPosition("RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceLineLabelHorizontalPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceLineLabelHorizontalPosition FindValue(string value)
        {
            return FindValue<ReferenceLineLabelHorizontalPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceLineLabelHorizontalPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceLineLabelVerticalPosition.
    /// </summary>
    public class ReferenceLineLabelVerticalPosition : ConstantClass
    {

        /// <summary>
        /// Constant ABOVE for ReferenceLineLabelVerticalPosition
        /// </summary>
        public static readonly ReferenceLineLabelVerticalPosition ABOVE = new ReferenceLineLabelVerticalPosition("ABOVE");
        /// <summary>
        /// Constant BELOW for ReferenceLineLabelVerticalPosition
        /// </summary>
        public static readonly ReferenceLineLabelVerticalPosition BELOW = new ReferenceLineLabelVerticalPosition("BELOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceLineLabelVerticalPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceLineLabelVerticalPosition FindValue(string value)
        {
            return FindValue<ReferenceLineLabelVerticalPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceLineLabelVerticalPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceLinePatternType.
    /// </summary>
    public class ReferenceLinePatternType : ConstantClass
    {

        /// <summary>
        /// Constant DASHED for ReferenceLinePatternType
        /// </summary>
        public static readonly ReferenceLinePatternType DASHED = new ReferenceLinePatternType("DASHED");
        /// <summary>
        /// Constant DOTTED for ReferenceLinePatternType
        /// </summary>
        public static readonly ReferenceLinePatternType DOTTED = new ReferenceLinePatternType("DOTTED");
        /// <summary>
        /// Constant SOLID for ReferenceLinePatternType
        /// </summary>
        public static readonly ReferenceLinePatternType SOLID = new ReferenceLinePatternType("SOLID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceLinePatternType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceLinePatternType FindValue(string value)
        {
            return FindValue<ReferenceLinePatternType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceLinePatternType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceLineValueLabelRelativePosition.
    /// </summary>
    public class ReferenceLineValueLabelRelativePosition : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_CUSTOM_LABEL for ReferenceLineValueLabelRelativePosition
        /// </summary>
        public static readonly ReferenceLineValueLabelRelativePosition AFTER_CUSTOM_LABEL = new ReferenceLineValueLabelRelativePosition("AFTER_CUSTOM_LABEL");
        /// <summary>
        /// Constant BEFORE_CUSTOM_LABEL for ReferenceLineValueLabelRelativePosition
        /// </summary>
        public static readonly ReferenceLineValueLabelRelativePosition BEFORE_CUSTOM_LABEL = new ReferenceLineValueLabelRelativePosition("BEFORE_CUSTOM_LABEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceLineValueLabelRelativePosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceLineValueLabelRelativePosition FindValue(string value)
        {
            return FindValue<ReferenceLineValueLabelRelativePosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceLineValueLabelRelativePosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelativeDateType.
    /// </summary>
    public class RelativeDateType : ConstantClass
    {

        /// <summary>
        /// Constant LAST for RelativeDateType
        /// </summary>
        public static readonly RelativeDateType LAST = new RelativeDateType("LAST");
        /// <summary>
        /// Constant NEXT for RelativeDateType
        /// </summary>
        public static readonly RelativeDateType NEXT = new RelativeDateType("NEXT");
        /// <summary>
        /// Constant NOW for RelativeDateType
        /// </summary>
        public static readonly RelativeDateType NOW = new RelativeDateType("NOW");
        /// <summary>
        /// Constant PREVIOUS for RelativeDateType
        /// </summary>
        public static readonly RelativeDateType PREVIOUS = new RelativeDateType("PREVIOUS");
        /// <summary>
        /// Constant THIS for RelativeDateType
        /// </summary>
        public static readonly RelativeDateType THIS = new RelativeDateType("THIS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelativeDateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelativeDateType FindValue(string value)
        {
            return FindValue<RelativeDateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelativeDateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelativeFontSize.
    /// </summary>
    public class RelativeFontSize : ConstantClass
    {

        /// <summary>
        /// Constant EXTRA_LARGE for RelativeFontSize
        /// </summary>
        public static readonly RelativeFontSize EXTRA_LARGE = new RelativeFontSize("EXTRA_LARGE");
        /// <summary>
        /// Constant EXTRA_SMALL for RelativeFontSize
        /// </summary>
        public static readonly RelativeFontSize EXTRA_SMALL = new RelativeFontSize("EXTRA_SMALL");
        /// <summary>
        /// Constant LARGE for RelativeFontSize
        /// </summary>
        public static readonly RelativeFontSize LARGE = new RelativeFontSize("LARGE");
        /// <summary>
        /// Constant MEDIUM for RelativeFontSize
        /// </summary>
        public static readonly RelativeFontSize MEDIUM = new RelativeFontSize("MEDIUM");
        /// <summary>
        /// Constant SMALL for RelativeFontSize
        /// </summary>
        public static readonly RelativeFontSize SMALL = new RelativeFontSize("SMALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelativeFontSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelativeFontSize FindValue(string value)
        {
            return FindValue<RelativeFontSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelativeFontSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResizeOption.
    /// </summary>
    public class ResizeOption : ConstantClass
    {

        /// <summary>
        /// Constant FIXED for ResizeOption
        /// </summary>
        public static readonly ResizeOption FIXED = new ResizeOption("FIXED");
        /// <summary>
        /// Constant RESPONSIVE for ResizeOption
        /// </summary>
        public static readonly ResizeOption RESPONSIVE = new ResizeOption("RESPONSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResizeOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResizeOption FindValue(string value)
        {
            return FindValue<ResizeOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResizeOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATION_FAILED = new ResourceStatus("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATION_IN_PROGRESS = new ResourceStatus("CREATION_IN_PROGRESS");
        /// <summary>
        /// Constant CREATION_SUCCESSFUL for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATION_SUCCESSFUL = new ResourceStatus("CREATION_SUCCESSFUL");
        /// <summary>
        /// Constant DELETED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETED = new ResourceStatus("DELETED");
        /// <summary>
        /// Constant UPDATE_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_FAILED = new ResourceStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_IN_PROGRESS = new ResourceStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCESSFUL for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_SUCCESSFUL = new ResourceStatus("UPDATE_SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RowLevelPermissionFormatVersion.
    /// </summary>
    public class RowLevelPermissionFormatVersion : ConstantClass
    {

        /// <summary>
        /// Constant VERSION_1 for RowLevelPermissionFormatVersion
        /// </summary>
        public static readonly RowLevelPermissionFormatVersion VERSION_1 = new RowLevelPermissionFormatVersion("VERSION_1");
        /// <summary>
        /// Constant VERSION_2 for RowLevelPermissionFormatVersion
        /// </summary>
        public static readonly RowLevelPermissionFormatVersion VERSION_2 = new RowLevelPermissionFormatVersion("VERSION_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RowLevelPermissionFormatVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RowLevelPermissionFormatVersion FindValue(string value)
        {
            return FindValue<RowLevelPermissionFormatVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RowLevelPermissionFormatVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RowLevelPermissionPolicy.
    /// </summary>
    public class RowLevelPermissionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DENY_ACCESS for RowLevelPermissionPolicy
        /// </summary>
        public static readonly RowLevelPermissionPolicy DENY_ACCESS = new RowLevelPermissionPolicy("DENY_ACCESS");
        /// <summary>
        /// Constant GRANT_ACCESS for RowLevelPermissionPolicy
        /// </summary>
        public static readonly RowLevelPermissionPolicy GRANT_ACCESS = new RowLevelPermissionPolicy("GRANT_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RowLevelPermissionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RowLevelPermissionPolicy FindValue(string value)
        {
            return FindValue<RowLevelPermissionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RowLevelPermissionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SectionPageBreakStatus.
    /// </summary>
    public class SectionPageBreakStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SectionPageBreakStatus
        /// </summary>
        public static readonly SectionPageBreakStatus DISABLED = new SectionPageBreakStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for SectionPageBreakStatus
        /// </summary>
        public static readonly SectionPageBreakStatus ENABLED = new SectionPageBreakStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SectionPageBreakStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SectionPageBreakStatus FindValue(string value)
        {
            return FindValue<SectionPageBreakStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SectionPageBreakStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelectAllValueOptions.
    /// </summary>
    public class SelectAllValueOptions : ConstantClass
    {

        /// <summary>
        /// Constant ALL_VALUES for SelectAllValueOptions
        /// </summary>
        public static readonly SelectAllValueOptions ALL_VALUES = new SelectAllValueOptions("ALL_VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelectAllValueOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelectAllValueOptions FindValue(string value)
        {
            return FindValue<SelectAllValueOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelectAllValueOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelectedFieldOptions.
    /// </summary>
    public class SelectedFieldOptions : ConstantClass
    {

        /// <summary>
        /// Constant ALL_FIELDS for SelectedFieldOptions
        /// </summary>
        public static readonly SelectedFieldOptions ALL_FIELDS = new SelectedFieldOptions("ALL_FIELDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelectedFieldOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelectedFieldOptions FindValue(string value)
        {
            return FindValue<SelectedFieldOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelectedFieldOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelectedTooltipType.
    /// </summary>
    public class SelectedTooltipType : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for SelectedTooltipType
        /// </summary>
        public static readonly SelectedTooltipType BASIC = new SelectedTooltipType("BASIC");
        /// <summary>
        /// Constant DETAILED for SelectedTooltipType
        /// </summary>
        public static readonly SelectedTooltipType DETAILED = new SelectedTooltipType("DETAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelectedTooltipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelectedTooltipType FindValue(string value)
        {
            return FindValue<SelectedTooltipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelectedTooltipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SheetContentType.
    /// </summary>
    public class SheetContentType : ConstantClass
    {

        /// <summary>
        /// Constant INTERACTIVE for SheetContentType
        /// </summary>
        public static readonly SheetContentType INTERACTIVE = new SheetContentType("INTERACTIVE");
        /// <summary>
        /// Constant PAGINATED for SheetContentType
        /// </summary>
        public static readonly SheetContentType PAGINATED = new SheetContentType("PAGINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SheetContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SheetContentType FindValue(string value)
        {
            return FindValue<SheetContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SheetContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SheetControlDateTimePickerType.
    /// </summary>
    public class SheetControlDateTimePickerType : ConstantClass
    {

        /// <summary>
        /// Constant DATE_RANGE for SheetControlDateTimePickerType
        /// </summary>
        public static readonly SheetControlDateTimePickerType DATE_RANGE = new SheetControlDateTimePickerType("DATE_RANGE");
        /// <summary>
        /// Constant SINGLE_VALUED for SheetControlDateTimePickerType
        /// </summary>
        public static readonly SheetControlDateTimePickerType SINGLE_VALUED = new SheetControlDateTimePickerType("SINGLE_VALUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SheetControlDateTimePickerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SheetControlDateTimePickerType FindValue(string value)
        {
            return FindValue<SheetControlDateTimePickerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SheetControlDateTimePickerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SheetControlListType.
    /// </summary>
    public class SheetControlListType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_SELECT for SheetControlListType
        /// </summary>
        public static readonly SheetControlListType MULTI_SELECT = new SheetControlListType("MULTI_SELECT");
        /// <summary>
        /// Constant SINGLE_SELECT for SheetControlListType
        /// </summary>
        public static readonly SheetControlListType SINGLE_SELECT = new SheetControlListType("SINGLE_SELECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SheetControlListType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SheetControlListType FindValue(string value)
        {
            return FindValue<SheetControlListType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SheetControlListType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SheetControlSliderType.
    /// </summary>
    public class SheetControlSliderType : ConstantClass
    {

        /// <summary>
        /// Constant RANGE for SheetControlSliderType
        /// </summary>
        public static readonly SheetControlSliderType RANGE = new SheetControlSliderType("RANGE");
        /// <summary>
        /// Constant SINGLE_POINT for SheetControlSliderType
        /// </summary>
        public static readonly SheetControlSliderType SINGLE_POINT = new SheetControlSliderType("SINGLE_POINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SheetControlSliderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SheetControlSliderType FindValue(string value)
        {
            return FindValue<SheetControlSliderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SheetControlSliderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimpleNumericalAggregationFunction.
    /// </summary>
    public class SimpleNumericalAggregationFunction : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction AVERAGE = new SimpleNumericalAggregationFunction("AVERAGE");
        /// <summary>
        /// Constant COUNT for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction COUNT = new SimpleNumericalAggregationFunction("COUNT");
        /// <summary>
        /// Constant DISTINCT_COUNT for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction DISTINCT_COUNT = new SimpleNumericalAggregationFunction("DISTINCT_COUNT");
        /// <summary>
        /// Constant MAX for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction MAX = new SimpleNumericalAggregationFunction("MAX");
        /// <summary>
        /// Constant MEDIAN for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction MEDIAN = new SimpleNumericalAggregationFunction("MEDIAN");
        /// <summary>
        /// Constant MIN for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction MIN = new SimpleNumericalAggregationFunction("MIN");
        /// <summary>
        /// Constant STDEV for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction STDEV = new SimpleNumericalAggregationFunction("STDEV");
        /// <summary>
        /// Constant STDEVP for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction STDEVP = new SimpleNumericalAggregationFunction("STDEVP");
        /// <summary>
        /// Constant SUM for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction SUM = new SimpleNumericalAggregationFunction("SUM");
        /// <summary>
        /// Constant VAR for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction VAR = new SimpleNumericalAggregationFunction("VAR");
        /// <summary>
        /// Constant VARP for SimpleNumericalAggregationFunction
        /// </summary>
        public static readonly SimpleNumericalAggregationFunction VARP = new SimpleNumericalAggregationFunction("VARP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimpleNumericalAggregationFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimpleNumericalAggregationFunction FindValue(string value)
        {
            return FindValue<SimpleNumericalAggregationFunction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimpleNumericalAggregationFunction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortDirection.
    /// </summary>
    public class SortDirection : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortDirection
        /// </summary>
        public static readonly SortDirection ASC = new SortDirection("ASC");
        /// <summary>
        /// Constant DESC for SortDirection
        /// </summary>
        public static readonly SortDirection DESC = new SortDirection("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortDirection FindValue(string value)
        {
            return FindValue<SortDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Status
        /// </summary>
        public static readonly Status DISABLED = new Status("DISABLED");
        /// <summary>
        /// Constant ENABLED for Status
        /// </summary>
        public static readonly Status ENABLED = new Status("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableBorderStyle.
    /// </summary>
    public class TableBorderStyle : ConstantClass
    {

        /// <summary>
        /// Constant NONE for TableBorderStyle
        /// </summary>
        public static readonly TableBorderStyle NONE = new TableBorderStyle("NONE");
        /// <summary>
        /// Constant SOLID for TableBorderStyle
        /// </summary>
        public static readonly TableBorderStyle SOLID = new TableBorderStyle("SOLID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableBorderStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableBorderStyle FindValue(string value)
        {
            return FindValue<TableBorderStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableBorderStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableCellImageScalingConfiguration.
    /// </summary>
    public class TableCellImageScalingConfiguration : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOT_SCALE for TableCellImageScalingConfiguration
        /// </summary>
        public static readonly TableCellImageScalingConfiguration DO_NOT_SCALE = new TableCellImageScalingConfiguration("DO_NOT_SCALE");
        /// <summary>
        /// Constant FIT_TO_CELL_HEIGHT for TableCellImageScalingConfiguration
        /// </summary>
        public static readonly TableCellImageScalingConfiguration FIT_TO_CELL_HEIGHT = new TableCellImageScalingConfiguration("FIT_TO_CELL_HEIGHT");
        /// <summary>
        /// Constant FIT_TO_CELL_WIDTH for TableCellImageScalingConfiguration
        /// </summary>
        public static readonly TableCellImageScalingConfiguration FIT_TO_CELL_WIDTH = new TableCellImageScalingConfiguration("FIT_TO_CELL_WIDTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableCellImageScalingConfiguration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableCellImageScalingConfiguration FindValue(string value)
        {
            return FindValue<TableCellImageScalingConfiguration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableCellImageScalingConfiguration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableFieldIconSetType.
    /// </summary>
    public class TableFieldIconSetType : ConstantClass
    {

        /// <summary>
        /// Constant LINK for TableFieldIconSetType
        /// </summary>
        public static readonly TableFieldIconSetType LINK = new TableFieldIconSetType("LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableFieldIconSetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableFieldIconSetType FindValue(string value)
        {
            return FindValue<TableFieldIconSetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableFieldIconSetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableOrientation.
    /// </summary>
    public class TableOrientation : ConstantClass
    {

        /// <summary>
        /// Constant HORIZONTAL for TableOrientation
        /// </summary>
        public static readonly TableOrientation HORIZONTAL = new TableOrientation("HORIZONTAL");
        /// <summary>
        /// Constant VERTICAL for TableOrientation
        /// </summary>
        public static readonly TableOrientation VERTICAL = new TableOrientation("VERTICAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableOrientation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableOrientation FindValue(string value)
        {
            return FindValue<TableOrientation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableOrientation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableTotalsPlacement.
    /// </summary>
    public class TableTotalsPlacement : ConstantClass
    {

        /// <summary>
        /// Constant END for TableTotalsPlacement
        /// </summary>
        public static readonly TableTotalsPlacement END = new TableTotalsPlacement("END");
        /// <summary>
        /// Constant START for TableTotalsPlacement
        /// </summary>
        public static readonly TableTotalsPlacement START = new TableTotalsPlacement("START");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableTotalsPlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableTotalsPlacement FindValue(string value)
        {
            return FindValue<TableTotalsPlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableTotalsPlacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableTotalsScrollStatus.
    /// </summary>
    public class TableTotalsScrollStatus : ConstantClass
    {

        /// <summary>
        /// Constant PINNED for TableTotalsScrollStatus
        /// </summary>
        public static readonly TableTotalsScrollStatus PINNED = new TableTotalsScrollStatus("PINNED");
        /// <summary>
        /// Constant SCROLLED for TableTotalsScrollStatus
        /// </summary>
        public static readonly TableTotalsScrollStatus SCROLLED = new TableTotalsScrollStatus("SCROLLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableTotalsScrollStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableTotalsScrollStatus FindValue(string value)
        {
            return FindValue<TableTotalsScrollStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableTotalsScrollStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetVisualOptions.
    /// </summary>
    public class TargetVisualOptions : ConstantClass
    {

        /// <summary>
        /// Constant ALL_VISUALS for TargetVisualOptions
        /// </summary>
        public static readonly TargetVisualOptions ALL_VISUALS = new TargetVisualOptions("ALL_VISUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetVisualOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetVisualOptions FindValue(string value)
        {
            return FindValue<TargetVisualOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetVisualOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateErrorType.
    /// </summary>
    public class TemplateErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType ACCESS_DENIED = new TemplateErrorType("ACCESS_DENIED");
        /// <summary>
        /// Constant DATA_SET_NOT_FOUND for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType DATA_SET_NOT_FOUND = new TemplateErrorType("DATA_SET_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType INTERNAL_FAILURE = new TemplateErrorType("INTERNAL_FAILURE");
        /// <summary>
        /// Constant SOURCE_NOT_FOUND for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType SOURCE_NOT_FOUND = new TemplateErrorType("SOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateErrorType FindValue(string value)
        {
            return FindValue<TemplateErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextQualifier.
    /// </summary>
    public class TextQualifier : ConstantClass
    {

        /// <summary>
        /// Constant DOUBLE_QUOTE for TextQualifier
        /// </summary>
        public static readonly TextQualifier DOUBLE_QUOTE = new TextQualifier("DOUBLE_QUOTE");
        /// <summary>
        /// Constant SINGLE_QUOTE for TextQualifier
        /// </summary>
        public static readonly TextQualifier SINGLE_QUOTE = new TextQualifier("SINGLE_QUOTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextQualifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextQualifier FindValue(string value)
        {
            return FindValue<TextQualifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextQualifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextWrap.
    /// </summary>
    public class TextWrap : ConstantClass
    {

        /// <summary>
        /// Constant NONE for TextWrap
        /// </summary>
        public static readonly TextWrap NONE = new TextWrap("NONE");
        /// <summary>
        /// Constant WRAP for TextWrap
        /// </summary>
        public static readonly TextWrap WRAP = new TextWrap("WRAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextWrap(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextWrap FindValue(string value)
        {
            return FindValue<TextWrap>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextWrap(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThemeErrorType.
    /// </summary>
    public class ThemeErrorType : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for ThemeErrorType
        /// </summary>
        public static readonly ThemeErrorType INTERNAL_FAILURE = new ThemeErrorType("INTERNAL_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThemeErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThemeErrorType FindValue(string value)
        {
            return FindValue<ThemeErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThemeErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThemeType.
    /// </summary>
    public class ThemeType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ThemeType
        /// </summary>
        public static readonly ThemeType ALL = new ThemeType("ALL");
        /// <summary>
        /// Constant CUSTOM for ThemeType
        /// </summary>
        public static readonly ThemeType CUSTOM = new ThemeType("CUSTOM");
        /// <summary>
        /// Constant QUICKSIGHT for ThemeType
        /// </summary>
        public static readonly ThemeType QUICKSIGHT = new ThemeType("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThemeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThemeType FindValue(string value)
        {
            return FindValue<ThemeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThemeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeGranularity.
    /// </summary>
    public class TimeGranularity : ConstantClass
    {

        /// <summary>
        /// Constant DAY for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity DAY = new TimeGranularity("DAY");
        /// <summary>
        /// Constant HOUR for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity HOUR = new TimeGranularity("HOUR");
        /// <summary>
        /// Constant MILLISECOND for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity MILLISECOND = new TimeGranularity("MILLISECOND");
        /// <summary>
        /// Constant MINUTE for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity MINUTE = new TimeGranularity("MINUTE");
        /// <summary>
        /// Constant MONTH for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity MONTH = new TimeGranularity("MONTH");
        /// <summary>
        /// Constant QUARTER for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity QUARTER = new TimeGranularity("QUARTER");
        /// <summary>
        /// Constant SECOND for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity SECOND = new TimeGranularity("SECOND");
        /// <summary>
        /// Constant WEEK for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity WEEK = new TimeGranularity("WEEK");
        /// <summary>
        /// Constant YEAR for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity YEAR = new TimeGranularity("YEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeGranularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeGranularity FindValue(string value)
        {
            return FindValue<TimeGranularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeGranularity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TooltipTitleType.
    /// </summary>
    public class TooltipTitleType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for TooltipTitleType
        /// </summary>
        public static readonly TooltipTitleType NONE = new TooltipTitleType("NONE");
        /// <summary>
        /// Constant PRIMARY_VALUE for TooltipTitleType
        /// </summary>
        public static readonly TooltipTitleType PRIMARY_VALUE = new TooltipTitleType("PRIMARY_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TooltipTitleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TooltipTitleType FindValue(string value)
        {
            return FindValue<TooltipTitleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TooltipTitleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TopBottomComputationType.
    /// </summary>
    public class TopBottomComputationType : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM for TopBottomComputationType
        /// </summary>
        public static readonly TopBottomComputationType BOTTOM = new TopBottomComputationType("BOTTOM");
        /// <summary>
        /// Constant TOP for TopBottomComputationType
        /// </summary>
        public static readonly TopBottomComputationType TOP = new TopBottomComputationType("TOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TopBottomComputationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TopBottomComputationType FindValue(string value)
        {
            return FindValue<TopBottomComputationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TopBottomComputationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TopBottomSortOrder.
    /// </summary>
    public class TopBottomSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ABSOLUTE_DIFFERENCE for TopBottomSortOrder
        /// </summary>
        public static readonly TopBottomSortOrder ABSOLUTE_DIFFERENCE = new TopBottomSortOrder("ABSOLUTE_DIFFERENCE");
        /// <summary>
        /// Constant PERCENT_DIFFERENCE for TopBottomSortOrder
        /// </summary>
        public static readonly TopBottomSortOrder PERCENT_DIFFERENCE = new TopBottomSortOrder("PERCENT_DIFFERENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TopBottomSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TopBottomSortOrder FindValue(string value)
        {
            return FindValue<TopBottomSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TopBottomSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type URLTargetConfiguration.
    /// </summary>
    public class URLTargetConfiguration : ConstantClass
    {

        /// <summary>
        /// Constant NEW_TAB for URLTargetConfiguration
        /// </summary>
        public static readonly URLTargetConfiguration NEW_TAB = new URLTargetConfiguration("NEW_TAB");
        /// <summary>
        /// Constant NEW_WINDOW for URLTargetConfiguration
        /// </summary>
        public static readonly URLTargetConfiguration NEW_WINDOW = new URLTargetConfiguration("NEW_WINDOW");
        /// <summary>
        /// Constant SAME_TAB for URLTargetConfiguration
        /// </summary>
        public static readonly URLTargetConfiguration SAME_TAB = new URLTargetConfiguration("SAME_TAB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public URLTargetConfiguration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static URLTargetConfiguration FindValue(string value)
        {
            return FindValue<URLTargetConfiguration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator URLTargetConfiguration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserRole.
    /// </summary>
    public class UserRole : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN for UserRole
        /// </summary>
        public static readonly UserRole ADMIN = new UserRole("ADMIN");
        /// <summary>
        /// Constant AUTHOR for UserRole
        /// </summary>
        public static readonly UserRole AUTHOR = new UserRole("AUTHOR");
        /// <summary>
        /// Constant READER for UserRole
        /// </summary>
        public static readonly UserRole READER = new UserRole("READER");
        /// <summary>
        /// Constant RESTRICTED_AUTHOR for UserRole
        /// </summary>
        public static readonly UserRole RESTRICTED_AUTHOR = new UserRole("RESTRICTED_AUTHOR");
        /// <summary>
        /// Constant RESTRICTED_READER for UserRole
        /// </summary>
        public static readonly UserRole RESTRICTED_READER = new UserRole("RESTRICTED_READER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserRole FindValue(string value)
        {
            return FindValue<UserRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValueWhenUnsetOption.
    /// </summary>
    public class ValueWhenUnsetOption : ConstantClass
    {

        /// <summary>
        /// Constant NULL for ValueWhenUnsetOption
        /// </summary>
        public static readonly ValueWhenUnsetOption NULL = new ValueWhenUnsetOption("NULL");
        /// <summary>
        /// Constant RECOMMENDED_VALUE for ValueWhenUnsetOption
        /// </summary>
        public static readonly ValueWhenUnsetOption RECOMMENDED_VALUE = new ValueWhenUnsetOption("RECOMMENDED_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValueWhenUnsetOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValueWhenUnsetOption FindValue(string value)
        {
            return FindValue<ValueWhenUnsetOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValueWhenUnsetOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerticalTextAlignment.
    /// </summary>
    public class VerticalTextAlignment : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM for VerticalTextAlignment
        /// </summary>
        public static readonly VerticalTextAlignment BOTTOM = new VerticalTextAlignment("BOTTOM");
        /// <summary>
        /// Constant MIDDLE for VerticalTextAlignment
        /// </summary>
        public static readonly VerticalTextAlignment MIDDLE = new VerticalTextAlignment("MIDDLE");
        /// <summary>
        /// Constant TOP for VerticalTextAlignment
        /// </summary>
        public static readonly VerticalTextAlignment TOP = new VerticalTextAlignment("TOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerticalTextAlignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerticalTextAlignment FindValue(string value)
        {
            return FindValue<VerticalTextAlignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerticalTextAlignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Visibility.
    /// </summary>
    public class Visibility : ConstantClass
    {

        /// <summary>
        /// Constant HIDDEN for Visibility
        /// </summary>
        public static readonly Visibility HIDDEN = new Visibility("HIDDEN");
        /// <summary>
        /// Constant VISIBLE for Visibility
        /// </summary>
        public static readonly Visibility VISIBLE = new Visibility("VISIBLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Visibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Visibility FindValue(string value)
        {
            return FindValue<Visibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Visibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VisualCustomActionTrigger.
    /// </summary>
    public class VisualCustomActionTrigger : ConstantClass
    {

        /// <summary>
        /// Constant DATA_POINT_CLICK for VisualCustomActionTrigger
        /// </summary>
        public static readonly VisualCustomActionTrigger DATA_POINT_CLICK = new VisualCustomActionTrigger("DATA_POINT_CLICK");
        /// <summary>
        /// Constant DATA_POINT_MENU for VisualCustomActionTrigger
        /// </summary>
        public static readonly VisualCustomActionTrigger DATA_POINT_MENU = new VisualCustomActionTrigger("DATA_POINT_MENU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VisualCustomActionTrigger(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VisualCustomActionTrigger FindValue(string value)
        {
            return FindValue<VisualCustomActionTrigger>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VisualCustomActionTrigger(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WidgetStatus.
    /// </summary>
    public class WidgetStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WidgetStatus
        /// </summary>
        public static readonly WidgetStatus DISABLED = new WidgetStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for WidgetStatus
        /// </summary>
        public static readonly WidgetStatus ENABLED = new WidgetStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WidgetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WidgetStatus FindValue(string value)
        {
            return FindValue<WidgetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WidgetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WordCloudCloudLayout.
    /// </summary>
    public class WordCloudCloudLayout : ConstantClass
    {

        /// <summary>
        /// Constant FLUID for WordCloudCloudLayout
        /// </summary>
        public static readonly WordCloudCloudLayout FLUID = new WordCloudCloudLayout("FLUID");
        /// <summary>
        /// Constant NORMAL for WordCloudCloudLayout
        /// </summary>
        public static readonly WordCloudCloudLayout NORMAL = new WordCloudCloudLayout("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WordCloudCloudLayout(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WordCloudCloudLayout FindValue(string value)
        {
            return FindValue<WordCloudCloudLayout>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WordCloudCloudLayout(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WordCloudWordCasing.
    /// </summary>
    public class WordCloudWordCasing : ConstantClass
    {

        /// <summary>
        /// Constant EXISTING_CASE for WordCloudWordCasing
        /// </summary>
        public static readonly WordCloudWordCasing EXISTING_CASE = new WordCloudWordCasing("EXISTING_CASE");
        /// <summary>
        /// Constant LOWER_CASE for WordCloudWordCasing
        /// </summary>
        public static readonly WordCloudWordCasing LOWER_CASE = new WordCloudWordCasing("LOWER_CASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WordCloudWordCasing(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WordCloudWordCasing FindValue(string value)
        {
            return FindValue<WordCloudWordCasing>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WordCloudWordCasing(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WordCloudWordOrientation.
    /// </summary>
    public class WordCloudWordOrientation : ConstantClass
    {

        /// <summary>
        /// Constant HORIZONTAL for WordCloudWordOrientation
        /// </summary>
        public static readonly WordCloudWordOrientation HORIZONTAL = new WordCloudWordOrientation("HORIZONTAL");
        /// <summary>
        /// Constant HORIZONTAL_AND_VERTICAL for WordCloudWordOrientation
        /// </summary>
        public static readonly WordCloudWordOrientation HORIZONTAL_AND_VERTICAL = new WordCloudWordOrientation("HORIZONTAL_AND_VERTICAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WordCloudWordOrientation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WordCloudWordOrientation FindValue(string value)
        {
            return FindValue<WordCloudWordOrientation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WordCloudWordOrientation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WordCloudWordPadding.
    /// </summary>
    public class WordCloudWordPadding : ConstantClass
    {

        /// <summary>
        /// Constant LARGE for WordCloudWordPadding
        /// </summary>
        public static readonly WordCloudWordPadding LARGE = new WordCloudWordPadding("LARGE");
        /// <summary>
        /// Constant MEDIUM for WordCloudWordPadding
        /// </summary>
        public static readonly WordCloudWordPadding MEDIUM = new WordCloudWordPadding("MEDIUM");
        /// <summary>
        /// Constant NONE for WordCloudWordPadding
        /// </summary>
        public static readonly WordCloudWordPadding NONE = new WordCloudWordPadding("NONE");
        /// <summary>
        /// Constant SMALL for WordCloudWordPadding
        /// </summary>
        public static readonly WordCloudWordPadding SMALL = new WordCloudWordPadding("SMALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WordCloudWordPadding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WordCloudWordPadding FindValue(string value)
        {
            return FindValue<WordCloudWordPadding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WordCloudWordPadding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WordCloudWordScaling.
    /// </summary>
    public class WordCloudWordScaling : ConstantClass
    {

        /// <summary>
        /// Constant EMPHASIZE for WordCloudWordScaling
        /// </summary>
        public static readonly WordCloudWordScaling EMPHASIZE = new WordCloudWordScaling("EMPHASIZE");
        /// <summary>
        /// Constant NORMAL for WordCloudWordScaling
        /// </summary>
        public static readonly WordCloudWordScaling NORMAL = new WordCloudWordScaling("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WordCloudWordScaling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WordCloudWordScaling FindValue(string value)
        {
            return FindValue<WordCloudWordScaling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WordCloudWordScaling(string value)
        {
            return FindValue(value);
        }
    }

}