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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGraph operation.
    /// Deletes the specified graph. Graphs cannot be deleted if delete-protection is enabled.
    /// </summary>
    public partial class DeleteGraphRequest : AmazonNeptuneGraphRequest
    {
        private string _graphIdentifier;
        private bool? _skipSnapshot;

        /// <summary>
        /// Gets and sets the property GraphIdentifier. 
        /// <para>
        /// The unique identifier of the Neptune Analytics graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GraphIdentifier
        {
            get { return this._graphIdentifier; }
            set { this._graphIdentifier = value; }
        }

        // Check to see if GraphIdentifier property is set
        internal bool IsSetGraphIdentifier()
        {
            return this._graphIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SkipSnapshot. 
        /// <para>
        /// Determines whether a final graph snapshot is created before the graph is deleted.
        /// If <c>true</c> is specified, no graph snapshot is created. If <c>false</c> is specified,
        /// a graph snapshot is created before the graph is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SkipSnapshot
        {
            get { return this._skipSnapshot; }
            set { this._skipSnapshot = value; }
        }

        // Check to see if SkipSnapshot property is set
        internal bool IsSetSkipSnapshot()
        {
            return this._skipSnapshot.HasValue; 
        }

    }
}