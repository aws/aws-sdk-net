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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
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
namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Defines the structure for multi-Region cluster configurations, containing the witness
    /// region and linked cluster settings.
    /// </summary>
    public partial class MultiRegionProperties
    {
        private List<string> _clusters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _witnessRegion;

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// The set of linked clusters that form the multi-Region cluster configuration. Each
        /// linked cluster represents a database instance in a different Region.
        /// </para>
        /// </summary>
        public List<string> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && (this._clusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WitnessRegion. 
        /// <para>
        /// The that serves as the witness region for a multi-Region cluster. The witness region
        /// helps maintain cluster consistency and quorum.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string WitnessRegion
        {
            get { return this._witnessRegion; }
            set { this._witnessRegion = value; }
        }

        // Check to see if WitnessRegion property is set
        internal bool IsSetWitnessRegion()
        {
            return this._witnessRegion != null;
        }

    }
}