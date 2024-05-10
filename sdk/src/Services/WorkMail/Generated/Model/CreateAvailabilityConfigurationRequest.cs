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
    /// Container for the parameters to the CreateAvailabilityConfiguration operation.
    /// Creates an <c>AvailabilityConfiguration</c> for the given WorkMail organization and
    /// domain.
    /// </summary>
    public partial class CreateAvailabilityConfigurationRequest : AmazonWorkMailRequest
    {
        private string _clientToken;
        private string _domainName;
        private EwsAvailabilityProvider _ewsProvider;
        private LambdaAvailabilityProvider _lambdaProvider;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotent token that ensures that an API request is executed only once.
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain to which the provider applies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// Exchange Web Services (EWS) availability provider definition. The request must contain
        /// exactly one provider definition, either <c>EwsProvider</c> or <c>LambdaProvider</c>.
        /// </para>
        /// </summary>
        public EwsAvailabilityProvider EwsProvider
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
        /// Lambda availability provider definition. The request must contain exactly one provider
        /// definition, either <c>EwsProvider</c> or <c>LambdaProvider</c>.
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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization for which the <c>AvailabilityConfiguration</c> will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}