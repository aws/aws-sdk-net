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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFleetAdvisorSchemas operation.
    /// Returns a list of schemas detected by Fleet Advisor Collectors in your account.
    /// </summary>
    public partial class DescribeFleetAdvisorSchemasRequest : AmazonDatabaseMigrationServiceRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  If you specify any of the following filters, the output includes information for
        /// only those schemas that meet the filter criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>complexity</code> – The schema's complexity, for example <code>Simple</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database-id</code> – The ID of the schema's database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database-ip-address</code> – The IP address of the schema's database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database-name</code> – The name of the schema's database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>database-engine</code> – The name of the schema database's engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>original-schema-name</code> – The name of the schema's database's main schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>schema-id</code> – The ID of the schema, for example <code>15</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>schema-name</code> – The name of the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>server-ip-address</code> – The IP address of the schema database's server.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An example is: <code>describe-fleet-advisor-schemas --filter Name="schema-id",Values="50"</code>
        /// 
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Sets the maximum number of records returned in the response.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>NextToken</code> is returned by a previous response, there are more results
        /// available. The value of <code>NextToken</code> is a unique pagination token for each
        /// page. Make the call again using the returned token to retrieve the next page. Keep
        /// all other arguments unchanged. 
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

    }
}