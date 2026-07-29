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
    /// Contains the Snowflake-specific settings returned for an existing connection, including
    /// the current role, identity mapping, lineage sync state, and connection status.
    /// </summary>
    public partial class SnowflakePropertiesOutput
    {
        private string _errorMessage;
        private IdentityMapping _identityMapping;
        private LineageSyncOutput _lineageSync;
        private string _snowflakeRole;
        private ConnectionStatus _status;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message returned if the Snowflake connection failed to establish or validate.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityMapping. 
        /// <para>
        /// The identity mapping configuration for the Snowflake connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityMapping IdentityMapping
        {
            get { return this._identityMapping; }
            set { this._identityMapping = value; }
        }

        // Check to see if IdentityMapping property is set
        internal bool IsSetIdentityMapping()
        {
            return this._identityMapping != null;
        }

        /// <summary>
        /// Gets and sets the property LineageSync. 
        /// <para>
        /// The lineage sync configuration for the Snowflake connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LineageSyncOutput LineageSync
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Snowflake connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}