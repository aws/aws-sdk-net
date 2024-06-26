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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSMBSecurityStrategy operation.
    /// Updates the SMB security strategy level for an Amazon S3 file gateway. This action
    /// is only supported for Amazon S3 file gateways.
    /// 
    ///  <note> 
    /// <para>
    /// For information about configuring this setting using the Amazon Web Services console,
    /// see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/security-strategy.html">Setting
    /// a security level for your gateway</a> in the <i>Amazon S3 File Gateway User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A higher security strategy level can affect performance of the gateway.
    /// </para>
    ///  </note>
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
        ///  <c>ClientSpecified</c>: If you choose this option, requests are established based
        /// on what is negotiated by the client. This option is recommended when you want to maximize
        /// compatibility across different clients in your environment. Supported only for S3
        /// File Gateway.
        /// </para>
        ///  
        /// <para>
        ///  <c>MandatorySigning</c>: If you choose this option, File Gateway only allows connections
        /// from SMBv2 or SMBv3 clients that have signing enabled. This option works with SMB
        /// clients on Microsoft Windows Vista, Windows Server 2008 or newer.
        /// </para>
        ///  
        /// <para>
        ///  <c>MandatoryEncryption</c>: If you choose this option, File Gateway only allows connections
        /// from SMBv3 clients that have encryption enabled. This option is recommended for environments
        /// that handle sensitive data. This option works with SMB clients on Microsoft Windows
        /// 8, Windows Server 2012 or newer.
        /// </para>
        ///  
        /// <para>
        ///  <c>MandatoryEncryptionNoAes128</c>: If you choose this option, File Gateway only
        /// allows connections from SMBv3 clients that use 256-bit AES encryption algorithms.
        /// 128-bit algorithms are not allowed. This option is recommended for environments that
        /// handle sensitive data. It works with SMB clients on Microsoft Windows 8, Windows Server
        /// 2012, or later.
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