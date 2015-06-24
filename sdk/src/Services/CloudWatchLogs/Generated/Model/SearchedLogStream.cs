/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// An object indicating the search status of a log stream in a <code class="code">FilterLogEvents</code>
    /// request.
    /// </summary>
    public partial class SearchedLogStream
    {
        private string _logStreamName;
        private bool? _searchedCompletely;

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the log stream.
        /// </para>
        /// </summary>
        public string LogStreamName
        {
            get { return this._logStreamName; }
            set { this._logStreamName = value; }
        }

        // Check to see if LogStreamName property is set
        internal bool IsSetLogStreamName()
        {
            return this._logStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property SearchedCompletely. 
        /// <para>
        /// Indicates whether all the events in this log stream were searched or more data exists
        /// to search by paginating further.
        /// </para>
        /// </summary>
        public bool SearchedCompletely
        {
            get { return this._searchedCompletely.GetValueOrDefault(); }
            set { this._searchedCompletely = value; }
        }

        // Check to see if SearchedCompletely property is set
        internal bool IsSetSearchedCompletely()
        {
            return this._searchedCompletely.HasValue; 
        }

    }
}