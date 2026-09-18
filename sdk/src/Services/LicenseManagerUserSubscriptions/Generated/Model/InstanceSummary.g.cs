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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Describes an EC2 instance providing user-based subscriptions.
    /// </summary>
    public partial class InstanceSummary
    {
        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// The <c>IdentityProvider</c> resource specifies details about the identity provider.
        /// </para>
        /// </summary>
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the EC2 instance, which provides user-based subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property LastStatusCheckDate. 
        /// <para>
        /// The date of the last status check.
        /// </para>
        /// </summary>
        public string LastStatusCheckDate { get; set; }

        /// <summary>
        /// Checks to see if the LastStatusCheckDate property is set.
        /// </summary>
        internal bool IsSetLastStatusCheckDate() => this.LastStatusCheckDate != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The AWS Account ID of the owner of this resource.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property Products. 
        /// <para>
        /// A list of provided user-based subscription products.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Products { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Products property is set.
        /// </summary>
        internal bool IsSetProducts() => this.Products != null && (this.Products.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an EC2 instance resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for an EC2 instance.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
