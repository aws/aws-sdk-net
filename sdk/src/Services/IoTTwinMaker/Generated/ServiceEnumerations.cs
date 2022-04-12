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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTTwinMaker
{

    /// <summary>
    /// Constants used for properties of type ComponentUpdateType.
    /// </summary>
    public class ComponentUpdateType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for ComponentUpdateType
        /// </summary>
        public static readonly ComponentUpdateType CREATE = new ComponentUpdateType("CREATE");
        /// <summary>
        /// Constant DELETE for ComponentUpdateType
        /// </summary>
        public static readonly ComponentUpdateType DELETE = new ComponentUpdateType("DELETE");
        /// <summary>
        /// Constant UPDATE for ComponentUpdateType
        /// </summary>
        public static readonly ComponentUpdateType UPDATE = new ComponentUpdateType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentUpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentUpdateType FindValue(string value)
        {
            return FindValue<ComponentUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentUpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_FAILURE = new ErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant VALIDATION_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode VALIDATION_ERROR = new ErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InterpolationType.
    /// </summary>
    public class InterpolationType : ConstantClass
    {

        /// <summary>
        /// Constant LINEAR for InterpolationType
        /// </summary>
        public static readonly InterpolationType LINEAR = new InterpolationType("LINEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InterpolationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InterpolationType FindValue(string value)
        {
            return FindValue<InterpolationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InterpolationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderByTime.
    /// </summary>
    public class OrderByTime : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for OrderByTime
        /// </summary>
        public static readonly OrderByTime ASCENDING = new OrderByTime("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for OrderByTime
        /// </summary>
        public static readonly OrderByTime DESCENDING = new OrderByTime("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderByTime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderByTime FindValue(string value)
        {
            return FindValue<OrderByTime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderByTime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParentEntityUpdateType.
    /// </summary>
    public class ParentEntityUpdateType : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for ParentEntityUpdateType
        /// </summary>
        public static readonly ParentEntityUpdateType DELETE = new ParentEntityUpdateType("DELETE");
        /// <summary>
        /// Constant UPDATE for ParentEntityUpdateType
        /// </summary>
        public static readonly ParentEntityUpdateType UPDATE = new ParentEntityUpdateType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParentEntityUpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParentEntityUpdateType FindValue(string value)
        {
            return FindValue<ParentEntityUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParentEntityUpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PropertyUpdateType.
    /// </summary>
    public class PropertyUpdateType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for PropertyUpdateType
        /// </summary>
        public static readonly PropertyUpdateType CREATE = new PropertyUpdateType("CREATE");
        /// <summary>
        /// Constant DELETE for PropertyUpdateType
        /// </summary>
        public static readonly PropertyUpdateType DELETE = new PropertyUpdateType("DELETE");
        /// <summary>
        /// Constant UPDATE for PropertyUpdateType
        /// </summary>
        public static readonly PropertyUpdateType UPDATE = new PropertyUpdateType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PropertyUpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PropertyUpdateType FindValue(string value)
        {
            return FindValue<PropertyUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PropertyUpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scope.
    /// </summary>
    public class Scope : ConstantClass
    {

        /// <summary>
        /// Constant ENTITY for Scope
        /// </summary>
        public static readonly Scope ENTITY = new Scope("ENTITY");
        /// <summary>
        /// Constant WORKSPACE for Scope
        /// </summary>
        public static readonly Scope WORKSPACE = new Scope("WORKSPACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scope FindValue(string value)
        {
            return FindValue<Scope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for State
        /// </summary>
        public static readonly State ACTIVE = new State("ACTIVE");
        /// <summary>
        /// Constant CREATING for State
        /// </summary>
        public static readonly State CREATING = new State("CREATING");
        /// <summary>
        /// Constant DELETING for State
        /// </summary>
        public static readonly State DELETING = new State("DELETING");
        /// <summary>
        /// Constant ERROR for State
        /// </summary>
        public static readonly State ERROR = new State("ERROR");
        /// <summary>
        /// Constant UPDATING for State
        /// </summary>
        public static readonly State UPDATING = new State("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for Type
        /// </summary>
        public static readonly Type BOOLEAN = new Type("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for Type
        /// </summary>
        public static readonly Type DOUBLE = new Type("DOUBLE");
        /// <summary>
        /// Constant INTEGER for Type
        /// </summary>
        public static readonly Type INTEGER = new Type("INTEGER");
        /// <summary>
        /// Constant LIST for Type
        /// </summary>
        public static readonly Type LIST = new Type("LIST");
        /// <summary>
        /// Constant LONG for Type
        /// </summary>
        public static readonly Type LONG = new Type("LONG");
        /// <summary>
        /// Constant MAP for Type
        /// </summary>
        public static readonly Type MAP = new Type("MAP");
        /// <summary>
        /// Constant RELATIONSHIP for Type
        /// </summary>
        public static readonly Type RELATIONSHIP = new Type("RELATIONSHIP");
        /// <summary>
        /// Constant STRING for Type
        /// </summary>
        public static readonly Type STRING = new Type("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}