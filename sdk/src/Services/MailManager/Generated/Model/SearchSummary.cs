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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Summary details of an archive search job.
    /// </summary>
    public partial class SearchSummary
    {
        private string _searchId;
        private SearchStatus _status;

        /// <summary>
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The unique identifier of the search job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SearchId
        {
            get { return this._searchId; }
            set { this._searchId = value; }
        }

        // Check to see if SearchId property is set
        internal bool IsSetSearchId()
        {
            return this._searchId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the search job.
        /// </para>
        /// </summary>
        public SearchStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}