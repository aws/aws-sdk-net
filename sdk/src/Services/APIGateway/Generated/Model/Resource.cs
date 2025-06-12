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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents an API resource.
    /// </summary>
    public partial class Resource
    {
        private string _id;
        private string _parentId;
        private string _path;
        private string _pathPart;
        private Dictionary<string, Method> _resourceMethods = AWSConfigs.InitializeCollections ? new Dictionary<string, Method>() : null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The resource's identifier.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The parent resource's identifier.
        /// </para>
        /// </summary>
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The full path for this resource.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PathPart. 
        /// <para>
        /// The last path segment for this resource.
        /// </para>
        /// </summary>
        public string PathPart
        {
            get { return this._pathPart; }
            set { this._pathPart = value; }
        }

        // Check to see if PathPart property is set
        internal bool IsSetPathPart()
        {
            return this._pathPart != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceMethods. 
        /// <para>
        /// Gets an API resource's method of a given HTTP verb.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Method> ResourceMethods
        {
            get { return this._resourceMethods; }
            set { this._resourceMethods = value; }
        }

        // Check to see if ResourceMethods property is set
        internal bool IsSetResourceMethods()
        {
            return this._resourceMethods != null && (this._resourceMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}