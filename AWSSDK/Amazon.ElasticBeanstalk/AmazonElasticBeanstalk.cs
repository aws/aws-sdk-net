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

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Interface for accessing AmazonElasticBeanstalk.
    ///  
    ///  AWS Elastic Beanstalk <para> This is the AWS Elastic Beanstalk API Reference. This guide provides detailed information about AWS Elastic
    /// Beanstalk actions, data types, parameters, and errors. </para> <para>AWS Elastic Beanstalk is a tool that makes it easy for you to create,
    /// deploy, and manage scalable, fault-tolerant applications running on Amazon Web Services cloud resources. </para> <para> For more information
    /// about this product, go to the AWS Elastic Beanstalk details page. The location of the lastest AWS Elastic Beanstalk WSDL is
    /// http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl. </para> <para> <b>Endpoints</b> </para> <para>AWS Elastic
    /// Beanstalk supports the following region-specific endpoint:</para>
    /// <ul>
    /// <li> https://elasticbeanstalk.us-east-1.amazonaws.com </li>
    /// 
    /// </ul>
    /// </summary>
    public interface AmazonElasticBeanstalk : IDisposable
    {
        

        #region CheckDNSAvailability

        /// <summary>
        /// <para> Checks if the specified CNAME is available. </para>
        /// </summary>
        /// 
        /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CheckDNSAvailability"/>
        /// </summary>
        /// 
        /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCheckDNSAvailability operation.</returns>
        IAsyncResult BeginCheckDNSAvailability(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CheckDNSAvailability operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CheckDNSAvailability"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDNSAvailability.</param>
        /// 
        /// <returns>Returns a CheckDNSAvailabilityResult from AmazonElasticBeanstalk.</returns>
        CheckDNSAvailabilityResponse EndCheckDNSAvailability(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeConfigurationOptions

        /// <summary>
        /// <para> Describes the configuration options that are used in a particular configuration template or environment, or that a specified solution
        /// stack defines. The description includes the values the options, their default values, and an indication of the required action on a running
        /// environment if an option value is changed. </para>
        /// </summary>
        /// 
        /// <param name="describeConfigurationOptionsRequest">Container for the necessary parameters to execute the DescribeConfigurationOptions service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeConfigurationOptions"/>
        /// </summary>
        /// 
        /// <param name="describeConfigurationOptionsRequest">Container for the necessary parameters to execute the DescribeConfigurationOptions
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConfigurationOptions operation.</returns>
        IAsyncResult BeginDescribeConfigurationOptions(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConfigurationOptions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeConfigurationOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationOptions.</param>
        /// 
        /// <returns>Returns a DescribeConfigurationOptionsResult from AmazonElasticBeanstalk.</returns>
        DescribeConfigurationOptionsResponse EndDescribeConfigurationOptions(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Describes the configuration options that are used in a particular configuration template or environment, or that a specified solution
        /// stack defines. The description includes the values the options, their default values, and an indication of the required action on a running
        /// environment if an option value is changed. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeConfigurationOptionsResponse DescribeConfigurationOptions();
        
        #endregion
        
    

        #region DeleteConfigurationTemplate

        /// <summary>
        /// <para>Deletes the specified configuration template.</para> <para><b>NOTE:</b>When you launch an environment using a configuration template,
        /// the environment gets a copy of the template. You can delete or modify the environment's copy of the template without affecting the running
        /// environment.</para>
        /// </summary>
        /// 
        /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteConfigurationTemplate(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationTemplate.</param>
        DeleteConfigurationTemplateResponse EndDeleteConfigurationTemplate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateEnvironment

        /// <summary>
        /// <para> Launches an environment for the specified application using the specified configuration. </para>
        /// </summary>
        /// 
        /// <param name="createEnvironmentRequest">Container for the necessary parameters to execute the CreateEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="TooManyEnvironmentsException"/>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="createEnvironmentRequest">Container for the necessary parameters to execute the CreateEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a CreateEnvironmentResult from AmazonElasticBeanstalk.</returns>
        CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateStorageLocation

        /// <summary>
        /// <para> Creates the Amazon S3 storage location for the account. </para> <para> This location is used to store user log files. </para>
        /// </summary>
        /// 
        /// <param name="createStorageLocationRequest">Container for the necessary parameters to execute the CreateStorageLocation service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="S3SubscriptionRequiredException"/>
        /// <exception cref="TooManyBucketsException"/>
        CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest createStorageLocationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateStorageLocation"/>
        /// </summary>
        /// 
        /// <param name="createStorageLocationRequest">Container for the necessary parameters to execute the CreateStorageLocation operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateStorageLocation operation.</returns>
        IAsyncResult BeginCreateStorageLocation(CreateStorageLocationRequest createStorageLocationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStorageLocation operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateStorageLocation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageLocation.</param>
        /// 
        /// <returns>Returns a CreateStorageLocationResult from AmazonElasticBeanstalk.</returns>
        CreateStorageLocationResponse EndCreateStorageLocation(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Creates the Amazon S3 storage location for the account. </para> <para> This location is used to store user log files. </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="S3SubscriptionRequiredException"/>
        /// <exception cref="TooManyBucketsException"/>
        CreateStorageLocationResponse CreateStorageLocation();
        
        #endregion
        
    

        #region RequestEnvironmentInfo

        /// <summary>
        /// <para> Initiates a request to compile the specified type of information of the deployed environment. </para> <para> Setting the
        /// <c>InfoType</c> to <c>tail</c> compiles the last lines from the application server log files of every Amazon EC2 instance in your
        /// environment. Use RetrieveEnvironmentInfo to access the compiled information. </para> <para>Related Topics</para>
        /// <ul>
        /// <li> RetrieveEnvironmentInfo </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="requestEnvironmentInfoRequest">Container for the necessary parameters to execute the RequestEnvironmentInfo service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RequestEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="requestEnvironmentInfoRequest">Container for the necessary parameters to execute the RequestEnvironmentInfo operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRequestEnvironmentInfo(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RequestEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RequestEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestEnvironmentInfo.</param>
        RequestEnvironmentInfoResponse EndRequestEnvironmentInfo(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateApplicationVersion

        /// <summary>
        /// <para>Creates an application version for the specified application.</para> <para><b>NOTE:</b>Once you create an application version with a
        /// specified Amazon S3 bucket and key location, you cannot change that Amazon S3 location. If you change the Amazon S3 location, you receive an
        /// exception when you attempt to launch an environment from the application version. </para>
        /// </summary>
        /// 
        /// <param name="createApplicationVersionRequest">Container for the necessary parameters to execute the CreateApplicationVersion service method
        ///          on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="TooManyApplicationsException"/>
        /// <exception cref="TooManyApplicationVersionsException"/>
        CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest createApplicationVersionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="createApplicationVersionRequest">Container for the necessary parameters to execute the CreateApplicationVersion operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateApplicationVersion operation.</returns>
        IAsyncResult BeginCreateApplicationVersion(CreateApplicationVersionRequest createApplicationVersionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationVersion.</param>
        /// 
        /// <returns>Returns a CreateApplicationVersionResult from AmazonElasticBeanstalk.</returns>
        CreateApplicationVersionResponse EndCreateApplicationVersion(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteApplicationVersion

        /// <summary>
        /// <para> Deletes the specified version from the specified application. </para> <para><b>NOTE:</b>You cannot delete an application version that
        /// is associated with a running environment.</para>
        /// </summary>
        /// 
        /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion service method
        ///          on AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="SourceBundleDeletionException"/>
        DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest deleteApplicationVersionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteApplicationVersion(DeleteApplicationVersionRequest deleteApplicationVersionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationVersion.</param>
        DeleteApplicationVersionResponse EndDeleteApplicationVersion(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeApplicationVersions

        /// <summary>
        /// <para>Returns descriptions for existing application versions.</para>
        /// </summary>
        /// 
        /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest describeApplicationVersionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeApplicationVersions"/>
        /// </summary>
        /// 
        /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeApplicationVersions operation.</returns>
        IAsyncResult BeginDescribeApplicationVersions(DescribeApplicationVersionsRequest describeApplicationVersionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeApplicationVersions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeApplicationVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationVersions.</param>
        /// 
        /// <returns>Returns a DescribeApplicationVersionsResult from AmazonElasticBeanstalk.</returns>
        DescribeApplicationVersionsResponse EndDescribeApplicationVersions(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns descriptions for existing application versions.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeApplicationVersionsResponse DescribeApplicationVersions();
        
        #endregion
        
    

        #region DeleteApplication

        /// <summary>
        /// <para> Deletes the specified application along with all associated versions and configurations. </para> <para><b>NOTE:</b>You cannot delete
        /// an application that has a running environment. </para>
        /// </summary>
        /// 
        /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteApplication"/>
        /// </summary>
        /// 
        /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest deleteApplicationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateApplicationVersion

        /// <summary>
        /// <para> Updates the specified application version to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
        /// description) is not provided, the value remains unchanged. To clear properties, specify an empty string. </para>
        /// </summary>
        /// 
        /// <param name="updateApplicationVersionRequest">Container for the necessary parameters to execute the UpdateApplicationVersion service method
        ///          on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest updateApplicationVersionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="updateApplicationVersionRequest">Container for the necessary parameters to execute the UpdateApplicationVersion operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateApplicationVersion operation.</returns>
        IAsyncResult BeginUpdateApplicationVersion(UpdateApplicationVersionRequest updateApplicationVersionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationVersion.</param>
        /// 
        /// <returns>Returns a UpdateApplicationVersionResult from AmazonElasticBeanstalk.</returns>
        UpdateApplicationVersionResponse EndUpdateApplicationVersion(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateApplication

        /// <summary>
        /// <para> Creates an application that has one configuration template named <c>default</c> and no application versions. </para>
        /// <para><b>NOTE:</b> The default configuration template is for a 32-bit version of the Amazon Linux operating system running the Tomcat 6
        /// application container. </para>
        /// </summary>
        /// 
        /// <param name="createApplicationRequest">Container for the necessary parameters to execute the CreateApplication service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="TooManyApplicationsException"/>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest createApplicationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateApplication"/>
        /// </summary>
        /// 
        /// <param name="createApplicationRequest">Container for the necessary parameters to execute the CreateApplication operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest createApplicationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a CreateApplicationResult from AmazonElasticBeanstalk.</returns>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SwapEnvironmentCNAMEs

        /// <summary>
        /// <para> Swaps the CNAMEs of two environments. </para>
        /// </summary>
        /// 
        /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.SwapEnvironmentCNAMEs"/>
        /// </summary>
        /// 
        /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.SwapEnvironmentCNAMEs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSwapEnvironmentCNAMEs.</param>
        SwapEnvironmentCNAMEsResponse EndSwapEnvironmentCNAMEs(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateConfigurationTemplate

        /// <summary>
        /// <para> Updates the specified configuration template to have the specified properties or configuration option values. </para>
        /// <para><b>NOTE:</b> If a property (for example, ApplicationName) is not provided, its value remains unchanged. To clear such properties,
        /// specify an empty string. </para> <para>Related Topics</para>
        /// <ul>
        /// <li> DescribeConfigurationOptions </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="updateConfigurationTemplateRequest">Container for the necessary parameters to execute the UpdateConfigurationTemplate service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="updateConfigurationTemplateRequest">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateConfigurationTemplate operation.</returns>
        IAsyncResult BeginUpdateConfigurationTemplate(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a UpdateConfigurationTemplateResult from AmazonElasticBeanstalk.</returns>
        UpdateConfigurationTemplateResponse EndUpdateConfigurationTemplate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RetrieveEnvironmentInfo

        /// <summary>
        /// <para> Retrieves the compiled information from a RequestEnvironmentInfo request. </para> <para>Related Topics</para>
        /// <ul>
        /// <li> RequestEnvironmentInfo </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="retrieveEnvironmentInfoRequest">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RetrieveEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="retrieveEnvironmentInfoRequest">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRetrieveEnvironmentInfo operation.</returns>
        IAsyncResult BeginRetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RetrieveEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a RetrieveEnvironmentInfoResult from AmazonElasticBeanstalk.</returns>
        RetrieveEnvironmentInfoResponse EndRetrieveEnvironmentInfo(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListAvailableSolutionStacks

        /// <summary>
        /// <para> Returns a list of the available solution stack names. </para>
        /// </summary>
        /// 
        /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.ListAvailableSolutionStacks"/>
        /// </summary>
        /// 
        /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListAvailableSolutionStacks operation.</returns>
        IAsyncResult BeginListAvailableSolutionStacks(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.ListAvailableSolutionStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableSolutionStacks.</param>
        /// 
        /// <returns>Returns a ListAvailableSolutionStacksResult from AmazonElasticBeanstalk.</returns>
        ListAvailableSolutionStacksResponse EndListAvailableSolutionStacks(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of the available solution stack names. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        ListAvailableSolutionStacksResponse ListAvailableSolutionStacks();
        
        #endregion
        
    

        #region UpdateApplication

        /// <summary>
        /// <para>Updates the specified application to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
        /// description) is not provided, the value remains unchanged. To clear these properties, specify an empty string. </para>
        /// </summary>
        /// 
        /// <param name="updateApplicationRequest">Container for the necessary parameters to execute the UpdateApplication service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateApplication"/>
        /// </summary>
        /// 
        /// <param name="updateApplicationRequest">Container for the necessary parameters to execute the UpdateApplication operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest updateApplicationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a UpdateApplicationResult from AmazonElasticBeanstalk.</returns>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeEnvironments

        /// <summary>
        /// <para>Returns descriptions for existing environments.</para>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest describeEnvironmentsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeEnvironments"/>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEnvironments operation.</returns>
        IAsyncResult BeginDescribeEnvironments(DescribeEnvironmentsRequest describeEnvironmentsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEnvironments operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeEnvironments"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironments.</param>
        /// 
        /// <returns>Returns a DescribeEnvironmentsResult from AmazonElasticBeanstalk.</returns>
        DescribeEnvironmentsResponse EndDescribeEnvironments(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns descriptions for existing environments.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeEnvironmentsResponse DescribeEnvironments();
        
        #endregion
        
    

        #region DescribeEnvironmentResources

        /// <summary>
        /// <para>Returns AWS resources for this environment.</para>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeEnvironmentResources"/>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEnvironmentResources operation.</returns>
        IAsyncResult BeginDescribeEnvironmentResources(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEnvironmentResources operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeEnvironmentResources"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentResources.</param>
        /// 
        /// <returns>Returns a DescribeEnvironmentResourcesResult from AmazonElasticBeanstalk.</returns>
        DescribeEnvironmentResourcesResponse EndDescribeEnvironmentResources(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region TerminateEnvironment

        /// <summary>
        /// <para> Terminates the specified environment. </para>
        /// </summary>
        /// 
        /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest terminateEnvironmentRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.TerminateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndTerminateEnvironment operation.</returns>
        IAsyncResult BeginTerminateEnvironment(TerminateEnvironmentRequest terminateEnvironmentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.TerminateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateEnvironment.</param>
        /// 
        /// <returns>Returns a TerminateEnvironmentResult from AmazonElasticBeanstalk.</returns>
        TerminateEnvironmentResponse EndTerminateEnvironment(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ValidateConfigurationSettings

        /// <summary>
        /// <para> Takes a set of configuration settings and either a configuration template or environment, and determines whether those values are
        /// valid. </para> <para> This action returns a list of messages indicating any errors or warnings associated with the selection of option
        /// values. </para>
        /// </summary>
        /// 
        /// <param name="validateConfigurationSettingsRequest">Container for the necessary parameters to execute the ValidateConfigurationSettings
        ///          service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.ValidateConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="validateConfigurationSettingsRequest">Container for the necessary parameters to execute the ValidateConfigurationSettings
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndValidateConfigurationSettings operation.</returns>
        IAsyncResult BeginValidateConfigurationSettings(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ValidateConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.ValidateConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateConfigurationSettings.</param>
        /// 
        /// <returns>Returns a ValidateConfigurationSettingsResult from AmazonElasticBeanstalk.</returns>
        ValidateConfigurationSettingsResponse EndValidateConfigurationSettings(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RestartAppServer

        /// <summary>
        /// <para> Causes the environment to restart the application container server running on each Amazon EC2 instance. </para>
        /// </summary>
        /// 
        /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        RestartAppServerResponse RestartAppServer(RestartAppServerRequest restartAppServerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RestartAppServer"/>
        /// </summary>
        /// 
        /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRestartAppServer(RestartAppServerRequest restartAppServerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RestartAppServer operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RestartAppServer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartAppServer.</param>
        RestartAppServerResponse EndRestartAppServer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteEnvironmentConfiguration

        /// <summary>
        /// <para> Deletes the draft configuration associated with the running environment. </para> <para> Updating a running environment with any
        /// configuration changes creates a draft configuration set. You can get the draft configuration using DescribeConfigurationSettings while the
        /// update is in progress or if the update fails. The <c>DeploymentStatus</c> for the draft configuration indicates whether the deployment is in
        /// process or has failed. The draft configuration remains in existence until it is deleted with this action. </para>
        /// </summary>
        /// 
        /// <param name="deleteEnvironmentConfigurationRequest">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration
        ///          service method on AmazonElasticBeanstalk.</param>
        /// 
        DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteEnvironmentConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteEnvironmentConfigurationRequest">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DeleteEnvironmentConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentConfiguration.</param>
        DeleteEnvironmentConfigurationResponse EndDeleteEnvironmentConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateEnvironment

        /// <summary>
        /// <para> Updates the environment description, deploys a new application version, updates the configuration settings to an entirely new
        /// configuration template, or updates select configuration option values in the running environment. </para> <para> Attempting to update both
        /// the release and configuration is not allowed and AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. </para> <para>
        /// When updating the configuration settings to a new template or individual settings, a draft configuration is created and
        /// DescribeConfigurationSettings for this environment returns two setting descriptions with different <c>DeploymentStatus</c> values. </para>
        /// </summary>
        /// 
        /// <param name="updateEnvironmentRequest">Container for the necessary parameters to execute the UpdateEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="updateEnvironmentRequest">Container for the necessary parameters to execute the UpdateEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.UpdateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a UpdateEnvironmentResult from AmazonElasticBeanstalk.</returns>
        UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateConfigurationTemplate

        /// <summary>
        /// <para>Creates a configuration template. Templates are associated with a specific application and are used to deploy different versions of
        /// the application with the same configuration settings.</para> <para>Related Topics</para>
        /// <ul>
        /// <li> DescribeConfigurationOptions </li>
        /// <li> DescribeConfigurationSettings </li>
        /// <li> ListAvailableSolutionStacks </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="createConfigurationTemplateRequest">Container for the necessary parameters to execute the CreateConfigurationTemplate service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="TooManyConfigurationTemplatesException"/>
        CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="createConfigurationTemplateRequest">Container for the necessary parameters to execute the CreateConfigurationTemplate operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateConfigurationTemplate operation.</returns>
        IAsyncResult BeginCreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CreateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a CreateConfigurationTemplateResult from AmazonElasticBeanstalk.</returns>
        CreateConfigurationTemplateResponse EndCreateConfigurationTemplate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeConfigurationSettings

        /// <summary>
        /// <para> Returns a description of the settings for the specified configuration set, that is, either a configuration template or the
        /// configuration set associated with a running environment. </para> <para> When describing the settings for the configuration set associated
        /// with a running environment, it is possible to receive two sets of setting descriptions. One is the deployed configuration set, and the other
        /// is a draft configuration of an environment that is either in the process of deployment or that failed to deploy. </para> <para>Related
        /// Topics</para>
        /// <ul>
        /// <li> DeleteEnvironmentConfiguration </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="describeConfigurationSettingsRequest">Container for the necessary parameters to execute the DescribeConfigurationSettings
        ///          service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="describeConfigurationSettingsRequest">Container for the necessary parameters to execute the DescribeConfigurationSettings
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConfigurationSettings operation.</returns>
        IAsyncResult BeginDescribeConfigurationSettings(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationSettings.</param>
        /// 
        /// <returns>Returns a DescribeConfigurationSettingsResult from AmazonElasticBeanstalk.</returns>
        DescribeConfigurationSettingsResponse EndDescribeConfigurationSettings(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeApplications

        /// <summary>
        /// <para>Returns the descriptions of existing applications.</para>
        /// </summary>
        /// 
        /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest describeApplicationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeApplications"/>
        /// </summary>
        /// 
        /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeApplications operation.</returns>
        IAsyncResult BeginDescribeApplications(DescribeApplicationsRequest describeApplicationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeApplications operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeApplications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplications.</param>
        /// 
        /// <returns>Returns a DescribeApplicationsResult from AmazonElasticBeanstalk.</returns>
        DescribeApplicationsResponse EndDescribeApplications(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns the descriptions of existing applications.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeApplicationsResponse DescribeApplications();
        
        #endregion
        
    

        #region RebuildEnvironment

        /// <summary>
        /// <para> Deletes and recreates all of the AWS resources (for example: the Auto Scaling group, load balancer, etc.) for a specified environment
        /// and forces a restart. </para>
        /// </summary>
        /// 
        /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest rebuildEnvironmentRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RebuildEnvironment"/>
        /// </summary>
        /// 
        /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRebuildEnvironment(RebuildEnvironmentRequest rebuildEnvironmentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RebuildEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.RebuildEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildEnvironment.</param>
        RebuildEnvironmentResponse EndRebuildEnvironment(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeEvents

        /// <summary>
        /// <para>Returns list of event descriptions matching criteria up to the last 6 weeks.</para> <para><b>NOTE:</b> This action returns the most
        /// recent 1,000 events from the specified NextToken. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a DescribeEventsResult from AmazonElasticBeanstalk.</returns>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns list of event descriptions matching criteria up to the last 6 weeks.</para> <para><b>NOTE:</b> This action returns the most
        /// recent 1,000 events from the specified NextToken. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        DescribeEventsResponse DescribeEvents();
        
        #endregion
        
    
    }
}
    
