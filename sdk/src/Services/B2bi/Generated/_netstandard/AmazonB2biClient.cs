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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.B2bi.Model;
using Amazon.B2bi.Model.Internal.MarshallTransformations;
using Amazon.B2bi.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.B2bi
{
    /// <summary>
    /// <para>Implementation for accessing B2bi</para>
    ///
    /// This is the <i>Amazon Web Services B2B Data Interchange API Reference</i>. It provides
    /// descriptions, API request parameters, and the XML response for each of the B2BI API
    /// actions.
    /// 
    ///  
    /// <para>
    /// B2BI enables automated exchange of EDI (electronic data interchange) based business-critical
    /// transactions at cloud scale, with elasticity and pay-as-you-go pricing. Businesses
    /// use EDI documents to exchange transactional data with trading partners, such as suppliers
    /// and end customers, using standardized formats such as X12.
    /// </para>
    ///  <note> 
    /// <para>
    /// Rather than actually running a command, you can use the <c>--generate-cli-skeleton</c>
    /// parameter with any API call to generate and display a parameter template. You can
    /// then use the generated template to customize and use as input on a later command.
    /// For details, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-skeleton.html#cli-usage-skeleton-generate">Generate
    /// and use a parameter skeleton file</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonB2biClient : AmazonServiceClient, IAmazonB2bi
    {
        private static IServiceMetadata serviceMetadata = new AmazonB2biMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonB2biClient with the credentials loaded from the application's
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
        public AmazonB2biClient()
            : base(new AmazonB2biConfig()) { }

        /// <summary>
        /// Constructs AmazonB2biClient with the credentials loaded from the application's
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
        public AmazonB2biClient(RegionEndpoint region)
            : base(new AmazonB2biConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonB2biClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(AmazonB2biConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonB2biClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonB2biClient(AWSCredentials credentials)
            : this(credentials, new AmazonB2biConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonB2biClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonB2biConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Credentials and an
        /// AmazonB2biClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(AWSCredentials credentials, AmazonB2biConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonB2biConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonB2biConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonB2biClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonB2biConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonB2biConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonB2biConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonB2biClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonB2biClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonB2biClient Configuration Object</param>
        public AmazonB2biClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonB2biConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IB2biPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IB2biPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new B2biPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonB2biEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonB2biAuthSchemeHandler());
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


        #region  CreateCapability

        internal virtual CreateCapabilityResponse CreateCapability(CreateCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapabilityResponseUnmarshaller.Instance;

            return Invoke<CreateCapabilityResponse>(request, options);
        }



        /// <summary>
        /// Instantiates a capability based on the specified parameters. A trading capability
        /// contains the information required to transform incoming EDI documents into JSON or
        /// XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        public virtual Task<CreateCapabilityResponse> CreateCapabilityAsync(CreateCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapabilityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCapabilityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePartnership

        internal virtual CreatePartnershipResponse CreatePartnership(CreatePartnershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnershipResponseUnmarshaller.Instance;

            return Invoke<CreatePartnershipResponse>(request, options);
        }



        /// <summary>
        /// Creates a partnership between a customer and a trading partner, based on the supplied
        /// parameters. A partnership represents the connection between you and your trading partner.
        /// It ties together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        public virtual Task<CreatePartnershipResponse> CreatePartnershipAsync(CreatePartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePartnershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProfile

        internal virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a customer profile. You can have up to five customer profiles, each representing
        /// a distinct private network. A profile is the mechanism used to create the concept
        /// of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStarterMappingTemplate

        internal virtual CreateStarterMappingTemplateResponse CreateStarterMappingTemplate(CreateStarterMappingTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStarterMappingTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStarterMappingTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateStarterMappingTemplateResponse>(request, options);
        }



        /// <summary>
        /// Amazon Web Services B2B Data Interchange uses a mapping template in JSONata or XSLT
        /// format to transform a customer input file into a JSON or XML file that can be converted
        /// to EDI.
        /// 
        ///  
        /// <para>
        /// If you provide a sample EDI file with the same structure as the EDI files that you
        /// wish to generate, then the service can generate a mapping template. The starter template
        /// contains placeholder values which you can replace with JSONata or XSLT expressions
        /// to take data from your input file and insert it into the JSON or XML file that is
        /// used to generate the EDI.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide a sample EDI file, then the service can generate a mapping template
        /// based on the EDI settings in the <c>templateDetails</c> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  Currently, we only support generating a template that can generate the input to produce
        /// an Outbound X12 EDI file.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStarterMappingTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStarterMappingTemplate service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateStarterMappingTemplate">REST API Reference for CreateStarterMappingTemplate Operation</seealso>
        public virtual Task<CreateStarterMappingTemplateResponse> CreateStarterMappingTemplateAsync(CreateStarterMappingTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStarterMappingTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStarterMappingTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStarterMappingTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTransformer

        internal virtual CreateTransformerResponse CreateTransformer(CreateTransformerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformerResponseUnmarshaller.Instance;

            return Invoke<CreateTransformerResponse>(request, options);
        }



        /// <summary>
        /// Creates a transformer. Amazon Web Services B2B Data Interchange currently supports
        /// two scenarios:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Inbound EDI</i>: the Amazon Web Services customer receives an EDI file from their
        /// trading partner. Amazon Web Services B2B Data Interchange converts this EDI file into
        /// a JSON or XML file with a service-defined structure. A mapping template provided by
        /// the customer, in JSONata or XSLT format, is optionally applied to this file to produce
        /// a JSON or XML file with the structure the customer requires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Outbound EDI</i>: the Amazon Web Services customer has a JSON or XML file containing
        /// data that they wish to use in an EDI file. A mapping template, provided by the customer
        /// (in either JSONata or XSLT format) is applied to this file to generate a JSON or XML
        /// file in the service-defined structure. This file is then converted to an EDI file.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The following fields are provided for backwards compatibility only: <c>fileFormat</c>,
        /// <c>mappingTemplate</c>, <c>ediType</c>, and <c>sampleDocument</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <c>mapping</c> data type in place of <c>mappingTemplate</c> and <c>fileFormat</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>sampleDocuments</c> data type in place of <c>sampleDocument</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use either the <c>inputConversion</c> or <c>outputConversion</c> in place of <c>ediType</c>
        /// 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        public virtual Task<CreateTransformerResponse> CreateTransformerAsync(CreateTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransformerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCapability

        internal virtual DeleteCapabilityResponse DeleteCapability(DeleteCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapabilityResponseUnmarshaller.Instance;

            return Invoke<DeleteCapabilityResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified capability. A trading capability contains the information required
        /// to transform incoming EDI documents into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        public virtual Task<DeleteCapabilityResponse> DeleteCapabilityAsync(DeleteCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCapabilityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCapabilityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePartnership

        internal virtual DeletePartnershipResponse DeletePartnership(DeletePartnershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnershipResponseUnmarshaller.Instance;

            return Invoke<DeletePartnershipResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified partnership. A partnership represents the connection between
        /// you and your trading partner. It ties together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        public virtual Task<DeletePartnershipResponse> DeletePartnershipAsync(DeletePartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePartnershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProfile

        internal virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified profile. A profile is the mechanism used to create the concept
        /// of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTransformer

        internal virtual DeleteTransformerResponse DeleteTransformer(DeleteTransformerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransformerResponseUnmarshaller.Instance;

            return Invoke<DeleteTransformerResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified transformer. A transformer can take an EDI file as input and
        /// transform it into a JSON-or XML-formatted document. Alternatively, a transformer can
        /// take a JSON-or XML-formatted document as input and transform it into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        public virtual Task<DeleteTransformerResponse> DeleteTransformerAsync(DeleteTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransformerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransformerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateMapping

        internal virtual GenerateMappingResponse GenerateMapping(GenerateMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMappingResponseUnmarshaller.Instance;

            return Invoke<GenerateMappingResponse>(request, options);
        }



        /// <summary>
        /// Takes sample input and output documents and uses Amazon Bedrock to generate a mapping
        /// automatically. Depending on the accuracy and other factors, you can then edit the
        /// mapping for your needs.
        /// 
        ///  <note> 
        /// <para>
        /// Before you can use the AI-assisted feature for Amazon Web Services B2B Data Interchange
        /// you must enable models in Amazon Bedrock. For details, see <a href="https://docs.aws.amazon.com/b2bi/latest/userguide/ai-assisted-mapping.html#ai-assist-prereq">AI-assisted
        /// template mapping prerequisites</a> in the <i>Amazon Web Services B2B Data Interchange
        /// User guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To generate a mapping, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Start with an X12 EDI document to use as the input.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>TestMapping</c> using your EDI document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the output from the <c>TestMapping</c> operation as either input or output for
        /// your GenerateMapping call, along with your sample file.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateMapping service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GenerateMapping">REST API Reference for GenerateMapping Operation</seealso>
        public virtual Task<GenerateMappingResponse> GenerateMappingAsync(GenerateMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCapability

        internal virtual GetCapabilityResponse GetCapability(GetCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCapabilityResponseUnmarshaller.Instance;

            return Invoke<GetCapabilityResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details for the specified capability. A trading capability contains
        /// the information required to transform incoming EDI documents into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCapability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        public virtual Task<GetCapabilityResponse> GetCapabilityAsync(GetCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCapabilityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCapabilityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPartnership

        internal virtual GetPartnershipResponse GetPartnership(GetPartnershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnershipResponseUnmarshaller.Instance;

            return Invoke<GetPartnershipResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details for a partnership, based on the partner and profile IDs specified.
        /// A partnership represents the connection between you and your trading partner. It ties
        /// together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        public virtual Task<GetPartnershipResponse> GetPartnershipAsync(GetPartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnershipResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartnershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProfile

        internal virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details for the profile specified by the profile ID. A profile is the
        /// mechanism used to create the concept of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTransformer

        internal virtual GetTransformerResponse GetTransformer(GetTransformerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerResponseUnmarshaller.Instance;

            return Invoke<GetTransformerResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details for the transformer specified by the transformer ID. A transformer
        /// can take an EDI file as input and transform it into a JSON-or XML-formatted document.
        /// Alternatively, a transformer can take a JSON-or XML-formatted document as input and
        /// transform it into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        public virtual Task<GetTransformerResponse> GetTransformerAsync(GetTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransformerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTransformerJob

        internal virtual GetTransformerJobResponse GetTransformerJob(GetTransformerJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerJobResponseUnmarshaller.Instance;

            return Invoke<GetTransformerJobResponse>(request, options);
        }



        /// <summary>
        /// Returns the details of the transformer run, based on the Transformer job ID.
        /// 
        ///  <note> 
        /// <para>
        /// If 30 days have elapsed since your transformer job was started, the system deletes
        /// it. So, if you run <c>GetTransformerJob</c> and supply a <c>transformerId</c> and
        /// <c>transformerJobId</c> for a job that was started more than 30 days previously, you
        /// receive a 404 response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformerJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransformerJob service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        public virtual Task<GetTransformerJobResponse> GetTransformerJobAsync(GetTransformerJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransformerJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransformerJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCapabilities

        internal virtual ListCapabilitiesResponse ListCapabilities(ListCapabilitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapabilitiesResponseUnmarshaller.Instance;

            return Invoke<ListCapabilitiesResponse>(request, options);
        }



        /// <summary>
        /// Lists the capabilities associated with your Amazon Web Services account for your current
        /// or specified region. A trading capability contains the information required to transform
        /// incoming EDI documents into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCapabilities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCapabilities service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        public virtual Task<ListCapabilitiesResponse> ListCapabilitiesAsync(ListCapabilitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCapabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCapabilitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCapabilitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPartnerships

        internal virtual ListPartnershipsResponse ListPartnerships(ListPartnershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartnershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnershipsResponseUnmarshaller.Instance;

            return Invoke<ListPartnershipsResponse>(request, options);
        }



        /// <summary>
        /// Lists the partnerships associated with your Amazon Web Services account for your current
        /// or specified region. A partnership represents the connection between you and your
        /// trading partner. It ties together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPartnerships service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        public virtual Task<ListPartnershipsResponse> ListPartnershipsAsync(ListPartnershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartnershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartnershipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfiles

        internal virtual ListProfilesResponse ListProfiles(ListProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists the profiles associated with your Amazon Web Services account for your current
        /// or specified region. A profile is the mechanism used to create the concept of a private
        /// network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a capability, partnership, profile, or transformer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTransformers

        internal virtual ListTransformersResponse ListTransformers(ListTransformersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTransformersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformersResponseUnmarshaller.Instance;

            return Invoke<ListTransformersResponse>(request, options);
        }



        /// <summary>
        /// Lists the available transformers. A transformer can take an EDI file as input and
        /// transform it into a JSON-or XML-formatted document. Alternatively, a transformer can
        /// take a JSON-or XML-formatted document as input and transform it into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTransformers service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        public virtual Task<ListTransformersResponse> ListTransformersAsync(ListTransformersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTransformersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformersResponseUnmarshaller.Instance;

            return InvokeAsync<ListTransformersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartTransformerJob

        internal virtual StartTransformerJobResponse StartTransformerJob(StartTransformerJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransformerJobResponseUnmarshaller.Instance;

            return Invoke<StartTransformerJobResponse>(request, options);
        }



        /// <summary>
        /// Runs a job, using a transformer, to parse input EDI (electronic data interchange)
        /// file into the output structures used by Amazon Web Services B2B Data Interchange.
        /// 
        ///  
        /// <para>
        /// If you only want to transform EDI (electronic data interchange) documents, you don't
        /// need to create profiles, partnerships or capabilities. Just create and configure a
        /// transformer, and then run the <c>StartTransformerJob</c> API to process your files.
        /// </para>
        ///  <note> 
        /// <para>
        /// The system stores transformer jobs for 30 days. During that period, you can run <a
        /// href="https://docs.aws.amazon.com/b2bi/latest/APIReference/API_GetTransformerJob.html">GetTransformerJob</a>
        /// and supply its <c>transformerId</c> and <c>transformerJobId</c> to return details
        /// of the job.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTransformerJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTransformerJob service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        public virtual Task<StartTransformerJobResponse> StartTransformerJobAsync(StartTransformerJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTransformerJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTransformerJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartTransformerJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are capability, partnership, profile, transformers and other entities.
        /// 
        ///  
        /// <para>
        /// There is no response returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestConversion

        internal virtual TestConversionResponse TestConversion(TestConversionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestConversionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConversionResponseUnmarshaller.Instance;

            return Invoke<TestConversionResponse>(request, options);
        }



        /// <summary>
        /// This operation mimics the latter half of a typical Outbound EDI request. It takes
        /// an input JSON/XML in the B2Bi shape as input, converts it to an X12 EDI string, and
        /// return that string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConversion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestConversion service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestConversion">REST API Reference for TestConversion Operation</seealso>
        public virtual Task<TestConversionResponse> TestConversionAsync(TestConversionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestConversionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConversionResponseUnmarshaller.Instance;

            return InvokeAsync<TestConversionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestMapping

        internal virtual TestMappingResponse TestMapping(TestMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMappingResponseUnmarshaller.Instance;

            return Invoke<TestMappingResponse>(request, options);
        }



        /// <summary>
        /// Maps the input file according to the provided template file. The API call downloads
        /// the file contents from the Amazon S3 location, and passes the contents in as a string,
        /// to the <c>inputFileContent</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestMapping service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        public virtual Task<TestMappingResponse> TestMappingAsync(TestMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMappingResponseUnmarshaller.Instance;

            return InvokeAsync<TestMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestParsing

        internal virtual TestParsingResponse TestParsing(TestParsingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestParsingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestParsingResponseUnmarshaller.Instance;

            return Invoke<TestParsingResponse>(request, options);
        }



        /// <summary>
        /// Parses the input EDI (electronic data interchange) file. The input file has a file
        /// size limit of 250 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestParsing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestParsing service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        public virtual Task<TestParsingResponse> TestParsingAsync(TestParsingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestParsingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestParsingResponseUnmarshaller.Instance;

            return InvokeAsync<TestParsingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Detaches a key-value pair from the specified resource, as identified by its Amazon
        /// Resource Name (ARN). Resources are capability, partnership, profile, transformers
        /// and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCapability

        internal virtual UpdateCapabilityResponse UpdateCapability(UpdateCapabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapabilityResponseUnmarshaller.Instance;

            return Invoke<UpdateCapabilityResponse>(request, options);
        }



        /// <summary>
        /// Updates some of the parameters for a capability, based on the specified parameters.
        /// A trading capability contains the information required to transform incoming EDI documents
        /// into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        public virtual Task<UpdateCapabilityResponse> UpdateCapabilityAsync(UpdateCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCapabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCapabilityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCapabilityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePartnership

        internal virtual UpdatePartnershipResponse UpdatePartnership(UpdatePartnershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnershipResponseUnmarshaller.Instance;

            return Invoke<UpdatePartnershipResponse>(request, options);
        }



        /// <summary>
        /// Updates some of the parameters for a partnership between a customer and trading partner.
        /// A partnership represents the connection between you and your trading partner. It ties
        /// together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        public virtual Task<UpdatePartnershipResponse> UpdatePartnershipAsync(UpdatePartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePartnershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnershipResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePartnershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProfile

        internal virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified parameters for a profile. A profile is the mechanism used to
        /// create the concept of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTransformer

        internal virtual UpdateTransformerResponse UpdateTransformer(UpdateTransformerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTransformerResponseUnmarshaller.Instance;

            return Invoke<UpdateTransformerResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified parameters for a transformer. A transformer can take an EDI
        /// file as input and transform it into a JSON-or XML-formatted document. Alternatively,
        /// a transformer can take a JSON-or XML-formatted document as input and transform it
        /// into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// This exception can be thrown during standard EDI validation or when custom validation
        /// rules fail, such as when element length constraints are violated, invalid codes are
        /// used in code list validations, or required elements are missing based on configured
        /// element requirement rules.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        public virtual Task<UpdateTransformerResponse> UpdateTransformerAsync(UpdateTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTransformerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTransformerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTransformerResponse>(request, options, cancellationToken);
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