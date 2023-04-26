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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        CreateComponentResponse CreateComponent(CreateComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        IAsyncResult BeginCreateComponent(CreateComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponent.</param>
        /// 
        /// <returns>Returns a  CreateComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        CreateComponentResponse EndCreateComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateForm


        /// <summary>
        /// Creates a new form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForm service method.</param>
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
        CreateFormResponse CreateForm(CreateFormRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateForm">REST API Reference for CreateForm Operation</seealso>
        IAsyncResult BeginCreateForm(CreateFormRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForm.</param>
        /// 
        /// <returns>Returns a  CreateFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateForm">REST API Reference for CreateForm Operation</seealso>
        CreateFormResponse EndCreateForm(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTheme


        /// <summary>
        /// Creates a theme to apply to the components in an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme service method.</param>
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
        CreateThemeResponse CreateTheme(CreateThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        IAsyncResult BeginCreateTheme(CreateThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTheme.</param>
        /// 
        /// <returns>Returns a  CreateThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        CreateThemeResponse EndCreateTheme(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteComponent


        /// <summary>
        /// Deletes a component from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
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
        DeleteComponentResponse DeleteComponent(DeleteComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponent.</param>
        /// 
        /// <returns>Returns a  DeleteComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteForm


        /// <summary>
        /// Deletes a form from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForm service method.</param>
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
        DeleteFormResponse DeleteForm(DeleteFormRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteForm">REST API Reference for DeleteForm Operation</seealso>
        IAsyncResult BeginDeleteForm(DeleteFormRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForm.</param>
        /// 
        /// <returns>Returns a  DeleteFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteForm">REST API Reference for DeleteForm Operation</seealso>
        DeleteFormResponse EndDeleteForm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTheme


        /// <summary>
        /// Deletes a theme from an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme service method.</param>
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
        DeleteThemeResponse DeleteTheme(DeleteThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        IAsyncResult BeginDeleteTheme(DeleteThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTheme.</param>
        /// 
        /// <returns>Returns a  DeleteThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        DeleteThemeResponse EndDeleteTheme(IAsyncResult asyncResult);

        #endregion
        
        #region  ExchangeCodeForToken


        /// <summary>
        /// Exchanges an access code for a token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExchangeCodeForToken service method.</param>
        /// 
        /// <returns>The response from the ExchangeCodeForToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        ExchangeCodeForTokenResponse ExchangeCodeForToken(ExchangeCodeForTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExchangeCodeForToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExchangeCodeForToken operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExchangeCodeForToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        IAsyncResult BeginExchangeCodeForToken(ExchangeCodeForTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExchangeCodeForToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExchangeCodeForToken.</param>
        /// 
        /// <returns>Returns a  ExchangeCodeForTokenResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExchangeCodeForToken">REST API Reference for ExchangeCodeForToken Operation</seealso>
        ExchangeCodeForTokenResponse EndExchangeCodeForToken(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportComponents


        /// <summary>
        /// Exports component configurations to code that is ready to integrate into an Amplify
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportComponents service method.</param>
        /// 
        /// <returns>The response from the ExportComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        ExportComponentsResponse ExportComponents(ExportComponentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportComponents operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        IAsyncResult BeginExportComponents(ExportComponentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportComponents.</param>
        /// 
        /// <returns>Returns a  ExportComponentsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportComponents">REST API Reference for ExportComponents Operation</seealso>
        ExportComponentsResponse EndExportComponents(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportForms


        /// <summary>
        /// Exports form configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportForms service method.</param>
        /// 
        /// <returns>The response from the ExportForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        ExportFormsResponse ExportForms(ExportFormsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportForms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportForms operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportForms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        IAsyncResult BeginExportForms(ExportFormsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportForms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportForms.</param>
        /// 
        /// <returns>Returns a  ExportFormsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportForms">REST API Reference for ExportForms Operation</seealso>
        ExportFormsResponse EndExportForms(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportThemes


        /// <summary>
        /// Exports theme configurations to code that is ready to integrate into an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportThemes service method.</param>
        /// 
        /// <returns>The response from the ExportThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        ExportThemesResponse ExportThemes(ExportThemesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportThemes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportThemes operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportThemes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        IAsyncResult BeginExportThemes(ExportThemesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportThemes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportThemes.</param>
        /// 
        /// <returns>Returns a  ExportThemesResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ExportThemes">REST API Reference for ExportThemes Operation</seealso>
        ExportThemesResponse EndExportThemes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetComponent


        /// <summary>
        /// Returns an existing component for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
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
        GetComponentResponse GetComponent(GetComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetComponent">REST API Reference for GetComponent Operation</seealso>
        IAsyncResult BeginGetComponent(GetComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponent.</param>
        /// 
        /// <returns>Returns a  GetComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetComponent">REST API Reference for GetComponent Operation</seealso>
        GetComponentResponse EndGetComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetForm


        /// <summary>
        /// Returns an existing form for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetForm service method.</param>
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
        GetFormResponse GetForm(GetFormRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetForm">REST API Reference for GetForm Operation</seealso>
        IAsyncResult BeginGetForm(GetFormRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetForm.</param>
        /// 
        /// <returns>Returns a  GetFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetForm">REST API Reference for GetForm Operation</seealso>
        GetFormResponse EndGetForm(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMetadata


        /// <summary>
        /// Returns existing metadata for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetadata service method.</param>
        /// 
        /// <returns>The response from the GetMetadata service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        GetMetadataResponse GetMetadata(GetMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetadata operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        IAsyncResult BeginGetMetadata(GetMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetadata.</param>
        /// 
        /// <returns>Returns a  GetMetadataResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetMetadata">REST API Reference for GetMetadata Operation</seealso>
        GetMetadataResponse EndGetMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTheme


        /// <summary>
        /// Returns an existing theme for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTheme service method.</param>
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
        GetThemeResponse GetTheme(GetThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetTheme">REST API Reference for GetTheme Operation</seealso>
        IAsyncResult BeginGetTheme(GetThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTheme.</param>
        /// 
        /// <returns>Returns a  GetThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/GetTheme">REST API Reference for GetTheme Operation</seealso>
        GetThemeResponse EndGetTheme(IAsyncResult asyncResult);

        #endregion
        
        #region  ListComponents


        /// <summary>
        /// Retrieves a list of components for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
        ListComponentsResponse ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
        IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListComponents">REST API Reference for ListComponents Operation</seealso>
        ListComponentsResponse EndListComponents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListForms


        /// <summary>
        /// Retrieves a list of forms for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForms service method.</param>
        /// 
        /// <returns>The response from the ListForms service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        ListFormsResponse ListForms(ListFormsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListForms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForms operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        IAsyncResult BeginListForms(ListFormsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListForms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForms.</param>
        /// 
        /// <returns>Returns a  ListFormsResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListForms">REST API Reference for ListForms Operation</seealso>
        ListFormsResponse EndListForms(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThemes


        /// <summary>
        /// Retrieves a list of themes for a specified Amplify app and backend environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemes service method.</param>
        /// 
        /// <returns>The response from the ListThemes service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InternalServerException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        ListThemesResponse ListThemes(ListThemesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThemes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThemes operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThemes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        IAsyncResult BeginListThemes(ListThemesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThemes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThemes.</param>
        /// 
        /// <returns>Returns a  ListThemesResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/ListThemes">REST API Reference for ListThemes Operation</seealso>
        ListThemesResponse EndListThemes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMetadataFlag


        /// <summary>
        /// Stores the metadata information about a feature on a form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetadataFlag service method.</param>
        /// 
        /// <returns>The response from the PutMetadataFlag service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.UnauthorizedException">
        /// You don't have permission to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        PutMetadataFlagResponse PutMetadataFlag(PutMetadataFlagRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetadataFlag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetadataFlag operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetadataFlag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        IAsyncResult BeginPutMetadataFlag(PutMetadataFlagRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetadataFlag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetadataFlag.</param>
        /// 
        /// <returns>Returns a  PutMetadataFlagResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/PutMetadataFlag">REST API Reference for PutMetadataFlag Operation</seealso>
        PutMetadataFlagResponse EndPutMetadataFlag(IAsyncResult asyncResult);

        #endregion
        
        #region  RefreshToken


        /// <summary>
        /// Refreshes a previously issued access token that might have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshToken service method.</param>
        /// 
        /// <returns>The response from the RefreshToken service method, as returned by AmplifyUIBuilder.</returns>
        /// <exception cref="Amazon.AmplifyUIBuilder.Model.InvalidParameterException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        RefreshTokenResponse RefreshToken(RefreshTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshToken operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRefreshToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        IAsyncResult BeginRefreshToken(RefreshTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RefreshToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRefreshToken.</param>
        /// 
        /// <returns>Returns a  RefreshTokenResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/RefreshToken">REST API Reference for RefreshToken Operation</seealso>
        RefreshTokenResponse EndRefreshToken(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateComponent


        /// <summary>
        /// Updates an existing component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
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
        UpdateComponentResponse UpdateComponent(UpdateComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        IAsyncResult BeginUpdateComponent(UpdateComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponent.</param>
        /// 
        /// <returns>Returns a  UpdateComponentResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        UpdateComponentResponse EndUpdateComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateForm


        /// <summary>
        /// Updates an existing form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateForm service method.</param>
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
        UpdateFormResponse UpdateForm(UpdateFormRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateForm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateForm operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateForm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateForm">REST API Reference for UpdateForm Operation</seealso>
        IAsyncResult BeginUpdateForm(UpdateFormRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateForm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateForm.</param>
        /// 
        /// <returns>Returns a  UpdateFormResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateForm">REST API Reference for UpdateForm Operation</seealso>
        UpdateFormResponse EndUpdateForm(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTheme


        /// <summary>
        /// Updates an existing theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme service method.</param>
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
        UpdateThemeResponse UpdateTheme(UpdateThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme operation on AmazonAmplifyUIBuilderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        IAsyncResult BeginUpdateTheme(UpdateThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTheme.</param>
        /// 
        /// <returns>Returns a  UpdateThemeResult from AmplifyUIBuilder.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifyuibuilder-2021-08-11/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        UpdateThemeResponse EndUpdateTheme(IAsyncResult asyncResult);

        #endregion
        
    }
}