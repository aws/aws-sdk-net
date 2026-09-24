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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// This is the response object from the GetDedicatedIps operation.
    /// </summary>
    public partial class GetDedicatedIpsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DedicatedIps. 
        /// <para>
        /// A list of dedicated IP addresses that are reserved for use by your Amazon Pinpoint
        /// account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DedicatedIp> DedicatedIps { get; set; } = AWSConfigs.InitializeCollections ? new List<DedicatedIp>() : null;

        /// <summary>
        /// Checks to see if the DedicatedIps property is set.
        /// </summary>
        internal bool IsSetDedicatedIps() => this.DedicatedIps != null && (this.DedicatedIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there are additional dedicated IP addresses to list. To
        /// view additional addresses, issue another request to <c>GetDedicatedIps</c>, passing
        /// this token in the <c>NextToken</c> parameter.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
