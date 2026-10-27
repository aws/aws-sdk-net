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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetOperationsForResource operation.
    /// </summary>
    public partial class GetOperationsForResourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextPageCount. 
        /// <para>
        /// (Discontinued) Returns the number of pages of results that remain.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to June 12, 2017, this parameter returned <c>null</c> by the API.
        /// It is now discontinued, and the API returns the <c>next page token</c> parameter instead.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("In releases prior to June 12, 2017, this parameter returned null by the API. It is now deprecated, and the API returns the nextPageToken parameter instead.")]
        public string NextPageCount { get; set; }

        /// <summary>
        /// Checks to see if the NextPageCount property is set.
        /// </summary>
        internal bool IsSetNextPageCount() => this.NextPageCount != null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// A next page token is not returned if there are no more results to display.
        /// </para>
        ///  
        /// <para>
        /// To get the next page of results, perform another <c>GetOperationsForResource</c> request
        /// and specify the next page token using the <c>pageToken</c> parameter.
        /// </para>
        /// </summary>
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// An array of objects that describe the result of the action, such as the status of
        /// the request, the timestamp of the request, and the resources affected by the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Operation> Operations { get; set; } = AWSConfigs.InitializeCollections ? new List<Operation>() : null;

        /// <summary>
        /// Checks to see if the Operations property is set.
        /// </summary>
        internal bool IsSetOperations() => this.Operations != null && (this.Operations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
