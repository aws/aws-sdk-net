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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the permissions for a connection alias. Connection aliases are used for
    /// cross-Region redirection. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
    /// Cross-Region Redirection for Amazon WorkSpaces</a>.
    /// </summary>
    public partial class ConnectionAliasPermission
    {
        /// <summary>
        /// Gets and sets the property AllowAssociation. 
        /// <para>
        /// Indicates whether the specified Amazon Web Services account is allowed to associate
        /// the connection alias with a directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AllowAssociation { get; set; }

        /// <summary>
        /// Checks to see if the AllowAssociation property is set.
        /// </summary>
        internal bool IsSetAllowAssociation() => this.AllowAssociation.HasValue;

        /// <summary>
        /// Gets and sets the property SharedAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that the connection alias is shared
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SharedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SharedAccountId property is set.
        /// </summary>
        internal bool IsSetSharedAccountId() => this.SharedAccountId != null;
    }
}
