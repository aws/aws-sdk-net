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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateCase operation.
    /// </summary>
    public partial class BatchUpdateCaseResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FailedCases. 
        /// <para>
        /// The list of cases that were not updated. Each entry includes an error code and message.
        /// Possible error codes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CASE_NOT_FOUND</c> - No case exists with the specified case ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VALIDATION_ERROR</c> - The request contains invalid input.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFLICT</c> - Another operation is in progress on the case, such as a concurrent
        /// update or a merge of the case into another case.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THROTTLED</c> - The request rate exceeded the allowed limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCESS_DENIED</c> - The caller lacks permission to perform the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE_QUOTA_EXCEEDED</c> - The request exceeded a service quota.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DOMAIN_NOT_FOUND</c> - The case domain was deleted while the request was being
        /// processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c> - An unexpected error occurred on the server.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchUpdateCaseErrorEntry> FailedCases { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchUpdateCaseErrorEntry>() : null;

        /// <summary>
        /// Checks to see if the FailedCases property is set.
        /// </summary>
        internal bool IsSetFailedCases() => this.FailedCases != null && (this.FailedCases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuccessfulCases. 
        /// <para>
        /// The list of cases that were successfully updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchUpdateCaseSuccessEntry> SuccessfulCases { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchUpdateCaseSuccessEntry>() : null;

        /// <summary>
        /// Checks to see if the SuccessfulCases property is set.
        /// </summary>
        internal bool IsSetSuccessfulCases() => this.SuccessfulCases != null && (this.SuccessfulCases.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
