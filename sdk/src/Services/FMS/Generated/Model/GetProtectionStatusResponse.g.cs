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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the GetProtectionStatus operation.
    /// </summary>
    public partial class GetProtectionStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdminAccountId. 
        /// <para>
        /// The ID of the Firewall Manager administrator account for this policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AdminAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AdminAccountId property is set.
        /// </summary>
        internal bool IsSetAdminAccountId() => this.AdminAccountId != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Details about the attack, including the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Attack type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Account ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN of the resource attacked
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time of the attack
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// End time of the attack (ongoing attacks will not have an end time)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The details are in JSON format. 
        /// </para>
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you have more objects than the number that you specified for <c>MaxResults</c>
        /// in the request, the response includes a <c>NextToken</c> value. To list more objects,
        /// submit another <c>GetProtectionStatus</c> request, and specify the <c>NextToken</c>
        /// value from the response in the <c>NextToken</c> value in the next request.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services SDKs provide auto-pagination that identify <c>NextToken</c> in
        /// a response and make subsequent request calls automatically on your behalf. However,
        /// this feature is not supported by <c>GetProtectionStatus</c>. You must submit subsequent
        /// requests with <c>NextToken</c> using your own processes. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The service type that is protected by the policy. Currently, this is always <c>SHIELD_ADVANCED</c>.
        /// </para>
        /// </summary>
        public SecurityServiceType ServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null;
    }
}
