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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Configurations used to create a decoder manifest.
    /// </summary>
    public partial class CanDbcDefinition
    {
        /// <summary>
        /// Gets and sets the property CanDbcFiles. 
        /// <para>
        /// A list of DBC files. You can upload only one DBC file for each network interface and
        /// specify up to five (inclusive) files in the list. The DBC file can be a maximum size
        /// of 200 MB.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<MemoryStream> CanDbcFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<MemoryStream>() : null;

        /// <summary>
        /// Checks to see if the CanDbcFiles property is set.
        /// </summary>
        internal bool IsSetCanDbcFiles() => this.CanDbcFiles != null && (this.CanDbcFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// Contains information about a network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterface property is set.
        /// </summary>
        internal bool IsSetNetworkInterface() => this.NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property SignalsMap. 
        /// <para>
        /// Pairs every signal specified in your vehicle model with a signal decoder.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SignalsMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SignalsMap property is set.
        /// </summary>
        internal bool IsSetSignalsMap() => this.SignalsMap != null && (this.SignalsMap.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
