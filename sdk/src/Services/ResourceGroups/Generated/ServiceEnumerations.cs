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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ResourceGroups
{

    /// <summary>
    /// Constants used for properties of type GroupConfigurationStatus.
    /// </summary>
    public class GroupConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant UPDATE_COMPLETE for GroupConfigurationStatus
        /// </summary>
        public static readonly GroupConfigurationStatus UPDATE_COMPLETE = new GroupConfigurationStatus("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for GroupConfigurationStatus
        /// </summary>
        public static readonly GroupConfigurationStatus UPDATE_FAILED = new GroupConfigurationStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for GroupConfigurationStatus
        /// </summary>
        public static readonly GroupConfigurationStatus UPDATING = new GroupConfigurationStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupConfigurationStatus FindValue(string value)
        {
            return FindValue<GroupConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupFilterName.
    /// </summary>
    public class GroupFilterName : ConstantClass
    {

        /// <summary>
        /// Constant ConfigurationType for GroupFilterName
        /// </summary>
        public static readonly GroupFilterName ConfigurationType = new GroupFilterName("configuration-type");
        /// <summary>
        /// Constant ResourceType for GroupFilterName
        /// </summary>
        public static readonly GroupFilterName ResourceType = new GroupFilterName("resource-type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupFilterName FindValue(string value)
        {
            return FindValue<GroupFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupLifecycleEventsDesiredStatus.
    /// </summary>
    public class GroupLifecycleEventsDesiredStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GroupLifecycleEventsDesiredStatus
        /// </summary>
        public static readonly GroupLifecycleEventsDesiredStatus ACTIVE = new GroupLifecycleEventsDesiredStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for GroupLifecycleEventsDesiredStatus
        /// </summary>
        public static readonly GroupLifecycleEventsDesiredStatus INACTIVE = new GroupLifecycleEventsDesiredStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupLifecycleEventsDesiredStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupLifecycleEventsDesiredStatus FindValue(string value)
        {
            return FindValue<GroupLifecycleEventsDesiredStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupLifecycleEventsDesiredStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupLifecycleEventsStatus.
    /// </summary>
    public class GroupLifecycleEventsStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GroupLifecycleEventsStatus
        /// </summary>
        public static readonly GroupLifecycleEventsStatus ACTIVE = new GroupLifecycleEventsStatus("ACTIVE");
        /// <summary>
        /// Constant ERROR for GroupLifecycleEventsStatus
        /// </summary>
        public static readonly GroupLifecycleEventsStatus ERROR = new GroupLifecycleEventsStatus("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for GroupLifecycleEventsStatus
        /// </summary>
        public static readonly GroupLifecycleEventsStatus IN_PROGRESS = new GroupLifecycleEventsStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INACTIVE for GroupLifecycleEventsStatus
        /// </summary>
        public static readonly GroupLifecycleEventsStatus INACTIVE = new GroupLifecycleEventsStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupLifecycleEventsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupLifecycleEventsStatus FindValue(string value)
        {
            return FindValue<GroupLifecycleEventsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupLifecycleEventsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryErrorCode.
    /// </summary>
    public class QueryErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDFORMATION_STACK_INACTIVE for QueryErrorCode
        /// </summary>
        public static readonly QueryErrorCode CLOUDFORMATION_STACK_INACTIVE = new QueryErrorCode("CLOUDFORMATION_STACK_INACTIVE");
        /// <summary>
        /// Constant CLOUDFORMATION_STACK_NOT_EXISTING for QueryErrorCode
        /// </summary>
        public static readonly QueryErrorCode CLOUDFORMATION_STACK_NOT_EXISTING = new QueryErrorCode("CLOUDFORMATION_STACK_NOT_EXISTING");
        /// <summary>
        /// Constant CLOUDFORMATION_STACK_UNASSUMABLE_ROLE for QueryErrorCode
        /// </summary>
        public static readonly QueryErrorCode CLOUDFORMATION_STACK_UNASSUMABLE_ROLE = new QueryErrorCode("CLOUDFORMATION_STACK_UNASSUMABLE_ROLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryErrorCode FindValue(string value)
        {
            return FindValue<QueryErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryType.
    /// </summary>
    public class QueryType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDFORMATION_STACK_1_0 for QueryType
        /// </summary>
        public static readonly QueryType CLOUDFORMATION_STACK_1_0 = new QueryType("CLOUDFORMATION_STACK_1_0");
        /// <summary>
        /// Constant TAG_FILTERS_1_0 for QueryType
        /// </summary>
        public static readonly QueryType TAG_FILTERS_1_0 = new QueryType("TAG_FILTERS_1_0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryType FindValue(string value)
        {
            return FindValue<QueryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceFilterName.
    /// </summary>
    public class ResourceFilterName : ConstantClass
    {

        /// <summary>
        /// Constant ResourceType for ResourceFilterName
        /// </summary>
        public static readonly ResourceFilterName ResourceType = new ResourceFilterName("resource-type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceFilterName FindValue(string value)
        {
            return FindValue<ResourceFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatusValue.
    /// </summary>
    public class ResourceStatusValue : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for ResourceStatusValue
        /// </summary>
        public static readonly ResourceStatusValue PENDING = new ResourceStatusValue("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatusValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatusValue FindValue(string value)
        {
            return FindValue<ResourceStatusValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatusValue(string value)
        {
            return FindValue(value);
        }
    }

}