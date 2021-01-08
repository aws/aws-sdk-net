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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing the array properties of a job.
    /// </summary>
    public partial class ArrayPropertiesDetail
    {
        private int? _index;
        private int? _size;
        private Dictionary<string, int> _statusSummary = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The job index within the array that's associated with this job. This parameter is
        /// returned for array job children.
        /// </para>
        /// </summary>
        public int Index
        {
            get { return this._index.GetValueOrDefault(); }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the array job. This parameter is returned for parent array jobs.
        /// </para>
        /// </summary>
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// A summary of the number of array job children in each available job status. This parameter
        /// is returned for parent array jobs.
        /// </para>
        /// </summary>
        public Dictionary<string, int> StatusSummary
        {
            get { return this._statusSummary; }
            set { this._statusSummary = value; }
        }

        // Check to see if StatusSummary property is set
        internal bool IsSetStatusSummary()
        {
            return this._statusSummary != null && this._statusSummary.Count > 0; 
        }

    }
}