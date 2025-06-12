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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
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
namespace Amazon.Pricing.Model
{
    /// <summary>
    /// This is the response object from the DescribeServices operation.
    /// </summary>
    public partial class DescribeServicesResponse : AmazonWebServiceResponse
    {
        private string _formatVersion;
        private string _nextToken;
        private List<Service> _services = AWSConfigs.InitializeCollections ? new List<Service>() : null;

        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The format version of the response. For example, <c>aws_v1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next set of retrievable results.
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
        /// Gets and sets the property Services. 
        /// <para>
        /// The service metadata for the service or services in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Service> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && (this._services.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}