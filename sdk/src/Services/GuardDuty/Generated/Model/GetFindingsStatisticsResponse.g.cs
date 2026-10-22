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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the GetFindingsStatistics operation.
    /// </summary>
    public partial class GetFindingsStatisticsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FindingStatistics. 
        /// <para>
        /// The finding statistics object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingStatistics FindingStatistics { get; set; }

        /// <summary>
        /// Checks to see if the FindingStatistics property is set.
        /// </summary>
        internal bool IsSetFindingStatistics() => this.FindingStatistics != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination parameter to be used on the next list operation to retrieve more items.
        /// </para>
        ///  
        /// <para>
        /// This parameter is currently not supported.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
