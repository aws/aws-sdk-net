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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A directed edge connecting two lineage entities.
    /// </summary>
    public partial class Edge
    {
        private AssociationEdgeType _associationType;
        private string _destinationArn;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of the Association(Edge) between the source and destination. For example
        /// <c>ContributedTo</c>, <c>Produced</c>, or <c>DerivedFrom</c>.
        /// </para>
        /// </summary>
        public AssociationEdgeType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination lineage entity of the directed edge.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source lineage entity of the directed edge.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}