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
    /// A multi-layout asset's layout choice: the selection, when made, and its options.
    /// </summary>
    public partial class CampaignAssetLayout
    {
        /// <summary>
        /// Gets and sets the property Options. Every option the asset was created with, in authored
        /// order.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public List<CampaignAssetLayoutOption> Options { get; set; } = AWSConfigs.InitializeCollections ? new List<CampaignAssetLayoutOption>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Selected. The selected option's value. An asset is created
        /// with its first option selected; an asset created before that rule, with none stored,
        /// reports and activates its first option.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Selected { get; set; }

        /// <summary>
        /// Checks to see if the Selected property is set.
        /// </summary>
        internal bool IsSetSelected() => this.Selected != null;
    }
}
