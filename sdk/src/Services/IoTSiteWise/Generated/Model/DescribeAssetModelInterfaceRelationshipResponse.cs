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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
        private string _assetModelId;
        private List<HierarchyMapping> _hierarchyMappings = AWSConfigs.InitializeCollections ? new List<HierarchyMapping>() : null;
        private string _interfaceAssetModelId;
        private List<PropertyMapping> _propertyMappings = AWSConfigs.InitializeCollections ? new List<PropertyMapping>() : null;

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetModelId
        {
            get { return this._assetModelId; }
            set { this._assetModelId = value; }
        }

        // Check to see if AssetModelId property is set
        internal bool IsSetAssetModelId()
        {
            return this._assetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchyMappings. 
        /// <para>
        /// A list of hierarchy mappings between the interface asset model and the asset model
        /// where the interface is applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HierarchyMapping> HierarchyMappings
        {
            get { return this._hierarchyMappings; }
            set { this._hierarchyMappings = value; }
        }

        // Check to see if HierarchyMappings property is set
        internal bool IsSetHierarchyMappings()
        {
            return this._hierarchyMappings != null && (this._hierarchyMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InterfaceAssetModelId. 
        /// <para>
        /// The ID of the interface asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InterfaceAssetModelId
        {
            get { return this._interfaceAssetModelId; }
            set { this._interfaceAssetModelId = value; }
        }

        // Check to see if InterfaceAssetModelId property is set
        internal bool IsSetInterfaceAssetModelId()
        {
            return this._interfaceAssetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyMappings. 
        /// <para>
        /// A list of property mappings between the interface asset model and the asset model
        /// where the interface is applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PropertyMapping> PropertyMappings
        {
            get { return this._propertyMappings; }
            set { this._propertyMappings = value; }
        }

        // Check to see if PropertyMappings property is set
        internal bool IsSetPropertyMappings()
        {
            return this._propertyMappings != null && (this._propertyMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}