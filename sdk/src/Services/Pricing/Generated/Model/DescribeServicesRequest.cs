/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pricing.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServices operation.
    /// Returns the metadata for one service or a list of the metadata for all services. Use
    /// this without a service code to get the service codes for all services. Use it with
    /// a service code, such as <code>AmazonEC2</code>, to get information specific to that
    /// service, such as the attribute names available for that service. For example, some
    /// of the attribute names available for EC2 are <code>volumeType</code>, <code>maxIopsVolume</code>,
    /// <code>operation</code>, <code>locationType</code>, and <code>instanceCapacity10xlarge</code>.
    /// </summary>
    public partial class DescribeServicesRequest : AmazonPricingRequest
    {
        private string _formatVersion;
        private int? _maxResults;
        private string _nextToken;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The format version that you want the response to be in.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <code>aws_v1</code> 
        /// </para>
        /// </summary>
        public string FormatVersion
        {
            get { return this._formatVersion; }
            set { this._formatVersion = value; }
        }

        // Check to see if FormatVersion property is set
        internal bool IsSetFormatVersion()
        {
            return this._formatVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that you want returned in the response.
        /// </para>
        /// </summary>
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
        /// The pagination token that indicates the next set of results that you want to retrieve.
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
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The code for the service whose information you want to retrieve, such as <code>AmazonEC2</code>.
        /// You can use the <code>ServiceCode</code> to filter the results in a <code>GetProducts</code>
        /// call. To retrieve a list of all services, leave this blank.
        /// </para>
        /// </summary>
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

    }
}