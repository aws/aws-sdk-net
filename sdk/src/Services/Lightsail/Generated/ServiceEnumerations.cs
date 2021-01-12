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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Lightsail
{

    /// <summary>
    /// Constants used for properties of type AccessDirection.
    /// </summary>
    public class AccessDirection : ConstantClass
    {

        /// <summary>
        /// Constant Inbound for AccessDirection
        /// </summary>
        public static readonly AccessDirection Inbound = new AccessDirection("inbound");
        /// <summary>
        /// Constant Outbound for AccessDirection
        /// </summary>
        public static readonly AccessDirection Outbound = new AccessDirection("outbound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDirection FindValue(string value)
        {
            return FindValue<AccessDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AddOnType.
    /// </summary>
    public class AddOnType : ConstantClass
    {

        /// <summary>
        /// Constant AutoSnapshot for AddOnType
        /// </summary>
        public static readonly AddOnType AutoSnapshot = new AddOnType("AutoSnapshot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddOnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddOnType FindValue(string value)
        {
            return FindValue<AddOnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddOnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlarmState.
    /// </summary>
    public class AlarmState : ConstantClass
    {

        /// <summary>
        /// Constant ALARM for AlarmState
        /// </summary>
        public static readonly AlarmState ALARM = new AlarmState("ALARM");
        /// <summary>
        /// Constant INSUFFICIENT_DATA for AlarmState
        /// </summary>
        public static readonly AlarmState INSUFFICIENT_DATA = new AlarmState("INSUFFICIENT_DATA");
        /// <summary>
        /// Constant OK for AlarmState
        /// </summary>
        public static readonly AlarmState OK = new AlarmState("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlarmState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlarmState FindValue(string value)
        {
            return FindValue<AlarmState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlarmState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoSnapshotStatus.
    /// </summary>
    public class AutoSnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for AutoSnapshotStatus
        /// </summary>
        public static readonly AutoSnapshotStatus Failed = new AutoSnapshotStatus("Failed");
        /// <summary>
        /// Constant InProgress for AutoSnapshotStatus
        /// </summary>
        public static readonly AutoSnapshotStatus InProgress = new AutoSnapshotStatus("InProgress");
        /// <summary>
        /// Constant NotFound for AutoSnapshotStatus
        /// </summary>
        public static readonly AutoSnapshotStatus NotFound = new AutoSnapshotStatus("NotFound");
        /// <summary>
        /// Constant Success for AutoSnapshotStatus
        /// </summary>
        public static readonly AutoSnapshotStatus Success = new AutoSnapshotStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoSnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoSnapshotStatus FindValue(string value)
        {
            return FindValue<AutoSnapshotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoSnapshotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BehaviorEnum.
    /// </summary>
    public class BehaviorEnum : ConstantClass
    {

        /// <summary>
        /// Constant Cache for BehaviorEnum
        /// </summary>
        public static readonly BehaviorEnum Cache = new BehaviorEnum("cache");
        /// <summary>
        /// Constant DontCache for BehaviorEnum
        /// </summary>
        public static readonly BehaviorEnum DontCache = new BehaviorEnum("dont-cache");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BehaviorEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BehaviorEnum FindValue(string value)
        {
            return FindValue<BehaviorEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BehaviorEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlueprintType.
    /// </summary>
    public class BlueprintType : ConstantClass
    {

        /// <summary>
        /// Constant App for BlueprintType
        /// </summary>
        public static readonly BlueprintType App = new BlueprintType("app");
        /// <summary>
        /// Constant Os for BlueprintType
        /// </summary>
        public static readonly BlueprintType Os = new BlueprintType("os");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlueprintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlueprintType FindValue(string value)
        {
            return FindValue<BlueprintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlueprintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateStatus.
    /// </summary>
    public class CertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXPIRED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus EXPIRED = new CertificateStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus FAILED = new CertificateStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus INACTIVE = new CertificateStatus("INACTIVE");
        /// <summary>
        /// Constant ISSUED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus ISSUED = new CertificateStatus("ISSUED");
        /// <summary>
        /// Constant PENDING_VALIDATION for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus PENDING_VALIDATION = new CertificateStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant REVOKED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus REVOKED = new CertificateStatus("REVOKED");
        /// <summary>
        /// Constant VALIDATION_TIMED_OUT for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus VALIDATION_TIMED_OUT = new CertificateStatus("VALIDATION_TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateStatus FindValue(string value)
        {
            return FindValue<CertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudFormationStackRecordSourceType.
    /// </summary>
    public class CloudFormationStackRecordSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ExportSnapshotRecord for CloudFormationStackRecordSourceType
        /// </summary>
        public static readonly CloudFormationStackRecordSourceType ExportSnapshotRecord = new CloudFormationStackRecordSourceType("ExportSnapshotRecord");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudFormationStackRecordSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudFormationStackRecordSourceType FindValue(string value)
        {
            return FindValue<CloudFormationStackRecordSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudFormationStackRecordSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant GreaterThanOrEqualToThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanOrEqualToThreshold = new ComparisonOperator("GreaterThanOrEqualToThreshold");
        /// <summary>
        /// Constant GreaterThanThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanThreshold = new ComparisonOperator("GreaterThanThreshold");
        /// <summary>
        /// Constant LessThanOrEqualToThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanOrEqualToThreshold = new ComparisonOperator("LessThanOrEqualToThreshold");
        /// <summary>
        /// Constant LessThanThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanThreshold = new ComparisonOperator("LessThanThreshold");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactMethodStatus.
    /// </summary>
    public class ContactMethodStatus : ConstantClass
    {

        /// <summary>
        /// Constant Invalid for ContactMethodStatus
        /// </summary>
        public static readonly ContactMethodStatus Invalid = new ContactMethodStatus("Invalid");
        /// <summary>
        /// Constant PendingVerification for ContactMethodStatus
        /// </summary>
        public static readonly ContactMethodStatus PendingVerification = new ContactMethodStatus("PendingVerification");
        /// <summary>
        /// Constant Valid for ContactMethodStatus
        /// </summary>
        public static readonly ContactMethodStatus Valid = new ContactMethodStatus("Valid");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactMethodStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactMethodStatus FindValue(string value)
        {
            return FindValue<ContactMethodStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactMethodStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactMethodVerificationProtocol.
    /// </summary>
    public class ContactMethodVerificationProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Email for ContactMethodVerificationProtocol
        /// </summary>
        public static readonly ContactMethodVerificationProtocol Email = new ContactMethodVerificationProtocol("Email");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactMethodVerificationProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactMethodVerificationProtocol FindValue(string value)
        {
            return FindValue<ContactMethodVerificationProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactMethodVerificationProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactProtocol.
    /// </summary>
    public class ContactProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Email for ContactProtocol
        /// </summary>
        public static readonly ContactProtocol Email = new ContactProtocol("Email");
        /// <summary>
        /// Constant SMS for ContactProtocol
        /// </summary>
        public static readonly ContactProtocol SMS = new ContactProtocol("SMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactProtocol FindValue(string value)
        {
            return FindValue<ContactProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerServiceDeploymentState.
    /// </summary>
    public class ContainerServiceDeploymentState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for ContainerServiceDeploymentState
        /// </summary>
        public static readonly ContainerServiceDeploymentState ACTIVATING = new ContainerServiceDeploymentState("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for ContainerServiceDeploymentState
        /// </summary>
        public static readonly ContainerServiceDeploymentState ACTIVE = new ContainerServiceDeploymentState("ACTIVE");
        /// <summary>
        /// Constant FAILED for ContainerServiceDeploymentState
        /// </summary>
        public static readonly ContainerServiceDeploymentState FAILED = new ContainerServiceDeploymentState("FAILED");
        /// <summary>
        /// Constant INACTIVE for ContainerServiceDeploymentState
        /// </summary>
        public static readonly ContainerServiceDeploymentState INACTIVE = new ContainerServiceDeploymentState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerServiceDeploymentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerServiceDeploymentState FindValue(string value)
        {
            return FindValue<ContainerServiceDeploymentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerServiceDeploymentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerServiceMetricName.
    /// </summary>
    public class ContainerServiceMetricName : ConstantClass
    {

        /// <summary>
        /// Constant CPUUtilization for ContainerServiceMetricName
        /// </summary>
        public static readonly ContainerServiceMetricName CPUUtilization = new ContainerServiceMetricName("CPUUtilization");
        /// <summary>
        /// Constant MemoryUtilization for ContainerServiceMetricName
        /// </summary>
        public static readonly ContainerServiceMetricName MemoryUtilization = new ContainerServiceMetricName("MemoryUtilization");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerServiceMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerServiceMetricName FindValue(string value)
        {
            return FindValue<ContainerServiceMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerServiceMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerServicePowerName.
    /// </summary>
    public class ContainerServicePowerName : ConstantClass
    {

        /// <summary>
        /// Constant Large for ContainerServicePowerName
        /// </summary>
        public static readonly ContainerServicePowerName Large = new ContainerServicePowerName("large");
        /// <summary>
        /// Constant Medium for ContainerServicePowerName
        /// </summary>
        public static readonly ContainerServicePowerName Medium = new ContainerServicePowerName("medium");
        /// <summary>
        /// Constant Micro for ContainerServicePowerName
        /// </summary>
        public static readonly ContainerServicePowerName Micro = new ContainerServicePowerName("micro");
        /// <summary>
        /// Constant Nano for ContainerServicePowerName
        /// </summary>
        public static readonly ContainerServicePowerName Nano = new ContainerServicePowerName("nano");
        /// <summary>
        /// Constant Small for ContainerServicePowerName
        /// </summary>
        public static readonly ContainerServicePowerName Small = new ContainerServicePowerName("small");
        /// <summary>
        /// Constant Xlarge for ContainerServicePowerName
        /// </summary>
        public static readonly ContainerServicePowerName Xlarge = new ContainerServicePowerName("xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerServicePowerName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerServicePowerName FindValue(string value)
        {
            return FindValue<ContainerServicePowerName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerServicePowerName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerServiceProtocol.
    /// </summary>
    public class ContainerServiceProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for ContainerServiceProtocol
        /// </summary>
        public static readonly ContainerServiceProtocol HTTP = new ContainerServiceProtocol("HTTP");
        /// <summary>
        /// Constant HTTPS for ContainerServiceProtocol
        /// </summary>
        public static readonly ContainerServiceProtocol HTTPS = new ContainerServiceProtocol("HTTPS");
        /// <summary>
        /// Constant TCP for ContainerServiceProtocol
        /// </summary>
        public static readonly ContainerServiceProtocol TCP = new ContainerServiceProtocol("TCP");
        /// <summary>
        /// Constant UDP for ContainerServiceProtocol
        /// </summary>
        public static readonly ContainerServiceProtocol UDP = new ContainerServiceProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerServiceProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerServiceProtocol FindValue(string value)
        {
            return FindValue<ContainerServiceProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerServiceProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerServiceState.
    /// </summary>
    public class ContainerServiceState : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ContainerServiceState
        /// </summary>
        public static readonly ContainerServiceState DELETING = new ContainerServiceState("DELETING");
        /// <summary>
        /// Constant DISABLED for ContainerServiceState
        /// </summary>
        public static readonly ContainerServiceState DISABLED = new ContainerServiceState("DISABLED");
        /// <summary>
        /// Constant PENDING for ContainerServiceState
        /// </summary>
        public static readonly ContainerServiceState PENDING = new ContainerServiceState("PENDING");
        /// <summary>
        /// Constant READY for ContainerServiceState
        /// </summary>
        public static readonly ContainerServiceState READY = new ContainerServiceState("READY");
        /// <summary>
        /// Constant RUNNING for ContainerServiceState
        /// </summary>
        public static readonly ContainerServiceState RUNNING = new ContainerServiceState("RUNNING");
        /// <summary>
        /// Constant UPDATING for ContainerServiceState
        /// </summary>
        public static readonly ContainerServiceState UPDATING = new ContainerServiceState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerServiceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerServiceState FindValue(string value)
        {
            return FindValue<ContainerServiceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerServiceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskSnapshotState.
    /// </summary>
    public class DiskSnapshotState : ConstantClass
    {

        /// <summary>
        /// Constant Completed for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Completed = new DiskSnapshotState("completed");
        /// <summary>
        /// Constant Error for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Error = new DiskSnapshotState("error");
        /// <summary>
        /// Constant Pending for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Pending = new DiskSnapshotState("pending");
        /// <summary>
        /// Constant Unknown for DiskSnapshotState
        /// </summary>
        public static readonly DiskSnapshotState Unknown = new DiskSnapshotState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskSnapshotState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskSnapshotState FindValue(string value)
        {
            return FindValue<DiskSnapshotState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskSnapshotState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskState.
    /// </summary>
    public class DiskState : ConstantClass
    {

        /// <summary>
        /// Constant Available for DiskState
        /// </summary>
        public static readonly DiskState Available = new DiskState("available");
        /// <summary>
        /// Constant Error for DiskState
        /// </summary>
        public static readonly DiskState Error = new DiskState("error");
        /// <summary>
        /// Constant InUse for DiskState
        /// </summary>
        public static readonly DiskState InUse = new DiskState("in-use");
        /// <summary>
        /// Constant Pending for DiskState
        /// </summary>
        public static readonly DiskState Pending = new DiskState("pending");
        /// <summary>
        /// Constant Unknown for DiskState
        /// </summary>
        public static readonly DiskState Unknown = new DiskState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskState FindValue(string value)
        {
            return FindValue<DiskState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DistributionMetricName.
    /// </summary>
    public class DistributionMetricName : ConstantClass
    {

        /// <summary>
        /// Constant BytesDownloaded for DistributionMetricName
        /// </summary>
        public static readonly DistributionMetricName BytesDownloaded = new DistributionMetricName("BytesDownloaded");
        /// <summary>
        /// Constant BytesUploaded for DistributionMetricName
        /// </summary>
        public static readonly DistributionMetricName BytesUploaded = new DistributionMetricName("BytesUploaded");
        /// <summary>
        /// Constant Http4xxErrorRate for DistributionMetricName
        /// </summary>
        public static readonly DistributionMetricName Http4xxErrorRate = new DistributionMetricName("Http4xxErrorRate");
        /// <summary>
        /// Constant Http5xxErrorRate for DistributionMetricName
        /// </summary>
        public static readonly DistributionMetricName Http5xxErrorRate = new DistributionMetricName("Http5xxErrorRate");
        /// <summary>
        /// Constant Requests for DistributionMetricName
        /// </summary>
        public static readonly DistributionMetricName Requests = new DistributionMetricName("Requests");
        /// <summary>
        /// Constant TotalErrorRate for DistributionMetricName
        /// </summary>
        public static readonly DistributionMetricName TotalErrorRate = new DistributionMetricName("TotalErrorRate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DistributionMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DistributionMetricName FindValue(string value)
        {
            return FindValue<DistributionMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DistributionMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportSnapshotRecordSourceType.
    /// </summary>
    public class ExportSnapshotRecordSourceType : ConstantClass
    {

        /// <summary>
        /// Constant DiskSnapshot for ExportSnapshotRecordSourceType
        /// </summary>
        public static readonly ExportSnapshotRecordSourceType DiskSnapshot = new ExportSnapshotRecordSourceType("DiskSnapshot");
        /// <summary>
        /// Constant InstanceSnapshot for ExportSnapshotRecordSourceType
        /// </summary>
        public static readonly ExportSnapshotRecordSourceType InstanceSnapshot = new ExportSnapshotRecordSourceType("InstanceSnapshot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportSnapshotRecordSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportSnapshotRecordSourceType FindValue(string value)
        {
            return FindValue<ExportSnapshotRecordSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportSnapshotRecordSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ForwardValues.
    /// </summary>
    public class ForwardValues : ConstantClass
    {

        /// <summary>
        /// Constant All for ForwardValues
        /// </summary>
        public static readonly ForwardValues All = new ForwardValues("all");
        /// <summary>
        /// Constant AllowList for ForwardValues
        /// </summary>
        public static readonly ForwardValues AllowList = new ForwardValues("allow-list");
        /// <summary>
        /// Constant None for ForwardValues
        /// </summary>
        public static readonly ForwardValues None = new ForwardValues("none");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ForwardValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ForwardValues FindValue(string value)
        {
            return FindValue<ForwardValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ForwardValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HeaderEnum.
    /// </summary>
    public class HeaderEnum : ConstantClass
    {

        /// <summary>
        /// Constant Accept for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum Accept = new HeaderEnum("Accept");
        /// <summary>
        /// Constant AcceptCharset for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum AcceptCharset = new HeaderEnum("Accept-Charset");
        /// <summary>
        /// Constant AcceptDatetime for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum AcceptDatetime = new HeaderEnum("Accept-Datetime");
        /// <summary>
        /// Constant AcceptEncoding for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum AcceptEncoding = new HeaderEnum("Accept-Encoding");
        /// <summary>
        /// Constant AcceptLanguage for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum AcceptLanguage = new HeaderEnum("Accept-Language");
        /// <summary>
        /// Constant Authorization for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum Authorization = new HeaderEnum("Authorization");
        /// <summary>
        /// Constant CloudFrontForwardedProto for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum CloudFrontForwardedProto = new HeaderEnum("CloudFront-Forwarded-Proto");
        /// <summary>
        /// Constant CloudFrontIsDesktopViewer for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum CloudFrontIsDesktopViewer = new HeaderEnum("CloudFront-Is-Desktop-Viewer");
        /// <summary>
        /// Constant CloudFrontIsMobileViewer for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum CloudFrontIsMobileViewer = new HeaderEnum("CloudFront-Is-Mobile-Viewer");
        /// <summary>
        /// Constant CloudFrontIsSmartTVViewer for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum CloudFrontIsSmartTVViewer = new HeaderEnum("CloudFront-Is-SmartTV-Viewer");
        /// <summary>
        /// Constant CloudFrontIsTabletViewer for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum CloudFrontIsTabletViewer = new HeaderEnum("CloudFront-Is-Tablet-Viewer");
        /// <summary>
        /// Constant CloudFrontViewerCountry for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum CloudFrontViewerCountry = new HeaderEnum("CloudFront-Viewer-Country");
        /// <summary>
        /// Constant Host for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum Host = new HeaderEnum("Host");
        /// <summary>
        /// Constant Origin for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum Origin = new HeaderEnum("Origin");
        /// <summary>
        /// Constant Referer for HeaderEnum
        /// </summary>
        public static readonly HeaderEnum Referer = new HeaderEnum("Referer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HeaderEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HeaderEnum FindValue(string value)
        {
            return FindValue<HeaderEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HeaderEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceAccessProtocol.
    /// </summary>
    public class InstanceAccessProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Rdp for InstanceAccessProtocol
        /// </summary>
        public static readonly InstanceAccessProtocol Rdp = new InstanceAccessProtocol("rdp");
        /// <summary>
        /// Constant Ssh for InstanceAccessProtocol
        /// </summary>
        public static readonly InstanceAccessProtocol Ssh = new InstanceAccessProtocol("ssh");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceAccessProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAccessProtocol FindValue(string value)
        {
            return FindValue<InstanceAccessProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceAccessProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceHealthReason.
    /// </summary>
    public class InstanceHealthReason : ConstantClass
    {

        /// <summary>
        /// Constant InstanceDeregistrationInProgress for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceDeregistrationInProgress = new InstanceHealthReason("Instance.DeregistrationInProgress");
        /// <summary>
        /// Constant InstanceFailedHealthChecks for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceFailedHealthChecks = new InstanceHealthReason("Instance.FailedHealthChecks");
        /// <summary>
        /// Constant InstanceInvalidState for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceInvalidState = new InstanceHealthReason("Instance.InvalidState");
        /// <summary>
        /// Constant InstanceIpUnusable for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceIpUnusable = new InstanceHealthReason("Instance.IpUnusable");
        /// <summary>
        /// Constant InstanceNotInUse for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceNotInUse = new InstanceHealthReason("Instance.NotInUse");
        /// <summary>
        /// Constant InstanceNotRegistered for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceNotRegistered = new InstanceHealthReason("Instance.NotRegistered");
        /// <summary>
        /// Constant InstanceResponseCodeMismatch for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceResponseCodeMismatch = new InstanceHealthReason("Instance.ResponseCodeMismatch");
        /// <summary>
        /// Constant InstanceTimeout for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason InstanceTimeout = new InstanceHealthReason("Instance.Timeout");
        /// <summary>
        /// Constant LbInitialHealthChecking for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason LbInitialHealthChecking = new InstanceHealthReason("Lb.InitialHealthChecking");
        /// <summary>
        /// Constant LbInternalError for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason LbInternalError = new InstanceHealthReason("Lb.InternalError");
        /// <summary>
        /// Constant LbRegistrationInProgress for InstanceHealthReason
        /// </summary>
        public static readonly InstanceHealthReason LbRegistrationInProgress = new InstanceHealthReason("Lb.RegistrationInProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceHealthReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceHealthReason FindValue(string value)
        {
            return FindValue<InstanceHealthReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceHealthReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceHealthState.
    /// </summary>
    public class InstanceHealthState : ConstantClass
    {

        /// <summary>
        /// Constant Draining for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Draining = new InstanceHealthState("draining");
        /// <summary>
        /// Constant Healthy for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Healthy = new InstanceHealthState("healthy");
        /// <summary>
        /// Constant Initial for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Initial = new InstanceHealthState("initial");
        /// <summary>
        /// Constant Unavailable for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Unavailable = new InstanceHealthState("unavailable");
        /// <summary>
        /// Constant Unhealthy for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Unhealthy = new InstanceHealthState("unhealthy");
        /// <summary>
        /// Constant Unused for InstanceHealthState
        /// </summary>
        public static readonly InstanceHealthState Unused = new InstanceHealthState("unused");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceHealthState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceHealthState FindValue(string value)
        {
            return FindValue<InstanceHealthState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceHealthState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceMetricName.
    /// </summary>
    public class InstanceMetricName : ConstantClass
    {

        /// <summary>
        /// Constant BurstCapacityPercentage for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName BurstCapacityPercentage = new InstanceMetricName("BurstCapacityPercentage");
        /// <summary>
        /// Constant BurstCapacityTime for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName BurstCapacityTime = new InstanceMetricName("BurstCapacityTime");
        /// <summary>
        /// Constant CPUUtilization for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName CPUUtilization = new InstanceMetricName("CPUUtilization");
        /// <summary>
        /// Constant NetworkIn for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName NetworkIn = new InstanceMetricName("NetworkIn");
        /// <summary>
        /// Constant NetworkOut for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName NetworkOut = new InstanceMetricName("NetworkOut");
        /// <summary>
        /// Constant StatusCheckFailed for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName StatusCheckFailed = new InstanceMetricName("StatusCheckFailed");
        /// <summary>
        /// Constant StatusCheckFailed_Instance for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName StatusCheckFailed_Instance = new InstanceMetricName("StatusCheckFailed_Instance");
        /// <summary>
        /// Constant StatusCheckFailed_System for InstanceMetricName
        /// </summary>
        public static readonly InstanceMetricName StatusCheckFailed_System = new InstanceMetricName("StatusCheckFailed_System");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMetricName FindValue(string value)
        {
            return FindValue<InstanceMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstancePlatform.
    /// </summary>
    public class InstancePlatform : ConstantClass
    {

        /// <summary>
        /// Constant LINUX_UNIX for InstancePlatform
        /// </summary>
        public static readonly InstancePlatform LINUX_UNIX = new InstancePlatform("LINUX_UNIX");
        /// <summary>
        /// Constant WINDOWS for InstancePlatform
        /// </summary>
        public static readonly InstancePlatform WINDOWS = new InstancePlatform("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstancePlatform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstancePlatform FindValue(string value)
        {
            return FindValue<InstancePlatform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstancePlatform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceSnapshotState.
    /// </summary>
    public class InstanceSnapshotState : ConstantClass
    {

        /// <summary>
        /// Constant Available for InstanceSnapshotState
        /// </summary>
        public static readonly InstanceSnapshotState Available = new InstanceSnapshotState("available");
        /// <summary>
        /// Constant Error for InstanceSnapshotState
        /// </summary>
        public static readonly InstanceSnapshotState Error = new InstanceSnapshotState("error");
        /// <summary>
        /// Constant Pending for InstanceSnapshotState
        /// </summary>
        public static readonly InstanceSnapshotState Pending = new InstanceSnapshotState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceSnapshotState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceSnapshotState FindValue(string value)
        {
            return FindValue<InstanceSnapshotState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceSnapshotState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant Dualstack for IpAddressType
        /// </summary>
        public static readonly IpAddressType Dualstack = new IpAddressType("dualstack");
        /// <summary>
        /// Constant Ipv4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType Ipv4 = new IpAddressType("ipv4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressType FindValue(string value)
        {
            return FindValue<IpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerAttributeName.
    /// </summary>
    public class LoadBalancerAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant HealthCheckPath for LoadBalancerAttributeName
        /// </summary>
        public static readonly LoadBalancerAttributeName HealthCheckPath = new LoadBalancerAttributeName("HealthCheckPath");
        /// <summary>
        /// Constant SessionStickiness_LB_CookieDurationSeconds for LoadBalancerAttributeName
        /// </summary>
        public static readonly LoadBalancerAttributeName SessionStickiness_LB_CookieDurationSeconds = new LoadBalancerAttributeName("SessionStickiness_LB_CookieDurationSeconds");
        /// <summary>
        /// Constant SessionStickinessEnabled for LoadBalancerAttributeName
        /// </summary>
        public static readonly LoadBalancerAttributeName SessionStickinessEnabled = new LoadBalancerAttributeName("SessionStickinessEnabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerAttributeName FindValue(string value)
        {
            return FindValue<LoadBalancerAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerMetricName.
    /// </summary>
    public class LoadBalancerMetricName : ConstantClass
    {

        /// <summary>
        /// Constant ClientTLSNegotiationErrorCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName ClientTLSNegotiationErrorCount = new LoadBalancerMetricName("ClientTLSNegotiationErrorCount");
        /// <summary>
        /// Constant HealthyHostCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HealthyHostCount = new LoadBalancerMetricName("HealthyHostCount");
        /// <summary>
        /// Constant HTTPCode_Instance_2XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_2XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_2XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_3XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_3XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_3XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_4XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_4XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_4XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_5XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_Instance_5XX_Count = new LoadBalancerMetricName("HTTPCode_Instance_5XX_Count");
        /// <summary>
        /// Constant HTTPCode_LB_4XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_LB_4XX_Count = new LoadBalancerMetricName("HTTPCode_LB_4XX_Count");
        /// <summary>
        /// Constant HTTPCode_LB_5XX_Count for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName HTTPCode_LB_5XX_Count = new LoadBalancerMetricName("HTTPCode_LB_5XX_Count");
        /// <summary>
        /// Constant InstanceResponseTime for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName InstanceResponseTime = new LoadBalancerMetricName("InstanceResponseTime");
        /// <summary>
        /// Constant RejectedConnectionCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName RejectedConnectionCount = new LoadBalancerMetricName("RejectedConnectionCount");
        /// <summary>
        /// Constant RequestCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName RequestCount = new LoadBalancerMetricName("RequestCount");
        /// <summary>
        /// Constant UnhealthyHostCount for LoadBalancerMetricName
        /// </summary>
        public static readonly LoadBalancerMetricName UnhealthyHostCount = new LoadBalancerMetricName("UnhealthyHostCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerMetricName FindValue(string value)
        {
            return FindValue<LoadBalancerMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerProtocol.
    /// </summary>
    public class LoadBalancerProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for LoadBalancerProtocol
        /// </summary>
        public static readonly LoadBalancerProtocol HTTP = new LoadBalancerProtocol("HTTP");
        /// <summary>
        /// Constant HTTP_HTTPS for LoadBalancerProtocol
        /// </summary>
        public static readonly LoadBalancerProtocol HTTP_HTTPS = new LoadBalancerProtocol("HTTP_HTTPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerProtocol FindValue(string value)
        {
            return FindValue<LoadBalancerProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerState.
    /// </summary>
    public class LoadBalancerState : ConstantClass
    {

        /// <summary>
        /// Constant Active for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Active = new LoadBalancerState("active");
        /// <summary>
        /// Constant Active_impaired for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Active_impaired = new LoadBalancerState("active_impaired");
        /// <summary>
        /// Constant Failed for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Failed = new LoadBalancerState("failed");
        /// <summary>
        /// Constant Provisioning for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Provisioning = new LoadBalancerState("provisioning");
        /// <summary>
        /// Constant Unknown for LoadBalancerState
        /// </summary>
        public static readonly LoadBalancerState Unknown = new LoadBalancerState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerState FindValue(string value)
        {
            return FindValue<LoadBalancerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateDomainStatus.
    /// </summary>
    public class LoadBalancerTlsCertificateDomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LoadBalancerTlsCertificateDomainStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateDomainStatus FAILED = new LoadBalancerTlsCertificateDomainStatus("FAILED");
        /// <summary>
        /// Constant PENDING_VALIDATION for LoadBalancerTlsCertificateDomainStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateDomainStatus PENDING_VALIDATION = new LoadBalancerTlsCertificateDomainStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant SUCCESS for LoadBalancerTlsCertificateDomainStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateDomainStatus SUCCESS = new LoadBalancerTlsCertificateDomainStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateDomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateDomainStatus FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateDomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateDomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateFailureReason.
    /// </summary>
    public class LoadBalancerTlsCertificateFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant ADDITIONAL_VERIFICATION_REQUIRED for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason ADDITIONAL_VERIFICATION_REQUIRED = new LoadBalancerTlsCertificateFailureReason("ADDITIONAL_VERIFICATION_REQUIRED");
        /// <summary>
        /// Constant DOMAIN_NOT_ALLOWED for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason DOMAIN_NOT_ALLOWED = new LoadBalancerTlsCertificateFailureReason("DOMAIN_NOT_ALLOWED");
        /// <summary>
        /// Constant INVALID_PUBLIC_DOMAIN for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason INVALID_PUBLIC_DOMAIN = new LoadBalancerTlsCertificateFailureReason("INVALID_PUBLIC_DOMAIN");
        /// <summary>
        /// Constant NO_AVAILABLE_CONTACTS for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason NO_AVAILABLE_CONTACTS = new LoadBalancerTlsCertificateFailureReason("NO_AVAILABLE_CONTACTS");
        /// <summary>
        /// Constant OTHER for LoadBalancerTlsCertificateFailureReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateFailureReason OTHER = new LoadBalancerTlsCertificateFailureReason("OTHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateFailureReason FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateRenewalStatus.
    /// </summary>
    public class LoadBalancerTlsCertificateRenewalStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus FAILED = new LoadBalancerTlsCertificateRenewalStatus("FAILED");
        /// <summary>
        /// Constant PENDING_AUTO_RENEWAL for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus PENDING_AUTO_RENEWAL = new LoadBalancerTlsCertificateRenewalStatus("PENDING_AUTO_RENEWAL");
        /// <summary>
        /// Constant PENDING_VALIDATION for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus PENDING_VALIDATION = new LoadBalancerTlsCertificateRenewalStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant SUCCESS for LoadBalancerTlsCertificateRenewalStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRenewalStatus SUCCESS = new LoadBalancerTlsCertificateRenewalStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateRenewalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateRenewalStatus FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateRenewalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateRenewalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateRevocationReason.
    /// </summary>
    public class LoadBalancerTlsCertificateRevocationReason : ConstantClass
    {

        /// <summary>
        /// Constant A_A_COMPROMISE for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason A_A_COMPROMISE = new LoadBalancerTlsCertificateRevocationReason("A_A_COMPROMISE");
        /// <summary>
        /// Constant AFFILIATION_CHANGED for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason AFFILIATION_CHANGED = new LoadBalancerTlsCertificateRevocationReason("AFFILIATION_CHANGED");
        /// <summary>
        /// Constant CA_COMPROMISE for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason CA_COMPROMISE = new LoadBalancerTlsCertificateRevocationReason("CA_COMPROMISE");
        /// <summary>
        /// Constant CERTIFICATE_HOLD for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason CERTIFICATE_HOLD = new LoadBalancerTlsCertificateRevocationReason("CERTIFICATE_HOLD");
        /// <summary>
        /// Constant CESSATION_OF_OPERATION for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason CESSATION_OF_OPERATION = new LoadBalancerTlsCertificateRevocationReason("CESSATION_OF_OPERATION");
        /// <summary>
        /// Constant KEY_COMPROMISE for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason KEY_COMPROMISE = new LoadBalancerTlsCertificateRevocationReason("KEY_COMPROMISE");
        /// <summary>
        /// Constant PRIVILEGE_WITHDRAWN for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason PRIVILEGE_WITHDRAWN = new LoadBalancerTlsCertificateRevocationReason("PRIVILEGE_WITHDRAWN");
        /// <summary>
        /// Constant REMOVE_FROM_CRL for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason REMOVE_FROM_CRL = new LoadBalancerTlsCertificateRevocationReason("REMOVE_FROM_CRL");
        /// <summary>
        /// Constant SUPERCEDED for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason SUPERCEDED = new LoadBalancerTlsCertificateRevocationReason("SUPERCEDED");
        /// <summary>
        /// Constant UNSPECIFIED for LoadBalancerTlsCertificateRevocationReason
        /// </summary>
        public static readonly LoadBalancerTlsCertificateRevocationReason UNSPECIFIED = new LoadBalancerTlsCertificateRevocationReason("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateRevocationReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateRevocationReason FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateRevocationReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateRevocationReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTlsCertificateStatus.
    /// </summary>
    public class LoadBalancerTlsCertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXPIRED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus EXPIRED = new LoadBalancerTlsCertificateStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus FAILED = new LoadBalancerTlsCertificateStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus INACTIVE = new LoadBalancerTlsCertificateStatus("INACTIVE");
        /// <summary>
        /// Constant ISSUED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus ISSUED = new LoadBalancerTlsCertificateStatus("ISSUED");
        /// <summary>
        /// Constant PENDING_VALIDATION for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus PENDING_VALIDATION = new LoadBalancerTlsCertificateStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant REVOKED for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus REVOKED = new LoadBalancerTlsCertificateStatus("REVOKED");
        /// <summary>
        /// Constant UNKNOWN for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus UNKNOWN = new LoadBalancerTlsCertificateStatus("UNKNOWN");
        /// <summary>
        /// Constant VALIDATION_TIMED_OUT for LoadBalancerTlsCertificateStatus
        /// </summary>
        public static readonly LoadBalancerTlsCertificateStatus VALIDATION_TIMED_OUT = new LoadBalancerTlsCertificateStatus("VALIDATION_TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTlsCertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTlsCertificateStatus FindValue(string value)
        {
            return FindValue<LoadBalancerTlsCertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTlsCertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricName.
    /// </summary>
    public class MetricName : ConstantClass
    {

        /// <summary>
        /// Constant BurstCapacityPercentage for MetricName
        /// </summary>
        public static readonly MetricName BurstCapacityPercentage = new MetricName("BurstCapacityPercentage");
        /// <summary>
        /// Constant BurstCapacityTime for MetricName
        /// </summary>
        public static readonly MetricName BurstCapacityTime = new MetricName("BurstCapacityTime");
        /// <summary>
        /// Constant ClientTLSNegotiationErrorCount for MetricName
        /// </summary>
        public static readonly MetricName ClientTLSNegotiationErrorCount = new MetricName("ClientTLSNegotiationErrorCount");
        /// <summary>
        /// Constant CPUUtilization for MetricName
        /// </summary>
        public static readonly MetricName CPUUtilization = new MetricName("CPUUtilization");
        /// <summary>
        /// Constant DatabaseConnections for MetricName
        /// </summary>
        public static readonly MetricName DatabaseConnections = new MetricName("DatabaseConnections");
        /// <summary>
        /// Constant DiskQueueDepth for MetricName
        /// </summary>
        public static readonly MetricName DiskQueueDepth = new MetricName("DiskQueueDepth");
        /// <summary>
        /// Constant FreeStorageSpace for MetricName
        /// </summary>
        public static readonly MetricName FreeStorageSpace = new MetricName("FreeStorageSpace");
        /// <summary>
        /// Constant HealthyHostCount for MetricName
        /// </summary>
        public static readonly MetricName HealthyHostCount = new MetricName("HealthyHostCount");
        /// <summary>
        /// Constant HTTPCode_Instance_2XX_Count for MetricName
        /// </summary>
        public static readonly MetricName HTTPCode_Instance_2XX_Count = new MetricName("HTTPCode_Instance_2XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_3XX_Count for MetricName
        /// </summary>
        public static readonly MetricName HTTPCode_Instance_3XX_Count = new MetricName("HTTPCode_Instance_3XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_4XX_Count for MetricName
        /// </summary>
        public static readonly MetricName HTTPCode_Instance_4XX_Count = new MetricName("HTTPCode_Instance_4XX_Count");
        /// <summary>
        /// Constant HTTPCode_Instance_5XX_Count for MetricName
        /// </summary>
        public static readonly MetricName HTTPCode_Instance_5XX_Count = new MetricName("HTTPCode_Instance_5XX_Count");
        /// <summary>
        /// Constant HTTPCode_LB_4XX_Count for MetricName
        /// </summary>
        public static readonly MetricName HTTPCode_LB_4XX_Count = new MetricName("HTTPCode_LB_4XX_Count");
        /// <summary>
        /// Constant HTTPCode_LB_5XX_Count for MetricName
        /// </summary>
        public static readonly MetricName HTTPCode_LB_5XX_Count = new MetricName("HTTPCode_LB_5XX_Count");
        /// <summary>
        /// Constant InstanceResponseTime for MetricName
        /// </summary>
        public static readonly MetricName InstanceResponseTime = new MetricName("InstanceResponseTime");
        /// <summary>
        /// Constant NetworkIn for MetricName
        /// </summary>
        public static readonly MetricName NetworkIn = new MetricName("NetworkIn");
        /// <summary>
        /// Constant NetworkOut for MetricName
        /// </summary>
        public static readonly MetricName NetworkOut = new MetricName("NetworkOut");
        /// <summary>
        /// Constant NetworkReceiveThroughput for MetricName
        /// </summary>
        public static readonly MetricName NetworkReceiveThroughput = new MetricName("NetworkReceiveThroughput");
        /// <summary>
        /// Constant NetworkTransmitThroughput for MetricName
        /// </summary>
        public static readonly MetricName NetworkTransmitThroughput = new MetricName("NetworkTransmitThroughput");
        /// <summary>
        /// Constant RejectedConnectionCount for MetricName
        /// </summary>
        public static readonly MetricName RejectedConnectionCount = new MetricName("RejectedConnectionCount");
        /// <summary>
        /// Constant RequestCount for MetricName
        /// </summary>
        public static readonly MetricName RequestCount = new MetricName("RequestCount");
        /// <summary>
        /// Constant StatusCheckFailed for MetricName
        /// </summary>
        public static readonly MetricName StatusCheckFailed = new MetricName("StatusCheckFailed");
        /// <summary>
        /// Constant StatusCheckFailed_Instance for MetricName
        /// </summary>
        public static readonly MetricName StatusCheckFailed_Instance = new MetricName("StatusCheckFailed_Instance");
        /// <summary>
        /// Constant StatusCheckFailed_System for MetricName
        /// </summary>
        public static readonly MetricName StatusCheckFailed_System = new MetricName("StatusCheckFailed_System");
        /// <summary>
        /// Constant UnhealthyHostCount for MetricName
        /// </summary>
        public static readonly MetricName UnhealthyHostCount = new MetricName("UnhealthyHostCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricName FindValue(string value)
        {
            return FindValue<MetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricStatistic.
    /// </summary>
    public class MetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Average = new MetricStatistic("Average");
        /// <summary>
        /// Constant Maximum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Maximum = new MetricStatistic("Maximum");
        /// <summary>
        /// Constant Minimum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Minimum = new MetricStatistic("Minimum");
        /// <summary>
        /// Constant SampleCount for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic SampleCount = new MetricStatistic("SampleCount");
        /// <summary>
        /// Constant Sum for MetricStatistic
        /// </summary>
        public static readonly MetricStatistic Sum = new MetricStatistic("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricStatistic FindValue(string value)
        {
            return FindValue<MetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricUnit.
    /// </summary>
    public class MetricUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Bits = new MetricUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit BitsSecond = new MetricUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Bytes = new MetricUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit BytesSecond = new MetricUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for MetricUnit
        /// </summary>
        public static readonly MetricUnit Count = new MetricUnit("Count");
        /// <summary>
        /// Constant CountSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit CountSecond = new MetricUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Gigabits = new MetricUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit GigabitsSecond = new MetricUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Gigabytes = new MetricUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit GigabytesSecond = new MetricUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Kilobits = new MetricUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit KilobitsSecond = new MetricUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Kilobytes = new MetricUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit KilobytesSecond = new MetricUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Megabits = new MetricUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit MegabitsSecond = new MetricUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Megabytes = new MetricUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit MegabytesSecond = new MetricUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Microseconds = new MetricUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Milliseconds = new MetricUnit("Milliseconds");
        /// <summary>
        /// Constant None for MetricUnit
        /// </summary>
        public static readonly MetricUnit None = new MetricUnit("None");
        /// <summary>
        /// Constant Percent for MetricUnit
        /// </summary>
        public static readonly MetricUnit Percent = new MetricUnit("Percent");
        /// <summary>
        /// Constant Seconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Seconds = new MetricUnit("Seconds");
        /// <summary>
        /// Constant Terabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Terabits = new MetricUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit TerabitsSecond = new MetricUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Terabytes = new MetricUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit TerabytesSecond = new MetricUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricUnit FindValue(string value)
        {
            return FindValue<MetricUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkProtocol.
    /// </summary>
    public class NetworkProtocol : ConstantClass
    {

        /// <summary>
        /// Constant All for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol All = new NetworkProtocol("all");
        /// <summary>
        /// Constant Icmp for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol Icmp = new NetworkProtocol("icmp");
        /// <summary>
        /// Constant Tcp for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol Tcp = new NetworkProtocol("tcp");
        /// <summary>
        /// Constant Udp for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol Udp = new NetworkProtocol("udp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkProtocol FindValue(string value)
        {
            return FindValue<NetworkProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkProtocol(string value)
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
        /// Constant Completed for OperationStatus
        /// </summary>
        public static readonly OperationStatus Completed = new OperationStatus("Completed");
        /// <summary>
        /// Constant Failed for OperationStatus
        /// </summary>
        public static readonly OperationStatus Failed = new OperationStatus("Failed");
        /// <summary>
        /// Constant NotStarted for OperationStatus
        /// </summary>
        public static readonly OperationStatus NotStarted = new OperationStatus("NotStarted");
        /// <summary>
        /// Constant Started for OperationStatus
        /// </summary>
        public static readonly OperationStatus Started = new OperationStatus("Started");
        /// <summary>
        /// Constant Succeeded for OperationStatus
        /// </summary>
        public static readonly OperationStatus Succeeded = new OperationStatus("Succeeded");

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
        /// Constant AllocateStaticIp for OperationType
        /// </summary>
        public static readonly OperationType AllocateStaticIp = new OperationType("AllocateStaticIp");
        /// <summary>
        /// Constant AttachCertificateToDistribution for OperationType
        /// </summary>
        public static readonly OperationType AttachCertificateToDistribution = new OperationType("AttachCertificateToDistribution");
        /// <summary>
        /// Constant AttachDisk for OperationType
        /// </summary>
        public static readonly OperationType AttachDisk = new OperationType("AttachDisk");
        /// <summary>
        /// Constant AttachInstancesToLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType AttachInstancesToLoadBalancer = new OperationType("AttachInstancesToLoadBalancer");
        /// <summary>
        /// Constant AttachLoadBalancerTlsCertificate for OperationType
        /// </summary>
        public static readonly OperationType AttachLoadBalancerTlsCertificate = new OperationType("AttachLoadBalancerTlsCertificate");
        /// <summary>
        /// Constant AttachStaticIp for OperationType
        /// </summary>
        public static readonly OperationType AttachStaticIp = new OperationType("AttachStaticIp");
        /// <summary>
        /// Constant CloseInstancePublicPorts for OperationType
        /// </summary>
        public static readonly OperationType CloseInstancePublicPorts = new OperationType("CloseInstancePublicPorts");
        /// <summary>
        /// Constant CreateCertificate for OperationType
        /// </summary>
        public static readonly OperationType CreateCertificate = new OperationType("CreateCertificate");
        /// <summary>
        /// Constant CreateContactMethod for OperationType
        /// </summary>
        public static readonly OperationType CreateContactMethod = new OperationType("CreateContactMethod");
        /// <summary>
        /// Constant CreateContainerService for OperationType
        /// </summary>
        public static readonly OperationType CreateContainerService = new OperationType("CreateContainerService");
        /// <summary>
        /// Constant CreateContainerServiceDeployment for OperationType
        /// </summary>
        public static readonly OperationType CreateContainerServiceDeployment = new OperationType("CreateContainerServiceDeployment");
        /// <summary>
        /// Constant CreateContainerServiceRegistryLogin for OperationType
        /// </summary>
        public static readonly OperationType CreateContainerServiceRegistryLogin = new OperationType("CreateContainerServiceRegistryLogin");
        /// <summary>
        /// Constant CreateDisk for OperationType
        /// </summary>
        public static readonly OperationType CreateDisk = new OperationType("CreateDisk");
        /// <summary>
        /// Constant CreateDiskFromSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateDiskFromSnapshot = new OperationType("CreateDiskFromSnapshot");
        /// <summary>
        /// Constant CreateDiskSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateDiskSnapshot = new OperationType("CreateDiskSnapshot");
        /// <summary>
        /// Constant CreateDistribution for OperationType
        /// </summary>
        public static readonly OperationType CreateDistribution = new OperationType("CreateDistribution");
        /// <summary>
        /// Constant CreateDomain for OperationType
        /// </summary>
        public static readonly OperationType CreateDomain = new OperationType("CreateDomain");
        /// <summary>
        /// Constant CreateInstance for OperationType
        /// </summary>
        public static readonly OperationType CreateInstance = new OperationType("CreateInstance");
        /// <summary>
        /// Constant CreateInstancesFromSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateInstancesFromSnapshot = new OperationType("CreateInstancesFromSnapshot");
        /// <summary>
        /// Constant CreateInstanceSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateInstanceSnapshot = new OperationType("CreateInstanceSnapshot");
        /// <summary>
        /// Constant CreateLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType CreateLoadBalancer = new OperationType("CreateLoadBalancer");
        /// <summary>
        /// Constant CreateLoadBalancerTlsCertificate for OperationType
        /// </summary>
        public static readonly OperationType CreateLoadBalancerTlsCertificate = new OperationType("CreateLoadBalancerTlsCertificate");
        /// <summary>
        /// Constant CreateRelationalDatabase for OperationType
        /// </summary>
        public static readonly OperationType CreateRelationalDatabase = new OperationType("CreateRelationalDatabase");
        /// <summary>
        /// Constant CreateRelationalDatabaseFromSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateRelationalDatabaseFromSnapshot = new OperationType("CreateRelationalDatabaseFromSnapshot");
        /// <summary>
        /// Constant CreateRelationalDatabaseSnapshot for OperationType
        /// </summary>
        public static readonly OperationType CreateRelationalDatabaseSnapshot = new OperationType("CreateRelationalDatabaseSnapshot");
        /// <summary>
        /// Constant DeleteAlarm for OperationType
        /// </summary>
        public static readonly OperationType DeleteAlarm = new OperationType("DeleteAlarm");
        /// <summary>
        /// Constant DeleteCertificate for OperationType
        /// </summary>
        public static readonly OperationType DeleteCertificate = new OperationType("DeleteCertificate");
        /// <summary>
        /// Constant DeleteContactMethod for OperationType
        /// </summary>
        public static readonly OperationType DeleteContactMethod = new OperationType("DeleteContactMethod");
        /// <summary>
        /// Constant DeleteContainerImage for OperationType
        /// </summary>
        public static readonly OperationType DeleteContainerImage = new OperationType("DeleteContainerImage");
        /// <summary>
        /// Constant DeleteContainerService for OperationType
        /// </summary>
        public static readonly OperationType DeleteContainerService = new OperationType("DeleteContainerService");
        /// <summary>
        /// Constant DeleteDisk for OperationType
        /// </summary>
        public static readonly OperationType DeleteDisk = new OperationType("DeleteDisk");
        /// <summary>
        /// Constant DeleteDiskSnapshot for OperationType
        /// </summary>
        public static readonly OperationType DeleteDiskSnapshot = new OperationType("DeleteDiskSnapshot");
        /// <summary>
        /// Constant DeleteDistribution for OperationType
        /// </summary>
        public static readonly OperationType DeleteDistribution = new OperationType("DeleteDistribution");
        /// <summary>
        /// Constant DeleteDomain for OperationType
        /// </summary>
        public static readonly OperationType DeleteDomain = new OperationType("DeleteDomain");
        /// <summary>
        /// Constant DeleteDomainEntry for OperationType
        /// </summary>
        public static readonly OperationType DeleteDomainEntry = new OperationType("DeleteDomainEntry");
        /// <summary>
        /// Constant DeleteInstance for OperationType
        /// </summary>
        public static readonly OperationType DeleteInstance = new OperationType("DeleteInstance");
        /// <summary>
        /// Constant DeleteInstanceSnapshot for OperationType
        /// </summary>
        public static readonly OperationType DeleteInstanceSnapshot = new OperationType("DeleteInstanceSnapshot");
        /// <summary>
        /// Constant DeleteKnownHostKeys for OperationType
        /// </summary>
        public static readonly OperationType DeleteKnownHostKeys = new OperationType("DeleteKnownHostKeys");
        /// <summary>
        /// Constant DeleteLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType DeleteLoadBalancer = new OperationType("DeleteLoadBalancer");
        /// <summary>
        /// Constant DeleteLoadBalancerTlsCertificate for OperationType
        /// </summary>
        public static readonly OperationType DeleteLoadBalancerTlsCertificate = new OperationType("DeleteLoadBalancerTlsCertificate");
        /// <summary>
        /// Constant DeleteRelationalDatabase for OperationType
        /// </summary>
        public static readonly OperationType DeleteRelationalDatabase = new OperationType("DeleteRelationalDatabase");
        /// <summary>
        /// Constant DeleteRelationalDatabaseSnapshot for OperationType
        /// </summary>
        public static readonly OperationType DeleteRelationalDatabaseSnapshot = new OperationType("DeleteRelationalDatabaseSnapshot");
        /// <summary>
        /// Constant DetachCertificateFromDistribution for OperationType
        /// </summary>
        public static readonly OperationType DetachCertificateFromDistribution = new OperationType("DetachCertificateFromDistribution");
        /// <summary>
        /// Constant DetachDisk for OperationType
        /// </summary>
        public static readonly OperationType DetachDisk = new OperationType("DetachDisk");
        /// <summary>
        /// Constant DetachInstancesFromLoadBalancer for OperationType
        /// </summary>
        public static readonly OperationType DetachInstancesFromLoadBalancer = new OperationType("DetachInstancesFromLoadBalancer");
        /// <summary>
        /// Constant DetachStaticIp for OperationType
        /// </summary>
        public static readonly OperationType DetachStaticIp = new OperationType("DetachStaticIp");
        /// <summary>
        /// Constant DisableAddOn for OperationType
        /// </summary>
        public static readonly OperationType DisableAddOn = new OperationType("DisableAddOn");
        /// <summary>
        /// Constant EnableAddOn for OperationType
        /// </summary>
        public static readonly OperationType EnableAddOn = new OperationType("EnableAddOn");
        /// <summary>
        /// Constant GetAlarms for OperationType
        /// </summary>
        public static readonly OperationType GetAlarms = new OperationType("GetAlarms");
        /// <summary>
        /// Constant GetContactMethods for OperationType
        /// </summary>
        public static readonly OperationType GetContactMethods = new OperationType("GetContactMethods");
        /// <summary>
        /// Constant OpenInstancePublicPorts for OperationType
        /// </summary>
        public static readonly OperationType OpenInstancePublicPorts = new OperationType("OpenInstancePublicPorts");
        /// <summary>
        /// Constant PutAlarm for OperationType
        /// </summary>
        public static readonly OperationType PutAlarm = new OperationType("PutAlarm");
        /// <summary>
        /// Constant PutInstancePublicPorts for OperationType
        /// </summary>
        public static readonly OperationType PutInstancePublicPorts = new OperationType("PutInstancePublicPorts");
        /// <summary>
        /// Constant RebootInstance for OperationType
        /// </summary>
        public static readonly OperationType RebootInstance = new OperationType("RebootInstance");
        /// <summary>
        /// Constant RebootRelationalDatabase for OperationType
        /// </summary>
        public static readonly OperationType RebootRelationalDatabase = new OperationType("RebootRelationalDatabase");
        /// <summary>
        /// Constant RegisterContainerImage for OperationType
        /// </summary>
        public static readonly OperationType RegisterContainerImage = new OperationType("RegisterContainerImage");
        /// <summary>
        /// Constant ReleaseStaticIp for OperationType
        /// </summary>
        public static readonly OperationType ReleaseStaticIp = new OperationType("ReleaseStaticIp");
        /// <summary>
        /// Constant ResetDistributionCache for OperationType
        /// </summary>
        public static readonly OperationType ResetDistributionCache = new OperationType("ResetDistributionCache");
        /// <summary>
        /// Constant SendContactMethodVerification for OperationType
        /// </summary>
        public static readonly OperationType SendContactMethodVerification = new OperationType("SendContactMethodVerification");
        /// <summary>
        /// Constant SetIpAddressType for OperationType
        /// </summary>
        public static readonly OperationType SetIpAddressType = new OperationType("SetIpAddressType");
        /// <summary>
        /// Constant StartInstance for OperationType
        /// </summary>
        public static readonly OperationType StartInstance = new OperationType("StartInstance");
        /// <summary>
        /// Constant StartRelationalDatabase for OperationType
        /// </summary>
        public static readonly OperationType StartRelationalDatabase = new OperationType("StartRelationalDatabase");
        /// <summary>
        /// Constant StopInstance for OperationType
        /// </summary>
        public static readonly OperationType StopInstance = new OperationType("StopInstance");
        /// <summary>
        /// Constant StopRelationalDatabase for OperationType
        /// </summary>
        public static readonly OperationType StopRelationalDatabase = new OperationType("StopRelationalDatabase");
        /// <summary>
        /// Constant TestAlarm for OperationType
        /// </summary>
        public static readonly OperationType TestAlarm = new OperationType("TestAlarm");
        /// <summary>
        /// Constant UpdateContainerService for OperationType
        /// </summary>
        public static readonly OperationType UpdateContainerService = new OperationType("UpdateContainerService");
        /// <summary>
        /// Constant UpdateDistribution for OperationType
        /// </summary>
        public static readonly OperationType UpdateDistribution = new OperationType("UpdateDistribution");
        /// <summary>
        /// Constant UpdateDistributionBundle for OperationType
        /// </summary>
        public static readonly OperationType UpdateDistributionBundle = new OperationType("UpdateDistributionBundle");
        /// <summary>
        /// Constant UpdateDomainEntry for OperationType
        /// </summary>
        public static readonly OperationType UpdateDomainEntry = new OperationType("UpdateDomainEntry");
        /// <summary>
        /// Constant UpdateLoadBalancerAttribute for OperationType
        /// </summary>
        public static readonly OperationType UpdateLoadBalancerAttribute = new OperationType("UpdateLoadBalancerAttribute");
        /// <summary>
        /// Constant UpdateRelationalDatabase for OperationType
        /// </summary>
        public static readonly OperationType UpdateRelationalDatabase = new OperationType("UpdateRelationalDatabase");
        /// <summary>
        /// Constant UpdateRelationalDatabaseParameters for OperationType
        /// </summary>
        public static readonly OperationType UpdateRelationalDatabaseParameters = new OperationType("UpdateRelationalDatabaseParameters");

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
    /// Constants used for properties of type OriginProtocolPolicyEnum.
    /// </summary>
    public class OriginProtocolPolicyEnum : ConstantClass
    {

        /// <summary>
        /// Constant HttpOnly for OriginProtocolPolicyEnum
        /// </summary>
        public static readonly OriginProtocolPolicyEnum HttpOnly = new OriginProtocolPolicyEnum("http-only");
        /// <summary>
        /// Constant HttpsOnly for OriginProtocolPolicyEnum
        /// </summary>
        public static readonly OriginProtocolPolicyEnum HttpsOnly = new OriginProtocolPolicyEnum("https-only");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginProtocolPolicyEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginProtocolPolicyEnum FindValue(string value)
        {
            return FindValue<OriginProtocolPolicyEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginProtocolPolicyEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortAccessType.
    /// </summary>
    public class PortAccessType : ConstantClass
    {

        /// <summary>
        /// Constant Private for PortAccessType
        /// </summary>
        public static readonly PortAccessType Private = new PortAccessType("Private");
        /// <summary>
        /// Constant Public for PortAccessType
        /// </summary>
        public static readonly PortAccessType Public = new PortAccessType("Public");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortAccessType FindValue(string value)
        {
            return FindValue<PortAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortInfoSourceType.
    /// </summary>
    public class PortInfoSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for PortInfoSourceType
        /// </summary>
        public static readonly PortInfoSourceType CLOSED = new PortInfoSourceType("CLOSED");
        /// <summary>
        /// Constant DEFAULT for PortInfoSourceType
        /// </summary>
        public static readonly PortInfoSourceType DEFAULT = new PortInfoSourceType("DEFAULT");
        /// <summary>
        /// Constant INSTANCE for PortInfoSourceType
        /// </summary>
        public static readonly PortInfoSourceType INSTANCE = new PortInfoSourceType("INSTANCE");
        /// <summary>
        /// Constant NONE for PortInfoSourceType
        /// </summary>
        public static readonly PortInfoSourceType NONE = new PortInfoSourceType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortInfoSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortInfoSourceType FindValue(string value)
        {
            return FindValue<PortInfoSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortInfoSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortState.
    /// </summary>
    public class PortState : ConstantClass
    {

        /// <summary>
        /// Constant Closed for PortState
        /// </summary>
        public static readonly PortState Closed = new PortState("closed");
        /// <summary>
        /// Constant Open for PortState
        /// </summary>
        public static readonly PortState Open = new PortState("open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortState FindValue(string value)
        {
            return FindValue<PortState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordState.
    /// </summary>
    public class RecordState : ConstantClass
    {

        /// <summary>
        /// Constant Failed for RecordState
        /// </summary>
        public static readonly RecordState Failed = new RecordState("Failed");
        /// <summary>
        /// Constant Started for RecordState
        /// </summary>
        public static readonly RecordState Started = new RecordState("Started");
        /// <summary>
        /// Constant Succeeded for RecordState
        /// </summary>
        public static readonly RecordState Succeeded = new RecordState("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordState FindValue(string value)
        {
            return FindValue<RecordState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionName.
    /// </summary>
    public class RegionName : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for RegionName
        /// </summary>
        public static readonly RegionName ApNortheast1 = new RegionName("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for RegionName
        /// </summary>
        public static readonly RegionName ApNortheast2 = new RegionName("ap-northeast-2");
        /// <summary>
        /// Constant ApSouth1 for RegionName
        /// </summary>
        public static readonly RegionName ApSouth1 = new RegionName("ap-south-1");
        /// <summary>
        /// Constant ApSoutheast1 for RegionName
        /// </summary>
        public static readonly RegionName ApSoutheast1 = new RegionName("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for RegionName
        /// </summary>
        public static readonly RegionName ApSoutheast2 = new RegionName("ap-southeast-2");
        /// <summary>
        /// Constant CaCentral1 for RegionName
        /// </summary>
        public static readonly RegionName CaCentral1 = new RegionName("ca-central-1");
        /// <summary>
        /// Constant EuCentral1 for RegionName
        /// </summary>
        public static readonly RegionName EuCentral1 = new RegionName("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for RegionName
        /// </summary>
        public static readonly RegionName EuWest1 = new RegionName("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for RegionName
        /// </summary>
        public static readonly RegionName EuWest2 = new RegionName("eu-west-2");
        /// <summary>
        /// Constant EuWest3 for RegionName
        /// </summary>
        public static readonly RegionName EuWest3 = new RegionName("eu-west-3");
        /// <summary>
        /// Constant UsEast1 for RegionName
        /// </summary>
        public static readonly RegionName UsEast1 = new RegionName("us-east-1");
        /// <summary>
        /// Constant UsEast2 for RegionName
        /// </summary>
        public static readonly RegionName UsEast2 = new RegionName("us-east-2");
        /// <summary>
        /// Constant UsWest1 for RegionName
        /// </summary>
        public static readonly RegionName UsWest1 = new RegionName("us-west-1");
        /// <summary>
        /// Constant UsWest2 for RegionName
        /// </summary>
        public static readonly RegionName UsWest2 = new RegionName("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionName FindValue(string value)
        {
            return FindValue<RegionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelationalDatabaseEngine.
    /// </summary>
    public class RelationalDatabaseEngine : ConstantClass
    {

        /// <summary>
        /// Constant Mysql for RelationalDatabaseEngine
        /// </summary>
        public static readonly RelationalDatabaseEngine Mysql = new RelationalDatabaseEngine("mysql");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationalDatabaseEngine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationalDatabaseEngine FindValue(string value)
        {
            return FindValue<RelationalDatabaseEngine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationalDatabaseEngine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelationalDatabaseMetricName.
    /// </summary>
    public class RelationalDatabaseMetricName : ConstantClass
    {

        /// <summary>
        /// Constant CPUUtilization for RelationalDatabaseMetricName
        /// </summary>
        public static readonly RelationalDatabaseMetricName CPUUtilization = new RelationalDatabaseMetricName("CPUUtilization");
        /// <summary>
        /// Constant DatabaseConnections for RelationalDatabaseMetricName
        /// </summary>
        public static readonly RelationalDatabaseMetricName DatabaseConnections = new RelationalDatabaseMetricName("DatabaseConnections");
        /// <summary>
        /// Constant DiskQueueDepth for RelationalDatabaseMetricName
        /// </summary>
        public static readonly RelationalDatabaseMetricName DiskQueueDepth = new RelationalDatabaseMetricName("DiskQueueDepth");
        /// <summary>
        /// Constant FreeStorageSpace for RelationalDatabaseMetricName
        /// </summary>
        public static readonly RelationalDatabaseMetricName FreeStorageSpace = new RelationalDatabaseMetricName("FreeStorageSpace");
        /// <summary>
        /// Constant NetworkReceiveThroughput for RelationalDatabaseMetricName
        /// </summary>
        public static readonly RelationalDatabaseMetricName NetworkReceiveThroughput = new RelationalDatabaseMetricName("NetworkReceiveThroughput");
        /// <summary>
        /// Constant NetworkTransmitThroughput for RelationalDatabaseMetricName
        /// </summary>
        public static readonly RelationalDatabaseMetricName NetworkTransmitThroughput = new RelationalDatabaseMetricName("NetworkTransmitThroughput");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationalDatabaseMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationalDatabaseMetricName FindValue(string value)
        {
            return FindValue<RelationalDatabaseMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationalDatabaseMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelationalDatabasePasswordVersion.
    /// </summary>
    public class RelationalDatabasePasswordVersion : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT for RelationalDatabasePasswordVersion
        /// </summary>
        public static readonly RelationalDatabasePasswordVersion CURRENT = new RelationalDatabasePasswordVersion("CURRENT");
        /// <summary>
        /// Constant PENDING for RelationalDatabasePasswordVersion
        /// </summary>
        public static readonly RelationalDatabasePasswordVersion PENDING = new RelationalDatabasePasswordVersion("PENDING");
        /// <summary>
        /// Constant PREVIOUS for RelationalDatabasePasswordVersion
        /// </summary>
        public static readonly RelationalDatabasePasswordVersion PREVIOUS = new RelationalDatabasePasswordVersion("PREVIOUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationalDatabasePasswordVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationalDatabasePasswordVersion FindValue(string value)
        {
            return FindValue<RelationalDatabasePasswordVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationalDatabasePasswordVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenewalStatus.
    /// </summary>
    public class RenewalStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus Failed = new RenewalStatus("Failed");
        /// <summary>
        /// Constant PendingAutoRenewal for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus PendingAutoRenewal = new RenewalStatus("PendingAutoRenewal");
        /// <summary>
        /// Constant PendingValidation for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus PendingValidation = new RenewalStatus("PendingValidation");
        /// <summary>
        /// Constant Success for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus Success = new RenewalStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenewalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenewalStatus FindValue(string value)
        {
            return FindValue<RenewalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenewalStatus(string value)
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
        /// Constant Alarm for ResourceType
        /// </summary>
        public static readonly ResourceType Alarm = new ResourceType("Alarm");
        /// <summary>
        /// Constant Certificate for ResourceType
        /// </summary>
        public static readonly ResourceType Certificate = new ResourceType("Certificate");
        /// <summary>
        /// Constant CloudFormationStackRecord for ResourceType
        /// </summary>
        public static readonly ResourceType CloudFormationStackRecord = new ResourceType("CloudFormationStackRecord");
        /// <summary>
        /// Constant ContactMethod for ResourceType
        /// </summary>
        public static readonly ResourceType ContactMethod = new ResourceType("ContactMethod");
        /// <summary>
        /// Constant ContainerService for ResourceType
        /// </summary>
        public static readonly ResourceType ContainerService = new ResourceType("ContainerService");
        /// <summary>
        /// Constant Disk for ResourceType
        /// </summary>
        public static readonly ResourceType Disk = new ResourceType("Disk");
        /// <summary>
        /// Constant DiskSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType DiskSnapshot = new ResourceType("DiskSnapshot");
        /// <summary>
        /// Constant Distribution for ResourceType
        /// </summary>
        public static readonly ResourceType Distribution = new ResourceType("Distribution");
        /// <summary>
        /// Constant Domain for ResourceType
        /// </summary>
        public static readonly ResourceType Domain = new ResourceType("Domain");
        /// <summary>
        /// Constant ExportSnapshotRecord for ResourceType
        /// </summary>
        public static readonly ResourceType ExportSnapshotRecord = new ResourceType("ExportSnapshotRecord");
        /// <summary>
        /// Constant Instance for ResourceType
        /// </summary>
        public static readonly ResourceType Instance = new ResourceType("Instance");
        /// <summary>
        /// Constant InstanceSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType InstanceSnapshot = new ResourceType("InstanceSnapshot");
        /// <summary>
        /// Constant KeyPair for ResourceType
        /// </summary>
        public static readonly ResourceType KeyPair = new ResourceType("KeyPair");
        /// <summary>
        /// Constant LoadBalancer for ResourceType
        /// </summary>
        public static readonly ResourceType LoadBalancer = new ResourceType("LoadBalancer");
        /// <summary>
        /// Constant LoadBalancerTlsCertificate for ResourceType
        /// </summary>
        public static readonly ResourceType LoadBalancerTlsCertificate = new ResourceType("LoadBalancerTlsCertificate");
        /// <summary>
        /// Constant PeeredVpc for ResourceType
        /// </summary>
        public static readonly ResourceType PeeredVpc = new ResourceType("PeeredVpc");
        /// <summary>
        /// Constant RelationalDatabase for ResourceType
        /// </summary>
        public static readonly ResourceType RelationalDatabase = new ResourceType("RelationalDatabase");
        /// <summary>
        /// Constant RelationalDatabaseSnapshot for ResourceType
        /// </summary>
        public static readonly ResourceType RelationalDatabaseSnapshot = new ResourceType("RelationalDatabaseSnapshot");
        /// <summary>
        /// Constant StaticIp for ResourceType
        /// </summary>
        public static readonly ResourceType StaticIp = new ResourceType("StaticIp");

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
    /// Constants used for properties of type TreatMissingData.
    /// </summary>
    public class TreatMissingData : ConstantClass
    {

        /// <summary>
        /// Constant Breaching for TreatMissingData
        /// </summary>
        public static readonly TreatMissingData Breaching = new TreatMissingData("breaching");
        /// <summary>
        /// Constant Ignore for TreatMissingData
        /// </summary>
        public static readonly TreatMissingData Ignore = new TreatMissingData("ignore");
        /// <summary>
        /// Constant Missing for TreatMissingData
        /// </summary>
        public static readonly TreatMissingData Missing = new TreatMissingData("missing");
        /// <summary>
        /// Constant NotBreaching for TreatMissingData
        /// </summary>
        public static readonly TreatMissingData NotBreaching = new TreatMissingData("notBreaching");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TreatMissingData(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TreatMissingData FindValue(string value)
        {
            return FindValue<TreatMissingData>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TreatMissingData(string value)
        {
            return FindValue(value);
        }
    }

}