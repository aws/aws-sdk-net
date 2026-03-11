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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Type-specific filters for listing channel handshakes.
    /// </summary>
    public partial class ListChannelHandshakesTypeFilters
    {
        private ProgramManagementAccountTypeFilters _programManagementAccountTypeFilters;
        private RevokeServicePeriodTypeFilters _revokeServicePeriodTypeFilters;
        private StartServicePeriodTypeFilters _startServicePeriodTypeFilters;

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountTypeFilters. 
        /// <para>
        /// Filters specific to program management account handshakes.
        /// </para>
        /// </summary>
        public ProgramManagementAccountTypeFilters ProgramManagementAccountTypeFilters
        {
            get { return this._programManagementAccountTypeFilters; }
            set { this._programManagementAccountTypeFilters = value; }
        }

        // Check to see if ProgramManagementAccountTypeFilters property is set
        internal bool IsSetProgramManagementAccountTypeFilters()
        {
            return this._programManagementAccountTypeFilters != null;
        }

        /// <summary>
        /// Gets and sets the property RevokeServicePeriodTypeFilters. 
        /// <para>
        /// Filters specific to revoke service period handshakes.
        /// </para>
        /// </summary>
        public RevokeServicePeriodTypeFilters RevokeServicePeriodTypeFilters
        {
            get { return this._revokeServicePeriodTypeFilters; }
            set { this._revokeServicePeriodTypeFilters = value; }
        }

        // Check to see if RevokeServicePeriodTypeFilters property is set
        internal bool IsSetRevokeServicePeriodTypeFilters()
        {
            return this._revokeServicePeriodTypeFilters != null;
        }

        /// <summary>
        /// Gets and sets the property StartServicePeriodTypeFilters. 
        /// <para>
        /// Filters specific to start service period handshakes.
        /// </para>
        /// </summary>
        public StartServicePeriodTypeFilters StartServicePeriodTypeFilters
        {
            get { return this._startServicePeriodTypeFilters; }
            set { this._startServicePeriodTypeFilters = value; }
        }

        // Check to see if StartServicePeriodTypeFilters property is set
        internal bool IsSetStartServicePeriodTypeFilters()
        {
            return this._startServicePeriodTypeFilters != null;
        }

    }
}