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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppRegistry
{

    /// <summary>
    /// Constants used for properties of type ApplicationTagStatus.
    /// </summary>
    public class ApplicationTagStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE for ApplicationTagStatus
        /// </summary>
        public static readonly ApplicationTagStatus FAILURE = new ApplicationTagStatus("FAILURE");
        /// <summary>
        /// Constant IN_PROGRESS for ApplicationTagStatus
        /// </summary>
        public static readonly ApplicationTagStatus IN_PROGRESS = new ApplicationTagStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for ApplicationTagStatus
        /// </summary>
        public static readonly ApplicationTagStatus SUCCESS = new ApplicationTagStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationTagStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationTagStatus FindValue(string value)
        {
            return FindValue<ApplicationTagStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationTagStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationOption.
    /// </summary>
    public class AssociationOption : ConstantClass
    {

        /// <summary>
        /// Constant APPLY_APPLICATION_TAG for AssociationOption
        /// </summary>
        public static readonly AssociationOption APPLY_APPLICATION_TAG = new AssociationOption("APPLY_APPLICATION_TAG");
        /// <summary>
        /// Constant SKIP_APPLICATION_TAG for AssociationOption
        /// </summary>
        public static readonly AssociationOption SKIP_APPLICATION_TAG = new AssociationOption("SKIP_APPLICATION_TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationOption FindValue(string value)
        {
            return FindValue<AssociationOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceGroupState.
    /// </summary>
    public class ResourceGroupState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for ResourceGroupState
        /// </summary>
        public static readonly ResourceGroupState CREATE_COMPLETE = new ResourceGroupState("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for ResourceGroupState
        /// </summary>
        public static readonly ResourceGroupState CREATE_FAILED = new ResourceGroupState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for ResourceGroupState
        /// </summary>
        public static readonly ResourceGroupState CREATING = new ResourceGroupState("CREATING");
        /// <summary>
        /// Constant UPDATE_COMPLETE for ResourceGroupState
        /// </summary>
        public static readonly ResourceGroupState UPDATE_COMPLETE = new ResourceGroupState("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for ResourceGroupState
        /// </summary>
        public static readonly ResourceGroupState UPDATE_FAILED = new ResourceGroupState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ResourceGroupState
        /// </summary>
        public static readonly ResourceGroupState UPDATING = new ResourceGroupState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceGroupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceGroupState FindValue(string value)
        {
            return FindValue<ResourceGroupState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceGroupState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceItemStatus.
    /// </summary>
    public class ResourceItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ResourceItemStatus
        /// </summary>
        public static readonly ResourceItemStatus FAILED = new ResourceItemStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ResourceItemStatus
        /// </summary>
        public static readonly ResourceItemStatus IN_PROGRESS = new ResourceItemStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SKIPPED for ResourceItemStatus
        /// </summary>
        public static readonly ResourceItemStatus SKIPPED = new ResourceItemStatus("SKIPPED");
        /// <summary>
        /// Constant SUCCESS for ResourceItemStatus
        /// </summary>
        public static readonly ResourceItemStatus SUCCESS = new ResourceItemStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceItemStatus FindValue(string value)
        {
            return FindValue<ResourceItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceItemStatus(string value)
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
        /// Constant CFN_STACK for ResourceType
        /// </summary>
        public static readonly ResourceType CFN_STACK = new ResourceType("CFN_STACK");
        /// <summary>
        /// Constant RESOURCE_TAG_VALUE for ResourceType
        /// </summary>
        public static readonly ResourceType RESOURCE_TAG_VALUE = new ResourceType("RESOURCE_TAG_VALUE");

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
    /// Constants used for properties of type SyncAction.
    /// </summary>
    public class SyncAction : ConstantClass
    {

        /// <summary>
        /// Constant NO_ACTION for SyncAction
        /// </summary>
        public static readonly SyncAction NO_ACTION = new SyncAction("NO_ACTION");
        /// <summary>
        /// Constant START_SYNC for SyncAction
        /// </summary>
        public static readonly SyncAction START_SYNC = new SyncAction("START_SYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyncAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyncAction FindValue(string value)
        {
            return FindValue<SyncAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyncAction(string value)
        {
            return FindValue(value);
        }
    }

}