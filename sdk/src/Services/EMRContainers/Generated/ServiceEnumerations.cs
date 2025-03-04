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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EMRContainers
{

    /// <summary>
    /// Constants used for properties of type AllowAWSToRetainLogs.
    /// </summary>
    public class AllowAWSToRetainLogs : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AllowAWSToRetainLogs
        /// </summary>
        public static readonly AllowAWSToRetainLogs DISABLED = new AllowAWSToRetainLogs("DISABLED");
        /// <summary>
        /// Constant ENABLED for AllowAWSToRetainLogs
        /// </summary>
        public static readonly AllowAWSToRetainLogs ENABLED = new AllowAWSToRetainLogs("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowAWSToRetainLogs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowAWSToRetainLogs FindValue(string value)
        {
            return FindValue<AllowAWSToRetainLogs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowAWSToRetainLogs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateProviderType.
    /// </summary>
    public class CertificateProviderType : ConstantClass
    {

        /// <summary>
        /// Constant PEM for CertificateProviderType
        /// </summary>
        public static readonly CertificateProviderType PEM = new CertificateProviderType("PEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateProviderType FindValue(string value)
        {
            return FindValue<CertificateProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerProviderType.
    /// </summary>
    public class ContainerProviderType : ConstantClass
    {

        /// <summary>
        /// Constant EKS for ContainerProviderType
        /// </summary>
        public static readonly ContainerProviderType EKS = new ContainerProviderType("EKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerProviderType FindValue(string value)
        {
            return FindValue<ContainerProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointState.
    /// </summary>
    public class EndpointState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EndpointState
        /// </summary>
        public static readonly EndpointState ACTIVE = new EndpointState("ACTIVE");
        /// <summary>
        /// Constant CREATING for EndpointState
        /// </summary>
        public static readonly EndpointState CREATING = new EndpointState("CREATING");
        /// <summary>
        /// Constant TERMINATED for EndpointState
        /// </summary>
        public static readonly EndpointState TERMINATED = new EndpointState("TERMINATED");
        /// <summary>
        /// Constant TERMINATED_WITH_ERRORS for EndpointState
        /// </summary>
        public static readonly EndpointState TERMINATED_WITH_ERRORS = new EndpointState("TERMINATED_WITH_ERRORS");
        /// <summary>
        /// Constant TERMINATING for EndpointState
        /// </summary>
        public static readonly EndpointState TERMINATING = new EndpointState("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointState FindValue(string value)
        {
            return FindValue<EndpointState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureReason.
    /// </summary>
    public class FailureReason : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER_UNAVAILABLE for FailureReason
        /// </summary>
        public static readonly FailureReason CLUSTER_UNAVAILABLE = new FailureReason("CLUSTER_UNAVAILABLE");
        /// <summary>
        /// Constant INTERNAL_ERROR for FailureReason
        /// </summary>
        public static readonly FailureReason INTERNAL_ERROR = new FailureReason("INTERNAL_ERROR");
        /// <summary>
        /// Constant USER_ERROR for FailureReason
        /// </summary>
        public static readonly FailureReason USER_ERROR = new FailureReason("USER_ERROR");
        /// <summary>
        /// Constant VALIDATION_ERROR for FailureReason
        /// </summary>
        public static readonly FailureReason VALIDATION_ERROR = new FailureReason("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureReason FindValue(string value)
        {
            return FindValue<FailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobRunState.
    /// </summary>
    public class JobRunState : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL_PENDING for JobRunState
        /// </summary>
        public static readonly JobRunState CANCEL_PENDING = new JobRunState("CANCEL_PENDING");
        /// <summary>
        /// Constant CANCELLED for JobRunState
        /// </summary>
        public static readonly JobRunState CANCELLED = new JobRunState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for JobRunState
        /// </summary>
        public static readonly JobRunState COMPLETED = new JobRunState("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobRunState
        /// </summary>
        public static readonly JobRunState FAILED = new JobRunState("FAILED");
        /// <summary>
        /// Constant PENDING for JobRunState
        /// </summary>
        public static readonly JobRunState PENDING = new JobRunState("PENDING");
        /// <summary>
        /// Constant RUNNING for JobRunState
        /// </summary>
        public static readonly JobRunState RUNNING = new JobRunState("RUNNING");
        /// <summary>
        /// Constant SUBMITTED for JobRunState
        /// </summary>
        public static readonly JobRunState SUBMITTED = new JobRunState("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobRunState FindValue(string value)
        {
            return FindValue<JobRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PersistentAppUI.
    /// </summary>
    public class PersistentAppUI : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PersistentAppUI
        /// </summary>
        public static readonly PersistentAppUI DISABLED = new PersistentAppUI("DISABLED");
        /// <summary>
        /// Constant ENABLED for PersistentAppUI
        /// </summary>
        public static readonly PersistentAppUI ENABLED = new PersistentAppUI("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PersistentAppUI(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PersistentAppUI FindValue(string value)
        {
            return FindValue<PersistentAppUI>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PersistentAppUI(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateParameterDataType.
    /// </summary>
    public class TemplateParameterDataType : ConstantClass
    {

        /// <summary>
        /// Constant NUMBER for TemplateParameterDataType
        /// </summary>
        public static readonly TemplateParameterDataType NUMBER = new TemplateParameterDataType("NUMBER");
        /// <summary>
        /// Constant STRING for TemplateParameterDataType
        /// </summary>
        public static readonly TemplateParameterDataType STRING = new TemplateParameterDataType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateParameterDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateParameterDataType FindValue(string value)
        {
            return FindValue<TemplateParameterDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateParameterDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualClusterState.
    /// </summary>
    public class VirtualClusterState : ConstantClass
    {

        /// <summary>
        /// Constant ARRESTED for VirtualClusterState
        /// </summary>
        public static readonly VirtualClusterState ARRESTED = new VirtualClusterState("ARRESTED");
        /// <summary>
        /// Constant RUNNING for VirtualClusterState
        /// </summary>
        public static readonly VirtualClusterState RUNNING = new VirtualClusterState("RUNNING");
        /// <summary>
        /// Constant TERMINATED for VirtualClusterState
        /// </summary>
        public static readonly VirtualClusterState TERMINATED = new VirtualClusterState("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for VirtualClusterState
        /// </summary>
        public static readonly VirtualClusterState TERMINATING = new VirtualClusterState("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualClusterState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualClusterState FindValue(string value)
        {
            return FindValue<VirtualClusterState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualClusterState(string value)
        {
            return FindValue(value);
        }
    }

}