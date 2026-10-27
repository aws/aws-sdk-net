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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the StartFileTransfer operation. Begins a file transfer
    /// between local Amazon Web Services storage and a remote AS2 or SFTP server. <ul> <li>
    /// <para> For an AS2 connector, you specify the <c>ConnectorId</c> and one or more <c>SendFilePaths</c>
    /// to identify the files you want to transfer. </para> </li> <li> <para> For an SFTP
    /// connector, the file transfer can be either outbound or inbound. In both cases, you
    /// specify the <c>ConnectorId</c>. Depending on the direction of the transfer, you also
    /// specify the following items: </para> <ul> <li> <para> If you are transferring file
    /// from a partner's SFTP server to Amazon Web Services storage, you specify one or more
    /// <c>RetrieveFilePaths</c> to identify the files you want to transfer, and a <c>LocalDirectoryPath</c>
    /// to specify the destination folder. </para> </li> <li> <para> If you are transferring
    /// file to a partner's SFTP server from Amazon Web Services storage, you specify one
    /// or more <c>SendFilePaths</c> to identify the files you want to transfer, and a <c>RemoteDirectoryPath</c>
    /// to specify the destination folder. </para> </li> </ul> </li> </ul>
    /// </summary>
    public partial class StartFileTransferRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique identifier for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property CustomHttpHeaders. 
        /// <para>
        /// An array of key-value pairs that represent custom HTTP headers to include in AS2 messages.
        /// These headers are added to the AS2 message when sending files to your trading partner.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomHttpHeader> CustomHttpHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomHttpHeader>() : null;

        /// <summary>
        /// Checks to see if the CustomHttpHeaders property is set.
        /// </summary>
        internal bool IsSetCustomHttpHeaders() => this.CustomHttpHeaders != null && (this.CustomHttpHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalDirectoryPath. 
        /// <para>
        /// For an inbound transfer, the <c>LocaDirectoryPath</c> specifies the destination for
        /// one or more files that are transferred from the partner's SFTP server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string LocalDirectoryPath { get; set; }

        /// <summary>
        /// Checks to see if the LocalDirectoryPath property is set.
        /// </summary>
        internal bool IsSetLocalDirectoryPath() => this.LocalDirectoryPath != null;

        /// <summary>
        /// Gets and sets the property RemoteDirectoryPath. 
        /// <para>
        /// For an outbound transfer, the <c>RemoteDirectoryPath</c> specifies the destination
        /// for one or more files that are transferred to the partner's SFTP server. If you don't
        /// specify a <c>RemoteDirectoryPath</c>, the destination for transferred files is the
        /// SFTP user's home directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RemoteDirectoryPath { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDirectoryPath property is set.
        /// </summary>
        internal bool IsSetRemoteDirectoryPath() => this.RemoteDirectoryPath != null;

        /// <summary>
        /// Gets and sets the property RetrieveFilePaths. 
        /// <para>
        /// One or more source paths for the partner's SFTP server. Each string represents a source
        /// file path for one inbound file transfer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> RetrieveFilePaths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RetrieveFilePaths property is set.
        /// </summary>
        internal bool IsSetRetrieveFilePaths() => this.RetrieveFilePaths != null && (this.RetrieveFilePaths.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> SendFilePaths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SendFilePaths property is set.
        /// </summary>
        internal bool IsSetSendFilePaths() => this.SendFilePaths != null && (this.SendFilePaths.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
