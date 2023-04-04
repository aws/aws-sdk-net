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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AmplifyUIBuilder.Model;

namespace Amazon.AmplifyUIBuilder
{
    /// <summary>
    /// Interface for accessing AmplifyUIBuilder
    ///
    /// The Amplify UI Builder API provides a programmatic interface for creating and configuring
    /// user interface (UI) component libraries and themes for use in your Amplify applications.
    /// You can then connect these UI components to an application's backend Amazon Web Services
    /// resources.
    /// 
    ///  
    /// <para>
    /// You can also use the Amplify Studio visual designer to create UI components and model
    /// data for an app. For more information, see <a href="https://docs.amplify.aws/console/adminui/intro">Introduction</a>
    /// in the <i>Amplify Docs</i>.
    /// </para>
    ///  
    /// <para>
    /// The Amplify Framework is a comprehensive set of SDKs, libraries, tools, and documentation
    /// for client app development. For more information, see the <a href="https://docs.amplify.aws/">Amplify
    /// Framework</a>. For more information about deploying an Amplify application to Amazon
    /// Web Services, see the <a href="https://docs.aws.amazon.com/amplify/latest/userguide/welcome.html">Amplify
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAmplifyUIBuilder : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAmplifyUIBuilderPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateComponent



        /// <summary>
        /// Creates a new component for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        Task<CreateComponentResponse> CreateComponentAsync(CreateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateForm



        /// <summary>
        /// Creates a new form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateForm">REST API Reference for CreateForm Operation</seealso>
        Task<CreateFormResponse> CreateFormAsync(CreateFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTheme



        /// <summary>
        /// Creates a theme to apply to the components in an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        Task<CreateThemeResponse> CreateThemeAsync(CreateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteComponent



        /// <summary>
        /// Deletes a component from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        Task<DeleteComponentResponse> DeleteComponentAsync(DeleteComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteForm



        /// <summary>
        /// Deletes a form from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteForm">REST API Reference for DeleteForm Operation</seealso>
        Task<DeleteFormResponse> DeleteFormAsync(DeleteFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTheme



        /// <summary>
        /// Deletes a theme from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        Task<DeleteThemeResponse> DeleteThemeAsync(DeleteThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExchangeCodeForToken



        /// <summary>
        /// Exchanges an access code for a token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExchangeCodeForToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExchangeCodeForToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        Task<ExchangeCodeForTokenResponse> ExchangeCodeForTokenAsync(ExchangeCodeForTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportComponents



        /// <summary>
        /// Exports component configurations to code that is ready to integrate into an Amplify
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        Task<ExportComponentsResponse> ExportComponentsAsync(ExportComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportForms



        /// <summary>
        /// Exports form configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportForms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        Task<ExportFormsResponse> ExportFormsAsync(ExportFormsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportThemes



        /// <summary>
        /// Exports theme configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportThemes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        Task<ExportThemesResponse> ExportThemesAsync(ExportThemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetComponent



        /// <summary>
        /// Returns an existing component for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetComponent">REST API Reference for GetComponent Operation</seealso>
        Task<GetComponentResponse> GetComponentAsync(GetComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetForm



        /// <summary>
        /// Returns an existing form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetForm">REST API Reference for GetForm Operation</seealso>
        Task<GetFormResponse> GetFormAsync(GetFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMetadata



        /// <summary>
        /// Returns existing metadata for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetadata service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        Task<GetMetadataResponse> GetMetadataAsync(GetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTheme



        /// <summary>
        /// Returns an existing theme for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetTheme">REST API Reference for GetTheme Operation</seealso>
        Task<GetThemeResponse> GetThemeAsync(GetThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListComponents



        /// <summary>
        /// Retrieves a list of components for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
        Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListForms



        /// <summary>
        /// Retrieves a list of forms for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        Task<ListFormsResponse> ListFormsAsync(ListFormsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThemes



        /// <summary>
        /// Retrieves a list of themes for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        Task<ListThemesResponse> ListThemesAsync(ListThemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMetadataFlag



        /// <summary>
        /// Stores the metadata information about a feature on a form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetadataFlag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetadataFlag service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        Task<PutMetadataFlagResponse> PutMetadataFlagAsync(PutMetadataFlagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RefreshToken



        /// <summary>
        /// Refreshes a previously issued access token that might have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RefreshToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateComponent



        /// <summary>
        /// Updates an existing component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComponent service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        Task<UpdateComponentResponse> UpdateComponentAsync(UpdateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateForm



        /// <summary>
        /// Updates an existing form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateForm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateForm service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateForm">REST API Reference for UpdateForm Operation</seealso>
        Task<UpdateFormResponse> UpdateFormAsync(UpdateFormRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTheme



        /// <summary>
        /// Updates an existing theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTheme service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        Task<UpdateThemeResponse> UpdateThemeAsync(UpdateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}