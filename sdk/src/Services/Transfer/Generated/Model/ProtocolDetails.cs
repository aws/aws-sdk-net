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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The protocol settings that are configured for your server.
    /// </summary>
    public partial class ProtocolDetails
    {
        private List<string> _as2Transports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _passiveIp;
        private SetStatOption _setStatOption;
        private TlsSessionResumptionMode _tlsSessionResumptionMode;

        /// <summary>
        /// Gets and sets the property As2Transports. 
        /// <para>
        /// Indicates the transport method for the AS2 messages. Currently, only HTTP is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> As2Transports
        {
            get { return this._as2Transports; }
            set { this._as2Transports = value; }
        }

        // Check to see if As2Transports property is set
        internal bool IsSetAs2Transports()
        {
            return this._as2Transports != null && (this._as2Transports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PassiveIp. 
        /// <para>
        ///  Indicates passive mode, for FTP and FTPS protocols. Enter a single IPv4 address,
        /// such as the public IP address of a firewall, router, or load balancer. For example:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>aws transfer update-server --protocol-details PassiveIp=0.0.0.0</c> 
        /// </para>
        ///  
        /// <para>
        /// Replace <c>0.0.0.0</c> in the example above with the actual IP address you want to
        /// use.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you change the <c>PassiveIp</c> value, you must stop and then restart your Transfer
        /// Family server for the change to take effect. For details on using passive mode (PASV)
        /// in a NAT environment, see <a href="http://aws.amazon.com/blogs/storage/configuring-your-ftps-server-behind-a-firewall-or-nat-with-aws-transfer-family/">Configuring
        /// your FTPS server behind a firewall or NAT with Transfer Family</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <i>Special values</i> 
        /// </para>
        ///  
        /// <para>
        /// The <c>AUTO</c> and <c>0.0.0.0</c> are special values for the <c>PassiveIp</c> parameter.
        /// The value <c>PassiveIp=AUTO</c> is assigned by default to FTP and FTPS type servers.
        /// In this case, the server automatically responds with one of the endpoint IPs within
        /// the PASV response. <c>PassiveIp=0.0.0.0</c> has a more unique application for its
        /// usage. For example, if you have a High Availability (HA) Network Load Balancer (NLB)
        /// environment, where you have 3 subnets, you can only specify a single IP address using
        /// the <c>PassiveIp</c> parameter. This reduces the effectiveness of having High Availability.
        /// In this case, you can specify <c>PassiveIp=0.0.0.0</c>. This tells the client to use
        /// the same IP address as the Control connection and utilize all AZs for their connections.
        /// Note, however, that not all FTP clients support the <c>PassiveIp=0.0.0.0</c> response.
        /// FileZilla and WinSCP do support it. If you are using other clients, check to see if
        /// your client supports the <c>PassiveIp=0.0.0.0</c> response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public string PassiveIp
        {
            get { return this._passiveIp; }
            set { this._passiveIp = value; }
        }

        // Check to see if PassiveIp property is set
        internal bool IsSetPassiveIp()
        {
            return this._passiveIp != null;
        }

        /// <summary>
        /// Gets and sets the property SetStatOption. 
        /// <para>
        /// Use the <c>SetStatOption</c> to ignore the error that is generated when the client
        /// attempts to use <c>SETSTAT</c> on a file you are uploading to an S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// Some SFTP file transfer clients can attempt to change the attributes of remote files,
        /// including timestamp and permissions, using commands, such as <c>SETSTAT</c> when uploading
        /// the file. However, these commands are not compatible with object storage systems,
        /// such as Amazon S3. Due to this incompatibility, file uploads from these clients can
        /// result in errors even when the file is otherwise successfully uploaded.
        /// </para>
        ///  
        /// <para>
        /// Set the value to <c>ENABLE_NO_OP</c> to have the Transfer Family server ignore the
        /// <c>SETSTAT</c> command, and upload files without needing to make any changes to your
        /// SFTP client. While the <c>SetStatOption</c> <c>ENABLE_NO_OP</c> setting ignores the
        /// error, it does generate a log entry in Amazon CloudWatch Logs, so you can determine
        /// when the client is making a <c>SETSTAT</c> call.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to preserve the original timestamp for your file, and modify other file
        /// attributes using <c>SETSTAT</c>, you can use Amazon EFS as backend storage with Transfer
        /// Family.
        /// </para>
        ///  </note>
        /// </summary>
        public SetStatOption SetStatOption
        {
            get { return this._setStatOption; }
            set { this._setStatOption = value; }
        }

        // Check to see if SetStatOption property is set
        internal bool IsSetSetStatOption()
        {
            return this._setStatOption != null;
        }

        /// <summary>
        /// Gets and sets the property TlsSessionResumptionMode. 
        /// <para>
        /// A property used with Transfer Family servers that use the FTPS protocol. TLS Session
        /// Resumption provides a mechanism to resume or share a negotiated secret key between
        /// the control and data connection for an FTPS session. <c>TlsSessionResumptionMode</c>
        /// determines whether or not the server resumes recent, negotiated sessions through a
        /// unique session ID. This property is available during <c>CreateServer</c> and <c>UpdateServer</c>
        /// calls. If a <c>TlsSessionResumptionMode</c> value is not specified during <c>CreateServer</c>,
        /// it is set to <c>ENFORCED</c> by default.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DISABLED</c>: the server does not process TLS session resumption client requests
        /// and creates a new TLS session for each request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED</c>: the server processes and accepts clients that are performing TLS
        /// session resumption. The server doesn't reject client data connections that do not
        /// perform the TLS session resumption client processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENFORCED</c>: the server processes and accepts clients that are performing TLS
        /// session resumption. The server rejects client data connections that do not perform
        /// the TLS session resumption client processing. Before you set the value to <c>ENFORCED</c>,
        /// test your clients.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not all FTPS clients perform TLS session resumption. So, if you choose to enforce
        /// TLS session resumption, you prevent any connections from FTPS clients that don't perform
        /// the protocol negotiation. To determine whether or not you can use the <c>ENFORCED</c>
        /// value, you need to test your clients.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public TlsSessionResumptionMode TlsSessionResumptionMode
        {
            get { return this._tlsSessionResumptionMode; }
            set { this._tlsSessionResumptionMode = value; }
        }

        // Check to see if TlsSessionResumptionMode property is set
        internal bool IsSetTlsSessionResumptionMode()
        {
            return this._tlsSessionResumptionMode != null;
        }

    }
}