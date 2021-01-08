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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudTrail
{

    /// <summary>
    /// Constants used for properties of type EventCategory.
    /// </summary>
    public class EventCategory : ConstantClass
    {

        /// <summary>
        /// Constant Insight for EventCategory
        /// </summary>
        public static readonly EventCategory Insight = new EventCategory("insight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventCategory FindValue(string value)
        {
            return FindValue<EventCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightType.
    /// </summary>
    public class InsightType : ConstantClass
    {

        /// <summary>
        /// Constant ApiCallRateInsight for InsightType
        /// </summary>
        public static readonly InsightType ApiCallRateInsight = new InsightType("ApiCallRateInsight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightType FindValue(string value)
        {
            return FindValue<InsightType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LookupAttributeKey.
    /// </summary>
    public class LookupAttributeKey : ConstantClass
    {

        /// <summary>
        /// Constant AccessKeyId for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey AccessKeyId = new LookupAttributeKey("AccessKeyId");
        /// <summary>
        /// Constant EventId for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventId = new LookupAttributeKey("EventId");
        /// <summary>
        /// Constant EventName for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventName = new LookupAttributeKey("EventName");
        /// <summary>
        /// Constant EventSource for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventSource = new LookupAttributeKey("EventSource");
        /// <summary>
        /// Constant ReadOnly for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ReadOnly = new LookupAttributeKey("ReadOnly");
        /// <summary>
        /// Constant ResourceName for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ResourceName = new LookupAttributeKey("ResourceName");
        /// <summary>
        /// Constant ResourceType for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ResourceType = new LookupAttributeKey("ResourceType");
        /// <summary>
        /// Constant Username for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey Username = new LookupAttributeKey("Username");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LookupAttributeKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LookupAttributeKey FindValue(string value)
        {
            return FindValue<LookupAttributeKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LookupAttributeKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadWriteType.
    /// </summary>
    public class ReadWriteType : ConstantClass
    {

        /// <summary>
        /// Constant All for ReadWriteType
        /// </summary>
        public static readonly ReadWriteType All = new ReadWriteType("All");
        /// <summary>
        /// Constant ReadOnly for ReadWriteType
        /// </summary>
        public static readonly ReadWriteType ReadOnly = new ReadWriteType("ReadOnly");
        /// <summary>
        /// Constant WriteOnly for ReadWriteType
        /// </summary>
        public static readonly ReadWriteType WriteOnly = new ReadWriteType("WriteOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadWriteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadWriteType FindValue(string value)
        {
            return FindValue<ReadWriteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadWriteType(string value)
        {
            return FindValue(value);
        }
    }

}