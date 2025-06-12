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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
        private List<EbsVolume> _ebsVolumes = AWSConfigs.InitializeCollections ? new List<EbsVolume>() : null;
        private string _ec2InstanceId;
        private string _id;
        private string _instanceFleetId;
        private string _instanceGroupId;
        private string _instanceType;
        private MarketType _market;
        private string _privateDnsName;
        private string _privateIpAddress;
        private string _publicDnsName;
        private string _publicIpAddress;
        private InstanceStatus _status;

        /// <summary>
        /// Gets and sets the property EbsVolumes. 
        /// <para>
        /// The list of Amazon EBS volumes that are attached to this instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EbsVolume> EbsVolumes
        {
            get { return this._ebsVolumes; }
            set { this._ebsVolumes = value; }
        }

        // Check to see if EbsVolumes property is set
        internal bool IsSetEbsVolumes()
        {
            return this._ebsVolumes != null && (this._ebsVolumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The unique identifier of the instance in Amazon EC2.
        /// </para>
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this._ec2InstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the instance in Amazon EMR.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFleetId. 
        /// <para>
        /// The unique identifier of the instance fleet to which an Amazon EC2 instance belongs.
        /// </para>
        /// </summary>
        public string InstanceFleetId
        {
            get { return this._instanceFleetId; }
            set { this._instanceFleetId = value; }
        }

        // Check to see if InstanceFleetId property is set
        internal bool IsSetInstanceFleetId()
        {
            return this._instanceFleetId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// The identifier of the instance group to which this instance belongs.
        /// </para>
        /// </summary>
        public string InstanceGroupId
        {
            get { return this._instanceGroupId; }
            set { this._instanceGroupId = value; }
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this._instanceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type, for example <c>m3.xlarge</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// The instance purchasing option. Valid values are <c>ON_DEMAND</c> or <c>SPOT</c>.
        /// 
        /// </para>
        /// </summary>
        public MarketType Market
        {
            get { return this._market; }
            set { this._market = value; }
        }

        // Check to see if Market property is set
        internal bool IsSetMarket()
        {
            return this._market != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// The private DNS name of the instance.
        /// </para>
        /// </summary>
        public string PrivateDnsName
        {
            get { return this._privateDnsName; }
            set { this._privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this._privateDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address of the instance.
        /// </para>
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// The public DNS name of the instance.
        /// </para>
        /// </summary>
        public string PublicDnsName
        {
            get { return this._publicDnsName; }
            set { this._publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this._publicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The public IP address of the instance.
        /// </para>
        /// </summary>
        public string PublicIpAddress
        {
            get { return this._publicIpAddress; }
            set { this._publicIpAddress = value; }
        }

        // Check to see if PublicIpAddress property is set
        internal bool IsSetPublicIpAddress()
        {
            return this._publicIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instance.
        /// </para>
        /// </summary>
        public InstanceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}