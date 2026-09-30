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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetSegmentEstimate operation.
    /// </summary>
    public partial class GetSegmentEstimateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Estimate. 
        /// <para>
        /// The estimated number of profiles contained in the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Estimate { get; set; }

        /// <summary>
        /// Checks to see if the Estimate property is set.
        /// </summary>
        internal bool IsSetEstimate() => this.Estimate != null;

        /// <summary>
        /// Gets and sets the property EstimateId. 
        /// <para>
        /// The <c>QueryId</c> which is the same as the value passed in <c>QueryId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EstimateId { get; set; }

        /// <summary>
        /// Checks to see if the EstimateId property is set.
        /// </summary>
        internal bool IsSetEstimateId() => this.EstimateId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message if there is any error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the query.
        /// </para>
        /// </summary>
        public EstimateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the segment estimate.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;
    }
}
