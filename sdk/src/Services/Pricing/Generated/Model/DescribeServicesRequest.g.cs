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

namespace Amazon.Pricing.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServices operation. Returns the metadata
    /// for one service or a list of the metadata for all services. Use this without a service
    /// code to get the service codes for all services. Use it with a service code, such as
    /// <c>AmazonEC2</c>, to get information specific to that service, such as the attribute
    /// names available for that service. For example, some of the attribute names available
    /// for EC2 are <c>volumeType</c>, <c>maxIopsVolume</c>, <c>operation</c>, <c>locationType</c>,
    /// and <c>instanceCapacity10xlarge</c>.
    /// </summary>
    public partial class DescribeServicesRequest : AmazonPricingRequest
    {
        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The format version that you want the response to be in.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <c>aws_v1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string FormatVersion { get; set; }

        /// <summary>
        /// Checks to see if the FormatVersion property is set.
        /// </summary>
        internal bool IsSetFormatVersion() => this.FormatVersion != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that you want returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that indicates the next set of results that you want to retrieve.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The code for the service whose information you want to retrieve, such as <c>AmazonEC2</c>.
        /// You can use the <c>ServiceCode</c> to filter the results in a <c>GetProducts</c> call.
        /// To retrieve a list of all services, leave this blank.
        /// </para>
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;
    }
}
