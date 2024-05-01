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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The status of the case returned by the <a>ResolveCase</a> operation.
    /// </summary>
    public partial class ResolveCaseResponse : AmazonWebServiceResponse
    {
        private string _finalCaseStatus;
        private string _initialCaseStatus;

        /// <summary>
        /// Gets and sets the property FinalCaseStatus. 
        /// <para>
        /// The status of the case after the <a>ResolveCase</a> request was processed.
        /// </para>
        /// </summary>
        public string FinalCaseStatus
        {
            get { return this._finalCaseStatus; }
            set { this._finalCaseStatus = value; }
        }

        // Check to see if FinalCaseStatus property is set
        internal bool IsSetFinalCaseStatus()
        {
            return this._finalCaseStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InitialCaseStatus. 
        /// <para>
        /// The status of the case when the <a>ResolveCase</a> request was sent.
        /// </para>
        /// </summary>
        public string InitialCaseStatus
        {
            get { return this._initialCaseStatus; }
            set { this._initialCaseStatus = value; }
        }

        // Check to see if InitialCaseStatus property is set
        internal bool IsSetInitialCaseStatus()
        {
            return this._initialCaseStatus != null;
        }

    }
}