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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeObservation operation. Describes an anomaly
    /// or error with the application.
    /// </summary>
    public partial class DescribeObservationRequest : AmazonApplicationInsightsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the resource group owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ObservationId. 
        /// <para>
        /// The ID of the observation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 38, Max = 38)]
        public string ObservationId { get; set; }

        /// <summary>
        /// Checks to see if the ObservationId property is set.
        /// </summary>
        internal bool IsSetObservationId() => this.ObservationId != null;
    }
}
