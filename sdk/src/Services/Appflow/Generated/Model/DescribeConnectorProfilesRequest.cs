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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConnectorProfiles operation.
    /// Returns a list of <c>connector-profile</c> details matching the provided <c>connector-profile</c>
    /// names and <c>connector-types</c>. Both input lists are optional, and you can use them
    /// to filter the result. 
    /// 
    ///  
    /// <para>
    /// If no names or <c>connector-types</c> are provided, returns all connector profiles
    /// in a paginated form. If there is no match, this operation returns an empty list.
    /// </para>
    /// </summary>
    public partial class DescribeConnectorProfilesRequest : AmazonAppflowRequest
    {
        private string _connectorLabel;
        private List<string> _connectorProfileNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConnectorType _connectorType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The name of the connector. The name is unique for each <c>ConnectorRegistration</c>
        /// in your Amazon Web Services account. Only needed if calling for CUSTOMCONNECTOR connector
        /// type/.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorLabel
        {
            get { return this._connectorLabel; }
            set { this._connectorLabel = value; }
        }

        // Check to see if ConnectorLabel property is set
        internal bool IsSetConnectorLabel()
        {
            return this._connectorLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileNames. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <c>ConnectorProfile</c>
        /// in the Amazon Web Services account. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ConnectorProfileNames
        {
            get { return this._connectorProfileNames; }
            set { this._connectorProfileNames = value; }
        }

        // Check to see if ConnectorProfileNames property is set
        internal bool IsSetConnectorProfileNames()
        {
            return this._connectorProfileNames != null && (this._connectorProfileNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType
        {
            get { return this._connectorType; }
            set { this._connectorType = value; }
        }

        // Check to see if ConnectorType property is set
        internal bool IsSetConnectorType()
        {
            return this._connectorType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of items that should be returned in the result set.
        /// The default for <c>maxResults</c> is 20 (for all paginated API operations). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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