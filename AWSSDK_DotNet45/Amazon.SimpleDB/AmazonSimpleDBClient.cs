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
using Amazon.SimpleDB.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleDB
{
    /// <summary>
    /// Implementation for accessing AmazonSimpleDB.
    /// 
    /// Amazon SimpleDB <para> Amazon SimpleDB is a web service providing the core database functions of data indexing and querying in the cloud. By
    /// offloading the time and effort associated with building and operating a web-scale database, SimpleDB provides developers the freedom to
    /// focus on application development. </para> <para> A traditional, clustered relational database requires a sizable upfront capital outlay, is
    /// complex to design, and often requires extensive and repetitive database administration. Amazon SimpleDB is dramatically simpler, requiring
    /// no schema, automatically indexing your data and providing a simple API for storage and access. This approach eliminates the administrative
    /// burden of data modeling, index maintenance, and performance tuning. Developers gain access to this functionality within Amazon's proven
    /// computing environment, are able to scale instantly, and pay only for what they use. </para> <para> Visit <a href="http://aws.amazon.com/simpledb/">http://aws.amazon.com/simpledb/</a> for more information. </para>
    /// </summary>
	public partial class AmazonSimpleDBClient : AmazonWebServiceClient, Amazon.SimpleDB.IAmazonSimpleDB
    {

        QueryStringSigner signer = new QueryStringSigner();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleDBClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSimpleDBClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleDBConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleDBConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSimpleDB Configuration Object</param>
        public AmazonSimpleDBClient(AmazonSimpleDBConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleDBConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Credentials and an
        /// AmazonSimpleDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleDBClient Configuration Object</param>
        public AmazonSimpleDBClient(AWSCredentials credentials, AmazonSimpleDBConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleDBConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDBClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleDBClient Configuration Object</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleDBConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDBClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleDBClient Configuration Object</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
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
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAttributes service method on
        /// AmazonSimpleDB.</param>
		public BatchDeleteAttributesResponse BatchDeleteAttributes(BatchDeleteAttributesRequest request)
        {
            var task = BatchDeleteAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteAttributes operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.BatchDeleteAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<BatchDeleteAttributesResponse> BatchDeleteAttributesAsync(BatchDeleteAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchDeleteAttributesRequestMarshaller();
            var unmarshaller = BatchDeleteAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, BatchDeleteAttributesRequest, BatchDeleteAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAttributes service method on
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
		public BatchPutAttributesResponse BatchPutAttributes(BatchPutAttributesRequest request)
        {
            var task = BatchPutAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutAttributes operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.BatchPutAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<BatchPutAttributesResponse> BatchPutAttributesAsync(BatchPutAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchPutAttributesRequestMarshaller();
            var unmarshaller = BatchPutAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, BatchPutAttributesRequest, BatchPutAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> The <c>CreateDomain</c> operation creates a new domain. The domain name should be unique among the domains associated with the Access
        /// Key ID provided in the request. The <c>CreateDomain</c> operation may take 10 or more seconds to complete. </para> <para><b>NOTE:</b>
        /// CreateDomain is an idempotent operation; running it multiple times using the same domain name will not result in an error response. </para>
        /// <para> The client can create up to 100 domains per account. </para> <para> If the client requires additional domains, go to <a href="http://aws.amazon.com/contact-us/simpledb-limit-request/"> http://aws.amazon.com/contact-us/simpledb-limit-request/</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainsExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
		public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var task = CreateDomainAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.CreateDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDomainRequest, CreateDomainResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes one or more attributes associated with an item. If all attributes of the item are deleted, the item is deleted. </para>
        /// <para><b>NOTE:</b> If DeleteAttributes is called without being passed any attributes or values specified, all the attributes for the item
        /// are deleted. </para> <para> <c>DeleteAttributes</c> is an idempotent operation; running it multiple times on the same item or attribute does
        /// not result in an error response. </para> <para> Because Amazon SimpleDB makes multiple copies of item data and uses an eventual consistency
        /// update model, performing a GetAttributes or Select operation (read) immediately after a <c>DeleteAttributes</c> or PutAttributes operation
        /// (write) might not return updated item data. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.AttributeDoesNotExistException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
		public DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request)
        {
            var task = DeleteAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttributes operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.DeleteAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteAttributesResponse> DeleteAttributesAsync(DeleteAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAttributesRequestMarshaller();
            var unmarshaller = DeleteAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteAttributesRequest, DeleteAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> The <c>DeleteDomain</c> operation deletes a domain. Any items (and their attributes) in the domain are deleted as well. The
        /// <c>DeleteDomain</c> operation might take 10 or more seconds to complete. </para> <para><b>NOTE:</b> Running DeleteDomain on a domain that
        /// does not exist or running the function multiple times using the same domain name will not result in an error response. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
		public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var task = DeleteDomainAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.DeleteDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteDomainRequest, DeleteDomainResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns information about the domain, including when the domain was created, the number of items and attributes in the domain, and
        /// the size of the attribute names and values. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DomainMetadata service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <returns>The response from the DomainMetadata service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
		public DomainMetadataResponse DomainMetadata(DomainMetadataRequest request)
        {
            var task = DomainMetadataAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DomainMetadata operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.DomainMetadata"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DomainMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DomainMetadataResponse> DomainMetadataAsync(DomainMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DomainMetadataRequestMarshaller();
            var unmarshaller = DomainMetadataResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DomainMetadataRequest, DomainMetadataResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns all of the attributes associated with the specified item. Optionally, the attributes returned can be limited to one or more
        /// attributes by specifying an attribute name parameter. </para> <para> If the item does not exist on the replica that was accessed for this
        /// operation, an empty set is returned. The system does not return an error as it cannot guarantee the item does not exist on other replicas.
        /// </para> <para><b>NOTE:</b> If GetAttributes is called without being passed any attribute names, all the attributes for the item are
        /// returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttributes service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <returns>The response from the GetAttributes service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
		public GetAttributesResponse GetAttributes(GetAttributesRequest request)
        {
            var task = GetAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetAttributes operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.GetAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetAttributesResponse> GetAttributesAsync(GetAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAttributesRequestMarshaller();
            var unmarshaller = GetAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetAttributesRequest, GetAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> The <c>ListDomains</c> operation lists all domains associated with the Access Key ID. It returns domain names up to the limit set by
        /// <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a> .
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c> domains. Calling
        /// <c>ListDomains</c> successive times with the <c>NextToken</c> provided by the operation returns up to <c>MaxNumberOfDomains</c> more domain
        /// names with each successive operation call. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method on AmazonSimpleDB.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidNextTokenException" />
		public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var task = ListDomainsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.ListDomains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListDomainsRequest, ListDomainsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> The <c>ListDomains</c> operation lists all domains associated with the Access Key ID. It returns domain names up to the limit set by
        /// <a href="#MaxNumberOfDomains">MaxNumberOfDomains</a> .
        /// A <a href="#NextToken">NextToken</a> is returned if there are more than <c>MaxNumberOfDomains</c> domains. Calling
        /// <c>ListDomains</c> successive times with the <c>NextToken</c> provided by the operation returns up to <c>MaxNumberOfDomains</c> more domain
        /// names with each successive operation call. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListDomains service method, as returned by AmazonSimpleDB.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidNextTokenException" />
		public ListDomainsResponse ListDomains()
        {
            return this.ListDomains(new ListDomainsRequest());
        }
 
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
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes service method on
        /// AmazonSimpleDB.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleDB.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainBytesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberDomainAttributesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NoSuchDomainException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.NumberItemAttributesExceededException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.AttributeDoesNotExistException" />
        /// <exception cref="T:Amazon.SimpleDB.Model.MissingParameterException" />
		public PutAttributesResponse PutAttributes(PutAttributesRequest request)
        {
            var task = PutAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PutAttributes operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.PutAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<PutAttributesResponse> PutAttributesAsync(PutAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutAttributesRequestMarshaller();
            var unmarshaller = PutAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PutAttributesRequest, PutAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> The <c>Select</c> operation returns a set of attributes for <c>ItemNames</c> that match the select expression. <c>Select</c> is
        /// similar to the standard SQL SELECT statement. </para> <para> The total size of the response cannot exceed 1 MB in total size. Amazon
        /// SimpleDB automatically adjusts the number of items returned per page to enforce this limit. For example, if the client asks to retrieve 2500
        /// items, but each individual item is 10 kB in size, the system returns 100 items and an appropriate <c>NextToken</c> so the client can access
        /// the next page of results. </para> <para> For information on how to construct select expressions, see Using Select to Create Amazon SimpleDB
        /// Queries in the Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Select service method on AmazonSimpleDB.</param>
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
		public SelectResponse Select(SelectRequest request)
        {
            var task = SelectAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the Select operation.
        /// <seealso cref="Amazon.SimpleDB.IAmazonSimpleDB.Select"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Select operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SelectResponse> SelectAsync(SelectRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SelectRequestMarshaller();
            var unmarshaller = SelectResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SelectRequest, SelectResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
