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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.TaxSettings.Model;
using Amazon.TaxSettings.Model.Internal.MarshallTransformations;
using Amazon.TaxSettings.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.TaxSettings
{
    /// <summary>
    /// <para>Implementation for accessing TaxSettings</para>
    ///
    /// You can use the tax setting API to programmatically set, modify, and delete the tax
    /// registration number (TRN), associated business legal name, and address (Collectively
    /// referred to as "TRN information"). You can also programmatically view TRN information
    /// and tax addresses ("Tax profiles"). 
    /// 
    ///  
    /// <para>
    /// You can use this API to automate your TRN information settings instead of manually
    /// using the console.
    /// </para>
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://tax.us-east-1.amazonaws.com
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonTaxSettingsClient : AmazonServiceClient, IAmazonTaxSettings
    {
        private static IServiceMetadata serviceMetadata = new AmazonTaxSettingsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonTaxSettingsClient()
            : base(new AmazonTaxSettingsConfig()) { }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonTaxSettingsClient(RegionEndpoint region)
            : base(new AmazonTaxSettingsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonTaxSettingsClient Configuration Object</param>
        public AmazonTaxSettingsClient(AmazonTaxSettingsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTaxSettingsClient(AWSCredentials credentials)
            : this(credentials, new AmazonTaxSettingsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTaxSettingsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTaxSettingsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Credentials and an
        /// AmazonTaxSettingsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTaxSettingsClient Configuration Object</param>
        public AmazonTaxSettingsClient(AWSCredentials credentials, AmazonTaxSettingsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTaxSettingsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTaxSettingsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTaxSettingsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTaxSettingsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTaxSettingsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTaxSettingsClient Configuration Object</param>
        public AmazonTaxSettingsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTaxSettingsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTaxSettingsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTaxSettingsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTaxSettingsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTaxSettingsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTaxSettingsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTaxSettingsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTaxSettingsClient Configuration Object</param>
        public AmazonTaxSettingsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTaxSettingsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ITaxSettingsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITaxSettingsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TaxSettingsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTaxSettingsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTaxSettingsAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  BatchDeleteTaxRegistration

        internal virtual BatchDeleteTaxRegistrationResponse BatchDeleteTaxRegistration(BatchDeleteTaxRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTaxRegistrationResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTaxRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Deletes tax registration for multiple accounts in batch. This can be used to delete
        /// tax registrations for up to five accounts in one batch. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can't be used to delete your tax registration in Brazil. Use the
        /// <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/BatchDeleteTaxRegistration">REST API Reference for BatchDeleteTaxRegistration Operation</seealso>
        public virtual Task<BatchDeleteTaxRegistrationResponse> BatchDeleteTaxRegistrationAsync(BatchDeleteTaxRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTaxRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTaxRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetTaxExemptions

        internal virtual BatchGetTaxExemptionsResponse BatchGetTaxExemptions(BatchGetTaxExemptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetTaxExemptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTaxExemptionsResponseUnmarshaller.Instance;

            return Invoke<BatchGetTaxExemptionsResponse>(request, options);
        }



        /// <summary>
        /// Get the active tax exemptions for a given list of accounts. The IAM action is <c>tax:GetExemptions</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTaxExemptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTaxExemptions service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/BatchGetTaxExemptions">REST API Reference for BatchGetTaxExemptions Operation</seealso>
        public virtual Task<BatchGetTaxExemptionsResponse> BatchGetTaxExemptionsAsync(BatchGetTaxExemptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetTaxExemptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTaxExemptionsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetTaxExemptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchPutTaxRegistration

        internal virtual BatchPutTaxRegistrationResponse BatchPutTaxRegistration(BatchPutTaxRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutTaxRegistrationResponseUnmarshaller.Instance;

            return Invoke<BatchPutTaxRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates tax registration for multiple accounts in batch. This can be used
        /// to add or update tax registrations for up to five accounts in one batch. You can't
        /// set a TRN if there's a pending TRN. You'll need to delete the pending TRN first.
        /// 
        ///  
        /// <para>
        /// To call this API operation for specific countries, see the following country-specific
        /// requirements.
        /// </para>
        ///  
        /// <para>
        ///  <b>Bangladesh</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Brazil</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must complete the tax registration process in the <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console. After your TRN and
        /// billing address are verified, you can call this API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Web Services accounts created through Organizations, you can call this
        /// API operation when you don't have a billing address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Georgia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The valid <c>personType</c> values are <c>Physical Person</c> and <c>Business</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Indonesia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PutTaxRegistration</c>: The use of this operation to submit tax information is
        /// subject to the <a href="http://aws.amazon.com/service-terms/">Amazon Web Services
        /// service terms</a>. By submitting, you’re providing consent for Amazon Web Services
        /// to validate NIK, NPWP, and NITKU data, provided by you with the Directorate General
        /// of Taxes of Indonesia in accordance with the Minister of Finance Regulation (PMK)
        /// Number 112/PMK.03/2022.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BatchPutTaxRegistration</c>: The use of this operation to submit tax information
        /// is subject to the <a href="http://aws.amazon.com/service-terms/">Amazon Web Services
        /// service terms</a>. By submitting, you’re providing consent for Amazon Web Services
        /// to validate NIK, NPWP, and NITKU data, provided by you with the Directorate General
        /// of Taxes of Indonesia in accordance with the Minister of Finance Regulation (PMK)
        /// Number 112/PMK.03/2022, through our third-party partner PT Achilles Advanced Management
        /// (OnlinePajak).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>taxRegistrationNumberType</c> in the <c>indonesiaAdditionalInfo</c>
        /// field of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>decisionNumber</c>, you must specify the <c>ppnExceptionDesignationCode</c>
        /// in the <c>indonesiaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. If the <c>taxRegistrationNumberType</c> is set to NPWP or NITKU, valid values
        /// for <c>ppnExceptionDesignationCode</c> are either <c>01</c>, <c>02</c>, <c>03</c>,
        /// <c>07</c>, or <c>08</c>.
        /// </para>
        ///  
        /// <para>
        /// For other <c>taxRegistrationNumberType</c> values, <c>ppnExceptionDesignationCode</c>
        /// must be either <c>01</c>, <c>07</c>, or <c>08</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>ppnExceptionDesignationCode</c> is <c>07</c>, you must specify the <c>decisionNumber</c>
        /// in the <c>indonesiaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Kenya</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>personType</c> in the <c>kenyaAdditionalInfo</c> field of
        /// the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>personType</c> is <c>Physical Person</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Malaysia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RegistrationType</c> valid values are <c>NRIC</c> for individual, and TIN and
        /// sales and service tax (SST) for Business.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid <c>MyKad</c> or NRIC number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business, you must specify a <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a TIN type and tax identification number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers, you must specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c>
        /// in <c>MalaysiaAdditionalInfo</c> with a sales and service tax (SST) type and a valid
        /// SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services reserves the right to seek additional information and/or take
        /// other actions to support your self-declaration as appropriate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services is currently registered under the following service tax codes.
        /// You must include at least one of the service tax codes in the service tax code strings
        /// to declare yourself as an authorized registered business reseller.
        /// </para>
        ///  
        /// <para>
        /// Taxable service and service tax codes:
        /// </para>
        ///  
        /// <para>
        /// Consultancy - 9907061674
        /// </para>
        ///  
        /// <para>
        /// Training or coaching service - 9907071685
        /// </para>
        ///  
        /// <para>
        /// IT service - 9907101676
        /// </para>
        ///  
        /// <para>
        /// Digital services and electronic medium - 9907121690
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Nepal</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Saudi Arabia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>addressLine3</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>South Korea</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>certifiedEmailId</c> and <c>legalName</c> in the <c>TaxRegistrationEntry</c>
        /// object. Use Korean characters for <c>legalName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>businessRepresentativeName</c>, <c>itemOfBusiness</c>, and
        /// <c>lineOfBusiness</c> in the <c>southKoreaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. Use Korean characters for these fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>address</c> object, use Korean characters for <c>addressLine1</c>, <c>addressLine2</c>
        /// <c>city</c>, <c>postalCode</c>, and <c>stateOrRegion</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Spain</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>registrationType</c> in the <c>spainAdditionalInfo</c> field
        /// of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>registrationType</c> is <c>Local</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Turkey</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>sector</c> in the <c>taxRegistrationEntry</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c>, <c>Individual</c>, or <c>Government</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>taxOffice</c>. If your <c>sector</c> is <c>Individual</c>, don't enter
        /// this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Specify the <c>kepEmailId</c>. If your <c>sector</c> is <c>Individual</c>,
        /// don't enter this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Note:</b> In the <b>Tax Settings</b> page of the Billing console, <c>Government</c>
        /// appears as <b>Public institutions</b> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c> and you're subject to KDV tax, you must specify
        /// your industry in the <c>industries</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>districtOrCounty</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Ukraine</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/BatchPutTaxRegistration">REST API Reference for BatchPutTaxRegistration Operation</seealso>
        public virtual Task<BatchPutTaxRegistrationResponse> BatchPutTaxRegistrationAsync(BatchPutTaxRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutTaxRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutTaxRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSupplementalTaxRegistration

        internal virtual DeleteSupplementalTaxRegistrationResponse DeleteSupplementalTaxRegistration(DeleteSupplementalTaxRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSupplementalTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSupplementalTaxRegistrationResponseUnmarshaller.Instance;

            return Invoke<DeleteSupplementalTaxRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a supplemental tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSupplementalTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSupplementalTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/DeleteSupplementalTaxRegistration">REST API Reference for DeleteSupplementalTaxRegistration Operation</seealso>
        public virtual Task<DeleteSupplementalTaxRegistrationResponse> DeleteSupplementalTaxRegistrationAsync(DeleteSupplementalTaxRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSupplementalTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSupplementalTaxRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSupplementalTaxRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTaxRegistration

        internal virtual DeleteTaxRegistrationResponse DeleteTaxRegistration(DeleteTaxRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaxRegistrationResponseUnmarshaller.Instance;

            return Invoke<DeleteTaxRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Deletes tax registration for a single account. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can't be used to delete your tax registration in Brazil. Use the
        /// <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/DeleteTaxRegistration">REST API Reference for DeleteTaxRegistration Operation</seealso>
        public virtual Task<DeleteTaxRegistrationResponse> DeleteTaxRegistrationAsync(DeleteTaxRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaxRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTaxRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTaxExemptionTypes

        internal virtual GetTaxExemptionTypesResponse GetTaxExemptionTypes(GetTaxExemptionTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxExemptionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxExemptionTypesResponseUnmarshaller.Instance;

            return Invoke<GetTaxExemptionTypesResponse>(request, options);
        }



        /// <summary>
        /// Get supported tax exemption types. The IAM action is <c>tax:GetExemptions</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxExemptionTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaxExemptionTypes service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxExemptionTypes">REST API Reference for GetTaxExemptionTypes Operation</seealso>
        public virtual Task<GetTaxExemptionTypesResponse> GetTaxExemptionTypesAsync(GetTaxExemptionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxExemptionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxExemptionTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTaxExemptionTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTaxInheritance

        internal virtual GetTaxInheritanceResponse GetTaxInheritance(GetTaxInheritanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxInheritanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxInheritanceResponseUnmarshaller.Instance;

            return Invoke<GetTaxInheritanceResponse>(request, options);
        }



        /// <summary>
        /// The get account tax inheritance status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxInheritance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaxInheritance service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxInheritance">REST API Reference for GetTaxInheritance Operation</seealso>
        public virtual Task<GetTaxInheritanceResponse> GetTaxInheritanceAsync(GetTaxInheritanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxInheritanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxInheritanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetTaxInheritanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTaxRegistration

        internal virtual GetTaxRegistrationResponse GetTaxRegistration(GetTaxRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxRegistrationResponseUnmarshaller.Instance;

            return Invoke<GetTaxRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxRegistration">REST API Reference for GetTaxRegistration Operation</seealso>
        public virtual Task<GetTaxRegistrationResponse> GetTaxRegistrationAsync(GetTaxRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetTaxRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTaxRegistrationDocument

        internal virtual GetTaxRegistrationDocumentResponse GetTaxRegistrationDocument(GetTaxRegistrationDocumentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxRegistrationDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxRegistrationDocumentResponseUnmarshaller.Instance;

            return Invoke<GetTaxRegistrationDocumentResponse>(request, options);
        }



        /// <summary>
        /// Downloads your tax documents to the Amazon S3 bucket that you specify in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxRegistrationDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaxRegistrationDocument service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxRegistrationDocument">REST API Reference for GetTaxRegistrationDocument Operation</seealso>
        public virtual Task<GetTaxRegistrationDocumentResponse> GetTaxRegistrationDocumentAsync(GetTaxRegistrationDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaxRegistrationDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaxRegistrationDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetTaxRegistrationDocumentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSupplementalTaxRegistrations

        internal virtual ListSupplementalTaxRegistrationsResponse ListSupplementalTaxRegistrations(ListSupplementalTaxRegistrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupplementalTaxRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupplementalTaxRegistrationsResponseUnmarshaller.Instance;

            return Invoke<ListSupplementalTaxRegistrationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves supplemental tax registrations for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupplementalTaxRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupplementalTaxRegistrations service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/ListSupplementalTaxRegistrations">REST API Reference for ListSupplementalTaxRegistrations Operation</seealso>
        public virtual Task<ListSupplementalTaxRegistrationsResponse> ListSupplementalTaxRegistrationsAsync(ListSupplementalTaxRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupplementalTaxRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupplementalTaxRegistrationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSupplementalTaxRegistrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTaxExemptions

        internal virtual ListTaxExemptionsResponse ListTaxExemptions(ListTaxExemptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTaxExemptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaxExemptionsResponseUnmarshaller.Instance;

            return Invoke<ListTaxExemptionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the tax exemption of accounts listed in a consolidated billing family. The
        /// IAM action is <c>tax:GetExemptions</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaxExemptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaxExemptions service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/ListTaxExemptions">REST API Reference for ListTaxExemptions Operation</seealso>
        public virtual Task<ListTaxExemptionsResponse> ListTaxExemptionsAsync(ListTaxExemptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTaxExemptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaxExemptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaxExemptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTaxRegistrations

        internal virtual ListTaxRegistrationsResponse ListTaxRegistrations(ListTaxRegistrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTaxRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaxRegistrationsResponseUnmarshaller.Instance;

            return Invoke<ListTaxRegistrationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the tax registration of accounts listed in a consolidated billing family.
        /// This can be used to retrieve up to 100 accounts' tax registrations in one call (default
        /// 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaxRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaxRegistrations service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/ListTaxRegistrations">REST API Reference for ListTaxRegistrations Operation</seealso>
        public virtual Task<ListTaxRegistrationsResponse> ListTaxRegistrationsAsync(ListTaxRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTaxRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaxRegistrationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaxRegistrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutSupplementalTaxRegistration

        internal virtual PutSupplementalTaxRegistrationResponse PutSupplementalTaxRegistration(PutSupplementalTaxRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSupplementalTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSupplementalTaxRegistrationResponseUnmarshaller.Instance;

            return Invoke<PutSupplementalTaxRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Stores supplemental tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSupplementalTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSupplementalTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutSupplementalTaxRegistration">REST API Reference for PutSupplementalTaxRegistration Operation</seealso>
        public virtual Task<PutSupplementalTaxRegistrationResponse> PutSupplementalTaxRegistrationAsync(PutSupplementalTaxRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSupplementalTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSupplementalTaxRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<PutSupplementalTaxRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTaxExemption

        internal virtual PutTaxExemptionResponse PutTaxExemption(PutTaxExemptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTaxExemptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTaxExemptionResponseUnmarshaller.Instance;

            return Invoke<PutTaxExemptionResponse>(request, options);
        }



        /// <summary>
        /// Adds the tax exemption for a single account or all accounts listed in a consolidated
        /// billing family. The IAM action is <c>tax:UpdateExemptions</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTaxExemption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTaxExemption service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.AccessDeniedException">
        /// The access is denied for the Amazon Web ServicesSupport API.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.AttachmentUploadException">
        /// Failed to upload the tax exemption document to Amazon Web ServicesSupport case.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.CaseCreationLimitExceededException">
        /// You've exceeded the Amazon Web ServicesSupport case creation limit for your account.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutTaxExemption">REST API Reference for PutTaxExemption Operation</seealso>
        public virtual Task<PutTaxExemptionResponse> PutTaxExemptionAsync(PutTaxExemptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTaxExemptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTaxExemptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutTaxExemptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTaxInheritance

        internal virtual PutTaxInheritanceResponse PutTaxInheritance(PutTaxInheritanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTaxInheritanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTaxInheritanceResponseUnmarshaller.Instance;

            return Invoke<PutTaxInheritanceResponse>(request, options);
        }



        /// <summary>
        /// The updated tax inheritance status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTaxInheritance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTaxInheritance service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutTaxInheritance">REST API Reference for PutTaxInheritance Operation</seealso>
        public virtual Task<PutTaxInheritanceResponse> PutTaxInheritanceAsync(PutTaxInheritanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTaxInheritanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTaxInheritanceResponseUnmarshaller.Instance;

            return InvokeAsync<PutTaxInheritanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutTaxRegistration

        internal virtual PutTaxRegistrationResponse PutTaxRegistration(PutTaxRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTaxRegistrationResponseUnmarshaller.Instance;

            return Invoke<PutTaxRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates tax registration for a single account. You can't set a TRN if there's
        /// a pending TRN. You'll need to delete the pending TRN first.
        /// 
        ///  
        /// <para>
        /// To call this API operation for specific countries, see the following country-specific
        /// requirements.
        /// </para>
        ///  
        /// <para>
        ///  <b>Bangladesh</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Brazil</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must complete the tax registration process in the <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console. After your TRN and
        /// billing address are verified, you can call this API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Web Services accounts created through Organizations, you can call this
        /// API operation when you don't have a billing address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Georgia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The valid <c>personType</c> values are <c>Physical Person</c> and <c>Business</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Indonesia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PutTaxRegistration</c>: The use of this operation to submit tax information is
        /// subject to the <a href="http://aws.amazon.com/service-terms/">Amazon Web Services
        /// service terms</a>. By submitting, you’re providing consent for Amazon Web Services
        /// to validate NIK, NPWP, and NITKU data, provided by you with the Directorate General
        /// of Taxes of Indonesia in accordance with the Minister of Finance Regulation (PMK)
        /// Number 112/PMK.03/2022.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BatchPutTaxRegistration</c>: The use of this operation to submit tax information
        /// is subject to the <a href="http://aws.amazon.com/service-terms/">Amazon Web Services
        /// service terms</a>. By submitting, you’re providing consent for Amazon Web Services
        /// to validate NIK, NPWP, and NITKU data, provided by you with the Directorate General
        /// of Taxes of Indonesia in accordance with the Minister of Finance Regulation (PMK)
        /// Number 112/PMK.03/2022, through our third-party partner PT Achilles Advanced Management
        /// (OnlinePajak).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>taxRegistrationNumberType</c> in the <c>indonesiaAdditionalInfo</c>
        /// field of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>decisionNumber</c>, you must specify the <c>ppnExceptionDesignationCode</c>
        /// in the <c>indonesiaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. If the <c>taxRegistrationNumberType</c> is set to NPWP or NITKU, valid values
        /// for <c>ppnExceptionDesignationCode</c> are either <c>01</c>, <c>02</c>, <c>03</c>,
        /// <c>07</c>, or <c>08</c>.
        /// </para>
        ///  
        /// <para>
        /// For other <c>taxRegistrationNumberType</c> values, <c>ppnExceptionDesignationCode</c>
        /// must be either <c>01</c>, <c>07</c>, or <c>08</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>ppnExceptionDesignationCode</c> is <c>07</c>, you must specify the <c>decisionNumber</c>
        /// in the <c>indonesiaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Kenya</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>personType</c> in the <c>kenyaAdditionalInfo</c> field of
        /// the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>personType</c> is <c>Physical Person</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Malaysia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RegistrationType</c> valid values are <c>NRIC</c> for individual, and TIN and
        /// sales and service tax (SST) for Business.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid <c>MyKad</c> or NRIC number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business, you must specify a <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a TIN type and tax identification number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers, you must specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c>
        /// in <c>MalaysiaAdditionalInfo</c> with a sales and service tax (SST) type and a valid
        /// SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services reserves the right to seek additional information and/or take
        /// other actions to support your self-declaration as appropriate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services is currently registered under the following service tax codes.
        /// You must include at least one of the service tax codes in the service tax code strings
        /// to declare yourself as an authorized registered business reseller.
        /// </para>
        ///  
        /// <para>
        /// Taxable service and service tax codes:
        /// </para>
        ///  
        /// <para>
        /// Consultancy - 9907061674
        /// </para>
        ///  
        /// <para>
        /// Training or coaching service - 9907071685
        /// </para>
        ///  
        /// <para>
        /// IT service - 9907101676
        /// </para>
        ///  
        /// <para>
        /// Digital services and electronic medium - 9907121690
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Nepal</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Saudi Arabia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>addressLine3</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>South Korea</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>certifiedEmailId</c> and <c>legalName</c> in the <c>TaxRegistrationEntry</c>
        /// object. Use Korean characters for <c>legalName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>businessRepresentativeName</c>, <c>itemOfBusiness</c>, and
        /// <c>lineOfBusiness</c> in the <c>southKoreaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. Use Korean characters for these fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>address</c> object, use Korean characters for <c>addressLine1</c>, <c>addressLine2</c>
        /// <c>city</c>, <c>postalCode</c>, and <c>stateOrRegion</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Spain</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>registrationType</c> in the <c>spainAdditionalInfo</c> field
        /// of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>registrationType</c> is <c>Local</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Turkey</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>sector</c> in the <c>taxRegistrationEntry</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c>, <c>Individual</c>, or <c>Government</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>taxOffice</c>. If your <c>sector</c> is <c>Individual</c>, don't enter
        /// this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Specify the <c>kepEmailId</c>. If your <c>sector</c> is <c>Individual</c>,
        /// don't enter this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Note:</b> In the <b>Tax Settings</b> page of the Billing console, <c>Government</c>
        /// appears as <b>Public institutions</b> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c> and you're subject to KDV tax, you must specify
        /// your industry in the <c>industries</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>districtOrCounty</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Ukraine</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutTaxRegistration">REST API Reference for PutTaxRegistration Operation</seealso>
        public virtual Task<PutTaxRegistrationResponse> PutTaxRegistrationAsync(PutTaxRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTaxRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTaxRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<PutTaxRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}