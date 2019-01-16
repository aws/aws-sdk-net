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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Backup.Model;
using Amazon.Backup.Model.Internal.MarshallTransformations;
using Amazon.Backup.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Backup
{
    /// <summary>
    /// Implementation for accessing Backup
    ///
    /// AWS Backup 
    /// <para>
    /// AWS Backup is a unified backup service designed to protect AWS services and their
    /// associated data. AWS Backup simplifies the creation, migration, restoration, and deletion
    /// of backups, while also providing reporting and auditing.
    /// </para>
    /// </summary>
    public partial class AmazonBackupClient : AmazonServiceClient, IAmazonBackup
    {
        private static IServiceMetadata serviceMetadata = new AmazonBackupMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonBackupClient with the credentials loaded from the application's
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
        public AmazonBackupClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupConfig()) { }

        /// <summary>
        /// Constructs AmazonBackupClient with the credentials loaded from the application's
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
        public AmazonBackupClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBackupClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(AmazonBackupConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBackupClient(AWSCredentials credentials)
            : this(credentials, new AmazonBackupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBackupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Credentials and an
        /// AmazonBackupClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(AWSCredentials credentials, AmazonBackupConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBackupConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBackupConfig clientConfig)
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


        #region  CreateBackupPlan

        /// <summary>
        /// Backup plans are documents that contain information that AWS Backup uses to schedule
        /// tasks that create recovery points of resources.
        /// 
        ///  
        /// <para>
        /// If you call <code>CreateBackupPlan</code> with a plan that already exists, the existing
        /// <code>backupPlanId</code> is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupPlan service method.</param>
        /// 
        /// <returns>The response from the CreateBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        public virtual CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<CreateBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginCreateBackupPlan(CreateBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackupPlan.</param>
        /// 
        /// <returns>Returns a  CreateBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        public virtual CreateBackupPlanResponse EndCreateBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackupPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackupSelection

        /// <summary>
        /// Creates a JSON document that specifies a set of resources to assign to a backup plan.
        /// Resources can be included by specifying patterns for a <code>ListOfTags</code> and
        /// selected <code>Resources</code>. 
        /// 
        ///  
        /// <para>
        /// For example, consider the following patterns:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Resources: "arn:aws:ec2:region:account-id:volume/volume-id"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConditionKey:"department"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionValue:"finance"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionType:"StringEquals"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConditionKey:"importance"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionValue:"critical"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionType:"StringEquals"</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Using these patterns would back up all Amazon Elastic Block Store (Amazon EBS) volumes
        /// that are tagged as <code>"department=finance"</code>, <code>"importance=critical"</code>,
        /// in addition to an EBS volume with the specified volume Id.
        /// </para>
        ///  
        /// <para>
        /// Resources and conditions are additive in that all resources that match the pattern
        /// are selected. This shouldn't be confused with a logical AND, where all conditions
        /// must match. The matching patterns are logically 'put together using the OR operator.
        /// In other words, all patterns that match are selected for backup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupSelection service method.</param>
        /// 
        /// <returns>The response from the CreateBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        public virtual CreateBackupSelectionResponse CreateBackupSelection(CreateBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<CreateBackupSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackupSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        public virtual IAsyncResult BeginCreateBackupSelection(CreateBackupSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackupSelection.</param>
        /// 
        /// <returns>Returns a  CreateBackupSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        public virtual CreateBackupSelectionResponse EndCreateBackupSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackupSelectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackupVault

        /// <summary>
        /// Creates a logical container where backups are stored. A <code>CreateBackupVault</code>
        /// request includes a name, optionally one or more resource tags, an encryption key,
        /// and a request ID.
        /// 
        ///  <note> 
        /// <para>
        /// Sensitive data, such as passport numbers, should not be included the name of a backup
        /// vault.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupVault service method.</param>
        /// 
        /// <returns>The response from the CreateBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        public virtual CreateBackupVaultResponse CreateBackupVault(CreateBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;

            return Invoke<CreateBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        public virtual IAsyncResult BeginCreateBackupVault(CreateBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackupVault.</param>
        /// 
        /// <returns>Returns a  CreateBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        public virtual CreateBackupVaultResponse EndCreateBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackupVaultResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackupPlan

        /// <summary>
        /// Deletes a backup plan. A backup plan can only be deleted after all associated selections
        /// of resources have been deleted. Deleting a backup plan deletes the current version
        /// of a backup plan. Previous versions, if any, will still exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        public virtual DeleteBackupPlanResponse DeleteBackupPlan(DeleteBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupPlan(DeleteBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupPlan.</param>
        /// 
        /// <returns>Returns a  DeleteBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        public virtual DeleteBackupPlanResponse EndDeleteBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackupSelection

        /// <summary>
        /// Deletes the resource selection associated with a backup plan that is specified by
        /// the <code>SelectionId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupSelection service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        public virtual DeleteBackupSelectionResponse DeleteBackupSelection(DeleteBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupSelection(DeleteBackupSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupSelection.</param>
        /// 
        /// <returns>Returns a  DeleteBackupSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        public virtual DeleteBackupSelectionResponse EndDeleteBackupSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupSelectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackupVault

        /// <summary>
        /// Deletes the backup vault identified by its name. A vault can be deleted only if it
        /// is empty.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVault service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        public virtual DeleteBackupVaultResponse DeleteBackupVault(DeleteBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupVault(DeleteBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupVault.</param>
        /// 
        /// <returns>Returns a  DeleteBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        public virtual DeleteBackupVaultResponse EndDeleteBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupVaultResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackupVaultAccessPolicy

        /// <summary>
        /// Deletes the policy document that manages permissions on a backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        public virtual DeleteBackupVaultAccessPolicyResponse DeleteBackupVaultAccessPolicy(DeleteBackupVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultAccessPolicy operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupVaultAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupVaultAccessPolicy(DeleteBackupVaultAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteBackupVaultAccessPolicyResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        public virtual DeleteBackupVaultAccessPolicyResponse EndDeleteBackupVaultAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupVaultAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackupVaultNotifications

        /// <summary>
        /// Deletes event notifications for the specified backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        public virtual DeleteBackupVaultNotificationsResponse DeleteBackupVaultNotifications(DeleteBackupVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultNotifications operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupVaultNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupVaultNotifications(DeleteBackupVaultNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupVaultNotifications.</param>
        /// 
        /// <returns>Returns a  DeleteBackupVaultNotificationsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        public virtual DeleteBackupVaultNotificationsResponse EndDeleteBackupVaultNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupVaultNotificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRecoveryPoint

        /// <summary>
        /// Deletes the recovery point specified by a recovery point ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        public virtual DeleteRecoveryPointResponse DeleteRecoveryPoint(DeleteRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DeleteRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryPoint operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecoveryPoint(DeleteRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  DeleteRecoveryPointResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        public virtual DeleteRecoveryPointResponse EndDeleteRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecoveryPointResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBackupJob

        /// <summary>
        /// Returns metadata associated with creating a backup of a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupJob service method.</param>
        /// 
        /// <returns>The response from the DescribeBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.DependencyFailureException">
        /// A dependent AWS service or resource returned an error to the AWS Backup service, and
        /// the action cannot be completed.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        public virtual DescribeBackupJobResponse DescribeBackupJob(DescribeBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackupJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeBackupJob(DescribeBackupJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackupJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackupJob.</param>
        /// 
        /// <returns>Returns a  DescribeBackupJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        public virtual DescribeBackupJobResponse EndDescribeBackupJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBackupJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBackupVault

        /// <summary>
        /// Returns metadata about a backup vault specified by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupVault service method.</param>
        /// 
        /// <returns>The response from the DescribeBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        public virtual DescribeBackupVaultResponse DescribeBackupVault(DescribeBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupVaultResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        public virtual IAsyncResult BeginDescribeBackupVault(DescribeBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackupVault.</param>
        /// 
        /// <returns>Returns a  DescribeBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        public virtual DescribeBackupVaultResponse EndDescribeBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBackupVaultResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProtectedResource

        /// <summary>
        /// Returns information about a saved resource, including the last time it was backed-up,
        /// its Amazon Resource Name (ARN), and the AWS service type of the saved resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectedResource service method.</param>
        /// 
        /// <returns>The response from the DescribeProtectedResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        public virtual DescribeProtectedResourceResponse DescribeProtectedResource(DescribeProtectedResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectedResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProtectedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectedResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProtectedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        public virtual IAsyncResult BeginDescribeProtectedResource(DescribeProtectedResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProtectedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProtectedResource.</param>
        /// 
        /// <returns>Returns a  DescribeProtectedResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        public virtual DescribeProtectedResourceResponse EndDescribeProtectedResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProtectedResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecoveryPoint

        /// <summary>
        /// Returns metadata associated with a recovery point, including ID, status, encryption,
        /// and lifecycle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the DescribeRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        public virtual DescribeRecoveryPointResponse DescribeRecoveryPoint(DescribeRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DescribeRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryPoint operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecoveryPoint(DescribeRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  DescribeRecoveryPointResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        public virtual DescribeRecoveryPointResponse EndDescribeRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecoveryPointResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRestoreJob

        /// <summary>
        /// Returns metadata associated with a restore job that is specified by a job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRestoreJob service method.</param>
        /// 
        /// <returns>The response from the DescribeRestoreJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.DependencyFailureException">
        /// A dependent AWS service or resource returned an error to the AWS Backup service, and
        /// the action cannot be completed.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        public virtual DescribeRestoreJobResponse DescribeRestoreJob(DescribeRestoreJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRestoreJobResponseUnmarshaller.Instance;

            return Invoke<DescribeRestoreJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRestoreJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRestoreJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeRestoreJob(DescribeRestoreJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRestoreJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRestoreJob.</param>
        /// 
        /// <returns>Returns a  DescribeRestoreJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        public virtual DescribeRestoreJobResponse EndDescribeRestoreJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRestoreJobResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportBackupPlanTemplate

        /// <summary>
        /// Returns the backup plan that is specified by the plan ID as a backup template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportBackupPlanTemplate service method.</param>
        /// 
        /// <returns>The response from the ExportBackupPlanTemplate service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        public virtual ExportBackupPlanTemplateResponse ExportBackupPlanTemplate(ExportBackupPlanTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportBackupPlanTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBackupPlanTemplateResponseUnmarshaller.Instance;

            return Invoke<ExportBackupPlanTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportBackupPlanTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportBackupPlanTemplate operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportBackupPlanTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        public virtual IAsyncResult BeginExportBackupPlanTemplate(ExportBackupPlanTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportBackupPlanTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBackupPlanTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportBackupPlanTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportBackupPlanTemplate.</param>
        /// 
        /// <returns>Returns a  ExportBackupPlanTemplateResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        public virtual ExportBackupPlanTemplateResponse EndExportBackupPlanTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportBackupPlanTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackupPlan

        /// <summary>
        /// Returns the body of a backup plan in JSON format, in addition to plan metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlan service method.</param>
        /// 
        /// <returns>The response from the GetBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        public virtual GetBackupPlanResponse GetBackupPlan(GetBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginGetBackupPlan(GetBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupPlan.</param>
        /// 
        /// <returns>Returns a  GetBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        public virtual GetBackupPlanResponse EndGetBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackupPlanFromJSON

        /// <summary>
        /// Returns a valid JSON document specifying a backup plan or an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromJSON service method.</param>
        /// 
        /// <returns>The response from the GetBackupPlanFromJSON service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        public virtual GetBackupPlanFromJSONResponse GetBackupPlanFromJSON(GetBackupPlanFromJSONRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromJSONRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromJSONResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanFromJSONResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlanFromJSON operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromJSON operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupPlanFromJSON
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        public virtual IAsyncResult BeginGetBackupPlanFromJSON(GetBackupPlanFromJSONRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromJSONRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromJSONResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupPlanFromJSON operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupPlanFromJSON.</param>
        /// 
        /// <returns>Returns a  GetBackupPlanFromJSONResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        public virtual GetBackupPlanFromJSONResponse EndGetBackupPlanFromJSON(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupPlanFromJSONResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackupPlanFromTemplate

        /// <summary>
        /// Returns the template specified by its <code>templateId</code> as a backup plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromTemplate service method.</param>
        /// 
        /// <returns>The response from the GetBackupPlanFromTemplate service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        public virtual GetBackupPlanFromTemplateResponse GetBackupPlanFromTemplate(GetBackupPlanFromTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanFromTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlanFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromTemplate operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupPlanFromTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetBackupPlanFromTemplate(GetBackupPlanFromTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupPlanFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupPlanFromTemplate.</param>
        /// 
        /// <returns>Returns a  GetBackupPlanFromTemplateResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        public virtual GetBackupPlanFromTemplateResponse EndGetBackupPlanFromTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupPlanFromTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackupSelection

        /// <summary>
        /// Returns selection metadata and a document in JSON format that specifies a list of
        /// resources that are associated with a backup plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupSelection service method.</param>
        /// 
        /// <returns>The response from the GetBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        public virtual GetBackupSelectionResponse GetBackupSelection(GetBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<GetBackupSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        public virtual IAsyncResult BeginGetBackupSelection(GetBackupSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupSelection.</param>
        /// 
        /// <returns>Returns a  GetBackupSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        public virtual GetBackupSelectionResponse EndGetBackupSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupSelectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackupVaultAccessPolicy

        /// <summary>
        /// Returns the access policy document that is associated with the named backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        public virtual GetBackupVaultAccessPolicyResponse GetBackupVaultAccessPolicy(GetBackupVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBackupVaultAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultAccessPolicy operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupVaultAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetBackupVaultAccessPolicy(GetBackupVaultAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  GetBackupVaultAccessPolicyResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        public virtual GetBackupVaultAccessPolicyResponse EndGetBackupVaultAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupVaultAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBackupVaultNotifications

        /// <summary>
        /// Returns event notifications for the specified backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the GetBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        public virtual GetBackupVaultNotificationsResponse GetBackupVaultNotifications(GetBackupVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<GetBackupVaultNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultNotifications operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupVaultNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        public virtual IAsyncResult BeginGetBackupVaultNotifications(GetBackupVaultNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupVaultNotifications.</param>
        /// 
        /// <returns>Returns a  GetBackupVaultNotificationsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        public virtual GetBackupVaultNotificationsResponse EndGetBackupVaultNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupVaultNotificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecoveryPointRestoreMetadata

        /// <summary>
        /// Returns two sets of metadata key-value pairs. The first set lists the metadata that
        /// the recovery point was created with. The second set lists the metadata key-value pairs
        /// that are required to restore the recovery point.
        /// 
        ///  
        /// <para>
        /// These sets can be the same, or the restore metadata set can contain different values
        /// if the target service to be restored has changed since the recovery point was created
        /// and now requires additional or different information in order to be restored.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointRestoreMetadata service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryPointRestoreMetadata service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        public virtual GetRecoveryPointRestoreMetadataResponse GetRecoveryPointRestoreMetadata(GetRecoveryPointRestoreMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRestoreMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointRestoreMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryPointRestoreMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryPointRestoreMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointRestoreMetadata operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryPointRestoreMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetRecoveryPointRestoreMetadata(GetRecoveryPointRestoreMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRestoreMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointRestoreMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryPointRestoreMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryPointRestoreMetadata.</param>
        /// 
        /// <returns>Returns a  GetRecoveryPointRestoreMetadataResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        public virtual GetRecoveryPointRestoreMetadataResponse EndGetRecoveryPointRestoreMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecoveryPointRestoreMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSupportedResourceTypes

        /// <summary>
        /// Returns the AWS resource types supported by AWS Backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSupportedResourceTypes service method.</param>
        /// 
        /// <returns>The response from the GetSupportedResourceTypes service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        public virtual GetSupportedResourceTypesResponse GetSupportedResourceTypes(GetSupportedResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetSupportedResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSupportedResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSupportedResourceTypes operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSupportedResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginGetSupportedResourceTypes(GetSupportedResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSupportedResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSupportedResourceTypes.</param>
        /// 
        /// <returns>Returns a  GetSupportedResourceTypesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        public virtual GetSupportedResourceTypesResponse EndGetSupportedResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSupportedResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupJobs

        /// <summary>
        /// Returns metadata about your backup jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobs service method.</param>
        /// 
        /// <returns>The response from the ListBackupJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        public virtual ListBackupJobsResponse ListBackupJobs(ListBackupJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobsResponseUnmarshaller.Instance;

            return Invoke<ListBackupJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobs operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        public virtual IAsyncResult BeginListBackupJobs(ListBackupJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupJobs.</param>
        /// 
        /// <returns>Returns a  ListBackupJobsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        public virtual ListBackupJobsResponse EndListBackupJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupPlans

        /// <summary>
        /// Returns metadata of your saved backup plans, including Amazon Resource Names (ARNs),
        /// plan IDs, creation and deletion dates, version IDs, plan names, and creator request
        /// IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlans service method.</param>
        /// 
        /// <returns>The response from the ListBackupPlans service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        public virtual ListBackupPlansResponse ListBackupPlans(ListBackupPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlansResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlans operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        public virtual IAsyncResult BeginListBackupPlans(ListBackupPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupPlans.</param>
        /// 
        /// <returns>Returns a  ListBackupPlansResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        public virtual ListBackupPlansResponse EndListBackupPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupPlansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupPlanTemplates

        /// <summary>
        /// Returns metadata of your saved backup plan templates, including the template ID, name,
        /// and the creation and deletion dates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanTemplates service method.</param>
        /// 
        /// <returns>The response from the ListBackupPlanTemplates service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        public virtual ListBackupPlanTemplatesResponse ListBackupPlanTemplates(ListBackupPlanTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlanTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlanTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanTemplates operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupPlanTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        public virtual IAsyncResult BeginListBackupPlanTemplates(ListBackupPlanTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupPlanTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupPlanTemplates.</param>
        /// 
        /// <returns>Returns a  ListBackupPlanTemplatesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        public virtual ListBackupPlanTemplatesResponse EndListBackupPlanTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupPlanTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupPlanVersions

        /// <summary>
        /// Returns version metadata of your backup plans, including Amazon Resource Names (ARNs),
        /// backup plan IDs, creation and deletion dates, plan names, and version IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanVersions service method.</param>
        /// 
        /// <returns>The response from the ListBackupPlanVersions service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        public virtual ListBackupPlanVersionsResponse ListBackupPlanVersions(ListBackupPlanVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanVersionsResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlanVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlanVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanVersions operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupPlanVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        public virtual IAsyncResult BeginListBackupPlanVersions(ListBackupPlanVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupPlanVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupPlanVersions.</param>
        /// 
        /// <returns>Returns a  ListBackupPlanVersionsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        public virtual ListBackupPlanVersionsResponse EndListBackupPlanVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupPlanVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupSelections

        /// <summary>
        /// Returns an array containing metadata of the resources associated with the target backup
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupSelections service method.</param>
        /// 
        /// <returns>The response from the ListBackupSelections service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        public virtual ListBackupSelectionsResponse ListBackupSelections(ListBackupSelectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupSelectionsResponseUnmarshaller.Instance;

            return Invoke<ListBackupSelectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupSelections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupSelections operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupSelections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        public virtual IAsyncResult BeginListBackupSelections(ListBackupSelectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupSelectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupSelections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupSelections.</param>
        /// 
        /// <returns>Returns a  ListBackupSelectionsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        public virtual ListBackupSelectionsResponse EndListBackupSelections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupSelectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupVaults

        /// <summary>
        /// Returns a list of recovery point storage containers along with information about them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupVaults service method.</param>
        /// 
        /// <returns>The response from the ListBackupVaults service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        public virtual ListBackupVaultsResponse ListBackupVaults(ListBackupVaultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupVaultsResponseUnmarshaller.Instance;

            return Invoke<ListBackupVaultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupVaults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupVaults operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupVaults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        public virtual IAsyncResult BeginListBackupVaults(ListBackupVaultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupVaultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupVaults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupVaults.</param>
        /// 
        /// <returns>Returns a  ListBackupVaultsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        public virtual ListBackupVaultsResponse EndListBackupVaults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupVaultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProtectedResources

        /// <summary>
        /// Returns an array of resources successfully backed up by AWS Backup, including the
        /// time the resource was saved, an Amazon Resource Name (ARN) of the resource, and a
        /// resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResources service method.</param>
        /// 
        /// <returns>The response from the ListProtectedResources service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        public virtual ListProtectedResourcesResponse ListProtectedResources(ListProtectedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListProtectedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtectedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResources operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtectedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        public virtual IAsyncResult BeginListProtectedResources(ListProtectedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtectedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtectedResources.</param>
        /// 
        /// <returns>Returns a  ListProtectedResourcesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        public virtual ListProtectedResourcesResponse EndListProtectedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProtectedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecoveryPointsByBackupVault

        /// <summary>
        /// Returns detailed information about the recovery points stored in a backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByBackupVault service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        public virtual ListRecoveryPointsByBackupVaultResponse ListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByBackupVaultResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPointsByBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryPointsByBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        public virtual IAsyncResult BeginListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryPointsByBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryPointsByBackupVault.</param>
        /// 
        /// <returns>Returns a  ListRecoveryPointsByBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        public virtual ListRecoveryPointsByBackupVaultResponse EndListRecoveryPointsByBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecoveryPointsByBackupVaultResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecoveryPointsByResource

        /// <summary>
        /// Returns detailed information about recovery points of the type specified by a resource
        /// Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByResource service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        public virtual ListRecoveryPointsByResourceResponse ListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPointsByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryPointsByResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        public virtual IAsyncResult BeginListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryPointsByResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryPointsByResource.</param>
        /// 
        /// <returns>Returns a  ListRecoveryPointsByResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        public virtual ListRecoveryPointsByResourceResponse EndListRecoveryPointsByResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecoveryPointsByResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRestoreJobs

        /// <summary>
        /// Returns a list of jobs that AWS Backup initiated to restore a saved resource, including
        /// metadata about the recovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobs service method.</param>
        /// 
        /// <returns>The response from the ListRestoreJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        public virtual ListRestoreJobsResponse ListRestoreJobs(ListRestoreJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobs operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRestoreJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        public virtual IAsyncResult BeginListRestoreJobs(ListRestoreJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRestoreJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRestoreJobs.</param>
        /// 
        /// <returns>Returns a  ListRestoreJobsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        public virtual ListRestoreJobsResponse EndListRestoreJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRestoreJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Returns a list of key-value pairs assigned to a target recovery point, backup plan,
        /// or backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBackupVaultAccessPolicy

        /// <summary>
        /// Sets a resource-based policy that is used to manage access permissions on the target
        /// backup vault. Requires a backup vault name and an access policy document in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        public virtual PutBackupVaultAccessPolicyResponse PutBackupVaultAccessPolicy(PutBackupVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultAccessPolicy operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBackupVaultAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutBackupVaultAccessPolicy(PutBackupVaultAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBackupVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  PutBackupVaultAccessPolicyResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        public virtual PutBackupVaultAccessPolicyResponse EndPutBackupVaultAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBackupVaultAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBackupVaultNotifications

        /// <summary>
        /// Turns on notifications on a backup vault for the specified topic and events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the PutBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        public virtual PutBackupVaultNotificationsResponse PutBackupVaultNotifications(PutBackupVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultNotifications operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBackupVaultNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        public virtual IAsyncResult BeginPutBackupVaultNotifications(PutBackupVaultNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBackupVaultNotifications.</param>
        /// 
        /// <returns>Returns a  PutBackupVaultNotificationsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        public virtual PutBackupVaultNotificationsResponse EndPutBackupVaultNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBackupVaultNotificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartBackupJob

        /// <summary>
        /// Starts a job to create a one-time backup of the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBackupJob service method.</param>
        /// 
        /// <returns>The response from the StartBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        public virtual StartBackupJobResponse StartBackupJob(StartBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBackupJobResponseUnmarshaller.Instance;

            return Invoke<StartBackupJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBackupJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBackupJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        public virtual IAsyncResult BeginStartBackupJob(StartBackupJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBackupJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartBackupJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBackupJob.</param>
        /// 
        /// <returns>Returns a  StartBackupJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        public virtual StartBackupJobResponse EndStartBackupJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartBackupJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRestoreJob

        /// <summary>
        /// Recovers the saved resource identified by an Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// If the resource ARN is included in the request, then the last complete backup of that
        /// resource is recovered. If the ARN of a recovery point is supplied, then that recovery
        /// point is restored.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRestoreJob service method.</param>
        /// 
        /// <returns>The response from the StartRestoreJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        public virtual StartRestoreJobResponse StartRestoreJob(StartRestoreJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRestoreJobResponseUnmarshaller.Instance;

            return Invoke<StartRestoreJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRestoreJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRestoreJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        public virtual IAsyncResult BeginStartRestoreJob(StartRestoreJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRestoreJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRestoreJob.</param>
        /// 
        /// <returns>Returns a  StartRestoreJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        public virtual StartRestoreJobResponse EndStartRestoreJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRestoreJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopBackupJob

        /// <summary>
        /// Attempts to cancel a job to create a one-time backup of a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBackupJob service method.</param>
        /// 
        /// <returns>The response from the StopBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        public virtual StopBackupJobResponse StopBackupJob(StopBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBackupJobResponseUnmarshaller.Instance;

            return Invoke<StopBackupJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBackupJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBackupJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        public virtual IAsyncResult BeginStopBackupJob(StopBackupJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBackupJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopBackupJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBackupJob.</param>
        /// 
        /// <returns>Returns a  StopBackupJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        public virtual StopBackupJobResponse EndStopBackupJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopBackupJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns a set of key-value pairs to a recovery point, backup plan, or backup vault
        /// identified by an Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a set of key-value pairs from a recovery point, backup plan, or backup vault
        /// identified by an Amazon Resource Name (ARN)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBackupPlan

        /// <summary>
        /// Replaces the body of a saved backup plan identified by its <code>backupPlanId</code>
        /// with the input document in JSON format. The new version is uniquely identified by
        /// a <code>VersionId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackupPlan service method.</param>
        /// 
        /// <returns>The response from the UpdateBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        public virtual UpdateBackupPlanResponse UpdateBackupPlan(UpdateBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginUpdateBackupPlan(UpdateBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackupPlan.</param>
        /// 
        /// <returns>Returns a  UpdateBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        public virtual UpdateBackupPlanResponse EndUpdateBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBackupPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRecoveryPointLifecycle

        /// <summary>
        /// Sets the transition lifecycle of a recovery point.
        /// 
        ///  
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. AWS Backup transitions and expires backups automatically according
        /// to the lifecycle that you define. 
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “expire after days” setting must be 90 days greater than
        /// the “transition to cold after days” setting. The “transition to cold after days” setting
        /// cannot be changed after a backup has been transitioned to cold. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateRecoveryPointLifecycle service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        public virtual UpdateRecoveryPointLifecycleResponse UpdateRecoveryPointLifecycle(UpdateRecoveryPointLifecycleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateRecoveryPointLifecycleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecoveryPointLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointLifecycle operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecoveryPointLifecycle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        public virtual IAsyncResult BeginUpdateRecoveryPointLifecycle(UpdateRecoveryPointLifecycleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointLifecycleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecoveryPointLifecycle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecoveryPointLifecycle.</param>
        /// 
        /// <returns>Returns a  UpdateRecoveryPointLifecycleResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        public virtual UpdateRecoveryPointLifecycleResponse EndUpdateRecoveryPointLifecycle(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRecoveryPointLifecycleResponse>(asyncResult);
        }

        #endregion
        
    }
}