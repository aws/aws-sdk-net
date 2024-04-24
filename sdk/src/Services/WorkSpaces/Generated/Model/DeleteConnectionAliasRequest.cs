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
    /// Container for the parameters to the DeleteConnectionAlias operation.
    /// Deletes the specified connection alias. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
    /// Cross-Region Redirection for Amazon WorkSpaces</a>.
    /// 
    ///  <important> 
    /// <para>
    ///  <b>If you will no longer be using a fully qualified domain name (FQDN) as the registration
    /// code for your WorkSpaces users, you must take certain precautions to prevent potential
    /// security issues.</b> For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html#cross-region-redirection-security-considerations">
    /// Security Considerations if You Stop Using Cross-Region Redirection</a>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// To delete a connection alias that has been shared, the shared account must first disassociate
    /// the connection alias from any directories it has been associated with. Then you must
    /// unshare the connection alias from the account it has been shared with. You can delete
    /// a connection alias only after it is no longer shared with any accounts or associated
    /// with any directories.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteConnectionAliasRequest : AmazonWorkSpacesRequest
    {
        private string _aliasId;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// The identifier of the connection alias to delete.
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

    }
}