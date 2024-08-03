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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition of the Anchor.
    /// </summary>
    public partial class Anchor
    {
        private AnchorType _anchorType;
        private int? _offset;
        private TimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property AnchorType. 
        /// <para>
        /// The <c>AnchorType</c> for the Anchor.
        /// </para>
        /// </summary>
        public AnchorType AnchorType
        {
            get { return this._anchorType; }
            set { this._anchorType = value; }
        }

        // Check to see if AnchorType property is set
        internal bool IsSetAnchorType()
        {
            return this._anchorType != null;
        }

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset of the Anchor.
        /// </para>
        /// </summary>
        public int? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The <c>TimeGranularity</c> of the Anchor.
        /// </para>
        /// </summary>
        public TimeGranularity TimeGranularity
        {
            get { return this._timeGranularity; }
            set { this._timeGranularity = value; }
        }

        // Check to see if TimeGranularity property is set
        internal bool IsSetTimeGranularity()
        {
            return this._timeGranularity != null;
        }

    }
}