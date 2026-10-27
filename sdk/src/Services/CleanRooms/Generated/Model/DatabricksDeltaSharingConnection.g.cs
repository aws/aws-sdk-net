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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Details about Delta Sharing Connector for Databricks
    /// </summary>
    public partial class DatabricksDeltaSharingConnection
    {
        /// <summary>
        /// Gets and sets the property DeltaShareEndpoint. 
        /// <para>
        /// The base URL of a Delta Sharing server that hosts shared datasets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1024)]
        public string DeltaShareEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DeltaShareEndpoint property is set.
        /// </summary>
        internal bool IsSetDeltaShareEndpoint() => this.DeltaShareEndpoint != null;

        /// <summary>
        /// Gets and sets the property ShareName. 
        /// <para>
        /// Name of the Share used for OpenSharing (Delta Sharing) the Databricks Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ShareName { get; set; }

        /// <summary>
        /// Checks to see if the ShareName property is set.
        /// </summary>
        internal bool IsSetShareName() => this.ShareName != null;
    }
}
