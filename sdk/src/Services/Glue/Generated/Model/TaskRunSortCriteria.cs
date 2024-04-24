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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The sorting criteria that are used to sort the list of task runs for the machine learning
    /// transform.
    /// </summary>
    public partial class TaskRunSortCriteria
    {
        private TaskRunSortColumnType _column;
        private SortDirectionType _sortDirection;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column to be used to sort the list of task runs for the machine learning transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskRunSortColumnType Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The sort direction to be used to sort the list of task runs for the machine learning
        /// transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SortDirectionType SortDirection
        {
            get { return this._sortDirection; }
            set { this._sortDirection = value; }
        }

        // Check to see if SortDirection property is set
        internal bool IsSetSortDirection()
        {
            return this._sortDirection != null;
        }

    }
}