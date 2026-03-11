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
    /// Type-specific sorting options for listing channel handshakes.
    /// </summary>
    public partial class ListChannelHandshakesTypeSort
    {
        private ProgramManagementAccountTypeSort _programManagementAccountTypeSort;
        private RevokeServicePeriodTypeSort _revokeServicePeriodTypeSort;
        private StartServicePeriodTypeSort _startServicePeriodTypeSort;

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountTypeSort. 
        /// <para>
        /// Sorting options specific to program management account handshakes.
        /// </para>
        /// </summary>
        public ProgramManagementAccountTypeSort ProgramManagementAccountTypeSort
        {
            get { return this._programManagementAccountTypeSort; }
            set { this._programManagementAccountTypeSort = value; }
        }

        // Check to see if ProgramManagementAccountTypeSort property is set
        internal bool IsSetProgramManagementAccountTypeSort()
        {
            return this._programManagementAccountTypeSort != null;
        }

        /// <summary>
        /// Gets and sets the property RevokeServicePeriodTypeSort. 
        /// <para>
        /// Sorting options specific to revoke service period handshakes.
        /// </para>
        /// </summary>
        public RevokeServicePeriodTypeSort RevokeServicePeriodTypeSort
        {
            get { return this._revokeServicePeriodTypeSort; }
            set { this._revokeServicePeriodTypeSort = value; }
        }

        // Check to see if RevokeServicePeriodTypeSort property is set
        internal bool IsSetRevokeServicePeriodTypeSort()
        {
            return this._revokeServicePeriodTypeSort != null;
        }

        /// <summary>
        /// Gets and sets the property StartServicePeriodTypeSort. 
        /// <para>
        /// Sorting options specific to start service period handshakes.
        /// </para>
        /// </summary>
        public StartServicePeriodTypeSort StartServicePeriodTypeSort
        {
            get { return this._startServicePeriodTypeSort; }
            set { this._startServicePeriodTypeSort = value; }
        }

        // Check to see if StartServicePeriodTypeSort property is set
        internal bool IsSetStartServicePeriodTypeSort()
        {
            return this._startServicePeriodTypeSort != null;
        }

    }
}