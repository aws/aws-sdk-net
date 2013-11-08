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
using System.Threading;
using System.Threading.Tasks;

using Amazon.SimpleDB.Model;

namespace Amazon.SimpleDB
{
    /// <summary>
    /// Interface for accessing AmazonSimpleDB.
    /// 
    /// Amazon SimpleDB <para> Amazon SimpleDB is a web service providing the core database functions of data indexing and querying in the cloud. By
    /// offloading the time and effort associated with building and operating a web-scale database, SimpleDB provides developers the freedom to
    /// focus on application development. </para> <para> A traditional, clustered relational database requires a sizable upfront capital outlay, is
    /// complex to design, and often requires extensive and repetitive database administration. Amazon SimpleDB is dramatically simpler, requiring
    /// no schema, automatically indexing your data and providing a simple API for storage and access. This approach eliminates the administrative
    /// burden of data modeling, index maintenance, and performance tuning. Developers gain access to this functionality within Amazon's proven
    /// computing environment, are able to scale instantly, and pay only for what they use. </para> <para> Visit <a href="http://aws.amazon.com/simpledb/">http://aws.amazon.com/simpledb/</a> for more information. </para>
    /// </summary>
	public partial interface IAmazonSimpleDB : IDisposable
    {
 
        /// <summary>
        /// <para> Performs multiple DeleteAttributes operations in a single call, which reduces round trips and latencies. This enables Amazon SimpleDB
        /// to optimize requests, which generally yields better throughput. </para> <para><b>NOTE:</b> If you specify BatchDeleteAttributes without
        /// attributes or values, all the attributes for the item are deleted. BatchDeleteAttributes is an idempotent operation; running it multiple
        /// times on the same item or attribute doesn't result in an error. The BatchDeleteAttributes operation succeeds or fails in its entirety. There
        /// are no partial deletes. You can execute multiple BatchDeleteAttributes operations and other operations in parallel. However, large numbers
        /// of concurrent BatchDeleteAttributes calls can result in Service Unavailable (503) responses. This operation is vulnerable to exceeding the
        /// maximum URL size when making a REST request using the HTTP GET method. This operation does not support conditions using Expected.X.Name,
        /// Expected.X.Value, or Expected.X.Exists. </para> <para> The following limitations are enforced for this operation:
        /// <ul>
        /// <li>1 MB request size</li>
        /// <li>25 item limit per BatchDeleteAttributes operation</li>
        /// 
        /// </ul>
        /// </para>
        /// </summary>
        /// 
        /// <param name="batchDeleteAttributesRequest">Container for the necessary parameters to execute the BatchDeleteAttributes service method on
        /// AmazonSimpleDB.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<BatchDeleteAttributesResponse> BatchDeleteAttributesAsync(BatchDeleteAttributesRequest batchDeleteAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The <c>BatchPutAttributes</c> operation creates or replaces attributes within one or more items. By using this operation, the client
        /// can perform multiple PutAttribute operation with a single call. This helps yield savings in round trips and latencies, enabling Amazon
        /// SimpleDB to optimize requests and generally produce better throughput. </para> <para> The client may specify the item name with the
        /// <c>Item.X.ItemName</c> parameter. The client may specify new attributes using a combination of the <c>Item.X.Attribute.Y.Name</c> and
        /// <c>Item.X.Attribute.Y.Value</c> parameters. The client may specify the first attribute for the first item using the parameters
        /// <c>Item.0.Attribute.0.Name</c> and <c>Item.0.Attribute.0.Value</c> ,
        /// and for the second attribute for the first item by the parameters <c>Item.0.Attribute.1.Name</c> and <c>Item.0.Attribute.1.Value</c> ,
        /// and so on. </para> <para> Attributes are uniquely identified within an item by their name/value combination. For example, a single item
        /// can have the attributes <c>{ "first_name", "first_value" }</c> and <c>{ "first_name", "second_value" }</c> .
        /// However, it cannot have two attribute instances where both the <c>Item.X.Attribute.Y.Name</c> and <c>Item.X.Attribute.Y.Value</c> are the
        /// same. </para> <para> Optionally, the requester can supply the <c>Replace</c> parameter for each individual value. Setting this value to
        /// <c>true</c> will cause the new attribute values to replace the existing attribute values. For example, if an item <c>I</c> has the
        /// attributes <c>{ 'a', '1' }, { 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requester does a BatchPutAttributes of <c>{'I', 'b', '4' }</c>
        /// with the Replace parameter set to true, the final attributes of the item will be <c>{ 'a', '1' }</c> and <c>{ 'b', '4' }</c> ,
        /// replacing the previous values of the 'b' attribute with the new value. </para> <para><b>NOTE:</b> You cannot specify an empty string as an
        /// item or as an attribute name. The BatchPutAttributes operation succeeds or fails in its entirety. There are no partial puts. </para>
        /// <para><b>IMPORTANT:</b> This operation is vulnerable to exceeding the maximum URL size when making a REST request using the HTTP GET method.
        /// This operation does not support conditions using Expected.X.Name, Expected.X.Value, or Expected.X.Exists. </para> <para> You can execute
        /// multiple <c>BatchPutAttributes</c> operations and other operations in parallel. However, large numbers of concurrent
        /// <c>BatchPutAttributes</c> calls can result in Service Unavailable (503) responses. </para> <para> The following limitations are enforced for
        /// this operation:
        /// <ul>
        /// <li>256 attribute name-value pairs per item</li>
        /// <li>1 MB request size</li>
        /// <li>1 billion attributes per domain</li>
        /// <li>10 GB of total user data storage per domain</li>
        /// <li>25 item limit per <c>BatchPutAttributes</c> operation</li>
        /// 
        /// </ul>
        /// </para>
        /// </summary>
        /// 
        /// <param name="batchPutAttributesRequest">Container for the necessary parameters to execute the BatchPutAttributes service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.DuplicateItemNameException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainBytesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberSubmittedItemsExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberSubmittedAttributesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainAttributesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberItemAttributesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<BatchPutAttributesResponse> BatchPutAttributesAsync(BatchPutAttributesRequest batchPutAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The <c>CreateDomain</c> operation creates a new domain. The domain name should be unique among the domains associated with the Access
        /// Key ID provided in the request. The <c>CreateDomain</c> operation may take 10 or more seconds to complete. </para> <para><b>NOTE:</b>
        /// CreateDomain is an idempotent operation; running it multiple times using the same domain name will not result in an error response. </para>
        /// <para> The client can create up to 100 domains per account. </para> <para> If the client requires additional domains, go to <a href="http://aws.amazon.com/contact-us/simpledb-limit-request/"> http://aws.amazon.com/contact-us/simpledb-limit-request/</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainsExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes one or more attributes associated with an item. If all attributes of the item are deleted, the item is deleted. </para>
        /// <para><b>NOTE:</b> If DeleteAttributes is called without being passed any attributes or values specified, all the attributes for the item
        /// are deleted. </para> <para> <c>DeleteAttributes</c> is an idempotent operation; running it multiple times on the same item or attribute does
        /// not result in an error response. </para> <para> Because Amazon SimpleDB makes multiple copies of item data and uses an eventual consistency
        /// update model, performing a GetAttributes or Select operation (read) immediately after a <c>DeleteAttributes</c> or PutAttributes operation
        /// (write) might not return updated item data. </para>
        /// </summary>
        /// 
        /// <param name="deleteAttributesRequest">Container for the necessary parameters to execute the DeleteAttributes service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.AttributeDoesNotExistException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest deleteAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The <c>DeleteDomain</c> operation deletes a domain. Any items (and their attributes) in the domain are deleted as well. The
        /// <c>DeleteDomain</c> operation might take 10 or more seconds to complete. </para> <para><b>NOTE:</b> Running DeleteDomain on a domain that
        /// does not exist or running the function multiple times using the same domain name will not result in an error response. </para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about the domain, including when the domain was created, the number of items and attributes in the domain, and
        /// the size of the attribute names and values. </para>
        /// </summary>
        /// 
        /// <param name="domainMetadataRequest">Container for the necessary parameters to execute the DomainMetadata service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <returns>The response from the DomainMetadata service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DomainMetadataResponse> DomainMetadataAsync(DomainMetadataRequest domainMetadataRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns all of the attributes associated with the specified item. Optionally, the attributes returned can be limited to one or more
        /// attributes by specifying an attribute name parameter. </para> <para> If the item does not exist on the replica that was accessed for this
        /// operation, an empty set is returned. The system does not return an error as it cannot guarantee the item does not exist on other replicas.
        /// </para> <para><b>NOTE:</b> If GetAttributes is called without being passed any attribute names, all the attributes for the item are
        /// returned. </para>
        /// </summary>
        /// 
        /// <param name="getAttributesRequest">Container for the necessary parameters to execute the GetAttributes service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <returns>The response from the GetAttributes service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetAttributesResponse> GetAttributesAsync(GetAttributesRequest getAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The <c>ListDomains</c> operation lists all domains associated with the Access Key ID. It returns domain names up to the limit set by
        /// <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a> .
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c> domains. Calling
        /// <c>ListDomains</c> successive times with the <c>NextToken</c> provided by the operation returns up to <c>MaxNumberOfDomains</c> more domain
        /// names with each successive operation call. </para>
        /// </summary>
        /// 
        /// <param name="listDomainsRequest">Container for the necessary parameters to execute the ListDomains service method on AmazonSimpleDB.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest listDomainsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The PutAttributes operation creates or replaces attributes in an item. The client may specify new attributes using a combination of
        /// the <c>Attribute.X.Name</c> and <c>Attribute.X.Value</c> parameters. The client specifies the first attribute by the parameters
        /// <c>Attribute.0.Name</c> and <c>Attribute.0.Value</c> ,
        /// the second attribute by the parameters <c>Attribute.1.Name</c> and <c>Attribute.1.Value</c> , and so on. </para> <para> Attributes are
        /// uniquely identified in an item by their name/value combination. For example, a single item can have the attributes <c>{ "first_name",
        /// "first_value" }</c> and <c>{ "first_name", second_value" }</c> . However, it cannot have two attribute instances where both the
        /// <c>Attribute.X.Name</c> and <c>Attribute.X.Value</c> are the same. </para> <para> Optionally, the requestor can supply the <c>Replace</c>
        /// parameter for each individual attribute. Setting this value to <c>true</c> causes the new attribute value to replace the existing attribute
        /// value(s). For example, if an item has the attributes <c>{ 'a', '1' }</c> ,
        /// 
        /// <c>{ 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requestor calls <c>PutAttributes</c> using the attributes <c>{ 'b',
        /// '4' }</c> with the <c>Replace</c> parameter set to true, the final attributes of the item are changed to <c>{ 'a', '1' }</c> and <c>{ 'b',
        /// '4' }</c> , which replaces the previous values of the 'b' attribute with the new value. </para> <para><b>NOTE:</b> Using PutAttributes to
        /// replace attribute values that do not exist will not result in an error response. </para> <para> You cannot specify an empty string as an
        /// attribute name. </para> <para> Because Amazon SimpleDB makes multiple copies of client data and uses an eventual consistency update model,
        /// an immediate GetAttributes or Select operation (read) immediately after a PutAttributes or DeleteAttributes operation (write) might not
        /// return the updated data. </para> <para> The following limitations are enforced for this operation:
        /// <ul>
        /// <li>256 total attribute name-value pairs per item</li>
        /// <li>One billion attributes per domain</li>
        /// <li>10 GB of total user data storage per domain</li>
        /// 
        /// </ul>
        /// </para>
        /// </summary>
        /// 
        /// <param name="putAttributesRequest">Container for the necessary parameters to execute the PutAttributes service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainBytesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainAttributesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberItemAttributesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.AttributeDoesNotExistException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest putAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The <c>Select</c> operation returns a set of attributes for <c>ItemNames</c> that match the select expression. <c>Select</c> is
        /// similar to the standard SQL SELECT statement. </para> <para> The total size of the response cannot exceed 1 MB in total size. Amazon
        /// SimpleDB automatically adjusts the number of items returned per page to enforce this limit. For example, if the client asks to retrieve 2500
        /// items, but each individual item is 10 kB in size, the system returns 100 items and an appropriate <c>NextToken</c> so the client can access
        /// the next page of results. </para> <para> For information on how to construct select expressions, see Using Select to Create Amazon SimpleDB
        /// Queries in the Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="selectRequest">Container for the necessary parameters to execute the Select service method on AmazonSimpleDB.</param>
        /// 
        /// <returns>The response from the Select service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidQueryExpressionException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.RequestTimeoutException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidNumberPredicatesException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidNextTokenException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.TooManyRequestedAttributesException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidNumberValueTestsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SelectResponse> SelectAsync(SelectRequest selectRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
