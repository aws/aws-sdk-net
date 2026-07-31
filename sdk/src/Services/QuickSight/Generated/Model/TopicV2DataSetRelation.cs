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
    /// A structure that represents a relation between two data sets of a topic.
    /// </summary>
    public partial class TopicV2DataSetRelation
    {
        private TopicV2DataSetRelationEndpoint _left;
        private TopicV2DataSetRelationEndpoint _right;

        /// <summary>
        /// Gets and sets the property Left. 
        /// <para>
        /// The left endpoint of the data set relation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TopicV2DataSetRelationEndpoint Left
        {
            get { return this._left; }
            set { this._left = value; }
        }

        // Check to see if Left property is set
        internal bool IsSetLeft()
        {
            return this._left != null;
        }

        /// <summary>
        /// Gets and sets the property Right. 
        /// <para>
        /// The right endpoint of the data set relation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TopicV2DataSetRelationEndpoint Right
        {
            get { return this._right; }
            set { this._right = value; }
        }

        // Check to see if Right property is set
        internal bool IsSetRight()
        {
            return this._right != null;
        }

    }
}