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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Stage plan information such as name, identifier, sub plans, and remote sources.
    /// </summary>
    public partial class QueryStagePlanNode
    {
        private List<QueryStagePlanNode> _children = AWSConfigs.InitializeCollections ? new List<QueryStagePlanNode>() : null;
        private string _identifier;
        private string _name;
        private List<string> _remoteSources = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// Stage plan information such as name, identifier, sub plans, and remote sources of
        /// child plan nodes/
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueryStagePlanNode> Children
        {
            get { return this._children; }
            set { this._children = value; }
        }

        // Check to see if Children property is set
        internal bool IsSetChildren()
        {
            return this._children != null && (this._children.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Information about the operation this query stage plan node is performing.
        /// </para>
        /// </summary>
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the query stage plan that describes the operation this stage is performing
        /// as part of query execution.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteSources. 
        /// <para>
        /// Source plan node IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoteSources
        {
            get { return this._remoteSources; }
            set { this._remoteSources = value; }
        }

        // Check to see if RemoteSources property is set
        internal bool IsSetRemoteSources()
        {
            return this._remoteSources != null && (this._remoteSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}