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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Greengrass.Model;

namespace Amazon.Greengrass
{
    /// <summary>
    /// Interface for accessing Greengrass
    ///
    /// AWS Greengrass seamlessly extends AWS onto physical devices so they can act locally
    /// on the data they generate, while still using the cloud for management, analytics,
    /// and durable storage. AWS Greengrass ensures your devices can respond quickly to local
    /// events and operate with intermittent connectivity. AWS Greengrass minimizes the cost
    /// of transmitting data to the cloud by allowing you to author AWS Lambda functions that
    /// execute locally.
    /// </summary>
    public partial interface IAmazonGreengrass : IAmazonService, IDisposable
    {

        
        #region  AssociateRoleToGroup


        /// <summary>
        /// Associates a role with a group. Your AWS Greengrass core will use the role to access
        /// AWS cloud services. The role's permissions should allow Greengrass core Lambda functions
        /// to perform actions against the cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoleToGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateRoleToGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        AssociateRoleToGroupResponse AssociateRoleToGroup(AssociateRoleToGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRoleToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRoleToGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateRoleToGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        IAsyncResult BeginAssociateRoleToGroup(AssociateRoleToGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRoleToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRoleToGroup.</param>
        /// 
        /// <returns>Returns a  AssociateRoleToGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateRoleToGroup">REST API Reference for AssociateRoleToGroup Operation</seealso>
        AssociateRoleToGroupResponse EndAssociateRoleToGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateServiceRoleToAccount


        /// <summary>
        /// Associates a role with your account. AWS Greengrass will use the role to access your
        /// Lambda functions and AWS IoT resources. This is necessary for deployments to succeed.
        /// The role must have at least minimum permissions in the policy ''AWSGreengrassResourceAccessRolePolicy''.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceRoleToAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        AssociateServiceRoleToAccountResponse AssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateServiceRoleToAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceRoleToAccount operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateServiceRoleToAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        IAsyncResult BeginAssociateServiceRoleToAccount(AssociateServiceRoleToAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateServiceRoleToAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateServiceRoleToAccount.</param>
        /// 
        /// <returns>Returns a  AssociateServiceRoleToAccountResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/AssociateServiceRoleToAccount">REST API Reference for AssociateServiceRoleToAccount Operation</seealso>
        AssociateServiceRoleToAccountResponse EndAssociateServiceRoleToAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCoreDefinition


        /// <summary>
        /// Creates a core definition. You may provide the initial version of the core definition
        /// now or use ''CreateCoreDefinitionVersion'' at a later time. AWS Greengrass groups
        /// must each contain exactly one AWS Greengrass core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        CreateCoreDefinitionResponse CreateCoreDefinition(CreateCoreDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        IAsyncResult BeginCreateCoreDefinition(CreateCoreDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCoreDefinition.</param>
        /// 
        /// <returns>Returns a  CreateCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinition">REST API Reference for CreateCoreDefinition Operation</seealso>
        CreateCoreDefinitionResponse EndCreateCoreDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCoreDefinitionVersion


        /// <summary>
        /// Creates a version of a core definition that has already been defined. AWS Greengrass
        /// groups must each contain exactly one AWS Greengrass core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateCoreDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        CreateCoreDefinitionVersionResponse CreateCoreDefinitionVersion(CreateCoreDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCoreDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        IAsyncResult BeginCreateCoreDefinitionVersion(CreateCoreDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCoreDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateCoreDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateCoreDefinitionVersion">REST API Reference for CreateCoreDefinitionVersion Operation</seealso>
        CreateCoreDefinitionVersionResponse EndCreateCoreDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Creates a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeviceDefinition


        /// <summary>
        /// Creates a device definition. You may provide the initial version of the device definition
        /// now or use ''CreateDeviceDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        CreateDeviceDefinitionResponse CreateDeviceDefinition(CreateDeviceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        IAsyncResult BeginCreateDeviceDefinition(CreateDeviceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  CreateDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinition">REST API Reference for CreateDeviceDefinition Operation</seealso>
        CreateDeviceDefinitionResponse EndCreateDeviceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeviceDefinitionVersion


        /// <summary>
        /// Creates a version of a device definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        CreateDeviceDefinitionVersionResponse CreateDeviceDefinitionVersion(CreateDeviceDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        IAsyncResult BeginCreateDeviceDefinitionVersion(CreateDeviceDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateDeviceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateDeviceDefinitionVersion">REST API Reference for CreateDeviceDefinitionVersion Operation</seealso>
        CreateDeviceDefinitionVersionResponse EndCreateDeviceDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFunctionDefinition


