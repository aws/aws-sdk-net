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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeResourcePermissions operation. Describes
    /// the permissions of a specified resource.
    /// </summary>
    public partial class DescribeResourcePermissionsRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8199)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationToken property is set.
        /// </summary>
        internal bool IsSetAuthenticationToken() => this.AuthenticationToken != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results. (You received this marker from a previous
        /// call)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The ID of the principal to filter permissions by.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
