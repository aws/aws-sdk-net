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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CertificateManager.Model;

#pragma warning disable CS1570
namespace Amazon.CertificateManager
{
    /// <summary>
    /// <para>Interface for accessing CertificateManager</para>
    ///
    /// Certificate Manager 
    /// <para>
    /// You can use Certificate Manager (ACM) to manage SSL/TLS certificates for your Amazon
    /// Web Services-based websites and applications. For more information about using ACM,
    /// see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">Certificate Manager
    /// User Guide</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonCertificateManager : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICertificateManagerPaginatorFactory Paginators { get; }

        
        #region  AddTagsToCertificate


        /// <summary>
        /// Adds one or more tags to an ACM certificate. Tags are labels that you can use to identify
        /// and organize your Amazon Web Services resources. Each tag consists of a <c>key</c>
        /// and an optional <c>value</c>. You specify the certificate on input by its Amazon Resource
        /// Name (ARN). You specify the tag by using a key-value pair. 
        /// 
        ///  
        /// <para>
        /// You can apply a tag to just one certificate if you want to identify a specific characteristic
        /// of that certificate, or you can apply the same tag to multiple certificates if you
        /// want to filter for a common relationship among those certificates. Similarly, you
        /// can apply the same tag to multiple resources if you want to specify a relationship
        /// among those resources. For example, you can add the same tag to an ACM certificate
        /// and an Elastic Load Balancing load balancer to indicate that they are both used by
        /// the same website. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
        /// ACM certificates</a>. 
        /// </para>
        ///  
        /// <para>
        /// To remove one or more tags, use the <a>RemoveTagsFromCertificate</a> action. To view
        /// all of the tags that have been applied to the certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate service method.</param>
        /// 
        /// <returns>The response from the AddTagsToCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        AddTagsToCertificateResponse AddTagsToCertificate(AddTagsToCertificateRequest request);



        /// <summary>
        /// Adds one or more tags to an ACM certificate. Tags are labels that you can use to identify
        /// and organize your Amazon Web Services resources. Each tag consists of a <c>key</c>
        /// and an optional <c>value</c>. You specify the certificate on input by its Amazon Resource
        /// Name (ARN). You specify the tag by using a key-value pair. 
        /// 
        ///  
        /// <para>
        /// You can apply a tag to just one certificate if you want to identify a specific characteristic
        /// of that certificate, or you can apply the same tag to multiple certificates if you
        /// want to filter for a common relationship among those certificates. Similarly, you
        /// can apply the same tag to multiple resources if you want to specify a relationship
        /// among those resources. For example, you can add the same tag to an ACM certificate
        /// and an Elastic Load Balancing load balancer to indicate that they are both used by
        /// the same website. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
        /// ACM certificates</a>. 
        /// </para>
        ///  
        /// <para>
        /// To remove one or more tags, use the <a>RemoveTagsFromCertificate</a> action. To view
        /// all of the tags that have been applied to the certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        Task<AddTagsToCertificateResponse> AddTagsToCertificateAsync(AddTagsToCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by Amazon Web Services services integrated with ACM.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another Amazon Web Services
        /// service. To delete a certificate that is in use, the certificate association must
        /// first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM certificate to be deleted. This must be of the form:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse DeleteCertificate(string certificateArn);

        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by Amazon Web Services services integrated with ACM.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another Amazon Web Services
        /// service. To delete a certificate that is in use, the certificate association must
        /// first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request);


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by Amazon Web Services services integrated with ACM.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another Amazon Web Services
        /// service. To delete a certificate that is in use, the certificate association must
        /// first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM certificate to be deleted. This must be of the form:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by Amazon Web Services services integrated with ACM.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another Amazon Web Services
        /// service. To delete a certificate that is in use, the certificate association must
        /// first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCertificate


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// 
        ///  
        /// <para>
        /// If you have just created a certificate using the <c>RequestCertificate</c> action,
        /// there is a delay of several seconds before you can retrieve information about it.
        /// </para>
        /// </summary>
        /// <param name="certificateArn">The Amazon Resource Name (ARN) of the ACM certificate. The ARN must have the following form:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse DescribeCertificate(string certificateArn);

        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// 
        ///  
        /// <para>
        /// If you have just created a certificate using the <c>RequestCertificate</c> action,
        /// there is a delay of several seconds before you can retrieve information about it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request);


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// 
        ///  
        /// <para>
        /// If you have just created a certificate using the <c>RequestCertificate</c> action,
        /// there is a delay of several seconds before you can retrieve information about it.
        /// </para>
        /// </summary>
        /// <param name="certificateArn">The Amazon Resource Name (ARN) of the ACM certificate. The ARN must have the following form:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        Task<DescribeCertificateResponse> DescribeCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// 
        ///  
        /// <para>
        /// If you have just created a certificate using the <c>RequestCertificate</c> action,
        /// there is a delay of several seconds before you can retrieve information about it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportCertificate


