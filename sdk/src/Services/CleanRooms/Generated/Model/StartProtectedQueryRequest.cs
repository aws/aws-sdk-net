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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the StartProtectedQuery operation.
    /// Creates a protected query that is started by AWS Clean Rooms.
    /// </summary>
    public partial class StartProtectedQueryRequest : AmazonCleanRoomsRequest
    {
        private string _membershipIdentifier;
        private ProtectedQueryResultConfiguration _resultConfiguration;
        private ProtectedQuerySQLParameters _sqlParameters;
        private ProtectedQueryType _type;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for the membership to run this query against. Currently accepts
        /// a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The details needed to write the query results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectedQueryResultConfiguration ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqlParameters. 
        /// <para>
        /// The protected SQL query parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public ProtectedQuerySQLParameters SqlParameters
        {
            get { return this._sqlParameters; }
            set { this._sqlParameters = value; }
        }

        // Check to see if SqlParameters property is set
        internal bool IsSetSqlParameters()
        {
            return this._sqlParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the protected query to be started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectedQueryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}