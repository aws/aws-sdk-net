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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.QuickSight.Model;
using Amazon.QuickSight.Model.Internal.MarshallTransformations;
using Amazon.QuickSight.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.QuickSight
{
    /// <summary>
    /// Implementation for accessing QuickSight
    ///
    /// Amazon QuickSight API Reference 
    /// <para>
    /// Amazon QuickSight is a fully managed, serverless, cloud business intelligence service
    /// that makes it easy to extend data and insights to every user in your organization.
    /// This API interface reference contains documentation for a programming interface that
    /// you can use to manage Amazon QuickSight. 
    /// </para>
    /// </summary>
    public partial class AmazonQuickSightClient : AmazonServiceClient, IAmazonQuickSight
    {
        private static IServiceMetadata serviceMetadata = new AmazonQuickSightMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQuickSightConfig()) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQuickSightConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AmazonQuickSightConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQuickSightClient(AWSCredentials credentials)
            : this(credentials, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials and an
        /// AmazonQuickSightClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AWSCredentials credentials, AmazonQuickSightConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQuickSightConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQuickSightConfig clientConfig)
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


        #region  CancelIngestion

        /// <summary>
        /// Cancels an on-going ingestion of data into SPICE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion service method.</param>
        /// 
        /// <returns>The response from the CancelIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        public virtual CancelIngestionResponse CancelIngestion(CancelIngestionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelIngestionResponseUnmarshaller.Instance;

            return Invoke<CancelIngestionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        public virtual IAsyncResult BeginCancelIngestion(CancelIngestionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelIngestionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelIngestion.</param>
        /// 
        /// <returns>Returns a  CancelIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        public virtual CancelIngestionResponse EndCancelIngestion(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelIngestionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDashboard

        /// <summary>
        /// Creates a dashboard from a template. To first create a template, see the CreateTemplate
        /// API.
        /// 
        ///  
        /// <para>
        /// A dashboard is an entity in QuickSight which identifies Quicksight reports, created
        /// from analyses. QuickSight dashboards are sharable. With the right permissions, you
        /// can create scheduled email reports from them. The <code>CreateDashboard</code>, <code>DescribeDashboard</code>
        /// and <code>ListDashboardsByUser</code> APIs act on the dashboard entity. If you have
        /// the correct permissions, you can create a dashboard from a template that exists in
        /// a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-dashboard --cli-input-json file://create-dashboard.json</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual CreateDashboardResponse CreateDashboard(CreateDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return Invoke<CreateDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual IAsyncResult BeginCreateDashboard(CreateDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDashboard.</param>
        /// 
        /// <returns>Returns a  CreateDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual CreateDashboardResponse EndCreateDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSet

        /// <summary>
        /// Creates a dataset.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My dataset' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--import-mode=SPICE \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--physical-table-map='{</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "physical-table-id": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RelationalTable": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DataSourceArn": "arn:aws:quicksight:us-west-2:111111111111:datasource/data-source-id",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "table1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "InputColumns": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "column1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Type": "STRING"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ]</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual CreateDataSetResponse CreateDataSet(CreateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;

            return Invoke<CreateDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSet(CreateDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSet.</param>
        /// 
        /// <returns>Returns a  CreateDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual CreateDataSetResponse EndCreateDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSource

        /// <summary>
        /// Creates a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-data-source \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My Data Source' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--type=POSTGRESQL \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-parameters='{ "PostgreSqlParameters": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Host": "my-db-host.example.com",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Port": 1234,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Database": "my-db" } }' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--credentials='{ "CredentialPair": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Username": "username",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Password": "password" } }'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroup

        /// <summary>
        /// Creates an Amazon QuickSight group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group --aws-account-id=111122223333 --namespace=default
        /// --group-name="Sales-Management" --description="Sales Management - Forecasting" </code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroupMembership

        /// <summary>
        /// Adds an Amazon QuickSight user to an Amazon QuickSight group. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group member object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --member-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateGroupMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateGroupMembership(CreateGroupMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupMembership.</param>
        /// 
        /// <returns>Returns a  CreateGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual CreateGroupMembershipResponse EndCreateGroupMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIAMPolicyAssignment

        /// <summary>
        /// Creates an assignment with one specified IAM policy ARN and will assigned to specified
        /// groups or users of QuickSight. Users and groups need to be in the same namespace.
        /// 
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-iam-policy-assignment --aws-account-id=111122223333 --assignment-name=helpAssignment
        /// --policy-arn=arn:aws:iam::aws:policy/AdministratorAccess --identities="user=user5,engineer123,group=QS-Admin"
        /// --namespace=default --region=us-west-2</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the CreateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        public virtual CreateIAMPolicyAssignmentResponse CreateIAMPolicyAssignment(CreateIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<CreateIAMPolicyAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        public virtual IAsyncResult BeginCreateIAMPolicyAssignment(CreateIAMPolicyAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  CreateIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        public virtual CreateIAMPolicyAssignmentResponse EndCreateIAMPolicyAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIAMPolicyAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIngestion

        /// <summary>
        /// Creates and starts a new SPICE ingestion on a dataset
        /// 
        ///  
        /// <para>
        /// Any ingestions operating on tagged datasets inherit the same tags automatically for
        /// use in access-control. For an example, see <a href="https://aws.example.com/premiumsupport/knowledge-center/iam-ec2-resource-tags/">How
        /// do I create an IAM policy to control access to Amazon EC2 resources using tags?</a>.
        /// Tags will be visible on the tagged dataset, but not on the ingestion resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        public virtual CreateIngestionResponse CreateIngestion(CreateIngestionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionResponseUnmarshaller.Instance;

            return Invoke<CreateIngestionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        public virtual IAsyncResult BeginCreateIngestion(CreateIngestionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIngestion.</param>
        /// 
        /// <returns>Returns a  CreateIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        public virtual CreateIngestionResponse EndCreateIngestion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIngestionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTemplate

        /// <summary>
        /// Creates a template from an existing QuickSight analysis or template. The resulting
        /// template can be used to create a dashboard.
        /// 
        ///  
        /// <para>
        /// A template is an entity in QuickSight which encapsulates the metadata required to
        /// create an analysis that can be used to create dashboard. It adds a layer of abstraction
        /// by use placeholders to replace the dataset associated with the analysis. You can use
        /// templates to create dashboards by replacing dataset placeholders with datasets which
        /// follow the same schema that was used to create the source analysis and template.
        /// </para>
        ///  
        /// <para>
        /// To create a template from an existing analysis, use the analysis's ARN, <code>aws-account-id</code>,
        /// <code>template-id</code>, <code>source-entity</code>, and <code>data-set-references</code>.
        /// </para>
        ///  
        /// <para>
        /// CLI syntax to create a template: 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-template —cli-input-json file://create-template.json</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax to create a template from another template in the same AWS account:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --data-set-references DataSetPlaceholder=reports,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/0dfc789c-81f6-4f4f-b9ac-7db2453eefc8
        /// DataSetPlaceholder=Elblogs,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/f60da323-af68-45db-9016-08e0d1d7ded5
        /// --source-entity SourceAnalysis='{Arn=arn:aws:quicksight:us-west-2:111122223333:analysis/7fb74527-c36d-4be8-8139-ac1be4c97365}'</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To create template from another account’s template, you need to grant cross account
        /// resource permission for DescribeTemplate the account that contains the template.
        /// </para>
        ///  
        /// <para>
        /// You can use a file to pass JSON to the function if you prefer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateTemplate(CreateTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse EndCreateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTemplateAlias

        /// <summary>
        /// Creates a template alias for a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight create-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name PROD —version-number 1</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        public virtual CreateTemplateAliasResponse CreateTemplateAlias(CreateTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateTemplateAlias(CreateTemplateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplateAlias.</param>
        /// 
        /// <returns>Returns a  CreateTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        public virtual CreateTemplateAliasResponse EndCreateTemplateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTemplateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDashboard

        /// <summary>
        /// Deletes a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-dashboard --aws-account-id 111122223333 —dashboard-id
        /// 123123123</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-dashboard --aws-account-id 111122223333 —dashboard-id
        /// 123123123 —version-number 3</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual IAsyncResult BeginDeleteDashboard(DeleteDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDashboard.</param>
        /// 
        /// <returns>Returns a  DeleteDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual DeleteDashboardResponse EndDeleteDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSet

        /// <summary>
        /// Deletes a dataset.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111111111111 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSet(DeleteDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSet.</param>
        /// 
        /// <returns>Returns a  DeleteDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual DeleteDataSetResponse EndDeleteDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Deletes the data source permanently. This action breaks all the datasets that reference
        /// the deleted data source.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-data-source \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Removes a user group from Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-group-name=Sales-Management </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroupMembership

        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The condition resource is the user name.
        /// </para>
        ///  
        /// <para>
        /// The condition key is <code>quicksight:UserName</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-group-membership --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales-Management --member-name=Charlie </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroupMembership(DeleteGroupMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupMembership.</param>
        /// 
        /// <returns>Returns a  DeleteGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual DeleteGroupMembershipResponse EndDeleteGroupMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIAMPolicyAssignment

        /// <summary>
        /// Deletes an existing assignment.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-iam-policy-assignment --aws-account-id=111122223333 --assignment-name=testtest
        /// --region=us-east-1 --namespace=default</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the DeleteIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        public virtual DeleteIAMPolicyAssignmentResponse DeleteIAMPolicyAssignment(DeleteIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteIAMPolicyAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        public virtual IAsyncResult BeginDeleteIAMPolicyAssignment(DeleteIAMPolicyAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        public virtual DeleteIAMPolicyAssignmentResponse EndDeleteIAMPolicyAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIAMPolicyAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTemplate

        /// <summary>
        /// Deletes a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template --aws-account-id 111122223333 —-template-id
        /// reports_test_template --version-number 2 </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template —aws-account-id 111122223333 —template-id reports_test_template
        /// —alias-name STAGING </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template —aws-account-id 111122223333 —template-id reports_test_template
        /// —alias-name ‘\$LATEST’ </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight delete-template --aws-account-id 111122223333 —-template-id
        /// reports_test_template</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If version number which is an optional field is not passed the template (including
        /// all the versions) is deleted by the API, if version number is provided, the specific
        /// template version is deleted by the API.
        /// </para>
        ///  
        /// <para>
        /// Users can explicitly describe the latest version of the template by passing <code>$LATEST</code>
        /// to the <code>alias-name</code> parameter. <code>$LATEST</code> is an internally supported
        /// alias, which points to the latest version of the template. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteTemplate(DeleteTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual DeleteTemplateResponse EndDeleteTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTemplateAlias

        /// <summary>
        /// Update template alias of given template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name 'STAGING'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        public virtual DeleteTemplateAliasResponse DeleteTemplateAlias(DeleteTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteTemplateAlias(DeleteTemplateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplateAlias.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        public virtual DeleteTemplateAliasResponse EndDeleteTemplateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTemplateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes the Amazon QuickSight user that is associated with the identity of the AWS
        /// Identity and Access Management (IAM) user or role that's making the call. The IAM
        /// user isn't deleted as a result of this call. 
        /// 
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserByPrincipalId

        /// <summary>
        /// Deletes a user identified by its principal ID. 
        /// 
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight delete-user-by-principal-id --aws-account-id=111122223333 --namespace=default
        /// --principal-id=ABCDEFJA26JLI7EUUOEHS </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId service method.</param>
        /// 
        /// <returns>The response from the DeleteUserByPrincipalId service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        public virtual DeleteUserByPrincipalIdResponse DeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserByPrincipalIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserByPrincipalIdResponseUnmarshaller.Instance;

            return Invoke<DeleteUserByPrincipalIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserByPrincipalId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserByPrincipalId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserByPrincipalIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserByPrincipalIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserByPrincipalId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserByPrincipalId.</param>
        /// 
        /// <returns>Returns a  DeleteUserByPrincipalIdResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        public virtual DeleteUserByPrincipalIdResponse EndDeleteUserByPrincipalId(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserByPrincipalIdResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDashboard

        /// <summary>
        /// Provides a summary for a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight describe-dashboard --aws-account-id 111122223333 —dashboard-id
        /// reports_test_report -version-number 2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code> aws quicksight describe-dashboard --aws-account-id 111122223333 —dashboard-id
        /// reports_test_report -alias-name ‘$PUBLISHED’ </code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual DescribeDashboardResponse DescribeDashboard(DescribeDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual IAsyncResult BeginDescribeDashboard(DescribeDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboard.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual DescribeDashboardResponse EndDescribeDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDashboardPermissions

        /// <summary>
        /// Describes read and write permissions on a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-dashboard-permissions --aws-account-id 735340738645
        /// —dashboard-id reports_test_bob_report</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        public virtual DescribeDashboardPermissionsResponse DescribeDashboardPermissions(DescribeDashboardPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboardPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeDashboardPermissions(DescribeDashboardPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboardPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        public virtual DescribeDashboardPermissionsResponse EndDescribeDashboardPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDashboardPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSet

        /// <summary>
        /// Describes a dataset. 
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111111111111 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        public virtual DescribeDataSetResponse DescribeDataSet(DescribeDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSet(DescribeDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSet.</param>
        /// 
        /// <returns>Returns a  DescribeDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        public virtual DescribeDataSetResponse EndDescribeDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSetPermissions

        /// <summary>
        /// Describes the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-data-set-permissions \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        public virtual DescribeDataSetPermissionsResponse DescribeDataSetPermissions(DescribeDataSetPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSetPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSetPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSetPermissions(DescribeDataSetPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSetPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDataSetPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        public virtual DescribeDataSetPermissionsResponse EndDescribeDataSetPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSetPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSource

        /// <summary>
        /// Describes a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        public virtual DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSource(DescribeDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSource.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        public virtual DescribeDataSourceResponse EndDescribeDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSourcePermissions

        /// <summary>
        /// Describes the resource permissions for a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        public virtual DescribeDataSourcePermissionsResponse DescribeDataSourcePermissions(DescribeDataSourcePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSourcePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSourcePermissions(DescribeDataSourcePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourcePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSourcePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourcePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        public virtual DescribeDataSourcePermissionsResponse EndDescribeDataSourcePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSourcePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGroup

        /// <summary>
        /// Returns an Amazon QuickSight group's description and Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is the group object. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-group -\-aws-account-id=11112222333 -\-namespace=default
        /// -\-group-name=Sales </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIAMPolicyAssignment

        /// <summary>
        /// Describes an existing IAMPolicy Assignment by specified assignment name.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-iam-policy-assignment --aws-account-id=111122223333
        /// --assignment-name=testtest --namespace=default --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the DescribeIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        public virtual DescribeIAMPolicyAssignmentResponse DescribeIAMPolicyAssignment(DescribeIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<DescribeIAMPolicyAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        public virtual IAsyncResult BeginDescribeIAMPolicyAssignment(DescribeIAMPolicyAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  DescribeIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        public virtual DescribeIAMPolicyAssignmentResponse EndDescribeIAMPolicyAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIAMPolicyAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIngestion

        /// <summary>
        /// Describes a SPICE ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion service method.</param>
        /// 
        /// <returns>The response from the DescribeIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        public virtual DescribeIngestionResponse DescribeIngestion(DescribeIngestionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIngestionResponseUnmarshaller.Instance;

            return Invoke<DescribeIngestionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        public virtual IAsyncResult BeginDescribeIngestion(DescribeIngestionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIngestionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIngestion.</param>
        /// 
        /// <returns>Returns a  DescribeIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        public virtual DescribeIngestionResponse EndDescribeIngestion(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIngestionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTemplate

        /// <summary>
        /// Describes a template's metadata.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
        /// reports_test_template </code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --version-number-2</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --alias-name '\$LATEST' </code> 
        /// </para>
        ///  
        /// <para>
        /// Users can explicitly describe the latest version of the dashboard by passing <code>$LATEST</code>
        /// to the <code>alias-name</code> parameter. <code>$LATEST</code> is an internally supported
        /// alias, which points to the latest version of the dashboard. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        public virtual DescribeTemplateResponse DescribeTemplate(DescribeTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        public virtual IAsyncResult BeginDescribeTemplate(DescribeTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        public virtual DescribeTemplateResponse EndDescribeTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTemplateAlias

        /// <summary>
        /// Describes the template aliases of a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name 'STAGING'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        public virtual DescribeTemplateAliasResponse DescribeTemplateAlias(DescribeTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeTemplateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        public virtual IAsyncResult BeginDescribeTemplateAlias(DescribeTemplateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplateAlias.</param>
        /// 
        /// <returns>Returns a  DescribeTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        public virtual DescribeTemplateAliasResponse EndDescribeTemplateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTemplateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTemplatePermissions

        /// <summary>
        /// Describes read and write permissions on a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-template-permissions —aws-account-id 735340738645 —template-id
        /// reports_test_template</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        public virtual DescribeTemplatePermissionsResponse DescribeTemplatePermissions(DescribeTemplatePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplatePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeTemplatePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeTemplatePermissions(DescribeTemplatePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplatePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplatePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeTemplatePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        public virtual DescribeTemplatePermissionsResponse EndDescribeTemplatePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTemplatePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUser

        /// <summary>
        /// Returns information about a user, given the user name. 
        /// 
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon Resource Name (ARN),
        /// AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user --aws-account-id=111122223333 --namespace=default
        /// --user-name=Pat </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDashboardEmbedUrl

        /// <summary>
        /// Generates a server-side embeddable URL and authorization code. Before this can work
        /// properly, first you need to configure the dashboards and user permissions. For more
        /// information, see <a href="https://docs.aws.example.com/en_us/quicksight/latest/user/embedding.html">
        /// Embedding Amazon QuickSight Dashboards</a>.
        /// 
        ///  
        /// <para>
        /// Currently, you can use <code>GetDashboardEmbedURL</code> only from the server, not
        /// from the user’s browser.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        /// Assume the role with permissions enabled for actions: <code>quickSight:RegisterUser</code>
        /// and <code>quicksight:GetDashboardEmbedURL</code>. You can use assume-role, assume-role-with-web-identity,
        /// or assume-role-with-saml. 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws sts assume-role --role-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --role-session-name embeddingsession</code> 
        /// </para>
        ///  
        /// <para>
        /// If the user does not exist in QuickSight, register the user:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user --aws-account-id 111122223333 --namespace default
        /// --identity-type IAM --iam-arn "arn:aws:iam::111122223333:role/embedding_quicksight_dashboard_role"
        /// --user-role READER --session-name "embeddingsession" --email user123@example.com --region
        /// us-east-1</code> 
        /// </para>
        ///  
        /// <para>
        /// Get the URL for the embedded dashboard (<code>IAM</code> identity authentication):
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight get-dashboard-embed-url --aws-account-id 111122223333 --dashboard-id
        /// 1a1ac2b2-3fc3-4b44-5e5d-c6db6778df89 --identity-type IAM</code> 
        /// </para>
        ///  
        /// <para>
        /// Get the URL for the embedded dashboard (<code>QUICKSIGHT</code> identity authentication):
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight get-dashboard-embed-url --aws-account-id 111122223333 --dashboard-id
        /// 1a1ac2b2-3fc3-4b44-5e5d-c6db6778df89 --identity-type QUICKSIGHT --user-arn arn:aws:quicksight:us-east-1:111122223333:user/default/embedding_quicksight_dashboard_role/embeddingsession</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified is not on the allowlist. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon QuickSight admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified is not supported. Supported identity types include IAM
        /// and QUICKSIGHT.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user is not found. This error can happen in any operation that requires finding
        /// a user based on a provided user name, such as <code>DeleteUser</code>, <code>DescribeUser</code>,
        /// and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session is not valid. The session
        /// lifetime must be from 15 to 600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual GetDashboardEmbedUrlResponse GetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return Invoke<GetDashboardEmbedUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDashboardEmbedUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual IAsyncResult BeginGetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDashboardEmbedUrl.</param>
        /// 
        /// <returns>Returns a  GetDashboardEmbedUrlResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual GetDashboardEmbedUrlResponse EndGetDashboardEmbedUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDashboardEmbedUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDashboards

        /// <summary>
        /// Lists dashboards in the AWS account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-dashboards --aws-account-id 111122223333 --max-results
        /// 5 —next-token 'next-10'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual IAsyncResult BeginListDashboards(ListDashboardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboards.</param>
        /// 
        /// <returns>Returns a  ListDashboardsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse EndListDashboards(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDashboardsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDashboardVersions

        /// <summary>
        /// Lists all the versions of the dashboards in the Quicksight subscription.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        /// aws quicksight list-template-versions —aws-account-id 111122223333 —template-id reports-test-template
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions service method.</param>
        /// 
        /// <returns>The response from the ListDashboardVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        public virtual ListDashboardVersionsResponse ListDashboardVersions(ListDashboardVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboardVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboardVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        public virtual IAsyncResult BeginListDashboardVersions(ListDashboardVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboardVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboardVersions.</param>
        /// 
        /// <returns>Returns a  ListDashboardVersionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        public virtual ListDashboardVersionsResponse EndListDashboardVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDashboardVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSets

        /// <summary>
        /// Lists all of the datasets belonging to this account in an AWS region.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:dataset/*</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: <code>aws quicksight list-data-sets --aws-account-id=111111111111</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual ListDataSetsResponse ListDataSets(ListDataSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return Invoke<ListDataSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual IAsyncResult BeginListDataSets(ListDataSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSets.</param>
        /// 
        /// <returns>Returns a  ListDataSetsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual ListDataSetsResponse EndListDataSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSources

        /// <summary>
        /// Lists data sources in current AWS region that belong to this AWS account.
        /// 
        ///  
        /// <para>
        /// The permissions resource is: <code>arn:aws:quicksight:region:aws-account-id:datasource/*</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: <code>aws quicksight list-data-sources --aws-account-id=111122223333</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupMemberships

        /// <summary>
        /// Lists member users in a group.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group member objects.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-group-memberships -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual IAsyncResult BeginListGroupMemberships(ListGroupMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMemberships.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual ListGroupMembershipsResponse EndListGroupMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Lists all user groups in Amazon QuickSight. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/*</code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a list of group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-groups -\-aws-account-id=111122223333 -\-namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIAMPolicyAssignments

        /// <summary>
        /// Lists assignments in current QuickSight account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-iam-policy-assignments --aws-account-id=111122223333 --max-result=5
        /// --assignment-status=ENABLED --namespace=default --region=us-east-1 --next-token=3
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments service method.</param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignments service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        public virtual ListIAMPolicyAssignmentsResponse ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsResponseUnmarshaller.Instance;

            return Invoke<ListIAMPolicyAssignmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIAMPolicyAssignments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIAMPolicyAssignments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        public virtual IAsyncResult BeginListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIAMPolicyAssignments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIAMPolicyAssignments.</param>
        /// 
        /// <returns>Returns a  ListIAMPolicyAssignmentsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        public virtual ListIAMPolicyAssignmentsResponse EndListIAMPolicyAssignments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIAMPolicyAssignmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIAMPolicyAssignmentsForUser

        /// <summary>
        /// Lists all the assignments and the ARNs for the associated IAM policies assigned to
        /// the specified user and the group or groups that the user belongs to.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-iam-policy-assignments-for-user --aws-account-id=111122223333
        /// --user-name=user5 --namespace=default --max-result=6 --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser service method.</param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignmentsForUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        public virtual ListIAMPolicyAssignmentsForUserResponse ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsForUserResponseUnmarshaller.Instance;

            return Invoke<ListIAMPolicyAssignmentsForUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIAMPolicyAssignmentsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIAMPolicyAssignmentsForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        public virtual IAsyncResult BeginListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsForUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIAMPolicyAssignmentsForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIAMPolicyAssignmentsForUser.</param>
        /// 
        /// <returns>Returns a  ListIAMPolicyAssignmentsForUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        public virtual ListIAMPolicyAssignmentsForUserResponse EndListIAMPolicyAssignmentsForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIAMPolicyAssignmentsForUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIngestions

        /// <summary>
        /// Lists the history of SPICE ingestions for a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        public virtual ListIngestionsResponse ListIngestions(ListIngestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionsResponseUnmarshaller.Instance;

            return Invoke<ListIngestionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIngestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        public virtual IAsyncResult BeginListIngestions(ListIngestionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngestions.</param>
        /// 
        /// <returns>Returns a  ListIngestionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        public virtual ListIngestionsResponse EndListIngestions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIngestionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags assigned to a resource.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight list-tags-for-resource --resource-arn arn:aws:quicksight:us-east-1:111111111111:dataset/dataset1
        /// --region us-east-1</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplateAliases

        /// <summary>
        /// Lists all the aliases of a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-template-aliases --aws-account-id 111122223333 —template-id
        /// 'reports_test_template'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases service method.</param>
        /// 
        /// <returns>The response from the ListTemplateAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        public virtual ListTemplateAliasesResponse ListTemplateAliases(ListTemplateAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateAliasesResponseUnmarshaller.Instance;

            return Invoke<ListTemplateAliasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        public virtual IAsyncResult BeginListTemplateAliases(ListTemplateAliasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateAliasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateAliases.</param>
        /// 
        /// <returns>Returns a  ListTemplateAliasesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        public virtual ListTemplateAliasesResponse EndListTemplateAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplateAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplates

        /// <summary>
        /// Lists all the templates in the QuickSight account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-templates --aws-account-id 111122223333 --max-results 1
        /// —next-token AYADeJuxwOypAndSoOn</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplateVersions

        /// <summary>
        /// Lists all the versions of the templates in the Quicksight account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        /// aws quicksight list-template-versions --aws-account-id 111122223333 --aws-account-id
        /// 196359894473 --template-id reports-test-template
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListTemplateVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        public virtual ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        public virtual IAsyncResult BeginListTemplateVersions(ListTemplateVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListTemplateVersionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        public virtual ListTemplateVersionsResponse EndListTemplateVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplateVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserGroups

        /// <summary>
        /// Lists the Amazon QuickSight groups that an Amazon QuickSight user is a member of.
        /// 
        ///  
        /// <para>
        /// The response is a one or more group objects. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-user-groups -\-user-name=Pat -\-aws-account-id=111122223333
        /// -\-namespace=default -\-region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return Invoke<ListUserGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual IAsyncResult BeginListUserGroups(ListUserGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserGroups.</param>
        /// 
        /// <returns>Returns a  ListUserGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual ListUserGroupsResponse EndListUserGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Returns a list of all of the Amazon QuickSight users belonging to this account. 
        /// 
        ///  
        /// <para>
        /// The response is a list of user objects, containing each user's Amazon Resource Name
        /// (ARN), AWS Identity and Access Management (IAM) role, and email address. 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight list-users --aws-account-id=111122223333 --namespace=default
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterUser

        /// <summary>
        /// Creates an Amazon QuickSight user, whose identity is associated with the AWS Identity
        /// and Access Management (IAM) identity or role specified in the request. 
        /// 
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight register-user -\-aws-account-id=111122223333 -\-namespace=default
        /// -\-email=pat@example.com -\-identity-type=IAM -\-user-role=AUTHOR -\-iam-arn=arn:aws:iam::111122223333:user/Pat
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual RegisterUserResponse RegisterUser(RegisterUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return Invoke<RegisterUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual IAsyncResult BeginRegisterUser(RegisterUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterUser.</param>
        /// 
        /// <returns>Returns a  RegisterUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual RegisterUserResponse EndRegisterUser(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterUserResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns a tag or tags to a resource.
        /// 
        ///  
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the specified QuickSight resource. Tags
        /// can help you organize and categorize your resources. You can also use them to scope
        /// user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the TagResource action with a resource that already
        /// has tags. If you specify a new tag key for the resource, this tag is appended to the
        /// list of tags associated with the resource. If you specify a tag key that is already
        /// associated with the resource, the new tag value that you specify replaces the previous
        /// value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource. QuickSight supports tagging
        /// on data-set, data-source, dashboard, template. 
        /// </para>
        ///  
        /// <para>
        /// Tagging for QuickSight works in a similar was to tagging for other AWS services, except
        /// for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't use tags to track AWS costs for QuickSight, because QuickSight costs are
        /// based on users and SPICE capacity, which aren't taggable resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// QuickSight doesn't currently support the Tag Editor for AWS Resource Groups.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// CLI syntax to tag a resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight tag-resource --resource-arn arn:aws:quicksight:us-east-1:111111111111:dataset/dataset1
        /// --tags Key=K1,Value=V1 Key=K2,Value=V2 --region us-east-1</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag or tags from a resource.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight untag-resource --resource-arn arn:aws:quicksight:us-east-1:111111111111:dataset/dataset1
        /// --tag-keys K1 K2 --region us-east-1</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDashboard

        /// <summary>
        /// Updates a dashboard in the AWS account.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard --aws-account-id 111122223333 --dashboard-id
        /// 123123123 --dashboard-name "test-update102" --source-entity SourceTemplate={Arn=arn:aws:quicksight:us-west-2:111122223333:template/sales-report-template2}
        /// --data-set-references DataSetPlaceholder=SalesDataSet,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/0e251aef-9ebf-46e1-b852-eb4fa33c1d3a</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard --cli-input-json file://update-dashboard.json
        /// </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual IAsyncResult BeginUpdateDashboard(UpdateDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboard.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual UpdateDashboardResponse EndUpdateDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDashboardPermissions

        /// <summary>
        /// Updates read and write permissions on a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard-permissions —cli-input-json file://update-permission.json</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for granting read only permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "GrantPermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
        /// "quicksight:QueryDashboard" ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for granting read and write permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "GrantPermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
        /// "quicksight:QueryDashboard", "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
        /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
        /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for revoking write permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "RevokePermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
        /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
        /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// A sample update-permissions.json for revoking read and write permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333", "DashboardId": "reports_test_report", "RevokePermissions":
        /// [ { "Principal": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2", "Actions":
        /// [ "quicksight:DescribeDashboard", "quicksight:ListDashboardVersions", "quicksight:DescribeDashboardVersion",
        /// "quicksight:QueryDashboard", "quicksight:DescribeDashboardPermissions", "quicksight:UpdateDashboardPermissions",
        /// "quicksight:DeleteDashboardVersion", "quicksight:DeleteDashboard", "quicksight:UpdateDashboard",
        /// "quicksight:UpdateDashboardPublishedVersion", ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// To obtain the principal name of a QuickSight user or group, you can use describe-group
        /// or describe-user. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user --aws-account-id 111122223333 --namespace default
        /// --user-name user2 --region us-east-1 { "User": { "Arn": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2",
        /// "Active": true, "Email": "user2@example.com", "Role": "ADMIN", "UserName": "user2",
        /// "PrincipalId": "federated/iam/abcd2abcdabcdeabc5ab5" }, "RequestId": "8f74bb31-6291-448a-a71c-a765a44bae31",
        /// "Status": 200 }</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        public virtual UpdateDashboardPermissionsResponse UpdateDashboardPermissions(UpdateDashboardPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        public virtual IAsyncResult BeginUpdateDashboardPermissions(UpdateDashboardPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        public virtual UpdateDashboardPermissionsResponse EndUpdateDashboardPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDashboardPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDashboardPublishedVersion

        /// <summary>
        /// Updates the published version of a dashboard.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-dashboard-published-version --aws-account-id 111122223333
        /// --dashboard-id dashboard-w1 ---version-number 2</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        public virtual UpdateDashboardPublishedVersionResponse UpdateDashboardPublishedVersion(UpdateDashboardPublishedVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPublishedVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardPublishedVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardPublishedVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateDashboardPublishedVersion(UpdateDashboardPublishedVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPublishedVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardPublishedVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardPublishedVersionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        public virtual UpdateDashboardPublishedVersionResponse EndUpdateDashboardPublishedVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDashboardPublishedVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSet

        /// <summary>
        /// Updates a dataset.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-set \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My dataset' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--import-mode=SPICE \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--physical-table-map='{</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "physical-table-id": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RelationalTable": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DataSourceArn": "arn:aws:quicksight:us-west-2:111111111111:datasource/data-source-id",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "table1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "InputColumns": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Name": "column1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Type": "STRING"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ]</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> }'</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSet(UpdateDataSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSet.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual UpdateDataSetResponse EndUpdateDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSetPermissions

        /// <summary>
        /// Updates the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax: 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-set-permissions \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-set-id=unique-data-set-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--grant-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user1","Actions":["quicksight:DescribeDataSet","quicksight:DescribeDataSetPermissions","quicksight:PassDataSet","quicksight:ListIngestions","quicksight:DescribeIngestion"]}]'
        /// \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--revoke-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user2","Actions":["quicksight:UpdateDataSet","quicksight:DeleteDataSet","quicksight:UpdateDataSetPermissions","quicksight:CreateIngestion","quicksight:CancelIngestion"]}]'</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        public virtual UpdateDataSetPermissionsResponse UpdateDataSetPermissions(UpdateDataSetPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSetPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSetPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSetPermissions(UpdateDataSetPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSetPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        public virtual UpdateDataSetPermissionsResponse EndUpdateDataSetPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSetPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Updates a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-source \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My Data Source' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-parameters='{"PostgreSqlParameters":{"Host":"my-db-host.example.com","Port":1234,"Database":"my-db"}}'
        /// \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--credentials='{"CredentialPair":{"Username":"username","Password":"password"}}</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSourcePermissions

        /// <summary>
        /// Updates the permissions to a data source.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-data-source-permissions \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id=111122223333 \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--data-source-id=unique-data-source-id \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--name='My Data Source' \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--grant-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user1","Actions":["quicksight:DescribeDataSource","quicksight:DescribeDataSourcePermissions","quicksight:PassDataSource"]}]'
        /// \</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--revoke-permissions='[{"Principal":"arn:aws:quicksight:us-east-1:111122223333:user/default/user2","Actions":["quicksight:UpdateDataSource","quicksight:DeleteDataSource","quicksight:UpdateDataSourcePermissions"]}]'</code>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        public virtual UpdateDataSourcePermissionsResponse UpdateDataSourcePermissions(UpdateDataSourcePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourcePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSourcePermissions(UpdateDataSourcePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourcePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSourcePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourcePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        public virtual UpdateDataSourcePermissionsResponse EndUpdateDataSourcePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourcePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Changes a group description. 
        /// 
        ///  
        /// <para>
        /// The permissions resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </code>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-group --aws-account-id=111122223333 --namespace=default
        /// --group-name=Sales --description="Sales BI Dashboards" </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIAMPolicyAssignment

        /// <summary>
        /// Updates an existing assignment. This operation updates only the optional parameter
        /// or parameters that are specified in the request.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code/>aws quicksight update-iam-policy-assignment --aws-account-id=111122223333
        /// --assignment-name=FullAccessAssignment --assignment-status=DRAFT --policy-arns=arn:aws:iam::aws:policy/AdministratorAccess
        /// --identities="user=user-1,user-2,group=admin" --namespace=default --region=us-east-1
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the UpdateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in an "actionable" state that must complete before a new update
        /// can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        public virtual UpdateIAMPolicyAssignmentResponse UpdateIAMPolicyAssignment(UpdateIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<UpdateIAMPolicyAssignmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        public virtual IAsyncResult BeginUpdateIAMPolicyAssignment(UpdateIAMPolicyAssignmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  UpdateIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        public virtual UpdateIAMPolicyAssignmentResponse EndUpdateIAMPolicyAssignment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIAMPolicyAssignmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplate

        /// <summary>
        /// Updates a template from an existing QuickSight analysis.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-template --aws-account-id 111122223333 --template-id
        /// reports_test_template --data-set-references DataSetPlaceholder=reports,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/c684a204-d134-4c53-a63c-451f72c60c28
        /// DataSetPlaceholder=Elblogs,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/15840b7d-b542-4491-937b-602416b367b3
        /// —source-entity SourceAnalysis=’{Arn=arn:aws:quicksight:us-west-2:111122223333:analysis/c5731fe9-4708-4598-8f6d-cf2a70875b6d}</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can also pass in a json file: <code>aws quicksight update-template —cli-input-json
        /// file://create-template.json</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplate(UpdateTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse EndUpdateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplateAlias

        /// <summary>
        /// Updates the template alias of a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-template-alias --aws-account-id 111122223333 --template-id
        /// 'reports_test_template' --alias-name STAGING —template-version-number 2 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        public virtual UpdateTemplateAliasResponse UpdateTemplateAlias(UpdateTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplateAlias(UpdateTemplateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        public virtual UpdateTemplateAliasResponse EndUpdateTemplateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplatePermissions

        /// <summary>
        /// Updates the permissions on a template.
        /// 
        ///  
        /// <para>
        /// CLI syntax:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aws quicksight describe-template-permissions —aws-account-id 111122223333 —template-id
        /// reports_test_template</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aws quicksight update-template-permissions —cli-input-json file://update-permission.json
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The structure of <code>update-permissions.json</code> to add permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DashboardId": "reports_test_template",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "GrantPermissions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> { "Principal": "arn:aws:quicksight:us-east-1:196359894473:user/default/user3",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Actions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:DescribeTemplate",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:ListTemplateVersions"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// The structure of <code>update-permissions.json</code> to add permissions:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "AwsAccountId": "111122223333",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "DashboardId": "reports_test_template",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RevokePermissions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> { "Principal": "arn:aws:quicksight:us-east-1:196359894473:user/default/user3",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Actions": [</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:DescribeTemplate",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "quicksight:ListTemplateVersions"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> ] } ] }</code> 
        /// </para>
        ///  
        /// <para>
        /// To obtain the principal name of a QuickSight group or user, use user describe-group
        /// or describe-user. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight describe-user </code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--aws-account-id 111122223333</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--namespace default</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--user-name user2 </code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>--region us-east-1</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "User": {</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Arn": "arn:aws:quicksight:us-east-1:111122223333:user/default/user2",</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Active": true,</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Email": "user2@example.com",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Role": "ADMIN",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "UserName": "user2",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "PrincipalId": "federated/iam/abcd2abcdabcdeabc5ab5"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> },</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "RequestId": "8f74bb31-6291-448a-a71c-a765a44bae31",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "Status": 200</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>}</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon QuickSight currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        public virtual UpdateTemplatePermissionsResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplatePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplatePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplatePermissions(UpdateTemplatePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplatePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplatePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateTemplatePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        public virtual UpdateTemplatePermissionsResponse EndUpdateTemplatePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplatePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Updates an Amazon QuickSight user.
        /// 
        ///  
        /// <para>
        /// The response is a user object that contains the user's Amazon QuickSight user name,
        /// email address, active or inactive status in Amazon QuickSight, Amazon QuickSight role,
        /// and Amazon Resource Name (ARN). 
        /// </para>
        ///  
        /// <para>
        ///  <b>CLI Sample:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <code>aws quicksight update-user --user-name=Pat --role=ADMIN --email=new_address@example.com
        /// --aws-account-id=111122223333 --namespace=default --region=us-east-1 </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this. The provided credentials couldn't be validated. You
        /// might not be authorized to carry out the request. Ensure that your account is authorized
        /// to use the Amazon QuickSight service, that your policies have the correct permissions,
        /// and that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters don't have a valid value.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
        }

        #endregion
        
    }
}