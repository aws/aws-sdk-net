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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the ListServices operation. Returns a list of services
    /// that have been discovered by Application Signals. A service represents a minimum logical
    /// and transactional unit that completes a business function. Services are discovered
    /// through Application Signals instrumentation.
    /// </summary>
    public partial class ListServicesRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// Amazon Web Services Account ID.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period to retrieve information about. When used in a raw HTTP
        /// Query API, it is formatted as be epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Your requested start time will be rounded to the nearest hour.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using this operation in a monitoring account, specify <c>true</c> to include
        /// services from source accounts in the returned data. 
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccounts() => this.IncludeLinkedAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in one operation. If you omit this parameter,
        /// the default of 50 is used. 
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
        /// Include this value, if it was returned by the previous operation, to get the next
        /// set of services.
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
        /// The start of the time period to retrieve information about. When used in a raw HTTP
        /// Query API, it is formatted as be epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Your requested start time will be rounded to the nearest hour.
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
