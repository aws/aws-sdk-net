/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.Glacier.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.Glacier
{
    /// <summary>
    /// Implementation for accessing AmazonGlacier.
    ///  
    /// <para>Amazon Glacier is a storage solution for "cold data."</para> <para>Amazon Glacier is an extremely low-cost storage service that
    /// provides secure, durable, and easy-to-use storage for data backup and archival. With Amazon Glacier, customers can store their data cost
    /// effectively for months, years, or decades. Amazon Glacier also enables customers to offload the administrative burdens of operating and
    /// scaling storage to AWS, so they don't have to worry about capacity planning, hardware provisioning, data replication, hardware failure and
    /// recovery, or time-consuming hardware migrations.</para> <para>Amazon Glacier is a great storage choice when low storage cost is paramount,
    /// your data is rarely retrieved, and retrieval latency of several hours is acceptable. If your application requires fast or frequent access to
    /// your data, consider using Amazon S3. For more information, go to Amazon Simple Storage Service (Amazon S3).</para> <para>You can store any
    /// kind of data in any format. There is no maximum limit on the total amount of data you can store in Amazon Glacier. </para> <para>If you are
    /// a first-time user of Amazon Glacier, we recommend that you begin by reading the following sections in the <i>Amazon Glacier Developer
    /// Guide</i> :</para>
    /// <ul>
    /// <li> <para> What is Amazon Glacier - This section of the Developer Guide describes the underlying data model, the operations it supports,
    /// and the AWS SDKs that you can use to interact with the service.</para> </li>
    /// <li> <para> Getting Started with Amazon Glacier - The Getting Started section walks you through the process of creating a vault, uploading
    /// archives, creating jobs to download archives, retrieving the job output, and deleting archives.</para> </li>
    /// 
    /// </ul>
    /// </summary>
    public class AmazonGlacierClient : AmazonWebServiceClient, AmazonGlacier
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonGlacierClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlacierConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlacierConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonGlacier Configuration Object</param>
        public AmazonGlacierClient(AmazonGlacierConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlacierClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlacierConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials and an
        /// AmazonGlacierClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(AWSCredentials credentials, AmazonGlacierConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlacierConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlacierClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlacierConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlacierConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlacierClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlacierConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
   
        #region ListVaults

        /// <summary>
        /// <para>This operation lists all vaults owned by the calling user's account. The list returned in the response is ASCII-sorted by vault name.
        /// </para> <para>By default, this operation returns up to 1,000 items. If there are more vaults to list, the response <c>marker</c> field
        /// contains the vault Amazon Resource Name (ARN) at which to continue the list with a new List Vaults request; otherwise, the <c>marker</c>
        /// field is <c>null</c> . To return a list of vaults that begins at a specific vault, set the <c>marker</c> request parameter to the vault ARN
        /// you obtained from a previous List Vaults request. You can also limit the number of vaults returned in the response by specifying the
        /// <c>limit</c> parameter in the request. </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform
        /// specific actions. For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual
        /// information and underlying REST API, go to Retrieving Vault Metadata in Amazon Glacier and List Vaults in the <i>Amazon Glacier Developer
        /// Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="listVaultsRequest">Container for the necessary parameters to execute the ListVaults service method on AmazonGlacier.</param>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public ListVaultsResponse ListVaults(ListVaultsRequest listVaultsRequest)
        {
            IAsyncResult asyncResult = invokeListVaults(listVaultsRequest, null, null, true);
            return EndListVaults(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListVaults operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListVaults"/>
        /// </summary>
        /// 
        /// <param name="listVaultsRequest">Container for the necessary parameters to execute the ListVaults operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVaults
        ///         operation.</returns>
        public IAsyncResult BeginListVaults(ListVaultsRequest listVaultsRequest, AsyncCallback callback, object state)
        {
            return invokeListVaults(listVaultsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListVaults operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListVaults"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVaults.</param>
        /// 
        /// <returns>Returns a ListVaultsResult from AmazonGlacier.</returns>
        public ListVaultsResponse EndListVaults(IAsyncResult asyncResult)
        {
            return endOperation<ListVaultsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListVaults(ListVaultsRequest listVaultsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListVaultsRequestMarshaller().Marshall(listVaultsRequest);
            var unmarshaller = ListVaultsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>This operation lists all vaults owned by the calling user's account. The list returned in the response is ASCII-sorted by vault name.
        /// </para> <para>By default, this operation returns up to 1,000 items. If there are more vaults to list, the response <c>marker</c> field
        /// contains the vault Amazon Resource Name (ARN) at which to continue the list with a new List Vaults request; otherwise, the <c>marker</c>
        /// field is <c>null</c> . To return a list of vaults that begins at a specific vault, set the <c>marker</c> request parameter to the vault ARN
        /// you obtained from a previous List Vaults request. You can also limit the number of vaults returned in the response by specifying the
        /// <c>limit</c> parameter in the request. </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform
        /// specific actions. For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual
        /// information and underlying REST API, go to Retrieving Vault Metadata in Amazon Glacier and List Vaults in the <i>Amazon Glacier Developer
        /// Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public ListVaultsResponse ListVaults()
        {
            return ListVaults(new ListVaultsRequest());
        }
        

        #endregion
    
        #region DescribeJob

        /// <summary>
        /// <para>This operation returns information about a job you previously initiated, including the job initiation date, the user who initiated the
        /// job, the job status code/message and the Amazon SNS topic to notify after Amazon Glacier completes the job. For more information about
        /// initiating a job, see InitiateJob. </para> <para><b>NOTE:</b> This operation enables you to check the status of your job. However, it is
        /// strongly recommended that you set up an Amazon SNS topic and specify it in your initiate job request so that Amazon Glacier can notify the
        /// topic after it completes the job. </para> <para>A job ID will not expire for at least 24 hours after Amazon Glacier completes the job.
        /// </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM)
        /// users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see
        /// Access Control Using AWS Identity and Access Management (IAM).</para> <para> For information about the underlying REST API, go to Working
        /// with Archives in Amazon Glacier in the <i>Amazon Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeJobRequest">Container for the necessary parameters to execute the DescribeJob service method on AmazonGlacier.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public DescribeJobResponse DescribeJob(DescribeJobRequest describeJobRequest)
        {
            IAsyncResult asyncResult = invokeDescribeJob(describeJobRequest, null, null, true);
            return EndDescribeJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DescribeJob"/>
        /// </summary>
        /// 
        /// <param name="describeJobRequest">Container for the necessary parameters to execute the DescribeJob operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJob
        ///         operation.</returns>
        public IAsyncResult BeginDescribeJob(DescribeJobRequest describeJobRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeJob(describeJobRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeJob operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DescribeJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJob.</param>
        /// 
        /// <returns>Returns a DescribeJobResult from AmazonGlacier.</returns>
        public DescribeJobResponse EndDescribeJob(IAsyncResult asyncResult)
        {
            return endOperation<DescribeJobResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeJob(DescribeJobRequest describeJobRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeJobRequestMarshaller().Marshall(describeJobRequest);
            var unmarshaller = DescribeJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListParts

        /// <summary>
        /// <para>This operation lists the parts of an archive that have been uploaded in a specific multipart upload. You can make this request at any
        /// time during an in-progress multipart upload before you complete the upload (see CompleteMultipartUpload. List Parts returns an error for
        /// completed uploads. The list returned in the List Parts response is sorted by part range. </para> <para>The List Parts operation supports
        /// pagination. By default, this operation returns up to 1,000 uploaded parts in the response. You should always check the response for a
        /// <c>marker</c> at which to continue the list; if there are no more items the <c>marker</c> is <c>null</c> .
        /// To return a list of parts that begins at a specific part, set the <c>marker</c> request parameter to the value you obtained from a
        /// previous List Parts request. You can also limit the number of parts returned in the response by specifying the <c>limit</c> parameter in the
        /// request. </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management
        /// (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more
        /// information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and the underlying
        /// REST API, go to Working with Archives in Amazon Glacier and List Parts in the <i>Amazon Glacier Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts service method on AmazonGlacier.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public ListPartsResponse ListParts(ListPartsRequest listPartsRequest)
        {
            IAsyncResult asyncResult = invokeListParts(listPartsRequest, null, null, true);
            return EndListParts(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListParts"/>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParts
        ///         operation.</returns>
        public IAsyncResult BeginListParts(ListPartsRequest listPartsRequest, AsyncCallback callback, object state)
        {
            return invokeListParts(listPartsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListParts"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// 
        /// <returns>Returns a ListPartsResult from AmazonGlacier.</returns>
        public ListPartsResponse EndListParts(IAsyncResult asyncResult)
        {
            return endOperation<ListPartsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListParts(ListPartsRequest listPartsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPartsRequestMarshaller().Marshall(listPartsRequest);
            var unmarshaller = ListPartsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetVaultNotifications

        /// <summary>
        /// <para>This operation retrieves the <c>notification-configuration</c> subresource of the specified vault.</para> <para>For information about
        /// setting a notification configuration on a vault, see SetVaultNotifications. If a notification configuration for a vault is not set, the
        /// operation returns a <c>404 Not Found</c> error. For more information about vault notifications, see Configuring Vault Notifications in
        /// Amazon Glacier. </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access
        /// Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more
        /// information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and underlying REST
        /// API, go to Configuring Vault Notifications in Amazon Glacier and Get Vault Notification Configuration in the <i>Amazon Glacier Developer
        /// Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getVaultNotificationsRequest">Container for the necessary parameters to execute the GetVaultNotifications service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the GetVaultNotifications service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public GetVaultNotificationsResponse GetVaultNotifications(GetVaultNotificationsRequest getVaultNotificationsRequest)
        {
            IAsyncResult asyncResult = invokeGetVaultNotifications(getVaultNotificationsRequest, null, null, true);
            return EndGetVaultNotifications(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.GetVaultNotifications"/>
        /// </summary>
        /// 
        /// <param name="getVaultNotificationsRequest">Container for the necessary parameters to execute the GetVaultNotifications operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetVaultNotifications operation.</returns>
        public IAsyncResult BeginGetVaultNotifications(GetVaultNotificationsRequest getVaultNotificationsRequest, AsyncCallback callback, object state)
        {
            return invokeGetVaultNotifications(getVaultNotificationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.GetVaultNotifications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVaultNotifications.</param>
        /// 
        /// <returns>Returns a GetVaultNotificationsResult from AmazonGlacier.</returns>
        public GetVaultNotificationsResponse EndGetVaultNotifications(IAsyncResult asyncResult)
        {
            return endOperation<GetVaultNotificationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetVaultNotifications(GetVaultNotificationsRequest getVaultNotificationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetVaultNotificationsRequestMarshaller().Marshall(getVaultNotificationsRequest);
            var unmarshaller = GetVaultNotificationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListJobs

        /// <summary>
        /// <para>This operation lists jobs for a vault, including jobs that are in-progress and jobs that have recently finished. </para>
        /// <para><b>NOTE:</b> Amazon Glacier retains recently completed jobs for a period before deleting them; however, it eventually removes
        /// completed jobs. The output of completed jobs can be retrieved. Retaining completed jobs for a period of time after they have completed
        /// enables you to get a job output in the event you miss the job completion notification or your first attempt to download it fails. For
        /// example, suppose you start an archive retrieval job to download an archive. After the job completes, you start to download the archive but
        /// encounter a network error. In this scenario, you can retry and download the archive while the job exists. </para> <para>To retrieve an
        /// archive or retrieve a vault inventory from Amazon Glacier, you first initiate a job, and after the job completes, you download the data. For
        /// an archive retrieval, the output is the archive data, and for an inventory retrieval, it is the inventory list. The List Job operation
        /// returns a list of these jobs sorted by job initiation time.</para> <para>This List Jobs operation supports pagination. By default, this
        /// operation returns up to 1,000 jobs in the response. You should always check the response for a <c>marker</c> at which to continue the list;
        /// if there are no more items the <c>marker</c> is <c>null</c> .
        /// To return a list of jobs that begins at a specific job, set the <c>marker</c> request parameter to the value you obtained from a
        /// previous List Jobs request. You can also limit the number of jobs returned in the response by specifying the <c>limit</c> parameter in the
        /// request.</para> <para>Additionally, you can filter the jobs list returned by specifying an optional <c>statuscode</c> (InProgress,
        /// Succeeded, or Failed) and <c>completed</c> (true, false) parameter. The <c>statuscode</c> allows you to specify that only jobs that match a
        /// specified status are returned. The <c>completed</c> parameter allows you to specify that only jobs in a specific completion state are
        /// returned.</para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management
        /// (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more
        /// information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For the underlying REST API, go to List Jobs
        /// </para>
        /// </summary>
        /// 
        /// <param name="listJobsRequest">Container for the necessary parameters to execute the ListJobs service method on AmazonGlacier.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            IAsyncResult asyncResult = invokeListJobs(listJobsRequest, null, null, true);
            return EndListJobs(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListJobs"/>
        /// </summary>
        /// 
        /// <param name="listJobsRequest">Container for the necessary parameters to execute the ListJobs operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        public IAsyncResult BeginListJobs(ListJobsRequest listJobsRequest, AsyncCallback callback, object state)
        {
            return invokeListJobs(listJobsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListJobs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a ListJobsResult from AmazonGlacier.</returns>
        public ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return endOperation<ListJobsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListJobs(ListJobsRequest listJobsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListJobsRequestMarshaller().Marshall(listJobsRequest);
            var unmarshaller = ListJobsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateVault

        /// <summary>
        /// <para>This operation creates a new vault with the specified name. The name of the vault must be unique within a region for an AWS account.
        /// You can create up to 1,000 vaults per account. If you need to create more vaults, contact Amazon Glacier.</para> <para>You must use the
        /// following guidelines when naming a vault. </para> <para>
        /// <ul>
        /// <li> <para> Names can be between 1 and 255 characters long. </para> </li>
        /// <li> <para>Allowed characters are a-z, A-Z, 0-9, '_' (underscore), '-' (hyphen), and '.' (period).</para> </li>
        /// 
        /// </ul>
        /// </para> <para>This operation is idempotent.</para> <para>An AWS account has full permission to perform all operations (actions). However,
        /// AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform
        /// specific actions. For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para> For conceptual
        /// information and underlying REST API, go to Creating a Vault in Amazon Glacier and Create Vault in the <i>Amazon Glacier Developer Guide</i>
        /// .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createVaultRequest">Container for the necessary parameters to execute the CreateVault service method on AmazonGlacier.</param>
        /// 
        /// <returns>The response from the CreateVault service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="LimitExceededException"/>
        public CreateVaultResponse CreateVault(CreateVaultRequest createVaultRequest)
        {
            IAsyncResult asyncResult = invokeCreateVault(createVaultRequest, null, null, true);
            return EndCreateVault(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVault operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.CreateVault"/>
        /// </summary>
        /// 
        /// <param name="createVaultRequest">Container for the necessary parameters to execute the CreateVault operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVault
        ///         operation.</returns>
        public IAsyncResult BeginCreateVault(CreateVaultRequest createVaultRequest, AsyncCallback callback, object state)
        {
            return invokeCreateVault(createVaultRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVault operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.CreateVault"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVault.</param>
        /// 
        /// <returns>Returns a CreateVaultResult from AmazonGlacier.</returns>
        public CreateVaultResponse EndCreateVault(IAsyncResult asyncResult)
        {
            return endOperation<CreateVaultResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateVault(CreateVaultRequest createVaultRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateVaultRequestMarshaller().Marshall(createVaultRequest);
            var unmarshaller = CreateVaultResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region InitiateMultipartUpload

        /// <summary>
        /// <para>This operation initiates a multipart upload. Amazon Glacier creates a multipart upload resource and returns its ID in the response.
        /// The multipart upload ID is used in subsequent requests to upload parts of an archive (see UploadMultipartPart).</para> <para>When you
        /// initiate a multipart upload, you specify the part size in number of bytes. The part size must be a megabyte (1024 KB) multiplied by a power
        /// of 2-for example, 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum allowable part size is 1 MB, and
        /// the maximum is 4 GB.</para> <para>Every part you upload to this resource (see UploadMultipartPart), except the last one, must have the same
        /// size. The last one can be the same size or smaller. For example, suppose you want to upload a 16.2 MB file. If you initiate the multipart
        /// upload with a part size of 4 MB, you will upload four parts of 4 MB each and one part of 0.2 MB. </para> <para><b>NOTE:</b> You don't need
        /// to know the size of the archive when you start a multipart upload because Amazon Glacier does not require you to specify the overall archive
        /// size. </para> <para>After you complete the multipart upload, Amazon Glacier removes the multipart upload resource referenced by the ID.
        /// Amazon Glacier also removes the multipart upload resource if you cancel the multipart upload or it may be removed if there is no activity
        /// for a period of 24 hours.</para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and
        /// Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions.
        /// For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and
        /// underlying REST API, go to Uploading Large Archives in Parts (Multipart Upload) and Initiate Multipart Upload in the <i>Amazon Glacier
        /// Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest)
        {
            IAsyncResult asyncResult = invokeInitiateMultipartUpload(initiateMultipartUploadRequest, null, null, true);
            return EndInitiateMultipartUpload(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.InitiateMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndInitiateMultipartUpload operation.</returns>
        public IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest, AsyncCallback callback, object state)
        {
            return invokeInitiateMultipartUpload(initiateMultipartUploadRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.InitiateMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// 
        /// <returns>Returns a InitiateMultipartUploadResult from AmazonGlacier.</returns>
        public InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<InitiateMultipartUploadResponse>(asyncResult);
        }
        
        IAsyncResult invokeInitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new InitiateMultipartUploadRequestMarshaller().Marshall(initiateMultipartUploadRequest);
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AbortMultipartUpload

        /// <summary>
        /// <para>This operation aborts a multipart upload identified by the upload ID.</para> <para>After the Abort Multipart Upload request succeeds,
        /// you cannot upload any more parts to the multipart upload or complete the multipart upload. Aborting a completed upload fails. However,
        /// aborting an already-aborted upload will succeed, for a short time. For more information about uploading a part and completing a multipart
        /// upload, see UploadPart and CompleteMultipartUpload.</para> <para>This operation is idempotent.</para> <para>An AWS account has full
        /// permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by
        /// default. You must grant them explicit permission to perform specific actions. For more information, see Access Control Using AWS Identity
        /// and Access Management (IAM).</para> <para> For conceptual information and underlying REST API, go to Working with Archives in Amazon Glacier
        /// and Abort Multipart Upload in the <i>Amazon Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest)
        {
            IAsyncResult asyncResult = invokeAbortMultipartUpload(abortMultipartUploadRequest, null, null, true);
            return EndAbortMultipartUpload(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.AbortMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest, AsyncCallback callback, object state)
        {
            return invokeAbortMultipartUpload(abortMultipartUploadRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.AbortMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        public AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<AbortMultipartUploadResponse>(asyncResult);
        }
        
        IAsyncResult invokeAbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AbortMultipartUploadRequestMarshaller().Marshall(abortMultipartUploadRequest);
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteArchive

        /// <summary>
        /// <para>This operation deletes an archive from a vault. Subsequent requests to initiate a retrieval of this archive will fail. Archive
        /// retrievals that are in progress for this archive ID may or may not succeed according to the following scenarios:</para>
        /// <ul>
        /// <li>If the archive retrieval job is actively preparing the data for download when Amazon Glacier receives the delete archive request, the
        /// archival retrieval operation might fail. </li>
        /// <li>If the archive retrieval job has successfully prepared the archive for download when Amazon Glacier receives the delete archive
        /// request, you will be able to download the output. </li>
        /// 
        /// </ul>
        /// <para>This operation is idempotent. Attempting to delete an already-deleted archive does not result in an error. </para> <para>An AWS
        /// account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any
        /// permissions by default. You must grant them explicit permission to perform specific actions. For more information, see Access Control Using
        /// AWS Identity and Access Management (IAM).</para> <para> For conceptual information and underlying REST API, go to Deleting an Archive in
        /// Amazon Glacier and Delete Archive in the <i>Amazon Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteArchiveRequest">Container for the necessary parameters to execute the DeleteArchive service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest deleteArchiveRequest)
        {
            IAsyncResult asyncResult = invokeDeleteArchive(deleteArchiveRequest, null, null, true);
            return EndDeleteArchive(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchive operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DeleteArchive"/>
        /// </summary>
        /// 
        /// <param name="deleteArchiveRequest">Container for the necessary parameters to execute the DeleteArchive operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteArchive(DeleteArchiveRequest deleteArchiveRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteArchive(deleteArchiveRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteArchive operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DeleteArchive"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArchive.</param>
        public DeleteArchiveResponse EndDeleteArchive(IAsyncResult asyncResult)
        {
            return endOperation<DeleteArchiveResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteArchive(DeleteArchiveRequest deleteArchiveRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteArchiveRequestMarshaller().Marshall(deleteArchiveRequest);
            var unmarshaller = DeleteArchiveResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetJobOutput

        /// <summary>
        /// <para>This operation downloads the output of the job you initiated using InitiateJob. Depending on the job type you specified when you
        /// initiated the job, the output will be either the content of an archive or a vault inventory.</para> <para>A job ID will not expire for at
        /// least 24 hours after Amazon Glacier completes the job. That is, you can download the job output within the 24 hours period after Amazon
        /// Glacier completes the job.</para> <para>If the job output is large, then you can use the <c>Range</c> request header to retrieve a portion
        /// of the output. This allows you to download the entire output in smaller chunks of bytes. For example, suppose you have 1 GB of job output
        /// you want to download and you decide to download 128 MB chunks of data at a time, which is a total of eight Get Job Output requests. You use
        /// the following process to download the job output:</para> <ol> <li> <para>Download a 128 MB chunk of output by specifying the appropriate
        /// byte range using the <c>Range</c> header.</para> </li>
        /// <li> <para>Along with the data, the response includes a checksum of the payload. You compute the checksum of the payload on the client and
        /// compare it with the checksum you received in the response to ensure you received all the expected data.</para> </li>
        /// <li> <para>Repeat steps 1 and 2 for all the eight 128 MB chunks of output data, each time specifying the appropriate byte range.</para>
        /// </li>
        /// <li> <para>After downloading all the parts of the job output, you have a list of eight checksum values. Compute the tree hash of these
        /// values to find the checksum of the entire output. Using the Describe Job API, obtain job information of the job that provided you the
        /// output. The response includes the checksum of the entire archive stored in Amazon Glacier. You compare this value with the checksum you
        /// computed to ensure you have downloaded the entire archive content with no errors.</para> </li>
        /// </ol> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users
        /// don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see Access
        /// Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and the underlying REST API, go to
        /// Downloading a Vault Inventory, Downloading an Archive, and Get Job Output </para>
        /// </summary>
        /// 
        /// <param name="getJobOutputRequest">Container for the necessary parameters to execute the GetJobOutput service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the GetJobOutput service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public GetJobOutputResponse GetJobOutput(GetJobOutputRequest getJobOutputRequest)
        {
            IAsyncResult asyncResult = invokeGetJobOutput(getJobOutputRequest, null, null, true);
            return EndGetJobOutput(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobOutput operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.GetJobOutput"/>
        /// </summary>
        /// 
        /// <param name="getJobOutputRequest">Container for the necessary parameters to execute the GetJobOutput operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobOutput
        ///         operation.</returns>
        public IAsyncResult BeginGetJobOutput(GetJobOutputRequest getJobOutputRequest, AsyncCallback callback, object state)
        {
            return invokeGetJobOutput(getJobOutputRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetJobOutput operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.GetJobOutput"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobOutput.</param>
        /// 
        /// <returns>Returns a GetJobOutputResult from AmazonGlacier.</returns>
        public GetJobOutputResponse EndGetJobOutput(IAsyncResult asyncResult)
        {
            return endOperation<GetJobOutputResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetJobOutput(GetJobOutputRequest getJobOutputRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetJobOutputRequestMarshaller().Marshall(getJobOutputRequest);
            var unmarshaller = GetJobOutputResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region InitiateJob

        /// <summary>
        /// <para>This operation initiates a job of the specified type. In this release, you can initiate a job to retrieve either an archive or a vault
        /// inventory (a list of archives in a vault). </para> <para>Retrieving data from Amazon Glacier is a two-step process: </para> <ol> <li>
        /// <para>Initiate a retrieval job.</para> </li>
        /// <li> <para>After the job completes, download the bytes.</para> </li>
        /// </ol> <para>The retrieval request is executed asynchronously. When you initiate a retrieval job, Amazon Glacier creates a job and returns a
        /// job ID in the response. When Amazon Glacier completes the job, you can get the job output (archive or inventory data). For information about
        /// getting job output, see GetJobOutput operation. </para> <para>The job must complete before you can get its output. To determine when a job
        /// is complete, you have the following options:</para>
        /// <ul>
        /// <li> <para> <b>Use Amazon SNS Notification</b> You can specify an Amazon Simple Notification Service (Amazon SNS) topic to which Amazon
        /// Glacier can post a notification after the job is completed. You can specify an SNS topic per job request. The notification is sent only
        /// after Amazon Glacier completes the job. In addition to specifying an SNS topic per job request, you can configure vault notifications for a
        /// vault so that job notifications are always sent. For more information, see SetVaultNotificationConfiguration.</para> </li>
        /// <li> <para> <b>Get job details</b> You can make a DescribeJob request to obtain job status information while a job is in progress. However,
        /// it is more efficient to use an Amazon SNS notification to determine when a job is complete.</para> </li>
        /// 
        /// </ul>
        /// <para><b>NOTE:</b> The information you get via notification is same that you get by calling DescribeJob. </para> <para>If for a specific
        /// event, you add both the notification configuration on the vault and also specify an SNS topic in your initiate job request, Amazon Glacier
        /// sends both notifications. For more information, see SetVaultNotificationConfiguration.</para> <para>An AWS account has full permission to
        /// perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must
        /// grant them explicit permission to perform specific actions. For more information, see Access Control Using AWS Identity and Access
        /// Management (IAM).</para> <para> <b>About the Vault Inventory</b> </para> <para>Amazon Glacier prepares an inventory for each vault
        /// periodically, every 24 hours. When you initiate a job for a vault inventory, Amazon Glacier returns the last inventory for the vault. The
        /// inventory data you get might be up to a day or two days old. Also, the initiate inventory job might take some time to complete before you
        /// can download the vault inventory. So you do not want to retrieve a vault inventory for each vault operation. However, in some scenarios, you
        /// might find the vault inventory useful. For example, when you upload an archive, you can provide an archive description but not an archive
        /// name. Amazon Glacier provides you a unique archive ID, an opaque string of characters. So, you might maintain your own database that maps
        /// archive names to their corresponding Amazon Glacier assigned archive IDs. You might find the vault inventory useful in the event you need to
        /// reconcile information in your database with the actual vault inventory. </para> <para>An AWS account has full permission to perform all
        /// operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them
        /// explicit permission to perform specific actions. For more information, see Access Control Using AWS Identity and Access Management
        /// (IAM).</para> <para>For conceptual information and the underlying REST API, go to Initiate a Job and Downloading a Vault Inventory </para>
        /// </summary>
        /// 
        /// <param name="initiateJobRequest">Container for the necessary parameters to execute the InitiateJob service method on AmazonGlacier.</param>
        /// 
        /// <returns>The response from the InitiateJob service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public InitiateJobResponse InitiateJob(InitiateJobRequest initiateJobRequest)
        {
            IAsyncResult asyncResult = invokeInitiateJob(initiateJobRequest, null, null, true);
            return EndInitiateJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateJob operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.InitiateJob"/>
        /// </summary>
        /// 
        /// <param name="initiateJobRequest">Container for the necessary parameters to execute the InitiateJob operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateJob
        ///         operation.</returns>
        public IAsyncResult BeginInitiateJob(InitiateJobRequest initiateJobRequest, AsyncCallback callback, object state)
        {
            return invokeInitiateJob(initiateJobRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the InitiateJob operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.InitiateJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateJob.</param>
        /// 
        /// <returns>Returns a InitiateJobResult from AmazonGlacier.</returns>
        public InitiateJobResponse EndInitiateJob(IAsyncResult asyncResult)
        {
            return endOperation<InitiateJobResponse>(asyncResult);
        }
        
        IAsyncResult invokeInitiateJob(InitiateJobRequest initiateJobRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new InitiateJobRequestMarshaller().Marshall(initiateJobRequest);
            var unmarshaller = InitiateJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UploadArchive

        /// <summary>
        /// <para>This operation adds an archive to a vault. This is a synchronous operation, and for a successful upload, your data is durably
        /// persisted. Amazon Glacier returns the archive ID in the <c>x-amz-archive-id</c> header of the response. </para> <para>You must use the
        /// archive ID to access your data in Amazon Glacier. After you upload an archive, you should save the archive ID returned so that you can
        /// retrieve or delete the archive later. Besides saving the archive ID, you can also index it and give it a friendly name to allow for better
        /// searching. You can also use the optional archive description field to specify how the archive is referred to in an external index of
        /// archives, such as you might create in Amazon DynamoDB. You can also get the vault inventory to obtain a list of archive IDs in a vault. For
        /// more information, see InitiateJob. </para> <para>You must provide a SHA256 tree hash of the data you are uploading. For information about
        /// computing a SHA256 tree hash, see Computing Checksums. </para> <para>You can optionally specify an archive description of up to 1,024
        /// printable ASCII characters. You can get the archive description when you either retrieve the archive or get the vault inventory. For more
        /// information, see InitiateJob. Amazon Glacier does not interpret the description in any way. An archive description does not need to be
        /// unique. You cannot use the description to retrieve or sort the archive list. </para> <para>Archives are immutable. After you upload an
        /// archive, you cannot edit the archive or its description. </para> <para>An AWS account has full permission to perform all operations
        /// (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them explicit
        /// permission to perform specific actions. For more information, see Access Control Using AWS Identity and Access Management (IAM).</para>
        /// <para> For conceptual information and underlying REST API, go to Uploading an Archive in Amazon Glacier and Upload Archive in the <i>Amazon
        /// Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="uploadArchiveRequest">Container for the necessary parameters to execute the UploadArchive service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the UploadArchive service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="RequestTimeoutException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public UploadArchiveResponse UploadArchive(UploadArchiveRequest uploadArchiveRequest)
        {
            IAsyncResult asyncResult = invokeUploadArchive(uploadArchiveRequest, null, null, true);
            return EndUploadArchive(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UploadArchive operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.UploadArchive"/>
        /// </summary>
        /// 
        /// <param name="uploadArchiveRequest">Container for the necessary parameters to execute the UploadArchive operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadArchive
        ///         operation.</returns>
        public IAsyncResult BeginUploadArchive(UploadArchiveRequest uploadArchiveRequest, AsyncCallback callback, object state)
        {
            return invokeUploadArchive(uploadArchiveRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UploadArchive operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.UploadArchive"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadArchive.</param>
        /// 
        /// <returns>Returns a UploadArchiveResult from AmazonGlacier.</returns>
        public UploadArchiveResponse EndUploadArchive(IAsyncResult asyncResult)
        {
            return endOperation<UploadArchiveResponse>(asyncResult);
        }
        
        IAsyncResult invokeUploadArchive(UploadArchiveRequest uploadArchiveRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UploadArchiveRequestMarshaller().Marshall(uploadArchiveRequest);
            var unmarshaller = UploadArchiveResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetVaultNotifications

        /// <summary>
        /// <para>This operation configures notifications that will be sent when specific events happen to a vault. By default, you don't get any
        /// notifications. </para> <para>To configure vault notifications, send a PUT request to the <c>notification-configuration</c> subresource of
        /// the vault. The request should include a JSON document that provides an Amazon SNS topic and specific events for which you want Amazon
        /// Glacier to send notifications to the topic.</para> <para>Amazon SNS topics must grant permission to the vault to be allowed to publish
        /// notifications to the topic. You can configure a vault to publish a notification for the following vault events:</para>
        /// <ul>
        /// <li> <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was initiated for an archive retrieval is completed (InitiateJob).
        /// The status of the completed job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the same output as returned from
        /// DescribeJob. </li>
        /// <li> <b>InventoryRetrievalCompleted</b> This event occurs when a job that was initiated for an inventory retrieval is completed
        /// (InitiateJob). The status of the completed job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the same output as
        /// returned from DescribeJob. </li>
        /// 
        /// </ul>
        /// <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't
        /// have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see Access
        /// Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and underlying REST API, go to Configuring
        /// Vault Notifications in Amazon Glacier and Set Vault Notification Configuration in the <i>Amazon Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="setVaultNotificationsRequest">Container for the necessary parameters to execute the SetVaultNotifications service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public SetVaultNotificationsResponse SetVaultNotifications(SetVaultNotificationsRequest setVaultNotificationsRequest)
        {
            IAsyncResult asyncResult = invokeSetVaultNotifications(setVaultNotificationsRequest, null, null, true);
            return EndSetVaultNotifications(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.SetVaultNotifications"/>
        /// </summary>
        /// 
        /// <param name="setVaultNotificationsRequest">Container for the necessary parameters to execute the SetVaultNotifications operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetVaultNotifications(SetVaultNotificationsRequest setVaultNotificationsRequest, AsyncCallback callback, object state)
        {
            return invokeSetVaultNotifications(setVaultNotificationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.SetVaultNotifications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVaultNotifications.</param>
        public SetVaultNotificationsResponse EndSetVaultNotifications(IAsyncResult asyncResult)
        {
            return endOperation<SetVaultNotificationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetVaultNotifications(SetVaultNotificationsRequest setVaultNotificationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetVaultNotificationsRequestMarshaller().Marshall(setVaultNotificationsRequest);
            var unmarshaller = SetVaultNotificationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CompleteMultipartUpload

        /// <summary>
        /// <para>You call this operation to inform Amazon Glacier that all the archive parts have been uploaded and that Amazon Glacier can now
        /// assemble the archive from the uploaded parts. After assembling and saving the archive to the vault, Amazon Glacier returns the URI path of
        /// the newly created archive resource. Using the URI path, you can then access the archive. After you upload an archive, you should save the
        /// archive ID returned to retrieve the archive at a later point. You can also get the vault inventory to obtain a list of archive IDs in a
        /// vault. For more information, see InitiateJob.</para> <para>In the request, you must include the computed SHA256 tree hash of the entire
        /// archive you have uploaded. For information about computing a SHA256 tree hash, see Computing Checksums. On the server side, Amazon Glacier
        /// also constructs the SHA256 tree hash of the assembled archive. If the values match, Amazon Glacier saves the archive to the vault;
        /// otherwise, it returns an error, and the operation fails. The ListParts operation returns a list of parts uploaded for a specific multipart
        /// upload. It includes checksum information for each uploaded part that can be used to debug a bad checksum issue.</para> <para>Additionally,
        /// Amazon Glacier also checks for any missing content ranges when assembling the archive, if missing content ranges are found, Amazon Glacier
        /// returns an error and the operation fails. </para> <para>Complete Multipart Upload is an idempotent operation. After your first successful
        /// complete multipart upload, if you call the operation again within a short period, the operation will succeed and return the same archive ID.
        /// This is useful in the event you experience a network issue that causes an aborted connection or receive a 500 server error, in which case
        /// you can repeat your Complete Multipart Upload request and get the same archive ID without creating duplicate archives. Note, however, that
        /// after the multipart upload completes, you cannot call the List Parts operation and the multipart upload will not appear in List Multipart
        /// Uploads response, even if idempotent complete is possible.</para> <para>An AWS account has full permission to perform all operations
        /// (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them explicit
        /// permission to perform specific actions. For more information, see Access Control Using AWS Identity and Access Management (IAM).</para>
        /// <para> For conceptual information and underlying REST API, go to Uploading Large Archives in Parts (Multipart Upload) and Complete Multipart
        /// Upload in the <i>Amazon Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest)
        {
            IAsyncResult asyncResult = invokeCompleteMultipartUpload(completeMultipartUploadRequest, null, null, true);
            return EndCompleteMultipartUpload(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.CompleteMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCompleteMultipartUpload operation.</returns>
        public IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest, AsyncCallback callback, object state)
        {
            return invokeCompleteMultipartUpload(completeMultipartUploadRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.CompleteMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// 
        /// <returns>Returns a CompleteMultipartUploadResult from AmazonGlacier.</returns>
        public CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<CompleteMultipartUploadResponse>(asyncResult);
        }
        
        IAsyncResult invokeCompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CompleteMultipartUploadRequestMarshaller().Marshall(completeMultipartUploadRequest);
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UploadMultipartPart

        /// <summary>
        /// <para>This operation uploads a part of an archive. You can upload archive parts in any order. You can also upload them in parallel. You can
        /// upload up to 10,000 parts for a multipart upload.</para> <para>Amazon Glacier rejects your upload part request if any of the following
        /// conditions is true:</para>
        /// <ul>
        /// <li> <para> <b>SHA256 tree hash does not match</b> To ensure that part data is not corrupted in transmission, you compute a SHA256 tree
        /// hash of the part and include it in your request. Upon receiving the part data, Amazon Glacier also computes a SHA256 tree hash. If these
        /// hash values don't match, the operation fails. For information about computing a SHA256 tree hash, see Computing Checksums.</para> </li>
        /// <li> <para> <b>Part size does not match</b> The size of each part except the last must match the size specified in the corresponding
        /// InitiateMultipartUpload request. The size of the last part must be the same size as, or smaller than, the specified size.</para>
        /// <para><b>NOTE:</b> If you upload a part whose size is smaller than the part size you specified in your initiate multipart upload request and
        /// that part is not the last part, then the upload part request will succeed. However, the subsequent Complete Multipart Upload request will
        /// fail. </para> </li>
        /// <li> <b>Range does not align</b> The byte range value in the request does not align with the part size specified in the corresponding
        /// initiate request. For example, if you specify a part size of 4194304 bytes (4 MB), then 0 to 4194303 bytes (4 MB - 1) and 4194304 (4 MB) to
        /// 8388607 (8 MB - 1) are valid part ranges. However, if you set a range value of 2 MB to 6 MB, the range does not align with the part size and
        /// the upload will fail. </li>
        /// 
        /// </ul>
        /// <para>This operation is idempotent. If you upload the same part multiple times, the data included in the most recent request overwrites the
        /// previously uploaded data.</para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and
        /// Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions.
        /// For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para> For conceptual information and
        /// underlying REST API, go to Uploading Large Archives in Parts (Multipart Upload) and Upload Part in the <i>Amazon Glacier Developer
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="uploadMultipartPartRequest">Container for the necessary parameters to execute the UploadMultipartPart service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the UploadMultipartPart service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="RequestTimeoutException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public UploadMultipartPartResponse UploadMultipartPart(UploadMultipartPartRequest uploadMultipartPartRequest)
        {
            IAsyncResult asyncResult = invokeUploadMultipartPart(uploadMultipartPartRequest, null, null, true);
            return EndUploadMultipartPart(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UploadMultipartPart operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.UploadMultipartPart"/>
        /// </summary>
        /// 
        /// <param name="uploadMultipartPartRequest">Container for the necessary parameters to execute the UploadMultipartPart operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUploadMultipartPart operation.</returns>
        public IAsyncResult BeginUploadMultipartPart(UploadMultipartPartRequest uploadMultipartPartRequest, AsyncCallback callback, object state)
        {
            return invokeUploadMultipartPart(uploadMultipartPartRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UploadMultipartPart operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.UploadMultipartPart"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadMultipartPart.</param>
        /// 
        /// <returns>Returns a UploadMultipartPartResult from AmazonGlacier.</returns>
        public UploadMultipartPartResponse EndUploadMultipartPart(IAsyncResult asyncResult)
        {
            return endOperation<UploadMultipartPartResponse>(asyncResult);
        }
        
        IAsyncResult invokeUploadMultipartPart(UploadMultipartPartRequest uploadMultipartPartRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UploadMultipartPartRequestMarshaller().Marshall(uploadMultipartPartRequest);
            var unmarshaller = UploadMultipartPartResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeVault

        /// <summary>
        /// <para>This operation returns information about a vault, including the vault's Amazon Resource Name (ARN), the date the vault was created,
        /// the number of archives it contains, and the total size of all the archives in the vault. The number of archives and their total size are as
        /// of the last inventory generation. This means that if you add or remove an archive from a vault, and then immediately use Describe Vault, the
        /// change in contents will not be immediately reflected. If you want to retrieve the latest inventory of the vault, use InitiateJob. Amazon
        /// Glacier generates vault inventories approximately daily. For more information, see Downloading a Vault Inventory in Amazon Glacier. </para>
        /// <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't
        /// have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see Access
        /// Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and underlying REST API, go to Retrieving
        /// Vault Metadata in Amazon Glacier and Describe Vault in the <i>Amazon Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeVaultRequest">Container for the necessary parameters to execute the DescribeVault service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the DescribeVault service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public DescribeVaultResponse DescribeVault(DescribeVaultRequest describeVaultRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVault(describeVaultRequest, null, null, true);
            return EndDescribeVault(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVault operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DescribeVault"/>
        /// </summary>
        /// 
        /// <param name="describeVaultRequest">Container for the necessary parameters to execute the DescribeVault operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVault
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVault(DescribeVaultRequest describeVaultRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVault(describeVaultRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVault operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DescribeVault"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVault.</param>
        /// 
        /// <returns>Returns a DescribeVaultResult from AmazonGlacier.</returns>
        public DescribeVaultResponse EndDescribeVault(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVaultResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVault(DescribeVaultRequest describeVaultRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVaultRequestMarshaller().Marshall(describeVaultRequest);
            var unmarshaller = DescribeVaultResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVaultNotifications

        /// <summary>
        /// <para>This operation deletes the notification configuration set for a vault. The operation is eventually consistent;that is, it might take
        /// some time for Amazon Glacier to completely disable the notifications and you might still receive some notifications for a short time after
        /// you send the delete request. </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and
        /// Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions.
        /// For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para> For conceptual information and
        /// underlying REST API, go to Configuring Vault Notifications in Amazon Glacier and Delete Vault Notification Configuration in the Amazon
        /// Glacier Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="deleteVaultNotificationsRequest">Container for the necessary parameters to execute the DeleteVaultNotifications service method
        ///          on AmazonGlacier.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public DeleteVaultNotificationsResponse DeleteVaultNotifications(DeleteVaultNotificationsRequest deleteVaultNotificationsRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVaultNotifications(deleteVaultNotificationsRequest, null, null, true);
            return EndDeleteVaultNotifications(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DeleteVaultNotifications"/>
        /// </summary>
        /// 
        /// <param name="deleteVaultNotificationsRequest">Container for the necessary parameters to execute the DeleteVaultNotifications operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVaultNotifications(DeleteVaultNotificationsRequest deleteVaultNotificationsRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVaultNotifications(deleteVaultNotificationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVaultNotifications operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DeleteVaultNotifications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVaultNotifications.</param>
        public DeleteVaultNotificationsResponse EndDeleteVaultNotifications(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVaultNotificationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVaultNotifications(DeleteVaultNotificationsRequest deleteVaultNotificationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVaultNotificationsRequestMarshaller().Marshall(deleteVaultNotificationsRequest);
            var unmarshaller = DeleteVaultNotificationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListMultipartUploads

        /// <summary>
        /// <para>This operation lists in-progress multipart uploads for the specified vault. An in-progress multipart upload is a multipart upload that
        /// has been initiated by an InitiateMultipartUpload request, but has not yet been completed or aborted. The list returned in the List Multipart
        /// Upload response has no guaranteed order. </para> <para>The List Multipart Uploads operation supports pagination. By default, this operation
        /// returns up to 1,000 multipart uploads in the response. You should always check the response for a <c>marker</c> at which to continue the
        /// list; if there are no more items the <c>marker</c> is <c>null</c> .
        /// To return a list of multipart uploads that begins at a specific upload, set the <c>marker</c> request parameter to the value you
        /// obtained from a previous List Multipart Upload request. You can also limit the number of uploads returned in the response by specifying the
        /// <c>limit</c> parameter in the request.</para> <para>Note the difference between this operation and listing parts (ListParts). The List
        /// Multipart Uploads operation lists all multipart uploads for a vault and does not require a multipart upload ID. The List Parts operation
        /// requires a multipart upload ID since parts are associated with a single upload.</para> <para>An AWS account has full permission to perform
        /// all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions by default. You must grant them
        /// explicit permission to perform specific actions. For more information, see Access Control Using AWS Identity and Access Management
        /// (IAM).</para> <para>For conceptual information and the underlying REST API, go to Working with Archives in Amazon Glacier and List Multipart
        /// Uploads in the <i>Amazon Glacier Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads service method on
        ///          AmazonGlacier.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by AmazonGlacier.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest)
        {
            IAsyncResult asyncResult = invokeListMultipartUploads(listMultipartUploadsRequest, null, null, true);
            return EndListMultipartUploads(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListMultipartUploads"/>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads operation on
        ///          AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListMultipartUploads operation.</returns>
        public IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest, AsyncCallback callback, object state)
        {
            return invokeListMultipartUploads(listMultipartUploadsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListMultipartUploads"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// 
        /// <returns>Returns a ListMultipartUploadsResult from AmazonGlacier.</returns>
        public ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult)
        {
            return endOperation<ListMultipartUploadsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListMultipartUploadsRequestMarshaller().Marshall(listMultipartUploadsRequest);
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVault

        /// <summary>
        /// <para>This operation deletes a vault. Amazon Glacier will delete a vault only if there are no archives in the vault as of the last inventory
        /// and there have been no writes to the vault since the last inventory. If either of these conditions is not satisfied, the vault deletion
        /// fails (that is, the vault is not removed) and Amazon Glacier returns an error. You can use DescribeVault to return the number of archives in
        /// a vault, and you can use Initiate a Job (POST jobs) to initiate a new inventory retrieval for a vault. The inventory contains the archive
        /// IDs you use to delete archives using Delete Archive (DELETE archive).</para> <para>This operation is idempotent.</para> <para>An AWS account
        /// has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't have any permissions
        /// by default. You must grant them explicit permission to perform specific actions. For more information, see Access Control Using AWS Identity
        /// and Access Management (IAM).</para> <para> For conceptual information and underlying REST API, go to Deleting a Vault in Amazon Glacier and
        /// Delete Vault in the <i>Amazon Glacier Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteVaultRequest">Container for the necessary parameters to execute the DeleteVault service method on AmazonGlacier.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="MissingParameterValueException"/>
        /// <exception cref="ServiceUnavailableException"/>
        /// <exception cref="InvalidParameterValueException"/>
        public DeleteVaultResponse DeleteVault(DeleteVaultRequest deleteVaultRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVault(deleteVaultRequest, null, null, true);
            return EndDeleteVault(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVault operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DeleteVault"/>
        /// </summary>
        /// 
        /// <param name="deleteVaultRequest">Container for the necessary parameters to execute the DeleteVault operation on AmazonGlacier.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVault(DeleteVaultRequest deleteVaultRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVault(deleteVaultRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVault operation.
        /// <seealso cref="Amazon.Glacier.AmazonGlacier.DeleteVault"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVault.</param>
        public DeleteVaultResponse EndDeleteVault(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVaultResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVault(DeleteVaultRequest deleteVaultRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVaultRequestMarshaller().Marshall(deleteVaultRequest);
            var unmarshaller = DeleteVaultResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        protected override void Initialize()
        {
            this.config.UseNagleAlgorithm = true;
            this.config.ResignRetries = true;
        }

        /// <summary>
        /// Add API version header
        /// </summary>
        /// <param name="request"></param>
        protected override void ProcessRequestHandlers(IRequest request)
        {
            if (request.ResourcePath != null)
            {
                if (request.ResourcePath.StartsWith("//"))
                {
                    request.ResourcePath = "/-" + request.ResourcePath.Substring(1);
                }
            }

            base.ProcessRequestHandlers(request);
            request.Headers["x-amz-glacier-version"] = "2012-06-01";
        }



    }
}
    
