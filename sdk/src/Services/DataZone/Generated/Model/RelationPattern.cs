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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The pattern describing the query's relational traversal.
    /// </summary>
    public partial class RelationPattern
    {
        private int? _maxPathLength;
        private RelationDirection _relationDirection;
        private RelationType _relationType;

        /// <summary>
        /// Gets and sets the property MaxPathLength. 
        /// <para>
        /// The number of hops to query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int MaxPathLength
        {
            get { return this._maxPathLength.GetValueOrDefault(); }
            set { this._maxPathLength = value; }
        }

        // Check to see if MaxPathLength property is set
        internal bool IsSetMaxPathLength()
        {
            return this._maxPathLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelationDirection. 
        /// <para>
        /// The direction to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelationDirection RelationDirection
        {
            get { return this._relationDirection; }
            set { this._relationDirection = value; }
        }

        // Check to see if RelationDirection property is set
        internal bool IsSetRelationDirection()
        {
            return this._relationDirection != null;
        }

        /// <summary>
        /// Gets and sets the property RelationType. 
        /// <para>
        /// The type of relation to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelationType RelationType
        {
            get { return this._relationType; }
            set { this._relationType = value; }
        }

        // Check to see if RelationType property is set
        internal bool IsSetRelationType()
        {
            return this._relationType != null;
        }

    }
}