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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Redshift
{

    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant RecommendNodeConfig for ActionType
        /// </summary>
        public static readonly ActionType RecommendNodeConfig = new ActionType("recommend-node-config");
        /// <summary>
        /// Constant ResizeCluster for ActionType
        /// </summary>
        public static readonly ActionType ResizeCluster = new ActionType("resize-cluster");
        /// <summary>
        /// Constant RestoreCluster for ActionType
        /// </summary>
        public static readonly ActionType RestoreCluster = new ActionType("restore-cluster");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AquaConfigurationStatus.
    /// </summary>
    public class AquaConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Auto for AquaConfigurationStatus
        /// </summary>
        public static readonly AquaConfigurationStatus Auto = new AquaConfigurationStatus("auto");
        /// <summary>
        /// Constant Disabled for AquaConfigurationStatus
        /// </summary>
        public static readonly AquaConfigurationStatus Disabled = new AquaConfigurationStatus("disabled");
        /// <summary>
        /// Constant Enabled for AquaConfigurationStatus
        /// </summary>
        public static readonly AquaConfigurationStatus Enabled = new AquaConfigurationStatus("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AquaConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AquaConfigurationStatus FindValue(string value)
        {
            return FindValue<AquaConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AquaConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AquaStatus.
    /// </summary>
    public class AquaStatus : ConstantClass
    {

        /// <summary>
        /// Constant Applying for AquaStatus
        /// </summary>
        public static readonly AquaStatus Applying = new AquaStatus("applying");
        /// <summary>
        /// Constant Disabled for AquaStatus
        /// </summary>
        public static readonly AquaStatus Disabled = new AquaStatus("disabled");
        /// <summary>
        /// Constant Enabled for AquaStatus
        /// </summary>
        public static readonly AquaStatus Enabled = new AquaStatus("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AquaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AquaStatus FindValue(string value)
        {
            return FindValue<AquaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AquaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthorizationStatus.
    /// </summary>
    public class AuthorizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Authorized for AuthorizationStatus
        /// </summary>
        public static readonly AuthorizationStatus Authorized = new AuthorizationStatus("Authorized");
        /// <summary>
        /// Constant Revoking for AuthorizationStatus
        /// </summary>
        public static readonly AuthorizationStatus Revoking = new AuthorizationStatus("Revoking");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizationStatus FindValue(string value)
        {
            return FindValue<AuthorizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataShareStatus.
    /// </summary>
    public class DataShareStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DataShareStatus
        /// </summary>
        public static readonly DataShareStatus ACTIVE = new DataShareStatus("ACTIVE");
        /// <summary>
        /// Constant AUTHORIZED for DataShareStatus
        /// </summary>
        public static readonly DataShareStatus AUTHORIZED = new DataShareStatus("AUTHORIZED");
        /// <summary>
        /// Constant AVAILABLE for DataShareStatus
        /// </summary>
        public static readonly DataShareStatus AVAILABLE = new DataShareStatus("AVAILABLE");
        /// <summary>
        /// Constant DEAUTHORIZED for DataShareStatus
        /// </summary>
        public static readonly DataShareStatus DEAUTHORIZED = new DataShareStatus("DEAUTHORIZED");
        /// <summary>
        /// Constant PENDING_AUTHORIZATION for DataShareStatus
        /// </summary>
        public static readonly DataShareStatus PENDING_AUTHORIZATION = new DataShareStatus("PENDING_AUTHORIZATION");
        /// <summary>
        /// Constant REJECTED for DataShareStatus
        /// </summary>
        public static readonly DataShareStatus REJECTED = new DataShareStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataShareStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataShareStatus FindValue(string value)
        {
            return FindValue<DataShareStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataShareStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataShareStatusForConsumer.
    /// </summary>
    public class DataShareStatusForConsumer : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DataShareStatusForConsumer
        /// </summary>
        public static readonly DataShareStatusForConsumer ACTIVE = new DataShareStatusForConsumer("ACTIVE");
        /// <summary>
        /// Constant AVAILABLE for DataShareStatusForConsumer
        /// </summary>
        public static readonly DataShareStatusForConsumer AVAILABLE = new DataShareStatusForConsumer("AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataShareStatusForConsumer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataShareStatusForConsumer FindValue(string value)
        {
            return FindValue<DataShareStatusForConsumer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataShareStatusForConsumer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataShareStatusForProducer.
    /// </summary>
    public class DataShareStatusForProducer : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DataShareStatusForProducer
        /// </summary>
        public static readonly DataShareStatusForProducer ACTIVE = new DataShareStatusForProducer("ACTIVE");
        /// <summary>
        /// Constant AUTHORIZED for DataShareStatusForProducer
        /// </summary>
        public static readonly DataShareStatusForProducer AUTHORIZED = new DataShareStatusForProducer("AUTHORIZED");
        /// <summary>
        /// Constant DEAUTHORIZED for DataShareStatusForProducer
        /// </summary>
        public static readonly DataShareStatusForProducer DEAUTHORIZED = new DataShareStatusForProducer("DEAUTHORIZED");
        /// <summary>
        /// Constant PENDING_AUTHORIZATION for DataShareStatusForProducer
        /// </summary>
        public static readonly DataShareStatusForProducer PENDING_AUTHORIZATION = new DataShareStatusForProducer("PENDING_AUTHORIZATION");
        /// <summary>
        /// Constant REJECTED for DataShareStatusForProducer
        /// </summary>
        public static readonly DataShareStatusForProducer REJECTED = new DataShareStatusForProducer("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataShareStatusForProducer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataShareStatusForProducer FindValue(string value)
        {
            return FindValue<DataShareStatusForProducer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataShareStatusForProducer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataShareType.
    /// </summary>
    public class DataShareType : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL for DataShareType
        /// </summary>
        public static readonly DataShareType INTERNAL = new DataShareType("INTERNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataShareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataShareType FindValue(string value)
        {
            return FindValue<DataShareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataShareType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescribeIntegrationsFilterName.
    /// </summary>
    public class DescribeIntegrationsFilterName : ConstantClass
    {

        /// <summary>
        /// Constant IntegrationArn for DescribeIntegrationsFilterName
        /// </summary>
        public static readonly DescribeIntegrationsFilterName IntegrationArn = new DescribeIntegrationsFilterName("integration-arn");
        /// <summary>
        /// Constant SourceArn for DescribeIntegrationsFilterName
        /// </summary>
        public static readonly DescribeIntegrationsFilterName SourceArn = new DescribeIntegrationsFilterName("source-arn");
        /// <summary>
        /// Constant SourceTypes for DescribeIntegrationsFilterName
        /// </summary>
        public static readonly DescribeIntegrationsFilterName SourceTypes = new DescribeIntegrationsFilterName("source-types");
        /// <summary>
        /// Constant Status for DescribeIntegrationsFilterName
        /// </summary>
        public static readonly DescribeIntegrationsFilterName Status = new DescribeIntegrationsFilterName("status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeIntegrationsFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeIntegrationsFilterName FindValue(string value)
        {
            return FindValue<DescribeIntegrationsFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeIntegrationsFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImpactRankingType.
    /// </summary>
    public class ImpactRankingType : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for ImpactRankingType
        /// </summary>
        public static readonly ImpactRankingType HIGH = new ImpactRankingType("HIGH");
        /// <summary>
        /// Constant LOW for ImpactRankingType
        /// </summary>
        public static readonly ImpactRankingType LOW = new ImpactRankingType("LOW");
        /// <summary>
        /// Constant MEDIUM for ImpactRankingType
        /// </summary>
        public static readonly ImpactRankingType MEDIUM = new ImpactRankingType("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImpactRankingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImpactRankingType FindValue(string value)
        {
            return FindValue<ImpactRankingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImpactRankingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDestinationType.
    /// </summary>
    public class LogDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant Cloudwatch for LogDestinationType
        /// </summary>
        public static readonly LogDestinationType Cloudwatch = new LogDestinationType("cloudwatch");
        /// <summary>
        /// Constant S3 for LogDestinationType
        /// </summary>
        public static readonly LogDestinationType S3 = new LogDestinationType("s3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDestinationType FindValue(string value)
        {
            return FindValue<LogDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mode.
    /// </summary>
    public class Mode : ConstantClass
    {

        /// <summary>
        /// Constant HighPerformance for Mode
        /// </summary>
        public static readonly Mode HighPerformance = new Mode("high-performance");
        /// <summary>
        /// Constant Standard for Mode
        /// </summary>
        public static readonly Mode Standard = new Mode("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mode FindValue(string value)
        {
            return FindValue<Mode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceRegistrationStatus.
    /// </summary>
    public class NamespaceRegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deregistering for NamespaceRegistrationStatus
        /// </summary>
        public static readonly NamespaceRegistrationStatus Deregistering = new NamespaceRegistrationStatus("Deregistering");
        /// <summary>
        /// Constant Registering for NamespaceRegistrationStatus
        /// </summary>
        public static readonly NamespaceRegistrationStatus Registering = new NamespaceRegistrationStatus("Registering");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceRegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceRegistrationStatus FindValue(string value)
        {
            return FindValue<NamespaceRegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceRegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeConfigurationOptionsFilterName.
    /// </summary>
    public class NodeConfigurationOptionsFilterName : ConstantClass
    {

        /// <summary>
        /// Constant EstimatedDiskUtilizationPercent for NodeConfigurationOptionsFilterName
        /// </summary>
        public static readonly NodeConfigurationOptionsFilterName EstimatedDiskUtilizationPercent = new NodeConfigurationOptionsFilterName("EstimatedDiskUtilizationPercent");
        /// <summary>
        /// Constant Mode for NodeConfigurationOptionsFilterName
        /// </summary>
        public static readonly NodeConfigurationOptionsFilterName Mode = new NodeConfigurationOptionsFilterName("Mode");
        /// <summary>
        /// Constant NodeType for NodeConfigurationOptionsFilterName
        /// </summary>
        public static readonly NodeConfigurationOptionsFilterName NodeType = new NodeConfigurationOptionsFilterName("NodeType");
        /// <summary>
        /// Constant NumberOfNodes for NodeConfigurationOptionsFilterName
        /// </summary>
        public static readonly NodeConfigurationOptionsFilterName NumberOfNodes = new NodeConfigurationOptionsFilterName("NumberOfNodes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeConfigurationOptionsFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeConfigurationOptionsFilterName FindValue(string value)
        {
            return FindValue<NodeConfigurationOptionsFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeConfigurationOptionsFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatorType.
    /// </summary>
    public class OperatorType : ConstantClass
    {

        /// <summary>
        /// Constant Between for OperatorType
        /// </summary>
        public static readonly OperatorType Between = new OperatorType("between");
        /// <summary>
        /// Constant Eq for OperatorType
        /// </summary>
        public static readonly OperatorType Eq = new OperatorType("eq");
        /// <summary>
        /// Constant Ge for OperatorType
        /// </summary>
        public static readonly OperatorType Ge = new OperatorType("ge");
        /// <summary>
        /// Constant Gt for OperatorType
        /// </summary>
        public static readonly OperatorType Gt = new OperatorType("gt");
        /// <summary>
        /// Constant In for OperatorType
        /// </summary>
        public static readonly OperatorType In = new OperatorType("in");
        /// <summary>
        /// Constant Le for OperatorType
        /// </summary>
        public static readonly OperatorType Le = new OperatorType("le");
        /// <summary>
        /// Constant Lt for OperatorType
        /// </summary>
        public static readonly OperatorType Lt = new OperatorType("lt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatorType FindValue(string value)
        {
            return FindValue<OperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterApplyType.
    /// </summary>
    public class ParameterApplyType : ConstantClass
    {

        /// <summary>
        /// Constant Dynamic for ParameterApplyType
        /// </summary>
        public static readonly ParameterApplyType Dynamic = new ParameterApplyType("dynamic");
        /// <summary>
        /// Constant Static for ParameterApplyType
        /// </summary>
        public static readonly ParameterApplyType Static = new ParameterApplyType("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterApplyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterApplyType FindValue(string value)
        {
            return FindValue<ParameterApplyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterApplyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartnerIntegrationStatus.
    /// </summary>
    public class PartnerIntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for PartnerIntegrationStatus
        /// </summary>
        public static readonly PartnerIntegrationStatus Active = new PartnerIntegrationStatus("Active");
        /// <summary>
        /// Constant ConnectionFailure for PartnerIntegrationStatus
        /// </summary>
        public static readonly PartnerIntegrationStatus ConnectionFailure = new PartnerIntegrationStatus("ConnectionFailure");
        /// <summary>
        /// Constant Inactive for PartnerIntegrationStatus
        /// </summary>
        public static readonly PartnerIntegrationStatus Inactive = new PartnerIntegrationStatus("Inactive");
        /// <summary>
        /// Constant RuntimeFailure for PartnerIntegrationStatus
        /// </summary>
        public static readonly PartnerIntegrationStatus RuntimeFailure = new PartnerIntegrationStatus("RuntimeFailure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartnerIntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartnerIntegrationStatus FindValue(string value)
        {
            return FindValue<PartnerIntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartnerIntegrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendedActionType.
    /// </summary>
    public class RecommendedActionType : ConstantClass
    {

        /// <summary>
        /// Constant CLI for RecommendedActionType
        /// </summary>
        public static readonly RecommendedActionType CLI = new RecommendedActionType("CLI");
        /// <summary>
        /// Constant SQL for RecommendedActionType
        /// </summary>
        public static readonly RecommendedActionType SQL = new RecommendedActionType("SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendedActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendedActionType FindValue(string value)
        {
            return FindValue<RecommendedActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendedActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservedNodeExchangeActionType.
    /// </summary>
    public class ReservedNodeExchangeActionType : ConstantClass
    {

        /// <summary>
        /// Constant ResizeCluster for ReservedNodeExchangeActionType
        /// </summary>
        public static readonly ReservedNodeExchangeActionType ResizeCluster = new ReservedNodeExchangeActionType("resize-cluster");
        /// <summary>
        /// Constant RestoreCluster for ReservedNodeExchangeActionType
        /// </summary>
        public static readonly ReservedNodeExchangeActionType RestoreCluster = new ReservedNodeExchangeActionType("restore-cluster");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservedNodeExchangeActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservedNodeExchangeActionType FindValue(string value)
        {
            return FindValue<ReservedNodeExchangeActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservedNodeExchangeActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservedNodeExchangeStatusType.
    /// </summary>
    public class ReservedNodeExchangeStatusType : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ReservedNodeExchangeStatusType
        /// </summary>
        public static readonly ReservedNodeExchangeStatusType FAILED = new ReservedNodeExchangeStatusType("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReservedNodeExchangeStatusType
        /// </summary>
        public static readonly ReservedNodeExchangeStatusType IN_PROGRESS = new ReservedNodeExchangeStatusType("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for ReservedNodeExchangeStatusType
        /// </summary>
        public static readonly ReservedNodeExchangeStatusType PENDING = new ReservedNodeExchangeStatusType("PENDING");
        /// <summary>
        /// Constant REQUESTED for ReservedNodeExchangeStatusType
        /// </summary>
        public static readonly ReservedNodeExchangeStatusType REQUESTED = new ReservedNodeExchangeStatusType("REQUESTED");
        /// <summary>
        /// Constant RETRYING for ReservedNodeExchangeStatusType
        /// </summary>
        public static readonly ReservedNodeExchangeStatusType RETRYING = new ReservedNodeExchangeStatusType("RETRYING");
        /// <summary>
        /// Constant SUCCEEDED for ReservedNodeExchangeStatusType
        /// </summary>
        public static readonly ReservedNodeExchangeStatusType SUCCEEDED = new ReservedNodeExchangeStatusType("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservedNodeExchangeStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservedNodeExchangeStatusType FindValue(string value)
        {
            return FindValue<ReservedNodeExchangeStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservedNodeExchangeStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservedNodeOfferingType.
    /// </summary>
    public class ReservedNodeOfferingType : ConstantClass
    {

        /// <summary>
        /// Constant Regular for ReservedNodeOfferingType
        /// </summary>
        public static readonly ReservedNodeOfferingType Regular = new ReservedNodeOfferingType("Regular");
        /// <summary>
        /// Constant Upgradable for ReservedNodeOfferingType
        /// </summary>
        public static readonly ReservedNodeOfferingType Upgradable = new ReservedNodeOfferingType("Upgradable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservedNodeOfferingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservedNodeOfferingType FindValue(string value)
        {
            return FindValue<ReservedNodeOfferingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservedNodeOfferingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduledActionFilterName.
    /// </summary>
    public class ScheduledActionFilterName : ConstantClass
    {

        /// <summary>
        /// Constant ClusterIdentifier for ScheduledActionFilterName
        /// </summary>
        public static readonly ScheduledActionFilterName ClusterIdentifier = new ScheduledActionFilterName("cluster-identifier");
        /// <summary>
        /// Constant IamRole for ScheduledActionFilterName
        /// </summary>
        public static readonly ScheduledActionFilterName IamRole = new ScheduledActionFilterName("iam-role");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduledActionFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduledActionFilterName FindValue(string value)
        {
            return FindValue<ScheduledActionFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduledActionFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduledActionState.
    /// </summary>
    public class ScheduledActionState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ScheduledActionState
        /// </summary>
        public static readonly ScheduledActionState ACTIVE = new ScheduledActionState("ACTIVE");
        /// <summary>
        /// Constant DISABLED for ScheduledActionState
        /// </summary>
        public static readonly ScheduledActionState DISABLED = new ScheduledActionState("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduledActionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduledActionState FindValue(string value)
        {
            return FindValue<ScheduledActionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduledActionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduledActionTypeValues.
    /// </summary>
    public class ScheduledActionTypeValues : ConstantClass
    {

        /// <summary>
        /// Constant PauseCluster for ScheduledActionTypeValues
        /// </summary>
        public static readonly ScheduledActionTypeValues PauseCluster = new ScheduledActionTypeValues("PauseCluster");
        /// <summary>
        /// Constant ResizeCluster for ScheduledActionTypeValues
        /// </summary>
        public static readonly ScheduledActionTypeValues ResizeCluster = new ScheduledActionTypeValues("ResizeCluster");
        /// <summary>
        /// Constant ResumeCluster for ScheduledActionTypeValues
        /// </summary>
        public static readonly ScheduledActionTypeValues ResumeCluster = new ScheduledActionTypeValues("ResumeCluster");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduledActionTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduledActionTypeValues FindValue(string value)
        {
            return FindValue<ScheduledActionTypeValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduledActionTypeValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduleState.
    /// </summary>
    public class ScheduleState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ScheduleState
        /// </summary>
        public static readonly ScheduleState ACTIVE = new ScheduleState("ACTIVE");
        /// <summary>
        /// Constant FAILED for ScheduleState
        /// </summary>
        public static readonly ScheduleState FAILED = new ScheduleState("FAILED");
        /// <summary>
        /// Constant MODIFYING for ScheduleState
        /// </summary>
        public static readonly ScheduleState MODIFYING = new ScheduleState("MODIFYING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleState FindValue(string value)
        {
            return FindValue<ScheduleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceAuthorization.
    /// </summary>
    public class ServiceAuthorization : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ServiceAuthorization
        /// </summary>
        public static readonly ServiceAuthorization Disabled = new ServiceAuthorization("Disabled");
        /// <summary>
        /// Constant Enabled for ServiceAuthorization
        /// </summary>
        public static readonly ServiceAuthorization Enabled = new ServiceAuthorization("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceAuthorization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceAuthorization FindValue(string value)
        {
            return FindValue<ServiceAuthorization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceAuthorization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotAttributeToSortBy.
    /// </summary>
    public class SnapshotAttributeToSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_TIME for SnapshotAttributeToSortBy
        /// </summary>
        public static readonly SnapshotAttributeToSortBy CREATE_TIME = new SnapshotAttributeToSortBy("CREATE_TIME");
        /// <summary>
        /// Constant SOURCE_TYPE for SnapshotAttributeToSortBy
        /// </summary>
        public static readonly SnapshotAttributeToSortBy SOURCE_TYPE = new SnapshotAttributeToSortBy("SOURCE_TYPE");
        /// <summary>
        /// Constant TOTAL_SIZE for SnapshotAttributeToSortBy
        /// </summary>
        public static readonly SnapshotAttributeToSortBy TOTAL_SIZE = new SnapshotAttributeToSortBy("TOTAL_SIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotAttributeToSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotAttributeToSortBy FindValue(string value)
        {
            return FindValue<SnapshotAttributeToSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotAttributeToSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortByOrder.
    /// </summary>
    public class SortByOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortByOrder
        /// </summary>
        public static readonly SortByOrder ASC = new SortByOrder("ASC");
        /// <summary>
        /// Constant DESC for SortByOrder
        /// </summary>
        public static readonly SortByOrder DESC = new SortByOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortByOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortByOrder FindValue(string value)
        {
            return FindValue<SortByOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortByOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant Cluster for SourceType
        /// </summary>
        public static readonly SourceType Cluster = new SourceType("cluster");
        /// <summary>
        /// Constant ClusterParameterGroup for SourceType
        /// </summary>
        public static readonly SourceType ClusterParameterGroup = new SourceType("cluster-parameter-group");
        /// <summary>
        /// Constant ClusterSecurityGroup for SourceType
        /// </summary>
        public static readonly SourceType ClusterSecurityGroup = new SourceType("cluster-security-group");
        /// <summary>
        /// Constant ClusterSnapshot for SourceType
        /// </summary>
        public static readonly SourceType ClusterSnapshot = new SourceType("cluster-snapshot");
        /// <summary>
        /// Constant ScheduledAction for SourceType
        /// </summary>
        public static readonly SourceType ScheduledAction = new SourceType("scheduled-action");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableRestoreStatusType.
    /// </summary>
    public class TableRestoreStatusType : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType CANCELED = new TableRestoreStatusType("CANCELED");
        /// <summary>
        /// Constant FAILED for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType FAILED = new TableRestoreStatusType("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType IN_PROGRESS = new TableRestoreStatusType("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType PENDING = new TableRestoreStatusType("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType SUCCEEDED = new TableRestoreStatusType("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableRestoreStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableRestoreStatusType FindValue(string value)
        {
            return FindValue<TableRestoreStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableRestoreStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageLimitBreachAction.
    /// </summary>
    public class UsageLimitBreachAction : ConstantClass
    {

        /// <summary>
        /// Constant Disable for UsageLimitBreachAction
        /// </summary>
        public static readonly UsageLimitBreachAction Disable = new UsageLimitBreachAction("disable");
        /// <summary>
        /// Constant EmitMetric for UsageLimitBreachAction
        /// </summary>
        public static readonly UsageLimitBreachAction EmitMetric = new UsageLimitBreachAction("emit-metric");
        /// <summary>
        /// Constant Log for UsageLimitBreachAction
        /// </summary>
        public static readonly UsageLimitBreachAction Log = new UsageLimitBreachAction("log");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageLimitBreachAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageLimitBreachAction FindValue(string value)
        {
            return FindValue<UsageLimitBreachAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageLimitBreachAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageLimitFeatureType.
    /// </summary>
    public class UsageLimitFeatureType : ConstantClass
    {

        /// <summary>
        /// Constant ConcurrencyScaling for UsageLimitFeatureType
        /// </summary>
        public static readonly UsageLimitFeatureType ConcurrencyScaling = new UsageLimitFeatureType("concurrency-scaling");
        /// <summary>
        /// Constant CrossRegionDatasharing for UsageLimitFeatureType
        /// </summary>
        public static readonly UsageLimitFeatureType CrossRegionDatasharing = new UsageLimitFeatureType("cross-region-datasharing");
        /// <summary>
        /// Constant Spectrum for UsageLimitFeatureType
        /// </summary>
        public static readonly UsageLimitFeatureType Spectrum = new UsageLimitFeatureType("spectrum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageLimitFeatureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageLimitFeatureType FindValue(string value)
        {
            return FindValue<UsageLimitFeatureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageLimitFeatureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageLimitLimitType.
    /// </summary>
    public class UsageLimitLimitType : ConstantClass
    {

        /// <summary>
        /// Constant DataScanned for UsageLimitLimitType
        /// </summary>
        public static readonly UsageLimitLimitType DataScanned = new UsageLimitLimitType("data-scanned");
        /// <summary>
        /// Constant Time for UsageLimitLimitType
        /// </summary>
        public static readonly UsageLimitLimitType Time = new UsageLimitLimitType("time");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageLimitLimitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageLimitLimitType FindValue(string value)
        {
            return FindValue<UsageLimitLimitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageLimitLimitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageLimitPeriod.
    /// </summary>
    public class UsageLimitPeriod : ConstantClass
    {

        /// <summary>
        /// Constant Daily for UsageLimitPeriod
        /// </summary>
        public static readonly UsageLimitPeriod Daily = new UsageLimitPeriod("daily");
        /// <summary>
        /// Constant Monthly for UsageLimitPeriod
        /// </summary>
        public static readonly UsageLimitPeriod Monthly = new UsageLimitPeriod("monthly");
        /// <summary>
        /// Constant Weekly for UsageLimitPeriod
        /// </summary>
        public static readonly UsageLimitPeriod Weekly = new UsageLimitPeriod("weekly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageLimitPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageLimitPeriod FindValue(string value)
        {
            return FindValue<UsageLimitPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageLimitPeriod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ZeroETLIntegrationStatus.
    /// </summary>
    public class ZeroETLIntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for ZeroETLIntegrationStatus
        /// </summary>
        public static readonly ZeroETLIntegrationStatus Active = new ZeroETLIntegrationStatus("active");
        /// <summary>
        /// Constant Creating for ZeroETLIntegrationStatus
        /// </summary>
        public static readonly ZeroETLIntegrationStatus Creating = new ZeroETLIntegrationStatus("creating");
        /// <summary>
        /// Constant Deleting for ZeroETLIntegrationStatus
        /// </summary>
        public static readonly ZeroETLIntegrationStatus Deleting = new ZeroETLIntegrationStatus("deleting");
        /// <summary>
        /// Constant Failed for ZeroETLIntegrationStatus
        /// </summary>
        public static readonly ZeroETLIntegrationStatus Failed = new ZeroETLIntegrationStatus("failed");
        /// <summary>
        /// Constant Modifying for ZeroETLIntegrationStatus
        /// </summary>
        public static readonly ZeroETLIntegrationStatus Modifying = new ZeroETLIntegrationStatus("modifying");
        /// <summary>
        /// Constant Needs_attention for ZeroETLIntegrationStatus
        /// </summary>
        public static readonly ZeroETLIntegrationStatus Needs_attention = new ZeroETLIntegrationStatus("needs_attention");
        /// <summary>
        /// Constant Syncing for ZeroETLIntegrationStatus
        /// </summary>
        public static readonly ZeroETLIntegrationStatus Syncing = new ZeroETLIntegrationStatus("syncing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZeroETLIntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZeroETLIntegrationStatus FindValue(string value)
        {
            return FindValue<ZeroETLIntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZeroETLIntegrationStatus(string value)
        {
            return FindValue(value);
        }
    }

}