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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElasticBeanstalk.Model;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Interface for accessing ElasticBeanstalk
    ///
    /// AWS Elastic Beanstalk 
    /// <para>
    /// AWS Elastic Beanstalk makes it easy for you to create, deploy, and manage scalable,
    /// fault-tolerant applications running on the Amazon Web Services cloud.
    /// </para>
    ///  
    /// <para>
    /// For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page. The location of the latest AWS Elastic Beanstalk
    /// WSDL is <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
    /// To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that enable you to access the API, go to <a
    /// href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions
    /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticBeanstalk : IAmazonService, IDisposable
    {

        
        #region  AbortEnvironmentUpdate


        /// <summary>
        /// Cancels in-progress environment configuration update or application version deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate service method.</param>
        /// 
        /// <returns>The response from the AbortEnvironmentUpdate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        AbortEnvironmentUpdateResponse AbortEnvironmentUpdate(AbortEnvironmentUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AbortEnvironmentUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAbortEnvironmentUpdate
        ///         operation.</returns>
        IAsyncResult BeginAbortEnvironmentUpdate(AbortEnvironmentUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AbortEnvironmentUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortEnvironmentUpdate.</param>
        /// 
        /// <returns>Returns a  AbortEnvironmentUpdateResult from ElasticBeanstalk.</returns>
        AbortEnvironmentUpdateResponse EndAbortEnvironmentUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  ApplyEnvironmentManagedAction


        /// <summary>
        /// Applies a scheduled managed action immediately. A managed action can be applied only
        /// if its status is <code>Scheduled</code>. Get the status and action ID of a managed
        /// action with <a>DescribeEnvironmentManagedActions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction service method.</param>
        /// 
        /// <returns>The response from the ApplyEnvironmentManagedAction service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ManagedActionInvalidStateException">
        /// Cannot modify the managed action in its current state.
        /// </exception>
        ApplyEnvironmentManagedActionResponse ApplyEnvironmentManagedAction(ApplyEnvironmentManagedActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyEnvironmentManagedAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyEnvironmentManagedAction
        ///         operation.</returns>
        IAsyncResult BeginApplyEnvironmentManagedAction(ApplyEnvironmentManagedActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ApplyEnvironmentManagedAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplyEnvironmentManagedAction.</param>
        /// 
        /// <returns>Returns a  ApplyEnvironmentManagedActionResult from ElasticBeanstalk.</returns>
        ApplyEnvironmentManagedActionResponse EndApplyEnvironmentManagedAction(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckDNSAvailability


        /// <summary>
        /// Checks if the specified CNAME is available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by ElasticBeanstalk.</returns>
        CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDNSAvailability
        ///         operation.</returns>
        IAsyncResult BeginCheckDNSAvailability(CheckDNSAvailabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDNSAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDNSAvailability.</param>
        /// 
        /// <returns>Returns a  CheckDNSAvailabilityResult from ElasticBeanstalk.</returns>
        CheckDNSAvailabilityResponse EndCheckDNSAvailability(IAsyncResult asyncResult);

        #endregion
        
        #region  ComposeEnvironments


        /// <summary>
        /// Create or update a group of environments that each run a separate component of a single
        /// application. Takes a list of version labels that specify application source bundles
        /// for each of the environments to create or update. The name of each environment and
        /// other required information must be included in the source bundles in an environment
        /// manifest named <code>env.yaml</code>. See <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-mgmt-compose.html">Compose
        /// Environments</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments service method.</param>
        /// 
        /// <returns>The response from the ComposeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        ComposeEnvironmentsResponse ComposeEnvironments(ComposeEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ComposeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndComposeEnvironments
        ///         operation.</returns>
        IAsyncResult BeginComposeEnvironments(ComposeEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ComposeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginComposeEnvironments.</param>
        /// 
        /// <returns>Returns a  ComposeEnvironmentsResult from ElasticBeanstalk.</returns>
        ComposeEnvironmentsResponse EndComposeEnvironments(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application that has one configuration template named <code>default</code>
        /// and no application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from ElasticBeanstalk.</returns>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplicationVersion


        /// <summary>
        /// Creates an application version for the specified application.
        /// 
        ///  <note> 
        /// <para>
        /// Once you create an application version with a specified Amazon S3 bucket and key location,
        /// you cannot change that Amazon S3 location. If you change the Amazon S3 location, you
        /// receive an exception when you attempt to launch an environment from the application
        /// version.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException">
        /// The specified account has reached its limit of application versions.
        /// </exception>
        CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationVersion
        ///         operation.</returns>
        IAsyncResult BeginCreateApplicationVersion(CreateApplicationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationVersion.</param>
        /// 
        /// <returns>Returns a  CreateApplicationVersionResult from ElasticBeanstalk.</returns>
        CreateApplicationVersionResponse EndCreateApplicationVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfigurationTemplate


        /// <summary>
        /// Creates a configuration template. Templates are associated with a specific application
        /// and are used to deploy different versions of the application with the same configuration
        /// settings.
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeConfigurationSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAvailableSolutionStacks</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException">
        /// The specified account has reached its limit of configuration templates.
        /// </exception>
        CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationTemplate
        ///         operation.</returns>
        IAsyncResult BeginCreateConfigurationTemplate(CreateConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationTemplateResult from ElasticBeanstalk.</returns>
        CreateConfigurationTemplateResponse EndCreateConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Launches an environment for the specified application using the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from ElasticBeanstalk.</returns>
        CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStorageLocation


        /// <summary>
        /// Creates the Amazon S3 storage location for the account.
        /// 
        ///  
        /// <para>
        /// This location is used to store user log files.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        CreateStorageLocationResponse CreateStorageLocation();

        /// <summary>
        /// Creates the Amazon S3 storage location for the account.
        /// 
        ///  
        /// <para>
        /// This location is used to store user log files.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation service method.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageLocation
        ///         operation.</returns>
        IAsyncResult BeginCreateStorageLocation(CreateStorageLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageLocation.</param>
        /// 
        /// <returns>Returns a  CreateStorageLocationResult from ElasticBeanstalk.</returns>
        CreateStorageLocationResponse EndCreateStorageLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the specified application along with all associated versions and configurations.
        /// The application versions will not be deleted from your Amazon S3 bucket.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application that has a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from ElasticBeanstalk.</returns>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationVersion


        /// <summary>
        /// Deletes the specified version from the specified application.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application version that is associated with a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException">
        /// Unable to delete the Amazon S3 source bundle associated with the application version.
        /// The application version was deleted successfully.
        /// </exception>
        DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationVersion
        ///         operation.</returns>
        IAsyncResult BeginDeleteApplicationVersion(DeleteApplicationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationVersion.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationVersionResult from ElasticBeanstalk.</returns>
        DeleteApplicationVersionResponse EndDeleteApplicationVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationTemplate


        /// <summary>
        /// Deletes the specified configuration template.
        /// 
        ///  <note> 
        /// <para>
        /// When you launch an environment using a configuration template, the environment gets
        /// a copy of the template. You can delete or modify the environment's copy of the template
        /// without affecting the running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationTemplate
        ///         operation.</returns>
        IAsyncResult BeginDeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationTemplateResult from ElasticBeanstalk.</returns>
        DeleteConfigurationTemplateResponse EndDeleteConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEnvironmentConfiguration


        /// <summary>
        /// Deletes the draft configuration associated with the running environment.
        /// 
        ///  
        /// <para>
        /// Updating a running environment with any configuration changes creates a draft configuration
        /// set. You can get the draft configuration using <a>DescribeConfigurationSettings</a>
        /// while the update is in progress or if the update fails. The <code>DeploymentStatus</code>
        /// for the draft configuration indicates whether the deployment is in process or has
        /// failed. The draft configuration remains in existence until it is deleted with this
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentConfiguration service method, as returned by ElasticBeanstalk.</returns>
        DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentConfiguration
        ///         operation.</returns>
        IAsyncResult BeginDeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentConfigurationResult from ElasticBeanstalk.</returns>
        DeleteEnvironmentConfigurationResponse EndDeleteEnvironmentConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplications


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationsResponse DescribeApplications();

        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplications
        ///         operation.</returns>
        IAsyncResult BeginDescribeApplications(DescribeApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplications.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationsResult from ElasticBeanstalk.</returns>
        DescribeApplicationsResponse EndDescribeApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplicationVersions


        /// <summary>
        /// Retrieve a list of application versions stored in your AWS Elastic Beanstalk storage
        /// bucket.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationVersionsResponse DescribeApplicationVersions();

        /// <summary>
        /// Retrieve a list of application versions stored in your AWS Elastic Beanstalk storage
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationVersions
        ///         operation.</returns>
        IAsyncResult BeginDescribeApplicationVersions(DescribeApplicationVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationVersions.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationVersionsResult from ElasticBeanstalk.</returns>
        DescribeApplicationVersionsResponse EndDescribeApplicationVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConfigurationOptions


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        DescribeConfigurationOptionsResponse DescribeConfigurationOptions();

        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationOptions
        ///         operation.</returns>
        IAsyncResult BeginDescribeConfigurationOptions(DescribeConfigurationOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationOptions.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationOptionsResult from ElasticBeanstalk.</returns>
        DescribeConfigurationOptionsResponse EndDescribeConfigurationOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConfigurationSettings


        /// <summary>
        /// Returns a description of the settings for the specified configuration set, that is,
        /// either a configuration template or the configuration set associated with a running
        /// environment.
        /// 
        ///  
        /// <para>
        /// When describing the settings for the configuration set associated with a running environment,
        /// it is possible to receive two sets of setting descriptions. One is the deployed configuration
        /// set, and the other is a draft configuration of an environment that is either in the
        /// process of deployment or that failed to deploy.
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteEnvironmentConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationSettings
        ///         operation.</returns>
        IAsyncResult BeginDescribeConfigurationSettings(DescribeConfigurationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationSettings.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationSettingsResult from ElasticBeanstalk.</returns>
        DescribeConfigurationSettingsResponse EndDescribeConfigurationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEnvironmentHealth


        /// <summary>
        /// Returns information about the overall health of the specified environment. The <b>DescribeEnvironmentHealth</b>
        /// operation is only available with AWS Elastic Beanstalk Enhanced Health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        DescribeEnvironmentHealthResponse DescribeEnvironmentHealth(DescribeEnvironmentHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentHealth
        ///         operation.</returns>
        IAsyncResult BeginDescribeEnvironmentHealth(DescribeEnvironmentHealthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentHealth.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentHealthResult from ElasticBeanstalk.</returns>
        DescribeEnvironmentHealthResponse EndDescribeEnvironmentHealth(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEnvironmentManagedActionHistory


        /// <summary>
        /// Lists an environment's completed and failed managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActionHistory service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        DescribeEnvironmentManagedActionHistoryResponse DescribeEnvironmentManagedActionHistory(DescribeEnvironmentManagedActionHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentManagedActionHistory
        ///         operation.</returns>
        IAsyncResult BeginDescribeEnvironmentManagedActionHistory(DescribeEnvironmentManagedActionHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentManagedActionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentManagedActionHistory.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentManagedActionHistoryResult from ElasticBeanstalk.</returns>
        DescribeEnvironmentManagedActionHistoryResponse EndDescribeEnvironmentManagedActionHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEnvironmentManagedActions


        /// <summary>
        /// Lists an environment's upcoming and in-progress managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        DescribeEnvironmentManagedActionsResponse DescribeEnvironmentManagedActions(DescribeEnvironmentManagedActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentManagedActions
        ///         operation.</returns>
        IAsyncResult BeginDescribeEnvironmentManagedActions(DescribeEnvironmentManagedActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentManagedActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentManagedActions.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentManagedActionsResult from ElasticBeanstalk.</returns>
        DescribeEnvironmentManagedActionsResponse EndDescribeEnvironmentManagedActions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEnvironmentResources


        /// <summary>
        /// Returns AWS resources for this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentResources
        ///         operation.</returns>
        IAsyncResult BeginDescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentResources.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentResourcesResult from ElasticBeanstalk.</returns>
        DescribeEnvironmentResourcesResponse EndDescribeEnvironmentResources(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEnvironments


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        DescribeEnvironmentsResponse DescribeEnvironments();

        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironments
        ///         operation.</returns>
        IAsyncResult BeginDescribeEnvironments(DescribeEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironments.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentsResult from ElasticBeanstalk.</returns>
        DescribeEnvironmentsResponse EndDescribeEnvironments(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        DescribeEventsResponse DescribeEvents();

        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from ElasticBeanstalk.</returns>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstancesHealth


        /// <summary>
        /// Returns more detailed information about the health of the specified instances (for
        /// example, CPU utilization, load average, and causes). The <b>DescribeInstancesHealth</b>
        /// operation is only available with AWS Elastic Beanstalk Enhanced Health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancesHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        DescribeInstancesHealthResponse DescribeInstancesHealth(DescribeInstancesHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancesHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancesHealth
        ///         operation.</returns>
        IAsyncResult BeginDescribeInstancesHealth(DescribeInstancesHealthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancesHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancesHealth.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesHealthResult from ElasticBeanstalk.</returns>
        DescribeInstancesHealthResponse EndDescribeInstancesHealth(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAvailableSolutionStacks


        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        ListAvailableSolutionStacksResponse ListAvailableSolutionStacks();

        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks service method.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableSolutionStacks
        ///         operation.</returns>
        IAsyncResult BeginListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableSolutionStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableSolutionStacks.</param>
        /// 
        /// <returns>Returns a  ListAvailableSolutionStacksResult from ElasticBeanstalk.</returns>
        ListAvailableSolutionStacksResponse EndListAvailableSolutionStacks(IAsyncResult asyncResult);

        #endregion
        
        #region  RebuildEnvironment


        /// <summary>
        /// Deletes and recreates all of the AWS resources (for example: the Auto Scaling group,
        /// load balancer, etc.) for a specified environment and forces a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment service method.</param>
        /// 
        /// <returns>The response from the RebuildEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebuildEnvironment
        ///         operation.</returns>
        IAsyncResult BeginRebuildEnvironment(RebuildEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebuildEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildEnvironment.</param>
        /// 
        /// <returns>Returns a  RebuildEnvironmentResult from ElasticBeanstalk.</returns>
        RebuildEnvironmentResponse EndRebuildEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestEnvironmentInfo


        /// <summary>
        /// Initiates a request to compile the specified type of information of the deployed environment.
        /// 
        ///  
        /// <para>
        ///  Setting the <code>InfoType</code> to <code>tail</code> compiles the last lines from
        /// the application server log files of every Amazon EC2 instance in your environment.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Setting the <code>InfoType</code> to <code>bundle</code> compresses the application
        /// server log files for every Amazon EC2 instance into a <code>.zip</code> file. Legacy
        /// and .NET containers do not support bundle logs. 
        /// </para>
        ///  
        /// <para>
        ///  Use <a>RetrieveEnvironmentInfo</a> to obtain the set of logs. 
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RetrieveEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RequestEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestEnvironmentInfo
        ///         operation.</returns>
        IAsyncResult BeginRequestEnvironmentInfo(RequestEnvironmentInfoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a  RequestEnvironmentInfoResult from ElasticBeanstalk.</returns>
        RequestEnvironmentInfoResponse EndRequestEnvironmentInfo(IAsyncResult asyncResult);

        #endregion
        
        #region  RestartAppServer


        /// <summary>
        /// Causes the environment to restart the application container server running on each
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer service method.</param>
        /// 
        /// <returns>The response from the RestartAppServer service method, as returned by ElasticBeanstalk.</returns>
        RestartAppServerResponse RestartAppServer(RestartAppServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestartAppServer
        ///         operation.</returns>
        IAsyncResult BeginRestartAppServer(RestartAppServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestartAppServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartAppServer.</param>
        /// 
        /// <returns>Returns a  RestartAppServerResult from ElasticBeanstalk.</returns>
        RestartAppServerResponse EndRestartAppServer(IAsyncResult asyncResult);

        #endregion
        
        #region  RetrieveEnvironmentInfo


        /// <summary>
        /// Retrieves the compiled information from a <a>RequestEnvironmentInfo</a> request.
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RequestEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveEnvironmentInfo
        ///         operation.</returns>
        IAsyncResult BeginRetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a  RetrieveEnvironmentInfoResult from ElasticBeanstalk.</returns>
        RetrieveEnvironmentInfoResponse EndRetrieveEnvironmentInfo(IAsyncResult asyncResult);

        #endregion
        
        #region  SwapEnvironmentCNAMEs


        /// <summary>
        /// Swaps the CNAMEs of two environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method.</param>
        /// 
        /// <returns>The response from the SwapEnvironmentCNAMEs service method, as returned by ElasticBeanstalk.</returns>
        SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSwapEnvironmentCNAMEs
        ///         operation.</returns>
        IAsyncResult BeginSwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SwapEnvironmentCNAMEs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSwapEnvironmentCNAMEs.</param>
        /// 
        /// <returns>Returns a  SwapEnvironmentCNAMEsResult from ElasticBeanstalk.</returns>
        SwapEnvironmentCNAMEsResponse EndSwapEnvironmentCNAMEs(IAsyncResult asyncResult);

        #endregion
        
        #region  TerminateEnvironment


        /// <summary>
        /// Terminates the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment service method.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateEnvironment
        ///         operation.</returns>
        IAsyncResult BeginTerminateEnvironment(TerminateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateEnvironment.</param>
        /// 
        /// <returns>Returns a  TerminateEnvironmentResult from ElasticBeanstalk.</returns>
        TerminateEnvironmentResponse EndTerminateEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates the specified application to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <code>description</code>) is not provided, the value remains
        /// unchanged. To clear these properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from ElasticBeanstalk.</returns>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplicationVersion


        /// <summary>
        /// Updates the specified application version to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <code>description</code>) is not provided, the value remains
        /// unchanged. To clear properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationVersion
        ///         operation.</returns>
        IAsyncResult BeginUpdateApplicationVersion(UpdateApplicationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationVersion.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationVersionResult from ElasticBeanstalk.</returns>
        UpdateApplicationVersionResponse EndUpdateApplicationVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfigurationTemplate


        /// <summary>
        /// Updates the specified configuration template to have the specified properties or configuration
        /// option values.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <code>ApplicationName</code>) is not provided, its value
        /// remains unchanged. To clear such properties, specify an empty string.
        /// </para>
        ///  </note> 
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationTemplate
        ///         operation.</returns>
        IAsyncResult BeginUpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationTemplateResult from ElasticBeanstalk.</returns>
        UpdateConfigurationTemplateResponse EndUpdateConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Updates the environment description, deploys a new application version, updates the
        /// configuration settings to an entirely new configuration template, or updates select
        /// configuration option values in the running environment.
        /// 
        ///  
        /// <para>
        ///  Attempting to update both the release and configuration is not allowed and AWS Elastic
        /// Beanstalk returns an <code>InvalidParameterCombination</code> error. 
        /// </para>
        ///  
        /// <para>
        ///  When updating the configuration settings to a new template or individual settings,
        /// a draft configuration is created and <a>DescribeConfigurationSettings</a> for this
        /// environment returns two setting descriptions with different <code>DeploymentStatus</code>
        /// values. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from ElasticBeanstalk.</returns>
        UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidateConfigurationSettings


        /// <summary>
        /// Takes a set of configuration settings and either a configuration template or environment,
        /// and determines whether those values are valid.
        /// 
        ///  
        /// <para>
        /// This action returns a list of messages indicating any errors or warnings associated
        /// with the selection of option values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateConfigurationSettings
        ///         operation.</returns>
        IAsyncResult BeginValidateConfigurationSettings(ValidateConfigurationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateConfigurationSettings.</param>
        /// 
        /// <returns>Returns a  ValidateConfigurationSettingsResult from ElasticBeanstalk.</returns>
        ValidateConfigurationSettingsResponse EndValidateConfigurationSettings(IAsyncResult asyncResult);

        #endregion
        
    }
}