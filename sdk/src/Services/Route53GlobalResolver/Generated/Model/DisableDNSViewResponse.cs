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
    /// This is the response object from the DisableDNSView operation.
    /// </summary>
    public partial class DisableDNSViewResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clientToken;
        private DateTime? _createdAt;
        private string _description;
        private DnsSecValidationType _dnssecValidation;
        private EdnsClientSubnetType _ednsClientSubnet;
        private FirewallRulesFailOpenType _firewallRulesFailOpen;
        private string _globalResolverId;
        private string _id;
        private string _name;
        private ProfileResourceStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the disabled DNS view.
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
        /// The unique string that identifies the request and ensures idempotency.
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
        /// The date and time when the DNS view was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// The description of the disabled DNS view.
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
        /// Gets and sets the property DnssecValidation. 
        /// <para>
        /// Whether DNSSEC validation is enabled for the disabled DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DnsSecValidationType DnssecValidation
        {
            get { return this._dnssecValidation; }
            set { this._dnssecValidation = value; }
        }

        // Check to see if DnssecValidation property is set
        internal bool IsSetDnssecValidation()
        {
            return this._dnssecValidation != null;
        }

        /// <summary>
        /// Gets and sets the property EdnsClientSubnet. 
        /// <para>
        /// Whether EDNS Client Subnet injection is enabled for the disabled DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdnsClientSubnetType EdnsClientSubnet
        {
            get { return this._ednsClientSubnet; }
            set { this._ednsClientSubnet = value; }
        }

        // Check to see if EdnsClientSubnet property is set
        internal bool IsSetEdnsClientSubnet()
        {
            return this._ednsClientSubnet != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRulesFailOpen. 
        /// <para>
        /// The firewall rules fail-open behavior configured for the disabled DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirewallRulesFailOpenType FirewallRulesFailOpen
        {
            get { return this._firewallRulesFailOpen; }
            set { this._firewallRulesFailOpen = value; }
        }

        // Check to see if FirewallRulesFailOpen property is set
        internal bool IsSetFirewallRulesFailOpen()
        {
            return this._firewallRulesFailOpen != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalResolverId. 
        /// <para>
        /// The ID of the Route 53 Global Resolver that the disabled DNS view is associated with.
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
        /// The unique identifier of the disabled DNS view.
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
        /// The name of the disabled DNS view.
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
        /// The current status of the disabled DNS view.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProfileResourceStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the DNS view was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}