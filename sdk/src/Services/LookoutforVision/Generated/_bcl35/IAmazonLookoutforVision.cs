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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LookoutforVision.Model;

namespace Amazon.LookoutforVision
{
    /// <summary>
    /// Interface for accessing LookoutforVision
    ///
    /// This is the Amazon Lookout for Vision API Reference. It provides descriptions of actions,
    /// data types, common parameters, and common errors.
    /// 
    ///  
    /// <para>
    /// Amazon Lookout for Vision enables you to find visual defects in industrial products,
    /// accurately and at scale. It uses computer vision to identify missing components in
    /// an industrial product, damage to vehicles or structures, irregularities in production
    /// lines, and even minuscule defects in silicon wafers — or any other physical item where
    /// quality is important such as a missing capacitor on printed circuit boards.
    /// </para>
    /// </summary>
    public partial interface IAmazonLookoutforVision : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILookoutforVisionPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateDataset


        /// <summary>
        /// Creates a new dataset in an Amazon Lookout for Vision project. <code>CreateDataset</code>
        /// can create a training or a test dataset from a valid dataset source (<code>DatasetSource</code>).
        /// 
        ///  
        /// <para>
        /// If you want a single dataset project, specify <code>train</code> for the value of
        /// <code>DatasetType</code>.
        /// </para>
        ///  
        /// <para>
        /// To have a project with separate training and test datasets, call <code>CreateDataset</code>
        /// twice. On the first call, specify <code>train</code> for the value of <code>DatasetType</code>.
        /// On the second call, specify <code>test</code> for the value of <code>DatasetType</code>.
        /// of dataset with 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Creates a new version of a model within an an Amazon Lookout for Vision project. <code>CreateModel</code>
        /// is an asynchronous operation in which Amazon Lookout for Vision trains, tests, and
        /// evaluates a new version of a model. 
        /// 
        ///  
        /// <para>
        /// To get the current status, check the <code>Status</code> field returned in the response
        /// from <a>DescribeModel</a>.
        /// </para>
        ///  
        /// <para>
        /// If the project has a single dataset, Amazon Lookout for Vision internally splits the
        /// dataset to create a training and a test dataset. If the project has a training and
        /// a test dataset, Lookout for Vision uses the respective datasets to train and test
        /// the model. 
        /// </para>
        ///  
        /// <para>
        /// After training completes, the evaluation metrics are stored at the location specified
        /// in <code>OutputConfig</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse CreateModel(CreateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateModel">REST API Reference for CreateModel Operation</seealso>
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates an empty Amazon Lookout for Vision project. After you create the project,
        /// add a dataset by calling <a>CreateDataset</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes an existing Amazon Lookout for Vision <code>dataset</code>. 
        /// 
        ///  
        /// <para>
        /// If your the project has a single dataset, you must create a new dataset before you
        /// can create a model.
        /// </para>
        ///  
        /// <para>
        /// If you project has a training dataset and a test dataset consider the following. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you delete the test dataset, your project reverts to a single dataset project.
        /// If you then train the model, Amazon Lookout for Vision internally splits the remaining
        /// dataset into a training and test dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you delete the training dataset, you must create a training dataset before you
        /// can create a model.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It might take a while to delete the dataset. To check the current status, check the
        /// <code>Status</code> field in the response from a call to <a>DescribeDataset</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes an Amazon Lookout for Vision model. You can't delete a running model. To stop
        /// a running model, use the <a>StopModel</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse DeleteModel(DeleteModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes an Amazon Lookout for Vision project.
        /// 
        ///  
        /// <para>
        /// To delete a project, you must first delete each version of the model associated with
        /// the project. To delete a model use the <a>DeleteModel</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The training and test datasets are deleted automatically for you. The images referenced
        /// by the training and test datasets aren't deleted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Describe an Amazon Lookout for Vision dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModel


        /// <summary>
        /// Describes a version of an Amazon Lookout for Vision model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        DescribeModelResponse DescribeModel(DescribeModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        IAsyncResult BeginDescribeModel(DescribeModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModel.</param>
        /// 
        /// <returns>Returns a  DescribeModelResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        DescribeModelResponse EndDescribeModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProject


        /// <summary>
        /// Describes an Amazon Lookout for Vision project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse DescribeProject(DescribeProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        IAsyncResult BeginDescribeProject(DescribeProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProject.</param>
        /// 
        /// <returns>Returns a  DescribeProjectResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse EndDescribeProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DetectAnomalies


