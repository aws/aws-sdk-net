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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// This is the response object from the CreateBrandProfile operation.
    /// </summary>
    public partial class CreateBrandProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttributesCreated. 
        /// <para>
        /// The number of default attributes that were created for the brand profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AttributesCreated { get; set; }

        /// <summary>
        /// Checks to see if the AttributesCreated property is set.
        /// </summary>
        internal bool IsSetAttributesCreated() => this.AttributesCreated.HasValue;

        /// <summary>
        /// Gets and sets the property BrandProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the brand profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 256)]
        public string BrandProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the BrandProfileArn property is set.
        /// </summary>
        internal bool IsSetBrandProfileArn() => this.BrandProfileArn != null;

        /// <summary>
        /// Gets and sets the property BrandProfileId. 
        /// <para>
        /// The unique identifier of the brand profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string BrandProfileId { get; set; }

        /// <summary>
        /// Checks to see if the BrandProfileId property is set.
        /// </summary>
        internal bool IsSetBrandProfileId() => this.BrandProfileId != null;

        /// <summary>
        /// Gets and sets the property BrandProfileName. 
        /// <para>
        /// The name of the brand profile. The name can contain alphanumeric characters, underscores,
        /// hyphens, and spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string BrandProfileName { get; set; }

        /// <summary>
        /// Checks to see if the BrandProfileName property is set.
        /// </summary>
        internal bool IsSetBrandProfileName() => this.BrandProfileName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the resource was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Specifies whether deletion protection is enabled. When enabled, the resource cannot
        /// be deleted until deletion protection is turned off.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle status of the brand profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
