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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Redshift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift
{
    /// <summary>
    /// Implementation for accessing Redshift
    ///
    /// Amazon Redshift 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is an interface reference for Amazon Redshift. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Redshift
    /// clusters. Note that Amazon Redshift is asynchronous, which means that some interfaces
    /// may require techniques, such as polling or asynchronous callback handlers, to determine
    /// when a command has been applied. In this reference, the parameter descriptions indicate
    /// whether a change is applied immediately, on the next instance reboot, or during the
    /// next maintenance window. For a summary of the Amazon Redshift cluster management interfaces,
    /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon Redshift manages all the work of setting up, operating, and scaling a data
    /// warehouse: provisioning capacity, monitoring and backing up the cluster, and applying
    /// patches and upgrades to the Amazon Redshift engine. You can focus on using your data
    /// to acquire new insights for your business and customers.
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the <a href="https://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// If you are a database developer, the <a href="https://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a> explains how to design, build, query, and maintain
    /// the databases that make up your data warehouse. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftClient : AmazonServiceClient, IAmazonRedshift
    {
        private static IServiceMetadata serviceMetadata = new AmazonRedshiftMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IRedshiftPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRedshiftPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RedshiftPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRedshiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AmazonRedshiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials and an
        /// AmazonRedshiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRedshiftEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AcceptReservedNodeExchange

        /// <summary>
        /// Exchanges a DC1 Reserved Node for a DC2 Reserved Node with no changes to the configuration
        /// (term, payment type, or number of nodes) and no additional costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedNodeExchange service method.</param>
        /// 
        /// <returns>The response from the AcceptReservedNodeExchange service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        public virtual AcceptReservedNodeExchangeResponse AcceptReservedNodeExchange(AcceptReservedNodeExchangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedNodeExchangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedNodeExchangeResponseUnmarshaller.Instance;

            return Invoke<AcceptReservedNodeExchangeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptReservedNodeExchange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedNodeExchange operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptReservedNodeExchange
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        public virtual IAsyncResult BeginAcceptReservedNodeExchange(AcceptReservedNodeExchangeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedNodeExchangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedNodeExchangeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptReservedNodeExchange operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptReservedNodeExchange.</param>
        /// 
        /// <returns>Returns a  AcceptReservedNodeExchangeResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        public virtual AcceptReservedNodeExchangeResponse EndAcceptReservedNodeExchange(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptReservedNodeExchangeResponse>(asyncResult);
        }

        #endregion
        
        #region  AddPartner

        /// <summary>
        /// Adds a partner integration to a cluster. This operation authorizes a partner to push
        /// status updates for the specified database. To complete the integration, you also set
        /// up the integration on the partner website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPartner service method.</param>
        /// 
        /// <returns>The response from the AddPartner service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.PartnerNotFoundException">
        /// The name of the partner was not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AddPartner">REST API Reference for AddPartner Operation</seealso>
        public virtual AddPartnerResponse AddPartner(AddPartnerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPartnerResponseUnmarshaller.Instance;

            return Invoke<AddPartnerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddPartner operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPartner operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPartner
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AddPartner">REST API Reference for AddPartner Operation</seealso>
        public virtual IAsyncResult BeginAddPartner(AddPartnerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPartnerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddPartner operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPartner.</param>
        /// 
        /// <returns>Returns a  AddPartnerResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AddPartner">REST API Reference for AddPartner Operation</seealso>
        public virtual AddPartnerResponse EndAddPartner(IAsyncResult asyncResult)
        {
            return EndInvoke<AddPartnerResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateDataShareConsumer

        /// <summary>
        /// From a datashare consumer account, associates a datashare with the account (AssociateEntireAccount)
        /// or the specified namespace (ConsumerArn). If you make this association, the consumer
        /// can consume the datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataShareConsumer service method.</param>
        /// 
        /// <returns>The response from the AssociateDataShareConsumer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AssociateDataShareConsumer">REST API Reference for AssociateDataShareConsumer Operation</seealso>
        public virtual AssociateDataShareConsumerResponse AssociateDataShareConsumer(AssociateDataShareConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataShareConsumerResponseUnmarshaller.Instance;

            return Invoke<AssociateDataShareConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDataShareConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataShareConsumer operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDataShareConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AssociateDataShareConsumer">REST API Reference for AssociateDataShareConsumer Operation</seealso>
        public virtual IAsyncResult BeginAssociateDataShareConsumer(AssociateDataShareConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataShareConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDataShareConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDataShareConsumer.</param>
        /// 
        /// <returns>Returns a  AssociateDataShareConsumerResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AssociateDataShareConsumer">REST API Reference for AssociateDataShareConsumer Operation</seealso>
        public virtual AssociateDataShareConsumerResponse EndAssociateDataShareConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDataShareConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeClusterSecurityGroupIngress

        /// <summary>
        /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on
        /// whether the application accessing your cluster is running on the Internet or an Amazon
        /// EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing
        /// (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security group. You can add
        /// as many as 20 ingress rules to an Amazon Redshift security group.
        /// 
        ///  
        /// <para>
        /// If you authorize access to an Amazon EC2 security group, specify <i>EC2SecurityGroupName</i>
        /// and <i>EC2SecurityGroupOwnerId</i>. The Amazon EC2 security group and Amazon Redshift
        /// cluster must be in the same Amazon Web Services Region. 
        /// </para>
        ///  
        /// <para>
        /// If you authorize access to a CIDR/IP address range, specify <i>CIDRIP</i>. For an
        /// overview of CIDR blocks, see the Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must also associate the security group with a cluster so that clients running
        /// on these IP addresses or the EC2 instance are authorized to connect to the cluster.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
        /// with Security Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        public virtual AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeClusterSecurityGroupIngressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeClusterSecurityGroupIngress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        public virtual IAsyncResult BeginAuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeClusterSecurityGroupIngressResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        public virtual AuthorizeClusterSecurityGroupIngressResponse EndAuthorizeClusterSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeClusterSecurityGroupIngressResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeDataShare

        /// <summary>
        /// From a data producer account, authorizes the sharing of a datashare with one or more
        /// consumer accounts or managing entities. To authorize a datashare for a data consumer,
        /// the producer account must have the correct access permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDataShare service method.</param>
        /// 
        /// <returns>The response from the AuthorizeDataShare service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeDataShare">REST API Reference for AuthorizeDataShare Operation</seealso>
        public virtual AuthorizeDataShareResponse AuthorizeDataShare(AuthorizeDataShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDataShareResponseUnmarshaller.Instance;

            return Invoke<AuthorizeDataShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDataShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDataShare operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeDataShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeDataShare">REST API Reference for AuthorizeDataShare Operation</seealso>
        public virtual IAsyncResult BeginAuthorizeDataShare(AuthorizeDataShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDataShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeDataShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeDataShare.</param>
        /// 
        /// <returns>Returns a  AuthorizeDataShareResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeDataShare">REST API Reference for AuthorizeDataShare Operation</seealso>
        public virtual AuthorizeDataShareResponse EndAuthorizeDataShare(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeDataShareResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeEndpointAccess

        /// <summary>
        /// Grants access to a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAuthorizationAlreadyExistsException">
        /// The authorization already exists for this endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAuthorizationsPerClusterLimitExceededException">
        /// The number of endpoint authorizations per cluster has exceeded its limit.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthorizationStateException">
        /// The status of the authorization is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeEndpointAccess">REST API Reference for AuthorizeEndpointAccess Operation</seealso>
        public virtual AuthorizeEndpointAccessResponse AuthorizeEndpointAccess(AuthorizeEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeEndpointAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeEndpointAccess">REST API Reference for AuthorizeEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginAuthorizeEndpointAccess(AuthorizeEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeEndpointAccess.</param>
        /// 
        /// <returns>Returns a  AuthorizeEndpointAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeEndpointAccess">REST API Reference for AuthorizeEndpointAccess Operation</seealso>
        public virtual AuthorizeEndpointAccessResponse EndAuthorizeEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeSnapshotAccess

        /// <summary>
        /// Authorizes the specified Amazon Web Services account to restore the specified snapshot.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        public virtual AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSnapshotAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeSnapshotAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        public virtual IAsyncResult BeginAuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a  AuthorizeSnapshotAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        public virtual AuthorizeSnapshotAccessResponse EndAuthorizeSnapshotAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeSnapshotAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteClusterSnapshots

        /// <summary>
        /// Deletes a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchDeleteRequestSizeExceededException">
        /// The maximum number for a batch delete of snapshots has been reached. The limit is
        /// 100.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        public virtual BatchDeleteClusterSnapshotsResponse BatchDeleteClusterSnapshots(BatchDeleteClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteClusterSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterSnapshots operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteClusterSnapshots(BatchDeleteClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  BatchDeleteClusterSnapshotsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        public virtual BatchDeleteClusterSnapshotsResponse EndBatchDeleteClusterSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteClusterSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchModifyClusterSnapshots

        /// <summary>
        /// Modifies the settings for a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchModifyClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the BatchModifyClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchModifyClusterSnapshotsLimitExceededException">
        /// The maximum number for snapshot identifiers has been reached. The limit is 100.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        public virtual BatchModifyClusterSnapshotsResponse BatchModifyClusterSnapshots(BatchModifyClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchModifyClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<BatchModifyClusterSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchModifyClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchModifyClusterSnapshots operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchModifyClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        public virtual IAsyncResult BeginBatchModifyClusterSnapshots(BatchModifyClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchModifyClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchModifyClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchModifyClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  BatchModifyClusterSnapshotsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        public virtual BatchModifyClusterSnapshotsResponse EndBatchModifyClusterSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchModifyClusterSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelResize

        /// <summary>
        /// Cancels a resize operation for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelResize service method.</param>
        /// 
        /// <returns>The response from the CancelResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        public virtual CancelResizeResponse CancelResize(CancelResizeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResizeResponseUnmarshaller.Instance;

            return Invoke<CancelResizeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelResize operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelResize
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        public virtual IAsyncResult BeginCancelResize(CancelResizeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResizeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelResize operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelResize.</param>
        /// 
        /// <returns>Returns a  CancelResizeResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        public virtual CancelResizeResponse EndCancelResize(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelResizeResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyClusterSnapshot

        /// <summary>
        /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
        /// The source must be an automated snapshot and it must be in the available state.
        /// 
        ///  
        /// <para>
        /// When you delete a cluster, Amazon Redshift deletes any automated snapshots of the
        /// cluster. Also, when the retention period of the snapshot expires, Amazon Redshift
        /// automatically deletes it. If you want to keep an automated snapshot for a longer period,
        /// you can make a manual copy of the snapshot. Manual snapshots are retained until you
        /// delete them.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCopyClusterSnapshot(CopyClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CopyClusterSnapshotResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual CopyClusterSnapshotResponse EndCopyClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAuthenticationProfile

        /// <summary>
        /// Creates an authentication profile with the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthenticationProfile service method.</param>
        /// 
        /// <returns>The response from the CreateAuthenticationProfile service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileAlreadyExistsException">
        /// The authentication profile already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileQuotaExceededException">
        /// The size or number of authentication profiles has exceeded the quota. The maximum
        /// length of the JSON string and maximum number of authentication profiles is determined
        /// by a quota for your account.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateAuthenticationProfile">REST API Reference for CreateAuthenticationProfile Operation</seealso>
        public virtual CreateAuthenticationProfileResponse CreateAuthenticationProfile(CreateAuthenticationProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthenticationProfileResponseUnmarshaller.Instance;

            return Invoke<CreateAuthenticationProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthenticationProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthenticationProfile operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAuthenticationProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateAuthenticationProfile">REST API Reference for CreateAuthenticationProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateAuthenticationProfile(CreateAuthenticationProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthenticationProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthenticationProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthenticationProfile.</param>
        /// 
        /// <returns>Returns a  CreateAuthenticationProfileResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateAuthenticationProfile">REST API Reference for CreateAuthenticationProfile Operation</seealso>
        public virtual CreateAuthenticationProfileResponse EndCreateAuthenticationProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAuthenticationProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCluster

        /// <summary>
        /// Creates a new cluster with the specified parameters.
        /// 
        ///  
        /// <para>
        /// To create a cluster in Virtual Private Cloud (VPC), you must provide a cluster subnet
        /// group name. The cluster subnet group identifies the subnets of your VPC that Amazon
        /// Redshift uses when creating the cluster. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateClusterParameterGroup

        /// <summary>
        /// Creates an Amazon Redshift parameter group.
        /// 
        ///  
        /// <para>
        /// Creating parameter groups is independent of creating clusters. You can associate a
        /// cluster with a parameter group when you create the cluster. You can also associate
        /// an existing cluster with a parameter group after the cluster is created by using <a>ModifyCluster</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Parameters in the parameter group define specific behavior that applies to the databases
        /// you create on the cluster. For more information about parameters and parameter groups,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException">
        /// A cluster parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster parameter
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        public virtual CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateClusterParameterGroup(CreateClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterParameterGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        public virtual CreateClusterParameterGroupResponse EndCreateClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateClusterSecurityGroup

        /// <summary>
        /// Creates a new Amazon Redshift security group. You use security groups to control access
        /// to non-VPC clusters.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException">
        /// A cluster security group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster security
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        public virtual CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterSecurityGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        public virtual CreateClusterSecurityGroupResponse EndCreateClusterSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateClusterSnapshot

        /// <summary>
        /// Creates a manual snapshot of the specified cluster. The cluster must be in the <code>available</code>
        /// state. 
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateClusterSnapshot(CreateClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateClusterSnapshotResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual CreateClusterSnapshotResponse EndCreateClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateClusterSubnetGroup

        /// <summary>
        /// Creates a new Amazon Redshift subnet group. You must provide a list of one or more
        /// subnets in your existing Amazon Virtual Private Cloud (Amazon VPC) when creating Amazon
        /// Redshift subnet group.
        /// 
        ///  
        /// <para>
        ///  For information about subnet groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
        /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException">
        /// A <i>ClusterSubnetGroupName</i> is already used by an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException">
        /// The request would result in user exceeding the allowed number of cluster subnet groups.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        public virtual CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterSubnetGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        public virtual CreateClusterSubnetGroupResponse EndCreateClusterSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpointAccess

        /// <summary>
        /// Creates a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToClusterDeniedException">
        /// You are not authorized to access the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAlreadyExistsException">
        /// The account already has a Redshift-managed VPC endpoint with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointsPerAuthorizationLimitExceededException">
        /// The number of Redshift-managed VPC endpoints per authorization has exceeded its limit.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointsPerClusterLimitExceededException">
        /// The number of Redshift-managed VPC endpoints per cluster has exceeded its limit.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual CreateEndpointAccessResponse CreateEndpointAccess(CreateEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginCreateEndpointAccess(CreateEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointAccess.</param>
        /// 
        /// <returns>Returns a  CreateEndpointAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual CreateEndpointAccessResponse EndCreateEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventSubscription

        /// <summary>
        /// Creates an Amazon Redshift event notification subscription. This action requires an
        /// ARN (Amazon Resource Name) of an Amazon SNS topic created by either the Amazon Redshift
        /// console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon
        /// SNS, you must create a topic in Amazon SNS and subscribe to the topic. The ARN is
        /// displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the source type, and lists of Amazon Redshift source IDs, event categories,
        /// and event severities. Notifications will be sent for all events you want that match
        /// those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1
        /// and mycluster2, event categories = Availability, Backup, and severity = ERROR. The
        /// subscription will only send notifications for those ERROR events in the Availability
        /// and Backup categories for the specified clusters.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the source type and source IDs, such as source type = cluster
        /// and source identifier = my-cluster-1, notifications will be sent for all the cluster
        /// events for my-cluster-1. If you specify a source type but do not specify a source
        /// identifier, you will receive notice of the events for the objects of that type in
        /// your Amazon Web Services account. If you do not specify either the SourceType nor
        /// the SourceIdentifier, you will be notified of events generated from all Amazon Redshift
        /// sources belonging to your Amazon Web Services account. You must specify a source type
        /// if you specify a source ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.EventSubscriptionQuotaExceededException">
        /// The request would exceed the allowed number of event subscriptions for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionAlreadyExistException">
        /// There is already an existing event notification subscription with the specified name.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a  CreateEventSubscriptionResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHsmClientCertificate

        /// <summary>
        /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
        /// to the client's HSM in order to store and retrieve the keys used to encrypt the cluster
        /// databases.
        /// 
        ///  
        /// <para>
        /// The command returns a public key, which you must store in the HSM. In addition to
        /// creating the HSM certificate, you must create an Amazon Redshift HSM configuration
        /// that provides a cluster the information needed to store and use encryption keys in
        /// the HSM. For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html#working-with-HSM">Hardware
        /// Security Modules</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM client certificate with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateQuotaExceededException">
        /// The quota for HSM client certificates has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        public virtual CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateHsmClientCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsmClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        public virtual IAsyncResult BeginCreateHsmClientCertificate(CreateHsmClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmClientCertificate.</param>
        /// 
        /// <returns>Returns a  CreateHsmClientCertificateResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        public virtual CreateHsmClientCertificateResponse EndCreateHsmClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHsmClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHsmConfiguration

        /// <summary>
        /// Creates an HSM configuration that contains the information required by an Amazon Redshift
        /// cluster to store and use database encryption keys in a Hardware Security Module (HSM).
        /// After creating the HSM configuration, you can specify it as a parameter when creating
        /// a cluster. The cluster will then store its encryption keys in the HSM.
        /// 
        ///  
        /// <para>
        /// In addition to creating an HSM configuration, you must also create an HSM client certificate.
        /// For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM configuration with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationQuotaExceededException">
        /// The quota for HSM configurations has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        public virtual CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateHsmConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsmConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateHsmConfiguration(CreateHsmConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateHsmConfigurationResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        public virtual CreateHsmConfigurationResponse EndCreateHsmConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHsmConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateScheduledAction

        /// <summary>
        /// Creates a scheduled action. A scheduled action contains a schedule and an Amazon Redshift
        /// API action. For example, you can create a schedule of when to run the <code>ResizeCluster</code>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionAlreadyExistsException">
        /// The scheduled action already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionQuotaExceededException">
        /// The quota for scheduled actions exceeded.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual CreateScheduledActionResponse CreateScheduledAction(CreateScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return Invoke<CreateScheduledActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginCreateScheduledAction(CreateScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScheduledAction.</param>
        /// 
        /// <returns>Returns a  CreateScheduledActionResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        public virtual CreateScheduledActionResponse EndCreateScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshotCopyGrant

        /// <summary>
        /// Creates a snapshot copy grant that permits Amazon Redshift to use an encrypted symmetric
        /// key from Key Management Service (KMS) to encrypt copied snapshots in a destination
        /// region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantAlreadyExistsException">
        /// The snapshot copy grant can't be created because a grant with the same name already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantQuotaExceededException">
        /// The Amazon Web Services account has exceeded the maximum number of snapshot copy grants
        /// in this region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        public virtual CreateSnapshotCopyGrantResponse CreateSnapshotCopyGrant(CreateSnapshotCopyGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotCopyGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshotCopyGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        public virtual IAsyncResult BeginCreateSnapshotCopyGrant(CreateSnapshotCopyGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshotCopyGrant.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotCopyGrantResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        public virtual CreateSnapshotCopyGrantResponse EndCreateSnapshotCopyGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotCopyGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshotSchedule

        /// <summary>
        /// Create a snapshot schedule that can be associated to a cluster and which overrides
        /// the default system backup schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduleDefinitionTypeUnsupportedException">
        /// The definition you submitted is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleAlreadyExistsException">
        /// The specified snapshot schedule already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleQuotaExceededException">
        /// You have exceeded the quota of snapshot schedules.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        public virtual CreateSnapshotScheduleResponse CreateSnapshotSchedule(CreateSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotSchedule operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshotSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        public virtual IAsyncResult BeginCreateSnapshotSchedule(CreateSnapshotScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotScheduleResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        public virtual CreateSnapshotScheduleResponse EndCreateSnapshotSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTags

        /// <summary>
        /// Adds tags to a cluster.
        /// 
        ///  
        /// <para>
        /// A resource can have up to 50 tags. If you try to create more than 50 tags for a resource,
        /// you will receive an error and the attempt will fail.
        /// </para>
        ///  
        /// <para>
        /// If you specify a key that already exists for the resource, the value for that key
        /// will be updated with the new value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse EndCreateTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUsageLimit

        /// <summary>
        /// Creates a usage limit for a specified Amazon Redshift feature on a cluster. The usage
        /// limit is identified by the returned usage limit identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit service method.</param>
        /// 
        /// <returns>The response from the CreateUsageLimit service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidUsageLimitException">
        /// The usage limit is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UsageLimitAlreadyExistsException">
        /// The usage limit already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual CreateUsageLimitResponse CreateUsageLimit(CreateUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<CreateUsageLimitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual IAsyncResult BeginCreateUsageLimit(CreateUsageLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsageLimit.</param>
        /// 
        /// <returns>Returns a  CreateUsageLimitResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual CreateUsageLimitResponse EndCreateUsageLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUsageLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  DeauthorizeDataShare

        /// <summary>
        /// From a datashare producer account, removes authorization from the specified datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeauthorizeDataShare service method.</param>
        /// 
        /// <returns>The response from the DeauthorizeDataShare service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeauthorizeDataShare">REST API Reference for DeauthorizeDataShare Operation</seealso>
        public virtual DeauthorizeDataShareResponse DeauthorizeDataShare(DeauthorizeDataShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeauthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeauthorizeDataShareResponseUnmarshaller.Instance;

            return Invoke<DeauthorizeDataShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeauthorizeDataShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeauthorizeDataShare operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeauthorizeDataShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeauthorizeDataShare">REST API Reference for DeauthorizeDataShare Operation</seealso>
        public virtual IAsyncResult BeginDeauthorizeDataShare(DeauthorizeDataShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeauthorizeDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeauthorizeDataShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeauthorizeDataShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeauthorizeDataShare.</param>
        /// 
        /// <returns>Returns a  DeauthorizeDataShareResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeauthorizeDataShare">REST API Reference for DeauthorizeDataShare Operation</seealso>
        public virtual DeauthorizeDataShareResponse EndDeauthorizeDataShare(IAsyncResult asyncResult)
        {
            return EndInvoke<DeauthorizeDataShareResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAuthenticationProfile

        /// <summary>
        /// Deletes an authentication profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthenticationProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthenticationProfile service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileNotFoundException">
        /// The authentication profile can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteAuthenticationProfile">REST API Reference for DeleteAuthenticationProfile Operation</seealso>
        public virtual DeleteAuthenticationProfileResponse DeleteAuthenticationProfile(DeleteAuthenticationProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthenticationProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthenticationProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthenticationProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthenticationProfile operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuthenticationProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteAuthenticationProfile">REST API Reference for DeleteAuthenticationProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteAuthenticationProfile(DeleteAuthenticationProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthenticationProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthenticationProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthenticationProfile.</param>
        /// 
        /// <returns>Returns a  DeleteAuthenticationProfileResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteAuthenticationProfile">REST API Reference for DeleteAuthenticationProfile Operation</seealso>
        public virtual DeleteAuthenticationProfileResponse EndDeleteAuthenticationProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAuthenticationProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCluster

        /// <summary>
        /// Deletes a previously provisioned cluster without its final snapshot being created.
        /// A successful response from the web service indicates that the request was received
        /// correctly. Use <a>DescribeClusters</a> to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you want to shut down the cluster and retain it for future use, set <i>SkipFinalClusterSnapshot</i>
        /// to <code>false</code> and specify a name for <i>FinalClusterSnapshotIdentifier</i>.
        /// You can later restore this snapshot to resume using the cluster. If a final cluster
        /// snapshot is requested, the status of the cluster will be "final-snapshot" while the
        /// snapshot is being taken, then it's "deleting" once Amazon Redshift begins deleting
        /// the cluster. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClusterParameterGroup

        /// <summary>
        /// Deletes a specified Amazon Redshift parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a parameter group if it is associated with a cluster.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        public virtual DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterParameterGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        public virtual DeleteClusterParameterGroupResponse EndDeleteClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClusterSecurityGroup

        /// <summary>
        /// Deletes an Amazon Redshift security group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a security group that is associated with any clusters. You cannot
        /// delete the default security group.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        public virtual DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSecurityGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        public virtual DeleteClusterSecurityGroupResponse EndDeleteClusterSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClusterSnapshot

        /// <summary>
        /// Deletes the specified manual snapshot. The snapshot must be in the <code>available</code>
        /// state, with no other users authorized to access the snapshot. 
        /// 
        ///  
        /// <para>
        /// Unlike automated snapshots, manual snapshots are retained even after you delete your
        /// cluster. Amazon Redshift does not delete your manual snapshots. You must delete manual
        /// snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete
        /// the snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteClusterSnapshot(DeleteClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSnapshotResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual DeleteClusterSnapshotResponse EndDeleteClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClusterSubnetGroup

        /// <summary>
        /// Deletes the specified cluster subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetStateException">
        /// The state of the subnet is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        public virtual DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSubnetGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        public virtual DeleteClusterSubnetGroupResponse EndDeleteClusterSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpointAccess

        /// <summary>
        /// Deletes a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidEndpointStateException">
        /// The status of the endpoint is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual DeleteEndpointAccessResponse DeleteEndpointAccess(DeleteEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpointAccess(DeleteEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointAccess.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual DeleteEndpointAccessResponse EndDeleteEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSubscription

        /// <summary>
        /// Deletes an Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteEventSubscriptionResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHsmClientCertificate

        /// <summary>
        /// Deletes the specified HSM client certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmClientCertificateStateException">
        /// The specified HSM client certificate is not in the <code>available</code> state, or
        /// it is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        public virtual DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmClientCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsmClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        public virtual IAsyncResult BeginDeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmClientCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteHsmClientCertificateResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        public virtual DeleteHsmClientCertificateResponse EndDeleteHsmClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHsmClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHsmConfiguration

        /// <summary>
        /// Deletes the specified Amazon Redshift HSM configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmConfigurationStateException">
        /// The specified HSM configuration is not in the <code>available</code> state, or it
        /// is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        public virtual DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsmConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteHsmConfiguration(DeleteHsmConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteHsmConfigurationResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        public virtual DeleteHsmConfigurationResponse EndDeleteHsmConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHsmConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePartner

        /// <summary>
        /// Deletes a partner integration from a cluster. Data can still flow to the cluster until
        /// the integration is deleted at the partner's website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartner service method.</param>
        /// 
        /// <returns>The response from the DeletePartner service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.PartnerNotFoundException">
        /// The name of the partner was not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeletePartner">REST API Reference for DeletePartner Operation</seealso>
        public virtual DeletePartnerResponse DeletePartner(DeletePartnerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnerResponseUnmarshaller.Instance;

            return Invoke<DeletePartnerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartner operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartner operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePartner
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeletePartner">REST API Reference for DeletePartner Operation</seealso>
        public virtual IAsyncResult BeginDeletePartner(DeletePartnerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartnerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartner operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartner.</param>
        /// 
        /// <returns>Returns a  DeletePartnerResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeletePartner">REST API Reference for DeletePartner Operation</seealso>
        public virtual DeletePartnerResponse EndDeletePartner(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePartnerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteScheduledAction

        /// <summary>
        /// Deletes a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledActionResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSnapshotCopyGrant

        /// <summary>
        /// Deletes the specified snapshot copy grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSnapshotCopyGrantStateException">
        /// The snapshot copy grant can't be deleted because it is used by one or more clusters.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        public virtual DeleteSnapshotCopyGrantResponse DeleteSnapshotCopyGrant(DeleteSnapshotCopyGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotCopyGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshotCopyGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        public virtual IAsyncResult BeginDeleteSnapshotCopyGrant(DeleteSnapshotCopyGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshotCopyGrant.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotCopyGrantResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        public virtual DeleteSnapshotCopyGrantResponse EndDeleteSnapshotCopyGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSnapshotCopyGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSnapshotSchedule

        /// <summary>
        /// Deletes a snapshot schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        public virtual DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshotSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        public virtual IAsyncResult BeginDeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotScheduleResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        public virtual DeleteSnapshotScheduleResponse EndDeleteSnapshotSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSnapshotScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Deletes tags from a resource. You must provide the ARN of the resource from which
        /// you want to delete the tag or tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUsageLimit

        /// <summary>
        /// Deletes a usage limit from a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteUsageLimit service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UsageLimitNotFoundException">
        /// The usage limit identifier can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual DeleteUsageLimitResponse DeleteUsageLimit(DeleteUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteUsageLimitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual IAsyncResult BeginDeleteUsageLimit(DeleteUsageLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsageLimit.</param>
        /// 
        /// <returns>Returns a  DeleteUsageLimitResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual DeleteUsageLimitResponse EndDeleteUsageLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUsageLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Returns a list of attributes attached to an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAuthenticationProfiles

        /// <summary>
        /// Describes an authentication profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthenticationProfiles service method.</param>
        /// 
        /// <returns>The response from the DescribeAuthenticationProfiles service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileNotFoundException">
        /// The authentication profile can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAuthenticationProfiles">REST API Reference for DescribeAuthenticationProfiles Operation</seealso>
        public virtual DescribeAuthenticationProfilesResponse DescribeAuthenticationProfiles(DescribeAuthenticationProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthenticationProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthenticationProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeAuthenticationProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuthenticationProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthenticationProfiles operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuthenticationProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAuthenticationProfiles">REST API Reference for DescribeAuthenticationProfiles Operation</seealso>
        public virtual IAsyncResult BeginDescribeAuthenticationProfiles(DescribeAuthenticationProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuthenticationProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuthenticationProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuthenticationProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuthenticationProfiles.</param>
        /// 
        /// <returns>Returns a  DescribeAuthenticationProfilesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAuthenticationProfiles">REST API Reference for DescribeAuthenticationProfiles Operation</seealso>
        public virtual DescribeAuthenticationProfilesResponse EndDescribeAuthenticationProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAuthenticationProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterDbRevisions

        /// <summary>
        /// Returns an array of <code>ClusterDbRevision</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterDbRevisions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterDbRevisions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        public virtual DescribeClusterDbRevisionsResponse DescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterDbRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterDbRevisionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterDbRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterDbRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterDbRevisions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterDbRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterDbRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterDbRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterDbRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterDbRevisions.</param>
        /// 
        /// <returns>Returns a  DescribeClusterDbRevisionsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        public virtual DescribeClusterDbRevisionsResponse EndDescribeClusterDbRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterDbRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterParameterGroups

        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups()
        {
            return DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
        }

        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParameterGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterParameterGroupsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual DescribeClusterParameterGroupsResponse EndDescribeClusterParameterGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterParameterGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterParameters

        /// <summary>
        /// Returns a detailed list of parameters contained within the specified Amazon Redshift
        /// parameter group. For each parameter the response includes information such as parameter
        /// name, description, data type, value, whether the parameter value is modifiable, and
        /// so on.
        /// 
        ///  
        /// <para>
        /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
        /// For example, to retrieve parameters that were modified by a user action such as from
        /// <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i> equal to <i>user</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        public virtual DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterParameters(DescribeClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeClusterParametersResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        public virtual DescribeClusterParametersResponse EndDescribeClusterParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusters

        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual DescribeClustersResponse DescribeClusters()
        {
            return DescribeClusters(new DescribeClustersRequest());
        }

        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterSecurityGroups

        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups()
        {
            return DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
        }

        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSecurityGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSecurityGroupsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual DescribeClusterSecurityGroupsResponse EndDescribeClusterSecurityGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterSecurityGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterSnapshots

        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by your Amazon Web Services account. No information is returned for
        /// snapshots owned by inactive Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual DescribeClusterSnapshotsResponse DescribeClusterSnapshots()
        {
            return DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest());
        }

        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by your Amazon Web Services account. No information is returned for
        /// snapshots owned by inactive Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterSnapshots(DescribeClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSnapshotsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual DescribeClusterSnapshotsResponse EndDescribeClusterSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterSubnetGroups

        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups()
        {
            return DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest());
        }

        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSubnetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSubnetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSubnetGroupsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual DescribeClusterSubnetGroupsResponse EndDescribeClusterSubnetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterSubnetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterTracks

        /// <summary>
        /// Returns a list of all the available maintenance tracks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterTracks service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterTracks service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        public virtual DescribeClusterTracksResponse DescribeClusterTracks(DescribeClusterTracksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterTracksResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterTracksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterTracks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterTracks operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterTracks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterTracks(DescribeClusterTracksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterTracksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterTracks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterTracks.</param>
        /// 
        /// <returns>Returns a  DescribeClusterTracksResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        public virtual DescribeClusterTracksResponse EndDescribeClusterTracks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterTracksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClusterVersions

        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual DescribeClusterVersionsResponse DescribeClusterVersions()
        {
            return DescribeClusterVersions(new DescribeClusterVersionsRequest());
        }

        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeClusterVersions(DescribeClusterVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterVersions.</param>
        /// 
        /// <returns>Returns a  DescribeClusterVersionsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual DescribeClusterVersionsResponse EndDescribeClusterVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataShares

        /// <summary>
        /// Shows the status of any inbound or outbound datashares available in the specified
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataShares service method.</param>
        /// 
        /// <returns>The response from the DescribeDataShares service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataShares">REST API Reference for DescribeDataShares Operation</seealso>
        public virtual DescribeDataSharesResponse DescribeDataShares(DescribeDataSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSharesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataShares operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataShares
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataShares">REST API Reference for DescribeDataShares Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataShares(DescribeDataSharesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataShares.</param>
        /// 
        /// <returns>Returns a  DescribeDataSharesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataShares">REST API Reference for DescribeDataShares Operation</seealso>
        public virtual DescribeDataSharesResponse EndDescribeDataShares(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSharesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSharesForConsumer

        /// <summary>
        /// Returns a list of datashares where the account identifier being called is a consumer
        /// account identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSharesForConsumer service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSharesForConsumer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForConsumer">REST API Reference for DescribeDataSharesForConsumer Operation</seealso>
        public virtual DescribeDataSharesForConsumerResponse DescribeDataSharesForConsumer(DescribeDataSharesForConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForConsumerResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSharesForConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSharesForConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSharesForConsumer operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSharesForConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForConsumer">REST API Reference for DescribeDataSharesForConsumer Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSharesForConsumer(DescribeDataSharesForConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSharesForConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSharesForConsumer.</param>
        /// 
        /// <returns>Returns a  DescribeDataSharesForConsumerResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForConsumer">REST API Reference for DescribeDataSharesForConsumer Operation</seealso>
        public virtual DescribeDataSharesForConsumerResponse EndDescribeDataSharesForConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSharesForConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataSharesForProducer

        /// <summary>
        /// Returns a list of datashares when the account identifier being called is a producer
        /// account identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSharesForProducer service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSharesForProducer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForProducer">REST API Reference for DescribeDataSharesForProducer Operation</seealso>
        public virtual DescribeDataSharesForProducerResponse DescribeDataSharesForProducer(DescribeDataSharesForProducerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForProducerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForProducerResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSharesForProducerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSharesForProducer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSharesForProducer operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSharesForProducer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForProducer">REST API Reference for DescribeDataSharesForProducer Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataSharesForProducer(DescribeDataSharesForProducerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSharesForProducerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSharesForProducerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSharesForProducer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSharesForProducer.</param>
        /// 
        /// <returns>Returns a  DescribeDataSharesForProducerResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDataSharesForProducer">REST API Reference for DescribeDataSharesForProducer Operation</seealso>
        public virtual DescribeDataSharesForProducerResponse EndDescribeDataSharesForProducer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataSharesForProducerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDefaultClusterParameters

        /// <summary>
        /// Returns a list of parameter settings for the specified parameter group family.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        public virtual DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultClusterParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultClusterParametersResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        public virtual DescribeDefaultClusterParametersResponse EndDescribeDefaultClusterParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDefaultClusterParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpointAccess

        /// <summary>
        /// Describes a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAccess">REST API Reference for DescribeEndpointAccess Operation</seealso>
        public virtual DescribeEndpointAccessResponse DescribeEndpointAccess(DescribeEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAccess">REST API Reference for DescribeEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpointAccess(DescribeEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointAccess.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAccess">REST API Reference for DescribeEndpointAccess Operation</seealso>
        public virtual DescribeEndpointAccessResponse EndDescribeEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpointAuthorization

        /// <summary>
        /// Describes an endpoint authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointAuthorization service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointAuthorization service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAuthorization">REST API Reference for DescribeEndpointAuthorization Operation</seealso>
        public virtual DescribeEndpointAuthorizationResponse DescribeEndpointAuthorization(DescribeEndpointAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointAuthorization operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAuthorization">REST API Reference for DescribeEndpointAuthorization Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpointAuthorization(DescribeEndpointAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointAuthorization.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointAuthorizationResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEndpointAuthorization">REST API Reference for DescribeEndpointAuthorization Operation</seealso>
        public virtual DescribeEndpointAuthorizationResponse EndDescribeEndpointAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointAuthorizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }

        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a  DescribeEventCategoriesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventCategoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }

        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }

        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeEventSubscriptionsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHsmClientCertificates

        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates()
        {
            return DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest());
        }

        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmClientCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsmClientCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual IAsyncResult BeginDescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsmClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmClientCertificates.</param>
        /// 
        /// <returns>Returns a  DescribeHsmClientCertificatesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual DescribeHsmClientCertificatesResponse EndDescribeHsmClientCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHsmClientCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHsmConfigurations

        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual DescribeHsmConfigurationsResponse DescribeHsmConfigurations()
        {
            return DescribeHsmConfigurations(new DescribeHsmConfigurationsRequest());
        }

        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsmConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDescribeHsmConfigurations(DescribeHsmConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsmConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeHsmConfigurationsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual DescribeHsmConfigurationsResponse EndDescribeHsmConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHsmConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoggingStatus

        /// <summary>
        /// Describes whether information, such as queries and connection attempts, is being logged
        /// for the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        public virtual DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoggingStatus(DescribeLoggingStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingStatus.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingStatusResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        public virtual DescribeLoggingStatusResponse EndDescribeLoggingStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoggingStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNodeConfigurationOptions

        /// <summary>
        /// Returns properties of possible node configurations such as node type, number of nodes,
        /// and disk usage for the specified action type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeNodeConfigurationOptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeNodeConfigurationOptions">REST API Reference for DescribeNodeConfigurationOptions Operation</seealso>
        public virtual DescribeNodeConfigurationOptionsResponse DescribeNodeConfigurationOptions(DescribeNodeConfigurationOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeConfigurationOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNodeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeConfigurationOptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNodeConfigurationOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeNodeConfigurationOptions">REST API Reference for DescribeNodeConfigurationOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeNodeConfigurationOptions(DescribeNodeConfigurationOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeConfigurationOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNodeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNodeConfigurationOptions.</param>
        /// 
        /// <returns>Returns a  DescribeNodeConfigurationOptionsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeNodeConfigurationOptions">REST API Reference for DescribeNodeConfigurationOptions Operation</seealso>
        public virtual DescribeNodeConfigurationOptionsResponse EndDescribeNodeConfigurationOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNodeConfigurationOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrderableClusterOptions

        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific Amazon Web Services Region that you can specify, and the
        /// node types you can request. The node types differ by available storage, memory, CPU
        /// and price. With the cost involved you might want to obtain a list of cluster options
        /// in the specific region and specify values when creating a cluster. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions()
        {
            return DescribeOrderableClusterOptions(new DescribeOrderableClusterOptionsRequest());
        }

        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific Amazon Web Services Region that you can specify, and the
        /// node types you can request. The node types differ by available storage, memory, CPU
        /// and price. With the cost involved you might want to obtain a list of cluster options
        /// in the specific region and specify values when creating a cluster. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableClusterOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableClusterOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableClusterOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableClusterOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrderableClusterOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableClusterOptions.</param>
        /// 
        /// <returns>Returns a  DescribeOrderableClusterOptionsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual DescribeOrderableClusterOptionsResponse EndDescribeOrderableClusterOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrderableClusterOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePartners

        /// <summary>
        /// Returns information about the partner integrations defined for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePartners service method.</param>
        /// 
        /// <returns>The response from the DescribePartners service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribePartners">REST API Reference for DescribePartners Operation</seealso>
        public virtual DescribePartnersResponse DescribePartners(DescribePartnersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePartnersResponseUnmarshaller.Instance;

            return Invoke<DescribePartnersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePartners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePartners operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePartners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribePartners">REST API Reference for DescribePartners Operation</seealso>
        public virtual IAsyncResult BeginDescribePartners(DescribePartnersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePartnersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePartners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePartners.</param>
        /// 
        /// <returns>Returns a  DescribePartnersResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribePartners">REST API Reference for DescribePartners Operation</seealso>
        public virtual DescribePartnersResponse EndDescribePartners(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePartnersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedNodeExchangeStatus

        /// <summary>
        /// Returns exchange status details and associated metadata for a reserved-node exchange.
        /// Statuses include such values as in progress and requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeExchangeStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeExchangeStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeExchangeNotFoundException">
        /// The reserved-node exchange status wasn't found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeExchangeStatus">REST API Reference for DescribeReservedNodeExchangeStatus Operation</seealso>
        public virtual DescribeReservedNodeExchangeStatusResponse DescribeReservedNodeExchangeStatus(DescribeReservedNodeExchangeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeExchangeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodeExchangeStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeExchangeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeExchangeStatus operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodeExchangeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeExchangeStatus">REST API Reference for DescribeReservedNodeExchangeStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservedNodeExchangeStatus(DescribeReservedNodeExchangeStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeExchangeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeExchangeStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodeExchangeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodeExchangeStatus.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodeExchangeStatusResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeExchangeStatus">REST API Reference for DescribeReservedNodeExchangeStatus Operation</seealso>
        public virtual DescribeReservedNodeExchangeStatusResponse EndDescribeReservedNodeExchangeStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedNodeExchangeStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedNodeOfferings

        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings()
        {
            return DescribeReservedNodeOfferings(new DescribeReservedNodeOfferingsRequest());
        }

        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodeOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodeOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodeOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodeOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodeOfferingsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual DescribeReservedNodeOfferingsResponse EndDescribeReservedNodeOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedNodeOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedNodes

        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual DescribeReservedNodesResponse DescribeReservedNodes()
        {
            return DescribeReservedNodes(new DescribeReservedNodesRequest());
        }

        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservedNodes(DescribeReservedNodesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodes.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual DescribeReservedNodesResponse EndDescribeReservedNodes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedNodesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResize

        /// <summary>
        /// Returns information about the last resize operation for the specified cluster. If
        /// no resize operation has ever been initiated for the specified cluster, a <code>HTTP
        /// 404</code> error is returned. If a resize operation was initiated and completed, the
        /// status of the resize remains as <code>SUCCEEDED</code> until the next resize. 
        /// 
        ///  
        /// <para>
        /// A resize operation can be requested using <a>ModifyCluster</a> and specifying a different
        /// number or type of nodes for the cluster. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        public virtual DescribeResizeResponse DescribeResize(DescribeResizeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return Invoke<DescribeResizeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResize
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        public virtual IAsyncResult BeginDescribeResize(DescribeResizeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResize operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResize.</param>
        /// 
        /// <returns>Returns a  DescribeResizeResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        public virtual DescribeResizeResponse EndDescribeResize(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResizeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScheduledActions

        /// <summary>
        /// Describes properties of scheduled actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledActionsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScheduledActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSnapshotCopyGrants

        /// <summary>
        /// Returns a list of snapshot copy grants owned by the Amazon Web Services account in
        /// the destination region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotCopyGrants service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        public virtual DescribeSnapshotCopyGrantsResponse DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotCopyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotCopyGrantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotCopyGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshotCopyGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        public virtual IAsyncResult BeginDescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotCopyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshotCopyGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotCopyGrants.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotCopyGrantsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        public virtual DescribeSnapshotCopyGrantsResponse EndDescribeSnapshotCopyGrants(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSnapshotCopyGrantsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSnapshotSchedules

        /// <summary>
        /// Returns a list of snapshot schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedules service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedules service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        public virtual DescribeSnapshotSchedulesResponse DescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotSchedulesResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotSchedulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedules operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshotSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        public virtual IAsyncResult BeginDescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotSchedulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshotSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotSchedules.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotSchedulesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        public virtual DescribeSnapshotSchedulesResponse EndDescribeSnapshotSchedules(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSnapshotSchedulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStorage

        /// <summary>
        /// Returns account level backups storage size and provisional storage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorage service method.</param>
        /// 
        /// <returns>The response from the DescribeStorage service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        public virtual DescribeStorageResponse DescribeStorage(DescribeStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorage operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        public virtual IAsyncResult BeginDescribeStorage(DescribeStorageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStorage.</param>
        /// 
        /// <returns>Returns a  DescribeStorageResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        public virtual DescribeStorageResponse EndDescribeStorage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStorageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTableRestoreStatus

        /// <summary>
        /// Lists the status of one or more table restore requests made using the <a>RestoreTableFromClusterSnapshot</a>
        /// API action. If you don't specify a value for the <code>TableRestoreRequestId</code>
        /// parameter, then <code>DescribeTableRestoreStatus</code> returns the status of all
        /// table restore requests ordered by the date and time of the request in ascending order.
        /// Otherwise <code>DescribeTableRestoreStatus</code> returns the status of the table
        /// specified by <code>TableRestoreRequestId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeTableRestoreStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableRestoreNotFoundException">
        /// The specified <code>TableRestoreRequestId</code> value was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        public virtual DescribeTableRestoreStatusResponse DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeTableRestoreStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTableRestoreStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTableRestoreStatus.</param>
        /// 
        /// <returns>Returns a  DescribeTableRestoreStatusResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        public virtual DescribeTableRestoreStatusResponse EndDescribeTableRestoreStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTableRestoreStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Returns a list of tags. You can return tags from a specific resource by specifying
        /// an ARN, or you can return all tags for a given type of resource, such as clusters,
        /// snapshots, and so on.
        /// 
        ///  
        /// <para>
        /// The following are limitations for <code>DescribeTags</code>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot specify an ARN and a resource-type value together in the same request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use the <code>MaxRecords</code> and <code>Marker</code> parameters together
        /// with the ARN parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>MaxRecords</code> parameter can be a range from 10 to 50 results to return
        /// in a request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all resources that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all resources that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, resources are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUsageLimits

        /// <summary>
        /// Shows usage limits on a cluster. Results are filtered based on the combination of
        /// input usage limit identifier, cluster identifier, and feature type parameters:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If usage limit identifier, cluster identifier, and feature type are not provided,
        /// then all usage limit objects for the current account in the current region are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If usage limit identifier is provided, then the corresponding usage limit object is
        /// returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If cluster identifier is provided, then all usage limit objects for the specified
        /// cluster are returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If cluster identifier and feature type are provided, then all usage limit objects
        /// for the combination of cluster and feature are returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsageLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeUsageLimits service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeUsageLimits">REST API Reference for DescribeUsageLimits Operation</seealso>
        public virtual DescribeUsageLimitsResponse DescribeUsageLimits(DescribeUsageLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeUsageLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUsageLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsageLimits operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUsageLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeUsageLimits">REST API Reference for DescribeUsageLimits Operation</seealso>
        public virtual IAsyncResult BeginDescribeUsageLimits(DescribeUsageLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsageLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUsageLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUsageLimits.</param>
        /// 
        /// <returns>Returns a  DescribeUsageLimitsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeUsageLimits">REST API Reference for DescribeUsageLimits Operation</seealso>
        public virtual DescribeUsageLimitsResponse EndDescribeUsageLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUsageLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableLogging

        /// <summary>
        /// Stops logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        public virtual DisableLoggingResponse DisableLogging(DisableLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return Invoke<DisableLoggingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableLogging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        public virtual IAsyncResult BeginDisableLogging(DisableLoggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableLogging.</param>
        /// 
        /// <returns>Returns a  DisableLoggingResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        public virtual DisableLoggingResponse EndDisableLogging(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableLoggingResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableSnapshotCopy

        /// <summary>
        /// Disables the automatic copying of snapshots from one region to another region for
        /// a specified cluster.
        /// 
        ///  
        /// <para>
        /// If your cluster and its snapshots are encrypted using an encrypted symmetric key from
        /// Key Management Service, use <a>DeleteSnapshotCopyGrant</a> to delete the grant that
        /// grants Amazon Redshift permission to the key in the destination region. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyDisabledException">
        /// The cluster already has cross-region snapshot copy disabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        public virtual DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<DisableSnapshotCopyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSnapshotCopy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        public virtual IAsyncResult BeginDisableSnapshotCopy(DisableSnapshotCopyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a  DisableSnapshotCopyResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        public virtual DisableSnapshotCopyResponse EndDisableSnapshotCopy(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableSnapshotCopyResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDataShareConsumer

        /// <summary>
        /// From a datashare consumer account, remove association for the specified datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataShareConsumer service method.</param>
        /// 
        /// <returns>The response from the DisassociateDataShareConsumer service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidNamespaceException">
        /// The namespace isn't valid because the namespace doesn't exist. Provide a valid namespace.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisassociateDataShareConsumer">REST API Reference for DisassociateDataShareConsumer Operation</seealso>
        public virtual DisassociateDataShareConsumerResponse DisassociateDataShareConsumer(DisassociateDataShareConsumerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataShareConsumerResponseUnmarshaller.Instance;

            return Invoke<DisassociateDataShareConsumerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDataShareConsumer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataShareConsumer operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDataShareConsumer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisassociateDataShareConsumer">REST API Reference for DisassociateDataShareConsumer Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDataShareConsumer(DisassociateDataShareConsumerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDataShareConsumerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataShareConsumerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDataShareConsumer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDataShareConsumer.</param>
        /// 
        /// <returns>Returns a  DisassociateDataShareConsumerResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisassociateDataShareConsumer">REST API Reference for DisassociateDataShareConsumer Operation</seealso>
        public virtual DisassociateDataShareConsumerResponse EndDisassociateDataShareConsumer(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDataShareConsumerResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableLogging

        /// <summary>
        /// Starts logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BucketNotFoundException">
        /// Could not find the specified S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientS3BucketPolicyException">
        /// The cluster does not have read bucket or put object permissions on the S3 bucket specified
        /// when enabling logging.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3BucketNameException">
        /// The S3 bucket name is invalid. For more information about naming rules, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service (S3) Developer
        /// Guide.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3KeyPrefixException">
        /// The string specified for the logging S3 key prefix does not comply with the documented
        /// constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        public virtual EnableLoggingResponse EnableLogging(EnableLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return Invoke<EnableLoggingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableLogging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        public virtual IAsyncResult BeginEnableLogging(EnableLoggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableLogging.</param>
        /// 
        /// <returns>Returns a  EnableLoggingResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        public virtual EnableLoggingResponse EndEnableLogging(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableLoggingResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableSnapshotCopy

        /// <summary>
        /// Enables the automatic copy of snapshots from one region to another region for a specified
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CopyToRegionDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IncompatibleOrderableOptionsException">
        /// The specified options are incompatible.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyEnabledException">
        /// The cluster already has cross-region snapshot copy enabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnknownSnapshotCopyRegionException">
        /// The specified region is incorrect or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        public virtual EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<EnableSnapshotCopyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSnapshotCopy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        public virtual IAsyncResult BeginEnableSnapshotCopy(EnableSnapshotCopyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a  EnableSnapshotCopyResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        public virtual EnableSnapshotCopyResponse EndEnableSnapshotCopy(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableSnapshotCopyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClusterCredentials

        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log on to an Amazon Redshift database. The action returns the database user name prefixed
        /// with <code>IAM:</code> if <code>AutoCreate</code> is <code>False</code> or <code>IAMA:</code>
        /// if <code>AutoCreate</code> is <code>True</code>. You can optionally specify one or
        /// more database user groups that the user will join at log on. By default, the temporary
        /// credentials expire in 900 seconds. You can optionally specify a duration between 900
        /// seconds (15 minutes) and 3600 seconds (60 minutes). For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/generating-user-credentials.html">Using
        /// IAM Authentication to Generate Database User Credentials</a> in the Amazon Redshift
        /// Cluster Management Guide.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) user or role that runs GetClusterCredentials
        /// must have an IAM policy attached that allows access to all necessary actions and resources.
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html#redshift-policy-resources.getclustercredentials-resources">Resource
        /// Policies for GetClusterCredentials</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If the <code>DbGroups</code> parameter is specified, the IAM policy must allow the
        /// <code>redshift:JoinGroup</code> action with access to the listed <code>dbgroups</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In addition, if the <code>AutoCreate</code> parameter is set to <code>True</code>,
        /// then the policy must include the <code>redshift:CreateClusterUser</code> permission.
        /// </para>
        ///  
        /// <para>
        /// If the <code>DbName</code> parameter is specified, the IAM policy must allow access
        /// to the resource <code>dbname</code> for the specified database name. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentials service method.</param>
        /// 
        /// <returns>The response from the GetClusterCredentials service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        public virtual GetClusterCredentialsResponse GetClusterCredentials(GetClusterCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetClusterCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentials operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClusterCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        public virtual IAsyncResult BeginGetClusterCredentials(GetClusterCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClusterCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClusterCredentials.</param>
        /// 
        /// <returns>Returns a  GetClusterCredentialsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        public virtual GetClusterCredentialsResponse EndGetClusterCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClusterCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClusterCredentialsWithIAM

        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log in to an Amazon Redshift database. The database user is mapped 1:1 to the source
        /// Identity and Access Management (IAM) identity. For more information about IAM identities,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id.html">IAM Identities
        /// (users, user groups, and roles)</a> in the Amazon Web Services Identity and Access
        /// Management User Guide.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) identity that runs this operation must have
        /// an IAM policy attached that allows access to all necessary actions and resources.
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html">Using
        /// identity-based policies (IAM policies)</a> in the Amazon Redshift Cluster Management
        /// Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentialsWithIAM service method.</param>
        /// 
        /// <returns>The response from the GetClusterCredentialsWithIAM service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentialsWithIAM">REST API Reference for GetClusterCredentialsWithIAM Operation</seealso>
        public virtual GetClusterCredentialsWithIAMResponse GetClusterCredentialsWithIAM(GetClusterCredentialsWithIAMRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsWithIAMResponseUnmarshaller.Instance;

            return Invoke<GetClusterCredentialsWithIAMResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterCredentialsWithIAM operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentialsWithIAM operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClusterCredentialsWithIAM
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentialsWithIAM">REST API Reference for GetClusterCredentialsWithIAM Operation</seealso>
        public virtual IAsyncResult BeginGetClusterCredentialsWithIAM(GetClusterCredentialsWithIAMRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsWithIAMRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsWithIAMResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClusterCredentialsWithIAM operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClusterCredentialsWithIAM.</param>
        /// 
        /// <returns>Returns a  GetClusterCredentialsWithIAMResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentialsWithIAM">REST API Reference for GetClusterCredentialsWithIAM Operation</seealso>
        public virtual GetClusterCredentialsWithIAMResponse EndGetClusterCredentialsWithIAM(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClusterCredentialsWithIAMResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReservedNodeExchangeConfigurationOptions

        /// <summary>
        /// Gets the configuration options for the reserved-node exchange. These options include
        /// information about the source reserved node and target reserved node offering. Details
        /// include the node type, the price, the node count, and the offering type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the GetReservedNodeExchangeConfigurationOptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeConfigurationOptions">REST API Reference for GetReservedNodeExchangeConfigurationOptions Operation</seealso>
        public virtual GetReservedNodeExchangeConfigurationOptionsResponse GetReservedNodeExchangeConfigurationOptions(GetReservedNodeExchangeConfigurationOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<GetReservedNodeExchangeConfigurationOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedNodeExchangeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeConfigurationOptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReservedNodeExchangeConfigurationOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeConfigurationOptions">REST API Reference for GetReservedNodeExchangeConfigurationOptions Operation</seealso>
        public virtual IAsyncResult BeginGetReservedNodeExchangeConfigurationOptions(GetReservedNodeExchangeConfigurationOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeConfigurationOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReservedNodeExchangeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReservedNodeExchangeConfigurationOptions.</param>
        /// 
        /// <returns>Returns a  GetReservedNodeExchangeConfigurationOptionsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeConfigurationOptions">REST API Reference for GetReservedNodeExchangeConfigurationOptions Operation</seealso>
        public virtual GetReservedNodeExchangeConfigurationOptionsResponse EndGetReservedNodeExchangeConfigurationOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReservedNodeExchangeConfigurationOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReservedNodeExchangeOfferings

        /// <summary>
        /// Returns an array of DC2 ReservedNodeOfferings that matches the payment type, term,
        /// and usage price of the given DC1 reserved node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeOfferings service method.</param>
        /// 
        /// <returns>The response from the GetReservedNodeExchangeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        public virtual GetReservedNodeExchangeOfferingsResponse GetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance;

            return Invoke<GetReservedNodeExchangeOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedNodeExchangeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeOfferings operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReservedNodeExchangeOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        public virtual IAsyncResult BeginGetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReservedNodeExchangeOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReservedNodeExchangeOfferings.</param>
        /// 
        /// <returns>Returns a  GetReservedNodeExchangeOfferingsResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        public virtual GetReservedNodeExchangeOfferingsResponse EndGetReservedNodeExchangeOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReservedNodeExchangeOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyAquaConfiguration

        /// <summary>
        /// This operation is retired. Calling this operation does not change AQUA configuration.
        /// Amazon Redshift automatically determines whether to use AQUA (Advanced Query Accelerator).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAquaConfiguration service method.</param>
        /// 
        /// <returns>The response from the ModifyAquaConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAquaConfiguration">REST API Reference for ModifyAquaConfiguration Operation</seealso>
        public virtual ModifyAquaConfigurationResponse ModifyAquaConfiguration(ModifyAquaConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAquaConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAquaConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyAquaConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyAquaConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyAquaConfiguration operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyAquaConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAquaConfiguration">REST API Reference for ModifyAquaConfiguration Operation</seealso>
        public virtual IAsyncResult BeginModifyAquaConfiguration(ModifyAquaConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAquaConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAquaConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyAquaConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyAquaConfiguration.</param>
        /// 
        /// <returns>Returns a  ModifyAquaConfigurationResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAquaConfiguration">REST API Reference for ModifyAquaConfiguration Operation</seealso>
        public virtual ModifyAquaConfigurationResponse EndModifyAquaConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyAquaConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyAuthenticationProfile

        /// <summary>
        /// Modifies an authentication profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAuthenticationProfile service method.</param>
        /// 
        /// <returns>The response from the ModifyAuthenticationProfile service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileNotFoundException">
        /// The authentication profile can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthenticationProfileQuotaExceededException">
        /// The size or number of authentication profiles has exceeded the quota. The maximum
        /// length of the JSON string and maximum number of authentication profiles is determined
        /// by a quota for your account.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthenticationProfileRequestException">
        /// The authentication profile request is not valid. The profile name can't be null or
        /// empty. The authentication profile API operation must be available in the Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAuthenticationProfile">REST API Reference for ModifyAuthenticationProfile Operation</seealso>
        public virtual ModifyAuthenticationProfileResponse ModifyAuthenticationProfile(ModifyAuthenticationProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAuthenticationProfileResponseUnmarshaller.Instance;

            return Invoke<ModifyAuthenticationProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyAuthenticationProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyAuthenticationProfile operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyAuthenticationProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAuthenticationProfile">REST API Reference for ModifyAuthenticationProfile Operation</seealso>
        public virtual IAsyncResult BeginModifyAuthenticationProfile(ModifyAuthenticationProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAuthenticationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAuthenticationProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyAuthenticationProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyAuthenticationProfile.</param>
        /// 
        /// <returns>Returns a  ModifyAuthenticationProfileResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyAuthenticationProfile">REST API Reference for ModifyAuthenticationProfile Operation</seealso>
        public virtual ModifyAuthenticationProfileResponse EndModifyAuthenticationProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyAuthenticationProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyCluster

        /// <summary>
        /// Modifies the settings for a cluster.
        /// 
        ///  
        /// <para>
        /// You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type
        /// even if one of the parameters does not change.
        /// </para>
        ///  
        /// <para>
        /// You can add another security or parameter group, or change the admin user password.
        /// Resetting a cluster password or modifying the security groups associated with a cluster
        /// do not need a reboot. However, modifying a parameter group requires a reboot for parameters
        /// to take effect. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableLimitExceededException">
        /// The number of tables in the cluster exceeds the limit for the requested new cluster
        /// node type.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual IAsyncResult BeginModifyCluster(ModifyClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCluster.</param>
        /// 
        /// <returns>Returns a  ModifyClusterResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual ModifyClusterResponse EndModifyCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClusterDbRevision

        /// <summary>
        /// Modifies the database revision of a cluster. The database revision is a unique revision
        /// of the database running in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterDbRevision service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterDbRevision service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterOnLatestRevisionException">
        /// Cluster is already on the latest database revision.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        public virtual ModifyClusterDbRevisionResponse ModifyClusterDbRevision(ModifyClusterDbRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterDbRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterDbRevisionResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterDbRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterDbRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterDbRevision operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterDbRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        public virtual IAsyncResult BeginModifyClusterDbRevision(ModifyClusterDbRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterDbRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterDbRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterDbRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterDbRevision.</param>
        /// 
        /// <returns>Returns a  ModifyClusterDbRevisionResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        public virtual ModifyClusterDbRevisionResponse EndModifyClusterDbRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterDbRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClusterIamRoles

        /// <summary>
        /// Modifies the list of Identity and Access Management (IAM) roles that can be used by
        /// the cluster to access other Amazon Web Services services.
        /// 
        ///  
        /// <para>
        /// The maximum number of IAM roles that you can associate is subject to a quota. For
        /// more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Quotas
        /// and limits</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterIamRoles service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterIamRoles service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        public virtual ModifyClusterIamRolesResponse ModifyClusterIamRoles(ModifyClusterIamRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterIamRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterIamRolesResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterIamRolesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterIamRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterIamRoles operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterIamRoles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        public virtual IAsyncResult BeginModifyClusterIamRoles(ModifyClusterIamRolesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterIamRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterIamRolesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterIamRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterIamRoles.</param>
        /// 
        /// <returns>Returns a  ModifyClusterIamRolesResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        public virtual ModifyClusterIamRolesResponse EndModifyClusterIamRoles(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterIamRolesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClusterMaintenance

        /// <summary>
        /// Modifies the maintenance settings of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterMaintenance service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterMaintenance service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        public virtual ModifyClusterMaintenanceResponse ModifyClusterMaintenance(ModifyClusterMaintenanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterMaintenanceResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterMaintenanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterMaintenance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterMaintenance operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterMaintenance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        public virtual IAsyncResult BeginModifyClusterMaintenance(ModifyClusterMaintenanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterMaintenanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterMaintenance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterMaintenance.</param>
        /// 
        /// <returns>Returns a  ModifyClusterMaintenanceResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        public virtual ModifyClusterMaintenanceResponse EndModifyClusterMaintenance(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterMaintenanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClusterParameterGroup

        /// <summary>
        /// Modifies the parameters of a parameter group. For the parameters parameter, it can't
        /// contain ASCII characters.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        public virtual ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyClusterParameterGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        public virtual ModifyClusterParameterGroupResponse EndModifyClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClusterSnapshot

        /// <summary>
        /// Modifies the settings for a snapshot.
        /// 
        ///  
        /// <para>
        /// This exanmple modifies the manual retention period setting for a cluster snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        public virtual ModifyClusterSnapshotResponse ModifyClusterSnapshot(ModifyClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginModifyClusterSnapshot(ModifyClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  ModifyClusterSnapshotResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        public virtual ModifyClusterSnapshotResponse EndModifyClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClusterSnapshotSchedule

        /// <summary>
        /// Modifies a snapshot schedule for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        public virtual ModifyClusterSnapshotScheduleResponse ModifyClusterSnapshotSchedule(ModifyClusterSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSnapshotScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshotSchedule operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterSnapshotSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        public virtual IAsyncResult BeginModifyClusterSnapshotSchedule(ModifyClusterSnapshotScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterSnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  ModifyClusterSnapshotScheduleResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        public virtual ModifyClusterSnapshotScheduleResponse EndModifyClusterSnapshotSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterSnapshotScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClusterSubnetGroup

        /// <summary>
        /// Modifies a cluster subnet group to include the specified list of VPC subnets. The
        /// operation replaces the existing list of subnets with the new list of subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubnetAlreadyInUseException">
        /// A specified subnet is already in use by another cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        public virtual ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyClusterSubnetGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        public virtual ModifyClusterSubnetGroupResponse EndModifyClusterSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClusterSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEndpointAccess

        /// <summary>
        /// Modifies a Redshift-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the ModifyEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidEndpointStateException">
        /// The status of the endpoint is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEndpointAccess">REST API Reference for ModifyEndpointAccess Operation</seealso>
        public virtual ModifyEndpointAccessResponse ModifyEndpointAccess(ModifyEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<ModifyEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpointAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEndpointAccess">REST API Reference for ModifyEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginModifyEndpointAccess(ModifyEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEndpointAccess.</param>
        /// 
        /// <returns>Returns a  ModifyEndpointAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEndpointAccess">REST API Reference for ModifyEndpointAccess Operation</seealso>
        public virtual ModifyEndpointAccessResponse EndModifyEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEventSubscription

        /// <summary>
        /// Modifies an existing Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a  ModifyEventSubscriptionResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyScheduledAction

        /// <summary>
        /// Modifies a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyScheduledAction service method.</param>
        /// 
        /// <returns>The response from the ModifyScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyScheduledAction">REST API Reference for ModifyScheduledAction Operation</seealso>
        public virtual ModifyScheduledActionResponse ModifyScheduledAction(ModifyScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyScheduledActionResponseUnmarshaller.Instance;

            return Invoke<ModifyScheduledActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyScheduledAction operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyScheduledAction">REST API Reference for ModifyScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginModifyScheduledAction(ModifyScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyScheduledAction.</param>
        /// 
        /// <returns>Returns a  ModifyScheduledActionResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyScheduledAction">REST API Reference for ModifyScheduledAction Operation</seealso>
        public virtual ModifyScheduledActionResponse EndModifyScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod

        /// <summary>
        /// Modifies the number of days to retain snapshots in the destination Amazon Web Services
        /// Region after they are copied from the source Amazon Web Services Region. By default,
        /// this operation only changes the retention period of copied automated snapshots. The
        /// retention periods for both new and existing copied automated snapshots are updated
        /// with the new retention period. You can set the manual option to change only the retention
        /// periods of copied manual snapshots. If you set this option, only newly copied manual
        /// snapshots have the new retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        public virtual ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotCopyRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotCopyRetentionPeriodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySnapshotCopyRetentionPeriod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        public virtual IAsyncResult BeginModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotCopyRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySnapshotCopyRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotCopyRetentionPeriod.</param>
        /// 
        /// <returns>Returns a  ModifySnapshotCopyRetentionPeriodResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        public virtual ModifySnapshotCopyRetentionPeriodResponse EndModifySnapshotCopyRetentionPeriod(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySnapshotCopyRetentionPeriodResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySnapshotSchedule

        /// <summary>
        /// Modifies a snapshot schedule. Any schedule associated with a cluster is modified asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleUpdateInProgressException">
        /// The specified snapshot schedule is already being updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        public virtual ModifySnapshotScheduleResponse ModifySnapshotSchedule(ModifySnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotSchedule operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySnapshotSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        public virtual IAsyncResult BeginModifySnapshotSchedule(ModifySnapshotScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotSchedule.</param>
        /// 
        /// <returns>Returns a  ModifySnapshotScheduleResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        public virtual ModifySnapshotScheduleResponse EndModifySnapshotSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySnapshotScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyUsageLimit

        /// <summary>
        /// Modifies a usage limit in a cluster. You can't modify the feature type or period of
        /// a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyUsageLimit service method.</param>
        /// 
        /// <returns>The response from the ModifyUsageLimit service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidUsageLimitException">
        /// The usage limit is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UsageLimitNotFoundException">
        /// The usage limit identifier can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyUsageLimit">REST API Reference for ModifyUsageLimit Operation</seealso>
        public virtual ModifyUsageLimitResponse ModifyUsageLimit(ModifyUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUsageLimitResponseUnmarshaller.Instance;

            return Invoke<ModifyUsageLimitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyUsageLimit operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyUsageLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyUsageLimit">REST API Reference for ModifyUsageLimit Operation</seealso>
        public virtual IAsyncResult BeginModifyUsageLimit(ModifyUsageLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUsageLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyUsageLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyUsageLimit.</param>
        /// 
        /// <returns>Returns a  ModifyUsageLimitResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyUsageLimit">REST API Reference for ModifyUsageLimit Operation</seealso>
        public virtual ModifyUsageLimitResponse EndModifyUsageLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyUsageLimitResponse>(asyncResult);
        }

        #endregion
        
        #region  PauseCluster

        /// <summary>
        /// Pauses a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCluster service method.</param>
        /// 
        /// <returns>The response from the PauseCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PauseCluster">REST API Reference for PauseCluster Operation</seealso>
        public virtual PauseClusterResponse PauseCluster(PauseClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PauseClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseClusterResponseUnmarshaller.Instance;

            return Invoke<PauseClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PauseCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PauseCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPauseCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PauseCluster">REST API Reference for PauseCluster Operation</seealso>
        public virtual IAsyncResult BeginPauseCluster(PauseClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PauseClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PauseCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPauseCluster.</param>
        /// 
        /// <returns>Returns a  PauseClusterResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PauseCluster">REST API Reference for PauseCluster Operation</seealso>
        public virtual PauseClusterResponse EndPauseCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<PauseClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseReservedNodeOffering

        /// <summary>
        /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of
        /// reserved node offerings. You can purchase one or more of the offerings. You can call
        /// the <a>DescribeReservedNodeOfferings</a> API to obtain the available reserved node
        /// offerings. You can call this API by providing a specific reserved node offering and
        /// the number of nodes you want to reserve. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeQuotaExceededException">
        /// Request would exceed the user's compute node quota. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        public virtual PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedNodeOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedNodeOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        public virtual IAsyncResult BeginPurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedNodeOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedNodeOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedNodeOfferingResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        public virtual PurchaseReservedNodeOfferingResponse EndPurchaseReservedNodeOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseReservedNodeOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootCluster

        /// <summary>
        /// Reboots a cluster. This action is taken as soon as possible. It results in a momentary
        /// outage to the cluster, during which the cluster status is set to <code>rebooting</code>.
        /// A cluster event is created when the reboot is completed. Any pending cluster modifications
        /// (see <a>ModifyCluster</a>) are applied at this reboot. For more information about
        /// managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        public virtual RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return Invoke<RebootClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        public virtual IAsyncResult BeginRebootCluster(RebootClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCluster.</param>
        /// 
        /// <returns>Returns a  RebootClusterResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        public virtual RebootClusterResponse EndRebootCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectDataShare

        /// <summary>
        /// From a datashare consumer account, rejects the specified datashare.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDataShare service method.</param>
        /// 
        /// <returns>The response from the RejectDataShare service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidDataShareException">
        /// There is an error with the datashare.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RejectDataShare">REST API Reference for RejectDataShare Operation</seealso>
        public virtual RejectDataShareResponse RejectDataShare(RejectDataShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDataShareResponseUnmarshaller.Instance;

            return Invoke<RejectDataShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectDataShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectDataShare operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectDataShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RejectDataShare">REST API Reference for RejectDataShare Operation</seealso>
        public virtual IAsyncResult BeginRejectDataShare(RejectDataShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectDataShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDataShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectDataShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectDataShare.</param>
        /// 
        /// <returns>Returns a  RejectDataShareResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RejectDataShare">REST API Reference for RejectDataShare Operation</seealso>
        public virtual RejectDataShareResponse EndRejectDataShare(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectDataShareResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetClusterParameterGroup

        /// <summary>
        /// Sets one or more parameters of the specified parameter group to their default values
        /// and sets the source values of the parameters to "engine-default". To reset the entire
        /// parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes
        /// to take effect you must reboot any associated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        public virtual ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginResetClusterParameterGroup(ResetClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetClusterParameterGroupResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        public virtual ResetClusterParameterGroupResponse EndResetClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ResizeCluster

        /// <summary>
        /// Changes the size of the cluster. You can change the cluster's type, or change the
        /// number or type of nodes. The default behavior is to use the elastic resize method.
        /// With an elastic resize, your cluster is available for read and write operations more
        /// quickly than with the classic resize method. 
        /// 
        ///  
        /// <para>
        /// Elastic resize operations have the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can only resize clusters of the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// dc1.large (if your cluster is in a VPC)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// dc1.8xlarge (if your cluster is in a VPC)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// dc2.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// dc2.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ds2.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ds2.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.xlplus
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.16xlarge
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The type of nodes that you add must match the node type for the cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResizeCluster service method.</param>
        /// 
        /// <returns>The response from the ResizeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        public virtual ResizeClusterResponse ResizeCluster(ResizeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResizeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResizeClusterResponseUnmarshaller.Instance;

            return Invoke<ResizeClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResizeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResizeCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResizeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        public virtual IAsyncResult BeginResizeCluster(ResizeClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResizeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResizeClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResizeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResizeCluster.</param>
        /// 
        /// <returns>Returns a  ResizeClusterResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        public virtual ResizeClusterResponse EndResizeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ResizeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreFromClusterSnapshot

        /// <summary>
        /// Creates a new cluster from a snapshot. By default, Amazon Redshift creates the resulting
        /// cluster with the same configuration as the original cluster from which the snapshot
        /// was created, except that the new cluster is created with the default cluster security
        /// and parameter groups. After Amazon Redshift creates the cluster, you can use the <a>ModifyCluster</a>
        /// API to associate a different security group and different parameter group with the
        /// restored cluster. If you are using a DS node type, you can also choose to change to
        /// another DS node type of the same size during restore.
        /// 
        ///  
        /// <para>
        /// If you restore a cluster into a VPC, you must provide a cluster subnet group where
        /// you want the cluster restored.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRestoreException">
        /// The restore is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in Amazon Web Services KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        public virtual RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreFromClusterSnapshotResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        public virtual RestoreFromClusterSnapshotResponse EndRestoreFromClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreFromClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreTableFromClusterSnapshot

        /// <summary>
        /// Creates a new table from a table in an Amazon Redshift cluster snapshot. You must
        /// create the new table within the Amazon Redshift cluster that the snapshot was taken
        /// from.
        /// 
        ///  
        /// <para>
        /// You cannot use <code>RestoreTableFromClusterSnapshot</code> to restore a table with
        /// the same name as an existing table in an Amazon Redshift cluster. That is, you cannot
        /// overwrite an existing table in a cluster with a restored table. If you want to replace
        /// your original table with a new, restored table, then rename or drop your original
        /// table before you call <code>RestoreTableFromClusterSnapshot</code>. When you have
        /// renamed your original table, then you can pass the original name of the table as the
        /// <code>NewTableName</code> parameter value in the call to <code>RestoreTableFromClusterSnapshot</code>.
        /// This way, you can replace the original table with the table created from the snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can't use this operation to restore tables with <a href="https://docs.aws.amazon.com/redshift/latest/dg/t_Sorting_data.html#t_Sorting_data-interleaved">interleaved
        /// sort keys</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreTableFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InProgressTableRestoreQuotaExceededException">
        /// You have exceeded the allowed number of table restore requests. Wait for your current
        /// table restore requests to complete before making a new request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTableRestoreArgumentException">
        /// The value specified for the <code>sourceDatabaseName</code>, <code>sourceSchemaName</code>,
        /// or <code>sourceTableName</code> parameter, or a combination of these, doesn't exist
        /// in the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        public virtual RestoreTableFromClusterSnapshotResponse RestoreTableFromClusterSnapshot(RestoreTableFromClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTableFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreTableFromClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreTableFromClusterSnapshot(RestoreTableFromClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreTableFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreTableFromClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreTableFromClusterSnapshotResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        public virtual RestoreTableFromClusterSnapshotResponse EndRestoreTableFromClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreTableFromClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeCluster

        /// <summary>
        /// Resumes a paused cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCluster service method.</param>
        /// 
        /// <returns>The response from the ResumeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResumeCluster">REST API Reference for ResumeCluster Operation</seealso>
        public virtual ResumeClusterResponse ResumeCluster(ResumeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeClusterResponseUnmarshaller.Instance;

            return Invoke<ResumeClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResumeCluster">REST API Reference for ResumeCluster Operation</seealso>
        public virtual IAsyncResult BeginResumeCluster(ResumeClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeCluster.</param>
        /// 
        /// <returns>Returns a  ResumeClusterResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResumeCluster">REST API Reference for ResumeCluster Operation</seealso>
        public virtual ResumeClusterResponse EndResumeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress

        /// <summary>
        /// Revokes an ingress rule in an Amazon Redshift security group for a previously authorized
        /// IP range or Amazon EC2 security group. To add an ingress rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        public virtual RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeClusterSecurityGroupIngressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeClusterSecurityGroupIngress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        public virtual IAsyncResult BeginRevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeClusterSecurityGroupIngressResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        public virtual RevokeClusterSecurityGroupIngressResponse EndRevokeClusterSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeClusterSecurityGroupIngressResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeEndpointAccess

        /// <summary>
        /// Revokes access to a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeEndpointAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointAuthorizationNotFoundException">
        /// The authorization for this endpoint can't be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.EndpointNotFoundException">
        /// The endpoint name doesn't refer to an existing endpoint.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidAuthorizationStateException">
        /// The status of the authorization is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidEndpointStateException">
        /// The status of the endpoint is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeEndpointAccess">REST API Reference for RevokeEndpointAccess Operation</seealso>
        public virtual RevokeEndpointAccessResponse RevokeEndpointAccess(RevokeEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeEndpointAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeEndpointAccess">REST API Reference for RevokeEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginRevokeEndpointAccess(RevokeEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeEndpointAccess.</param>
        /// 
        /// <returns>Returns a  RevokeEndpointAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeEndpointAccess">REST API Reference for RevokeEndpointAccess Operation</seealso>
        public virtual RevokeEndpointAccessResponse EndRevokeEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeSnapshotAccess

        /// <summary>
        /// Removes the ability of the specified Amazon Web Services account to restore the specified
        /// snapshot. If the account is currently restoring the snapshot, the restore will run
        /// to completion.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        public virtual RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeSnapshotAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSnapshotAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        public virtual IAsyncResult BeginRevokeSnapshotAccess(RevokeSnapshotAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a  RevokeSnapshotAccessResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        public virtual RevokeSnapshotAccessResponse EndRevokeSnapshotAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeSnapshotAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  RotateEncryptionKey

        /// <summary>
        /// Rotates the encryption keys for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        public virtual RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<RotateEncryptionKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        public virtual IAsyncResult BeginRotateEncryptionKey(RotateEncryptionKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RotateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateEncryptionKey.</param>
        /// 
        /// <returns>Returns a  RotateEncryptionKeyResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        public virtual RotateEncryptionKeyResponse EndRotateEncryptionKey(IAsyncResult asyncResult)
        {
            return EndInvoke<RotateEncryptionKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePartnerStatus

        /// <summary>
        /// Updates the status of a partner integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePartnerStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.PartnerNotFoundException">
        /// The name of the partner was not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedPartnerIntegrationException">
        /// The partner integration is not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/UpdatePartnerStatus">REST API Reference for UpdatePartnerStatus Operation</seealso>
        public virtual UpdatePartnerStatusResponse UpdatePartnerStatus(UpdatePartnerStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePartnerStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartnerStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerStatus operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartnerStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/UpdatePartnerStatus">REST API Reference for UpdatePartnerStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdatePartnerStatus(UpdatePartnerStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartnerStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartnerStatus.</param>
        /// 
        /// <returns>Returns a  UpdatePartnerStatusResult from Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/UpdatePartnerStatus">REST API Reference for UpdatePartnerStatus Operation</seealso>
        public virtual UpdatePartnerStatusResponse EndUpdatePartnerStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePartnerStatusResponse>(asyncResult);
        }

        #endregion
        
    }
}