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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a path.
    /// </summary>
    public partial class AccessScopePathRequest
    {
        private PathStatementRequest _destination;
        private PathStatementRequest _source;
        private List<ThroughResourcesStatementRequest> _throughResources = AWSConfigs.InitializeCollections ? new List<ThroughResourcesStatementRequest>() : null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination.
        /// </para>
        /// </summary>
        public PathStatementRequest Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source.
        /// </para>
        /// </summary>
        public PathStatementRequest Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property ThroughResources. 
        /// <para>
        /// The through resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThroughResourcesStatementRequest> ThroughResources
        {
            get { return this._throughResources; }
            set { this._throughResources = value; }
        }

        // Check to see if ThroughResources property is set
        internal bool IsSetThroughResources()
        {
            return this._throughResources != null && (this._throughResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}