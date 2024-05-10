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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.B2bi.Model;

#pragma warning disable CS1570
namespace Amazon.B2bi
{
    /// <summary>
    /// <para>Interface for accessing B2bi</para>
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
    public partial interface IAmazonB2bi : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IB2biPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateCapability



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        Task<CreateCapabilityResponse> CreateCapabilityAsync(CreateCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePartnership



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        Task<CreatePartnershipResponse> CreatePartnershipAsync(CreatePartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProfile



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransformer



        /// <summary>
        /// Creates a transformer. A transformer describes how to process the incoming EDI documents
        /// and extract the necessary information to the output file.
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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        Task<CreateTransformerResponse> CreateTransformerAsync(CreateTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCapability



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        Task<DeleteCapabilityResponse> DeleteCapabilityAsync(DeleteCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePartnership



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        Task<DeletePartnershipResponse> DeletePartnershipAsync(DeletePartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProfile



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransformer



        /// <summary>
        /// Deletes the specified transformer. A transformer describes how to process the incoming
        /// EDI documents and extract the necessary information to the output file.
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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        Task<DeleteTransformerResponse> DeleteTransformerAsync(DeleteTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCapability



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        Task<GetCapabilityResponse> GetCapabilityAsync(GetCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPartnership



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        Task<GetPartnershipResponse> GetPartnershipAsync(GetPartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProfile



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransformer



        /// <summary>
        /// Retrieves the details for the transformer specified by the transformer ID. A transformer
        /// describes how to process the incoming EDI documents and extract the necessary information
        /// to the output file.
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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        Task<GetTransformerResponse> GetTransformerAsync(GetTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransformerJob



        /// <summary>
        /// Returns the details of the transformer run, based on the Transformer job ID.
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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        Task<GetTransformerJobResponse> GetTransformerJobAsync(GetTransformerJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCapabilities



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        Task<ListCapabilitiesResponse> ListCapabilitiesAsync(ListCapabilitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPartnerships



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        Task<ListPartnershipsResponse> ListPartnershipsAsync(ListPartnershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProfiles



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTransformers



        /// <summary>
        /// Lists the available transformers. A transformer describes how to process the incoming
        /// EDI documents and extract the necessary information to the output file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTransformers service method, as returned by B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        Task<ListTransformersResponse> ListTransformersAsync(ListTransformersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTransformerJob



        /// <summary>
        /// Runs a job, using a transformer, to parse input EDI (electronic data interchange)
        /// file into the output structures used by Amazon Web Services B2BI Data Interchange.
        /// 
        ///  
        /// <para>
        /// If you only want to transform EDI (electronic data interchange) documents, you don't
        /// need to create profiles, partnerships or capabilities. Just create and configure a
        /// transformer, and then run the <c>StartTransformerJob</c> API to process your files.
        /// </para>
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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        Task<StartTransformerJobResponse> StartTransformerJobAsync(StartTransformerJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestMapping



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        Task<TestMappingResponse> TestMappingAsync(TestMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestParsing



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        Task<TestParsingResponse> TestParsingAsync(TestParsingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCapability



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        Task<UpdateCapabilityResponse> UpdateCapabilityAsync(UpdateCapabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePartnership



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        Task<UpdatePartnershipResponse> UpdatePartnershipAsync(UpdatePartnershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProfile



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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTransformer



        /// <summary>
        /// Updates the specified parameters for a transformer. A transformer describes how to
        /// process the incoming EDI documents and extract the necessary information to the output
        /// file.
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
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        Task<UpdateTransformerResponse> UpdateTransformerAsync(UpdateTransformerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}