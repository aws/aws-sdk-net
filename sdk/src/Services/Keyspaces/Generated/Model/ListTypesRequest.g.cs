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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the ListTypes operation. The <c>ListTypes</c> operation
    /// returns a list of types for a specified keyspace. <para> To read keyspace metadata
    /// using <c>ListTypes</c>, the IAM principal needs <c>Select</c> action permissions for
    /// the system keyspace. To configure the required permissions, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-view">Permissions
    /// to view a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>. </para>
    /// </summary>
    public partial class ListTypesRequest : AmazonKeyspacesRequest
    {
        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace that contains the listed types. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The total number of types to return in the output. If the total number of types available
        /// is more than the value specified, a <c>NextToken</c> is provided in the output. To
        /// resume pagination, provide the <c>NextToken</c> value as an argument of a subsequent
        /// API invocation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token. To resume pagination, provide the <c>NextToken</c> value as
        /// an argument of a subsequent API invocation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
