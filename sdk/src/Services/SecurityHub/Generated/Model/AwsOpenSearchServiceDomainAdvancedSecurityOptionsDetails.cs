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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about domain access control options.
    /// </summary>
    public partial class AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetails
    {
        private bool? _enabled;
        private bool? _internalUserDatabaseEnabled;
        private AwsOpenSearchServiceDomainMasterUserOptionsDetails _masterUserOptions;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enables fine-grained access control. 
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
        /// Gets and sets the property InternalUserDatabaseEnabled. 
        /// <para>
        /// Enables the internal user database. 
        /// </para>
        /// </summary>
        public bool? InternalUserDatabaseEnabled
        {
            get { return this._internalUserDatabaseEnabled; }
            set { this._internalUserDatabaseEnabled = value; }
        }

        // Check to see if InternalUserDatabaseEnabled property is set
        internal bool IsSetInternalUserDatabaseEnabled()
        {
            return this._internalUserDatabaseEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUserOptions. 
        /// <para>
        /// Specifies information about the master user of the domain. 
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainMasterUserOptionsDetails MasterUserOptions
        {
            get { return this._masterUserOptions; }
            set { this._masterUserOptions = value; }
        }

        // Check to see if MasterUserOptions property is set
        internal bool IsSetMasterUserOptions()
        {
            return this._masterUserOptions != null;
        }

    }
}