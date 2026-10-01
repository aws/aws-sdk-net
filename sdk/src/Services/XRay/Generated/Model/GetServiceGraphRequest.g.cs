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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the GetServiceGraph operation. Retrieves a document
    /// that describes services that process incoming requests, and downstream services that
    /// they call as a result. Root services process incoming requests and make calls to downstream
    /// services. Root services are applications that use the <a href="https://docs.aws.amazon.com/xray/index.html">Amazon
    /// Web Services X-Ray SDK</a>. Downstream services can be other applications, Amazon
    /// Web Services resources, HTTP web APIs, or SQL databases.
    /// </summary>
    public partial class GetServiceGraphRequest : AmazonXRayRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the timeframe for which to generate a graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property GroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a group based on which you want to generate a graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public string GroupARN { get; set; }

        /// <summary>
        /// Checks to see if the GroupARN property is set.
        /// </summary>
        internal bool IsSetGroupARN() => this.GroupARN != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of a group based on which you want to generate a graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time frame for which to generate a graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
