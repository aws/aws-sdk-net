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
    /// Maps a hierarchy from an interface asset model to a hierarchy in the asset model where
    /// the interface is applied.
    /// </summary>
    public partial class HierarchyMapping
    {
        /// <summary>
        /// Gets and sets the property AssetModelHierarchyId. 
        /// <para>
        /// The ID of the hierarchy in the asset model where the interface is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetModelHierarchyId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelHierarchyId property is set.
        /// </summary>
        internal bool IsSetAssetModelHierarchyId() => this.AssetModelHierarchyId != null;

        /// <summary>
        /// Gets and sets the property InterfaceAssetModelHierarchyId. 
        /// <para>
        /// The ID of the hierarchy in the interface asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InterfaceAssetModelHierarchyId { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceAssetModelHierarchyId property is set.
        /// </summary>
        internal bool IsSetInterfaceAssetModelHierarchyId() => this.InterfaceAssetModelHierarchyId != null;
    }
}
