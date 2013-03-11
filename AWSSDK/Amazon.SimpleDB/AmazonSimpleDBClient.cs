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
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

using Amazon.Runtime.Internal.Util;
using Amazon.SimpleDB.Model;
using Amazon.SimpleDB.Util;
using Attribute = Amazon.SimpleDB.Model.Attribute;
using Amazon.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleDB
{
    public class AmazonSimpleDBClient : AmazonSimpleDB
    {
        static Logger LOGGER = Logger.GetLogger(typeof(AmazonSimpleDBClient));

        private bool ownCredentials;
        private AWSCredentials credentials;
        private AmazonSimpleDBConfig config;
        private bool disposed;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonSimpleDBClient
        /// </summary>
        /// <param name="fDisposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool fDisposing)
        {
            if (!this.disposed)
            {
                if (fDisposing && credentials != null)
                {
                    if (ownCredentials)
                    {
                        credentials.Dispose();
                    }
                    credentials = null;
                }
                if (fDisposing && LOGGER != null)
                {
                    LOGGER.Flush();
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~AmazonSimpleDBClient()
        {
            this.Dispose(false);
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
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleDBConfig(), true) { }

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
        /// <param name="region">The region to connect to.</param>
        public AmazonSimpleDBClient(RegionEndpoint region)
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleDBConfig() { RegionEndpoint = region }, true) { }

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
            : this(FallbackCredentialsFactory.GetCredentials(), config, true) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonSimpleDBConfig(), true) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonSimpleDBConfig() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs AmazonSimpleDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDB Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonSimpleDB Configuration Object</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleDBConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonSimpleDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleDB Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonSimpleDB Configuration Object</param>
        public AmazonSimpleDBClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonSimpleDBConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonSimpleDBClient with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonSimpleDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleDBConfig()) { }

        /// <summary>
        /// Constructs an AmazonSimpleDBClient with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSimpleDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleDBConfig(){ RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs an AmazonSimpleDBClient with AWSCredentials and an
        /// AmazonSimpleDBClient Configuration object
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        public AmazonSimpleDBClient(AWSCredentials credentials, AmazonSimpleDBConfig config)
            : this(credentials, config, false) { }

        // Constructs an AmazonSimpleDBClient with credentials, config and flag which
        // specifies if the credentials are owned by the client or not
        private AmazonSimpleDBClient(AWSCredentials credentials, AmazonSimpleDBConfig config, bool ownCredentials)
        {
            this.credentials = credentials;
            this.config = config;
            this.ownCredentials = ownCredentials;
        }
        #endregion


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
        public IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateDomain(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.CreateDomain"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a CreateDomainResponse from S3.</returns>
        public CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return endOperation<CreateDomainResponse>(asyncResult);
        }

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
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            IAsyncResult asyncResult = invokeCreateDomain(request, null, null, true);
            return EndCreateDomain(asyncResult);
        }

        IAsyncResult invokeCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertCreateDomain(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<CreateDomainResponse>(result);
            return result;
        }

        /**
         * Convert CreateDomainRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateDomain(CreateDomainRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateDomain";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }

            return parameters;
        }

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
        public IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            return invokeListDomains(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the ListDomains operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.ListDomains"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a ListDomainsResponse from S3.</returns>
        public ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return endOperation<ListDomainsResponse>(asyncResult);
        }

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
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            IAsyncResult asyncResult = invokeListDomains(request, null, null, true);
            return EndListDomains(asyncResult);
        }

        IAsyncResult invokeListDomains(ListDomainsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertListDomains(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<ListDomainsResponse>(result);
            return result;
        }

        /**
         * Convert ListDomainsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertListDomains(ListDomainsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ListDomains";
            if (request.IsSetMaxNumberOfDomains())
            {
                parameters["MaxNumberOfDomains"] = request.MaxNumberOfDomains.ToString();
            }
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }

            return parameters;
        }

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
        public IAsyncResult BeginDomainMetadata(DomainMetadataRequest request, AsyncCallback callback, object state)
        {
            return invokeDomainMetadata(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DomainMetadata operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DomainMetadata"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDomainMetadata.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a DomainMetadataResponse from S3.</returns>
        public DomainMetadataResponse EndDomainMetadata(IAsyncResult asyncResult)
        {
            return endOperation<DomainMetadataResponse>(asyncResult);
        }

        /// <summary>
        /// Domain Metadata
        /// </summary>
        /// <param name="request">Domain Metadata  request</param>
        /// <returns>Domain Metadata  Response from the service</returns>
        /// <remarks>
        /// The DomainMetadata operation returns some domain metadata values, such as the
        /// number of items, attribute names and attribute values along with their sizes.
        /// </remarks>
        public DomainMetadataResponse DomainMetadata(DomainMetadataRequest request)
        {
            IAsyncResult asyncResult = invokeDomainMetadata(request, null, null, true);
            return EndDomainMetadata(asyncResult);
        }

        IAsyncResult invokeDomainMetadata(DomainMetadataRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertDomainMetadata(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<DomainMetadataResponse>(result);
            return result;
        }

        /**
         * Convert DomainMetadataRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDomainMetadata(DomainMetadataRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DomainMetadata";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }

            return parameters;
        }

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
        public IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteDomain(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DeleteDomain"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a DeleteDomainResponse from S3.</returns>
        public DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDomainResponse>(asyncResult);
        }

        /// <summary>
        /// Delete Domain
        /// </summary>
        /// <param name="request">Delete Domain  request</param>
        /// <returns>Delete Domain  Response from the service</returns>
        /// <remarks>
        /// The DeleteDomain operation deletes a domain. Any items (and their attributes) in the domain
        /// are deleted as well. The DeleteDomain operation may take 10 or more seconds to complete.
        /// </remarks>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteDomain(request, null, null, true);
            return EndDeleteDomain(asyncResult);
        }

        IAsyncResult invokeDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertDeleteDomain(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<DeleteDomainResponse>(result);
            return result;
        }

        /**
         * Convert DeleteDomainRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteDomain(DeleteDomainRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteDomain";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }

            return parameters;
        }

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
        public IAsyncResult BeginPutAttributes(PutAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokePutAttributes(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.PutAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a PutAttributesResponse from S3.</returns>
        public PutAttributesResponse EndPutAttributes(IAsyncResult asyncResult)
        {
            return endOperation<PutAttributesResponse>(asyncResult);
        }

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
        public PutAttributesResponse PutAttributes(PutAttributesRequest request)
        {
            IAsyncResult asyncResult = invokePutAttributes(request, null, null, true);
            return EndPutAttributes(asyncResult);
        }

        IAsyncResult invokePutAttributes(PutAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertPutAttributes(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<PutAttributesResponse>(result);
            return result;
        }

        /**
         * Convert PutAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertPutAttributes(PutAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "PutAttributes";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }
            if (request.IsSetItemName())
            {
                parameters["ItemName"] = request.ItemName;
            }
            List<ReplaceableAttribute> putAttributesRequestAttributeList = request.Attribute;
            int putAttributesRequestAttributeListIndex = 1;
            foreach (ReplaceableAttribute putAttributesRequestAttribute in putAttributesRequestAttributeList)
            {
                if (putAttributesRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", putAttributesRequestAttributeListIndex, ".", "Name")] = putAttributesRequestAttribute.Name;
                }
                if (putAttributesRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", putAttributesRequestAttributeListIndex, ".", "Value")] = putAttributesRequestAttribute.Value;
                }
                if (putAttributesRequestAttribute.IsSetReplace())
                {
                    parameters[String.Concat("Attribute", ".", putAttributesRequestAttributeListIndex, ".", "Replace")] = putAttributesRequestAttribute.Replace.ToString().ToLower();
                }

                putAttributesRequestAttributeListIndex++;
            }
            if (request.IsSetExpected())
            {
                UpdateCondition putAttributesRequestExpected = request.Expected;
                if (putAttributesRequestExpected.IsSetName())
                {
                    parameters[String.Concat("Expected", ".", "Name")] = putAttributesRequestExpected.Name;
                }
                if (putAttributesRequestExpected.IsSetValue())
                {
                    parameters[String.Concat("Expected", ".", "Value")] = putAttributesRequestExpected.Value;
                }
                if (putAttributesRequestExpected.IsSetExists())
                {
                    parameters[String.Concat("Expected", ".", "Exists")] = putAttributesRequestExpected.Exists.ToString().ToLower();
                }
            }

            return parameters;
        }

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
        public IAsyncResult BeginBatchPutAttributes(BatchPutAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeBatchPutAttributes(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the BatchPutAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.BatchPutAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a BatchPutAttributesResponse from S3.</returns>
        public BatchPutAttributesResponse EndBatchPutAttributes(IAsyncResult asyncResult)
        {
            return endOperation<BatchPutAttributesResponse>(asyncResult);
        }

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
        public BatchPutAttributesResponse BatchPutAttributes(BatchPutAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeBatchPutAttributes(request, null, null, true);
            return EndBatchPutAttributes(asyncResult);
        }

        IAsyncResult invokeBatchPutAttributes(BatchPutAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertBatchPutAttributes(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<BatchPutAttributesResponse>(result);
            return result;
        }

        /**
         * Convert BatchPutAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertBatchPutAttributes(BatchPutAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "BatchPutAttributes";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }
            List<ReplaceableItem> batchPutAttributesRequestItemList = request.Item;
            int batchPutAttributesRequestItemListIndex = 1;
            foreach (ReplaceableItem batchPutAttributesRequestItem in batchPutAttributesRequestItemList)
            {
                if (batchPutAttributesRequestItem.IsSetItemName())
                {
                    parameters[String.Concat("Item", ".", batchPutAttributesRequestItemListIndex, ".", "ItemName")] = batchPutAttributesRequestItem.ItemName;
                }
                List<ReplaceableAttribute> itemAttributeList = batchPutAttributesRequestItem.Attribute;
                int itemAttributeListIndex = 1;
                foreach (ReplaceableAttribute itemAttribute in itemAttributeList)
                {
                    if (itemAttribute.IsSetName())
                    {
                        parameters[String.Concat("Item", ".", batchPutAttributesRequestItemListIndex, ".", "Attribute", ".", itemAttributeListIndex, ".", "Name")] = itemAttribute.Name;
                    }
                    if (itemAttribute.IsSetValue())
                    {
                        parameters[String.Concat("Item", ".", batchPutAttributesRequestItemListIndex, ".", "Attribute", ".", itemAttributeListIndex, ".", "Value")] = itemAttribute.Value;
                    }
                    if (itemAttribute.IsSetReplace())
                    {
                        parameters[String.Concat("Item", ".", batchPutAttributesRequestItemListIndex, ".", "Attribute", ".", itemAttributeListIndex, ".", "Replace")] = itemAttribute.Replace.ToString().ToLower();
                    }

                    itemAttributeListIndex++;
                }

                batchPutAttributesRequestItemListIndex++;
            }

            return parameters;
        }

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
        public IAsyncResult BeginGetAttributes(GetAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeGetAttributes(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.GetAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a GetAttributesResponse from S3.</returns>
        public GetAttributesResponse EndGetAttributes(IAsyncResult asyncResult)
        {
            return endOperation<GetAttributesResponse>(asyncResult);
        }

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
        public GetAttributesResponse GetAttributes(GetAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeGetAttributes(request, null, null, true);
            return EndGetAttributes(asyncResult);
        }

        IAsyncResult invokeGetAttributes(GetAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertGetAttributes(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<GetAttributesResponse>(result);
            return result;
        }

        /**
         * Convert GetAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetAttributes(GetAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "GetAttributes";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }
            if (request.IsSetItemName())
            {
                parameters["ItemName"] = request.ItemName;
            }
            List<string> getAttributesRequestAttributeNameList = request.AttributeName;
            int getAttributesRequestAttributeNameListIndex = 1;
            foreach (string getAttributesRequestAttributeName in getAttributesRequestAttributeNameList)
            {
                parameters[String.Concat("AttributeName", ".", getAttributesRequestAttributeNameListIndex)] = getAttributesRequestAttributeName;
                getAttributesRequestAttributeNameListIndex++;
            }
            if (request.IsSetConsistentRead())
            {
                parameters["ConsistentRead"] = request.ConsistentRead.ToString().ToLower();
            }

            return parameters;
        }


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
        public IAsyncResult BeginDeleteAttributes(DeleteAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteAttributes(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.DeleteAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a DeleteAttributesResponse from S3.</returns>
        public DeleteAttributesResponse EndDeleteAttributes(IAsyncResult asyncResult)
        {
            return endOperation<DeleteAttributesResponse>(asyncResult);
        }

        /// <summary>
        /// Delete Attributes
        /// </summary>
        /// <param name="request">Delete Attributes  request</param>
        /// <returns>Delete Attributes  Response from the service</returns>
        /// <remarks>
        /// Deletes one or more attributes associated with the item. If all attributes of an item are deleted, the item is
        /// deleted.
        /// </remarks>
        public DeleteAttributesResponse DeleteAttributes(DeleteAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteAttributes(request, null, null, true);
            return EndDeleteAttributes(asyncResult);
        }

        IAsyncResult invokeDeleteAttributes(DeleteAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertDeleteAttributes(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<DeleteAttributesResponse>(result);
            return result;
        }

        /**
         * Convert DeleteAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteAttributes(DeleteAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteAttributes";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }
            if (request.IsSetItemName())
            {
                parameters["ItemName"] = request.ItemName;
            }
            List<Attribute> deleteAttributesRequestAttributeList = request.Attribute;
            int deleteAttributesRequestAttributeListIndex = 1;
            foreach (Attribute deleteAttributesRequestAttribute in deleteAttributesRequestAttributeList)
            {
                if (deleteAttributesRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", deleteAttributesRequestAttributeListIndex, ".", "Name")] = deleteAttributesRequestAttribute.Name;
                }
                if (deleteAttributesRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", deleteAttributesRequestAttributeListIndex, ".", "Value")] = deleteAttributesRequestAttribute.Value;
                }
                if (deleteAttributesRequestAttribute.IsSetNameEncoding())
                {
                    parameters[String.Concat("Attribute", ".", deleteAttributesRequestAttributeListIndex, ".", "NameEncoding")] = deleteAttributesRequestAttribute.NameEncoding;
                }
                if (deleteAttributesRequestAttribute.IsSetValueEncoding())
                {
                    parameters[String.Concat("Attribute", ".", deleteAttributesRequestAttributeListIndex, ".", "ValueEncoding")] = deleteAttributesRequestAttribute.ValueEncoding;
                }

                deleteAttributesRequestAttributeListIndex++;
            }
            if (request.IsSetExpected())
            {
                UpdateCondition deleteAttributesRequestExpected = request.Expected;
                if (deleteAttributesRequestExpected.IsSetName())
                {
                    parameters[String.Concat("Expected", ".", "Name")] = deleteAttributesRequestExpected.Name;
                }
                if (deleteAttributesRequestExpected.IsSetValue())
                {
                    parameters[String.Concat("Expected", ".", "Value")] = deleteAttributesRequestExpected.Value;
                }
                if (deleteAttributesRequestExpected.IsSetExists())
                {
                    parameters[String.Concat("Expected", ".", "Exists")] = deleteAttributesRequestExpected.Exists.ToString().ToLower();
                }
            }

            return parameters;
        }

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
        public IAsyncResult BeginBatchDeleteAttributes(BatchDeleteAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeBatchDeleteAttributes(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the BatchDeleteAttributes operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.BatchDeleteAttributes"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteAttributes.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a BatchDeleteAttributesResponse from S3.</returns>
        public BatchDeleteAttributesResponse EndBatchDeleteAttributes(IAsyncResult asyncResult)
        {
            return endOperation<BatchDeleteAttributesResponse>(asyncResult);
        }

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
        public BatchDeleteAttributesResponse BatchDeleteAttributes(BatchDeleteAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeBatchDeleteAttributes(request, null, null, true);
            return EndBatchDeleteAttributes(asyncResult);
        }

        IAsyncResult invokeBatchDeleteAttributes(BatchDeleteAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertBatchDeleteAttributes(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<BatchDeleteAttributesResponse>(result);
            return result;
        }

        private static IDictionary<string, string> ConvertBatchDeleteAttributes(BatchDeleteAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "BatchDeleteAttributes";
            if (request.IsSetDomainName())
            {
                parameters["DomainName"] = request.DomainName;
            }
            List<DeleteableItem> batchDeleteAttributesRequestItemList = request.Item;
            int batchDeleteAttributesRequestItemListIndex = 1;
            foreach (DeleteableItem batchDeleteAttributesRequestItem in batchDeleteAttributesRequestItemList)
            {
                if (batchDeleteAttributesRequestItem.IsSetItemName())
                {
                    parameters[String.Concat("Item", ".", batchDeleteAttributesRequestItemListIndex, ".", "ItemName")] = batchDeleteAttributesRequestItem.ItemName;
                }
                List<Attribute> itemAttributeList = batchDeleteAttributesRequestItem.Attribute;
                int itemAttributeListIndex = 1;
                foreach (Attribute itemAttribute in itemAttributeList)
                {
                    if (itemAttribute.IsSetName())
                    {
                        parameters[String.Concat("Item", ".", batchDeleteAttributesRequestItemListIndex, ".", "Attribute", ".", itemAttributeListIndex, ".", "Name")] = itemAttribute.Name;
                    }
                    if (itemAttribute.IsSetValue())
                    {
                        parameters[String.Concat("Item", ".", batchDeleteAttributesRequestItemListIndex, ".", "Attribute", ".", itemAttributeListIndex, ".", "Value")] = itemAttribute.Value;
                    }

                    itemAttributeListIndex++;
                }

                batchDeleteAttributesRequestItemListIndex++;
            }

            return parameters;
        }

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
        public IAsyncResult BeginSelect(SelectRequest request, AsyncCallback callback, object state)
        {
            return invokeSelect(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Select operation.
        /// <seealso cref="M:Amazon.SimpleDB.AmazonSimpleDB.Select"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSelect.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.SimpleDB.AmazonSimpleDBException"></exception>
        /// <returns>Returns a SelectResponse from S3.</returns>
        public SelectResponse EndSelect(IAsyncResult asyncResult)
        {
            return endOperation<SelectResponse>(asyncResult);
        }

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
        public SelectResponse Select(SelectRequest request)
        {
            IAsyncResult asyncResult = invokeSelect(request, null, null, true);
            return EndSelect(asyncResult);
        }

        IAsyncResult invokeSelect(SelectRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IDictionary<string, string> parameters = ConvertSelect(request);
            SDBAsyncResult result = new SDBAsyncResult(parameters, callback, state, synchronized, request);
            invoke<SelectResponse>(result);
            return result;
        }

        /**
         * Convert SelectRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSelect(SelectRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "Select";
            if (request.IsSetSelectExpression())
            {
                parameters["SelectExpression"] = request.SelectExpression;
            }
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }
            if (request.IsSetConsistentRead())
            {
                parameters["ConsistentRead"] = request.ConsistentRead.ToString().ToLower();
            }

            return parameters;
        }

        #endregion



        #region Runtime

        void invoke<T>(SDBAsyncResult sdbAsyncResult) where T : new()
        {
            

            string actionName = sdbAsyncResult.Parameters["Action"];
            /* Add required request parameters */
            addRequiredParameters(sdbAsyncResult.Parameters);

            string queryString = AWSSDKUtils.GetParametersAsString(sdbAsyncResult.Parameters);

            byte[] requestData = Encoding.UTF8.GetBytes(queryString);
            IDictionary<string, string> headers = new Dictionary<string, string>();
            headers[AWSSDKUtils.UserAgentHeader] = config.UserAgent;
            ProcessRequestHandlers(sdbAsyncResult.RequestEvents, headers);

            HttpWebRequest request = configureWebRequest(requestData.Length, config, sdbAsyncResult.CompletedSynchronously, headers);

            
            sdbAsyncResult.RequestState = new RequestState(request, requestData);

            if (sdbAsyncResult.CompletedSynchronously)
            {
                this.getRequestStreamCallback<T>(sdbAsyncResult);
            }
            else
            {
                IAsyncResult httpResult = request.BeginGetRequestStream(new AsyncCallback(this.getRequestStreamCallback<T>), sdbAsyncResult);
                if (httpResult.CompletedSynchronously)
                {
                    if (!sdbAsyncResult.RequestState.GetRequestStreamCallbackCalled)
                    {
                        getRequestStreamCallback<T>(httpResult);
                    }
                    sdbAsyncResult.SetCompletedSynchronously(true);
                }
            }
        }

        protected virtual void ProcessRequestHandlers(IRequestEvents request, IDictionary<string, string> headers)
        {
            if (request == null) throw new ArgumentNullException("request");

            HeadersRequestEventArgs args = HeadersRequestEventArgs.Create(headers);

            request.FireBeforeRequestEvent(this, args);
        }

        void getRequestStreamCallback<T>(IAsyncResult result) where T : new()
        {
            SDBAsyncResult sdbAsyncResult;
            if (result is SDBAsyncResult)
                sdbAsyncResult = result as SDBAsyncResult;
            else
                sdbAsyncResult = result.AsyncState as SDBAsyncResult;

            sdbAsyncResult.RequestState.GetRequestStreamCallbackCalled = true;
            try
            {
                RequestState state = sdbAsyncResult.RequestState;

                Stream requestStream;
                if (sdbAsyncResult.CompletedSynchronously)
                    requestStream = state.WebRequest.GetRequestStream();
                else
                    requestStream = state.WebRequest.EndGetRequestStream(result);

                using (requestStream)
                {
                    requestStream.Write(sdbAsyncResult.RequestState.RequestData, 0, sdbAsyncResult.RequestState.RequestData.Length);
                }

                if (sdbAsyncResult.CompletedSynchronously)
                {
                    this.getResponseCallback<T>(sdbAsyncResult);
                }
                else
                {
                    IAsyncResult httpResult = state.WebRequest.BeginGetResponse(new AsyncCallback(this.getResponseCallback<T>), sdbAsyncResult);
                    if (httpResult.CompletedSynchronously)
                    {
                        if (!sdbAsyncResult.RequestState.GetResponseCallbackCalled)
                        {
                            getResponseCallback<T>(httpResult);
                        }
                        sdbAsyncResult.SetCompletedSynchronously(true);
                    }
                }
            }
            catch (Exception e)
            {
                sdbAsyncResult.RequestState.WebRequest.Abort();
                LOGGER.Error(e, "Error for GetRequestStream");
                sdbAsyncResult.Exception = e;

                sdbAsyncResult.SignalWaitHandle();
                if (sdbAsyncResult.Callback != null)
                    sdbAsyncResult.Callback(sdbAsyncResult);
            }
        }

        void getResponseCallback<T>(IAsyncResult result) where T : new()
        {
            SDBAsyncResult sdbAsyncResult;
            if (result is SDBAsyncResult)
                sdbAsyncResult = result as SDBAsyncResult;
            else
                sdbAsyncResult = result.AsyncState as SDBAsyncResult;

            sdbAsyncResult.RequestState.GetResponseCallbackCalled = true;
            bool shouldRetry = false;
            try
            {
                HttpStatusCode statusCode;
                RequestState state = sdbAsyncResult.RequestState;
                HttpWebResponse httpResponse = null;
                try
                {
                    if (sdbAsyncResult.CompletedSynchronously)
                        httpResponse = state.WebRequest.GetResponse() as HttpWebResponse;
                    else
                        httpResponse = state.WebRequest.EndGetResponse(result) as HttpWebResponse;

                    sdbAsyncResult.FinalSDBResponse = handleHttpResponse<T>(sdbAsyncResult, httpResponse, out statusCode);
                }
                catch (WebException we)
                {
                    shouldRetry = handleHttpWebErrorResponse(sdbAsyncResult, we, out statusCode);

                    if (shouldRetry)
                    {
                        sdbAsyncResult.RequestState.WebRequest.Abort();
                        sdbAsyncResult.RetriesAttempt++;
                        handleRetry(sdbAsyncResult, statusCode, we);
                        invoke<T>(sdbAsyncResult);
                    }
                }
            }
            catch (Exception e)
            {
                sdbAsyncResult.RequestState.WebRequest.Abort();
                LOGGER.Error(e, "Error for GetResponse");
                sdbAsyncResult.Exception = e;
                shouldRetry = false;
            }
            finally
            {
                if (!shouldRetry)
                {
                    sdbAsyncResult.SignalWaitHandle();
                    if (sdbAsyncResult.Callback != null)
                        sdbAsyncResult.Callback(sdbAsyncResult);
                }
            }
        }


        T handleHttpResponse<T>(SDBAsyncResult sdbAsyncResult, HttpWebResponse httpResponse, out HttpStatusCode statusCode)
        {
            string responseBody;
            using (httpResponse)
            {
                if (httpResponse == null)
                {
                    throw new WebException(
                        "The Web Response for a successful request is null!",
                        WebExceptionStatus.ProtocolError
                        );
                }
                statusCode = httpResponse.StatusCode;
                using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                {
                    responseBody = reader.ReadToEnd().Trim();
                }
            }

            /* Perform response transformation for GetAttributes and Select operations */
            if (sdbAsyncResult.ActionName.Equals("GetAttributes") ||
                sdbAsyncResult.ActionName.Equals("Select"))
            {
                if (responseBody.EndsWith(String.Concat(sdbAsyncResult.ActionName, "Response>")))
                {
                    responseBody = transform(responseBody, sdbAsyncResult.ActionName, this.GetType());
                }
            }

            T response;
            /* Attempt to deserialize response into <Action> Response type */
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
            {
                response = (T)serializer.Deserialize(sr);
            }

            return response;
        }

        bool handleHttpWebErrorResponse(SDBAsyncResult sdbAsyncResult, WebException we, out HttpStatusCode statusCode)
        {
            string responseBody;
            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (httpErrorResponse == null)
                {
                    // Abort the unsuccessful request
                    sdbAsyncResult.RequestState.WebRequest.Abort();
                    throw we;
                }
                statusCode = httpErrorResponse.StatusCode;
                using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                {
                    responseBody = reader.ReadToEnd();
                }

                // Abort the unsuccessful request
                sdbAsyncResult.RequestState.WebRequest.Abort();
            }

            bool shouldRetry = false;
            if (statusCode == HttpStatusCode.InternalServerError ||
                statusCode == HttpStatusCode.ServiceUnavailable)
            {
                shouldRetry = true;
                sdbAsyncResult.RetriesAttempt++;
                pauseOnRetry(sdbAsyncResult.RetriesAttempt, this.config.MaxErrorRetry, statusCode, we);
            }
            else
            {
                throw reportAnyErrors(responseBody, statusCode);
            }

            return shouldRetry;
        }


        void handleRetry(SDBAsyncResult sdbAsyncResult, HttpStatusCode statusCode, Exception cause)
        {
            int retries = sdbAsyncResult.RetriesAttempt;
            if (retries <= this.config.MaxErrorRetry)
            {
                LOGGER.InfoFormat("Retry number {0} for request {1}.", retries, sdbAsyncResult.ActionName);
            }
            pauseOnRetry(retries, this.config.MaxErrorRetry, statusCode, cause);
        }

        /**
          * Configure HttpClient with set of defaults as well as configuration
          * from AmazonSimpleDBConfig instance
          */
        private static HttpWebRequest configureWebRequest(int contentLength, AmazonSimpleDBConfig config, bool completedSynchronously, IDictionary<string, string> headers)
        {
            string url;
            if (config.RegionEndpoint != null)
                url = "https://" + config.RegionEndpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname;
            else
                url = config.ServiceURL;

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {
                request.ServicePoint.ConnectionLimit = config.ConnectionLimit;

                if (config.IsSetProxyHost() && config.IsSetProxyPort())
                {
                    WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    request.Proxy = proxy;
                }
                if (request.Proxy != null && config.IsSetProxyCredentials())
                {
                    request.Proxy.Credentials = config.ProxyCredentials;
                }
                request.UserAgent = headers[AWSSDKUtils.UserAgentHeader] + " " + (completedSynchronously ? "SDBSync" : "SDBAsync");
                request.Method = "POST";
                request.Timeout = 50000;
                request.ContentType = AWSSDKUtils.UrlEncodedContent;
                request.ContentLength = contentLength;
                request.ServicePoint.Expect100Continue = false;
                request.ServicePoint.UseNagleAlgorithm = false;
            }

            return request;
        }

        /**
          * Look for additional error strings in the response and return formatted exception
          */
        private static AmazonSimpleDBException reportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonSimpleDBException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(
                    responseBody,
                    "<RequestId>(.*)</RequestId>.*<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?",
                    RegexOptions.Multiline
                    );
                Match errorMatcherTwo = Regex.Match(
                    responseBody,
                    "<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>",
                    RegexOptions.Multiline
                    );
                Match errorMatcherThree = Regex.Match(
                    responseBody,
                    "<Error><Code>(.*)</Code><Message>(.*)</Message><BoxUsage>(.*)</BoxUsage></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>",
                    RegexOptions.Multiline);

                if (errorMatcherOne.Success)
                {
                    string requestId = errorMatcherOne.Groups[1].Value;
                    string code = errorMatcherOne.Groups[2].Value;
                    string message = errorMatcherOne.Groups[3].Value;

                    ex = new AmazonSimpleDBException(message, status, code, "Unknown", null, requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonSimpleDBException(message, status, code, "Unknown", null, requestId, responseBody);
                }
                else if (errorMatcherThree.Success)
                {
                    string code = errorMatcherThree.Groups[1].Value;
                    string message = errorMatcherThree.Groups[2].Value;
                    string boxUsage = errorMatcherThree.Groups[3].Value;
                    string requestId = errorMatcherThree.Groups[5].Value;

                    ex = new AmazonSimpleDBException(message, status, code, "Unknown", boxUsage, requestId, responseBody);
                }
                else
                {
                    ex = new AmazonSimpleDBException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonSimpleDBException("Internal Error", status);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void pauseOnRetry(int retries, int maxRetries, HttpStatusCode status, Exception cause)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonSimpleDBException(
                    "Maximum number of retry attempts reached : " + (retries - 1),
                    status,
                    cause
                    );
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void addRequiredParameters(IDictionary<string, string> parameters)
        {
            using (ImmutableCredentials immutableCredentials = this.credentials.GetCredentials())
            {
                if (String.IsNullOrEmpty(immutableCredentials.AccessKey))
                {
                    throw new AmazonSimpleDBException("The AWS Access Key ID cannot be NULL or a Zero length string");
                }

                if (parameters.ContainsKey("Signature"))
                {
                    parameters.Remove("Signature");
                }

                if (immutableCredentials.UseToken)
                {
                    parameters["SecurityToken"] = immutableCredentials.Token;
                }
                parameters["AWSAccessKeyId"] = immutableCredentials.AccessKey;
                parameters["SignatureVersion"] = config.SignatureVersion;
                parameters["SignatureMethod"] = config.SignatureMethod;
                parameters["Timestamp"] = AmazonSimpleDBUtil.FormattedCurrentTimestamp;
                parameters["Version"] = config.ServiceVersion;
                if (!config.SignatureVersion.Equals("2"))
                {
                    throw new AmazonSimpleDBException("Invalid Signature Version specified");
                }

                string url;
                if (config.RegionEndpoint != null)
                    url = "https://" + config.RegionEndpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname;
                else
                    url = config.ServiceURL;
                string toSign = AWSSDKUtils.CalculateStringToSignV2(parameters, url);

                KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(config.SignatureMethod.ToUpper());
                string auth;

                if (immutableCredentials.UseSecureStringForSecretKey)
                {
                    auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.SecureSecretKey, algorithm);
                }
                else
                {
                    auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.ClearSecretKey, algorithm);
                }
                parameters["Signature"] = auth;
            }
        }

        /*
         *  Transforms response based on xslt template
         */
        private static string transform(string responseBody, string action, Type t)
        {
            // Build the name of the xslt transform to apply to the response
            char[] seps = { ',' };

            Assembly assembly = Assembly.GetAssembly(t);
            string assemblyName = assembly.FullName;
            assemblyName = assemblyName.Split(seps)[0];

            string ns = t.Namespace;
            string resourceName = String.Concat(
                assemblyName,
                ".",
                ns,
                ".Model.",
                "ResponseTransformer.xslt"
                );

            XslCompiledTransform transformer = AWSSDKUtils.GetXslCompiledTransform(resourceName);
            StringBuilder sb = new StringBuilder(1024);
            using (XmlTextReader xmlR = new XmlTextReader(new StringReader(responseBody)))
            {
                using (StringWriter sw = new StringWriter(sb))
                {
                    transformer.Transform(xmlR, null, sw);
                    return sb.ToString();
                }
            }
        }

        T endOperation<T>(IAsyncResult result) where T : class
        {
            SDBAsyncResult sdbAsyncResult = result as SDBAsyncResult;
            if (sdbAsyncResult == null)
                return default(T);


            if (!sdbAsyncResult.IsCompleted)
            {
                sdbAsyncResult.AsyncWaitHandle.WaitOne();
            }

            if (sdbAsyncResult.Exception != null)
            {
                AWSSDKUtils.PreserveStackTrace(sdbAsyncResult.Exception);
                throw sdbAsyncResult.Exception;
            }

            return sdbAsyncResult.FinalSDBResponse as T;
        }

        #region Async Classes
        class SDBAsyncResult : IAsyncResult
        {
            bool _isComplete;
            bool _completedSynchronously;
            ManualResetEvent _waitHandle;
            IDictionary<string, string> _parameters;
            AsyncCallback _callback;
            RequestState _requestState;
            object _state;
            int _retiresAttempt;
            Exception _exception;
            object _finalSDBResponse;
            object _lockObj;
            IRequestEvents _requestEvents;


            internal SDBAsyncResult(IDictionary<string, string> parameters, AsyncCallback callback, object state, bool completeSynchronized, IRequestEvents requestEvents)
            {
                this._parameters = parameters;
                this._callback = callback;
                this._state = state;
                this._completedSynchronously = completeSynchronized;
                this._requestEvents = requestEvents;

                this._lockObj = new object();
            }


            internal string ActionName
            {
                get { return this._parameters["Action"]; }
            }

            internal IRequestEvents RequestEvents
            {
                get { return this._requestEvents; }
            }

            internal IDictionary<string, string> Parameters
            {
                get { return this._parameters; }
                set { this._parameters = value; }
            }

            internal Exception Exception
            {
                get { return this._exception; }
                set { this._exception = value; }
            }

            internal int RetriesAttempt
            {
                get { return this._retiresAttempt; }
                set { this._retiresAttempt = value; }
            }

            internal AsyncCallback Callback
            {
                get { return this._callback; }
            }

            internal void SignalWaitHandle()
            {
                this._isComplete = true;
                if (this._waitHandle != null)
                {
                    this._waitHandle.Set();
                }
            }

            internal object State
            {
                get { return this._state; }
            }

            public bool CompletedSynchronously
            {
                get { return this._completedSynchronously; }
            }

            internal void SetCompletedSynchronously(bool completedSynchronously)
            {
                this._completedSynchronously = completedSynchronously;
            }

            public bool IsCompleted
            {
                get { return this._isComplete; }
            }

            public object AsyncState
            {
                get { return this._state; }
            }

            public WaitHandle AsyncWaitHandle
            {
                get
                {
                    if (this._waitHandle != null)
                    {
                        return this._waitHandle;
                    }

                    lock (this._lockObj)
                    {
                        if (this._waitHandle == null)
                        {
                            this._waitHandle = new ManualResetEvent(this._isComplete);
                        }
                    }

                    return this._waitHandle;
                }
            }

            internal RequestState RequestState
            {
                get { return this._requestState; }
                set { this._requestState = value; }
            }


            internal object FinalSDBResponse
            {
                get { return this._finalSDBResponse; }
                set { this._finalSDBResponse = value; }
            }
        }


        class RequestState
        {
            HttpWebRequest _webRequest;
            byte[] _requestData;
            bool _getRequestStreamCallbackCalled;
            bool _getResponseCallbackCalled;

            public RequestState(HttpWebRequest webRequest, byte[] requestData)
            {
                this._webRequest = webRequest;
                this._requestData = requestData;
            }

            internal HttpWebRequest WebRequest
            {
                get { return this._webRequest; }
            }

            internal byte[] RequestData
            {
                get { return this._requestData; }
            }


            internal bool GetRequestStreamCallbackCalled
            {
                get { return this._getRequestStreamCallbackCalled; }
                set { this._getRequestStreamCallbackCalled = value; }
            }

            internal bool GetResponseCallbackCalled
            {
                get { return this._getResponseCallbackCalled; }
                set { this._getResponseCallbackCalled = value; }
            }
        }
        #endregion

        #endregion
    }
}
