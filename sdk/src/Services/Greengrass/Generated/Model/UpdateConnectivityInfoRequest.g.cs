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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectivityInfo operation. Updates the
    /// connectivity information for the core. Any devices that belong to the group which
    /// has this core will receive this information in order to find the location of the core
    /// and connect to it.
    /// </summary>
    public partial class UpdateConnectivityInfoRequest : AmazonGreengrassRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectivityInfo. A list of connectivity info.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectivityInfo> ConnectivityInfo { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectivityInfo>() : null;

        /// <summary>
        /// Checks to see if the ConnectivityInfo property is set.
        /// </summary>
        internal bool IsSetConnectivityInfo() => this.ConnectivityInfo != null && (this.ConnectivityInfo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThingName. The thing name.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;
    }
}
