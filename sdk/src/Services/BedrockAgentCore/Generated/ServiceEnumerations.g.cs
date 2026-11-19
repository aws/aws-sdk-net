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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.BedrockAgentCore
{
    /// <summary>
    /// Constants used for properties of type ABTestExecutionStatus.
    /// </summary>
    public class ABTestExecutionStatus : ConstantClass
    {
        /// <summary>
        /// Constant NOT_STARTED for ABTestExecutionStatus
        /// </summary>
        public static readonly ABTestExecutionStatus NOT_STARTED = new ABTestExecutionStatus("NOT_STARTED");

        /// <summary>
        /// Constant PAUSED for ABTestExecutionStatus
        /// </summary>
        public static readonly ABTestExecutionStatus PAUSED = new ABTestExecutionStatus("PAUSED");

        /// <summary>
        /// Constant RUNNING for ABTestExecutionStatus
        /// </summary>
        public static readonly ABTestExecutionStatus RUNNING = new ABTestExecutionStatus("RUNNING");

        /// <summary>
        /// Constant STOPPED for ABTestExecutionStatus
        /// </summary>
        public static readonly ABTestExecutionStatus STOPPED = new ABTestExecutionStatus("STOPPED");

        /// <summary>
        /// Constructs a custom ABTestExecutionStatus for a value not among the defined constants.
        /// </summary>
        public ABTestExecutionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ABTestExecutionStatus FindValue(string value)
        {
            return FindValue<ABTestExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ABTestExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ABTestStatus.
    /// </summary>
    public class ABTestStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus ACTIVE = new ABTestStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus CREATE_FAILED = new ABTestStatus("CREATE_FAILED");

        /// <summary>
        /// Constant CREATING for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus CREATING = new ABTestStatus("CREATING");

        /// <summary>
        /// Constant DELETE_FAILED for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus DELETE_FAILED = new ABTestStatus("DELETE_FAILED");

        /// <summary>
        /// Constant DELETING for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus DELETING = new ABTestStatus("DELETING");

        /// <summary>
        /// Constant FAILED for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus FAILED = new ABTestStatus("FAILED");

        /// <summary>
        /// Constant UPDATE_FAILED for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus UPDATE_FAILED = new ABTestStatus("UPDATE_FAILED");

        /// <summary>
        /// Constant UPDATING for ABTestStatus
        /// </summary>
        public static readonly ABTestStatus UPDATING = new ABTestStatus("UPDATING");

        /// <summary>
        /// Constructs a custom ABTestStatus for a value not among the defined constants.
        /// </summary>
        public ABTestStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ABTestStatus FindValue(string value)
        {
            return FindValue<ABTestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ABTestStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AgentInsightArchiveStatus.
    /// </summary>
    public class AgentInsightArchiveStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for AgentInsightArchiveStatus
        /// </summary>
        public static readonly AgentInsightArchiveStatus ACTIVE = new AgentInsightArchiveStatus("ACTIVE");

        /// <summary>
        /// Constant ARCHIVED for AgentInsightArchiveStatus
        /// </summary>
        public static readonly AgentInsightArchiveStatus ARCHIVED = new AgentInsightArchiveStatus("ARCHIVED");

        /// <summary>
        /// Constructs a custom AgentInsightArchiveStatus for a value not among the defined constants.
        /// </summary>
        public AgentInsightArchiveStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentInsightArchiveStatus FindValue(string value)
        {
            return FindValue<AgentInsightArchiveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentInsightArchiveStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AgentInsightCustomerMetadataStatus.
    /// </summary>
    public class AgentInsightCustomerMetadataStatus : ConstantClass
    {
        /// <summary>
        /// Constant AVAILABLE for AgentInsightCustomerMetadataStatus
        /// </summary>
        public static readonly AgentInsightCustomerMetadataStatus AVAILABLE = new AgentInsightCustomerMetadataStatus("AVAILABLE");

        /// <summary>
        /// Constant CUSTOMER_KEY_UNAVAILABLE for AgentInsightCustomerMetadataStatus
        /// </summary>
        public static readonly AgentInsightCustomerMetadataStatus CUSTOMER_KEY_UNAVAILABLE = new AgentInsightCustomerMetadataStatus("CUSTOMER_KEY_UNAVAILABLE");

        /// <summary>
        /// Constant UNAVAILABLE for AgentInsightCustomerMetadataStatus
        /// </summary>
        public static readonly AgentInsightCustomerMetadataStatus UNAVAILABLE = new AgentInsightCustomerMetadataStatus("UNAVAILABLE");

        /// <summary>
        /// Constructs a custom AgentInsightCustomerMetadataStatus for a value not among the defined constants.
        /// </summary>
        public AgentInsightCustomerMetadataStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentInsightCustomerMetadataStatus FindValue(string value)
        {
            return FindValue<AgentInsightCustomerMetadataStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentInsightCustomerMetadataStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AutomationStreamStatus.
    /// </summary>
    public class AutomationStreamStatus : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for AutomationStreamStatus
        /// </summary>
        public static readonly AutomationStreamStatus DISABLED = new AutomationStreamStatus("DISABLED");

        /// <summary>
        /// Constant ENABLED for AutomationStreamStatus
        /// </summary>
        public static readonly AutomationStreamStatus ENABLED = new AutomationStreamStatus("ENABLED");

        /// <summary>
        /// Constructs a custom AutomationStreamStatus for a value not among the defined constants.
        /// </summary>
        public AutomationStreamStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationStreamStatus FindValue(string value)
        {
            return FindValue<AutomationStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationStreamStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BatchEvaluationStatus.
    /// </summary>
    public class BatchEvaluationStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus COMPLETED = new BatchEvaluationStatus("COMPLETED");

        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus COMPLETED_WITH_ERRORS = new BatchEvaluationStatus("COMPLETED_WITH_ERRORS");

        /// <summary>
        /// Constant DELETING for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus DELETING = new BatchEvaluationStatus("DELETING");

        /// <summary>
        /// Constant FAILED for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus FAILED = new BatchEvaluationStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus IN_PROGRESS = new BatchEvaluationStatus("IN_PROGRESS");

        /// <summary>
        /// Constant PENDING for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus PENDING = new BatchEvaluationStatus("PENDING");

        /// <summary>
        /// Constant STOPPED for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus STOPPED = new BatchEvaluationStatus("STOPPED");

        /// <summary>
        /// Constant STOPPING for BatchEvaluationStatus
        /// </summary>
        public static readonly BatchEvaluationStatus STOPPING = new BatchEvaluationStatus("STOPPING");

        /// <summary>
        /// Constructs a custom BatchEvaluationStatus for a value not among the defined constants.
        /// </summary>
        public BatchEvaluationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchEvaluationStatus FindValue(string value)
        {
            return FindValue<BatchEvaluationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchEvaluationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BlockchainChainId.
    /// </summary>
    public class BlockchainChainId : ConstantClass
    {
        /// <summary>
        /// Constant BASE for BlockchainChainId
        /// </summary>
        public static readonly BlockchainChainId BASE = new BlockchainChainId("BASE");

        /// <summary>
        /// Constant BASE_SEPOLIA for BlockchainChainId
        /// </summary>
        public static readonly BlockchainChainId BASE_SEPOLIA = new BlockchainChainId("BASE_SEPOLIA");

        /// <summary>
        /// Constant ETHEREUM for BlockchainChainId
        /// </summary>
        public static readonly BlockchainChainId ETHEREUM = new BlockchainChainId("ETHEREUM");

        /// <summary>
        /// Constant SOLANA for BlockchainChainId
        /// </summary>
        public static readonly BlockchainChainId SOLANA = new BlockchainChainId("SOLANA");

        /// <summary>
        /// Constant SOLANA_DEVNET for BlockchainChainId
        /// </summary>
        public static readonly BlockchainChainId SOLANA_DEVNET = new BlockchainChainId("SOLANA_DEVNET");

        /// <summary>
        /// Constructs a custom BlockchainChainId for a value not among the defined constants.
        /// </summary>
        public BlockchainChainId(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlockchainChainId FindValue(string value)
        {
            return FindValue<BlockchainChainId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlockchainChainId(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BrowserActionStatus.
    /// </summary>
    public class BrowserActionStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for BrowserActionStatus
        /// </summary>
        public static readonly BrowserActionStatus FAILED = new BrowserActionStatus("FAILED");

        /// <summary>
        /// Constant SUCCESS for BrowserActionStatus
        /// </summary>
        public static readonly BrowserActionStatus SUCCESS = new BrowserActionStatus("SUCCESS");

        /// <summary>
        /// Constructs a custom BrowserActionStatus for a value not among the defined constants.
        /// </summary>
        public BrowserActionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserActionStatus FindValue(string value)
        {
            return FindValue<BrowserActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserActionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BrowserEnterprisePolicyType.
    /// </summary>
    public class BrowserEnterprisePolicyType : ConstantClass
    {
        /// <summary>
        /// Constant MANAGED for BrowserEnterprisePolicyType
        /// </summary>
        public static readonly BrowserEnterprisePolicyType MANAGED = new BrowserEnterprisePolicyType("MANAGED");

        /// <summary>
        /// Constant RECOMMENDED for BrowserEnterprisePolicyType
        /// </summary>
        public static readonly BrowserEnterprisePolicyType RECOMMENDED = new BrowserEnterprisePolicyType("RECOMMENDED");

        /// <summary>
        /// Constructs a custom BrowserEnterprisePolicyType for a value not among the defined constants.
        /// </summary>
        public BrowserEnterprisePolicyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserEnterprisePolicyType FindValue(string value)
        {
            return FindValue<BrowserEnterprisePolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserEnterprisePolicyType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BrowserSessionStatus.
    /// </summary>
    public class BrowserSessionStatus : ConstantClass
    {
        /// <summary>
        /// Constant READY for BrowserSessionStatus
        /// </summary>
        public static readonly BrowserSessionStatus READY = new BrowserSessionStatus("READY");

        /// <summary>
        /// Constant TERMINATED for BrowserSessionStatus
        /// </summary>
        public static readonly BrowserSessionStatus TERMINATED = new BrowserSessionStatus("TERMINATED");

        /// <summary>
        /// Constructs a custom BrowserSessionStatus for a value not among the defined constants.
        /// </summary>
        public BrowserSessionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserSessionStatus FindValue(string value)
        {
            return FindValue<BrowserSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserSessionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CapacityProviderSessionStatus.
    /// </summary>
    public class CapacityProviderSessionStatus : ConstantClass
    {
        /// <summary>
        /// Constant Active for CapacityProviderSessionStatus
        /// </summary>
        public static readonly CapacityProviderSessionStatus Active = new CapacityProviderSessionStatus("Active");

        /// <summary>
        /// Constant Deleted for CapacityProviderSessionStatus
        /// </summary>
        public static readonly CapacityProviderSessionStatus Deleted = new CapacityProviderSessionStatus("Deleted");

        /// <summary>
        /// Constant Deleting for CapacityProviderSessionStatus
        /// </summary>
        public static readonly CapacityProviderSessionStatus Deleting = new CapacityProviderSessionStatus("Deleting");

        /// <summary>
        /// Constant Deprovisioning for CapacityProviderSessionStatus
        /// </summary>
        public static readonly CapacityProviderSessionStatus Deprovisioning = new CapacityProviderSessionStatus("Deprovisioning");

        /// <summary>
        /// Constant Provisioning for CapacityProviderSessionStatus
        /// </summary>
        public static readonly CapacityProviderSessionStatus Provisioning = new CapacityProviderSessionStatus("Provisioning");

        /// <summary>
        /// Constant Stopped for CapacityProviderSessionStatus
        /// </summary>
        public static readonly CapacityProviderSessionStatus Stopped = new CapacityProviderSessionStatus("Stopped");

        /// <summary>
        /// Constructs a custom CapacityProviderSessionStatus for a value not among the defined constants.
        /// </summary>
        public CapacityProviderSessionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderSessionStatus FindValue(string value)
        {
            return FindValue<CapacityProviderSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderSessionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CloudWatchLogsFilterOperator.
    /// </summary>
    public class CloudWatchLogsFilterOperator : ConstantClass
    {
        /// <summary>
        /// Constant Contains for CloudWatchLogsFilterOperator
        /// </summary>
        public static readonly CloudWatchLogsFilterOperator Contains = new CloudWatchLogsFilterOperator("Contains");

        /// <summary>
        /// Constant Equals for CloudWatchLogsFilterOperator
        /// </summary>
        public new static readonly CloudWatchLogsFilterOperator Equals = new CloudWatchLogsFilterOperator("Equals");

        /// <summary>
        /// Constant GreaterThan for CloudWatchLogsFilterOperator
        /// </summary>
        public static readonly CloudWatchLogsFilterOperator GreaterThan = new CloudWatchLogsFilterOperator("GreaterThan");

        /// <summary>
        /// Constant GreaterThanOrEqual for CloudWatchLogsFilterOperator
        /// </summary>
        public static readonly CloudWatchLogsFilterOperator GreaterThanOrEqual = new CloudWatchLogsFilterOperator("GreaterThanOrEqual");

        /// <summary>
        /// Constant LessThan for CloudWatchLogsFilterOperator
        /// </summary>
        public static readonly CloudWatchLogsFilterOperator LessThan = new CloudWatchLogsFilterOperator("LessThan");

        /// <summary>
        /// Constant LessThanOrEqual for CloudWatchLogsFilterOperator
        /// </summary>
        public static readonly CloudWatchLogsFilterOperator LessThanOrEqual = new CloudWatchLogsFilterOperator("LessThanOrEqual");

        /// <summary>
        /// Constant NotContains for CloudWatchLogsFilterOperator
        /// </summary>
        public static readonly CloudWatchLogsFilterOperator NotContains = new CloudWatchLogsFilterOperator("NotContains");

        /// <summary>
        /// Constant NotEquals for CloudWatchLogsFilterOperator
        /// </summary>
        public static readonly CloudWatchLogsFilterOperator NotEquals = new CloudWatchLogsFilterOperator("NotEquals");

        /// <summary>
        /// Constructs a custom CloudWatchLogsFilterOperator for a value not among the defined constants.
        /// </summary>
        public CloudWatchLogsFilterOperator(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchLogsFilterOperator FindValue(string value)
        {
            return FindValue<CloudWatchLogsFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchLogsFilterOperator(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CodeInterpreterSessionStatus.
    /// </summary>
    public class CodeInterpreterSessionStatus : ConstantClass
    {
        /// <summary>
        /// Constant READY for CodeInterpreterSessionStatus
        /// </summary>
        public static readonly CodeInterpreterSessionStatus READY = new CodeInterpreterSessionStatus("READY");

        /// <summary>
        /// Constant TERMINATED for CodeInterpreterSessionStatus
        /// </summary>
        public static readonly CodeInterpreterSessionStatus TERMINATED = new CodeInterpreterSessionStatus("TERMINATED");

        /// <summary>
        /// Constructs a custom CodeInterpreterSessionStatus for a value not among the defined constants.
        /// </summary>
        public CodeInterpreterSessionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeInterpreterSessionStatus FindValue(string value)
        {
            return FindValue<CodeInterpreterSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeInterpreterSessionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CommandExecutionStatus.
    /// </summary>
    public class CommandExecutionStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for CommandExecutionStatus
        /// </summary>
        public static readonly CommandExecutionStatus COMPLETED = new CommandExecutionStatus("COMPLETED");

        /// <summary>
        /// Constant TIMED_OUT for CommandExecutionStatus
        /// </summary>
        public static readonly CommandExecutionStatus TIMED_OUT = new CommandExecutionStatus("TIMED_OUT");

        /// <summary>
        /// Constructs a custom CommandExecutionStatus for a value not among the defined constants.
        /// </summary>
        public CommandExecutionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandExecutionStatus FindValue(string value)
        {
            return FindValue<CommandExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ContentBlockType.
    /// </summary>
    public class ContentBlockType : ConstantClass
    {
        /// <summary>
        /// Constant Image for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Image = new ContentBlockType("image");

        /// <summary>
        /// Constant Resource for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Resource = new ContentBlockType("resource");

        /// <summary>
        /// Constant Resource_link for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Resource_link = new ContentBlockType("resource_link");

        /// <summary>
        /// Constant Text for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Text = new ContentBlockType("text");

        /// <summary>
        /// Constructs a custom ContentBlockType for a value not among the defined constants.
        /// </summary>
        public ContentBlockType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentBlockType FindValue(string value)
        {
            return FindValue<ContentBlockType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentBlockType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CryptoWalletNetwork.
    /// </summary>
    public class CryptoWalletNetwork : ConstantClass
    {
        /// <summary>
        /// Constant ETHEREUM for CryptoWalletNetwork
        /// </summary>
        public static readonly CryptoWalletNetwork ETHEREUM = new CryptoWalletNetwork("ETHEREUM");

        /// <summary>
        /// Constant SOLANA for CryptoWalletNetwork
        /// </summary>
        public static readonly CryptoWalletNetwork SOLANA = new CryptoWalletNetwork("SOLANA");

        /// <summary>
        /// Constructs a custom CryptoWalletNetwork for a value not among the defined constants.
        /// </summary>
        public CryptoWalletNetwork(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CryptoWalletNetwork FindValue(string value)
        {
            return FindValue<CryptoWalletNetwork>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CryptoWalletNetwork(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Currency.
    /// </summary>
    public class Currency : ConstantClass
    {
        /// <summary>
        /// Constant USD for Currency
        /// </summary>
        public static readonly Currency USD = new Currency("USD");

        /// <summary>
        /// Constructs a custom Currency for a value not among the defined constants.
        /// </summary>
        public Currency(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Currency FindValue(string value)
        {
            return FindValue<Currency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Currency(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DatasetGenerationStatus.
    /// </summary>
    public class DatasetGenerationStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for DatasetGenerationStatus
        /// </summary>
        public static readonly DatasetGenerationStatus COMPLETED = new DatasetGenerationStatus("COMPLETED");

        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for DatasetGenerationStatus
        /// </summary>
        public static readonly DatasetGenerationStatus COMPLETED_WITH_ERRORS = new DatasetGenerationStatus("COMPLETED_WITH_ERRORS");

        /// <summary>
        /// Constant DELETING for DatasetGenerationStatus
        /// </summary>
        public static readonly DatasetGenerationStatus DELETING = new DatasetGenerationStatus("DELETING");

        /// <summary>
        /// Constant FAILED for DatasetGenerationStatus
        /// </summary>
        public static readonly DatasetGenerationStatus FAILED = new DatasetGenerationStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for DatasetGenerationStatus
        /// </summary>
        public static readonly DatasetGenerationStatus IN_PROGRESS = new DatasetGenerationStatus("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom DatasetGenerationStatus for a value not among the defined constants.
        /// </summary>
        public DatasetGenerationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetGenerationStatus FindValue(string value)
        {
            return FindValue<DatasetGenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetGenerationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DescriptorType.
    /// </summary>
    public class DescriptorType : ConstantClass
    {
        /// <summary>
        /// Constant A2A for DescriptorType
        /// </summary>
        public static readonly DescriptorType A2A = new DescriptorType("A2A");

        /// <summary>
        /// Constant AGENT_SKILLS for DescriptorType
        /// </summary>
        public static readonly DescriptorType AGENT_SKILLS = new DescriptorType("AGENT_SKILLS");

        /// <summary>
        /// Constant CUSTOM for DescriptorType
        /// </summary>
        public static readonly DescriptorType CUSTOM = new DescriptorType("CUSTOM");

        /// <summary>
        /// Constant MCP for DescriptorType
        /// </summary>
        public static readonly DescriptorType MCP = new DescriptorType("MCP");

        /// <summary>
        /// Constructs a custom DescriptorType for a value not among the defined constants.
        /// </summary>
        public DescriptorType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescriptorType FindValue(string value)
        {
            return FindValue<DescriptorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescriptorType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EventFilterCondition.
    /// </summary>
    public class EventFilterCondition : ConstantClass
    {
        /// <summary>
        /// Constant HAS_EVENTS for EventFilterCondition
        /// </summary>
        public static readonly EventFilterCondition HAS_EVENTS = new EventFilterCondition("HAS_EVENTS");

        /// <summary>
        /// Constructs a custom EventFilterCondition for a value not among the defined constants.
        /// </summary>
        public EventFilterCondition(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventFilterCondition FindValue(string value)
        {
            return FindValue<EventFilterCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventFilterCondition(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ExtractionJobStatus.
    /// </summary>
    public class ExtractionJobStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for ExtractionJobStatus
        /// </summary>
        public static readonly ExtractionJobStatus FAILED = new ExtractionJobStatus("FAILED");

        /// <summary>
        /// Constructs a custom ExtractionJobStatus for a value not among the defined constants.
        /// </summary>
        public ExtractionJobStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtractionJobStatus FindValue(string value)
        {
            return FindValue<ExtractionJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtractionJobStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ExtractionMode.
    /// </summary>
    public class ExtractionMode : ConstantClass
    {
        /// <summary>
        /// Constant SKIP for ExtractionMode
        /// </summary>
        public static readonly ExtractionMode SKIP = new ExtractionMode("SKIP");

        /// <summary>
        /// Constructs a custom ExtractionMode for a value not among the defined constants.
        /// </summary>
        public ExtractionMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtractionMode FindValue(string value)
        {
            return FindValue<ExtractionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtractionMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingTargetType.
    /// </summary>
    public class FindingTargetType : ConstantClass
    {
        /// <summary>
        /// Constant SPAN_ID for FindingTargetType
        /// </summary>
        public static readonly FindingTargetType SPAN_ID = new FindingTargetType("SPAN_ID");

        /// <summary>
        /// Constant SPAN_NAME for FindingTargetType
        /// </summary>
        public static readonly FindingTargetType SPAN_NAME = new FindingTargetType("SPAN_NAME");

        /// <summary>
        /// Constant TRACE_ID for FindingTargetType
        /// </summary>
        public static readonly FindingTargetType TRACE_ID = new FindingTargetType("TRACE_ID");

        /// <summary>
        /// Constructs a custom FindingTargetType for a value not among the defined constants.
        /// </summary>
        public FindingTargetType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingTargetType FindValue(string value)
        {
            return FindValue<FindingTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingTargetType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type GenerationFilterOperator.
    /// </summary>
    public class GenerationFilterOperator : ConstantClass
    {
        /// <summary>
        /// Constant Contains for GenerationFilterOperator
        /// </summary>
        public static readonly GenerationFilterOperator Contains = new GenerationFilterOperator("Contains");

        /// <summary>
        /// Constant Equals for GenerationFilterOperator
        /// </summary>
        public new static readonly GenerationFilterOperator Equals = new GenerationFilterOperator("Equals");

        /// <summary>
        /// Constant GreaterThan for GenerationFilterOperator
        /// </summary>
        public static readonly GenerationFilterOperator GreaterThan = new GenerationFilterOperator("GreaterThan");

        /// <summary>
        /// Constant GreaterThanOrEqual for GenerationFilterOperator
        /// </summary>
        public static readonly GenerationFilterOperator GreaterThanOrEqual = new GenerationFilterOperator("GreaterThanOrEqual");

        /// <summary>
        /// Constant LessThan for GenerationFilterOperator
        /// </summary>
        public static readonly GenerationFilterOperator LessThan = new GenerationFilterOperator("LessThan");

        /// <summary>
        /// Constant LessThanOrEqual for GenerationFilterOperator
        /// </summary>
        public static readonly GenerationFilterOperator LessThanOrEqual = new GenerationFilterOperator("LessThanOrEqual");

        /// <summary>
        /// Constant NotContains for GenerationFilterOperator
        /// </summary>
        public static readonly GenerationFilterOperator NotContains = new GenerationFilterOperator("NotContains");

        /// <summary>
        /// Constant NotEquals for GenerationFilterOperator
        /// </summary>
        public static readonly GenerationFilterOperator NotEquals = new GenerationFilterOperator("NotEquals");

        /// <summary>
        /// Constructs a custom GenerationFilterOperator for a value not among the defined constants.
        /// </summary>
        public GenerationFilterOperator(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GenerationFilterOperator FindValue(string value)
        {
            return FindValue<GenerationFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GenerationFilterOperator(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type GroundTruthField.
    /// </summary>
    public class GroundTruthField : ConstantClass
    {
        /// <summary>
        /// Constant Expected_response for GroundTruthField
        /// </summary>
        public static readonly GroundTruthField Expected_response = new GroundTruthField("expected_response");

        /// <summary>
        /// Constant Expected_trajectory for GroundTruthField
        /// </summary>
        public static readonly GroundTruthField Expected_trajectory = new GroundTruthField("expected_trajectory");

        /// <summary>
        /// Constructs a custom GroundTruthField for a value not among the defined constants.
        /// </summary>
        public GroundTruthField(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroundTruthField FindValue(string value)
        {
            return FindValue<GroundTruthField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroundTruthField(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessBedrockApiFormat.
    /// </summary>
    public class HarnessBedrockApiFormat : ConstantClass
    {
        /// <summary>
        /// Constant Chat_completions for HarnessBedrockApiFormat
        /// </summary>
        public static readonly HarnessBedrockApiFormat Chat_completions = new HarnessBedrockApiFormat("chat_completions");

        /// <summary>
        /// Constant Converse_stream for HarnessBedrockApiFormat
        /// </summary>
        public static readonly HarnessBedrockApiFormat Converse_stream = new HarnessBedrockApiFormat("converse_stream");

        /// <summary>
        /// Constant Responses for HarnessBedrockApiFormat
        /// </summary>
        public static readonly HarnessBedrockApiFormat Responses = new HarnessBedrockApiFormat("responses");

        /// <summary>
        /// Constructs a custom HarnessBedrockApiFormat for a value not among the defined constants.
        /// </summary>
        public HarnessBedrockApiFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessBedrockApiFormat FindValue(string value)
        {
            return FindValue<HarnessBedrockApiFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessBedrockApiFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessConversationRole.
    /// </summary>
    public class HarnessConversationRole : ConstantClass
    {
        /// <summary>
        /// Constant Assistant for HarnessConversationRole
        /// </summary>
        public static readonly HarnessConversationRole Assistant = new HarnessConversationRole("assistant");

        /// <summary>
        /// Constant User for HarnessConversationRole
        /// </summary>
        public static readonly HarnessConversationRole User = new HarnessConversationRole("user");

        /// <summary>
        /// Constructs a custom HarnessConversationRole for a value not among the defined constants.
        /// </summary>
        public HarnessConversationRole(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessConversationRole FindValue(string value)
        {
            return FindValue<HarnessConversationRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessConversationRole(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessHookDecision.
    /// </summary>
    public class HarnessHookDecision : ConstantClass
    {
        /// <summary>
        /// Constant Allow for HarnessHookDecision
        /// </summary>
        public static readonly HarnessHookDecision Allow = new HarnessHookDecision("allow");

        /// <summary>
        /// Constant Deny for HarnessHookDecision
        /// </summary>
        public static readonly HarnessHookDecision Deny = new HarnessHookDecision("deny");

        /// <summary>
        /// Constructs a custom HarnessHookDecision for a value not among the defined constants.
        /// </summary>
        public HarnessHookDecision(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessHookDecision FindValue(string value)
        {
            return FindValue<HarnessHookDecision>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessHookDecision(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessHookEventType.
    /// </summary>
    public class HarnessHookEventType : ConstantClass
    {
        /// <summary>
        /// Constant After_invocation for HarnessHookEventType
        /// </summary>
        public static readonly HarnessHookEventType After_invocation = new HarnessHookEventType("after_invocation");

        /// <summary>
        /// Constant After_tool_call for HarnessHookEventType
        /// </summary>
        public static readonly HarnessHookEventType After_tool_call = new HarnessHookEventType("after_tool_call");

        /// <summary>
        /// Constant Before_invocation for HarnessHookEventType
        /// </summary>
        public static readonly HarnessHookEventType Before_invocation = new HarnessHookEventType("before_invocation");

        /// <summary>
        /// Constant Before_tool_call for HarnessHookEventType
        /// </summary>
        public static readonly HarnessHookEventType Before_tool_call = new HarnessHookEventType("before_tool_call");

        /// <summary>
        /// Constructs a custom HarnessHookEventType for a value not among the defined constants.
        /// </summary>
        public HarnessHookEventType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessHookEventType FindValue(string value)
        {
            return FindValue<HarnessHookEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessHookEventType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessOpenAiApiFormat.
    /// </summary>
    public class HarnessOpenAiApiFormat : ConstantClass
    {
        /// <summary>
        /// Constant Chat_completions for HarnessOpenAiApiFormat
        /// </summary>
        public static readonly HarnessOpenAiApiFormat Chat_completions = new HarnessOpenAiApiFormat("chat_completions");

        /// <summary>
        /// Constant Responses for HarnessOpenAiApiFormat
        /// </summary>
        public static readonly HarnessOpenAiApiFormat Responses = new HarnessOpenAiApiFormat("responses");

        /// <summary>
        /// Constructs a custom HarnessOpenAiApiFormat for a value not among the defined constants.
        /// </summary>
        public HarnessOpenAiApiFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessOpenAiApiFormat FindValue(string value)
        {
            return FindValue<HarnessOpenAiApiFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessOpenAiApiFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessStopReason.
    /// </summary>
    public class HarnessStopReason : ConstantClass
    {
        /// <summary>
        /// Constant Content_filtered for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Content_filtered = new HarnessStopReason("content_filtered");

        /// <summary>
        /// Constant End_turn for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason End_turn = new HarnessStopReason("end_turn");

        /// <summary>
        /// Constant Hook_stopped for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Hook_stopped = new HarnessStopReason("hook_stopped");

        /// <summary>
        /// Constant Interrupted for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Interrupted = new HarnessStopReason("interrupted");

        /// <summary>
        /// Constant Malformed_model_output for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Malformed_model_output = new HarnessStopReason("malformed_model_output");

        /// <summary>
        /// Constant Malformed_tool_use for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Malformed_tool_use = new HarnessStopReason("malformed_tool_use");

        /// <summary>
        /// Constant Max_iterations_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Max_iterations_exceeded = new HarnessStopReason("max_iterations_exceeded");

        /// <summary>
        /// Constant Max_output_tokens_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Max_output_tokens_exceeded = new HarnessStopReason("max_output_tokens_exceeded");

        /// <summary>
        /// Constant Max_tokens for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Max_tokens = new HarnessStopReason("max_tokens");

        /// <summary>
        /// Constant Model_context_window_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Model_context_window_exceeded = new HarnessStopReason("model_context_window_exceeded");

        /// <summary>
        /// Constant Partial_turn for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Partial_turn = new HarnessStopReason("partial_turn");

        /// <summary>
        /// Constant Stop_sequence for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Stop_sequence = new HarnessStopReason("stop_sequence");

        /// <summary>
        /// Constant Timeout_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Timeout_exceeded = new HarnessStopReason("timeout_exceeded");

        /// <summary>
        /// Constant Tool_result for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Tool_result = new HarnessStopReason("tool_result");

        /// <summary>
        /// Constant Tool_use for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Tool_use = new HarnessStopReason("tool_use");

        /// <summary>
        /// Constructs a custom HarnessStopReason for a value not among the defined constants.
        /// </summary>
        public HarnessStopReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessStopReason FindValue(string value)
        {
            return FindValue<HarnessStopReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessStopReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessToolType.
    /// </summary>
    public class HarnessToolType : ConstantClass
    {
        /// <summary>
        /// Constant Agentcore_browser for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Agentcore_browser = new HarnessToolType("agentcore_browser");

        /// <summary>
        /// Constant Agentcore_code_interpreter for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Agentcore_code_interpreter = new HarnessToolType("agentcore_code_interpreter");

        /// <summary>
        /// Constant Agentcore_gateway for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Agentcore_gateway = new HarnessToolType("agentcore_gateway");

        /// <summary>
        /// Constant Inline_function for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Inline_function = new HarnessToolType("inline_function");

        /// <summary>
        /// Constant Remote_mcp for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Remote_mcp = new HarnessToolType("remote_mcp");

        /// <summary>
        /// Constructs a custom HarnessToolType for a value not among the defined constants.
        /// </summary>
        public HarnessToolType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessToolType FindValue(string value)
        {
            return FindValue<HarnessToolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessToolType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessToolUseStatus.
    /// </summary>
    public class HarnessToolUseStatus : ConstantClass
    {
        /// <summary>
        /// Constant Error for HarnessToolUseStatus
        /// </summary>
        public static readonly HarnessToolUseStatus Error = new HarnessToolUseStatus("error");

        /// <summary>
        /// Constant Success for HarnessToolUseStatus
        /// </summary>
        public static readonly HarnessToolUseStatus Success = new HarnessToolUseStatus("success");

        /// <summary>
        /// Constructs a custom HarnessToolUseStatus for a value not among the defined constants.
        /// </summary>
        public HarnessToolUseStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessToolUseStatus FindValue(string value)
        {
            return FindValue<HarnessToolUseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessToolUseStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HarnessToolUseType.
    /// </summary>
    public class HarnessToolUseType : ConstantClass
    {
        /// <summary>
        /// Constant Mcp_tool_use for HarnessToolUseType
        /// </summary>
        public static readonly HarnessToolUseType Mcp_tool_use = new HarnessToolUseType("mcp_tool_use");

        /// <summary>
        /// Constant Server_tool_use for HarnessToolUseType
        /// </summary>
        public static readonly HarnessToolUseType Server_tool_use = new HarnessToolUseType("server_tool_use");

        /// <summary>
        /// Constant Tool_use for HarnessToolUseType
        /// </summary>
        public static readonly HarnessToolUseType Tool_use = new HarnessToolUseType("tool_use");

        /// <summary>
        /// Constructs a custom HarnessToolUseType for a value not among the defined constants.
        /// </summary>
        public HarnessToolUseType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessToolUseType FindValue(string value)
        {
            return FindValue<HarnessToolUseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessToolUseType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InsightType.
    /// </summary>
    public class InsightType : ConstantClass
    {
        /// <summary>
        /// Constant FAILURE for InsightType
        /// </summary>
        public static readonly InsightType FAILURE = new InsightType("FAILURE");

        /// <summary>
        /// Constructs a custom InsightType for a value not among the defined constants.
        /// </summary>
        public InsightType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightType FindValue(string value)
        {
            return FindValue<InsightType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InsightsFailureCategory.
    /// </summary>
    public class InsightsFailureCategory : ConstantClass
    {
        /// <summary>
        /// Constant CodingUseCaseSpecificFailureTypesCategoryDependencyIssues for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory CodingUseCaseSpecificFailureTypesCategoryDependencyIssues = new InsightsFailureCategory("coding-use-case-specific-failure-types-category-dependency-issues");

        /// <summary>
        /// Constant CodingUseCaseSpecificFailureTypesCategoryEdgeCaseOversights for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory CodingUseCaseSpecificFailureTypesCategoryEdgeCaseOversights = new InsightsFailureCategory("coding-use-case-specific-failure-types-category-edge-case-oversights");

        /// <summary>
        /// Constant ConfigurationMismatchCategoryToolDefinition for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ConfigurationMismatchCategoryToolDefinition = new InsightsFailureCategory("configuration-mismatch-category-tool-definition");

        /// <summary>
        /// Constant ContextHandlingErrorCategoryContextHandlingFailures for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ContextHandlingErrorCategoryContextHandlingFailures = new InsightsFailureCategory("context-handling-error-category-context-handling-failures");

        /// <summary>
        /// Constant ExecutionErrorCategoryAuthentication for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryAuthentication = new InsightsFailureCategory("execution-error-category-authentication");

        /// <summary>
        /// Constant ExecutionErrorCategoryEnvironment for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryEnvironment = new InsightsFailureCategory("execution-error-category-environment");

        /// <summary>
        /// Constant ExecutionErrorCategoryFormatting for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryFormatting = new InsightsFailureCategory("execution-error-category-formatting");

        /// <summary>
        /// Constant ExecutionErrorCategoryRateLimiting for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryRateLimiting = new InsightsFailureCategory("execution-error-category-rate-limiting");

        /// <summary>
        /// Constant ExecutionErrorCategoryResourceExhaustion for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryResourceExhaustion = new InsightsFailureCategory("execution-error-category-resource-exhaustion");

        /// <summary>
        /// Constant ExecutionErrorCategoryResourceNotFound for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryResourceNotFound = new InsightsFailureCategory("execution-error-category-resource-not-found");

        /// <summary>
        /// Constant ExecutionErrorCategoryServiceErrors for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryServiceErrors = new InsightsFailureCategory("execution-error-category-service-errors");

        /// <summary>
        /// Constant ExecutionErrorCategoryTimeout for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryTimeout = new InsightsFailureCategory("execution-error-category-timeout");

        /// <summary>
        /// Constant ExecutionErrorCategoryToolSchema for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory ExecutionErrorCategoryToolSchema = new InsightsFailureCategory("execution-error-category-tool-schema");

        /// <summary>
        /// Constant HallucinationCategoryFabricateToolOutputs for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory HallucinationCategoryFabricateToolOutputs = new InsightsFailureCategory("hallucination-category-fabricate-tool-outputs");

        /// <summary>
        /// Constant HallucinationCategoryHallCapabilities for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory HallucinationCategoryHallCapabilities = new InsightsFailureCategory("hallucination-category-hall-capabilities");

        /// <summary>
        /// Constant HallucinationCategoryHallHistory for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory HallucinationCategoryHallHistory = new InsightsFailureCategory("hallucination-category-hall-history");

        /// <summary>
        /// Constant HallucinationCategoryHallMisunderstand for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory HallucinationCategoryHallMisunderstand = new InsightsFailureCategory("hallucination-category-hall-misunderstand");

        /// <summary>
        /// Constant HallucinationCategoryHallParams for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory HallucinationCategoryHallParams = new InsightsFailureCategory("hallucination-category-hall-params");

        /// <summary>
        /// Constant HallucinationCategoryHallUsage for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory HallucinationCategoryHallUsage = new InsightsFailureCategory("hallucination-category-hall-usage");

        /// <summary>
        /// Constant IncorrectActionsCategoryClarification for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory IncorrectActionsCategoryClarification = new InsightsFailureCategory("incorrect-actions-category-clarification");

        /// <summary>
        /// Constant IncorrectActionsCategoryInappropriateInfoRequest for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory IncorrectActionsCategoryInappropriateInfoRequest = new InsightsFailureCategory("incorrect-actions-category-inappropriate-info-request");

        /// <summary>
        /// Constant IncorrectActionsCategoryPoorInformationRetrieval for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory IncorrectActionsCategoryPoorInformationRetrieval = new InsightsFailureCategory("incorrect-actions-category-poor-information-retrieval");

        /// <summary>
        /// Constant IncorrectActionsCategoryToolSelection for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory IncorrectActionsCategoryToolSelection = new InsightsFailureCategory("incorrect-actions-category-tool-selection");

        /// <summary>
        /// Constant LlmOutputCategoryNonsensical for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory LlmOutputCategoryNonsensical = new InsightsFailureCategory("llm-output-category-nonsensical");

        /// <summary>
        /// Constant OrchestrationRelatedErrorsCategoryGoalDeviation for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory OrchestrationRelatedErrorsCategoryGoalDeviation = new InsightsFailureCategory("orchestration-related-errors-category-goal-deviation");

        /// <summary>
        /// Constant OrchestrationRelatedErrorsCategoryPrematureTermination for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory OrchestrationRelatedErrorsCategoryPrematureTermination = new InsightsFailureCategory("orchestration-related-errors-category-premature-termination");

        /// <summary>
        /// Constant OrchestrationRelatedErrorsCategoryReasoningMismatch for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory OrchestrationRelatedErrorsCategoryReasoningMismatch = new InsightsFailureCategory("orchestration-related-errors-category-reasoning-mismatch");

        /// <summary>
        /// Constant OrchestrationRelatedErrorsCategoryUnawareTermination for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory OrchestrationRelatedErrorsCategoryUnawareTermination = new InsightsFailureCategory("orchestration-related-errors-category-unaware-termination");

        /// <summary>
        /// Constant Other for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory Other = new InsightsFailureCategory("other");

        /// <summary>
        /// Constant RepetitiveBehaviorCategoryRepetitionInfo for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory RepetitiveBehaviorCategoryRepetitionInfo = new InsightsFailureCategory("repetitive-behavior-category-repetition-info");

        /// <summary>
        /// Constant RepetitiveBehaviorCategoryRepetitionTool for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory RepetitiveBehaviorCategoryRepetitionTool = new InsightsFailureCategory("repetitive-behavior-category-repetition-tool");

        /// <summary>
        /// Constant RepetitiveBehaviorCategoryStepRepetition for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory RepetitiveBehaviorCategoryStepRepetition = new InsightsFailureCategory("repetitive-behavior-category-step-repetition");

        /// <summary>
        /// Constant TaskInstructionCategoryNonCompliance for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory TaskInstructionCategoryNonCompliance = new InsightsFailureCategory("task-instruction-category-non-compliance");

        /// <summary>
        /// Constant TaskInstructionCategoryProblemId for InsightsFailureCategory
        /// </summary>
        public static readonly InsightsFailureCategory TaskInstructionCategoryProblemId = new InsightsFailureCategory("task-instruction-category-problem-id");

        /// <summary>
        /// Constructs a custom InsightsFailureCategory for a value not among the defined constants.
        /// </summary>
        public InsightsFailureCategory(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightsFailureCategory FindValue(string value)
        {
            return FindValue<InsightsFailureCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightsFailureCategory(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InstrumentBalanceToken.
    /// </summary>
    public class InstrumentBalanceToken : ConstantClass
    {
        /// <summary>
        /// Constant USDC for InstrumentBalanceToken
        /// </summary>
        public static readonly InstrumentBalanceToken USDC = new InstrumentBalanceToken("USDC");

        /// <summary>
        /// Constructs a custom InstrumentBalanceToken for a value not among the defined constants.
        /// </summary>
        public InstrumentBalanceToken(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstrumentBalanceToken FindValue(string value)
        {
            return FindValue<InstrumentBalanceToken>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstrumentBalanceToken(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LanguageRuntime.
    /// </summary>
    public class LanguageRuntime : ConstantClass
    {
        /// <summary>
        /// Constant Deno for LanguageRuntime
        /// </summary>
        public static readonly LanguageRuntime Deno = new LanguageRuntime("deno");

        /// <summary>
        /// Constant Nodejs for LanguageRuntime
        /// </summary>
        public static readonly LanguageRuntime Nodejs = new LanguageRuntime("nodejs");

        /// <summary>
        /// Constant Python for LanguageRuntime
        /// </summary>
        public static readonly LanguageRuntime Python = new LanguageRuntime("python");

        /// <summary>
        /// Constructs a custom LanguageRuntime for a value not among the defined constants.
        /// </summary>
        public LanguageRuntime(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageRuntime FindValue(string value)
        {
            return FindValue<LanguageRuntime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageRuntime(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MemoryRecordOperatorType.
    /// </summary>
    public class MemoryRecordOperatorType : ConstantClass
    {
        /// <summary>
        /// Constant AFTER for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType AFTER = new MemoryRecordOperatorType("AFTER");

        /// <summary>
        /// Constant BEFORE for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType BEFORE = new MemoryRecordOperatorType("BEFORE");

        /// <summary>
        /// Constant CONTAINS for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType CONTAINS = new MemoryRecordOperatorType("CONTAINS");

        /// <summary>
        /// Constant EQUALS_TO for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType EQUALS_TO = new MemoryRecordOperatorType("EQUALS_TO");

        /// <summary>
        /// Constant EXISTS for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType EXISTS = new MemoryRecordOperatorType("EXISTS");

        /// <summary>
        /// Constant GREATER_THAN for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType GREATER_THAN = new MemoryRecordOperatorType("GREATER_THAN");

        /// <summary>
        /// Constant GREATER_THAN_OR_EQUALS for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType GREATER_THAN_OR_EQUALS = new MemoryRecordOperatorType("GREATER_THAN_OR_EQUALS");

        /// <summary>
        /// Constant LESS_THAN for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType LESS_THAN = new MemoryRecordOperatorType("LESS_THAN");

        /// <summary>
        /// Constant LESS_THAN_OR_EQUALS for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType LESS_THAN_OR_EQUALS = new MemoryRecordOperatorType("LESS_THAN_OR_EQUALS");

        /// <summary>
        /// Constant NOT_EXISTS for MemoryRecordOperatorType
        /// </summary>
        public static readonly MemoryRecordOperatorType NOT_EXISTS = new MemoryRecordOperatorType("NOT_EXISTS");

        /// <summary>
        /// Constructs a custom MemoryRecordOperatorType for a value not among the defined constants.
        /// </summary>
        public MemoryRecordOperatorType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryRecordOperatorType FindValue(string value)
        {
            return FindValue<MemoryRecordOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryRecordOperatorType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MemoryRecordStatus.
    /// </summary>
    public class MemoryRecordStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for MemoryRecordStatus
        /// </summary>
        public static readonly MemoryRecordStatus FAILED = new MemoryRecordStatus("FAILED");

        /// <summary>
        /// Constant SUCCEEDED for MemoryRecordStatus
        /// </summary>
        public static readonly MemoryRecordStatus SUCCEEDED = new MemoryRecordStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom MemoryRecordStatus for a value not among the defined constants.
        /// </summary>
        public MemoryRecordStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryRecordStatus FindValue(string value)
        {
            return FindValue<MemoryRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryRecordStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MouseButton.
    /// </summary>
    public class MouseButton : ConstantClass
    {
        /// <summary>
        /// Constant LEFT for MouseButton
        /// </summary>
        public static readonly MouseButton LEFT = new MouseButton("LEFT");

        /// <summary>
        /// Constant MIDDLE for MouseButton
        /// </summary>
        public static readonly MouseButton MIDDLE = new MouseButton("MIDDLE");

        /// <summary>
        /// Constant RIGHT for MouseButton
        /// </summary>
        public static readonly MouseButton RIGHT = new MouseButton("RIGHT");

        /// <summary>
        /// Constructs a custom MouseButton for a value not among the defined constants.
        /// </summary>
        public MouseButton(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MouseButton FindValue(string value)
        {
            return FindValue<MouseButton>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MouseButton(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type OAuthGrantType.
    /// </summary>
    public class OAuthGrantType : ConstantClass
    {
        /// <summary>
        /// Constant AUTHORIZATION_CODE for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType AUTHORIZATION_CODE = new OAuthGrantType("AUTHORIZATION_CODE");

        /// <summary>
        /// Constant CLIENT_CREDENTIALS for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType CLIENT_CREDENTIALS = new OAuthGrantType("CLIENT_CREDENTIALS");

        /// <summary>
        /// Constant TOKEN_EXCHANGE for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType TOKEN_EXCHANGE = new OAuthGrantType("TOKEN_EXCHANGE");

        /// <summary>
        /// Constructs a custom OAuthGrantType for a value not among the defined constants.
        /// </summary>
        public OAuthGrantType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuthGrantType FindValue(string value)
        {
            return FindValue<OAuthGrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuthGrantType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Oauth2FlowType.
    /// </summary>
    public class Oauth2FlowType : ConstantClass
    {
        /// <summary>
        /// Constant M2M for Oauth2FlowType
        /// </summary>
        public static readonly Oauth2FlowType M2M = new Oauth2FlowType("M2M");

        /// <summary>
        /// Constant ON_BEHALF_OF_TOKEN_EXCHANGE for Oauth2FlowType
        /// </summary>
        public static readonly Oauth2FlowType ON_BEHALF_OF_TOKEN_EXCHANGE = new Oauth2FlowType("ON_BEHALF_OF_TOKEN_EXCHANGE");

        /// <summary>
        /// Constant USER_FEDERATION for Oauth2FlowType
        /// </summary>
        public static readonly Oauth2FlowType USER_FEDERATION = new Oauth2FlowType("USER_FEDERATION");

        /// <summary>
        /// Constructs a custom Oauth2FlowType for a value not among the defined constants.
        /// </summary>
        public Oauth2FlowType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Oauth2FlowType FindValue(string value)
        {
            return FindValue<Oauth2FlowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Oauth2FlowType(string value)
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
        /// Constant EQUALS_TO for OperatorType
        /// </summary>
        public static readonly OperatorType EQUALS_TO = new OperatorType("EQUALS_TO");

        /// <summary>
        /// Constant EXISTS for OperatorType
        /// </summary>
        public static readonly OperatorType EXISTS = new OperatorType("EXISTS");

        /// <summary>
        /// Constant NOT_EXISTS for OperatorType
        /// </summary>
        public static readonly OperatorType NOT_EXISTS = new OperatorType("NOT_EXISTS");

        /// <summary>
        /// Constructs a custom OperatorType for a value not among the defined constants.
        /// </summary>
        public OperatorType(string value) : base(value) { }

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
    /// Constants used for properties of type PaymentHttpMethodType.
    /// </summary>
    public class PaymentHttpMethodType : ConstantClass
    {
        /// <summary>
        /// Constant DELETE for PaymentHttpMethodType
        /// </summary>
        public static readonly PaymentHttpMethodType DELETE = new PaymentHttpMethodType("DELETE");

        /// <summary>
        /// Constant GET for PaymentHttpMethodType
        /// </summary>
        public static readonly PaymentHttpMethodType GET = new PaymentHttpMethodType("GET");

        /// <summary>
        /// Constant PATCH for PaymentHttpMethodType
        /// </summary>
        public static readonly PaymentHttpMethodType PATCH = new PaymentHttpMethodType("PATCH");

        /// <summary>
        /// Constant POST for PaymentHttpMethodType
        /// </summary>
        public static readonly PaymentHttpMethodType POST = new PaymentHttpMethodType("POST");

        /// <summary>
        /// Constant PUT for PaymentHttpMethodType
        /// </summary>
        public static readonly PaymentHttpMethodType PUT = new PaymentHttpMethodType("PUT");

        /// <summary>
        /// Constructs a custom PaymentHttpMethodType for a value not among the defined constants.
        /// </summary>
        public PaymentHttpMethodType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentHttpMethodType FindValue(string value)
        {
            return FindValue<PaymentHttpMethodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentHttpMethodType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PaymentInstrumentStatus.
    /// </summary>
    public class PaymentInstrumentStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus ACTIVE = new PaymentInstrumentStatus("ACTIVE");

        /// <summary>
        /// Constant BLOCKED for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus BLOCKED = new PaymentInstrumentStatus("BLOCKED");

        /// <summary>
        /// Constant DELETED for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus DELETED = new PaymentInstrumentStatus("DELETED");

        /// <summary>
        /// Constant FAILED for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus FAILED = new PaymentInstrumentStatus("FAILED");

        /// <summary>
        /// Constant INITIATED for PaymentInstrumentStatus
        /// </summary>
        public static readonly PaymentInstrumentStatus INITIATED = new PaymentInstrumentStatus("INITIATED");

        /// <summary>
        /// Constructs a custom PaymentInstrumentStatus for a value not among the defined constants.
        /// </summary>
        public PaymentInstrumentStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentInstrumentStatus FindValue(string value)
        {
            return FindValue<PaymentInstrumentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentInstrumentStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PaymentInstrumentType.
    /// </summary>
    public class PaymentInstrumentType : ConstantClass
    {
        /// <summary>
        /// Constant EMBEDDED_CRYPTO_WALLET for PaymentInstrumentType
        /// </summary>
        public static readonly PaymentInstrumentType EMBEDDED_CRYPTO_WALLET = new PaymentInstrumentType("EMBEDDED_CRYPTO_WALLET");

        /// <summary>
        /// Constructs a custom PaymentInstrumentType for a value not among the defined constants.
        /// </summary>
        public PaymentInstrumentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentInstrumentType FindValue(string value)
        {
            return FindValue<PaymentInstrumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentInstrumentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PaymentSessionStatus.
    /// </summary>
    public class PaymentSessionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for PaymentSessionStatus
        /// </summary>
        public static readonly PaymentSessionStatus ACTIVE = new PaymentSessionStatus("ACTIVE");

        /// <summary>
        /// Constant DELETED for PaymentSessionStatus
        /// </summary>
        public static readonly PaymentSessionStatus DELETED = new PaymentSessionStatus("DELETED");

        /// <summary>
        /// Constant EXPIRED for PaymentSessionStatus
        /// </summary>
        public static readonly PaymentSessionStatus EXPIRED = new PaymentSessionStatus("EXPIRED");

        /// <summary>
        /// Constructs a custom PaymentSessionStatus for a value not among the defined constants.
        /// </summary>
        public PaymentSessionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentSessionStatus FindValue(string value)
        {
            return FindValue<PaymentSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentSessionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PaymentStatus.
    /// </summary>
    public class PaymentStatus : ConstantClass
    {
        /// <summary>
        /// Constant PROOF_GENERATED for PaymentStatus
        /// </summary>
        public static readonly PaymentStatus PROOF_GENERATED = new PaymentStatus("PROOF_GENERATED");

        /// <summary>
        /// Constructs a custom PaymentStatus for a value not among the defined constants.
        /// </summary>
        public PaymentStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentStatus FindValue(string value)
        {
            return FindValue<PaymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PaymentType.
    /// </summary>
    public class PaymentType : ConstantClass
    {
        /// <summary>
        /// Constant CRYPTO_X402 for PaymentType
        /// </summary>
        public static readonly PaymentType CRYPTO_X402 = new PaymentType("CRYPTO_X402");

        /// <summary>
        /// Constant MPP for PaymentType
        /// </summary>
        public static readonly PaymentType MPP = new PaymentType("MPP");

        /// <summary>
        /// Constructs a custom PaymentType for a value not among the defined constants.
        /// </summary>
        public PaymentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentType FindValue(string value)
        {
            return FindValue<PaymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProgrammingLanguage.
    /// </summary>
    public class ProgrammingLanguage : ConstantClass
    {
        /// <summary>
        /// Constant Javascript for ProgrammingLanguage
        /// </summary>
        public static readonly ProgrammingLanguage Javascript = new ProgrammingLanguage("javascript");

        /// <summary>
        /// Constant Python for ProgrammingLanguage
        /// </summary>
        public static readonly ProgrammingLanguage Python = new ProgrammingLanguage("python");

        /// <summary>
        /// Constant Typescript for ProgrammingLanguage
        /// </summary>
        public static readonly ProgrammingLanguage Typescript = new ProgrammingLanguage("typescript");

        /// <summary>
        /// Constructs a custom ProgrammingLanguage for a value not among the defined constants.
        /// </summary>
        public ProgrammingLanguage(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProgrammingLanguage FindValue(string value)
        {
            return FindValue<ProgrammingLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProgrammingLanguage(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RecommendationStatus.
    /// </summary>
    public class RecommendationStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus COMPLETED = new RecommendationStatus("COMPLETED");

        /// <summary>
        /// Constant DELETING for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus DELETING = new RecommendationStatus("DELETING");

        /// <summary>
        /// Constant FAILED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus FAILED = new RecommendationStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus IN_PROGRESS = new RecommendationStatus("IN_PROGRESS");

        /// <summary>
        /// Constant PENDING for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus PENDING = new RecommendationStatus("PENDING");

        /// <summary>
        /// Constructs a custom RecommendationStatus for a value not among the defined constants.
        /// </summary>
        public RecommendationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationStatus FindValue(string value)
        {
            return FindValue<RecommendationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RecommendationType.
    /// </summary>
    public class RecommendationType : ConstantClass
    {
        /// <summary>
        /// Constant SYSTEM_PROMPT_RECOMMENDATION for RecommendationType
        /// </summary>
        public static readonly RecommendationType SYSTEM_PROMPT_RECOMMENDATION = new RecommendationType("SYSTEM_PROMPT_RECOMMENDATION");

        /// <summary>
        /// Constant TOOL_DESCRIPTION_RECOMMENDATION for RecommendationType
        /// </summary>
        public static readonly RecommendationType TOOL_DESCRIPTION_RECOMMENDATION = new RecommendationType("TOOL_DESCRIPTION_RECOMMENDATION");

        /// <summary>
        /// Constructs a custom RecommendationType for a value not among the defined constants.
        /// </summary>
        public RecommendationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationType FindValue(string value)
        {
            return FindValue<RecommendationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RecordExpiryAction.
    /// </summary>
    public class RecordExpiryAction : ConstantClass
    {
        /// <summary>
        /// Constant REMOVE for RecordExpiryAction
        /// </summary>
        public static readonly RecordExpiryAction REMOVE = new RecordExpiryAction("REMOVE");

        /// <summary>
        /// Constructs a custom RecordExpiryAction for a value not among the defined constants.
        /// </summary>
        public RecordExpiryAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordExpiryAction FindValue(string value)
        {
            return FindValue<RecordExpiryAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordExpiryAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RedactionIdentifier.
    /// </summary>
    public class RedactionIdentifier : ConstantClass
    {
        /// <summary>
        /// Constant ADDRESS for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier ADDRESS = new RedactionIdentifier("ADDRESS");

        /// <summary>
        /// Constant AWS_SECRET_KEY for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier AWS_SECRET_KEY = new RedactionIdentifier("AWS_SECRET_KEY");

        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER_DE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier BANK_ACCOUNT_NUMBER_DE = new RedactionIdentifier("BANK_ACCOUNT_NUMBER_DE");

        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier BANK_ACCOUNT_NUMBER_ES = new RedactionIdentifier("BANK_ACCOUNT_NUMBER_ES");

        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER_FR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier BANK_ACCOUNT_NUMBER_FR = new RedactionIdentifier("BANK_ACCOUNT_NUMBER_FR");

        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier BANK_ACCOUNT_NUMBER_GB = new RedactionIdentifier("BANK_ACCOUNT_NUMBER_GB");

        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER_IT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier BANK_ACCOUNT_NUMBER_IT = new RedactionIdentifier("BANK_ACCOUNT_NUMBER_IT");

        /// <summary>
        /// Constant BANK_ACCOUNT_NUMBER_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier BANK_ACCOUNT_NUMBER_US = new RedactionIdentifier("BANK_ACCOUNT_NUMBER_US");

        /// <summary>
        /// Constant CEP_CODE_BR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier CEP_CODE_BR = new RedactionIdentifier("CEP_CODE_BR");

        /// <summary>
        /// Constant CNPJ_BR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier CNPJ_BR = new RedactionIdentifier("CNPJ_BR");

        /// <summary>
        /// Constant CPF_CODE_BR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier CPF_CODE_BR = new RedactionIdentifier("CPF_CODE_BR");

        /// <summary>
        /// Constant CREDIT_CARD_EXPIRATION for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier CREDIT_CARD_EXPIRATION = new RedactionIdentifier("CREDIT_CARD_EXPIRATION");

        /// <summary>
        /// Constant CREDIT_CARD_MAGNETIC_STRIPE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier CREDIT_CARD_MAGNETIC_STRIPE = new RedactionIdentifier("CREDIT_CARD_MAGNETIC_STRIPE");

        /// <summary>
        /// Constant CREDIT_CARD_NUMBER for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier CREDIT_CARD_NUMBER = new RedactionIdentifier("CREDIT_CARD_NUMBER");

        /// <summary>
        /// Constant CREDIT_CARD_SECURITY_CODE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier CREDIT_CARD_SECURITY_CODE = new RedactionIdentifier("CREDIT_CARD_SECURITY_CODE");

        /// <summary>
        /// Constant DATE_OF_BIRTH for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DATE_OF_BIRTH = new RedactionIdentifier("DATE_OF_BIRTH");

        /// <summary>
        /// Constant DRIVERS_LICENSE_AT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_AT = new RedactionIdentifier("DRIVERS_LICENSE_AT");

        /// <summary>
        /// Constant DRIVERS_LICENSE_AU for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_AU = new RedactionIdentifier("DRIVERS_LICENSE_AU");

        /// <summary>
        /// Constant DRIVERS_LICENSE_BE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_BE = new RedactionIdentifier("DRIVERS_LICENSE_BE");

        /// <summary>
        /// Constant DRIVERS_LICENSE_BG for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_BG = new RedactionIdentifier("DRIVERS_LICENSE_BG");

        /// <summary>
        /// Constant DRIVERS_LICENSE_CA for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_CA = new RedactionIdentifier("DRIVERS_LICENSE_CA");

        /// <summary>
        /// Constant DRIVERS_LICENSE_CY for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_CY = new RedactionIdentifier("DRIVERS_LICENSE_CY");

        /// <summary>
        /// Constant DRIVERS_LICENSE_CZ for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_CZ = new RedactionIdentifier("DRIVERS_LICENSE_CZ");

        /// <summary>
        /// Constant DRIVERS_LICENSE_DE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_DE = new RedactionIdentifier("DRIVERS_LICENSE_DE");

        /// <summary>
        /// Constant DRIVERS_LICENSE_DK for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_DK = new RedactionIdentifier("DRIVERS_LICENSE_DK");

        /// <summary>
        /// Constant DRIVERS_LICENSE_EE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_EE = new RedactionIdentifier("DRIVERS_LICENSE_EE");

        /// <summary>
        /// Constant DRIVERS_LICENSE_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_ES = new RedactionIdentifier("DRIVERS_LICENSE_ES");

        /// <summary>
        /// Constant DRIVERS_LICENSE_FI for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_FI = new RedactionIdentifier("DRIVERS_LICENSE_FI");

        /// <summary>
        /// Constant DRIVERS_LICENSE_FR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_FR = new RedactionIdentifier("DRIVERS_LICENSE_FR");

        /// <summary>
        /// Constant DRIVERS_LICENSE_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_GB = new RedactionIdentifier("DRIVERS_LICENSE_GB");

        /// <summary>
        /// Constant DRIVERS_LICENSE_GR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_GR = new RedactionIdentifier("DRIVERS_LICENSE_GR");

        /// <summary>
        /// Constant DRIVERS_LICENSE_HR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_HR = new RedactionIdentifier("DRIVERS_LICENSE_HR");

        /// <summary>
        /// Constant DRIVERS_LICENSE_HU for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_HU = new RedactionIdentifier("DRIVERS_LICENSE_HU");

        /// <summary>
        /// Constant DRIVERS_LICENSE_IE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_IE = new RedactionIdentifier("DRIVERS_LICENSE_IE");

        /// <summary>
        /// Constant DRIVERS_LICENSE_IT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_IT = new RedactionIdentifier("DRIVERS_LICENSE_IT");

        /// <summary>
        /// Constant DRIVERS_LICENSE_LT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_LT = new RedactionIdentifier("DRIVERS_LICENSE_LT");

        /// <summary>
        /// Constant DRIVERS_LICENSE_LU for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_LU = new RedactionIdentifier("DRIVERS_LICENSE_LU");

        /// <summary>
        /// Constant DRIVERS_LICENSE_LV for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_LV = new RedactionIdentifier("DRIVERS_LICENSE_LV");

        /// <summary>
        /// Constant DRIVERS_LICENSE_MT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_MT = new RedactionIdentifier("DRIVERS_LICENSE_MT");

        /// <summary>
        /// Constant DRIVERS_LICENSE_NL for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_NL = new RedactionIdentifier("DRIVERS_LICENSE_NL");

        /// <summary>
        /// Constant DRIVERS_LICENSE_PL for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_PL = new RedactionIdentifier("DRIVERS_LICENSE_PL");

        /// <summary>
        /// Constant DRIVERS_LICENSE_PT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_PT = new RedactionIdentifier("DRIVERS_LICENSE_PT");

        /// <summary>
        /// Constant DRIVERS_LICENSE_RO for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_RO = new RedactionIdentifier("DRIVERS_LICENSE_RO");

        /// <summary>
        /// Constant DRIVERS_LICENSE_SE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_SE = new RedactionIdentifier("DRIVERS_LICENSE_SE");

        /// <summary>
        /// Constant DRIVERS_LICENSE_SI for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_SI = new RedactionIdentifier("DRIVERS_LICENSE_SI");

        /// <summary>
        /// Constant DRIVERS_LICENSE_SK for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_SK = new RedactionIdentifier("DRIVERS_LICENSE_SK");

        /// <summary>
        /// Constant DRIVERS_LICENSE_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRIVERS_LICENSE_US = new RedactionIdentifier("DRIVERS_LICENSE_US");

        /// <summary>
        /// Constant DRUG_ENFORCEMENT_AGENCY_NUMBER_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier DRUG_ENFORCEMENT_AGENCY_NUMBER_US = new RedactionIdentifier("DRUG_ENFORCEMENT_AGENCY_NUMBER_US");

        /// <summary>
        /// Constant ELECTORAL_ROLL_NUMBER_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier ELECTORAL_ROLL_NUMBER_GB = new RedactionIdentifier("ELECTORAL_ROLL_NUMBER_GB");

        /// <summary>
        /// Constant EMAIL_ADDRESS for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier EMAIL_ADDRESS = new RedactionIdentifier("EMAIL_ADDRESS");

        /// <summary>
        /// Constant HEALTHCARE_PROCEDURE_CODE_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier HEALTHCARE_PROCEDURE_CODE_US = new RedactionIdentifier("HEALTHCARE_PROCEDURE_CODE_US");

        /// <summary>
        /// Constant HEALTH_INSURANCE_CARD_NUMBER_EU for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier HEALTH_INSURANCE_CARD_NUMBER_EU = new RedactionIdentifier("HEALTH_INSURANCE_CARD_NUMBER_EU");

        /// <summary>
        /// Constant HEALTH_INSURANCE_CLAIM_NUMBER_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier HEALTH_INSURANCE_CLAIM_NUMBER_US = new RedactionIdentifier("HEALTH_INSURANCE_CLAIM_NUMBER_US");

        /// <summary>
        /// Constant HEALTH_INSURANCE_NUMBER_FR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier HEALTH_INSURANCE_NUMBER_FR = new RedactionIdentifier("HEALTH_INSURANCE_NUMBER_FR");

        /// <summary>
        /// Constant INDIVIDUAL_TAX_IDENTIFICATION_NUMBER_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier INDIVIDUAL_TAX_IDENTIFICATION_NUMBER_US = new RedactionIdentifier("INDIVIDUAL_TAX_IDENTIFICATION_NUMBER_US");

        /// <summary>
        /// Constant INSEE_CODE_FR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier INSEE_CODE_FR = new RedactionIdentifier("INSEE_CODE_FR");

        /// <summary>
        /// Constant IP_ADDRESS for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier IP_ADDRESS = new RedactionIdentifier("IP_ADDRESS");

        /// <summary>
        /// Constant LAT_LONG for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier LAT_LONG = new RedactionIdentifier("LAT_LONG");

        /// <summary>
        /// Constant MEDICARE_BENEFICIARY_NUMBER_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier MEDICARE_BENEFICIARY_NUMBER_US = new RedactionIdentifier("MEDICARE_BENEFICIARY_NUMBER_US");

        /// <summary>
        /// Constant NAME for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NAME = new RedactionIdentifier("NAME");

        /// <summary>
        /// Constant NATIONAL_DRUG_CODE_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NATIONAL_DRUG_CODE_US = new RedactionIdentifier("NATIONAL_DRUG_CODE_US");

        /// <summary>
        /// Constant NATIONAL_IDENTIFICATION_NUMBER_DE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NATIONAL_IDENTIFICATION_NUMBER_DE = new RedactionIdentifier("NATIONAL_IDENTIFICATION_NUMBER_DE");

        /// <summary>
        /// Constant NATIONAL_IDENTIFICATION_NUMBER_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NATIONAL_IDENTIFICATION_NUMBER_ES = new RedactionIdentifier("NATIONAL_IDENTIFICATION_NUMBER_ES");

        /// <summary>
        /// Constant NATIONAL_IDENTIFICATION_NUMBER_IT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NATIONAL_IDENTIFICATION_NUMBER_IT = new RedactionIdentifier("NATIONAL_IDENTIFICATION_NUMBER_IT");

        /// <summary>
        /// Constant NATIONAL_INSURANCE_NUMBER_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NATIONAL_INSURANCE_NUMBER_GB = new RedactionIdentifier("NATIONAL_INSURANCE_NUMBER_GB");

        /// <summary>
        /// Constant NATIONAL_PROVIDER_ID_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NATIONAL_PROVIDER_ID_US = new RedactionIdentifier("NATIONAL_PROVIDER_ID_US");

        /// <summary>
        /// Constant NHS_NUMBER_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NHS_NUMBER_GB = new RedactionIdentifier("NHS_NUMBER_GB");

        /// <summary>
        /// Constant NIE_NUMBER_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NIE_NUMBER_ES = new RedactionIdentifier("NIE_NUMBER_ES");

        /// <summary>
        /// Constant NIF_NUMBER_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier NIF_NUMBER_ES = new RedactionIdentifier("NIF_NUMBER_ES");

        /// <summary>
        /// Constant OPEN_SSH_PRIVATE_KEY for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier OPEN_SSH_PRIVATE_KEY = new RedactionIdentifier("OPEN_SSH_PRIVATE_KEY");

        /// <summary>
        /// Constant PASSPORT_NUMBER_CA for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PASSPORT_NUMBER_CA = new RedactionIdentifier("PASSPORT_NUMBER_CA");

        /// <summary>
        /// Constant PASSPORT_NUMBER_DE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PASSPORT_NUMBER_DE = new RedactionIdentifier("PASSPORT_NUMBER_DE");

        /// <summary>
        /// Constant PASSPORT_NUMBER_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PASSPORT_NUMBER_ES = new RedactionIdentifier("PASSPORT_NUMBER_ES");

        /// <summary>
        /// Constant PASSPORT_NUMBER_FR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PASSPORT_NUMBER_FR = new RedactionIdentifier("PASSPORT_NUMBER_FR");

        /// <summary>
        /// Constant PASSPORT_NUMBER_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PASSPORT_NUMBER_GB = new RedactionIdentifier("PASSPORT_NUMBER_GB");

        /// <summary>
        /// Constant PASSPORT_NUMBER_IT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PASSPORT_NUMBER_IT = new RedactionIdentifier("PASSPORT_NUMBER_IT");

        /// <summary>
        /// Constant PASSPORT_NUMBER_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PASSPORT_NUMBER_US = new RedactionIdentifier("PASSPORT_NUMBER_US");

        /// <summary>
        /// Constant PERMANENT_RESIDENCE_NUMBER_CA for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PERMANENT_RESIDENCE_NUMBER_CA = new RedactionIdentifier("PERMANENT_RESIDENCE_NUMBER_CA");

        /// <summary>
        /// Constant PERSONAL_HEALTH_NUMBER_CA for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PERSONAL_HEALTH_NUMBER_CA = new RedactionIdentifier("PERSONAL_HEALTH_NUMBER_CA");

        /// <summary>
        /// Constant PGP_PRIVATE_KEY for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PGP_PRIVATE_KEY = new RedactionIdentifier("PGP_PRIVATE_KEY");

        /// <summary>
        /// Constant PHONE_NUMBER_BR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PHONE_NUMBER_BR = new RedactionIdentifier("PHONE_NUMBER_BR");

        /// <summary>
        /// Constant PHONE_NUMBER_DE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PHONE_NUMBER_DE = new RedactionIdentifier("PHONE_NUMBER_DE");

        /// <summary>
        /// Constant PHONE_NUMBER_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PHONE_NUMBER_ES = new RedactionIdentifier("PHONE_NUMBER_ES");

        /// <summary>
        /// Constant PHONE_NUMBER_FR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PHONE_NUMBER_FR = new RedactionIdentifier("PHONE_NUMBER_FR");

        /// <summary>
        /// Constant PHONE_NUMBER_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PHONE_NUMBER_GB = new RedactionIdentifier("PHONE_NUMBER_GB");

        /// <summary>
        /// Constant PHONE_NUMBER_IT for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PHONE_NUMBER_IT = new RedactionIdentifier("PHONE_NUMBER_IT");

        /// <summary>
        /// Constant PHONE_NUMBER_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PHONE_NUMBER_US = new RedactionIdentifier("PHONE_NUMBER_US");

        /// <summary>
        /// Constant PKCS_PRIVATE_KEY for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PKCS_PRIVATE_KEY = new RedactionIdentifier("PKCS_PRIVATE_KEY");

        /// <summary>
        /// Constant POSTAL_CODE_CA for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier POSTAL_CODE_CA = new RedactionIdentifier("POSTAL_CODE_CA");

        /// <summary>
        /// Constant PUTTY_PRIVATE_KEY for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier PUTTY_PRIVATE_KEY = new RedactionIdentifier("PUTTY_PRIVATE_KEY");

        /// <summary>
        /// Constant RG_NUMBER_BR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier RG_NUMBER_BR = new RedactionIdentifier("RG_NUMBER_BR");

        /// <summary>
        /// Constant SOCIAL_INSURANCE_NUMBER_CA for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier SOCIAL_INSURANCE_NUMBER_CA = new RedactionIdentifier("SOCIAL_INSURANCE_NUMBER_CA");

        /// <summary>
        /// Constant SSN_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier SSN_ES = new RedactionIdentifier("SSN_ES");

        /// <summary>
        /// Constant SSN_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier SSN_US = new RedactionIdentifier("SSN_US");

        /// <summary>
        /// Constant TAX_ID_DE for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier TAX_ID_DE = new RedactionIdentifier("TAX_ID_DE");

        /// <summary>
        /// Constant TAX_ID_ES for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier TAX_ID_ES = new RedactionIdentifier("TAX_ID_ES");

        /// <summary>
        /// Constant TAX_ID_FR for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier TAX_ID_FR = new RedactionIdentifier("TAX_ID_FR");

        /// <summary>
        /// Constant TAX_ID_GB for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier TAX_ID_GB = new RedactionIdentifier("TAX_ID_GB");

        /// <summary>
        /// Constant VEHICLE_IDENTIFICATION_NUMBER for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier VEHICLE_IDENTIFICATION_NUMBER = new RedactionIdentifier("VEHICLE_IDENTIFICATION_NUMBER");

        /// <summary>
        /// Constant ZIP_CODE_US for RedactionIdentifier
        /// </summary>
        public static readonly RedactionIdentifier ZIP_CODE_US = new RedactionIdentifier("ZIP_CODE_US");

        /// <summary>
        /// Constructs a custom RedactionIdentifier for a value not among the defined constants.
        /// </summary>
        public RedactionIdentifier(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedactionIdentifier FindValue(string value)
        {
            return FindValue<RedactionIdentifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedactionIdentifier(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RegistryRecordStatus.
    /// </summary>
    public class RegistryRecordStatus : ConstantClass
    {
        /// <summary>
        /// Constant APPROVED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus APPROVED = new RegistryRecordStatus("APPROVED");

        /// <summary>
        /// Constant DEPRECATED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus DEPRECATED = new RegistryRecordStatus("DEPRECATED");

        /// <summary>
        /// Constant DRAFT for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus DRAFT = new RegistryRecordStatus("DRAFT");

        /// <summary>
        /// Constant PENDING_APPROVAL for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus PENDING_APPROVAL = new RegistryRecordStatus("PENDING_APPROVAL");

        /// <summary>
        /// Constant REJECTED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus REJECTED = new RegistryRecordStatus("REJECTED");

        /// <summary>
        /// Constructs a custom RegistryRecordStatus for a value not among the defined constants.
        /// </summary>
        public RegistryRecordStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryRecordStatus FindValue(string value)
        {
            return FindValue<RegistryRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryRecordStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResourceContentType.
    /// </summary>
    public class ResourceContentType : ConstantClass
    {
        /// <summary>
        /// Constant Blob for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType Blob = new ResourceContentType("blob");

        /// <summary>
        /// Constant Text for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType Text = new ResourceContentType("text");

        /// <summary>
        /// Constructs a custom ResourceContentType for a value not among the defined constants.
        /// </summary>
        public ResourceContentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceContentType FindValue(string value)
        {
            return FindValue<ResourceContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceContentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResultAggregation.
    /// </summary>
    public class ResultAggregation : ConstantClass
    {
        /// <summary>
        /// Constant AllMatch for ResultAggregation
        /// </summary>
        public static readonly ResultAggregation AllMatch = new ResultAggregation("AllMatch");

        /// <summary>
        /// Constant AnyMatch for ResultAggregation
        /// </summary>
        public static readonly ResultAggregation AnyMatch = new ResultAggregation("AnyMatch");

        /// <summary>
        /// Constant Max for ResultAggregation
        /// </summary>
        public static readonly ResultAggregation Max = new ResultAggregation("Max");

        /// <summary>
        /// Constant Mean for ResultAggregation
        /// </summary>
        public static readonly ResultAggregation Mean = new ResultAggregation("Mean");

        /// <summary>
        /// Constant Min for ResultAggregation
        /// </summary>
        public static readonly ResultAggregation Min = new ResultAggregation("Min");

        /// <summary>
        /// Constructs a custom ResultAggregation for a value not among the defined constants.
        /// </summary>
        public ResultAggregation(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResultAggregation FindValue(string value)
        {
            return FindValue<ResultAggregation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResultAggregation(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResultDestination.
    /// </summary>
    public class ResultDestination : ConstantClass
    {
        /// <summary>
        /// Constant DEDICATED_LOG_GROUP for ResultDestination
        /// </summary>
        public static readonly ResultDestination DEDICATED_LOG_GROUP = new ResultDestination("DEDICATED_LOG_GROUP");

        /// <summary>
        /// Constant SOURCE_LOG_GROUP for ResultDestination
        /// </summary>
        public static readonly ResultDestination SOURCE_LOG_GROUP = new ResultDestination("SOURCE_LOG_GROUP");

        /// <summary>
        /// Constructs a custom ResultDestination for a value not among the defined constants.
        /// </summary>
        public ResultDestination(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResultDestination FindValue(string value)
        {
            return FindValue<ResultDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResultDestination(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Role.
    /// </summary>
    public class Role : ConstantClass
    {
        /// <summary>
        /// Constant ASSISTANT for Role
        /// </summary>
        public static readonly Role ASSISTANT = new Role("ASSISTANT");

        /// <summary>
        /// Constant OTHER for Role
        /// </summary>
        public static readonly Role OTHER = new Role("OTHER");

        /// <summary>
        /// Constant TOOL for Role
        /// </summary>
        public static readonly Role TOOL = new Role("TOOL");

        /// <summary>
        /// Constant USER for Role
        /// </summary>
        public static readonly Role USER = new Role("USER");

        /// <summary>
        /// Constructs a custom Role for a value not among the defined constants.
        /// </summary>
        public Role(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Role FindValue(string value)
        {
            return FindValue<Role>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Role(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ScenarioType.
    /// </summary>
    public class ScenarioType : ConstantClass
    {
        /// <summary>
        /// Constant DYNAMIC for ScenarioType
        /// </summary>
        public static readonly ScenarioType DYNAMIC = new ScenarioType("DYNAMIC");

        /// <summary>
        /// Constant FIXED for ScenarioType
        /// </summary>
        public static readonly ScenarioType FIXED = new ScenarioType("FIXED");

        /// <summary>
        /// Constructs a custom ScenarioType for a value not among the defined constants.
        /// </summary>
        public ScenarioType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScenarioType FindValue(string value)
        {
            return FindValue<ScenarioType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScenarioType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ScreenshotFormat.
    /// </summary>
    public class ScreenshotFormat : ConstantClass
    {
        /// <summary>
        /// Constant PNG for ScreenshotFormat
        /// </summary>
        public static readonly ScreenshotFormat PNG = new ScreenshotFormat("PNG");

        /// <summary>
        /// Constructs a custom ScreenshotFormat for a value not among the defined constants.
        /// </summary>
        public ScreenshotFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScreenshotFormat FindValue(string value)
        {
            return FindValue<ScreenshotFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScreenshotFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SessionStatus.
    /// </summary>
    public class SessionStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for SessionStatus
        /// </summary>
        public static readonly SessionStatus FAILED = new SessionStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for SessionStatus
        /// </summary>
        public static readonly SessionStatus IN_PROGRESS = new SessionStatus("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom SessionStatus for a value not among the defined constants.
        /// </summary>
        public SessionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionStatus FindValue(string value)
        {
            return FindValue<SessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {
        /// <summary>
        /// Constant Canceled for TaskStatus
        /// </summary>
        public static readonly TaskStatus Canceled = new TaskStatus("canceled");

        /// <summary>
        /// Constant Completed for TaskStatus
        /// </summary>
        public static readonly TaskStatus Completed = new TaskStatus("completed");

        /// <summary>
        /// Constant Failed for TaskStatus
        /// </summary>
        public static readonly TaskStatus Failed = new TaskStatus("failed");

        /// <summary>
        /// Constant Submitted for TaskStatus
        /// </summary>
        public static readonly TaskStatus Submitted = new TaskStatus("submitted");

        /// <summary>
        /// Constant Working for TaskStatus
        /// </summary>
        public static readonly TaskStatus Working = new TaskStatus("working");

        /// <summary>
        /// Constructs a custom TaskStatus for a value not among the defined constants.
        /// </summary>
        public TaskStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ToolName.
    /// </summary>
    public class ToolName : ConstantClass
    {
        /// <summary>
        /// Constant ExecuteCode for ToolName
        /// </summary>
        public static readonly ToolName ExecuteCode = new ToolName("executeCode");

        /// <summary>
        /// Constant ExecuteCommand for ToolName
        /// </summary>
        public static readonly ToolName ExecuteCommand = new ToolName("executeCommand");

        /// <summary>
        /// Constant GetTask for ToolName
        /// </summary>
        public static readonly ToolName GetTask = new ToolName("getTask");

        /// <summary>
        /// Constant ListFiles for ToolName
        /// </summary>
        public static readonly ToolName ListFiles = new ToolName("listFiles");

        /// <summary>
        /// Constant ReadFiles for ToolName
        /// </summary>
        public static readonly ToolName ReadFiles = new ToolName("readFiles");

        /// <summary>
        /// Constant RemoveFiles for ToolName
        /// </summary>
        public static readonly ToolName RemoveFiles = new ToolName("removeFiles");

        /// <summary>
        /// Constant StartCommandExecution for ToolName
        /// </summary>
        public static readonly ToolName StartCommandExecution = new ToolName("startCommandExecution");

        /// <summary>
        /// Constant StopTask for ToolName
        /// </summary>
        public static readonly ToolName StopTask = new ToolName("stopTask");

        /// <summary>
        /// Constant WriteFiles for ToolName
        /// </summary>
        public static readonly ToolName WriteFiles = new ToolName("writeFiles");

        /// <summary>
        /// Constructs a custom ToolName for a value not among the defined constants.
        /// </summary>
        public ToolName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToolName FindValue(string value)
        {
            return FindValue<ToolName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToolName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {
        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("CannotParse");

        /// <summary>
        /// Constant EventInOtherSession for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason EventInOtherSession = new ValidationExceptionReason("EventInOtherSession");

        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");

        /// <summary>
        /// Constant IdempotentParameterMismatchException for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason IdempotentParameterMismatchException = new ValidationExceptionReason("IdempotentParameterMismatchException");

        /// <summary>
        /// Constant ResourceConflict for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ResourceConflict = new ValidationExceptionReason("ResourceConflict");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }
}
