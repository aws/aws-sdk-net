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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// An `AssetLink` field's constraints.
    /// </summary>
    public partial class AssetLinkFieldType
    {
        /// <summary>
        /// Gets and sets the property Category. The category of asset the field may name. The
        /// value must be an asset of this category on the same campaign; list the candidates
        /// with `ListCampaignAssets`.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property LabelFieldId. The text field on the same asset whose copy
        /// names the linked asset, such as the "Solution Brief" in "Your Solution Brief is ready
        /// to download!". When the partner picks an asset, fill this field with the picked asset's
        /// `LinkLabel`, in a preview and in the same save, unless the partner has edited it.
        /// The field stays editable. The service does the same when a save changes the link without
        /// setting this field and the partner has never written it.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LabelFieldId { get; set; }

        /// <summary>
        /// Checks to see if the LabelFieldId property is set.
        /// </summary>
        internal bool IsSetLabelFieldId() => this.LabelFieldId != null;
    }
}
