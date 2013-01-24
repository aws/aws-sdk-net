/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-04-15
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.SimpleDB.Model;

namespace Amazon.SimpleDB
{
    /// <summary>
    /// Amazon SimpleDB is a web service for running queries on structured
    /// data in real time. This service works in close conjunction with Amazon
    /// Simple Storage Service (Amazon S3) and Amazon Elastic Compute Cloud
    /// (Amazon EC2), collectively providing the ability to store, process
    /// and query data sets in the cloud. These services are designed to make
    /// web-scale computing easier and more cost-effective for developers.
    /// Traditionally, this type of functionality has been accomplished with
    /// a clustered relational database that requires a sizable upfront
    /// investment, brings more complexity than is typically needed, and often
    /// requires a DBA to maintain and administer. In contrast, Amazon SimpleDB
    /// is easy to use and provides the core functionality of a database -
    /// real-time lookup and simple querying of structured data without the
    /// operational complexity.  Amazon SimpleDB requires no schema, automatically
    /// indexes your data and provides a simple API for storage and access.
    /// This eliminates the administrative burden of data modeling, index
    /// maintenance, and performance tuning. Developers gain access to this
    /// functionality within Amazon's proven computing environment, are able
    /// to scale instantly, and pay only for what they use.
    /// </summary>
    public interface AmazonSimpleDB : IDisposable
    {
        #region CreateDomain Operation

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.CreateDomain"/>
        /// </summary>
        /// <param name="request">The CreateDomainRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndCreateDomain.</returns>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.CreateDomain"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a CreateDomainResponse from S3.</returns>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

        /// <summary>
        /// Create Domain
        /// </summary>
        /// <param name="request">Create Domain  request</param>
        /// <returns>Create Domain  Response from the service</returns>
        /// <remarks>
        /// The CreateDomain operation creates a new domain. The domain name must be unique
        /// among the domains associated with the Access Key ID provided in the request. The CreateDomain
        /// operation may take 10 or more seconds to complete.
        /// </remarks>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);

        #endregion

        #region ListDomains Operation

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.ListDomains"/>
        /// </summary>
        /// <param name="request">The ListDomainsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListDomains.</returns>
        IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListDomains operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.ListDomains"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a ListDomainsResponse from S3.</returns>
        ListDomainsResponse EndListDomains(IAsyncResult asyncResult);

        /// <summary>
        /// List Domains
        /// </summary>
        /// <param name="request">List Domains  request</param>
        /// <returns>List Domains  Response from the service</returns>
        /// <remarks>
        /// The ListDomains operation lists all domains associated with the Access Key ID. It returns
        /// domain names up to the limit set by MaxNumberOfDomains. A NextToken is returned if there are more
        /// than MaxNumberOfDomains domains. Calling ListDomains successive times with the
        /// NextToken returns up to MaxNumberOfDomains more domain names each time.
        /// </remarks>
        ListDomainsResponse ListDomains(ListDomainsRequest request);

        #endregion

        #region DomainMetadata Operation

