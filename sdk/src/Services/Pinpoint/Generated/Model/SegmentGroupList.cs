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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings that define the relationships between segment groups for a
    /// segment.
    /// </summary>
    public partial class SegmentGroupList
    {
        private List<SegmentGroup> _groups = new List<SegmentGroup>();
        private Include _include;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// An array that defines the set of segment criteria to evaluate when handling segment
        /// groups for the segment.
        /// </para>
        /// </summary>
        public List<SegmentGroup> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Specifies how to handle multiple segment groups for the segment. For example, if the
        /// segment includes three segment groups, whether the resulting segment includes endpoints
        /// that match all, any, or none of the segment groups.
        /// </para>
        /// </summary>
        public Include Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null;
        }

    }
}