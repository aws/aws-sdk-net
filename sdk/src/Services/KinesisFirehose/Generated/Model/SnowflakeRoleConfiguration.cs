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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Optionally configure a Snowflake role. Otherwise the default user role will be used.
    /// </summary>
    public partial class SnowflakeRoleConfiguration
    {
        private bool? _enabled;
        private string _snowflakeRole;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enable Snowflake role
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnowflakeRole. 
        /// <para>
        /// The Snowflake role you wish to configure
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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