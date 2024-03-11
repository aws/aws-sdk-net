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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeStarconnections
{

    /// <summary>
    /// Constants used for properties of type BlockerStatus.
    /// </summary>
    public class BlockerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BlockerStatus
        /// </summary>
        public static readonly BlockerStatus ACTIVE = new BlockerStatus("ACTIVE");
        /// <summary>
        /// Constant RESOLVED for BlockerStatus
        /// </summary>
        public static readonly BlockerStatus RESOLVED = new BlockerStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlockerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlockerStatus FindValue(string value)
        {
            return FindValue<BlockerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlockerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlockerType.
    /// </summary>
    public class BlockerType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATED for BlockerType
        /// </summary>
        public static readonly BlockerType AUTOMATED = new BlockerType("AUTOMATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlockerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlockerType FindValue(string value)
        {
            return FindValue<BlockerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlockerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus AVAILABLE = new ConnectionStatus("AVAILABLE");
        /// <summary>
        /// Constant ERROR for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus ERROR = new ConnectionStatus("ERROR");
        /// <summary>
        /// Constant PENDING for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus PENDING = new ConnectionStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProviderType.
    /// </summary>
    public class ProviderType : ConstantClass
    {

        /// <summary>
        /// Constant Bitbucket for ProviderType
        /// </summary>
        public static readonly ProviderType Bitbucket = new ProviderType("Bitbucket");
        /// <summary>
        /// Constant GitHub for ProviderType
        /// </summary>
        public static readonly ProviderType GitHub = new ProviderType("GitHub");
        /// <summary>
        /// Constant GitHubEnterpriseServer for ProviderType
        /// </summary>
        public static readonly ProviderType GitHubEnterpriseServer = new ProviderType("GitHubEnterpriseServer");
        /// <summary>
        /// Constant GitLab for ProviderType
        /// </summary>
        public static readonly ProviderType GitLab = new ProviderType("GitLab");
        /// <summary>
        /// Constant GitLabSelfManaged for ProviderType
        /// </summary>
        public static readonly ProviderType GitLabSelfManaged = new ProviderType("GitLabSelfManaged");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProviderType FindValue(string value)
        {
            return FindValue<ProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PublishDeploymentStatus.
    /// </summary>
    public class PublishDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PublishDeploymentStatus
        /// </summary>
        public static readonly PublishDeploymentStatus DISABLED = new PublishDeploymentStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for PublishDeploymentStatus
        /// </summary>
        public static readonly PublishDeploymentStatus ENABLED = new PublishDeploymentStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublishDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublishDeploymentStatus FindValue(string value)
        {
            return FindValue<PublishDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublishDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepositorySyncStatus.
    /// </summary>
    public class RepositorySyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RepositorySyncStatus
        /// </summary>
        public static readonly RepositorySyncStatus FAILED = new RepositorySyncStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RepositorySyncStatus
        /// </summary>
        public static readonly RepositorySyncStatus IN_PROGRESS = new RepositorySyncStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INITIATED for RepositorySyncStatus
        /// </summary>
        public static readonly RepositorySyncStatus INITIATED = new RepositorySyncStatus("INITIATED");
        /// <summary>
        /// Constant QUEUED for RepositorySyncStatus
        /// </summary>
        public static readonly RepositorySyncStatus QUEUED = new RepositorySyncStatus("QUEUED");
        /// <summary>
        /// Constant SUCCEEDED for RepositorySyncStatus
        /// </summary>
        public static readonly RepositorySyncStatus SUCCEEDED = new RepositorySyncStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositorySyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositorySyncStatus FindValue(string value)
        {
            return FindValue<RepositorySyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositorySyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceSyncStatus.
    /// </summary>
    public class ResourceSyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ResourceSyncStatus
        /// </summary>
        public static readonly ResourceSyncStatus FAILED = new ResourceSyncStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ResourceSyncStatus
        /// </summary>
        public static readonly ResourceSyncStatus IN_PROGRESS = new ResourceSyncStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INITIATED for ResourceSyncStatus
        /// </summary>
        public static readonly ResourceSyncStatus INITIATED = new ResourceSyncStatus("INITIATED");
        /// <summary>
        /// Constant SUCCEEDED for ResourceSyncStatus
        /// </summary>
        public static readonly ResourceSyncStatus SUCCEEDED = new ResourceSyncStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceSyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceSyncStatus FindValue(string value)
        {
            return FindValue<ResourceSyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceSyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SyncConfigurationType.
    /// </summary>
    public class SyncConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant CFN_STACK_SYNC for SyncConfigurationType
        /// </summary>
        public static readonly SyncConfigurationType CFN_STACK_SYNC = new SyncConfigurationType("CFN_STACK_SYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyncConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyncConfigurationType FindValue(string value)
        {
            return FindValue<SyncConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyncConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerResourceUpdateOn.
    /// </summary>
    public class TriggerResourceUpdateOn : ConstantClass
    {

        /// <summary>
        /// Constant ANY_CHANGE for TriggerResourceUpdateOn
        /// </summary>
        public static readonly TriggerResourceUpdateOn ANY_CHANGE = new TriggerResourceUpdateOn("ANY_CHANGE");
        /// <summary>
        /// Constant FILE_CHANGE for TriggerResourceUpdateOn
        /// </summary>
        public static readonly TriggerResourceUpdateOn FILE_CHANGE = new TriggerResourceUpdateOn("FILE_CHANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerResourceUpdateOn(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerResourceUpdateOn FindValue(string value)
        {
            return FindValue<TriggerResourceUpdateOn>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerResourceUpdateOn(string value)
        {
            return FindValue(value);
        }
    }

}