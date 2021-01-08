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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that identifies a hosted zone that a specified Amazon VPC is associated
    /// with and the owner of the hosted zone. If there is a value for <code>OwningAccount</code>,
    /// there is no value for <code>OwningService</code>, and vice versa.
    /// </summary>
    public partial class HostedZoneOwner
    {
        private string _owningAccount;
        private string _owningService;

        /// <summary>
        /// Gets and sets the property OwningAccount. 
        /// <para>
        /// If the hosted zone was created by an AWS account, or was created by an AWS service
        /// that creates hosted zones using the current account, <code>OwningAccount</code> contains
        /// the account ID of that account. For example, when you use AWS Cloud Map to create
        /// a hosted zone, Cloud Map creates the hosted zone using the current AWS account. 
        /// </para>
        /// </summary>
        public string OwningAccount
        {
            get { return this._owningAccount; }
            set { this._owningAccount = value; }
        }

        // Check to see if OwningAccount property is set
        internal bool IsSetOwningAccount()
        {
            return this._owningAccount != null;
        }

        /// <summary>
        /// Gets and sets the property OwningService. 
        /// <para>
        /// If an AWS service uses its own account to create a hosted zone and associate the specified
        /// VPC with that hosted zone, <code>OwningService</code> contains an abbreviation that
        /// identifies the service. For example, if Amazon Elastic File System (Amazon EFS) created
        /// a hosted zone and associated a VPC with the hosted zone, the value of <code>OwningService</code>
        /// is <code>efs.amazonaws.com</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string OwningService
        {
            get { return this._owningService; }
            set { this._owningService = value; }
        }

        // Check to see if OwningService property is set
        internal bool IsSetOwningService()
        {
            return this._owningService != null;
        }

    }
}