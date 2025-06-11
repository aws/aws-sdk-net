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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ControlCatalog
{

    /// <summary>
    /// Constants used for properties of type ControlBehavior.
    /// </summary>
    public class ControlBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DETECTIVE for ControlBehavior
        /// </summary>
        public static readonly ControlBehavior DETECTIVE = new ControlBehavior("DETECTIVE");
        /// <summary>
        /// Constant PREVENTIVE for ControlBehavior
        /// </summary>
        public static readonly ControlBehavior PREVENTIVE = new ControlBehavior("PREVENTIVE");
        /// <summary>
        /// Constant PROACTIVE for ControlBehavior
        /// </summary>
        public static readonly ControlBehavior PROACTIVE = new ControlBehavior("PROACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlBehavior FindValue(string value)
        {
            return FindValue<ControlBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlScope.
    /// </summary>
    public class ControlScope : ConstantClass
    {

        /// <summary>
        /// Constant GLOBAL for ControlScope
        /// </summary>
        public static readonly ControlScope GLOBAL = new ControlScope("GLOBAL");
        /// <summary>
        /// Constant REGIONAL for ControlScope
        /// </summary>
        public static readonly ControlScope REGIONAL = new ControlScope("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlScope FindValue(string value)
        {
            return FindValue<ControlScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlSeverity.
    /// </summary>
    public class ControlSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for ControlSeverity
        /// </summary>
        public static readonly ControlSeverity CRITICAL = new ControlSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for ControlSeverity
        /// </summary>
        public static readonly ControlSeverity HIGH = new ControlSeverity("HIGH");
        /// <summary>
        /// Constant LOW for ControlSeverity
        /// </summary>
        public static readonly ControlSeverity LOW = new ControlSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for ControlSeverity
        /// </summary>
        public static readonly ControlSeverity MEDIUM = new ControlSeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlSeverity FindValue(string value)
        {
            return FindValue<ControlSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MappingType.
    /// </summary>
    public class MappingType : ConstantClass
    {

        /// <summary>
        /// Constant COMMON_CONTROL for MappingType
        /// </summary>
        public static readonly MappingType COMMON_CONTROL = new MappingType("COMMON_CONTROL");
        /// <summary>
        /// Constant FRAMEWORK for MappingType
        /// </summary>
        public static readonly MappingType FRAMEWORK = new MappingType("FRAMEWORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MappingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MappingType FindValue(string value)
        {
            return FindValue<MappingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MappingType(string value)
        {
            return FindValue(value);
        }
    }

}