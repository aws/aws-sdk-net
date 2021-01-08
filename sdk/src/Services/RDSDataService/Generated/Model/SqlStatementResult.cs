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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The result of a SQL statement.
    /// 
    ///  <pre><code> &lt;important&gt; &lt;p&gt;This data type is deprecated.&lt;/p&gt; &lt;/important&gt;
    /// </code></pre>
    /// </summary>
    public partial class SqlStatementResult
    {
        private long? _numberOfRecordsUpdated;
        private ResultFrame _resultFrame;

        /// <summary>
        /// Gets and sets the property NumberOfRecordsUpdated. 
        /// <para>
        /// The number of records updated by a SQL statement.
        /// </para>
        /// </summary>
        public long NumberOfRecordsUpdated
        {
            get { return this._numberOfRecordsUpdated.GetValueOrDefault(); }
            set { this._numberOfRecordsUpdated = value; }
        }

        // Check to see if NumberOfRecordsUpdated property is set
        internal bool IsSetNumberOfRecordsUpdated()
        {
            return this._numberOfRecordsUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultFrame. 
        /// <para>
        /// The result set of the SQL statement.
        /// </para>
        /// </summary>
        public ResultFrame ResultFrame
        {
            get { return this._resultFrame; }
            set { this._resultFrame = value; }
        }

        // Check to see if ResultFrame property is set
        internal bool IsSetResultFrame()
        {
            return this._resultFrame != null;
        }

    }
}