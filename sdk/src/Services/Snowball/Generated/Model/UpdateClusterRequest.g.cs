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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCluster operation. While a cluster's <c>ClusterState</c>
    /// value is in the <c>AwaitingQuorum</c> state, you can update some of the information
    /// associated with a cluster. Once the cluster changes to a different job state, usually
    /// 60 minutes after the cluster being created, this action is no longer available.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonSnowballRequest
    {
        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The ID of the updated <a>Address</a> object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string AddressId { get; set; }

        /// <summary>
        /// Checks to see if the AddressId property is set.
        /// </summary>
        internal bool IsSetAddressId() => this.AddressId != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The cluster ID of the cluster that you want to update, for example <c>CID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 39, Max = 39)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of this cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ForwardingAddressId. 
        /// <para>
        /// The updated ID for the forwarding address for a cluster. This field is not supported
        /// in most regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string ForwardingAddressId { get; set; }

        /// <summary>
        /// Checks to see if the ForwardingAddressId property is set.
        /// </summary>
        internal bool IsSetForwardingAddressId() => this.ForwardingAddressId != null;

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// The new or updated <a>Notification</a> object.
        /// </para>
        /// </summary>
        public Notification Notification { get; set; }

        /// <summary>
        /// Checks to see if the Notification property is set.
        /// </summary>
        internal bool IsSetNotification() => this.Notification != null;

        /// <summary>
        /// Gets and sets the property OnDeviceServiceConfiguration. 
        /// <para>
        /// Specifies the service or services on the Snow Family device that your transferred
        /// data will be exported from or imported into. Amazon Web Services Snow Family device
        /// clusters support Amazon S3 and NFS (Network File System).
        /// </para>
        /// </summary>
        public OnDeviceServiceConfiguration OnDeviceServiceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnDeviceServiceConfiguration property is set.
        /// </summary>
        internal bool IsSetOnDeviceServiceConfiguration() => this.OnDeviceServiceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The updated arrays of <a>JobResource</a> objects that can include updated <a>S3Resource</a>
        /// objects or <a>LambdaResource</a> objects.
        /// </para>
        /// </summary>
        public JobResource Resources { get; set; }

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The new role Amazon Resource Name (ARN) that you want to associate with this cluster.
        /// To create a role ARN, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
        /// API action in Identity and Access Management (IAM).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property ShippingOption. 
        /// <para>
        /// The updated shipping option value of this cluster's <a>ShippingDetails</a> object.
        /// </para>
        /// </summary>
        public ShippingOption ShippingOption { get; set; }

        /// <summary>
        /// Checks to see if the ShippingOption property is set.
        /// </summary>
        internal bool IsSetShippingOption() => this.ShippingOption != null;
    }
}
