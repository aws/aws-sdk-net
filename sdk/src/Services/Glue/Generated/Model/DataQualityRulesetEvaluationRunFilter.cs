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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The filter criteria.
    /// </summary>
    public partial class DataQualityRulesetEvaluationRunFilter
    {
        private DataSource _dataSource;
        private DateTime? _startedAfter;
        private DateTime? _startedBefore;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Filter based on a data source (an Glue table) associated with the run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Filter results by runs that started after this time.
        /// </para>
        /// </summary>
        public DateTime StartedAfter
        {
            get { return this._startedAfter.GetValueOrDefault(); }
            set { this._startedAfter = value; }
        }

        // Check to see if StartedAfter property is set
        internal bool IsSetStartedAfter()
        {
            return this._startedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Filter results by runs that started before this time.
        /// </para>
        /// </summary>
        public DateTime StartedBefore
        {
            get { return this._startedBefore.GetValueOrDefault(); }
            set { this._startedBefore = value; }
        }

        // Check to see if StartedBefore property is set
        internal bool IsSetStartedBefore()
        {
            return this._startedBefore.HasValue; 
        }

    }
}