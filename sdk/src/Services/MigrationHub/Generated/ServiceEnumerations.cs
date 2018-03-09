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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MigrationHub
{

    /// <summary>
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus COMPLETED = new ApplicationStatus("COMPLETED");
        /// <summary>
        /// Constant IN_PROGRESS for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus IN_PROGRESS = new ApplicationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus NOT_STARTED = new ApplicationStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceAttributeType.
    /// </summary>
    public class ResourceAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant BIOS_ID for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType BIOS_ID = new ResourceAttributeType("BIOS_ID");
        /// <summary>
        /// Constant FQDN for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType FQDN = new ResourceAttributeType("FQDN");
        /// <summary>
        /// Constant IPV4_ADDRESS for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType IPV4_ADDRESS = new ResourceAttributeType("IPV4_ADDRESS");
        /// <summary>
        /// Constant IPV6_ADDRESS for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType IPV6_ADDRESS = new ResourceAttributeType("IPV6_ADDRESS");
        /// <summary>
        /// Constant MAC_ADDRESS for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType MAC_ADDRESS = new ResourceAttributeType("MAC_ADDRESS");
        /// <summary>
        /// Constant MOTHERBOARD_SERIAL_NUMBER for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType MOTHERBOARD_SERIAL_NUMBER = new ResourceAttributeType("MOTHERBOARD_SERIAL_NUMBER");
        /// <summary>
        /// Constant VM_MANAGED_OBJECT_REFERENCE for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType VM_MANAGED_OBJECT_REFERENCE = new ResourceAttributeType("VM_MANAGED_OBJECT_REFERENCE");
        /// <summary>
        /// Constant VM_MANAGER_ID for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType VM_MANAGER_ID = new ResourceAttributeType("VM_MANAGER_ID");
        /// <summary>
        /// Constant VM_NAME for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType VM_NAME = new ResourceAttributeType("VM_NAME");
        /// <summary>
        /// Constant VM_PATH for ResourceAttributeType
        /// </summary>
        public static readonly ResourceAttributeType VM_PATH = new ResourceAttributeType("VM_PATH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceAttributeType FindValue(string value)
        {
            return FindValue<ResourceAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceAttributeType(string value)
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
        /// Constant COMPLETED for Status
        /// </summary>
        public static readonly Status COMPLETED = new Status("COMPLETED");
        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for Status
        /// </summary>
        public static readonly Status IN_PROGRESS = new Status("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for Status
        /// </summary>
        public static readonly Status NOT_STARTED = new Status("NOT_STARTED");

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

}