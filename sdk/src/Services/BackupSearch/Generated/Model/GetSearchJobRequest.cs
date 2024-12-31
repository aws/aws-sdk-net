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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// Container for the parameters to the GetSearchJob operation.
    /// This operation retrieves metadata of a search job, including its progress.
    /// </summary>
    public partial class GetSearchJobRequest : AmazonBackupSearchRequest
    {
        private string _searchJobIdentifier;

        /// <summary>
        /// Gets and sets the property SearchJobIdentifier. 
        /// <para>
        /// Required unique string that specifies the search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SearchJobIdentifier
        {
            get { return this._searchJobIdentifier; }
            set { this._searchJobIdentifier = value; }
        }

        // Check to see if SearchJobIdentifier property is set
        internal bool IsSetSearchJobIdentifier()
        {
            return this._searchJobIdentifier != null;
        }

    }
}