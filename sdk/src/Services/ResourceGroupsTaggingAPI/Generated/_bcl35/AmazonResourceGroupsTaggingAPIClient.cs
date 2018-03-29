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

        /// <summary>
        /// Returns all the tagged resources that are associated with the specified tags (keys
        /// and values) located in the specified region for the AWS account. The tags and the
        /// resource types that you specify in the request are known as <i>filters</i>. The response
        /// includes all tags that are associated with the requested resources. If no filter is
        /// provided, this action returns a paginated resource list with the associated tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesRequest,GetResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<GetResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResources.</param>
        /// 
        /// <returns>Returns a  GetResourcesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual GetResourcesResponse EndGetResources(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTagKeys

        /// <summary>
        /// Returns all tag keys in the specified region for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys service method.</param>
        /// 
        /// <returns>The response from the GetTagKeys service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        public virtual GetTagKeysResponse GetTagKeys(GetTagKeysRequest request)
        {
            var marshaller = GetTagKeysRequestMarshaller.Instance;
            var unmarshaller = GetTagKeysResponseUnmarshaller.Instance;

            return Invoke<GetTagKeysRequest,GetTagKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTagKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTagKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        public virtual IAsyncResult BeginGetTagKeys(GetTagKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTagKeysRequestMarshaller.Instance;
            var unmarshaller = GetTagKeysResponseUnmarshaller.Instance;

            return BeginInvoke<GetTagKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTagKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTagKeys.</param>
        /// 
        /// <returns>Returns a  GetTagKeysResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        public virtual GetTagKeysResponse EndGetTagKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTagKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTagValues

        /// <summary>
        /// Returns all tag values for the specified key in the specified region for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues service method.</param>
        /// 
        /// <returns>The response from the GetTagValues service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        public virtual GetTagValuesResponse GetTagValues(GetTagValuesRequest request)
        {
            var marshaller = GetTagValuesRequestMarshaller.Instance;
            var unmarshaller = GetTagValuesResponseUnmarshaller.Instance;

            return Invoke<GetTagValuesRequest,GetTagValuesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTagValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTagValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        public virtual IAsyncResult BeginGetTagValues(GetTagValuesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTagValuesRequestMarshaller.Instance;
            var unmarshaller = GetTagValuesResponseUnmarshaller.Instance;

            return BeginInvoke<GetTagValuesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTagValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTagValues.</param>
        /// 
        /// <returns>Returns a  GetTagValuesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        public virtual GetTagValuesResponse EndGetTagValues(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTagValuesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResources

        /// <summary>
        /// Applies one or more tags to the specified resources. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Not all resources can have tags. For a list of resources that support tagging, see
        /// <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/supported-resources.html">Supported
        /// Resources</a> in the <i>AWS Resource Groups and Tag Editor User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. For other limits, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#tag-restrictions">Tag
        /// Restrictions</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified region for the AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/obtaining-permissions-for-tagging.html">Obtaining
        /// Permissions for Tagging</a> in the <i>AWS Resource Groups and Tag Editor User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResources service method.</param>
        /// 
        /// <returns>The response from the TagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        public virtual TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            var marshaller = TagResourcesRequestMarshaller.Instance;
            var unmarshaller = TagResourcesResponseUnmarshaller.Instance;

            return Invoke<TagResourcesRequest,TagResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResources operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        public virtual IAsyncResult BeginTagResources(TagResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TagResourcesRequestMarshaller.Instance;
            var unmarshaller = TagResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<TagResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResources.</param>
        /// 
        /// <returns>Returns a  TagResourcesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        public virtual TagResourcesResponse EndTagResources(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResources

        /// <summary>
        /// Removes the specified tags from the specified resources. When you specify a tag key,
        /// the action removes both that key and its associated value. The operation succeeds
        /// even if you attempt to remove tags from a resource that were already removed. Note
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To remove tags from a resource, you need the necessary permissions for the service
        /// that the resource belongs to as well as permissions for removing tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/obtaining-permissions-for-tagging.html">Obtaining
        /// Permissions for Tagging</a> in the <i>AWS Resource Groups and Tag Editor User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified region for the AWS account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResources service method.</param>
        /// 
        /// <returns>The response from the UntagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// A parameter is missing or a malformed string or invalid or out-of-range value was
        /// supplied for the request parameter.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        public virtual UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            var marshaller = UntagResourcesRequestMarshaller.Instance;
            var unmarshaller = UntagResourcesResponseUnmarshaller.Instance;

            return Invoke<UntagResourcesRequest,UntagResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResources operation on AmazonResourceGroupsTaggingAPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        public virtual IAsyncResult BeginUntagResources(UntagResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UntagResourcesRequestMarshaller.Instance;
            var unmarshaller = UntagResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<UntagResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResources.</param>
        /// 
        /// <returns>Returns a  UntagResourcesResult from ResourceGroupsTaggingAPI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        public virtual UntagResourcesResponse EndUntagResources(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourcesResponse>(asyncResult);
        }

        #endregion
        
    }
}