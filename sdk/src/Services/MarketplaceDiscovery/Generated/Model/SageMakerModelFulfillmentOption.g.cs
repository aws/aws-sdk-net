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
    /// Describes an Amazon SageMaker model fulfillment option, including version details
    /// and recommended instance types.
    /// </summary>
    public partial class SageMakerModelFulfillmentOption
    {
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
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// Recommended instance types for inference with this model.
        /// </para>
        /// </summary>
        public SageMakerModelRecommendation Recommendation { get; set; }

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
        /// Gets and sets the property SupportedContentTypes. 
        /// <para>
        /// The MIME types that this model accepts as input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> SupportedContentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedContentTypes property is set.
        /// </summary>
        internal bool IsSetSupportedContentTypes() => this.SupportedContentTypes != null && (this.SupportedContentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedResponseMimeTypes. 
        /// <para>
        /// The MIME types that this model returns as output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> SupportedResponseMimeTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedResponseMimeTypes property is set.
        /// </summary>
        internal bool IsSetSupportedResponseMimeTypes() => this.SupportedResponseMimeTypes != null && (this.SupportedResponseMimeTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageInstructions. 
        /// <para>
        /// Instructions on how to use this SageMaker model.
        /// </para>
        /// </summary>
        public string UsageInstructions { get; set; }

        /// <summary>
        /// Checks to see if the UsageInstructions property is set.
        /// </summary>
        internal bool IsSetUsageInstructions() => this.UsageInstructions != null;
    }
}
