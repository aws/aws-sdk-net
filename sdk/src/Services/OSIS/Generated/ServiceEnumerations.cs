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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.OSIS
{

    /// <summary>
    /// Constants used for properties of type ChangeProgressStageStatuses.
    /// </summary>
    public class ChangeProgressStageStatuses : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ChangeProgressStageStatuses
        /// </summary>
        public static readonly ChangeProgressStageStatuses COMPLETED = new ChangeProgressStageStatuses("COMPLETED");
        /// <summary>
        /// Constant FAILED for ChangeProgressStageStatuses
        /// </summary>
        public static readonly ChangeProgressStageStatuses FAILED = new ChangeProgressStageStatuses("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ChangeProgressStageStatuses
        /// </summary>
        public static readonly ChangeProgressStageStatuses IN_PROGRESS = new ChangeProgressStageStatuses("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for ChangeProgressStageStatuses
        /// </summary>
        public static readonly ChangeProgressStageStatuses PENDING = new ChangeProgressStageStatuses("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeProgressStageStatuses(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeProgressStageStatuses FindValue(string value)
        {
            return FindValue<ChangeProgressStageStatuses>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeProgressStageStatuses(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeProgressStatuses.
    /// </summary>
    public class ChangeProgressStatuses : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ChangeProgressStatuses
        /// </summary>
        public static readonly ChangeProgressStatuses COMPLETED = new ChangeProgressStatuses("COMPLETED");
        /// <summary>
        /// Constant FAILED for ChangeProgressStatuses
        /// </summary>
        public static readonly ChangeProgressStatuses FAILED = new ChangeProgressStatuses("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ChangeProgressStatuses
        /// </summary>
        public static readonly ChangeProgressStatuses IN_PROGRESS = new ChangeProgressStatuses("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for ChangeProgressStatuses
        /// </summary>
        public static readonly ChangeProgressStatuses PENDING = new ChangeProgressStatuses("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeProgressStatuses(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeProgressStatuses FindValue(string value)
        {
            return FindValue<ChangeProgressStatuses>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeProgressStatuses(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineEndpointStatus.
    /// </summary>
    public class PipelineEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PipelineEndpointStatus
        /// </summary>
        public static readonly PipelineEndpointStatus ACTIVE = new PipelineEndpointStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for PipelineEndpointStatus
        /// </summary>
        public static readonly PipelineEndpointStatus CREATE_FAILED = new PipelineEndpointStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for PipelineEndpointStatus
        /// </summary>
        public static readonly PipelineEndpointStatus CREATING = new PipelineEndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETING for PipelineEndpointStatus
        /// </summary>
        public static readonly PipelineEndpointStatus DELETING = new PipelineEndpointStatus("DELETING");
        /// <summary>
        /// Constant REVOKED for PipelineEndpointStatus
        /// </summary>
        public static readonly PipelineEndpointStatus REVOKED = new PipelineEndpointStatus("REVOKED");
        /// <summary>
        /// Constant REVOKING for PipelineEndpointStatus
        /// </summary>
        public static readonly PipelineEndpointStatus REVOKING = new PipelineEndpointStatus("REVOKING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineEndpointStatus FindValue(string value)
        {
            return FindValue<PipelineEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineStatus.
    /// </summary>
    public class PipelineStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus ACTIVE = new PipelineStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus CREATE_FAILED = new PipelineStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus CREATING = new PipelineStatus("CREATING");
        /// <summary>
        /// Constant DELETING for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus DELETING = new PipelineStatus("DELETING");
        /// <summary>
        /// Constant START_FAILED for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus START_FAILED = new PipelineStatus("START_FAILED");
        /// <summary>
        /// Constant STARTING for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus STARTING = new PipelineStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus STOPPED = new PipelineStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus STOPPING = new PipelineStatus("STOPPING");
        /// <summary>
        /// Constant UPDATE_FAILED for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus UPDATE_FAILED = new PipelineStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus UPDATING = new PipelineStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineStatus FindValue(string value)
        {
            return FindValue<PipelineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcEndpointManagement.
    /// </summary>
    public class VpcEndpointManagement : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER for VpcEndpointManagement
        /// </summary>
        public static readonly VpcEndpointManagement CUSTOMER = new VpcEndpointManagement("CUSTOMER");
        /// <summary>
        /// Constant SERVICE for VpcEndpointManagement
        /// </summary>
        public static readonly VpcEndpointManagement SERVICE = new VpcEndpointManagement("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcEndpointManagement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointManagement FindValue(string value)
        {
            return FindValue<VpcEndpointManagement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointManagement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcEndpointServiceName.
    /// </summary>
    public class VpcEndpointServiceName : ConstantClass
    {

        /// <summary>
        /// Constant OPENSEARCH_SERVERLESS for VpcEndpointServiceName
        /// </summary>
        public static readonly VpcEndpointServiceName OPENSEARCH_SERVERLESS = new VpcEndpointServiceName("OPENSEARCH_SERVERLESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcEndpointServiceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointServiceName FindValue(string value)
        {
            return FindValue<VpcEndpointServiceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointServiceName(string value)
        {
            return FindValue(value);
        }
    }

}