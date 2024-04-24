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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectionAliasPermission operation.
    /// Shares or unshares a connection alias with one account by specifying whether that
    /// account has permission to associate the connection alias with a directory. If the
    /// association permission is granted, the connection alias is shared with that account.
    /// If the association permission is revoked, the connection alias is unshared with the
    /// account. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
    /// Cross-Region Redirection for Amazon WorkSpaces</a>.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// Before performing this operation, call <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeConnectionAliases.html">
    /// DescribeConnectionAliases</a> to make sure that the current state of the connection
    /// alias is <c>CREATED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To delete a connection alias that has been shared, the shared account must first disassociate
    /// the connection alias from any directories it has been associated with. Then you must
    /// unshare the connection alias from the account it has been shared with. You can delete
    /// a connection alias only after it is no longer shared with any accounts or associated
    /// with any directories.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class UpdateConnectionAliasPermissionRequest : AmazonWorkSpacesRequest
    {
        private string _aliasId;
        private ConnectionAliasPermission _connectionAliasPermission;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// The identifier of the connection alias that you want to update permissions for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=68)]
        public string AliasId
        {
            get { return this._aliasId; }
            set { this._aliasId = value; }
        }

        // Check to see if AliasId property is set
        internal bool IsSetAliasId()
        {
            return this._aliasId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionAliasPermission. 
        /// <para>
        /// Indicates whether to share or unshare the connection alias with the specified Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionAliasPermission ConnectionAliasPermission
        {
            get { return this._connectionAliasPermission; }
            set { this._connectionAliasPermission = value; }
        }

        // Check to see if ConnectionAliasPermission property is set
        internal bool IsSetConnectionAliasPermission()
        {
            return this._connectionAliasPermission != null;
        }

    }
}