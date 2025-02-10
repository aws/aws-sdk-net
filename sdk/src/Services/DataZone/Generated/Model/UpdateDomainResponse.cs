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
    /// This is the response object from the UpdateDomain operation.
    /// </summary>
    public partial class UpdateDomainResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _domainExecutionRole;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private string _rootDomainUnitId;
        private string _serviceRole;
        private SingleSignOn _singleSignOn;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateDomain</c> action.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainExecutionRole. 
        /// <para>
        /// The domain execution role to be updated as part of the <c>UpdateDomain</c> action.
        /// </para>
        /// </summary>
        public string DomainExecutionRole
        {
            get { return this._domainExecutionRole; }
            set { this._domainExecutionRole = value; }
        }

        // Check to see if DomainExecutionRole property is set
        internal bool IsSetDomainExecutionRole()
        {
            return this._domainExecutionRole != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Specifies the timestamp of when the domain was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateDomain</c> action.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RootDomainUnitId. 
        /// <para>
        /// The ID of the root domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RootDomainUnitId
        {
            get { return this._rootDomainUnitId; }
            set { this._rootDomainUnitId = value; }
        }

        // Check to see if RootDomainUnitId property is set
        internal bool IsSetRootDomainUnitId()
        {
            return this._rootDomainUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role of the domain.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSignOn. 
        /// <para>
        /// The single sign-on option of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public SingleSignOn SingleSignOn
        {
            get { return this._singleSignOn; }
            set { this._singleSignOn = value; }
        }

        // Check to see if SingleSignOn property is set
        internal bool IsSetSingleSignOn()
        {
            return this._singleSignOn != null;
        }

    }
}