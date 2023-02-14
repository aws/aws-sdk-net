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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRoute operation.
    /// Creates an Amazon Web Services Migration Hub Refactor Spaces route. The account owner
    /// of the service resource is always the environment owner, regardless of which account
    /// creates the route. Routes target a service in the application. If an application does
    /// not have any routes, then the first route must be created as a <code>DEFAULT</code>
    /// <code>RouteType</code>.
    /// 
    ///  
    /// <para>
    /// When created, the default route defaults to an active state so state is not a required
    /// input. However, like all other state values the state of the default route can be
    /// updated after creation, but only when all other routes are also inactive. Conversely,
    /// no route can be active without the default route also being active.
    /// </para>
    ///  
    /// <para>
    /// When you create a route, Refactor Spaces configures the Amazon API Gateway to send
    /// traffic to the target service as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the service has a URL endpoint, and the endpoint resolves to a private IP address,
    /// Refactor Spaces routes traffic using the API Gateway VPC link. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the service has a URL endpoint, and the endpoint resolves to a public IP address,
    /// Refactor Spaces routes traffic over the public internet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the service has an Lambda function endpoint, then Refactor Spaces configures the
    /// Lambda function's resource policy to allow the application's API Gateway to invoke
    /// the function.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A one-time health check is performed on the service when either the route is updated
    /// from inactive to active, or when it is created with an active state. If the health
    /// check fails, the route transitions the route state to <code>FAILED</code>, an error
    /// code of <code>SERVICE_ENDPOINT_HEALTH_CHECK_FAILURE</code> is provided, and no traffic
    /// is sent to the service.
    /// </para>
    ///  
    /// <para>
    /// For Lambda functions, the Lambda function state is checked. If the function is not
    /// active, the function configuration is updated so that Lambda resources are provisioned.
    /// If the Lambda state is <code>Failed</code>, then the route creation fails. For more
    /// information, see the <a href="https://docs.aws.amazon.com/lambda/latest/dg/API_GetFunctionConfiguration.html#SSS-GetFunctionConfiguration-response-State">GetFunctionConfiguration's
    /// State response parameter</a> in the <i>Lambda Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For Lambda endpoints, a check is performed to determine that a Lambda function with
    /// the specified ARN exists. If it does not exist, the health check fails. For public
    /// URLs, a connection is opened to the public endpoint. If the URL is not reachable,
    /// the health check fails. 
    /// </para>
    ///  
    /// <para>
    /// Refactor Spaces automatically resolves the public Domain Name System (DNS) names that
    /// are set in <a>CreateServiceRequest$UrlEndpoint</a> when you create a service. The
    /// DNS names resolve when the DNS time-to-live (TTL) expires, or every 60 seconds for
    /// TTLs less than 60 seconds. This periodic DNS resolution ensures that the route configuration
    /// remains up-to-date. 
    /// </para>
    ///  
    /// <para>
    /// For private URLS, a target group is created on the Elastic Load Balancing and the
    /// target group health check is run. The <code>HealthCheckProtocol</code>, <code>HealthCheckPort</code>,
    /// and <code>HealthCheckPath</code> are the same protocol, port, and path specified in
    /// the URL or health URL, if used. All other settings use the default values, as described
    /// in <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/target-group-health-checks.html">Health
    /// checks for your target groups</a>. The health check is considered successful if at
    /// least one target within the target group transitions to a healthy state.
    /// </para>
    ///  
    /// <para>
    /// Services can have HTTP or HTTPS URL endpoints. For HTTPS URLs, publicly-signed certificates
    /// are supported. Private Certificate Authorities (CAs) are permitted only if the CA's
    /// domain is also publicly resolvable.
    /// </para>
    /// </summary>
    public partial class CreateRouteRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        private string _applicationIdentifier;
        private string _clientToken;
        private DefaultRouteInput _defaultRoute;
        private string _environmentIdentifier;
        private RouteType _routeType;
        private string _serviceIdentifier;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private UriPathRouteInput _uriPathRoute;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The ID of the application within which the route is being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRoute. 
        /// <para>
        ///  Configuration for the default route type. 
        /// </para>
        /// </summary>
        public DefaultRouteInput DefaultRoute
        {
            get { return this._defaultRoute; }
            set { this._defaultRoute = value; }
        }

        // Check to see if DefaultRoute property is set
        internal bool IsSetDefaultRoute()
        {
            return this._defaultRoute != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment in which the route is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RouteType. 
        /// <para>
        /// The route type of the route. <code>DEFAULT</code> indicates that all traffic that
        /// does not match another route is forwarded to the default route. Applications must
        /// have a default route before any other routes can be created. <code>URI_PATH</code>
        /// indicates a route that is based on a URI path.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteType RouteType
        {
            get { return this._routeType; }
            set { this._routeType = value; }
        }

        // Check to see if RouteType property is set
        internal bool IsSetRouteType()
        {
            return this._routeType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID of the service in which the route is created. Traffic that matches this route
        /// is forwarded to this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string ServiceIdentifier
        {
            get { return this._serviceIdentifier; }
            set { this._serviceIdentifier = value; }
        }

        // Check to see if ServiceIdentifier property is set
        internal bool IsSetServiceIdentifier()
        {
            return this._serviceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the route. A tag is a label that you assign to an Amazon Web
        /// Services resource. Each tag consists of a key-value pair.. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UriPathRoute. 
        /// <para>
        /// The configuration for the URI path route type. 
        /// </para>
        /// </summary>
        public UriPathRouteInput UriPathRoute
        {
            get { return this._uriPathRoute; }
            set { this._uriPathRoute = value; }
        }

        // Check to see if UriPathRoute property is set
        internal bool IsSetUriPathRoute()
        {
            return this._uriPathRoute != null;
        }

    }
}