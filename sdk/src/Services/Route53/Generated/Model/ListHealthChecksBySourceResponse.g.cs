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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the ListHealthChecksBySource operation.
    /// </summary>
    public partial class ListHealthChecksBySourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HealthChecks. 
        /// <para>
        /// A complex type that contains one <c>HealthCheck</c> element for each health check
        /// that uses the specified health check source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HealthCheck> HealthChecks { get; set; } = AWSConfigs.InitializeCollections ? new List<HealthCheck>() : null;

        /// <summary>
        /// Checks to see if the HealthChecks property is set.
        /// </summary>
        internal bool IsSetHealthChecks() => this.HealthChecks != null && (this.HealthChecks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The value that you specified for the <c>marker</c> parameter in the call to <c>ListHealthChecksBySource</c>
        /// that produced the current response. This value is present for the second and subsequent
        /// calls to <c>ListHealthChecksBySource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Specifies whether there are more health checks to list. If the value is <c>true</c>,
        /// specify the <c>NextMarker</c> value for <c>marker</c> to get the next group of health
        /// checks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// Checks to see if the IsTruncated property is set.
        /// </summary>
        internal bool IsSetIsTruncated() => this.IsTruncated.HasValue;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// The identifier of the first health check in the next group of health checks. If <c>IsTruncated</c>
        /// is <c>true</c>, specify this value in the <c>marker</c> parameter of another <c>ListHealthChecksBySource</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string NextMarker { get; set; }

        /// <summary>
        /// Checks to see if the NextMarker property is set.
        /// </summary>
        internal bool IsSetNextMarker() => this.NextMarker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <c>maxitems</c> parameter in the call to <c>ListHealthChecksBySource</c>
        /// that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;
    }
}
