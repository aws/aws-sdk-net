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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ListEndpointAccess operation.
    /// Returns an array of <code>EndpointAccess</code> objects and relevant information.
    /// </summary>
    public partial class ListEndpointAccessRequest : AmazonRedshiftServerlessRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _vpcId;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter that specifies the maximum number of results to return. You
        /// can use <code>nextToken</code> to display the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If your initial <code>ListEndpointAccess</code> operation returns a <code>nextToken</code>,
        /// you can include the returned <code>nextToken</code> in following <code>ListEndpointAccess</code>
        /// operations, which returns results in the next page.
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the virtual private cloud with access to Amazon Redshift
        /// Serverless.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup associated with the VPC endpoint to return.
        /// </para>
        /// </summary>
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}