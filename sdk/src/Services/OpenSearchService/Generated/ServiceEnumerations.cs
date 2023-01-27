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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.OpenSearchService
{

    /// <summary>
    /// Constants used for properties of type AutoTuneDesiredState.
    /// </summary>
    public class AutoTuneDesiredState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AutoTuneDesiredState
        /// </summary>
        public static readonly AutoTuneDesiredState DISABLED = new AutoTuneDesiredState("DISABLED");
        /// <summary>
        /// Constant ENABLED for AutoTuneDesiredState
        /// </summary>
        public static readonly AutoTuneDesiredState ENABLED = new AutoTuneDesiredState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoTuneDesiredState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoTuneDesiredState FindValue(string value)
        {
            return FindValue<AutoTuneDesiredState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoTuneDesiredState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoTuneState.
    /// </summary>
    public class AutoTuneState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState DISABLE_IN_PROGRESS = new AutoTuneState("DISABLE_IN_PROGRESS");
        /// <summary>
        /// Constant DISABLED for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState DISABLED = new AutoTuneState("DISABLED");
        /// <summary>
        /// Constant DISABLED_AND_ROLLBACK_COMPLETE for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState DISABLED_AND_ROLLBACK_COMPLETE = new AutoTuneState("DISABLED_AND_ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant DISABLED_AND_ROLLBACK_ERROR for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState DISABLED_AND_ROLLBACK_ERROR = new AutoTuneState("DISABLED_AND_ROLLBACK_ERROR");
        /// <summary>
        /// Constant DISABLED_AND_ROLLBACK_IN_PROGRESS for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState DISABLED_AND_ROLLBACK_IN_PROGRESS = new AutoTuneState("DISABLED_AND_ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant DISABLED_AND_ROLLBACK_SCHEDULED for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState DISABLED_AND_ROLLBACK_SCHEDULED = new AutoTuneState("DISABLED_AND_ROLLBACK_SCHEDULED");
        /// <summary>
        /// Constant ENABLE_IN_PROGRESS for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState ENABLE_IN_PROGRESS = new AutoTuneState("ENABLE_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState ENABLED = new AutoTuneState("ENABLED");
        /// <summary>
        /// Constant ERROR for AutoTuneState
        /// </summary>
        public static readonly AutoTuneState ERROR = new AutoTuneState("ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoTuneState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoTuneState FindValue(string value)
        {
            return FindValue<AutoTuneState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoTuneState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoTuneType.
    /// </summary>
    public class AutoTuneType : ConstantClass
    {

        /// <summary>
        /// Constant SCHEDULED_ACTION for AutoTuneType
        /// </summary>
        public static readonly AutoTuneType SCHEDULED_ACTION = new AutoTuneType("SCHEDULED_ACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoTuneType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoTuneType FindValue(string value)
        {
            return FindValue<AutoTuneType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoTuneType(string value)
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
        /// Constant COMPLETED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus COMPLETED = new DeploymentStatus("COMPLETED");
        /// <summary>
        /// Constant ELIGIBLE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus ELIGIBLE = new DeploymentStatus("ELIGIBLE");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus IN_PROGRESS = new DeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_ELIGIBLE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus NOT_ELIGIBLE = new DeploymentStatus("NOT_ELIGIBLE");
        /// <summary>
        /// Constant PENDING_UPDATE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus PENDING_UPDATE = new DeploymentStatus("PENDING_UPDATE");

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
    /// Constants used for properties of type DescribePackagesFilterName.
    /// </summary>
    public class DescribePackagesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant PackageID for DescribePackagesFilterName
        /// </summary>
        public static readonly DescribePackagesFilterName PackageID = new DescribePackagesFilterName("PackageID");
        /// <summary>
        /// Constant PackageName for DescribePackagesFilterName
        /// </summary>
        public static readonly DescribePackagesFilterName PackageName = new DescribePackagesFilterName("PackageName");
        /// <summary>
        /// Constant PackageStatus for DescribePackagesFilterName
        /// </summary>
        public static readonly DescribePackagesFilterName PackageStatus = new DescribePackagesFilterName("PackageStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribePackagesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribePackagesFilterName FindValue(string value)
        {
            return FindValue<DescribePackagesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribePackagesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainPackageStatus.
    /// </summary>
    public class DomainPackageStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DomainPackageStatus
        /// </summary>
        public static readonly DomainPackageStatus ACTIVE = new DomainPackageStatus("ACTIVE");
        /// <summary>
        /// Constant ASSOCIATING for DomainPackageStatus
        /// </summary>
        public static readonly DomainPackageStatus ASSOCIATING = new DomainPackageStatus("ASSOCIATING");
        /// <summary>
        /// Constant ASSOCIATION_FAILED for DomainPackageStatus
        /// </summary>
        public static readonly DomainPackageStatus ASSOCIATION_FAILED = new DomainPackageStatus("ASSOCIATION_FAILED");
        /// <summary>
        /// Constant DISSOCIATING for DomainPackageStatus
        /// </summary>
        public static readonly DomainPackageStatus DISSOCIATING = new DomainPackageStatus("DISSOCIATING");
        /// <summary>
        /// Constant DISSOCIATION_FAILED for DomainPackageStatus
        /// </summary>
        public static readonly DomainPackageStatus DISSOCIATION_FAILED = new DomainPackageStatus("DISSOCIATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainPackageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainPackageStatus FindValue(string value)
        {
            return FindValue<DomainPackageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainPackageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DryRunMode.
    /// </summary>
    public class DryRunMode : ConstantClass
    {

        /// <summary>
        /// Constant Basic for DryRunMode
        /// </summary>
        public static readonly DryRunMode Basic = new DryRunMode("Basic");
        /// <summary>
        /// Constant Verbose for DryRunMode
        /// </summary>
        public static readonly DryRunMode Verbose = new DryRunMode("Verbose");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DryRunMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DryRunMode FindValue(string value)
        {
            return FindValue<DryRunMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DryRunMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngineType.
    /// </summary>
    public class EngineType : ConstantClass
    {

        /// <summary>
        /// Constant Elasticsearch for EngineType
        /// </summary>
        public static readonly EngineType Elasticsearch = new EngineType("Elasticsearch");
        /// <summary>
        /// Constant OpenSearch for EngineType
        /// </summary>
        public static readonly EngineType OpenSearch = new EngineType("OpenSearch");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngineType FindValue(string value)
        {
            return FindValue<EngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InboundConnectionStatusCode.
    /// </summary>
    public class InboundConnectionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode ACTIVE = new InboundConnectionStatusCode("ACTIVE");
        /// <summary>
        /// Constant APPROVED for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode APPROVED = new InboundConnectionStatusCode("APPROVED");
        /// <summary>
        /// Constant DELETED for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode DELETED = new InboundConnectionStatusCode("DELETED");
        /// <summary>
        /// Constant DELETING for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode DELETING = new InboundConnectionStatusCode("DELETING");
        /// <summary>
        /// Constant PENDING_ACCEPTANCE for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode PENDING_ACCEPTANCE = new InboundConnectionStatusCode("PENDING_ACCEPTANCE");
        /// <summary>
        /// Constant PROVISIONING for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode PROVISIONING = new InboundConnectionStatusCode("PROVISIONING");
        /// <summary>
        /// Constant REJECTED for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode REJECTED = new InboundConnectionStatusCode("REJECTED");
        /// <summary>
        /// Constant REJECTING for InboundConnectionStatusCode
        /// </summary>
        public static readonly InboundConnectionStatusCode REJECTING = new InboundConnectionStatusCode("REJECTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InboundConnectionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InboundConnectionStatusCode FindValue(string value)
        {
            return FindValue<InboundConnectionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InboundConnectionStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIT_LOGS for LogType
        /// </summary>
        public static readonly LogType AUDIT_LOGS = new LogType("AUDIT_LOGS");
        /// <summary>
        /// Constant ES_APPLICATION_LOGS for LogType
        /// </summary>
        public static readonly LogType ES_APPLICATION_LOGS = new LogType("ES_APPLICATION_LOGS");
        /// <summary>
        /// Constant INDEX_SLOW_LOGS for LogType
        /// </summary>
        public static readonly LogType INDEX_SLOW_LOGS = new LogType("INDEX_SLOW_LOGS");
        /// <summary>
        /// Constant SEARCH_SLOW_LOGS for LogType
        /// </summary>
        public static readonly LogType SEARCH_SLOW_LOGS = new LogType("SEARCH_SLOW_LOGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenSearchPartitionInstanceType.
    /// </summary>
    public class OpenSearchPartitionInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant C42xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C42xlargeSearch = new OpenSearchPartitionInstanceType("c4.2xlarge.search");
        /// <summary>
        /// Constant C44xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C44xlargeSearch = new OpenSearchPartitionInstanceType("c4.4xlarge.search");
        /// <summary>
        /// Constant C48xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C48xlargeSearch = new OpenSearchPartitionInstanceType("c4.8xlarge.search");
        /// <summary>
        /// Constant C4LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C4LargeSearch = new OpenSearchPartitionInstanceType("c4.large.search");
        /// <summary>
        /// Constant C4XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C4XlargeSearch = new OpenSearchPartitionInstanceType("c4.xlarge.search");
        /// <summary>
        /// Constant C518xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C518xlargeSearch = new OpenSearchPartitionInstanceType("c5.18xlarge.search");
        /// <summary>
        /// Constant C52xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C52xlargeSearch = new OpenSearchPartitionInstanceType("c5.2xlarge.search");
        /// <summary>
        /// Constant C54xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C54xlargeSearch = new OpenSearchPartitionInstanceType("c5.4xlarge.search");
        /// <summary>
        /// Constant C59xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C59xlargeSearch = new OpenSearchPartitionInstanceType("c5.9xlarge.search");
        /// <summary>
        /// Constant C5LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C5LargeSearch = new OpenSearchPartitionInstanceType("c5.large.search");
        /// <summary>
        /// Constant C5XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C5XlargeSearch = new OpenSearchPartitionInstanceType("c5.xlarge.search");
        /// <summary>
        /// Constant C6g12xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C6g12xlargeSearch = new OpenSearchPartitionInstanceType("c6g.12xlarge.search");
        /// <summary>
        /// Constant C6g2xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C6g2xlargeSearch = new OpenSearchPartitionInstanceType("c6g.2xlarge.search");
        /// <summary>
        /// Constant C6g4xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C6g4xlargeSearch = new OpenSearchPartitionInstanceType("c6g.4xlarge.search");
        /// <summary>
        /// Constant C6g8xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C6g8xlargeSearch = new OpenSearchPartitionInstanceType("c6g.8xlarge.search");
        /// <summary>
        /// Constant C6gLargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C6gLargeSearch = new OpenSearchPartitionInstanceType("c6g.large.search");
        /// <summary>
        /// Constant C6gXlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType C6gXlargeSearch = new OpenSearchPartitionInstanceType("c6g.xlarge.search");
        /// <summary>
        /// Constant D22xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType D22xlargeSearch = new OpenSearchPartitionInstanceType("d2.2xlarge.search");
        /// <summary>
        /// Constant D24xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType D24xlargeSearch = new OpenSearchPartitionInstanceType("d2.4xlarge.search");
        /// <summary>
        /// Constant D28xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType D28xlargeSearch = new OpenSearchPartitionInstanceType("d2.8xlarge.search");
        /// <summary>
        /// Constant D2XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType D2XlargeSearch = new OpenSearchPartitionInstanceType("d2.xlarge.search");
        /// <summary>
        /// Constant I22xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I22xlargeSearch = new OpenSearchPartitionInstanceType("i2.2xlarge.search");
        /// <summary>
        /// Constant I2XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I2XlargeSearch = new OpenSearchPartitionInstanceType("i2.xlarge.search");
        /// <summary>
        /// Constant I316xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I316xlargeSearch = new OpenSearchPartitionInstanceType("i3.16xlarge.search");
        /// <summary>
        /// Constant I32xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I32xlargeSearch = new OpenSearchPartitionInstanceType("i3.2xlarge.search");
        /// <summary>
        /// Constant I34xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I34xlargeSearch = new OpenSearchPartitionInstanceType("i3.4xlarge.search");
        /// <summary>
        /// Constant I38xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I38xlargeSearch = new OpenSearchPartitionInstanceType("i3.8xlarge.search");
        /// <summary>
        /// Constant I3LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I3LargeSearch = new OpenSearchPartitionInstanceType("i3.large.search");
        /// <summary>
        /// Constant I3XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType I3XlargeSearch = new OpenSearchPartitionInstanceType("i3.xlarge.search");
        /// <summary>
        /// Constant M32xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M32xlargeSearch = new OpenSearchPartitionInstanceType("m3.2xlarge.search");
        /// <summary>
        /// Constant M3LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M3LargeSearch = new OpenSearchPartitionInstanceType("m3.large.search");
        /// <summary>
        /// Constant M3MediumSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M3MediumSearch = new OpenSearchPartitionInstanceType("m3.medium.search");
        /// <summary>
        /// Constant M3XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M3XlargeSearch = new OpenSearchPartitionInstanceType("m3.xlarge.search");
        /// <summary>
        /// Constant M410xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M410xlargeSearch = new OpenSearchPartitionInstanceType("m4.10xlarge.search");
        /// <summary>
        /// Constant M42xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M42xlargeSearch = new OpenSearchPartitionInstanceType("m4.2xlarge.search");
        /// <summary>
        /// Constant M44xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M44xlargeSearch = new OpenSearchPartitionInstanceType("m4.4xlarge.search");
        /// <summary>
        /// Constant M4LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M4LargeSearch = new OpenSearchPartitionInstanceType("m4.large.search");
        /// <summary>
        /// Constant M4XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M4XlargeSearch = new OpenSearchPartitionInstanceType("m4.xlarge.search");
        /// <summary>
        /// Constant M512xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M512xlargeSearch = new OpenSearchPartitionInstanceType("m5.12xlarge.search");
        /// <summary>
        /// Constant M524xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M524xlargeSearch = new OpenSearchPartitionInstanceType("m5.24xlarge.search");
        /// <summary>
        /// Constant M52xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M52xlargeSearch = new OpenSearchPartitionInstanceType("m5.2xlarge.search");
        /// <summary>
        /// Constant M54xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M54xlargeSearch = new OpenSearchPartitionInstanceType("m5.4xlarge.search");
        /// <summary>
        /// Constant M5LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M5LargeSearch = new OpenSearchPartitionInstanceType("m5.large.search");
        /// <summary>
        /// Constant M5XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M5XlargeSearch = new OpenSearchPartitionInstanceType("m5.xlarge.search");
        /// <summary>
        /// Constant M6g12xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M6g12xlargeSearch = new OpenSearchPartitionInstanceType("m6g.12xlarge.search");
        /// <summary>
        /// Constant M6g2xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M6g2xlargeSearch = new OpenSearchPartitionInstanceType("m6g.2xlarge.search");
        /// <summary>
        /// Constant M6g4xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M6g4xlargeSearch = new OpenSearchPartitionInstanceType("m6g.4xlarge.search");
        /// <summary>
        /// Constant M6g8xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M6g8xlargeSearch = new OpenSearchPartitionInstanceType("m6g.8xlarge.search");
        /// <summary>
        /// Constant M6gLargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M6gLargeSearch = new OpenSearchPartitionInstanceType("m6g.large.search");
        /// <summary>
        /// Constant M6gXlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType M6gXlargeSearch = new OpenSearchPartitionInstanceType("m6g.xlarge.search");
        /// <summary>
        /// Constant R32xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R32xlargeSearch = new OpenSearchPartitionInstanceType("r3.2xlarge.search");
        /// <summary>
        /// Constant R34xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R34xlargeSearch = new OpenSearchPartitionInstanceType("r3.4xlarge.search");
        /// <summary>
        /// Constant R38xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R38xlargeSearch = new OpenSearchPartitionInstanceType("r3.8xlarge.search");
        /// <summary>
        /// Constant R3LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R3LargeSearch = new OpenSearchPartitionInstanceType("r3.large.search");
        /// <summary>
        /// Constant R3XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R3XlargeSearch = new OpenSearchPartitionInstanceType("r3.xlarge.search");
        /// <summary>
        /// Constant R416xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R416xlargeSearch = new OpenSearchPartitionInstanceType("r4.16xlarge.search");
        /// <summary>
        /// Constant R42xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R42xlargeSearch = new OpenSearchPartitionInstanceType("r4.2xlarge.search");
        /// <summary>
        /// Constant R44xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R44xlargeSearch = new OpenSearchPartitionInstanceType("r4.4xlarge.search");
        /// <summary>
        /// Constant R48xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R48xlargeSearch = new OpenSearchPartitionInstanceType("r4.8xlarge.search");
        /// <summary>
        /// Constant R4LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R4LargeSearch = new OpenSearchPartitionInstanceType("r4.large.search");
        /// <summary>
        /// Constant R4XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R4XlargeSearch = new OpenSearchPartitionInstanceType("r4.xlarge.search");
        /// <summary>
        /// Constant R512xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R512xlargeSearch = new OpenSearchPartitionInstanceType("r5.12xlarge.search");
        /// <summary>
        /// Constant R524xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R524xlargeSearch = new OpenSearchPartitionInstanceType("r5.24xlarge.search");
        /// <summary>
        /// Constant R52xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R52xlargeSearch = new OpenSearchPartitionInstanceType("r5.2xlarge.search");
        /// <summary>
        /// Constant R54xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R54xlargeSearch = new OpenSearchPartitionInstanceType("r5.4xlarge.search");
        /// <summary>
        /// Constant R5LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R5LargeSearch = new OpenSearchPartitionInstanceType("r5.large.search");
        /// <summary>
        /// Constant R5XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R5XlargeSearch = new OpenSearchPartitionInstanceType("r5.xlarge.search");
        /// <summary>
        /// Constant R6g12xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6g12xlargeSearch = new OpenSearchPartitionInstanceType("r6g.12xlarge.search");
        /// <summary>
        /// Constant R6g2xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6g2xlargeSearch = new OpenSearchPartitionInstanceType("r6g.2xlarge.search");
        /// <summary>
        /// Constant R6g4xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6g4xlargeSearch = new OpenSearchPartitionInstanceType("r6g.4xlarge.search");
        /// <summary>
        /// Constant R6g8xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6g8xlargeSearch = new OpenSearchPartitionInstanceType("r6g.8xlarge.search");
        /// <summary>
        /// Constant R6gd12xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gd12xlargeSearch = new OpenSearchPartitionInstanceType("r6gd.12xlarge.search");
        /// <summary>
        /// Constant R6gd16xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gd16xlargeSearch = new OpenSearchPartitionInstanceType("r6gd.16xlarge.search");
        /// <summary>
        /// Constant R6gd2xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gd2xlargeSearch = new OpenSearchPartitionInstanceType("r6gd.2xlarge.search");
        /// <summary>
        /// Constant R6gd4xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gd4xlargeSearch = new OpenSearchPartitionInstanceType("r6gd.4xlarge.search");
        /// <summary>
        /// Constant R6gd8xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gd8xlargeSearch = new OpenSearchPartitionInstanceType("r6gd.8xlarge.search");
        /// <summary>
        /// Constant R6gdLargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gdLargeSearch = new OpenSearchPartitionInstanceType("r6gd.large.search");
        /// <summary>
        /// Constant R6gdXlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gdXlargeSearch = new OpenSearchPartitionInstanceType("r6gd.xlarge.search");
        /// <summary>
        /// Constant R6gLargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gLargeSearch = new OpenSearchPartitionInstanceType("r6g.large.search");
        /// <summary>
        /// Constant R6gXlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType R6gXlargeSearch = new OpenSearchPartitionInstanceType("r6g.xlarge.search");
        /// <summary>
        /// Constant T2MediumSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T2MediumSearch = new OpenSearchPartitionInstanceType("t2.medium.search");
        /// <summary>
        /// Constant T2MicroSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T2MicroSearch = new OpenSearchPartitionInstanceType("t2.micro.search");
        /// <summary>
        /// Constant T2SmallSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T2SmallSearch = new OpenSearchPartitionInstanceType("t2.small.search");
        /// <summary>
        /// Constant T32xlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T32xlargeSearch = new OpenSearchPartitionInstanceType("t3.2xlarge.search");
        /// <summary>
        /// Constant T3LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T3LargeSearch = new OpenSearchPartitionInstanceType("t3.large.search");
        /// <summary>
        /// Constant T3MediumSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T3MediumSearch = new OpenSearchPartitionInstanceType("t3.medium.search");
        /// <summary>
        /// Constant T3MicroSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T3MicroSearch = new OpenSearchPartitionInstanceType("t3.micro.search");
        /// <summary>
        /// Constant T3NanoSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T3NanoSearch = new OpenSearchPartitionInstanceType("t3.nano.search");
        /// <summary>
        /// Constant T3SmallSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T3SmallSearch = new OpenSearchPartitionInstanceType("t3.small.search");
        /// <summary>
        /// Constant T3XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T3XlargeSearch = new OpenSearchPartitionInstanceType("t3.xlarge.search");
        /// <summary>
        /// Constant T4gMediumSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T4gMediumSearch = new OpenSearchPartitionInstanceType("t4g.medium.search");
        /// <summary>
        /// Constant T4gSmallSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType T4gSmallSearch = new OpenSearchPartitionInstanceType("t4g.small.search");
        /// <summary>
        /// Constant Ultrawarm1LargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType Ultrawarm1LargeSearch = new OpenSearchPartitionInstanceType("ultrawarm1.large.search");
        /// <summary>
        /// Constant Ultrawarm1MediumSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType Ultrawarm1MediumSearch = new OpenSearchPartitionInstanceType("ultrawarm1.medium.search");
        /// <summary>
        /// Constant Ultrawarm1XlargeSearch for OpenSearchPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchPartitionInstanceType Ultrawarm1XlargeSearch = new OpenSearchPartitionInstanceType("ultrawarm1.xlarge.search");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenSearchPartitionInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenSearchPartitionInstanceType FindValue(string value)
        {
            return FindValue<OpenSearchPartitionInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenSearchPartitionInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenSearchWarmPartitionInstanceType.
    /// </summary>
    public class OpenSearchWarmPartitionInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant Ultrawarm1LargeSearch for OpenSearchWarmPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchWarmPartitionInstanceType Ultrawarm1LargeSearch = new OpenSearchWarmPartitionInstanceType("ultrawarm1.large.search");
        /// <summary>
        /// Constant Ultrawarm1MediumSearch for OpenSearchWarmPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchWarmPartitionInstanceType Ultrawarm1MediumSearch = new OpenSearchWarmPartitionInstanceType("ultrawarm1.medium.search");
        /// <summary>
        /// Constant Ultrawarm1XlargeSearch for OpenSearchWarmPartitionInstanceType
        /// </summary>
        public static readonly OpenSearchWarmPartitionInstanceType Ultrawarm1XlargeSearch = new OpenSearchWarmPartitionInstanceType("ultrawarm1.xlarge.search");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenSearchWarmPartitionInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenSearchWarmPartitionInstanceType FindValue(string value)
        {
            return FindValue<OpenSearchWarmPartitionInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenSearchWarmPartitionInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptionState.
    /// </summary>
    public class OptionState : ConstantClass
    {

        /// <summary>
        /// Constant Active for OptionState
        /// </summary>
        public static readonly OptionState Active = new OptionState("Active");
        /// <summary>
        /// Constant Processing for OptionState
        /// </summary>
        public static readonly OptionState Processing = new OptionState("Processing");
        /// <summary>
        /// Constant RequiresIndexDocuments for OptionState
        /// </summary>
        public static readonly OptionState RequiresIndexDocuments = new OptionState("RequiresIndexDocuments");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptionState FindValue(string value)
        {
            return FindValue<OptionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutboundConnectionStatusCode.
    /// </summary>
    public class OutboundConnectionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode ACTIVE = new OutboundConnectionStatusCode("ACTIVE");
        /// <summary>
        /// Constant APPROVED for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode APPROVED = new OutboundConnectionStatusCode("APPROVED");
        /// <summary>
        /// Constant DELETED for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode DELETED = new OutboundConnectionStatusCode("DELETED");
        /// <summary>
        /// Constant DELETING for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode DELETING = new OutboundConnectionStatusCode("DELETING");
        /// <summary>
        /// Constant PENDING_ACCEPTANCE for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode PENDING_ACCEPTANCE = new OutboundConnectionStatusCode("PENDING_ACCEPTANCE");
        /// <summary>
        /// Constant PROVISIONING for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode PROVISIONING = new OutboundConnectionStatusCode("PROVISIONING");
        /// <summary>
        /// Constant REJECTED for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode REJECTED = new OutboundConnectionStatusCode("REJECTED");
        /// <summary>
        /// Constant REJECTING for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode REJECTING = new OutboundConnectionStatusCode("REJECTING");
        /// <summary>
        /// Constant VALIDATING for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode VALIDATING = new OutboundConnectionStatusCode("VALIDATING");
        /// <summary>
        /// Constant VALIDATION_FAILED for OutboundConnectionStatusCode
        /// </summary>
        public static readonly OutboundConnectionStatusCode VALIDATION_FAILED = new OutboundConnectionStatusCode("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutboundConnectionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutboundConnectionStatusCode FindValue(string value)
        {
            return FindValue<OutboundConnectionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutboundConnectionStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverallChangeStatus.
    /// </summary>
    public class OverallChangeStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for OverallChangeStatus
        /// </summary>
        public static readonly OverallChangeStatus COMPLETED = new OverallChangeStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for OverallChangeStatus
        /// </summary>
        public static readonly OverallChangeStatus FAILED = new OverallChangeStatus("FAILED");
        /// <summary>
        /// Constant PENDING for OverallChangeStatus
        /// </summary>
        public static readonly OverallChangeStatus PENDING = new OverallChangeStatus("PENDING");
        /// <summary>
        /// Constant PROCESSING for OverallChangeStatus
        /// </summary>
        public static readonly OverallChangeStatus PROCESSING = new OverallChangeStatus("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverallChangeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverallChangeStatus FindValue(string value)
        {
            return FindValue<OverallChangeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverallChangeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageStatus.
    /// </summary>
    public class PackageStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for PackageStatus
        /// </summary>
        public static readonly PackageStatus AVAILABLE = new PackageStatus("AVAILABLE");
        /// <summary>
        /// Constant COPY_FAILED for PackageStatus
        /// </summary>
        public static readonly PackageStatus COPY_FAILED = new PackageStatus("COPY_FAILED");
        /// <summary>
        /// Constant COPYING for PackageStatus
        /// </summary>
        public static readonly PackageStatus COPYING = new PackageStatus("COPYING");
        /// <summary>
        /// Constant DELETE_FAILED for PackageStatus
        /// </summary>
        public static readonly PackageStatus DELETE_FAILED = new PackageStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for PackageStatus
        /// </summary>
        public static readonly PackageStatus DELETED = new PackageStatus("DELETED");
        /// <summary>
        /// Constant DELETING for PackageStatus
        /// </summary>
        public static readonly PackageStatus DELETING = new PackageStatus("DELETING");
        /// <summary>
        /// Constant VALIDATING for PackageStatus
        /// </summary>
        public static readonly PackageStatus VALIDATING = new PackageStatus("VALIDATING");
        /// <summary>
        /// Constant VALIDATION_FAILED for PackageStatus
        /// </summary>
        public static readonly PackageStatus VALIDATION_FAILED = new PackageStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageStatus FindValue(string value)
        {
            return FindValue<PackageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageType.
    /// </summary>
    public class PackageType : ConstantClass
    {

        /// <summary>
        /// Constant TXTDICTIONARY for PackageType
        /// </summary>
        public static readonly PackageType TXTDICTIONARY = new PackageType("TXT-DICTIONARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageType FindValue(string value)
        {
            return FindValue<PackageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_ACCOUNT for PrincipalType
        /// </summary>
        public static readonly PrincipalType AWS_ACCOUNT = new PrincipalType("AWS_ACCOUNT");
        /// <summary>
        /// Constant AWS_SERVICE for PrincipalType
        /// </summary>
        public static readonly PrincipalType AWS_SERVICE = new PrincipalType("AWS_SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservedInstancePaymentOption.
    /// </summary>
    public class ReservedInstancePaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL_UPFRONT for ReservedInstancePaymentOption
        /// </summary>
        public static readonly ReservedInstancePaymentOption ALL_UPFRONT = new ReservedInstancePaymentOption("ALL_UPFRONT");
        /// <summary>
        /// Constant NO_UPFRONT for ReservedInstancePaymentOption
        /// </summary>
        public static readonly ReservedInstancePaymentOption NO_UPFRONT = new ReservedInstancePaymentOption("NO_UPFRONT");
        /// <summary>
        /// Constant PARTIAL_UPFRONT for ReservedInstancePaymentOption
        /// </summary>
        public static readonly ReservedInstancePaymentOption PARTIAL_UPFRONT = new ReservedInstancePaymentOption("PARTIAL_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservedInstancePaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservedInstancePaymentOption FindValue(string value)
        {
            return FindValue<ReservedInstancePaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservedInstancePaymentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RollbackOnDisable.
    /// </summary>
    public class RollbackOnDisable : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_ROLLBACK for RollbackOnDisable
        /// </summary>
        public static readonly RollbackOnDisable DEFAULT_ROLLBACK = new RollbackOnDisable("DEFAULT_ROLLBACK");
        /// <summary>
        /// Constant NO_ROLLBACK for RollbackOnDisable
        /// </summary>
        public static readonly RollbackOnDisable NO_ROLLBACK = new RollbackOnDisable("NO_ROLLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RollbackOnDisable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RollbackOnDisable FindValue(string value)
        {
            return FindValue<RollbackOnDisable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RollbackOnDisable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduledAutoTuneActionType.
    /// </summary>
    public class ScheduledAutoTuneActionType : ConstantClass
    {

        /// <summary>
        /// Constant JVM_HEAP_SIZE_TUNING for ScheduledAutoTuneActionType
        /// </summary>
        public static readonly ScheduledAutoTuneActionType JVM_HEAP_SIZE_TUNING = new ScheduledAutoTuneActionType("JVM_HEAP_SIZE_TUNING");
        /// <summary>
        /// Constant JVM_YOUNG_GEN_TUNING for ScheduledAutoTuneActionType
        /// </summary>
        public static readonly ScheduledAutoTuneActionType JVM_YOUNG_GEN_TUNING = new ScheduledAutoTuneActionType("JVM_YOUNG_GEN_TUNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduledAutoTuneActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduledAutoTuneActionType FindValue(string value)
        {
            return FindValue<ScheduledAutoTuneActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduledAutoTuneActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduledAutoTuneSeverityType.
    /// </summary>
    public class ScheduledAutoTuneSeverityType : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for ScheduledAutoTuneSeverityType
        /// </summary>
        public static readonly ScheduledAutoTuneSeverityType HIGH = new ScheduledAutoTuneSeverityType("HIGH");
        /// <summary>
        /// Constant LOW for ScheduledAutoTuneSeverityType
        /// </summary>
        public static readonly ScheduledAutoTuneSeverityType LOW = new ScheduledAutoTuneSeverityType("LOW");
        /// <summary>
        /// Constant MEDIUM for ScheduledAutoTuneSeverityType
        /// </summary>
        public static readonly ScheduledAutoTuneSeverityType MEDIUM = new ScheduledAutoTuneSeverityType("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduledAutoTuneSeverityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduledAutoTuneSeverityType FindValue(string value)
        {
            return FindValue<ScheduledAutoTuneSeverityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduledAutoTuneSeverityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeUnit.
    /// </summary>
    public class TimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant HOURS for TimeUnit
        /// </summary>
        public static readonly TimeUnit HOURS = new TimeUnit("HOURS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeUnit FindValue(string value)
        {
            return FindValue<TimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TLSSecurityPolicy.
    /// </summary>
    public class TLSSecurityPolicy : ConstantClass
    {

        /// <summary>
        /// Constant PolicyMinTLS10201907 for TLSSecurityPolicy
        /// </summary>
        public static readonly TLSSecurityPolicy PolicyMinTLS10201907 = new TLSSecurityPolicy("Policy-Min-TLS-1-0-2019-07");
        /// <summary>
        /// Constant PolicyMinTLS12201907 for TLSSecurityPolicy
        /// </summary>
        public static readonly TLSSecurityPolicy PolicyMinTLS12201907 = new TLSSecurityPolicy("Policy-Min-TLS-1-2-2019-07");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TLSSecurityPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TLSSecurityPolicy FindValue(string value)
        {
            return FindValue<TLSSecurityPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TLSSecurityPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpgradeStatus.
    /// </summary>
    public class UpgradeStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for UpgradeStatus
        /// </summary>
        public static readonly UpgradeStatus FAILED = new UpgradeStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for UpgradeStatus
        /// </summary>
        public static readonly UpgradeStatus IN_PROGRESS = new UpgradeStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for UpgradeStatus
        /// </summary>
        public static readonly UpgradeStatus SUCCEEDED = new UpgradeStatus("SUCCEEDED");
        /// <summary>
        /// Constant SUCCEEDED_WITH_ISSUES for UpgradeStatus
        /// </summary>
        public static readonly UpgradeStatus SUCCEEDED_WITH_ISSUES = new UpgradeStatus("SUCCEEDED_WITH_ISSUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpgradeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpgradeStatus FindValue(string value)
        {
            return FindValue<UpgradeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpgradeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpgradeStep.
    /// </summary>
    public class UpgradeStep : ConstantClass
    {

        /// <summary>
        /// Constant PRE_UPGRADE_CHECK for UpgradeStep
        /// </summary>
        public static readonly UpgradeStep PRE_UPGRADE_CHECK = new UpgradeStep("PRE_UPGRADE_CHECK");
        /// <summary>
        /// Constant SNAPSHOT for UpgradeStep
        /// </summary>
        public static readonly UpgradeStep SNAPSHOT = new UpgradeStep("SNAPSHOT");
        /// <summary>
        /// Constant UPGRADE for UpgradeStep
        /// </summary>
        public static readonly UpgradeStep UPGRADE = new UpgradeStep("UPGRADE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpgradeStep(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpgradeStep FindValue(string value)
        {
            return FindValue<UpgradeStep>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpgradeStep(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp2 = new VolumeType("gp2");
        /// <summary>
        /// Constant Gp3 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp3 = new VolumeType("gp3");
        /// <summary>
        /// Constant Io1 for VolumeType
        /// </summary>
        public static readonly VolumeType Io1 = new VolumeType("io1");
        /// <summary>
        /// Constant Standard for VolumeType
        /// </summary>
        public static readonly VolumeType Standard = new VolumeType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcEndpointErrorCode.
    /// </summary>
    public class VpcEndpointErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ENDPOINT_NOT_FOUND for VpcEndpointErrorCode
        /// </summary>
        public static readonly VpcEndpointErrorCode ENDPOINT_NOT_FOUND = new VpcEndpointErrorCode("ENDPOINT_NOT_FOUND");
        /// <summary>
        /// Constant SERVER_ERROR for VpcEndpointErrorCode
        /// </summary>
        public static readonly VpcEndpointErrorCode SERVER_ERROR = new VpcEndpointErrorCode("SERVER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcEndpointErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointErrorCode FindValue(string value)
        {
            return FindValue<VpcEndpointErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcEndpointStatus.
    /// </summary>
    public class VpcEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus ACTIVE = new VpcEndpointStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus CREATE_FAILED = new VpcEndpointStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus CREATING = new VpcEndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus DELETE_FAILED = new VpcEndpointStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus DELETING = new VpcEndpointStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus UPDATE_FAILED = new VpcEndpointStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus UPDATING = new VpcEndpointStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointStatus FindValue(string value)
        {
            return FindValue<VpcEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }

}