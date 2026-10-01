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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the ListPodIdentityAssociations operation. List the
    /// EKS Pod Identity associations in a cluster. You can filter the list by the namespace
    /// that the association is in or the service account that the association uses.
    /// </summary>
    public partial class ListPodIdentityAssociationsRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that the associations are in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of EKS Pod Identity association results returned by <c>ListPodIdentityAssociations</c>
        /// in paginated output. When you use this parameter, <c>ListPodIdentityAssociations</c>
        /// returns only <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. You can see the remaining results of the initial request by sending
        /// another <c>ListPodIdentityAssociations</c> request with the returned <c>nextToken</c>
        /// value. This value can be between 1 and 100. If you don't use this parameter, <c>ListPodIdentityAssociations</c>
        /// returns up to 100 results and a <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the Kubernetes namespace inside the cluster that the associations are
        /// in.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated <c>ListUpdates</c> request
        /// where <c>maxResults</c> was used and the results exceeded the value of that parameter.
        /// Pagination continues from the end of the previous results that returned the <c>nextToken</c>
        /// value.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is used only to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceAccount. 
        /// <para>
        /// The name of the Kubernetes service account that the associations use.
        /// </para>
        /// </summary>
        public string ServiceAccount { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccount property is set.
        /// </summary>
        internal bool IsSetServiceAccount() => this.ServiceAccount != null;
    }
}
