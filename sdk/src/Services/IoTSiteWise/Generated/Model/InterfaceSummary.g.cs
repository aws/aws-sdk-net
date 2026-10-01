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
    /// Contains summary information about an interface that a property belongs to.
    /// </summary>
    public partial class InterfaceSummary
    {
        /// <summary>
        /// Gets and sets the property InterfaceAssetModelId. 
        /// <para>
        /// The ID of the interface asset model that contains this property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InterfaceAssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceAssetModelId property is set.
        /// </summary>
        internal bool IsSetInterfaceAssetModelId() => this.InterfaceAssetModelId != null;

        /// <summary>
        /// Gets and sets the property InterfaceAssetModelPropertyId. 
        /// <para>
        /// The ID of the property in the interface asset model that corresponds to this property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InterfaceAssetModelPropertyId { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceAssetModelPropertyId property is set.
        /// </summary>
        internal bool IsSetInterfaceAssetModelPropertyId() => this.InterfaceAssetModelPropertyId != null;
    }
}
