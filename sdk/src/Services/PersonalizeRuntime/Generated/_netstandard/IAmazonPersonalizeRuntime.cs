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
using System.Threading;
using System.Threading.Tasks;
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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPersonalizedRanking service method, as returned by PersonalizeRuntime.</returns>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetPersonalizedRanking">REST API Reference for GetPersonalizedRanking Operation</seealso>
        Task<GetPersonalizedRankingResponse> GetPersonalizedRankingAsync(GetPersonalizedRankingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendations service method, as returned by PersonalizeRuntime.</returns>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeRuntime.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-runtime-2018-05-22/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        Task<GetRecommendationsResponse> GetRecommendationsAsync(GetRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}