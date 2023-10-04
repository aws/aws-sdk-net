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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DataZone
{

    /// <summary>
    /// Constants used for properties of type AcceptRuleBehavior.
    /// </summary>
    public class AcceptRuleBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AcceptRuleBehavior
        /// </summary>
        public static readonly AcceptRuleBehavior ALL = new AcceptRuleBehavior("ALL");
        /// <summary>
        /// Constant NONE for AcceptRuleBehavior
        /// </summary>
        public static readonly AcceptRuleBehavior NONE = new AcceptRuleBehavior("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptRuleBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptRuleBehavior FindValue(string value)
        {
            return FindValue<AcceptRuleBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptRuleBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AuthType
        /// </summary>
        public static readonly AuthType DISABLED = new AuthType("DISABLED");
        /// <summary>
        /// Constant IAM_IDC for AuthType
        /// </summary>
        public static readonly AuthType IAM_IDC = new AuthType("IAM_IDC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISH for ChangeAction
        /// </summary>
        public static readonly ChangeAction PUBLISH = new ChangeAction("PUBLISH");
        /// <summary>
        /// Constant UNPUBLISH for ChangeAction
        /// </summary>
        public static readonly ChangeAction UNPUBLISH = new ChangeAction("UNPUBLISH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurableActionTypeAuthorization.
    /// </summary>
    public class ConfigurableActionTypeAuthorization : ConstantClass
    {

        /// <summary>
        /// Constant HTTPS for ConfigurableActionTypeAuthorization
        /// </summary>
        public static readonly ConfigurableActionTypeAuthorization HTTPS = new ConfigurableActionTypeAuthorization("HTTPS");
        /// <summary>
        /// Constant IAM for ConfigurableActionTypeAuthorization
        /// </summary>
        public static readonly ConfigurableActionTypeAuthorization IAM = new ConfigurableActionTypeAuthorization("IAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurableActionTypeAuthorization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurableActionTypeAuthorization FindValue(string value)
        {
            return FindValue<ConfigurableActionTypeAuthorization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurableActionTypeAuthorization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataAssetActivityStatus.
    /// </summary>
    public class DataAssetActivityStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus FAILED = new DataAssetActivityStatus("FAILED");
        /// <summary>
        /// Constant PUBLISHING_FAILED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus PUBLISHING_FAILED = new DataAssetActivityStatus("PUBLISHING_FAILED");
        /// <summary>
        /// Constant SKIPPED_ALREADY_IMPORTED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SKIPPED_ALREADY_IMPORTED = new DataAssetActivityStatus("SKIPPED_ALREADY_IMPORTED");
        /// <summary>
        /// Constant SKIPPED_ARCHIVED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SKIPPED_ARCHIVED = new DataAssetActivityStatus("SKIPPED_ARCHIVED");
        /// <summary>
        /// Constant SKIPPED_NO_ACCESS for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SKIPPED_NO_ACCESS = new DataAssetActivityStatus("SKIPPED_NO_ACCESS");
        /// <summary>
        /// Constant SUCCEEDED_CREATED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SUCCEEDED_CREATED = new DataAssetActivityStatus("SUCCEEDED_CREATED");
        /// <summary>
        /// Constant SUCCEEDED_UPDATED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SUCCEEDED_UPDATED = new DataAssetActivityStatus("SUCCEEDED_UPDATED");
        /// <summary>
        /// Constant UNCHANGED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus UNCHANGED = new DataAssetActivityStatus("UNCHANGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAssetActivityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAssetActivityStatus FindValue(string value)
        {
            return FindValue<DataAssetActivityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAssetActivityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceErrorType.
    /// </summary>
    public class DataSourceErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType ACCESS_DENIED_EXCEPTION = new DataSourceErrorType("ACCESS_DENIED_EXCEPTION");
        /// <summary>
        /// Constant CONFLICT_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType CONFLICT_EXCEPTION = new DataSourceErrorType("CONFLICT_EXCEPTION");
        /// <summary>
        /// Constant INTERNAL_SERVER_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType INTERNAL_SERVER_EXCEPTION = new DataSourceErrorType("INTERNAL_SERVER_EXCEPTION");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType RESOURCE_NOT_FOUND_EXCEPTION = new DataSourceErrorType("RESOURCE_NOT_FOUND_EXCEPTION");
        /// <summary>
        /// Constant SERVICE_QUOTA_EXCEEDED_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType SERVICE_QUOTA_EXCEEDED_EXCEPTION = new DataSourceErrorType("SERVICE_QUOTA_EXCEEDED_EXCEPTION");
        /// <summary>
        /// Constant THROTTLING_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType THROTTLING_EXCEPTION = new DataSourceErrorType("THROTTLING_EXCEPTION");
        /// <summary>
        /// Constant VALIDATION_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType VALIDATION_EXCEPTION = new DataSourceErrorType("VALIDATION_EXCEPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceErrorType FindValue(string value)
        {
            return FindValue<DataSourceErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceRunStatus.
    /// </summary>
    public class DataSourceRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus FAILED = new DataSourceRunStatus("FAILED");
        /// <summary>
        /// Constant PARTIALLY_SUCCEEDED for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus PARTIALLY_SUCCEEDED = new DataSourceRunStatus("PARTIALLY_SUCCEEDED");
        /// <summary>
        /// Constant REQUESTED for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus REQUESTED = new DataSourceRunStatus("REQUESTED");
        /// <summary>
        /// Constant RUNNING for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus RUNNING = new DataSourceRunStatus("RUNNING");
        /// <summary>
        /// Constant SUCCESS for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus SUCCESS = new DataSourceRunStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceRunStatus FindValue(string value)
        {
            return FindValue<DataSourceRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceRunType.
    /// </summary>
    public class DataSourceRunType : ConstantClass
    {

        /// <summary>
        /// Constant PRIORITIZED for DataSourceRunType
        /// </summary>
        public static readonly DataSourceRunType PRIORITIZED = new DataSourceRunType("PRIORITIZED");
        /// <summary>
        /// Constant SCHEDULED for DataSourceRunType
        /// </summary>
        public static readonly DataSourceRunType SCHEDULED = new DataSourceRunType("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceRunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceRunType FindValue(string value)
        {
            return FindValue<DataSourceRunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceRunType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceStatus.
    /// </summary>
    public class DataSourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus CREATING = new DataSourceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus DELETING = new DataSourceStatus("DELETING");
        /// <summary>
        /// Constant FAILED_CREATION for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED_CREATION = new DataSourceStatus("FAILED_CREATION");
        /// <summary>
        /// Constant FAILED_DELETION for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED_DELETION = new DataSourceStatus("FAILED_DELETION");
        /// <summary>
        /// Constant FAILED_UPDATE for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED_UPDATE = new DataSourceStatus("FAILED_UPDATE");
        /// <summary>
        /// Constant READY for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus READY = new DataSourceStatus("READY");
        /// <summary>
        /// Constant RUNNING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus RUNNING = new DataSourceStatus("RUNNING");
        /// <summary>
        /// Constant UPDATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus UPDATING = new DataSourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceStatus FindValue(string value)
        {
            return FindValue<DataSourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus FAILED = new DeploymentStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus IN_PROGRESS = new DeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING_DEPLOYMENT for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus PENDING_DEPLOYMENT = new DeploymentStatus("PENDING_DEPLOYMENT");
        /// <summary>
        /// Constant SUCCESSFUL for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus SUCCESSFUL = new DeploymentStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentType.
    /// </summary>
    public class DeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for DeploymentType
        /// </summary>
        public static readonly DeploymentType CREATE = new DeploymentType("CREATE");
        /// <summary>
        /// Constant DELETE for DeploymentType
        /// </summary>
        public static readonly DeploymentType DELETE = new DeploymentType("DELETE");
        /// <summary>
        /// Constant UPDATE for DeploymentType
        /// </summary>
        public static readonly DeploymentType UPDATE = new DeploymentType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentType FindValue(string value)
        {
            return FindValue<DeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatus.
    /// </summary>
    public class DomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DomainStatus
        /// </summary>
        public static readonly DomainStatus AVAILABLE = new DomainStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for DomainStatus
        /// </summary>
        public static readonly DomainStatus CREATING = new DomainStatus("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for DomainStatus
        /// </summary>
        public static readonly DomainStatus CREATION_FAILED = new DomainStatus("CREATION_FAILED");
        /// <summary>
        /// Constant DELETED for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETED = new DomainStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETING = new DomainStatus("DELETING");
        /// <summary>
        /// Constant DELETION_FAILED for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETION_FAILED = new DomainStatus("DELETION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatus FindValue(string value)
        {
            return FindValue<DomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnableSetting.
    /// </summary>
    public class EnableSetting : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EnableSetting
        /// </summary>
        public static readonly EnableSetting DISABLED = new EnableSetting("DISABLED");
        /// <summary>
        /// Constant ENABLED for EnableSetting
        /// </summary>
        public static readonly EnableSetting ENABLED = new EnableSetting("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnableSetting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnableSetting FindValue(string value)
        {
            return FindValue<EnableSetting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnableSetting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for EntityType
        /// </summary>
        public static readonly EntityType ASSET = new EntityType("ASSET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus ACTIVE = new EnvironmentStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATE_FAILED = new EnvironmentStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATING = new EnvironmentStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETE_FAILED = new EnvironmentStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETED = new EnvironmentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETING = new EnvironmentStatus("DELETING");
        /// <summary>
        /// Constant DISABLED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DISABLED = new EnvironmentStatus("DISABLED");
        /// <summary>
        /// Constant EXPIRED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus EXPIRED = new EnvironmentStatus("EXPIRED");
        /// <summary>
        /// Constant INACCESSIBLE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus INACCESSIBLE = new EnvironmentStatus("INACCESSIBLE");
        /// <summary>
        /// Constant SUSPENDED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus SUSPENDED = new EnvironmentStatus("SUSPENDED");
        /// <summary>
        /// Constant UPDATE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATE_FAILED = new EnvironmentStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATING = new EnvironmentStatus("UPDATING");
        /// <summary>
        /// Constant VALIDATION_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus VALIDATION_FAILED = new EnvironmentStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterExpressionType.
    /// </summary>
    public class FilterExpressionType : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for FilterExpressionType
        /// </summary>
        public static readonly FilterExpressionType EXCLUDE = new FilterExpressionType("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for FilterExpressionType
        /// </summary>
        public static readonly FilterExpressionType INCLUDE = new FilterExpressionType("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterExpressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterExpressionType FindValue(string value)
        {
            return FindValue<FilterExpressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterExpressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormTypeStatus.
    /// </summary>
    public class FormTypeStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FormTypeStatus
        /// </summary>
        public static readonly FormTypeStatus DISABLED = new FormTypeStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for FormTypeStatus
        /// </summary>
        public static readonly FormTypeStatus ENABLED = new FormTypeStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormTypeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormTypeStatus FindValue(string value)
        {
            return FindValue<FormTypeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormTypeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlossaryStatus.
    /// </summary>
    public class GlossaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GlossaryStatus
        /// </summary>
        public static readonly GlossaryStatus DISABLED = new GlossaryStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for GlossaryStatus
        /// </summary>
        public static readonly GlossaryStatus ENABLED = new GlossaryStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlossaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlossaryStatus FindValue(string value)
        {
            return FindValue<GlossaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlossaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlossaryTermStatus.
    /// </summary>
    public class GlossaryTermStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GlossaryTermStatus
        /// </summary>
        public static readonly GlossaryTermStatus DISABLED = new GlossaryTermStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for GlossaryTermStatus
        /// </summary>
        public static readonly GlossaryTermStatus ENABLED = new GlossaryTermStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlossaryTermStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlossaryTermStatus FindValue(string value)
        {
            return FindValue<GlossaryTermStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlossaryTermStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupProfileStatus.
    /// </summary>
    public class GroupProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGNED for GroupProfileStatus
        /// </summary>
        public static readonly GroupProfileStatus ASSIGNED = new GroupProfileStatus("ASSIGNED");
        /// <summary>
        /// Constant NOT_ASSIGNED for GroupProfileStatus
        /// </summary>
        public static readonly GroupProfileStatus NOT_ASSIGNED = new GroupProfileStatus("NOT_ASSIGNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupProfileStatus FindValue(string value)
        {
            return FindValue<GroupProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupSearchType.
    /// </summary>
    public class GroupSearchType : ConstantClass
    {

        /// <summary>
        /// Constant DATAZONE_SSO_GROUP for GroupSearchType
        /// </summary>
        public static readonly GroupSearchType DATAZONE_SSO_GROUP = new GroupSearchType("DATAZONE_SSO_GROUP");
        /// <summary>
        /// Constant SSO_GROUP for GroupSearchType
        /// </summary>
        public static readonly GroupSearchType SSO_GROUP = new GroupSearchType("SSO_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupSearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupSearchType FindValue(string value)
        {
            return FindValue<GroupSearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupSearchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventorySearchScope.
    /// </summary>
    public class InventorySearchScope : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for InventorySearchScope
        /// </summary>
        public static readonly InventorySearchScope ASSET = new InventorySearchScope("ASSET");
        /// <summary>
        /// Constant GLOSSARY for InventorySearchScope
        /// </summary>
        public static readonly InventorySearchScope GLOSSARY = new InventorySearchScope("GLOSSARY");
        /// <summary>
        /// Constant GLOSSARY_TERM for InventorySearchScope
        /// </summary>
        public static readonly InventorySearchScope GLOSSARY_TERM = new InventorySearchScope("GLOSSARY_TERM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventorySearchScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventorySearchScope FindValue(string value)
        {
            return FindValue<InventorySearchScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventorySearchScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListingStatus.
    /// </summary>
    public class ListingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ListingStatus
        /// </summary>
        public static readonly ListingStatus ACTIVE = new ListingStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ListingStatus
        /// </summary>
        public static readonly ListingStatus CREATING = new ListingStatus("CREATING");
        /// <summary>
        /// Constant INACTIVE for ListingStatus
        /// </summary>
        public static readonly ListingStatus INACTIVE = new ListingStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListingStatus FindValue(string value)
        {
            return FindValue<ListingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationResourceType.
    /// </summary>
    public class NotificationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant PROJECT for NotificationResourceType
        /// </summary>
        public static readonly NotificationResourceType PROJECT = new NotificationResourceType("PROJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationResourceType FindValue(string value)
        {
            return FindValue<NotificationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationRole.
    /// </summary>
    public class NotificationRole : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_OWNER for NotificationRole
        /// </summary>
        public static readonly NotificationRole DOMAIN_OWNER = new NotificationRole("DOMAIN_OWNER");
        /// <summary>
        /// Constant PROJECT_CONTRIBUTOR for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_CONTRIBUTOR = new NotificationRole("PROJECT_CONTRIBUTOR");
        /// <summary>
        /// Constant PROJECT_OWNER for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_OWNER = new NotificationRole("PROJECT_OWNER");
        /// <summary>
        /// Constant PROJECT_SUBSCRIBER for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_SUBSCRIBER = new NotificationRole("PROJECT_SUBSCRIBER");
        /// <summary>
        /// Constant PROJECT_VIEWER for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_VIEWER = new NotificationRole("PROJECT_VIEWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationRole FindValue(string value)
        {
            return FindValue<NotificationRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationRole(string value)
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
        /// Constant EVENT for NotificationType
        /// </summary>
        public static readonly NotificationType EVENT = new NotificationType("EVENT");
        /// <summary>
        /// Constant TASK for NotificationType
        /// </summary>
        public static readonly NotificationType TASK = new NotificationType("TASK");

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
    /// Constants used for properties of type RejectRuleBehavior.
    /// </summary>
    public class RejectRuleBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RejectRuleBehavior
        /// </summary>
        public static readonly RejectRuleBehavior ALL = new RejectRuleBehavior("ALL");
        /// <summary>
        /// Constant NONE for RejectRuleBehavior
        /// </summary>
        public static readonly RejectRuleBehavior NONE = new RejectRuleBehavior("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RejectRuleBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RejectRuleBehavior FindValue(string value)
        {
            return FindValue<RejectRuleBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RejectRuleBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchOutputAdditionalAttribute.
    /// </summary>
    public class SearchOutputAdditionalAttribute : ConstantClass
    {

        /// <summary>
        /// Constant FORMS for SearchOutputAdditionalAttribute
        /// </summary>
        public static readonly SearchOutputAdditionalAttribute FORMS = new SearchOutputAdditionalAttribute("FORMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchOutputAdditionalAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchOutputAdditionalAttribute FindValue(string value)
        {
            return FindValue<SearchOutputAdditionalAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchOutputAdditionalAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortFieldProject.
    /// </summary>
    public class SortFieldProject : ConstantClass
    {

        /// <summary>
        /// Constant NAME for SortFieldProject
        /// </summary>
        public static readonly SortFieldProject NAME = new SortFieldProject("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortFieldProject(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortFieldProject FindValue(string value)
        {
            return FindValue<SortFieldProject>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortFieldProject(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortKey.
    /// </summary>
    public class SortKey : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_AT for SortKey
        /// </summary>
        public static readonly SortKey CREATED_AT = new SortKey("CREATED_AT");
        /// <summary>
        /// Constant UPDATED_AT for SortKey
        /// </summary>
        public static readonly SortKey UPDATED_AT = new SortKey("UPDATED_AT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortKey FindValue(string value)
        {
            return FindValue<SortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionGrantOverallStatus.
    /// </summary>
    public class SubscriptionGrantOverallStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus COMPLETED = new SubscriptionGrantOverallStatus("COMPLETED");
        /// <summary>
        /// Constant GRANT_AND_REVOKE_FAILED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus GRANT_AND_REVOKE_FAILED = new SubscriptionGrantOverallStatus("GRANT_AND_REVOKE_FAILED");
        /// <summary>
        /// Constant GRANT_FAILED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus GRANT_FAILED = new SubscriptionGrantOverallStatus("GRANT_FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus IN_PROGRESS = new SubscriptionGrantOverallStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INACCESSIBLE for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus INACCESSIBLE = new SubscriptionGrantOverallStatus("INACCESSIBLE");
        /// <summary>
        /// Constant PENDING for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus PENDING = new SubscriptionGrantOverallStatus("PENDING");
        /// <summary>
        /// Constant REVOKE_FAILED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus REVOKE_FAILED = new SubscriptionGrantOverallStatus("REVOKE_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionGrantOverallStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionGrantOverallStatus FindValue(string value)
        {
            return FindValue<SubscriptionGrantOverallStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionGrantOverallStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionGrantStatus.
    /// </summary>
    public class SubscriptionGrantStatus : ConstantClass
    {

        /// <summary>
        /// Constant GRANT_FAILED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANT_FAILED = new SubscriptionGrantStatus("GRANT_FAILED");
        /// <summary>
        /// Constant GRANT_IN_PROGRESS for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANT_IN_PROGRESS = new SubscriptionGrantStatus("GRANT_IN_PROGRESS");
        /// <summary>
        /// Constant GRANT_PENDING for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANT_PENDING = new SubscriptionGrantStatus("GRANT_PENDING");
        /// <summary>
        /// Constant GRANTED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANTED = new SubscriptionGrantStatus("GRANTED");
        /// <summary>
        /// Constant REVOKE_FAILED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKE_FAILED = new SubscriptionGrantStatus("REVOKE_FAILED");
        /// <summary>
        /// Constant REVOKE_IN_PROGRESS for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKE_IN_PROGRESS = new SubscriptionGrantStatus("REVOKE_IN_PROGRESS");
        /// <summary>
        /// Constant REVOKE_PENDING for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKE_PENDING = new SubscriptionGrantStatus("REVOKE_PENDING");
        /// <summary>
        /// Constant REVOKED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKED = new SubscriptionGrantStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionGrantStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionGrantStatus FindValue(string value)
        {
            return FindValue<SubscriptionGrantStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionGrantStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionRequestStatus.
    /// </summary>
    public class SubscriptionRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for SubscriptionRequestStatus
        /// </summary>
        public static readonly SubscriptionRequestStatus ACCEPTED = new SubscriptionRequestStatus("ACCEPTED");
        /// <summary>
        /// Constant PENDING for SubscriptionRequestStatus
        /// </summary>
        public static readonly SubscriptionRequestStatus PENDING = new SubscriptionRequestStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for SubscriptionRequestStatus
        /// </summary>
        public static readonly SubscriptionRequestStatus REJECTED = new SubscriptionRequestStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionRequestStatus FindValue(string value)
        {
            return FindValue<SubscriptionRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionRequestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionStatus.
    /// </summary>
    public class SubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus APPROVED = new SubscriptionStatus("APPROVED");
        /// <summary>
        /// Constant CANCELLED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus CANCELLED = new SubscriptionStatus("CANCELLED");
        /// <summary>
        /// Constant REVOKED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus REVOKED = new SubscriptionStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionStatus FindValue(string value)
        {
            return FindValue<SubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionStatus(string value)
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
        /// Constant ACTIVE for TaskStatus
        /// </summary>
        public static readonly TaskStatus ACTIVE = new TaskStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for TaskStatus
        /// </summary>
        public static readonly TaskStatus INACTIVE = new TaskStatus("INACTIVE");

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
    /// Constants used for properties of type Timezone.
    /// </summary>
    public class Timezone : ConstantClass
    {

        /// <summary>
        /// Constant AFRICA_JOHANNESBURG for Timezone
        /// </summary>
        public static readonly Timezone AFRICA_JOHANNESBURG = new Timezone("AFRICA_JOHANNESBURG");
        /// <summary>
        /// Constant AMERICA_MONTREAL for Timezone
        /// </summary>
        public static readonly Timezone AMERICA_MONTREAL = new Timezone("AMERICA_MONTREAL");
        /// <summary>
        /// Constant AMERICA_SAO_PAULO for Timezone
        /// </summary>
        public static readonly Timezone AMERICA_SAO_PAULO = new Timezone("AMERICA_SAO_PAULO");
        /// <summary>
        /// Constant ASIA_BAHRAIN for Timezone
        /// </summary>
        public static readonly Timezone ASIA_BAHRAIN = new Timezone("ASIA_BAHRAIN");
        /// <summary>
        /// Constant ASIA_BANGKOK for Timezone
        /// </summary>
        public static readonly Timezone ASIA_BANGKOK = new Timezone("ASIA_BANGKOK");
        /// <summary>
        /// Constant ASIA_CALCUTTA for Timezone
        /// </summary>
        public static readonly Timezone ASIA_CALCUTTA = new Timezone("ASIA_CALCUTTA");
        /// <summary>
        /// Constant ASIA_DUBAI for Timezone
        /// </summary>
        public static readonly Timezone ASIA_DUBAI = new Timezone("ASIA_DUBAI");
        /// <summary>
        /// Constant ASIA_HONG_KONG for Timezone
        /// </summary>
        public static readonly Timezone ASIA_HONG_KONG = new Timezone("ASIA_HONG_KONG");
        /// <summary>
        /// Constant ASIA_JAKARTA for Timezone
        /// </summary>
        public static readonly Timezone ASIA_JAKARTA = new Timezone("ASIA_JAKARTA");
        /// <summary>
        /// Constant ASIA_KUALA_LUMPUR for Timezone
        /// </summary>
        public static readonly Timezone ASIA_KUALA_LUMPUR = new Timezone("ASIA_KUALA_LUMPUR");
        /// <summary>
        /// Constant ASIA_SEOUL for Timezone
        /// </summary>
        public static readonly Timezone ASIA_SEOUL = new Timezone("ASIA_SEOUL");
        /// <summary>
        /// Constant ASIA_SHANGHAI for Timezone
        /// </summary>
        public static readonly Timezone ASIA_SHANGHAI = new Timezone("ASIA_SHANGHAI");
        /// <summary>
        /// Constant ASIA_SINGAPORE for Timezone
        /// </summary>
        public static readonly Timezone ASIA_SINGAPORE = new Timezone("ASIA_SINGAPORE");
        /// <summary>
        /// Constant ASIA_TAIPEI for Timezone
        /// </summary>
        public static readonly Timezone ASIA_TAIPEI = new Timezone("ASIA_TAIPEI");
        /// <summary>
        /// Constant ASIA_TOKYO for Timezone
        /// </summary>
        public static readonly Timezone ASIA_TOKYO = new Timezone("ASIA_TOKYO");
        /// <summary>
        /// Constant AUSTRALIA_MELBOURNE for Timezone
        /// </summary>
        public static readonly Timezone AUSTRALIA_MELBOURNE = new Timezone("AUSTRALIA_MELBOURNE");
        /// <summary>
        /// Constant AUSTRALIA_SYDNEY for Timezone
        /// </summary>
        public static readonly Timezone AUSTRALIA_SYDNEY = new Timezone("AUSTRALIA_SYDNEY");
        /// <summary>
        /// Constant CANADA_CENTRAL for Timezone
        /// </summary>
        public static readonly Timezone CANADA_CENTRAL = new Timezone("CANADA_CENTRAL");
        /// <summary>
        /// Constant CET for Timezone
        /// </summary>
        public static readonly Timezone CET = new Timezone("CET");
        /// <summary>
        /// Constant CST6CDT for Timezone
        /// </summary>
        public static readonly Timezone CST6CDT = new Timezone("CST6CDT");
        /// <summary>
        /// Constant ETC_GMT for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT = new Timezone("ETC_GMT");
        /// <summary>
        /// Constant ETC_GMT_ADD_0 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_0 = new Timezone("ETC_GMT_ADD_0");
        /// <summary>
        /// Constant ETC_GMT_ADD_1 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_1 = new Timezone("ETC_GMT_ADD_1");
        /// <summary>
        /// Constant ETC_GMT_ADD_10 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_10 = new Timezone("ETC_GMT_ADD_10");
        /// <summary>
        /// Constant ETC_GMT_ADD_11 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_11 = new Timezone("ETC_GMT_ADD_11");
        /// <summary>
        /// Constant ETC_GMT_ADD_12 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_12 = new Timezone("ETC_GMT_ADD_12");
        /// <summary>
        /// Constant ETC_GMT_ADD_2 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_2 = new Timezone("ETC_GMT_ADD_2");
        /// <summary>
        /// Constant ETC_GMT_ADD_3 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_3 = new Timezone("ETC_GMT_ADD_3");
        /// <summary>
        /// Constant ETC_GMT_ADD_4 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_4 = new Timezone("ETC_GMT_ADD_4");
        /// <summary>
        /// Constant ETC_GMT_ADD_5 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_5 = new Timezone("ETC_GMT_ADD_5");
        /// <summary>
        /// Constant ETC_GMT_ADD_6 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_6 = new Timezone("ETC_GMT_ADD_6");
        /// <summary>
        /// Constant ETC_GMT_ADD_7 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_7 = new Timezone("ETC_GMT_ADD_7");
        /// <summary>
        /// Constant ETC_GMT_ADD_8 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_8 = new Timezone("ETC_GMT_ADD_8");
        /// <summary>
        /// Constant ETC_GMT_ADD_9 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_9 = new Timezone("ETC_GMT_ADD_9");
        /// <summary>
        /// Constant ETC_GMT_NEG_0 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_0 = new Timezone("ETC_GMT_NEG_0");
        /// <summary>
        /// Constant ETC_GMT_NEG_1 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_1 = new Timezone("ETC_GMT_NEG_1");
        /// <summary>
        /// Constant ETC_GMT_NEG_10 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_10 = new Timezone("ETC_GMT_NEG_10");
        /// <summary>
        /// Constant ETC_GMT_NEG_11 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_11 = new Timezone("ETC_GMT_NEG_11");
        /// <summary>
        /// Constant ETC_GMT_NEG_12 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_12 = new Timezone("ETC_GMT_NEG_12");
        /// <summary>
        /// Constant ETC_GMT_NEG_13 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_13 = new Timezone("ETC_GMT_NEG_13");
        /// <summary>
        /// Constant ETC_GMT_NEG_14 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_14 = new Timezone("ETC_GMT_NEG_14");
        /// <summary>
        /// Constant ETC_GMT_NEG_2 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_2 = new Timezone("ETC_GMT_NEG_2");
        /// <summary>
        /// Constant ETC_GMT_NEG_3 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_3 = new Timezone("ETC_GMT_NEG_3");
        /// <summary>
        /// Constant ETC_GMT_NEG_4 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_4 = new Timezone("ETC_GMT_NEG_4");
        /// <summary>
        /// Constant ETC_GMT_NEG_5 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_5 = new Timezone("ETC_GMT_NEG_5");
        /// <summary>
        /// Constant ETC_GMT_NEG_6 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_6 = new Timezone("ETC_GMT_NEG_6");
        /// <summary>
        /// Constant ETC_GMT_NEG_7 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_7 = new Timezone("ETC_GMT_NEG_7");
        /// <summary>
        /// Constant ETC_GMT_NEG_8 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_8 = new Timezone("ETC_GMT_NEG_8");
        /// <summary>
        /// Constant ETC_GMT_NEG_9 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_9 = new Timezone("ETC_GMT_NEG_9");
        /// <summary>
        /// Constant ETC_GMT0 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT0 = new Timezone("ETC_GMT0");
        /// <summary>
        /// Constant EUROPE_DUBLIN for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_DUBLIN = new Timezone("EUROPE_DUBLIN");
        /// <summary>
        /// Constant EUROPE_LONDON for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_LONDON = new Timezone("EUROPE_LONDON");
        /// <summary>
        /// Constant EUROPE_PARIS for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_PARIS = new Timezone("EUROPE_PARIS");
        /// <summary>
        /// Constant EUROPE_STOCKHOLM for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_STOCKHOLM = new Timezone("EUROPE_STOCKHOLM");
        /// <summary>
        /// Constant EUROPE_ZURICH for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_ZURICH = new Timezone("EUROPE_ZURICH");
        /// <summary>
        /// Constant ISRAEL for Timezone
        /// </summary>
        public static readonly Timezone ISRAEL = new Timezone("ISRAEL");
        /// <summary>
        /// Constant MEXICO_GENERAL for Timezone
        /// </summary>
        public static readonly Timezone MEXICO_GENERAL = new Timezone("MEXICO_GENERAL");
        /// <summary>
        /// Constant MST7MDT for Timezone
        /// </summary>
        public static readonly Timezone MST7MDT = new Timezone("MST7MDT");
        /// <summary>
        /// Constant PACIFIC_AUCKLAND for Timezone
        /// </summary>
        public static readonly Timezone PACIFIC_AUCKLAND = new Timezone("PACIFIC_AUCKLAND");
        /// <summary>
        /// Constant US_CENTRAL for Timezone
        /// </summary>
        public static readonly Timezone US_CENTRAL = new Timezone("US_CENTRAL");
        /// <summary>
        /// Constant US_EASTERN for Timezone
        /// </summary>
        public static readonly Timezone US_EASTERN = new Timezone("US_EASTERN");
        /// <summary>
        /// Constant US_MOUNTAIN for Timezone
        /// </summary>
        public static readonly Timezone US_MOUNTAIN = new Timezone("US_MOUNTAIN");
        /// <summary>
        /// Constant US_PACIFIC for Timezone
        /// </summary>
        public static readonly Timezone US_PACIFIC = new Timezone("US_PACIFIC");
        /// <summary>
        /// Constant UTC for Timezone
        /// </summary>
        public static readonly Timezone UTC = new Timezone("UTC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Timezone(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Timezone FindValue(string value)
        {
            return FindValue<Timezone>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Timezone(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypesSearchScope.
    /// </summary>
    public class TypesSearchScope : ConstantClass
    {

        /// <summary>
        /// Constant ASSET_TYPE for TypesSearchScope
        /// </summary>
        public static readonly TypesSearchScope ASSET_TYPE = new TypesSearchScope("ASSET_TYPE");
        /// <summary>
        /// Constant FORM_TYPE for TypesSearchScope
        /// </summary>
        public static readonly TypesSearchScope FORM_TYPE = new TypesSearchScope("FORM_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypesSearchScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypesSearchScope FindValue(string value)
        {
            return FindValue<TypesSearchScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypesSearchScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserAssignment.
    /// </summary>
    public class UserAssignment : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for UserAssignment
        /// </summary>
        public static readonly UserAssignment AUTOMATIC = new UserAssignment("AUTOMATIC");
        /// <summary>
        /// Constant MANUAL for UserAssignment
        /// </summary>
        public static readonly UserAssignment MANUAL = new UserAssignment("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserAssignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserAssignment FindValue(string value)
        {
            return FindValue<UserAssignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserAssignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserDesignation.
    /// </summary>
    public class UserDesignation : ConstantClass
    {

        /// <summary>
        /// Constant PROJECT_CONTRIBUTOR for UserDesignation
        /// </summary>
        public static readonly UserDesignation PROJECT_CONTRIBUTOR = new UserDesignation("PROJECT_CONTRIBUTOR");
        /// <summary>
        /// Constant PROJECT_OWNER for UserDesignation
        /// </summary>
        public static readonly UserDesignation PROJECT_OWNER = new UserDesignation("PROJECT_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserDesignation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserDesignation FindValue(string value)
        {
            return FindValue<UserDesignation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserDesignation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserProfileStatus.
    /// </summary>
    public class UserProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus ACTIVATED = new UserProfileStatus("ACTIVATED");
        /// <summary>
        /// Constant ASSIGNED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus ASSIGNED = new UserProfileStatus("ASSIGNED");
        /// <summary>
        /// Constant DEACTIVATED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus DEACTIVATED = new UserProfileStatus("DEACTIVATED");
        /// <summary>
        /// Constant NOT_ASSIGNED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus NOT_ASSIGNED = new UserProfileStatus("NOT_ASSIGNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserProfileStatus FindValue(string value)
        {
            return FindValue<UserProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserProfileType.
    /// </summary>
    public class UserProfileType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for UserProfileType
        /// </summary>
        public static readonly UserProfileType IAM = new UserProfileType("IAM");
        /// <summary>
        /// Constant SSO for UserProfileType
        /// </summary>
        public static readonly UserProfileType SSO = new UserProfileType("SSO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserProfileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserProfileType FindValue(string value)
        {
            return FindValue<UserProfileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserProfileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserSearchType.
    /// </summary>
    public class UserSearchType : ConstantClass
    {

        /// <summary>
        /// Constant DATAZONE_IAM_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType DATAZONE_IAM_USER = new UserSearchType("DATAZONE_IAM_USER");
        /// <summary>
        /// Constant DATAZONE_SSO_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType DATAZONE_SSO_USER = new UserSearchType("DATAZONE_SSO_USER");
        /// <summary>
        /// Constant DATAZONE_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType DATAZONE_USER = new UserSearchType("DATAZONE_USER");
        /// <summary>
        /// Constant SSO_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType SSO_USER = new UserSearchType("SSO_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserSearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserSearchType FindValue(string value)
        {
            return FindValue<UserSearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserSearchType(string value)
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
        /// Constant IAM_ROLE for UserType
        /// </summary>
        public static readonly UserType IAM_ROLE = new UserType("IAM_ROLE");
        /// <summary>
        /// Constant IAM_USER for UserType
        /// </summary>
        public static readonly UserType IAM_USER = new UserType("IAM_USER");
        /// <summary>
        /// Constant SSO_USER for UserType
        /// </summary>
        public static readonly UserType SSO_USER = new UserType("SSO_USER");

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

}