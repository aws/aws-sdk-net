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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimpleDB.Model;

#pragma warning disable CS1570
namespace Amazon.SimpleDB
{
    /// <summary>
    /// <para>Interface for accessing SimpleDB</para>
    ///
    /// Amazon SimpleDB is a web service providing the core database functions of data indexing
    /// and querying in the cloud. By offloading the time and effort associated with building
    /// and operating a web-scale database, SimpleDB provides developers the freedom to focus
    /// on application development. 
    /// <para>
    ///  A traditional, clustered relational database requires a sizable upfront capital outlay,
    /// is complex to design, and often requires extensive and repetitive database administration.
    /// Amazon SimpleDB is dramatically simpler, requiring no schema, automatically indexing
    /// your data and providing a simple API for storage and access. This approach eliminates
    /// the administrative burden of data modeling, index maintenance, and performance tuning.
    /// Developers gain access to this functionality within Amazon's proven computing environment,
    /// are able to scale instantly, and pay only for what they use. 
    /// </para>
    ///  
    /// <para>
    ///  Visit <a href="http://aws.amazon.com/simpledb/">http://aws.amazon.com/simpledb/</a>
    /// for more information. 
    /// </para>
    /// </summary>
    public partial interface IAmazonSimpleDB : IAmazonService, IDisposable
    {


        
        #region  BatchDeleteAttributes


        /// <summary>
        /// Performs multiple DeleteAttributes operations in a single call, which reduces round
        /// trips and latencies. This enables Amazon SimpleDB to optimize requests, which generally
        /// yields better throughput. 
        /// 
        ///  
        /// <para>
        ///  The following limitations are enforced for this operation: <ul> <li>1 MB request
        /// size</li> <li>25 item limit per BatchDeleteAttributes operation</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAttributes service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteAttributes service method, as returned by SimpleDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/BatchDeleteAttributes">REST API Reference for BatchDeleteAttributes Operation</seealso>
        BatchDeleteAttributesResponse BatchDeleteAttributes(BatchDeleteAttributesRequest request);



