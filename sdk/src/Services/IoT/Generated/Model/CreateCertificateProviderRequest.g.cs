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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCertificateProvider operation. Creates an
    /// Amazon Web Services IoT Core certificate provider. You can use Amazon Web Services
    /// IoT Core certificate provider to customize how to sign a certificate signing request
    /// (CSR) in IoT fleet provisioning. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provisioning-cert-provider.html">Customizing
    /// certificate signing using Amazon Web Services IoT Core certificate provider</a> from
    /// <i>Amazon Web Services IoT Core Developer Guide</i>. <para> Requires permission to
    /// access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateCertificateProvider</a>
    /// action. </para> <important> <para> After you create a certificate provider, the behavior
    /// of <a href="https://docs.aws.amazon.com/iot/latest/developerguide/fleet-provision-api.html#create-cert-csr">
    /// <c>CreateCertificateFromCsr</c> API for fleet provisioning</a> will change and all
    /// API calls to <c>CreateCertificateFromCsr</c> will invoke the certificate provider
    /// to create the certificates. It can take up to a few minutes for this behavior to change
    /// after a certificate provider is created. </para> </important>
    /// </summary>
    public partial class CreateCertificateProviderRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AccountDefaultForOperations. 
        /// <para>
        /// A list of the operations that the certificate provider will use to generate certificates.
        /// Valid value: <c>CreateCertificateFromCsr</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> AccountDefaultForOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountDefaultForOperations property is set.
        /// </summary>
        internal bool IsSetAccountDefaultForOperations() => this.AccountDefaultForOperations != null && (this.AccountDefaultForOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CertificateProviderName. 
        /// <para>
        /// The name of the certificate provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string CertificateProviderName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateProviderName property is set.
        /// </summary>
        internal bool IsSetCertificateProviderName() => this.CertificateProviderName != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A string that you can optionally pass in the <c>CreateCertificateProvider</c> request
        /// to make sure the request is idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// The ARN of the Lambda function that defines the authentication logic.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LambdaFunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionArn property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionArn() => this.LambdaFunctionArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the certificate provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
