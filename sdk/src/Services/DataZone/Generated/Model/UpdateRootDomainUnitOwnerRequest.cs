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
    /// Container for the parameters to the UpdateRootDomainUnitOwner operation.
    /// Updates the owner of the root domain unit.
    /// </summary>
    public partial class UpdateRootDomainUnitOwnerRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _currentOwner;
        private string _domainIdentifier;
        private string _newOwner;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CurrentOwner. 
        /// <para>
        /// The current owner of the root domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentOwner
        {
            get { return this._currentOwner; }
            set { this._currentOwner = value; }
        }

        // Check to see if CurrentOwner property is set
        internal bool IsSetCurrentOwner()
        {
            return this._currentOwner != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where the root domain unit owner is to be updated.
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
        /// Gets and sets the property NewOwner. 
        /// <para>
        /// The new owner of the root domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NewOwner
        {
            get { return this._newOwner; }
            set { this._newOwner = value; }
        }

        // Check to see if NewOwner property is set
        internal bool IsSetNewOwner()
        {
            return this._newOwner != null;
        }

    }
}