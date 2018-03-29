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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ResourceGroupsTaggingAPI.Model;
using Amazon.ResourceGroupsTaggingAPI.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ResourceGroupsTaggingAPI
{
    /// <summary>
    /// Implementation for accessing ResourceGroupsTaggingAPI
    ///
    /// Resource Groups Tagging API 
    /// <para>
    /// This guide describes the API operations for the resource groups tagging.
    /// </para>
    ///  
    /// <para>
    /// A tag is a label that you assign to an AWS resource. A tag consists of a key and a
    /// value, both of which you define. For example, if you have two Amazon EC2 instances,
    /// you might assign both a tag key of "Stack." But the value of "Stack" might be "Testing"
    /// for one and "Production" for the other.
    /// </para>
    ///  
    /// <para>
    /// Tagging can help you organize your resources and enables you to simplify resource
    /// management, access management and cost allocation. For more information about tagging,
    /// see <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/tag-editor.html">Working
    /// with Tag Editor</a> and <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/resource-groups.html">Working
    /// with Resource Groups</a>. For more information about permissions you need to use the
    /// resource groups tagging APIs, see <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/obtaining-permissions-for-resource-groups.html">Obtaining
    /// Permissions for Resource Groups </a> and <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/obtaining-permissions-for-tagging.html">Obtaining
    /// Permissions for Tagging </a>.
    /// </para>
    ///  
    /// <para>
    /// You can use the resource groups tagging APIs to complete the following tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tag and untag supported resources located in the specified region for the AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use tag-based filters to search for resources located in the specified region for
    /// the AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing tag keys in the specified region for the AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing values for the specified key in the specified region for the AWS
    /// account
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Not all resources can have tags. For a lists of resources that you can tag, see <a
    /// href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/supported-resources.html">Supported
    /// Resources</a> in the <i>AWS Resource Groups and Tag Editor User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To make full use of the resource groups tagging APIs, you might need additional IAM
    /// permissions, including permission to access the resources of individual services as
    /// well as permission to view and apply tags to those resources. For more information,
    /// see <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/obtaining-permissions-for-tagging.html">Obtaining
    /// Permissions for Tagging</a> in the <i>AWS Resource Groups and Tag Editor User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonResourceGroupsTaggingAPIClient : AmazonServiceClient, IAmazonResourceGroupsTaggingAPI
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with the credentials loaded from the application's
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
        public AmazonResourceGroupsTaggingAPIClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResourceGroupsTaggingAPIConfig()) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with the credentials loaded from the application's
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
        public AmazonResourceGroupsTaggingAPIClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResourceGroupsTaggingAPIConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(AmazonResourceGroupsTaggingAPIConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonResourceGroupsTaggingAPIClient(AWSCredentials credentials)
            : this(credentials, new AmazonResourceGroupsTaggingAPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsTaggingAPIClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonResourceGroupsTaggingAPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Credentials and an
        /// AmazonResourceGroupsTaggingAPIClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(AWSCredentials credentials, AmazonResourceGroupsTaggingAPIConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceGroupsTaggingAPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceGroupsTaggingAPIConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceGroupsTaggingAPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonResourceGroupsTaggingAPIConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceGroupsTaggingAPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceGroupsTaggingAPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsTaggingAPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceGroupsTaggingAPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonResourceGroupsTaggingAPIClient Configuration Object</param>
        public AmazonResourceGroupsTaggingAPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonResourceGroupsTaggingAPIConfig clientConfig)
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

        
        #region  GetResources

        internal virtual GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesRequest,GetResourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcesRequest,GetResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTagKeys

        internal virtual GetTagKeysResponse GetTagKeys(GetTagKeysRequest request)
        {
            var marshaller = GetTagKeysRequestMarshaller.Instance;
            var unmarshaller = GetTagKeysResponseUnmarshaller.Instance;

            return Invoke<GetTagKeysRequest,GetTagKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTagKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        public virtual Task<GetTagKeysResponse> GetTagKeysAsync(GetTagKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTagKeysRequestMarshaller.Instance;
            var unmarshaller = GetTagKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetTagKeysRequest,GetTagKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTagValues

        internal virtual GetTagValuesResponse GetTagValues(GetTagValuesRequest request)
        {
            var marshaller = GetTagValuesRequestMarshaller.Instance;
            var unmarshaller = GetTagValuesResponseUnmarshaller.Instance;

            return Invoke<GetTagValuesRequest,GetTagValuesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTagValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        public virtual Task<GetTagValuesResponse> GetTagValuesAsync(GetTagValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTagValuesRequestMarshaller.Instance;
            var unmarshaller = GetTagValuesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTagValuesRequest,GetTagValuesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResources

        internal virtual TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            var marshaller = TagResourcesRequestMarshaller.Instance;
            var unmarshaller = TagResourcesResponseUnmarshaller.Instance;

            return Invoke<TagResourcesRequest,TagResourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        public virtual Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourcesRequestMarshaller.Instance;
            var unmarshaller = TagResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourcesRequest,TagResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResources

        internal virtual UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            var marshaller = UntagResourcesRequestMarshaller.Instance;
            var unmarshaller = UntagResourcesResponseUnmarshaller.Instance;

            return Invoke<UntagResourcesRequest,UntagResourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        public virtual Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourcesRequestMarshaller.Instance;
            var unmarshaller = UntagResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourcesRequest,UntagResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}