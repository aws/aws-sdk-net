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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppConfigData.Model;

namespace Amazon.AppConfigData
{
    /// <summary>
    /// Interface for accessing AppConfigData
    ///
    /// Use the AppConfigData API, a capability of AWS AppConfig, to retrieve deployed configuration.
    /// </summary>
    public partial interface IAmazonAppConfigData : IAmazonService, IDisposable
    {




        
        #region  GetLatestConfiguration


        /// <summary>
        /// Retrieves the latest deployed configuration. This API may return empty Configuration
        /// data if the client already has the latest version. See StartConfigurationSession to
        /// obtain an InitialConfigurationToken to call this API.
        /// 
        ///  <important> 
        /// <para>
        /// Each call to GetLatestConfiguration returns a new ConfigurationToken (NextPollConfigurationToken
        /// in the response). This new token MUST be provided to the next call to GetLatestConfiguration
        /// when polling for configuration updates.
        /// </para>
        ///  
        /// <para>
        /// To avoid excess charges, we recommend that you include the <code>ClientConfigurationVersion</code>
        /// value with every call to <code>GetConfiguration</code>. This value must be saved on
        /// your client. Subsequent calls to <code>GetConfiguration</code> must pass this value
        /// by using the <code>ClientConfigurationVersion</code> parameter. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLatestConfiguration service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/GetLatestConfiguration">REST API Reference for GetLatestConfiguration Operation</seealso>
        GetLatestConfigurationResponse GetLatestConfiguration(GetLatestConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLatestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLatestConfiguration operation on AmazonAppConfigDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLatestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/GetLatestConfiguration">REST API Reference for GetLatestConfiguration Operation</seealso>
        IAsyncResult BeginGetLatestConfiguration(GetLatestConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLatestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLatestConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLatestConfigurationResult from AppConfigData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/GetLatestConfiguration">REST API Reference for GetLatestConfiguration Operation</seealso>
        GetLatestConfigurationResponse EndGetLatestConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  StartConfigurationSession


        /// <summary>
        /// Starts a configuration session used to retrieve a deployed configuration. See the
        /// GetLatestConfiguration API for more details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationSession service method.</param>
        /// 
        /// <returns>The response from the StartConfigurationSession service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/StartConfigurationSession">REST API Reference for StartConfigurationSession Operation</seealso>
        StartConfigurationSessionResponse StartConfigurationSession(StartConfigurationSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationSession operation on AmazonAppConfigDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConfigurationSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/StartConfigurationSession">REST API Reference for StartConfigurationSession Operation</seealso>
        IAsyncResult BeginStartConfigurationSession(StartConfigurationSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartConfigurationSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConfigurationSession.</param>
        /// 
        /// <returns>Returns a  StartConfigurationSessionResult from AppConfigData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/StartConfigurationSession">REST API Reference for StartConfigurationSession Operation</seealso>
        StartConfigurationSessionResponse EndStartConfigurationSession(IAsyncResult asyncResult);

        #endregion
        
    }
}