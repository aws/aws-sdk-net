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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Contains the Snowflake-specific settings to update on an existing connection. Include
    /// only the fields you want to change.
    /// </summary>
    public partial class SnowflakePropertiesPatch
    {
        private ConnectivityPropertiesPatch _connectivityPropertiesPatch;
        private LineageSyncInput _lineageSync;
        private string _snowflakeRole;

        /// <summary>
        /// Gets and sets the property ConnectivityPropertiesPatch. 
        /// <para>
        /// The connectivity properties patch of the Snowflake connection.
        /// </para>
        /// </summary>
        public ConnectivityPropertiesPatch ConnectivityPropertiesPatch
        {
            get { return this._connectivityPropertiesPatch; }
            set { this._connectivityPropertiesPatch = value; }
        }

        // Check to see if ConnectivityPropertiesPatch property is set
        internal bool IsSetConnectivityPropertiesPatch()
        {
            return this._connectivityPropertiesPatch != null;
        }

        /// <summary>
        /// Gets and sets the property LineageSync. 
        /// <para>
        /// The lineage sync configuration for the Snowflake connection.
        /// </para>
        /// </summary>
        public LineageSyncInput LineageSync
        {
            get { return this._lineageSync; }
            set { this._lineageSync = value; }
        }

        // Check to see if LineageSync property is set
        internal bool IsSetLineageSync()
        {
            return this._lineageSync != null;
        }

        /// <summary>
        /// Gets and sets the property SnowflakeRole. 
        /// <para>
        /// The Snowflake role used to access Snowflake resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SnowflakeRole
        {
            get { return this._snowflakeRole; }
            set { this._snowflakeRole = value; }
        }

        // Check to see if SnowflakeRole property is set
        internal bool IsSetSnowflakeRole()
        {
            return this._snowflakeRole != null;
        }

    }
}