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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBackup operation.
    /// Creates an application-level backup of a server. While the server is in the <c>BACKING_UP</c>
    /// state, the server cannot be changed, and no additional backup can be created. 
    /// 
    ///  
    /// <para>
    ///  Backups can be created for servers in <c>RUNNING</c>, <c>HEALTHY</c>, and <c>UNHEALTHY</c>
    /// states. By default, you can create a maximum of 50 manual backups. 
    /// </para>
    ///  
    /// <para>
    ///  This operation is asynchronous. 
    /// </para>
    ///  
    /// <para>
    ///  A <c>LimitExceededException</c> is thrown when the maximum number of manual backups
    /// is reached. An <c>InvalidStateException</c> is thrown when the server is not in any
    /// of the following states: RUNNING, HEALTHY, or UNHEALTHY. A <c>ResourceNotFoundException</c>
    /// is thrown when the server is not found. A <c>ValidationException</c> is thrown when
    /// parameters of the request are not valid. 
    /// </para>
    /// </summary>
    public partial class CreateBackupRequest : AmazonOpsWorksCMRequest
    {
        private string _description;
        private string _serverName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A user-defined description of the backup. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server that you want to back up. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values to attach to an OpsWorks CM server backup.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key cannot be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key can be a maximum of 127 characters, and can contain only Unicode letters,
        /// numbers, or separators, or the following special characters: <c>+ - = . _ : /</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value can be a maximum 255 characters, and contain only Unicode letters, numbers,
        /// or separators, or the following special characters: <c>+ - = . _ : /</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leading and trailing white spaces are trimmed from both the key and value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A maximum of 50 user-applied tags is allowed for tag-supported OpsWorks CM resources.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}