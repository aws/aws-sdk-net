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
    /// A Spot Instance request
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class SpotInstanceRequest
    {    
        private string spotInstanceRequestIdField;
        private string spotPriceField;
        private string typeField;
        private string stateField;
        private SpotInstanceStateFault faultField;
        private SpotInstanceStatusMessage statusField;
        private string validFromField;
        private string validUntilField;
        private string launchGroupField;
        private string availabilityZoneGroupField;
        private LaunchSpecification launchSpecificationField;
        private string instanceIdField;
        private string createTimeField;
        private string productDescriptionField;
        private List<Tag> tagField;
        private string launchedAvailabilityZoneField;

        /// <summary>
        /// The ID of the SpotInstanceRequest.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotInstanceRequestId")]
        public string SpotInstanceRequestId
        {
            get { return this.spotInstanceRequestIdField; }
            set { this.spotInstanceRequestIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the SpotInstanceRequest.
        /// </summary>
        /// <param name="spotInstanceRequestId">The ID of the SpotInstanceRequest.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithSpotInstanceRequestId(string spotInstanceRequestId)
        {
            this.spotInstanceRequestIdField = spotInstanceRequestId;
            return this;
        }

        /// <summary>
        /// Checks if SpotInstanceRequestId property is set
        /// </summary>
        /// <returns>true if SpotInstanceRequestId property is set</returns>
        public bool IsSetSpotInstanceRequestId()
        {
            return this.spotInstanceRequestIdField != null;
        }

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
        public SpotInstanceRequest WithSpotPrice(string spotPrice)
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
        /// The instance type (eg. m1.small)
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the instance type (eg. m1.small)
        /// </summary>
        /// <param name="type">The instance type (eg. m1.small)</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithType(string type)
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
        /// The state of the Spot Instance request.
        /// Valid values: open | closed | cancelled | failed
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the state of the Spot Instance request.
        /// </summary>
        /// <param name="state">The state of the Spot Instance request.
        /// Valid values: open | closed | cancelled | failed</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return this.stateField != null;
        }

        /// <summary>
        /// Fault details for the Spot Instance request, if any.
        /// </summary>
        [XmlElementAttribute(ElementName = "Fault")]
        public SpotInstanceStateFault Fault
        {
            get { return this.faultField; }
            set { this.faultField = value; }
        }

        /// <summary>
        /// Sets the fault details for the Spot Instance request.
        /// </summary>
        /// <param name="fault">Fault details for the Spot Instance request, if any.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithFault(SpotInstanceStateFault fault)
        {
            this.faultField = fault;
            return this;
        }

        /// <summary>
        /// Checks if Fault property is set
        /// </summary>
        /// <returns>true if Fault property is set</returns>
        public bool IsSetFault()
        {
            return this.faultField != null;
        }


        /// <summary>
        /// Status details for the Spot Instance request, if any.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public SpotInstanceStatusMessage Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status details for the Spot Instance request.
        /// </summary>
        /// <param name="status">Status details for the Spot Instance request, if any.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithStatus(SpotInstanceStatusMessage status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }



        /// <summary>
        /// Start date of the request.
        /// If this is a one-time request, the request remains active until all instances
        /// launch, the request expires, or the request is canceled. If the request is
        /// persistent, it remains active until it expires or is canceled.
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
        /// <param name="validFrom">Start date of the request. If this is a
        /// one-time request, the request
        /// remains active until all instances
        /// launch, the request expires, or
        /// the request is canceled. If the
        /// request is persistent, it remains
        /// active until it expires or is
        /// canceled.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithValidFrom(string validFrom)
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
        /// If this is a one-time request, the request remains active until all
        /// instances launch, the request expires, or the request is canceled.
        /// If the request is persistent, it remains active until it expires or
        /// is canceled.
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
        /// <param name="validUntil">End date of the request. If this is a one-time
        /// request, the request
        /// remains active until all instances launch,
        /// the request expires, or
        /// the request is canceled. If the request is
        /// persistent, it remains
        /// active until it expires or is canceled.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithValidUntil(string validUntil)
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
        /// Launch groups are Spot Instances that launch and terminate together.
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
        /// <param name="launchGroup">Sets the instance launch group. Launch
        /// groups are Spot Instances that launch and terminate together.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithLaunchGroup(string launchGroup)
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
        /// If you specify the same Availability Zone group for all Spot Instance
        /// requests, all Spot Instances are launched in the same Availability Zone.
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
        /// <param name="availabilityZoneGroup">Specifies the Availability Zone group. If you
        /// specify the same Availability Zone group for
        /// all Spot Instance requests, all Spot
        /// Instances are launched in the same
        /// Availability Zone.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithAvailabilityZoneGroup(string availabilityZoneGroup)
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
        /// Sets the additional launch instance information.
        /// </summary>
        /// <param name="launchSpecification">Specifies additional launch instance
        /// information.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithLaunchSpecification(LaunchSpecification launchSpecification)
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

        /// <summary>
        /// The instance associated with the Spot Instance Request.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the instance associated with the Spot Instance Request.
        /// </summary>
        /// <param name="instanceId">The instance associated with the Spot Instance
        /// Request.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Time stamp when the Spot Instance request was fulfilled.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreateTime")]
        public string CreateTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
        }

        /// <summary>
        /// Sets the time stamp when the Spot Instance request was fulfilled.
        /// </summary>
        /// <param name="createTime">Time stamp when the Spot Instance request was
        /// fulfilled.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithCreateTime(string createTime)
        {
            this.createTimeField = createTime;
            return this;
        }

        /// <summary>
        /// Checks if CreateTime property is set
        /// </summary>
        /// <returns>true if CreateTime property is set</returns>
        public bool IsSetCreateTime()
        {
            return this.createTimeField != null;
        }

        /// <summary>
        /// The product description associated with the Spot Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductDescription")]
        public string ProductDescription
        {
            get { return this.productDescriptionField; }
            set { this.productDescriptionField = value; }
        }

        /// <summary>
        /// Sets the product description associated with the Spot Instance.
        /// </summary>
        /// <param name="productDescription">The product description associated with the
        /// Spot Instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithProductDescription(string productDescription)
        {
            this.productDescriptionField = productDescription;
            return this;
        }

        /// <summary>
        /// Checks if ProductDescription property is set
        /// </summary>
        /// <returns>true if ProductDescription property is set</returns>
        public bool IsSetProductDescription()
        {
            return this.productDescriptionField != null;
        }

        /// <summary>
        /// A list of tags for the specified resources.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the tags for the specified resources.
        /// </summary>
        /// <param name="list">A list of tags for the specified resources.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

        /// <summary>
        /// The Availability Zone in which the bid is launched.
        /// </summary>
        public string LaunchedAvailabilityZone
        {
            get { return this.launchedAvailabilityZoneField; }
            set { this.launchedAvailabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone in which the bid is launched.
        /// </summary>
        /// <param name="launchedAvailabilityZone">The Availability Zone in which the bid is launched.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SpotInstanceRequest WithLaunchedAvailabilityZone(string launchedAvailabilityZone)
        {
            this.launchedAvailabilityZoneField = launchedAvailabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if LaunchedAvailabilityZone property is set
        /// </summary>
        /// <returns>true if LaunchedAvailabilityZone property is set</returns>
        public bool IsSetLaunchedAvailabilityZone()
        {
            return this.launchedAvailabilityZoneField != null;
        }

    }
}
