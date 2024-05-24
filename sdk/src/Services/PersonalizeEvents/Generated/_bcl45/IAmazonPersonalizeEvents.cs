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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PersonalizeEvents.Model;

#pragma warning disable CS1570
namespace Amazon.PersonalizeEvents
{
    /// <summary>
    /// <para>Interface for accessing PersonalizeEvents</para>
    ///
    /// Amazon Personalize can consume real-time user event data, such as <i>stream</i> or
    /// <i>click</i> data, and use it for model training either alone or combined with historical
    /// data. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-item-interaction-events.html">Recording
    /// item interaction events</a>.
    /// </summary>
    public partial interface IAmazonPersonalizeEvents : IAmazonService, IDisposable
    {


        
        #region  PutActionInteractions


        /// <summary>
        /// Records action interaction event data. An <i>action interaction</i> event is an interaction
        /// between a user and an <i>action</i>. For example, a user taking an action, such a
        /// enrolling in a membership program or downloading your app.
        /// 
        ///  
        /// <para>
        ///  For more information about recording action interactions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-action-interaction-events.html">Recording
        /// action interaction events</a>. For more information about actions in an Actions dataset,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/actions-datasets.html">Actions
        /// dataset</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActionInteractions service method.</param>
        /// 
        /// <returns>The response from the PutActionInteractions service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutActionInteractions">REST API Reference for PutActionInteractions Operation</seealso>
        PutActionInteractionsResponse PutActionInteractions(PutActionInteractionsRequest request);



        /// <summary>
        /// Records action interaction event data. An <i>action interaction</i> event is an interaction
        /// between a user and an <i>action</i>. For example, a user taking an action, such a
        /// enrolling in a membership program or downloading your app.
        /// 
        ///  
        /// <para>
        ///  For more information about recording action interactions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-action-interaction-events.html">Recording
        /// action interaction events</a>. For more information about actions in an Actions dataset,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/actions-datasets.html">Actions
        /// dataset</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActionInteractions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutActionInteractions service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutActionInteractions">REST API Reference for PutActionInteractions Operation</seealso>
        Task<PutActionInteractionsResponse> PutActionInteractionsAsync(PutActionInteractionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutActions


        /// <summary>
        /// Adds one or more actions to an Actions dataset. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-actions.html">Importing
        /// actions individually</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActions service method.</param>
        /// 
        /// <returns>The response from the PutActions service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutActions">REST API Reference for PutActions Operation</seealso>
        PutActionsResponse PutActions(PutActionsRequest request);



        /// <summary>
        /// Adds one or more actions to an Actions dataset. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-actions.html">Importing
        /// actions individually</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutActions service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutActions">REST API Reference for PutActions Operation</seealso>
        Task<PutActionsResponse> PutActionsAsync(PutActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutEvents


        /// <summary>
        /// Records item interaction event data. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-item-interaction-events.html">Recording
        /// item interaction events</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutEvents">REST API Reference for PutEvents Operation</seealso>
        PutEventsResponse PutEvents(PutEventsRequest request);



        /// <summary>
        /// Records item interaction event data. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-item-interaction-events.html">Recording
        /// item interaction events</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutEvents">REST API Reference for PutEvents Operation</seealso>
        Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutItems


        /// <summary>
        /// Adds one or more items to an Items dataset. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-items.html">Importing
        /// items individually</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItems service method.</param>
        /// 
        /// <returns>The response from the PutItems service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutItems">REST API Reference for PutItems Operation</seealso>
        PutItemsResponse PutItems(PutItemsRequest request);



        /// <summary>
        /// Adds one or more items to an Items dataset. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-items.html">Importing
        /// items individually</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutItems service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutItems">REST API Reference for PutItems Operation</seealso>
        Task<PutItemsResponse> PutItemsAsync(PutItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutUsers


        /// <summary>
        /// Adds one or more users to a Users dataset. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-users.html">Importing
        /// users individually</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUsers service method.</param>
        /// 
        /// <returns>The response from the PutUsers service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutUsers">REST API Reference for PutUsers Operation</seealso>
        PutUsersResponse PutUsers(PutUsersRequest request);



        /// <summary>
        /// Adds one or more users to a Users dataset. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-users.html">Importing
        /// users individually</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutUsers service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutUsers">REST API Reference for PutUsers Operation</seealso>
        Task<PutUsersResponse> PutUsersAsync(PutUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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