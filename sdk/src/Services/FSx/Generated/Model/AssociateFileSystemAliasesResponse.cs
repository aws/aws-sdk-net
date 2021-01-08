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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The system generated response showing the DNS aliases that Amazon FSx is attempting
    /// to associate with the file system. Use the API operation to monitor the status of
    /// the aliases Amazon FSx is associating with the file system. It can take up to 2.5
    /// minutes for the alias status to change from <code>CREATING</code> to <code>AVAILABLE</code>.
    /// </summary>
    public partial class AssociateFileSystemAliasesResponse : AmazonWebServiceResponse
    {
        private List<Alias> _aliases = new List<Alias>();

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// An array of the DNS aliases that Amazon FSx is associating with the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Alias> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && this._aliases.Count > 0; 
        }

    }
}