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
    /// Container for the parameters to the StartDirectoryListing operation.
    /// Retrieves a list of the contents of a directory from a remote SFTP server. You specify
    /// the connector ID, the output path, and the remote directory path. You can also specify
    /// the optional <c>MaxItems</c> value to control the maximum number of items that are
    /// listed from the remote directory. This API returns a list of all files and directories
    /// in the remote directory (up to the maximum value), but does not return files or folders
    /// in sub-directories. That is, it only returns a list of files and directories one-level
    /// deep.
    /// 
    ///  
    /// <para>
    /// After you receive the listing file, you can provide the files that you want to transfer
    /// to the <c>RetrieveFilePaths</c> parameter of the <c>StartFileTransfer</c> API call.
    /// </para>
    ///  
    /// <para>
    /// The naming convention for the output file is <c> <i>connector-ID</i>-<i>listing-ID</i>.json</c>.
    /// The output file contains the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>filePath</c>: the complete path of a remote file, relative to the directory of
    /// the listing request for your SFTP connector on the remote server.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>modifiedTimestamp</c>: the last time the file was modified, in UTC time format.
    /// This field is optional. If the remote file attributes don't contain a timestamp, it
    /// is omitted from the file listing.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>size</c>: the size of the file, in bytes. This field is optional. If the remote
    /// file attributes don't contain a file size, it is omitted from the file listing.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>path</c>: the complete path of a remote directory, relative to the directory of
    /// the listing request for your SFTP connector on the remote server.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>truncated</c>: a flag indicating whether the list output contains all of the items
    /// contained in the remote directory or not. If your <c>Truncated</c> output value is
    /// true, you can increase the value provided in the optional <c>max-items</c> input attribute
    /// to be able to list more items (up to the maximum allowed list size of 10,000 items).
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartDirectoryListingRequest : AmazonTransferRequest
    {
        private string _connectorId;
        private int? _maxItems;
        private string _outputDirectoryPath;
        private string _remoteDirectoryPath;

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
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// An optional parameter where you can specify the maximum number of file/directory names
        /// to retrieve. The default value is 1,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputDirectoryPath. 
        /// <para>
        /// Specifies the path (bucket and prefix) in Amazon S3 storage to store the results of
        /// the directory listing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string OutputDirectoryPath
        {
            get { return this._outputDirectoryPath; }
            set { this._outputDirectoryPath = value; }
        }

        // Check to see if OutputDirectoryPath property is set
        internal bool IsSetOutputDirectoryPath()
        {
            return this._outputDirectoryPath != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDirectoryPath. 
        /// <para>
        /// Specifies the directory on the remote SFTP server for which you want to list its contents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

    }
}