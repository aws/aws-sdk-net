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

#if CORECLR
    
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

#endif

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

        internal virtual ApproveSkillResponse ApproveSkill(ApproveSkillRequest request)
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

        internal virtual AssociateContactWithAddressBookResponse AssociateContactWithAddressBook(AssociateContactWithAddressBookRequest request)
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

        internal virtual AssociateDeviceWithRoomResponse AssociateDeviceWithRoom(AssociateDeviceWithRoomRequest request)
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

        internal virtual AssociateSkillGroupWithRoomResponse AssociateSkillGroupWithRoom(AssociateSkillGroupWithRoomRequest request)
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

        internal virtual AssociateSkillWithSkillGroupResponse AssociateSkillWithSkillGroup(AssociateSkillWithSkillGroupRequest request)
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

        internal virtual AssociateSkillWithUsersResponse AssociateSkillWithUsers(AssociateSkillWithUsersRequest request)
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

        internal virtual CreateAddressBookResponse CreateAddressBook(CreateAddressBookRequest request)
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

        internal virtual CreateBusinessReportScheduleResponse CreateBusinessReportSchedule(CreateBusinessReportScheduleRequest request)
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

        internal virtual CreateConferenceProviderResponse CreateConferenceProvider(CreateConferenceProviderRequest request)
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

        internal virtual CreateContactResponse CreateContact(CreateContactRequest request)
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

        internal virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
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

        internal virtual CreateRoomResponse CreateRoom(CreateRoomRequest request)
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

        internal virtual CreateSkillGroupResponse CreateSkillGroup(CreateSkillGroupRequest request)
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

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
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

        internal virtual DeleteAddressBookResponse DeleteAddressBook(DeleteAddressBookRequest request)
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

        internal virtual DeleteBusinessReportScheduleResponse DeleteBusinessReportSchedule(DeleteBusinessReportScheduleRequest request)
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

        internal virtual DeleteConferenceProviderResponse DeleteConferenceProvider(DeleteConferenceProviderRequest request)
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

        internal virtual DeleteContactResponse DeleteContact(DeleteContactRequest request)
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

        internal virtual DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
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

        internal virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
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

        internal virtual DeleteRoomResponse DeleteRoom(DeleteRoomRequest request)
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

        internal virtual DeleteRoomSkillParameterResponse DeleteRoomSkillParameter(DeleteRoomSkillParameterRequest request)
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

        internal virtual DeleteSkillAuthorizationResponse DeleteSkillAuthorization(DeleteSkillAuthorizationRequest request)
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

        internal virtual DeleteSkillGroupResponse DeleteSkillGroup(DeleteSkillGroupRequest request)
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

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
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

        internal virtual DisassociateContactFromAddressBookResponse DisassociateContactFromAddressBook(DisassociateContactFromAddressBookRequest request)
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

        internal virtual DisassociateDeviceFromRoomResponse DisassociateDeviceFromRoom(DisassociateDeviceFromRoomRequest request)
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

        internal virtual DisassociateSkillFromSkillGroupResponse DisassociateSkillFromSkillGroup(DisassociateSkillFromSkillGroupRequest request)
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

        internal virtual DisassociateSkillFromUsersResponse DisassociateSkillFromUsers(DisassociateSkillFromUsersRequest request)
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

        internal virtual DisassociateSkillGroupFromRoomResponse DisassociateSkillGroupFromRoom(DisassociateSkillGroupFromRoomRequest request)
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

        internal virtual ForgetSmartHomeAppliancesResponse ForgetSmartHomeAppliances(ForgetSmartHomeAppliancesRequest request)
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

        internal virtual GetAddressBookResponse GetAddressBook(GetAddressBookRequest request)
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

        internal virtual GetConferencePreferenceResponse GetConferencePreference(GetConferencePreferenceRequest request)
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

        internal virtual GetConferenceProviderResponse GetConferenceProvider(GetConferenceProviderRequest request)
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

        internal virtual GetContactResponse GetContact(GetContactRequest request)
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

        internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
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

        internal virtual GetProfileResponse GetProfile(GetProfileRequest request)
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

        internal virtual GetRoomResponse GetRoom(GetRoomRequest request)
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

        internal virtual GetRoomSkillParameterResponse GetRoomSkillParameter(GetRoomSkillParameterRequest request)
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

        internal virtual GetSkillGroupResponse GetSkillGroup(GetSkillGroupRequest request)
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

        internal virtual ListBusinessReportSchedulesResponse ListBusinessReportSchedules(ListBusinessReportSchedulesRequest request)
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

        internal virtual ListConferenceProvidersResponse ListConferenceProviders(ListConferenceProvidersRequest request)
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

        internal virtual ListDeviceEventsResponse ListDeviceEvents(ListDeviceEventsRequest request)
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

        internal virtual ListSkillsResponse ListSkills(ListSkillsRequest request)
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

        internal virtual ListSkillsStoreCategoriesResponse ListSkillsStoreCategories(ListSkillsStoreCategoriesRequest request)
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

        internal virtual ListSkillsStoreSkillsByCategoryResponse ListSkillsStoreSkillsByCategory(ListSkillsStoreSkillsByCategoryRequest request)
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

        internal virtual ListSmartHomeAppliancesResponse ListSmartHomeAppliances(ListSmartHomeAppliancesRequest request)
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

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
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

        internal virtual PutConferencePreferenceResponse PutConferencePreference(PutConferencePreferenceRequest request)
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

        internal virtual PutRoomSkillParameterResponse PutRoomSkillParameter(PutRoomSkillParameterRequest request)
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

        internal virtual PutSkillAuthorizationResponse PutSkillAuthorization(PutSkillAuthorizationRequest request)
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

        internal virtual RegisterAVSDeviceResponse RegisterAVSDevice(RegisterAVSDeviceRequest request)
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

        internal virtual RejectSkillResponse RejectSkill(RejectSkillRequest request)
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

        internal virtual ResolveRoomResponse ResolveRoom(ResolveRoomRequest request)
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

        internal virtual RevokeInvitationResponse RevokeInvitation(RevokeInvitationRequest request)
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

        internal virtual SearchAddressBooksResponse SearchAddressBooks(SearchAddressBooksRequest request)
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

        internal virtual SearchContactsResponse SearchContacts(SearchContactsRequest request)
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

        internal virtual SearchDevicesResponse SearchDevices(SearchDevicesRequest request)
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

        internal virtual SearchProfilesResponse SearchProfiles(SearchProfilesRequest request)
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

        internal virtual SearchRoomsResponse SearchRooms(SearchRoomsRequest request)
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

        internal virtual SearchSkillGroupsResponse SearchSkillGroups(SearchSkillGroupsRequest request)
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

        internal virtual SearchUsersResponse SearchUsers(SearchUsersRequest request)
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

        internal virtual SendInvitationResponse SendInvitation(SendInvitationRequest request)
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

        internal virtual StartDeviceSyncResponse StartDeviceSync(StartDeviceSyncRequest request)
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

        internal virtual StartSmartHomeApplianceDiscoveryResponse StartSmartHomeApplianceDiscovery(StartSmartHomeApplianceDiscoveryRequest request)
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

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
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

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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

        internal virtual UpdateAddressBookResponse UpdateAddressBook(UpdateAddressBookRequest request)
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

        internal virtual UpdateBusinessReportScheduleResponse UpdateBusinessReportSchedule(UpdateBusinessReportScheduleRequest request)
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

        internal virtual UpdateConferenceProviderResponse UpdateConferenceProvider(UpdateConferenceProviderRequest request)
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

        internal virtual UpdateContactResponse UpdateContact(UpdateContactRequest request)
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

        internal virtual UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request)
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

        internal virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
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

        internal virtual UpdateRoomResponse UpdateRoom(UpdateRoomRequest request)
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

        internal virtual UpdateSkillGroupResponse UpdateSkillGroup(UpdateSkillGroupRequest request)
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