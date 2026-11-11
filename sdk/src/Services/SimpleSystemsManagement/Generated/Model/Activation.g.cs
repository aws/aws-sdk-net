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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An activation registers one or more on-premises servers or virtual machines (VMs)
    /// with Amazon Web Services so that you can configure those servers or VMs using Run
    /// Command. A server or VM that has been registered with Amazon Web Services Systems
    /// Manager is called a managed node.
    /// </summary>
    public partial class Activation
    {
        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The ID created by Systems Manager when you submitted the activation.
        /// </para>
        /// </summary>
        public string ActivationId { get; set; }

        /// <summary>
        /// Checks to see if the ActivationId property is set.
        /// </summary>
        internal bool IsSetActivationId() => this.ActivationId != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the activation was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultInstanceName. 
        /// <para>
        /// A name for the managed node when it is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DefaultInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the DefaultInstanceName property is set.
        /// </summary>
        internal bool IsSetDefaultInstanceName() => this.DefaultInstanceName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user defined description of the activation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when this activation can no longer be used to register managed nodes.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Expired. 
        /// <para>
        /// Whether or not the activation is expired.
        /// </para>
        /// </summary>
        public bool? Expired { get; set; }

        /// <summary>
        /// Checks to see if the Expired property is set.
        /// </summary>
        internal bool IsSetExpired() => this.Expired.HasValue;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The Identity and Access Management (IAM) role to assign to the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string IamRole { get; set; }

        /// <summary>
        /// Checks to see if the IamRole property is set.
        /// </summary>
        internal bool IsSetIamRole() => this.IamRole != null;

        /// <summary>
        /// Gets and sets the property RegistrationLimit. 
        /// <para>
        /// The maximum number of managed nodes that can be registered using this activation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? RegistrationLimit { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationLimit property is set.
        /// </summary>
        internal bool IsSetRegistrationLimit() => this.RegistrationLimit.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrationsCount. 
        /// <para>
        /// The number of managed nodes already registered with this activation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? RegistrationsCount { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationsCount property is set.
        /// </summary>
        internal bool IsSetRegistrationsCount() => this.RegistrationsCount.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the activation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
