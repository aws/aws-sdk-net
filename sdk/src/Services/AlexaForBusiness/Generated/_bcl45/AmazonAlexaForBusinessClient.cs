/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        /// <summary>
        /// Associates a skill with the organization under the customer's AWS account. If a skill
        /// is private, the user implicitly accepts access to this skill during enablement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApproveSkill service method.</param>
        /// 
        /// <returns>The response from the ApproveSkill service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ApproveSkill">REST API Reference for ApproveSkill Operation</seealso>
        public virtual ApproveSkillResponse ApproveSkill(ApproveSkillRequest request)
        {
            var marshaller = ApproveSkillRequestMarshaller.Instance;
            var unmarshaller = ApproveSkillResponseUnmarshaller.Instance;

            return Invoke<ApproveSkillRequest,ApproveSkillResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApproveSkill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApproveSkill operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ApproveSkill">REST API Reference for ApproveSkill Operation</seealso>
        public virtual Task<ApproveSkillResponse> ApproveSkillAsync(ApproveSkillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ApproveSkillRequestMarshaller.Instance;
            var unmarshaller = ApproveSkillResponseUnmarshaller.Instance;

            return InvokeAsync<ApproveSkillRequest,ApproveSkillResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateContactWithAddressBook


        /// <summary>
        /// Associates a contact with a given address book.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateContactWithAddressBook service method.</param>
        /// 
        /// <returns>The response from the AssociateContactWithAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateContactWithAddressBook">REST API Reference for AssociateContactWithAddressBook Operation</seealso>
        public virtual AssociateContactWithAddressBookResponse AssociateContactWithAddressBook(AssociateContactWithAddressBookRequest request)
        {
            var marshaller = AssociateContactWithAddressBookRequestMarshaller.Instance;
            var unmarshaller = AssociateContactWithAddressBookResponseUnmarshaller.Instance;

            return Invoke<AssociateContactWithAddressBookRequest,AssociateContactWithAddressBookResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateContactWithAddressBook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateContactWithAddressBook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateContactWithAddressBook">REST API Reference for AssociateContactWithAddressBook Operation</seealso>
        public virtual Task<AssociateContactWithAddressBookResponse> AssociateContactWithAddressBookAsync(AssociateContactWithAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateContactWithAddressBookRequestMarshaller.Instance;
            var unmarshaller = AssociateContactWithAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateContactWithAddressBookRequest,AssociateContactWithAddressBookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateDeviceWithRoom


        /// <summary>
        /// Associates a device with a given room. This applies all the settings from the room
        /// profile to the device, and all the skills in any skill groups added to that room.
        /// This operation requires the device to be online, or else a manual sync is required.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithRoom service method.</param>
        /// 
        /// <returns>The response from the AssociateDeviceWithRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateDeviceWithRoom">REST API Reference for AssociateDeviceWithRoom Operation</seealso>
        public virtual AssociateDeviceWithRoomResponse AssociateDeviceWithRoom(AssociateDeviceWithRoomRequest request)
        {
            var marshaller = AssociateDeviceWithRoomRequestMarshaller.Instance;
            var unmarshaller = AssociateDeviceWithRoomResponseUnmarshaller.Instance;

            return Invoke<AssociateDeviceWithRoomRequest,AssociateDeviceWithRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDeviceWithRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateDeviceWithRoom">REST API Reference for AssociateDeviceWithRoom Operation</seealso>
        public virtual Task<AssociateDeviceWithRoomResponse> AssociateDeviceWithRoomAsync(AssociateDeviceWithRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateDeviceWithRoomRequestMarshaller.Instance;
            var unmarshaller = AssociateDeviceWithRoomResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDeviceWithRoomRequest,AssociateDeviceWithRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateSkillGroupWithRoom


        /// <summary>
        /// Associates a skill group with a given room. This enables all skills in the associated
        /// skill group on all devices in the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillGroupWithRoom service method.</param>
        /// 
        /// <returns>The response from the AssociateSkillGroupWithRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillGroupWithRoom">REST API Reference for AssociateSkillGroupWithRoom Operation</seealso>
        public virtual AssociateSkillGroupWithRoomResponse AssociateSkillGroupWithRoom(AssociateSkillGroupWithRoomRequest request)
        {
            var marshaller = AssociateSkillGroupWithRoomRequestMarshaller.Instance;
            var unmarshaller = AssociateSkillGroupWithRoomResponseUnmarshaller.Instance;

            return Invoke<AssociateSkillGroupWithRoomRequest,AssociateSkillGroupWithRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSkillGroupWithRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillGroupWithRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillGroupWithRoom">REST API Reference for AssociateSkillGroupWithRoom Operation</seealso>
        public virtual Task<AssociateSkillGroupWithRoomResponse> AssociateSkillGroupWithRoomAsync(AssociateSkillGroupWithRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateSkillGroupWithRoomRequestMarshaller.Instance;
            var unmarshaller = AssociateSkillGroupWithRoomResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSkillGroupWithRoomRequest,AssociateSkillGroupWithRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateSkillWithSkillGroup


        /// <summary>
        /// Associates a skill with a skill group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillWithSkillGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateSkillWithSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.SkillNotLinkedException">
        /// The skill must be linked to a third-party account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillWithSkillGroup">REST API Reference for AssociateSkillWithSkillGroup Operation</seealso>
        public virtual AssociateSkillWithSkillGroupResponse AssociateSkillWithSkillGroup(AssociateSkillWithSkillGroupRequest request)
        {
            var marshaller = AssociateSkillWithSkillGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateSkillWithSkillGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateSkillWithSkillGroupRequest,AssociateSkillWithSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSkillWithSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillWithSkillGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillWithSkillGroup">REST API Reference for AssociateSkillWithSkillGroup Operation</seealso>
        public virtual Task<AssociateSkillWithSkillGroupResponse> AssociateSkillWithSkillGroupAsync(AssociateSkillWithSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateSkillWithSkillGroupRequestMarshaller.Instance;
            var unmarshaller = AssociateSkillWithSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSkillWithSkillGroupRequest,AssociateSkillWithSkillGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateSkillWithUsers


        /// <summary>
        /// Makes a private skill available for enrolled users to enable on their devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillWithUsers service method.</param>
        /// 
        /// <returns>The response from the AssociateSkillWithUsers service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillWithUsers">REST API Reference for AssociateSkillWithUsers Operation</seealso>
        public virtual AssociateSkillWithUsersResponse AssociateSkillWithUsers(AssociateSkillWithUsersRequest request)
        {
            var marshaller = AssociateSkillWithUsersRequestMarshaller.Instance;
            var unmarshaller = AssociateSkillWithUsersResponseUnmarshaller.Instance;

            return Invoke<AssociateSkillWithUsersRequest,AssociateSkillWithUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSkillWithUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillWithUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillWithUsers">REST API Reference for AssociateSkillWithUsers Operation</seealso>
        public virtual Task<AssociateSkillWithUsersResponse> AssociateSkillWithUsersAsync(AssociateSkillWithUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateSkillWithUsersRequestMarshaller.Instance;
            var unmarshaller = AssociateSkillWithUsersResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSkillWithUsersRequest,AssociateSkillWithUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAddressBook


        /// <summary>
        /// Creates an address book with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressBook service method.</param>
        /// 
        /// <returns>The response from the CreateAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateAddressBook">REST API Reference for CreateAddressBook Operation</seealso>
        public virtual CreateAddressBookResponse CreateAddressBook(CreateAddressBookRequest request)
        {
            var marshaller = CreateAddressBookRequestMarshaller.Instance;
            var unmarshaller = CreateAddressBookResponseUnmarshaller.Instance;

            return Invoke<CreateAddressBookRequest,CreateAddressBookResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddressBook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressBook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateAddressBook">REST API Reference for CreateAddressBook Operation</seealso>
        public virtual Task<CreateAddressBookResponse> CreateAddressBookAsync(CreateAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAddressBookRequestMarshaller.Instance;
            var unmarshaller = CreateAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAddressBookRequest,CreateAddressBookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBusinessReportSchedule


        /// <summary>
        /// Creates a recurring schedule for usage reports to deliver to the specified S3 location
        /// with a specified daily or weekly interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBusinessReportSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateBusinessReportSchedule service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateBusinessReportSchedule">REST API Reference for CreateBusinessReportSchedule Operation</seealso>
        public virtual CreateBusinessReportScheduleResponse CreateBusinessReportSchedule(CreateBusinessReportScheduleRequest request)
        {
            var marshaller = CreateBusinessReportScheduleRequestMarshaller.Instance;
            var unmarshaller = CreateBusinessReportScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateBusinessReportScheduleRequest,CreateBusinessReportScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBusinessReportSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBusinessReportSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateBusinessReportSchedule">REST API Reference for CreateBusinessReportSchedule Operation</seealso>
        public virtual Task<CreateBusinessReportScheduleResponse> CreateBusinessReportScheduleAsync(CreateBusinessReportScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateBusinessReportScheduleRequestMarshaller.Instance;
            var unmarshaller = CreateBusinessReportScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBusinessReportScheduleRequest,CreateBusinessReportScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConferenceProvider


        /// <summary>
        /// Adds a new conference provider under the user's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConferenceProvider service method.</param>
        /// 
        /// <returns>The response from the CreateConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateConferenceProvider">REST API Reference for CreateConferenceProvider Operation</seealso>
        public virtual CreateConferenceProviderResponse CreateConferenceProvider(CreateConferenceProviderRequest request)
        {
            var marshaller = CreateConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = CreateConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<CreateConferenceProviderRequest,CreateConferenceProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConferenceProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConferenceProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateConferenceProvider">REST API Reference for CreateConferenceProvider Operation</seealso>
        public virtual Task<CreateConferenceProviderResponse> CreateConferenceProviderAsync(CreateConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = CreateConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConferenceProviderRequest,CreateConferenceProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateContact


        /// <summary>
        /// Creates a contact with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// 
        /// <returns>The response from the CreateContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateContact">REST API Reference for CreateContact Operation</seealso>
        public virtual CreateContactResponse CreateContact(CreateContactRequest request)
        {
            var marshaller = CreateContactRequestMarshaller.Instance;
            var unmarshaller = CreateContactResponseUnmarshaller.Instance;

            return Invoke<CreateContactRequest,CreateContactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateContact">REST API Reference for CreateContact Operation</seealso>
        public virtual Task<CreateContactResponse> CreateContactAsync(CreateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateContactRequestMarshaller.Instance;
            var unmarshaller = CreateContactResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContactRequest,CreateContactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateProfile


        /// <summary>
        /// Creates a new room profile with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var marshaller = CreateProfileRequestMarshaller.Instance;
            var unmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileRequest,CreateProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateProfileRequestMarshaller.Instance;
            var unmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProfileRequest,CreateProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRoom


        /// <summary>
        /// Creates a room with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual CreateRoomResponse CreateRoom(CreateRoomRequest request)
        {
            var marshaller = CreateRoomRequestMarshaller.Instance;
            var unmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return Invoke<CreateRoomRequest,CreateRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRoomRequestMarshaller.Instance;
            var unmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoomRequest,CreateRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSkillGroup


        /// <summary>
        /// Creates a skill group with a specified name and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSkillGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateSkillGroup">REST API Reference for CreateSkillGroup Operation</seealso>
        public virtual CreateSkillGroupResponse CreateSkillGroup(CreateSkillGroupRequest request)
        {
            var marshaller = CreateSkillGroupRequestMarshaller.Instance;
            var unmarshaller = CreateSkillGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSkillGroupRequest,CreateSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSkillGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateSkillGroup">REST API Reference for CreateSkillGroup Operation</seealso>
        public virtual Task<CreateSkillGroupResponse> CreateSkillGroupAsync(CreateSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSkillGroupRequestMarshaller.Instance;
            var unmarshaller = CreateSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSkillGroupRequest,CreateSkillGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ResourceInUseException">
        /// The resource in the request is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserRequest,CreateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUserRequestMarshaller.Instance;
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserRequest,CreateUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAddressBook


        /// <summary>
        /// Deletes an address book by the address book ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddressBook service method.</param>
        /// 
        /// <returns>The response from the DeleteAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteAddressBook">REST API Reference for DeleteAddressBook Operation</seealso>
        public virtual DeleteAddressBookResponse DeleteAddressBook(DeleteAddressBookRequest request)
        {
            var marshaller = DeleteAddressBookRequestMarshaller.Instance;
            var unmarshaller = DeleteAddressBookResponseUnmarshaller.Instance;

            return Invoke<DeleteAddressBookRequest,DeleteAddressBookResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAddressBook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddressBook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteAddressBook">REST API Reference for DeleteAddressBook Operation</seealso>
        public virtual Task<DeleteAddressBookResponse> DeleteAddressBookAsync(DeleteAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAddressBookRequestMarshaller.Instance;
            var unmarshaller = DeleteAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAddressBookRequest,DeleteAddressBookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBusinessReportSchedule


        /// <summary>
        /// Deletes the recurring report delivery schedule with the specified schedule ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBusinessReportSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteBusinessReportSchedule service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteBusinessReportSchedule">REST API Reference for DeleteBusinessReportSchedule Operation</seealso>
        public virtual DeleteBusinessReportScheduleResponse DeleteBusinessReportSchedule(DeleteBusinessReportScheduleRequest request)
        {
            var marshaller = DeleteBusinessReportScheduleRequestMarshaller.Instance;
            var unmarshaller = DeleteBusinessReportScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteBusinessReportScheduleRequest,DeleteBusinessReportScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBusinessReportSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBusinessReportSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteBusinessReportSchedule">REST API Reference for DeleteBusinessReportSchedule Operation</seealso>
        public virtual Task<DeleteBusinessReportScheduleResponse> DeleteBusinessReportScheduleAsync(DeleteBusinessReportScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteBusinessReportScheduleRequestMarshaller.Instance;
            var unmarshaller = DeleteBusinessReportScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBusinessReportScheduleRequest,DeleteBusinessReportScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConferenceProvider


        /// <summary>
        /// Deletes a conference provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConferenceProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteConferenceProvider">REST API Reference for DeleteConferenceProvider Operation</seealso>
        public virtual DeleteConferenceProviderResponse DeleteConferenceProvider(DeleteConferenceProviderRequest request)
        {
            var marshaller = DeleteConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = DeleteConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteConferenceProviderRequest,DeleteConferenceProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConferenceProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConferenceProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteConferenceProvider">REST API Reference for DeleteConferenceProvider Operation</seealso>
        public virtual Task<DeleteConferenceProviderResponse> DeleteConferenceProviderAsync(DeleteConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = DeleteConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConferenceProviderRequest,DeleteConferenceProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteContact


        /// <summary>
        /// Deletes a contact by the contact ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// 
        /// <returns>The response from the DeleteContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        public virtual DeleteContactResponse DeleteContact(DeleteContactRequest request)
        {
            var marshaller = DeleteContactRequestMarshaller.Instance;
            var unmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return Invoke<DeleteContactRequest,DeleteContactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        public virtual Task<DeleteContactResponse> DeleteContactAsync(DeleteContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteContactRequestMarshaller.Instance;
            var unmarshaller = DeleteContactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContactRequest,DeleteContactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevice


        /// <summary>
        /// Removes a device from Alexa For Business.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidCertificateAuthorityException">
        /// The Certificate Authority can't issue or revoke a certificate.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            var marshaller = DeleteDeviceRequestMarshaller.Instance;
            var unmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceRequest,DeleteDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDeviceRequestMarshaller.Instance;
            var unmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceRequest,DeleteDeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteProfile


        /// <summary>
        /// Deletes a room profile by the profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var marshaller = DeleteProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileRequest,DeleteProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteProfileRequestMarshaller.Instance;
            var unmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileRequest,DeleteProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoom


        /// <summary>
        /// Deletes a room by the room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual DeleteRoomResponse DeleteRoom(DeleteRoomRequest request)
        {
            var marshaller = DeleteRoomRequestMarshaller.Instance;
            var unmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomRequest,DeleteRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual Task<DeleteRoomResponse> DeleteRoomAsync(DeleteRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRoomRequestMarshaller.Instance;
            var unmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoomRequest,DeleteRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoomSkillParameter


        /// <summary>
        /// Deletes room skill parameter details by room, skill, and parameter key ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomSkillParameter service method.</param>
        /// 
        /// <returns>The response from the DeleteRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoomSkillParameter">REST API Reference for DeleteRoomSkillParameter Operation</seealso>
        public virtual DeleteRoomSkillParameterResponse DeleteRoomSkillParameter(DeleteRoomSkillParameterRequest request)
        {
            var marshaller = DeleteRoomSkillParameterRequestMarshaller.Instance;
            var unmarshaller = DeleteRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomSkillParameterRequest,DeleteRoomSkillParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomSkillParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoomSkillParameter">REST API Reference for DeleteRoomSkillParameter Operation</seealso>
        public virtual Task<DeleteRoomSkillParameterResponse> DeleteRoomSkillParameterAsync(DeleteRoomSkillParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRoomSkillParameterRequestMarshaller.Instance;
            var unmarshaller = DeleteRoomSkillParameterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoomSkillParameterRequest,DeleteRoomSkillParameterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSkillAuthorization


        /// <summary>
        /// Unlinks a third-party account from a skill.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteSkillAuthorization service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillAuthorization">REST API Reference for DeleteSkillAuthorization Operation</seealso>
        public virtual DeleteSkillAuthorizationResponse DeleteSkillAuthorization(DeleteSkillAuthorizationRequest request)
        {
            var marshaller = DeleteSkillAuthorizationRequestMarshaller.Instance;
            var unmarshaller = DeleteSkillAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteSkillAuthorizationRequest,DeleteSkillAuthorizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSkillAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillAuthorization">REST API Reference for DeleteSkillAuthorization Operation</seealso>
        public virtual Task<DeleteSkillAuthorizationResponse> DeleteSkillAuthorizationAsync(DeleteSkillAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSkillAuthorizationRequestMarshaller.Instance;
            var unmarshaller = DeleteSkillAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSkillAuthorizationRequest,DeleteSkillAuthorizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSkillGroup


        /// <summary>
        /// Deletes a skill group by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillGroup">REST API Reference for DeleteSkillGroup Operation</seealso>
        public virtual DeleteSkillGroupResponse DeleteSkillGroup(DeleteSkillGroupRequest request)
        {
            var marshaller = DeleteSkillGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteSkillGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSkillGroupRequest,DeleteSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillGroup">REST API Reference for DeleteSkillGroup Operation</seealso>
        public virtual Task<DeleteSkillGroupResponse> DeleteSkillGroupAsync(DeleteSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSkillGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSkillGroupRequest,DeleteSkillGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a specified user by user ARN and enrollment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUserRequestMarshaller.Instance;
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserRequest,DeleteUserResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateContactFromAddressBook


        /// <summary>
        /// Disassociates a contact from a given address book.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateContactFromAddressBook service method.</param>
        /// 
        /// <returns>The response from the DisassociateContactFromAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateContactFromAddressBook">REST API Reference for DisassociateContactFromAddressBook Operation</seealso>
        public virtual DisassociateContactFromAddressBookResponse DisassociateContactFromAddressBook(DisassociateContactFromAddressBookRequest request)
        {
            var marshaller = DisassociateContactFromAddressBookRequestMarshaller.Instance;
            var unmarshaller = DisassociateContactFromAddressBookResponseUnmarshaller.Instance;

            return Invoke<DisassociateContactFromAddressBookRequest,DisassociateContactFromAddressBookResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateContactFromAddressBook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateContactFromAddressBook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateContactFromAddressBook">REST API Reference for DisassociateContactFromAddressBook Operation</seealso>
        public virtual Task<DisassociateContactFromAddressBookResponse> DisassociateContactFromAddressBookAsync(DisassociateContactFromAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateContactFromAddressBookRequestMarshaller.Instance;
            var unmarshaller = DisassociateContactFromAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateContactFromAddressBookRequest,DisassociateContactFromAddressBookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDeviceFromRoom


        /// <summary>
        /// Disassociates a device from its current room. The device continues to be connected
        /// to the Wi-Fi network and is still registered to the account. The device settings and
        /// skills are removed from the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromRoom service method.</param>
        /// 
        /// <returns>The response from the DisassociateDeviceFromRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateDeviceFromRoom">REST API Reference for DisassociateDeviceFromRoom Operation</seealso>
        public virtual DisassociateDeviceFromRoomResponse DisassociateDeviceFromRoom(DisassociateDeviceFromRoomRequest request)
        {
            var marshaller = DisassociateDeviceFromRoomRequestMarshaller.Instance;
            var unmarshaller = DisassociateDeviceFromRoomResponseUnmarshaller.Instance;

            return Invoke<DisassociateDeviceFromRoomRequest,DisassociateDeviceFromRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDeviceFromRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateDeviceFromRoom">REST API Reference for DisassociateDeviceFromRoom Operation</seealso>
        public virtual Task<DisassociateDeviceFromRoomResponse> DisassociateDeviceFromRoomAsync(DisassociateDeviceFromRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateDeviceFromRoomRequestMarshaller.Instance;
            var unmarshaller = DisassociateDeviceFromRoomResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDeviceFromRoomRequest,DisassociateDeviceFromRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSkillFromSkillGroup


        /// <summary>
        /// Disassociates a skill from a skill group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillFromSkillGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateSkillFromSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillFromSkillGroup">REST API Reference for DisassociateSkillFromSkillGroup Operation</seealso>
        public virtual DisassociateSkillFromSkillGroupResponse DisassociateSkillFromSkillGroup(DisassociateSkillFromSkillGroupRequest request)
        {
            var marshaller = DisassociateSkillFromSkillGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateSkillFromSkillGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateSkillFromSkillGroupRequest,DisassociateSkillFromSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSkillFromSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillFromSkillGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillFromSkillGroup">REST API Reference for DisassociateSkillFromSkillGroup Operation</seealso>
        public virtual Task<DisassociateSkillFromSkillGroupResponse> DisassociateSkillFromSkillGroupAsync(DisassociateSkillFromSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateSkillFromSkillGroupRequestMarshaller.Instance;
            var unmarshaller = DisassociateSkillFromSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSkillFromSkillGroupRequest,DisassociateSkillFromSkillGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSkillFromUsers


        /// <summary>
        /// Makes a private skill unavailable for enrolled users and prevents them from enabling
        /// it on their devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillFromUsers service method.</param>
        /// 
        /// <returns>The response from the DisassociateSkillFromUsers service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillFromUsers">REST API Reference for DisassociateSkillFromUsers Operation</seealso>
        public virtual DisassociateSkillFromUsersResponse DisassociateSkillFromUsers(DisassociateSkillFromUsersRequest request)
        {
            var marshaller = DisassociateSkillFromUsersRequestMarshaller.Instance;
            var unmarshaller = DisassociateSkillFromUsersResponseUnmarshaller.Instance;

            return Invoke<DisassociateSkillFromUsersRequest,DisassociateSkillFromUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSkillFromUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillFromUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillFromUsers">REST API Reference for DisassociateSkillFromUsers Operation</seealso>
        public virtual Task<DisassociateSkillFromUsersResponse> DisassociateSkillFromUsersAsync(DisassociateSkillFromUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateSkillFromUsersRequestMarshaller.Instance;
            var unmarshaller = DisassociateSkillFromUsersResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSkillFromUsersRequest,DisassociateSkillFromUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSkillGroupFromRoom


        /// <summary>
        /// Disassociates a skill group from a specified room. This disables all skills in the
        /// skill group on all devices in the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillGroupFromRoom service method.</param>
        /// 
        /// <returns>The response from the DisassociateSkillGroupFromRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillGroupFromRoom">REST API Reference for DisassociateSkillGroupFromRoom Operation</seealso>
        public virtual DisassociateSkillGroupFromRoomResponse DisassociateSkillGroupFromRoom(DisassociateSkillGroupFromRoomRequest request)
        {
            var marshaller = DisassociateSkillGroupFromRoomRequestMarshaller.Instance;
            var unmarshaller = DisassociateSkillGroupFromRoomResponseUnmarshaller.Instance;

            return Invoke<DisassociateSkillGroupFromRoomRequest,DisassociateSkillGroupFromRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSkillGroupFromRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillGroupFromRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillGroupFromRoom">REST API Reference for DisassociateSkillGroupFromRoom Operation</seealso>
        public virtual Task<DisassociateSkillGroupFromRoomResponse> DisassociateSkillGroupFromRoomAsync(DisassociateSkillGroupFromRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateSkillGroupFromRoomRequestMarshaller.Instance;
            var unmarshaller = DisassociateSkillGroupFromRoomResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSkillGroupFromRoomRequest,DisassociateSkillGroupFromRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ForgetSmartHomeAppliances


        /// <summary>
        /// Forgets smart home appliances associated to a room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ForgetSmartHomeAppliances service method.</param>
        /// 
        /// <returns>The response from the ForgetSmartHomeAppliances service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ForgetSmartHomeAppliances">REST API Reference for ForgetSmartHomeAppliances Operation</seealso>
        public virtual ForgetSmartHomeAppliancesResponse ForgetSmartHomeAppliances(ForgetSmartHomeAppliancesRequest request)
        {
            var marshaller = ForgetSmartHomeAppliancesRequestMarshaller.Instance;
            var unmarshaller = ForgetSmartHomeAppliancesResponseUnmarshaller.Instance;

            return Invoke<ForgetSmartHomeAppliancesRequest,ForgetSmartHomeAppliancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ForgetSmartHomeAppliances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgetSmartHomeAppliances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ForgetSmartHomeAppliances">REST API Reference for ForgetSmartHomeAppliances Operation</seealso>
        public virtual Task<ForgetSmartHomeAppliancesResponse> ForgetSmartHomeAppliancesAsync(ForgetSmartHomeAppliancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ForgetSmartHomeAppliancesRequestMarshaller.Instance;
            var unmarshaller = ForgetSmartHomeAppliancesResponseUnmarshaller.Instance;

            return InvokeAsync<ForgetSmartHomeAppliancesRequest,ForgetSmartHomeAppliancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAddressBook


        /// <summary>
        /// Gets address the book details by the address book ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddressBook service method.</param>
        /// 
        /// <returns>The response from the GetAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetAddressBook">REST API Reference for GetAddressBook Operation</seealso>
        public virtual GetAddressBookResponse GetAddressBook(GetAddressBookRequest request)
        {
            var marshaller = GetAddressBookRequestMarshaller.Instance;
            var unmarshaller = GetAddressBookResponseUnmarshaller.Instance;

            return Invoke<GetAddressBookRequest,GetAddressBookResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAddressBook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAddressBook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetAddressBook">REST API Reference for GetAddressBook Operation</seealso>
        public virtual Task<GetAddressBookResponse> GetAddressBookAsync(GetAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAddressBookRequestMarshaller.Instance;
            var unmarshaller = GetAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<GetAddressBookRequest,GetAddressBookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConferencePreference


        /// <summary>
        /// Retrieves the existing conference preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConferencePreference service method.</param>
        /// 
        /// <returns>The response from the GetConferencePreference service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetConferencePreference">REST API Reference for GetConferencePreference Operation</seealso>
        public virtual GetConferencePreferenceResponse GetConferencePreference(GetConferencePreferenceRequest request)
        {
            var marshaller = GetConferencePreferenceRequestMarshaller.Instance;
            var unmarshaller = GetConferencePreferenceResponseUnmarshaller.Instance;

            return Invoke<GetConferencePreferenceRequest,GetConferencePreferenceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConferencePreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConferencePreference operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetConferencePreference">REST API Reference for GetConferencePreference Operation</seealso>
        public virtual Task<GetConferencePreferenceResponse> GetConferencePreferenceAsync(GetConferencePreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConferencePreferenceRequestMarshaller.Instance;
            var unmarshaller = GetConferencePreferenceResponseUnmarshaller.Instance;

            return InvokeAsync<GetConferencePreferenceRequest,GetConferencePreferenceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConferenceProvider


        /// <summary>
        /// Gets details about a specific conference provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConferenceProvider service method.</param>
        /// 
        /// <returns>The response from the GetConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetConferenceProvider">REST API Reference for GetConferenceProvider Operation</seealso>
        public virtual GetConferenceProviderResponse GetConferenceProvider(GetConferenceProviderRequest request)
        {
            var marshaller = GetConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = GetConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<GetConferenceProviderRequest,GetConferenceProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConferenceProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConferenceProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetConferenceProvider">REST API Reference for GetConferenceProvider Operation</seealso>
        public virtual Task<GetConferenceProviderResponse> GetConferenceProviderAsync(GetConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = GetConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<GetConferenceProviderRequest,GetConferenceProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetContact


        /// <summary>
        /// Gets the contact details by the contact ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetContact">REST API Reference for GetContact Operation</seealso>
        public virtual GetContactResponse GetContact(GetContactRequest request)
        {
            var marshaller = GetContactRequestMarshaller.Instance;
            var unmarshaller = GetContactResponseUnmarshaller.Instance;

            return Invoke<GetContactRequest,GetContactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetContact">REST API Reference for GetContact Operation</seealso>
        public virtual Task<GetContactResponse> GetContactAsync(GetContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetContactRequestMarshaller.Instance;
            var unmarshaller = GetContactResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactRequest,GetContactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDevice


        /// <summary>
        /// Gets the details of a device by device ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var marshaller = GetDeviceRequestMarshaller.Instance;
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceRequest,GetDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeviceRequestMarshaller.Instance;
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceRequest,GetDeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetProfile


        /// <summary>
        /// Gets the details of a room profile by profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var marshaller = GetProfileRequestMarshaller.Instance;
            var unmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileRequest,GetProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetProfileRequestMarshaller.Instance;
            var unmarshaller = GetProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileRequest,GetProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRoom


        /// <summary>
        /// Gets room details by room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual GetRoomResponse GetRoom(GetRoomRequest request)
        {
            var marshaller = GetRoomRequestMarshaller.Instance;
            var unmarshaller = GetRoomResponseUnmarshaller.Instance;

            return Invoke<GetRoomRequest,GetRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual Task<GetRoomResponse> GetRoomAsync(GetRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRoomRequestMarshaller.Instance;
            var unmarshaller = GetRoomResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoomRequest,GetRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRoomSkillParameter


        /// <summary>
        /// Gets room skill parameter details by room, skill, and parameter key ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoomSkillParameter service method.</param>
        /// 
        /// <returns>The response from the GetRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoomSkillParameter">REST API Reference for GetRoomSkillParameter Operation</seealso>
        public virtual GetRoomSkillParameterResponse GetRoomSkillParameter(GetRoomSkillParameterRequest request)
        {
            var marshaller = GetRoomSkillParameterRequestMarshaller.Instance;
            var unmarshaller = GetRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<GetRoomSkillParameterRequest,GetRoomSkillParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoomSkillParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoomSkillParameter">REST API Reference for GetRoomSkillParameter Operation</seealso>
        public virtual Task<GetRoomSkillParameterResponse> GetRoomSkillParameterAsync(GetRoomSkillParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRoomSkillParameterRequestMarshaller.Instance;
            var unmarshaller = GetRoomSkillParameterResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoomSkillParameterRequest,GetRoomSkillParameterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSkillGroup


        /// <summary>
        /// Gets skill group details by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSkillGroup service method.</param>
        /// 
        /// <returns>The response from the GetSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetSkillGroup">REST API Reference for GetSkillGroup Operation</seealso>
        public virtual GetSkillGroupResponse GetSkillGroup(GetSkillGroupRequest request)
        {
            var marshaller = GetSkillGroupRequestMarshaller.Instance;
            var unmarshaller = GetSkillGroupResponseUnmarshaller.Instance;

            return Invoke<GetSkillGroupRequest,GetSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSkillGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetSkillGroup">REST API Reference for GetSkillGroup Operation</seealso>
        public virtual Task<GetSkillGroupResponse> GetSkillGroupAsync(GetSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSkillGroupRequestMarshaller.Instance;
            var unmarshaller = GetSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetSkillGroupRequest,GetSkillGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBusinessReportSchedules


        /// <summary>
        /// Lists the details of the schedules that a user configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBusinessReportSchedules service method.</param>
        /// 
        /// <returns>The response from the ListBusinessReportSchedules service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListBusinessReportSchedules">REST API Reference for ListBusinessReportSchedules Operation</seealso>
        public virtual ListBusinessReportSchedulesResponse ListBusinessReportSchedules(ListBusinessReportSchedulesRequest request)
        {
            var marshaller = ListBusinessReportSchedulesRequestMarshaller.Instance;
            var unmarshaller = ListBusinessReportSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListBusinessReportSchedulesRequest,ListBusinessReportSchedulesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBusinessReportSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBusinessReportSchedules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListBusinessReportSchedules">REST API Reference for ListBusinessReportSchedules Operation</seealso>
        public virtual Task<ListBusinessReportSchedulesResponse> ListBusinessReportSchedulesAsync(ListBusinessReportSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListBusinessReportSchedulesRequestMarshaller.Instance;
            var unmarshaller = ListBusinessReportSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBusinessReportSchedulesRequest,ListBusinessReportSchedulesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListConferenceProviders


        /// <summary>
        /// Lists conference providers under a specific AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConferenceProviders service method.</param>
        /// 
        /// <returns>The response from the ListConferenceProviders service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListConferenceProviders">REST API Reference for ListConferenceProviders Operation</seealso>
        public virtual ListConferenceProvidersResponse ListConferenceProviders(ListConferenceProvidersRequest request)
        {
            var marshaller = ListConferenceProvidersRequestMarshaller.Instance;
            var unmarshaller = ListConferenceProvidersResponseUnmarshaller.Instance;

            return Invoke<ListConferenceProvidersRequest,ListConferenceProvidersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConferenceProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConferenceProviders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListConferenceProviders">REST API Reference for ListConferenceProviders Operation</seealso>
        public virtual Task<ListConferenceProvidersResponse> ListConferenceProvidersAsync(ListConferenceProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListConferenceProvidersRequestMarshaller.Instance;
            var unmarshaller = ListConferenceProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListConferenceProvidersRequest,ListConferenceProvidersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceEvents


        /// <summary>
        /// Lists the device event history, including device connection status, for up to 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceEvents service method.</param>
        /// 
        /// <returns>The response from the ListDeviceEvents service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListDeviceEvents">REST API Reference for ListDeviceEvents Operation</seealso>
        public virtual ListDeviceEventsResponse ListDeviceEvents(ListDeviceEventsRequest request)
        {
            var marshaller = ListDeviceEventsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceEventsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceEventsRequest,ListDeviceEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListDeviceEvents">REST API Reference for ListDeviceEvents Operation</seealso>
        public virtual Task<ListDeviceEventsResponse> ListDeviceEventsAsync(ListDeviceEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeviceEventsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceEventsRequest,ListDeviceEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSkills


        /// <summary>
        /// Lists all enabled skills in a specific skill group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSkills service method.</param>
        /// 
        /// <returns>The response from the ListSkills service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkills">REST API Reference for ListSkills Operation</seealso>
        public virtual ListSkillsResponse ListSkills(ListSkillsRequest request)
        {
            var marshaller = ListSkillsRequestMarshaller.Instance;
            var unmarshaller = ListSkillsResponseUnmarshaller.Instance;

            return Invoke<ListSkillsRequest,ListSkillsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSkills operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSkills operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkills">REST API Reference for ListSkills Operation</seealso>
        public virtual Task<ListSkillsResponse> ListSkillsAsync(ListSkillsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSkillsRequestMarshaller.Instance;
            var unmarshaller = ListSkillsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSkillsRequest,ListSkillsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSkillsStoreCategories


        /// <summary>
        /// Lists all categories in the Alexa skill store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSkillsStoreCategories service method.</param>
        /// 
        /// <returns>The response from the ListSkillsStoreCategories service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkillsStoreCategories">REST API Reference for ListSkillsStoreCategories Operation</seealso>
        public virtual ListSkillsStoreCategoriesResponse ListSkillsStoreCategories(ListSkillsStoreCategoriesRequest request)
        {
            var marshaller = ListSkillsStoreCategoriesRequestMarshaller.Instance;
            var unmarshaller = ListSkillsStoreCategoriesResponseUnmarshaller.Instance;

            return Invoke<ListSkillsStoreCategoriesRequest,ListSkillsStoreCategoriesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSkillsStoreCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSkillsStoreCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkillsStoreCategories">REST API Reference for ListSkillsStoreCategories Operation</seealso>
        public virtual Task<ListSkillsStoreCategoriesResponse> ListSkillsStoreCategoriesAsync(ListSkillsStoreCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSkillsStoreCategoriesRequestMarshaller.Instance;
            var unmarshaller = ListSkillsStoreCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSkillsStoreCategoriesRequest,ListSkillsStoreCategoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSkillsStoreSkillsByCategory


        /// <summary>
        /// Lists all skills in the Alexa skill store by category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSkillsStoreSkillsByCategory service method.</param>
        /// 
        /// <returns>The response from the ListSkillsStoreSkillsByCategory service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkillsStoreSkillsByCategory">REST API Reference for ListSkillsStoreSkillsByCategory Operation</seealso>
        public virtual ListSkillsStoreSkillsByCategoryResponse ListSkillsStoreSkillsByCategory(ListSkillsStoreSkillsByCategoryRequest request)
        {
            var marshaller = ListSkillsStoreSkillsByCategoryRequestMarshaller.Instance;
            var unmarshaller = ListSkillsStoreSkillsByCategoryResponseUnmarshaller.Instance;

            return Invoke<ListSkillsStoreSkillsByCategoryRequest,ListSkillsStoreSkillsByCategoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSkillsStoreSkillsByCategory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSkillsStoreSkillsByCategory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkillsStoreSkillsByCategory">REST API Reference for ListSkillsStoreSkillsByCategory Operation</seealso>
        public virtual Task<ListSkillsStoreSkillsByCategoryResponse> ListSkillsStoreSkillsByCategoryAsync(ListSkillsStoreSkillsByCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSkillsStoreSkillsByCategoryRequestMarshaller.Instance;
            var unmarshaller = ListSkillsStoreSkillsByCategoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListSkillsStoreSkillsByCategoryRequest,ListSkillsStoreSkillsByCategoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSmartHomeAppliances


        /// <summary>
        /// Lists all of the smart home appliances associated with a room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSmartHomeAppliances service method.</param>
        /// 
        /// <returns>The response from the ListSmartHomeAppliances service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSmartHomeAppliances">REST API Reference for ListSmartHomeAppliances Operation</seealso>
        public virtual ListSmartHomeAppliancesResponse ListSmartHomeAppliances(ListSmartHomeAppliancesRequest request)
        {
            var marshaller = ListSmartHomeAppliancesRequestMarshaller.Instance;
            var unmarshaller = ListSmartHomeAppliancesResponseUnmarshaller.Instance;

            return Invoke<ListSmartHomeAppliancesRequest,ListSmartHomeAppliancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSmartHomeAppliances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSmartHomeAppliances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSmartHomeAppliances">REST API Reference for ListSmartHomeAppliances Operation</seealso>
        public virtual Task<ListSmartHomeAppliancesResponse> ListSmartHomeAppliancesAsync(ListSmartHomeAppliancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSmartHomeAppliancesRequestMarshaller.Instance;
            var unmarshaller = ListSmartHomeAppliancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSmartHomeAppliancesRequest,ListSmartHomeAppliancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists all tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsRequest,ListTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsRequest,ListTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutConferencePreference


        /// <summary>
        /// Sets the conference preferences on a specific conference provider at the account level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConferencePreference service method.</param>
        /// 
        /// <returns>The response from the PutConferencePreference service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutConferencePreference">REST API Reference for PutConferencePreference Operation</seealso>
        public virtual PutConferencePreferenceResponse PutConferencePreference(PutConferencePreferenceRequest request)
        {
            var marshaller = PutConferencePreferenceRequestMarshaller.Instance;
            var unmarshaller = PutConferencePreferenceResponseUnmarshaller.Instance;

            return Invoke<PutConferencePreferenceRequest,PutConferencePreferenceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConferencePreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConferencePreference operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutConferencePreference">REST API Reference for PutConferencePreference Operation</seealso>
        public virtual Task<PutConferencePreferenceResponse> PutConferencePreferenceAsync(PutConferencePreferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutConferencePreferenceRequestMarshaller.Instance;
            var unmarshaller = PutConferencePreferenceResponseUnmarshaller.Instance;

            return InvokeAsync<PutConferencePreferenceRequest,PutConferencePreferenceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutRoomSkillParameter


        /// <summary>
        /// Updates room skill parameter details by room, skill, and parameter key ID. Not all
        /// skills have a room skill parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRoomSkillParameter service method.</param>
        /// 
        /// <returns>The response from the PutRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutRoomSkillParameter">REST API Reference for PutRoomSkillParameter Operation</seealso>
        public virtual PutRoomSkillParameterResponse PutRoomSkillParameter(PutRoomSkillParameterRequest request)
        {
            var marshaller = PutRoomSkillParameterRequestMarshaller.Instance;
            var unmarshaller = PutRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<PutRoomSkillParameterRequest,PutRoomSkillParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRoomSkillParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutRoomSkillParameter">REST API Reference for PutRoomSkillParameter Operation</seealso>
        public virtual Task<PutRoomSkillParameterResponse> PutRoomSkillParameterAsync(PutRoomSkillParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutRoomSkillParameterRequestMarshaller.Instance;
            var unmarshaller = PutRoomSkillParameterResponseUnmarshaller.Instance;

            return InvokeAsync<PutRoomSkillParameterRequest,PutRoomSkillParameterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutSkillAuthorization


        /// <summary>
        /// Links a user's account to a third-party skill provider. If this API operation is called
        /// by an assumed IAM role, the skill being linked must be a private skill. Also, the
        /// skill must be owned by the AWS account that assumed the IAM role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSkillAuthorization service method.</param>
        /// 
        /// <returns>The response from the PutSkillAuthorization service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.UnauthorizedException">
        /// The caller has no permissions to operate on the resource involved in the API call.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutSkillAuthorization">REST API Reference for PutSkillAuthorization Operation</seealso>
        public virtual PutSkillAuthorizationResponse PutSkillAuthorization(PutSkillAuthorizationRequest request)
        {
            var marshaller = PutSkillAuthorizationRequestMarshaller.Instance;
            var unmarshaller = PutSkillAuthorizationResponseUnmarshaller.Instance;

            return Invoke<PutSkillAuthorizationRequest,PutSkillAuthorizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSkillAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSkillAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutSkillAuthorization">REST API Reference for PutSkillAuthorization Operation</seealso>
        public virtual Task<PutSkillAuthorizationResponse> PutSkillAuthorizationAsync(PutSkillAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutSkillAuthorizationRequestMarshaller.Instance;
            var unmarshaller = PutSkillAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<PutSkillAuthorizationRequest,PutSkillAuthorizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterAVSDevice


        /// <summary>
        /// Registers an Alexa-enabled device built by an Original Equipment Manufacturer (OEM)
        /// using Alexa Voice Service (AVS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAVSDevice service method.</param>
        /// 
        /// <returns>The response from the RegisterAVSDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidDeviceException">
        /// The device is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RegisterAVSDevice">REST API Reference for RegisterAVSDevice Operation</seealso>
        public virtual RegisterAVSDeviceResponse RegisterAVSDevice(RegisterAVSDeviceRequest request)
        {
            var marshaller = RegisterAVSDeviceRequestMarshaller.Instance;
            var unmarshaller = RegisterAVSDeviceResponseUnmarshaller.Instance;

            return Invoke<RegisterAVSDeviceRequest,RegisterAVSDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAVSDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAVSDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RegisterAVSDevice">REST API Reference for RegisterAVSDevice Operation</seealso>
        public virtual Task<RegisterAVSDeviceResponse> RegisterAVSDeviceAsync(RegisterAVSDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterAVSDeviceRequestMarshaller.Instance;
            var unmarshaller = RegisterAVSDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterAVSDeviceRequest,RegisterAVSDeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectSkill


        /// <summary>
        /// Disassociates a skill from the organization under a user's AWS account. If the skill
        /// is a private skill, it moves to an AcceptStatus of PENDING. Any private or public
        /// skill that is rejected can be added later by calling the ApproveSkill API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSkill service method.</param>
        /// 
        /// <returns>The response from the RejectSkill service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RejectSkill">REST API Reference for RejectSkill Operation</seealso>
        public virtual RejectSkillResponse RejectSkill(RejectSkillRequest request)
        {
            var marshaller = RejectSkillRequestMarshaller.Instance;
            var unmarshaller = RejectSkillResponseUnmarshaller.Instance;

            return Invoke<RejectSkillRequest,RejectSkillResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectSkill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectSkill operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RejectSkill">REST API Reference for RejectSkill Operation</seealso>
        public virtual Task<RejectSkillResponse> RejectSkillAsync(RejectSkillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RejectSkillRequestMarshaller.Instance;
            var unmarshaller = RejectSkillResponseUnmarshaller.Instance;

            return InvokeAsync<RejectSkillRequest,RejectSkillResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResolveRoom


        /// <summary>
        /// Determines the details for the room from which a skill request was invoked. This operation
        /// is used by skill developers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveRoom service method.</param>
        /// 
        /// <returns>The response from the ResolveRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ResolveRoom">REST API Reference for ResolveRoom Operation</seealso>
        public virtual ResolveRoomResponse ResolveRoom(ResolveRoomRequest request)
        {
            var marshaller = ResolveRoomRequestMarshaller.Instance;
            var unmarshaller = ResolveRoomResponseUnmarshaller.Instance;

            return Invoke<ResolveRoomRequest,ResolveRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ResolveRoom">REST API Reference for ResolveRoom Operation</seealso>
        public virtual Task<ResolveRoomResponse> ResolveRoomAsync(ResolveRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResolveRoomRequestMarshaller.Instance;
            var unmarshaller = ResolveRoomResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveRoomRequest,ResolveRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeInvitation


        /// <summary>
        /// Revokes an invitation and invalidates the enrollment URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeInvitation service method.</param>
        /// 
        /// <returns>The response from the RevokeInvitation service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RevokeInvitation">REST API Reference for RevokeInvitation Operation</seealso>
        public virtual RevokeInvitationResponse RevokeInvitation(RevokeInvitationRequest request)
        {
            var marshaller = RevokeInvitationRequestMarshaller.Instance;
            var unmarshaller = RevokeInvitationResponseUnmarshaller.Instance;

            return Invoke<RevokeInvitationRequest,RevokeInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeInvitation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RevokeInvitation">REST API Reference for RevokeInvitation Operation</seealso>
        public virtual Task<RevokeInvitationResponse> RevokeInvitationAsync(RevokeInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RevokeInvitationRequestMarshaller.Instance;
            var unmarshaller = RevokeInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeInvitationRequest,RevokeInvitationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchAddressBooks


        /// <summary>
        /// Searches address books and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAddressBooks service method.</param>
        /// 
        /// <returns>The response from the SearchAddressBooks service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchAddressBooks">REST API Reference for SearchAddressBooks Operation</seealso>
        public virtual SearchAddressBooksResponse SearchAddressBooks(SearchAddressBooksRequest request)
        {
            var marshaller = SearchAddressBooksRequestMarshaller.Instance;
            var unmarshaller = SearchAddressBooksResponseUnmarshaller.Instance;

            return Invoke<SearchAddressBooksRequest,SearchAddressBooksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAddressBooks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAddressBooks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchAddressBooks">REST API Reference for SearchAddressBooks Operation</seealso>
        public virtual Task<SearchAddressBooksResponse> SearchAddressBooksAsync(SearchAddressBooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchAddressBooksRequestMarshaller.Instance;
            var unmarshaller = SearchAddressBooksResponseUnmarshaller.Instance;

            return InvokeAsync<SearchAddressBooksRequest,SearchAddressBooksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchContacts


        /// <summary>
        /// Searches contacts and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchContacts service method.</param>
        /// 
        /// <returns>The response from the SearchContacts service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchContacts">REST API Reference for SearchContacts Operation</seealso>
        public virtual SearchContactsResponse SearchContacts(SearchContactsRequest request)
        {
            var marshaller = SearchContactsRequestMarshaller.Instance;
            var unmarshaller = SearchContactsResponseUnmarshaller.Instance;

            return Invoke<SearchContactsRequest,SearchContactsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchContacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchContacts">REST API Reference for SearchContacts Operation</seealso>
        public virtual Task<SearchContactsResponse> SearchContactsAsync(SearchContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchContactsRequestMarshaller.Instance;
            var unmarshaller = SearchContactsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchContactsRequest,SearchContactsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchDevices


        /// <summary>
        /// Searches devices and lists the ones that meet a set of filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices service method.</param>
        /// 
        /// <returns>The response from the SearchDevices service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        public virtual SearchDevicesResponse SearchDevices(SearchDevicesRequest request)
        {
            var marshaller = SearchDevicesRequestMarshaller.Instance;
            var unmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return Invoke<SearchDevicesRequest,SearchDevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        public virtual Task<SearchDevicesResponse> SearchDevicesAsync(SearchDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchDevicesRequestMarshaller.Instance;
            var unmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDevicesRequest,SearchDevicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchProfiles


        /// <summary>
        /// Searches room profiles and lists the ones that meet a set of filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchProfiles service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        public virtual SearchProfilesResponse SearchProfiles(SearchProfilesRequest request)
        {
            var marshaller = SearchProfilesRequestMarshaller.Instance;
            var unmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchProfilesRequest,SearchProfilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        public virtual Task<SearchProfilesResponse> SearchProfilesAsync(SearchProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchProfilesRequestMarshaller.Instance;
            var unmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchProfilesRequest,SearchProfilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchRooms


        /// <summary>
        /// Searches rooms and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRooms service method.</param>
        /// 
        /// <returns>The response from the SearchRooms service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchRooms">REST API Reference for SearchRooms Operation</seealso>
        public virtual SearchRoomsResponse SearchRooms(SearchRoomsRequest request)
        {
            var marshaller = SearchRoomsRequestMarshaller.Instance;
            var unmarshaller = SearchRoomsResponseUnmarshaller.Instance;

            return Invoke<SearchRoomsRequest,SearchRoomsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchRooms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRooms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchRooms">REST API Reference for SearchRooms Operation</seealso>
        public virtual Task<SearchRoomsResponse> SearchRoomsAsync(SearchRoomsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchRoomsRequestMarshaller.Instance;
            var unmarshaller = SearchRoomsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchRoomsRequest,SearchRoomsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchSkillGroups


        /// <summary>
        /// Searches skill groups and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSkillGroups service method.</param>
        /// 
        /// <returns>The response from the SearchSkillGroups service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchSkillGroups">REST API Reference for SearchSkillGroups Operation</seealso>
        public virtual SearchSkillGroupsResponse SearchSkillGroups(SearchSkillGroupsRequest request)
        {
            var marshaller = SearchSkillGroupsRequestMarshaller.Instance;
            var unmarshaller = SearchSkillGroupsResponseUnmarshaller.Instance;

            return Invoke<SearchSkillGroupsRequest,SearchSkillGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSkillGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSkillGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchSkillGroups">REST API Reference for SearchSkillGroups Operation</seealso>
        public virtual Task<SearchSkillGroupsResponse> SearchSkillGroupsAsync(SearchSkillGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchSkillGroupsRequestMarshaller.Instance;
            var unmarshaller = SearchSkillGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSkillGroupsRequest,SearchSkillGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchUsers


        /// <summary>
        /// Searches users and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual SearchUsersResponse SearchUsers(SearchUsersRequest request)
        {
            var marshaller = SearchUsersRequestMarshaller.Instance;
            var unmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return Invoke<SearchUsersRequest,SearchUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual Task<SearchUsersResponse> SearchUsersAsync(SearchUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchUsersRequestMarshaller.Instance;
            var unmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return InvokeAsync<SearchUsersRequest,SearchUsersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendInvitation


        /// <summary>
        /// Sends an enrollment invitation email with a URL to a user. The URL is valid for 72
        /// hours or until you call this operation again, whichever comes first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendInvitation service method.</param>
        /// 
        /// <returns>The response from the SendInvitation service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidUserStatusException">
        /// The attempt to update a user is invalid due to the user's current status.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SendInvitation">REST API Reference for SendInvitation Operation</seealso>
        public virtual SendInvitationResponse SendInvitation(SendInvitationRequest request)
        {
            var marshaller = SendInvitationRequestMarshaller.Instance;
            var unmarshaller = SendInvitationResponseUnmarshaller.Instance;

            return Invoke<SendInvitationRequest,SendInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendInvitation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SendInvitation">REST API Reference for SendInvitation Operation</seealso>
        public virtual Task<SendInvitationResponse> SendInvitationAsync(SendInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SendInvitationRequestMarshaller.Instance;
            var unmarshaller = SendInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<SendInvitationRequest,SendInvitationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartDeviceSync


        /// <summary>
        /// Resets a device and its account to the known default settings, by clearing all information
        /// and settings set by previous users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceSync service method.</param>
        /// 
        /// <returns>The response from the StartDeviceSync service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartDeviceSync">REST API Reference for StartDeviceSync Operation</seealso>
        public virtual StartDeviceSyncResponse StartDeviceSync(StartDeviceSyncRequest request)
        {
            var marshaller = StartDeviceSyncRequestMarshaller.Instance;
            var unmarshaller = StartDeviceSyncResponseUnmarshaller.Instance;

            return Invoke<StartDeviceSyncRequest,StartDeviceSyncResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDeviceSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceSync operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartDeviceSync">REST API Reference for StartDeviceSync Operation</seealso>
        public virtual Task<StartDeviceSyncResponse> StartDeviceSyncAsync(StartDeviceSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartDeviceSyncRequestMarshaller.Instance;
            var unmarshaller = StartDeviceSyncResponseUnmarshaller.Instance;

            return InvokeAsync<StartDeviceSyncRequest,StartDeviceSyncResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartSmartHomeApplianceDiscovery


        /// <summary>
        /// Initiates the discovery of any smart home appliances associated with the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSmartHomeApplianceDiscovery service method.</param>
        /// 
        /// <returns>The response from the StartSmartHomeApplianceDiscovery service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartSmartHomeApplianceDiscovery">REST API Reference for StartSmartHomeApplianceDiscovery Operation</seealso>
        public virtual StartSmartHomeApplianceDiscoveryResponse StartSmartHomeApplianceDiscovery(StartSmartHomeApplianceDiscoveryRequest request)
        {
            var marshaller = StartSmartHomeApplianceDiscoveryRequestMarshaller.Instance;
            var unmarshaller = StartSmartHomeApplianceDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StartSmartHomeApplianceDiscoveryRequest,StartSmartHomeApplianceDiscoveryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSmartHomeApplianceDiscovery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSmartHomeApplianceDiscovery operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartSmartHomeApplianceDiscovery">REST API Reference for StartSmartHomeApplianceDiscovery Operation</seealso>
        public virtual Task<StartSmartHomeApplianceDiscoveryResponse> StartSmartHomeApplianceDiscoveryAsync(StartSmartHomeApplianceDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartSmartHomeApplianceDiscoveryRequestMarshaller.Instance;
            var unmarshaller = StartSmartHomeApplianceDiscoveryResponseUnmarshaller.Instance;

            return InvokeAsync<StartSmartHomeApplianceDiscoveryRequest,StartSmartHomeApplianceDiscoveryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds metadata tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes metadata tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAddressBook


        /// <summary>
        /// Updates address book details by the address book ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAddressBook service method.</param>
        /// 
        /// <returns>The response from the UpdateAddressBook service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateAddressBook">REST API Reference for UpdateAddressBook Operation</seealso>
        public virtual UpdateAddressBookResponse UpdateAddressBook(UpdateAddressBookRequest request)
        {
            var marshaller = UpdateAddressBookRequestMarshaller.Instance;
            var unmarshaller = UpdateAddressBookResponseUnmarshaller.Instance;

            return Invoke<UpdateAddressBookRequest,UpdateAddressBookResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAddressBook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAddressBook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateAddressBook">REST API Reference for UpdateAddressBook Operation</seealso>
        public virtual Task<UpdateAddressBookResponse> UpdateAddressBookAsync(UpdateAddressBookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAddressBookRequestMarshaller.Instance;
            var unmarshaller = UpdateAddressBookResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAddressBookRequest,UpdateAddressBookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBusinessReportSchedule


        /// <summary>
        /// Updates the configuration of the report delivery schedule with the specified schedule
        /// ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBusinessReportSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateBusinessReportSchedule service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateBusinessReportSchedule">REST API Reference for UpdateBusinessReportSchedule Operation</seealso>
        public virtual UpdateBusinessReportScheduleResponse UpdateBusinessReportSchedule(UpdateBusinessReportScheduleRequest request)
        {
            var marshaller = UpdateBusinessReportScheduleRequestMarshaller.Instance;
            var unmarshaller = UpdateBusinessReportScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateBusinessReportScheduleRequest,UpdateBusinessReportScheduleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBusinessReportSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBusinessReportSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateBusinessReportSchedule">REST API Reference for UpdateBusinessReportSchedule Operation</seealso>
        public virtual Task<UpdateBusinessReportScheduleResponse> UpdateBusinessReportScheduleAsync(UpdateBusinessReportScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateBusinessReportScheduleRequestMarshaller.Instance;
            var unmarshaller = UpdateBusinessReportScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBusinessReportScheduleRequest,UpdateBusinessReportScheduleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConferenceProvider


        /// <summary>
        /// Updates an existing conference provider's settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConferenceProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateConferenceProvider service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateConferenceProvider">REST API Reference for UpdateConferenceProvider Operation</seealso>
        public virtual UpdateConferenceProviderResponse UpdateConferenceProvider(UpdateConferenceProviderRequest request)
        {
            var marshaller = UpdateConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = UpdateConferenceProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateConferenceProviderRequest,UpdateConferenceProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConferenceProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConferenceProvider operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateConferenceProvider">REST API Reference for UpdateConferenceProvider Operation</seealso>
        public virtual Task<UpdateConferenceProviderResponse> UpdateConferenceProviderAsync(UpdateConferenceProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateConferenceProviderRequestMarshaller.Instance;
            var unmarshaller = UpdateConferenceProviderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConferenceProviderRequest,UpdateConferenceProviderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateContact


        /// <summary>
        /// Updates the contact details by the contact ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual UpdateContactResponse UpdateContact(UpdateContactRequest request)
        {
            var marshaller = UpdateContactRequestMarshaller.Instance;
            var unmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return Invoke<UpdateContactRequest,UpdateContactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        public virtual Task<UpdateContactResponse> UpdateContactAsync(UpdateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateContactRequestMarshaller.Instance;
            var unmarshaller = UpdateContactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContactRequest,UpdateContactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevice


        /// <summary>
        /// Updates the device name by device ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.DeviceNotRegisteredException">
        /// The request failed because this device is no longer registered and therefore no longer
        /// managed by this account.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request)
        {
            var marshaller = UpdateDeviceRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceRequest,UpdateDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDeviceRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceRequest,UpdateDeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateProfile


        /// <summary>
        /// Updates an existing room profile by room profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var marshaller = UpdateProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileRequest,UpdateProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateProfileRequestMarshaller.Instance;
            var unmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProfileRequest,UpdateProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoom


        /// <summary>
        /// Updates room details by room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual UpdateRoomResponse UpdateRoom(UpdateRoomRequest request)
        {
            var marshaller = UpdateRoomRequestMarshaller.Instance;
            var unmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return Invoke<UpdateRoomRequest,UpdateRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual Task<UpdateRoomResponse> UpdateRoomAsync(UpdateRoomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRoomRequestMarshaller.Instance;
            var unmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoomRequest,UpdateRoomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSkillGroup


        /// <summary>
        /// Updates skill group details by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSkillGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ConcurrentModificationException">
        /// Concurrent modification of resources. HTTP Status Code: 400.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use.
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateSkillGroup">REST API Reference for UpdateSkillGroup Operation</seealso>
        public virtual UpdateSkillGroupResponse UpdateSkillGroup(UpdateSkillGroupRequest request)
        {
            var marshaller = UpdateSkillGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateSkillGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateSkillGroupRequest,UpdateSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSkillGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateSkillGroup">REST API Reference for UpdateSkillGroup Operation</seealso>
        public virtual Task<UpdateSkillGroupResponse> UpdateSkillGroupAsync(UpdateSkillGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSkillGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateSkillGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSkillGroupRequest,UpdateSkillGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}