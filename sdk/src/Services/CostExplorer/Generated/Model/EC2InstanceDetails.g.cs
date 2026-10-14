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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details about the Amazon EC2 reservations that Amazon Web Services recommends that
    /// you purchase.
    /// </summary>
    public partial class EC2InstanceDetails
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the recommended reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Determines whether the recommendation is for a current-generation instance. 
        /// </para>
        /// </summary>
        public bool? CurrentGeneration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentGeneration property is set.
        /// </summary>
        internal bool IsSetCurrentGeneration() => this.CurrentGeneration.HasValue;

        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        /// The instance family of the recommended reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Family { get; set; }

        /// <summary>
        /// Checks to see if the Family property is set.
        /// </summary>
        internal bool IsSetFamily() => this.Family != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance that Amazon Web Services recommends.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the recommended reservation. The platform is the specific combination
        /// of operating system, license model, and software on an instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the recommended reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SizeFlexEligible. 
        /// <para>
        /// Determines whether the recommended reservation is size flexible.
        /// </para>
        /// </summary>
        public bool? SizeFlexEligible { get; set; }

        /// <summary>
        /// Checks to see if the SizeFlexEligible property is set.
        /// </summary>
        internal bool IsSetSizeFlexEligible() => this.SizeFlexEligible.HasValue;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Determines whether the recommended reservation is dedicated or shared.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
