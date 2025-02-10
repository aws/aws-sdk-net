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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BackupSearch
{

    /// <summary>
    /// Constants used for properties of type ExportJobStatus.
    /// </summary>
    public class ExportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ExportJobStatus
        /// </summary>
        public static readonly ExportJobStatus COMPLETED = new ExportJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ExportJobStatus
        /// </summary>
        public static readonly ExportJobStatus FAILED = new ExportJobStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ExportJobStatus
        /// </summary>
        public static readonly ExportJobStatus RUNNING = new ExportJobStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportJobStatus FindValue(string value)
        {
            return FindValue<ExportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LongConditionOperator.
    /// </summary>
    public class LongConditionOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS_TO for LongConditionOperator
        /// </summary>
        public static readonly LongConditionOperator EQUALS_TO = new LongConditionOperator("EQUALS_TO");
        /// <summary>
        /// Constant GREATER_THAN_EQUAL_TO for LongConditionOperator
        /// </summary>
        public static readonly LongConditionOperator GREATER_THAN_EQUAL_TO = new LongConditionOperator("GREATER_THAN_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN_EQUAL_TO for LongConditionOperator
        /// </summary>
        public static readonly LongConditionOperator LESS_THAN_EQUAL_TO = new LongConditionOperator("LESS_THAN_EQUAL_TO");
        /// <summary>
        /// Constant NOT_EQUALS_TO for LongConditionOperator
        /// </summary>
        public static readonly LongConditionOperator NOT_EQUALS_TO = new LongConditionOperator("NOT_EQUALS_TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LongConditionOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LongConditionOperator FindValue(string value)
        {
            return FindValue<LongConditionOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LongConditionOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant EBS for ResourceType
        /// </summary>
        public static readonly ResourceType EBS = new ResourceType("EBS");
        /// <summary>
        /// Constant S3 for ResourceType
        /// </summary>
        public static readonly ResourceType S3 = new ResourceType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchJobState.
    /// </summary>
    public class SearchJobState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SearchJobState
        /// </summary>
        public static readonly SearchJobState COMPLETED = new SearchJobState("COMPLETED");
        /// <summary>
        /// Constant FAILED for SearchJobState
        /// </summary>
        public static readonly SearchJobState FAILED = new SearchJobState("FAILED");
        /// <summary>
        /// Constant RUNNING for SearchJobState
        /// </summary>
        public static readonly SearchJobState RUNNING = new SearchJobState("RUNNING");
        /// <summary>
        /// Constant STOPPED for SearchJobState
        /// </summary>
        public static readonly SearchJobState STOPPED = new SearchJobState("STOPPED");
        /// <summary>
        /// Constant STOPPING for SearchJobState
        /// </summary>
        public static readonly SearchJobState STOPPING = new SearchJobState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchJobState FindValue(string value)
        {
            return FindValue<SearchJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchJobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StringConditionOperator.
    /// </summary>
    public class StringConditionOperator : ConstantClass
    {

        /// <summary>
        /// Constant BEGINS_WITH for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator BEGINS_WITH = new StringConditionOperator("BEGINS_WITH");
        /// <summary>
        /// Constant CONTAINS for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator CONTAINS = new StringConditionOperator("CONTAINS");
        /// <summary>
        /// Constant DOES_NOT_BEGIN_WITH for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator DOES_NOT_BEGIN_WITH = new StringConditionOperator("DOES_NOT_BEGIN_WITH");
        /// <summary>
        /// Constant DOES_NOT_CONTAIN for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator DOES_NOT_CONTAIN = new StringConditionOperator("DOES_NOT_CONTAIN");
        /// <summary>
        /// Constant DOES_NOT_END_WITH for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator DOES_NOT_END_WITH = new StringConditionOperator("DOES_NOT_END_WITH");
        /// <summary>
        /// Constant ENDS_WITH for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator ENDS_WITH = new StringConditionOperator("ENDS_WITH");
        /// <summary>
        /// Constant EQUALS_TO for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator EQUALS_TO = new StringConditionOperator("EQUALS_TO");
        /// <summary>
        /// Constant NOT_EQUALS_TO for StringConditionOperator
        /// </summary>
        public static readonly StringConditionOperator NOT_EQUALS_TO = new StringConditionOperator("NOT_EQUALS_TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringConditionOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringConditionOperator FindValue(string value)
        {
            return FindValue<StringConditionOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringConditionOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeConditionOperator.
    /// </summary>
    public class TimeConditionOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS_TO for TimeConditionOperator
        /// </summary>
        public static readonly TimeConditionOperator EQUALS_TO = new TimeConditionOperator("EQUALS_TO");
        /// <summary>
        /// Constant GREATER_THAN_EQUAL_TO for TimeConditionOperator
        /// </summary>
        public static readonly TimeConditionOperator GREATER_THAN_EQUAL_TO = new TimeConditionOperator("GREATER_THAN_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN_EQUAL_TO for TimeConditionOperator
        /// </summary>
        public static readonly TimeConditionOperator LESS_THAN_EQUAL_TO = new TimeConditionOperator("LESS_THAN_EQUAL_TO");
        /// <summary>
        /// Constant NOT_EQUALS_TO for TimeConditionOperator
        /// </summary>
        public static readonly TimeConditionOperator NOT_EQUALS_TO = new TimeConditionOperator("NOT_EQUALS_TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeConditionOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeConditionOperator FindValue(string value)
        {
            return FindValue<TimeConditionOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeConditionOperator(string value)
        {
            return FindValue(value);
        }
    }

}