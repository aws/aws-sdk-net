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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides information for filtering a list of entity recognizers. You can only specify
    /// one filtering parameter in a request. For more information, see the operation./&gt;
    /// </summary>
    public partial class EntityRecognizerFilter
    {
        private ModelStatus _status;
        private DateTime? _submitTimeAfter;
        private DateTime? _submitTimeBefore;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an entity recognizer.
        /// </para>
        /// </summary>
        public ModelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeAfter. 
        /// <para>
        /// Filters the list of entities based on the time that the list was submitted for processing.
        /// Returns only jobs submitted after the specified time. Jobs are returned in ascending
        /// order, oldest to newest.
        /// </para>
        /// </summary>
        public DateTime SubmitTimeAfter
        {
            get { return this._submitTimeAfter.GetValueOrDefault(); }
            set { this._submitTimeAfter = value; }
        }

        // Check to see if SubmitTimeAfter property is set
        internal bool IsSetSubmitTimeAfter()
        {
            return this._submitTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmitTimeBefore. 
        /// <para>
        /// Filters the list of entities based on the time that the list was submitted for processing.
        /// Returns only jobs submitted before the specified time. Jobs are returned in descending
        /// order, newest to oldest.
        /// </para>
        /// </summary>
        public DateTime SubmitTimeBefore
        {
            get { return this._submitTimeBefore.GetValueOrDefault(); }
            set { this._submitTimeBefore = value; }
        }

        // Check to see if SubmitTimeBefore property is set
        internal bool IsSetSubmitTimeBefore()
        {
            return this._submitTimeBefore.HasValue; 
        }

    }
}