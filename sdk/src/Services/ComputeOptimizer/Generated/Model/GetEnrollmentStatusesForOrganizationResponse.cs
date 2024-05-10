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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the GetEnrollmentStatusesForOrganization operation.
    /// </summary>
    public partial class GetEnrollmentStatusesForOrganizationResponse : AmazonWebServiceResponse
    {
        private List<AccountEnrollmentStatus> _accountEnrollmentStatuses = AWSConfigs.InitializeCollections ? new List<AccountEnrollmentStatus>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountEnrollmentStatuses. 
        /// <para>
        /// An array of objects that describe the enrollment statuses of organization member accounts.
        /// </para>
        /// </summary>
        public List<AccountEnrollmentStatus> AccountEnrollmentStatuses
        {
            get { return this._accountEnrollmentStatuses; }
            set { this._accountEnrollmentStatuses = value; }
        }

        // Check to see if AccountEnrollmentStatuses property is set
        internal bool IsSetAccountEnrollmentStatuses()
        {
            return this._accountEnrollmentStatuses != null && (this._accountEnrollmentStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to advance to the next page of account enrollment statuses.
        /// </para>
        ///  
        /// <para>
        /// This value is null when there are no more pages of account enrollment statuses to
        /// return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}