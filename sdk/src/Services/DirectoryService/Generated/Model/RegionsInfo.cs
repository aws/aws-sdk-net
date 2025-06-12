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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Provides information about the Regions that are configured for multi-Region replication.
    /// </summary>
    public partial class RegionsInfo
    {
        private List<string> _additionalRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _primaryRegion;

        /// <summary>
        /// Gets and sets the property AdditionalRegions. 
        /// <para>
        /// Lists the Regions where the directory has been replicated, excluding the primary Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalRegions
        {
            get { return this._additionalRegions; }
            set { this._additionalRegions = value; }
        }

        // Check to see if AdditionalRegions property is set
        internal bool IsSetAdditionalRegions()
        {
            return this._additionalRegions != null && (this._additionalRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The Region where the Managed Microsoft AD directory was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=32)]
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

    }
}