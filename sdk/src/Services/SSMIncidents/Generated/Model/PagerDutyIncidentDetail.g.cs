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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about the PagerDuty incident associated with an incident created by an Incident
    /// Manager response plan.
    /// </summary>
    public partial class PagerDutyIncidentDetail
    {
        /// <summary>
        /// Gets and sets the property AutoResolve. 
        /// <para>
        /// Indicates whether to resolve the PagerDuty incident when you resolve the associated
        /// Incident Manager incident.
        /// </para>
        /// </summary>
        public bool? AutoResolve { get; set; }

        /// <summary>
        /// Checks to see if the AutoResolve property is set.
        /// </summary>
        internal bool IsSetAutoResolve() => this.AutoResolve.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the incident associated with the PagerDuty service for the response plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ID of the Amazon Web Services Secrets Manager secret that stores your PagerDuty
        /// key, either a General Access REST API Key or User Token REST API Key, and other user
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretId property is set.
        /// </summary>
        internal bool IsSetSecretId() => this.SecretId != null;
    }
}
