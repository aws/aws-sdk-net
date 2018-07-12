/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DLM
{

    /// <summary>
    /// Constants used for properties of type GettablePolicyStateValues.
    /// </summary>
    public class GettablePolicyStateValues : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GettablePolicyStateValues
        /// </summary>
        public static readonly GettablePolicyStateValues DISABLED = new GettablePolicyStateValues("DISABLED");
        /// <summary>
        /// Constant ENABLED for GettablePolicyStateValues
        /// </summary>
        public static readonly GettablePolicyStateValues ENABLED = new GettablePolicyStateValues("ENABLED");
        /// <summary>
        /// Constant ERROR for GettablePolicyStateValues
        /// </summary>
        public static readonly GettablePolicyStateValues ERROR = new GettablePolicyStateValues("ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GettablePolicyStateValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GettablePolicyStateValues FindValue(string value)
        {
            return FindValue<GettablePolicyStateValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GettablePolicyStateValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntervalUnitValues.
    /// </summary>
    public class IntervalUnitValues : ConstantClass
    {

        /// <summary>
        /// Constant HOURS for IntervalUnitValues
        /// </summary>
        public static readonly IntervalUnitValues HOURS = new IntervalUnitValues("HOURS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntervalUnitValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntervalUnitValues FindValue(string value)
        {
            return FindValue<IntervalUnitValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntervalUnitValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceTypeValues.
    /// </summary>
    public class ResourceTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant VOLUME for ResourceTypeValues
        /// </summary>
        public static readonly ResourceTypeValues VOLUME = new ResourceTypeValues("VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceTypeValues FindValue(string value)
        {
            return FindValue<ResourceTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SettablePolicyStateValues.
    /// </summary>
    public class SettablePolicyStateValues : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SettablePolicyStateValues
        /// </summary>
        public static readonly SettablePolicyStateValues DISABLED = new SettablePolicyStateValues("DISABLED");
        /// <summary>
        /// Constant ENABLED for SettablePolicyStateValues
        /// </summary>
        public static readonly SettablePolicyStateValues ENABLED = new SettablePolicyStateValues("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SettablePolicyStateValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SettablePolicyStateValues FindValue(string value)
        {
            return FindValue<SettablePolicyStateValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SettablePolicyStateValues(string value)
        {
            return FindValue(value);
        }
    }

}