        /// <summary>
        /// Performs multiple DeleteAttributes operations in a single call, which reduces round
        /// trips and latencies. This enables Amazon SimpleDB to optimize requests, which generally
        /// yields better throughput. 
        /// 
        ///  
        /// <para>
        ///  The following limitations are enforced for this operation: <ul> <li>1 MB request
        /// size</li> <li>25 item limit per BatchDeleteAttributes operation</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteAttributes service method, as returned by SimpleDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/BatchDeleteAttributes">REST API Reference for BatchDeleteAttributes Operation</seealso>
        Task<BatchDeleteAttributesResponse> BatchDeleteAttributesAsync(BatchDeleteAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchPutAttributes


        /// <summary>
        /// The <c>BatchPutAttributes</c> operation creates or replaces attributes within one
        /// or more items. By using this operation, the client can perform multiple <a>PutAttribute</a>
        /// operation with a single call. This helps yield savings in round trips and latencies,
        /// enabling Amazon SimpleDB to optimize requests and generally produce better throughput.
        /// 
        /// 
        ///  
        /// <para>
        ///  The client may specify the item name with the <c>Item.X.ItemName</c> parameter. The
        /// client may specify new attributes using a combination of the <c>Item.X.Attribute.Y.Name</c>
        /// and <c>Item.X.Attribute.Y.Value</c> parameters. The client may specify the first attribute
        /// for the first item using the parameters <c>Item.0.Attribute.0.Name</c> and <c>Item.0.Attribute.0.Value</c>,
        /// and for the second attribute for the first item by the parameters <c>Item.0.Attribute.1.Name</c>
        /// and <c>Item.0.Attribute.1.Value</c>, and so on. 
        /// </para>
        ///  
        /// <para>
        ///  Attributes are uniquely identified within an item by their name/value combination.
        /// For example, a single item can have the attributes <c>{ "first_name", "first_value"
        /// }</c> and <c>{ "first_name", "second_value" }</c>. However, it cannot have two attribute
        /// instances where both the <c>Item.X.Attribute.Y.Name</c> and <c>Item.X.Attribute.Y.Value</c>
        /// are the same. 
        /// </para>
        ///  
        /// <para>
        ///  Optionally, the requester can supply the <c>Replace</c> parameter for each individual
        /// value. Setting this value to <c>true</c> will cause the new attribute values to replace
        /// the existing attribute values. For example, if an item <c>I</c> has the attributes
        /// <c>{ 'a', '1' }, { 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requester does a
        /// BatchPutAttributes of <c>{'I', 'b', '4' }</c> with the Replace parameter set to true,
        /// the final attributes of the item will be <c>{ 'a', '1' }</c> and <c>{ 'b', '4' }</c>,
        /// replacing the previous values of the 'b' attribute with the new value. 
        /// </para>
        ///  <important> This operation is vulnerable to exceeding the maximum URL size when making
        /// a REST request using the HTTP GET method. This operation does not support conditions
        /// using <c>Expected.X.Name</c>, <c>Expected.X.Value</c>, or <c>Expected.X.Exists</c>.
        /// </important> 
        /// <para>
        ///  You can execute multiple <c>BatchPutAttributes</c> operations and other operations
        /// in parallel. However, large numbers of concurrent <c>BatchPutAttributes</c> calls
        /// can result in Service Unavailable (503) responses. 
        /// </para>
        ///  
        /// <para>
        ///  The following limitations are enforced for this operation: <ul> <li>256 attribute
        /// name-value pairs per item</li> <li>1 MB request size</li> <li>1 billion attributes
        /// per domain</li> <li>10 GB of total user data storage per domain</li> <li>25 item limit
        /// per <c>BatchPutAttributes</c> operation</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAttributes service method.</param>
        /// 
        /// <returns>The response from the BatchPutAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.DuplicateItemNameException">
        /// The item name was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainAttributesExceededException">
        /// Too many attributes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainBytesExceededException">
        /// Too many bytes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberItemAttributesExceededException">
        /// Too many attributes in this item.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberSubmittedAttributesExceededException">
        /// Too many attributes exist in a single call.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberSubmittedItemsExceededException">
        /// Too many items exist in a single call.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/BatchPutAttributes">REST API Reference for BatchPutAttributes Operation</seealso>
        BatchPutAttributesResponse BatchPutAttributes(BatchPutAttributesRequest request);



        /// <summary>
        /// The <c>BatchPutAttributes</c> operation creates or replaces attributes within one
        /// or more items. By using this operation, the client can perform multiple <a>PutAttribute</a>
        /// operation with a single call. This helps yield savings in round trips and latencies,
        /// enabling Amazon SimpleDB to optimize requests and generally produce better throughput.
        /// 
        /// 
        ///  
        /// <para>
        ///  The client may specify the item name with the <c>Item.X.ItemName</c> parameter. The
        /// client may specify new attributes using a combination of the <c>Item.X.Attribute.Y.Name</c>
        /// and <c>Item.X.Attribute.Y.Value</c> parameters. The client may specify the first attribute
        /// for the first item using the parameters <c>Item.0.Attribute.0.Name</c> and <c>Item.0.Attribute.0.Value</c>,
        /// and for the second attribute for the first item by the parameters <c>Item.0.Attribute.1.Name</c>
        /// and <c>Item.0.Attribute.1.Value</c>, and so on. 
        /// </para>
        ///  
        /// <para>
        ///  Attributes are uniquely identified within an item by their name/value combination.
        /// For example, a single item can have the attributes <c>{ "first_name", "first_value"
        /// }</c> and <c>{ "first_name", "second_value" }</c>. However, it cannot have two attribute
        /// instances where both the <c>Item.X.Attribute.Y.Name</c> and <c>Item.X.Attribute.Y.Value</c>
        /// are the same. 
        /// </para>
        ///  
        /// <para>
        ///  Optionally, the requester can supply the <c>Replace</c> parameter for each individual
        /// value. Setting this value to <c>true</c> will cause the new attribute values to replace
        /// the existing attribute values. For example, if an item <c>I</c> has the attributes
        /// <c>{ 'a', '1' }, { 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requester does a
        /// BatchPutAttributes of <c>{'I', 'b', '4' }</c> with the Replace parameter set to true,
        /// the final attributes of the item will be <c>{ 'a', '1' }</c> and <c>{ 'b', '4' }</c>,
        /// replacing the previous values of the 'b' attribute with the new value. 
        /// </para>
        ///  <important> This operation is vulnerable to exceeding the maximum URL size when making
        /// a REST request using the HTTP GET method. This operation does not support conditions
        /// using <c>Expected.X.Name</c>, <c>Expected.X.Value</c>, or <c>Expected.X.Exists</c>.
        /// </important> 
        /// <para>
        ///  You can execute multiple <c>BatchPutAttributes</c> operations and other operations
        /// in parallel. However, large numbers of concurrent <c>BatchPutAttributes</c> calls
        /// can result in Service Unavailable (503) responses. 
        /// </para>
        ///  
        /// <para>
        ///  The following limitations are enforced for this operation: <ul> <li>256 attribute
        /// name-value pairs per item</li> <li>1 MB request size</li> <li>1 billion attributes
        /// per domain</li> <li>10 GB of total user data storage per domain</li> <li>25 item limit
        /// per <c>BatchPutAttributes</c> operation</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.DuplicateItemNameException">
        /// The item name was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainAttributesExceededException">
        /// Too many attributes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainBytesExceededException">
        /// Too many bytes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberItemAttributesExceededException">
        /// Too many attributes in this item.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberSubmittedAttributesExceededException">
        /// Too many attributes exist in a single call.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberSubmittedItemsExceededException">
        /// Too many items exist in a single call.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/BatchPutAttributes">REST API Reference for BatchPutAttributes Operation</seealso>
        Task<BatchPutAttributesResponse> BatchPutAttributesAsync(BatchPutAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// The <c>CreateDomain</c> operation creates a new domain. The domain name should be
        /// unique among the domains associated with the Access Key ID provided in the request.
        /// The <c>CreateDomain</c> operation may take 10 or more seconds to complete. 
        /// 
        ///  
        /// <para>
        ///  The client can create up to 100 domains per account. 
        /// </para>
        ///  
        /// <para>
        ///  If the client requires additional domains, go to <a href="http://aws.amazon.com/contact-us/simpledb-limit-request/">
        /// http://aws.amazon.com/contact-us/simpledb-limit-request/</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainsExceededException">
        /// Too many domains exist per this account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);



        /// <summary>
        /// The <c>CreateDomain</c> operation creates a new domain. The domain name should be
        /// unique among the domains associated with the Access Key ID provided in the request.
        /// The <c>CreateDomain</c> operation may take 10 or more seconds to complete. 
        /// 
        ///  
        /// <para>
        ///  The client can create up to 100 domains per account. 
        /// </para>
        ///  
        /// <para>
        ///  If the client requires additional domains, go to <a href="http://aws.amazon.com/contact-us/simpledb-limit-request/">
        /// http://aws.amazon.com/contact-us/simpledb-limit-request/</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainsExceededException">
        /// Too many domains exist per this account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAttributes


        /// <summary>
        /// Deletes one or more attributes associated with an item. If all attributes of the
        /// item are deleted, the item is deleted. 
        /// 
        ///  
        /// <para>
        ///  <c>DeleteAttributes</c> is an idempotent operation; running it multiple times on
        /// the same item or attribute does not result in an error response. 
        /// </para>
        ///  
        /// <para>
        ///  Because Amazon SimpleDB makes multiple copies of item data and uses an eventual consistency
        /// update model, performing a <a>GetAttributes</a> or <a>Select</a> operation (read)
        /// immediately after a <c>DeleteAttributes</c> or <a>PutAttributes</a> operation (write)
        /// might not return updated item data. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes service method.</param>
        /// 
        /// <returns>The response from the DeleteAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.AttributeDoesNotExistException">
        /// The specified attribute does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request);



        /// <summary>
        /// Deletes one or more attributes associated with an item. If all attributes of the
        /// item are deleted, the item is deleted. 
        /// 
        ///  
        /// <para>
        ///  <c>DeleteAttributes</c> is an idempotent operation; running it multiple times on
        /// the same item or attribute does not result in an error response. 
        /// </para>
        ///  
        /// <para>
        ///  Because Amazon SimpleDB makes multiple copies of item data and uses an eventual consistency
        /// update model, performing a <a>GetAttributes</a> or <a>Select</a> operation (read)
        /// immediately after a <c>DeleteAttributes</c> or <a>PutAttributes</a> operation (write)
        /// might not return updated item data. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.AttributeDoesNotExistException">
        /// The specified attribute does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/DeleteAttributes">REST API Reference for DeleteAttributes Operation</seealso>
        Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// The <c>DeleteDomain</c> operation deletes a domain. Any items (and their attributes)
        /// in the domain are deleted as well. The <c>DeleteDomain</c> operation might take 10
        /// or more seconds to complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);



        /// <summary>
        /// The <c>DeleteDomain</c> operation deletes a domain. Any items (and their attributes)
        /// in the domain are deleted as well. The <c>DeleteDomain</c> operation might take 10
        /// or more seconds to complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DomainMetadata


        /// <summary>
        /// Returns information about the domain, including when the domain was created, the
        /// number of items and attributes in the domain, and the size of the attribute names
        /// and values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DomainMetadata service method.</param>
        /// 
        /// <returns>The response from the DomainMetadata service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/DomainMetadata">REST API Reference for DomainMetadata Operation</seealso>
        DomainMetadataResponse DomainMetadata(DomainMetadataRequest request);



        /// <summary>
        /// Returns information about the domain, including when the domain was created, the
        /// number of items and attributes in the domain, and the size of the attribute names
        /// and values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DomainMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DomainMetadata service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/DomainMetadata">REST API Reference for DomainMetadata Operation</seealso>
        Task<DomainMetadataResponse> DomainMetadataAsync(DomainMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAttributes


        /// <summary>
        /// Returns all of the attributes associated with the specified item. Optionally, the
        /// attributes returned can be limited to one or more attributes by specifying an attribute
        /// name parameter. 
        /// 
        ///  
        /// <para>
        ///  If the item does not exist on the replica that was accessed for this operation, an
        /// empty set is returned. The system does not return an error as it cannot guarantee
        /// the item does not exist on other replicas. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributes service method.</param>
        /// 
        /// <returns>The response from the GetAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/GetAttributes">REST API Reference for GetAttributes Operation</seealso>
        GetAttributesResponse GetAttributes(GetAttributesRequest request);



        /// <summary>
        /// Returns all of the attributes associated with the specified item. Optionally, the
        /// attributes returned can be limited to one or more attributes by specifying an attribute
        /// name parameter. 
        /// 
        ///  
        /// <para>
        ///  If the item does not exist on the replica that was accessed for this operation, an
        /// empty set is returned. The system does not return an error as it cannot guarantee
        /// the item does not exist on other replicas. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/GetAttributes">REST API Reference for GetAttributes Operation</seealso>
        Task<GetAttributesResponse> GetAttributesAsync(GetAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// The <c>ListDomains</c> operation lists all domains associated with the Access Key
        /// ID. It returns domain names up to the limit set by <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a>.
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c>
        /// domains. Calling <c>ListDomains</c> successive times with the <c>NextToken</c> provided
        /// by the operation returns up to <c>MaxNumberOfDomains</c> more domain names with each
        /// successive operation call.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNextTokenException">
        /// The specified NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains();


        /// <summary>
        /// The <c>ListDomains</c> operation lists all domains associated with the Access Key
        /// ID. It returns domain names up to the limit set by <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a>.
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c>
        /// domains. Calling <c>ListDomains</c> successive times with the <c>NextToken</c> provided
        /// by the operation returns up to <c>MaxNumberOfDomains</c> more domain names with each
        /// successive operation call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNextTokenException">
        /// The specified NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);


        /// <summary>
        /// The <c>ListDomains</c> operation lists all domains associated with the Access Key
        /// ID. It returns domain names up to the limit set by <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a>.
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c>
        /// domains. Calling <c>ListDomains</c> successive times with the <c>NextToken</c> provided
        /// by the operation returns up to <c>MaxNumberOfDomains</c> more domain names with each
        /// successive operation call.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNextTokenException">
        /// The specified NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// The <c>ListDomains</c> operation lists all domains associated with the Access Key
        /// ID. It returns domain names up to the limit set by <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a>.
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c>
        /// domains. Calling <c>ListDomains</c> successive times with the <c>NextToken</c> provided
        /// by the operation returns up to <c>MaxNumberOfDomains</c> more domain names with each
        /// successive operation call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNextTokenException">
        /// The specified NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAttributes


        /// <summary>
        /// The PutAttributes operation creates or replaces attributes in an item. The client
        /// may specify new attributes using a combination of the <c>Attribute.X.Name</c> and
        /// <c>Attribute.X.Value</c> parameters. The client specifies the first attribute by the
        /// parameters <c>Attribute.0.Name</c> and <c>Attribute.0.Value</c>, the second attribute
        /// by the parameters <c>Attribute.1.Name</c> and <c>Attribute.1.Value</c>, and so on.
        /// 
        /// 
        ///  
        /// <para>
        ///  Attributes are uniquely identified in an item by their name/value combination. For
        /// example, a single item can have the attributes <c>{ "first_name", "first_value" }</c>
        /// and <c>{ "first_name", second_value" }</c>. However, it cannot have two attribute
        /// instances where both the <c>Attribute.X.Name</c> and <c>Attribute.X.Value</c> are
        /// the same. 
        /// </para>
        ///  
        /// <para>
        ///  Optionally, the requestor can supply the <c>Replace</c> parameter for each individual
        /// attribute. Setting this value to <c>true</c> causes the new attribute value to replace
        /// the existing attribute value(s). For example, if an item has the attributes <c>{ 'a',
        /// '1' }</c>, <c>{ 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requestor calls <c>PutAttributes</c>
        /// using the attributes <c>{ 'b', '4' }</c> with the <c>Replace</c> parameter set to
        /// true, the final attributes of the item are changed to <c>{ 'a', '1' }</c> and <c>{
        /// 'b', '4' }</c>, which replaces the previous values of the 'b' attribute with the new
        /// value. 
        /// </para>
        ///  
        /// <para>
        ///  You cannot specify an empty string as an attribute name. 
        /// </para>
        ///  
        /// <para>
        ///  Because Amazon SimpleDB makes multiple copies of client data and uses an eventual
        /// consistency update model, an immediate <a>GetAttributes</a> or <a>Select</a> operation
        /// (read) immediately after a <a>PutAttributes</a> or <a>DeleteAttributes</a> operation
        /// (write) might not return the updated data. 
        /// </para>
        ///  
        /// <para>
        ///  The following limitations are enforced for this operation: <ul> <li>256 total attribute
        /// name-value pairs per item</li> <li>One billion attributes per domain</li> <li>10 GB
        /// of total user data storage per domain</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.AttributeDoesNotExistException">
        /// The specified attribute does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainAttributesExceededException">
        /// Too many attributes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainBytesExceededException">
        /// Too many bytes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberItemAttributesExceededException">
        /// Too many attributes in this item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        PutAttributesResponse PutAttributes(PutAttributesRequest request);



        /// <summary>
        /// The PutAttributes operation creates or replaces attributes in an item. The client
        /// may specify new attributes using a combination of the <c>Attribute.X.Name</c> and
        /// <c>Attribute.X.Value</c> parameters. The client specifies the first attribute by the
        /// parameters <c>Attribute.0.Name</c> and <c>Attribute.0.Value</c>, the second attribute
        /// by the parameters <c>Attribute.1.Name</c> and <c>Attribute.1.Value</c>, and so on.
        /// 
        /// 
        ///  
        /// <para>
        ///  Attributes are uniquely identified in an item by their name/value combination. For
        /// example, a single item can have the attributes <c>{ "first_name", "first_value" }</c>
        /// and <c>{ "first_name", second_value" }</c>. However, it cannot have two attribute
        /// instances where both the <c>Attribute.X.Name</c> and <c>Attribute.X.Value</c> are
        /// the same. 
        /// </para>
        ///  
        /// <para>
        ///  Optionally, the requestor can supply the <c>Replace</c> parameter for each individual
        /// attribute. Setting this value to <c>true</c> causes the new attribute value to replace
        /// the existing attribute value(s). For example, if an item has the attributes <c>{ 'a',
        /// '1' }</c>, <c>{ 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requestor calls <c>PutAttributes</c>
        /// using the attributes <c>{ 'b', '4' }</c> with the <c>Replace</c> parameter set to
        /// true, the final attributes of the item are changed to <c>{ 'a', '1' }</c> and <c>{
        /// 'b', '4' }</c>, which replaces the previous values of the 'b' attribute with the new
        /// value. 
        /// </para>
        ///  
        /// <para>
        ///  You cannot specify an empty string as an attribute name. 
        /// </para>
        ///  
        /// <para>
        ///  Because Amazon SimpleDB makes multiple copies of client data and uses an eventual
        /// consistency update model, an immediate <a>GetAttributes</a> or <a>Select</a> operation
        /// (read) immediately after a <a>PutAttributes</a> or <a>DeleteAttributes</a> operation
        /// (write) might not return the updated data. 
        /// </para>
        ///  
        /// <para>
        ///  The following limitations are enforced for this operation: <ul> <li>256 total attribute
        /// name-value pairs per item</li> <li>One billion attributes per domain</li> <li>10 GB
        /// of total user data storage per domain</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAttributes service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.AttributeDoesNotExistException">
        /// The specified attribute does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainAttributesExceededException">
        /// Too many attributes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberDomainBytesExceededException">
        /// Too many bytes in this domain.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NumberItemAttributesExceededException">
        /// Too many attributes in this item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/PutAttributes">REST API Reference for PutAttributes Operation</seealso>
        Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Select


        /// <summary>
        /// The <c>Select</c> operation returns a set of attributes for <c>ItemNames</c> that
        /// match the select expression. <c>Select</c> is similar to the standard SQL SELECT statement.
        /// 
        /// 
        ///  
        /// <para>
        ///  The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB
        /// automatically adjusts the number of items returned per page to enforce this limit.
        /// For example, if the client asks to retrieve 2500 items, but each individual item is
        /// 10 kB in size, the system returns 100 items and an appropriate <c>NextToken</c> so
        /// the client can access the next page of results. 
        /// </para>
        ///  
        /// <para>
        ///  For information on how to construct select expressions, see Using Select to Create
        /// Amazon SimpleDB Queries in the Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Select service method.</param>
        /// 
        /// <returns>The response from the Select service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNextTokenException">
        /// The specified NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNumberPredicatesException">
        /// Too many predicates exist in the query expression.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNumberValueTestsException">
        /// Too many predicates exist in the query expression.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidQueryExpressionException">
        /// The specified query expression syntax is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.RequestTimeoutException">
        /// A timeout occurred when attempting to query the specified domain with specified query
        /// expression.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.TooManyRequestedAttributesException">
        /// Too many attributes requested.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/Select">REST API Reference for Select Operation</seealso>
        SelectResponse Select(SelectRequest request);



        /// <summary>
        /// The <c>Select</c> operation returns a set of attributes for <c>ItemNames</c> that
        /// match the select expression. <c>Select</c> is similar to the standard SQL SELECT statement.
        /// 
        /// 
        ///  
        /// <para>
        ///  The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB
        /// automatically adjusts the number of items returned per page to enforce this limit.
        /// For example, if the client asks to retrieve 2500 items, but each individual item is
        /// 10 kB in size, the system returns 100 items and an appropriate <c>NextToken</c> so
        /// the client can access the next page of results. 
        /// </para>
        ///  
        /// <para>
        ///  For information on how to construct select expressions, see Using Select to Create
        /// Amazon SimpleDB Queries in the Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Select service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Select service method, as returned by SimpleDB.</returns>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNextTokenException">
        /// The specified NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNumberPredicatesException">
        /// Too many predicates exist in the query expression.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidNumberValueTestsException">
        /// Too many predicates exist in the query expression.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.InvalidQueryExpressionException">
        /// The specified query expression syntax is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.MissingParameterException">
        /// The request must contain the specified missing parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.RequestTimeoutException">
        /// A timeout occurred when attempting to query the specified domain with specified query
        /// expression.
        /// </exception>
        /// <exception cref="Amazon.SimpleDB.Model.TooManyRequestedAttributesException">
        /// Too many attributes requested.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sdb-2009-04-15/Select">REST API Reference for Select Operation</seealso>
        Task<SelectResponse> SelectAsync(SelectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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