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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
        private CaseStatus _caseStatus;
        private DateTime? _closedDate;

        /// <summary>
        /// Gets and sets the property CaseStatus. 
        /// <para>
        /// A response element providing responses for requests to CloseCase. This element responds
        /// with the case status following the action. 
        /// </para>
        /// </summary>
        public CaseStatus CaseStatus
        {
            get { return this._caseStatus; }
            set { this._caseStatus = value; }
        }

        // Check to see if CaseStatus property is set
        internal bool IsSetCaseStatus()
        {
            return this._caseStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClosedDate. 
        /// <para>
        /// A response element providing responses for requests to CloseCase. This element responds
        /// with the case closure date following the action. 
        /// </para>
        /// </summary>
        public DateTime ClosedDate
        {
            get { return this._closedDate.GetValueOrDefault(); }
            set { this._closedDate = value; }
        }

        // Check to see if ClosedDate property is set
        internal bool IsSetClosedDate()
        {
            return this._closedDate.HasValue; 
        }

    }
}