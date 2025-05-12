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

#pragma warning disable CS1570
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISupplyChainPaginatorFactory Paginators { get; }
#endif


        
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
        
        #region  CreateDataIntegrationFlow


        /// <summary>
        /// Enables you to programmatically create a data pipeline to ingest data from source
        /// systems such as Amazon S3 buckets, to a predefined Amazon Web Services Supply Chain
        /// dataset (product, inbound_order) or a temporary dataset along with the data transformation
        /// query provided with the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegrationFlow service method.</param>
        /// 
        /// <returns>The response from the CreateDataIntegrationFlow service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataIntegrationFlow">REST API Reference for CreateDataIntegrationFlow Operation</seealso>
        CreateDataIntegrationFlowResponse CreateDataIntegrationFlow(CreateDataIntegrationFlowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataIntegrationFlow">REST API Reference for CreateDataIntegrationFlow Operation</seealso>
        IAsyncResult BeginCreateDataIntegrationFlow(CreateDataIntegrationFlowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  CreateDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataIntegrationFlow">REST API Reference for CreateDataIntegrationFlow Operation</seealso>
        CreateDataIntegrationFlowResponse EndCreateDataIntegrationFlow(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataLakeDataset


        /// <summary>
        /// Enables you to programmatically create an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can create the datasets using their pre-defined or custom schema
        /// for a given instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataLakeDataset service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeDataset">REST API Reference for CreateDataLakeDataset Operation</seealso>
        CreateDataLakeDatasetResponse CreateDataLakeDataset(CreateDataLakeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeDataset">REST API Reference for CreateDataLakeDataset Operation</seealso>
        IAsyncResult BeginCreateDataLakeDataset(CreateDataLakeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  CreateDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeDataset">REST API Reference for CreateDataLakeDataset Operation</seealso>
        CreateDataLakeDatasetResponse EndCreateDataLakeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataLakeNamespace


        /// <summary>
        /// Enables you to programmatically create an Amazon Web Services Supply Chain data lake
        /// namespace. Developers can create the namespaces for a given instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeNamespace">REST API Reference for CreateDataLakeNamespace Operation</seealso>
        CreateDataLakeNamespaceResponse CreateDataLakeNamespace(CreateDataLakeNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeNamespace">REST API Reference for CreateDataLakeNamespace Operation</seealso>
        IAsyncResult BeginCreateDataLakeNamespace(CreateDataLakeNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  CreateDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateDataLakeNamespace">REST API Reference for CreateDataLakeNamespace Operation</seealso>
        CreateDataLakeNamespaceResponse EndCreateDataLakeNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstance


        /// <summary>
        /// Enables you to programmatically create an Amazon Web Services Supply Chain instance
        /// by applying KMS keys and relevant information associated with the API without using
        /// the Amazon Web Services console.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. Upon receiving a CreateInstance request, Amazon
        /// Web Services Supply Chain immediately returns the instance resource, instance ID,
        /// and the initializing state while simultaneously creating all required Amazon Web Services
        /// resources for an instance creation. You can use GetInstance to check the status of
        /// the instance. If the instance results in an unhealthy state, you need to check the
        /// error message, delete the current instance, and recreate a new one based on the mitigation
        /// from the error message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        CreateInstanceResponse CreateInstance(CreateInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataIntegrationFlow


        /// <summary>
        /// Enable you to programmatically delete an existing data pipeline for the provided Amazon
        /// Web Services Supply Chain instance and DataIntegrationFlow name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegrationFlow service method.</param>
        /// 
        /// <returns>The response from the DeleteDataIntegrationFlow service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataIntegrationFlow">REST API Reference for DeleteDataIntegrationFlow Operation</seealso>
        DeleteDataIntegrationFlowResponse DeleteDataIntegrationFlow(DeleteDataIntegrationFlowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataIntegrationFlow">REST API Reference for DeleteDataIntegrationFlow Operation</seealso>
        IAsyncResult BeginDeleteDataIntegrationFlow(DeleteDataIntegrationFlowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  DeleteDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataIntegrationFlow">REST API Reference for DeleteDataIntegrationFlow Operation</seealso>
        DeleteDataIntegrationFlowResponse EndDeleteDataIntegrationFlow(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataLakeDataset


        /// <summary>
        /// Enables you to programmatically delete an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can delete the existing datasets for a given instance ID, namespace,
        /// and instance name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataLakeDataset service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeDataset">REST API Reference for DeleteDataLakeDataset Operation</seealso>
        DeleteDataLakeDatasetResponse DeleteDataLakeDataset(DeleteDataLakeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeDataset">REST API Reference for DeleteDataLakeDataset Operation</seealso>
        IAsyncResult BeginDeleteDataLakeDataset(DeleteDataLakeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeDataset">REST API Reference for DeleteDataLakeDataset Operation</seealso>
        DeleteDataLakeDatasetResponse EndDeleteDataLakeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataLakeNamespace


        /// <summary>
        /// Enables you to programmatically delete an Amazon Web Services Supply Chain data lake
        /// namespace and its underling datasets. Developers can delete the existing namespaces
        /// for a given instance ID and namespace name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeNamespace">REST API Reference for DeleteDataLakeNamespace Operation</seealso>
        DeleteDataLakeNamespaceResponse DeleteDataLakeNamespace(DeleteDataLakeNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeNamespace">REST API Reference for DeleteDataLakeNamespace Operation</seealso>
        IAsyncResult BeginDeleteDataLakeNamespace(DeleteDataLakeNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteDataLakeNamespace">REST API Reference for DeleteDataLakeNamespace Operation</seealso>
        DeleteDataLakeNamespaceResponse EndDeleteDataLakeNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Enables you to programmatically delete an Amazon Web Services Supply Chain instance
        /// by deleting the KMS keys and relevant information associated with the API without
        /// using the Amazon Web Services console.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. Upon receiving a DeleteInstance request, Amazon
        /// Web Services Supply Chain immediately returns a response with the instance resource,
        /// delete state while cleaning up all Amazon Web Services resources created during the
        /// instance creation process. You can use the GetInstance action to check the instance
        /// status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult);

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
        
        #region  GetDataIntegrationEvent


        /// <summary>
        /// Enables you to programmatically view an Amazon Web Services Supply Chain Data Integration
        /// Event. Developers can view the eventType, eventGroupId, eventTimestamp, datasetTarget,
        /// datasetLoadExecution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationEvent service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegrationEvent service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationEvent">REST API Reference for GetDataIntegrationEvent Operation</seealso>
        GetDataIntegrationEventResponse GetDataIntegrationEvent(GetDataIntegrationEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationEvent operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataIntegrationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationEvent">REST API Reference for GetDataIntegrationEvent Operation</seealso>
        IAsyncResult BeginGetDataIntegrationEvent(GetDataIntegrationEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataIntegrationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataIntegrationEvent.</param>
        /// 
        /// <returns>Returns a  GetDataIntegrationEventResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationEvent">REST API Reference for GetDataIntegrationEvent Operation</seealso>
        GetDataIntegrationEventResponse EndGetDataIntegrationEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataIntegrationFlow


        /// <summary>
        /// Enables you to programmatically view a specific data pipeline for the provided Amazon
        /// Web Services Supply Chain instance and DataIntegrationFlow name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlow service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegrationFlow service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlow">REST API Reference for GetDataIntegrationFlow Operation</seealso>
        GetDataIntegrationFlowResponse GetDataIntegrationFlow(GetDataIntegrationFlowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlow">REST API Reference for GetDataIntegrationFlow Operation</seealso>
        IAsyncResult BeginGetDataIntegrationFlow(GetDataIntegrationFlowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  GetDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlow">REST API Reference for GetDataIntegrationFlow Operation</seealso>
        GetDataIntegrationFlowResponse EndGetDataIntegrationFlow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataIntegrationFlowExecution


        /// <summary>
        /// Get the flow execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlowExecution service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegrationFlowExecution service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlowExecution">REST API Reference for GetDataIntegrationFlowExecution Operation</seealso>
        GetDataIntegrationFlowExecutionResponse GetDataIntegrationFlowExecution(GetDataIntegrationFlowExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataIntegrationFlowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegrationFlowExecution operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataIntegrationFlowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlowExecution">REST API Reference for GetDataIntegrationFlowExecution Operation</seealso>
        IAsyncResult BeginGetDataIntegrationFlowExecution(GetDataIntegrationFlowExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataIntegrationFlowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataIntegrationFlowExecution.</param>
        /// 
        /// <returns>Returns a  GetDataIntegrationFlowExecutionResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataIntegrationFlowExecution">REST API Reference for GetDataIntegrationFlowExecution Operation</seealso>
        GetDataIntegrationFlowExecutionResponse EndGetDataIntegrationFlowExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataLakeDataset


        /// <summary>
        /// Enables you to programmatically view an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can view the data lake dataset information such as namespace,
        /// schema, and so on for a given instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeDataset service method.</param>
        /// 
        /// <returns>The response from the GetDataLakeDataset service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeDataset">REST API Reference for GetDataLakeDataset Operation</seealso>
        GetDataLakeDatasetResponse GetDataLakeDataset(GetDataLakeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeDataset">REST API Reference for GetDataLakeDataset Operation</seealso>
        IAsyncResult BeginGetDataLakeDataset(GetDataLakeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  GetDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeDataset">REST API Reference for GetDataLakeDataset Operation</seealso>
        GetDataLakeDatasetResponse EndGetDataLakeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataLakeNamespace


        /// <summary>
        /// Enables you to programmatically view an Amazon Web Services Supply Chain data lake
        /// namespace. Developers can view the data lake namespace information such as description
        /// for a given instance ID and namespace name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the GetDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeNamespace">REST API Reference for GetDataLakeNamespace Operation</seealso>
        GetDataLakeNamespaceResponse GetDataLakeNamespace(GetDataLakeNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeNamespace">REST API Reference for GetDataLakeNamespace Operation</seealso>
        IAsyncResult BeginGetDataLakeNamespace(GetDataLakeNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  GetDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetDataLakeNamespace">REST API Reference for GetDataLakeNamespace Operation</seealso>
        GetDataLakeNamespaceResponse EndGetDataLakeNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInstance


        /// <summary>
        /// Enables you to programmatically retrieve the information related to an Amazon Web
        /// Services Supply Chain instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetInstance">REST API Reference for GetInstance Operation</seealso>
        GetInstanceResponse GetInstance(GetInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetInstance">REST API Reference for GetInstance Operation</seealso>
        IAsyncResult BeginGetInstance(GetInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstance.</param>
        /// 
        /// <returns>Returns a  GetInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/GetInstance">REST API Reference for GetInstance Operation</seealso>
        GetInstanceResponse EndGetInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataIntegrationEvents


        /// <summary>
        /// Enables you to programmatically list all data integration events for the provided
        /// Amazon Web Services Supply Chain instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationEvents service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationEvents service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationEvents">REST API Reference for ListDataIntegrationEvents Operation</seealso>
        ListDataIntegrationEventsResponse ListDataIntegrationEvents(ListDataIntegrationEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationEvents operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationEvents">REST API Reference for ListDataIntegrationEvents Operation</seealso>
        IAsyncResult BeginListDataIntegrationEvents(ListDataIntegrationEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrationEvents.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationEventsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationEvents">REST API Reference for ListDataIntegrationEvents Operation</seealso>
        ListDataIntegrationEventsResponse EndListDataIntegrationEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataIntegrationFlowExecutions


        /// <summary>
        /// List flow executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationFlowExecutions service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlowExecutions">REST API Reference for ListDataIntegrationFlowExecutions Operation</seealso>
        ListDataIntegrationFlowExecutionsResponse ListDataIntegrationFlowExecutions(ListDataIntegrationFlowExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrationFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlowExecutions operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrationFlowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlowExecutions">REST API Reference for ListDataIntegrationFlowExecutions Operation</seealso>
        IAsyncResult BeginListDataIntegrationFlowExecutions(ListDataIntegrationFlowExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrationFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrationFlowExecutions.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationFlowExecutionsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlowExecutions">REST API Reference for ListDataIntegrationFlowExecutions Operation</seealso>
        ListDataIntegrationFlowExecutionsResponse EndListDataIntegrationFlowExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataIntegrationFlows


        /// <summary>
        /// Enables you to programmatically list all data pipelines for the provided Amazon Web
        /// Services Supply Chain instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlows service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationFlows service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlows">REST API Reference for ListDataIntegrationFlows Operation</seealso>
        ListDataIntegrationFlowsResponse ListDataIntegrationFlows(ListDataIntegrationFlowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrationFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationFlows operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrationFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlows">REST API Reference for ListDataIntegrationFlows Operation</seealso>
        IAsyncResult BeginListDataIntegrationFlows(ListDataIntegrationFlowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrationFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrationFlows.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationFlowsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataIntegrationFlows">REST API Reference for ListDataIntegrationFlows Operation</seealso>
        ListDataIntegrationFlowsResponse EndListDataIntegrationFlows(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataLakeDatasets


        /// <summary>
        /// Enables you to programmatically view the list of Amazon Web Services Supply Chain
        /// data lake datasets. Developers can view the datasets and the corresponding information
        /// such as namespace, schema, and so on for a given instance ID and namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDataLakeDatasets service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeDatasets">REST API Reference for ListDataLakeDatasets Operation</seealso>
        ListDataLakeDatasetsResponse ListDataLakeDatasets(ListDataLakeDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataLakeDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeDatasets operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataLakeDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeDatasets">REST API Reference for ListDataLakeDatasets Operation</seealso>
        IAsyncResult BeginListDataLakeDatasets(ListDataLakeDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataLakeDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataLakeDatasets.</param>
        /// 
        /// <returns>Returns a  ListDataLakeDatasetsResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeDatasets">REST API Reference for ListDataLakeDatasets Operation</seealso>
        ListDataLakeDatasetsResponse EndListDataLakeDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataLakeNamespaces


        /// <summary>
        /// Enables you to programmatically view the list of Amazon Web Services Supply Chain
        /// data lake namespaces. Developers can view the namespaces and the corresponding information
        /// such as description for a given instance ID. Note that this API only return custom
        /// namespaces, instance pre-defined namespaces are not included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListDataLakeNamespaces service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeNamespaces">REST API Reference for ListDataLakeNamespaces Operation</seealso>
        ListDataLakeNamespacesResponse ListDataLakeNamespaces(ListDataLakeNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataLakeNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeNamespaces operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataLakeNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeNamespaces">REST API Reference for ListDataLakeNamespaces Operation</seealso>
        IAsyncResult BeginListDataLakeNamespaces(ListDataLakeNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataLakeNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataLakeNamespaces.</param>
        /// 
        /// <returns>Returns a  ListDataLakeNamespacesResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListDataLakeNamespaces">REST API Reference for ListDataLakeNamespaces Operation</seealso>
        ListDataLakeNamespacesResponse EndListDataLakeNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstances


        /// <summary>
        /// List all Amazon Web Services Supply Chain instances for a specific account. Enables
        /// you to programmatically list all Amazon Web Services Supply Chain instances based
        /// on their account ID, instance name, and state of the instance (active or delete).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListInstances">REST API Reference for ListInstances Operation</seealso>
        IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse EndListInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all the tags for an Amazon Web ServicesSupply Chain resource. You can list all
        /// the tags added to a resource. By listing the tags, developers can view the tag level
        /// information on a resource and perform actions such as, deleting a resource associated
        /// with a particular tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  SendDataIntegrationEvent


        /// <summary>
        /// Send the data payload for the event with real-time data for analysis or monitoring.
        /// The real-time data events are stored in an Amazon Web Services service before being
        /// processed and stored in data lake.
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
        
        #region  TagResource


        /// <summary>
        /// You can create tags during or after creating a resource such as instance, data flow,
        /// or dataset in AWS Supply chain. During the data ingestion process, you can add tags
        /// such as dev, test, or prod to data flows created during the data ingestion process
        /// in the AWS Supply Chain datasets. You can use these tags to identify a group of resources
        /// or a single resource used by the developer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// You can delete tags for an Amazon Web Services Supply chain resource such as instance,
        /// data flow, or dataset in AWS Supply Chain. During the data ingestion process, you
        /// can delete tags such as dev, test, or prod to data flows created during the data ingestion
        /// process in the AWS Supply Chain datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataIntegrationFlow


        /// <summary>
        /// Enables you to programmatically update an existing data pipeline to ingest data from
        /// the source systems such as, Amazon S3 buckets, to a predefined Amazon Web Services
        /// Supply Chain dataset (product, inbound_order) or a temporary dataset along with the
        /// data transformation query provided with the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegrationFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateDataIntegrationFlow service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataIntegrationFlow">REST API Reference for UpdateDataIntegrationFlow Operation</seealso>
        UpdateDataIntegrationFlowResponse UpdateDataIntegrationFlow(UpdateDataIntegrationFlowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegrationFlow operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataIntegrationFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataIntegrationFlow">REST API Reference for UpdateDataIntegrationFlow Operation</seealso>
        IAsyncResult BeginUpdateDataIntegrationFlow(UpdateDataIntegrationFlowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataIntegrationFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataIntegrationFlow.</param>
        /// 
        /// <returns>Returns a  UpdateDataIntegrationFlowResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataIntegrationFlow">REST API Reference for UpdateDataIntegrationFlow Operation</seealso>
        UpdateDataIntegrationFlowResponse EndUpdateDataIntegrationFlow(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataLakeDataset


        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain data lake
        /// dataset. Developers can update the description of a data lake dataset for a given
        /// instance ID, namespace, and dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeDataset service method.</param>
        /// 
        /// <returns>The response from the UpdateDataLakeDataset service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeDataset">REST API Reference for UpdateDataLakeDataset Operation</seealso>
        UpdateDataLakeDatasetResponse UpdateDataLakeDataset(UpdateDataLakeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeDataset operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataLakeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeDataset">REST API Reference for UpdateDataLakeDataset Operation</seealso>
        IAsyncResult BeginUpdateDataLakeDataset(UpdateDataLakeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataLakeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataLakeDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDataLakeDatasetResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeDataset">REST API Reference for UpdateDataLakeDataset Operation</seealso>
        UpdateDataLakeDatasetResponse EndUpdateDataLakeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataLakeNamespace


        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain data lake
        /// namespace. Developers can update the description of a data lake namespace for a given
        /// instance ID and namespace name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateDataLakeNamespace service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeNamespace">REST API Reference for UpdateDataLakeNamespace Operation</seealso>
        UpdateDataLakeNamespaceResponse UpdateDataLakeNamespace(UpdateDataLakeNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeNamespace operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataLakeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeNamespace">REST API Reference for UpdateDataLakeNamespace Operation</seealso>
        IAsyncResult BeginUpdateDataLakeNamespace(UpdateDataLakeNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataLakeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataLakeNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateDataLakeNamespaceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateDataLakeNamespace">REST API Reference for UpdateDataLakeNamespace Operation</seealso>
        UpdateDataLakeNamespaceResponse EndUpdateDataLakeNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInstance


        /// <summary>
        /// Enables you to programmatically update an Amazon Web Services Supply Chain instance
        /// description by providing all the relevant information such as account ID, instance
        /// ID and so on without using the AWS console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateInstance service method, as returned by SupplyChain.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation on AmazonSupplyChainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        IAsyncResult BeginUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceResult from SupplyChain.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supplychain-2024-01-01/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult);

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