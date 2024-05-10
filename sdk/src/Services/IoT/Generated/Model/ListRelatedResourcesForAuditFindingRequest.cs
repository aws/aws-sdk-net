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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListRelatedResourcesForAuditFinding operation.
    /// The related resources of an Audit finding. The following resources can be returned
    /// from calling this API:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// DEVICE_CERTIFICATE
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CA_CERTIFICATE
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IOT_POLICY
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// COGNITO_IDENTITY_POOL
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CLIENT_ID
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ACCOUNT_SETTINGS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ROLE_ALIAS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IAM_ROLE
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ISSUER_CERTIFICATE
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// This API is similar to DescribeAuditFinding's <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_DescribeAuditFinding.html">RelatedResources</a>
    /// but provides pagination and is not limited to 10 resources. When calling <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_DescribeAuditFinding.html">DescribeAuditFinding</a>
    /// for the intermediate CA revoked for active device certificates check, RelatedResources
    /// will not be populated. You must use this API, ListRelatedResourcesForAuditFinding,
    /// to list the certificates.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListRelatedResourcesForAuditFindingRequest : AmazonIoTRequest
    {
        private string _findingId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The finding Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string FindingId
        {
            get { return this._findingId; }
            set { this._findingId = value; }
        }

        // Check to see if FindingId property is set
        internal bool IsSetFindingId()
        {
            return this._findingId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that can be used to retrieve the next set of results, or <c>null</c> if there
        /// are no additional results.
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