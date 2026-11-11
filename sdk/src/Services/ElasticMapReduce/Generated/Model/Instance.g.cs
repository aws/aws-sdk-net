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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Represents an Amazon EC2 instance provisioned as part of cluster.
    /// </summary>
    public partial class Instance
    {
        /// <summary>
        /// Gets and sets the property EbsVolumes. 
        /// <para>
        /// The list of Amazon EBS volumes that are attached to this instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EbsVolume> EbsVolumes { get; set; } = AWSConfigs.InitializeCollections ? new List<EbsVolume>() : null;

        /// <summary>
        /// Checks to see if the EbsVolumes property is set.
        /// </summary>
        internal bool IsSetEbsVolumes() => this.EbsVolumes != null && (this.EbsVolumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The unique identifier of the instance in Amazon EC2.
        /// </para>
        /// </summary>
        public string Ec2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceId property is set.
        /// </summary>
        internal bool IsSetEc2InstanceId() => this.Ec2InstanceId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the instance in Amazon EMR.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceFleetId. 
        /// <para>
        /// The unique identifier of the instance fleet to which an Amazon EC2 instance belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InstanceFleetId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFleetId property is set.
        /// </summary>
        internal bool IsSetInstanceFleetId() => this.InstanceFleetId != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// The identifier of the instance group to which this instance belongs.
        /// </para>
        /// </summary>
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupId property is set.
        /// </summary>
        internal bool IsSetInstanceGroupId() => this.InstanceGroupId != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type, for example <c>m3.xlarge</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// The instance purchasing option. Valid values are <c>ON_DEMAND</c> or <c>SPOT</c>.
        /// 
        /// </para>
        /// </summary>
        public MarketType Market { get; set; }

        /// <summary>
        /// Checks to see if the Market property is set.
        /// </summary>
        internal bool IsSetMarket() => this.Market != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// The private DNS name of the instance.
        /// </para>
        /// </summary>
        public string PrivateDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsName property is set.
        /// </summary>
        internal bool IsSetPrivateDnsName() => this.PrivateDnsName != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address of the instance.
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// The public DNS name of the instance.
        /// </para>
        /// </summary>
        public string PublicDnsName { get; set; }

        /// <summary>
        /// Checks to see if the PublicDnsName property is set.
        /// </summary>
        internal bool IsSetPublicDnsName() => this.PublicDnsName != null;

        /// <summary>
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The public IP address of the instance.
        /// </para>
        /// </summary>
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpAddress property is set.
        /// </summary>
        internal bool IsSetPublicIpAddress() => this.PublicIpAddress != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instance.
        /// </para>
        /// </summary>
        public InstanceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
