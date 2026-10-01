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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Contains the Snowflake-specific settings required when creating or updating a connection,
    /// including the Snowflake role, identity mapping, and lineage sync configuration.
    /// </summary>
    public partial class SnowflakePropertiesInput
    {
        /// <summary>
        /// Gets and sets the property ConnectivityProperties. 
        /// <para>
        /// The connectivity properties of the Snowflake connection.
        /// </para>
        /// </summary>
        public ConnectivityProperties ConnectivityProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityProperties property is set.
        /// </summary>
        internal bool IsSetConnectivityProperties() => this.ConnectivityProperties != null;

        /// <summary>
        /// Gets and sets the property IdentityMapping. 
        /// <para>
        /// The identity mapping configuration for the Snowflake connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdentityMapping IdentityMapping { get; set; }

        /// <summary>
        /// Checks to see if the IdentityMapping property is set.
        /// </summary>
        internal bool IsSetIdentityMapping() => this.IdentityMapping != null;

        /// <summary>
        /// Gets and sets the property LineageSync. 
        /// <para>
        /// The lineage sync configuration for the Snowflake connection.
        /// </para>
        /// </summary>
        public LineageSyncInput LineageSync { get; set; }

        /// <summary>
        /// Checks to see if the LineageSync property is set.
        /// </summary>
        internal bool IsSetLineageSync() => this.LineageSync != null;

        /// <summary>
        /// Gets and sets the property SnowflakeRole. 
        /// <para>
        /// The Snowflake role used to access Snowflake resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SnowflakeRole { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeRole property is set.
        /// </summary>
        internal bool IsSetSnowflakeRole() => this.SnowflakeRole != null;
    }
}
