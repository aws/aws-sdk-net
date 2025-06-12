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
    /// Container for the parameters to the StartFileTransfer operation.
    /// Begins a file transfer between local Amazon Web Services storage and a remote AS2
    /// or SFTP server.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For an AS2 connector, you specify the <c>ConnectorId</c> and one or more <c>SendFilePaths</c>
    /// to identify the files you want to transfer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For an SFTP connector, the file transfer can be either outbound or inbound. In both
    /// cases, you specify the <c>ConnectorId</c>. Depending on the direction of the transfer,
    /// you also specify the following items:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you are transferring file from a partner's SFTP server to Amazon Web Services storage,
    /// you specify one or more <c>RetrieveFilePaths</c> to identify the files you want to
    /// transfer, and a <c>LocalDirectoryPath</c> to specify the destination folder.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are transferring file to a partner's SFTP server from Amazon Web Services storage,
    /// you specify one or more <c>SendFilePaths</c> to identify the files you want to transfer,
    /// and a <c>RemoteDirectoryPath</c> to specify the destination folder.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class StartFileTransferRequest : AmazonTransferRequest
    {
        private string _connectorId;
        private string _localDirectoryPath;
        private string _remoteDirectoryPath;
        private List<string> _retrieveFilePaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sendFilePaths = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique identifier for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalDirectoryPath. 
        /// <para>
        /// For an inbound transfer, the <c>LocaDirectoryPath</c> specifies the destination for
        /// one or more files that are transferred from the partner's SFTP server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LocalDirectoryPath
        {
            get { return this._localDirectoryPath; }
            set { this._localDirectoryPath = value; }
        }

        // Check to see if LocalDirectoryPath property is set
        internal bool IsSetLocalDirectoryPath()
        {
            return this._localDirectoryPath != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDirectoryPath. 
        /// <para>
        /// For an outbound transfer, the <c>RemoteDirectoryPath</c> specifies the destination
        /// for one or more files that are transferred to the partner's SFTP server. If you don't
        /// specify a <c>RemoteDirectoryPath</c>, the destination for transferred files is the
        /// SFTP user's home directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RemoteDirectoryPath
        {
            get { return this._remoteDirectoryPath; }
            set { this._remoteDirectoryPath = value; }
        }

        // Check to see if RemoteDirectoryPath property is set
        internal bool IsSetRemoteDirectoryPath()
        {
            return this._remoteDirectoryPath != null;
        }

        /// <summary>
        /// Gets and sets the property RetrieveFilePaths. 
        /// <para>
        /// One or more source paths for the partner's SFTP server. Each string represents a source
        /// file path for one inbound file transfer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> RetrieveFilePaths
        {
            get { return this._retrieveFilePaths; }
            set { this._retrieveFilePaths = value; }
        }

        // Check to see if RetrieveFilePaths property is set
        internal bool IsSetRetrieveFilePaths()
        {
            return this._retrieveFilePaths != null && (this._retrieveFilePaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SendFilePaths. 
        /// <para>
        /// One or more source paths for the Amazon S3 storage. Each string represents a source
        /// file path for one outbound file transfer. For example, <c> <i>amzn-s3-demo-bucket</i>/<i>myfile.txt</i>
        /// </c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Replace <c> <i>amzn-s3-demo-bucket</i> </c> with one of your actual buckets.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> SendFilePaths
        {
            get { return this._sendFilePaths; }
            set { this._sendFilePaths = value; }
        }

        // Check to see if SendFilePaths property is set
        internal bool IsSetSendFilePaths()
        {
            return this._sendFilePaths != null && (this._sendFilePaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}