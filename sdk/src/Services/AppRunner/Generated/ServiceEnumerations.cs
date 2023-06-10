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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppRunner
{

    /// <summary>
    /// Constants used for properties of type AutoScalingConfigurationStatus.
    /// </summary>
    public class AutoScalingConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AutoScalingConfigurationStatus
        /// </summary>
        public static readonly AutoScalingConfigurationStatus ACTIVE = new AutoScalingConfigurationStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AutoScalingConfigurationStatus
        /// </summary>
        public static readonly AutoScalingConfigurationStatus INACTIVE = new AutoScalingConfigurationStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingConfigurationStatus FindValue(string value)
        {
            return FindValue<AutoScalingConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateValidationRecordStatus.
    /// </summary>
    public class CertificateValidationRecordStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CertificateValidationRecordStatus
        /// </summary>
        public static readonly CertificateValidationRecordStatus FAILED = new CertificateValidationRecordStatus("FAILED");
        /// <summary>
        /// Constant PENDING_VALIDATION for CertificateValidationRecordStatus
        /// </summary>
        public static readonly CertificateValidationRecordStatus PENDING_VALIDATION = new CertificateValidationRecordStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant SUCCESS for CertificateValidationRecordStatus
        /// </summary>
        public static readonly CertificateValidationRecordStatus SUCCESS = new CertificateValidationRecordStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateValidationRecordStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateValidationRecordStatus FindValue(string value)
        {
            return FindValue<CertificateValidationRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateValidationRecordStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationSource.
    /// </summary>
    public class ConfigurationSource : ConstantClass
    {

        /// <summary>
        /// Constant API for ConfigurationSource
        /// </summary>
        public static readonly ConfigurationSource API = new ConfigurationSource("API");
        /// <summary>
        /// Constant REPOSITORY for ConfigurationSource
        /// </summary>
        public static readonly ConfigurationSource REPOSITORY = new ConfigurationSource("REPOSITORY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationSource FindValue(string value)
        {
            return FindValue<ConfigurationSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus AVAILABLE = new ConnectionStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus DELETED = new ConnectionStatus("DELETED");
        /// <summary>
        /// Constant ERROR for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus ERROR = new ConnectionStatus("ERROR");
        /// <summary>
        /// Constant PENDING_HANDSHAKE for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus PENDING_HANDSHAKE = new ConnectionStatus("PENDING_HANDSHAKE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomDomainAssociationStatus.
    /// </summary>
    public class CustomDomainAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CustomDomainAssociationStatus
        /// </summary>
        public static readonly CustomDomainAssociationStatus ACTIVE = new CustomDomainAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant BINDING_CERTIFICATE for CustomDomainAssociationStatus
        /// </summary>
        public static readonly CustomDomainAssociationStatus BINDING_CERTIFICATE = new CustomDomainAssociationStatus("BINDING_CERTIFICATE");
        /// <summary>
        /// Constant CREATE_FAILED for CustomDomainAssociationStatus
        /// </summary>
        public static readonly CustomDomainAssociationStatus CREATE_FAILED = new CustomDomainAssociationStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for CustomDomainAssociationStatus
        /// </summary>
        public static readonly CustomDomainAssociationStatus CREATING = new CustomDomainAssociationStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for CustomDomainAssociationStatus
        /// </summary>
        public static readonly CustomDomainAssociationStatus DELETE_FAILED = new CustomDomainAssociationStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for CustomDomainAssociationStatus
        /// </summary>
        public static readonly CustomDomainAssociationStatus DELETING = new CustomDomainAssociationStatus("DELETING");
        /// <summary>
        /// Constant PENDING_CERTIFICATE_DNS_VALIDATION for CustomDomainAssociationStatus
        /// </summary>
        public static readonly CustomDomainAssociationStatus PENDING_CERTIFICATE_DNS_VALIDATION = new CustomDomainAssociationStatus("PENDING_CERTIFICATE_DNS_VALIDATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomDomainAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomDomainAssociationStatus FindValue(string value)
        {
            return FindValue<CustomDomainAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomDomainAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EgressType.
    /// </summary>
    public class EgressType : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for EgressType
        /// </summary>
        public static readonly EgressType DEFAULT = new EgressType("DEFAULT");
        /// <summary>
        /// Constant VPC for EgressType
        /// </summary>
        public static readonly EgressType VPC = new EgressType("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EgressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EgressType FindValue(string value)
        {
            return FindValue<EgressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EgressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthCheckProtocol.
    /// </summary>
    public class HealthCheckProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for HealthCheckProtocol
        /// </summary>
        public static readonly HealthCheckProtocol HTTP = new HealthCheckProtocol("HTTP");
        /// <summary>
        /// Constant TCP for HealthCheckProtocol
        /// </summary>
        public static readonly HealthCheckProtocol TCP = new HealthCheckProtocol("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthCheckProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthCheckProtocol FindValue(string value)
        {
            return FindValue<HealthCheckProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthCheckProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageRepositoryType.
    /// </summary>
    public class ImageRepositoryType : ConstantClass
    {

        /// <summary>
        /// Constant ECR for ImageRepositoryType
        /// </summary>
        public static readonly ImageRepositoryType ECR = new ImageRepositoryType("ECR");
        /// <summary>
        /// Constant ECR_PUBLIC for ImageRepositoryType
        /// </summary>
        public static readonly ImageRepositoryType ECR_PUBLIC = new ImageRepositoryType("ECR_PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageRepositoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageRepositoryType FindValue(string value)
        {
            return FindValue<ImageRepositoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageRepositoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObservabilityConfigurationStatus.
    /// </summary>
    public class ObservabilityConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ObservabilityConfigurationStatus
        /// </summary>
        public static readonly ObservabilityConfigurationStatus ACTIVE = new ObservabilityConfigurationStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for ObservabilityConfigurationStatus
        /// </summary>
        public static readonly ObservabilityConfigurationStatus INACTIVE = new ObservabilityConfigurationStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObservabilityConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObservabilityConfigurationStatus FindValue(string value)
        {
            return FindValue<ObservabilityConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObservabilityConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for OperationStatus
        /// </summary>
        public static readonly OperationStatus FAILED = new OperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus IN_PROGRESS = new OperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for OperationStatus
        /// </summary>
        public static readonly OperationStatus PENDING = new OperationStatus("PENDING");
        /// <summary>
        /// Constant ROLLBACK_FAILED for OperationStatus
        /// </summary>
        public static readonly OperationStatus ROLLBACK_FAILED = new OperationStatus("ROLLBACK_FAILED");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus ROLLBACK_IN_PROGRESS = new OperationStatus("ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant ROLLBACK_SUCCEEDED for OperationStatus
        /// </summary>
        public static readonly OperationStatus ROLLBACK_SUCCEEDED = new OperationStatus("ROLLBACK_SUCCEEDED");
        /// <summary>
        /// Constant SUCCEEDED for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUCCEEDED = new OperationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationType.
    /// </summary>
    public class OperationType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_SERVICE for OperationType
        /// </summary>
        public static readonly OperationType CREATE_SERVICE = new OperationType("CREATE_SERVICE");
        /// <summary>
        /// Constant DELETE_SERVICE for OperationType
        /// </summary>
        public static readonly OperationType DELETE_SERVICE = new OperationType("DELETE_SERVICE");
        /// <summary>
        /// Constant PAUSE_SERVICE for OperationType
        /// </summary>
        public static readonly OperationType PAUSE_SERVICE = new OperationType("PAUSE_SERVICE");
        /// <summary>
        /// Constant RESUME_SERVICE for OperationType
        /// </summary>
        public static readonly OperationType RESUME_SERVICE = new OperationType("RESUME_SERVICE");
        /// <summary>
        /// Constant START_DEPLOYMENT for OperationType
        /// </summary>
        public static readonly OperationType START_DEPLOYMENT = new OperationType("START_DEPLOYMENT");
        /// <summary>
        /// Constant UPDATE_SERVICE for OperationType
        /// </summary>
        public static readonly OperationType UPDATE_SERVICE = new OperationType("UPDATE_SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationType FindValue(string value)
        {
            return FindValue<OperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProviderType.
    /// </summary>
    public class ProviderType : ConstantClass
    {

        /// <summary>
        /// Constant GITHUB for ProviderType
        /// </summary>
        public static readonly ProviderType GITHUB = new ProviderType("GITHUB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProviderType FindValue(string value)
        {
            return FindValue<ProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Runtime.
    /// </summary>
    public class Runtime : ConstantClass
    {

        /// <summary>
        /// Constant CORRETTO_11 for Runtime
        /// </summary>
        public static readonly Runtime CORRETTO_11 = new Runtime("CORRETTO_11");
        /// <summary>
        /// Constant CORRETTO_8 for Runtime
        /// </summary>
        public static readonly Runtime CORRETTO_8 = new Runtime("CORRETTO_8");
        /// <summary>
        /// Constant DOTNET_6 for Runtime
        /// </summary>
        public static readonly Runtime DOTNET_6 = new Runtime("DOTNET_6");
        /// <summary>
        /// Constant GO_1 for Runtime
        /// </summary>
        public static readonly Runtime GO_1 = new Runtime("GO_1");
        /// <summary>
        /// Constant NODEJS_12 for Runtime
        /// </summary>
        public static readonly Runtime NODEJS_12 = new Runtime("NODEJS_12");
        /// <summary>
        /// Constant NODEJS_14 for Runtime
        /// </summary>
        public static readonly Runtime NODEJS_14 = new Runtime("NODEJS_14");
        /// <summary>
        /// Constant NODEJS_16 for Runtime
        /// </summary>
        public static readonly Runtime NODEJS_16 = new Runtime("NODEJS_16");
        /// <summary>
        /// Constant PHP_81 for Runtime
        /// </summary>
        public static readonly Runtime PHP_81 = new Runtime("PHP_81");
        /// <summary>
        /// Constant PYTHON_3 for Runtime
        /// </summary>
        public static readonly Runtime PYTHON_3 = new Runtime("PYTHON_3");
        /// <summary>
        /// Constant RUBY_31 for Runtime
        /// </summary>
        public static readonly Runtime RUBY_31 = new Runtime("RUBY_31");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Runtime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Runtime FindValue(string value)
        {
            return FindValue<Runtime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Runtime(string value)
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
        /// Constant CREATE_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_FAILED = new ServiceStatus("CREATE_FAILED");
        /// <summary>
        /// Constant DELETE_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus DELETE_FAILED = new ServiceStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus DELETED = new ServiceStatus("DELETED");
        /// <summary>
        /// Constant OPERATION_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus OPERATION_IN_PROGRESS = new ServiceStatus("OPERATION_IN_PROGRESS");
        /// <summary>
        /// Constant PAUSED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus PAUSED = new ServiceStatus("PAUSED");
        /// <summary>
        /// Constant RUNNING for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus RUNNING = new ServiceStatus("RUNNING");

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
    /// Constants used for properties of type SourceCodeVersionType.
    /// </summary>
    public class SourceCodeVersionType : ConstantClass
    {

        /// <summary>
        /// Constant BRANCH for SourceCodeVersionType
        /// </summary>
        public static readonly SourceCodeVersionType BRANCH = new SourceCodeVersionType("BRANCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceCodeVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceCodeVersionType FindValue(string value)
        {
            return FindValue<SourceCodeVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceCodeVersionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TracingVendor.
    /// </summary>
    public class TracingVendor : ConstantClass
    {

        /// <summary>
        /// Constant AWSXRAY for TracingVendor
        /// </summary>
        public static readonly TracingVendor AWSXRAY = new TracingVendor("AWSXRAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TracingVendor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TracingVendor FindValue(string value)
        {
            return FindValue<TracingVendor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TracingVendor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcConnectorStatus.
    /// </summary>
    public class VpcConnectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VpcConnectorStatus
        /// </summary>
        public static readonly VpcConnectorStatus ACTIVE = new VpcConnectorStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for VpcConnectorStatus
        /// </summary>
        public static readonly VpcConnectorStatus INACTIVE = new VpcConnectorStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcConnectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcConnectorStatus FindValue(string value)
        {
            return FindValue<VpcConnectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcConnectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcIngressConnectionStatus.
    /// </summary>
    public class VpcIngressConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus AVAILABLE = new VpcIngressConnectionStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus DELETED = new VpcIngressConnectionStatus("DELETED");
        /// <summary>
        /// Constant FAILED_CREATION for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus FAILED_CREATION = new VpcIngressConnectionStatus("FAILED_CREATION");
        /// <summary>
        /// Constant FAILED_DELETION for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus FAILED_DELETION = new VpcIngressConnectionStatus("FAILED_DELETION");
        /// <summary>
        /// Constant FAILED_UPDATE for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus FAILED_UPDATE = new VpcIngressConnectionStatus("FAILED_UPDATE");
        /// <summary>
        /// Constant PENDING_CREATION for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus PENDING_CREATION = new VpcIngressConnectionStatus("PENDING_CREATION");
        /// <summary>
        /// Constant PENDING_DELETION for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus PENDING_DELETION = new VpcIngressConnectionStatus("PENDING_DELETION");
        /// <summary>
        /// Constant PENDING_UPDATE for VpcIngressConnectionStatus
        /// </summary>
        public static readonly VpcIngressConnectionStatus PENDING_UPDATE = new VpcIngressConnectionStatus("PENDING_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcIngressConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcIngressConnectionStatus FindValue(string value)
        {
            return FindValue<VpcIngressConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcIngressConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }

}