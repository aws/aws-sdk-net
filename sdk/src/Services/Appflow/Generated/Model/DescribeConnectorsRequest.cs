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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConnectors operation.
    /// Describes the connectors vended by Amazon AppFlow for specified connector types.
    /// If you don't specify a connector type, this operation describes all connectors vended
    /// by Amazon AppFlow. If there are more connectors than can be returned in one page,
    /// the response contains a <code>nextToken</code> object, which can be be passed in to
    /// the next call to the <code>DescribeConnectors</code> API operation to retrieve the
    /// next page.
    /// </summary>
    public partial class DescribeConnectorsRequest : AmazonAppflowRequest
    {
        private List<string> _connectorTypes = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConnectorTypes. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ConnectorTypes
        {
            get { return this._connectorTypes; }
            set { this._connectorTypes = value; }
        }

        // Check to see if ConnectorTypes property is set
        internal bool IsSetConnectorTypes()
        {
            return this._connectorTypes != null && this._connectorTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token for the next page of data. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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