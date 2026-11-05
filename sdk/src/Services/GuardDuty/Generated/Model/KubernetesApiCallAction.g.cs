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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the Kubernetes API call action described in this finding.
    /// </summary>
    public partial class KubernetesApiCallAction
    {
        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the namespace where the Kubernetes API call action takes place.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Parameters related to the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property RemoteIpDetails.
        /// </summary>
        public RemoteIpDetails RemoteIpDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIpDetails property is set.
        /// </summary>
        internal bool IsSetRemoteIpDetails() => this.RemoteIpDetails != null;

        /// <summary>
        /// Gets and sets the property RequestUri. 
        /// <para>
        /// The Kubernetes API request URI.
        /// </para>
        /// </summary>
        public string RequestUri { get; set; }

        /// <summary>
        /// Checks to see if the RequestUri property is set.
        /// </summary>
        internal bool IsSetRequestUri() => this.RequestUri != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource component in the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource in the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property SourceIps. 
        /// <para>
        /// The IP of the Kubernetes API caller and the IPs of any proxies or load balancers between
        /// the caller and the API endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceIps property is set.
        /// </summary>
        internal bool IsSetSourceIps() => this.SourceIps != null && (this.SourceIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The resulting HTTP response code of the Kubernetes API call action.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;

        /// <summary>
        /// Gets and sets the property Subresource. 
        /// <para>
        /// The name of the sub-resource in the Kubernetes API call action.
        /// </para>
        /// </summary>
        public string Subresource { get; set; }

        /// <summary>
        /// Checks to see if the Subresource property is set.
        /// </summary>
        internal bool IsSetSubresource() => this.Subresource != null;

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The user agent of the caller of the Kubernetes API.
        /// </para>
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;

        /// <summary>
        /// Gets and sets the property Verb. 
        /// <para>
        /// The Kubernetes API request HTTP verb.
        /// </para>
        /// </summary>
        public string Verb { get; set; }

        /// <summary>
        /// Checks to see if the Verb property is set.
        /// </summary>
        internal bool IsSetVerb() => this.Verb != null;
    }
}
