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
    /// Contains details about a Kubernetes API call.
    /// </summary>
    public partial class KubernetesApiCall
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// The number of matching API calls.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? EventCount { get; set; }

        /// <summary>
        /// Checks to see if the EventCount property is set.
        /// </summary>
        internal bool IsSetEventCount() => this.EventCount.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Kubernetes namespace of the resource.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property RequestUri. 
        /// <para>
        /// The URI of the request.
        /// </para>
        /// </summary>
        public string RequestUri { get; set; }

        /// <summary>
        /// Checks to see if the RequestUri property is set.
        /// </summary>
        internal bool IsSetRequestUri() => this.RequestUri != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the Kubernetes resource.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the Kubernetes resource.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceIps. 
        /// <para>
        /// The source IP addresses of the API call.
        /// </para>
        /// </summary>
        public string SourceIps { get; set; }

        /// <summary>
        /// Checks to see if the SourceIps property is set.
        /// </summary>
        internal bool IsSetSourceIps() => this.SourceIps != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the API call.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The user agent of the caller.
        /// </para>
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// The Kubernetes groups of the caller.
        /// </para>
        /// </summary>
        public string UserGroups { get; set; }

        /// <summary>
        /// Checks to see if the UserGroups property is set.
        /// </summary>
        internal bool IsSetUserGroups() => this.UserGroups != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the caller.
        /// </para>
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The Kubernetes user name of the caller.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;

        /// <summary>
        /// Gets and sets the property Verb. 
        /// <para>
        /// The Kubernetes API verb, such as <c>get</c> or <c>create</c>.
        /// </para>
        /// </summary>
        public string Verb { get; set; }

        /// <summary>
        /// Checks to see if the Verb property is set.
        /// </summary>
        internal bool IsSetVerb() => this.Verb != null;
    }
}
