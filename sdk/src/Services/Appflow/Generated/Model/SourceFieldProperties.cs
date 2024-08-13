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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that can be applied to a field when the connector is being used as
    /// a source.
    /// </summary>
    public partial class SourceFieldProperties
    {
        private bool? _isQueryable;
        private bool? _isRetrievable;
        private bool? _isTimestampFieldForIncrementalQueries;

        /// <summary>
        /// Gets and sets the property IsQueryable. 
        /// <para>
        ///  Indicates if the field can be queried. 
        /// </para>
        /// </summary>
        public bool? IsQueryable
        {
            get { return this._isQueryable; }
            set { this._isQueryable = value; }
        }

        // Check to see if IsQueryable property is set
        internal bool IsSetIsQueryable()
        {
            return this._isQueryable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRetrievable. 
        /// <para>
        ///  Indicates whether the field can be returned in a search result. 
        /// </para>
        /// </summary>
        public bool? IsRetrievable
        {
            get { return this._isRetrievable; }
            set { this._isRetrievable = value; }
        }

        // Check to see if IsRetrievable property is set
        internal bool IsSetIsRetrievable()
        {
            return this._isRetrievable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsTimestampFieldForIncrementalQueries. 
        /// <para>
        /// Indicates if this timestamp field can be used for incremental queries.
        /// </para>
        /// </summary>
        public bool? IsTimestampFieldForIncrementalQueries
        {
            get { return this._isTimestampFieldForIncrementalQueries; }
            set { this._isTimestampFieldForIncrementalQueries = value; }
        }

        // Check to see if IsTimestampFieldForIncrementalQueries property is set
        internal bool IsSetIsTimestampFieldForIncrementalQueries()
        {
            return this._isTimestampFieldForIncrementalQueries.HasValue; 
        }

    }
}