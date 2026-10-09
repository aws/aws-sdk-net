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
    /// Contains metadata about a specific cluster.
    /// </summary>
    public partial class ClusterMetadata
    {
        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The automatically generated ID for a specific address.
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
        /// The automatically generated ID for a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property ClusterState. 
        /// <para>
        /// The current status of the cluster.
        /// </para>
        /// </summary>
        public ClusterState ClusterState { get; set; }

        /// <summary>
        /// Checks to see if the ClusterState property is set.
        /// </summary>
        internal bool IsSetClusterState() => this.ClusterState != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date for this cluster.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description of the cluster.
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
        /// The ID of the address that you want a cluster shipped to, after it will be shipped
        /// to its primary address. This field is not supported in most regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string ForwardingAddressId { get; set; }

        /// <summary>
        /// Checks to see if the ForwardingAddressId property is set.
        /// </summary>
        internal bool IsSetForwardingAddressId() => this.ForwardingAddressId != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job for this cluster. Currently, the only job type supported for clusters
        /// is <c>LOCAL_USE</c>.
        /// </para>
        /// </summary>
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyARN. 
        /// <para>
        /// The <c>KmsKeyARN</c> Amazon Resource Name (ARN) associated with this cluster. This
        /// ARN was created using the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// API action in Key Management Service (KMS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string KmsKeyARN { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyARN property is set.
        /// </summary>
        internal bool IsSetKmsKeyARN() => this.KmsKeyARN != null;

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// The Amazon Simple Notification Service (Amazon SNS) notification settings for this
        /// cluster.
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
        /// Represents metadata and configuration settings for services on an Amazon Web Services
        /// Snow Family device.
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
        /// The arrays of <a>JobResource</a> objects that can include updated <a>S3Resource</a>
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
        /// The role ARN associated with this cluster. This ARN was created using the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
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
        /// The shipping speed for each node in this cluster. This speed doesn't dictate how soon
        /// you'll get each device, rather it represents how quickly each device moves to its
        /// destination while in transit. Regional shipping speeds are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In Australia, you have access to express shipping. Typically, devices shipped express
        /// are delivered in about a day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the European Union (EU), you have access to express shipping. Typically, Snow devices
        /// shipped express are delivered in about a day. In addition, most countries in the EU
        /// have access to standard shipping, which typically takes less than a week, one way.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In India, Snow devices are delivered in one to seven days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the US, you have access to one-day shipping and two-day shipping.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ShippingOption ShippingOption { get; set; }

        /// <summary>
        /// Checks to see if the ShippingOption property is set.
        /// </summary>
        internal bool IsSetShippingOption() => this.ShippingOption != null;

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of Snowball Edge device to use for this cluster. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For cluster jobs, Amazon Web Services Snow Family currently supports only the <c>EDGE</c>
        /// device type.
        /// </para>
        ///  </note>
        /// </summary>
        public SnowballType SnowballType { get; set; }

        /// <summary>
        /// Checks to see if the SnowballType property is set.
        /// </summary>
        internal bool IsSetSnowballType() => this.SnowballType != null;

        /// <summary>
        /// Gets and sets the property TaxDocuments. 
        /// <para>
        /// The tax documents required in your Amazon Web Services Region.
        /// </para>
        /// </summary>
        public TaxDocuments TaxDocuments { get; set; }

        /// <summary>
        /// Checks to see if the TaxDocuments property is set.
        /// </summary>
        internal bool IsSetTaxDocuments() => this.TaxDocuments != null;
    }
}
