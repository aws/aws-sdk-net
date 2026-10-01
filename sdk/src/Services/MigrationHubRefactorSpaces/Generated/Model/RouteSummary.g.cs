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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The summary information for the routes as a response to <c>ListRoutes</c>.
    /// </summary>
    public partial class RouteSummary
    {
        /// <summary>
        /// Gets and sets the property AppendSourcePath. 
        /// <para>
        /// If set to <c>true</c>, this option appends the source path to the service URL endpoint.
        /// </para>
        /// </summary>
        public bool? AppendSourcePath { get; set; }

        /// <summary>
        /// Checks to see if the AppendSourcePath property is set.
        /// </summary>
        internal bool IsSetAppendSourcePath() => this.AppendSourcePath.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the route. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedByAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the route creator. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string CreatedByAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByAccountId property is set.
        /// </summary>
        internal bool IsSetCreatedByAccountId() => this.CreatedByAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that indicates when the route is created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique identifier of the environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Any error associated with the route resource. 
        /// </para>
        /// </summary>
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property IncludeChildPaths. 
        /// <para>
        /// Indicates whether to match all subpaths of the given source path. If this value is
        /// <c>false</c>, requests must match the source path exactly before they are forwarded
        /// to this route's service.
        /// </para>
        /// </summary>
        public bool? IncludeChildPaths { get; set; }

        /// <summary>
        /// Checks to see if the IncludeChildPaths property is set.
        /// </summary>
        internal bool IsSetIncludeChildPaths() => this.IncludeChildPaths.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// A timestamp that indicates when the route was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Methods. 
        /// <para>
        /// A list of HTTP methods to match. An empty list matches all values. If a method is
        /// present, only HTTP requests using that method are forwarded to this route’s service.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Methods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Methods property is set.
        /// </summary>
        internal bool IsSetMethods() => this.Methods != null && (this.Methods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the route owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property PathResourceToId. 
        /// <para>
        /// A mapping of Amazon API Gateway path resources to resource IDs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PathResourceToId { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the PathResourceToId property is set.
        /// </summary>
        internal bool IsSetPathResourceToId() => this.PathResourceToId != null && (this.PathResourceToId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteId. 
        /// <para>
        /// The unique identifier of the route. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string RouteId { get; set; }

        /// <summary>
        /// Checks to see if the RouteId property is set.
        /// </summary>
        internal bool IsSetRouteId() => this.RouteId != null;

        /// <summary>
        /// Gets and sets the property RouteType. 
        /// <para>
        /// The route type of the route. 
        /// </para>
        /// </summary>
        public RouteType RouteType { get; set; }

        /// <summary>
        /// Checks to see if the RouteType property is set.
        /// </summary>
        internal bool IsSetRouteType() => this.RouteType != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The unique identifier of the service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// This is the path that Refactor Spaces uses to match traffic. Paths must start with
        /// <c>/</c> and are relative to the base of the application. To use path parameters in
        /// the source path, add a variable in curly braces. For example, the resource path {user}
        /// represents a path parameter called 'user'.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SourcePath { get; set; }

        /// <summary>
        /// Checks to see if the SourcePath property is set.
        /// </summary>
        internal bool IsSetSourcePath() => this.SourcePath != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route. 
        /// </para>
        /// </summary>
        public RouteState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the route. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
