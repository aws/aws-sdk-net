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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PersonalizeEvents.Model;
using Amazon.PersonalizeEvents.Model.Internal.MarshallTransformations;
using Amazon.PersonalizeEvents.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PersonalizeEvents
{
    /// <summary>
    /// <para>Implementation for accessing PersonalizeEvents</para>
    ///
    /// Amazon Personalize can consume real-time user event data, such as <i>stream</i> or
    /// <i>click</i> data, and use it for model training either alone or combined with historical
    /// data. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-item-interaction-events.html">Recording
    /// item interaction events</a>.
    /// </summary>
    public partial class AmazonPersonalizeEventsClient : AmazonServiceClient, IAmazonPersonalizeEvents
    {
        private static IServiceMetadata serviceMetadata = new AmazonPersonalizeEventsMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        public AmazonPersonalizeEventsClient()
            : base(new AmazonPersonalizeEventsConfig()) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        public AmazonPersonalizeEventsClient(RegionEndpoint region)
            : base(new AmazonPersonalizeEventsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(AmazonPersonalizeEventsConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials)
            : this(credentials, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPersonalizeEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials and an
        /// AmazonPersonalizeEventsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials, AmazonPersonalizeEventsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeEventsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPersonalizeEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPersonalizeEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPersonalizeEventsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPersonalizeEventsAuthSchemeHandler());
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
        public virtual PutActionInteractionsResponse PutActionInteractions(PutActionInteractionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutActionInteractionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionInteractionsResponseUnmarshaller.Instance;

            return Invoke<PutActionInteractionsResponse>(request, options);
        }


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
        public virtual Task<PutActionInteractionsResponse> PutActionInteractionsAsync(PutActionInteractionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutActionInteractionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionInteractionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutActionInteractionsResponse>(request, options, cancellationToken);
        }

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
        public virtual PutActionsResponse PutActions(PutActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionsResponseUnmarshaller.Instance;

            return Invoke<PutActionsResponse>(request, options);
        }


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
        public virtual Task<PutActionsResponse> PutActionsAsync(PutActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutActionsResponse>(request, options, cancellationToken);
        }

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
        public virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }


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
        public virtual Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEventsResponse>(request, options, cancellationToken);
        }

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
        public virtual PutItemsResponse PutItems(PutItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemsResponseUnmarshaller.Instance;

            return Invoke<PutItemsResponse>(request, options);
        }


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
        public virtual Task<PutItemsResponse> PutItemsAsync(PutItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutItemsResponse>(request, options, cancellationToken);
        }

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
        public virtual PutUsersResponse PutUsers(PutUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUsersResponseUnmarshaller.Instance;

            return Invoke<PutUsersResponse>(request, options);
        }


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
        public virtual Task<PutUsersResponse> PutUsersAsync(PutUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUsersResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutUsersResponse>(request, options, cancellationToken);
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