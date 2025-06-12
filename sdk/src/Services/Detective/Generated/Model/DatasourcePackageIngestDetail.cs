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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details about the data source packages ingested by your behavior graph.
    /// </summary>
    public partial class DatasourcePackageIngestDetail
    {
        private DatasourcePackageIngestState _datasourcePackageIngestState;
        private Dictionary<string, TimestampForCollection> _lastIngestStateChange = AWSConfigs.InitializeCollections ? new Dictionary<string, TimestampForCollection>() : null;

        /// <summary>
        /// Gets and sets the property DatasourcePackageIngestState. 
        /// <para>
        /// Details on which data source packages are ingested for a member account.
        /// </para>
        /// </summary>
        public DatasourcePackageIngestState DatasourcePackageIngestState
        {
            get { return this._datasourcePackageIngestState; }
            set { this._datasourcePackageIngestState = value; }
        }

        // Check to see if DatasourcePackageIngestState property is set
        internal bool IsSetDatasourcePackageIngestState()
        {
            return this._datasourcePackageIngestState != null;
        }

        /// <summary>
        /// Gets and sets the property LastIngestStateChange. 
        /// <para>
        /// The date a data source package was enabled for this account
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, TimestampForCollection> LastIngestStateChange
        {
            get { return this._lastIngestStateChange; }
            set { this._lastIngestStateChange = value; }
        }

        // Check to see if LastIngestStateChange property is set
        internal bool IsSetLastIngestStateChange()
        {
            return this._lastIngestStateChange != null && (this._lastIngestStateChange.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}