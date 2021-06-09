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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Proton
{

    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus CANCELLED = new DeploymentStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus CANCELLING = new DeploymentStatus("CANCELLING");
        /// <summary>
        /// Constant DELETE_COMPLETE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DELETE_COMPLETE = new DeploymentStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DELETE_FAILED = new DeploymentStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DELETE_IN_PROGRESS = new DeploymentStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus FAILED = new DeploymentStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus IN_PROGRESS = new DeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus SUCCEEDED = new DeploymentStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentUpdateType.
    /// </summary>
    public class DeploymentUpdateType : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT_VERSION for DeploymentUpdateType
        /// </summary>
        public static readonly DeploymentUpdateType CURRENT_VERSION = new DeploymentUpdateType("CURRENT_VERSION");
        /// <summary>
        /// Constant MAJOR_VERSION for DeploymentUpdateType
        /// </summary>
        public static readonly DeploymentUpdateType MAJOR_VERSION = new DeploymentUpdateType("MAJOR_VERSION");
        /// <summary>
        /// Constant MINOR_VERSION for DeploymentUpdateType
        /// </summary>
        public static readonly DeploymentUpdateType MINOR_VERSION = new DeploymentUpdateType("MINOR_VERSION");
        /// <summary>
        /// Constant NONE for DeploymentUpdateType
        /// </summary>
        public static readonly DeploymentUpdateType NONE = new DeploymentUpdateType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentUpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentUpdateType FindValue(string value)
        {
            return FindValue<DeploymentUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentUpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentAccountConnectionRequesterAccountType.
    /// </summary>
    public class EnvironmentAccountConnectionRequesterAccountType : ConstantClass
    {

        /// <summary>
        /// Constant ENVIRONMENT_ACCOUNT for EnvironmentAccountConnectionRequesterAccountType
        /// </summary>
        public static readonly EnvironmentAccountConnectionRequesterAccountType ENVIRONMENT_ACCOUNT = new EnvironmentAccountConnectionRequesterAccountType("ENVIRONMENT_ACCOUNT");
        /// <summary>
        /// Constant MANAGEMENT_ACCOUNT for EnvironmentAccountConnectionRequesterAccountType
        /// </summary>
        public static readonly EnvironmentAccountConnectionRequesterAccountType MANAGEMENT_ACCOUNT = new EnvironmentAccountConnectionRequesterAccountType("MANAGEMENT_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentAccountConnectionRequesterAccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentAccountConnectionRequesterAccountType FindValue(string value)
        {
            return FindValue<EnvironmentAccountConnectionRequesterAccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentAccountConnectionRequesterAccountType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentAccountConnectionStatus.
    /// </summary>
    public class EnvironmentAccountConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for EnvironmentAccountConnectionStatus
        /// </summary>
        public static readonly EnvironmentAccountConnectionStatus CONNECTED = new EnvironmentAccountConnectionStatus("CONNECTED");
        /// <summary>
        /// Constant PENDING for EnvironmentAccountConnectionStatus
        /// </summary>
        public static readonly EnvironmentAccountConnectionStatus PENDING = new EnvironmentAccountConnectionStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for EnvironmentAccountConnectionStatus
        /// </summary>
        public static readonly EnvironmentAccountConnectionStatus REJECTED = new EnvironmentAccountConnectionStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentAccountConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentAccountConnectionStatus FindValue(string value)
        {
            return FindValue<EnvironmentAccountConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentAccountConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Provisioning.
    /// </summary>
    public class Provisioning : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_MANAGED for Provisioning
        /// </summary>
        public static readonly Provisioning CUSTOMER_MANAGED = new Provisioning("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Provisioning(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Provisioning FindValue(string value)
        {
            return FindValue<Provisioning>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Provisioning(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceStatus.
    /// </summary>
    public class ServiceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus ACTIVE = new ServiceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_FAILED = new ServiceStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_FAILED_CLEANUP_COMPLETE for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_FAILED_CLEANUP_COMPLETE = new ServiceStatus("CREATE_FAILED_CLEANUP_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED_CLEANUP_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_FAILED_CLEANUP_FAILED = new ServiceStatus("CREATE_FAILED_CLEANUP_FAILED");
        /// <summary>
        /// Constant CREATE_FAILED_CLEANUP_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_FAILED_CLEANUP_IN_PROGRESS = new ServiceStatus("CREATE_FAILED_CLEANUP_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_IN_PROGRESS = new ServiceStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus DELETE_FAILED = new ServiceStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus DELETE_IN_PROGRESS = new ServiceStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_COMPLETE_CLEANUP_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus UPDATE_COMPLETE_CLEANUP_FAILED = new ServiceStatus("UPDATE_COMPLETE_CLEANUP_FAILED");
        /// <summary>
        /// Constant UPDATE_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus UPDATE_FAILED = new ServiceStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_FAILED_CLEANUP_COMPLETE for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus UPDATE_FAILED_CLEANUP_COMPLETE = new ServiceStatus("UPDATE_FAILED_CLEANUP_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED_CLEANUP_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus UPDATE_FAILED_CLEANUP_FAILED = new ServiceStatus("UPDATE_FAILED_CLEANUP_FAILED");
        /// <summary>
        /// Constant UPDATE_FAILED_CLEANUP_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus UPDATE_FAILED_CLEANUP_IN_PROGRESS = new ServiceStatus("UPDATE_FAILED_CLEANUP_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus UPDATE_IN_PROGRESS = new ServiceStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceStatus FindValue(string value)
        {
            return FindValue<ServiceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateVersionStatus.
    /// </summary>
    public class TemplateVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRAFT for TemplateVersionStatus
        /// </summary>
        public static readonly TemplateVersionStatus DRAFT = new TemplateVersionStatus("DRAFT");
        /// <summary>
        /// Constant PUBLISHED for TemplateVersionStatus
        /// </summary>
        public static readonly TemplateVersionStatus PUBLISHED = new TemplateVersionStatus("PUBLISHED");
        /// <summary>
        /// Constant REGISTRATION_FAILED for TemplateVersionStatus
        /// </summary>
        public static readonly TemplateVersionStatus REGISTRATION_FAILED = new TemplateVersionStatus("REGISTRATION_FAILED");
        /// <summary>
        /// Constant REGISTRATION_IN_PROGRESS for TemplateVersionStatus
        /// </summary>
        public static readonly TemplateVersionStatus REGISTRATION_IN_PROGRESS = new TemplateVersionStatus("REGISTRATION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateVersionStatus FindValue(string value)
        {
            return FindValue<TemplateVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateVersionStatus(string value)
        {
            return FindValue(value);
        }
    }

}