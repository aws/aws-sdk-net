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
    /// Container for the parameters to the DescribeInsightDetails operation. Describes the
    /// details of an existing insight for an Amazon OpenSearch Service domain. Returns detailed
    /// fields associated with the specified insight, such as text descriptions and metric
    /// data.
    /// </summary>
    public partial class DescribeInsightDetailsRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The entity for which to retrieve insight details. Specifies the type and value of
        /// the entity, such as a domain name or Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightEntity Entity { get; set; }

        /// <summary>
        /// Checks to see if the Entity property is set.
        /// </summary>
        internal bool IsSetEntity() => this.Entity != null;

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The unique identifier of the insight to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InsightId { get; set; }

        /// <summary>
        /// Checks to see if the InsightId property is set.
        /// </summary>
        internal bool IsSetInsightId() => this.InsightId != null;

        /// <summary>
        /// Gets and sets the property ShowHtmlContent. 
        /// <para>
        /// Specifies whether to show response with HTML content in response or not.
        /// </para>
        /// </summary>
        public bool? ShowHtmlContent { get; set; }

        /// <summary>
        /// Checks to see if the ShowHtmlContent property is set.
        /// </summary>
        internal bool IsSetShowHtmlContent() => this.ShowHtmlContent.HasValue;
    }
}