        /// <summary>
        /// Exports a private certificate issued by a private certificate authority (CA) or public
        /// certificate for use anywhere. The exported file contains the certificate, the certificate
        /// chain, and the encrypted private key associated with the public key that is embedded
        /// in the certificate. For security, you must assign a passphrase for the private key
        /// when exporting it. 
        /// 
        ///  
        /// <para>
        /// For information about exporting and formatting a certificate using the ACM console
        /// or CLI, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/export-private.html">Export
        /// a private certificate</a> and <a href="https://docs.aws.amazon.com/acm/latest/userguide/export-public-certificate">Export
        /// a public certificate</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportCertificate service method.</param>
        /// 
        /// <returns>The response from the ExportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ExportCertificate">REST API Reference for ExportCertificate Operation</seealso>
        ExportCertificateResponse ExportCertificate(ExportCertificateRequest request);



        /// <summary>
        /// Exports a private certificate issued by a private certificate authority (CA) or public
        /// certificate for use anywhere. The exported file contains the certificate, the certificate
        /// chain, and the encrypted private key associated with the public key that is embedded
        /// in the certificate. For security, you must assign a passphrase for the private key
        /// when exporting it. 
        /// 
        ///  
        /// <para>
        /// For information about exporting and formatting a certificate using the ACM console
        /// or CLI, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/export-private.html">Export
        /// a private certificate</a> and <a href="https://docs.aws.amazon.com/acm/latest/userguide/export-public-certificate">Export
        /// a public certificate</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ExportCertificate">REST API Reference for ExportCertificate Operation</seealso>
        Task<ExportCertificateResponse> ExportCertificateAsync(ExportCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccountConfiguration


        /// <summary>
        /// Returns the account configuration options associated with an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAccountConfiguration service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetAccountConfiguration">REST API Reference for GetAccountConfiguration Operation</seealso>
        GetAccountConfigurationResponse GetAccountConfiguration(GetAccountConfigurationRequest request);



        /// <summary>
        /// Returns the account configuration options associated with an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountConfiguration service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetAccountConfiguration">REST API Reference for GetAccountConfiguration Operation</seealso>
        Task<GetAccountConfigurationResponse> GetAccountConfigurationAsync(GetAccountConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCertificate


        /// <summary>
        /// Retrieves a certificate and its certificate chain. The certificate may be either a
        /// public or private certificate issued using the ACM <c>RequestCertificate</c> action,
        /// or a certificate imported into ACM using the <c>ImportCertificate</c> action. The
        /// chain consists of the certificate of the issuing CA and the intermediate certificates
        /// of any other subordinate CAs. All of the certificates are base64 encoded. You can
        /// use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        GetCertificateResponse GetCertificate(string certificateArn);

        /// <summary>
        /// Retrieves a certificate and its certificate chain. The certificate may be either a
        /// public or private certificate issued using the ACM <c>RequestCertificate</c> action,
        /// or a certificate imported into ACM using the <c>ImportCertificate</c> action. The
        /// chain consists of the certificate of the issuing CA and the intermediate certificates
        /// of any other subordinate CAs. All of the certificates are base64 encoded. You can
        /// use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        GetCertificateResponse GetCertificate(GetCertificateRequest request);


        /// <summary>
        /// Retrieves a certificate and its certificate chain. The certificate may be either a
        /// public or private certificate issued using the ACM <c>RequestCertificate</c> action,
        /// or a certificate imported into ACM using the <c>ImportCertificate</c> action. The
        /// chain consists of the certificate of the issuing CA and the intermediate certificates
        /// of any other subordinate CAs. All of the certificates are base64 encoded. You can
        /// use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        Task<GetCertificateResponse> GetCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Retrieves a certificate and its certificate chain. The certificate may be either a
        /// public or private certificate issued using the ACM <c>RequestCertificate</c> action,
        /// or a certificate imported into ACM using the <c>ImportCertificate</c> action. The
        /// chain consists of the certificate of the issuing CA and the intermediate certificates
        /// of any other subordinate CAs. All of the certificates are base64 encoded. You can
        /// use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportCertificate


        /// <summary>
        /// Imports a certificate into Certificate Manager (ACM) to use with services that are
        /// integrated with ACM. Note that <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">integrated
        /// services</a> allow only certificate types and keys they support to be associated with
        /// their resources. Further, their support differs depending on whether the certificate
        /// is imported into IAM or into ACM. For more information, see the documentation for
        /// each service. For more information about importing certificates into ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>Certificate Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// ACM does not provide <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for certificates that you import.
        /// </para>
        ///  </note> 
        /// <para>
        /// Note the following guidelines when importing third party certificates:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must enter the private key that matches the certificate you are importing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be unencrypted. You cannot import a private key that is protected
        /// by a password or a passphrase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be no larger than 5 KB (5,120 bytes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate, private key, and certificate chain must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The current time must be between the <c>Not Before</c> and <c>Not After</c> certificate
        /// fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Issuer</c> field must not be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The OCSP authority URL, if present, must not exceed 1000 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To import a new certificate, omit the <c>CertificateArn</c> argument. Include this
        /// argument only when you want to replace a previously imported certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using the CLI, you must specify the certificate,
        /// the certificate chain, and the private key by their file names preceded by <c>fileb://</c>.
        /// For example, you can specify a certificate saved in the <c>C:\temp</c> folder as <c>fileb://C:\temp\certificate_to_import.pem</c>.
        /// If you are making an HTTP or HTTPS Query request, include these arguments as BLOBs.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using an SDK, you must specify the certificate, the
        /// certificate chain, and the private key files in the manner required by the programming
        /// language you're using. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cryptographic algorithm of an imported certificate must match the algorithm of
        /// the signing CA. For example, if the signing CA key type is RSA, then the certificate
        /// key type must also be RSA.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation returns the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the imported certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        ImportCertificateResponse ImportCertificate(ImportCertificateRequest request);



        /// <summary>
        /// Imports a certificate into Certificate Manager (ACM) to use with services that are
        /// integrated with ACM. Note that <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">integrated
        /// services</a> allow only certificate types and keys they support to be associated with
        /// their resources. Further, their support differs depending on whether the certificate
        /// is imported into IAM or into ACM. For more information, see the documentation for
        /// each service. For more information about importing certificates into ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>Certificate Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// ACM does not provide <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for certificates that you import.
        /// </para>
        ///  </note> 
        /// <para>
        /// Note the following guidelines when importing third party certificates:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must enter the private key that matches the certificate you are importing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be unencrypted. You cannot import a private key that is protected
        /// by a password or a passphrase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be no larger than 5 KB (5,120 bytes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate, private key, and certificate chain must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The current time must be between the <c>Not Before</c> and <c>Not After</c> certificate
        /// fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Issuer</c> field must not be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The OCSP authority URL, if present, must not exceed 1000 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To import a new certificate, omit the <c>CertificateArn</c> argument. Include this
        /// argument only when you want to replace a previously imported certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using the CLI, you must specify the certificate,
        /// the certificate chain, and the private key by their file names preceded by <c>fileb://</c>.
        /// For example, you can specify a certificate saved in the <c>C:\temp</c> folder as <c>fileb://C:\temp\certificate_to_import.pem</c>.
        /// If you are making an HTTP or HTTPS Query request, include these arguments as BLOBs.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using an SDK, you must specify the certificate, the
        /// certificate chain, and the private key files in the manner required by the programming
        /// language you're using. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cryptographic algorithm of an imported certificate must match the algorithm of
        /// the signing CA. For example, if the signing CA key type is RSA, then the certificate
        /// key type must also be RSA.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation returns the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the imported certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCertificates


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <c>RSA_2048</c> certificates. For
        /// more information, see <a>Filters</a>.
        /// </summary>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of request parameters specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse ListCertificates();


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <c>RSA_2048</c> certificates. For
        /// more information, see <a>Filters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of request parameters specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse ListCertificates(ListCertificatesRequest request);


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <c>RSA_2048</c> certificates. For
        /// more information, see <a>Filters</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of request parameters specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        Task<ListCertificatesResponse> ListCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <c>RSA_2048</c> certificates. For
        /// more information, see <a>Filters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of request parameters specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForCertificate


        /// <summary>
        /// Lists the tags that have been applied to the ACM certificate. Use the certificate's
        /// Amazon Resource Name (ARN) to specify the certificate. To add a tag to an ACM certificate,
        /// use the <a>AddTagsToCertificate</a> action. To delete a tag, use the <a>RemoveTagsFromCertificate</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate service method.</param>
        /// 
        /// <returns>The response from the ListTagsForCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        ListTagsForCertificateResponse ListTagsForCertificate(ListTagsForCertificateRequest request);



        /// <summary>
        /// Lists the tags that have been applied to the ACM certificate. Use the certificate's
        /// Amazon Resource Name (ARN) to specify the certificate. To add a tag to an ACM certificate,
        /// use the <a>AddTagsToCertificate</a> action. To delete a tag, use the <a>RemoveTagsFromCertificate</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        Task<ListTagsForCertificateResponse> ListTagsForCertificateAsync(ListTagsForCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAccountConfiguration


        /// <summary>
        /// Adds or modifies account-level configurations in ACM. 
        /// 
        ///  
        /// <para>
        /// The supported configuration option is <c>DaysBeforeExpiry</c>. This option specifies
        /// the number of days prior to certificate expiration when ACM starts generating <c>EventBridge</c>
        /// events. ACM sends one event per day per certificate until the certificate expires.
        /// By default, accounts receive events starting 45 days before certificate expiration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutAccountConfiguration service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/PutAccountConfiguration">REST API Reference for PutAccountConfiguration Operation</seealso>
        PutAccountConfigurationResponse PutAccountConfiguration(PutAccountConfigurationRequest request);



        /// <summary>
        /// Adds or modifies account-level configurations in ACM. 
        /// 
        ///  
        /// <para>
        /// The supported configuration option is <c>DaysBeforeExpiry</c>. This option specifies
        /// the number of days prior to certificate expiration when ACM starts generating <c>EventBridge</c>
        /// events. ACM sends one event per day per certificate until the certificate expires.
        /// By default, accounts receive events starting 45 days before certificate expiration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountConfiguration service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/PutAccountConfiguration">REST API Reference for PutAccountConfiguration Operation</seealso>
        Task<PutAccountConfigurationResponse> PutAccountConfigurationAsync(PutAccountConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromCertificate


        /// <summary>
        /// Remove one or more tags from an ACM certificate. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value. 
        /// 
        ///  
        /// <para>
        /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
        /// all of the tags that have been applied to a specific ACM certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        RemoveTagsFromCertificateResponse RemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request);



        /// <summary>
        /// Remove one or more tags from an ACM certificate. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value. 
        /// 
        ///  
        /// <para>
        /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
        /// all of the tags that have been applied to a specific ACM certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        Task<RemoveTagsFromCertificateResponse> RemoveTagsFromCertificateAsync(RemoveTagsFromCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RenewCertificate


        /// <summary>
        /// Renews an <a href="https://docs.aws.amazon.com/acm/latest/userguide/managed-renewal.html">eligible
        /// ACM certificate</a>. In order to renew your Amazon Web Services Private CA certificates
        /// with ACM, you must first <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaPermissions.html">grant
        /// the ACM service principal permission to do so</a>. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/manual-renewal.html">Testing
        /// Managed Renewal</a> in the ACM User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewCertificate service method.</param>
        /// 
        /// <returns>The response from the RenewCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RenewCertificate">REST API Reference for RenewCertificate Operation</seealso>
        RenewCertificateResponse RenewCertificate(RenewCertificateRequest request);



        /// <summary>
        /// Renews an <a href="https://docs.aws.amazon.com/acm/latest/userguide/managed-renewal.html">eligible
        /// ACM certificate</a>. In order to renew your Amazon Web Services Private CA certificates
        /// with ACM, you must first <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaPermissions.html">grant
        /// the ACM service principal permission to do so</a>. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/manual-renewal.html">Testing
        /// Managed Renewal</a> in the ACM User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenewCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RenewCertificate">REST API Reference for RenewCertificate Operation</seealso>
        Task<RenewCertificateResponse> RenewCertificateAsync(RenewCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RequestCertificate


        /// <summary>
        /// Requests an ACM certificate for use with other Amazon Web Services services. To request
        /// an ACM certificate, you must specify a fully qualified domain name (FQDN) in the <c>DomainName</c>
        /// parameter. You can also specify additional FQDNs in the <c>SubjectAlternativeNames</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM behavior differs from the <a href="https://datatracker.ietf.org/doc/html/rfc6125#appendix-B.2">RFC
        /// 6125</a> specification of the certificate validation process. ACM first checks for
        /// a Subject Alternative Name, and, if it finds one, ignores the common name (CN).
        /// </para>
        ///  </note> 
        /// <para>
        /// After successful completion of the <c>RequestCertificate</c> action, there is a delay
        /// of several seconds before you can retrieve information about the new certificate.
        /// </para>
        /// </summary>
        /// <param name="domainName">Fully qualified domain name (FQDN), such as www.example.com, that you want to secure with an ACM certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.  In compliance with <a href="https://datatracker.ietf.org/doc/html/rfc5280">RFC 5280</a>, the length of the domain name (technically, the Common Name) that you provide cannot exceed 64 octets (characters), including periods. To add a longer domain name, specify it in the Subject Alternative Name field, which supports names up to 253 octets in length. </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        RequestCertificateResponse RequestCertificate(string domainName);

        /// <summary>
        /// Requests an ACM certificate for use with other Amazon Web Services services. To request
        /// an ACM certificate, you must specify a fully qualified domain name (FQDN) in the <c>DomainName</c>
        /// parameter. You can also specify additional FQDNs in the <c>SubjectAlternativeNames</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM behavior differs from the <a href="https://datatracker.ietf.org/doc/html/rfc6125#appendix-B.2">RFC
        /// 6125</a> specification of the certificate validation process. ACM first checks for
        /// a Subject Alternative Name, and, if it finds one, ignores the common name (CN).
        /// </para>
        ///  </note> 
        /// <para>
        /// After successful completion of the <c>RequestCertificate</c> action, there is a delay
        /// of several seconds before you can retrieve information about the new certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        RequestCertificateResponse RequestCertificate(RequestCertificateRequest request);


        /// <summary>
        /// Requests an ACM certificate for use with other Amazon Web Services services. To request
        /// an ACM certificate, you must specify a fully qualified domain name (FQDN) in the <c>DomainName</c>
        /// parameter. You can also specify additional FQDNs in the <c>SubjectAlternativeNames</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM behavior differs from the <a href="https://datatracker.ietf.org/doc/html/rfc6125#appendix-B.2">RFC
        /// 6125</a> specification of the certificate validation process. ACM first checks for
        /// a Subject Alternative Name, and, if it finds one, ignores the common name (CN).
        /// </para>
        ///  </note> 
        /// <para>
        /// After successful completion of the <c>RequestCertificate</c> action, there is a delay
        /// of several seconds before you can retrieve information about the new certificate.
        /// </para>
        /// </summary>
        /// <param name="domainName">Fully qualified domain name (FQDN), such as www.example.com, that you want to secure with an ACM certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.  In compliance with <a href="https://datatracker.ietf.org/doc/html/rfc5280">RFC 5280</a>, the length of the domain name (technically, the Common Name) that you provide cannot exceed 64 octets (characters), including periods. To add a longer domain name, specify it in the Subject Alternative Name field, which supports names up to 253 octets in length. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        Task<RequestCertificateResponse> RequestCertificateAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Requests an ACM certificate for use with other Amazon Web Services services. To request
        /// an ACM certificate, you must specify a fully qualified domain name (FQDN) in the <c>DomainName</c>
        /// parameter. You can also specify additional FQDNs in the <c>SubjectAlternativeNames</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM behavior differs from the <a href="https://datatracker.ietf.org/doc/html/rfc6125#appendix-B.2">RFC
        /// 6125</a> specification of the certificate validation process. ACM first checks for
        /// a Subject Alternative Name, and, if it finds one, ignores the common name (CN).
        /// </para>
        ///  </note> 
        /// <para>
        /// After successful completion of the <c>RequestCertificate</c> action, there is a delay
        /// of several seconds before you can retrieve information about the new certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        Task<RequestCertificateResponse> RequestCertificateAsync(RequestCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResendValidationEmail


        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or an
        /// authorized representative must approve the ACM certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
        /// For more information about setting up your contact email addresses, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/setup-email.html">Configure
        /// Email for your Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail service method.</param>
        /// 
        /// <returns>The response from the ResendValidationEmail service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        ResendValidationEmailResponse ResendValidationEmail(ResendValidationEmailRequest request);



        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or an
        /// authorized representative must approve the ACM certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
        /// For more information about setting up your contact email addresses, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/setup-email.html">Configure
        /// Email for your Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendValidationEmail service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        Task<ResendValidationEmailResponse> ResendValidationEmailAsync(ResendValidationEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeCertificate


        /// <summary>
        /// Revokes a public ACM certificate. You can only revoke certificates that have been
        /// previously exported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCertificate service method.</param>
        /// 
        /// <returns>The response from the RevokeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        RevokeCertificateResponse RevokeCertificate(RevokeCertificateRequest request);



        /// <summary>
        /// Revokes a public ACM certificate. You can only revoke certificates that have been
        /// previously exported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        Task<RevokeCertificateResponse> RevokeCertificateAsync(RevokeCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCertificateOptions


        /// <summary>
        /// Updates a certificate. You can use this function to specify whether to opt in to or
        /// out of recording your certificate in a certificate transparency log and exporting.
        /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency">
        /// Opting Out of Certificate Transparency Logging</a> and <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-exportable-certificates.html">Certificate
        /// Manager Exportable Managed Certificates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateCertificateOptions service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateCertificateOptions">REST API Reference for UpdateCertificateOptions Operation</seealso>
        UpdateCertificateOptionsResponse UpdateCertificateOptions(UpdateCertificateOptionsRequest request);



        /// <summary>
        /// Updates a certificate. You can use this function to specify whether to opt in to or
        /// out of recording your certificate in a certificate transparency log and exporting.
        /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency">
        /// Opting Out of Certificate Transparency Logging</a> and <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-exportable-certificates.html">Certificate
        /// Manager Exportable Managed Certificates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCertificateOptions service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateCertificateOptions">REST API Reference for UpdateCertificateOptions Operation</seealso>
        Task<UpdateCertificateOptionsResponse> UpdateCertificateOptionsAsync(UpdateCertificateOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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