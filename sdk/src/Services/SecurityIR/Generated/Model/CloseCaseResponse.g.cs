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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// This is the response object from the CloseCase operation.
    /// </summary>
    public partial class CloseCaseResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CaseStatus. 
        /// <para>
        /// A response element providing responses for requests to CloseCase. This element responds
        /// <c>Closed </c> if successful. 
        /// </para>
        /// </summary>
        public CaseStatus CaseStatus { get; set; }

        /// <summary>
        /// Checks to see if the CaseStatus property is set.
        /// </summary>
        internal bool IsSetCaseStatus() => this.CaseStatus != null;

        /// <summary>
        /// Gets and sets the property ClosedDate. 
        /// <para>
        /// A response element providing responses for requests to CloseCase. This element responds
        /// with the ISO-8601 formatted timestamp of the moment when the case was closed. 
        /// </para>
        /// </summary>
        public DateTime? ClosedDate { get; set; }

        /// <summary>
        /// Checks to see if the ClosedDate property is set.
        /// </summary>
        internal bool IsSetClosedDate() => this.ClosedDate.HasValue;
    }
}
