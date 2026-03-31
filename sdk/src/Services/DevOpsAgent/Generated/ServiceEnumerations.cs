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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DevOpsAgent
{

    /// <summary>
    /// Constants used for properties of type AuthFlow.
    /// </summary>
    public class AuthFlow : ConstantClass
    {

        /// <summary>
        /// Constant Iam for AuthFlow
        /// </summary>
        public static readonly AuthFlow Iam = new AuthFlow("iam");
        /// <summary>
        /// Constant Idc for AuthFlow
        /// </summary>
        public static readonly AuthFlow Idc = new AuthFlow("idc");
        /// <summary>
        /// Constant Idp for AuthFlow
        /// </summary>
        public static readonly AuthFlow Idp = new AuthFlow("idp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthFlow(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthFlow FindValue(string value)
        {
            return FindValue<AuthFlow>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthFlow(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventChannelType.
    /// </summary>
    public class EventChannelType : ConstantClass
    {

        /// <summary>
        /// Constant Webhook for EventChannelType
        /// </summary>
        public static readonly EventChannelType Webhook = new EventChannelType("webhook");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventChannelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventChannelType FindValue(string value)
        {
            return FindValue<EventChannelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventChannelType(string value)
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
        /// Constant CANCELED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus CANCELED = new ExecutionStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus FAILED = new ExecutionStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus RUNNING = new ExecutionStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus STOPPED = new ExecutionStatus("STOPPED");
        /// <summary>
        /// Constant TIMED_OUT for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus TIMED_OUT = new ExecutionStatus("TIMED_OUT");

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
    /// Constants used for properties of type GithubRepoOwnerType.
    /// </summary>
    public class GithubRepoOwnerType : ConstantClass
    {

        /// <summary>
        /// Constant Organization for GithubRepoOwnerType
        /// </summary>
        public static readonly GithubRepoOwnerType Organization = new GithubRepoOwnerType("organization");
        /// <summary>
        /// Constant User for GithubRepoOwnerType
        /// </summary>
        public static readonly GithubRepoOwnerType User = new GithubRepoOwnerType("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GithubRepoOwnerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GithubRepoOwnerType FindValue(string value)
        {
            return FindValue<GithubRepoOwnerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GithubRepoOwnerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GitLabTokenType.
    /// </summary>
    public class GitLabTokenType : ConstantClass
    {

        /// <summary>
        /// Constant Group for GitLabTokenType
        /// </summary>
        public static readonly GitLabTokenType Group = new GitLabTokenType("group");
        /// <summary>
        /// Constant Personal for GitLabTokenType
        /// </summary>
        public static readonly GitLabTokenType Personal = new GitLabTokenType("personal");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GitLabTokenType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GitLabTokenType FindValue(string value)
        {
            return FindValue<GitLabTokenType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GitLabTokenType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GoalStatus.
    /// </summary>
    public class GoalStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GoalStatus
        /// </summary>
        public static readonly GoalStatus ACTIVE = new GoalStatus("ACTIVE");
        /// <summary>
        /// Constant COMPLETE for GoalStatus
        /// </summary>
        public static readonly GoalStatus COMPLETE = new GoalStatus("COMPLETE");
        /// <summary>
        /// Constant PAUSED for GoalStatus
        /// </summary>
        public static readonly GoalStatus PAUSED = new GoalStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GoalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GoalStatus FindValue(string value)
        {
            return FindValue<GoalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GoalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GoalType.
    /// </summary>
    public class GoalType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_DEFINED for GoalType
        /// </summary>
        public static readonly GoalType CUSTOMER_DEFINED = new GoalType("CUSTOMER_DEFINED");
        /// <summary>
        /// Constant ONCALL_REPORT for GoalType
        /// </summary>
        public static readonly GoalType ONCALL_REPORT = new GoalType("ONCALL_REPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GoalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GoalType FindValue(string value)
        {
            return FindValue<GoalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GoalType(string value)
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
        /// Constant DUAL_STACK for IpAddressType
        /// </summary>
        public static readonly IpAddressType DUAL_STACK = new IpAddressType("DUAL_STACK");
        /// <summary>
        /// Constant IPV4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4 = new IpAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV6 = new IpAddressType("IPV6");

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
    /// Constants used for properties of type MCPServerAuthorizationMethod.
    /// </summary>
    public class MCPServerAuthorizationMethod : ConstantClass
    {

        /// <summary>
        /// Constant ApiKey for MCPServerAuthorizationMethod
        /// </summary>
        public static readonly MCPServerAuthorizationMethod ApiKey = new MCPServerAuthorizationMethod("api-key");
        /// <summary>
        /// Constant BearerToken for MCPServerAuthorizationMethod
        /// </summary>
        public static readonly MCPServerAuthorizationMethod BearerToken = new MCPServerAuthorizationMethod("bearer-token");
        /// <summary>
        /// Constant Oauth3lo for MCPServerAuthorizationMethod
        /// </summary>
        public static readonly MCPServerAuthorizationMethod Oauth3lo = new MCPServerAuthorizationMethod("oauth-3lo");
        /// <summary>
        /// Constant OauthClientCredentials for MCPServerAuthorizationMethod
        /// </summary>
        public static readonly MCPServerAuthorizationMethod OauthClientCredentials = new MCPServerAuthorizationMethod("oauth-client-credentials");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MCPServerAuthorizationMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MCPServerAuthorizationMethod FindValue(string value)
        {
            return FindValue<MCPServerAuthorizationMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MCPServerAuthorizationMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorAccountType.
    /// </summary>
    public class MonitorAccountType : ConstantClass
    {

        /// <summary>
        /// Constant Monitor for MonitorAccountType
        /// </summary>
        public static readonly MonitorAccountType Monitor = new MonitorAccountType("monitor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorAccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorAccountType FindValue(string value)
        {
            return FindValue<MonitorAccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorAccountType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NewRelicRegion.
    /// </summary>
    public class NewRelicRegion : ConstantClass
    {

        /// <summary>
        /// Constant EU for NewRelicRegion
        /// </summary>
        public static readonly NewRelicRegion EU = new NewRelicRegion("EU");
        /// <summary>
        /// Constant US for NewRelicRegion
        /// </summary>
        public static readonly NewRelicRegion US = new NewRelicRegion("US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NewRelicRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NewRelicRegion FindValue(string value)
        {
            return FindValue<NewRelicRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NewRelicRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderType.
    /// </summary>
    public class OrderType : ConstantClass
    {

        /// <summary>
        /// Constant ASC for OrderType
        /// </summary>
        public static readonly OrderType ASC = new OrderType("ASC");
        /// <summary>
        /// Constant DESC for OrderType
        /// </summary>
        public static readonly OrderType DESC = new OrderType("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderType FindValue(string value)
        {
            return FindValue<OrderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PostRegisterServiceSupportedService.
    /// </summary>
    public class PostRegisterServiceSupportedService : ConstantClass
    {

        /// <summary>
        /// Constant Azureidentity for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Azureidentity = new PostRegisterServiceSupportedService("azureidentity");
        /// <summary>
        /// Constant Dynatrace for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Dynatrace = new PostRegisterServiceSupportedService("dynatrace");
        /// <summary>
        /// Constant EventChannel for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService EventChannel = new PostRegisterServiceSupportedService("eventChannel");
        /// <summary>
        /// Constant Gitlab for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Gitlab = new PostRegisterServiceSupportedService("gitlab");
        /// <summary>
        /// Constant Mcpserver for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Mcpserver = new PostRegisterServiceSupportedService("mcpserver");
        /// <summary>
        /// Constant Mcpserverdatadog for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Mcpserverdatadog = new PostRegisterServiceSupportedService("mcpserverdatadog");
        /// <summary>
        /// Constant Mcpservergrafana for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Mcpservergrafana = new PostRegisterServiceSupportedService("mcpservergrafana");
        /// <summary>
        /// Constant Mcpservernewrelic for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Mcpservernewrelic = new PostRegisterServiceSupportedService("mcpservernewrelic");
        /// <summary>
        /// Constant Mcpserversplunk for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Mcpserversplunk = new PostRegisterServiceSupportedService("mcpserversplunk");
        /// <summary>
        /// Constant Pagerduty for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Pagerduty = new PostRegisterServiceSupportedService("pagerduty");
        /// <summary>
        /// Constant Servicenow for PostRegisterServiceSupportedService
        /// </summary>
        public static readonly PostRegisterServiceSupportedService Servicenow = new PostRegisterServiceSupportedService("servicenow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PostRegisterServiceSupportedService(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostRegisterServiceSupportedService FindValue(string value)
        {
            return FindValue<PostRegisterServiceSupportedService>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostRegisterServiceSupportedService(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Priority.
    /// </summary>
    public class Priority : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for Priority
        /// </summary>
        public static readonly Priority CRITICAL = new Priority("CRITICAL");
        /// <summary>
        /// Constant HIGH for Priority
        /// </summary>
        public static readonly Priority HIGH = new Priority("HIGH");
        /// <summary>
        /// Constant LOW for Priority
        /// </summary>
        public static readonly Priority LOW = new Priority("LOW");
        /// <summary>
        /// Constant MEDIUM for Priority
        /// </summary>
        public static readonly Priority MEDIUM = new Priority("MEDIUM");
        /// <summary>
        /// Constant MINIMAL for Priority
        /// </summary>
        public static readonly Priority MINIMAL = new Priority("MINIMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Priority(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Priority FindValue(string value)
        {
            return FindValue<Priority>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Priority(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivateConnectionStatus.
    /// </summary>
    public class PrivateConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus ACTIVE = new PrivateConnectionStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus CREATE_FAILED = new PrivateConnectionStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus CREATE_IN_PROGRESS = new PrivateConnectionStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus DELETE_FAILED = new PrivateConnectionStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus DELETE_IN_PROGRESS = new PrivateConnectionStatus("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivateConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivateConnectionStatus FindValue(string value)
        {
            return FindValue<PrivateConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivateConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivateConnectionType.
    /// </summary>
    public class PrivateConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant SELF_MANAGED for PrivateConnectionType
        /// </summary>
        public static readonly PrivateConnectionType SELF_MANAGED = new PrivateConnectionType("SELF_MANAGED");
        /// <summary>
        /// Constant SERVICE_MANAGED for PrivateConnectionType
        /// </summary>
        public static readonly PrivateConnectionType SERVICE_MANAGED = new PrivateConnectionType("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivateConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivateConnectionType FindValue(string value)
        {
            return FindValue<PrivateConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivateConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationPriority.
    /// </summary>
    public class RecommendationPriority : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for RecommendationPriority
        /// </summary>
        public static readonly RecommendationPriority HIGH = new RecommendationPriority("HIGH");
        /// <summary>
        /// Constant LOW for RecommendationPriority
        /// </summary>
        public static readonly RecommendationPriority LOW = new RecommendationPriority("LOW");
        /// <summary>
        /// Constant MEDIUM for RecommendationPriority
        /// </summary>
        public static readonly RecommendationPriority MEDIUM = new RecommendationPriority("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationPriority(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationPriority FindValue(string value)
        {
            return FindValue<RecommendationPriority>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationPriority(string value)
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
        /// Constant ACCEPTED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus ACCEPTED = new RecommendationStatus("ACCEPTED");
        /// <summary>
        /// Constant CLOSED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus CLOSED = new RecommendationStatus("CLOSED");
        /// <summary>
        /// Constant COMPLETED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus COMPLETED = new RecommendationStatus("COMPLETED");
        /// <summary>
        /// Constant PROPOSED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus PROPOSED = new RecommendationStatus("PROPOSED");
        /// <summary>
        /// Constant REJECTED for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus REJECTED = new RecommendationStatus("REJECTED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for RecommendationStatus
        /// </summary>
        public static readonly RecommendationStatus UPDATE_IN_PROGRESS = new RecommendationStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationStatus(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type SchedulerState.
    /// </summary>
    public class SchedulerState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SchedulerState
        /// </summary>
        public static readonly SchedulerState DISABLED = new SchedulerState("DISABLED");
        /// <summary>
        /// Constant ENABLED for SchedulerState
        /// </summary>
        public static readonly SchedulerState ENABLED = new SchedulerState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchedulerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchedulerState FindValue(string value)
        {
            return FindValue<SchedulerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchedulerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Service.
    /// </summary>
    public class Service : ConstantClass
    {

        /// <summary>
        /// Constant Azure for Service
        /// </summary>
        public static readonly Service Azure = new Service("azure");
        /// <summary>
        /// Constant Azuredevops for Service
        /// </summary>
        public static readonly Service Azuredevops = new Service("azuredevops");
        /// <summary>
        /// Constant Azureidentity for Service
        /// </summary>
        public static readonly Service Azureidentity = new Service("azureidentity");
        /// <summary>
        /// Constant Dynatrace for Service
        /// </summary>
        public static readonly Service Dynatrace = new Service("dynatrace");
        /// <summary>
        /// Constant EventChannel for Service
        /// </summary>
        public static readonly Service EventChannel = new Service("eventChannel");
        /// <summary>
        /// Constant Github for Service
        /// </summary>
        public static readonly Service Github = new Service("github");
        /// <summary>
        /// Constant Gitlab for Service
        /// </summary>
        public static readonly Service Gitlab = new Service("gitlab");
        /// <summary>
        /// Constant Mcpserver for Service
        /// </summary>
        public static readonly Service Mcpserver = new Service("mcpserver");
        /// <summary>
        /// Constant Mcpserverdatadog for Service
        /// </summary>
        public static readonly Service Mcpserverdatadog = new Service("mcpserverdatadog");
        /// <summary>
        /// Constant Mcpservergrafana for Service
        /// </summary>
        public static readonly Service Mcpservergrafana = new Service("mcpservergrafana");
        /// <summary>
        /// Constant Mcpservernewrelic for Service
        /// </summary>
        public static readonly Service Mcpservernewrelic = new Service("mcpservernewrelic");
        /// <summary>
        /// Constant Mcpserversplunk for Service
        /// </summary>
        public static readonly Service Mcpserversplunk = new Service("mcpserversplunk");
        /// <summary>
        /// Constant Pagerduty for Service
        /// </summary>
        public static readonly Service Pagerduty = new Service("pagerduty");
        /// <summary>
        /// Constant Servicenow for Service
        /// </summary>
        public static readonly Service Servicenow = new Service("servicenow");
        /// <summary>
        /// Constant Slack for Service
        /// </summary>
        public static readonly Service Slack = new Service("slack");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Service(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Service FindValue(string value)
        {
            return FindValue<Service>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Service(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceAccountType.
    /// </summary>
    public class SourceAccountType : ConstantClass
    {

        /// <summary>
        /// Constant Source for SourceAccountType
        /// </summary>
        public static readonly SourceAccountType Source = new SourceAccountType("source");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceAccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceAccountType FindValue(string value)
        {
            return FindValue<SourceAccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceAccountType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskSortField.
    /// </summary>
    public class TaskSortField : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_AT for TaskSortField
        /// </summary>
        public static readonly TaskSortField CREATED_AT = new TaskSortField("CREATED_AT");
        /// <summary>
        /// Constant PRIORITY for TaskSortField
        /// </summary>
        public static readonly TaskSortField PRIORITY = new TaskSortField("PRIORITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskSortField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskSortField FindValue(string value)
        {
            return FindValue<TaskSortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskSortField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskSortOrder.
    /// </summary>
    public class TaskSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for TaskSortOrder
        /// </summary>
        public static readonly TaskSortOrder ASC = new TaskSortOrder("ASC");
        /// <summary>
        /// Constant DESC for TaskSortOrder
        /// </summary>
        public static readonly TaskSortOrder DESC = new TaskSortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskSortOrder FindValue(string value)
        {
            return FindValue<TaskSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskSortOrder(string value)
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
        /// Constant CANCELED for TaskStatus
        /// </summary>
        public static readonly TaskStatus CANCELED = new TaskStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for TaskStatus
        /// </summary>
        public static readonly TaskStatus COMPLETED = new TaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for TaskStatus
        /// </summary>
        public static readonly TaskStatus FAILED = new TaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TaskStatus
        /// </summary>
        public static readonly TaskStatus IN_PROGRESS = new TaskStatus("IN_PROGRESS");
        /// <summary>
        /// Constant LINKED for TaskStatus
        /// </summary>
        public static readonly TaskStatus LINKED = new TaskStatus("LINKED");
        /// <summary>
        /// Constant PENDING_CUSTOMER_APPROVAL for TaskStatus
        /// </summary>
        public static readonly TaskStatus PENDING_CUSTOMER_APPROVAL = new TaskStatus("PENDING_CUSTOMER_APPROVAL");
        /// <summary>
        /// Constant PENDING_START for TaskStatus
        /// </summary>
        public static readonly TaskStatus PENDING_START = new TaskStatus("PENDING_START");
        /// <summary>
        /// Constant PENDING_TRIAGE for TaskStatus
        /// </summary>
        public static readonly TaskStatus PENDING_TRIAGE = new TaskStatus("PENDING_TRIAGE");
        /// <summary>
        /// Constant TIMED_OUT for TaskStatus
        /// </summary>
        public static readonly TaskStatus TIMED_OUT = new TaskStatus("TIMED_OUT");

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
    /// Constants used for properties of type TaskType.
    /// </summary>
    public class TaskType : ConstantClass
    {

        /// <summary>
        /// Constant EVALUATION for TaskType
        /// </summary>
        public static readonly TaskType EVALUATION = new TaskType("EVALUATION");
        /// <summary>
        /// Constant INVESTIGATION for TaskType
        /// </summary>
        public static readonly TaskType INVESTIGATION = new TaskType("INVESTIGATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskType FindValue(string value)
        {
            return FindValue<TaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserType.
    /// </summary>
    public class UserType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for UserType
        /// </summary>
        public static readonly UserType IAM = new UserType("IAM");
        /// <summary>
        /// Constant IDC for UserType
        /// </summary>
        public static readonly UserType IDC = new UserType("IDC");
        /// <summary>
        /// Constant IDP for UserType
        /// </summary>
        public static readonly UserType IDP = new UserType("IDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserType FindValue(string value)
        {
            return FindValue<UserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationStatus.
    /// </summary>
    public class ValidationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Invalid for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus Invalid = new ValidationStatus("invalid");
        /// <summary>
        /// Constant PendingConfirmation for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus PendingConfirmation = new ValidationStatus("pending-confirmation");
        /// <summary>
        /// Constant Valid for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus Valid = new ValidationStatus("valid");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationStatus FindValue(string value)
        {
            return FindValue<ValidationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebhookType.
    /// </summary>
    public class WebhookType : ConstantClass
    {

        /// <summary>
        /// Constant Apikey for WebhookType
        /// </summary>
        public static readonly WebhookType Apikey = new WebhookType("apikey");
        /// <summary>
        /// Constant Gitlab for WebhookType
        /// </summary>
        public static readonly WebhookType Gitlab = new WebhookType("gitlab");
        /// <summary>
        /// Constant Hmac for WebhookType
        /// </summary>
        public static readonly WebhookType Hmac = new WebhookType("hmac");
        /// <summary>
        /// Constant Pagerduty for WebhookType
        /// </summary>
        public static readonly WebhookType Pagerduty = new WebhookType("pagerduty");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebhookType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebhookType FindValue(string value)
        {
            return FindValue<WebhookType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebhookType(string value)
        {
            return FindValue(value);
        }
    }

}