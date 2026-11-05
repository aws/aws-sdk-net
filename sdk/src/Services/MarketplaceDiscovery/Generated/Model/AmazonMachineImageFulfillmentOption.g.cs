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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Describes an Amazon Machine Image (AMI) fulfillment option, including version details,
    /// supported operating systems, and recommended instance types.
    /// </summary>
    public partial class AmazonMachineImageFulfillmentOption
    {
        /// <summary>
        /// Gets and sets the property AccessUrlTemplate. 
        /// <para>
        /// The URL pattern for accessing the product when an instance is running.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string AccessUrlTemplate { get; set; }

        /// <summary>
        /// Checks to see if the AccessUrlTemplate property is set.
        /// </summary>
        internal bool IsSetAccessUrlTemplate() => this.AccessUrlTemplate != null;

        /// <summary>
        /// Gets and sets the property AmiAlias. 
        /// <para>
        /// The alias of the AMI associated with this fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string AmiAlias { get; set; }

        /// <summary>
        /// Checks to see if the AmiAlias property is set.
        /// </summary>
        internal bool IsSetAmiAlias() => this.AmiAlias != null;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the AMI, such as <c>x86_64</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property AvailableFromTime. 
        /// <para>
        /// The date and time when the AMI became available for fulfillment.
        /// </para>
        /// </summary>
        public DateTime? AvailableFromTime { get; set; }

        /// <summary>
        /// Checks to see if the AvailableFromTime property is set.
        /// </summary>
        internal bool IsSetAvailableFromTime() => this.AvailableFromTime.HasValue;

        /// <summary>
        /// Gets and sets the property EbsVolume. 
        /// <para>
        /// The supported Amazon EBS volume configuration for the AMI.
        /// </para>
        /// </summary>
        public AmazonMachineImageEbsVolume EbsVolume { get; set; }

        /// <summary>
        /// Checks to see if the EbsVolume property is set.
        /// </summary>
        internal bool IsSetEbsVolume() => this.EbsVolume != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionDisplayName. 
        /// <para>
        /// A human-readable name for the fulfillment option type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FulfillmentOptionDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionDisplayName property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionDisplayName() => this.FulfillmentOptionDisplayName != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionId. 
        /// <para>
        /// The unique identifier of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FulfillmentOptionId { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionId property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionId() => this.FulfillmentOptionId != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionName. 
        /// <para>
        /// The display name of the fulfillment option version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FulfillmentOptionName { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionName property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionName() => this.FulfillmentOptionName != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionType. 
        /// <para>
        /// The category of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FulfillmentOptionType FulfillmentOptionType { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionType property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionType() => this.FulfillmentOptionType != null;

        /// <summary>
        /// Gets and sets the property FulfillmentOptionVersion. 
        /// <para>
        /// The version identifier of the fulfillment option.
        /// </para>
        /// </summary>
        public string FulfillmentOptionVersion { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentOptionVersion property is set.
        /// </summary>
        internal bool IsSetFulfillmentOptionVersion() => this.FulfillmentOptionVersion != null;

        /// <summary>
        /// Gets and sets the property OperatingSystems. 
        /// <para>
        /// The operating systems supported by this AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AmazonMachineImageOperatingSystem> OperatingSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<AmazonMachineImageOperatingSystem>() : null;

        /// <summary>
        /// Checks to see if the OperatingSystems property is set.
        /// </summary>
        internal bool IsSetOperatingSystems() => this.OperatingSystems != null && (this.OperatingSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// Recommended instance types for running this AMI.
        /// </para>
        /// </summary>
        public AmazonMachineImageRecommendation Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property ReleaseNotes. 
        /// <para>
        /// Release notes describing changes in this version of the fulfillment option.
        /// </para>
        /// </summary>
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseNotes property is set.
        /// </summary>
        internal bool IsSetReleaseNotes() => this.ReleaseNotes != null;

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A short description of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 4096)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Instructions on how to deploy and use this fulfillment option.
        /// </para>
        /// </summary>
        public string UsageInstructions { get; set; }

        /// <summary>
        /// Checks to see if the UsageInstructions property is set.
        /// </summary>
        internal bool IsSetUsageInstructions() => this.UsageInstructions != null;
    }
}
