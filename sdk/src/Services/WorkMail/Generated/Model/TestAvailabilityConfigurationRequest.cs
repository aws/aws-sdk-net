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
    /// Container for the parameters to the TestAvailabilityConfiguration operation.
    /// Performs a test on an availability provider to ensure that access is allowed. For
    /// EWS, it verifies the provided credentials can be used to successfully log in. For
    /// Lambda, it verifies that the Lambda function can be invoked and that the resource
    /// access policy was configured to deny anonymous access. An anonymous invocation is
    /// one done without providing either a <c>SourceArn</c> or <c>SourceAccount</c> header.
    /// 
    ///  <note> 
    /// <para>
    /// The request must contain either one provider definition (<c>EwsProvider</c> or <c>LambdaProvider</c>)
    /// or the <c>DomainName</c> parameter. If the <c>DomainName</c> parameter is provided,
    /// the configuration stored under the <c>DomainName</c> will be tested.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TestAvailabilityConfigurationRequest : AmazonWorkMailRequest
    {
        private string _domainName;
        private EwsAvailabilityProvider _ewsProvider;
        private LambdaAvailabilityProvider _lambdaProvider;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain to which the provider applies. If this field is provided, a stored availability
        /// provider associated to this domain name will be tested.
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
        /// The WorkMail organization where the availability provider will be tested.
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