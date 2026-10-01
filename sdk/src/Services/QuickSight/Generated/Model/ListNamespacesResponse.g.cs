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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the ListNamespaces operation.
    /// </summary>
    public partial class ListNamespacesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Namespaces. 
        /// <para>
        /// The information about the namespaces in this Amazon Web Services account. The response
        /// includes the namespace ARN, name, Amazon Web Services Region, notification email address,
        /// creation status, and identity store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NamespaceInfoV2> Namespaces { get; set; } = AWSConfigs.InitializeCollections ? new List<NamespaceInfoV2>() : null;

        /// <summary>
        /// Checks to see if the Namespaces property is set.
        /// </summary>
        internal bool IsSetNamespaces() => this.Namespaces != null && (this.Namespaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A unique pagination token that can be used in a subsequent request. Receiving <c>NextToken</c>
        /// in your response inticates that there is more data that can be returned. To receive
        /// the data, make another <c>ListNamespaces</c> API call with the returned token to retrieve
        /// the next page of data. Each token is valid for 24 hours. If you try to make a <c>ListNamespaces</c>
        /// API call with an expired token, you will receive a <c>HTTP 400 InvalidNextTokenException</c>
        /// error.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;
    }
}
