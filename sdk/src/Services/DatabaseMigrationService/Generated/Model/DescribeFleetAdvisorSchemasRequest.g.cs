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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFleetAdvisorSchemas operation. <important>
    /// <para> End of support notice: On May 20, 2026, Amazon Web Services will end support
    /// for Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer
    /// be able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web
    /// Services DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
    /// Web Services DMS Fleet Advisor end of support</a>. </para> </important> <para> Returns
    /// a list of schemas detected by Fleet Advisor Collectors in your account. </para>
    /// </summary>
    public partial class DescribeFleetAdvisorSchemasRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  If you specify any of the following filters, the output includes information for
        /// only those schemas that meet the filter criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>complexity</c> – The schema's complexity, for example <c>Simple</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database-id</c> – The ID of the schema's database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database-ip-address</c> – The IP address of the schema's database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database-name</c> – The name of the schema's database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>database-engine</c> – The name of the schema database's engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>original-schema-name</c> – The name of the schema's database's main schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>schema-id</c> – The ID of the schema, for example <c>15</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>schema-name</c> – The name of the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>server-ip-address</c> – The IP address of the schema database's server.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An example is: <c>describe-fleet-advisor-schemas --filter Name="schema-id",Values="50"</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Sets the maximum number of records returned in the response.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>NextToken</c> is returned by a previous response, there are more results available.
        /// The value of <c>NextToken</c> is a unique pagination token for each page. Make the
        /// call again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
