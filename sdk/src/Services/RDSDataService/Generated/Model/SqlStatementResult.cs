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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// SQL statement execution result
    /// </summary>
    public partial class SqlStatementResult
    {
        private long? _numberOfRecordsUpdated;
        private ResultFrame _resultFrame;

        /// <summary>
        /// Gets and sets the property NumberOfRecordsUpdated. Number of rows updated.
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
        /// Gets and sets the property ResultFrame. ResultFrame returned by executing the sql
        /// statement
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