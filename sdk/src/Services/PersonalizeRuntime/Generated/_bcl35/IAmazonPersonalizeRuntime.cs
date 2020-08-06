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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PersonalizeRuntime.Model;

namespace Amazon.PersonalizeRuntime
{
    /// <summary>
    /// Interface for accessing PersonalizeRuntime
    ///
    /// 
    /// </summary>
    public partial interface IAmazonPersonalizeRuntime : IAmazonService, IDisposable
    {




        
        #region  GetPersonalizedRanking


        /// <summary>
        /// Re-ranks a list of recommended items for the given user. The first item in the list
        /// is deemed the most likely item to be of interest to the user.
        /// 
        ///  <note> 
        /// <para>
        /// The solution backing the campaign must have been created using a recipe of type PERSONALIZED_RANKING.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersonalizedRanking service method.</param>
        /// 
        /// <returns>The response from the GetPersonalizedRanking service method, as returned by PersonalizeRuntime.</returns>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetPersonalizedRanking">REST API Reference for GetPersonalizedRanking Operation</seealso>
        GetPersonalizedRankingResponse GetPersonalizedRanking(GetPersonalizedRankingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPersonalizedRanking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersonalizedRanking operation on AmazonPersonalizeRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPersonalizedRanking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetPersonalizedRanking">REST API Reference for GetPersonalizedRanking Operation</seealso>
        IAsyncResult BeginGetPersonalizedRanking(GetPersonalizedRankingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPersonalizedRanking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPersonalizedRanking.</param>
        /// 
        /// <returns>Returns a  GetPersonalizedRankingResult from PersonalizeRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetPersonalizedRanking">REST API Reference for GetPersonalizedRanking Operation</seealso>
        GetPersonalizedRankingResponse EndGetPersonalizedRanking(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommendations


        /// <summary>
        /// Returns a list of recommended items. The required input depends on the recipe type
        /// used to create the solution backing the campaign, as follows:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// RELATED_ITEMS - <code>itemId</code> required, <code>userId</code> not used
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USER_PERSONALIZATION - <code>itemId</code> optional, <code>userId</code> required
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Campaigns that are backed by a solution created using a recipe of type PERSONALIZED_RANKING
        /// use the API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetRecommendations service method, as returned by PersonalizeRuntime.</returns>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations operation on AmazonPersonalizeRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        IAsyncResult BeginGetRecommendations(GetRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendations.</param>
        /// 
        /// <returns>Returns a  GetRecommendationsResult from PersonalizeRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        GetRecommendationsResponse EndGetRecommendations(IAsyncResult asyncResult);

        #endregion
        
    }
}