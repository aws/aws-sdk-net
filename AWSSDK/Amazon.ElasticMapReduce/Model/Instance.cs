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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Represents an EC2 instance provisioned as part of cluster.
    /// </summary>
    public partial class Instance
    {
        private string _ec2InstanceId;
        private string _id;
        private string _privateDnsName;
        private string _privateIpAddress;
        private string _publicDnsName;
        private string _publicIpAddress;
        private InstanceStatus _status;


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


        /// <summary>
        /// Sets the Ec2InstanceId property
        /// </summary>
        /// <param name="ec2InstanceId">The value to set for the Ec2InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithEc2InstanceId(string ec2InstanceId)
        {
            this._ec2InstanceId = ec2InstanceId;
            return this;
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


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithId(string id)
        {
            this._id = id;
            return this;
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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


        /// <summary>
        /// Sets the PrivateDnsName property
        /// </summary>
        /// <param name="privateDnsName">The value to set for the PrivateDnsName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPrivateDnsName(string privateDnsName)
        {
            this._privateDnsName = privateDnsName;
            return this;
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


        /// <summary>
        /// Sets the PrivateIpAddress property
        /// </summary>
        /// <param name="privateIpAddress">The value to set for the PrivateIpAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPrivateIpAddress(string privateIpAddress)
        {
            this._privateIpAddress = privateIpAddress;
            return this;
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


        /// <summary>
        /// Sets the PublicDnsName property
        /// </summary>
        /// <param name="publicDnsName">The value to set for the PublicDnsName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPublicDnsName(string publicDnsName)
        {
            this._publicDnsName = publicDnsName;
            return this;
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


        /// <summary>
        /// Sets the PublicIpAddress property
        /// </summary>
        /// <param name="publicIpAddress">The value to set for the PublicIpAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPublicIpAddress(string publicIpAddress)
        {
            this._publicIpAddress = publicIpAddress;
            return this;
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


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithStatus(InstanceStatus status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}