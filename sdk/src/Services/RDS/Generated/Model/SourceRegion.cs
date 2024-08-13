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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains an Amazon Web Services Region name as the result of a successful call to
    /// the <c>DescribeSourceRegions</c> action.
    /// </summary>
    public partial class SourceRegion
    {
        private string _endpoint;
        private string _regionName;
        private string _status;
        private bool? _supportsDBInstanceAutomatedBackupsReplication;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for the source Amazon Web Services Region endpoint.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the source Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the source Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportsDBInstanceAutomatedBackupsReplication. 
        /// <para>
        /// Indicates whether the source Amazon Web Services Region supports replicating automated
        /// backups to the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        public bool? SupportsDBInstanceAutomatedBackupsReplication
        {
            get { return this._supportsDBInstanceAutomatedBackupsReplication; }
            set { this._supportsDBInstanceAutomatedBackupsReplication = value; }
        }

        // Check to see if SupportsDBInstanceAutomatedBackupsReplication property is set
        internal bool IsSetSupportsDBInstanceAutomatedBackupsReplication()
        {
            return this._supportsDBInstanceAutomatedBackupsReplication.HasValue; 
        }

    }
}