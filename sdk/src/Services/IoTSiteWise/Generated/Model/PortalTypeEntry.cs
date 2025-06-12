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
    /// The configuration entry associated with the specific portal type. The <c>portalTypeConfiguration</c>
    /// is a map of the <c>portalTypeKey</c> to the <c>PortalTypeEntry</c>.
    /// </summary>
    public partial class PortalTypeEntry
    {
        private List<string> _portalTools = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PortalTools. 
        /// <para>
        /// The array of tools associated with the specified portal type. The possible values
        /// are <c>ASSISTANT</c> and <c>DASHBOARD</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PortalTools
        {
            get { return this._portalTools; }
            set { this._portalTools = value; }
        }

        // Check to see if PortalTools property is set
        internal bool IsSetPortalTools()
        {
            return this._portalTools != null && (this._portalTools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}