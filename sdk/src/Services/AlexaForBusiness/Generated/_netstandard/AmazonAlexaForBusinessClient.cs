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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AlexaForBusiness.Model;
using Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations;
using Amazon.AlexaForBusiness.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AlexaForBusiness
{
    /// <summary>
    /// Implementation for accessing AlexaForBusiness
    ///
    /// Alexa for Business helps you use Alexa in your organization. Alexa for Business provides
    /// you with the tools to manage Alexa devices, enroll your users, and assign skills,
    /// at scale. You can build your own context-aware voice skills using the Alexa Skills
    /// Kit and the Alexa for Business API operations. You can also make these available as
    /// private skills for your organization. Alexa for Business makes it efficient to voice-enable
    /// your products and services, thus providing context-aware voice experiences for your
    /// customers. Device makers building with the Alexa Voice Service (AVS) can create fully
    /// integrated solutions, register their products with Alexa for Business, and manage
    /// them as shared devices in their organization.
    /// </summary>
    public partial class AmazonAlexaForBusinessClient : AmazonServiceClient, IAmazonAlexaForBusiness
    {
        private static IServiceMetadata serviceMetadata = new AmazonAlexaForBusinessMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with the credentials loaded from the application's
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
        public AmazonAlexaForBusinessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAlexaForBusinessConfig()) { }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with the credentials loaded from the application's
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
        public AmazonAlexaForBusinessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAlexaForBusinessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(AmazonAlexaForBusinessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAlexaForBusinessClient(AWSCredentials credentials)
            : this(credentials, new AmazonAlexaForBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAlexaForBusinessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAlexaForBusinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Credentials and an
        /// AmazonAlexaForBusinessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(AWSCredentials credentials, AmazonAlexaForBusinessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAlexaForBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAlexaForBusinessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAlexaForBusinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAlexaForBusinessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAlexaForBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAlexaForBusinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAlexaForBusinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAlexaForBusinessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAlexaForBusinessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAlexaForBusinessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AlexaForBusinessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAlexaForBusinessEndpointResolver());
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


        #region  ApproveSkill

        internal virtual ApproveSkillResponse ApproveSkill(ApproveSkillRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApproveSkillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveSkillResponseUnmarshaller.Instance;

            return Invoke<ApproveSkillResponse>(request, options);
        }



        /// <summary>
        /// Associates a skill with the organization under the customer's AWS account. If a skill
        /// is private, the user implicitly accepts access to this skill during enablement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApproveSkill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApproveSkill service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ApproveSkill">REST API Reference for ApproveSkill Operation</seealso>
        public virtual Task<ApproveSkillResponse> ApproveSkillAsync(ApproveSkillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApproveSkillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApproveSkillResponseUnmarshaller.Instance;

            return InvokeAsync<ApproveSkillResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateContactWithAddressBook

        internal virtual AssociateContactWithAddressBookResponse AssociateContactWithAddressBook(AssociateContactWithAddressBookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateContactWithAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateContactWithAddressBookResponseUnmarshaller.Instance;

            return Invoke<AssociateContactWithAddressBookResponse>(request, options);
        }



        /// <summary>
        /// Associates a contact with a given address book.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateContactWithAddressBook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateContactWithAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateContactWithAddressBook">REST API Reference for AssociateContactWithAddressBook Operation</seealso>
        public virtual Task<AssociateContactWithAddressBookResponse> AssociateContactWithAddressBookAsync(AssociateContactWithAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateContactWithAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateContactWithAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateContactWithAddressBookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateDeviceWithNetworkProfile

        internal virtual AssociateDeviceWithNetworkProfileResponse AssociateDeviceWithNetworkProfile(AssociateDeviceWithNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDeviceWithNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDeviceWithNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateDeviceWithNetworkProfileResponse>(request, options);
        }



        /// <summary>
        /// Associates a device with the specified network profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithNetworkProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDeviceWithNetworkProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateDeviceWithNetworkProfile">REST API Reference for AssociateDeviceWithNetworkProfile Operation</seealso>
        public virtual Task<AssociateDeviceWithNetworkProfileResponse> AssociateDeviceWithNetworkProfileAsync(AssociateDeviceWithNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDeviceWithNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDeviceWithNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDeviceWithNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateDeviceWithRoom

        internal virtual AssociateDeviceWithRoomResponse AssociateDeviceWithRoom(AssociateDeviceWithRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDeviceWithRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDeviceWithRoomResponseUnmarshaller.Instance;

            return Invoke<AssociateDeviceWithRoomResponse>(request, options);
        }



        /// <summary>
        /// Associates a device with a given room. This applies all the settings from the room
        /// profile to the device, and all the skills in any skill groups added to that room.
        /// This operation requires the device to be online, or else a manual sync is required.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDeviceWithRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateDeviceWithRoom">REST API Reference for AssociateDeviceWithRoom Operation</seealso>
        public virtual Task<AssociateDeviceWithRoomResponse> AssociateDeviceWithRoomAsync(AssociateDeviceWithRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDeviceWithRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDeviceWithRoomResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDeviceWithRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSkillGroupWithRoom

        internal virtual AssociateSkillGroupWithRoomResponse AssociateSkillGroupWithRoom(AssociateSkillGroupWithRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSkillGroupWithRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSkillGroupWithRoomResponseUnmarshaller.Instance;

            return Invoke<AssociateSkillGroupWithRoomResponse>(request, options);
        }



        /// <summary>
        /// Associates a skill group with a given room. This enables all skills in the associated
        /// skill group on all devices in the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillGroupWithRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSkillGroupWithRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillGroupWithRoom">REST API Reference for AssociateSkillGroupWithRoom Operation</seealso>
        public virtual Task<AssociateSkillGroupWithRoomResponse> AssociateSkillGroupWithRoomAsync(AssociateSkillGroupWithRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSkillGroupWithRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSkillGroupWithRoomResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSkillGroupWithRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSkillWithSkillGroup

        internal virtual AssociateSkillWithSkillGroupResponse AssociateSkillWithSkillGroup(AssociateSkillWithSkillGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSkillWithSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSkillWithSkillGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateSkillWithSkillGroupResponse>(request, options);
        }



        /// <summary>
        /// Associates a skill with a skill group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillWithSkillGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSkillWithSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.SkillNotLinkedException">
        /// The skill must be linked to a third-party account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillWithSkillGroup">REST API Reference for AssociateSkillWithSkillGroup Operation</seealso>
        public virtual Task<AssociateSkillWithSkillGroupResponse> AssociateSkillWithSkillGroupAsync(AssociateSkillWithSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSkillWithSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSkillWithSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSkillWithSkillGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSkillWithUsers

        internal virtual AssociateSkillWithUsersResponse AssociateSkillWithUsers(AssociateSkillWithUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSkillWithUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSkillWithUsersResponseUnmarshaller.Instance;

            return Invoke<AssociateSkillWithUsersResponse>(request, options);
        }



        /// <summary>
        /// Makes a private skill available for enrolled users to enable on their devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillWithUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSkillWithUsers service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillWithUsers">REST API Reference for AssociateSkillWithUsers Operation</seealso>
        public virtual Task<AssociateSkillWithUsersResponse> AssociateSkillWithUsersAsync(AssociateSkillWithUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSkillWithUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSkillWithUsersResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSkillWithUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAddressBook

        internal virtual CreateAddressBookResponse CreateAddressBook(CreateAddressBookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressBookResponseUnmarshaller.Instance;

            return Invoke<CreateAddressBookResponse>(request, options);
        }



        /// <summary>
        /// Creates an address book with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressBook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateAddressBook">REST API Reference for CreateAddressBook Operation</seealso>
        public virtual Task<CreateAddressBookResponse> CreateAddressBookAsync(CreateAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddressBookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBusinessReportSchedule

        internal virtual CreateBusinessReportScheduleResponse CreateBusinessReportSchedule(CreateBusinessReportScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBusinessReportScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBusinessReportScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateBusinessReportScheduleResponse>(request, options);
        }



        /// <summary>
        /// Creates a recurring schedule for usage reports to deliver to the specified S3 location
        /// with a specified daily or weekly interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBusinessReportSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBusinessReportSchedule service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateBusinessReportSchedule">REST API Reference for CreateBusinessReportSchedule Operation</seealso>
        public virtual Task<CreateBusinessReportScheduleResponse> CreateBusinessReportScheduleAsync(CreateBusinessReportScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBusinessReportScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBusinessReportScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBusinessReportScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConferenceProvider

        internal virtual CreateConferenceProviderResponse CreateConferenceProvider(CreateConferenceProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<CreateConferenceProviderResponse>(request, options);
        }



        /// <summary>
        /// Adds a new conference provider under the user's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConferenceProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateConferenceProvider">REST API Reference for CreateConferenceProvider Operation</seealso>
        public virtual Task<CreateConferenceProviderResponse> CreateConferenceProviderAsync(CreateConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConferenceProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateContact

        internal virtual CreateContactResponse CreateContact(CreateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactResponseUnmarshaller.Instance;

            return Invoke<CreateContactResponse>(request, options);
        }



        /// <summary>
        /// Creates a contact with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateContact">REST API Reference for CreateContact Operation</seealso>
        public virtual Task<CreateContactResponse> CreateContactAsync(CreateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGatewayGroup

        internal virtual CreateGatewayGroupResponse CreateGatewayGroup(CreateGatewayGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a gateway group with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGatewayGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGatewayGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateGatewayGroup">REST API Reference for CreateGatewayGroup Operation</seealso>
        public virtual Task<CreateGatewayGroupResponse> CreateGatewayGroupAsync(CreateGatewayGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGatewayGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkProfile

        internal virtual CreateNetworkProfileResponse CreateNetworkProfile(CreateNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a network profile with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidCertificateAuthorityException">
        /// The Certificate Authority can't issue or revoke a certificate.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidServiceLinkedRoleStateException">
        /// The service linked role is locked for deletion.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateNetworkProfile">REST API Reference for CreateNetworkProfile Operation</seealso>
        public virtual Task<CreateNetworkProfileResponse> CreateNetworkProfileAsync(CreateNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProfile

        internal virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a new room profile with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoom

        internal virtual CreateRoomResponse CreateRoom(CreateRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return Invoke<CreateRoomResponse>(request, options);
        }



        /// <summary>
        /// Creates a room with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSkillGroup

        internal virtual CreateSkillGroupResponse CreateSkillGroup(CreateSkillGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSkillGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSkillGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a skill group with a specified name and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSkillGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateSkillGroup">REST API Reference for CreateSkillGroup Operation</seealso>
        public virtual Task<CreateSkillGroupResponse> CreateSkillGroupAsync(CreateSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSkillGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ResourceInUseException">
        /// The resource in the request is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAddressBook

        internal virtual DeleteAddressBookResponse DeleteAddressBook(DeleteAddressBookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddressBookResponseUnmarshaller.Instance;

            return Invoke<DeleteAddressBookResponse>(request, options);
        }



        /// <summary>
        /// Deletes an address book by the address book ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddressBook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteAddressBook">REST API Reference for DeleteAddressBook Operation</seealso>
        public virtual Task<DeleteAddressBookResponse> DeleteAddressBookAsync(DeleteAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAddressBookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBusinessReportSchedule

        internal virtual DeleteBusinessReportScheduleResponse DeleteBusinessReportSchedule(DeleteBusinessReportScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBusinessReportScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBusinessReportScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteBusinessReportScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes the recurring report delivery schedule with the specified schedule ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBusinessReportSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBusinessReportSchedule service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteBusinessReportSchedule">REST API Reference for DeleteBusinessReportSchedule Operation</seealso>
        public virtual Task<DeleteBusinessReportScheduleResponse> DeleteBusinessReportScheduleAsync(DeleteBusinessReportScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBusinessReportScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBusinessReportScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBusinessReportScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConferenceProvider

        internal virtual DeleteConferenceProviderResponse DeleteConferenceProvider(DeleteConferenceProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteConferenceProviderResponse>(request, options);
        }



        /// <summary>
        /// Deletes a conference provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConferenceProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteConferenceProvider">REST API Reference for DeleteConferenceProvider Operation</seealso>
        public virtual Task<DeleteConferenceProviderResponse> DeleteConferenceProviderAsync(DeleteConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConferenceProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContact

        internal virtual DeleteContactResponse DeleteContact(DeleteContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return Invoke<DeleteContactResponse>(request, options);
        }



        /// <summary>
        /// Deletes a contact by the contact ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        public virtual Task<DeleteContactResponse> DeleteContactAsync(DeleteContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevice

        internal virtual DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceResponse>(request, options);
        }



        /// <summary>
        /// Removes a device from Alexa For Business.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidCertificateAuthorityException">
        /// The Certificate Authority can't issue or revoke a certificate.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeviceUsageData

        internal virtual DeleteDeviceUsageDataResponse DeleteDeviceUsageData(DeleteDeviceUsageDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceUsageDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceUsageDataResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceUsageDataResponse>(request, options);
        }



        /// <summary>
        /// When this action is called for a specified shared device, it allows authorized users
        /// to delete the device's entire previous history of voice input data and associated
        /// response data. This action can be called once every 24 hours for a specific shared
        /// device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceUsageData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeviceUsageData service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteDeviceUsageData">REST API Reference for DeleteDeviceUsageData Operation</seealso>
        public virtual Task<DeleteDeviceUsageDataResponse> DeleteDeviceUsageDataAsync(DeleteDeviceUsageDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceUsageDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceUsageDataResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceUsageDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGatewayGroup

        internal virtual DeleteGatewayGroupResponse DeleteGatewayGroup(DeleteGatewayGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a gateway group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGatewayGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ResourceAssociatedException">
        /// Another resource is associated with the resource in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteGatewayGroup">REST API Reference for DeleteGatewayGroup Operation</seealso>
        public virtual Task<DeleteGatewayGroupResponse> DeleteGatewayGroupAsync(DeleteGatewayGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGatewayGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkProfile

        internal virtual DeleteNetworkProfileResponse DeleteNetworkProfile(DeleteNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a network profile by the network profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ResourceInUseException">
        /// The resource in the request is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteNetworkProfile">REST API Reference for DeleteNetworkProfile Operation</seealso>
        public virtual Task<DeleteNetworkProfileResponse> DeleteNetworkProfileAsync(DeleteNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProfile

        internal virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a room profile by the profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoom

        internal virtual DeleteRoomResponse DeleteRoom(DeleteRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomResponse>(request, options);
        }



        /// <summary>
        /// Deletes a room by the room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual Task<DeleteRoomResponse> DeleteRoomAsync(DeleteRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoomSkillParameter

        internal virtual DeleteRoomSkillParameterResponse DeleteRoomSkillParameter(DeleteRoomSkillParameterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomSkillParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomSkillParameterResponse>(request, options);
        }



        /// <summary>
        /// Deletes room skill parameter details by room, skill, and parameter key ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomSkillParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoomSkillParameter">REST API Reference for DeleteRoomSkillParameter Operation</seealso>
        public virtual Task<DeleteRoomSkillParameterResponse> DeleteRoomSkillParameterAsync(DeleteRoomSkillParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomSkillParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomSkillParameterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoomSkillParameterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSkillAuthorization

        internal virtual DeleteSkillAuthorizationResponse DeleteSkillAuthorization(DeleteSkillAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSkillAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSkillAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteSkillAuthorizationResponse>(request, options);
        }



        /// <summary>
        /// Unlinks a third-party account from a skill.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSkillAuthorization service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillAuthorization">REST API Reference for DeleteSkillAuthorization Operation</seealso>
        public virtual Task<DeleteSkillAuthorizationResponse> DeleteSkillAuthorizationAsync(DeleteSkillAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSkillAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSkillAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSkillAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSkillGroup

        internal virtual DeleteSkillGroupResponse DeleteSkillGroup(DeleteSkillGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSkillGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSkillGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a skill group by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillGroup">REST API Reference for DeleteSkillGroup Operation</seealso>
        public virtual Task<DeleteSkillGroupResponse> DeleteSkillGroupAsync(DeleteSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSkillGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified user by user ARN and enrollment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateContactFromAddressBook

        internal virtual DisassociateContactFromAddressBookResponse DisassociateContactFromAddressBook(DisassociateContactFromAddressBookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateContactFromAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateContactFromAddressBookResponseUnmarshaller.Instance;

            return Invoke<DisassociateContactFromAddressBookResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a contact from a given address book.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateContactFromAddressBook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateContactFromAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateContactFromAddressBook">REST API Reference for DisassociateContactFromAddressBook Operation</seealso>
        public virtual Task<DisassociateContactFromAddressBookResponse> DisassociateContactFromAddressBookAsync(DisassociateContactFromAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateContactFromAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateContactFromAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateContactFromAddressBookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDeviceFromRoom

        internal virtual DisassociateDeviceFromRoomResponse DisassociateDeviceFromRoom(DisassociateDeviceFromRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDeviceFromRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDeviceFromRoomResponseUnmarshaller.Instance;

            return Invoke<DisassociateDeviceFromRoomResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a device from its current room. The device continues to be connected
        /// to the Wi-Fi network and is still registered to the account. The device settings and
        /// skills are removed from the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDeviceFromRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateDeviceFromRoom">REST API Reference for DisassociateDeviceFromRoom Operation</seealso>
        public virtual Task<DisassociateDeviceFromRoomResponse> DisassociateDeviceFromRoomAsync(DisassociateDeviceFromRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDeviceFromRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDeviceFromRoomResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDeviceFromRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSkillFromSkillGroup

        internal virtual DisassociateSkillFromSkillGroupResponse DisassociateSkillFromSkillGroup(DisassociateSkillFromSkillGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSkillFromSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSkillFromSkillGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateSkillFromSkillGroupResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a skill from a skill group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillFromSkillGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSkillFromSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillFromSkillGroup">REST API Reference for DisassociateSkillFromSkillGroup Operation</seealso>
        public virtual Task<DisassociateSkillFromSkillGroupResponse> DisassociateSkillFromSkillGroupAsync(DisassociateSkillFromSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSkillFromSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSkillFromSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSkillFromSkillGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSkillFromUsers

        internal virtual DisassociateSkillFromUsersResponse DisassociateSkillFromUsers(DisassociateSkillFromUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSkillFromUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSkillFromUsersResponseUnmarshaller.Instance;

            return Invoke<DisassociateSkillFromUsersResponse>(request, options);
        }



        /// <summary>
        /// Makes a private skill unavailable for enrolled users and prevents them from enabling
        /// it on their devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillFromUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSkillFromUsers service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillFromUsers">REST API Reference for DisassociateSkillFromUsers Operation</seealso>
        public virtual Task<DisassociateSkillFromUsersResponse> DisassociateSkillFromUsersAsync(DisassociateSkillFromUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSkillFromUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSkillFromUsersResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSkillFromUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSkillGroupFromRoom

        internal virtual DisassociateSkillGroupFromRoomResponse DisassociateSkillGroupFromRoom(DisassociateSkillGroupFromRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSkillGroupFromRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSkillGroupFromRoomResponseUnmarshaller.Instance;

            return Invoke<DisassociateSkillGroupFromRoomResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a skill group from a specified room. This disables all skills in the
        /// skill group on all devices in the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillGroupFromRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSkillGroupFromRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillGroupFromRoom">REST API Reference for DisassociateSkillGroupFromRoom Operation</seealso>
        public virtual Task<DisassociateSkillGroupFromRoomResponse> DisassociateSkillGroupFromRoomAsync(DisassociateSkillGroupFromRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSkillGroupFromRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSkillGroupFromRoomResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSkillGroupFromRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ForgetSmartHomeAppliances

        internal virtual ForgetSmartHomeAppliancesResponse ForgetSmartHomeAppliances(ForgetSmartHomeAppliancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgetSmartHomeAppliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgetSmartHomeAppliancesResponseUnmarshaller.Instance;

            return Invoke<ForgetSmartHomeAppliancesResponse>(request, options);
        }



        /// <summary>
        /// Forgets smart home appliances associated to a room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgetSmartHomeAppliances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ForgetSmartHomeAppliances service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ForgetSmartHomeAppliances">REST API Reference for ForgetSmartHomeAppliances Operation</seealso>
        public virtual Task<ForgetSmartHomeAppliancesResponse> ForgetSmartHomeAppliancesAsync(ForgetSmartHomeAppliancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgetSmartHomeAppliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgetSmartHomeAppliancesResponseUnmarshaller.Instance;

            return InvokeAsync<ForgetSmartHomeAppliancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAddressBook

        internal virtual GetAddressBookResponse GetAddressBook(GetAddressBookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressBookResponseUnmarshaller.Instance;

            return Invoke<GetAddressBookResponse>(request, options);
        }



        /// <summary>
        /// Gets address the book details by the address book ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddressBook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetAddressBook">REST API Reference for GetAddressBook Operation</seealso>
        public virtual Task<GetAddressBookResponse> GetAddressBookAsync(GetAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<GetAddressBookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConferencePreference

        internal virtual GetConferencePreferenceResponse GetConferencePreference(GetConferencePreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConferencePreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConferencePreferenceResponseUnmarshaller.Instance;

            return Invoke<GetConferencePreferenceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the existing conference preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConferencePreference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConferencePreference service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetConferencePreference">REST API Reference for GetConferencePreference Operation</seealso>
        public virtual Task<GetConferencePreferenceResponse> GetConferencePreferenceAsync(GetConferencePreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConferencePreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConferencePreferenceResponseUnmarshaller.Instance;

            return InvokeAsync<GetConferencePreferenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConferenceProvider

        internal virtual GetConferenceProviderResponse GetConferenceProvider(GetConferenceProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<GetConferenceProviderResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a specific conference provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConferenceProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetConferenceProvider">REST API Reference for GetConferenceProvider Operation</seealso>
        public virtual Task<GetConferenceProviderResponse> GetConferenceProviderAsync(GetConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<GetConferenceProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContact

        internal virtual GetContactResponse GetContact(GetContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactResponseUnmarshaller.Instance;

            return Invoke<GetContactResponse>(request, options);
        }



        /// <summary>
        /// Gets the contact details by the contact ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetContact">REST API Reference for GetContact Operation</seealso>
        public virtual Task<GetContactResponse> GetContactAsync(GetContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevice

        internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a device by device ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGateway

        internal virtual GetGatewayResponse GetGateway(GetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGateway service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetGateway">REST API Reference for GetGateway Operation</seealso>
        public virtual Task<GetGatewayResponse> GetGatewayAsync(GetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<GetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGatewayGroup

        internal virtual GetGatewayGroupResponse GetGatewayGroup(GetGatewayGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayGroupResponseUnmarshaller.Instance;

            return Invoke<GetGatewayGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a gateway group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGatewayGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetGatewayGroup">REST API Reference for GetGatewayGroup Operation</seealso>
        public virtual Task<GetGatewayGroupResponse> GetGatewayGroupAsync(GetGatewayGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGatewayGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInvitationConfiguration

        internal virtual GetInvitationConfigurationResponse GetInvitationConfiguration(GetInvitationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetInvitationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the configured values for the user enrollment invitation email template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvitationConfiguration service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetInvitationConfiguration">REST API Reference for GetInvitationConfiguration Operation</seealso>
        public virtual Task<GetInvitationConfigurationResponse> GetInvitationConfigurationAsync(GetInvitationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvitationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkProfile

        internal virtual GetNetworkProfileResponse GetNetworkProfile(GetNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<GetNetworkProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets the network profile details by the network profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidSecretsManagerResourceException">
        /// A password in SecretsManager is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetNetworkProfile">REST API Reference for GetNetworkProfile Operation</seealso>
        public virtual Task<GetNetworkProfileResponse> GetNetworkProfileAsync(GetNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProfile

        internal virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a room profile by profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRoom

        internal virtual GetRoomResponse GetRoom(GetRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomResponseUnmarshaller.Instance;

            return Invoke<GetRoomResponse>(request, options);
        }



        /// <summary>
        /// Gets room details by room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual Task<GetRoomResponse> GetRoomAsync(GetRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRoomSkillParameter

        internal virtual GetRoomSkillParameterResponse GetRoomSkillParameter(GetRoomSkillParameterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomSkillParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<GetRoomSkillParameterResponse>(request, options);
        }



        /// <summary>
        /// Gets room skill parameter details by room, skill, and parameter key ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoomSkillParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoomSkillParameter">REST API Reference for GetRoomSkillParameter Operation</seealso>
        public virtual Task<GetRoomSkillParameterResponse> GetRoomSkillParameterAsync(GetRoomSkillParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomSkillParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomSkillParameterResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoomSkillParameterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSkillGroup

        internal virtual GetSkillGroupResponse GetSkillGroup(GetSkillGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSkillGroupResponseUnmarshaller.Instance;

            return Invoke<GetSkillGroupResponse>(request, options);
        }



        /// <summary>
        /// Gets skill group details by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSkillGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetSkillGroup">REST API Reference for GetSkillGroup Operation</seealso>
        public virtual Task<GetSkillGroupResponse> GetSkillGroupAsync(GetSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetSkillGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBusinessReportSchedules

        internal virtual ListBusinessReportSchedulesResponse ListBusinessReportSchedules(ListBusinessReportSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBusinessReportSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBusinessReportSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListBusinessReportSchedulesResponse>(request, options);
        }



        /// <summary>
        /// Lists the details of the schedules that a user configured. A download URL of the report
        /// associated with each schedule is returned every time this action is called. A new
        /// download URL is returned each time, and is valid for 24 hours.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBusinessReportSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBusinessReportSchedules service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListBusinessReportSchedules">REST API Reference for ListBusinessReportSchedules Operation</seealso>
        public virtual Task<ListBusinessReportSchedulesResponse> ListBusinessReportSchedulesAsync(ListBusinessReportSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBusinessReportSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBusinessReportSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBusinessReportSchedulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConferenceProviders

        internal virtual ListConferenceProvidersResponse ListConferenceProviders(ListConferenceProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConferenceProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConferenceProvidersResponseUnmarshaller.Instance;

            return Invoke<ListConferenceProvidersResponse>(request, options);
        }



        /// <summary>
        /// Lists conference providers under a specific AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConferenceProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConferenceProviders service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListConferenceProviders">REST API Reference for ListConferenceProviders Operation</seealso>
        public virtual Task<ListConferenceProvidersResponse> ListConferenceProvidersAsync(ListConferenceProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConferenceProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConferenceProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListConferenceProvidersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceEvents

        internal virtual ListDeviceEventsResponse ListDeviceEvents(ListDeviceEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceEventsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists the device event history, including device connection status, for up to 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceEvents service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListDeviceEvents">REST API Reference for ListDeviceEvents Operation</seealso>
        public virtual Task<ListDeviceEventsResponse> ListDeviceEventsAsync(ListDeviceEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGatewayGroups

        internal virtual ListGatewayGroupsResponse ListGatewayGroups(ListGatewayGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewayGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGatewayGroupsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of gateway group summaries. Use GetGatewayGroup to retrieve details
        /// of a specific gateway group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGatewayGroups service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListGatewayGroups">REST API Reference for ListGatewayGroups Operation</seealso>
        public virtual Task<ListGatewayGroupsResponse> ListGatewayGroupsAsync(ListGatewayGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewayGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewayGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGateways

        internal virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of gateway summaries. Use GetGateway to retrieve details of a specific
        /// gateway. An optional gateway group ARN can be provided to only retrieve gateway summaries
        /// of gateways that are associated with that gateway group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSkills

        internal virtual ListSkillsResponse ListSkills(ListSkillsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSkillsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSkillsResponseUnmarshaller.Instance;

            return Invoke<ListSkillsResponse>(request, options);
        }



        /// <summary>
        /// Lists all enabled skills in a specific skill group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSkills service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSkills service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkills">REST API Reference for ListSkills Operation</seealso>
        public virtual Task<ListSkillsResponse> ListSkillsAsync(ListSkillsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSkillsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSkillsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSkillsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSkillsStoreCategories

        internal virtual ListSkillsStoreCategoriesResponse ListSkillsStoreCategories(ListSkillsStoreCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSkillsStoreCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSkillsStoreCategoriesResponseUnmarshaller.Instance;

            return Invoke<ListSkillsStoreCategoriesResponse>(request, options);
        }



        /// <summary>
        /// Lists all categories in the Alexa skill store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSkillsStoreCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSkillsStoreCategories service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkillsStoreCategories">REST API Reference for ListSkillsStoreCategories Operation</seealso>
        public virtual Task<ListSkillsStoreCategoriesResponse> ListSkillsStoreCategoriesAsync(ListSkillsStoreCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSkillsStoreCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSkillsStoreCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSkillsStoreCategoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSkillsStoreSkillsByCategory

        internal virtual ListSkillsStoreSkillsByCategoryResponse ListSkillsStoreSkillsByCategory(ListSkillsStoreSkillsByCategoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSkillsStoreSkillsByCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSkillsStoreSkillsByCategoryResponseUnmarshaller.Instance;

            return Invoke<ListSkillsStoreSkillsByCategoryResponse>(request, options);
        }



        /// <summary>
        /// Lists all skills in the Alexa skill store by category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSkillsStoreSkillsByCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSkillsStoreSkillsByCategory service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkillsStoreSkillsByCategory">REST API Reference for ListSkillsStoreSkillsByCategory Operation</seealso>
        public virtual Task<ListSkillsStoreSkillsByCategoryResponse> ListSkillsStoreSkillsByCategoryAsync(ListSkillsStoreSkillsByCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSkillsStoreSkillsByCategoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSkillsStoreSkillsByCategoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListSkillsStoreSkillsByCategoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSmartHomeAppliances

        internal virtual ListSmartHomeAppliancesResponse ListSmartHomeAppliances(ListSmartHomeAppliancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSmartHomeAppliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSmartHomeAppliancesResponseUnmarshaller.Instance;

            return Invoke<ListSmartHomeAppliancesResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the smart home appliances associated with a room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSmartHomeAppliances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSmartHomeAppliances service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSmartHomeAppliances">REST API Reference for ListSmartHomeAppliances Operation</seealso>
        public virtual Task<ListSmartHomeAppliancesResponse> ListSmartHomeAppliancesAsync(ListSmartHomeAppliancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSmartHomeAppliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSmartHomeAppliancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSmartHomeAppliancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConferencePreference

        internal virtual PutConferencePreferenceResponse PutConferencePreference(PutConferencePreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConferencePreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConferencePreferenceResponseUnmarshaller.Instance;

            return Invoke<PutConferencePreferenceResponse>(request, options);
        }



        /// <summary>
        /// Sets the conference preferences on a specific conference provider at the account level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConferencePreference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConferencePreference service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutConferencePreference">REST API Reference for PutConferencePreference Operation</seealso>
        public virtual Task<PutConferencePreferenceResponse> PutConferencePreferenceAsync(PutConferencePreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConferencePreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConferencePreferenceResponseUnmarshaller.Instance;

            return InvokeAsync<PutConferencePreferenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutInvitationConfiguration

        internal virtual PutInvitationConfigurationResponse PutInvitationConfiguration(PutInvitationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInvitationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInvitationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutInvitationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Configures the email template for the user enrollment invitation with the specified
        /// attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInvitationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInvitationConfiguration service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutInvitationConfiguration">REST API Reference for PutInvitationConfiguration Operation</seealso>
        public virtual Task<PutInvitationConfigurationResponse> PutInvitationConfigurationAsync(PutInvitationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInvitationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInvitationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutInvitationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRoomSkillParameter

        internal virtual PutRoomSkillParameterResponse PutRoomSkillParameter(PutRoomSkillParameterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRoomSkillParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<PutRoomSkillParameterResponse>(request, options);
        }



        /// <summary>
        /// Updates room skill parameter details by room, skill, and parameter key ID. Not all
        /// skills have a room skill parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRoomSkillParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutRoomSkillParameter">REST API Reference for PutRoomSkillParameter Operation</seealso>
        public virtual Task<PutRoomSkillParameterResponse> PutRoomSkillParameterAsync(PutRoomSkillParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRoomSkillParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRoomSkillParameterResponseUnmarshaller.Instance;

            return InvokeAsync<PutRoomSkillParameterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSkillAuthorization

        internal virtual PutSkillAuthorizationResponse PutSkillAuthorization(PutSkillAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSkillAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSkillAuthorizationResponseUnmarshaller.Instance;

            return Invoke<PutSkillAuthorizationResponse>(request, options);
        }



        /// <summary>
        /// Links a user's account to a third-party skill provider. If this API operation is called
        /// by an assumed IAM role, the skill being linked must be a private skill. Also, the
        /// skill must be owned by the AWS account that assumed the IAM role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSkillAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSkillAuthorization service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.UnauthorizedException">
        /// The caller has no permissions to operate on the resource involved in the API call.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutSkillAuthorization">REST API Reference for PutSkillAuthorization Operation</seealso>
        public virtual Task<PutSkillAuthorizationResponse> PutSkillAuthorizationAsync(PutSkillAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSkillAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSkillAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<PutSkillAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterAVSDevice

        internal virtual RegisterAVSDeviceResponse RegisterAVSDevice(RegisterAVSDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAVSDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAVSDeviceResponseUnmarshaller.Instance;

            return Invoke<RegisterAVSDeviceResponse>(request, options);
        }



        /// <summary>
        /// Registers an Alexa-enabled device built by an Original Equipment Manufacturer (OEM)
        /// using Alexa Voice Service (AVS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAVSDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterAVSDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidDeviceException">
        /// The device is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RegisterAVSDevice">REST API Reference for RegisterAVSDevice Operation</seealso>
        public virtual Task<RegisterAVSDeviceResponse> RegisterAVSDeviceAsync(RegisterAVSDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAVSDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAVSDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterAVSDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectSkill

        internal virtual RejectSkillResponse RejectSkill(RejectSkillRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSkillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSkillResponseUnmarshaller.Instance;

            return Invoke<RejectSkillResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a skill from the organization under a user's AWS account. If the skill
        /// is a private skill, it moves to an AcceptStatus of PENDING. Any private or public
        /// skill that is rejected can be added later by calling the ApproveSkill API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSkill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectSkill service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RejectSkill">REST API Reference for RejectSkill Operation</seealso>
        public virtual Task<RejectSkillResponse> RejectSkillAsync(RejectSkillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSkillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSkillResponseUnmarshaller.Instance;

            return InvokeAsync<RejectSkillResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResolveRoom

        internal virtual ResolveRoomResponse ResolveRoom(ResolveRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveRoomResponseUnmarshaller.Instance;

            return Invoke<ResolveRoomResponse>(request, options);
        }



        /// <summary>
        /// Determines the details for the room from which a skill request was invoked. This operation
        /// is used by skill developers.
        /// 
        ///  
        /// <para>
        /// To query ResolveRoom from an Alexa skill, the skill ID needs to be authorized. When
        /// the skill is using an AWS Lambda function, the skill is automatically authorized when
        /// you publish your skill as a private skill to your AWS account. Skills that are hosted
        /// using a custom web service must be manually authorized. To get your skill authorized,
        /// contact AWS Support with your AWS account ID that queries the ResolveRoom API and
        /// skill ID. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ResolveRoom">REST API Reference for ResolveRoom Operation</seealso>
        public virtual Task<ResolveRoomResponse> ResolveRoomAsync(ResolveRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveRoomResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeInvitation

        internal virtual RevokeInvitationResponse RevokeInvitation(RevokeInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeInvitationResponseUnmarshaller.Instance;

            return Invoke<RevokeInvitationResponse>(request, options);
        }



        /// <summary>
        /// Revokes an invitation and invalidates the enrollment URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeInvitation service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RevokeInvitation">REST API Reference for RevokeInvitation Operation</seealso>
        public virtual Task<RevokeInvitationResponse> RevokeInvitationAsync(RevokeInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchAddressBooks

        internal virtual SearchAddressBooksResponse SearchAddressBooks(SearchAddressBooksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAddressBooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAddressBooksResponseUnmarshaller.Instance;

            return Invoke<SearchAddressBooksResponse>(request, options);
        }



        /// <summary>
        /// Searches address books and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAddressBooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAddressBooks service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchAddressBooks">REST API Reference for SearchAddressBooks Operation</seealso>
        public virtual Task<SearchAddressBooksResponse> SearchAddressBooksAsync(SearchAddressBooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAddressBooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAddressBooksResponseUnmarshaller.Instance;

            return InvokeAsync<SearchAddressBooksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchContacts

        internal virtual SearchContactsResponse SearchContacts(SearchContactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchContactsResponseUnmarshaller.Instance;

            return Invoke<SearchContactsResponse>(request, options);
        }



        /// <summary>
        /// Searches contacts and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchContacts service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchContacts">REST API Reference for SearchContacts Operation</seealso>
        public virtual Task<SearchContactsResponse> SearchContactsAsync(SearchContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchContactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchContactsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchContactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchDevices

        internal virtual SearchDevicesResponse SearchDevices(SearchDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return Invoke<SearchDevicesResponse>(request, options);
        }



        /// <summary>
        /// Searches devices and lists the ones that meet a set of filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDevices service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        public virtual Task<SearchDevicesResponse> SearchDevicesAsync(SearchDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchNetworkProfiles

        internal virtual SearchNetworkProfilesResponse SearchNetworkProfiles(SearchNetworkProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchNetworkProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchNetworkProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchNetworkProfilesResponse>(request, options);
        }



        /// <summary>
        /// Searches network profiles and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchNetworkProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchNetworkProfiles service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchNetworkProfiles">REST API Reference for SearchNetworkProfiles Operation</seealso>
        public virtual Task<SearchNetworkProfilesResponse> SearchNetworkProfilesAsync(SearchNetworkProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchNetworkProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchNetworkProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchNetworkProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchProfiles

        internal virtual SearchProfilesResponse SearchProfiles(SearchProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchProfilesResponse>(request, options);
        }



        /// <summary>
        /// Searches room profiles and lists the ones that meet a set of filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchProfiles service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        public virtual Task<SearchProfilesResponse> SearchProfilesAsync(SearchProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchRooms

        internal virtual SearchRoomsResponse SearchRooms(SearchRoomsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRoomsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRoomsResponseUnmarshaller.Instance;

            return Invoke<SearchRoomsResponse>(request, options);
        }



        /// <summary>
        /// Searches rooms and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRooms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchRooms service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchRooms">REST API Reference for SearchRooms Operation</seealso>
        public virtual Task<SearchRoomsResponse> SearchRoomsAsync(SearchRoomsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRoomsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRoomsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchRoomsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchSkillGroups

        internal virtual SearchSkillGroupsResponse SearchSkillGroups(SearchSkillGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSkillGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSkillGroupsResponseUnmarshaller.Instance;

            return Invoke<SearchSkillGroupsResponse>(request, options);
        }



        /// <summary>
        /// Searches skill groups and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSkillGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSkillGroups service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchSkillGroups">REST API Reference for SearchSkillGroups Operation</seealso>
        public virtual Task<SearchSkillGroupsResponse> SearchSkillGroupsAsync(SearchSkillGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchSkillGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSkillGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSkillGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchUsers

        internal virtual SearchUsersResponse SearchUsers(SearchUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return Invoke<SearchUsersResponse>(request, options);
        }



        /// <summary>
        /// Searches users and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual Task<SearchUsersResponse> SearchUsersAsync(SearchUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return InvokeAsync<SearchUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendAnnouncement

        internal virtual SendAnnouncementResponse SendAnnouncement(SendAnnouncementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendAnnouncementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAnnouncementResponseUnmarshaller.Instance;

            return Invoke<SendAnnouncementResponse>(request, options);
        }



        /// <summary>
        /// Triggers an asynchronous flow to send text, SSML, or audio announcements to rooms
        /// that are identified by a search or filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAnnouncement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendAnnouncement service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SendAnnouncement">REST API Reference for SendAnnouncement Operation</seealso>
        public virtual Task<SendAnnouncementResponse> SendAnnouncementAsync(SendAnnouncementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendAnnouncementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAnnouncementResponseUnmarshaller.Instance;

            return InvokeAsync<SendAnnouncementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendInvitation

        internal virtual SendInvitationResponse SendInvitation(SendInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendInvitationResponseUnmarshaller.Instance;

            return Invoke<SendInvitationResponse>(request, options);
        }



        /// <summary>
        /// Sends an enrollment invitation email with a URL to a user. The URL is valid for 30
        /// days or until you call this operation again, whichever comes first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendInvitation service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidUserStatusException">
        /// The attempt to update a user is invalid due to the user's current status.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SendInvitation">REST API Reference for SendInvitation Operation</seealso>
        public virtual Task<SendInvitationResponse> SendInvitationAsync(SendInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<SendInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDeviceSync

        internal virtual StartDeviceSyncResponse StartDeviceSync(StartDeviceSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceSyncResponseUnmarshaller.Instance;

            return Invoke<StartDeviceSyncResponse>(request, options);
        }



        /// <summary>
        /// Resets a device and its account to the known default settings. This clears all information
        /// and settings set by previous users in the following ways:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Bluetooth - This unpairs all bluetooth devices paired with your echo device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Volume - This resets the echo device's volume to the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notifications - This clears all notifications from your echo device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lists - This clears all to-do items from your echo device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Settings - This internally syncs the room's profile (if the device is assigned to
        /// a room), contacts, address books, delegation access for account linking, and communications
        /// (if enabled on the room profile).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDeviceSync service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartDeviceSync">REST API Reference for StartDeviceSync Operation</seealso>
        public virtual Task<StartDeviceSyncResponse> StartDeviceSyncAsync(StartDeviceSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeviceSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeviceSyncResponseUnmarshaller.Instance;

            return InvokeAsync<StartDeviceSyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSmartHomeApplianceDiscovery

        internal virtual StartSmartHomeApplianceDiscoveryResponse StartSmartHomeApplianceDiscovery(StartSmartHomeApplianceDiscoveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSmartHomeApplianceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSmartHomeApplianceDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StartSmartHomeApplianceDiscoveryResponse>(request, options);
        }



        /// <summary>
        /// Initiates the discovery of any smart home appliances associated with the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSmartHomeApplianceDiscovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSmartHomeApplianceDiscovery service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartSmartHomeApplianceDiscovery">REST API Reference for StartSmartHomeApplianceDiscovery Operation</seealso>
        public virtual Task<StartSmartHomeApplianceDiscoveryResponse> StartSmartHomeApplianceDiscoveryAsync(StartSmartHomeApplianceDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSmartHomeApplianceDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSmartHomeApplianceDiscoveryResponseUnmarshaller.Instance;

            return InvokeAsync<StartSmartHomeApplianceDiscoveryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds metadata tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes metadata tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAddressBook

        internal virtual UpdateAddressBookResponse UpdateAddressBook(UpdateAddressBookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAddressBookResponseUnmarshaller.Instance;

            return Invoke<UpdateAddressBookResponse>(request, options);
        }



        /// <summary>
        /// Updates address book details by the address book ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAddressBook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateAddressBook">REST API Reference for UpdateAddressBook Operation</seealso>
        public virtual Task<UpdateAddressBookResponse> UpdateAddressBookAsync(UpdateAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAddressBookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAddressBookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBusinessReportSchedule

        internal virtual UpdateBusinessReportScheduleResponse UpdateBusinessReportSchedule(UpdateBusinessReportScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBusinessReportScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBusinessReportScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateBusinessReportScheduleResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of the report delivery schedule with the specified schedule
        /// ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBusinessReportSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBusinessReportSchedule service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateBusinessReportSchedule">REST API Reference for UpdateBusinessReportSchedule Operation</seealso>
        public virtual Task<UpdateBusinessReportScheduleResponse> UpdateBusinessReportScheduleAsync(UpdateBusinessReportScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBusinessReportScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBusinessReportScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBusinessReportScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConferenceProvider

        internal virtual UpdateConferenceProviderResponse UpdateConferenceProvider(UpdateConferenceProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateConferenceProviderResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing conference provider's settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConferenceProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateConferenceProvider">REST API Reference for UpdateConferenceProvider Operation</seealso>
        public virtual Task<UpdateConferenceProviderResponse> UpdateConferenceProviderAsync(UpdateConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConferenceProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConferenceProviderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContact

        internal virtual UpdateContactResponse UpdateContact(UpdateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return Invoke<UpdateContactResponse>(request, options);
        }



        /// <summary>
        /// Updates the contact details by the contact ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual Task<UpdateContactResponse> UpdateContactAsync(UpdateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevice

        internal virtual UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceResponse>(request, options);
        }



        /// <summary>
        /// Updates the device name by device ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGateway

        internal virtual UpdateGatewayResponse UpdateGateway(UpdateGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayResponse>(request, options);
        }



        /// <summary>
        /// Updates the details of a gateway. If any optional field is not provided, the existing
        /// corresponding value is left unmodified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGateway service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual Task<UpdateGatewayResponse> UpdateGatewayAsync(UpdateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewayGroup

        internal virtual UpdateGatewayGroupResponse UpdateGatewayGroup(UpdateGatewayGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates the details of a gateway group. If any optional field is not provided, the
        /// existing corresponding value is left unmodified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateGatewayGroup">REST API Reference for UpdateGatewayGroup Operation</seealso>
        public virtual Task<UpdateGatewayGroupResponse> UpdateGatewayGroupAsync(UpdateGatewayGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNetworkProfile

        internal virtual UpdateNetworkProfileResponse UpdateNetworkProfile(UpdateNetworkProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates a network profile by the network profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidCertificateAuthorityException">
        /// The Certificate Authority can't issue or revoke a certificate.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidSecretsManagerResourceException">
        /// A password in SecretsManager is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateNetworkProfile">REST API Reference for UpdateNetworkProfile Operation</seealso>
        public virtual Task<UpdateNetworkProfileResponse> UpdateNetworkProfileAsync(UpdateNetworkProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNetworkProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProfile

        internal virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing room profile by room profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoom

        internal virtual UpdateRoomResponse UpdateRoom(UpdateRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return Invoke<UpdateRoomResponse>(request, options);
        }



        /// <summary>
        /// Updates room details by room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual Task<UpdateRoomResponse> UpdateRoomAsync(UpdateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSkillGroup

        internal virtual UpdateSkillGroupResponse UpdateSkillGroup(UpdateSkillGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSkillGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateSkillGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates skill group details by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSkillGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// There is a concurrent modification of resources.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateSkillGroup">REST API Reference for UpdateSkillGroup Operation</seealso>
        public virtual Task<UpdateSkillGroupResponse> UpdateSkillGroupAsync(UpdateSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSkillGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSkillGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}