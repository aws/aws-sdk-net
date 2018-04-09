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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudDirectory.Model;

namespace Amazon.CloudDirectory
{
    /// <summary>
    /// Interface for accessing CloudDirectory
    ///
    /// Amazon Cloud Directory 
    /// <para>
    /// Amazon Cloud Directory is a component of the AWS Directory Service that simplifies
    /// the development and management of cloud-scale web, mobile, and IoT applications. This
    /// guide describes the Cloud Directory operations that you can call programmatically
    /// and includes detailed information on data types and errors. For information about
    /// AWS Directory Services features, see <a href="https://aws.amazon.com/directoryservice/">AWS
    /// Directory Service</a> and the <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/what_is.html">AWS
    /// Directory Service Administration Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudDirectory : IAmazonService, IDisposable
    {

        
        #region  AddFacetToObject


        /// <summary>
        /// Adds a new <a>Facet</a> to an object. An object can have more than one facet applied
        /// on it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject service method.</param>
        /// 
        /// <returns>The response from the AddFacetToObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        AddFacetToObjectResponse AddFacetToObject(AddFacetToObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddFacetToObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFacetToObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddFacetToObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        IAsyncResult BeginAddFacetToObject(AddFacetToObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddFacetToObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddFacetToObject.</param>
        /// 
        /// <returns>Returns a  AddFacetToObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AddFacetToObject">REST API Reference for AddFacetToObject Operation</seealso>
        AddFacetToObjectResponse EndAddFacetToObject(IAsyncResult asyncResult);

        #endregion
        
        #region  ApplySchema


        /// <summary>
        /// Copies the input published schema, at the specified version, into the <a>Directory</a>
        /// with the same name and version as that of the published schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySchema service method.</param>
        /// 
        /// <returns>The response from the ApplySchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        ApplySchemaResponse ApplySchema(ApplySchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplySchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        IAsyncResult BeginApplySchema(ApplySchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ApplySchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplySchema.</param>
        /// 
        /// <returns>Returns a  ApplySchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ApplySchema">REST API Reference for ApplySchema Operation</seealso>
        ApplySchemaResponse EndApplySchema(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachObject


        /// <summary>
        /// Attaches an existing object to another object. An object can be accessed in two ways:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Using the path
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Using <code>ObjectIdentifier</code> 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachObject service method.</param>
        /// 
        /// <returns>The response from the AttachObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachObject">REST API Reference for AttachObject Operation</seealso>
        AttachObjectResponse AttachObject(AttachObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachObject">REST API Reference for AttachObject Operation</seealso>
        IAsyncResult BeginAttachObject(AttachObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachObject.</param>
        /// 
        /// <returns>Returns a  AttachObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachObject">REST API Reference for AttachObject Operation</seealso>
        AttachObjectResponse EndAttachObject(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachPolicy


        /// <summary>
        /// Attaches a policy object to a regular object. An object can have a limited number
        /// of attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotPolicyException">
        /// Indicates that the requested operation can only operate on policy objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        AttachPolicyResponse AttachPolicy(AttachPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        IAsyncResult BeginAttachPolicy(AttachPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachPolicy.</param>
        /// 
        /// <returns>Returns a  AttachPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        AttachPolicyResponse EndAttachPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachToIndex


        /// <summary>
        /// Attaches the specified object to the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachToIndex service method.</param>
        /// 
        /// <returns>The response from the AttachToIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.IndexedAttributeMissingException">
        /// An object has been attempted to be attached to an object that does not have the appropriate
        /// attribute value.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotIndexException">
        /// Indicates that the requested operation can only operate on index objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        AttachToIndexResponse AttachToIndex(AttachToIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachToIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachToIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachToIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        IAsyncResult BeginAttachToIndex(AttachToIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachToIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachToIndex.</param>
        /// 
        /// <returns>Returns a  AttachToIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachToIndex">REST API Reference for AttachToIndex Operation</seealso>
        AttachToIndexResponse EndAttachToIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachTypedLink


        /// <summary>
        /// Attaches a typed link to a specified source and target object. For more information,
        /// see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachTypedLink service method.</param>
        /// 
        /// <returns>The response from the AttachTypedLink service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        AttachTypedLinkResponse AttachTypedLink(AttachTypedLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachTypedLink operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachTypedLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        IAsyncResult BeginAttachTypedLink(AttachTypedLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachTypedLink.</param>
        /// 
        /// <returns>Returns a  AttachTypedLinkResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/AttachTypedLink">REST API Reference for AttachTypedLink Operation</seealso>
        AttachTypedLinkResponse EndAttachTypedLink(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchRead


        /// <summary>
        /// Performs all the read operations in a batch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRead service method.</param>
        /// 
        /// <returns>The response from the BatchRead service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchRead">REST API Reference for BatchRead Operation</seealso>
        BatchReadResponse BatchRead(BatchReadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchRead operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchRead operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchRead
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchRead">REST API Reference for BatchRead Operation</seealso>
        IAsyncResult BeginBatchRead(BatchReadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchRead operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchRead.</param>
        /// 
        /// <returns>Returns a  BatchReadResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchRead">REST API Reference for BatchRead Operation</seealso>
        BatchReadResponse EndBatchRead(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchWrite


        /// <summary>
        /// Performs all the write operations in a batch. Either all the operations succeed or
        /// none.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchWrite service method.</param>
        /// 
        /// <returns>The response from the BatchWrite service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.BatchWriteException">
        /// A <code>BatchWrite</code> exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        BatchWriteResponse BatchWrite(BatchWriteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchWrite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchWrite operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchWrite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        IAsyncResult BeginBatchWrite(BatchWriteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchWrite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchWrite.</param>
        /// 
        /// <returns>Returns a  BatchWriteResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/BatchWrite">REST API Reference for BatchWrite Operation</seealso>
        BatchWriteResponse EndBatchWrite(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDirectory


        /// <summary>
        /// Creates a <a>Directory</a> by copying the published schema into the directory. A directory
        /// cannot be created without a schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory service method.</param>
        /// 
        /// <returns>The response from the CreateDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryAlreadyExistsException">
        /// Indicates that a <a>Directory</a> could not be created due to a naming conflict. Choose
        /// a different name and try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        IAsyncResult BeginCreateDirectory(CreateDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectory.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        CreateDirectoryResponse EndCreateDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFacet


        /// <summary>
        /// Creates a new <a>Facet</a> in a schema. Facet creation is allowed only in development
        /// or applied schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFacet service method.</param>
        /// 
        /// <returns>The response from the CreateFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetAlreadyExistsException">
        /// A facet with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        CreateFacetResponse CreateFacet(CreateFacetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        IAsyncResult BeginCreateFacet(CreateFacetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFacet.</param>
        /// 
        /// <returns>Returns a  CreateFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateFacet">REST API Reference for CreateFacet Operation</seealso>
        CreateFacetResponse EndCreateFacet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIndex


        /// <summary>
        /// Creates an index object. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_indexing.html">Indexing</a>
        /// for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.UnsupportedIndexTypeException">
        /// Indicates that the requested index type is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        CreateIndexResponse CreateIndex(CreateIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIndex.</param>
        /// 
        /// <returns>Returns a  CreateIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateObject


        /// <summary>
        /// Creates an object in a <a>Directory</a>. Additionally attaches the object to a parent,
        /// if a parent reference and <code>LinkName</code> is specified. An object is simply
        /// a collection of <a>Facet</a> attributes. You can also use this API call to create
        /// a policy object, if the facet from which you create the object is a policy facet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateObject service method.</param>
        /// 
        /// <returns>The response from the CreateObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LinkNameAlreadyInUseException">
        /// Indicates that a link could not be created due to a naming conflict. Choose a different
        /// name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.UnsupportedIndexTypeException">
        /// Indicates that the requested index type is not supported.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateObject">REST API Reference for CreateObject Operation</seealso>
        CreateObjectResponse CreateObject(CreateObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateObject">REST API Reference for CreateObject Operation</seealso>
        IAsyncResult BeginCreateObject(CreateObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateObject.</param>
        /// 
        /// <returns>Returns a  CreateObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateObject">REST API Reference for CreateObject Operation</seealso>
        CreateObjectResponse EndCreateObject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSchema


        /// <summary>
        /// Creates a new schema in a development state. A schema can exist in three phases:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Development:</i> This is a mutable phase of the schema. All new schemas are in
        /// the development phase. Once the schema is finalized, it can be published.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Published:</i> Published schemas are immutable and have a version associated with
        /// them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Applied:</i> Applied schemas are mutable in a way that allows you to add new schema
        /// facets. You can also add new, nonrequired attributes to existing schema facets. You
        /// can apply only published schemas to directories. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.SchemaAlreadyExistsException">
        /// Indicates that a schema could not be created due to a naming conflict. Please select
        /// a different name and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        CreateSchemaResponse CreateSchema(CreateSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTypedLinkFacet


        /// <summary>
        /// Creates a <a>TypedLinkFacet</a>. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTypedLinkFacet service method.</param>
        /// 
        /// <returns>The response from the CreateTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetAlreadyExistsException">
        /// A facet with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        CreateTypedLinkFacetResponse CreateTypedLinkFacet(CreateTypedLinkFacetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTypedLinkFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTypedLinkFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        IAsyncResult BeginCreateTypedLinkFacet(CreateTypedLinkFacetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  CreateTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/CreateTypedLinkFacet">REST API Reference for CreateTypedLinkFacet Operation</seealso>
        CreateTypedLinkFacetResponse EndCreateTypedLinkFacet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDirectory


        /// <summary>
        /// Deletes a directory. Only disabled directories can be deleted. A deleted directory
        /// cannot be undone. Exercise extreme caution when deleting directories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryDeletedException">
        /// A directory that has been deleted and to which access has been attempted. Note: The
        /// requested resource will eventually cease to exist.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotDisabledException">
        /// An operation can only operate on a disabled directory.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        IAsyncResult BeginDeleteDirectory(DeleteDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectory.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        DeleteDirectoryResponse EndDeleteDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFacet


        /// <summary>
        /// Deletes a given <a>Facet</a>. All attributes and <a>Rule</a>s that are associated
        /// with the facet will be deleted. Only development schema facets are allowed deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFacet service method.</param>
        /// 
        /// <returns>The response from the DeleteFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetInUseException">
        /// Occurs when deleting a facet that contains an attribute that is a target to an attribute
        /// reference in a different facet.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        DeleteFacetResponse DeleteFacet(DeleteFacetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        IAsyncResult BeginDeleteFacet(DeleteFacetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFacet.</param>
        /// 
        /// <returns>Returns a  DeleteFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteFacet">REST API Reference for DeleteFacet Operation</seealso>
        DeleteFacetResponse EndDeleteFacet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteObject


        /// <summary>
        /// Deletes an object and its associated attributes. Only objects with no children and
        /// no parents can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ObjectNotDetachedException">
        /// Indicates that the requested operation cannot be completed because the object has
        /// not been detached from the tree.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        DeleteObjectResponse DeleteObject(DeleteObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        IAsyncResult BeginDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// 
        /// <returns>Returns a  DeleteObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSchema


        /// <summary>
        /// Deletes a given schema. Schemas in a development and published state can only be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.StillContainsLinksException">
        /// The object could not be deleted because links still exist. Remove the links and then
        /// try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTypedLinkFacet


        /// <summary>
        /// Deletes a <a>TypedLinkFacet</a>. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTypedLinkFacet service method.</param>
        /// 
        /// <returns>The response from the DeleteTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        DeleteTypedLinkFacetResponse DeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTypedLinkFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTypedLinkFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        IAsyncResult BeginDeleteTypedLinkFacet(DeleteTypedLinkFacetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  DeleteTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DeleteTypedLinkFacet">REST API Reference for DeleteTypedLinkFacet Operation</seealso>
        DeleteTypedLinkFacetResponse EndDeleteTypedLinkFacet(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachFromIndex


        /// <summary>
        /// Detaches the specified object from the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachFromIndex service method.</param>
        /// 
        /// <returns>The response from the DetachFromIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotIndexException">
        /// Indicates that the requested operation can only operate on index objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ObjectAlreadyDetachedException">
        /// Indicates that the object is not attached to the index.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        DetachFromIndexResponse DetachFromIndex(DetachFromIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachFromIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachFromIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachFromIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        IAsyncResult BeginDetachFromIndex(DetachFromIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachFromIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachFromIndex.</param>
        /// 
        /// <returns>Returns a  DetachFromIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachFromIndex">REST API Reference for DetachFromIndex Operation</seealso>
        DetachFromIndexResponse EndDetachFromIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachObject


        /// <summary>
        /// Detaches a given object from the parent object. The object that is to be detached
        /// from the parent is specified by the link name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachObject service method.</param>
        /// 
        /// <returns>The response from the DetachObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotNodeException">
        /// Occurs when any invalid operations are performed on an object that is not a node,
        /// such as calling <code>ListObjectChildren</code> for a leaf node object.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        DetachObjectResponse DetachObject(DetachObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        IAsyncResult BeginDetachObject(DetachObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachObject.</param>
        /// 
        /// <returns>Returns a  DetachObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachObject">REST API Reference for DetachObject Operation</seealso>
        DetachObjectResponse EndDetachObject(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachPolicy


        /// <summary>
        /// Detaches a policy from an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotPolicyException">
        /// Indicates that the requested operation can only operate on policy objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        DetachPolicyResponse DetachPolicy(DetachPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        IAsyncResult BeginDetachPolicy(DetachPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachPolicy.</param>
        /// 
        /// <returns>Returns a  DetachPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        DetachPolicyResponse EndDetachPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachTypedLink


        /// <summary>
        /// Detaches a typed link from a specified source and target object. For more information,
        /// see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachTypedLink service method.</param>
        /// 
        /// <returns>The response from the DetachTypedLink service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        DetachTypedLinkResponse DetachTypedLink(DetachTypedLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachTypedLink operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachTypedLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        IAsyncResult BeginDetachTypedLink(DetachTypedLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachTypedLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachTypedLink.</param>
        /// 
        /// <returns>Returns a  DetachTypedLinkResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DetachTypedLink">REST API Reference for DetachTypedLink Operation</seealso>
        DetachTypedLinkResponse EndDetachTypedLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableDirectory


        /// <summary>
        /// Disables the specified directory. Disabled directories cannot be read or written to.
        /// Only enabled directories can be disabled. Disabled directories may be reenabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectory service method.</param>
        /// 
        /// <returns>The response from the DisableDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryDeletedException">
        /// A directory that has been deleted and to which access has been attempted. Note: The
        /// requested resource will eventually cease to exist.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        DisableDirectoryResponse DisableDirectory(DisableDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        IAsyncResult BeginDisableDirectory(DisableDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDirectory.</param>
        /// 
        /// <returns>Returns a  DisableDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/DisableDirectory">REST API Reference for DisableDirectory Operation</seealso>
        DisableDirectoryResponse EndDisableDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableDirectory


        /// <summary>
        /// Enables the specified directory. Only disabled directories can be enabled. Once enabled,
        /// the directory can then be read and written to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectory service method.</param>
        /// 
        /// <returns>The response from the EnableDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryDeletedException">
        /// A directory that has been deleted and to which access has been attempted. Note: The
        /// requested resource will eventually cease to exist.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        EnableDirectoryResponse EnableDirectory(EnableDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        IAsyncResult BeginEnableDirectory(EnableDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDirectory.</param>
        /// 
        /// <returns>Returns a  EnableDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/EnableDirectory">REST API Reference for EnableDirectory Operation</seealso>
        EnableDirectoryResponse EndEnableDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAppliedSchemaVersion


        /// <summary>
        /// Returns current applied schema version ARN, including the minor version in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppliedSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the GetAppliedSchemaVersion service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        GetAppliedSchemaVersionResponse GetAppliedSchemaVersion(GetAppliedSchemaVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppliedSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppliedSchemaVersion operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppliedSchemaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        IAsyncResult BeginGetAppliedSchemaVersion(GetAppliedSchemaVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppliedSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppliedSchemaVersion.</param>
        /// 
        /// <returns>Returns a  GetAppliedSchemaVersionResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetAppliedSchemaVersion">REST API Reference for GetAppliedSchemaVersion Operation</seealso>
        GetAppliedSchemaVersionResponse EndGetAppliedSchemaVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDirectory


        /// <summary>
        /// Retrieves metadata about a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectory service method.</param>
        /// 
        /// <returns>The response from the GetDirectory service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        GetDirectoryResponse GetDirectory(GetDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectory operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        IAsyncResult BeginGetDirectory(GetDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDirectory.</param>
        /// 
        /// <returns>Returns a  GetDirectoryResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetDirectory">REST API Reference for GetDirectory Operation</seealso>
        GetDirectoryResponse EndGetDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFacet


        /// <summary>
        /// Gets details of the <a>Facet</a>, such as facet name, attributes, <a>Rule</a>s, or
        /// <code>ObjectType</code>. You can call this on all kinds of schema facets -- published,
        /// development, or applied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFacet service method.</param>
        /// 
        /// <returns>The response from the GetFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetFacet">REST API Reference for GetFacet Operation</seealso>
        GetFacetResponse GetFacet(GetFacetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetFacet">REST API Reference for GetFacet Operation</seealso>
        IAsyncResult BeginGetFacet(GetFacetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFacet.</param>
        /// 
        /// <returns>Returns a  GetFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetFacet">REST API Reference for GetFacet Operation</seealso>
        GetFacetResponse EndGetFacet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetObjectAttributes


        /// <summary>
        /// Retrieves attributes within a facet that are associated with an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectAttributes service method.</param>
        /// 
        /// <returns>The response from the GetObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        GetObjectAttributesResponse GetObjectAttributes(GetObjectAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        IAsyncResult BeginGetObjectAttributes(GetObjectAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectAttributes.</param>
        /// 
        /// <returns>Returns a  GetObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectAttributes">REST API Reference for GetObjectAttributes Operation</seealso>
        GetObjectAttributesResponse EndGetObjectAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetObjectInformation


        /// <summary>
        /// Retrieves metadata about an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectInformation service method.</param>
        /// 
        /// <returns>The response from the GetObjectInformation service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        GetObjectInformationResponse GetObjectInformation(GetObjectInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectInformation operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        IAsyncResult BeginGetObjectInformation(GetObjectInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectInformation.</param>
        /// 
        /// <returns>Returns a  GetObjectInformationResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetObjectInformation">REST API Reference for GetObjectInformation Operation</seealso>
        GetObjectInformationResponse EndGetObjectInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSchemaAsJson


        /// <summary>
        /// Retrieves a JSON representation of the schema. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_schemas.html#jsonformat">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAsJson service method.</param>
        /// 
        /// <returns>The response from the GetSchemaAsJson service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        GetSchemaAsJsonResponse GetSchemaAsJson(GetSchemaAsJsonRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaAsJson operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAsJson operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaAsJson
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        IAsyncResult BeginGetSchemaAsJson(GetSchemaAsJsonRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaAsJson operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaAsJson.</param>
        /// 
        /// <returns>Returns a  GetSchemaAsJsonResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetSchemaAsJson">REST API Reference for GetSchemaAsJson Operation</seealso>
        GetSchemaAsJsonResponse EndGetSchemaAsJson(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTypedLinkFacetInformation


        /// <summary>
        /// Returns the identity attribute order for a specific <a>TypedLinkFacet</a>. For more
        /// information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTypedLinkFacetInformation service method.</param>
        /// 
        /// <returns>The response from the GetTypedLinkFacetInformation service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        GetTypedLinkFacetInformationResponse GetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTypedLinkFacetInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTypedLinkFacetInformation operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTypedLinkFacetInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        IAsyncResult BeginGetTypedLinkFacetInformation(GetTypedLinkFacetInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTypedLinkFacetInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTypedLinkFacetInformation.</param>
        /// 
        /// <returns>Returns a  GetTypedLinkFacetInformationResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/GetTypedLinkFacetInformation">REST API Reference for GetTypedLinkFacetInformation Operation</seealso>
        GetTypedLinkFacetInformationResponse EndGetTypedLinkFacetInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppliedSchemaArns


        /// <summary>
        /// Lists schema major versions applied to a directory. If <code>SchemaArn</code> is provided,
        /// lists the minor version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppliedSchemaArns service method.</param>
        /// 
        /// <returns>The response from the ListAppliedSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppliedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppliedSchemaArns operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppliedSchemaArns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        IAsyncResult BeginListAppliedSchemaArns(ListAppliedSchemaArnsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppliedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppliedSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListAppliedSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAppliedSchemaArns">REST API Reference for ListAppliedSchemaArns Operation</seealso>
        ListAppliedSchemaArnsResponse EndListAppliedSchemaArns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedIndices


        /// <summary>
        /// Lists indices attached to the specified object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedIndices service method.</param>
        /// 
        /// <returns>The response from the ListAttachedIndices service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        ListAttachedIndicesResponse ListAttachedIndices(ListAttachedIndicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedIndices operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedIndices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        IAsyncResult BeginListAttachedIndices(ListAttachedIndicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedIndices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedIndices.</param>
        /// 
        /// <returns>Returns a  ListAttachedIndicesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListAttachedIndices">REST API Reference for ListAttachedIndices Operation</seealso>
        ListAttachedIndicesResponse EndListAttachedIndices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevelopmentSchemaArns


        /// <summary>
        /// Retrieves each Amazon Resource Name (ARN) of schemas in the development state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevelopmentSchemaArns service method.</param>
        /// 
        /// <returns>The response from the ListDevelopmentSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        ListDevelopmentSchemaArnsResponse ListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevelopmentSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevelopmentSchemaArns operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevelopmentSchemaArns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        IAsyncResult BeginListDevelopmentSchemaArns(ListDevelopmentSchemaArnsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevelopmentSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevelopmentSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListDevelopmentSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDevelopmentSchemaArns">REST API Reference for ListDevelopmentSchemaArns Operation</seealso>
        ListDevelopmentSchemaArnsResponse EndListDevelopmentSchemaArns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDirectories


        /// <summary>
        /// Lists directories created within an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectories service method.</param>
        /// 
        /// <returns>The response from the ListDirectories service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        ListDirectoriesResponse ListDirectories(ListDirectoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDirectories operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDirectories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        IAsyncResult BeginListDirectories(ListDirectoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDirectories.</param>
        /// 
        /// <returns>Returns a  ListDirectoriesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListDirectories">REST API Reference for ListDirectories Operation</seealso>
        ListDirectoriesResponse EndListDirectories(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFacetAttributes


        /// <summary>
        /// Retrieves attributes attached to the facet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFacetAttributes service method.</param>
        /// 
        /// <returns>The response from the ListFacetAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        ListFacetAttributesResponse ListFacetAttributes(ListFacetAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFacetAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFacetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        IAsyncResult BeginListFacetAttributes(ListFacetAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFacetAttributes.</param>
        /// 
        /// <returns>Returns a  ListFacetAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetAttributes">REST API Reference for ListFacetAttributes Operation</seealso>
        ListFacetAttributesResponse EndListFacetAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFacetNames


        /// <summary>
        /// Retrieves the names of facets that exist in a schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFacetNames service method.</param>
        /// 
        /// <returns>The response from the ListFacetNames service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        ListFacetNamesResponse ListFacetNames(ListFacetNamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFacetNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFacetNames operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFacetNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        IAsyncResult BeginListFacetNames(ListFacetNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFacetNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFacetNames.</param>
        /// 
        /// <returns>Returns a  ListFacetNamesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListFacetNames">REST API Reference for ListFacetNames Operation</seealso>
        ListFacetNamesResponse EndListFacetNames(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIncomingTypedLinks


        /// <summary>
        /// Returns a paginated list of all the incoming <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncomingTypedLinks service method.</param>
        /// 
        /// <returns>The response from the ListIncomingTypedLinks service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        ListIncomingTypedLinksResponse ListIncomingTypedLinks(ListIncomingTypedLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIncomingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIncomingTypedLinks operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIncomingTypedLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        IAsyncResult BeginListIncomingTypedLinks(ListIncomingTypedLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIncomingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIncomingTypedLinks.</param>
        /// 
        /// <returns>Returns a  ListIncomingTypedLinksResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIncomingTypedLinks">REST API Reference for ListIncomingTypedLinks Operation</seealso>
        ListIncomingTypedLinksResponse EndListIncomingTypedLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIndex


        /// <summary>
        /// Lists objects attached to the specified index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndex service method.</param>
        /// 
        /// <returns>The response from the ListIndex service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotIndexException">
        /// Indicates that the requested operation can only operate on index objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIndex">REST API Reference for ListIndex Operation</seealso>
        ListIndexResponse ListIndex(ListIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndex operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIndex">REST API Reference for ListIndex Operation</seealso>
        IAsyncResult BeginListIndex(ListIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndex.</param>
        /// 
        /// <returns>Returns a  ListIndexResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListIndex">REST API Reference for ListIndex Operation</seealso>
        ListIndexResponse EndListIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  ListObjectAttributes


        /// <summary>
        /// Lists all attributes that are associated with an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectAttributes service method.</param>
        /// 
        /// <returns>The response from the ListObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        ListObjectAttributesResponse ListObjectAttributes(ListObjectAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        IAsyncResult BeginListObjectAttributes(ListObjectAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectAttributes.</param>
        /// 
        /// <returns>Returns a  ListObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectAttributes">REST API Reference for ListObjectAttributes Operation</seealso>
        ListObjectAttributesResponse EndListObjectAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListObjectChildren


        /// <summary>
        /// Returns a paginated list of child objects that are associated with a given object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectChildren service method.</param>
        /// 
        /// <returns>The response from the ListObjectChildren service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotNodeException">
        /// Occurs when any invalid operations are performed on an object that is not a node,
        /// such as calling <code>ListObjectChildren</code> for a leaf node object.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        ListObjectChildrenResponse ListObjectChildren(ListObjectChildrenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectChildren operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectChildren operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectChildren
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        IAsyncResult BeginListObjectChildren(ListObjectChildrenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectChildren operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectChildren.</param>
        /// 
        /// <returns>Returns a  ListObjectChildrenResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectChildren">REST API Reference for ListObjectChildren Operation</seealso>
        ListObjectChildrenResponse EndListObjectChildren(IAsyncResult asyncResult);

        #endregion
        
        #region  ListObjectParentPaths


        /// <summary>
        /// Retrieves all available parent paths for any object type such as node, leaf node,
        /// policy node, and index node objects. For more information about objects, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_key_concepts.html#dirstructure">Directory
        /// Structure</a>.
        /// 
        ///  
        /// <para>
        /// Use this API to evaluate all parents for an object. The call returns all objects from
        /// the root of the directory up to the requested object. The API returns the number of
        /// paths based on user-defined <code>MaxResults</code>, in case there are multiple paths
        /// to the parent. The order of the paths and nodes returned is consistent among multiple
        /// API calls unless the objects are deleted or moved. Paths not leading to the directory
        /// root are ignored from the target object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParentPaths service method.</param>
        /// 
        /// <returns>The response from the ListObjectParentPaths service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        ListObjectParentPathsResponse ListObjectParentPaths(ListObjectParentPathsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectParentPaths operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParentPaths operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectParentPaths
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        IAsyncResult BeginListObjectParentPaths(ListObjectParentPathsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectParentPaths operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectParentPaths.</param>
        /// 
        /// <returns>Returns a  ListObjectParentPathsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParentPaths">REST API Reference for ListObjectParentPaths Operation</seealso>
        ListObjectParentPathsResponse EndListObjectParentPaths(IAsyncResult asyncResult);

        #endregion
        
        #region  ListObjectParents


        /// <summary>
        /// Lists parent objects that are associated with a given object in pagination fashion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParents service method.</param>
        /// 
        /// <returns>The response from the ListObjectParents service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.CannotListParentOfRootException">
        /// Cannot list the parents of a <a>Directory</a> root.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        ListObjectParentsResponse ListObjectParents(ListObjectParentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectParents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectParents operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectParents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        IAsyncResult BeginListObjectParents(ListObjectParentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectParents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectParents.</param>
        /// 
        /// <returns>Returns a  ListObjectParentsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectParents">REST API Reference for ListObjectParents Operation</seealso>
        ListObjectParentsResponse EndListObjectParents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListObjectPolicies


        /// <summary>
        /// Returns policies attached to an object in pagination fashion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectPolicies service method.</param>
        /// 
        /// <returns>The response from the ListObjectPolicies service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        ListObjectPoliciesResponse ListObjectPolicies(ListObjectPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectPolicies operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        IAsyncResult BeginListObjectPolicies(ListObjectPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectPolicies.</param>
        /// 
        /// <returns>Returns a  ListObjectPoliciesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListObjectPolicies">REST API Reference for ListObjectPolicies Operation</seealso>
        ListObjectPoliciesResponse EndListObjectPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOutgoingTypedLinks


        /// <summary>
        /// Returns a paginated list of all the outgoing <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingTypedLinks service method.</param>
        /// 
        /// <returns>The response from the ListOutgoingTypedLinks service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        ListOutgoingTypedLinksResponse ListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOutgoingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingTypedLinks operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOutgoingTypedLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        IAsyncResult BeginListOutgoingTypedLinks(ListOutgoingTypedLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOutgoingTypedLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOutgoingTypedLinks.</param>
        /// 
        /// <returns>Returns a  ListOutgoingTypedLinksResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListOutgoingTypedLinks">REST API Reference for ListOutgoingTypedLinks Operation</seealso>
        ListOutgoingTypedLinksResponse EndListOutgoingTypedLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyAttachments


        /// <summary>
        /// Returns all of the <code>ObjectIdentifiers</code> to which a given policy is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyAttachments service method.</param>
        /// 
        /// <returns>The response from the ListPolicyAttachments service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.NotPolicyException">
        /// Indicates that the requested operation can only operate on policy objects.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        ListPolicyAttachmentsResponse ListPolicyAttachments(ListPolicyAttachmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyAttachments operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyAttachments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        IAsyncResult BeginListPolicyAttachments(ListPolicyAttachmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyAttachments.</param>
        /// 
        /// <returns>Returns a  ListPolicyAttachmentsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPolicyAttachments">REST API Reference for ListPolicyAttachments Operation</seealso>
        ListPolicyAttachmentsResponse EndListPolicyAttachments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPublishedSchemaArns


        /// <summary>
        /// Lists the major version families of each published schema. If a major version ARN
        /// is provided as <code>SchemaArn</code>, the minor version revisions in that family
        /// are listed instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublishedSchemaArns service method.</param>
        /// 
        /// <returns>The response from the ListPublishedSchemaArns service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        ListPublishedSchemaArnsResponse ListPublishedSchemaArns(ListPublishedSchemaArnsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPublishedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublishedSchemaArns operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPublishedSchemaArns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        IAsyncResult BeginListPublishedSchemaArns(ListPublishedSchemaArnsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublishedSchemaArns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublishedSchemaArns.</param>
        /// 
        /// <returns>Returns a  ListPublishedSchemaArnsResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListPublishedSchemaArns">REST API Reference for ListPublishedSchemaArns Operation</seealso>
        ListPublishedSchemaArnsResponse EndListPublishedSchemaArns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns tags for a resource. Tagging is currently supported only for directories with
        /// a limit of 50 tags per directory. All 50 tags are returned for a given directory with
        /// this API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidTaggingRequestException">
        /// Can occur for multiple reasons such as when you tag a resource that doesn’t exist
        /// or if you specify a higher number of tags for a resource than the allowed limit. Allowed
        /// limit is 50 tags per resource.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTypedLinkFacetAttributes


        /// <summary>
        /// Returns a paginated list of all attribute definitions for a particular <a>TypedLinkFacet</a>.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetAttributes service method.</param>
        /// 
        /// <returns>The response from the ListTypedLinkFacetAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        ListTypedLinkFacetAttributesResponse ListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypedLinkFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypedLinkFacetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        IAsyncResult BeginListTypedLinkFacetAttributes(ListTypedLinkFacetAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypedLinkFacetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypedLinkFacetAttributes.</param>
        /// 
        /// <returns>Returns a  ListTypedLinkFacetAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetAttributes">REST API Reference for ListTypedLinkFacetAttributes Operation</seealso>
        ListTypedLinkFacetAttributesResponse EndListTypedLinkFacetAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTypedLinkFacetNames


        /// <summary>
        /// Returns a paginated list of <code>TypedLink</code> facet names for a particular schema.
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetNames service method.</param>
        /// 
        /// <returns>The response from the ListTypedLinkFacetNames service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        ListTypedLinkFacetNamesResponse ListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypedLinkFacetNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypedLinkFacetNames operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypedLinkFacetNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        IAsyncResult BeginListTypedLinkFacetNames(ListTypedLinkFacetNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypedLinkFacetNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypedLinkFacetNames.</param>
        /// 
        /// <returns>Returns a  ListTypedLinkFacetNamesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/ListTypedLinkFacetNames">REST API Reference for ListTypedLinkFacetNames Operation</seealso>
        ListTypedLinkFacetNamesResponse EndListTypedLinkFacetNames(IAsyncResult asyncResult);

        #endregion
        
        #region  LookupPolicy


        /// <summary>
        /// Lists all policies from the root of the <a>Directory</a> to the object specified.
        /// If there are no policies present, an empty list is returned. If policies are present,
        /// and if some objects don't have the policies attached, it returns the <code>ObjectIdentifier</code>
        /// for such objects. If policies are present, it returns <code>ObjectIdentifier</code>,
        /// <code>policyId</code>, and <code>policyType</code>. Paths that don't lead to the root
        /// from the target object are ignored. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_key_concepts.html#policies">Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupPolicy service method.</param>
        /// 
        /// <returns>The response from the LookupPolicy service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidNextTokenException">
        /// Indicates that the <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        LookupPolicyResponse LookupPolicy(LookupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the LookupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupPolicy operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLookupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        IAsyncResult BeginLookupPolicy(LookupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  LookupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLookupPolicy.</param>
        /// 
        /// <returns>Returns a  LookupPolicyResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/LookupPolicy">REST API Reference for LookupPolicy Operation</seealso>
        LookupPolicyResponse EndLookupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishSchema


        /// <summary>
        /// Publishes a development schema with a major version and a recommended minor version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishSchema service method.</param>
        /// 
        /// <returns>The response from the PublishSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.SchemaAlreadyPublishedException">
        /// Indicates that a schema is already published.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        PublishSchemaResponse PublishSchema(PublishSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        IAsyncResult BeginPublishSchema(PublishSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishSchema.</param>
        /// 
        /// <returns>Returns a  PublishSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PublishSchema">REST API Reference for PublishSchema Operation</seealso>
        PublishSchemaResponse EndPublishSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSchemaFromJson


        /// <summary>
        /// Allows a schema to be updated using JSON upload. Only available for development schemas.
        /// See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_schemas.html#jsonformat">JSON
        /// Schema Format</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaFromJson service method.</param>
        /// 
        /// <returns>The response from the PutSchemaFromJson service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidSchemaDocException">
        /// Indicates that the provided <code>SchemaDoc</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        PutSchemaFromJsonResponse PutSchemaFromJson(PutSchemaFromJsonRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSchemaFromJson operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaFromJson operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSchemaFromJson
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        IAsyncResult BeginPutSchemaFromJson(PutSchemaFromJsonRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSchemaFromJson operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSchemaFromJson.</param>
        /// 
        /// <returns>Returns a  PutSchemaFromJsonResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/PutSchemaFromJson">REST API Reference for PutSchemaFromJson Operation</seealso>
        PutSchemaFromJsonResponse EndPutSchemaFromJson(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveFacetFromObject


        /// <summary>
        /// Removes the specified facet from the specified object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFacetFromObject service method.</param>
        /// 
        /// <returns>The response from the RemoveFacetFromObject service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        RemoveFacetFromObjectResponse RemoveFacetFromObject(RemoveFacetFromObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFacetFromObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFacetFromObject operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFacetFromObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        IAsyncResult BeginRemoveFacetFromObject(RemoveFacetFromObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFacetFromObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFacetFromObject.</param>
        /// 
        /// <returns>Returns a  RemoveFacetFromObjectResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/RemoveFacetFromObject">REST API Reference for RemoveFacetFromObject Operation</seealso>
        RemoveFacetFromObjectResponse EndRemoveFacetFromObject(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// An API operation for adding tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidTaggingRequestException">
        /// Can occur for multiple reasons such as when you tag a resource that doesn’t exist
        /// or if you specify a higher number of tags for a resource than the allowed limit. Allowed
        /// limit is 50 tags per resource.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// An API operation for removing tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidTaggingRequestException">
        /// Can occur for multiple reasons such as when you tag a resource that doesn’t exist
        /// or if you specify a higher number of tags for a resource than the allowed limit. Allowed
        /// limit is 50 tags per resource.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFacet


        /// <summary>
        /// Does the following:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Adds new <code>Attributes</code>, <code>Rules</code>, or <code>ObjectTypes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updates existing <code>Attributes</code>, <code>Rules</code>, or <code>ObjectTypes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes existing <code>Attributes</code>, <code>Rules</code>, or <code>ObjectTypes</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFacet service method.</param>
        /// 
        /// <returns>The response from the UpdateFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidFacetUpdateException">
        /// An attempt to modify a <a>Facet</a> resulted in an invalid schema exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        UpdateFacetResponse UpdateFacet(UpdateFacetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        IAsyncResult BeginUpdateFacet(UpdateFacetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFacet.</param>
        /// 
        /// <returns>Returns a  UpdateFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateFacet">REST API Reference for UpdateFacet Operation</seealso>
        UpdateFacetResponse EndUpdateFacet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateObjectAttributes


        /// <summary>
        /// Updates a given object's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateObjectAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateObjectAttributes service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.DirectoryNotEnabledException">
        /// Operations are only permitted on enabled directories.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        UpdateObjectAttributesResponse UpdateObjectAttributes(UpdateObjectAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateObjectAttributes operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateObjectAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        IAsyncResult BeginUpdateObjectAttributes(UpdateObjectAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateObjectAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateObjectAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateObjectAttributesResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateObjectAttributes">REST API Reference for UpdateObjectAttributes Operation</seealso>
        UpdateObjectAttributesResponse EndUpdateObjectAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSchema


        /// <summary>
        /// Updates the schema name with a new name. Only development schema names can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        IAsyncResult BeginUpdateSchema(UpdateSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchema.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        UpdateSchemaResponse EndUpdateSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTypedLinkFacet


        /// <summary>
        /// Updates a <a>TypedLinkFacet</a>. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTypedLinkFacet service method.</param>
        /// 
        /// <returns>The response from the UpdateTypedLinkFacet service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetNotFoundException">
        /// The specified <a>Facet</a> could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.FacetValidationException">
        /// The <a>Facet</a> that you provided was not well formed or could not be validated with
        /// the schema.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidFacetUpdateException">
        /// An attempt to modify a <a>Facet</a> resulted in an invalid schema exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidRuleException">
        /// Occurs when any of the rule parameter keys or values are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        UpdateTypedLinkFacetResponse UpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTypedLinkFacet operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTypedLinkFacet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        IAsyncResult BeginUpdateTypedLinkFacet(UpdateTypedLinkFacetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTypedLinkFacet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTypedLinkFacet.</param>
        /// 
        /// <returns>Returns a  UpdateTypedLinkFacetResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpdateTypedLinkFacet">REST API Reference for UpdateTypedLinkFacet Operation</seealso>
        UpdateTypedLinkFacetResponse EndUpdateTypedLinkFacet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpgradeAppliedSchema


        /// <summary>
        /// Upgrades a single directory in-place using the <code>PublishedSchemaArn</code> with
        /// schema updates found in <code>MinorVersion</code>. Backwards-compatible minor version
        /// upgrades are instantaneously available for readers on all objects in the directory.
        /// Note: This is a synchronous API call and upgrades only one schema on a given directory
        /// per call. To upgrade multiple directories from one schema, you would need to call
        /// this API on each directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeAppliedSchema service method.</param>
        /// 
        /// <returns>The response from the UpgradeAppliedSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.IncompatibleSchemaException">
        /// Indicates a failure occurred while performing a check for backward compatibility between
        /// the specified schema and the schema that is currently applied to the directory.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        UpgradeAppliedSchemaResponse UpgradeAppliedSchema(UpgradeAppliedSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeAppliedSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeAppliedSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradeAppliedSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        IAsyncResult BeginUpgradeAppliedSchema(UpgradeAppliedSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradeAppliedSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradeAppliedSchema.</param>
        /// 
        /// <returns>Returns a  UpgradeAppliedSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradeAppliedSchema">REST API Reference for UpgradeAppliedSchema Operation</seealso>
        UpgradeAppliedSchemaResponse EndUpgradeAppliedSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  UpgradePublishedSchema


        /// <summary>
        /// Upgrades a published schema under a new minor version revision using the current contents
        /// of <code>DevelopmentSchemaArn</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradePublishedSchema service method.</param>
        /// 
        /// <returns>The response from the UpgradePublishedSchema service method, as returned by CloudDirectory.</returns>
        /// <exception cref="Amazon.CloudDirectory.Model.AccessDeniedException">
        /// Access denied. Check your permissions.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.IncompatibleSchemaException">
        /// Indicates a failure occurred while performing a check for backward compatibility between
        /// the specified schema and the schema that is currently applied to the directory.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InternalServiceException">
        /// Indicates a problem that must be resolved by Amazon Web Services. This might be a
        /// transient error in which case you can retry your request until it succeeds. Otherwise,
        /// go to the <a href="http://status.aws.amazon.com/">AWS Service Health Dashboard</a>
        /// site to see if there are any operational issues with the service.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidArnException">
        /// Indicates that the provided ARN value is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.InvalidAttachmentException">
        /// Indicates that an attempt to attach an object with the same link name or to apply
        /// a schema with the same name has occurred. Rename the link or the schema and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.LimitExceededException">
        /// Indicates that limits are exceeded. See <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html">Limits</a>
        /// for more information.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.RetryableConflictException">
        /// Occurs when a conflict with a previous successful write is detected. For example,
        /// if a write operation occurs on an object and then an attempt is made to read the object
        /// using “SERIALIZABLE” consistency, this exception may result. This generally occurs
        /// when the previous write did not have time to propagate to the host serving the current
        /// request. A retry (with appropriate backoff logic) is the recommended response to this
        /// exception.
        /// </exception>
        /// <exception cref="Amazon.CloudDirectory.Model.ValidationException">
        /// Indicates that your request is malformed in some manner. See the exception message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        UpgradePublishedSchemaResponse UpgradePublishedSchema(UpgradePublishedSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradePublishedSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradePublishedSchema operation on AmazonCloudDirectoryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradePublishedSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        IAsyncResult BeginUpgradePublishedSchema(UpgradePublishedSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradePublishedSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradePublishedSchema.</param>
        /// 
        /// <returns>Returns a  UpgradePublishedSchemaResult from CloudDirectory.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/clouddirectory-2016-05-10/UpgradePublishedSchema">REST API Reference for UpgradePublishedSchema Operation</seealso>
        UpgradePublishedSchemaResponse EndUpgradePublishedSchema(IAsyncResult asyncResult);

        #endregion
        
    }
}