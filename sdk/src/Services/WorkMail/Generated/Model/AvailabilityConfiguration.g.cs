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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date and time at which the availability configuration was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The date and time at which the availability configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Checks to see if the DateModified property is set.
        /// </summary>
        internal bool IsSetDateModified() => this.DateModified.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Displays the domain to which the provider applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EwsProvider. 
        /// <para>
        /// If <c>ProviderType</c> is <c>EWS</c>, then this field contains <c>RedactedEwsAvailabilityProvider</c>.
        /// Otherwise, it is not required.
        /// </para>
        /// </summary>
        public RedactedEwsAvailabilityProvider EwsProvider { get; set; }

        /// <summary>
        /// Checks to see if the EwsProvider property is set.
        /// </summary>
        internal bool IsSetEwsProvider() => this.EwsProvider != null;

        /// <summary>
        /// Gets and sets the property LambdaProvider. 
        /// <para>
        /// If ProviderType is <c>LAMBDA</c> then this field contains <c>LambdaAvailabilityProvider</c>.
        /// Otherwise, it is not required.
        /// </para>
        /// </summary>
        public LambdaAvailabilityProvider LambdaProvider { get; set; }

        /// <summary>
        /// Checks to see if the LambdaProvider property is set.
        /// </summary>
        internal bool IsSetLambdaProvider() => this.LambdaProvider != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// Displays the provider type that applies to this domain.
        /// </para>
        /// </summary>
        public AvailabilityProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;
    }
}
