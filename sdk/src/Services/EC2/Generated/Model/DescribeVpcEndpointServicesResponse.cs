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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeVpcEndpointServices operation.
    /// </summary>
    public partial class DescribeVpcEndpointServicesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServiceDetail> _serviceDetails = new List<ServiceDetail>();
        private List<string> _serviceNames = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items. If there are no additional
        /// items to return, the string is empty.
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
        /// Gets and sets the property ServiceDetails. 
        /// <para>
        /// Information about the service.
        /// </para>
        /// </summary>
        public List<ServiceDetail> ServiceDetails
        {
            get { return this._serviceDetails; }
            set { this._serviceDetails = value; }
        }

        // Check to see if ServiceDetails property is set
        internal bool IsSetServiceDetails()
        {
            return this._serviceDetails != null && this._serviceDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceNames. 
        /// <para>
        /// The supported services.
        /// </para>
        /// </summary>
        public List<string> ServiceNames
        {
            get { return this._serviceNames; }
            set { this._serviceNames = value; }
        }

        // Check to see if ServiceNames property is set
        internal bool IsSetServiceNames()
        {
            return this._serviceNames != null && this._serviceNames.Count > 0; 
        }

    }
}