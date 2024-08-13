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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// List all the <c>AvailabilityConfiguration</c>'s for the given WorkMail organization.
    /// </summary>
    public partial class AvailabilityConfiguration
    {
        private DateTime? _dateCreated;
        private DateTime? _dateModified;
        private string _domainName;
        private RedactedEwsAvailabilityProvider _ewsProvider;
        private LambdaAvailabilityProvider _lambdaProvider;
        private AvailabilityProviderType _providerType;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date and time at which the availability configuration was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The date and time at which the availability configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified
        {
            get { return this._dateModified; }
            set { this._dateModified = value; }
        }

        // Check to see if DateModified property is set
        internal bool IsSetDateModified()
        {
            return this._dateModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Displays the domain to which the provider applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EwsProvider. 
        /// <para>
        /// If <c>ProviderType</c> is <c>EWS</c>, then this field contains <c>RedactedEwsAvailabilityProvider</c>.
        /// Otherwise, it is not required.
        /// </para>
        /// </summary>
        public RedactedEwsAvailabilityProvider EwsProvider
        {
            get { return this._ewsProvider; }
            set { this._ewsProvider = value; }
        }

        // Check to see if EwsProvider property is set
        internal bool IsSetEwsProvider()
        {
            return this._ewsProvider != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaProvider. 
        /// <para>
        /// If ProviderType is <c>LAMBDA</c> then this field contains <c>LambdaAvailabilityProvider</c>.
        /// Otherwise, it is not required.
        /// </para>
        /// </summary>
        public LambdaAvailabilityProvider LambdaProvider
        {
            get { return this._lambdaProvider; }
            set { this._lambdaProvider = value; }
        }

        // Check to see if LambdaProvider property is set
        internal bool IsSetLambdaProvider()
        {
            return this._lambdaProvider != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// Displays the provider type that applies to this domain.
        /// </para>
        /// </summary>
        public AvailabilityProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

    }
}