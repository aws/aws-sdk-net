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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.QApps
{

    /// <summary>
    /// Constants used for properties of type AppRequiredCapability.
    /// </summary>
    public class AppRequiredCapability : ConstantClass
    {

        /// <summary>
        /// Constant CreatorMode for AppRequiredCapability
        /// </summary>
        public static readonly AppRequiredCapability CreatorMode = new AppRequiredCapability("CreatorMode");
        /// <summary>
        /// Constant FileUpload for AppRequiredCapability
        /// </summary>
        public static readonly AppRequiredCapability FileUpload = new AppRequiredCapability("FileUpload");
        /// <summary>
        /// Constant PluginMode for AppRequiredCapability
        /// </summary>
        public static readonly AppRequiredCapability PluginMode = new AppRequiredCapability("PluginMode");
        /// <summary>
        /// Constant RetrievalMode for AppRequiredCapability
        /// </summary>
        public static readonly AppRequiredCapability RetrievalMode = new AppRequiredCapability("RetrievalMode");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppRequiredCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppRequiredCapability FindValue(string value)
        {
            return FindValue<AppRequiredCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppRequiredCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppStatus.
    /// </summary>
    public class AppStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for AppStatus
        /// </summary>
        public static readonly AppStatus DELETED = new AppStatus("DELETED");
        /// <summary>
        /// Constant DRAFT for AppStatus
        /// </summary>
        public static readonly AppStatus DRAFT = new AppStatus("DRAFT");
        /// <summary>
        /// Constant PUBLISHED for AppStatus
        /// </summary>
        public static readonly AppStatus PUBLISHED = new AppStatus("PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppStatus FindValue(string value)
        {
            return FindValue<AppStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CardOutputSource.
    /// </summary>
    public class CardOutputSource : ConstantClass
    {

        /// <summary>
        /// Constant ApprovedSources for CardOutputSource
        /// </summary>
        public static readonly CardOutputSource ApprovedSources = new CardOutputSource("approved-sources");
        /// <summary>
        /// Constant Llm for CardOutputSource
        /// </summary>
        public static readonly CardOutputSource Llm = new CardOutputSource("llm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CardOutputSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CardOutputSource FindValue(string value)
        {
            return FindValue<CardOutputSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CardOutputSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CardType.
    /// </summary>
    public class CardType : ConstantClass
    {

        /// <summary>
        /// Constant FileUpload for CardType
        /// </summary>
        public static readonly CardType FileUpload = new CardType("file-upload");
        /// <summary>
        /// Constant FormInput for CardType
        /// </summary>
        public static readonly CardType FormInput = new CardType("form-input");
        /// <summary>
        /// Constant QPlugin for CardType
        /// </summary>
        public static readonly CardType QPlugin = new CardType("q-plugin");
        /// <summary>
        /// Constant QQuery for CardType
        /// </summary>
        public static readonly CardType QQuery = new CardType("q-query");
        /// <summary>
        /// Constant TextInput for CardType
        /// </summary>
        public static readonly CardType TextInput = new CardType("text-input");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CardType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CardType FindValue(string value)
        {
            return FindValue<CardType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CardType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentScope.
    /// </summary>
    public class DocumentScope : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for DocumentScope
        /// </summary>
        public static readonly DocumentScope APPLICATION = new DocumentScope("APPLICATION");
        /// <summary>
        /// Constant SESSION for DocumentScope
        /// </summary>
        public static readonly DocumentScope SESSION = new DocumentScope("SESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentScope FindValue(string value)
        {
            return FindValue<DocumentScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus COMPLETED = new ExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant ERROR for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus ERROR = new ExecutionStatus("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus IN_PROGRESS = new ExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant WAITING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus WAITING = new ExecutionStatus("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputCardComputeMode.
    /// </summary>
    public class InputCardComputeMode : ConstantClass
    {

        /// <summary>
        /// Constant Append for InputCardComputeMode
        /// </summary>
        public static readonly InputCardComputeMode Append = new InputCardComputeMode("append");
        /// <summary>
        /// Constant Replace for InputCardComputeMode
        /// </summary>
        public static readonly InputCardComputeMode Replace = new InputCardComputeMode("replace");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputCardComputeMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputCardComputeMode FindValue(string value)
        {
            return FindValue<InputCardComputeMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputCardComputeMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LibraryItemStatus.
    /// </summary>
    public class LibraryItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for LibraryItemStatus
        /// </summary>
        public static readonly LibraryItemStatus DISABLED = new LibraryItemStatus("DISABLED");
        /// <summary>
        /// Constant PUBLISHED for LibraryItemStatus
        /// </summary>
        public static readonly LibraryItemStatus PUBLISHED = new LibraryItemStatus("PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LibraryItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LibraryItemStatus FindValue(string value)
        {
            return FindValue<LibraryItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LibraryItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionInputActionEnum.
    /// </summary>
    public class PermissionInputActionEnum : ConstantClass
    {

        /// <summary>
        /// Constant Read for PermissionInputActionEnum
        /// </summary>
        public static readonly PermissionInputActionEnum Read = new PermissionInputActionEnum("read");
        /// <summary>
        /// Constant Write for PermissionInputActionEnum
        /// </summary>
        public static readonly PermissionInputActionEnum Write = new PermissionInputActionEnum("write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionInputActionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionInputActionEnum FindValue(string value)
        {
            return FindValue<PermissionInputActionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionInputActionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionOutputActionEnum.
    /// </summary>
    public class PermissionOutputActionEnum : ConstantClass
    {

        /// <summary>
        /// Constant Read for PermissionOutputActionEnum
        /// </summary>
        public static readonly PermissionOutputActionEnum Read = new PermissionOutputActionEnum("read");
        /// <summary>
        /// Constant Write for PermissionOutputActionEnum
        /// </summary>
        public static readonly PermissionOutputActionEnum Write = new PermissionOutputActionEnum("write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionOutputActionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionOutputActionEnum FindValue(string value)
        {
            return FindValue<PermissionOutputActionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionOutputActionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PluginType.
    /// </summary>
    public class PluginType : ConstantClass
    {

        /// <summary>
        /// Constant ASANA for PluginType
        /// </summary>
        public static readonly PluginType ASANA = new PluginType("ASANA");
        /// <summary>
        /// Constant ATLASSIAN_CONFLUENCE for PluginType
        /// </summary>
        public static readonly PluginType ATLASSIAN_CONFLUENCE = new PluginType("ATLASSIAN_CONFLUENCE");
        /// <summary>
        /// Constant CUSTOM for PluginType
        /// </summary>
        public static readonly PluginType CUSTOM = new PluginType("CUSTOM");
        /// <summary>
        /// Constant GOOGLE_CALENDAR for PluginType
        /// </summary>
        public static readonly PluginType GOOGLE_CALENDAR = new PluginType("GOOGLE_CALENDAR");
        /// <summary>
        /// Constant JIRA for PluginType
        /// </summary>
        public static readonly PluginType JIRA = new PluginType("JIRA");
        /// <summary>
        /// Constant JIRA_CLOUD for PluginType
        /// </summary>
        public static readonly PluginType JIRA_CLOUD = new PluginType("JIRA_CLOUD");
        /// <summary>
        /// Constant MICROSOFT_EXCHANGE for PluginType
        /// </summary>
        public static readonly PluginType MICROSOFT_EXCHANGE = new PluginType("MICROSOFT_EXCHANGE");
        /// <summary>
        /// Constant MICROSOFT_TEAMS for PluginType
        /// </summary>
        public static readonly PluginType MICROSOFT_TEAMS = new PluginType("MICROSOFT_TEAMS");
        /// <summary>
        /// Constant PAGERDUTY_ADVANCE for PluginType
        /// </summary>
        public static readonly PluginType PAGERDUTY_ADVANCE = new PluginType("PAGERDUTY_ADVANCE");
        /// <summary>
        /// Constant SALESFORCE for PluginType
        /// </summary>
        public static readonly PluginType SALESFORCE = new PluginType("SALESFORCE");
        /// <summary>
        /// Constant SALESFORCE_CRM for PluginType
        /// </summary>
        public static readonly PluginType SALESFORCE_CRM = new PluginType("SALESFORCE_CRM");
        /// <summary>
        /// Constant SERVICE_NOW for PluginType
        /// </summary>
        public static readonly PluginType SERVICE_NOW = new PluginType("SERVICE_NOW");
        /// <summary>
        /// Constant SERVICENOW_NOW_PLATFORM for PluginType
        /// </summary>
        public static readonly PluginType SERVICENOW_NOW_PLATFORM = new PluginType("SERVICENOW_NOW_PLATFORM");
        /// <summary>
        /// Constant SMARTSHEET for PluginType
        /// </summary>
        public static readonly PluginType SMARTSHEET = new PluginType("SMARTSHEET");
        /// <summary>
        /// Constant ZENDESK for PluginType
        /// </summary>
        public static readonly PluginType ZENDESK = new PluginType("ZENDESK");
        /// <summary>
        /// Constant ZENDESK_SUITE for PluginType
        /// </summary>
        public static readonly PluginType ZENDESK_SUITE = new PluginType("ZENDESK_SUITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PluginType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PluginType FindValue(string value)
        {
            return FindValue<PluginType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PluginType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalOutputUserTypeEnum.
    /// </summary>
    public class PrincipalOutputUserTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Owner for PrincipalOutputUserTypeEnum
        /// </summary>
        public static readonly PrincipalOutputUserTypeEnum Owner = new PrincipalOutputUserTypeEnum("owner");
        /// <summary>
        /// Constant User for PrincipalOutputUserTypeEnum
        /// </summary>
        public static readonly PrincipalOutputUserTypeEnum User = new PrincipalOutputUserTypeEnum("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalOutputUserTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalOutputUserTypeEnum FindValue(string value)
        {
            return FindValue<PrincipalOutputUserTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalOutputUserTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Sender.
    /// </summary>
    public class Sender : ConstantClass
    {

        /// <summary>
        /// Constant SYSTEM for Sender
        /// </summary>
        public static readonly Sender SYSTEM = new Sender("SYSTEM");
        /// <summary>
        /// Constant USER for Sender
        /// </summary>
        public static readonly Sender USER = new Sender("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Sender(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Sender FindValue(string value)
        {
            return FindValue<Sender>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Sender(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubmissionMutationKind.
    /// </summary>
    public class SubmissionMutationKind : ConstantClass
    {

        /// <summary>
        /// Constant Add for SubmissionMutationKind
        /// </summary>
        public static readonly SubmissionMutationKind Add = new SubmissionMutationKind("add");
        /// <summary>
        /// Constant Delete for SubmissionMutationKind
        /// </summary>
        public static readonly SubmissionMutationKind Delete = new SubmissionMutationKind("delete");
        /// <summary>
        /// Constant Edit for SubmissionMutationKind
        /// </summary>
        public static readonly SubmissionMutationKind Edit = new SubmissionMutationKind("edit");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubmissionMutationKind(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubmissionMutationKind FindValue(string value)
        {
            return FindValue<SubmissionMutationKind>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubmissionMutationKind(string value)
        {
            return FindValue(value);
        }
    }

}