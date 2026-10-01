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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A finding from a <c>BatchUpdateFindings</c> request that Security Hub CSPM was unable
    /// to update.
    /// </summary>
    public partial class BatchUpdateFindingsUnprocessedFinding
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code associated with the error. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ConcurrentUpdateError</c> - Another request attempted to update the finding while
        /// this request was being processed. This error may also occur if you call <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateFindings.html">
        /// <c>BatchUpdateFindings</c> </a> and <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchImportFindings.html">
        /// <c>BatchImportFindings</c> </a> at the same time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DuplicatedFindingIdentifier</c> - The request included two or more findings with
        /// the same <c>FindingIdentifier</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FindingNotFound</c> - The <c>FindingIdentifier</c> included in the request did
        /// not match an existing finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FindingSizeExceeded</c> - The finding size was greater than the permissible value
        /// of 240 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InternalFailure</c> - An internal service failure occurred when updating the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidInput</c> - The finding update contained an invalid value that did not
        /// satisfy the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-findings-format.html">Amazon
        /// Web Services Security Finding Format</a> syntax.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The message associated with the error. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Concurrent finding updates detected</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Finding Identifier is duplicated</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Finding Not Found</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Finding size exceeded 240 KB</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Internal service failure</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Invalid Input</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property FindingIdentifier. 
        /// <para>
        /// The identifier of the finding that was not updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AwsSecurityFindingIdentifier FindingIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FindingIdentifier property is set.
        /// </summary>
        internal bool IsSetFindingIdentifier() => this.FindingIdentifier != null;
    }
}
