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
    /// This is the response object from the AssociateConnectionAlias operation.
    /// </summary>
    public partial class AssociateConnectionAliasResponse : AmazonWebServiceResponse
    {
        private string _connectionIdentifier;

        /// <summary>
        /// Gets and sets the property ConnectionIdentifier. 
        /// <para>
        /// The identifier of the connection alias association. You use the connection identifier
        /// in the DNS TXT record when you're configuring your DNS routing policies. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string ConnectionIdentifier
        {
            get { return this._connectionIdentifier; }
            set { this._connectionIdentifier = value; }
        }

        // Check to see if ConnectionIdentifier property is set
        internal bool IsSetConnectionIdentifier()
        {
            return this._connectionIdentifier != null;
        }

    }
}