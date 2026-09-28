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
    /// Container for the parameters to the ListConnectorEntities operation. Returns the list
    /// of available connector entities supported by Amazon AppFlow. For example, you can
    /// query Salesforce for <i>Account</i> and <i>Opportunity</i> entities, or query ServiceNow
    /// for the <i>Incident</i> entity.
    /// </summary>
    public partial class ListConnectorEntitiesRequest : AmazonAppflowRequest
    {
        /// <summary>
        /// Gets and sets the property ApiVersion. 
        /// <para>
        /// The version of the API that's used by the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Checks to see if the ApiVersion property is set.
        /// </summary>
        internal bool IsSetApiVersion() => this.ApiVersion != null;

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <c>ConnectorProfile</c>
        /// in the Amazon Web Services account, and is used to query the downstream connector.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProfileName property is set.
        /// </summary>
        internal bool IsSetConnectorProfileName() => this.ConnectorProfileName != null;

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
        /// Gets and sets the property EntitiesPath. 
        /// <para>
        ///  This optional parameter is specific to connector implementation. Some connectors
        /// support multiple levels or categories of entities. You can find out the list of roots
        /// for such providers by sending a request without the <c>entitiesPath</c> parameter.
        /// If the connector supports entities at different roots, this initial request returns
        /// the list of roots. Otherwise, this request returns all entities supported by the provider.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EntitiesPath { get; set; }

        /// <summary>
        /// Checks to see if the EntitiesPath property is set.
        /// </summary>
        internal bool IsSetEntitiesPath() => this.EntitiesPath != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items that the operation returns in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that was provided by your prior <c>ListConnectorEntities</c> operation if
        /// the response was too big for the page size. You specify this token to get the next
        /// page of results in paginated response.
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
