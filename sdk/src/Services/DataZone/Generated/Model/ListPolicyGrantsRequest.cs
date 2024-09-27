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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListPolicyGrants operation.
    /// Lists policy grants.
    /// </summary>
    public partial class ListPolicyGrantsRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _entityIdentifier;
        private TargetEntityType _entityType;
        private int? _maxResults;
        private string _nextToken;
        private ManagedPolicyType _policyType;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where you want to list policy grants.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// The ID of the entity for which you want to list policy grants.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EntityIdentifier
        {
            get { return this._entityIdentifier; }
            set { this._entityIdentifier = value; }
        }

        // Check to see if EntityIdentifier property is set
        internal bool IsSetEntityIdentifier()
        {
            return this._entityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entity for which you want to list policy grants.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetEntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of grants to return in a single call to <c>ListPolicyGrants</c>.
        /// When the number of grants to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>ListPolicyGrants</c> to list the next set of grants.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// When the number of grants is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of grants, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>ListPolicyGrants</c>
        /// to list the next set of grants.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy that you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagedPolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}