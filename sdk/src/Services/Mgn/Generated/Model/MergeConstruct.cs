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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A construct reference specifying the source segment and construct to merge.
    /// </summary>
    public partial class MergeConstruct
    {
        private string _constructid;
        private string _segmentid;

        /// <summary>
        /// Gets and sets the property ConstructID. 
        /// <para>
        /// The construct ID to merge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ConstructID
        {
            get { return this._constructid; }
            set { this._constructid = value; }
        }

        // Check to see if ConstructID property is set
        internal bool IsSetConstructID()
        {
            return this._constructid != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The segment ID of the construct to merge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SegmentID
        {
            get { return this._segmentid; }
            set { this._segmentid = value; }
        }

        // Check to see if SegmentID property is set
        internal bool IsSetSegmentID()
        {
            return this._segmentid != null;
        }

    }
}