        /// <summary>
        /// Detects anomalies in an image that you supply. 
        /// 
        ///  
        /// <para>
        /// The response from <code>DetectAnomalies</code> includes a boolean prediction that
        /// the image contains one or more anomalies and a confidence value for the prediction.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before calling <code>DetectAnomalies</code>, you must first start your model with
        /// the <a>StartModel</a> operation. You are charged for the amount of time, in minutes,
        /// that a model runs and for the number of anomaly detection units that your model uses.
        /// If you are not using a model, use the <a>StopModel</a> operation to stop your model.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectAnomalies service method.</param>
        /// 
        /// <returns>The response from the DetectAnomalies service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DetectAnomalies">REST API Reference for DetectAnomalies Operation</seealso>
        DetectAnomaliesResponse DetectAnomalies(DetectAnomaliesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectAnomalies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectAnomalies operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectAnomalies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DetectAnomalies">REST API Reference for DetectAnomalies Operation</seealso>
        IAsyncResult BeginDetectAnomalies(DetectAnomaliesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectAnomalies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectAnomalies.</param>
        /// 
        /// <returns>Returns a  DetectAnomaliesResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/DetectAnomalies">REST API Reference for DetectAnomalies Operation</seealso>
        DetectAnomaliesResponse EndDetectAnomalies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetEntries


        /// <summary>
        /// Lists the JSON Lines within a dataset. An Amazon Lookout for Vision JSON Line contains
        /// the anomaly information for a single image, including the image location and the assigned
        /// label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetEntries service method.</param>
        /// 
        /// <returns>The response from the ListDatasetEntries service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListDatasetEntries">REST API Reference for ListDatasetEntries Operation</seealso>
        ListDatasetEntriesResponse ListDatasetEntries(ListDatasetEntriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetEntries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetEntries operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetEntries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListDatasetEntries">REST API Reference for ListDatasetEntries Operation</seealso>
        IAsyncResult BeginListDatasetEntries(ListDatasetEntriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetEntries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetEntries.</param>
        /// 
        /// <returns>Returns a  ListDatasetEntriesResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListDatasetEntries">REST API Reference for ListDatasetEntries Operation</seealso>
        ListDatasetEntriesResponse EndListDatasetEntries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModels


        /// <summary>
        /// Lists the versions of a model in an Amazon Lookout for Vision project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse ListModels(ListModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListModels">REST API Reference for ListModels Operation</seealso>
        IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse EndListModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Lists the Amazon Lookout for Vision projects in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  StartModel


        /// <summary>
        /// Starts the running of the version of an Amazon Lookout for Vision model. Starting
        /// a model takes a while to complete. To check the current state of the model, use <a>DescribeModel</a>.
        /// 
        ///  
        /// <para>
        /// Once the model is running, you can detect custom labels in new images by calling <a>DetectAnomalies</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged for the amount of time that the model is running. To stop a running
        /// model, call <a>StopModel</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartModel service method.</param>
        /// 
        /// <returns>The response from the StartModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded the allowed limit. For more information, see Limits in
        /// Amazon Lookout for Vision in the Amazon Lookout for Vision Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StartModel">REST API Reference for StartModel Operation</seealso>
        StartModelResponse StartModel(StartModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartModel operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StartModel">REST API Reference for StartModel Operation</seealso>
        IAsyncResult BeginStartModel(StartModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartModel.</param>
        /// 
        /// <returns>Returns a  StartModelResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StartModel">REST API Reference for StartModel Operation</seealso>
        StartModelResponse EndStartModel(IAsyncResult asyncResult);

        #endregion
        
        #region  StopModel


        /// <summary>
        /// Stops a running model. The operation might take a while to complete. To check the
        /// current status, call <a>DescribeModel</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModel service method.</param>
        /// 
        /// <returns>The response from the StopModel service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StopModel">REST API Reference for StopModel Operation</seealso>
        StopModelResponse StopModel(StopModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopModel operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StopModel">REST API Reference for StopModel Operation</seealso>
        IAsyncResult BeginStopModel(StopModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopModel.</param>
        /// 
        /// <returns>Returns a  StopModelResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/StopModel">REST API Reference for StopModel Operation</seealso>
        StopModelResponse EndStopModel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatasetEntries


        /// <summary>
        /// Adds one or more JSON Line entries to a dataset. A JSON Line includes information
        /// about an image used for training or testing an Amazon Lookout for Vision model. The
        /// following is an example JSON Line.
        /// 
        ///  
        /// <para>
        /// Updating a dataset might take a while to complete. To check the current status, call
        /// <a>DescribeDataset</a> and check the <code>Status</code> field in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetEntries service method.</param>
        /// 
        /// <returns>The response from the UpdateDatasetEntries service method, as returned by LookoutforVision.</returns>
        /// <exception cref="Amazon.LookoutforVision.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ConflictException">
        /// The update or deletion of a resource caused an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.InternalServerException">
        /// Amazon Lookout for Vision experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ThrottlingException">
        /// Amazon Lookout for Vision is temporarily unable to process the request. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.LookoutforVision.Model.ValidationException">
        /// An input validation error occured. For example, invalid characters in a project name,
        /// or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/UpdateDatasetEntries">REST API Reference for UpdateDatasetEntries Operation</seealso>
        UpdateDatasetEntriesResponse UpdateDatasetEntries(UpdateDatasetEntriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatasetEntries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetEntries operation on AmazonLookoutforVisionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatasetEntries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/UpdateDatasetEntries">REST API Reference for UpdateDatasetEntries Operation</seealso>
        IAsyncResult BeginUpdateDatasetEntries(UpdateDatasetEntriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatasetEntries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatasetEntries.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetEntriesResult from LookoutforVision.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutvision-2020-11-20/UpdateDatasetEntries">REST API Reference for UpdateDatasetEntries Operation</seealso>
        UpdateDatasetEntriesResponse EndUpdateDatasetEntries(IAsyncResult asyncResult);

        #endregion
        
    }
}