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
        /// Constant InstanceId for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey InstanceId = new AssociationFilterKey("InstanceId");
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
        /// Constant ManagedInstance for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging ManagedInstance = new ResourceTypeForTagging("ManagedInstance");

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

}