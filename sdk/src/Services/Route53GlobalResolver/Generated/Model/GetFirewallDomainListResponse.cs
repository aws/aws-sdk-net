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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
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
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// This is the response object from the GetFirewallDomainList operation.
    /// </summary>
    public partial class GetFirewallDomainListResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clientToken;
        private DateTime? _createdAt;
        private string _description;
        private int? _domainCount;
        private string _globalResolverId;
        private string _id;
        private string _name;
        private CRResourceStatus _status;
        private string _statusMessage;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency. This means that making
        /// the same request multiple times with the same <c>clientToken</c> has the same result
        /// every time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time and date the domain list was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property DomainCount. 
        /// <para>
        /// Number of domains in the domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DomainCount
        {
            get { return this._domainCount; }
            set { this._domainCount = value; }
        }

        // Check to see if DomainCount property is set
        internal bool IsSetDomainCount()
        {
            return this._domainCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalResolverId. 
        /// <para>
        /// ID of the Global Resolver that the domain list is associated to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string GlobalResolverId
        {
            get { return this._globalResolverId; }
            set { this._globalResolverId = value; }
        }

        // Check to see if GlobalResolverId property is set
        internal bool IsSetGlobalResolverId()
        {
            return this._globalResolverId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID of the domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Operational status of the domain list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CRResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional information about the status of the domain list.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the domain list was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}