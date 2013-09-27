/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates a Spot Instance request.
    /// </summary>
    /// <remarks>
    /// Spot Instances are instances that Amazon EC2 starts on your behalf
    /// when the maximum price that you specify exceeds the current Spot Price.
    /// Amazon EC2 periodically sets the Spot Price based on available
    /// Spot Instance capacity and current Spot Instance requests.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class RequestSpotInstancesRequest : EC2Request
    {    
        private string spotPriceField;
        private Decimal? instanceCountField;
        private string typeField;
        private string validFromField;
        private string validUntilField;
        private string launchGroupField;
        private string availabilityZoneGroupField;
        private LaunchSpecification launchSpecificationField;

        /// <summary>
        /// The maximum price you will pay to launch one or more Spot Instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotPrice")]
        public string SpotPrice
        {
            get { return this.spotPriceField; }
            set { this.spotPriceField = value; }
        }

        /// <summary>
        /// Sets the maximum price you will pay to launch one or more Spot Instances.
        /// </summary>
        /// <param name="spotPrice">Specifies the maximum price you will pay to
        /// launch one or more Spot Instances.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithSpotPrice(string spotPrice)
        {
            this.spotPriceField = spotPrice;
            return this;
        }

        /// <summary>
        /// Checks if SpotPrice property is set
        /// </summary>
        /// <returns>true if SpotPrice property is set</returns>
        public bool IsSetSpotPrice()
        {
            return this.spotPriceField != null;
        }

        /// <summary>
        /// The maximum number of Spot Instances to launch.
        /// Default is 1.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCount")]
        public Decimal InstanceCount
        {
            get { return this.instanceCountField.GetValueOrDefault(); }
            set { this.instanceCountField = value; }
        }

        /// <summary>
        /// Sets the maximum number of Spot Instances to launch.
        /// </summary>
        /// <param name="instanceCount">The maximum number of Spot Instances to launch. Default - 1.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithInstanceCount(Decimal instanceCount)
        {
            this.instanceCountField = instanceCount;
            return this;
        }

        /// <summary>
        /// Checks if InstanceCount property is set
        /// </summary>
        /// <returns>true if InstanceCount property is set</returns>
        public bool IsSetInstanceCount()
        {
            return this.instanceCountField.HasValue;
        }

        /// <summary>
        /// The instance type.
        /// Valid values: m1.small|m1.medium|m1.large|m1.xlarge|c1.medium|c1.xlarge|m2.2xlarge|m4.4xlarge
        /// Default - m1.small.
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the instance type.
        /// </summary>
        /// <param name="type">The instance type. Valid values:
        /// m1.small|m1.medium|m1.large|m1.xlarge|c1.medium|c1.xlarge|m2.2xlarge|m4.4xlarge.
        /// Default - m1.small.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithType(string type)
        {
            this.typeField = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public bool IsSetType()
        {
            return this.typeField != null;
        }

        /// <summary>
        /// Start date of the request.
        /// If this is a one-time request, the request remains active until all instances
        /// launch, the request expires, or the request is canceled. If the
        /// request is persistent, it remains active until it expires or
        /// is canceled.
        /// Default: Request is effective immediately
        /// </summary>
        [XmlElementAttribute(ElementName = "ValidFrom")]
        public string ValidFrom
        {
            get { return this.validFromField; }
            set { this.validFromField = value; }
        }

        /// <summary>
        /// Sets the start date of the request.
        /// </summary>
        /// <param name="validFrom">Start date of the request. If this is a one-time request,
        /// the request remains active until all instances
        /// launch, the request expires, or the request is canceled. If the
        /// request is persistent, it remains active until it expires or
        /// is canceled.
        /// Default: Request is effective immediately</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithValidFrom(string validFrom)
        {
            this.validFromField = validFrom;
            return this;
        }

        /// <summary>
        /// Checks if ValidFrom property is set
        /// </summary>
        /// <returns>true if ValidFrom property is set</returns>
        public bool IsSetValidFrom()
        {
            return this.validFromField != null;
        }

        /// <summary>
        /// End date of the request.
        /// If this is a one-time request, the request remains active
        /// until all instances launch, the request expires, or the
        /// request is canceled. If the request is persistent, it remains
        /// active until it expires or is canceled.
        /// Default: Request remains open until criteria for closing are met
        /// </summary>
        [XmlElementAttribute(ElementName = "ValidUntil")]
        public string ValidUntil
        {
            get { return this.validUntilField; }
            set { this.validUntilField = value; }
        }

        /// <summary>
        /// Sets the end date of the request.
        /// </summary>
        /// <param name="validUntil">End date of the request. If this is a one-time request,
        /// the request remains active until all instances launch,
        /// the request expires, or the request is canceled. If the
        /// request is persistent, it remains active until it expires or
        /// is canceled.
        /// Default: Request remains open until criteria for closing are met</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithValidUntil(string validUntil)
        {
            this.validUntilField = validUntil;
            return this;
        }

        /// <summary>
        /// Checks if ValidUntil property is set
        /// </summary>
        /// <returns>true if ValidUntil property is set</returns>
        public bool IsSetValidUntil()
        {
            return this.validUntilField != null;
        }

        /// <summary>
        /// The instance launch group.
        /// Launch groups are Spot Instances that launch together and terminate
        /// together.
        /// Default: Instances are launched and terminated individually
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchGroup")]
        public string LaunchGroup
        {
            get { return this.launchGroupField; }
            set { this.launchGroupField = value; }
        }

        /// <summary>
        /// Sets the instance launch group.
        /// </summary>
        /// <param name="launchGroup">Specifies the instance launch group. Launch
        /// groups are Spot Instances that launch together and terminate
        /// together.
        /// Default: Instances are launched and terminated individually</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithLaunchGroup(string launchGroup)
        {
            this.launchGroupField = launchGroup;
            return this;
        }

        /// <summary>
        /// Checks if LaunchGroup property is set
        /// </summary>
        /// <returns>true if LaunchGroup property is set</returns>
        public bool IsSetLaunchGroup()
        {
            return this.launchGroupField != null;
        }

        /// <summary>
        /// The Availability Zone group.
        /// If you specify the same Availability Zone group for all
        /// Spot Instance requests, all Spot Instances are launched
        /// in the same Availability Zone.
        /// Default: Instances are launched in any available Availability Zone.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZoneGroup")]
        public string AvailabilityZoneGroup
        {
            get { return this.availabilityZoneGroupField; }
            set { this.availabilityZoneGroupField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone group.
        /// </summary>
        /// <param name="availabilityZoneGroup">Specifies the Availability Zone group. If you specify
        /// the same Availability Zone group for all Spot Instance
        /// requests, all Spot Instances are launched in the same
        /// Availability Zone.
        /// Default: Instances are launched in any available Availability Zone.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithAvailabilityZoneGroup(string availabilityZoneGroup)
        {
            this.availabilityZoneGroupField = availabilityZoneGroup;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZoneGroup property is set
        /// </summary>
        /// <returns>true if AvailabilityZoneGroup property is set</returns>
        public bool IsSetAvailabilityZoneGroup()
        {
            return this.availabilityZoneGroupField != null;
        }

        /// <summary>
        /// Additional launch instance information.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchSpecification")]
        public LaunchSpecification LaunchSpecification
        {
            get { return this.launchSpecificationField; }
            set { this.launchSpecificationField = value; }
        }

        /// <summary>
        /// Sets additional launch instance information.
        /// </summary>
        /// <param name="launchSpecification">Specifies additional launch instance information.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RequestSpotInstancesRequest WithLaunchSpecification(LaunchSpecification launchSpecification)
        {
            this.launchSpecificationField = launchSpecification;
            return this;
        }

        /// <summary>
        /// Checks if LaunchSpecification property is set
        /// </summary>
        /// <returns>true if LaunchSpecification property is set</returns>
        public bool IsSetLaunchSpecification()
        {
            return this.launchSpecificationField != null;
        }

    }
}
