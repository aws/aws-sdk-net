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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ConfigService
{

    /// <summary>
    /// Constants used for properties of type ChronologicalOrder.
    /// </summary>
    public class ChronologicalOrder : ConstantClass
    {

        /// <summary>
        /// Constant Forward for ChronologicalOrder
        /// </summary>
        public static readonly ChronologicalOrder Forward = new ChronologicalOrder("Forward");
        /// <summary>
        /// Constant Reverse for ChronologicalOrder
        /// </summary>
        public static readonly ChronologicalOrder Reverse = new ChronologicalOrder("Reverse");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChronologicalOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChronologicalOrder FindValue(string value)
        {
            return FindValue<ChronologicalOrder>(value);
        }

        public static implicit operator ChronologicalOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationItemStatus.
    /// </summary>
    public class ConfigurationItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleted for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus Deleted = new ConfigurationItemStatus("Deleted");
        /// <summary>
        /// Constant Discovered for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus Discovered = new ConfigurationItemStatus("Discovered");
        /// <summary>
        /// Constant Failed for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus Failed = new ConfigurationItemStatus("Failed");
        /// <summary>
        /// Constant Ok for ConfigurationItemStatus
        /// </summary>
        public static readonly ConfigurationItemStatus Ok = new ConfigurationItemStatus("Ok");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ConfigurationItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationItemStatus FindValue(string value)
        {
            return FindValue<ConfigurationItemStatus>(value);
        }

        public static implicit operator ConfigurationItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryStatus.
    /// </summary>
    public class DeliveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failure for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus Failure = new DeliveryStatus("Failure");
        /// <summary>
        /// Constant Not_Applicable for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus Not_Applicable = new DeliveryStatus("Not_Applicable");
        /// <summary>
        /// Constant Success for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus Success = new DeliveryStatus("Success");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DeliveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStatus FindValue(string value)
        {
            return FindValue<DeliveryStatus>(value);
        }

        public static implicit operator DeliveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecorderStatus.
    /// </summary>
    public class RecorderStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failure for RecorderStatus
        /// </summary>
        public static readonly RecorderStatus Failure = new RecorderStatus("Failure");
        /// <summary>
        /// Constant Pending for RecorderStatus
        /// </summary>
        public static readonly RecorderStatus Pending = new RecorderStatus("Pending");
        /// <summary>
        /// Constant Success for RecorderStatus
        /// </summary>
        public static readonly RecorderStatus Success = new RecorderStatus("Success");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RecorderStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecorderStatus FindValue(string value)
        {
            return FindValue<RecorderStatus>(value);
        }

        public static implicit operator RecorderStatus(string value)
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
        /// Constant AWSCloudTrailTrail for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudTrailTrail = new ResourceType("AWS::CloudTrail::Trail");
        /// <summary>
        /// Constant AWSEC2CustomerGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2CustomerGateway = new ResourceType("AWS::EC2::CustomerGateway");
        /// <summary>
        /// Constant AWSEC2EIP for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2EIP = new ResourceType("AWS::EC2::EIP");
        /// <summary>
        /// Constant AWSEC2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Instance = new ResourceType("AWS::EC2::Instance");
        /// <summary>
        /// Constant AWSEC2InternetGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2InternetGateway = new ResourceType("AWS::EC2::InternetGateway");
        /// <summary>
        /// Constant AWSEC2NetworkAcl for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkAcl = new ResourceType("AWS::EC2::NetworkAcl");
        /// <summary>
        /// Constant AWSEC2NetworkInterface for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2NetworkInterface = new ResourceType("AWS::EC2::NetworkInterface");
        /// <summary>
        /// Constant AWSEC2RouteTable for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2RouteTable = new ResourceType("AWS::EC2::RouteTable");
        /// <summary>
        /// Constant AWSEC2SecurityGroup for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2SecurityGroup = new ResourceType("AWS::EC2::SecurityGroup");
        /// <summary>
        /// Constant AWSEC2Subnet for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Subnet = new ResourceType("AWS::EC2::Subnet");
        /// <summary>
        /// Constant AWSEC2Volume for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2Volume = new ResourceType("AWS::EC2::Volume");
        /// <summary>
        /// Constant AWSEC2VPC for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPC = new ResourceType("AWS::EC2::VPC");
        /// <summary>
        /// Constant AWSEC2VPNConnection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPNConnection = new ResourceType("AWS::EC2::VPNConnection");
        /// <summary>
        /// Constant AWSEC2VPNGateway for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2VPNGateway = new ResourceType("AWS::EC2::VPNGateway");

        /// <summary>
        /// Default Constructor
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

        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }

}