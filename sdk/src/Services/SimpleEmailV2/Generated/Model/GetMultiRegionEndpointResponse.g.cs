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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// This is the response object from the GetMultiRegionEndpoint operation.
    /// </summary>
    public partial class GetMultiRegionEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time stamp of when the multi-region endpoint (global-endpoint) was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the multi-region endpoint (global-endpoint).
        /// </para>
        /// </summary>
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the multi-region endpoint (global-endpoint).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time stamp of when the multi-region endpoint (global-endpoint) was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// Contains routes information for the multi-region endpoint (global-endpoint).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> Routes { get; set; } = AWSConfigs.InitializeCollections ? new List<Route>() : null;

        /// <summary>
        /// Checks to see if the Routes property is set.
        /// </summary>
        internal bool IsSetRoutes() => this.Routes != null && (this.Routes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the multi-region endpoint (global-endpoint).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> – The resource is being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> – The resource is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The resource failed to be provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – The resource is being deleted as requested.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
