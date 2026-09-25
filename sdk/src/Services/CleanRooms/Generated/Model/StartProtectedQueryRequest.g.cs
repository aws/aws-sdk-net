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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the StartProtectedQuery operation. Creates a protected
    /// query that is started by Clean Rooms.
    /// </summary>
    public partial class StartProtectedQueryRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        ///  The compute configuration for the protected query.
        /// </para>
        /// </summary>
        public ComputeConfiguration ComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetComputeConfiguration() => this.ComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for the membership to run this query against. Currently accepts
        /// a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property QueryComputePayerAccountId. 
        /// <para>
        /// The account ID of the member that pays for the query compute costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string QueryComputePayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the QueryComputePayerAccountId property is set.
        /// </summary>
        internal bool IsSetQueryComputePayerAccountId() => this.QueryComputePayerAccountId != null;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The details needed to write the query results.
        /// </para>
        /// </summary>
        public ProtectedQueryResultConfiguration ResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfiguration property is set.
        /// </summary>
        internal bool IsSetResultConfiguration() => this.ResultConfiguration != null;

        /// <summary>
        /// Gets and sets the property SqlParameters. 
        /// <para>
        /// The protected SQL query parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ProtectedQuerySQLParameters SqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqlParameters property is set.
        /// </summary>
        internal bool IsSetSqlParameters() => this.SqlParameters != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the protected query to be started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProtectedQueryType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