        /// <summary>
        /// Creates a Lambda function definition which contains a list of Lambda functions and
        /// their configurations to be used in a group. You can create an initial version of the
        /// definition by providing a list of Lambda functions and their configurations now, or
        /// use ''CreateFunctionDefinitionVersion'' later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        CreateFunctionDefinitionResponse CreateFunctionDefinition(CreateFunctionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        IAsyncResult BeginCreateFunctionDefinition(CreateFunctionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  CreateFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinition">REST API Reference for CreateFunctionDefinition Operation</seealso>
        CreateFunctionDefinitionResponse EndCreateFunctionDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFunctionDefinitionVersion


        /// <summary>
        /// Creates a version of a Lambda function definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateFunctionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        CreateFunctionDefinitionVersionResponse CreateFunctionDefinitionVersion(CreateFunctionDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunctionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        IAsyncResult BeginCreateFunctionDefinitionVersion(CreateFunctionDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunctionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateFunctionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateFunctionDefinitionVersion">REST API Reference for CreateFunctionDefinitionVersion Operation</seealso>
        CreateFunctionDefinitionVersionResponse EndCreateFunctionDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a group. You may provide the initial version of the group or use ''CreateGroupVersion''
        /// at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroupCertificateAuthority


        /// <summary>
        /// Creates a CA for the group. If a CA already exists, it will rotate the existing CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the CreateGroupCertificateAuthority service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        CreateGroupCertificateAuthorityResponse CreateGroupCertificateAuthority(CreateGroupCertificateAuthorityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupCertificateAuthority operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        IAsyncResult BeginCreateGroupCertificateAuthority(CreateGroupCertificateAuthorityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  CreateGroupCertificateAuthorityResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupCertificateAuthority">REST API Reference for CreateGroupCertificateAuthority Operation</seealso>
        CreateGroupCertificateAuthorityResponse EndCreateGroupCertificateAuthority(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroupVersion


        /// <summary>
        /// Creates a version of a group which has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupVersion service method.</param>
        /// 
        /// <returns>The response from the CreateGroupVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        CreateGroupVersionResponse CreateGroupVersion(CreateGroupVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        IAsyncResult BeginCreateGroupVersion(CreateGroupVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupVersion.</param>
        /// 
        /// <returns>Returns a  CreateGroupVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateGroupVersion">REST API Reference for CreateGroupVersion Operation</seealso>
        CreateGroupVersionResponse EndCreateGroupVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoggerDefinition


        /// <summary>
        /// Creates a logger definition. You may provide the initial version of the logger definition
        /// now or use ''CreateLoggerDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        CreateLoggerDefinitionResponse CreateLoggerDefinition(CreateLoggerDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        IAsyncResult BeginCreateLoggerDefinition(CreateLoggerDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  CreateLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinition">REST API Reference for CreateLoggerDefinition Operation</seealso>
        CreateLoggerDefinitionResponse EndCreateLoggerDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoggerDefinitionVersion


        /// <summary>
        /// Creates a version of a logger definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateLoggerDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        CreateLoggerDefinitionVersionResponse CreateLoggerDefinitionVersion(CreateLoggerDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggerDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoggerDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        IAsyncResult BeginCreateLoggerDefinitionVersion(CreateLoggerDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoggerDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateLoggerDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateLoggerDefinitionVersion">REST API Reference for CreateLoggerDefinitionVersion Operation</seealso>
        CreateLoggerDefinitionVersionResponse EndCreateLoggerDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourceDefinition


        /// <summary>
        /// Creates a resource definition which contains a list of resources to be used in a group.
        /// You can create an initial version of the definition by providing a list of resources
        /// now, or use ''CreateResourceDefinitionVersion'' later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        CreateResourceDefinitionResponse CreateResourceDefinition(CreateResourceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        IAsyncResult BeginCreateResourceDefinition(CreateResourceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceDefinition.</param>
        /// 
        /// <returns>Returns a  CreateResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinition">REST API Reference for CreateResourceDefinition Operation</seealso>
        CreateResourceDefinitionResponse EndCreateResourceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourceDefinitionVersion


        /// <summary>
        /// Creates a version of a resource definition that has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateResourceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        CreateResourceDefinitionVersionResponse CreateResourceDefinitionVersion(CreateResourceDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        IAsyncResult BeginCreateResourceDefinitionVersion(CreateResourceDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateResourceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateResourceDefinitionVersion">REST API Reference for CreateResourceDefinitionVersion Operation</seealso>
        CreateResourceDefinitionVersionResponse EndCreateResourceDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSoftwareUpdateJob


        /// <summary>
        /// Creates a software update for a core or group of cores (specified as an IoT thing
        /// group.) Use this to update the OTA Agent as well as the Greengrass core software.
        /// It makes use of the IoT Jobs feature which provides additional commands to manage
        /// a Greengrass core software update job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSoftwareUpdateJob service method.</param>
        /// 
        /// <returns>The response from the CreateSoftwareUpdateJob service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        CreateSoftwareUpdateJobResponse CreateSoftwareUpdateJob(CreateSoftwareUpdateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSoftwareUpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSoftwareUpdateJob operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSoftwareUpdateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        IAsyncResult BeginCreateSoftwareUpdateJob(CreateSoftwareUpdateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSoftwareUpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSoftwareUpdateJob.</param>
        /// 
        /// <returns>Returns a  CreateSoftwareUpdateJobResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSoftwareUpdateJob">REST API Reference for CreateSoftwareUpdateJob Operation</seealso>
        CreateSoftwareUpdateJobResponse EndCreateSoftwareUpdateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubscriptionDefinition


        /// <summary>
        /// Creates a subscription definition. You may provide the initial version of the subscription
        /// definition now or use ''CreateSubscriptionDefinitionVersion'' at a later time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        CreateSubscriptionDefinitionResponse CreateSubscriptionDefinition(CreateSubscriptionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        IAsyncResult BeginCreateSubscriptionDefinition(CreateSubscriptionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinition">REST API Reference for CreateSubscriptionDefinition Operation</seealso>
        CreateSubscriptionDefinitionResponse EndCreateSubscriptionDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubscriptionDefinitionVersion


        /// <summary>
        /// Creates a version of a subscription definition which has already been defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        CreateSubscriptionDefinitionVersionResponse CreateSubscriptionDefinitionVersion(CreateSubscriptionDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        IAsyncResult BeginCreateSubscriptionDefinitionVersion(CreateSubscriptionDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/CreateSubscriptionDefinitionVersion">REST API Reference for CreateSubscriptionDefinitionVersion Operation</seealso>
        CreateSubscriptionDefinitionVersionResponse EndCreateSubscriptionDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCoreDefinition


        /// <summary>
        /// Deletes a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        DeleteCoreDefinitionResponse DeleteCoreDefinition(DeleteCoreDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        IAsyncResult BeginDeleteCoreDefinition(DeleteCoreDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteCoreDefinition">REST API Reference for DeleteCoreDefinition Operation</seealso>
        DeleteCoreDefinitionResponse EndDeleteCoreDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDeviceDefinition


        /// <summary>
        /// Deletes a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        DeleteDeviceDefinitionResponse DeleteDeviceDefinition(DeleteDeviceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        IAsyncResult BeginDeleteDeviceDefinition(DeleteDeviceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteDeviceDefinition">REST API Reference for DeleteDeviceDefinition Operation</seealso>
        DeleteDeviceDefinitionResponse EndDeleteDeviceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFunctionDefinition


        /// <summary>
        /// Deletes a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        DeleteFunctionDefinitionResponse DeleteFunctionDefinition(DeleteFunctionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        IAsyncResult BeginDeleteFunctionDefinition(DeleteFunctionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteFunctionDefinition">REST API Reference for DeleteFunctionDefinition Operation</seealso>
        DeleteFunctionDefinitionResponse EndDeleteFunctionDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoggerDefinition


        /// <summary>
        /// Deletes a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        DeleteLoggerDefinitionResponse DeleteLoggerDefinition(DeleteLoggerDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        IAsyncResult BeginDeleteLoggerDefinition(DeleteLoggerDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteLoggerDefinition">REST API Reference for DeleteLoggerDefinition Operation</seealso>
        DeleteLoggerDefinitionResponse EndDeleteLoggerDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourceDefinition


        /// <summary>
        /// Deletes a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        DeleteResourceDefinitionResponse DeleteResourceDefinition(DeleteResourceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        IAsyncResult BeginDeleteResourceDefinition(DeleteResourceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteResourceDefinition">REST API Reference for DeleteResourceDefinition Operation</seealso>
        DeleteResourceDefinitionResponse EndDeleteResourceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubscriptionDefinition


        /// <summary>
        /// Deletes a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        DeleteSubscriptionDefinitionResponse DeleteSubscriptionDefinition(DeleteSubscriptionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        IAsyncResult BeginDeleteSubscriptionDefinition(DeleteSubscriptionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DeleteSubscriptionDefinition">REST API Reference for DeleteSubscriptionDefinition Operation</seealso>
        DeleteSubscriptionDefinitionResponse EndDeleteSubscriptionDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateRoleFromGroup


        /// <summary>
        /// Disassociates the role from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoleFromGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateRoleFromGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        DisassociateRoleFromGroupResponse DisassociateRoleFromGroup(DisassociateRoleFromGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRoleFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRoleFromGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRoleFromGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        IAsyncResult BeginDisassociateRoleFromGroup(DisassociateRoleFromGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRoleFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRoleFromGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateRoleFromGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateRoleFromGroup">REST API Reference for DisassociateRoleFromGroup Operation</seealso>
        DisassociateRoleFromGroupResponse EndDisassociateRoleFromGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateServiceRoleFromAccount


        /// <summary>
        /// Disassociates the service role from your account. Without a service role, deployments
        /// will not work.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceRoleFromAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        DisassociateServiceRoleFromAccountResponse DisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateServiceRoleFromAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceRoleFromAccount operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateServiceRoleFromAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        IAsyncResult BeginDisassociateServiceRoleFromAccount(DisassociateServiceRoleFromAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateServiceRoleFromAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateServiceRoleFromAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateServiceRoleFromAccountResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/DisassociateServiceRoleFromAccount">REST API Reference for DisassociateServiceRoleFromAccount Operation</seealso>
        DisassociateServiceRoleFromAccountResponse EndDisassociateServiceRoleFromAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssociatedRole


        /// <summary>
        /// Retrieves the role associated with a particular group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedRole service method.</param>
        /// 
        /// <returns>The response from the GetAssociatedRole service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        GetAssociatedRoleResponse GetAssociatedRole(GetAssociatedRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssociatedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedRole operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssociatedRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        IAsyncResult BeginGetAssociatedRole(GetAssociatedRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssociatedRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssociatedRole.</param>
        /// 
        /// <returns>Returns a  GetAssociatedRoleResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetAssociatedRole">REST API Reference for GetAssociatedRole Operation</seealso>
        GetAssociatedRoleResponse EndGetAssociatedRole(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectivityInfo


        /// <summary>
        /// Retrieves the connectivity information for a core.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo service method.</param>
        /// 
        /// <returns>The response from the GetConnectivityInfo service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        GetConnectivityInfoResponse GetConnectivityInfo(GetConnectivityInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectivityInfo operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectivityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        IAsyncResult BeginGetConnectivityInfo(GetConnectivityInfoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectivityInfo.</param>
        /// 
        /// <returns>Returns a  GetConnectivityInfoResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetConnectivityInfo">REST API Reference for GetConnectivityInfo Operation</seealso>
        GetConnectivityInfoResponse EndGetConnectivityInfo(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCoreDefinition


        /// <summary>
        /// Retrieves information about a core definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the GetCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        GetCoreDefinitionResponse GetCoreDefinition(GetCoreDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        IAsyncResult BeginGetCoreDefinition(GetCoreDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreDefinition.</param>
        /// 
        /// <returns>Returns a  GetCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinition">REST API Reference for GetCoreDefinition Operation</seealso>
        GetCoreDefinitionResponse EndGetCoreDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCoreDefinitionVersion


        /// <summary>
        /// Retrieves information about a core definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetCoreDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        GetCoreDefinitionVersionResponse GetCoreDefinitionVersion(GetCoreDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        IAsyncResult BeginGetCoreDefinitionVersion(GetCoreDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetCoreDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetCoreDefinitionVersion">REST API Reference for GetCoreDefinitionVersion Operation</seealso>
        GetCoreDefinitionVersionResponse EndGetCoreDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeploymentStatus


        /// <summary>
        /// Returns the status of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStatus service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentStatus service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        GetDeploymentStatusResponse GetDeploymentStatus(GetDeploymentStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStatus operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeploymentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        IAsyncResult BeginGetDeploymentStatus(GetDeploymentStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeploymentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeploymentStatus.</param>
        /// 
        /// <returns>Returns a  GetDeploymentStatusResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeploymentStatus">REST API Reference for GetDeploymentStatus Operation</seealso>
        GetDeploymentStatusResponse EndGetDeploymentStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeviceDefinition


        /// <summary>
        /// Retrieves information about a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the GetDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        GetDeviceDefinitionResponse GetDeviceDefinition(GetDeviceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        IAsyncResult BeginGetDeviceDefinition(GetDeviceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  GetDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinition">REST API Reference for GetDeviceDefinition Operation</seealso>
        GetDeviceDefinitionResponse EndGetDeviceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeviceDefinitionVersion


        /// <summary>
        /// Retrieves information about a device definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetDeviceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        GetDeviceDefinitionVersionResponse GetDeviceDefinitionVersion(GetDeviceDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        IAsyncResult BeginGetDeviceDefinitionVersion(GetDeviceDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetDeviceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetDeviceDefinitionVersion">REST API Reference for GetDeviceDefinitionVersion Operation</seealso>
        GetDeviceDefinitionVersionResponse EndGetDeviceDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFunctionDefinition


        /// <summary>
        /// Retrieves information about a Lambda function definition, including its creation time
        /// and latest version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the GetFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        GetFunctionDefinitionResponse GetFunctionDefinition(GetFunctionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        IAsyncResult BeginGetFunctionDefinition(GetFunctionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  GetFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinition">REST API Reference for GetFunctionDefinition Operation</seealso>
        GetFunctionDefinitionResponse EndGetFunctionDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFunctionDefinitionVersion


        /// <summary>
        /// Retrieves information about a Lambda function definition version, including which
        /// Lambda functions are included in the version and their configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetFunctionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        GetFunctionDefinitionVersionResponse GetFunctionDefinitionVersion(GetFunctionDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        IAsyncResult BeginGetFunctionDefinitionVersion(GetFunctionDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetFunctionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetFunctionDefinitionVersion">REST API Reference for GetFunctionDefinitionVersion Operation</seealso>
        GetFunctionDefinitionVersionResponse EndGetFunctionDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Retrieves information about a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupCertificateAuthority


        /// <summary>
        /// Retreives the CA associated with a group. Returns the public key of the CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the GetGroupCertificateAuthority service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        GetGroupCertificateAuthorityResponse GetGroupCertificateAuthority(GetGroupCertificateAuthorityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateAuthority operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        IAsyncResult BeginGetGroupCertificateAuthority(GetGroupCertificateAuthorityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  GetGroupCertificateAuthorityResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateAuthority">REST API Reference for GetGroupCertificateAuthority Operation</seealso>
        GetGroupCertificateAuthorityResponse EndGetGroupCertificateAuthority(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupCertificateConfiguration


        /// <summary>
        /// Retrieves the current configuration for the CA used by the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetGroupCertificateConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        GetGroupCertificateConfigurationResponse GetGroupCertificateConfiguration(GetGroupCertificateConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupCertificateConfiguration operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupCertificateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        IAsyncResult BeginGetGroupCertificateConfiguration(GetGroupCertificateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupCertificateConfiguration.</param>
        /// 
        /// <returns>Returns a  GetGroupCertificateConfigurationResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupCertificateConfiguration">REST API Reference for GetGroupCertificateConfiguration Operation</seealso>
        GetGroupCertificateConfigurationResponse EndGetGroupCertificateConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupVersion


        /// <summary>
        /// Retrieves information about a group version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupVersion service method.</param>
        /// 
        /// <returns>The response from the GetGroupVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        GetGroupVersionResponse GetGroupVersion(GetGroupVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        IAsyncResult BeginGetGroupVersion(GetGroupVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupVersion.</param>
        /// 
        /// <returns>Returns a  GetGroupVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetGroupVersion">REST API Reference for GetGroupVersion Operation</seealso>
        GetGroupVersionResponse EndGetGroupVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLoggerDefinition


        /// <summary>
        /// Retrieves information about a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the GetLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        GetLoggerDefinitionResponse GetLoggerDefinition(GetLoggerDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        IAsyncResult BeginGetLoggerDefinition(GetLoggerDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  GetLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinition">REST API Reference for GetLoggerDefinition Operation</seealso>
        GetLoggerDefinitionResponse EndGetLoggerDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLoggerDefinitionVersion


        /// <summary>
        /// Retrieves information about a logger definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetLoggerDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        GetLoggerDefinitionVersionResponse GetLoggerDefinitionVersion(GetLoggerDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggerDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggerDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        IAsyncResult BeginGetLoggerDefinitionVersion(GetLoggerDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggerDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggerDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetLoggerDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetLoggerDefinitionVersion">REST API Reference for GetLoggerDefinitionVersion Operation</seealso>
        GetLoggerDefinitionVersionResponse EndGetLoggerDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceDefinition


        /// <summary>
        /// Retrieves information about a resource definition, including its creation time and
        /// latest version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the GetResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        GetResourceDefinitionResponse GetResourceDefinition(GetResourceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        IAsyncResult BeginGetResourceDefinition(GetResourceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceDefinition.</param>
        /// 
        /// <returns>Returns a  GetResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinition">REST API Reference for GetResourceDefinition Operation</seealso>
        GetResourceDefinitionResponse EndGetResourceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceDefinitionVersion


        /// <summary>
        /// Retrieves information about a resource definition version, including which resources
        /// are included in the version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetResourceDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        GetResourceDefinitionVersionResponse GetResourceDefinitionVersion(GetResourceDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        IAsyncResult BeginGetResourceDefinitionVersion(GetResourceDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetResourceDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetResourceDefinitionVersion">REST API Reference for GetResourceDefinitionVersion Operation</seealso>
        GetResourceDefinitionVersionResponse EndGetResourceDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceRoleForAccount


        /// <summary>
        /// Retrieves the service role that is attached to your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount service method.</param>
        /// 
        /// <returns>The response from the GetServiceRoleForAccount service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        GetServiceRoleForAccountResponse GetServiceRoleForAccount(GetServiceRoleForAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceRoleForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceRoleForAccount operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceRoleForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        IAsyncResult BeginGetServiceRoleForAccount(GetServiceRoleForAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceRoleForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceRoleForAccount.</param>
        /// 
        /// <returns>Returns a  GetServiceRoleForAccountResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetServiceRoleForAccount">REST API Reference for GetServiceRoleForAccount Operation</seealso>
        GetServiceRoleForAccountResponse EndGetServiceRoleForAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSubscriptionDefinition


        /// <summary>
        /// Retrieves information about a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        GetSubscriptionDefinitionResponse GetSubscriptionDefinition(GetSubscriptionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        IAsyncResult BeginGetSubscriptionDefinition(GetSubscriptionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinition">REST API Reference for GetSubscriptionDefinition Operation</seealso>
        GetSubscriptionDefinitionResponse EndGetSubscriptionDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSubscriptionDefinitionVersion


        /// <summary>
        /// Retrieves information about a subscription definition version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinitionVersion service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionDefinitionVersion service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        GetSubscriptionDefinitionVersionResponse GetSubscriptionDefinitionVersion(GetSubscriptionDefinitionVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionDefinitionVersion operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionDefinitionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        IAsyncResult BeginGetSubscriptionDefinitionVersion(GetSubscriptionDefinitionVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionDefinitionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionDefinitionVersion.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionDefinitionVersionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/GetSubscriptionDefinitionVersion">REST API Reference for GetSubscriptionDefinitionVersion Operation</seealso>
        GetSubscriptionDefinitionVersionResponse EndGetSubscriptionDefinitionVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoreDefinitions


        /// <summary>
        /// Retrieves a list of core definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListCoreDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        ListCoreDefinitionsResponse ListCoreDefinitions(ListCoreDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        IAsyncResult BeginListCoreDefinitions(ListCoreDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreDefinitions.</param>
        /// 
        /// <returns>Returns a  ListCoreDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitions">REST API Reference for ListCoreDefinitions Operation</seealso>
        ListCoreDefinitionsResponse EndListCoreDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoreDefinitionVersions


        /// <summary>
        /// Lists the versions of a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListCoreDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        ListCoreDefinitionVersionsResponse ListCoreDefinitionVersions(ListCoreDefinitionVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        IAsyncResult BeginListCoreDefinitionVersions(ListCoreDefinitionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListCoreDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListCoreDefinitionVersions">REST API Reference for ListCoreDefinitionVersions Operation</seealso>
        ListCoreDefinitionVersionsResponse EndListCoreDefinitionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeployments


        /// <summary>
        /// Returns a history of deployments for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        IAsyncResult BeginListDeployments(ListDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployments.</param>
        /// 
        /// <returns>Returns a  ListDeploymentsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        ListDeploymentsResponse EndListDeployments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeviceDefinitions


        /// <summary>
        /// Retrieves a list of device definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListDeviceDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        ListDeviceDefinitionsResponse ListDeviceDefinitions(ListDeviceDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        IAsyncResult BeginListDeviceDefinitions(ListDeviceDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceDefinitions.</param>
        /// 
        /// <returns>Returns a  ListDeviceDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitions">REST API Reference for ListDeviceDefinitions Operation</seealso>
        ListDeviceDefinitionsResponse EndListDeviceDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeviceDefinitionVersions


        /// <summary>
        /// Lists the versions of a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListDeviceDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        ListDeviceDefinitionVersionsResponse ListDeviceDefinitionVersions(ListDeviceDefinitionVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        IAsyncResult BeginListDeviceDefinitionVersions(ListDeviceDefinitionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListDeviceDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListDeviceDefinitionVersions">REST API Reference for ListDeviceDefinitionVersions Operation</seealso>
        ListDeviceDefinitionVersionsResponse EndListDeviceDefinitionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFunctionDefinitions


        /// <summary>
        /// Retrieves a list of Lambda function definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListFunctionDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        ListFunctionDefinitionsResponse ListFunctionDefinitions(ListFunctionDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctionDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        IAsyncResult BeginListFunctionDefinitions(ListFunctionDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctionDefinitions.</param>
        /// 
        /// <returns>Returns a  ListFunctionDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitions">REST API Reference for ListFunctionDefinitions Operation</seealso>
        ListFunctionDefinitionsResponse EndListFunctionDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFunctionDefinitionVersions


        /// <summary>
        /// Lists the versions of a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListFunctionDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        ListFunctionDefinitionVersionsResponse ListFunctionDefinitionVersions(ListFunctionDefinitionVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctionDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        IAsyncResult BeginListFunctionDefinitionVersions(ListFunctionDefinitionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctionDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListFunctionDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListFunctionDefinitionVersions">REST API Reference for ListFunctionDefinitionVersions Operation</seealso>
        ListFunctionDefinitionVersionsResponse EndListFunctionDefinitionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupCertificateAuthorities


        /// <summary>
        /// Retrieves the current CAs for a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupCertificateAuthorities service method.</param>
        /// 
        /// <returns>The response from the ListGroupCertificateAuthorities service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        ListGroupCertificateAuthoritiesResponse ListGroupCertificateAuthorities(ListGroupCertificateAuthoritiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupCertificateAuthorities operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupCertificateAuthorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        IAsyncResult BeginListGroupCertificateAuthorities(ListGroupCertificateAuthoritiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupCertificateAuthorities.</param>
        /// 
        /// <returns>Returns a  ListGroupCertificateAuthoritiesResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupCertificateAuthorities">REST API Reference for ListGroupCertificateAuthorities Operation</seealso>
        ListGroupCertificateAuthoritiesResponse EndListGroupCertificateAuthorities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Retrieves a list of groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupVersions


        /// <summary>
        /// Lists the versions of a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupVersions service method.</param>
        /// 
        /// <returns>The response from the ListGroupVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        ListGroupVersionsResponse ListGroupVersions(ListGroupVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        IAsyncResult BeginListGroupVersions(ListGroupVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupVersions.</param>
        /// 
        /// <returns>Returns a  ListGroupVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListGroupVersions">REST API Reference for ListGroupVersions Operation</seealso>
        ListGroupVersionsResponse EndListGroupVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLoggerDefinitions


        /// <summary>
        /// Retrieves a list of logger definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListLoggerDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        ListLoggerDefinitionsResponse ListLoggerDefinitions(ListLoggerDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLoggerDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoggerDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        IAsyncResult BeginListLoggerDefinitions(ListLoggerDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoggerDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoggerDefinitions.</param>
        /// 
        /// <returns>Returns a  ListLoggerDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitions">REST API Reference for ListLoggerDefinitions Operation</seealso>
        ListLoggerDefinitionsResponse EndListLoggerDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLoggerDefinitionVersions


        /// <summary>
        /// Lists the versions of a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListLoggerDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        ListLoggerDefinitionVersionsResponse ListLoggerDefinitionVersions(ListLoggerDefinitionVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLoggerDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoggerDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoggerDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        IAsyncResult BeginListLoggerDefinitionVersions(ListLoggerDefinitionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoggerDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoggerDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListLoggerDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListLoggerDefinitionVersions">REST API Reference for ListLoggerDefinitionVersions Operation</seealso>
        ListLoggerDefinitionVersionsResponse EndListLoggerDefinitionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceDefinitions


        /// <summary>
        /// Retrieves a list of resource definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListResourceDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        ListResourceDefinitionsResponse ListResourceDefinitions(ListResourceDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        IAsyncResult BeginListResourceDefinitions(ListResourceDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceDefinitions.</param>
        /// 
        /// <returns>Returns a  ListResourceDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitions">REST API Reference for ListResourceDefinitions Operation</seealso>
        ListResourceDefinitionsResponse EndListResourceDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceDefinitionVersions


        /// <summary>
        /// Lists the versions of a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListResourceDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        ListResourceDefinitionVersionsResponse ListResourceDefinitionVersions(ListResourceDefinitionVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        IAsyncResult BeginListResourceDefinitionVersions(ListResourceDefinitionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListResourceDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListResourceDefinitionVersions">REST API Reference for ListResourceDefinitionVersions Operation</seealso>
        ListResourceDefinitionVersionsResponse EndListResourceDefinitionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscriptionDefinitions


        /// <summary>
        /// Retrieves a list of subscription definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionDefinitions service method, as returned by Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        ListSubscriptionDefinitionsResponse ListSubscriptionDefinitions(ListSubscriptionDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        IAsyncResult BeginListSubscriptionDefinitions(ListSubscriptionDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionDefinitions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionDefinitionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitions">REST API Reference for ListSubscriptionDefinitions Operation</seealso>
        ListSubscriptionDefinitionsResponse EndListSubscriptionDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscriptionDefinitionVersions


        /// <summary>
        /// Lists the versions of a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitionVersions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionDefinitionVersions service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        ListSubscriptionDefinitionVersionsResponse ListSubscriptionDefinitionVersions(ListSubscriptionDefinitionVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionDefinitionVersions operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionDefinitionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        IAsyncResult BeginListSubscriptionDefinitionVersions(ListSubscriptionDefinitionVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionDefinitionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionDefinitionVersions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionDefinitionVersionsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ListSubscriptionDefinitionVersions">REST API Reference for ListSubscriptionDefinitionVersions Operation</seealso>
        ListSubscriptionDefinitionVersionsResponse EndListSubscriptionDefinitionVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetDeployments


        /// <summary>
        /// Resets a group's deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDeployments service method.</param>
        /// 
        /// <returns>The response from the ResetDeployments service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        ResetDeploymentsResponse ResetDeployments(ResetDeploymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDeployments operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        IAsyncResult BeginResetDeployments(ResetDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDeployments.</param>
        /// 
        /// <returns>Returns a  ResetDeploymentsResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/ResetDeployments">REST API Reference for ResetDeployments Operation</seealso>
        ResetDeploymentsResponse EndResetDeployments(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnectivityInfo


        /// <summary>
        /// Updates the connectivity information for the core. Any devices that belong to the
        /// group which has this core will receive this information in order to find the location
        /// of the core and connect to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectivityInfo service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        UpdateConnectivityInfoResponse UpdateConnectivityInfo(UpdateConnectivityInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivityInfo operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectivityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        IAsyncResult BeginUpdateConnectivityInfo(UpdateConnectivityInfoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectivityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectivityInfo.</param>
        /// 
        /// <returns>Returns a  UpdateConnectivityInfoResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateConnectivityInfo">REST API Reference for UpdateConnectivityInfo Operation</seealso>
        UpdateConnectivityInfoResponse EndUpdateConnectivityInfo(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCoreDefinition


        /// <summary>
        /// Updates a core definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateCoreDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        UpdateCoreDefinitionResponse UpdateCoreDefinition(UpdateCoreDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCoreDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        IAsyncResult BeginUpdateCoreDefinition(UpdateCoreDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCoreDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCoreDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateCoreDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateCoreDefinition">REST API Reference for UpdateCoreDefinition Operation</seealso>
        UpdateCoreDefinitionResponse EndUpdateCoreDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDeviceDefinition


        /// <summary>
        /// Updates a device definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        UpdateDeviceDefinitionResponse UpdateDeviceDefinition(UpdateDeviceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeviceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        IAsyncResult BeginUpdateDeviceDefinition(UpdateDeviceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateDeviceDefinition">REST API Reference for UpdateDeviceDefinition Operation</seealso>
        UpdateDeviceDefinitionResponse EndUpdateDeviceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFunctionDefinition


        /// <summary>
        /// Updates a Lambda function definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        UpdateFunctionDefinitionResponse UpdateFunctionDefinition(UpdateFunctionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        IAsyncResult BeginUpdateFunctionDefinition(UpdateFunctionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateFunctionDefinition">REST API Reference for UpdateFunctionDefinition Operation</seealso>
        UpdateFunctionDefinitionResponse EndUpdateFunctionDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroupCertificateConfiguration


        /// <summary>
        /// Updates the Certificate expiry time for a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupCertificateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateGroupCertificateConfiguration service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <exception cref="Amazon.Greengrass.Model.InternalServerErrorException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        UpdateGroupCertificateConfigurationResponse UpdateGroupCertificateConfiguration(UpdateGroupCertificateConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupCertificateConfiguration operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroupCertificateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        IAsyncResult BeginUpdateGroupCertificateConfiguration(UpdateGroupCertificateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroupCertificateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroupCertificateConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateGroupCertificateConfigurationResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateGroupCertificateConfiguration">REST API Reference for UpdateGroupCertificateConfiguration Operation</seealso>
        UpdateGroupCertificateConfigurationResponse EndUpdateGroupCertificateConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLoggerDefinition


        /// <summary>
        /// Updates a logger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggerDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateLoggerDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        UpdateLoggerDefinitionResponse UpdateLoggerDefinition(UpdateLoggerDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggerDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoggerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        IAsyncResult BeginUpdateLoggerDefinition(UpdateLoggerDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoggerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoggerDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateLoggerDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateLoggerDefinition">REST API Reference for UpdateLoggerDefinition Operation</seealso>
        UpdateLoggerDefinitionResponse EndUpdateLoggerDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourceDefinition


        /// <summary>
        /// Updates a resource definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        UpdateResourceDefinitionResponse UpdateResourceDefinition(UpdateResourceDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        IAsyncResult BeginUpdateResourceDefinition(UpdateResourceDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateResourceDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateResourceDefinition">REST API Reference for UpdateResourceDefinition Operation</seealso>
        UpdateResourceDefinitionResponse EndUpdateResourceDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSubscriptionDefinition


        /// <summary>
        /// Updates a subscription definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionDefinition service method, as returned by Greengrass.</returns>
        /// <exception cref="Amazon.Greengrass.Model.BadRequestException">
        /// General error information.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        UpdateSubscriptionDefinitionResponse UpdateSubscriptionDefinition(UpdateSubscriptionDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionDefinition operation on AmazonGreengrassClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriptionDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        IAsyncResult BeginUpdateSubscriptionDefinition(UpdateSubscriptionDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriptionDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriptionDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionDefinitionResult from Greengrass.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrass-2017-06-07/UpdateSubscriptionDefinition">REST API Reference for UpdateSubscriptionDefinition Operation</seealso>
        UpdateSubscriptionDefinitionResponse EndUpdateSubscriptionDefinition(IAsyncResult asyncResult);

        #endregion
        
    }
}