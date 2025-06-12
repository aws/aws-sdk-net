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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the Kubernetes API call action described in this finding.
    /// </summary>
    public partial class KubernetesApiCallAction
    {
        private string _awsNamespace;
        private string _parameters;
        private RemoteIpDetails _remoteIpDetails;
        private string _requestUri;
        private string _resource;
        private string _resourceName;
        private List<string> _sourceIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _statusCode;
        private string _subresource;
        private string _userAgent;
        private string _verb;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the namespace where the Kubernetes API call action takes place.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Parameters related to the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIpDetails.
        /// </summary>
        public RemoteIpDetails RemoteIpDetails
        {
            get { return this._remoteIpDetails; }
            set { this._remoteIpDetails = value; }
        }

        // Check to see if RemoteIpDetails property is set
        internal bool IsSetRemoteIpDetails()
        {
            return this._remoteIpDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RequestUri. 
        /// <para>
        /// The Kubernetes API request URI.
        /// </para>
        /// </summary>
        public string RequestUri
        {
            get { return this._requestUri; }
            set { this._requestUri = value; }
        }

        // Check to see if RequestUri property is set
        internal bool IsSetRequestUri()
        {
            return this._requestUri != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource component in the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource in the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIps. 
        /// <para>
        /// The IP of the Kubernetes API caller and the IPs of any proxies or load balancers between
        /// the caller and the API endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceIps
        {
            get { return this._sourceIps; }
            set { this._sourceIps = value; }
        }

        // Check to see if SourceIps property is set
        internal bool IsSetSourceIps()
        {
            return this._sourceIps != null && (this._sourceIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The resulting HTTP response code of the Kubernetes API call action.
        /// </para>
        /// </summary>
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Subresource. 
        /// <para>
        /// The name of the sub-resource in the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string Subresource
        {
            get { return this._subresource; }
            set { this._subresource = value; }
        }

        // Check to see if Subresource property is set
        internal bool IsSetSubresource()
        {
            return this._subresource != null;
        }

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The user agent of the caller of the Kubernetes API.
        /// </para>
        /// </summary>
        public string UserAgent
        {
            get { return this._userAgent; }
            set { this._userAgent = value; }
        }

        // Check to see if UserAgent property is set
        internal bool IsSetUserAgent()
        {
            return this._userAgent != null;
        }

        /// <summary>
        /// Gets and sets the property Verb. 
        /// <para>
        /// The Kubernetes API request HTTP verb.
        /// </para>
        /// </summary>
        public string Verb
        {
            get { return this._verb; }
            set { this._verb = value; }
        }

        // Check to see if Verb property is set
        internal bool IsSetVerb()
        {
            return this._verb != null;
        }

    }
}