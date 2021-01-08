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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Elasticsearch
{

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
    /// Constants used for properties of type ESPartitionInstanceType.
    /// </summary>
    public class ESPartitionInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant C42xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C42xlargeElasticsearch = new ESPartitionInstanceType("c4.2xlarge.elasticsearch");
        /// <summary>
        /// Constant C44xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C44xlargeElasticsearch = new ESPartitionInstanceType("c4.4xlarge.elasticsearch");
        /// <summary>
        /// Constant C48xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C48xlargeElasticsearch = new ESPartitionInstanceType("c4.8xlarge.elasticsearch");
        /// <summary>
        /// Constant C4LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C4LargeElasticsearch = new ESPartitionInstanceType("c4.large.elasticsearch");
        /// <summary>
        /// Constant C4XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C4XlargeElasticsearch = new ESPartitionInstanceType("c4.xlarge.elasticsearch");
        /// <summary>
        /// Constant C518xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C518xlargeElasticsearch = new ESPartitionInstanceType("c5.18xlarge.elasticsearch");
        /// <summary>
        /// Constant C52xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C52xlargeElasticsearch = new ESPartitionInstanceType("c5.2xlarge.elasticsearch");
        /// <summary>
        /// Constant C54xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C54xlargeElasticsearch = new ESPartitionInstanceType("c5.4xlarge.elasticsearch");
        /// <summary>
        /// Constant C59xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C59xlargeElasticsearch = new ESPartitionInstanceType("c5.9xlarge.elasticsearch");
        /// <summary>
        /// Constant C5LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C5LargeElasticsearch = new ESPartitionInstanceType("c5.large.elasticsearch");
        /// <summary>
        /// Constant C5XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType C5XlargeElasticsearch = new ESPartitionInstanceType("c5.xlarge.elasticsearch");
        /// <summary>
        /// Constant D22xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType D22xlargeElasticsearch = new ESPartitionInstanceType("d2.2xlarge.elasticsearch");
        /// <summary>
        /// Constant D24xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType D24xlargeElasticsearch = new ESPartitionInstanceType("d2.4xlarge.elasticsearch");
        /// <summary>
        /// Constant D28xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType D28xlargeElasticsearch = new ESPartitionInstanceType("d2.8xlarge.elasticsearch");
        /// <summary>
        /// Constant D2XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType D2XlargeElasticsearch = new ESPartitionInstanceType("d2.xlarge.elasticsearch");
        /// <summary>
        /// Constant I22xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I22xlargeElasticsearch = new ESPartitionInstanceType("i2.2xlarge.elasticsearch");
        /// <summary>
        /// Constant I2XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I2XlargeElasticsearch = new ESPartitionInstanceType("i2.xlarge.elasticsearch");
        /// <summary>
        /// Constant I316xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I316xlargeElasticsearch = new ESPartitionInstanceType("i3.16xlarge.elasticsearch");
        /// <summary>
        /// Constant I32xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I32xlargeElasticsearch = new ESPartitionInstanceType("i3.2xlarge.elasticsearch");
        /// <summary>
        /// Constant I34xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I34xlargeElasticsearch = new ESPartitionInstanceType("i3.4xlarge.elasticsearch");
        /// <summary>
        /// Constant I38xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I38xlargeElasticsearch = new ESPartitionInstanceType("i3.8xlarge.elasticsearch");
        /// <summary>
        /// Constant I3LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I3LargeElasticsearch = new ESPartitionInstanceType("i3.large.elasticsearch");
        /// <summary>
        /// Constant I3XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType I3XlargeElasticsearch = new ESPartitionInstanceType("i3.xlarge.elasticsearch");
        /// <summary>
        /// Constant M32xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M32xlargeElasticsearch = new ESPartitionInstanceType("m3.2xlarge.elasticsearch");
        /// <summary>
        /// Constant M3LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M3LargeElasticsearch = new ESPartitionInstanceType("m3.large.elasticsearch");
        /// <summary>
        /// Constant M3MediumElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M3MediumElasticsearch = new ESPartitionInstanceType("m3.medium.elasticsearch");
        /// <summary>
        /// Constant M3XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M3XlargeElasticsearch = new ESPartitionInstanceType("m3.xlarge.elasticsearch");
        /// <summary>
        /// Constant M410xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M410xlargeElasticsearch = new ESPartitionInstanceType("m4.10xlarge.elasticsearch");
        /// <summary>
        /// Constant M42xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M42xlargeElasticsearch = new ESPartitionInstanceType("m4.2xlarge.elasticsearch");
        /// <summary>
        /// Constant M44xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M44xlargeElasticsearch = new ESPartitionInstanceType("m4.4xlarge.elasticsearch");
        /// <summary>
        /// Constant M4LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M4LargeElasticsearch = new ESPartitionInstanceType("m4.large.elasticsearch");
        /// <summary>
        /// Constant M4XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M4XlargeElasticsearch = new ESPartitionInstanceType("m4.xlarge.elasticsearch");
        /// <summary>
        /// Constant M512xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M512xlargeElasticsearch = new ESPartitionInstanceType("m5.12xlarge.elasticsearch");
        /// <summary>
        /// Constant M52xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M52xlargeElasticsearch = new ESPartitionInstanceType("m5.2xlarge.elasticsearch");
        /// <summary>
        /// Constant M54xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M54xlargeElasticsearch = new ESPartitionInstanceType("m5.4xlarge.elasticsearch");
        /// <summary>
        /// Constant M5LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M5LargeElasticsearch = new ESPartitionInstanceType("m5.large.elasticsearch");
        /// <summary>
        /// Constant M5XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType M5XlargeElasticsearch = new ESPartitionInstanceType("m5.xlarge.elasticsearch");
        /// <summary>
        /// Constant R32xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R32xlargeElasticsearch = new ESPartitionInstanceType("r3.2xlarge.elasticsearch");
        /// <summary>
        /// Constant R34xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R34xlargeElasticsearch = new ESPartitionInstanceType("r3.4xlarge.elasticsearch");
        /// <summary>
        /// Constant R38xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R38xlargeElasticsearch = new ESPartitionInstanceType("r3.8xlarge.elasticsearch");
        /// <summary>
        /// Constant R3LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R3LargeElasticsearch = new ESPartitionInstanceType("r3.large.elasticsearch");
        /// <summary>
        /// Constant R3XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R3XlargeElasticsearch = new ESPartitionInstanceType("r3.xlarge.elasticsearch");
        /// <summary>
        /// Constant R416xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R416xlargeElasticsearch = new ESPartitionInstanceType("r4.16xlarge.elasticsearch");
        /// <summary>
        /// Constant R42xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R42xlargeElasticsearch = new ESPartitionInstanceType("r4.2xlarge.elasticsearch");
        /// <summary>
        /// Constant R44xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R44xlargeElasticsearch = new ESPartitionInstanceType("r4.4xlarge.elasticsearch");
        /// <summary>
        /// Constant R48xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R48xlargeElasticsearch = new ESPartitionInstanceType("r4.8xlarge.elasticsearch");
        /// <summary>
        /// Constant R4LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R4LargeElasticsearch = new ESPartitionInstanceType("r4.large.elasticsearch");
        /// <summary>
        /// Constant R4XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R4XlargeElasticsearch = new ESPartitionInstanceType("r4.xlarge.elasticsearch");
        /// <summary>
        /// Constant R512xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R512xlargeElasticsearch = new ESPartitionInstanceType("r5.12xlarge.elasticsearch");
        /// <summary>
        /// Constant R52xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R52xlargeElasticsearch = new ESPartitionInstanceType("r5.2xlarge.elasticsearch");
        /// <summary>
        /// Constant R54xlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R54xlargeElasticsearch = new ESPartitionInstanceType("r5.4xlarge.elasticsearch");
        /// <summary>
        /// Constant R5LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R5LargeElasticsearch = new ESPartitionInstanceType("r5.large.elasticsearch");
        /// <summary>
        /// Constant R5XlargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType R5XlargeElasticsearch = new ESPartitionInstanceType("r5.xlarge.elasticsearch");
        /// <summary>
        /// Constant T2MediumElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType T2MediumElasticsearch = new ESPartitionInstanceType("t2.medium.elasticsearch");
        /// <summary>
        /// Constant T2MicroElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType T2MicroElasticsearch = new ESPartitionInstanceType("t2.micro.elasticsearch");
        /// <summary>
        /// Constant T2SmallElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType T2SmallElasticsearch = new ESPartitionInstanceType("t2.small.elasticsearch");
        /// <summary>
        /// Constant Ultrawarm1LargeElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType Ultrawarm1LargeElasticsearch = new ESPartitionInstanceType("ultrawarm1.large.elasticsearch");
        /// <summary>
        /// Constant Ultrawarm1MediumElasticsearch for ESPartitionInstanceType
        /// </summary>
        public static readonly ESPartitionInstanceType Ultrawarm1MediumElasticsearch = new ESPartitionInstanceType("ultrawarm1.medium.elasticsearch");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ESPartitionInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ESPartitionInstanceType FindValue(string value)
        {
            return FindValue<ESPartitionInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ESPartitionInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ESWarmPartitionInstanceType.
    /// </summary>
    public class ESWarmPartitionInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant Ultrawarm1LargeElasticsearch for ESWarmPartitionInstanceType
        /// </summary>
        public static readonly ESWarmPartitionInstanceType Ultrawarm1LargeElasticsearch = new ESWarmPartitionInstanceType("ultrawarm1.large.elasticsearch");
        /// <summary>
        /// Constant Ultrawarm1MediumElasticsearch for ESWarmPartitionInstanceType
        /// </summary>
        public static readonly ESWarmPartitionInstanceType Ultrawarm1MediumElasticsearch = new ESWarmPartitionInstanceType("ultrawarm1.medium.elasticsearch");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ESWarmPartitionInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ESWarmPartitionInstanceType FindValue(string value)
        {
            return FindValue<ESWarmPartitionInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ESWarmPartitionInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InboundCrossClusterSearchConnectionStatusCode.
    /// </summary>
    public class InboundCrossClusterSearchConnectionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for InboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly InboundCrossClusterSearchConnectionStatusCode APPROVED = new InboundCrossClusterSearchConnectionStatusCode("APPROVED");
        /// <summary>
        /// Constant DELETED for InboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly InboundCrossClusterSearchConnectionStatusCode DELETED = new InboundCrossClusterSearchConnectionStatusCode("DELETED");
        /// <summary>
        /// Constant DELETING for InboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly InboundCrossClusterSearchConnectionStatusCode DELETING = new InboundCrossClusterSearchConnectionStatusCode("DELETING");
        /// <summary>
        /// Constant PENDING_ACCEPTANCE for InboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly InboundCrossClusterSearchConnectionStatusCode PENDING_ACCEPTANCE = new InboundCrossClusterSearchConnectionStatusCode("PENDING_ACCEPTANCE");
        /// <summary>
        /// Constant REJECTED for InboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly InboundCrossClusterSearchConnectionStatusCode REJECTED = new InboundCrossClusterSearchConnectionStatusCode("REJECTED");
        /// <summary>
        /// Constant REJECTING for InboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly InboundCrossClusterSearchConnectionStatusCode REJECTING = new InboundCrossClusterSearchConnectionStatusCode("REJECTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InboundCrossClusterSearchConnectionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InboundCrossClusterSearchConnectionStatusCode FindValue(string value)
        {
            return FindValue<InboundCrossClusterSearchConnectionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InboundCrossClusterSearchConnectionStatusCode(string value)
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
    /// Constants used for properties of type OutboundCrossClusterSearchConnectionStatusCode.
    /// </summary>
    public class OutboundCrossClusterSearchConnectionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode ACTIVE = new OutboundCrossClusterSearchConnectionStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode DELETED = new OutboundCrossClusterSearchConnectionStatusCode("DELETED");
        /// <summary>
        /// Constant DELETING for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode DELETING = new OutboundCrossClusterSearchConnectionStatusCode("DELETING");
        /// <summary>
        /// Constant PENDING_ACCEPTANCE for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode PENDING_ACCEPTANCE = new OutboundCrossClusterSearchConnectionStatusCode("PENDING_ACCEPTANCE");
        /// <summary>
        /// Constant PROVISIONING for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode PROVISIONING = new OutboundCrossClusterSearchConnectionStatusCode("PROVISIONING");
        /// <summary>
        /// Constant REJECTED for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode REJECTED = new OutboundCrossClusterSearchConnectionStatusCode("REJECTED");
        /// <summary>
        /// Constant VALIDATING for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode VALIDATING = new OutboundCrossClusterSearchConnectionStatusCode("VALIDATING");
        /// <summary>
        /// Constant VALIDATION_FAILED for OutboundCrossClusterSearchConnectionStatusCode
        /// </summary>
        public static readonly OutboundCrossClusterSearchConnectionStatusCode VALIDATION_FAILED = new OutboundCrossClusterSearchConnectionStatusCode("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutboundCrossClusterSearchConnectionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutboundCrossClusterSearchConnectionStatusCode FindValue(string value)
        {
            return FindValue<OutboundCrossClusterSearchConnectionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutboundCrossClusterSearchConnectionStatusCode(string value)
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
    /// Constants used for properties of type ReservedElasticsearchInstancePaymentOption.
    /// </summary>
    public class ReservedElasticsearchInstancePaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL_UPFRONT for ReservedElasticsearchInstancePaymentOption
        /// </summary>
        public static readonly ReservedElasticsearchInstancePaymentOption ALL_UPFRONT = new ReservedElasticsearchInstancePaymentOption("ALL_UPFRONT");
        /// <summary>
        /// Constant NO_UPFRONT for ReservedElasticsearchInstancePaymentOption
        /// </summary>
        public static readonly ReservedElasticsearchInstancePaymentOption NO_UPFRONT = new ReservedElasticsearchInstancePaymentOption("NO_UPFRONT");
        /// <summary>
        /// Constant PARTIAL_UPFRONT for ReservedElasticsearchInstancePaymentOption
        /// </summary>
        public static readonly ReservedElasticsearchInstancePaymentOption PARTIAL_UPFRONT = new ReservedElasticsearchInstancePaymentOption("PARTIAL_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservedElasticsearchInstancePaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservedElasticsearchInstancePaymentOption FindValue(string value)
        {
            return FindValue<ReservedElasticsearchInstancePaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservedElasticsearchInstancePaymentOption(string value)
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

}