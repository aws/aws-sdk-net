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
    /// Container for the parameters to the RemoveSourceServerAction operation.
    /// Remove source server post migration custom action.
    /// </summary>
    public partial class RemoveSourceServerActionRequest : AmazonMgnRequest
    {
        private string _actionid;
        private string _sourceServerID;

        /// <summary>
        /// Gets and sets the property ActionID. 
        /// <para>
        /// Source server post migration custom action ID to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ActionID
        {
            get { return this._actionid; }
            set { this._actionid = value; }
        }

        // Check to see if ActionID property is set
        internal bool IsSetActionID()
        {
            return this._actionid != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Source server ID of the post migration custom action to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

    }
}