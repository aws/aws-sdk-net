/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSMBSecurityStrategy operation.
    /// Updates the SMB security strategy on a file gateway. This action is only supported
    /// in file gateways.
    /// </summary>
    public partial class UpdateSMBSecurityStrategyRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private SMBSecurityStrategy _smbSecurityStrategy;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property SMBSecurityStrategy. 
        /// <para>
        /// Specifies the type of security strategy.
        /// </para>
        ///  
        /// <para>
        /// ClientSpecified: SMBv1 is enabled, SMB signing is offered but not required, SMB encryption
        /// is offered but not required.
        /// </para>
        ///  
        /// <para>
        /// MandatorySigning: SMBv1 is disabled, SMB signing is required, SMB encryption is offered
        /// but not required.
        /// </para>
        ///  
        /// <para>
        /// MandatoryEncryption: SMBv1 is disabled, SMB signing is offered but not required, SMB
        /// encryption is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SMBSecurityStrategy SMBSecurityStrategy
        {
            get { return this._smbSecurityStrategy; }
            set { this._smbSecurityStrategy = value; }
        }

        // Check to see if SMBSecurityStrategy property is set
        internal bool IsSetSMBSecurityStrategy()
        {
            return this._smbSecurityStrategy != null;
        }

    }
}