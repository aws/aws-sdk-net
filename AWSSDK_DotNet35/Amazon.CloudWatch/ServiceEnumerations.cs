/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.CloudWatch
{


    /// <summary>Comparison Operator
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {


       /// <summary>Constant GreaterThanOrEqualToThreshold for ComparisonOperator
       /// </summary>
        public static readonly ComparisonOperator GreaterThanOrEqualToThreshold = new ComparisonOperator("GreaterThanOrEqualToThreshold");
    

       /// <summary>Constant GreaterThanThreshold for ComparisonOperator
       /// </summary>
        public static readonly ComparisonOperator GreaterThanThreshold = new ComparisonOperator("GreaterThanThreshold");
    

       /// <summary>Constant LessThanOrEqualToThreshold for ComparisonOperator
       /// </summary>
        public static readonly ComparisonOperator LessThanOrEqualToThreshold = new ComparisonOperator("LessThanOrEqualToThreshold");
    

       /// <summary>Constant LessThanThreshold for ComparisonOperator
       /// </summary>
        public static readonly ComparisonOperator LessThanThreshold = new ComparisonOperator("LessThanThreshold");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>History Item Type
    /// </summary>
    public class HistoryItemType : ConstantClass
    {


       /// <summary>Constant Action for HistoryItemType
       /// </summary>
        public static readonly HistoryItemType Action = new HistoryItemType("Action");
    

       /// <summary>Constant ConfigurationUpdate for HistoryItemType
       /// </summary>
        public static readonly HistoryItemType ConfigurationUpdate = new HistoryItemType("ConfigurationUpdate");
    

       /// <summary>Constant StateUpdate for HistoryItemType
       /// </summary>
        public static readonly HistoryItemType StateUpdate = new HistoryItemType("StateUpdate");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public HistoryItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HistoryItemType FindValue(string value)
        {
            return FindValue<HistoryItemType>(value);
        }

        public static implicit operator HistoryItemType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Standard Unit
    /// </summary>
    public class StandardUnit : ConstantClass
    {


       /// <summary>Constant Bits for StandardUnit
       /// </summary>
        public static readonly StandardUnit Bits = new StandardUnit("Bits");
    

       /// <summary>Constant BitsSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit BitsSecond = new StandardUnit("Bits/Second");
    

       /// <summary>Constant Bytes for StandardUnit
       /// </summary>
        public static readonly StandardUnit Bytes = new StandardUnit("Bytes");
    

       /// <summary>Constant BytesSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit BytesSecond = new StandardUnit("Bytes/Second");
    

       /// <summary>Constant Count for StandardUnit
       /// </summary>
        public static readonly StandardUnit Count = new StandardUnit("Count");
    

       /// <summary>Constant CountSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit CountSecond = new StandardUnit("Count/Second");
    

       /// <summary>Constant Gigabits for StandardUnit
       /// </summary>
        public static readonly StandardUnit Gigabits = new StandardUnit("Gigabits");
    

       /// <summary>Constant GigabitsSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit GigabitsSecond = new StandardUnit("Gigabits/Second");
    

       /// <summary>Constant Gigabytes for StandardUnit
       /// </summary>
        public static readonly StandardUnit Gigabytes = new StandardUnit("Gigabytes");
    

       /// <summary>Constant GigabytesSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit GigabytesSecond = new StandardUnit("Gigabytes/Second");
    

       /// <summary>Constant Kilobits for StandardUnit
       /// </summary>
        public static readonly StandardUnit Kilobits = new StandardUnit("Kilobits");
    

       /// <summary>Constant KilobitsSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit KilobitsSecond = new StandardUnit("Kilobits/Second");
    

       /// <summary>Constant Kilobytes for StandardUnit
       /// </summary>
        public static readonly StandardUnit Kilobytes = new StandardUnit("Kilobytes");
    

       /// <summary>Constant KilobytesSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit KilobytesSecond = new StandardUnit("Kilobytes/Second");
    

       /// <summary>Constant Megabits for StandardUnit
       /// </summary>
        public static readonly StandardUnit Megabits = new StandardUnit("Megabits");
    

       /// <summary>Constant MegabitsSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit MegabitsSecond = new StandardUnit("Megabits/Second");
    

       /// <summary>Constant Megabytes for StandardUnit
       /// </summary>
        public static readonly StandardUnit Megabytes = new StandardUnit("Megabytes");
    

       /// <summary>Constant MegabytesSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit MegabytesSecond = new StandardUnit("Megabytes/Second");
    

       /// <summary>Constant Microseconds for StandardUnit
       /// </summary>
        public static readonly StandardUnit Microseconds = new StandardUnit("Microseconds");
    

       /// <summary>Constant Milliseconds for StandardUnit
       /// </summary>
        public static readonly StandardUnit Milliseconds = new StandardUnit("Milliseconds");
    

       /// <summary>Constant None for StandardUnit
       /// </summary>
        public static readonly StandardUnit None = new StandardUnit("None");
    

       /// <summary>Constant Percent for StandardUnit
       /// </summary>
        public static readonly StandardUnit Percent = new StandardUnit("Percent");
    

       /// <summary>Constant Seconds for StandardUnit
       /// </summary>
        public static readonly StandardUnit Seconds = new StandardUnit("Seconds");
    

       /// <summary>Constant Terabits for StandardUnit
       /// </summary>
        public static readonly StandardUnit Terabits = new StandardUnit("Terabits");
    

       /// <summary>Constant TerabitsSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit TerabitsSecond = new StandardUnit("Terabits/Second");
    

       /// <summary>Constant Terabytes for StandardUnit
       /// </summary>
        public static readonly StandardUnit Terabytes = new StandardUnit("Terabytes");
    

       /// <summary>Constant TerabytesSecond for StandardUnit
       /// </summary>
        public static readonly StandardUnit TerabytesSecond = new StandardUnit("Terabytes/Second");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StandardUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardUnit FindValue(string value)
        {
            return FindValue<StandardUnit>(value);
        }

        public static implicit operator StandardUnit(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>State Value
    /// </summary>
    public class StateValue : ConstantClass
    {


       /// <summary>Constant ALARM for StateValue
       /// </summary>
        public static readonly StateValue ALARM = new StateValue("ALARM");
    

       /// <summary>Constant INSUFFICIENT_DATA for StateValue
       /// </summary>
        public static readonly StateValue INSUFFICIENT_DATA = new StateValue("INSUFFICIENT_DATA");
    

       /// <summary>Constant OK for StateValue
       /// </summary>
        public static readonly StateValue OK = new StateValue("OK");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StateValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateValue FindValue(string value)
        {
            return FindValue<StateValue>(value);
        }

        public static implicit operator StateValue(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Statistic
    /// </summary>
    public class Statistic : ConstantClass
    {


       /// <summary>Constant Average for Statistic
       /// </summary>
        public static readonly Statistic Average = new Statistic("Average");
    

       /// <summary>Constant Maximum for Statistic
       /// </summary>
        public static readonly Statistic Maximum = new Statistic("Maximum");
    

       /// <summary>Constant Minimum for Statistic
       /// </summary>
        public static readonly Statistic Minimum = new Statistic("Minimum");
    

       /// <summary>Constant SampleCount for Statistic
       /// </summary>
        public static readonly Statistic SampleCount = new Statistic("SampleCount");
    

       /// <summary>Constant Sum for Statistic
       /// </summary>
        public static readonly Statistic Sum = new Statistic("Sum");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Statistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Statistic FindValue(string value)
        {
            return FindValue<Statistic>(value);
        }

        public static implicit operator Statistic(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
