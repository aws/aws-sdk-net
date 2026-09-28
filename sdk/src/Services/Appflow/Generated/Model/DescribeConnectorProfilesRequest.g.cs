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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeConnectorProfiles operation. Returns a
    /// list of <c>connector-profile</c> details matching the provided <c>connector-profile</c>
    /// names and <c>connector-types</c>. Both input lists are optional, and you can use them
    /// to filter the result. <para> If no names or <c>connector-types</c> are provided, returns
    /// all connector profiles in a paginated form. If there is no match, this operation returns
    /// an empty list. </para>
    /// </summary>
    public partial class DescribeConnectorProfilesRequest : AmazonAppflowRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The name of the connector. The name is unique for each <c>ConnectorRegistration</c>
        /// in your Amazon Web Services account. Only needed if calling for CUSTOMCONNECTOR connector
        /// type/.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorLabel property is set.
        /// </summary>
        internal bool IsSetConnectorLabel() => this.ConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property ConnectorProfileNames. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <c>ConnectorProfile</c>
        /// in the Amazon Web Services account. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> ConnectorProfileNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorProfileNames property is set.
        /// </summary>
        internal bool IsSetConnectorProfileNames() => this.ConnectorProfileNames != null && (this.ConnectorProfileNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of items that should be returned in the result set.
        /// The default for <c>maxResults</c> is 20 (for all paginated API operations). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token for the next page of data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
