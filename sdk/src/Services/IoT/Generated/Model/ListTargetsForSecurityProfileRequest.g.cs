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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListTargetsForSecurityProfile operation. <note>
    /// <para> The IoT Device Defender detect feature will no longer be available to new customers
    /// starting August 31, 2026. If you would like to use the detect feature, sign up prior
    /// to August 31, 2026. To learn about alternatives to IoT Device Defender detect, see
    /// IoT Device Defender detect feature availability change in the IoT Device Defender
    /// Developer Guide. There is no change to IoT Device Defender audit availability. </para>
    /// </note> <para> Lists the targets (thing groups) associated with a given Device Defender
    /// security profile. </para> <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTargetsForSecurityProfile</a>
    /// action. </para>
    /// </summary>
    public partial class ListTargetsForSecurityProfileRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SecurityProfileName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileName property is set.
        /// </summary>
        internal bool IsSetSecurityProfileName() => this.SecurityProfileName != null;
    }
}
