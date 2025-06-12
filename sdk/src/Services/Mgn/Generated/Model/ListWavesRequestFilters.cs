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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Waves list filters.
    /// </summary>
    public partial class ListWavesRequestFilters
    {
        private bool? _isArchived;
        private List<string> _waveiDs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Filter waves list by archival status.
        /// </para>
        /// </summary>
        public bool? IsArchived
        {
            get { return this._isArchived; }
            set { this._isArchived = value; }
        }

        // Check to see if IsArchived property is set
        internal bool IsSetIsArchived()
        {
            return this._isArchived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WaveIDs. 
        /// <para>
        /// Filter waves list by wave ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> WaveIDs
        {
            get { return this._waveiDs; }
            set { this._waveiDs = value; }
        }

        // Check to see if WaveIDs property is set
        internal bool IsSetWaveIDs()
        {
            return this._waveiDs != null && (this._waveiDs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}