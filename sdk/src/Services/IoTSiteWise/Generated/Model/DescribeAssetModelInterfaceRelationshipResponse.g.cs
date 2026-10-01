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
    /// This is the response object from the DescribeAssetModelInterfaceRelationship operation.
    /// </summary>
    public partial class DescribeAssetModelInterfaceRelationshipResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property HierarchyMappings. 
        /// <para>
        /// A list of hierarchy mappings between the interface asset model and the asset model
        /// where the interface is applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HierarchyMapping> HierarchyMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<HierarchyMapping>() : null;

        /// <summary>
        /// Checks to see if the HierarchyMappings property is set.
        /// </summary>
        internal bool IsSetHierarchyMappings() => this.HierarchyMappings != null && (this.HierarchyMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InterfaceAssetModelId. 
        /// <para>
        /// The ID of the interface asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InterfaceAssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceAssetModelId property is set.
        /// </summary>
        internal bool IsSetInterfaceAssetModelId() => this.InterfaceAssetModelId != null;

        /// <summary>
        /// Gets and sets the property PropertyMappings. 
        /// <para>
        /// A list of property mappings between the interface asset model and the asset model
        /// where the interface is applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PropertyMapping> PropertyMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<PropertyMapping>() : null;

        /// <summary>
        /// Checks to see if the PropertyMappings property is set.
        /// </summary>
        internal bool IsSetPropertyMappings() => this.PropertyMappings != null && (this.PropertyMappings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