        /// <summary>
        /// Initiates the asynchronous execution of the DomainMetadata operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DomainMetadata"/>
        /// </summary>
        /// <param name="request">The DomainMetadataRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDomainMetadata.</returns>
        IAsyncResult BeginDomainMetadata(DomainMetadataRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DomainMetadata operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DomainMetadata"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDomainMetadata.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a DomainMetadataResponse from S3.</returns>
        DomainMetadataResponse EndDomainMetadata(IAsyncResult asyncResult);

        /// <summary>
        /// Domain Metadata
        /// </summary>
        /// <param name="request">Domain Metadata  request</param>
        /// <returns>Domain Metadata  Response from the service</returns>
        /// <remarks>
        /// The DomainMetadata operation returns some domain metadata values, such as the
        /// number of items, attribute names and attribute values along with their sizes.
        /// </remarks>
        DomainMetadataResponse DomainMetadata(DomainMetadataRequest request);

        #endregion

        #region DeleteDomain Operation

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DeleteDomain"/>
        /// </summary>
        /// <param name="request">The DeleteDomainRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteDomain.</returns>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DeleteDomain"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a DeleteDomainResponse from S3.</returns>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

        /// <summary>
        /// Delete Domain
        /// </summary>
        /// <param name="request">Delete Domain  request</param>
        /// <returns>Delete Domain  Response from the service</returns>
        /// <remarks>
        /// The DeleteDomain operation deletes a domain. Any items (and their attributes) in the domain
        /// are deleted as well. The DeleteDomain operation may take 10 or more seconds to complete.
        /// </remarks>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        #endregion

        #region PutAttributes Operation

        /// <summary>
        /// Initiates the asynchronous execution of the PutAttributes operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.PutAttributes"/>
        /// </summary>
        /// <param name="request">The PutAttributesRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutAttributes.</returns>
        IAsyncResult BeginPutAttributes(PutAttributesRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.PutAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a PutAttributesResponse from S3.</returns>
        PutAttributesResponse EndPutAttributes(IAsyncResult asyncResult);

        /// <summary>
        /// Put Attributes
        /// </summary>
        /// <param name="request">Put Attributes  request</param>
        /// <returns>Put Attributes  Response from the service</returns>
        /// <remarks>
        /// The PutAttributes operation creates or replaces attributes within an item. You specify new attributes
        /// using a combination of the Attribute.X.Name and Attribute.X.Value parameters. You specify
        /// the first attribute by the parameters Attribute.0.Name and Attribute.0.Value, the second
        /// attribute by the parameters Attribute.1.Name and Attribute.1.Value, and so on.
        /// Attributes are uniquely identified within an item by their name/value combination. For example, a single
        /// item can have the attributes { "first_name", "first_value" } and { "first_name",
        /// second_value" }. However, it cannot have two attribute instances where both the Attribute.X.Name and
        /// Attribute.X.Value are the same.
        /// Optionally, the requestor can supply the Replace parameter for each individual value. Setting this value
        /// to true will cause the new attribute value to replace the existing attribute value(s). For example, if an
        /// item has the attributes { 'a', '1' }, { 'b', '2'} and { 'b', '3' } and the requestor does a
        /// PutAttributes of { 'b', '4' } with the Replace parameter set to true, the final attributes of the
        /// item will be { 'a', '1' } and { 'b', '4' }, replacing the previous values of the 'b' attribute
        /// with the new value.
        /// </remarks>
        PutAttributesResponse PutAttributes(PutAttributesRequest request);

        #endregion

        #region BatchPutAttributes Operation

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutAttributes operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.BatchPutAttributes"/>
        /// </summary>
        /// <param name="request">The BatchPutAttributesRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndBatchPutAttributes.</returns>
        IAsyncResult BeginBatchPutAttributes(BatchPutAttributesRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the BatchPutAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.BatchPutAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a BatchPutAttributesResponse from S3.</returns>
        BatchPutAttributesResponse EndBatchPutAttributes(IAsyncResult asyncResult);

        /// <summary>
        /// Batch Put Attributes
        /// </summary>
        /// <param name="request">Batch Put Attributes  request</param>
        /// <returns>Batch Put Attributes  Response from the service</returns>
        /// <remarks>
        /// The BatchPutAttributes operation creates or replaces attributes within one or more items.
        /// You specify the item name with the Item.X.ItemName parameter.
        /// You specify new attributes using a combination of the Item.X.Attribute.Y.Name and Item.X.Attribute.Y.Value parameters.
        /// You specify the first attribute for the first item by the parameters Item.0.Attribute.0.Name and Item.0.Attribute.0.Value,
        /// the second attribute for the first item by the parameters Item.0.Attribute.1.Name and Item.0.Attribute.1.Value, and so on.
        /// Attributes are uniquely identified within an item by their name/value combination. For example, a single
        /// item can have the attributes { "first_name", "first_value" } and { "first_name",
        /// second_value" }. However, it cannot have two attribute instances where both the Item.X.Attribute.Y.Name and
        /// Item.X.Attribute.Y.Value are the same.
        /// Optionally, the requestor can supply the Replace parameter for each individual value. Setting this value
        /// to true will cause the new attribute value to replace the existing attribute value(s). For example, if an
        /// item 'I' has the attributes { 'a', '1' }, { 'b', '2'} and { 'b', '3' } and the requestor does a
        /// BacthPutAttributes of {'I', 'b', '4' } with the Replace parameter set to true, the final attributes of the
        /// item will be { 'a', '1' } and { 'b', '4' }, replacing the previous values of the 'b' attribute
        /// with the new value.
        /// </remarks>
        BatchPutAttributesResponse BatchPutAttributes(BatchPutAttributesRequest request);

        #endregion

        #region GetAttributes Operation

        /// <summary>
        /// Initiates the asynchronous execution of the GetAttributes operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.GetAttributes"/>
        /// </summary>
        /// <param name="request">The GetAttributesRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetAttributes.</returns>
        IAsyncResult BeginGetAttributes(GetAttributesRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.GetAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a GetAttributesResponse from S3.</returns>
        GetAttributesResponse EndGetAttributes(IAsyncResult asyncResult);

        /// <summary>
        /// Get Attributes
        /// </summary>
        /// <param name="request">Get Attributes  request</param>
        /// <returns>Get Attributes  Response from the service</returns>
        /// <remarks>
        /// Returns all of the attributes associated with the item. Optionally, the attributes returned can be limited to
        /// the specified AttributeName parameter.
        /// If the item does not exist on the replica that was accessed for this operation, an empty attribute is
        /// returned. The system does not return an error as it cannot guarantee the item does not exist on other
        /// replicas.
        /// </remarks>
        GetAttributesResponse GetAttributes(GetAttributesRequest request);

        #endregion

        #region DeleteAttributes Operation

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttributes operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DeleteAttributes"/>
        /// </summary>
        /// <param name="request">The DeleteAttributesRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteAttributes.</returns>
        IAsyncResult BeginDeleteAttributes(DeleteAttributesRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DeleteAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a DeleteAttributesResponse from S3.</returns>
        DeleteAttributesResponse EndDeleteAttributes(IAsyncResult asyncResult);

        /// <summary>
        /// Delete Attributes
        /// </summary>
        /// <param name="request">Delete Attributes  request</param>
        /// <returns>Delete Attributes  Response from the service</returns>
        /// <remarks>
        /// Deletes one or more attributes associated with the item. If all attributes of an item are deleted, the item is
        /// deleted.
        /// </remarks>
        DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request);

        #endregion

        #region BatchDeleteAttributes Operation

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteAttributes operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.BatchDeleteAttributes"/>
        /// </summary>
        /// <param name="request">The BatchDeleteAttributesRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndBatchDeleteAttributes.</returns>
        IAsyncResult BeginBatchDeleteAttributes(BatchDeleteAttributesRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the BatchDeleteAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.BatchDeleteAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a BatchDeleteAttributesResponse from S3.</returns>
        BatchDeleteAttributesResponse EndBatchDeleteAttributes(IAsyncResult asyncResult);

        /// <summary>
        /// Batch Delete Attributes
        /// </summary>
        /// <param name="request">Batch Delete Attributes request</param>
        /// <returns>BatchDeleteAttributesResponse from the service</returns>
        /// <remarks>
        /// The BatchDeleteAttributes operation deletes attributes within one or more items.
        /// An item name and a collection of <see cref="T:Amazon.SimpleDB.Model.Attribute"/> is specified for each
        /// item to have attributes deleted for.  If no attributes are specified then the entire item will be deleted.
        /// </remarks>
        BatchDeleteAttributesResponse BatchDeleteAttributes(BatchDeleteAttributesRequest request);

        #endregion

        #region Select Operation

        /// <summary>
        /// Initiates the asynchronous execution of the Select operation. 
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.Select"/>
        /// </summary>
        /// <param name="request">The SelectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndSelect.</returns>
        IAsyncResult BeginSelect(SelectRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the Select operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.Select"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSelect.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a SelectResponse from S3.</returns>
        SelectResponse EndSelect(IAsyncResult asyncResult);

        /// <summary>
        /// Select
        /// </summary>
        /// <param name="request">Select  request</param>
        /// <returns>Select  Response from the service</returns>
        /// <remarks>
        /// The Select operation returns a set of item names and associate attributes that match the
        /// query expression. Select operations that run longer than 5 seconds will likely time-out
        /// and return a time-out error response.
        /// </remarks>
        SelectResponse Select(SelectRequest request);


        #endregion

    }
}
