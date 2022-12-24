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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LicenseManagerLinuxSubscriptions
{

    /// <summary>
    /// Constants used for properties of type LinuxSubscriptionsDiscovery.
    /// </summary>
    public class LinuxSubscriptionsDiscovery : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for LinuxSubscriptionsDiscovery
        /// </summary>
        public static readonly LinuxSubscriptionsDiscovery Disabled = new LinuxSubscriptionsDiscovery("Disabled");
        /// <summary>
        /// Constant Enabled for LinuxSubscriptionsDiscovery
        /// </summary>
        public static readonly LinuxSubscriptionsDiscovery Enabled = new LinuxSubscriptionsDiscovery("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LinuxSubscriptionsDiscovery(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LinuxSubscriptionsDiscovery FindValue(string value)
        {
            return FindValue<LinuxSubscriptionsDiscovery>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LinuxSubscriptionsDiscovery(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant Contains for Operator
        /// </summary>
        public static readonly Operator Contains = new Operator("Contains");
        /// <summary>
        /// Constant Equal for Operator
        /// </summary>
        public static readonly Operator Equal = new Operator("Equal");
        /// <summary>
        /// Constant NotEqual for Operator
        /// </summary>
        public static readonly Operator NotEqual = new Operator("NotEqual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationIntegration.
    /// </summary>
    public class OrganizationIntegration : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for OrganizationIntegration
        /// </summary>
        public static readonly OrganizationIntegration Disabled = new OrganizationIntegration("Disabled");
        /// <summary>
        /// Constant Enabled for OrganizationIntegration
        /// </summary>
        public static readonly OrganizationIntegration Enabled = new OrganizationIntegration("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationIntegration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationIntegration FindValue(string value)
        {
            return FindValue<OrganizationIntegration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationIntegration(string value)
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
        /// Constant Completed for Status
        /// </summary>
        public static readonly Status Completed = new Status("Completed");
        /// <summary>
        /// Constant Failed for Status
        /// </summary>
        public static readonly Status Failed = new Status("Failed");
        /// <summary>
        /// Constant InProgress for Status
        /// </summary>
        public static readonly Status InProgress = new Status("InProgress");
        /// <summary>
        /// Constant Successful for Status
        /// </summary>
        public static readonly Status Successful = new Status("Successful");

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