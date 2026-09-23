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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the GetSparqlStatistics operation.
    /// </summary>
    public partial class GetSparqlStatisticsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Statistics for RDF data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Statistics Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP return code of the request. If the request succeeded, the code is 200. See
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/neptune-dfe-statistics.html#neptune-dfe-statistics-errors">Common
        /// error codes for DFE statistics request</a> for a list of common errors.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstatisticsstatus">neptune-db:GetStatisticsStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
