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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnectionAlias operation.
    /// Creates the specified connection alias for use with cross-Region redirection. For
    /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
    /// Cross-Region Redirection for Amazon WorkSpaces</a>.
    /// </summary>
    public partial class CreateConnectionAliasRequest : AmazonWorkSpacesRequest
    {
        private string _connectionString;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ConnectionString. 
        /// <para>
        /// A connection string in the form of a fully qualified domain name (FQDN), such as <code>www.example.com</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a connection string, it is always associated to your AWS account.
        /// You cannot recreate the same connection string with a different account, even if you
        /// delete all instances of it from the original account. The connection string is globally
        /// reserved for your account.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ConnectionString
        {
            get { return this._connectionString; }
            set { this._connectionString = value; }
        }

        // Check to see if ConnectionString property is set
        internal bool IsSetConnectionString()
        {
            return this._connectionString != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the connection alias.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}