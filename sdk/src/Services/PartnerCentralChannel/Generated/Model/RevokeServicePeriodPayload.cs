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
    /// Payload for revoke service period handshake requests.
    /// </summary>
    public partial class RevokeServicePeriodPayload
    {
        private string _note;
        private string _programManagementAccountIdentifier;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// A note explaining the reason for revoking the service period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountIdentifier. 
        /// <para>
        /// The identifier of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=1011)]
        public string ProgramManagementAccountIdentifier
        {
            get { return this._programManagementAccountIdentifier; }
            set { this._programManagementAccountIdentifier = value; }
        }

        // Check to see if ProgramManagementAccountIdentifier property is set
        internal bool IsSetProgramManagementAccountIdentifier()
        {
            return this._programManagementAccountIdentifier != null;
        }

    }
}