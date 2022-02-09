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
    /// AppConfig Data provides the data plane APIs your application uses to retrieve configuration
    /// data. Here's how it works:
    /// 
    ///  
    /// <para>
    /// Your application retrieves configuration data by first establishing a configuration
    /// session using the AppConfig Data <a>StartConfigurationSession</a> API action. Your
    /// session's client then makes periodic calls to <a>GetLatestConfiguration</a> to check
    /// for and retrieve the latest data available.
    /// </para>
    ///  
    /// <para>
    /// When calling <code>StartConfigurationSession</code>, your code sends the following
    /// information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Identifiers (ID or name) of an AppConfig application, environment, and configuration
    /// profile that the session tracks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) The minimum amount of time the session's client must wait between calls
    /// to <code>GetLatestConfiguration</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In response, AppConfig provides an <code>InitialConfigurationToken</code> to be given
    /// to the session's client and used the first time it calls <code>GetLatestConfiguration</code>
    /// for that session.
    /// </para>
    ///  
    /// <para>
    /// When calling <code>GetLatestConfiguration</code>, your client code sends the most
    /// recent <code>ConfigurationToken</code> value it has and receives in response:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>NextPollConfigurationToken</code>: the <code>ConfigurationToken</code> value
    /// to use on the next call to <code>GetLatestConfiguration</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>NextPollIntervalInSeconds</code>: the duration the client should wait before
    /// making its next call to <code>GetLatestConfiguration</code>. This duration may vary
    /// over the course of the session, so it should be used instead of the value sent on
    /// the <code>StartConfigurationSession</code> call.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The configuration: the latest data intended for the session. This may be empty if
    /// the client already has the latest version of the configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information and to view example CLI commands that show how to retrieve a
    /// configuration using the AppConfig Data <code>StartConfigurationSession</code> and
    /// <code>GetLatestConfiguration</code> API actions, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Receiving
    /// the configuration</a> in the <i>AppConfig User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAppConfigData : IAmazonService, IDisposable
    {




        
        #region  GetLatestConfiguration


        /// <summary>
        /// Retrieves the latest deployed configuration. This API may return empty configuration
        /// data if the client already has the latest version. For more information about this
        /// API action and to view example CLI commands that show how to use it with the <a>StartConfigurationSession</a>
        /// API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Receiving
        /// the configuration</a> in the <i>AppConfig User Guide</i>. 
        /// 
        ///  <important> 
        /// <para>
        /// Note the following important information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Each configuration token is only valid for one call to <code>GetLatestConfiguration</code>.
        /// The <code>GetLatestConfiguration</code> response includes a <code>NextPollConfigurationToken</code>
        /// that should always replace the token used for the just-completed call in preparation
        /// for the next one. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GetLatestConfiguration</code> is a priced call. For more information, see <a
        /// href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
        /// </para>
        ///  </li> </ul> </important>
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
        /// Starts a configuration session used to retrieve a deployed configuration. For more
        /// information about this API action and to view example CLI commands that show how to
        /// use it with the <a>GetLatestConfiguration</a> API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Receiving
        /// the configuration</a> in the <i>AppConfig User Guide</i>.
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