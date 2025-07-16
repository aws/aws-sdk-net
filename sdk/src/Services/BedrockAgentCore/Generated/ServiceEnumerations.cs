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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockAgentCore
{

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationStreamStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserSessionStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeInterpreterSessionStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentBlockType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type Oauth2FlowType.
    /// </summary>
    public class Oauth2FlowType : ConstantClass
    {

        /// <summary>
        /// Constant M2M for Oauth2FlowType
        /// </summary>
        public static readonly Oauth2FlowType M2M = new Oauth2FlowType("M2M");
        /// <summary>
        /// Constant USER_FEDERATION for Oauth2FlowType
        /// </summary>
        public static readonly Oauth2FlowType USER_FEDERATION = new Oauth2FlowType("USER_FEDERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Oauth2FlowType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProgrammingLanguage(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceContentType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Role(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToolName(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

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