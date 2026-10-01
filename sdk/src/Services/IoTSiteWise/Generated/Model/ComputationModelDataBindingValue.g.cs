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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains computation model data binding value information, which can be one of <c>assetModelProperty</c>,
    /// <c>list</c>.
    /// </summary>
    public partial class ComputationModelDataBindingValue
    {
        /// <summary>
        /// Gets and sets the property AssetModelProperty. 
        /// <para>
        /// Specifies an asset model property data binding value.
        /// </para>
        /// </summary>
        public AssetModelPropertyBindingValue AssetModelProperty { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelProperty property is set.
        /// </summary>
        internal bool IsSetAssetModelProperty() => this.AssetModelProperty != null;

        /// <summary>
        /// Gets and sets the property AssetProperty. 
        /// <para>
        /// The asset property value used for computation model data binding.
        /// </para>
        /// </summary>
        public AssetPropertyBindingValue AssetProperty { get; set; }

        /// <summary>
        /// Checks to see if the AssetProperty property is set.
        /// </summary>
        internal bool IsSetAssetProperty() => this.AssetProperty != null;

        /// <summary>
        /// Gets and sets the property List. 
        /// <para>
        /// Specifies a list of data binding value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComputationModelDataBindingValue> List { get; set; } = AWSConfigs.InitializeCollections ? new List<ComputationModelDataBindingValue>() : null;

        /// <summary>
        /// Checks to see if the List property is set.
        /// </summary>
        internal bool IsSetList() => this.List != null && (this.List.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
