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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrust operation.
    /// AWS Directory Service for Microsoft Active Directory allows you to configure trust
    /// relationships. For example, you can establish a trust between your Microsoft AD in
    /// the AWS cloud, and your existing on-premises Microsoft Active Directory. This would
    /// allow you to provide users and groups access to resources in either domain, with a
    /// single set of credentials.
    /// 
    /// 
    /// <para>
    /// This action initiates the creation of the AWS side of a trust relationship between
    /// a Microsoft AD in the AWS cloud and an external domain.
    /// </para>
    /// </summary>
    public partial class CreateTrustRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private string _remoteDomainName;
        private TrustDirection _trustDirection;
        private string _trustPassword;
        private TrustType _trustType;

        /// <summary>
        /// Gets and sets the property DirectoryId. The Directory ID of the Microsoft AD in the
        /// AWS cloud for which to establish the trust relationship.
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDomainName. The Fully Qualified Domain Name (FQDN)
        /// of the external domain for which to create the trust relationship.
        /// </summary>
        public string RemoteDomainName
        {
            get { return this._remoteDomainName; }
            set { this._remoteDomainName = value; }
        }

        // Check to see if RemoteDomainName property is set
        internal bool IsSetRemoteDomainName()
        {
            return this._remoteDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property TrustDirection. The direction of the trust relationship.
        /// </summary>
        public TrustDirection TrustDirection
        {
            get { return this._trustDirection; }
            set { this._trustDirection = value; }
        }

        // Check to see if TrustDirection property is set
        internal bool IsSetTrustDirection()
        {
            return this._trustDirection != null;
        }

        /// <summary>
        /// Gets and sets the property TrustPassword. The trust password. The must be the same
        /// password that was used when creating the trust relationship on the external domain.
        /// </summary>
        public string TrustPassword
        {
            get { return this._trustPassword; }
            set { this._trustPassword = value; }
        }

        // Check to see if TrustPassword property is set
        internal bool IsSetTrustPassword()
        {
            return this._trustPassword != null;
        }

        /// <summary>
        /// Gets and sets the property TrustType. The trust relationship type.
        /// </summary>
        public TrustType TrustType
        {
            get { return this._trustType; }
            set { this._trustType = value; }
        }

        // Check to see if TrustType property is set
        internal bool IsSetTrustType()
        {
            return this._trustType != null;
        }

    }
}