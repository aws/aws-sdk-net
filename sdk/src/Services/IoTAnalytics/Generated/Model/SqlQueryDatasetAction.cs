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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// The SQL query to modify the message.
    /// </summary>
    public partial class SqlQueryDatasetAction
    {
        private List<QueryFilter> _filters = new List<QueryFilter>();
        private string _sqlQuery;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Prefilters applied to message data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<QueryFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SqlQuery. 
        /// <para>
        /// A SQL query string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SqlQuery
        {
            get { return this._sqlQuery; }
            set { this._sqlQuery = value; }
        }

        // Check to see if SqlQuery property is set
        internal bool IsSetSqlQuery()
        {
            return this._sqlQuery != null;
        }

    }
}