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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SupplyChain.Model;

namespace Amazon.SupplyChain
{
    /// <summary>
    /// <para>Interface for accessing SupplyChain</para>
    ///
    /// AWS Supply Chain is a cloud-based application that works with your enterprise resource
    /// planning (ERP) and supply chain management systems. Using AWS Supply Chain, you can
    /// connect and extract your inventory, supply, and demand related data from existing
    /// ERP or supply chain systems into a single data model. 
    /// 
    ///  
    /// <para>
    /// The AWS Supply Chain API supports configuration data import for Supply Planning.
    /// </para>
    ///  
    /// <para>
    ///  All AWS Supply chain API operations are Amazon-authenticated and certificate-signed.
    /// They not only require the use of the AWS SDK, but also allow for the exclusive use
    /// of AWS Identity and Access Management users and roles to help facilitate access, trust,
    /// and permission policies. 
    /// </para>
    /// </summary>
    public partial interface IAmazonSupplyChain : IAmazonService, IDisposable
    {




        
        #region  CreateBillOfMaterialsImportJob


        /// <summary>
        /// CreateBillOfMaterialsImportJob creates an import job for the Product Bill Of Materials
        /// (BOM) entity. For information on the product_bom entity, see the AWS Supply Chain
        /// User Guide.
        /// 
        ///  
        /// <para>
        /// The CSV file must be located in an Amazon S3 location accessible to AWS Supply Chain.
        /// It is recommended to use the same Amazon S3 bucket created during your AWS Supply
        /// Chain instance creation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillOfMaterialsImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateBillOfMaterialsImportJob service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateBillOfMaterialsImportJob">REST API Reference for CreateBillOfMaterialsImportJob Operation</seealso>
        CreateBillOfMaterialsImportJobResponse CreateBillOfMaterialsImportJob(CreateBillOfMaterialsImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillOfMaterialsImportJob operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillOfMaterialsImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateBillOfMaterialsImportJob">REST API Reference for CreateBillOfMaterialsImportJob Operation</seealso>
        IAsyncResult BeginCreateBillOfMaterialsImportJob(CreateBillOfMaterialsImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillOfMaterialsImportJob.</param>
        /// 
        /// <returns>Returns a  CreateBillOfMaterialsImportJobResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateBillOfMaterialsImportJob">REST API Reference for CreateBillOfMaterialsImportJob Operation</seealso>
        CreateBillOfMaterialsImportJobResponse EndCreateBillOfMaterialsImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBillOfMaterialsImportJob


        /// <summary>
        /// Get status and details of a BillOfMaterialsImportJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillOfMaterialsImportJob service method.</param>
        /// 
        /// <returns>The response from the GetBillOfMaterialsImportJob service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetBillOfMaterialsImportJob">REST API Reference for GetBillOfMaterialsImportJob Operation</seealso>
        GetBillOfMaterialsImportJobResponse GetBillOfMaterialsImportJob(GetBillOfMaterialsImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillOfMaterialsImportJob operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillOfMaterialsImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetBillOfMaterialsImportJob">REST API Reference for GetBillOfMaterialsImportJob Operation</seealso>
        IAsyncResult BeginGetBillOfMaterialsImportJob(GetBillOfMaterialsImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillOfMaterialsImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillOfMaterialsImportJob.</param>
        /// 
        /// <returns>Returns a  GetBillOfMaterialsImportJobResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetBillOfMaterialsImportJob">REST API Reference for GetBillOfMaterialsImportJob Operation</seealso>
        GetBillOfMaterialsImportJobResponse EndGetBillOfMaterialsImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  SendDataIntegrationEvent


        /// <summary>
        /// Send transactional data events with real-time data for analysis or monitoring.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataIntegrationEvent service method.</param>
        /// 
        /// <returns>The response from the SendDataIntegrationEvent service method, as returned by SupplyChain.</returns>
        /// <exception cref="Amazon.SupplyChain.Model.AccessDeniedException">
        /// You do not have the required privileges to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SupplyChain.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/SendDataIntegrationEvent">REST API Reference for SendDataIntegrationEvent Operation</seealso>
        SendDataIntegrationEventResponse SendDataIntegrationEvent(SendDataIntegrationEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataIntegrationEvent operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataIntegrationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/SendDataIntegrationEvent">REST API Reference for SendDataIntegrationEvent Operation</seealso>
        IAsyncResult BeginSendDataIntegrationEvent(SendDataIntegrationEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataIntegrationEvent.</param>
        /// 
        /// <returns>Returns a  SendDataIntegrationEventResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/SendDataIntegrationEvent">REST API Reference for SendDataIntegrationEvent Operation</seealso>
        SendDataIntegrationEventResponse EndSendDataIntegrationEvent(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}