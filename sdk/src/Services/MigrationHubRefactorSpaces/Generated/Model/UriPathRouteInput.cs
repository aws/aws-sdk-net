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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
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
namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// The configuration for the URI path route type.
    /// </summary>
    public partial class UriPathRouteInput
    {
        private RouteActivationState _activationState;
        private bool? _appendSourcePath;
        private bool? _includeChildPaths;
        private List<string> _methods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourcePath;

        /// <summary>
        /// Gets and sets the property ActivationState. 
        /// <para>
        /// If set to <c>ACTIVE</c>, traffic is forwarded to this route’s service after the route
        /// is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteActivationState ActivationState
        {
            get { return this._activationState; }
            set { this._activationState = value; }
        }

        // Check to see if ActivationState property is set
        internal bool IsSetActivationState()
        {
            return this._activationState != null;
        }

        /// <summary>
        /// Gets and sets the property AppendSourcePath. 
        /// <para>
        /// If set to <c>true</c>, this option appends the source path to the service URL endpoint.
        /// </para>
        /// </summary>
        public bool? AppendSourcePath
        {
            get { return this._appendSourcePath; }
            set { this._appendSourcePath = value; }
        }

        // Check to see if AppendSourcePath property is set
        internal bool IsSetAppendSourcePath()
        {
            return this._appendSourcePath.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeChildPaths. 
        /// <para>
        /// Indicates whether to match all subpaths of the given source path. If this value is
        /// <c>false</c>, requests must match the source path exactly before they are forwarded
        /// to this route's service. 
        /// </para>
        /// </summary>
        public bool? IncludeChildPaths
        {
            get { return this._includeChildPaths; }
            set { this._includeChildPaths = value; }
        }

        // Check to see if IncludeChildPaths property is set
        internal bool IsSetIncludeChildPaths()
        {
            return this._includeChildPaths.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Methods. 
        /// <para>
        /// A list of HTTP methods to match. An empty list matches all values. If a method is
        /// present, only HTTP requests using that method are forwarded to this route’s service.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Methods
        {
            get { return this._methods; }
            set { this._methods = value; }
        }

        // Check to see if Methods property is set
        internal bool IsSetMethods()
        {
            return this._methods != null && (this._methods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// This is the path that Refactor Spaces uses to match traffic. Paths must start with
        /// <c>/</c> and are relative to the base of the application. To use path parameters in
        /// the source path, add a variable in curly braces. For example, the resource path {user}
        /// represents a path parameter called 'user'.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SourcePath
        {
            get { return this._sourcePath; }
            set { this._sourcePath = value; }
        }

        // Check to see if SourcePath property is set
        internal bool IsSetSourcePath()
        {
            return this._sourcePath != null;
        }

    }
}