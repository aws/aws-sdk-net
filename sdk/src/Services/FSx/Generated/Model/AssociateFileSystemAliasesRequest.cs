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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateFileSystemAliases operation.
    /// Use this action to associate one or more Domain Name Server (DNS) aliases with an
    /// existing Amazon FSx for Windows File Server file system. A file system can have a
    /// maximum of 50 DNS aliases associated with it at any one time. If you try to associate
    /// a DNS alias that is already associated with the file system, FSx takes no action on
    /// that alias in the request. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
    /// with DNS Aliases</a> and <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/walkthrough05-file-system-custom-CNAME.html">Walkthrough
    /// 5: Using DNS aliases to access your file system</a>, including additional steps you
    /// must take to be able to access your file system using a DNS alias.
    /// 
    ///  
    /// <para>
    /// The system response shows the DNS aliases that Amazon FSx is attempting to associate
    /// with the file system. Use the API operation to monitor the status of the aliases Amazon
    /// FSx is associating with the file system.
    /// </para>
    /// </summary>
    public partial class AssociateFileSystemAliasesRequest : AmazonFSxRequest
    {
        private List<string> _aliases = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientRequestToken;
        private string _fileSystemId;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// An array of one or more DNS alias names to associate with the file system. The alias
        /// name has to comply with the following formatting requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Formatted as a fully-qualified domain name (FQDN), <i> <c>hostname.domain</c> </i>,
        /// for example, <c>accounting.corp.example.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can contain alphanumeric characters and the hyphen (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot start or end with a hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can start with a numeric.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For DNS alias names, Amazon FSx stores alphabetic characters as lowercase letters
        /// (a-z), regardless of how you specify them: as uppercase letters, lowercase letters,
        /// or the corresponding letters in escape codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public List<string> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && (this._aliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// Specifies the file system with which you want to associate one or more DNS aliases.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=21)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

    }
}