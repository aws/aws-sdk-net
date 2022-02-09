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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Specifies change details of the domain configuration change.
    /// </summary>
    public partial class ChangeProgressDetails
    {
        private string _changeId;
        private string _message;

        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The unique change identifier associated with a specific domain configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ChangeId
        {
            get { return this._changeId; }
            set { this._changeId = value; }
        }

        // Check to see if ChangeId property is set
        internal bool IsSetChangeId()
        {
            return this._changeId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Contains an optional message associated with the domain configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}