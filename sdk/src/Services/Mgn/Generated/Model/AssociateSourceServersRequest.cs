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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateSourceServers operation.
    /// Associate source servers to application.
    /// </summary>
    public partial class AssociateSourceServersRequest : AmazonMgnRequest
    {
        private string _applicationid;
        private List<string> _sourceServerIDs = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationID. 
        /// <para>
        /// Application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string ApplicationID
        {
            get { return this._applicationid; }
            set { this._applicationid = value; }
        }

        // Check to see if ApplicationID property is set
        internal bool IsSetApplicationID()
        {
            return this._applicationid != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerIDs. 
        /// <para>
        /// Source server IDs list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> SourceServerIDs
        {
            get { return this._sourceServerIDs; }
            set { this._sourceServerIDs = value; }
        }

        // Check to see if SourceServerIDs property is set
        internal bool IsSetSourceServerIDs()
        {
            return this._sourceServerIDs != null && this._sourceServerIDs.Count > 0; 
        }

    }
}