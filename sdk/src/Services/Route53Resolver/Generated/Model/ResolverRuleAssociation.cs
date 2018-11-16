/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In the response to an <a>AssociateResolverRule</a>, <a>DisassociateResolverRule</a>,
    /// or <a>ListResolverRuleAssociations</a> request, information about an association between
    /// a resolver rule and a VPC.
    /// </summary>
    public partial class ResolverRuleAssociation
    {
        private string _id;
        private string _name;
        private string _resolverRuleId;
        private ResolverRuleAssociationStatus _status;
        private string _statusMessage;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association between a resolver rule and a VPC. Resolver assigns this
        /// value when you submit an <a>AssociateResolverRule</a> request.
        /// </para>
        /// </summary>
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
        /// The name of an association between a resolver rule and a VPC.
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
        /// Gets and sets the property ResolverRuleId. 
        /// <para>
        /// The ID of the resolver rule that you associated with the VPC that is specified by
        /// <code>VPCId</code>.
        /// </para>
        /// </summary>
        public string ResolverRuleId
        {
            get { return this._resolverRuleId; }
            set { this._resolverRuleId = value; }
        }

        // Check to see if ResolverRuleId property is set
        internal bool IsSetResolverRuleId()
        {
            return this._resolverRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A code that specifies the current status of the association between a resolver rule
        /// and a VPC.
        /// </para>
        /// </summary>
        public ResolverRuleAssociationStatus Status
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
        /// A detailed description of the status of the association between a resolver rule and
        /// a VPC.
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
        /// Gets and sets the property VPCId. 
        /// <para>
        /// The ID of the VPC that you associated the resolver rule with.
        /// </para>
        /// </summary>
        public string VPCId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VPCId property is set
        internal bool IsSetVPCId()
        {
            return this._vpcId != null;
        }

    }
}