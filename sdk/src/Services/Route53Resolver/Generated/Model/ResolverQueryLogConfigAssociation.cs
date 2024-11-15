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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In the response to an <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverQueryLogConfig.html">AssociateResolverQueryLogConfig</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverQueryLogConfig.html">DisassociateResolverQueryLogConfig</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverQueryLogConfigAssociation.html">GetResolverQueryLogConfigAssociation</a>,
    /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigAssociations.html">ListResolverQueryLogConfigAssociations</a>,
    /// request, a complex type that contains settings for a specified association between
    /// an Amazon VPC and a query logging configuration.
    /// </summary>
    public partial class ResolverQueryLogConfigAssociation
    {
        private string _creationTime;
        private ResolverQueryLogConfigAssociationError _error;
        private string _errorMessage;
        private string _id;
        private string _resolverQueryLogConfigId;
        private string _resourceId;
        private ResolverQueryLogConfigAssociationStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the VPC was associated with the query logging configuration,
        /// in Unix time format and Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// If the value of <c>Status</c> is <c>FAILED</c>, the value of <c>Error</c> indicates
        /// the cause:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DESTINATION_NOT_FOUND</c>: The specified destination (for example, an Amazon S3
        /// bucket) was deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCESS_DENIED</c>: Permissions don't allow sending logs to the destination.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the value of <c>Status</c> is a value other than <c>FAILED</c>, <c>Error</c> is
        /// null. 
        /// </para>
        /// </summary>
        public ResolverQueryLogConfigAssociationError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Contains additional information about the error. If the value or <c>Error</c> is null,
        /// the value of <c>ErrorMessage</c> also is null.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the query logging association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ResolverQueryLogConfigId. 
        /// <para>
        /// The ID of the query logging configuration that a VPC is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ResolverQueryLogConfigId
        {
            get { return this._resolverQueryLogConfigId; }
            set { this._resolverQueryLogConfigId = value; }
        }

        // Check to see if ResolverQueryLogConfigId property is set
        internal bool IsSetResolverQueryLogConfigId()
        {
            return this._resolverQueryLogConfigId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Amazon VPC that is associated with the query logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the specified query logging association. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: Resolver is creating an association between an Amazon VPC and a
        /// query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The association between an Amazon VPC and a query logging configuration
        /// was successfully created. Resolver is logging queries that originate in the specified
        /// VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Resolver is deleting this query logging association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: Resolver either couldn't create or couldn't delete the query logging
        /// association.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverQueryLogConfigAssociationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}