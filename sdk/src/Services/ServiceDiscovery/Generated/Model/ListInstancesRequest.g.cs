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

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstances operation. Lists summary information
    /// about the instances that you registered by using a specified service.
    /// </summary>
    public partial class ListInstancesRequest : AmazonServiceDiscoveryRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of instances that you want Cloud Map to return in the response
        /// to a <c>ListInstances</c> request. If you don't specify a value for <c>MaxResults</c>,
        /// Cloud Map returns up to 100 instances.
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
        /// For the first <c>ListInstances</c> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If more than <c>MaxResults</c> instances match the specified criteria, you can submit
        /// another <c>ListInstances</c> request to get the next group of results. Specify the
        /// value of <c>NextToken</c> from the previous response in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service that you want to list instances
        /// for. For services created in a shared namespace, specify the service ARN. For more
        /// information about shared namespaces, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;
    }
}
