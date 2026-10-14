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
    /// Container for the parameters to the UpdateJob operation. While a job's <c>JobState</c>
    /// value is <c>New</c>, you can update some of the information associated with a job.
    /// Once the job changes to a different job state, usually within 60 minutes of the job
    /// being created, this action is no longer available.
    /// </summary>
    public partial class UpdateJobRequest : AmazonSnowballRequest
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of this job's <a>JobMetadata</a> object.
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
        /// The updated ID for the forwarding address for a job. This field is not supported in
        /// most regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string ForwardingAddressId { get; set; }

        /// <summary>
        /// Checks to see if the ForwardingAddressId property is set.
        /// </summary>
        internal bool IsSetForwardingAddressId() => this.ForwardingAddressId != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID of the job that you want to update, for example <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 39, Max = 39)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

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
        /// data will be exported from or imported into. Amazon Web Services Snow Family supports
        /// Amazon S3 and NFS (Network File System) and the Amazon Web Services Storage Gateway
        /// service Tape Gateway type.
        /// </para>
        /// </summary>
        public OnDeviceServiceConfiguration OnDeviceServiceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnDeviceServiceConfiguration property is set.
        /// </summary>
        internal bool IsSetOnDeviceServiceConfiguration() => this.OnDeviceServiceConfiguration != null;

        /// <summary>
        /// Gets and sets the property PickupDetails.
        /// </summary>
        public PickupDetails PickupDetails { get; set; }

        /// <summary>
        /// Checks to see if the PickupDetails property is set.
        /// </summary>
        internal bool IsSetPickupDetails() => this.PickupDetails != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The updated <c>JobResource</c> object, or the updated <a>JobResource</a> object. 
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
        /// The new role Amazon Resource Name (ARN) that you want to associate with this job.
        /// To create a role ARN, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>Identity
        /// and Access Management (IAM) API action.
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
        /// The updated shipping option value of this job's <a>ShippingDetails</a> object.
        /// </para>
        /// </summary>
        public ShippingOption ShippingOption { get; set; }

        /// <summary>
        /// Checks to see if the ShippingOption property is set.
        /// </summary>
        internal bool IsSetShippingOption() => this.ShippingOption != null;

        /// <summary>
        /// Gets and sets the property SnowballCapacityPreference. 
        /// <para>
        /// The updated <c>SnowballCapacityPreference</c> of this job's <a>JobMetadata</a> object.
        /// The 50 TB Snowballs are only available in the US regions.
        /// </para>
        ///  
        /// <para>
        /// For more information, see "https://docs.aws.amazon.com/snowball/latest/snowcone-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i> or "https://docs.aws.amazon.com/snowball/latest/developer-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i>.
        /// </para>
        /// </summary>
        public SnowballCapacity SnowballCapacityPreference { get; set; }

        /// <summary>
        /// Checks to see if the SnowballCapacityPreference property is set.
        /// </summary>
        internal bool IsSetSnowballCapacityPreference() => this.SnowballCapacityPreference != null;
    }
}
