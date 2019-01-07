/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing metadata for a resource.
    /// </summary>
    public partial class ResourceMetadata
    {
        private string _arn;
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private string _uid;
        private long? _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) for the resource.
        /// </para>
        ///          <note>            
        /// <para>
        /// After you create a virtual node, set this value (either the full ARN or the      
        ///      truncated resource name, for example, <code>mesh/default/virtualNode/simpleapp</code>,
        ///            as the <code>APPMESH_VIRTUAL_NODE_NAME</code> environment variable for
        /// your task group's            Envoy proxy container in your task definition or pod
        /// spec. This is then mapped to the               <code>node.id</code> and <code>node.cluster</code>
        /// Envoy parameters.
        /// </para>
        ///             
        /// <para>
        /// If you require your Envoy stats or tracing to use a different name, you can override
        ///            the <code>node.cluster</code> value that is set by               <code>APPMESH_VIRTUAL_NODE_NAME</code>
        /// with the               <code>APPMESH_VIRTUAL_NODE_CLUSTER</code> environment variable.
        /// </para>
        ///          </note>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the resource was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the resource was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier for the resource.
        /// </para>
        /// </summary>
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the resource. Resources are created at version 1, and this version
        /// is         incremented each time they are updated.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}