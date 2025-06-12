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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// A configuration to store the Tickerplant logs. It consists of a list of volumes that
    /// will be mounted to your cluster. For the cluster type <c>Tickerplant</c>, the location
    /// of the TP volume on the cluster will be available by using the global variable <c>.aws.tp_log_path</c>.
    /// </summary>
    public partial class TickerplantLogConfiguration
    {
        private List<string> _tickerplantLogVolumes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TickerplantLogVolumes. 
        /// <para>
        ///  The name of the volumes for tickerplant logs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TickerplantLogVolumes
        {
            get { return this._tickerplantLogVolumes; }
            set { this._tickerplantLogVolumes = value; }
        }

        // Check to see if TickerplantLogVolumes property is set
        internal bool IsSetTickerplantLogVolumes()
        {
            return this._tickerplantLogVolumes != null && (this._tickerplantLogVolumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}