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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the RegisterCapability operation.
    /// </summary>
    public partial class RegisterCapabilityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the OpenSearch UI application.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CapabilityConfig. 
        /// <para>
        /// The configuration settings for the registered capability.
        /// </para>
        /// </summary>
        public CapabilityBaseResponseConfig CapabilityConfig { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityConfig property is set.
        /// </summary>
        internal bool IsSetCapabilityConfig() => this.CapabilityConfig != null;

        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// The name of the registered capability.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 30)]
        public string CapabilityName { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityName property is set.
        /// </summary>
        internal bool IsSetCapabilityName() => this.CapabilityName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the capability. Possible values: <c>creating</c>, <c>create_failed</c>,
        /// <c>active</c>, <c>updating</c>, <c>update_failed</c>, <c>deleting</c>, <c>delete_failed</c>.
        /// </para>
        /// </summary>
        public CapabilityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
