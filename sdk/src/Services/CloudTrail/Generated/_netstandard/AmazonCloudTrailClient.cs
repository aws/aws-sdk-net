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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudTrail.Model;
using Amazon.CloudTrail.Model.Internal.MarshallTransformations;
using Amazon.CloudTrail.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudTrail
{
    /// <summary>
    /// Implementation for accessing CloudTrail
    ///
    /// AWS CloudTrail 
    /// <para>
    /// This is the CloudTrail API Reference. It provides descriptions of actions, data types,
    /// common parameters, and common errors for CloudTrail.
    /// </para>
    ///  
    /// <para>
    /// CloudTrail is a web service that records AWS API calls for your AWS account and delivers
    /// log files to an Amazon S3 bucket. The recorded information includes the identity of
    /// the user, the start time of the AWS API call, the source IP address, the request parameters,
    /// and the response elements returned by the service.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to the API, you can use one of the AWS SDKs, which consist of libraries
    /// and sample code for various programming languages and platforms (Java, Ruby, .NET,
    /// iOS, Android, etc.). The SDKs provide a convenient way to create programmatic access
    /// to AWSCloudTrail. For example, the SDKs take care of cryptographically signing requests,
    /// managing errors, and retrying requests automatically. For information about the AWS
    /// SDKs, including how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services page</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// See the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-user-guide.html">AWS
    /// CloudTrail User Guide</a> for information about the data that is included with each
    /// AWS API call listed in the log files.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonCloudTrailClient : AmazonServiceClient, IAmazonCloudTrail
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudTrailMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(AmazonCloudTrailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudTrailClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudTrailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials and an
        /// AmazonCloudTrailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(AWSCredentials credentials, AmazonCloudTrailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudTrailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudTrailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICloudTrailPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudTrailPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudTrailPaginatorFactory(this);
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


        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to a trail, up to a limit of 50. Overwrites an existing tag's
        /// value when a new value is specified for an existing tag key. Tag key names must be
        /// unique for a trail; you cannot have two keys with the same name but different values.
        /// If you specify a key without a value, the tag will be created with the specified key
        /// and a value of null. You can tag a trail that applies to all AWS Regions only from
        /// the Region in which the trail was created (also known as its home region).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an invalid trail ARN. The
        /// format of a trail ARN is:
        /// 
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail has exceeded the permitted amount. Currently, the limit
        /// is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrail

        internal virtual CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return Invoke<CreateTrailResponse>(request, options);
        }



        /// <summary>
        /// Creates a trail that specifies the settings for delivery of log data to an Amazon
        /// S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between AWS CloudTrail
        /// and AWS Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Enabling
        /// Trusted Access with Other AWS Services</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <code>InvalidClientTokenId</code>
        /// error code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended AWS account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// This exception is thrown when the policy on the S3 bucket or KMS key is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail can’t be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same region, or when the KMS key associated with the SNS topic
        /// either does not exist or is not in the same region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaximumNumberOfTrailsExceededException">
        /// This exception is thrown when the maximum number of trails is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when AWS Organizations is not configured to support all features.
        /// All features must be enabled in AWS Organization to support creating an organization
        /// trail. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an AWS account that is not
        /// a member of an organization. To make this request, sign in using the credentials of
        /// an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailAlreadyExistsException">
        /// This exception is thrown when the specified trail already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        public virtual Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrail

        internal virtual DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return Invoke<DeleteTrailResponse>(request, options);
        }



        /// <summary>
        /// Deletes a trail. This operation must be called from the region in which the trail
        /// was created. <code>DeleteTrail</code> cannot be called on the shadow trails (replicated
        /// trails in other regions) of a trail that is enabled in all regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteTrail">REST API Reference for DeleteTrail Operation</seealso>
        public virtual Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrails

        internal virtual DescribeTrailsResponse DescribeTrails()
        {
            return DescribeTrails(new DescribeTrailsRequest());
        }
        internal virtual DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrailsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves settings for one or more trails associated with the current region for your
        /// account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        public virtual Task<DescribeTrailsResponse> DescribeTrailsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTrailsAsync(new DescribeTrailsRequest(), cancellationToken);
        }



        /// <summary>
        /// Retrieves settings for one or more trails associated with the current region for your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        public virtual Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventSelectors

        internal virtual GetEventSelectorsResponse GetEventSelectors(GetEventSelectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSelectorsResponseUnmarshaller.Instance;

            return Invoke<GetEventSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Describes the settings for the event selectors that you configured for your trail.
        /// The information returned for your event selectors includes the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If your event selector includes read-only events, write-only events, or all events.
        /// This applies to both management events and data events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes management events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes data events, the Amazon S3 objects or AWS Lambda functions
        /// that you are logging for data events.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html">Logging
        /// Data and Management Events for Trails </a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventSelectors">REST API Reference for GetEventSelectors Operation</seealso>
        public virtual Task<GetEventSelectorsResponse> GetEventSelectorsAsync(GetEventSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventSelectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInsightSelectors

        internal virtual GetInsightSelectorsResponse GetInsightSelectors(GetInsightSelectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSelectorsResponseUnmarshaller.Instance;

            return Invoke<GetInsightSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Describes the settings for the Insights event selectors that you configured for your
        /// trail. <code>GetInsightSelectors</code> shows if CloudTrail Insights event logging
        /// is enabled on the trail, and if it is, which insight types are enabled. If you run
        /// <code>GetInsightSelectors</code> on a trail that does not have Insights events enabled,
        /// the operation throws the exception <code>InsightNotEnabledException</code> 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Logging
        /// CloudTrail Insights Events for Trails </a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsightNotEnabledException">
        /// If you run <code>GetInsightSelectors</code> on a trail that does not have Insights
        /// events enabled, the operation throws the exception <code>InsightNotEnabledException</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetInsightSelectors">REST API Reference for GetInsightSelectors Operation</seealso>
        public virtual Task<GetInsightSelectorsResponse> GetInsightSelectorsAsync(GetInsightSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInsightSelectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrail

        internal virtual GetTrailResponse GetTrail(GetTrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailResponseUnmarshaller.Instance;

            return Invoke<GetTrailResponse>(request, options);
        }



        /// <summary>
        /// Returns settings information for a specified trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrail">REST API Reference for GetTrail Operation</seealso>
        public virtual Task<GetTrailResponse> GetTrailAsync(GetTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrailStatus

        internal virtual GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrailStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return Invoke<GetTrailStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns a JSON-formatted list of information about the specified trail. Fields include
        /// information on delivery errors, Amazon SNS and Amazon S3 errors, and start and stop
        /// logging times for each trail. This operation returns trail status from a single region.
        /// To return trail status from all regions, you must call the operation on each region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        public virtual Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrailStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrailStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPublicKeys

        internal virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysResponse>(request, options);
        }



        /// <summary>
        /// Returns all public keys whose private keys were used to sign the digest files within
        /// the specified time range. The public key is needed to validate digest files that were
        /// signed with its corresponding private key.
        /// 
        ///  <note> 
        /// <para>
        /// CloudTrail uses different private/public key pairs per region. Each digest file is
        /// signed with a private key unique to its region. Therefore, when you validate a digest
        /// file from a particular region, you must look in the same region for its corresponding
        /// public key.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are invalid. Either the start time occurs after the
        /// end time or the time range is outside the range of possible values.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTokenException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublicKeysResponse>(request, options, cancellationToken);
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
        /// Lists the tags for the trail in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an invalid trail ARN. The
        /// format of a trail ARN is:
        /// 
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTokenException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrails

        internal virtual ListTrailsResponse ListTrails(ListTrailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrailsResponseUnmarshaller.Instance;

            return Invoke<ListTrailsResponse>(request, options);
        }



        /// <summary>
        /// Lists trails that are in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTrails">REST API Reference for ListTrails Operation</seealso>
        public virtual Task<ListTrailsResponse> ListTrailsAsync(ListTrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrailsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  LookupEvents

        internal virtual LookupEventsResponse LookupEvents(LookupEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupEventsResponseUnmarshaller.Instance;

            return Invoke<LookupEventsResponse>(request, options);
        }



        /// <summary>
        /// Looks up <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-management-events">management
        /// events</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-insights-events">CloudTrail
        /// Insights events</a> that are captured by CloudTrail. You can look up events that occurred
        /// in a region within the last 90 days. Lookup supports the following attributes for
        /// management events:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS access key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event source
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Read only
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Lookup supports the following attributes for Insights events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Event ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event source
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// All attributes are optional. The default number of results returned is 50, with a
        /// maximum of 50 possible. The response includes a token that you can use to get the
        /// next page of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// The rate of lookup requests is limited to two per second, per account, per region.
        /// If this limit is exceeded, a throttling error occurs.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LookupEvents service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventCategoryException">
        /// Occurs if an event category that is not valid is specified as a value of <code>EventCategory</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidLookupAttributesException">
        /// Occurs when an invalid lookup attribute is specified.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// Invalid token or token that was previously used in a request with different parameters.
        /// This exception is thrown if the token is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are invalid. Either the start time occurs after the
        /// end time or the time range is outside the range of possible values.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        public virtual Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupEventsResponseUnmarshaller.Instance;

            return InvokeAsync<LookupEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEventSelectors

        internal virtual PutEventSelectorsResponse PutEventSelectors(PutEventSelectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventSelectorsResponseUnmarshaller.Instance;

            return Invoke<PutEventSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Configures an event selector or advanced event selectors for your trail. Use event
        /// selectors or advanced event selectors to specify management and data event settings
        /// for your trail. By default, trails created without specific event selectors are configured
        /// to log all read and write management events, and no data events.
        /// 
        ///  
        /// <para>
        /// When an event occurs in your account, CloudTrail evaluates the event selectors or
        /// advanced event selectors in all trails. For each trail, if the event matches any event
        /// selector, the trail processes and logs the event. If the event doesn't match any event
        /// selector, the trail doesn't log the event. 
        /// </para>
        ///  
        /// <para>
        /// Example
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You create an event selector for a trail and specify that you want write-only events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 <code>GetConsoleOutput</code> and <code>RunInstances</code> API operations
        /// occur in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudTrail evaluates whether the events match your event selectors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RunInstances</code> is a write-only event and it matches your event selector.
        /// The trail logs the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GetConsoleOutput</code> is a read-only event that doesn't match your event
        /// selector. The trail doesn't log the event. 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// The <code>PutEventSelectors</code> operation must be called from the region in which
        /// the trail was created; otherwise, an <code>InvalidHomeRegionException</code> exception
        /// is thrown.
        /// </para>
        ///  
        /// <para>
        /// You can configure up to five event selectors for each trail. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html">Logging
        /// data and management events for trails </a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Quotas
        /// in AWS CloudTrail</a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can add advanced event selectors, and conditions for your advanced event selectors,
        /// up to a maximum of 500 values for all conditions and selectors on a trail. You can
        /// use either <code>AdvancedEventSelectors</code> or <code>EventSelectors</code>, but
        /// not both. If you apply <code>AdvancedEventSelectors</code> to a trail, any existing
        /// <code>EventSelectors</code> are overwritten. For more information about advanced event
        /// selectors, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events for trails</a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <code>PutEventSelectors</code> operation is called
        /// with a number of event selectors, advanced event selectors, or data resources that
        /// is not valid. The combination of event selectors or advanced event selectors and data
        /// resources is not valid. A trail can have up to 5 event selectors. If a trail uses
        /// advanced event selectors, a maximum of 500 total values for all conditions in all
        /// advanced event selectors is allowed. A trail is limited to 250 data resources. These
        /// data resources can be distributed across event selectors, but the overall total cannot
        /// exceed 250.
        /// 
        ///  
        /// <para>
        /// You can:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a valid number of event selectors (1 to 5) for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
        /// of number of resources on an individual event selector is configurable up to 250.
        /// However, this upper limit is allowed only if the total number of data resources does
        /// not exceed 250 across all event selectors for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <code>ReadWriteType</code>
        /// parameter with a value of <code>read-only</code> is invalid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventSelectors">REST API Reference for PutEventSelectors Operation</seealso>
        public virtual Task<PutEventSelectorsResponse> PutEventSelectorsAsync(PutEventSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventSelectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutInsightSelectors

        internal virtual PutInsightSelectorsResponse PutInsightSelectors(PutInsightSelectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInsightSelectorsResponseUnmarshaller.Instance;

            return Invoke<PutInsightSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Lets you enable Insights event logging by specifying the Insights selectors that you
        /// want to enable on an existing trail. You also use <code>PutInsightSelectors</code>
        /// to turn off Insights event logging, by passing an empty list of insight types. In
        /// this release, only <code>ApiCallRateInsight</code> is supported as an Insights selector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInsightSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// This exception is thrown when the policy on the S3 bucket or KMS key is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidInsightSelectorsException">
        /// The formatting or syntax of the <code>InsightSelectors</code> JSON statement in your
        /// <code>PutInsightSelectors</code> or <code>GetInsightSelectors</code> request is not
        /// valid, or the specified insight type in the <code>InsightSelectors</code> statement
        /// is not a valid insight type.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutInsightSelectors">REST API Reference for PutInsightSelectors Operation</seealso>
        public virtual Task<PutInsightSelectorsResponse> PutInsightSelectorsAsync(PutInsightSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInsightSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<PutInsightSelectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from a trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an invalid trail ARN. The
        /// format of a trail ARN is:
        /// 
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartLogging

        internal virtual StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return Invoke<StartLoggingResponse>(request, options);
        }



        /// <summary>
        /// Starts the recording of AWS API calls and log file delivery for a trail. For a trail
        /// that is enabled in all regions, this operation must be called from the region in which
        /// the trail was created. This operation cannot be called on the shadow trails (replicated
        /// trails in other regions) of a trail that is enabled in all regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartLogging">REST API Reference for StartLogging Operation</seealso>
        public virtual Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StartLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopLogging

        internal virtual StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return Invoke<StopLoggingResponse>(request, options);
        }



        /// <summary>
        /// Suspends the recording of AWS API calls and log file delivery for the specified trail.
        /// Under most circumstances, there is no need to use this action. You can update a trail
        /// without stopping it first. This action is the only way to stop recording. For a trail
        /// enabled in all regions, this operation must be called from the region in which the
        /// trail was created, or an <code>InvalidHomeRegionException</code> will occur. This
        /// operation cannot be called on the shadow trails (replicated trails in other regions)
        /// of a trail enabled in all regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopLogging">REST API Reference for StopLogging Operation</seealso>
        public virtual Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StopLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrail

        internal virtual UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return Invoke<UpdateTrailResponse>(request, options);
        }



        /// <summary>
        /// Updates the settings that specify delivery of log files. Changes to a trail do not
        /// require stopping the CloudTrail service. Use this action to designate an existing
        /// bucket for log delivery. If the existing bucket has previously been a target for CloudTrail
        /// log files, an IAM policy exists for the bucket. <code>UpdateTrail</code> must be called
        /// from the region in which the trail was created; otherwise, an <code>InvalidHomeRegionException</code>
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between AWS CloudTrail
        /// and AWS Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Enabling
        /// Trusted Access with Other AWS Services</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <code>InvalidClientTokenId</code>
        /// error code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended AWS account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM user or role that is used to create the organization
        /// trail is lacking one or more required permissions for creating an organization trail
        /// in a required service. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// This exception is thrown when the policy on the S3 bucket or KMS key is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <code>PutEventSelectors</code> operation is called
        /// with a number of event selectors, advanced event selectors, or data resources that
        /// is not valid. The combination of event selectors or advanced event selectors and data
        /// resources is not valid. A trail can have up to 5 event selectors. If a trail uses
        /// advanced event selectors, a maximum of 500 total values for all conditions in all
        /// advanced event selectors is allowed. A trail is limited to 250 data resources. These
        /// data resources can be distributed across event selectors, but the overall total cannot
        /// exceed 250.
        /// 
        ///  
        /// <para>
        /// You can:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a valid number of event selectors (1 to 5) for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
        /// of number of resources on an individual event selector is configurable up to 250.
        /// However, this upper limit is allowed only if the total number of data resources does
        /// not exceed 250 across all event selectors for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <code>ReadWriteType</code>
        /// parameter with a value of <code>read-only</code> is invalid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a region other
        /// than the region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail can’t be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same region, or when the KMS key associated with the SNS topic
        /// either does not exist or is not in the same region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the AWS account making the request to create or update
        /// an organization trail is not the master account for an organization in AWS Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when AWS Organizations is not configured to support all features.
        /// All features must be enabled in AWS Organization to support creating an organization
        /// trail. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an AWS account that is not
        /// a member of an organization. To make this request, sign in using the credentials of
        /// an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        public virtual Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}