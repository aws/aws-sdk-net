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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SimpleSystemsManagement
{

    /// <summary>
    /// Constants used for properties of type AssociationFilterKey.
    /// </summary>
    public class AssociationFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant AssociationId for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey AssociationId = new AssociationFilterKey("AssociationId");
        /// <summary>
        /// Constant AssociationName for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey AssociationName = new AssociationFilterKey("AssociationName");
        /// <summary>
        /// Constant AssociationStatusName for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey AssociationStatusName = new AssociationFilterKey("AssociationStatusName");
        /// <summary>
        /// Constant InstanceId for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey InstanceId = new AssociationFilterKey("InstanceId");
        /// <summary>
        /// Constant LastExecutedAfter for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey LastExecutedAfter = new AssociationFilterKey("LastExecutedAfter");
        /// <summary>
        /// Constant LastExecutedBefore for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey LastExecutedBefore = new AssociationFilterKey("LastExecutedBefore");
        /// <summary>
        /// Constant Name for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey Name = new AssociationFilterKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationFilterKey FindValue(string value)
        {
            return FindValue<AssociationFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationStatusName.
    /// </summary>
    public class AssociationStatusName : ConstantClass
    {

        /// <summary>
        /// Constant Failed for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Failed = new AssociationStatusName("Failed");
        /// <summary>
        /// Constant Pending for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Pending = new AssociationStatusName("Pending");
        /// <summary>
        /// Constant Success for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Success = new AssociationStatusName("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationStatusName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationStatusName FindValue(string value)
        {
            return FindValue<AssociationStatusName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationStatusName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationExecutionFilterKey.
    /// </summary>
    public class AutomationExecutionFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant CurrentAction for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey CurrentAction = new AutomationExecutionFilterKey("CurrentAction");
        /// <summary>
        /// Constant DocumentNamePrefix for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey DocumentNamePrefix = new AutomationExecutionFilterKey("DocumentNamePrefix");
        /// <summary>
        /// Constant ExecutionId for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey ExecutionId = new AutomationExecutionFilterKey("ExecutionId");
        /// <summary>
        /// Constant ExecutionStatus for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey ExecutionStatus = new AutomationExecutionFilterKey("ExecutionStatus");
        /// <summary>
        /// Constant ParentExecutionId for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey ParentExecutionId = new AutomationExecutionFilterKey("ParentExecutionId");
        /// <summary>
        /// Constant StartTimeAfter for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey StartTimeAfter = new AutomationExecutionFilterKey("StartTimeAfter");
        /// <summary>
        /// Constant StartTimeBefore for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey StartTimeBefore = new AutomationExecutionFilterKey("StartTimeBefore");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationExecutionFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationExecutionFilterKey FindValue(string value)
        {
            return FindValue<AutomationExecutionFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationExecutionFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationExecutionStatus.
    /// </summary>
    public class AutomationExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Cancelled = new AutomationExecutionStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Cancelling = new AutomationExecutionStatus("Cancelling");
        /// <summary>
        /// Constant Failed for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Failed = new AutomationExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus InProgress = new AutomationExecutionStatus("InProgress");
        /// <summary>
        /// Constant Pending for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Pending = new AutomationExecutionStatus("Pending");
        /// <summary>
        /// Constant Success for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Success = new AutomationExecutionStatus("Success");
        /// <summary>
        /// Constant TimedOut for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus TimedOut = new AutomationExecutionStatus("TimedOut");
        /// <summary>
        /// Constant Waiting for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Waiting = new AutomationExecutionStatus("Waiting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationExecutionStatus FindValue(string value)
        {
            return FindValue<AutomationExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandFilterKey.
    /// </summary>
    public class CommandFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant InvokedAfter for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey InvokedAfter = new CommandFilterKey("InvokedAfter");
        /// <summary>
        /// Constant InvokedBefore for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey InvokedBefore = new CommandFilterKey("InvokedBefore");
        /// <summary>
        /// Constant Status for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey Status = new CommandFilterKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandFilterKey FindValue(string value)
        {
            return FindValue<CommandFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandInvocationStatus.
    /// </summary>
    public class CommandInvocationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Cancelled = new CommandInvocationStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Cancelling = new CommandInvocationStatus("Cancelling");
        /// <summary>
        /// Constant Delayed for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Delayed = new CommandInvocationStatus("Delayed");
        /// <summary>
        /// Constant Failed for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Failed = new CommandInvocationStatus("Failed");
        /// <summary>
        /// Constant InProgress for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus InProgress = new CommandInvocationStatus("InProgress");
        /// <summary>
        /// Constant Pending for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Pending = new CommandInvocationStatus("Pending");
        /// <summary>
        /// Constant Success for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Success = new CommandInvocationStatus("Success");
        /// <summary>
        /// Constant TimedOut for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus TimedOut = new CommandInvocationStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandInvocationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandInvocationStatus FindValue(string value)
        {
            return FindValue<CommandInvocationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandInvocationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandPluginStatus.
    /// </summary>
    public class CommandPluginStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Cancelled = new CommandPluginStatus("Cancelled");
        /// <summary>
        /// Constant Failed for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Failed = new CommandPluginStatus("Failed");
        /// <summary>
        /// Constant InProgress for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus InProgress = new CommandPluginStatus("InProgress");
        /// <summary>
        /// Constant Pending for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Pending = new CommandPluginStatus("Pending");
        /// <summary>
        /// Constant Success for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Success = new CommandPluginStatus("Success");
        /// <summary>
        /// Constant TimedOut for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus TimedOut = new CommandPluginStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandPluginStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandPluginStatus FindValue(string value)
        {
            return FindValue<CommandPluginStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandPluginStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandStatus.
    /// </summary>
    public class CommandStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for CommandStatus
        /// </summary>
        public static readonly CommandStatus Cancelled = new CommandStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for CommandStatus
        /// </summary>
        public static readonly CommandStatus Cancelling = new CommandStatus("Cancelling");
        /// <summary>
        /// Constant Failed for CommandStatus
        /// </summary>
        public static readonly CommandStatus Failed = new CommandStatus("Failed");
        /// <summary>
        /// Constant InProgress for CommandStatus
        /// </summary>
        public static readonly CommandStatus InProgress = new CommandStatus("InProgress");
        /// <summary>
        /// Constant Pending for CommandStatus
        /// </summary>
        public static readonly CommandStatus Pending = new CommandStatus("Pending");
        /// <summary>
        /// Constant Success for CommandStatus
        /// </summary>
        public static readonly CommandStatus Success = new CommandStatus("Success");
        /// <summary>
        /// Constant TimedOut for CommandStatus
        /// </summary>
        public static readonly CommandStatus TimedOut = new CommandStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandStatus FindValue(string value)
        {
            return FindValue<CommandStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceQueryOperatorType.
    /// </summary>
    public class ComplianceQueryOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant BEGIN_WITH for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType BEGIN_WITH = new ComplianceQueryOperatorType("BEGIN_WITH");
        /// <summary>
        /// Constant EQUAL for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType EQUAL = new ComplianceQueryOperatorType("EQUAL");
        /// <summary>
        /// Constant GREATER_THAN for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType GREATER_THAN = new ComplianceQueryOperatorType("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType LESS_THAN = new ComplianceQueryOperatorType("LESS_THAN");
        /// <summary>
        /// Constant NOT_EQUAL for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType NOT_EQUAL = new ComplianceQueryOperatorType("NOT_EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceQueryOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceQueryOperatorType FindValue(string value)
        {
            return FindValue<ComplianceQueryOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceQueryOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceSeverity.
    /// </summary>
    public class ComplianceSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity CRITICAL = new ComplianceSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity HIGH = new ComplianceSeverity("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity INFORMATIONAL = new ComplianceSeverity("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity LOW = new ComplianceSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity MEDIUM = new ComplianceSeverity("MEDIUM");
        /// <summary>
        /// Constant UNSPECIFIED for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity UNSPECIFIED = new ComplianceSeverity("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceSeverity FindValue(string value)
        {
            return FindValue<ComplianceSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceStatus.
    /// </summary>
    public class ComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANT for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus COMPLIANT = new ComplianceStatus("COMPLIANT");
        /// <summary>
        /// Constant NON_COMPLIANT for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus NON_COMPLIANT = new ComplianceStatus("NON_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceStatus FindValue(string value)
        {
            return FindValue<ComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescribeActivationsFilterKeys.
    /// </summary>
    public class DescribeActivationsFilterKeys : ConstantClass
    {

        /// <summary>
        /// Constant ActivationIds for DescribeActivationsFilterKeys
        /// </summary>
        public static readonly DescribeActivationsFilterKeys ActivationIds = new DescribeActivationsFilterKeys("ActivationIds");
        /// <summary>
        /// Constant DefaultInstanceName for DescribeActivationsFilterKeys
        /// </summary>
        public static readonly DescribeActivationsFilterKeys DefaultInstanceName = new DescribeActivationsFilterKeys("DefaultInstanceName");
        /// <summary>
        /// Constant IamRole for DescribeActivationsFilterKeys
        /// </summary>
        public static readonly DescribeActivationsFilterKeys IamRole = new DescribeActivationsFilterKeys("IamRole");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeActivationsFilterKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeActivationsFilterKeys FindValue(string value)
        {
            return FindValue<DescribeActivationsFilterKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeActivationsFilterKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentFilterKey.
    /// </summary>
    public class DocumentFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant DocumentType for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey DocumentType = new DocumentFilterKey("DocumentType");
        /// <summary>
        /// Constant Name for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey Name = new DocumentFilterKey("Name");
        /// <summary>
        /// Constant Owner for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey Owner = new DocumentFilterKey("Owner");
        /// <summary>
        /// Constant PlatformTypes for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey PlatformTypes = new DocumentFilterKey("PlatformTypes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentFilterKey FindValue(string value)
        {
            return FindValue<DocumentFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentFormat.
    /// </summary>
    public class DocumentFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat JSON = new DocumentFormat("JSON");
        /// <summary>
        /// Constant YAML for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat YAML = new DocumentFormat("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentFormat FindValue(string value)
        {
            return FindValue<DocumentFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentHashType.
    /// </summary>
    public class DocumentHashType : ConstantClass
    {

        /// <summary>
        /// Constant Sha1 for DocumentHashType
        /// </summary>
        public static readonly DocumentHashType Sha1 = new DocumentHashType("Sha1");
        /// <summary>
        /// Constant Sha256 for DocumentHashType
        /// </summary>
        public static readonly DocumentHashType Sha256 = new DocumentHashType("Sha256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentHashType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentHashType FindValue(string value)
        {
            return FindValue<DocumentHashType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentHashType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentParameterType.
    /// </summary>
    public class DocumentParameterType : ConstantClass
    {

        /// <summary>
        /// Constant String for DocumentParameterType
        /// </summary>
        public static readonly DocumentParameterType String = new DocumentParameterType("String");
        /// <summary>
        /// Constant StringList for DocumentParameterType
        /// </summary>
        public static readonly DocumentParameterType StringList = new DocumentParameterType("StringList");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentParameterType FindValue(string value)
        {
            return FindValue<DocumentParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentPermissionType.
    /// </summary>
    public class DocumentPermissionType : ConstantClass
    {

        /// <summary>
        /// Constant Share for DocumentPermissionType
        /// </summary>
        public static readonly DocumentPermissionType Share = new DocumentPermissionType("Share");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentPermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentPermissionType FindValue(string value)
        {
            return FindValue<DocumentPermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentPermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentStatus.
    /// </summary>
    public class DocumentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Active = new DocumentStatus("Active");
        /// <summary>
        /// Constant Creating for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Creating = new DocumentStatus("Creating");
        /// <summary>
        /// Constant Deleting for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Deleting = new DocumentStatus("Deleting");
        /// <summary>
        /// Constant Updating for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Updating = new DocumentStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentStatus FindValue(string value)
        {
            return FindValue<DocumentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentType.
    /// </summary>
    public class DocumentType : ConstantClass
    {

        /// <summary>
        /// Constant Automation for DocumentType
        /// </summary>
        public static readonly DocumentType Automation = new DocumentType("Automation");
        /// <summary>
        /// Constant Command for DocumentType
        /// </summary>
        public static readonly DocumentType Command = new DocumentType("Command");
        /// <summary>
        /// Constant Policy for DocumentType
        /// </summary>
        public static readonly DocumentType Policy = new DocumentType("Policy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentType FindValue(string value)
        {
            return FindValue<DocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionMode.
    /// </summary>
    public class ExecutionMode : ConstantClass
    {

        /// <summary>
        /// Constant Auto for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode Auto = new ExecutionMode("Auto");
        /// <summary>
        /// Constant Interactive for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode Interactive = new ExecutionMode("Interactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionMode FindValue(string value)
        {
            return FindValue<ExecutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Fault.
    /// </summary>
    public class Fault : ConstantClass
    {

        /// <summary>
        /// Constant Client for Fault
        /// </summary>
        public static readonly Fault Client = new Fault("Client");
        /// <summary>
        /// Constant Server for Fault
        /// </summary>
        public static readonly Fault Server = new Fault("Server");
        /// <summary>
        /// Constant Unknown for Fault
        /// </summary>
        public static readonly Fault Unknown = new Fault("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Fault(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Fault FindValue(string value)
        {
            return FindValue<Fault>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Fault(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceInformationFilterKey.
    /// </summary>
    public class InstanceInformationFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant ActivationIds for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey ActivationIds = new InstanceInformationFilterKey("ActivationIds");
        /// <summary>
        /// Constant AgentVersion for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey AgentVersion = new InstanceInformationFilterKey("AgentVersion");
        /// <summary>
        /// Constant AssociationStatus for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey AssociationStatus = new InstanceInformationFilterKey("AssociationStatus");
        /// <summary>
        /// Constant IamRole for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey IamRole = new InstanceInformationFilterKey("IamRole");
        /// <summary>
        /// Constant InstanceIds for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey InstanceIds = new InstanceInformationFilterKey("InstanceIds");
        /// <summary>
        /// Constant PingStatus for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey PingStatus = new InstanceInformationFilterKey("PingStatus");
        /// <summary>
        /// Constant PlatformTypes for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey PlatformTypes = new InstanceInformationFilterKey("PlatformTypes");
        /// <summary>
        /// Constant ResourceType for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey ResourceType = new InstanceInformationFilterKey("ResourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceInformationFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceInformationFilterKey FindValue(string value)
        {
            return FindValue<InstanceInformationFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceInformationFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstancePatchStateOperatorType.
    /// </summary>
    public class InstancePatchStateOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant Equal for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType Equal = new InstancePatchStateOperatorType("Equal");
        /// <summary>
        /// Constant GreaterThan for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType GreaterThan = new InstancePatchStateOperatorType("GreaterThan");
        /// <summary>
        /// Constant LessThan for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType LessThan = new InstancePatchStateOperatorType("LessThan");
        /// <summary>
        /// Constant NotEqual for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType NotEqual = new InstancePatchStateOperatorType("NotEqual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstancePatchStateOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstancePatchStateOperatorType FindValue(string value)
        {
            return FindValue<InstancePatchStateOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstancePatchStateOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryAttributeDataType.
    /// </summary>
    public class InventoryAttributeDataType : ConstantClass
    {

        /// <summary>
        /// Constant Number for InventoryAttributeDataType
        /// </summary>
        public static readonly InventoryAttributeDataType Number = new InventoryAttributeDataType("number");
        /// <summary>
        /// Constant String for InventoryAttributeDataType
        /// </summary>
        public static readonly InventoryAttributeDataType String = new InventoryAttributeDataType("string");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryAttributeDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryAttributeDataType FindValue(string value)
        {
            return FindValue<InventoryAttributeDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryAttributeDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryDeletionStatus.
    /// </summary>
    public class InventoryDeletionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for InventoryDeletionStatus
        /// </summary>
        public static readonly InventoryDeletionStatus Complete = new InventoryDeletionStatus("Complete");
        /// <summary>
        /// Constant InProgress for InventoryDeletionStatus
        /// </summary>
        public static readonly InventoryDeletionStatus InProgress = new InventoryDeletionStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryDeletionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryDeletionStatus FindValue(string value)
        {
            return FindValue<InventoryDeletionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryDeletionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryQueryOperatorType.
    /// </summary>
    public class InventoryQueryOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant BeginWith for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType BeginWith = new InventoryQueryOperatorType("BeginWith");
        /// <summary>
        /// Constant Equal for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType Equal = new InventoryQueryOperatorType("Equal");
        /// <summary>
        /// Constant GreaterThan for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType GreaterThan = new InventoryQueryOperatorType("GreaterThan");
        /// <summary>
        /// Constant LessThan for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType LessThan = new InventoryQueryOperatorType("LessThan");
        /// <summary>
        /// Constant NotEqual for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType NotEqual = new InventoryQueryOperatorType("NotEqual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryQueryOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryQueryOperatorType FindValue(string value)
        {
            return FindValue<InventoryQueryOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryQueryOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventorySchemaDeleteOption.
    /// </summary>
    public class InventorySchemaDeleteOption : ConstantClass
    {

        /// <summary>
        /// Constant DeleteSchema for InventorySchemaDeleteOption
        /// </summary>
        public static readonly InventorySchemaDeleteOption DeleteSchema = new InventorySchemaDeleteOption("DeleteSchema");
        /// <summary>
        /// Constant DisableSchema for InventorySchemaDeleteOption
        /// </summary>
        public static readonly InventorySchemaDeleteOption DisableSchema = new InventorySchemaDeleteOption("DisableSchema");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventorySchemaDeleteOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventorySchemaDeleteOption FindValue(string value)
        {
            return FindValue<InventorySchemaDeleteOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventorySchemaDeleteOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastResourceDataSyncStatus.
    /// </summary>
    public class LastResourceDataSyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for LastResourceDataSyncStatus
        /// </summary>
        public static readonly LastResourceDataSyncStatus Failed = new LastResourceDataSyncStatus("Failed");
        /// <summary>
        /// Constant InProgress for LastResourceDataSyncStatus
        /// </summary>
        public static readonly LastResourceDataSyncStatus InProgress = new LastResourceDataSyncStatus("InProgress");
        /// <summary>
        /// Constant Successful for LastResourceDataSyncStatus
        /// </summary>
        public static readonly LastResourceDataSyncStatus Successful = new LastResourceDataSyncStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastResourceDataSyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastResourceDataSyncStatus FindValue(string value)
        {
            return FindValue<LastResourceDataSyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastResourceDataSyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowExecutionStatus.
    /// </summary>
    public class MaintenanceWindowExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus CANCELLED = new MaintenanceWindowExecutionStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus CANCELLING = new MaintenanceWindowExecutionStatus("CANCELLING");
        /// <summary>
        /// Constant FAILED for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus FAILED = new MaintenanceWindowExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus IN_PROGRESS = new MaintenanceWindowExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus PENDING = new MaintenanceWindowExecutionStatus("PENDING");
        /// <summary>
        /// Constant SKIPPED_OVERLAPPING for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus SKIPPED_OVERLAPPING = new MaintenanceWindowExecutionStatus("SKIPPED_OVERLAPPING");
        /// <summary>
        /// Constant SUCCESS for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus SUCCESS = new MaintenanceWindowExecutionStatus("SUCCESS");
        /// <summary>
        /// Constant TIMED_OUT for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus TIMED_OUT = new MaintenanceWindowExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowExecutionStatus FindValue(string value)
        {
            return FindValue<MaintenanceWindowExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowResourceType.
    /// </summary>
    public class MaintenanceWindowResourceType : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE for MaintenanceWindowResourceType
        /// </summary>
        public static readonly MaintenanceWindowResourceType INSTANCE = new MaintenanceWindowResourceType("INSTANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowResourceType FindValue(string value)
        {
            return FindValue<MaintenanceWindowResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowTaskType.
    /// </summary>
    public class MaintenanceWindowTaskType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATION for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType AUTOMATION = new MaintenanceWindowTaskType("AUTOMATION");
        /// <summary>
        /// Constant LAMBDA for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType LAMBDA = new MaintenanceWindowTaskType("LAMBDA");
        /// <summary>
        /// Constant RUN_COMMAND for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType RUN_COMMAND = new MaintenanceWindowTaskType("RUN_COMMAND");
        /// <summary>
        /// Constant STEP_FUNCTIONS for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType STEP_FUNCTIONS = new MaintenanceWindowTaskType("STEP_FUNCTIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowTaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowTaskType FindValue(string value)
        {
            return FindValue<MaintenanceWindowTaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowTaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationEvent.
    /// </summary>
    public class NotificationEvent : ConstantClass
    {

        /// <summary>
        /// Constant All for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent All = new NotificationEvent("All");
        /// <summary>
        /// Constant Cancelled for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent Cancelled = new NotificationEvent("Cancelled");
        /// <summary>
        /// Constant Failed for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent Failed = new NotificationEvent("Failed");
        /// <summary>
        /// Constant InProgress for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent InProgress = new NotificationEvent("InProgress");
        /// <summary>
        /// Constant Success for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent Success = new NotificationEvent("Success");
        /// <summary>
        /// Constant TimedOut for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent TimedOut = new NotificationEvent("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationEvent FindValue(string value)
        {
            return FindValue<NotificationEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationType.
    /// </summary>
    public class NotificationType : ConstantClass
    {

        /// <summary>
        /// Constant Command for NotificationType
        /// </summary>
        public static readonly NotificationType Command = new NotificationType("Command");
        /// <summary>
        /// Constant Invocation for NotificationType
        /// </summary>
        public static readonly NotificationType Invocation = new NotificationType("Invocation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatingSystem.
    /// </summary>
    public class OperatingSystem : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX = new OperatingSystem("AMAZON_LINUX");
        /// <summary>
        /// Constant CENTOS for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem CENTOS = new OperatingSystem("CENTOS");
        /// <summary>
        /// Constant REDHAT_ENTERPRISE_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem REDHAT_ENTERPRISE_LINUX = new OperatingSystem("REDHAT_ENTERPRISE_LINUX");
        /// <summary>
        /// Constant SUSE for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem SUSE = new OperatingSystem("SUSE");
        /// <summary>
        /// Constant UBUNTU for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem UBUNTU = new OperatingSystem("UBUNTU");
        /// <summary>
        /// Constant WINDOWS for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem WINDOWS = new OperatingSystem("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatingSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatingSystem FindValue(string value)
        {
            return FindValue<OperatingSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatingSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParametersFilterKey.
    /// </summary>
    public class ParametersFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant KeyId for ParametersFilterKey
        /// </summary>
        public static readonly ParametersFilterKey KeyId = new ParametersFilterKey("KeyId");
        /// <summary>
        /// Constant Name for ParametersFilterKey
        /// </summary>
        public static readonly ParametersFilterKey Name = new ParametersFilterKey("Name");
        /// <summary>
        /// Constant Type for ParametersFilterKey
        /// </summary>
        public static readonly ParametersFilterKey Type = new ParametersFilterKey("Type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParametersFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParametersFilterKey FindValue(string value)
        {
            return FindValue<ParametersFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParametersFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterType.
    /// </summary>
    public class ParameterType : ConstantClass
    {

        /// <summary>
        /// Constant SecureString for ParameterType
        /// </summary>
        public static readonly ParameterType SecureString = new ParameterType("SecureString");
        /// <summary>
        /// Constant String for ParameterType
        /// </summary>
        public static readonly ParameterType String = new ParameterType("String");
        /// <summary>
        /// Constant StringList for ParameterType
        /// </summary>
        public static readonly ParameterType StringList = new ParameterType("StringList");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterType FindValue(string value)
        {
            return FindValue<ParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchComplianceDataState.
    /// </summary>
    public class PatchComplianceDataState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState FAILED = new PatchComplianceDataState("FAILED");
        /// <summary>
        /// Constant INSTALLED for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState INSTALLED = new PatchComplianceDataState("INSTALLED");
        /// <summary>
        /// Constant INSTALLED_OTHER for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState INSTALLED_OTHER = new PatchComplianceDataState("INSTALLED_OTHER");
        /// <summary>
        /// Constant MISSING for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState MISSING = new PatchComplianceDataState("MISSING");
        /// <summary>
        /// Constant NOT_APPLICABLE for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState NOT_APPLICABLE = new PatchComplianceDataState("NOT_APPLICABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchComplianceDataState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchComplianceDataState FindValue(string value)
        {
            return FindValue<PatchComplianceDataState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchComplianceDataState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchComplianceLevel.
    /// </summary>
    public class PatchComplianceLevel : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel CRITICAL = new PatchComplianceLevel("CRITICAL");
        /// <summary>
        /// Constant HIGH for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel HIGH = new PatchComplianceLevel("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel INFORMATIONAL = new PatchComplianceLevel("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel LOW = new PatchComplianceLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel MEDIUM = new PatchComplianceLevel("MEDIUM");
        /// <summary>
        /// Constant UNSPECIFIED for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel UNSPECIFIED = new PatchComplianceLevel("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchComplianceLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchComplianceLevel FindValue(string value)
        {
            return FindValue<PatchComplianceLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchComplianceLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchDeploymentStatus.
    /// </summary>
    public class PatchDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus APPROVED = new PatchDeploymentStatus("APPROVED");
        /// <summary>
        /// Constant EXPLICIT_APPROVED for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus EXPLICIT_APPROVED = new PatchDeploymentStatus("EXPLICIT_APPROVED");
        /// <summary>
        /// Constant EXPLICIT_REJECTED for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus EXPLICIT_REJECTED = new PatchDeploymentStatus("EXPLICIT_REJECTED");
        /// <summary>
        /// Constant PENDING_APPROVAL for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus PENDING_APPROVAL = new PatchDeploymentStatus("PENDING_APPROVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchDeploymentStatus FindValue(string value)
        {
            return FindValue<PatchDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchFilterKey.
    /// </summary>
    public class PatchFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant CLASSIFICATION for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey CLASSIFICATION = new PatchFilterKey("CLASSIFICATION");
        /// <summary>
        /// Constant MSRC_SEVERITY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey MSRC_SEVERITY = new PatchFilterKey("MSRC_SEVERITY");
        /// <summary>
        /// Constant PATCH_ID for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PATCH_ID = new PatchFilterKey("PATCH_ID");
        /// <summary>
        /// Constant PRIORITY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PRIORITY = new PatchFilterKey("PRIORITY");
        /// <summary>
        /// Constant PRODUCT for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PRODUCT = new PatchFilterKey("PRODUCT");
        /// <summary>
        /// Constant SECTION for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey SECTION = new PatchFilterKey("SECTION");
        /// <summary>
        /// Constant SEVERITY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey SEVERITY = new PatchFilterKey("SEVERITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchFilterKey FindValue(string value)
        {
            return FindValue<PatchFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchOperationType.
    /// </summary>
    public class PatchOperationType : ConstantClass
    {

        /// <summary>
        /// Constant Install for PatchOperationType
        /// </summary>
        public static readonly PatchOperationType Install = new PatchOperationType("Install");
        /// <summary>
        /// Constant Scan for PatchOperationType
        /// </summary>
        public static readonly PatchOperationType Scan = new PatchOperationType("Scan");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchOperationType FindValue(string value)
        {
            return FindValue<PatchOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchOperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PingStatus.
    /// </summary>
    public class PingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ConnectionLost for PingStatus
        /// </summary>
        public static readonly PingStatus ConnectionLost = new PingStatus("ConnectionLost");
        /// <summary>
        /// Constant Inactive for PingStatus
        /// </summary>
        public static readonly PingStatus Inactive = new PingStatus("Inactive");
        /// <summary>
        /// Constant Online for PingStatus
        /// </summary>
        public static readonly PingStatus Online = new PingStatus("Online");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PingStatus FindValue(string value)
        {
            return FindValue<PingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformType.
    /// </summary>
    public class PlatformType : ConstantClass
    {

        /// <summary>
        /// Constant Linux for PlatformType
        /// </summary>
        public static readonly PlatformType Linux = new PlatformType("Linux");
        /// <summary>
        /// Constant Windows for PlatformType
        /// </summary>
        public static readonly PlatformType Windows = new PlatformType("Windows");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformType FindValue(string value)
        {
            return FindValue<PlatformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceDataSyncS3Format.
    /// </summary>
    public class ResourceDataSyncS3Format : ConstantClass
    {

        /// <summary>
        /// Constant JsonSerDe for ResourceDataSyncS3Format
        /// </summary>
        public static readonly ResourceDataSyncS3Format JsonSerDe = new ResourceDataSyncS3Format("JsonSerDe");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceDataSyncS3Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceDataSyncS3Format FindValue(string value)
        {
            return FindValue<ResourceDataSyncS3Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceDataSyncS3Format(string value)
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
        /// Constant Document for ResourceType
        /// </summary>
        public static readonly ResourceType Document = new ResourceType("Document");
        /// <summary>
        /// Constant EC2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType EC2Instance = new ResourceType("EC2Instance");
        /// <summary>
        /// Constant ManagedInstance for ResourceType
        /// </summary>
        public static readonly ResourceType ManagedInstance = new ResourceType("ManagedInstance");

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
    /// Constants used for properties of type ResourceTypeForTagging.
    /// </summary>
    public class ResourceTypeForTagging : ConstantClass
    {

        /// <summary>
        /// Constant Document for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging Document = new ResourceTypeForTagging("Document");
        /// <summary>
        /// Constant MaintenanceWindow for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging MaintenanceWindow = new ResourceTypeForTagging("MaintenanceWindow");
        /// <summary>
        /// Constant ManagedInstance for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging ManagedInstance = new ResourceTypeForTagging("ManagedInstance");
        /// <summary>
        /// Constant Parameter for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging Parameter = new ResourceTypeForTagging("Parameter");
        /// <summary>
        /// Constant PatchBaseline for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging PatchBaseline = new ResourceTypeForTagging("PatchBaseline");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceTypeForTagging(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceTypeForTagging FindValue(string value)
        {
            return FindValue<ResourceTypeForTagging>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceTypeForTagging(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalType.
    /// </summary>
    public class SignalType : ConstantClass
    {

        /// <summary>
        /// Constant Approve for SignalType
        /// </summary>
        public static readonly SignalType Approve = new SignalType("Approve");
        /// <summary>
        /// Constant Reject for SignalType
        /// </summary>
        public static readonly SignalType Reject = new SignalType("Reject");
        /// <summary>
        /// Constant Resume for SignalType
        /// </summary>
        public static readonly SignalType Resume = new SignalType("Resume");
        /// <summary>
        /// Constant StartStep for SignalType
        /// </summary>
        public static readonly SignalType StartStep = new SignalType("StartStep");
        /// <summary>
        /// Constant StopStep for SignalType
        /// </summary>
        public static readonly SignalType StopStep = new SignalType("StopStep");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalType FindValue(string value)
        {
            return FindValue<SignalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepExecutionFilterKey.
    /// </summary>
    public class StepExecutionFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant Action for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey Action = new StepExecutionFilterKey("Action");
        /// <summary>
        /// Constant StartTimeAfter for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StartTimeAfter = new StepExecutionFilterKey("StartTimeAfter");
        /// <summary>
        /// Constant StartTimeBefore for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StartTimeBefore = new StepExecutionFilterKey("StartTimeBefore");
        /// <summary>
        /// Constant StepExecutionId for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StepExecutionId = new StepExecutionFilterKey("StepExecutionId");
        /// <summary>
        /// Constant StepExecutionStatus for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StepExecutionStatus = new StepExecutionFilterKey("StepExecutionStatus");
        /// <summary>
        /// Constant StepName for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StepName = new StepExecutionFilterKey("StepName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepExecutionFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepExecutionFilterKey FindValue(string value)
        {
            return FindValue<StepExecutionFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepExecutionFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StopType.
    /// </summary>
    public class StopType : ConstantClass
    {

        /// <summary>
        /// Constant Cancel for StopType
        /// </summary>
        public static readonly StopType Cancel = new StopType("Cancel");
        /// <summary>
        /// Constant Complete for StopType
        /// </summary>
        public static readonly StopType Complete = new StopType("Complete");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopType FindValue(string value)
        {
            return FindValue<StopType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopType(string value)
        {
            return FindValue(value);
        }
    }

}