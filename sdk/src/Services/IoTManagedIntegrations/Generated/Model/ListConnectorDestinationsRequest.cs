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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the ListConnectorDestinations operation.
    /// Lists all connector destinations, with optional filtering by cloud connector ID.
    /// </summary>
    public partial class ListConnectorDestinationsRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _cloudConnectorId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CloudConnectorId. 
        /// <para>
        /// The identifier of the cloud connector to filter connector destinations by.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudConnectorId
        {
            get { return this._cloudConnectorId; }
            set { this._cloudConnectorId = value; }
        }

        // Check to see if CloudConnectorId property is set
        internal bool IsSetCloudConnectorId()
        {
            return this._cloudConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of connector destinations to return in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// A token used for pagination of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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